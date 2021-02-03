Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Emp_settings_control
    Private Sub Emp_settings_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim cmd As New MySqlCommand("select Emp_name from employees", conn)
        Dim ds As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        Dim col As New AutoCompleteStringCollection
        conn.Open()

        da.Fill(ds)
        For i = 0 To ds.Rows.Count - 1
            col.Add(ds.Rows(i)("Emp_name").ToString())

        Next
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        conn.Close()
    End Sub


    Dim conn As MySqlConnection

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim ID = txt_empID.Text
            Dim cmd = New MySqlCommand("update employees set status = 0 where Emp_ID ='" & ID & "'", conn)
            conn.Open()
            If cmd.ExecuteNonQuery() Then
                MsgBox("employee removed successfully")

            Else
                MsgBox("Error occurred ")
            End If

            conn.Close()
            txt_empID.Text = ""
            TextBox1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Activ_btn_Click(sender As Object, e As EventArgs) Handles Activ_btn.Click
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim ID = txt_empID.Text
            Dim cmd = New MySqlCommand("update employees set status = 1 where Emp_ID ='" & ID & "'", conn)

            conn.Open()
            If cmd.ExecuteNonQuery() Then
                MsgBox("employee Activated successfully")
            Else
                MsgBox("Error occurred ")
            End If
            conn.Close()
            txt_empID.Text = ""
            TextBox1.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub txt_empID_TextChanged(sender As Object, e As EventArgs) Handles txt_empID.TextChanged
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        If Global_ID.validation_allspecial(txt_empID.Text) Then
            Dim cmd = New MySqlCommand("Select emp_name ,status from employees where emp_ID='" & txt_empID.Text & "'", conn)
            Dim rd As MySqlDataReader
            conn.Open()
            rd = cmd.ExecuteReader
            Dim result2 = rd.Read()
            If result2 Then
                If (rd("status") = 0) Then
                    TextBox1.Text = "User is deactivated "
                Else
                    TextBox1.Text = rd("Emp_name")
                End If

            Else
                TextBox1.Text = "User ID doesn't exist"
            End If
            conn.Close()

        Else
            MsgBox("you can't special charachter ")
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim cmd2 As New MySqlCommand("select Emp_id from employees where emp_name='" & TextBox1.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        txt_empID.Text = rd("emp_ID")
        conn.Close()
    End Sub
End Class
