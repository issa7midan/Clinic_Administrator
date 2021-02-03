Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class pat_history_control
    Private Sub pat_history_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
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


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        'Try
        '    Dim ID = pat_ID.Text
        '    Dim rd As MySqlDataReader
        '    conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
        '    'conn.Open()
        '    'Dim cmd = New MySqlCommand("Select report from pat_doc_rep where date ='" & Report_Number.selectedValue & "' and pat_ID ='" & ID & "'", conn)
        '    'rd = cmd.ExecuteReader
        '    'rd.Read()
        '    'Report.Text = rd("report")
        '    'conn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub doc_ID_TextChanged(sender As Object, e As EventArgs) Handles doc_ID.TextChanged

    End Sub

    Private Sub Report_Number_onItemSelected(sender As Object, e As EventArgs) Handles Report_Number.onItemSelected
        Try

            Dim ID = pat_ID.Text
            Dim rd As MySqlDataReader
            conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
            conn.Open()
            Dim cmd = New MySqlCommand("Select doctor_ID , report ,Cost,Procedures from pat_doc_rep  where date ='" & Report_Number.selectedValue.Trim & "' and pat_id ='" & ID & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            doc_ID.Text = rd("doctor_ID")
            Report.Text = rd("report")
            Cost.Text = rd("Cost")
            proc.Text = rd("Procedures")
            conn.Close()
            Dim cmd2 = New MySqlCommand("Select emp_name from employees where emp_ID='" & doc_ID.Text & "'", conn)
            conn.Open()
            rd = cmd2.ExecuteReader
            rd.Read()
            Doc_name.Text = (rd("emp_name"))
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Try
            conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
            Dim cmd = New MySqlCommand("UPDATE pat_doc_rep set Report ='" & Report.Text & "',Cost='" & Cost.Text & "',Procedures='" & proc.Text & "' where doctor_ID='" & doc_ID.Text & "' and pat_ID='" & pat_ID.Text & "'", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Report updated successfully")
            pat_ID.Text = ""
            TextBox1.Text = ""
            doc_ID.Text = ""
            Report_Number.Clear()
            Doc_name.Text = ""
            Report.Text = ""
            proc.Text = ""
            Cost.Text = ""
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub pat_ID_TextChanged(sender As Object, e As EventArgs) Handles pat_ID.TextChanged
        conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
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
            doc_ID.Text = ""
            Report_Number.Clear()
            Doc_name.Text = ""
            Report.Text = ""
            proc.Text = ""
            Cost.Text = ""
        Else

            TextBox1.Text = "Patient ID doesn't exist"
        End If
        conn.Close()
        Report_Number.Clear()
        Rep_check()

    End Sub
    Function Rep_check()
        conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
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

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        pat_ID.Text = ""
        TextBox1.Text = ""
        doc_ID.Text = ""
        Report_Number.Clear()
        Doc_name.Text = ""
        Report.Text = ""
    End Sub

    Private Sub pat_name_TextChanged(sender As Object, e As EventArgs)

        ' Try

        'conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
        'Dim patient = pat_name.Text
        'Dim patientID = pat_ID.Text
        'Dim rd As MySqlDataReader
        'Dim cmd = New MySqlCommand("Select pat_name from patient", conn)
        'Dim da As New MySqlDataAdapter(cmd)
        'Dim col As New AutoCompleteStringCollection
        'Dim ds As New DataTable
        'conn.Open()
        'da.Fill(ds)
        'For i = 0 To ds.Rows.Count - 1
        '    col.Add(ds.Rows(i)("pat_name").ToString())

        'Next

        'pat_name.AutoCompleteSource = AutoCompleteSource.CustomSource
        'pat_name.AutoCompleteCustomSource = col
        'pat_name.AutoCompleteMode = AutoCompleteMode.Suggest
        'conn.Close()

        '    rd = cmd.ExecuteReader
        '    Dim result2 = rd.Read()

        '    If result2 Then
        '        pat_ID.Text = rd("pat_id")
        '    ElseIf pat_ID.Text = "" Then
        '        pat_ID.Text = ""
        '        '  pat_name.Text = ""
        '        doc_ID.Text = ""
        '        Report_Number.Clear()
        '        Doc_name.Text = ""
        '        Report.Text = ""
        '    Else

        '        'pat_name.Text = "Patient ID doesn't exist"
        '    End If
        '    conn.Close()
        '    Report_Number.Clear()
        '    Rep_check()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub pat_name_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then

            pat_ID.Text = ""
                TextBox1.Text = ""
                doc_ID.Text = ""
                Report_Number.Clear()
                Doc_name.Text = ""
                Report.Text = ""
                proc.Text = ""
            Cost.Text = ""
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim cmd2 As New MySqlCommand("select pat_id from patient where pat_name='" & TextBox1.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        pat_ID.Text = rd("pat_id")
        conn.Close()
    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            pat_ID.Text = ""
            TextBox1.Text = ""
            doc_ID.Text = ""
            Report_Number.Clear()
            Doc_name.Text = ""
            Report.Text = ""
            proc.Text = ""
            Cost.Text = ""
        End If
    End Sub
End Class
