<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_emp_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(update_emp_control))
        Me.Role_txt = New System.Windows.Forms.TextBox()
        Me.Dept_txt = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.updated_pass = New System.Windows.Forms.TextBox()
        Me.updated_mail = New System.Windows.Forms.TextBox()
        Me.updated_name = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Emp_pass = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Emp_mail = New System.Windows.Forms.TextBox()
        Me.emp_nam = New System.Windows.Forms.TextBox()
        Me.emp_ID = New System.Windows.Forms.TextBox()
        Me.update_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.updated_dept = New Bunifu.Framework.UI.BunifuDropdown()
        Me.updated_Role = New Bunifu.Framework.UI.BunifuDropdown()
        Me.wipe = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Role_txt
        '
        Me.Role_txt.Location = New System.Drawing.Point(273, 390)
        Me.Role_txt.Multiline = True
        Me.Role_txt.Name = "Role_txt"
        Me.Role_txt.ReadOnly = True
        Me.Role_txt.Size = New System.Drawing.Size(270, 29)
        Me.Role_txt.TabIndex = 65
        '
        'Dept_txt
        '
        Me.Dept_txt.Location = New System.Drawing.Point(273, 336)
        Me.Dept_txt.Multiline = True
        Me.Dept_txt.Name = "Dept_txt"
        Me.Dept_txt.ReadOnly = True
        Me.Dept_txt.Size = New System.Drawing.Size(270, 28)
        Me.Dept_txt.TabIndex = 64
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(19, 387)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(169, 29)
        Me.BunifuCustomLabel7.TabIndex = 62
        Me.BunifuCustomLabel7.Text = "Employee Role"
        '
        'updated_pass
        '
        Me.updated_pass.Location = New System.Drawing.Point(566, 285)
        Me.updated_pass.Multiline = True
        Me.updated_pass.Name = "updated_pass"
        Me.updated_pass.Size = New System.Drawing.Size(270, 28)
        Me.updated_pass.TabIndex = 60
        '
        'updated_mail
        '
        Me.updated_mail.Location = New System.Drawing.Point(566, 235)
        Me.updated_mail.Multiline = True
        Me.updated_mail.Name = "updated_mail"
        Me.updated_mail.Size = New System.Drawing.Size(270, 28)
        Me.updated_mail.TabIndex = 59
        '
        'updated_name
        '
        Me.updated_name.Location = New System.Drawing.Point(566, 183)
        Me.updated_name.Multiline = True
        Me.updated_name.Name = "updated_name"
        Me.updated_name.Size = New System.Drawing.Size(270, 28)
        Me.updated_name.TabIndex = 58
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(19, 337)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(249, 29)
        Me.BunifuCustomLabel6.TabIndex = 57
        Me.BunifuCustomLabel6.Text = "Employee Department"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(19, 287)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(224, 29)
        Me.BunifuCustomLabel5.TabIndex = 56
        Me.BunifuCustomLabel5.Text = "Employee Password"
        '
        'Emp_pass
        '
        Me.Emp_pass.Location = New System.Drawing.Point(273, 285)
        Me.Emp_pass.Multiline = True
        Me.Emp_pass.Name = "Emp_pass"
        Me.Emp_pass.ReadOnly = True
        Me.Emp_pass.Size = New System.Drawing.Size(270, 28)
        Me.Emp_pass.TabIndex = 55
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(19, 232)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(179, 29)
        Me.BunifuCustomLabel4.TabIndex = 54
        Me.BunifuCustomLabel4.Text = "Employee Email"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(19, 181)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(182, 29)
        Me.BunifuCustomLabel3.TabIndex = 53
        Me.BunifuCustomLabel3.Text = "Employee name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(19, 133)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(148, 29)
        Me.BunifuCustomLabel2.TabIndex = 52
        Me.BunifuCustomLabel2.Text = "Employee ID"
        '
        'Emp_mail
        '
        Me.Emp_mail.Location = New System.Drawing.Point(273, 235)
        Me.Emp_mail.Multiline = True
        Me.Emp_mail.Name = "Emp_mail"
        Me.Emp_mail.ReadOnly = True
        Me.Emp_mail.Size = New System.Drawing.Size(270, 28)
        Me.Emp_mail.TabIndex = 51
        '
        'emp_nam
        '
        Me.emp_nam.Location = New System.Drawing.Point(273, 183)
        Me.emp_nam.Multiline = True
        Me.emp_nam.Name = "emp_nam"
        Me.emp_nam.ReadOnly = True
        Me.emp_nam.Size = New System.Drawing.Size(270, 28)
        Me.emp_nam.TabIndex = 50
        '
        'emp_ID
        '
        Me.emp_ID.Location = New System.Drawing.Point(273, 134)
        Me.emp_ID.Multiline = True
        Me.emp_ID.Name = "emp_ID"
        Me.emp_ID.Size = New System.Drawing.Size(270, 28)
        Me.emp_ID.TabIndex = 49
        '
        'update_btn
        '
        Me.update_btn.ActiveBorderThickness = 1
        Me.update_btn.ActiveCornerRadius = 60
        Me.update_btn.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.update_btn.ActiveForecolor = System.Drawing.Color.White
        Me.update_btn.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.update_btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.update_btn.BackgroundImage = CType(resources.GetObject("update_btn.BackgroundImage"), System.Drawing.Image)
        Me.update_btn.ButtonText = "Update"
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.update_btn.ForeColor = System.Drawing.Color.SeaGreen
        Me.update_btn.IdleBorderThickness = 1
        Me.update_btn.IdleCornerRadius = 50
        Me.update_btn.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.update_btn.IdleForecolor = System.Drawing.Color.White
        Me.update_btn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.update_btn.Location = New System.Drawing.Point(566, 468)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(226, 65)
        Me.update_btn.TabIndex = 68
        Me.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'updated_dept
        '
        Me.updated_dept.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.updated_dept.BorderRadius = 3
        Me.updated_dept.ForeColor = System.Drawing.Color.White
        Me.updated_dept.Items = New String(-1) {}
        Me.updated_dept.Location = New System.Drawing.Point(566, 335)
        Me.updated_dept.Name = "updated_dept"
        Me.updated_dept.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.updated_dept.onHoverColor = System.Drawing.Color.SteelBlue
        Me.updated_dept.selectedIndex = -1
        Me.updated_dept.Size = New System.Drawing.Size(270, 35)
        Me.updated_dept.TabIndex = 66
        '
        'updated_Role
        '
        Me.updated_Role.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.updated_Role.BorderRadius = 3
        Me.updated_Role.ForeColor = System.Drawing.Color.White
        Me.updated_Role.Items = New String(-1) {}
        Me.updated_Role.Location = New System.Drawing.Point(566, 385)
        Me.updated_Role.Name = "updated_Role"
        Me.updated_Role.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.updated_Role.onHoverColor = System.Drawing.Color.SteelBlue
        Me.updated_Role.selectedIndex = -1
        Me.updated_Role.Size = New System.Drawing.Size(270, 35)
        Me.updated_Role.TabIndex = 67
        '
        'wipe
        '
        Me.wipe.ActiveBorderThickness = 1
        Me.wipe.ActiveCornerRadius = 60
        Me.wipe.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.wipe.ActiveForecolor = System.Drawing.Color.White
        Me.wipe.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.wipe.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.wipe.BackgroundImage = CType(resources.GetObject("wipe.BackgroundImage"), System.Drawing.Image)
        Me.wipe.ButtonText = "Clear"
        Me.wipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.wipe.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.wipe.ForeColor = System.Drawing.Color.SeaGreen
        Me.wipe.IdleBorderThickness = 1
        Me.wipe.IdleCornerRadius = 50
        Me.wipe.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.wipe.IdleForecolor = System.Drawing.Color.White
        Me.wipe.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.wipe.Location = New System.Drawing.Point(295, 468)
        Me.wipe.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.wipe.Name = "wipe"
        Me.wipe.Size = New System.Drawing.Size(226, 65)
        Me.wipe.TabIndex = 69
        Me.wipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'update_emp_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.wipe)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.updated_Role)
        Me.Controls.Add(Me.updated_dept)
        Me.Controls.Add(Me.Role_txt)
        Me.Controls.Add(Me.Dept_txt)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.updated_pass)
        Me.Controls.Add(Me.updated_mail)
        Me.Controls.Add(Me.updated_name)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.Emp_pass)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.Emp_mail)
        Me.Controls.Add(Me.emp_nam)
        Me.Controls.Add(Me.emp_ID)
        Me.Name = "update_emp_control"
        Me.Size = New System.Drawing.Size(1181, 658)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Role_txt As TextBox
    Friend WithEvents Dept_txt As TextBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents updated_pass As TextBox
    Friend WithEvents updated_mail As TextBox
    Friend WithEvents updated_name As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Emp_pass As TextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Emp_mail As TextBox
    Friend WithEvents emp_nam As TextBox
    Friend WithEvents emp_ID As TextBox
    Friend WithEvents update_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents updated_dept As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents updated_Role As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents wipe As Bunifu.Framework.UI.BunifuThinButton2
End Class
