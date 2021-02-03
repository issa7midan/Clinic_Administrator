Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Patient_rep_control


    Dim conn As MySqlConnection
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Check_Click(sender As Object, e As EventArgs) Handles Check.Click

        Dim Repor = Report.Text
        Dim costs = Cost.Text
        Dim proc = ProceduresTxt.Text
        Dim X = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        If Global_ID.validation_LONG_TEXT(Repor) Then
            Try
                conn = New MySqlConnection("server = localhost;user id=root;database=clinic")
                Dim ID = pat_ID.Text
                Dim cmd = New MySqlCommand("INSERT INTO  pat_doc_rep (Pat_ID , Doctor_ID ,Report ,Cost,Procedures, Date) VALUES ('" & ID & "','" & Global_ID.userID & "', '" & Repor & "','" & costs & "','" & proc & "','" & X & "')", conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Patient report saved successfully", "patient Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pat_ID.Text = ""
                TextBox1.Text = ""
                Report.Text = ""
                Cost.Text = ""
                ProceduresTxt.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(ex.ToString)

            End Try
        Else
            MsgBox("Error")
        End If

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
            TextBox1.Text = ""
        Else

            TextBox1.Text = "Patient ID doesn't exist"
        End If
        conn.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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
End Class
