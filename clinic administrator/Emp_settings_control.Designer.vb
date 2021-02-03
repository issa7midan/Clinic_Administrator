<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_settings_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_settings_control))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Activ_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.remove_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label3.Location = New System.Drawing.Point(214, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 28)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Employee Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 17.0!)
        Me.Label2.Location = New System.Drawing.Point(214, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 28)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Employee ID"
        '
        'txt_empID
        '
        Me.txt_empID.Location = New System.Drawing.Point(401, 192)
        Me.txt_empID.Multiline = True
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.Size = New System.Drawing.Size(235, 28)
        Me.txt_empID.TabIndex = 21
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(205, 112)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(462, 29)
        Me.BunifuCustomLabel1.TabIndex = 20
        Me.BunifuCustomLabel1.Text = "Remove an employee / Activate Employee"
        '
        'Activ_btn
        '
        Me.Activ_btn.ActiveBorderThickness = 1
        Me.Activ_btn.ActiveCornerRadius = 60
        Me.Activ_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Activ_btn.ActiveForecolor = System.Drawing.Color.White
        Me.Activ_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Activ_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Activ_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Activ_btn.BackgroundImage = CType(resources.GetObject("Activ_btn.BackgroundImage"), System.Drawing.Image)
        Me.Activ_btn.ButtonText = "Enable"
        Me.Activ_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Activ_btn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Activ_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.Activ_btn.IdleBorderThickness = 1
        Me.Activ_btn.IdleCornerRadius = 50
        Me.Activ_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Activ_btn.IdleForecolor = System.Drawing.Color.White
        Me.Activ_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Activ_btn.Location = New System.Drawing.Point(287, 314)
        Me.Activ_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Activ_btn.Name = "Activ_btn"
        Me.Activ_btn.Size = New System.Drawing.Size(154, 59)
        Me.Activ_btn.TabIndex = 27
        Me.Activ_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'remove_btn
        '
        Me.remove_btn.ActiveBorderThickness = 1
        Me.remove_btn.ActiveCornerRadius = 60
        Me.remove_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.remove_btn.ActiveForecolor = System.Drawing.Color.White
        Me.remove_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.remove_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.remove_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.remove_btn.BackgroundImage = CType(resources.GetObject("remove_btn.BackgroundImage"), System.Drawing.Image)
        Me.remove_btn.ButtonText = "Disable"
        Me.remove_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.remove_btn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.remove_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.remove_btn.IdleBorderThickness = 1
        Me.remove_btn.IdleCornerRadius = 50
        Me.remove_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.remove_btn.IdleForecolor = System.Drawing.Color.White
        Me.remove_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.remove_btn.Location = New System.Drawing.Point(507, 314)
        Me.remove_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.remove_btn.Name = "remove_btn"
        Me.remove_btn.Size = New System.Drawing.Size(160, 59)
        Me.remove_btn.TabIndex = 28
        Me.remove_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 1
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "check"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 1
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuThinButton22.Location = New System.Drawing.Point(657, 238)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(90, 40)
        Me.BunifuThinButton22.TabIndex = 84
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.TextBox1.Location = New System.Drawing.Point(401, 245)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 30)
        Me.TextBox1.TabIndex = 85
        '
        'Emp_settings_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.remove_btn)
        Me.Controls.Add(Me.Activ_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_empID)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "Emp_settings_control"
        Me.Size = New System.Drawing.Size(910, 467)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_empID As TextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Activ_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents remove_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox1 As TextBox
End Class
