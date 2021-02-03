Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Online_form_usercontrol
    Dim conn As MySqlConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub

    Function app_doc()
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")

            Dim X = DateTime.Now.ToString("yyyy/MM/dd")
            Dim cmd3 = New MySqlCommand("UPDATE form_reg SET status=0 WHERE reg_date <>'" & X & "'", conn)
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
            Dim cmd4 = New MySqlCommand("SELECT NAME 'Name',Phone_number  'Phone number',DOB 'Date of birth' ,Visit_date 'Visit date',Dept department FROM form_reg WHERE STATUS =1 ", conn)

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

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Online_form_usercontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        app_doc()
    End Sub
End Class
