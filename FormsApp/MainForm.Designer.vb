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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvStock = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvPurchases = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvOrders = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvClients = New System.Windows.Forms.DataGridView()
        Me.split = New System.Windows.Forms.Splitter()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLogoCE = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbbCompany = New System.Windows.Forms.ComboBox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.picLogoLJ = New System.Windows.Forms.PictureBox()
        Me.tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.Controls.Add(Me.TabPage4)
        Me.tabs.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabs.Location = New System.Drawing.Point(225, 170)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1113, 500)
        Me.tabs.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvStock)
        Me.TabPage1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1105, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estoque"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvStock
        '
        Me.lvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvStock.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvStock.DefaultCellStyle = DataGridViewCellStyle1
        Me.lvStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvStock.Location = New System.Drawing.Point(3, 3)
        Me.lvStock.MultiSelect = False
        Me.lvStock.Name = "lvStock"
        Me.lvStock.Size = New System.Drawing.Size(1099, 461)
        Me.lvStock.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvPurchases)
        Me.TabPage2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1105, 467)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Histórico de Entradas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvPurchases
        '
        Me.lvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvPurchases.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvPurchases.DefaultCellStyle = DataGridViewCellStyle2
        Me.lvPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvPurchases.Location = New System.Drawing.Point(0, 0)
        Me.lvPurchases.MultiSelect = False
        Me.lvPurchases.Name = "lvPurchases"
        Me.lvPurchases.Size = New System.Drawing.Size(1105, 467)
        Me.lvPurchases.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvOrders)
        Me.TabPage3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1105, 467)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Histórico de Saídas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvOrders
        '
        Me.lvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvOrders.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvOrders.DefaultCellStyle = DataGridViewCellStyle3
        Me.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvOrders.Location = New System.Drawing.Point(3, 3)
        Me.lvOrders.MultiSelect = False
        Me.lvOrders.Name = "lvOrders"
        Me.lvOrders.Size = New System.Drawing.Size(1099, 461)
        Me.lvOrders.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lvClients)
        Me.TabPage4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1105, 467)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Lista de Clientes"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lvClients
        '
        Me.lvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvClients.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvClients.DefaultCellStyle = DataGridViewCellStyle4
        Me.lvClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvClients.Location = New System.Drawing.Point(0, 0)
        Me.lvClients.MultiSelect = False
        Me.lvClients.Name = "lvClients"
        Me.lvClients.Size = New System.Drawing.Size(1105, 467)
        Me.lvClients.TabIndex = 1
        '
        'split
        '
        Me.split.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.split.Location = New System.Drawing.Point(201, 0)
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
        Me.menu.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem6})
        Me.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(0)
        Me.menu.ShowItemToolTips = True
        Me.menu.Size = New System.Drawing.Size(201, 729)
        Me.menu.TabIndex = 3
        Me.menu.Text = "tsMenu"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.AutoSize = False
        Me.MenuToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(200, 100)
        Me.MenuToolStripMenuItem.Text = "MENU"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 60)
        Me.ToolStripMenuItem1.Text = "  Novo Item"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.Image = Global.FormsApp.My.Resources.Resources._6
        Me.ToolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(200, 60)
        Me.ToolStripMenuItem2.Text = "  Entrada"
        Me.ToolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.AutoSize = False
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(200, 60)
        Me.ToolStripMenuItem3.Text = "  Saída"
        Me.ToolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.AutoSize = False
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(200, 60)
        Me.ToolStripMenuItem4.Text = " Inventário"
        Me.ToolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.AutoSize = False
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(200, 60)
        Me.ToolStripMenuItem6.Text = "  Relatório"
        Me.ToolStripMenuItem6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picLogoCE
        '
        Me.picLogoCE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogoCE.Image = CType(resources.GetObject("picLogoCE.Image"), System.Drawing.Image)
        Me.picLogoCE.Location = New System.Drawing.Point(969, 0)
        Me.picLogoCE.Name = "picLogoCE"
        Me.picLogoCE.Size = New System.Drawing.Size(380, 190)
        Me.picLogoCE.TabIndex = 4
        Me.picLogoCE.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(379, 3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(510, 156)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Controle de Estoque"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbbCompany
        '
        Me.cbbCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbbCompany.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbCompany.FormattingEnabled = True
        Me.cbbCompany.Items.AddRange(New Object() {"ChoppExpress", "L'jaica", " "})
        Me.cbbCompany.Location = New System.Drawing.Point(1114, 682)
        Me.cbbCompany.Name = "cbbCompany"
        Me.cbbCompany.Size = New System.Drawing.Size(217, 28)
        Me.cbbCompany.TabIndex = 6
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(220, 3)
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
        Me.picLogoLJ.Location = New System.Drawing.Point(895, 3)
        Me.picLogoLJ.Name = "picLogoLJ"
        Me.picLogoLJ.Size = New System.Drawing.Size(454, 182)
        Me.picLogoLJ.TabIndex = 4
        Me.picLogoLJ.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.cbbCompany)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.picLogoLJ)
        Me.Controls.Add(Me.picLogoCE)
        Me.Controls.Add(Me.split)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 726)
        Me.Name = "MainForm"
        Me.Text = "StockControl v2.0"
        Me.tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.lvStock, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

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
    Friend WithEvents lvClients As DataGridView
    Friend WithEvents lvStock As DataGridView
    Friend WithEvents lvOrders As DataGridView
    Friend WithEvents lvPurchases As DataGridView
    Friend WithEvents cbbCompany As ComboBox
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents picLogoLJ As PictureBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
