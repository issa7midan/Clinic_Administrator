<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_roles_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_roles_control))
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Role_ID = New System.Windows.Forms.TextBox()
        Me.Role_name = New System.Windows.Forms.TextBox()
        Me.Add_Role = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(214, 253)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(92, 29)
        Me.BunifuCustomLabel3.TabIndex = 55
        Me.BunifuCustomLabel3.Text = "Role ID"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(214, 192)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(129, 29)
        Me.BunifuCustomLabel1.TabIndex = 53
        Me.BunifuCustomLabel1.Text = "Role Name"
        '
        'Role_ID
        '
        Me.Role_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Role_ID.Location = New System.Drawing.Point(372, 254)
        Me.Role_ID.Multiline = True
        Me.Role_ID.Name = "Role_ID"
        Me.Role_ID.Size = New System.Drawing.Size(235, 28)
        Me.Role_ID.TabIndex = 52
        '
        'Role_name
        '
        Me.Role_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Role_name.Location = New System.Drawing.Point(372, 193)
        Me.Role_name.Multiline = True
        Me.Role_name.Name = "Role_name"
        Me.Role_name.Size = New System.Drawing.Size(235, 28)
        Me.Role_name.TabIndex = 51
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
        Me.Add_Role.ButtonText = "Add Role"
        Me.Add_Role.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Role.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Add_Role.ForeColor = System.Drawing.Color.SeaGreen
        Me.Add_Role.IdleBorderThickness = 1
        Me.Add_Role.IdleCornerRadius = 50
        Me.Add_Role.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Add_Role.IdleForecolor = System.Drawing.Color.White
        Me.Add_Role.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Add_Role.Location = New System.Drawing.Point(458, 339)
        Me.Add_Role.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Add_Role.Name = "Add_Role"
        Me.Add_Role.Size = New System.Drawing.Size(192, 65)
        Me.Add_Role.TabIndex = 73
        Me.Add_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.clear.Location = New System.Drawing.Point(232, 339)
        Me.clear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(192, 65)
        Me.clear.TabIndex = 74
        Me.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_roles_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Add_Role)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Role_ID)
        Me.Controls.Add(Me.Role_name)
        Me.Name = "add_roles_control"
        Me.Size = New System.Drawing.Size(961, 546)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Role_ID As TextBox
    Friend WithEvents Role_name As TextBox
    Friend WithEvents Add_Role As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents clear As Bunifu.Framework.UI.BunifuThinButton2
End Class
