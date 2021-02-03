<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pat_reg_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pat_reg_control))
        Me.Date_pick = New System.Windows.Forms.DateTimePicker()
        Me.pat_ID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pat_phone = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pat_name = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Reg = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Date_pick
        '
        Me.Date_pick.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_pick.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.Date_pick.Location = New System.Drawing.Point(486, 159)
        Me.Date_pick.MinDate = New Date(1930, 12, 31, 0, 0, 0, 0)
        Me.Date_pick.Name = "Date_pick"
        Me.Date_pick.Size = New System.Drawing.Size(271, 28)
        Me.Date_pick.TabIndex = 69
        Me.Date_pick.Value = New Date(2020, 11, 10, 0, 0, 0, 0)
        '
        'pat_ID
        '
        Me.pat_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_ID.Location = New System.Drawing.Point(486, 268)
        Me.pat_ID.Multiline = True
        Me.pat_ID.Name = "pat_ID"
        Me.pat_ID.ReadOnly = True
        Me.pat_ID.Size = New System.Drawing.Size(271, 28)
        Me.pat_ID.TabIndex = 67
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(205, 262)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(119, 29)
        Me.BunifuCustomLabel4.TabIndex = 66
        Me.BunifuCustomLabel4.Text = "Patient ID"
        '
        'pat_phone
        '
        Me.pat_phone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_phone.Location = New System.Drawing.Point(486, 211)
        Me.pat_phone.Multiline = True
        Me.pat_phone.Name = "pat_phone"
        Me.pat_phone.Size = New System.Drawing.Size(271, 28)
        Me.pat_phone.TabIndex = 65
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(205, 205)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(248, 29)
        Me.BunifuCustomLabel3.TabIndex = 64
        Me.BunifuCustomLabel3.Text = "Patient phone number"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(205, 153)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(229, 29)
        Me.BunifuCustomLabel1.TabIndex = 63
        Me.BunifuCustomLabel1.Text = "Patient Date of birth"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(205, 112)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(156, 29)
        Me.BunifuCustomLabel2.TabIndex = 62
        Me.BunifuCustomLabel2.Text = "Patient Name"
        '
        'pat_name
        '
        Me.pat_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_name.Location = New System.Drawing.Point(486, 112)
        Me.pat_name.Multiline = True
        Me.pat_name.Name = "pat_name"
        Me.pat_name.Size = New System.Drawing.Size(271, 28)
        Me.pat_name.TabIndex = 61
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(269, 343)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(205, 70)
        Me.BunifuThinButton21.TabIndex = 71
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Reg
        '
        Me.Reg.ActiveBorderThickness = 1
        Me.Reg.ActiveCornerRadius = 60
        Me.Reg.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Reg.ActiveForecolor = System.Drawing.Color.White
        Me.Reg.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Reg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reg.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Reg.BackgroundImage = CType(resources.GetObject("Reg.BackgroundImage"), System.Drawing.Image)
        Me.Reg.ButtonText = "Register patient"
        Me.Reg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Reg.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Reg.ForeColor = System.Drawing.Color.SeaGreen
        Me.Reg.IdleBorderThickness = 1
        Me.Reg.IdleCornerRadius = 50
        Me.Reg.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Reg.IdleForecolor = System.Drawing.Color.White
        Me.Reg.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Reg.Location = New System.Drawing.Point(486, 343)
        Me.Reg.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Reg.Name = "Reg"
        Me.Reg.Size = New System.Drawing.Size(205, 70)
        Me.Reg.TabIndex = 72
        Me.Reg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pat_reg_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.Reg)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Date_pick)
        Me.Controls.Add(Me.pat_ID)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.pat_phone)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.pat_name)
        Me.Name = "pat_reg_control"
        Me.Size = New System.Drawing.Size(961, 546)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Date_pick As DateTimePicker
    Friend WithEvents pat_ID As TextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pat_phone As TextBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pat_name As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Reg As Bunifu.Framework.UI.BunifuThinButton2
End Class
