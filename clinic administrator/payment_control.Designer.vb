<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment_control))
        Me.Payment_ID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Payment_txt = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Payment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pat_ID = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Confirm = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Report_Number = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Payment_ID
        '
        Me.Payment_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Payment_ID.Location = New System.Drawing.Point(395, 293)
        Me.Payment_ID.Multiline = True
        Me.Payment_ID.Name = "Payment_ID"
        Me.Payment_ID.ReadOnly = True
        Me.Payment_ID.Size = New System.Drawing.Size(235, 28)
        Me.Payment_ID.TabIndex = 62
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(205, 289)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(138, 29)
        Me.BunifuCustomLabel3.TabIndex = 61
        Me.BunifuCustomLabel3.Text = "Payment ID"
        '
        'Payment_txt
        '
        Me.Payment_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Payment_txt.Location = New System.Drawing.Point(395, 242)
        Me.Payment_txt.Multiline = True
        Me.Payment_txt.Name = "Payment_txt"
        Me.Payment_txt.Size = New System.Drawing.Size(235, 28)
        Me.Payment_txt.TabIndex = 60
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(205, 238)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(105, 29)
        Me.BunifuCustomLabel1.TabIndex = 58
        Me.BunifuCustomLabel1.Text = "Payment"
        '
        'Payment
        '
        Me.Payment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Payment.AutoSize = True
        Me.Payment.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.Location = New System.Drawing.Point(205, 155)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(156, 29)
        Me.Payment.TabIndex = 57
        Me.Payment.Text = "Patient Name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(205, 112)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(175, 29)
        Me.BunifuCustomLabel2.TabIndex = 56
        Me.BunifuCustomLabel2.Text = "Patient number"
        '
        'pat_ID
        '
        Me.pat_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_ID.Location = New System.Drawing.Point(395, 122)
        Me.pat_ID.Multiline = True
        Me.pat_ID.Name = "pat_ID"
        Me.pat_ID.Size = New System.Drawing.Size(235, 28)
        Me.pat_ID.TabIndex = 55
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
        Me.BunifuThinButton21.ButtonText = "Clear"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 50
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuThinButton21.Location = New System.Drawing.Point(231, 387)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(192, 65)
        Me.BunifuThinButton21.TabIndex = 76
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Confirm
        '
        Me.Confirm.ActiveBorderThickness = 1
        Me.Confirm.ActiveCornerRadius = 60
        Me.Confirm.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Confirm.ActiveForecolor = System.Drawing.Color.White
        Me.Confirm.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Confirm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Confirm.BackgroundImage = CType(resources.GetObject("Confirm.BackgroundImage"), System.Drawing.Image)
        Me.Confirm.ButtonText = "Confirm payment"
        Me.Confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confirm.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Confirm.ForeColor = System.Drawing.Color.SeaGreen
        Me.Confirm.IdleBorderThickness = 1
        Me.Confirm.IdleCornerRadius = 50
        Me.Confirm.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Confirm.IdleForecolor = System.Drawing.Color.White
        Me.Confirm.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Confirm.Location = New System.Drawing.Point(465, 387)
        Me.Confirm.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(192, 65)
        Me.Confirm.TabIndex = 75
        Me.Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Report_Number
        '
        Me.Report_Number.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Report_Number.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Report_Number.BorderRadius = 3
        Me.Report_Number.ForeColor = System.Drawing.Color.White
        Me.Report_Number.Items = New String(-1) {}
        Me.Report_Number.Location = New System.Drawing.Point(396, 193)
        Me.Report_Number.Name = "Report_Number"
        Me.Report_Number.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.Report_Number.onHoverColor = System.Drawing.Color.SteelBlue
        Me.Report_Number.selectedIndex = -1
        Me.Report_Number.Size = New System.Drawing.Size(234, 35)
        Me.Report_Number.TabIndex = 78
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(205, 195)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(114, 29)
        Me.BunifuCustomLabel4.TabIndex = 77
        Me.BunifuCustomLabel4.Text = "Visit Date"
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
        Me.BunifuThinButton22.Location = New System.Drawing.Point(639, 153)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(134, 38)
        Me.BunifuThinButton22.TabIndex = 84
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.TextBox1.Location = New System.Drawing.Point(396, 156)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 28)
        Me.TextBox1.TabIndex = 85
        '
        'payment_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Report_Number)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Payment_ID)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Payment_txt)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Payment)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.pat_ID)
        Me.Name = "payment_control"
        Me.Size = New System.Drawing.Size(961, 546)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Payment_ID As TextBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Payment_txt As TextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Payment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pat_ID As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Confirm As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Report_Number As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox1 As TextBox
End Class
