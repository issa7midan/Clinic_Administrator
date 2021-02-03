Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class pat_reg_control
    Private Sub pat_reg_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim conn As MySqlConnection

    Private Sub Reg_Click(sender As Object, e As EventArgs) Handles Reg.Click
        Dim patient_name = pat_name.Text
        If Global_ID.validation_names(patient_name) Then
            Try

                Dim dater = Date_pick.Value
                dater = dater.Date
                conn = New MySqlConnection("server = localhost;user id=root;database=clinic")


                Dim patient_ID = pat_ID.Text
                Dim patient_phone = pat_phone.Text
                Dim cmd = New MySqlCommand("INSERT INTO patient (pat_name , pat_DOB , pat_phone) VALUES ('" & patient_name & "' , '" & dater & "' , '" & pat_phone.Text & "')", conn)
                Dim rd As MySqlDataReader
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                conn.Open()
                Dim cmd2 = New MySqlCommand("SELECT pat_ID from patient where pat_name ='" & patient_name & "'", conn)
                rd = cmd2.ExecuteReader
                rd.Read()
                pat_ID.Text = rd("pat_ID")
                conn.Close()
                MsgBox("registered patient successfully")
            Catch ex As Exception
                MsgBox("Something went wrong")
            End Try
        Else
            MsgBox("wrong name")
        End If

    End Sub

    Private Sub Date_pick_ValueChanged(sender As Object, e As EventArgs) Handles Date_pick.ValueChanged
        Dim MinDate As Date = Date.MinValue
        Dim MaxDate As Date = Date.MaxValue
        MaxDate = Date.Today

    End Sub

    Private Sub register_pat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        pat_ID.Text = ""
        pat_name.Text = ""
        pat_phone.Text = ""
    End Sub

End Class
