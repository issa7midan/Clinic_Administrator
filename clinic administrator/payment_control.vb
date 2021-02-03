Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class payment_control
    Private Sub payment_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim cmd As New MySqlCommand("select pat_name from patient", conn)
        Dim ds As New DataTable
        Dim da As New MySqlDataAdapter(cmd)
        Dim col As New AutoCompleteStringCollection
        conn.Open()

        da.Fill(ds)
        For i = 0 To ds.Rows.Count - 1
            col.Add(ds.Rows(i)("pat_name").ToString())

        Next
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        conn.Close()
    End Sub


    Dim conn As MySqlConnection
    Private Sub pat_ID_TextChanged(sender As Object, e As EventArgs) Handles pat_ID.TextChanged
        'Try
        '    conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        '    If Global_ID.validation_allspecial(pat_ID.Text) Then
        '        Dim cmd = New MySqlCommand("select pat_name from patient where pat_ID ='" & pat_ID.Text & "'", conn)
        '        Dim rd As MySqlDataReader
        '        conn.Open()
        '        rd = cmd.ExecuteReader
        '        Dim status = rd.Read()
        '        If status Then
        '            pat_name.Text = rd("pat_name")
        '        ElseIf pat_ID.Text = "" Then
        '            pat_name.Text = ""
        '            Payment_txt.Text = ""
        '        Else
        '            pat_name.Text = "patient doesn't exist"
        '        End If
        '        conn.Close()
        '    Else
        '        MsgBox("you can't use special charachters ")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    MsgBox(ex.ToString)
        'End Try

        ' End Sub
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim patient = TextBox1.Text
        Dim patientID = pat_ID.Text
        Dim cmd = New MySqlCommand("Select pat_name from patient where pat_id ='" & patientID & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd.ExecuteReader
        Dim result2 = rd.Read()
        If result2 Then
            TextBox1.Text = rd("pat_name")
        ElseIf pat_ID.Text = "" Then
            pat_ID.Text = ""
            TextBox1.Text = ""
            Report_Number.Clear()
        Else

            TextBox1.Text = "Patient ID doesn't exist"
        End If
        conn.Close()
        Report_Number.Clear()
        Rep_check()

    End Sub
    Function Rep_check()
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim ID = pat_ID.Text
        Dim rd As MySqlDataReader
        Dim cmd = New MySqlCommand("SELECT date FROM pat_doc_rep  WHERE pat_ID ='" & ID & "'", conn)

        conn.Open()
        rd = cmd.ExecuteReader
        While rd.HasRows
            Dim result = rd.Read
            If result Then
                Report_Number.AddItem(rd("Date"))
            Else
                Exit While
            End If
        End While
        conn.Close()
    End Function

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        Try
            Dim X = DateTime.Now.ToString("yyyy-MM-dd")
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim cmd = New MySqlCommand("Insert into payment (amount , emp_ID , pat_ID , date ) VALUES ('" & Payment_txt.Text & "' , '" & Global_ID.userID & "' , '" & pat_ID.Text & "' , '" & X & "' )", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            Dim cmd2 = New MySqlCommand("SELECT payment_id FROM payment getLastRecord ORDER BY Payment_ID DESC LIMIT 1", conn)
            conn.Open()
            Dim rd As MySqlDataReader
            rd = cmd2.ExecuteReader
            rd.Read()
            Payment_ID.Text = rd("payment_ID")
            conn.Close()
            MsgBox("Payment is fixed. ")

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Payment_ID.Text = ""
        pat_ID.Text = ""
        Payment_txt.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub Report_Number_onItemSelected(sender As Object, e As EventArgs) Handles Report_Number.onItemSelected
        Try

            Dim ID = pat_ID.Text
            Dim rd As MySqlDataReader
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            conn.Open()
            Dim cmd = New MySqlCommand("Select Cost from pat_doc_rep  where date ='" & Report_Number.selectedValue.Trim & "' and pat_id ='" & ID & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Payment_txt.Text = rd("Cost")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim cmd2 As New MySqlCommand("select pat_id from patient where pat_name='" & TextBox1.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        pat_ID.Text = rd("pat_id")
        conn.Close()
    End Sub
End Class
