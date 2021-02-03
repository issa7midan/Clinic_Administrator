<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register_control))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listDept = New Bunifu.Framework.UI.BunifuDropdown()
        Me.listRole = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_emp_mail = New System.Windows.Forms.TextBox()
        Me.txt_empName = New System.Windows.Forms.TextBox()
        Me.reged_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label5.Location = New System.Drawing.Point(205, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 28)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Department"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label1.Location = New System.Drawing.Point(205, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 28)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Role"
        '
        'listDept
        '
        Me.listDept.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listDept.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listDept.BorderRadius = 3
        Me.listDept.ForeColor = System.Drawing.Color.White
        Me.listDept.Items = New String(-1) {}
        Me.listDept.Location = New System.Drawing.Point(386, 327)
        Me.listDept.Name = "listDept"
        Me.listDept.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.listDept.onHoverColor = System.Drawing.Color.SteelBlue
        Me.listDept.selectedIndex = -1
        Me.listDept.Size = New System.Drawing.Size(235, 35)
        Me.listDept.TabIndex = 23
        '
        'listRole
        '
        Me.listRole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listRole.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.listRole.BorderRadius = 3
        Me.listRole.ForeColor = System.Drawing.Color.White
        Me.listRole.Items = New String(-1) {}
        Me.listRole.Location = New System.Drawing.Point(386, 266)
        Me.listRole.Name = "listRole"
        Me.listRole.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.listRole.onHoverColor = System.Drawing.Color.SteelBlue
        Me.listRole.selectedIndex = -1
        Me.listRole.Size = New System.Drawing.Size(235, 35)
        Me.listRole.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label4.Location = New System.Drawing.Point(205, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 28)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label3.Location = New System.Drawing.Point(205, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 28)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label2.Location = New System.Drawing.Point(205, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 28)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Employee Name"
        '
        'txt_pass
        '
        Me.txt_pass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_pass.Location = New System.Drawing.Point(386, 219)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(235, 28)
        Me.txt_pass.TabIndex = 18
        '
        'txt_emp_mail
        '
        Me.txt_emp_mail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_emp_mail.Location = New System.Drawing.Point(386, 162)
        Me.txt_emp_mail.Multiline = True
        Me.txt_emp_mail.Name = "txt_emp_mail"
        Me.txt_emp_mail.Size = New System.Drawing.Size(235, 28)
        Me.txt_emp_mail.TabIndex = 17
        '
        'txt_empName
        '
        Me.txt_empName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_empName.Location = New System.Drawing.Point(386, 112)
        Me.txt_empName.Multiline = True
        Me.txt_empName.Name = "txt_empName"
        Me.txt_empName.Size = New System.Drawing.Size(235, 28)
        Me.txt_empName.TabIndex = 16
        '
        'reged_btn
        '
        Me.reged_btn.ActiveBorderThickness = 1
        Me.reged_btn.ActiveCornerRadius = 60
        Me.reged_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.reged_btn.ActiveForecolor = System.Drawing.Color.White
        Me.reged_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.reged_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reged_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.reged_btn.BackgroundImage = CType(resources.GetObject("reged_btn.BackgroundImage"), System.Drawing.Image)
        Me.reged_btn.ButtonText = "Register"
        Me.reged_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reged_btn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.reged_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.reged_btn.IdleBorderThickness = 1
        Me.reged_btn.IdleCornerRadius = 50
        Me.reged_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.reged_btn.IdleForecolor = System.Drawing.Color.White
        Me.reged_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.reged_btn.Location = New System.Drawing.Point(397, 398)
        Me.reged_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.reged_btn.Name = "reged_btn"
        Me.reged_btn.Size = New System.Drawing.Size(205, 70)
        Me.reged_btn.TabIndex = 26
        Me.reged_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Register_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.reged_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listDept)
        Me.Controls.Add(Me.listRole)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_emp_mail)
        Me.Controls.Add(Me.txt_empName)
        Me.Name = "Register_control"
        Me.Size = New System.Drawing.Size(863, 511)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents listDept As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents listRole As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_emp_mail As TextBox
    Friend WithEvents txt_empName As TextBox
    Friend WithEvents reged_btn As Bunifu.Framework.UI.BunifuThinButton2
End Class
