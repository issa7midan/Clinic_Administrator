Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class add_roles_control
    Private Sub add_roles_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim conn As MySqlConnection
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
            Role_ID.Text = ""
            Role_name.Text = ""
        End Sub

        Private Sub Checker_Click(sender As Object, e As EventArgs)
            Try
                Dim ID = Role_ID.Text
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim cmd = New MySqlCommand("select Role_name from Role where role_ID='" & ID & "'", conn)
                Dim rd As MySqlDataReader
                conn.Open()
                rd = cmd.ExecuteReader
                rd.Read()
                Role_name.Text = rd("Role_name")
                conn.Close()
                Role_ID.Text = ""
                Role_name.Text = ""
            Catch ex As Exception
                MsgBox("Enter ID!!!")
            End Try
        End Sub


    Private Sub Add_Role_Click(sender As Object, e As EventArgs) Handles Add_Role.Click
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim Name = Role_name.Text
            Dim ID = Role_ID.Text
            Dim cmd = New MySqlCommand("INSERT INTO Role (Role_name) VALUES ('" & Name & "')", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Dim cmd2 = New MySqlCommand("Select Role_ID from Role where Role_name='" & Name & "'", conn)
            conn.Open()
            Dim rd As MySqlDataReader
            rd = cmd2.ExecuteReader
            rd.Read()
            MsgBox("Your new Role ID is : " & rd("Role_ID"))
            conn.Close()
            Role_name.Text = ""
            Role_ID.Text = ""
        Catch ex As Exception
            MsgBox("You have to enter Name and ID")

        End Try
    End Sub

    Private Sub Role_ID_TextChanged(sender As Object, e As EventArgs) Handles Role_ID.TextChanged
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            If Global_ID.validation_allspecial(Role_ID.Text) Then
                    Dim cmd = New MySqlCommand("SELECT Role_id , Role_name FROM Role where Role_ID='" & Role_ID.Text & "'", conn)
                    Dim rd As MySqlDataReader

                    conn.Open()
                    rd = cmd.ExecuteReader
                    Dim result2 = rd.Read()
                    If result2 Then
                        Role_name.Text = rd("Role_name")
                    Else
                        Role_name.Text = "Role is free to fill "

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

        Private Sub frm_add_role_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

