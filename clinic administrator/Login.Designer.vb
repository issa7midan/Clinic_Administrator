<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.txt_Email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_Pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.logon_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Email
        '
        Me.txt_Email.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Email.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Email.HintForeColor = System.Drawing.Color.Empty
        Me.txt_Email.HintText = ""
        Me.txt_Email.isPassword = False
        Me.txt_Email.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_Email.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_Email.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_Email.LineThickness = 3
        Me.txt_Email.Location = New System.Drawing.Point(759, 254)
        Me.txt_Email.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.Size = New System.Drawing.Size(314, 34)
        Me.txt_Email.TabIndex = 10
        Me.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_Pass
        '
        Me.txt_Pass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Pass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_Pass.HintForeColor = System.Drawing.Color.Empty
        Me.txt_Pass.HintText = "Password"
        Me.txt_Pass.isPassword = True
        Me.txt_Pass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_Pass.LineIdleColor = System.Drawing.Color.Gray
        Me.txt_Pass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_Pass.LineThickness = 3
        Me.txt_Pass.Location = New System.Drawing.Point(759, 341)
        Me.txt_Pass.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Pass.Name = "txt_Pass"
        Me.txt_Pass.Size = New System.Drawing.Size(314, 36)
        Me.txt_Pass.TabIndex = 11
        Me.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(605, 267)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(59, 24)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "Email"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(605, 353)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(94, 24)
        Me.BunifuCustomLabel2.TabIndex = 13
        Me.BunifuCustomLabel2.Text = "Password"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = False
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Tahoma", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(810, 168)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(143, 52)
        Me.BunifuCustomLabel7.TabIndex = 87
        Me.BunifuCustomLabel7.Text = "Login"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(123, 371)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(271, 183)
        Me.Panel3.TabIndex = 86
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(0, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(243, 219)
        Me.Panel1.TabIndex = 86
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(266, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 219)
        Me.Panel2.TabIndex = 85
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.PowderBlue
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.RoyalBlue
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DarkBlue
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1130, 96)
        Me.BunifuGradientPanel2.TabIndex = 83
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Info
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(352, 25)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(385, 48)
        Me.BunifuCustomLabel5.TabIndex = 87
        Me.BunifuCustomLabel5.Text = "Eyad AbuSalah Clinic"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.clinic_administrator.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(1071, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.PowderBlue
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkBlue
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 560)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1130, 66)
        Me.BunifuGradientPanel1.TabIndex = 82
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton3.ErrorImage = CType(resources.GetObject("BunifuImageButton3.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Global.clinic_administrator.My.Resources.Resources.locate_location_map_location_marker_location_pin_location_tracker_1320086034839105915
        Me.BunifuImageButton3.InitialImage = CType(resources.GetObject("BunifuImageButton3.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton3.Location = New System.Drawing.Point(759, 12)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(51, 42)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 79
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 0
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(311, 23)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(171, 24)
        Me.BunifuCustomLabel4.TabIndex = 78
        Me.BunifuCustomLabel4.Text = "fb.com/eyad.clinic"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(560, 23)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(157, 24)
        Me.BunifuCustomLabel3.TabIndex = 77
        Me.BunifuCustomLabel3.Text = "+962799263275"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImage = Global.clinic_administrator.My.Resources.Resources.facebook_outline_social_media_icon_1320193495573517082
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(254, 12)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(51, 42)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 75
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImage = Global.clinic_administrator.My.Resources.Resources.chat_communication_internet_online_web_whatsapp_icon_1320193494394736262
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(503, 12)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(51, 42)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 76
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(816, 23)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(85, 24)
        Me.BunifuCustomLabel6.TabIndex = 81
        Me.BunifuCustomLabel6.Text = "Location"
        '
        'logon_btn
        '
        Me.logon_btn.ActiveBorderThickness = 1
        Me.logon_btn.ActiveCornerRadius = 60
        Me.logon_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.logon_btn.ActiveForecolor = System.Drawing.Color.White
        Me.logon_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.logon_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logon_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.logon_btn.BackgroundImage = CType(resources.GetObject("logon_btn.BackgroundImage"), System.Drawing.Image)
        Me.logon_btn.ButtonText = "Login"
        Me.logon_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logon_btn.Font = New System.Drawing.Font("Century Gothic", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logon_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.logon_btn.IdleBorderThickness = 1
        Me.logon_btn.IdleCornerRadius = 50
        Me.logon_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.logon_btn.IdleForecolor = System.Drawing.Color.White
        Me.logon_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.logon_btn.Location = New System.Drawing.Point(800, 416)
        Me.logon_btn.Margin = New System.Windows.Forms.Padding(7)
        Me.logon_btn.Name = "logon_btn"
        Me.logon_btn.Size = New System.Drawing.Size(197, 66)
        Me.logon_btn.TabIndex = 69
        Me.logon_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1130, 626)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.logon_btn)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txt_Pass)
        Me.Controls.Add(Me.txt_Email)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_Pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Public WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents logon_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel3 As Panel
End Class
