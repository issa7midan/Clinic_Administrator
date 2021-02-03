Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class update_emp_control

    Private Sub update_emp_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        error_1()

    End Sub

    Dim conn As MySqlConnection

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        If Global_ID.validation_names(updated_name.Text) Then
            Try
                Dim ID = emp_ID.Text
                Dim emp_name = updated_name.Text
                Dim emp_email = updated_mail.Text
                Dim emp_pass = updated_pass.Text
                Dim cmd = New MySqlCommand("update employees set emp_name ='" & emp_name & "' where emp_ID ='" & ID & "'", conn)
                Dim cmd2 = New MySqlCommand("update employees set emp_email='" & emp_email & "' where emp_ID='" & ID & "'", conn)
                Dim cmd3 = New MySqlCommand("update employees set emp_pass='" & emp_pass & "'where emp_ID ='" & ID & "'", conn)
                Dim cmd4 = New MySqlCommand("update employees set dept_ID=(select dept_id from department WHERE dept_name='" & updated_dept.selectedValue.Trim & "') where Emp_ID='" & ID & "'", conn)


                If emp_name.Length > 1 Then
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                Else

                End If


                If emp_email.Length > 5 Then
                    conn.Open()
                    cmd2.ExecuteNonQuery()
                    conn.Close()
                Else

                End If


                If emp_pass.Length > 1 Then
                    conn.Open()
                    cmd3.ExecuteNonQuery()
                    conn.Close()
                Else

                End If



                If updated_dept.selectedIndex >= 0 And updated_dept.selectedIndex < 20 Then
                    conn.Open()
                    cmd4.ExecuteNonQuery()
                    conn.Close()
                Else

                End If

                selected()


                MsgBox("Updated The Employee info")


                error_1()
                emp_ID.Text = ""
                emp_nam.Text = ""
                Emp_mail.Text = ""
                Dept_txt.Text = ""
                Role_txt.Text = ""
                updated_mail.Text = ""
                updated_pass.Text = ""
                updated_name.Text = ""
                updated_Role.Clear()
                updated_dept.Clear()
                error_1()

            Catch ex As Exception


            End Try
        Else
            MsgBox("You cant use special charachter ")
        End If
    End Sub



    Private Sub wipe_Click(sender As Object, e As EventArgs) Handles wipe.Click
        emp_ID.Text = ""
        emp_nam.Text = ""
        Emp_mail.Text = ""
        Emp_pass.Text = ""
        Dept_txt.Text = ""
        Role_txt.Text = ""
        updated_mail.Text = ""
        updated_pass.Text = ""
        updated_name.Text = ""
        updated_Role.Clear()
        updated_dept.Clear()
        error_1()

    End Sub

    Private Sub emp_ID_TextChanged(sender As Object, e As EventArgs) Handles emp_ID.TextChanged
        updt_emp()
        If emp_ID.Text = "" Then
            emp_nam.Text = ""
            Emp_mail.Text = ""
            Emp_pass.Text = ""
            Dept_txt.Text = ""
            Role_txt.Text = ""
            updated_dept.Clear()
            updated_Role.Clear()
            error_1()

        End If
    End Sub

    Function error_1()
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")

        Dim cmd = New MySqlCommand("select Dept_name from department where status = 1 ", conn)
        Dim cmd2 = New MySqlCommand("select Role_name from Role ", conn)


        conn.Open()
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader

        While rd.HasRows
            Dim result = rd.Read
            If result Then
                updated_dept.AddItem(rd("Dept_name"))
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
                updated_Role.AddItem(rd("Role_name"))
            Else
                Exit While
            End If
        End While

        conn.Close()


    End Function
    Function selected()

        Dim cmd5 = New MySqlCommand("update employees set Role_ID=(Select role_id from Role where role_name='" & updated_Role.selectedValue.Trim & "') where Emp_ID='" & emp_ID.Text & "'", conn)

        If updated_Role.selectedIndex >= 0 And updated_Role.selectedIndex < 20 Then

            conn.Open()
            cmd5.ExecuteNonQuery()
            conn.Close()
        Else

        End If
    End Function
    Function updt_emp()


        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        If Global_ID.validation_allspecial(emp_ID.Text) Then
                Dim cmd = New MySqlCommand("SELECT * FROM employees where emp_id='" & emp_ID.Text & "'", conn)
                Dim rd As MySqlDataReader
                conn.Open()
                rd = cmd.ExecuteReader
                Dim result2 = rd.Read()
                If result2 Then
                    If (rd("status") = 0) Then
                        emp_nam.Text = "Employee is disabled"
                        Emp_mail.Text = ""
                        Emp_pass.Text = ""
                        Dept_txt.Text = ""
                        Role_txt.Text = ""
                        updated_dept.Clear()
                        updated_Role.Clear()
                        error_1()

                    ElseIf emp_ID.Text = "" Then
                        emp_nam.Text = ""
                        Emp_mail.Text = ""
                        Emp_pass.Text = ""
                        Dept_txt.Text = ""
                        Role_txt.Text = ""
                        updated_dept.Clear()
                        updated_Role.Clear()
                        error_1()


                    ElseIf result2 Then
                        conn.Close()
                        Dim cmd2 = New MySqlCommand("select * from employees NATURAL JOIN ROLE NATURAL JOIN DEPARTMENT where emp_ID='" & emp_ID.Text & "'", conn)
                        conn.Open()
                        rd = cmd2.ExecuteReader
                        rd.Read()
                        emp_nam.Text = rd("Emp_name")
                        Emp_mail.Text = rd("Emp_email")
                        Dept_txt.Text = rd("Dept_name")
                        Emp_pass.Text = rd("Emp_pass")
                        Role_txt.Text = rd("Role_name")
                    updated_dept.selectedIndex = rd("dept_id") - 1
                    updated_Role.selectedIndex = rd("Role_ID") - 1

                Else
                    End If
                    conn.Close()
                ElseIf emp_ID.Text = "" Then
                    emp_nam.Text = ""
                    Emp_mail.Text = ""
                    Emp_pass.Text = ""
                    Dept_txt.Text = ""
                    Role_txt.Text = ""
                    updated_dept.Clear()
                    updated_Role.Clear()
                    error_1()
                Else

                    MsgBox("Emp doesn't exist")
                    emp_nam.Text = ""
                    Emp_mail.Text = ""
                    Emp_pass.Text = ""
                    Dept_txt.Text = ""
                    Role_txt.Text = ""
                    updated_dept.Clear()
                    updated_Role.Clear()
                    error_1()
                End If
            Else
                MsgBox("you can't special charachter ")
            End If

    End Function

    Private Sub updated_dept_onItemSelected(sender As Object, e As EventArgs) Handles updated_dept.onItemSelected

    End Sub

    Private Sub updated_Role_onItemSelected(sender As Object, e As EventArgs) Handles updated_Role.onItemSelected

    End Sub

    Private Sub updated_pass_TextChanged(sender As Object, e As EventArgs) Handles updated_pass.TextChanged

    End Sub
End Class
