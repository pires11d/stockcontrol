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
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblKind = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblQtty = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStockLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.tbQtty = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPriceUnit = New System.Windows.Forms.Label()
        Me.lblQttyUnit = New System.Windows.Forms.Label()
        Me.lblStockUnit = New System.Windows.Forms.Label()
        Me.lvItems = New System.Windows.Forms.ListView()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tvItems
        '
        Me.tvItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvItems.CheckBoxes = True
        Me.tvItems.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvItems.ForeColor = System.Drawing.Color.Black
        Me.tvItems.Indent = 40
        Me.tvItems.ItemHeight = 30
        Me.tvItems.Location = New System.Drawing.Point(14, 147)
        Me.tvItems.Margin = New System.Windows.Forms.Padding(5)
        Me.tvItems.Name = "tvItems"
        Me.tvItems.ShowNodeToolTips = True
        Me.tvItems.ShowPlusMinus = False
        Me.tvItems.Size = New System.Drawing.Size(300, 440)
        Me.tvItems.TabIndex = 0
        '
        'cbbClient
        '
        Me.cbbClient.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbClient.FormattingEnabled = True
        Me.cbbClient.Location = New System.Drawing.Point(158, 60)
        Me.cbbClient.Margin = New System.Windows.Forms.Padding(5)
        Me.cbbClient.Name = "cbbClient"
        Me.cbbClient.Size = New System.Drawing.Size(292, 31)
        Me.cbbClient.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(14, 17)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 23)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "N° da NF:"
        '
        'tbID
        '
        Me.tbID.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(158, 14)
        Me.tbID.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(156, 30)
        Me.tbID.TabIndex = 3
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(537, 115)
        Me.lblOrder.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(158, 23)
        Me.lblOrder.TabIndex = 2
        Me.lblOrder.Text = "Itens do Pedido:"
        '
        'lblKind
        '
        Me.lblKind.AutoSize = True
        Me.lblKind.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKind.Location = New System.Drawing.Point(322, 147)
        Me.lblKind.Name = "lblKind"
        Me.lblKind.Size = New System.Drawing.Size(51, 22)
        Me.lblKind.TabIndex = 5
        Me.lblKind.Text = "TIPO"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(322, 189)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 23)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "NOME"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(322, 235)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(84, 22)
        Me.lblBrand.TabIndex = 5
        Me.lblBrand.Text = "MARCA"
        '
        'lblQtty
        '
        Me.lblQtty.AutoSize = True
        Me.lblQtty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtty.Location = New System.Drawing.Point(322, 295)
        Me.lblQtty.Name = "lblQtty"
        Me.lblQtty.Size = New System.Drawing.Size(128, 23)
        Me.lblQtty.TabIndex = 5
        Me.lblQtty.Text = "Quantidade:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(322, 470)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(68, 23)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Preço:"
        '
        'lblStockLabel
        '
        Me.lblStockLabel.AutoSize = True
        Me.lblStockLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockLabel.Location = New System.Drawing.Point(322, 385)
        Me.lblStockLabel.Name = "lblStockLabel"
        Me.lblStockLabel.Size = New System.Drawing.Size(120, 23)
        Me.lblStockLabel.TabIndex = 5
        Me.lblStockLabel.Text = "Em Estoque:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(889, 474)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "TOTAL:"
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(322, 419)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(69, 23)
        Me.lblStock.TabIndex = 5
        Me.lblStock.Text = "-"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbQtty
        '
        Me.tbQtty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQtty.Location = New System.Drawing.Point(326, 335)
        Me.tbQtty.Name = "tbQtty"
        Me.tbQtty.Size = New System.Drawing.Size(63, 31)
        Me.tbQtty.TabIndex = 6
        Me.tbQtty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(889, 510)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(37, 23)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "R$ "
        '
        'tbPrice
        '
        Me.tbPrice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.Location = New System.Drawing.Point(326, 508)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(65, 31)
        Me.tbPrice.TabIndex = 6
        Me.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(881, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "__________________"
        '
        'lblPriceUnit
        '
        Me.lblPriceUnit.AutoSize = True
        Me.lblPriceUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceUnit.Location = New System.Drawing.Point(393, 510)
        Me.lblPriceUnit.Name = "lblPriceUnit"
        Me.lblPriceUnit.Size = New System.Drawing.Size(49, 23)
        Me.lblPriceUnit.TabIndex = 5
        Me.lblPriceUnit.Text = "R$/L"
        '
        'lblQttyUnit
        '
        Me.lblQttyUnit.AutoSize = True
        Me.lblQttyUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQttyUnit.Location = New System.Drawing.Point(393, 419)
        Me.lblQttyUnit.Name = "lblQttyUnit"
        Me.lblQttyUnit.Size = New System.Drawing.Size(18, 23)
        Me.lblQttyUnit.TabIndex = 5
        Me.lblQttyUnit.Text = "L"
        '
        'lblStockUnit
        '
        Me.lblStockUnit.AutoSize = True
        Me.lblStockUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockUnit.Location = New System.Drawing.Point(393, 337)
        Me.lblStockUnit.Name = "lblStockUnit"
        Me.lblStockUnit.Size = New System.Drawing.Size(18, 23)
        Me.lblStockUnit.TabIndex = 5
        Me.lblStockUnit.Text = "L"
        '
        'lvItems
        '
        Me.lvItems.BackColor = System.Drawing.SystemColors.Control
        Me.lvItems.HideSelection = False
        Me.lvItems.Location = New System.Drawing.Point(541, 147)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(455, 310)
        Me.lvItems.TabIndex = 7
        Me.lvItems.UseCompatibleStateImageBehavior = False
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(14, 115)
        Me.lblProducts.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(206, 23)
        Me.lblProducts.TabIndex = 8
        Me.lblProducts.Text = "Produtos em Estoque:"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.Location = New System.Drawing.Point(14, 63)
        Me.lblClient.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(81, 23)
        Me.lblClient.TabIndex = 2
        Me.lblClient.Text = "Cliente:"
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 601)
        Me.Controls.Add(Me.lblProducts)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbQtty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblStockLabel)
        Me.Controls.Add(Me.lblStockUnit)
        Me.Controls.Add(Me.lblQttyUnit)
        Me.Controls.Add(Me.lblPriceUnit)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblQtty)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblKind)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cbbClient)
        Me.Controls.Add(Me.tvItems)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
    Friend WithEvents tbID As TextBox
    Friend WithEvents lblOrder As Label
    Friend WithEvents lblKind As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblQtty As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStockLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents tbQtty As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPriceUnit As Label
    Friend WithEvents lblQttyUnit As Label
    Friend WithEvents lblStockUnit As Label
    Friend WithEvents lvItems As ListView
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblClient As Label
End Class
