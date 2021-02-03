Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Reports_control
    Dim conn As MySqlConnection

    Private Sub Reports_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim sda As New MySqlDataAdapter
            Dim ds As New DataTable
            Dim bs As New BindingSource

            BunifuDropdown1.AddItem("Last 30 days")
            BunifuDropdown1.AddItem("Last 60 days")
            BunifuDropdown1.AddItem("Last 90 days")
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim cmd = New MySqlCommand("SELECT SUM(amount) AS Total_Amount FROM payment", conn)
            Dim cmd2 = New MySqlCommand("SELECT  payment_ID,amount,emp_ID ,YEAR(DATE) AS 'year', MONTH(DATE) AS 'month' FROM payment", conn)

            Dim rd As MySqlDataReader
            conn.Close()
            conn.Open()
            Dim cmd4 = New MySqlCommand("Select * from payment", conn)
            cmd4.Connection = conn
            cmd4.CommandType = CommandType.Text
            sda.SelectCommand = cmd4
            sda.Fill(ds)
            bs.DataSource = ds
            DataGridView1.DataSource = bs
            sda.Update(ds)
            DataGridView1.Refresh()
            conn.Close()

            conn.Open()
            rd = cmd.ExecuteReader
            rd.Read()
            Amount_lb.Text = rd("Total_Amount")
            conn.Close()



        Catch ex As Exception

        End Try
    End Sub

    Public Class Reports
        Dim conn As MySqlConnection

        Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

        End Sub

    End Class

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown1.onItemSelected
        Dim rd As MySqlDataReader
        Dim sda As New MySqlDataAdapter
        Dim ds As New DataTable
        Dim bs As New BindingSource
        Dim picker As Integer
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        If BunifuDropdown1.selectedIndex = 0 Then
            picker = 1
        ElseIf BunifuDropdown1.selectedIndex = 1 Then
            picker = 2
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            picker = 3
        End If

        conn.Open()
        Dim cmd3 = New MySqlCommand("SELECT * FROM payment 
            WHERE DATE < NOW() AND DATE > DATE_ADD(NOW(), INTERVAL- '" & picker & "' MONTH);", conn)
        cmd3.Connection = conn
        cmd3.CommandType = CommandType.Text
        sda.SelectCommand = cmd3
        sda.Fill(ds)
        bs.DataSource = ds
        DataGridView1.DataSource = bs
        sda.Update(ds)
        DataGridView1.Refresh()
        conn.Close()
        Dim cmd = New MySqlCommand("SELECT SUM(amount) AS Total_Amount FROM payment 
            WHERE DATE < NOW() AND DATE > DATE_ADD(NOW(), INTERVAL- '" & picker & "' MONTH);", conn)
        conn.Open()
        rd = cmd.ExecuteReader
        rd.Read()
        Amount_lb.Text = rd("Total_Amount")
        conn.Close()
    End Sub
End Class
