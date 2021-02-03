<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_doctor_new
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.emp_name_lbl_1 = New System.Windows.Forms.Label()
        Me.emp_ID_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.my_appointments = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.history = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Logout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Check = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.emp_name_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
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
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(31, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Doctor ID :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel5.Controls.Add(Me.my_appointments)
        Me.Panel5.Controls.Add(Me.history)
        Me.Panel5.Controls.Add(Me.Logout)
        Me.Panel5.Controls.Add(Me.Check)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 124)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 445)
        Me.Panel5.TabIndex = 2
        '
        'my_appointments
        '
        Me.my_appointments.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.my_appointments.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.my_appointments.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.my_appointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.my_appointments.BorderRadius = 0
        Me.my_appointments.ButtonText = "Logout"
        Me.my_appointments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.my_appointments.DisabledColor = System.Drawing.Color.Gray
        Me.my_appointments.Dock = System.Windows.Forms.DockStyle.Top
        Me.my_appointments.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.my_appointments.Iconcolor = System.Drawing.Color.Transparent
        Me.my_appointments.Iconimage = Global.clinic_administrator.My.Resources.Resources.logout
        Me.my_appointments.Iconimage_right = Nothing
        Me.my_appointments.Iconimage_right_Selected = Nothing
        Me.my_appointments.Iconimage_Selected = Nothing
        Me.my_appointments.IconMarginLeft = 0
        Me.my_appointments.IconMarginRight = 0
        Me.my_appointments.IconRightVisible = True
        Me.my_appointments.IconRightZoom = 0R
        Me.my_appointments.IconVisible = True
        Me.my_appointments.IconZoom = 90.0R
        Me.my_appointments.IsTab = False
        Me.my_appointments.Location = New System.Drawing.Point(0, 198)
        Me.my_appointments.Name = "my_appointments"
        Me.my_appointments.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.my_appointments.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.my_appointments.OnHoverTextColor = System.Drawing.Color.White
        Me.my_appointments.selected = False
        Me.my_appointments.Size = New System.Drawing.Size(241, 66)
        Me.my_appointments.TabIndex = 2
        Me.my_appointments.Text = "Logout"
        Me.my_appointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.my_appointments.Textcolor = System.Drawing.Color.White
        Me.my_appointments.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'history
        '
        Me.history.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.history.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.history.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.history.BorderRadius = 0
        Me.history.ButtonText = "Patient History"
        Me.history.Cursor = System.Windows.Forms.Cursors.Hand
        Me.history.DisabledColor = System.Drawing.Color.Gray
        Me.history.Dock = System.Windows.Forms.DockStyle.Top
        Me.history.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history.Iconcolor = System.Drawing.Color.Transparent
        Me.history.Iconimage = Global.clinic_administrator.My.Resources.Resources.user
        Me.history.Iconimage_right = Nothing
        Me.history.Iconimage_right_Selected = Nothing
        Me.history.Iconimage_Selected = Nothing
        Me.history.IconMarginLeft = 0
        Me.history.IconMarginRight = 0
        Me.history.IconRightVisible = True
        Me.history.IconRightZoom = 0R
        Me.history.IconVisible = True
        Me.history.IconZoom = 90.0R
        Me.history.IsTab = False
        Me.history.Location = New System.Drawing.Point(0, 132)
        Me.history.Name = "history"
        Me.history.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.history.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.history.OnHoverTextColor = System.Drawing.Color.White
        Me.history.selected = False
        Me.history.Size = New System.Drawing.Size(241, 66)
        Me.history.TabIndex = 1
        Me.history.Text = "Patient History"
        Me.history.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.history.Textcolor = System.Drawing.Color.White
        Me.history.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip2.SetToolTip(Me.history, "This button allows Doctor to review and edit the patients latest reports.")
        '
        'Logout
        '
        Me.Logout.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logout.BorderRadius = 0
        Me.Logout.ButtonText = "My Appointments"
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.DisabledColor = System.Drawing.Color.Gray
        Me.Logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logout.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Iconcolor = System.Drawing.Color.Transparent
        Me.Logout.Iconimage = Global.clinic_administrator.My.Resources.Resources._31038561
        Me.Logout.Iconimage_right = Nothing
        Me.Logout.Iconimage_right_Selected = Nothing
        Me.Logout.Iconimage_Selected = Nothing
        Me.Logout.IconMarginLeft = 0
        Me.Logout.IconMarginRight = 0
        Me.Logout.IconRightVisible = True
        Me.Logout.IconRightZoom = 0R
        Me.Logout.IconVisible = True
        Me.Logout.IconZoom = 90.0R
        Me.Logout.IsTab = False
        Me.Logout.Location = New System.Drawing.Point(0, 66)
        Me.Logout.Name = "Logout"
        Me.Logout.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Logout.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Logout.OnHoverTextColor = System.Drawing.Color.White
        Me.Logout.selected = False
        Me.Logout.Size = New System.Drawing.Size(241, 66)
        Me.Logout.TabIndex = 6
        Me.Logout.Text = "My Appointments"
        Me.Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout.Textcolor = System.Drawing.Color.White
        Me.Logout.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Check
        '
        Me.Check.Activecolor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Check.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Check.BorderRadius = 0
        Me.Check.ButtonText = "Patient Diagnosis"
        Me.Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check.DisabledColor = System.Drawing.Color.Gray
        Me.Check.Dock = System.Windows.Forms.DockStyle.Top
        Me.Check.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check.Iconcolor = System.Drawing.Color.Transparent
        Me.Check.Iconimage = Global.clinic_administrator.My.Resources.Resources.edit_product1
        Me.Check.Iconimage_right = Nothing
        Me.Check.Iconimage_right_Selected = Nothing
        Me.Check.Iconimage_Selected = Nothing
        Me.Check.IconMarginLeft = 0
        Me.Check.IconMarginRight = 0
        Me.Check.IconRightVisible = True
        Me.Check.IconRightZoom = 0R
        Me.Check.IconVisible = True
        Me.Check.IconZoom = 90.0R
        Me.Check.IsTab = False
        Me.Check.Location = New System.Drawing.Point(0, 0)
        Me.Check.Name = "Check"
        Me.Check.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Check.OnHoverTextColor = System.Drawing.Color.White
        Me.Check.selected = False
        Me.Check.Size = New System.Drawing.Size(241, 66)
        Me.Check.TabIndex = 0
        Me.Check.Text = "Patient Diagnosis"
        Me.Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Check.Textcolor = System.Drawing.Color.White
        Me.Check.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.Check, "This button allows Doctor to write a new patient report (diagnosis) ,procedures a" &
        "nd cost.")
        '
        'emp_name_lbl
        '
        Me.emp_name_lbl.AutoSize = True
        Me.emp_name_lbl.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.emp_name_lbl.Location = New System.Drawing.Point(304, 14)
        Me.emp_name_lbl.Name = "emp_name_lbl"
        Me.emp_name_lbl.Size = New System.Drawing.Size(148, 23)
        Me.emp_name_lbl.TabIndex = 0
        Me.emp_name_lbl.Text = "Doctor Name :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.clinic_administrator.My.Resources.Resources.clipart5780242
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel7.Controls.Add(Me.emp_name_lbl_1)
        Me.Panel7.Controls.Add(Me.emp_ID_lbl)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.emp_name_lbl)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(241, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(894, 58)
        Me.Panel7.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1135, 569)
        Me.Panel2.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(241, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(894, 569)
        Me.Panel6.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 569)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Panel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 32)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(475, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dr. Eyad Abusalah Clinic"
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
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Panel1
        Me.BunifuDragControl2.Vertical = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Patient Diagnosis"
        '
        'ToolTip2
        '
        Me.ToolTip2.ToolTipTitle = "Patient History"
        '
        'frm_doctor_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 601)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_doctor_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_doctor_new"
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents emp_name_lbl_1 As Label
    Friend WithEvents emp_ID_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents emp_name_lbl As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Logout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents my_appointments As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents history As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Check As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
End Class
