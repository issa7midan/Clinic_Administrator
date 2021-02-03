<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports_control
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
        Me.Amount_lb = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Amount_lb
        '
        Me.Amount_lb.AutoSize = True
        Me.Amount_lb.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.Amount_lb.Location = New System.Drawing.Point(256, 297)
        Me.Amount_lb.Name = "Amount_lb"
        Me.Amount_lb.Size = New System.Drawing.Size(0, 29)
        Me.Amount_lb.TabIndex = 55
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(125, 297)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(110, 29)
        Me.BunifuCustomLabel3.TabIndex = 54
        Me.BunifuCustomLabel3.Text = "Amount :"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(130, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(555, 160)
        Me.DataGridView1.TabIndex = 53
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuDropdown1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(691, 112)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.SteelBlue
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(366, 35)
        Me.BunifuDropdown1.TabIndex = 67
        '
        'Reports_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.Amount_lb)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Reports_control"
        Me.Size = New System.Drawing.Size(1113, 546)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Amount_lb As Label
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
End Class
