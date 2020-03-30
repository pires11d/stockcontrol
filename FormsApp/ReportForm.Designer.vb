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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cbbMonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tpMonthly = New System.Windows.Forms.TabPage()
        Me.tpYearly = New System.Windows.Forms.TabPage()
        Me.cbbYear = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.tpStock = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lvTotal = New System.Windows.Forms.DataGridView()
        Me.MARCADataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPRASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANÇODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPITALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStockSchema = New StockLib.ProductStock()
        Me.lvReport = New System.Windows.Forms.DataGridView()
        Me.MARCADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRADASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAÍDASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPRASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANÇODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lvTotalY = New System.Windows.Forms.DataGridView()
        Me.MARCADataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPRASDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDASDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANÇODataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAPITALDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lvReportY = New System.Windows.Forms.DataGridView()
        Me.MARCADataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUTODataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRADASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAÍDASDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMPRASDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDASDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANÇODataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lvStock = New System.Windows.Forms.DataGridView()
        Me.PRODUTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MARCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTOQUEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabs.SuspendLayout()
        Me.tpMonthly.SuspendLayout()
        Me.tpYearly.SuspendLayout()
        Me.tpStock.SuspendLayout()
        CType(Me.lvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductStockSchema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvTotalY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvReportY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(9, 12)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(38, 16)
        Me.lblMonth.TabIndex = 6
        Me.lblMonth.Text = "Mês:"
        '
        'cbbMonth
        '
        Me.cbbMonth.FormattingEnabled = True
        Me.cbbMonth.Location = New System.Drawing.Point(54, 9)
        Me.cbbMonth.Name = "cbbMonth"
        Me.cbbMonth.Size = New System.Drawing.Size(97, 25)
        Me.cbbMonth.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-247, -127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mês:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(-197, -128)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 25)
        Me.ComboBox1.TabIndex = 7
        '
        'tabs
        '
        Me.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tabs.Controls.Add(Me.tpMonthly)
        Me.tabs.Controls.Add(Me.tpYearly)
        Me.tabs.Controls.Add(Me.tpStock)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.ItemSize = New System.Drawing.Size(290, 30)
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(884, 701)
        Me.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabs.TabIndex = 8
        '
        'tpMonthly
        '
        Me.tpMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tpMonthly.Controls.Add(Me.Label4)
        Me.tpMonthly.Controls.Add(Me.Label3)
        Me.tpMonthly.Controls.Add(Me.ComboBox1)
        Me.tpMonthly.Controls.Add(Me.cbbMonth)
        Me.tpMonthly.Controls.Add(Me.lblMonth)
        Me.tpMonthly.Controls.Add(Me.Label1)
        Me.tpMonthly.Controls.Add(Me.lvTotal)
        Me.tpMonthly.Controls.Add(Me.lvReport)
        Me.tpMonthly.Location = New System.Drawing.Point(4, 34)
        Me.tpMonthly.Name = "tpMonthly"
        Me.tpMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMonthly.Size = New System.Drawing.Size(876, 663)
        Me.tpMonthly.TabIndex = 0
        Me.tpMonthly.Text = "Relatório Mensal"
        '
        'tpYearly
        '
        Me.tpYearly.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tpYearly.Controls.Add(Me.Label5)
        Me.tpYearly.Controls.Add(Me.Label2)
        Me.tpYearly.Controls.Add(Me.cbbYear)
        Me.tpYearly.Controls.Add(Me.lblYear)
        Me.tpYearly.Controls.Add(Me.lvTotalY)
        Me.tpYearly.Controls.Add(Me.lvReportY)
        Me.tpYearly.Location = New System.Drawing.Point(4, 34)
        Me.tpYearly.Name = "tpYearly"
        Me.tpYearly.Padding = New System.Windows.Forms.Padding(3)
        Me.tpYearly.Size = New System.Drawing.Size(876, 663)
        Me.tpYearly.TabIndex = 1
        Me.tpYearly.Text = "Relatório Anual"
        '
        'cbbYear
        '
        Me.cbbYear.FormattingEnabled = True
        Me.cbbYear.Items.AddRange(New Object() {"2019", "2020", "2021"})
        Me.cbbYear.Location = New System.Drawing.Point(54, 9)
        Me.cbbYear.Name = "cbbYear"
        Me.cbbYear.Size = New System.Drawing.Size(97, 25)
        Me.cbbYear.TabIndex = 11
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(9, 12)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(38, 16)
        Me.lblYear.TabIndex = 10
        Me.lblYear.Text = "Ano:"
        '
        'tpStock
        '
        Me.tpStock.Controls.Add(Me.Label6)
        Me.tpStock.Controls.Add(Me.lvStock)
        Me.tpStock.Location = New System.Drawing.Point(4, 34)
        Me.tpStock.Name = "tpStock"
        Me.tpStock.Size = New System.Drawing.Size(876, 663)
        Me.tpStock.TabIndex = 2
        Me.tpStock.Text = "Relatório do Estoque"
        Me.tpStock.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 504)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tabela com valores totais ANUAIS, por Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 504)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(317, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tabela com valores totais MENSAIS, por Marca:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tabela com valores MENSAIS, por Produto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tabela com valores ANUAIS, por Produto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 48)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(567, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Tabela referente ao Estoque Atual de Produtos, bem como seu valor a preço de cust" &
    "o:"
        '
        'lvTotal
        '
        Me.lvTotal.AllowUserToAddRows = False
        Me.lvTotal.AllowUserToDeleteRows = False
        Me.lvTotal.AllowUserToOrderColumns = True
        Me.lvTotal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTotal.AutoGenerateColumns = False
        Me.lvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvTotal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCADataGridViewTextBoxColumn2, Me.COMPRASDataGridViewTextBoxColumn1, Me.VENDASDataGridViewTextBoxColumn1, Me.BALANÇODataGridViewTextBoxColumn1, Me.ESTOQUEDataGridViewTextBoxColumn2, Me.CAPITALDataGridViewTextBoxColumn})
        Me.lvTotal.DataMember = "TotalTable"
        Me.lvTotal.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.lvTotal.Location = New System.Drawing.Point(8, 524)
        Me.lvTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lvTotal.MultiSelect = False
        Me.lvTotal.Name = "lvTotal"
        Me.lvTotal.RowHeadersVisible = False
        Me.lvTotal.Size = New System.Drawing.Size(860, 130)
        Me.lvTotal.TabIndex = 5
        '
        'MARCADataGridViewTextBoxColumn2
        '
        Me.MARCADataGridViewTextBoxColumn2.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn2.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn2.Name = "MARCADataGridViewTextBoxColumn2"
        '
        'COMPRASDataGridViewTextBoxColumn1
        '
        Me.COMPRASDataGridViewTextBoxColumn1.DataPropertyName = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn1.HeaderText = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn1.Name = "COMPRASDataGridViewTextBoxColumn1"
        '
        'VENDASDataGridViewTextBoxColumn1
        '
        Me.VENDASDataGridViewTextBoxColumn1.DataPropertyName = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn1.HeaderText = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn1.Name = "VENDASDataGridViewTextBoxColumn1"
        '
        'BALANÇODataGridViewTextBoxColumn1
        '
        Me.BALANÇODataGridViewTextBoxColumn1.DataPropertyName = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn1.HeaderText = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn1.Name = "BALANÇODataGridViewTextBoxColumn1"
        '
        'ESTOQUEDataGridViewTextBoxColumn2
        '
        Me.ESTOQUEDataGridViewTextBoxColumn2.DataPropertyName = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn2.HeaderText = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn2.Name = "ESTOQUEDataGridViewTextBoxColumn2"
        '
        'CAPITALDataGridViewTextBoxColumn
        '
        Me.CAPITALDataGridViewTextBoxColumn.DataPropertyName = "CAPITAL($)"
        Me.CAPITALDataGridViewTextBoxColumn.HeaderText = "CAPITAL($)"
        Me.CAPITALDataGridViewTextBoxColumn.Name = "CAPITALDataGridViewTextBoxColumn"
        '
        'ProductStockSchema
        '
        Me.ProductStockSchema.DataSetName = "ProductStock"
        Me.ProductStockSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvReport
        '
        Me.lvReport.AllowUserToAddRows = False
        Me.lvReport.AllowUserToDeleteRows = False
        Me.lvReport.AllowUserToOrderColumns = True
        Me.lvReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvReport.AutoGenerateColumns = False
        Me.lvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvReport.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCADataGridViewTextBoxColumn1, Me.PRODUTODataGridViewTextBoxColumn1, Me.UNIDADEDataGridViewTextBoxColumn, Me.ENTRADASDataGridViewTextBoxColumn, Me.SAÍDASDataGridViewTextBoxColumn, Me.SALDODataGridViewTextBoxColumn, Me.COMPRASDataGridViewTextBoxColumn, Me.VENDASDataGridViewTextBoxColumn, Me.BALANÇODataGridViewTextBoxColumn})
        Me.lvReport.DataMember = "BalanceTable"
        Me.lvReport.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvReport.DefaultCellStyle = DataGridViewCellStyle2
        Me.lvReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lvReport.Location = New System.Drawing.Point(8, 68)
        Me.lvReport.Margin = New System.Windows.Forms.Padding(4)
        Me.lvReport.MultiSelect = False
        Me.lvReport.Name = "lvReport"
        Me.lvReport.ReadOnly = True
        Me.lvReport.RowHeadersVisible = False
        Me.lvReport.Size = New System.Drawing.Size(860, 420)
        Me.lvReport.TabIndex = 5
        '
        'MARCADataGridViewTextBoxColumn1
        '
        Me.MARCADataGridViewTextBoxColumn1.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn1.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn1.Name = "MARCADataGridViewTextBoxColumn1"
        Me.MARCADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PRODUTODataGridViewTextBoxColumn1
        '
        Me.PRODUTODataGridViewTextBoxColumn1.DataPropertyName = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.PRODUTODataGridViewTextBoxColumn1.HeaderText = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn1.Name = "PRODUTODataGridViewTextBoxColumn1"
        Me.PRODUTODataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn
        '
        Me.UNIDADEDataGridViewTextBoxColumn.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.UNIDADEDataGridViewTextBoxColumn.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn.Name = "UNIDADEDataGridViewTextBoxColumn"
        Me.UNIDADEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ENTRADASDataGridViewTextBoxColumn
        '
        Me.ENTRADASDataGridViewTextBoxColumn.DataPropertyName = "ENTRADAS"
        Me.ENTRADASDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.ENTRADASDataGridViewTextBoxColumn.HeaderText = "ENTRADAS"
        Me.ENTRADASDataGridViewTextBoxColumn.Name = "ENTRADASDataGridViewTextBoxColumn"
        Me.ENTRADASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SAÍDASDataGridViewTextBoxColumn
        '
        Me.SAÍDASDataGridViewTextBoxColumn.DataPropertyName = "SAÍDAS"
        Me.SAÍDASDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.SAÍDASDataGridViewTextBoxColumn.HeaderText = "SAÍDAS"
        Me.SAÍDASDataGridViewTextBoxColumn.Name = "SAÍDASDataGridViewTextBoxColumn"
        Me.SAÍDASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SALDODataGridViewTextBoxColumn
        '
        Me.SALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO"
        Me.SALDODataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.SALDODataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SALDODataGridViewTextBoxColumn.Name = "SALDODataGridViewTextBoxColumn"
        Me.SALDODataGridViewTextBoxColumn.ReadOnly = True
        '
        'COMPRASDataGridViewTextBoxColumn
        '
        Me.COMPRASDataGridViewTextBoxColumn.DataPropertyName = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn.HeaderText = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn.Name = "COMPRASDataGridViewTextBoxColumn"
        Me.COMPRASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VENDASDataGridViewTextBoxColumn
        '
        Me.VENDASDataGridViewTextBoxColumn.DataPropertyName = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn.HeaderText = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn.Name = "VENDASDataGridViewTextBoxColumn"
        Me.VENDASDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BALANÇODataGridViewTextBoxColumn
        '
        Me.BALANÇODataGridViewTextBoxColumn.DataPropertyName = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn.HeaderText = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn.Name = "BALANÇODataGridViewTextBoxColumn"
        Me.BALANÇODataGridViewTextBoxColumn.ReadOnly = True
        '
        'lvTotalY
        '
        Me.lvTotalY.AllowUserToAddRows = False
        Me.lvTotalY.AllowUserToDeleteRows = False
        Me.lvTotalY.AllowUserToOrderColumns = True
        Me.lvTotalY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTotalY.AutoGenerateColumns = False
        Me.lvTotalY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvTotalY.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvTotalY.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvTotalY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvTotalY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCADataGridViewTextBoxColumn4, Me.COMPRASDataGridViewTextBoxColumn3, Me.VENDASDataGridViewTextBoxColumn3, Me.BALANÇODataGridViewTextBoxColumn3, Me.ESTOQUEDataGridViewTextBoxColumn3, Me.CAPITALDataGridViewTextBoxColumn1})
        Me.lvTotalY.DataMember = "TotalTable"
        Me.lvTotalY.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvTotalY.DefaultCellStyle = DataGridViewCellStyle3
        Me.lvTotalY.Location = New System.Drawing.Point(8, 524)
        Me.lvTotalY.Margin = New System.Windows.Forms.Padding(4)
        Me.lvTotalY.MultiSelect = False
        Me.lvTotalY.Name = "lvTotalY"
        Me.lvTotalY.RowHeadersVisible = False
        Me.lvTotalY.Size = New System.Drawing.Size(860, 130)
        Me.lvTotalY.TabIndex = 8
        '
        'MARCADataGridViewTextBoxColumn4
        '
        Me.MARCADataGridViewTextBoxColumn4.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn4.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn4.Name = "MARCADataGridViewTextBoxColumn4"
        '
        'COMPRASDataGridViewTextBoxColumn3
        '
        Me.COMPRASDataGridViewTextBoxColumn3.DataPropertyName = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn3.HeaderText = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn3.Name = "COMPRASDataGridViewTextBoxColumn3"
        '
        'VENDASDataGridViewTextBoxColumn3
        '
        Me.VENDASDataGridViewTextBoxColumn3.DataPropertyName = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn3.HeaderText = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn3.Name = "VENDASDataGridViewTextBoxColumn3"
        '
        'BALANÇODataGridViewTextBoxColumn3
        '
        Me.BALANÇODataGridViewTextBoxColumn3.DataPropertyName = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn3.HeaderText = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn3.Name = "BALANÇODataGridViewTextBoxColumn3"
        '
        'ESTOQUEDataGridViewTextBoxColumn3
        '
        Me.ESTOQUEDataGridViewTextBoxColumn3.DataPropertyName = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn3.HeaderText = "ESTOQUE($)"
        Me.ESTOQUEDataGridViewTextBoxColumn3.Name = "ESTOQUEDataGridViewTextBoxColumn3"
        '
        'CAPITALDataGridViewTextBoxColumn1
        '
        Me.CAPITALDataGridViewTextBoxColumn1.DataPropertyName = "CAPITAL($)"
        Me.CAPITALDataGridViewTextBoxColumn1.HeaderText = "CAPITAL($)"
        Me.CAPITALDataGridViewTextBoxColumn1.Name = "CAPITALDataGridViewTextBoxColumn1"
        '
        'lvReportY
        '
        Me.lvReportY.AllowUserToAddRows = False
        Me.lvReportY.AllowUserToDeleteRows = False
        Me.lvReportY.AllowUserToOrderColumns = True
        Me.lvReportY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvReportY.AutoGenerateColumns = False
        Me.lvReportY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvReportY.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvReportY.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvReportY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvReportY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCADataGridViewTextBoxColumn3, Me.PRODUTODataGridViewTextBoxColumn2, Me.UNIDADEDataGridViewTextBoxColumn1, Me.ENTRADASDataGridViewTextBoxColumn1, Me.SAÍDASDataGridViewTextBoxColumn1, Me.SALDODataGridViewTextBoxColumn1, Me.COMPRASDataGridViewTextBoxColumn2, Me.VENDASDataGridViewTextBoxColumn2, Me.BALANÇODataGridViewTextBoxColumn2})
        Me.lvReportY.DataMember = "BalanceTable"
        Me.lvReportY.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvReportY.DefaultCellStyle = DataGridViewCellStyle4
        Me.lvReportY.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lvReportY.Location = New System.Drawing.Point(8, 68)
        Me.lvReportY.Margin = New System.Windows.Forms.Padding(4)
        Me.lvReportY.MultiSelect = False
        Me.lvReportY.Name = "lvReportY"
        Me.lvReportY.ReadOnly = True
        Me.lvReportY.RowHeadersVisible = False
        Me.lvReportY.Size = New System.Drawing.Size(860, 420)
        Me.lvReportY.TabIndex = 9
        '
        'MARCADataGridViewTextBoxColumn3
        '
        Me.MARCADataGridViewTextBoxColumn3.DataPropertyName = "MARCA"
        Me.MARCADataGridViewTextBoxColumn3.HeaderText = "MARCA"
        Me.MARCADataGridViewTextBoxColumn3.Name = "MARCADataGridViewTextBoxColumn3"
        Me.MARCADataGridViewTextBoxColumn3.ReadOnly = True
        '
        'PRODUTODataGridViewTextBoxColumn2
        '
        Me.PRODUTODataGridViewTextBoxColumn2.DataPropertyName = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.PRODUTODataGridViewTextBoxColumn2.HeaderText = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn2.Name = "PRODUTODataGridViewTextBoxColumn2"
        Me.PRODUTODataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UNIDADEDataGridViewTextBoxColumn1
        '
        Me.UNIDADEDataGridViewTextBoxColumn1.DataPropertyName = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.UNIDADEDataGridViewTextBoxColumn1.HeaderText = "UNIDADE"
        Me.UNIDADEDataGridViewTextBoxColumn1.Name = "UNIDADEDataGridViewTextBoxColumn1"
        Me.UNIDADEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ENTRADASDataGridViewTextBoxColumn1
        '
        Me.ENTRADASDataGridViewTextBoxColumn1.DataPropertyName = "ENTRADAS"
        Me.ENTRADASDataGridViewTextBoxColumn1.FillWeight = 90.0!
        Me.ENTRADASDataGridViewTextBoxColumn1.HeaderText = "ENTRADAS"
        Me.ENTRADASDataGridViewTextBoxColumn1.Name = "ENTRADASDataGridViewTextBoxColumn1"
        Me.ENTRADASDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SAÍDASDataGridViewTextBoxColumn1
        '
        Me.SAÍDASDataGridViewTextBoxColumn1.DataPropertyName = "SAÍDAS"
        Me.SAÍDASDataGridViewTextBoxColumn1.FillWeight = 90.0!
        Me.SAÍDASDataGridViewTextBoxColumn1.HeaderText = "SAÍDAS"
        Me.SAÍDASDataGridViewTextBoxColumn1.Name = "SAÍDASDataGridViewTextBoxColumn1"
        Me.SAÍDASDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SALDODataGridViewTextBoxColumn1
        '
        Me.SALDODataGridViewTextBoxColumn1.DataPropertyName = "SALDO"
        Me.SALDODataGridViewTextBoxColumn1.FillWeight = 90.0!
        Me.SALDODataGridViewTextBoxColumn1.HeaderText = "SALDO"
        Me.SALDODataGridViewTextBoxColumn1.Name = "SALDODataGridViewTextBoxColumn1"
        Me.SALDODataGridViewTextBoxColumn1.ReadOnly = True
        '
        'COMPRASDataGridViewTextBoxColumn2
        '
        Me.COMPRASDataGridViewTextBoxColumn2.DataPropertyName = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn2.HeaderText = "COMPRAS($)"
        Me.COMPRASDataGridViewTextBoxColumn2.Name = "COMPRASDataGridViewTextBoxColumn2"
        Me.COMPRASDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'VENDASDataGridViewTextBoxColumn2
        '
        Me.VENDASDataGridViewTextBoxColumn2.DataPropertyName = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn2.HeaderText = "VENDAS($)"
        Me.VENDASDataGridViewTextBoxColumn2.Name = "VENDASDataGridViewTextBoxColumn2"
        Me.VENDASDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'BALANÇODataGridViewTextBoxColumn2
        '
        Me.BALANÇODataGridViewTextBoxColumn2.DataPropertyName = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn2.HeaderText = "BALANÇO($)"
        Me.BALANÇODataGridViewTextBoxColumn2.Name = "BALANÇODataGridViewTextBoxColumn2"
        Me.BALANÇODataGridViewTextBoxColumn2.ReadOnly = True
        '
        'lvStock
        '
        Me.lvStock.AllowUserToAddRows = False
        Me.lvStock.AllowUserToDeleteRows = False
        Me.lvStock.AllowUserToOrderColumns = True
        Me.lvStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvStock.AutoGenerateColumns = False
        Me.lvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvStock.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTODataGridViewTextBoxColumn, Me.MARCADataGridViewTextBoxColumn, Me.ESTOQUEDataGridViewTextBoxColumn, Me.UNIDDataGridViewTextBoxColumn, Me.CUSTODataGridViewTextBoxColumn, Me.PREÇODataGridViewTextBoxColumn, Me.ESTOQUEDataGridViewTextBoxColumn1})
        Me.lvStock.DataMember = "StockTable"
        Me.lvStock.DataSource = Me.ProductStockSchema
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvStock.DefaultCellStyle = DataGridViewCellStyle5
        Me.lvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lvStock.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lvStock.Location = New System.Drawing.Point(8, 68)
        Me.lvStock.Margin = New System.Windows.Forms.Padding(4)
        Me.lvStock.MultiSelect = False
        Me.lvStock.Name = "lvStock"
        Me.lvStock.ReadOnly = True
        Me.lvStock.RowHeadersVisible = False
        Me.lvStock.Size = New System.Drawing.Size(860, 586)
        Me.lvStock.TabIndex = 6
        '
        'PRODUTODataGridViewTextBoxColumn
        '
        Me.PRODUTODataGridViewTextBoxColumn.DataPropertyName = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.PRODUTODataGridViewTextBoxColumn.HeaderText = "PRODUTO"
        Me.PRODUTODataGridViewTextBoxColumn.Name = "PRODUTODataGridViewTextBoxColumn"
        Me.PRODUTODataGridViewTextBoxColumn.ReadOnly = True
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
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 701)
        Me.Controls.Add(Me.tabs)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório"
        Me.tabs.ResumeLayout(False)
        Me.tpMonthly.ResumeLayout(False)
        Me.tpMonthly.PerformLayout()
        Me.tpYearly.ResumeLayout(False)
        Me.tpYearly.PerformLayout()
        Me.tpStock.ResumeLayout(False)
        Me.tpStock.PerformLayout()
        CType(Me.lvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductStockSchema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvTotalY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvReportY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvReport As DataGridView
    Friend WithEvents lblMonth As Label
    Friend WithEvents cbbMonth As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tabs As TabControl
    Friend WithEvents tpMonthly As TabPage
    Friend WithEvents tpYearly As TabPage
    Friend WithEvents lvTotal As DataGridView
    Friend WithEvents cbbYear As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lvTotalY As DataGridView
    Friend WithEvents lvReportY As DataGridView
    Friend WithEvents tpStock As TabPage
    Friend WithEvents lvStock As DataGridView
    Friend WithEvents ProductStockSchema As StockLib.ProductStock
    Friend WithEvents PRODUTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UNIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREÇODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents COMPRASDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents VENDASDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BALANÇODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CAPITALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUTODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTRADASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAÍDASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMPRASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VENDASDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BALANÇODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents COMPRASDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents VENDASDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BALANÇODataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ESTOQUEDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CAPITALDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MARCADataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUTODataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ENTRADASDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SAÍDASDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SALDODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents COMPRASDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents VENDASDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BALANÇODataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
