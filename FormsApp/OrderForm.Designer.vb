<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderForm
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
        Me.lblPriceUnit = New System.Windows.Forms.Label()
        Me.lblQttyUnit = New System.Windows.Forms.Label()
        Me.lblStockUnit = New System.Windows.Forms.Label()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lvItems = New System.Windows.Forms.DataGridView()
        Me.ItemColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.cbbResp1 = New System.Windows.Forms.ComboBox()
        Me.cbbResp2 = New System.Windows.Forms.ComboBox()
        Me.lblResp1 = New System.Windows.Forms.Label()
        Me.lblResp2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbObs = New System.Windows.Forms.TextBox()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.datePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.lvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvItems
        '
        Me.tvItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvItems.BackColor = System.Drawing.SystemColors.Control
        Me.tvItems.CheckBoxes = True
        Me.tvItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tvItems.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvItems.ForeColor = System.Drawing.Color.Black
        Me.tvItems.HotTracking = True
        Me.tvItems.Indent = 40
        Me.tvItems.ItemHeight = 30
        Me.tvItems.Location = New System.Drawing.Point(14, 166)
        Me.tvItems.Margin = New System.Windows.Forms.Padding(5)
        Me.tvItems.Name = "tvItems"
        Me.tvItems.ShowNodeToolTips = True
        Me.tvItems.Size = New System.Drawing.Size(300, 442)
        Me.tvItems.TabIndex = 2
        '
        'cbbClient
        '
        Me.cbbClient.BackColor = System.Drawing.SystemColors.Control
        Me.cbbClient.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbClient.FormattingEnabled = True
        Me.cbbClient.Location = New System.Drawing.Point(155, 83)
        Me.cbbClient.Margin = New System.Windows.Forms.Padding(5)
        Me.cbbClient.Name = "cbbClient"
        Me.cbbClient.Size = New System.Drawing.Size(237, 31)
        Me.cbbClient.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(10, 43)
        Me.lblID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(96, 23)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "N° da NF:"
        '
        'tbID
        '
        Me.tbID.BackColor = System.Drawing.SystemColors.Info
        Me.tbID.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbID.Location = New System.Drawing.Point(155, 40)
        Me.tbID.Margin = New System.Windows.Forms.Padding(5)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(121, 30)
        Me.tbID.TabIndex = 0
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(537, 138)
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
        Me.lblKind.Location = New System.Drawing.Point(322, 166)
        Me.lblKind.Name = "lblKind"
        Me.lblKind.Size = New System.Drawing.Size(51, 22)
        Me.lblKind.TabIndex = 5
        Me.lblKind.Text = "TIPO"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(322, 208)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 23)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "PRODUTO"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(322, 254)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(84, 22)
        Me.lblBrand.TabIndex = 5
        Me.lblBrand.Text = "MARCA"
        '
        'lblQtty
        '
        Me.lblQtty.AutoSize = True
        Me.lblQtty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtty.Location = New System.Drawing.Point(322, 314)
        Me.lblQtty.Name = "lblQtty"
        Me.lblQtty.Size = New System.Drawing.Size(128, 23)
        Me.lblQtty.TabIndex = 5
        Me.lblQtty.Text = "Quantidade:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(322, 493)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(68, 23)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Preço:"
        '
        'lblStockLabel
        '
        Me.lblStockLabel.AutoSize = True
        Me.lblStockLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockLabel.Location = New System.Drawing.Point(322, 406)
        Me.lblStockLabel.Name = "lblStockLabel"
        Me.lblStockLabel.Size = New System.Drawing.Size(120, 23)
        Me.lblStockLabel.TabIndex = 5
        Me.lblStockLabel.Text = "Em Estoque:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(816, 493)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "TOTAL:"
        '
        'lblStock
        '
        Me.lblStock.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(322, 438)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(69, 23)
        Me.lblStock.TabIndex = 5
        Me.lblStock.Text = "-"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbQtty
        '
        Me.tbQtty.BackColor = System.Drawing.SystemColors.Control
        Me.tbQtty.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQtty.Location = New System.Drawing.Point(327, 342)
        Me.tbQtty.Name = "tbQtty"
        Me.tbQtty.Size = New System.Drawing.Size(63, 31)
        Me.tbQtty.TabIndex = 3
        Me.tbQtty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(816, 523)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(37, 23)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "R$ "
        '
        'tbPrice
        '
        Me.tbPrice.BackColor = System.Drawing.SystemColors.Control
        Me.tbPrice.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPrice.Location = New System.Drawing.Point(327, 521)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(65, 31)
        Me.tbPrice.TabIndex = 4
        Me.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPriceUnit
        '
        Me.lblPriceUnit.AutoSize = True
        Me.lblPriceUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceUnit.Location = New System.Drawing.Point(394, 523)
        Me.lblPriceUnit.Name = "lblPriceUnit"
        Me.lblPriceUnit.Size = New System.Drawing.Size(49, 23)
        Me.lblPriceUnit.TabIndex = 5
        Me.lblPriceUnit.Text = "R$/-"
        '
        'lblQttyUnit
        '
        Me.lblQttyUnit.AutoSize = True
        Me.lblQttyUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQttyUnit.Location = New System.Drawing.Point(393, 438)
        Me.lblQttyUnit.Name = "lblQttyUnit"
        Me.lblQttyUnit.Size = New System.Drawing.Size(18, 23)
        Me.lblQttyUnit.TabIndex = 5
        Me.lblQttyUnit.Text = "-"
        '
        'lblStockUnit
        '
        Me.lblStockUnit.AutoSize = True
        Me.lblStockUnit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockUnit.Location = New System.Drawing.Point(393, 342)
        Me.lblStockUnit.Name = "lblStockUnit"
        Me.lblStockUnit.Size = New System.Drawing.Size(18, 23)
        Me.lblStockUnit.TabIndex = 5
        Me.lblStockUnit.Text = "-"
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(10, 138)
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
        Me.lblClient.Location = New System.Drawing.Point(10, 86)
        Me.lblClient.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(81, 23)
        Me.lblClient.TabIndex = 2
        Me.lblClient.Text = "Cliente:"
        '
        'lvItems
        '
        Me.lvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemColumn, Me.PriceColumn})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvItems.DefaultCellStyle = DataGridViewCellStyle1
        Me.lvItems.Location = New System.Drawing.Point(541, 166)
        Me.lvItems.Name = "lvItems"
        Me.lvItems.RowHeadersVisible = False
        Me.lvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.lvItems.Size = New System.Drawing.Size(391, 300)
        Me.lvItems.TabIndex = 10
        Me.lvItems.TabStop = False
        '
        'ItemColumn
        '
        Me.ItemColumn.HeaderText = "Item"
        Me.ItemColumn.Name = "ItemColumn"
        '
        'PriceColumn
        '
        Me.PriceColumn.HeaderText = "Preço"
        Me.PriceColumn.Name = "PriceColumn"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(820, 566)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(112, 42)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(434, 43)
        Me.lblDate1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(86, 23)
        Me.lblDate1.TabIndex = 2
        Me.lblDate1.Text = "Entrega:"
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(434, 86)
        Me.lblDate2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(94, 23)
        Me.lblDate2.TabIndex = 2
        Me.lblDate2.Text = "Retirada:"
        '
        'cbbResp1
        '
        Me.cbbResp1.BackColor = System.Drawing.SystemColors.Control
        Me.cbbResp1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbResp1.FormattingEnabled = True
        Me.cbbResp1.Location = New System.Drawing.Point(798, 39)
        Me.cbbResp1.Margin = New System.Windows.Forms.Padding(5)
        Me.cbbResp1.Name = "cbbResp1"
        Me.cbbResp1.Size = New System.Drawing.Size(132, 31)
        Me.cbbResp1.TabIndex = 6
        '
        'cbbResp2
        '
        Me.cbbResp2.BackColor = System.Drawing.SystemColors.Control
        Me.cbbResp2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbResp2.FormattingEnabled = True
        Me.cbbResp2.Location = New System.Drawing.Point(798, 83)
        Me.cbbResp2.Margin = New System.Windows.Forms.Padding(5)
        Me.cbbResp2.Name = "cbbResp2"
        Me.cbbResp2.Size = New System.Drawing.Size(132, 31)
        Me.cbbResp2.TabIndex = 8
        '
        'lblResp1
        '
        Me.lblResp1.AutoSize = True
        Me.lblResp1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResp1.Location = New System.Drawing.Point(726, 43)
        Me.lblResp1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblResp1.Name = "lblResp1"
        Me.lblResp1.Size = New System.Drawing.Size(64, 23)
        Me.lblResp1.TabIndex = 2
        Me.lblResp1.Text = "Resp.:"
        '
        'lblResp2
        '
        Me.lblResp2.AutoSize = True
        Me.lblResp2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResp2.Location = New System.Drawing.Point(726, 86)
        Me.lblResp2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblResp2.Name = "lblResp2"
        Me.lblResp2.Size = New System.Drawing.Size(64, 23)
        Me.lblResp2.TabIndex = 2
        Me.lblResp2.Text = "Resp.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(537, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Observação:"
        '
        'tbObs
        '
        Me.tbObs.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbObs.Location = New System.Drawing.Point(541, 521)
        Me.tbObs.Multiline = True
        Me.tbObs.Name = "tbObs"
        Me.tbObs.Size = New System.Drawing.Size(249, 87)
        Me.tbObs.TabIndex = 10
        Me.tbObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menu
        '
        Me.menu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.AddToolStripMenuItem, Me.RemoveToolStripMenuItem, Me.InventoryToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(944, 29)
        Me.menu.TabIndex = 12
        Me.menu.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseToolStripMenuItem, Me.OrderStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(78, 25)
        Me.NewToolStripMenuItem.Text = "Novo(a)"
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.PurchaseToolStripMenuItem.Text = "Compra"
        '
        'OrderStripMenuItem
        '
        Me.OrderStripMenuItem.Name = "OrderStripMenuItem"
        Me.OrderStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.OrderStripMenuItem.Text = "Pedido"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Enabled = False
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.AddToolStripMenuItem.Text = "Adicionar"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Enabled = False
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.RemoveToolStripMenuItem.Text = "Remover"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Enabled = False
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(151, 25)
        Me.InventoryToolStripMenuItem.Text = "Itens do Inventário"
        '
        'datePicker1
        '
        Me.datePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.datePicker1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker1.Location = New System.Drawing.Point(541, 38)
        Me.datePicker1.Name = "datePicker1"
        Me.datePicker1.Size = New System.Drawing.Size(141, 31)
        Me.datePicker1.TabIndex = 5
        '
        'datePicker2
        '
        Me.datePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.datePicker2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePicker2.Location = New System.Drawing.Point(541, 83)
        Me.datePicker2.Name = "datePicker2"
        Me.datePicker2.Size = New System.Drawing.Size(141, 31)
        Me.datePicker2.TabIndex = 7
        '
        'OrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 627)
        Me.Controls.Add(Me.datePicker2)
        Me.Controls.Add(Me.datePicker1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.lblProducts)
        Me.Controls.Add(Me.tbObs)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbQtty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblStockLabel)
        Me.Controls.Add(Me.lblStockUnit)
        Me.Controls.Add(Me.lblQttyUnit)
        Me.Controls.Add(Me.lblPriceUnit)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.lblResp2)
        Me.Controls.Add(Me.lblResp1)
        Me.Controls.Add(Me.lblDate1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cbbResp2)
        Me.Controls.Add(Me.cbbResp1)
        Me.Controls.Add(Me.cbbClient)
        Me.Controls.Add(Me.tvItems)
        Me.Controls.Add(Me.menu)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "OrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário"
        CType(Me.lvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
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
    Friend WithEvents lblPriceUnit As Label
    Friend WithEvents lblQttyUnit As Label
    Friend WithEvents lblStockUnit As Label
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblClient As Label
    Friend WithEvents lvItems As DataGridView
    Friend WithEvents ItemColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnOK As Button
    Friend WithEvents lblDate1 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents cbbResp1 As ComboBox
    Friend WithEvents cbbResp2 As ComboBox
    Friend WithEvents lblResp1 As Label
    Friend WithEvents lblResp2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbObs As TextBox
    Friend WithEvents menu As MenuStrip
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datePicker1 As DateTimePicker
    Friend WithEvents datePicker2 As DateTimePicker
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
End Class
