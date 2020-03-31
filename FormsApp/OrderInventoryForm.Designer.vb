<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderInventoryForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tvC = New System.Windows.Forms.TreeView()
        Me.tvB = New System.Windows.Forms.TreeView()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Chopeiras:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Barris:"
        '
        'tvC
        '
        Me.tvC.BackColor = System.Drawing.SystemColors.Control
        Me.tvC.CheckBoxes = True
        Me.tvC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvC.HotTracking = True
        Me.tvC.Indent = 50
        Me.tvC.ItemHeight = 30
        Me.tvC.Location = New System.Drawing.Point(305, 35)
        Me.tvC.Margin = New System.Windows.Forms.Padding(5)
        Me.tvC.Name = "tvC"
        Me.tvC.ShowNodeToolTips = True
        Me.tvC.Size = New System.Drawing.Size(269, 424)
        Me.tvC.TabIndex = 2
        '
        'tvB
        '
        Me.tvB.BackColor = System.Drawing.SystemColors.Control
        Me.tvB.CheckBoxes = True
        Me.tvB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvB.HotTracking = True
        Me.tvB.Indent = 50
        Me.tvB.ItemHeight = 30
        Me.tvB.Location = New System.Drawing.Point(14, 35)
        Me.tvB.Margin = New System.Windows.Forms.Padding(5)
        Me.tvB.Name = "tvB"
        Me.tvB.ShowNodeToolTips = True
        Me.tvB.Size = New System.Drawing.Size(269, 424)
        Me.tvB.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(219, 474)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(148, 42)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'OrderInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 529)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tvC)
        Me.Controls.Add(Me.tvB)
        Me.Name = "OrderInventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Itens no Inventório"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tvC As TreeView
    Friend WithEvents tvB As TreeView
    Friend WithEvents btnOK As Button
End Class
