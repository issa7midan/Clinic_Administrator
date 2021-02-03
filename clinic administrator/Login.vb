Imports MySql.Data
Imports MySql.Data.MySqlClient


Public Class frm_login
    Dim conn As MySqlConnection


    Private Sub logon_btn_Click(sender As Object, e As EventArgs)
        conn = New MySqlConnection("server = 192.168.1.3;user id=issa;database=clinic")
        login()

    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles txt_Pass.OnValueChanged


        txt_Pass.isPassword = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New MySqlConnection("server = 192.168.1.3;user id=issa;database=clinic")

    End Sub

    Private Sub txt_Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                login()

                'Dim email = txt_Email.Text
                'Dim Password = txt_Pass.Text
                'Dim cmd = New MySqlCommand("select * from employees where Emp_email='" & email & "' and Emp_pass='" & Password & "'", conn)
                'Dim rd As MySqlDataReader

                'conn.Open()
                'rd = cmd.ExecuteReader
                'Dim result = rd.Read()
                'If result Then
                '    ADMIN.Show()
                '    Me.Hide()
                'Else
                '    MsgBox("login failed")

                'End If
                conn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
    Sub login()
        If Global_ID.validation_Email(txt_Email.Text) Then
            Try
                Dim email = txt_Email.Text

                conn = New MySqlConnection("server = 192.168.1.3;user id=issa;database=clinic")

                Dim Password = txt_Pass.Text
                Dim cmd = New MySqlCommand("select * from employees where Emp_email='" & email & "'   
                                             and Emp_pass='" & Password & "' 
                                             and status =1", conn)
                Dim rd As MySqlDataReader
                For i = 0 To email.Length - 1
                    If email(i) = "'" Then
                        MsgBox("SQL INJECTION ALLERT!")
                        Exit Sub
                    End If
                Next
                For i = 0 To Password.Length - 1
                    If (Password(i) = "'") Then
                        MsgBox("SQL INJECTION ALLERT!")
                        Exit Sub
                    End If
                Next
                conn.Open()
                rd = cmd.ExecuteReader
                rd.Read()
                Global_ID.userID = rd("Emp_ID")
                Dim result = rd("Role_ID")
                If rd("Role_ID") = "1" Then
                    Me.Hide()
                    frm_new_admin.Show()
                ElseIf rd("Role_ID") = "2" Then
                    Me.Hide()
                    frm_doctor_new.Show()

                ElseIf rd("Role_ID") = "3" Then
                    Me.Hide()
                    frm_nurse_new.Show()
                Else
                    MsgBox("Wrong Email")

                End If
                conn.Close()
                txt_Email.Text = ""
                txt_Pass.Text = ""
            Catch ex As Exception
                MsgBox("Wrong password Or Email ")


            End Try
        Else
            MsgBox("NO SQL INJECTION :D ")
        End If

    End Sub


    Private Sub logon_btn_Click_1(sender As Object, e As EventArgs) Handles logon_btn.Click
        login()



        txt_Email.Text = ""
        txt_Pass.Text = ""
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Dim url As String = "https://www.facebook.com/eyad.clinic"

        Process.Start(url)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs)
        Dim url As String = "https://www.facebook.com/eyad.clinic"

        Process.Start(url)
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim url As String = "https://www.google.com/maps/dir/32.0420292,35.8389018/31.8876517,35.8549869/@31.8883143,35.8560111,18.63z/data=!4m4!4m3!1m1!4e1!1m0"

        Process.Start(url)
    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.Click
        Dim url As String = "https://www.google.com/maps/dir/32.0420292,35.8389018/31.8876517,35.8549869/@31.8883143,35.8560111,18.63z/data=!4m4!4m3!1m1!4e1!1m0"

        Process.Start(url)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

End Class
