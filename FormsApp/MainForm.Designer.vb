<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvPurchases = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvOrders = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvClients = New System.Windows.Forms.DataGridView()
        Me.split = New System.Windows.Forms.Splitter()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLogoCE = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.picLogoLJ = New System.Windows.Forms.PictureBox()
        Me.btnSync = New System.Windows.Forms.PictureBox()
        Me.bgw = New System.ComponentModel.BackgroundWorker()
        Me.lblSync = New System.Windows.Forms.Label()
        Me.lvStock = New System.Windows.Forms.DataGridView()
        Me.ProductStockSchema = New StockLib.ProductStock()
        Me.PRODUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.lvPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.lvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.lvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu.SuspendLayout()
        CType(Me.picLogoCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogoLJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSync, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductStockSchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.Controls.Add(Me.TabPage4)
        Me.tabs.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabs.HotTrack = True
        Me.tabs.Location = New System.Drawing.Point(209, 188)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1129, 530)
        Me.tabs.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lvStock)
        Me.TabPage1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1121, 492)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estoque Atual"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.lvPurchases)
        Me.TabPage2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1121, 492)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Histórico de Entradas"
        '
        'lvPurchases
        '
        Me.lvPurchases.AllowUserToAddRows = False
        Me.lvPurchases.AllowUserToDeleteRows = False
        Me.lvPurchases.AllowUserToOrderColumns = True
        Me.lvPurchases.AllowUserToResizeRows = False
        Me.lvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvPurchases.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvPurchases.DefaultCellStyle = DataGridViewCellStyle4
        Me.lvPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPurchases.Location = New System.Drawing.Point(0, 0)
        Me.lvPurchases.MultiSelect = False
        Me.lvPurchases.Name = "lvPurchases"
        Me.lvPurchases.ReadOnly = True
        Me.lvPurchases.RowHeadersVisible = False
        Me.lvPurchases.Size = New System.Drawing.Size(1121, 492)
        Me.lvPurchases.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.lvOrders)
        Me.TabPage3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1121, 492)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Histórico de Saídas"
        '
        'lvOrders
        '
        Me.lvOrders.AllowUserToAddRows = False
        Me.lvOrders.AllowUserToDeleteRows = False
        Me.lvOrders.AllowUserToOrderColumns = True
        Me.lvOrders.AllowUserToResizeRows = False
        Me.lvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvOrders.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvOrders.DefaultCellStyle = DataGridViewCellStyle5
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.Location = New System.Drawing.Point(0, 0)
        Me.lvOrders.MultiSelect = False
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.RowHeadersVisible = False
        Me.lvOrders.Size = New System.Drawing.Size(1121, 492)
        Me.lvOrders.TabIndex = 4
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Transparent
        Me.TabPage4.Controls.Add(Me.lvClients)
        Me.TabPage4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1121, 492)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Lista de Clientes"
        '
        'lvClients
        '
        Me.lvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvClients.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvClients.DefaultCellStyle = DataGridViewCellStyle6
        Me.lvClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvClients.Location = New System.Drawing.Point(0, 0)
        Me.lvClients.MultiSelect = False
        Me.lvClients.Name = "lvClients"
        Me.lvClients.Size = New System.Drawing.Size(1121, 492)
        Me.lvClients.TabIndex = 2
        '
        'split
        '
        Me.split.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.split.Location = New System.Drawing.Point(190, 0)
        Me.split.Name = "split"
        Me.split.Size = New System.Drawing.Size(13, 729)
        Me.split.TabIndex = 2
        Me.split.TabStop = False
        '
        'menu
        '
        Me.menu.AutoSize = False
        Me.menu.BackColor = System.Drawing.SystemColors.Control
        Me.menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.menu.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.EmpresaToolStripComboBox, Me.NewProductToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.OrderToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(0)
        Me.menu.ShowItemToolTips = True
        Me.menu.Size = New System.Drawing.Size(190, 729)
        Me.menu.TabIndex = 3
        Me.menu.Text = "tsMenu"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.AutoSize = False
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(190, 100)
        Me.MenuToolStripMenuItem.Text = "MENU"
        '
        'EmpresaToolStripComboBox
        '
        Me.EmpresaToolStripComboBox.AutoSize = False
        Me.EmpresaToolStripComboBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaToolStripComboBox.Items.AddRange(New Object() {"L'jaica", "ChoppExpress"})
        Me.EmpresaToolStripComboBox.Name = "EmpresaToolStripComboBox"
        Me.EmpresaToolStripComboBox.Size = New System.Drawing.Size(190, 33)
        '
        'NewProductToolStripMenuItem
        '
        Me.NewProductToolStripMenuItem.AutoSize = False
        Me.NewProductToolStripMenuItem.Image = CType(resources.GetObject("NewProductToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewProductToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewProductToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem"
        Me.NewProductToolStripMenuItem.Size = New System.Drawing.Size(190, 60)
        Me.NewProductToolStripMenuItem.Text = "  Novo Item"
        Me.NewProductToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.AutoSize = False
        Me.PurchaseToolStripMenuItem.Image = Global.FormsApp.My.Resources.Resources._6
        Me.PurchaseToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurchaseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        Me.PurchaseToolStripMenuItem.Size = New System.Drawing.Size(190, 60)
        Me.PurchaseToolStripMenuItem.Text = "  Entradas"
        Me.PurchaseToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.AutoSize = False
        Me.OrderToolStripMenuItem.Image = CType(resources.GetObject("OrderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OrderToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OrderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(190, 60)
        Me.OrderToolStripMenuItem.Text = "  Saídas"
        Me.OrderToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.AutoSize = False
        Me.InventoryToolStripMenuItem.Image = CType(resources.GetObject("InventoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InventoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(190, 60)
        Me.InventoryToolStripMenuItem.Text = " Inventário"
        Me.InventoryToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.AutoSize = False
        Me.ReportToolStripMenuItem.Image = CType(resources.GetObject("ReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(190, 60)
        Me.ReportToolStripMenuItem.Text = "  Relatório"
        Me.ReportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picLogoCE
        '
        Me.picLogoCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogoCE.Image = CType(resources.GetObject("picLogoCE.Image"), System.Drawing.Image)
        Me.picLogoCE.Location = New System.Drawing.Point(986, 2)
        Me.picLogoCE.Name = "picLogoCE"
        Me.picLogoCE.Size = New System.Drawing.Size(362, 183)
        Me.picLogoCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoCE.TabIndex = 4
        Me.picLogoCE.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(379, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 156)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Controle de Estoque"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(205, 0)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(153, 153)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 4
        Me.picIcon.TabStop = False
        '
        'picLogoLJ
        '
        Me.picLogoLJ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogoLJ.Image = Global.FormsApp.My.Resources.Resources.logo_ljaica
        Me.picLogoLJ.Location = New System.Drawing.Point(898, 0)
        Me.picLogoLJ.Name = "picLogoLJ"
        Me.picLogoLJ.Size = New System.Drawing.Size(450, 185)
        Me.picLogoLJ.TabIndex = 4
        Me.picLogoLJ.TabStop = False
        '
        'btnSync
        '
        Me.btnSync.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSync.Image = Global.FormsApp.My.Resources.Resources.syncing_static
        Me.btnSync.Location = New System.Drawing.Point(-9, 602)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(117, 115)
        Me.btnSync.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSync.TabIndex = 7
        Me.btnSync.TabStop = False
        '
        'bgw
        '
        Me.bgw.WorkerReportsProgress = True
        Me.bgw.WorkerSupportsCancellation = True
        '
        'lblSync
        '
        Me.lblSync.AutoSize = True
        Me.lblSync.Location = New System.Drawing.Point(11, 689)
        Me.lblSync.Name = "lblSync"
        Me.lblSync.Size = New System.Drawing.Size(10, 13)
        Me.lblSync.TabIndex = 8
        Me.lblSync.Text = "-"
        '
        'lvStock
        '
        Me.lvStock.AllowUserToAddRows = False
        Me.lvStock.AllowUserToDeleteRows = False
        Me.lvStock.AllowUserToResizeColumns = False
        Me.lvStock.AllowUserToResizeRows = False
        Me.lvStock.AutoGenerateColumns = False
        Me.lvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvStock.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.lvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.lvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTODataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.ESTOQUEDataGridViewTextBoxColumn, Me.UNIDDataGridViewTextBoxColumn, Me.CUSTODataGridViewTextBoxColumn, Me.PREÇODataGridViewTextBoxColumn, Me.ESTOQUEDataGridViewTextBoxColumn1})
        Me.lvStock.DataMember = "StockTable"
        Me.lvStock.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvStock.DefaultCellStyle = DataGridViewCellStyle3
        Me.lvStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvStock.Location = New System.Drawing.Point(0, 0)
        Me.lvStock.MultiSelect = False
        Me.lvStock.Name = "lvStock"
        Me.lvStock.ReadOnly = True
        Me.lvStock.RowHeadersVisible = False
        Me.lvStock.Size = New System.Drawing.Size(1121, 492)
        Me.lvStock.TabIndex = 2
        '
        'ProductStockSchema
        '
        Me.ProductStockSchema.DataSetName = "ProductStock"
        Me.ProductStockSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUTODataGridViewTextBoxColumn
        '
        Me.PRODUTODataGridViewTextBoxColumn.ActiveLinkColor = System.Drawing.Color.White
        Me.PRODUTODataGridViewTextBoxColumn.DataPropertyName = "PRODUTO"
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.PRODUTODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PRODUTODataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.PRODUTODataGridViewTextBoxColumn.HeaderText = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn.LinkColor = System.Drawing.Color.Navy
        Me.PRODUTODataGridViewTextBoxColumn.Name = "PRODUTODataGridViewTextBoxColumn"
        Me.PRODUTODataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODUTODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRODUTODataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PRODUTODataGridViewTextBoxColumn.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'MARCADataGridViewTextBoxColumn
        '
        Me.MARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.MARCADataGridViewTextBoxColumn.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn.Name = "MARCADataGridViewTextBoxColumn"
        Me.MARCADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTOQUEDataGridViewTextBoxColumn
        '
        Me.ESTOQUEDataGridViewTextBoxColumn.DataPropertyName = "ESTOQUE"
        Me.ESTOQUEDataGridViewTextBoxColumn.HeaderText = "ESTOQUE"
        Me.ESTOQUEDataGridViewTextBoxColumn.Name = "ESTOQUEDataGridViewTextBoxColumn"
        Me.ESTOQUEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UNIDDataGridViewTextBoxColumn
        '
        Me.UNIDDataGridViewTextBoxColumn.DataPropertyName = "UNID"
        Me.UNIDDataGridViewTextBoxColumn.HeaderText = "UNID"
        Me.UNIDDataGridViewTextBoxColumn.Name = "UNIDDataGridViewTextBoxColumn"
        Me.UNIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CUSTODataGridViewTextBoxColumn
        '
        Me.CUSTODataGridViewTextBoxColumn.DataPropertyName = "CUSTO"
        Me.CUSTODataGridViewTextBoxColumn.HeaderText = "CUSTO"
        Me.CUSTODataGridViewTextBoxColumn.Name = "CUSTODataGridViewTextBoxColumn"
        Me.CUSTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'PREÇODataGridViewTextBoxColumn
        '
        Me.PREÇODataGridViewTextBoxColumn.DataPropertyName = "PREÇO"
        Me.PREÇODataGridViewTextBoxColumn.HeaderText = "PREÇO"
        Me.PREÇODataGridViewTextBoxColumn.Name = "PREÇODataGridViewTextBoxColumn"
        Me.PREÇODataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTOQUEDataGridViewTextBoxColumn1
        '
        Me.ESTOQUEDataGridViewTextBoxColumn1.DataPropertyName = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn1.HeaderText = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn1.Name = "ESTOQUEDataGridViewTextBoxColumn1"
        Me.ESTOQUEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.picLogoLJ)
        Me.Controls.Add(Me.lblSync)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.picLogoCE)
        Me.Controls.Add(Me.split)
        Me.Controls.Add(Me.menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(825, 464)
        Me.Name = "MainForm"
        Me.Text = "StockControl v2.0"
        Me.tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.lvPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.lvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.lvClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.picLogoCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogoLJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSync, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductStockSchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents split As Splitter
    Friend WithEvents menu As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogoCE As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lvStock As DataGridView
    Friend WithEvents lvPurchases As DataGridView
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents picLogoLJ As PictureBox
    Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSync As PictureBox
    Friend WithEvents bgw As System.ComponentModel.BackgroundWorker
    Friend WithEvents lvOrders As DataGridView
    Friend WithEvents lvClients As DataGridView
    Friend WithEvents EmpresaToolStripComboBox As ToolStripComboBox
    Friend WithEvents lblSync As Label
    Friend WithEvents ProductStockSchema As StockLib.ProductStock
    Friend WithEvents PRODUTODataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREÇODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
