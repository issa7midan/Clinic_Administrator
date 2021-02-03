<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pat_history_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pat_history_control))
        Me.Report = New System.Windows.Forms.TextBox()
        Me.doc_ID = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pat_ID = New System.Windows.Forms.TextBox()
        Me.Report_Number = New Bunifu.Framework.UI.BunifuDropdown()
        Me.update = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Clear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Doc_name = New System.Windows.Forms.TextBox()
        Me.proc = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cost = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SuspendLayout()
        '
        'Report
        '
        Me.Report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Report.Location = New System.Drawing.Point(226, 286)
        Me.Report.Multiline = True
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(234, 32)
        Me.Report.TabIndex = 66
        '
        'doc_ID
        '
        Me.doc_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doc_ID.Location = New System.Drawing.Point(226, 242)
        Me.doc_ID.Multiline = True
        Me.doc_ID.Name = "doc_ID"
        Me.doc_ID.ReadOnly = True
        Me.doc_ID.Size = New System.Drawing.Size(234, 28)
        Me.doc_ID.TabIndex = 65
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(21, 241)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(116, 29)
        Me.BunifuCustomLabel4.TabIndex = 64
        Me.BunifuCustomLabel4.Text = "Doctor ID"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(23, 150)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(156, 29)
        Me.BunifuCustomLabel1.TabIndex = 60
        Me.BunifuCustomLabel1.Text = "Patient Name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(23, 110)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(175, 29)
        Me.BunifuCustomLabel2.TabIndex = 59
        Me.BunifuCustomLabel2.Text = "Patient number"
        '
        'pat_ID
        '
        Me.pat_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_ID.Location = New System.Drawing.Point(226, 111)
        Me.pat_ID.Multiline = True
        Me.pat_ID.Name = "pat_ID"
        Me.pat_ID.Size = New System.Drawing.Size(234, 28)
        Me.pat_ID.TabIndex = 58
        '
        'Report_Number
        '
        Me.Report_Number.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Report_Number.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Report_Number.BorderRadius = 3
        Me.Report_Number.ForeColor = System.Drawing.Color.White
        Me.Report_Number.Items = New String(-1) {}
        Me.Report_Number.Location = New System.Drawing.Point(226, 193)
        Me.Report_Number.Name = "Report_Number"
        Me.Report_Number.NomalColor = System.Drawing.Color.CornflowerBlue
        Me.Report_Number.onHoverColor = System.Drawing.Color.SteelBlue
        Me.Report_Number.selectedIndex = -1
        Me.Report_Number.Size = New System.Drawing.Size(234, 35)
        Me.Report_Number.TabIndex = 71
        '
        'update
        '
        Me.update.ActiveBorderThickness = 1
        Me.update.ActiveCornerRadius = 60
        Me.update.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.update.ActiveForecolor = System.Drawing.Color.White
        Me.update.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.update.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.update.BackgroundImage = CType(resources.GetObject("update.BackgroundImage"), System.Drawing.Image)
        Me.update.ButtonText = "Update Report"
        Me.update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.update.ForeColor = System.Drawing.Color.SeaGreen
        Me.update.IdleBorderThickness = 1
        Me.update.IdleCornerRadius = 50
        Me.update.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.update.IdleForecolor = System.Drawing.Color.White
        Me.update.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.update.Location = New System.Drawing.Point(515, 505)
        Me.update.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(225, 65)
        Me.update.TabIndex = 72
        Me.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Clear.Location = New System.Drawing.Point(266, 505)
        Me.Clear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(225, 65)
        Me.Clear.TabIndex = 73
        Me.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(466, 241)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(153, 29)
        Me.BunifuCustomLabel5.TabIndex = 69
        Me.BunifuCustomLabel5.Text = "Doctor Name"
        '
        'Doc_name
        '
        Me.Doc_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Doc_name.Location = New System.Drawing.Point(625, 242)
        Me.Doc_name.Multiline = True
        Me.Doc_name.Name = "Doc_name"
        Me.Doc_name.ReadOnly = True
        Me.Doc_name.Size = New System.Drawing.Size(177, 28)
        Me.Doc_name.TabIndex = 70
        '
        'proc
        '
        Me.proc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.proc.Location = New System.Drawing.Point(226, 332)
        Me.proc.Multiline = True
        Me.proc.Name = "proc"
        Me.proc.Size = New System.Drawing.Size(577, 129)
        Me.proc.TabIndex = 74
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(21, 286)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(113, 29)
        Me.BunifuCustomLabel6.TabIndex = 75
        Me.BunifuCustomLabel6.Text = "Diagnosis"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(21, 337)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(131, 29)
        Me.BunifuCustomLabel7.TabIndex = 76
        Me.BunifuCustomLabel7.Text = "procedures"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(466, 284)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(59, 29)
        Me.BunifuCustomLabel8.TabIndex = 78
        Me.BunifuCustomLabel8.Text = "Cost"
        '
        'Cost
        '
        Me.Cost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cost.Location = New System.Drawing.Point(625, 284)
        Me.Cost.Multiline = True
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(177, 31)
        Me.Cost.TabIndex = 77
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(23, 193)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(114, 29)
        Me.BunifuCustomLabel9.TabIndex = 79
        Me.BunifuCustomLabel9.Text = "Visit Date"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.TextBox1.Location = New System.Drawing.Point(226, 150)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 32)
        Me.TextBox1.TabIndex = 80
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(472, 146)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(81, 38)
        Me.BunifuThinButton21.TabIndex = 82
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pat_history_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.proc)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Report_Number)
        Me.Controls.Add(Me.Doc_name)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.doc_ID)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.pat_ID)
        Me.Name = "pat_history_control"
        Me.Size = New System.Drawing.Size(1186, 690)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Report As TextBox
    Friend WithEvents doc_ID As TextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pat_ID As TextBox
    Friend WithEvents Report_Number As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents update As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Clear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Doc_name As TextBox
    Friend WithEvents proc As TextBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cost As TextBox
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
End Class
