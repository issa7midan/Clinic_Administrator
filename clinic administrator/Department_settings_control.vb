Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Department_settings_control
    Private Sub Department_settings_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim conn As MySqlConnection

    Private Sub Add_Role_Click(sender As Object, e As EventArgs) Handles Add_Role.Click
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim Name = Dept_name.Text
            Dim ID = Dept_ID.Text
            Dim cmd = New MySqlCommand("INSERT INTO department (dept_name , STATUS) VALUES ('" & Name & "','1')", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Dim cmd2 = New MySqlCommand("select dept_ID from department where dept_name ='" & Dept_name.Text & "'", conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = cmd2.ExecuteReader
            rd.Read()
            MsgBox("Your new department ID is :" & rd("dept_id"))
            conn.Close()
            Dept_name.Text = ""
            Dept_ID.Text = ""
        Catch ex As Exception
            MsgBox("You have to enter Name and ID")

        End Try
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        Dept_name.Text = ""
        Dept_ID.Text = ""
    End Sub

    Private Sub Dept_ID_TextChanged(sender As Object, e As EventArgs) Handles Dept_ID.TextChanged
        Try


            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            If Global_ID.validation_allspecial(Dept_ID.Text) Then
                Dim cmd = New MySqlCommand("SELECT dept_ID ,dept_name , status FROM department where dept_ID ='" & Dept_ID.Text & "'", conn)
                Dim cmd2 = New MySqlCommand("SELECT dept_id FROM department ORDER BY dept_ID DESC LIMIT 1")
                Dim rd As MySqlDataReader

                conn.Open()
                rd = cmd.ExecuteReader
                Dim result2 = rd.Read()
                If result2 Then
                    If (rd("status") = 0) Then
                        Dept_name.Text = "Department is Deactivated"
                    Else

                        Dept_name.Text = rd("Dept_name")
                    End If

                Else
                    Dept_name.Text = "Department is free to use "

                End If
                conn.Close()

            Else
                MsgBox("you can't special charachter ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub disable_btn_Click(sender As Object, e As EventArgs) Handles disable_btn.Click
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim cmd = New MySqlCommand("Update department set status=0 where dept_ID ='" & Dept_ID.Text & "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Department was disabled successfully ")
            conn.Close()
            Dept_ID.Text = ""
            Dept_name.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim cmd = New MySqlCommand("Update department set status=1 where dept_ID ='" & Dept_ID.Text & "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Department was Activated successfully ")
            conn.Close()
            Dept_ID.Text = ""
            Dept_name.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
