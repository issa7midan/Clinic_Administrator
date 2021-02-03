Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frm_nurse_new

    Dim conn As MySqlConnection
    Dim active_panel As UserControl
    Private Sub logOut_btn_Click(sender As Object, e As EventArgs) Handles logOut_btn.Click
        Me.Hide()
        frm_login.Show()

    End Sub

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

    Private Sub Reg_pat_Click(sender As Object, e As EventArgs) Handles Reg_pat.Click

        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim reg_pat As New pat_reg_control
        Panel6.Controls.Add(reg_pat)
        reg_pat.Dock = DockStyle.Fill
        active_panel = reg_pat
    End Sub

    Private Sub Check_pat_Click(sender As Object, e As EventArgs) Handles Check_pat.Click

        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim check_pat As New check_pat_control
        Panel6.Controls.Add(check_pat)
        check_pat.Dock = DockStyle.Fill
        active_panel = check_pat
    End Sub

    Private Sub appointments_Click(sender As Object, e As EventArgs) Handles appointments.Click
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim set_app As New nurse_set_appointments_control
        Panel6.Controls.Add(set_app)
        '  set_app.Dock = DockStyle.Fill
        active_panel = set_app
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub payment_Click(sender As Object, e As EventArgs) Handles payment.Click
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim payment As New payment_control
        Panel6.Controls.Add(payment)
        payment.Dock = DockStyle.Fill
        active_panel = payment
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        update_ntfns()
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim form_online As New Online_form_usercontrol
        Panel6.Controls.Add(form_online)
        form_online.Dock = DockStyle.Fill
        active_panel = form_online
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
    Public Sub notifications()
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim cmd = New MySqlCommand("SELECT COUNT(*) as cnt FROM form_reg WHERE ntfns=1;", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        rd = cmd.ExecuteReader
        rd.Read()
        Label4.Text = rd("cnt")
        If (rd("cnt") = 0) Then
            Label4.Text = ""
        End If
        conn.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Sub frm_nurse_new_Load(sender As Object, e As EventArgs) Handles Me.Load
        notifications()
        Dim xSub As New SampleCallEveryXMinute(60000) ' 1000 ms = 1 sec so 60000 ms = 1 min
        xSub.StartTimer()
    End Sub
    Sub update_ntfns()
        conn = New MySqlConnection("server = 192.168.1.6;user id=issa;database=clinic")
        Dim cmd = New MySqlCommand("update form_reg set ntfns=0 WHERE ntfns=1;", conn)
        Dim rd As MySqlDataReader
        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()
        Dim cmd2 = New MySqlCommand("SELECT COUNT(*) as cnt FROM form_reg WHERE ntfns=1;", conn)
        conn.Open()
        rd = cmd2.ExecuteReader
        rd.Read()
        Label4.Text = rd("cnt")
        If (rd("cnt") = 0) Then
            Label4.Text = ""
        End If
        conn.Close()

    End Sub


    Public Class SampleCallEveryXMinute

        Private WithEvents xTimer As New System.Windows.Forms.Timer

        Public Sub New(TickValue As Integer)
            xTimer = New System.Windows.Forms.Timer
            xTimer.Interval = TickValue
        End Sub

        Public Sub StartTimer()
            xTimer.Start()
        End Sub

        Public Sub StopTimer()
            xTimer.Stop()
        End Sub

        Private Sub Timer_Tick() Handles xTimer.Tick
            SampleProcedure()
        End Sub

        Private Sub SampleProcedure()
            frm_nurse_new.notifications()
        End Sub

    End Class
End Class