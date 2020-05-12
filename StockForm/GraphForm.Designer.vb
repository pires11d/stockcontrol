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
        Me.cbbValues = New System.Windows.Forms.ComboBox()
        Me.rb0 = New System.Windows.Forms.RadioButton()
        Me.cbAcc = New System.Windows.Forms.CheckBox()
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
        Me.cht.Cursor = System.Windows.Forms.Cursors.Cross
        Me.cht.Location = New System.Drawing.Point(-2, 41)
        Me.cht.Name = "cht"
        Me.cht.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.LabelAngle = 45
        Series1.MarkerBorderColor = System.Drawing.Color.Black
        Series1.MarkerColor = System.Drawing.Color.Green
        Series1.MarkerSize = 10
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series1.Name = "Series1"
        Me.cht.Series.Add(Series1)
        Me.cht.Size = New System.Drawing.Size(839, 493)
        Me.cht.TabIndex = 0
        '
        'rb1
        '
        Me.rb1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb1.AutoSize = True
        Me.rb1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb1.Location = New System.Drawing.Point(117, 12)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(83, 23)
        Me.rb1.TabIndex = 1
        Me.rb1.Text = "Weekly"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb2.AutoSize = True
        Me.rb2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb2.Location = New System.Drawing.Point(241, 12)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(88, 23)
        Me.rb2.TabIndex = 2
        Me.rb2.Text = "Monthly"
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb3.AutoSize = True
        Me.rb3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb3.Location = New System.Drawing.Point(365, 12)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(76, 23)
        Me.rb3.TabIndex = 3
        Me.rb3.Text = "Yearly"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'cbbValues
        '
        Me.cbbValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbValues.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbValues.FormattingEnabled = True
        Me.cbbValues.Location = New System.Drawing.Point(705, 12)
        Me.cbbValues.Name = "cbbValues"
        Me.cbbValues.Size = New System.Drawing.Size(121, 29)
        Me.cbbValues.TabIndex = 4
        '
        'rb0
        '
        Me.rb0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rb0.AutoSize = True
        Me.rb0.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb0.Location = New System.Drawing.Point(12, 12)
        Me.rb0.Name = "rb0"
        Me.rb0.Size = New System.Drawing.Size(66, 23)
        Me.rb0.TabIndex = 0
        Me.rb0.Text = "Daily"
        Me.rb0.UseVisualStyleBackColor = True
        '
        'cbAcc
        '
        Me.cbAcc.AutoSize = True
        Me.cbAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAcc.Location = New System.Drawing.Point(531, 14)
        Me.cbAcc.Name = "cbAcc"
        Me.cbAcc.Size = New System.Drawing.Size(166, 25)
        Me.cbAcc.TabIndex = 5
        Me.cbAcc.Text = "Valor Acumulado"
        Me.cbAcc.UseVisualStyleBackColor = True
        '
        'GraphForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 546)
        Me.Controls.Add(Me.cbAcc)
        Me.Controls.Add(Me.cbbValues)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb0)
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
    Friend WithEvents cbbValues As ComboBox
    Friend WithEvents rb0 As RadioButton
    Friend WithEvents cbAcc As CheckBox
End Class
