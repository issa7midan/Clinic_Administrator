<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nurse_set_appointments_control
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nurse_set_appointments_control))
        Me.Doc_IDD = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pat_ID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Check = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Doc_ID = New System.Windows.Forms.TextBox()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Doc_IDD
        '
        Me.Doc_IDD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Doc_IDD.Location = New System.Drawing.Point(214, 3)
        Me.Doc_IDD.Multiline = True
        Me.Doc_IDD.Name = "Doc_IDD"
        Me.Doc_IDD.ReadOnly = True
        Me.Doc_IDD.Size = New System.Drawing.Size(235, 28)
        Me.Doc_IDD.TabIndex = 86
        Me.Doc_IDD.Visible = False
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(38, 3)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(116, 29)
        Me.BunifuCustomLabel10.TabIndex = 85
        Me.BunifuCustomLabel10.Text = "Doctor ID"
        Me.BunifuCustomLabel10.Visible = False
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(28, 325)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(170, 24)
        Me.BunifuCustomLabel8.TabIndex = 83
        Me.BunifuCustomLabel8.Text = "Appointment date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DateTimePicker1.Location = New System.Drawing.Point(209, 324)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(235, 28)
        Me.DateTimePicker1.TabIndex = 82
        Me.DateTimePicker1.Value = New Date(2020, 11, 10, 0, 0, 0, 0)
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(26, 216)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(153, 29)
        Me.BunifuCustomLabel9.TabIndex = 80
        Me.BunifuCustomLabel9.Text = "Doctor Name"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(26, 172)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(156, 29)
        Me.BunifuCustomLabel6.TabIndex = 79
        Me.BunifuCustomLabel6.Text = "Patient Name"
        '
        'Pat_ID
        '
        Me.Pat_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pat_ID.Location = New System.Drawing.Point(208, 129)
        Me.Pat_ID.Multiline = True
        Me.Pat_ID.Name = "Pat_ID"
        Me.Pat_ID.Size = New System.Drawing.Size(235, 28)
        Me.Pat_ID.TabIndex = 77
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(26, 127)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(119, 29)
        Me.BunifuCustomLabel7.TabIndex = 76
        Me.BunifuCustomLabel7.Text = "Patient ID"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(215, 76)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(229, 29)
        Me.BunifuCustomLabel5.TabIndex = 75
        Me.BunifuCustomLabel5.Text = "Pick an Appointment"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(657, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(235, 172)
        Me.DataGridView1.TabIndex = 93
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(656, 76)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(228, 29)
        Me.BunifuCustomLabel2.TabIndex = 88
        Me.BunifuCustomLabel2.Text = "Check Appointments"
        '
        'Check
        '
        Me.Check.ActiveBorderThickness = 1
        Me.Check.ActiveCornerRadius = 60
        Me.Check.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Check.ActiveForecolor = System.Drawing.Color.White
        Me.Check.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Check.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Check.BackgroundImage = CType(resources.GetObject("Check.BackgroundImage"), System.Drawing.Image)
        Me.Check.ButtonText = "Check doctor appointments"
        Me.Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Check.ForeColor = System.Drawing.Color.SeaGreen
        Me.Check.IdleBorderThickness = 1
        Me.Check.IdleCornerRadius = 50
        Me.Check.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Check.IdleForecolor = System.Drawing.Color.White
        Me.Check.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check.Location = New System.Drawing.Point(671, 371)
        Me.Check.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(207, 67)
        Me.Check.TabIndex = 94
        Me.Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Check, "This button allows to check doctors appointments after picking a doctor name from" &
        " the droplist." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You should use this before booking a new appointment.")
        '
        'Clear
        '
        Me.Clear.ActiveBorderThickness = 1
        Me.Clear.ActiveCornerRadius = 60
        Me.Clear.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Clear.ActiveForecolor = System.Drawing.Color.White
        Me.Clear.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Clear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Clear.BackgroundImage = CType(resources.GetObject("Clear.BackgroundImage"), System.Drawing.Image)
        Me.Clear.ButtonText = "Clear"
        Me.Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Clear.ForeColor = System.Drawing.Color.SeaGreen
        Me.Clear.IdleBorderThickness = 1
        Me.Clear.IdleCornerRadius = 50
        Me.Clear.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Clear.IdleForecolor = System.Drawing.Color.White
        Me.Clear.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Clear.Location = New System.Drawing.Point(31, 448)
        Me.Clear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(207, 67)
        Me.Clear.TabIndex = 95
        Me.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 60
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Set appointment"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 50
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(225, 371)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(207, 67)
        Me.BunifuThinButton22.TabIndex = 96
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuDropdown1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(208, 216)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.SteelBlue
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(235, 35)
        Me.BunifuDropdown1.TabIndex = 97
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(208, 174)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 28)
        Me.TextBox1.TabIndex = 98
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 1
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "check"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 1
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(452, 170)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(80, 35)
        Me.BunifuThinButton21.TabIndex = 99
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Doc_ID
        '
        Me.Doc_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Doc_ID.Location = New System.Drawing.Point(668, 3)
        Me.Doc_ID.Multiline = True
        Me.Doc_ID.Name = "Doc_ID"
        Me.Doc_ID.Size = New System.Drawing.Size(235, 28)
        Me.Doc_ID.TabIndex = 91
        Me.Doc_ID.Visible = False
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuDropdown2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuDropdown2.BorderRadius = 3
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String(-1) {}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(655, 127)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.SteelBlue
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(235, 35)
        Me.BunifuDropdown2.TabIndex = 100
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(537, 127)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(112, 29)
        Me.BunifuCustomLabel3.TabIndex = 101
        Me.BunifuCustomLabel3.Text = "Dr. name"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Check doctor appointments"
        '
        'nurse_set_appointments_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuDropdown2)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Doc_ID)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.Doc_IDD)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.Pat_ID)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Name = "nurse_set_appointments_control"
        Me.Size = New System.Drawing.Size(1139, 592)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Doc_IDD As TextBox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pat_ID As TextBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Check As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Clear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Doc_ID As TextBox
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
End Class
