Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class appointments_control
    Private Sub appointments_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        app_doc()

    End Sub


    Dim conn As MySqlConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Function app_doc()
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")

            Dim X = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            Dim cmd3 = New MySqlCommand("UPDATE appointment SET status=0 WHERE app_date< '" & X & "'", conn)
            conn.Open()
            cmd3.ExecuteNonQuery()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
        Try


            'Dim rd As MySqlDataReader

            Dim sda As New MySqlDataAdapter
            Dim ds As New DataTable
            Dim bs As New BindingSource

            conn.Open()
            Dim cmd4 = New MySqlCommand("Select pat_name,pat_ID , app_date from appointment NATURAL JOIN patient where doctor_id='" & Global_ID.userID & "' and status ='1'", conn)

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

    End Function




End Class
