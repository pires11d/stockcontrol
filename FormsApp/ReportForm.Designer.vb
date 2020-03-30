<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lvReport = New System.Windows.Forms.DataGridView()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printDialog = New System.Windows.Forms.PrintDialog()
        Me.printPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lvReport2 = New System.Windows.Forms.DataGridView()
        Me.cbbMonth = New System.Windows.Forms.ComboBox()
        CType(Me.lvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvReport2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvReport
        '
        Me.lvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvReport.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvReport.DefaultCellStyle = DataGridViewCellStyle1
        Me.lvReport.Location = New System.Drawing.Point(14, 87)
        Me.lvReport.Margin = New System.Windows.Forms.Padding(5)
        Me.lvReport.MultiSelect = False
        Me.lvReport.Name = "lvReport"
        Me.lvReport.Size = New System.Drawing.Size(724, 361)
        Me.lvReport.TabIndex = 5
        '
        'printDialog
        '
        Me.printDialog.UseEXDialog = True
        '
        'printPreviewDialog
        '
        Me.printPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog.Enabled = True
        Me.printPreviewDialog.Icon = CType(resources.GetObject("printPreviewDialog.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog.Name = "printPreviewDialog"
        Me.printPreviewDialog.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(15, 15)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(45, 21)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "Mês:"
        '
        'lvReport2
        '
        Me.lvReport2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvReport2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvReport2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvReport2.DefaultCellStyle = DataGridViewCellStyle2
        Me.lvReport2.Location = New System.Drawing.Point(14, 503)
        Me.lvReport2.Margin = New System.Windows.Forms.Padding(5)
        Me.lvReport2.MultiSelect = False
        Me.lvReport2.Name = "lvReport2"
        Me.lvReport2.Size = New System.Drawing.Size(724, 212)
        Me.lvReport2.TabIndex = 5
        '
        'cbbMonth
        '
        Me.cbbMonth.FormattingEnabled = True
        Me.cbbMonth.Location = New System.Drawing.Point(77, 12)
        Me.cbbMonth.Name = "cbbMonth"
        Me.cbbMonth.Size = New System.Drawing.Size(121, 29)
        Me.cbbMonth.TabIndex = 7
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 729)
        Me.Controls.Add(Me.cbbMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lvReport2)
        Me.Controls.Add(Me.lvReport)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório"
        CType(Me.lvReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvReport2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvReport As DataGridView
    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents printDialog As PrintDialog
    Friend WithEvents printPreviewDialog As PrintPreviewDialog
    Friend WithEvents lblMonth As Label
    Friend WithEvents lvReport2 As DataGridView
    Friend WithEvents cbbMonth As ComboBox
End Class
