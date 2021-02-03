Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class connection
    Dim con = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
    Public cmd As New MySqlCommand
    Public conn As New MySqlConnection(con)
    Public rd As MySqlDataReader
    Public sda As New MySqlDataAdapter
    Public bs As New BindingSource
    Public dt As New DataTable

    Sub connect()
        con.open()
    End Sub

    Sub disconnect()
        con.close()
    End Sub
End Class
