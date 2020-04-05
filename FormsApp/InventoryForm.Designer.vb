<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryForm))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLastClient = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblKind = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.tvB = New System.Windows.Forms.TreeView()
        Me.tvC = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLastOrder = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLastAddress = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(493, 21)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Selecione um dos itens abaixo para accesar mais informações:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(592, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 48)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Último Cliente:"
        '
        'lblLastClient
        '
        Me.lblLastClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastClient.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastClient.Location = New System.Drawing.Point(701, 318)
        Me.lblLastClient.Name = "lblLastClient"
        Me.lblLastClient.Size = New System.Drawing.Size(152, 61)
        Me.lblLastClient.TabIndex = 1
        Me.lblLastClient.Text = "-"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(592, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Item:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(592, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Modelo:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Código:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(592, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Recolhido:"
        '
        'lblKind
        '
        Me.lblKind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKind.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKind.Location = New System.Drawing.Point(701, 83)
        Me.lblKind.Name = "lblKind"
        Me.lblKind.Size = New System.Drawing.Size(143, 21)
        Me.lblKind.TabIndex = 1
        Me.lblKind.Text = "-"
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(701, 125)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(143, 44)
        Me.lblType.TabIndex = 1
        Me.lblType.Text = "-"
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(701, 169)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(143, 21)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "-"
        '
        'lblState
        '
        Me.lblState.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblState.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(701, 213)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(143, 21)
        Me.lblState.TabIndex = 1
        Me.lblState.Text = "-"
        '
        'tvB
        '
        Me.tvB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvB.BackColor = System.Drawing.SystemColors.Control
        Me.tvB.Cursor = System.Windows.Forms.Cursors.Help
        Me.tvB.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvB.HotTracking = True
        Me.tvB.Indent = 50
        Me.tvB.ItemHeight = 30
        Me.tvB.Location = New System.Drawing.Point(14, 75)
        Me.tvB.Margin = New System.Windows.Forms.Padding(5)
        Me.tvB.Name = "tvB"
        Me.tvB.ShowNodeToolTips = True
        Me.tvB.Size = New System.Drawing.Size(269, 424)
        Me.tvB.TabIndex = 0
        '
        'tvC
        '
        Me.tvC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvC.BackColor = System.Drawing.SystemColors.Control
        Me.tvC.Cursor = System.Windows.Forms.Cursors.Help
        Me.tvC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvC.HotTracking = True
        Me.tvC.Indent = 50
        Me.tvC.ItemHeight = 30
        Me.tvC.Location = New System.Drawing.Point(305, 75)
        Me.tvC.Margin = New System.Windows.Forms.Padding(5)
        Me.tvC.Name = "tvC"
        Me.tvC.ShowNodeToolTips = True
        Me.tvC.Size = New System.Drawing.Size(269, 424)
        Me.tvC.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barris:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chopeiras:"
        '
        'lblLastOrder
        '
        Me.lblLastOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastOrder.AutoSize = True
        Me.lblLastOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastOrder.Location = New System.Drawing.Point(701, 256)
        Me.lblLastOrder.Name = "lblLastOrder"
        Me.lblLastOrder.Size = New System.Drawing.Size(16, 19)
        Me.lblLastOrder.TabIndex = 1
        Me.lblLastOrder.Text = "-"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(592, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 48)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Último Pedido:"
        '
        'lblLastAddress
        '
        Me.lblLastAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAddress.Location = New System.Drawing.Point(701, 379)
        Me.lblLastAddress.Name = "lblLastAddress"
        Me.lblLastAddress.Size = New System.Drawing.Size(152, 80)
        Me.lblLastAddress.TabIndex = 1
        Me.lblLastAddress.Text = "-"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(591, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 48)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Último Endereço:"
        '
        'btnHistory
        '
        Me.btnHistory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHistory.Location = New System.Drawing.Point(596, 12)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(248, 44)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "Acessar Histórico"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 517)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblLastOrder)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblLastAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLastClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblKind)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tvC)
        Me.Controls.Add(Me.tvB)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLastClient As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblKind As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblState As Label
    Friend WithEvents tvB As TreeView
    Friend WithEvents tvC As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLastOrder As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblLastAddress As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnHistory As Button
End Class
