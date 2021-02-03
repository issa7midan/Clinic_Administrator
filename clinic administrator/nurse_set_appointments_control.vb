Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class nurse_set_appointments_control
    Private Sub nurse_set_appointments_control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
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
        Dim rd As MySqlDataReader
        Dim cmd2 = New MySqlCommand("Select emp_name from employees where Role_ID=2", conn)
        conn.Open()
        rd = cmd2.ExecuteReader
        While rd.HasRows
            Dim result = rd.Read
            If result Then
                BunifuDropdown2.AddItem(rd("emp_name"))
            Else
                Exit While
            End If
        End While

        conn.Close()
    End Sub


    Dim conn As MySqlConnection


    Private Sub Check_Click(sender As Object, e As EventArgs) Handles Check.Click
        Dim X = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Dim cmd3 = New MySqlCommand("UPDATE appointment SET status=0 WHERE app_date< '" & X & "'", conn)
        conn.Open()
        cmd3.ExecuteNonQuery()
        conn.Close()
        Try
            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim doctor_ID = Doc_ID.Text
            'Dim docror_name = doc_name.Text

            Dim rd As MySqlDataReader

            Dim sda As New MySqlDataAdapter
            Dim ds As New DataTable
            Dim bs As New BindingSource
            Try
                conn.Open()
                Dim cmd = New MySqlCommand("Select Emp_name , app_date from appointment NATURAL JOIN EMPLOYEES where emp_ID ='" & doctor_ID & "' and role_ID =2", conn)
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                sda.SelectCommand = cmd
                sda.Fill(ds)
                bs.DataSource = ds
                DataGridView1.DataSource = bs
                sda.Update(ds)
                DataGridView1.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Close()
            End Try
            'Dim ada As New MySqlDataAdapter()
            'Dim ds As New DataSet
            'conn.Open()
            'ada = New MySqlDataAdapter("Select * from employees", conn)
            'ada.Fill(ds)
            'DataGridViewAdvancedBorderStyle.DataSource = ds.Tables(0)
            'DataGridViewAdvancedBorderStyle.databind()

            '  rd = cmd.ExecuteReader()
            'rd.Read()
            'doc_name.Text = rd("emp_name")
            'Appointments_txt.Text.Append(rd("app_date"))
            'Appointments_txt.Text.Append(rd("app_date"))

            'Dim result = rd.Read()

            'While rd.HasRows
            '    If result Then
            '        Appointments_txt.Text = rd("app_date")
            '    Else
            '        Exit While
            '    End If
            'End While

            'conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try


    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    'End Sub

    'Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
    '    conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
    '    Dim doctor_ID = Doc_ID.Text
    '    Dim docror_name = doc_name.Text

    '    Dim rd As MySqlDataReader
    '    conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")

    '    Dim sda As New MySqlDataAdapter
    '    Dim ds As New DataTable
    '    Dim bs As New BindingSource
    '    Try
    '        conn.Open()
    '        Dim cmd = New MySqlCommand("Select Emp_name , app_date from appointment NATURAL JOIN EMPLOYEES where emp_ID ='" & doctor_ID & "' and role_ID =2", conn)
    '        cmd.Connection = conn
    '        cmd.CommandType = CommandType.Text
    '        sda.SelectCommand = cmd
    '        sda.Fill(ds)
    '        bs.DataSource = ds
    '        BunifuCustomDataGrid1.DataSource = bs
    '        sda.Update(ds)
    '        BunifuCustomDataGrid1.Refresh()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    Private Sub Doc_ID_TextChanged(sender As Object, e As EventArgs) Handles Doc_ID.TextChanged



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pat_ID_TextChanged(sender As Object, e As EventArgs) Handles Pat_ID.TextChanged

        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim patient = TextBox1.Text
        Dim patientID = Pat_ID.Text
        Dim cmd = New MySqlCommand("Select pat_name from patient where pat_id ='" & patientID & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd.ExecuteReader
        Dim result2 = rd.Read()
        If result2 Then
            TextBox1.Text = rd("pat_name")
        ElseIf Pat_ID.Text = "" Then
            TextBox1.Text = ""
        Else

            TextBox1.Text = "Patient ID doesn't exist"
        End If
        conn.Close()
        BunifuDropdown1.Clear()
        docs()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Try


            '  Dim x = DateTimePicker1.CustomFormat("dd/MM/yyyy HH:mm:ss").ToString
            ' Convert.ToString(x)

            conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
            Dim patient = TextBox1.Text
            Dim patientID = Pat_ID.Text
            Dim cmd = New MySqlCommand("INSERT INTO appointment (DOCTOR_ID , PAT_ID , APP_DATE , status ) VALUES ('" & Doc_IDD.Text & "', '" & Pat_ID.Text & "' , '" & DateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss") & "' , '1')", conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Appointment is set successfully")
            conn.Close()
            TextBox1.Text = ""
            Pat_ID.Text = ""
            Doc_IDD.Text = ""
            BunifuDropdown1.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown1.onItemSelected
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim rd As MySqlDataReader
        Dim cmd3 = New MySqlCommand("Select emp_ID from employees where Role_ID =2 And Emp_name='" & BunifuDropdown1.selectedValue.Trim & "'", conn)

        conn.Open()
        rd = cmd3.ExecuteReader
        rd.Read()
        Doc_IDD.Text = rd("Emp_ID")
        conn.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "dd/MM/yyyy ss:mm:HH"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        Pat_ID.Text = ""
        Doc_IDD.Text = ""
        Doc_ID.Text = ""
        BunifuDropdown1.Clear()
        DataGridView1.ClearSelection()
        BunifuDropdown2.Clear()


    End Sub
    Function docs()
        Dim rd As MySqlDataReader
        Dim cmd2 = New MySqlCommand("Select emp_name from employees where Role_ID=2", conn)
        conn.Open()
        rd = cmd2.ExecuteReader
        While rd.HasRows
            Dim result = rd.Read
            If result Then
                BunifuDropdown1.AddItem(rd("emp_name"))
            Else
                Exit While
            End If
        End While

        conn.Close()
    End Function

    Private Sub App_pat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim cmd2 As New MySqlCommand("select pat_id from patient where pat_name='" & TextBox1.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        Pat_ID.Text = rd("pat_id")
        conn.Close()
    End Sub

    Private Sub BunifuDropdown2_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDropdown2_onItemSelected_1(sender As Object, e As EventArgs) Handles BunifuDropdown2.onItemSelected
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim rd As MySqlDataReader
        Dim cmd3 = New MySqlCommand("Select emp_ID from employees where Role_ID =2 And Emp_name='" & BunifuDropdown2.selectedValue.Trim & "'", conn)

        conn.Open()
        rd = cmd3.ExecuteReader
        rd.Read()
        Doc_ID.Text = rd("Emp_ID")
        conn.Close()
    End Sub
End Class
