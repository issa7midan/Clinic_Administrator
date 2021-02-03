<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nurse_new
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.emp_name_lbl = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.emp_name_lbl_1 = New System.Windows.Forms.Label()
        Me.emp_ID_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.logOut_btn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Check_pat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.payment = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.appointments = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Reg_pat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'emp_name_lbl
        '
        Me.emp_name_lbl.AutoSize = True
        Me.emp_name_lbl.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_name_lbl.Location = New System.Drawing.Point(304, 14)
        Me.emp_name_lbl.Name = "emp_name_lbl"
        Me.emp_name_lbl.Size = New System.Drawing.Size(146, 23)
        Me.emp_name_lbl.TabIndex = 0
        Me.emp_name_lbl.Text = "Nurse Name : "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Controls.Add(Me.emp_name_lbl_1)
        Me.Panel7.Controls.Add(Me.emp_ID_lbl)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.emp_name_lbl)
        Me.Panel7.Location = New System.Drawing.Point(210, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(925, 58)
        Me.Panel7.TabIndex = 2
        '
        'emp_name_lbl_1
        '
        Me.emp_name_lbl_1.AutoSize = True
        Me.emp_name_lbl_1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.emp_name_lbl_1.Location = New System.Drawing.Point(476, 14)
        Me.emp_name_lbl_1.Name = "emp_name_lbl_1"
        Me.emp_name_lbl_1.Size = New System.Drawing.Size(0, 24)
        Me.emp_name_lbl_1.TabIndex = 4
        '
        'emp_ID_lbl
        '
        Me.emp_ID_lbl.AutoSize = True
        Me.emp_ID_lbl.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.emp_ID_lbl.Location = New System.Drawing.Point(161, 14)
        Me.emp_ID_lbl.Name = "emp_ID_lbl"
        Me.emp_ID_lbl.Size = New System.Drawing.Size(0, 24)
        Me.emp_ID_lbl.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nurse ID : "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1135, 601)
        Me.Panel2.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.Location = New System.Drawing.Point(210, 55)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(925, 546)
        Me.Panel6.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(182, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 601)
        Me.Panel3.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.logOut_btn)
        Me.Panel5.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel5.Controls.Add(Me.Check_pat)
        Me.Panel5.Controls.Add(Me.payment)
        Me.Panel5.Controls.Add(Me.appointments)
        Me.Panel5.Controls.Add(Me.Reg_pat)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 124)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(210, 477)
        Me.Panel5.TabIndex = 2
        '
        'logOut_btn
        '
        Me.logOut_btn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.logOut_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.logOut_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logOut_btn.BorderRadius = 0
        Me.logOut_btn.ButtonText = "Logout"
        Me.logOut_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logOut_btn.DisabledColor = System.Drawing.Color.Gray
        Me.logOut_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.logOut_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOut_btn.Iconcolor = System.Drawing.Color.Transparent
        Me.logOut_btn.Iconimage = Global.clinic_administrator.My.Resources.Resources.logout
        Me.logOut_btn.Iconimage_right = Nothing
        Me.logOut_btn.Iconimage_right_Selected = Nothing
        Me.logOut_btn.Iconimage_Selected = Nothing
        Me.logOut_btn.IconMarginLeft = 0
        Me.logOut_btn.IconMarginRight = 0
        Me.logOut_btn.IconRightVisible = True
        Me.logOut_btn.IconRightZoom = 0R
        Me.logOut_btn.IconVisible = True
        Me.logOut_btn.IconZoom = 90.0R
        Me.logOut_btn.IsTab = False
        Me.logOut_btn.Location = New System.Drawing.Point(0, 330)
        Me.logOut_btn.Name = "logOut_btn"
        Me.logOut_btn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.logOut_btn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.logOut_btn.OnHoverTextColor = System.Drawing.Color.White
        Me.logOut_btn.selected = False
        Me.logOut_btn.Size = New System.Drawing.Size(210, 66)
        Me.logOut_btn.TabIndex = 6
        Me.logOut_btn.Text = "Logout"
        Me.logOut_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logOut_btn.Textcolor = System.Drawing.Color.White
        Me.logOut_btn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Online-Form"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.clinic_administrator.My.Resources.Resources.menu
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 264)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(210, 66)
        Me.BunifuFlatButton1.TabIndex = 7
        Me.BunifuFlatButton1.Text = "Online-Form"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ToolTip3.SetToolTip(Me.BunifuFlatButton1, "This button allows you to review patients who registered appointments on the web " &
        "form.")
        '
        'Check_pat
        '
        Me.Check_pat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Check_pat.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check_pat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Check_pat.BorderRadius = 0
        Me.Check_pat.ButtonText = "Check patient"
        Me.Check_pat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check_pat.DisabledColor = System.Drawing.Color.Gray
        Me.Check_pat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Check_pat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_pat.Iconcolor = System.Drawing.Color.Transparent
        Me.Check_pat.Iconimage = Global.clinic_administrator.My.Resources.Resources._31038561
        Me.Check_pat.Iconimage_right = Nothing
        Me.Check_pat.Iconimage_right_Selected = Nothing
        Me.Check_pat.Iconimage_Selected = Nothing
        Me.Check_pat.IconMarginLeft = 0
        Me.Check_pat.IconMarginRight = 0
        Me.Check_pat.IconRightVisible = True
        Me.Check_pat.IconRightZoom = 0R
        Me.Check_pat.IconVisible = True
        Me.Check_pat.IconZoom = 90.0R
        Me.Check_pat.IsTab = False
        Me.Check_pat.Location = New System.Drawing.Point(0, 198)
        Me.Check_pat.Name = "Check_pat"
        Me.Check_pat.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check_pat.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Check_pat.OnHoverTextColor = System.Drawing.Color.White
        Me.Check_pat.selected = False
        Me.Check_pat.Size = New System.Drawing.Size(210, 66)
        Me.Check_pat.TabIndex = 1
        Me.Check_pat.Text = "Check patient"
        Me.Check_pat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Check_pat.Textcolor = System.Drawing.Color.White
        Me.Check_pat.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ToolTip2.SetToolTip(Me.Check_pat, "This button Allows you to review patient information and appointments.")
        '
        'payment
        '
        Me.payment.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.payment.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.payment.BorderRadius = 0
        Me.payment.ButtonText = "Payment"
        Me.payment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.payment.DisabledColor = System.Drawing.Color.Gray
        Me.payment.Dock = System.Windows.Forms.DockStyle.Top
        Me.payment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment.Iconcolor = System.Drawing.Color.Transparent
        Me.payment.Iconimage = Global.clinic_administrator.My.Resources.Resources.hand
        Me.payment.Iconimage_right = Nothing
        Me.payment.Iconimage_right_Selected = Nothing
        Me.payment.Iconimage_Selected = Nothing
        Me.payment.IconMarginLeft = 0
        Me.payment.IconMarginRight = 0
        Me.payment.IconRightVisible = True
        Me.payment.IconRightZoom = 0R
        Me.payment.IconVisible = True
        Me.payment.IconZoom = 90.0R
        Me.payment.IsTab = False
        Me.payment.Location = New System.Drawing.Point(0, 132)
        Me.payment.Name = "payment"
        Me.payment.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.payment.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.payment.OnHoverTextColor = System.Drawing.Color.White
        Me.payment.selected = False
        Me.payment.Size = New System.Drawing.Size(210, 66)
        Me.payment.TabIndex = 3
        Me.payment.Text = "Payment"
        Me.payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.payment.Textcolor = System.Drawing.Color.White
        Me.payment.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        '
        'appointments
        '
        Me.appointments.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.appointments.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.appointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.appointments.BorderRadius = 0
        Me.appointments.ButtonText = "Set appointments"
        Me.appointments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.appointments.DisabledColor = System.Drawing.Color.Gray
        Me.appointments.Dock = System.Windows.Forms.DockStyle.Top
        Me.appointments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.appointments.Iconcolor = System.Drawing.Color.Transparent
        Me.appointments.Iconimage = Global.clinic_administrator.My.Resources.Resources.edit_product
        Me.appointments.Iconimage_right = Nothing
        Me.appointments.Iconimage_right_Selected = Nothing
        Me.appointments.Iconimage_Selected = Nothing
        Me.appointments.IconMarginLeft = 0
        Me.appointments.IconMarginRight = 0
        Me.appointments.IconRightVisible = True
        Me.appointments.IconRightZoom = 0R
        Me.appointments.IconVisible = True
        Me.appointments.IconZoom = 90.0R
        Me.appointments.IsTab = False
        Me.appointments.Location = New System.Drawing.Point(0, 66)
        Me.appointments.Name = "appointments"
        Me.appointments.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.appointments.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.appointments.OnHoverTextColor = System.Drawing.Color.White
        Me.appointments.selected = False
        Me.appointments.Size = New System.Drawing.Size(210, 66)
        Me.appointments.TabIndex = 2
        Me.appointments.Text = "Set appointments"
        Me.appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.appointments.Textcolor = System.Drawing.Color.White
        Me.appointments.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        '
        'Reg_pat
        '
        Me.Reg_pat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Reg_pat.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Reg_pat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Reg_pat.BorderRadius = 0
        Me.Reg_pat.ButtonText = "Register patient"
        Me.Reg_pat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reg_pat.DisabledColor = System.Drawing.Color.Gray
        Me.Reg_pat.Dock = System.Windows.Forms.DockStyle.Top
        Me.Reg_pat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg_pat.Iconcolor = System.Drawing.Color.Transparent
        Me.Reg_pat.Iconimage = Global.clinic_administrator.My.Resources.Resources.register
        Me.Reg_pat.Iconimage_right = Nothing
        Me.Reg_pat.Iconimage_right_Selected = Nothing
        Me.Reg_pat.Iconimage_Selected = Nothing
        Me.Reg_pat.IconMarginLeft = 0
        Me.Reg_pat.IconMarginRight = 0
        Me.Reg_pat.IconRightVisible = True
        Me.Reg_pat.IconRightZoom = 0R
        Me.Reg_pat.IconVisible = True
        Me.Reg_pat.IconZoom = 90.0R
        Me.Reg_pat.IsTab = False
        Me.Reg_pat.Location = New System.Drawing.Point(0, 0)
        Me.Reg_pat.Name = "Reg_pat"
        Me.Reg_pat.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Reg_pat.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Reg_pat.OnHoverTextColor = System.Drawing.Color.White
        Me.Reg_pat.selected = False
        Me.Reg_pat.Size = New System.Drawing.Size(210, 66)
        Me.Reg_pat.TabIndex = 0
        Me.Reg_pat.Text = "Register patient"
        Me.Reg_pat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Reg_pat.Textcolor = System.Drawing.Color.White
        Me.Reg_pat.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.ToolTip1.SetToolTip(Me.Reg_pat, "This button Allows you to register a new patient into the system")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 127)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.clinic_administrator.My.Resources.Resources.clipart578024
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Panel1
        Me.BunifuDragControl2.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 32)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dr Eyad Abusalah Clinic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nurse Panel"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.clinic_administrator.My.Resources.Resources.__
        Me.PictureBox3.Location = New System.Drawing.Point(1051, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.clinic_administrator.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(1093, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 50
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Register patient"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "Check patient"
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipTitle = "Online-Form "
        '
        'frm_nurse_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 633)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_nurse_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_nurse_new"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents emp_name_lbl_1 As Label
    Friend WithEvents emp_ID_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents emp_name_lbl As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logOut_btn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents payment As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents appointments As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Check_pat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Reg_pat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents Label4 As Label
End Class
