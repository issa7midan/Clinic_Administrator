Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frm_new_admin
    Dim conn As MySqlConnection
    Dim active_panel As UserControl

    Private Sub frm_new_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub emp_reg_btn_Click(sender As Object, e As EventArgs) Handles emp_reg_btn.Click

        Try


            If active_panel IsNot Nothing Then
                active_panel.Hide()
            End If
            Dim dpet_settings As New Department_settings_control
            Panel6.Controls.Add(dpet_settings)
            dpet_settings.Dock = DockStyle.Fill
            active_panel = dpet_settings

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub rmv_emp_button_Click(sender As Object, e As EventArgs) Handles rmv_emp_button.Click
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim settings As New Emp_settings_control
        Panel6.Controls.Add(settings)
        settings.Dock = DockStyle.Fill
        active_panel = settings

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Try


            If active_panel IsNot Nothing Then
                active_panel.Hide()
            End If
            Dim Roles_settings As New add_roles_control
            Panel6.Controls.Add(Roles_settings)
            Roles_settings.Dock = DockStyle.Fill
            active_panel = Roles_settings

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Department_Click(sender As Object, e As EventArgs) Handles Department.Click
        If active_panel IsNot Nothing Then
            active_panel.Hide()
        End If
        Dim reg As New Register_control
        Panel6.Controls.Add(reg)
        reg.Dock = DockStyle.Fill
        active_panel = reg

    End Sub

    Private Sub Roles_Click(sender As Object, e As EventArgs) Handles Roles.Click
        Try


            If active_panel IsNot Nothing Then
                active_panel.Hide()
            End If
            Dim update As New update_emp_control
            Panel6.Controls.Add(update)
            update.Dock = DockStyle.Fill
            active_panel = update

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Reports_btn_Click(sender As Object, e As EventArgs) Handles Reports_btn.Click
        Try


            If active_panel IsNot Nothing Then
                active_panel.Hide()
            End If
            Dim Reports As New Reports_control
            Panel6.Controls.Add(Reports)
            Reports.Dock = DockStyle.Fill
            active_panel = Reports

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

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

    Private Sub emp_name_lbl_Click(sender As Object, e As EventArgs) Handles emp_name_lbl.Click

    End Sub

    Private Sub BunifuGradientPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class