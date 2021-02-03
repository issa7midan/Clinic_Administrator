Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Register_control



    Dim conn As MySqlConnection

    Private Sub reged_btn_Click(sender As Object, e As EventArgs) Handles reged_btn.Click
        Dim Emp_email = txt_emp_mail.Text
        Dim Emp_name = txt_empName.Text
        If Global_ID.validation_Email(Emp_email) And Global_ID.validation_names(Emp_name) Then
            Try
                ' Dim Emp_email = txt_emp_mail.Text
                Dim Emp_Password = txt_pass.Text
                Dim role = listRole.selectedValue
                Dim dept = listDept.selectedValue
                conn.Open()
                Dim cmd = New MySqlCommand("insert into employees (Role_ID ,Dept_ID ,Emp_name ,Emp_email,Emp_pass ,status ) values
                                        ((SELECT role_ID FROM role WHERE role_name ='" & role & "'),
                                        (SELECT Dept_ID FROM department WHERE dept_name ='" & dept & "'),
                                        '" & Emp_name & "', '" & Emp_email & "', '" & Emp_Password & "',1)", conn)
                cmd.ExecuteNonQuery()
                conn.Close()
                Dim cmd2 = New MySqlCommand("Select emp_ID from employees where emp_name='" & Emp_name & "'", conn)
                Dim rd As MySqlDataReader
                conn.Open()

                rd = cmd2.ExecuteReader
                rd.Read()
                Dim x = rd("Emp_ID")
                MsgBox("registered the employee successfully Employee ID is:" & x)
                conn.Close()

                txt_empName.Text = ""
                txt_emp_mail.Text = ""
                txt_pass.Text = ""
                listRole.Clear()
                listDept.Clear()
                Role_dept()

            Catch ex As Exception
                MsgBox("You have to fill all the fields.")

            End Try
        Else
            MsgBox("something went wrong ")
        End If

    End Sub
    Function Role_dept()
        Try
            Dim cmd = New MySqlCommand("select Dept_name from department where status = 1 ", conn)
            Dim cmd2 = New MySqlCommand("select Role_name from Role ", conn)


            conn.Open()
            Dim rd As MySqlDataReader
            rd = cmd.ExecuteReader

            While rd.HasRows
                Dim result = rd.Read
                If result Then
                    listDept.AddItem(rd("Dept_name"))
                Else
                    Exit While
                End If
            End While

            conn.Close()
            conn.Open()
            rd = cmd2.ExecuteReader

            While rd.HasRows
                Dim result = rd.Read
                If result Then
                    listRole.AddItem(rd("Role_name"))
                Else
                    Exit While
                End If
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Function

    Private Sub Register_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Role_dept()
    End Sub
End Class
