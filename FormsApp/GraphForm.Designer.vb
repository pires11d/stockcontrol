<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraphForm))
        Me.cht = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        CType(Me.cht, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cht
        '
        Me.cht.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cht.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.BorderColor = System.Drawing.Color.DimGray
        ChartArea1.Name = "ChartArea1"
        Me.cht.ChartAreas.Add(ChartArea1)
        Me.cht.Location = New System.Drawing.Point(12, 23)
        Me.cht.Name = "cht"
        Me.cht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.LabelAngle = 45
        Series1.Name = "Series1"
        Me.cht.Series.Add(Series1)
        Me.cht.Size = New System.Drawing.Size(795, 488)
        Me.cht.TabIndex = 0
        '
        'rb1
        '
        Me.rb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb1.AutoSize = True
        Me.rb1.Checked = True
        Me.rb1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(188, 12)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(83, 23)
        Me.rb1.TabIndex = 1
        Me.rb1.TabStop = True
        Me.rb1.Text = "Weekly"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(369, 12)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(88, 23)
        Me.rb2.TabIndex = 1
        Me.rb2.Text = "Monthly"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(556, 12)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(76, 23)
        Me.rb3.TabIndex = 1
        Me.rb3.Text = "Yearly"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'GraphForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 523)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.cht)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GraphForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GraphForm"
        CType(Me.cht, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cht As DataVisualization.Charting.Chart
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb3 As RadioButton
End Class
