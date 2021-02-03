/*
SQLyog Professional v13.1.1 (64 bit)
MySQL - 5.7.31 : Database - clinic
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`clinic` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `clinic`;

/*Table structure for table `app_emp_pat_dept` */

DROP TABLE IF EXISTS `app_emp_pat_dept`;

CREATE TABLE `app_emp_pat_dept` (
  `Pat_ID` int(10) NOT NULL,
  `Emp_ID` int(10) NOT NULL,
  `Dept_ID` int(2) NOT NULL,
  `App_ID` int(10) NOT NULL,
  KEY `Pat_ID` (`Pat_ID`),
  KEY `Emp_ID` (`Emp_ID`),
  KEY `Dept_ID` (`Dept_ID`),
  KEY `App_ID` (`App_ID`),
  CONSTRAINT `app_emp_pat_dept_ibfk_1` FOREIGN KEY (`Pat_ID`) REFERENCES `patient` (`Pat_ID`),
  CONSTRAINT `app_emp_pat_dept_ibfk_2` FOREIGN KEY (`Emp_ID`) REFERENCES `employees` (`Emp_ID`),
  CONSTRAINT `app_emp_pat_dept_ibfk_3` FOREIGN KEY (`Dept_ID`) REFERENCES `department` (`Dept_ID`),
  CONSTRAINT `app_emp_pat_dept_ibfk_4` FOREIGN KEY (`App_ID`) REFERENCES `appointment` (`App_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `app_emp_pat_dept` */

/*Table structure for table `appointment` */

DROP TABLE IF EXISTS `appointment`;

CREATE TABLE `appointment` (
  `App_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Doctor_ID` int(10) DEFAULT NULL,
  `pat_ID` int(10) NOT NULL,
  `App_date` varchar(2000) DEFAULT NULL,
  `status` int(1) DEFAULT NULL,
  PRIMARY KEY (`App_ID`,`pat_ID`),
  KEY `Doctor_ID` (`Doctor_ID`),
  CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`Doctor_ID`) REFERENCES `employees` (`Emp_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

/*Data for the table `appointment` */

insert  into `appointment`(`App_ID`,`Doctor_ID`,`pat_ID`,`App_date`,`status`) values 
(13,7,3,'2020/11/14 13:00:00',1),
(14,7,3,'2020/11/10 14:00:00',0),
(15,7,3,'2020/11/1 13:00:00',0),
(16,5,3,'2020/11/11 13:00:00',0),
(17,7,2,'2020/11/12 01:00:00',0),
(18,7,1,'2020/11/15 12:00:00',1),
(19,7,7,'2020/11/17 14:30:00',1),
(20,4,8,'2020/11/17 15:30:00',1);

/*Table structure for table `department` */

DROP TABLE IF EXISTS `department`;

CREATE TABLE `department` (
  `Dept_ID` int(2) NOT NULL AUTO_INCREMENT,
  `Dept_name` varchar(60) NOT NULL,
  `Status` int(1) DEFAULT NULL,
  PRIMARY KEY (`Dept_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `department` */

insert  into `department`(`Dept_ID`,`Dept_name`,`Status`) values 
(1,'IT',1),
(2,'Services',1),
(3,'Emergency',1),
(4,'Clinic',1),
(5,'Clinic_2',0),
(6,'Dentest',1),
(7,'Clinic3',1),
(8,'clinic4',1);

/*Table structure for table `emp_pat_dept` */

DROP TABLE IF EXISTS `emp_pat_dept`;

CREATE TABLE `emp_pat_dept` (
  `Pat_ID` int(10) NOT NULL,
  `Emp_ID` int(10) NOT NULL,
  `Dept_ID` int(2) NOT NULL,
  KEY `Pat_ID` (`Pat_ID`),
  KEY `Emp_ID` (`Emp_ID`),
  KEY `Dept_ID` (`Dept_ID`),
  CONSTRAINT `emp_pat_dept_ibfk_1` FOREIGN KEY (`Pat_ID`) REFERENCES `patient` (`Pat_ID`),
  CONSTRAINT `emp_pat_dept_ibfk_2` FOREIGN KEY (`Emp_ID`) REFERENCES `employees` (`Emp_ID`),
  CONSTRAINT `emp_pat_dept_ibfk_3` FOREIGN KEY (`Dept_ID`) REFERENCES `department` (`Dept_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `emp_pat_dept` */

/*Table structure for table `employees` */

DROP TABLE IF EXISTS `employees`;

CREATE TABLE `employees` (
  `Emp_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Role_ID` int(2) NOT NULL,
  `Dept_ID` int(2) NOT NULL,
  `Emp_name` varchar(60) NOT NULL,
  `Emp_email` varchar(60) DEFAULT NULL,
  `Emp_pass` varchar(60) NOT NULL,
  `status` int(1) DEFAULT NULL,
  PRIMARY KEY (`Emp_ID`),
  KEY `Role_ID` (`Role_ID`),
  KEY `Dept_ID` (`Dept_ID`),
  CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`Role_ID`) REFERENCES `role` (`Role_ID`),
  CONSTRAINT `employees_ibfk_2` FOREIGN KEY (`Dept_ID`) REFERENCES `department` (`Dept_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

/*Data for the table `employees` */

insert  into `employees`(`Emp_ID`,`Role_ID`,`Dept_ID`,`Emp_name`,`Emp_email`,`Emp_pass`,`status`) values 
(1,1,1,'Issa Hmidan','issa@hotmail.com','issa079',1),
(2,2,4,'Ahmad Emad','ahmad@hotmail.com','ahmad079',1),
(3,4,2,'Zuhair Salah','zuzu@hotmail.com','1234',1),
(4,2,4,'Yousef Hmidan','ok@hotmail.com','079',1),
(5,2,4,'Ahmad ELAHMAD','okk@hotmail.com','0796',1),
(6,3,2,'Holy Molly','hh@hotmail.com','079',1),
(7,2,4,'Yousef Ismail','yousef@hotmail.com','yousef079',1),
(8,3,2,'Ismail Yousef','ismail@hotmail.com','ismail079',1),
(9,3,2,'weq','qwe','qweq',0),
(10,3,2,'Ahmad Ahmad','AhmadAhmad@hotmail.com','07911111',1),
(11,1,1,'Ahmad Emad','ahmad.emad@hotmail.com','07955',0),
(12,4,2,'zuhair ali','zuhair_ali@hotmail.com','123456',1),
(13,4,2,'Mohammad hasan','ali.zuhair@gmail.com','079514',1),
(14,2,2,'Khaldon Ahmad','khkh@hotmail.com','0795',1);

/*Table structure for table `pat_doc_rep` */

DROP TABLE IF EXISTS `pat_doc_rep`;

CREATE TABLE `pat_doc_rep` (
  `Pat_ID` int(10) NOT NULL,
  `Doctor_ID` int(10) NOT NULL,
  `Report` longtext CHARACTER SET utf8,
  `Date` varchar(40) CHARACTER SET latin1 DEFAULT NULL,
  KEY `Pat_ID` (`Pat_ID`),
  KEY `Doctor_ID` (`Doctor_ID`),
  CONSTRAINT `pat_doc_rep_ibfk_1` FOREIGN KEY (`Pat_ID`) REFERENCES `patient` (`Pat_ID`),
  CONSTRAINT `pat_doc_rep_ibfk_2` FOREIGN KEY (`Doctor_ID`) REFERENCES `employees` (`Emp_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

/*Data for the table `pat_doc_rep` */

insert  into `pat_doc_rep`(`Pat_ID`,`Doctor_ID`,`Report`,`Date`) values 
(3,7,'panadpole extra ','11/11/2020 11:05:17'),
(3,7,'panadpole extra ','11/11/2020 23:21:04'),
(8,2,'panadole\r\nqwewlqw \r\nasdlas\r\n','13/11/2020 00:40:08'),
(8,2,'panadole\r\nqwewlqw \r\nasdlas\r\n','13/11/2020 00:40:52');

/*Table structure for table `patient` */

DROP TABLE IF EXISTS `patient`;

CREATE TABLE `patient` (
  `Pat_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Pat_name` varchar(60) NOT NULL,
  `Pat_DOB` varchar(60) DEFAULT NULL,
  `Pat_phone` int(13) DEFAULT NULL,
  PRIMARY KEY (`Pat_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `patient` */

insert  into `patient`(`Pat_ID`,`Pat_name`,`Pat_DOB`,`Pat_phone`) values 
(1,'Ahmad Issa','17/11/2020',7951),
(2,'Salah Ahmad','11/11/2020',5121412),
(3,'Hammad Hammad','11/11/2020',12536),
(4,'Mohammad Ali','10/11/1998',79555414),
(5,'Khaled Ahmad','10/11/1991',78945),
(6,'Hassan Emad','10/11/1997',791111111),
(7,'Hassan Ali','10/11/1997',79525252),
(8,'Ali Hassan','10/11/2009',7955555),
(9,'Ahmad Issa','13/05/1998',84765454);

/*Table structure for table `pay_emp_pat` */

DROP TABLE IF EXISTS `pay_emp_pat`;

CREATE TABLE `pay_emp_pat` (
  `Payment_ID` int(10) NOT NULL,
  `Patient_ID` int(10) NOT NULL,
  `Emp_ID` int(10) NOT NULL,
  KEY `Payment_ID` (`Payment_ID`),
  KEY `Patient_ID` (`Patient_ID`),
  KEY `Emp_ID` (`Emp_ID`),
  CONSTRAINT `pay_emp_pat_ibfk_1` FOREIGN KEY (`Payment_ID`) REFERENCES `payment` (`Payment_ID`),
  CONSTRAINT `pay_emp_pat_ibfk_2` FOREIGN KEY (`Patient_ID`) REFERENCES `patient` (`Pat_ID`),
  CONSTRAINT `pay_emp_pat_ibfk_3` FOREIGN KEY (`Emp_ID`) REFERENCES `employees` (`Emp_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `pay_emp_pat` */

/*Table structure for table `payment` */

DROP TABLE IF EXISTS `payment`;

CREATE TABLE `payment` (
  `Payment_ID` int(10) NOT NULL AUTO_INCREMENT,
  `Amount` int(10) NOT NULL,
  `emp_ID` int(10) NOT NULL,
  `pat_ID` int(10) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`Payment_ID`),
  KEY `emp_ID` (`emp_ID`),
  KEY `pat_ID` (`pat_ID`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`emp_ID`) REFERENCES `employees` (`Emp_ID`),
  CONSTRAINT `payment_ibfk_2` FOREIGN KEY (`pat_ID`) REFERENCES `patient` (`Pat_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `payment` */

insert  into `payment`(`Payment_ID`,`Amount`,`emp_ID`,`pat_ID`,`date`) values 
(7,17,6,1,'2020-11-12'),
(8,41,6,1,'2020-10-15'),
(9,28,6,1,'2020-09-14'),
(10,47,6,8,'2020-11-13');

/*Table structure for table `role` */

DROP TABLE IF EXISTS `role`;

CREATE TABLE `role` (
  `Role_ID` int(2) NOT NULL AUTO_INCREMENT,
  `Role_name` varchar(60) NOT NULL,
  PRIMARY KEY (`Role_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `role` */

insert  into `role`(`Role_ID`,`Role_name`) values 
(1,'admin'),
(2,'Doctor'),
(3,'Nurse'),
(4,'cleaners'),
(5,'Consultant');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
