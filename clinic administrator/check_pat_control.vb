Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class check_pat_control
    Private Sub check_pat_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Pat_name_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pat_check_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")

    End Sub

    Private Sub pat_Number_TextChanged(sender As Object, e As EventArgs) Handles pat_Number.TextChanged
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim patient = TextBox1.Text
        Dim patientID = pat_Number.Text
        Dim cmd = New MySqlCommand("Select pat_name from patient where pat_id ='" & patientID & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd.ExecuteReader
        Dim result2 = rd.Read()
        If result2 Then
            TextBox1.Text = rd("pat_name")
        ElseIf patientID = "" Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = "patient doesn't exist"
        End If
        conn.Close()
        Try

            Dim sda As New MySqlDataAdapter
            Dim ds As New DataTable
            Dim bs As New BindingSource

            conn.Open()
            Dim cmd4 = New MySqlCommand("select * from patient where pat_ID='" & pat_Number.Text & "'", conn)
            cmd4.Connection = conn
            cmd4.CommandType = CommandType.Text
            sda.SelectCommand = cmd4
            sda.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            sda.Update(ds)
            DataGridView1.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
        Try

            Dim sda As New MySqlDataAdapter
            Dim ds As New DataTable
            Dim bs As New BindingSource

            conn.Open()
            Dim cmd4 = New MySqlCommand("select app_ID , doctor_ID , pat_ID ,APP_date from appointment where pat_ID='" & pat_Number.Text & "' and status =1", conn)
            cmd4.Connection = conn
            cmd4.CommandType = CommandType.Text
            sda.SelectCommand = cmd4
            sda.Fill(ds)
            bs.DataSource = ds
            DataGridView2.DataSource = bs
            sda.Update(ds)
            DataGridView2.Refresh()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        pat_Number.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim cmd2 As New MySqlCommand("select pat_id from patient where pat_name='" & TextBox1.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        pat_Number.Text = rd("pat_id")
        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
