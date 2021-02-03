<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_rep_control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_rep_control))
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Report = New System.Windows.Forms.TextBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pat_ID = New System.Windows.Forms.TextBox()
        Me.Check = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ProceduresTxt = New System.Windows.Forms.RichTextBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cost = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(205, 206)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(113, 29)
        Me.BunifuCustomLabel3.TabIndex = 44
        Me.BunifuCustomLabel3.Text = "Diagnosis"
        '
        'Report
        '
        Me.Report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Report.Location = New System.Drawing.Point(386, 215)
        Me.Report.Multiline = True
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(235, 29)
        Me.Report.TabIndex = 43
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(205, 154)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(153, 29)
        Me.BunifuCustomLabel1.TabIndex = 41
        Me.BunifuCustomLabel1.Text = "Patient name"
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
        Me.BunifuCustomLabel2.TabIndex = 40
        Me.BunifuCustomLabel2.Text = "Patient number"
        '
        'pat_ID
        '
        Me.pat_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pat_ID.Location = New System.Drawing.Point(386, 122)
        Me.pat_ID.Multiline = True
        Me.pat_ID.Name = "pat_ID"
        Me.pat_ID.Size = New System.Drawing.Size(235, 28)
        Me.pat_ID.TabIndex = 39
        '
        'Check
        '
        Me.Check.ActiveBorderThickness = 1
        Me.Check.ActiveCornerRadius = 60
        Me.Check.ActiveFillColor = System.Drawing.Color.SteelBlue
        Me.Check.ActiveForecolor = System.Drawing.Color.White
        Me.Check.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption
        Me.Check.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Check.BackgroundImage = CType(resources.GetObject("Check.BackgroundImage"), System.Drawing.Image)
        Me.Check.ButtonText = "Save patient report"
        Me.Check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check.Font = New System.Drawing.Font("Century Gothic", 15.0!)
        Me.Check.ForeColor = System.Drawing.Color.SeaGreen
        Me.Check.IdleBorderThickness = 1
        Me.Check.IdleCornerRadius = 50
        Me.Check.IdleFillColor = System.Drawing.Color.CornflowerBlue
        Me.Check.IdleForecolor = System.Drawing.Color.White
        Me.Check.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Check.Location = New System.Drawing.Point(401, 464)
        Me.Check.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(241, 66)
        Me.Check.TabIndex = 70
        Me.Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProceduresTxt
        '
        Me.ProceduresTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProceduresTxt.Location = New System.Drawing.Point(386, 271)
        Me.ProceduresTxt.Name = "ProceduresTxt"
        Me.ProceduresTxt.Size = New System.Drawing.Size(401, 110)
        Me.ProceduresTxt.TabIndex = 71
        Me.ProceduresTxt.Text = ""
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(205, 262)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(131, 29)
        Me.BunifuCustomLabel4.TabIndex = 72
        Me.BunifuCustomLabel4.Text = "Procedures"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(205, 397)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(59, 29)
        Me.BunifuCustomLabel5.TabIndex = 73
        Me.BunifuCustomLabel5.Text = "Cost"
        '
        'Cost
        '
        Me.Cost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cost.Location = New System.Drawing.Point(386, 406)
        Me.Cost.Multiline = True
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(235, 29)
        Me.Cost.TabIndex = 74
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(630, 155)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(81, 38)
        Me.BunifuThinButton21.TabIndex = 83
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.TextBox1.Location = New System.Drawing.Point(386, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(234, 32)
        Me.TextBox1.TabIndex = 84
        '
        'Patient_rep_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.ProceduresTxt)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.pat_ID)
        Me.Name = "Patient_rep_control"
        Me.Size = New System.Drawing.Size(961, 562)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Report As TextBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pat_ID As TextBox
    Friend WithEvents Check As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ProceduresTxt As RichTextBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cost As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TextBox1 As TextBox
End Class
