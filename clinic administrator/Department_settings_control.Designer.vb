<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department_settings_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department_settings_control))
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Dept_ID = New System.Windows.Forms.TextBox()
        Me.Dept_name = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.disable_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Add_Role = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(214, 192)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(172, 29)
        Me.BunifuCustomLabel3.TabIndex = 48
        Me.BunifuCustomLabel3.Text = "Department ID"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(214, 239)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(209, 29)
        Me.BunifuCustomLabel1.TabIndex = 46
        Me.BunifuCustomLabel1.Text = "Department Name"
        '
        'Dept_ID
        '
        Me.Dept_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_ID.Location = New System.Drawing.Point(429, 193)
        Me.Dept_ID.Multiline = True
        Me.Dept_ID.Name = "Dept_ID"
        Me.Dept_ID.Size = New System.Drawing.Size(287, 28)
        Me.Dept_ID.TabIndex = 45
        '
        'Dept_name
        '
        Me.Dept_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_name.Location = New System.Drawing.Point(429, 240)
        Me.Dept_name.Multiline = True
        Me.Dept_name.Name = "Dept_name"
        Me.Dept_name.Size = New System.Drawing.Size(287, 28)
        Me.Dept_name.TabIndex = 44
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(298, 113)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(242, 29)
        Me.BunifuCustomLabel2.TabIndex = 43
        Me.BunifuCustomLabel2.Text = "Departments Settings"
        '
        'clear
        '
        Me.clear.ActiveBorderThickness = 1
        Me.clear.ActiveCornerRadius = 60
        Me.clear.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.clear.ActiveForecolor = System.Drawing.Color.White
        Me.clear.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.clear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.clear.BackgroundImage = CType(resources.GetObject("clear.BackgroundImage"), System.Drawing.Image)
        Me.clear.ButtonText = "Clear"
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.clear.ForeColor = System.Drawing.Color.SeaGreen
        Me.clear.IdleBorderThickness = 1
        Me.clear.IdleCornerRadius = 50
        Me.clear.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.clear.IdleForecolor = System.Drawing.Color.White
        Me.clear.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.clear.Location = New System.Drawing.Point(416, 421)
        Me.clear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(192, 65)
        Me.clear.TabIndex = 72
        Me.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 60
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Activate Department"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 50
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(179, 325)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(225, 65)
        Me.BunifuThinButton21.TabIndex = 71
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'disable_btn
        '
        Me.disable_btn.ActiveBorderThickness = 1
        Me.disable_btn.ActiveCornerRadius = 60
        Me.disable_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.disable_btn.ActiveForecolor = System.Drawing.Color.White
        Me.disable_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.disable_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.disable_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.disable_btn.BackgroundImage = CType(resources.GetObject("disable_btn.BackgroundImage"), System.Drawing.Image)
        Me.disable_btn.ButtonText = "Disable Department"
        Me.disable_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.disable_btn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.disable_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.disable_btn.IdleBorderThickness = 1
        Me.disable_btn.IdleCornerRadius = 50
        Me.disable_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.disable_btn.IdleForecolor = System.Drawing.Color.White
        Me.disable_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.disable_btn.Location = New System.Drawing.Point(383, 325)
        Me.disable_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.disable_btn.Name = "disable_btn"
        Me.disable_btn.Size = New System.Drawing.Size(225, 65)
        Me.disable_btn.TabIndex = 70
        Me.disable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add_Role
        '
        Me.Add_Role.ActiveBorderThickness = 1
        Me.Add_Role.ActiveCornerRadius = 60
        Me.Add_Role.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Add_Role.ActiveForecolor = System.Drawing.Color.White
        Me.Add_Role.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Add_Role.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add_Role.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Add_Role.BackgroundImage = CType(resources.GetObject("Add_Role.BackgroundImage"), System.Drawing.Image)
        Me.Add_Role.ButtonText = "Add Department"
        Me.Add_Role.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Role.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Add_Role.ForeColor = System.Drawing.Color.SeaGreen
        Me.Add_Role.IdleBorderThickness = 1
        Me.Add_Role.IdleCornerRadius = 50
        Me.Add_Role.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Add_Role.IdleForecolor = System.Drawing.Color.White
        Me.Add_Role.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Add_Role.Location = New System.Drawing.Point(587, 325)
        Me.Add_Role.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Add_Role.Name = "Add_Role"
        Me.Add_Role.Size = New System.Drawing.Size(225, 65)
        Me.Add_Role.TabIndex = 69
        Me.Add_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Department_settings_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.disable_btn)
        Me.Controls.Add(Me.Add_Role)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Dept_ID)
        Me.Controls.Add(Me.Dept_name)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Name = "Department_settings_control"
        Me.Size = New System.Drawing.Size(961, 592)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Dept_ID As TextBox
    Friend WithEvents Dept_name As TextBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Add_Role As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents disable_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents clear As Bunifu.Framework.UI.BunifuThinButton2
End Class
