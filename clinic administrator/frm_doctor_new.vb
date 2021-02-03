Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frm_doctor_new
    Dim conn As MySqlConnection
    Dim active_panel As UserControl
    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        emp_ID_lbl.Text = Global_ID.userID
        Dim cmd = New MySqlCommand("Select emp_name from employees where emp_ID ='" & emp_ID_lbl.Text & "'", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd.ExecuteReader
        rd.Read()
        emp_name_lbl_1.Text = rd("emp_name")
        conn.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Check_Click(sender As Object, e As EventArgs) Handles Check.Click

        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If

        Dim reports1 As New Patient_rep_control
        Panel6.Controls.Add(reports1)
        'Pat_report.Dock = DockStyle.Fill
        active_panel = reports1

    End Sub

    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If

        Dim pat_history As New pat_history_control
        Panel6.Controls.Add(pat_history)
        ' Pat_report.Dock = DockStyle.Fill
        active_panel = pat_history

    End Sub

    Private Sub my_appointments_Click(sender As Object, e As EventArgs) Handles my_appointments.Click
        Me.Hide()
        frm_login.Show()


    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        'If active_panel IsNot Nothing Then
        '    active_panel.Hide()
        'End If
        'Dim reg_pat As New pat_reg_control
        'Panel6.Controls.Add(reg_pat)
        'reg_pat.Dock = DockStyle.Fill
        'active_panel = reg_pat
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If

        Dim appointments As New appointments_control
        Panel6.Controls.Add(appointments)
        appointments.Dock = DockStyle.Fill
        active_panel = appointments
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub emp_name_lbl_Click(sender As Object, e As EventArgs) Handles emp_name_lbl.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class