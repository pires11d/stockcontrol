<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderForm))
        Me.tvItems = New System.Windows.Forms.TreeView()
        Me.cbbClient = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tbNF = New System.Windows.Forms.TextBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tvItems
        '
        Me.tvItems.Location = New System.Drawing.Point(14, 102)
        Me.tvItems.Margin = New System.Windows.Forms.Padding(5)
        Me.tvItems.Name = "tvItems"
        Me.tvItems.Size = New System.Drawing.Size(436, 445)
        Me.tvItems.TabIndex = 0
        '
        'cbbClient
        '
        Me.cbbClient.FormattingEnabled = True
        Me.cbbClient.Location = New System.Drawing.Point(121, 18)
        Me.cbbClient.Margin = New System.Windows.Forms.Padding(5)
        Me.cbbClient.Name = "cbbClient"
        Me.cbbClient.Size = New System.Drawing.Size(329, 28)
        Me.cbbClient.TabIndex = 1
        Me.cbbClient.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(10, 22)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(92, 20)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "N° da NF:"
        '
        'tbNF
        '
        Me.tbNF.Location = New System.Drawing.Point(121, 19)
        Me.tbNF.Margin = New System.Windows.Forms.Padding(5)
        Me.tbNF.Name = "tbNF"
        Me.tbNF.Size = New System.Drawing.Size(164, 27)
        Me.tbNF.TabIndex = 3
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItems.Location = New System.Drawing.Point(10, 73)
        Me.lblItems.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(142, 20)
        Me.lblItems.TabIndex = 2
        Me.lblItems.Text = "Itens do Pedido:"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 561)
        Me.Controls.Add(Me.tbNF)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cbbClient)
        Me.Controls.Add(Me.tvItems)
        Me.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrderForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tvItems As TreeView
    Friend WithEvents cbbClient As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents tbNF As TextBox
    Friend WithEvents lblItems As Label
End Class
