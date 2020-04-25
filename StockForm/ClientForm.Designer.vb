<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientForm))
        Me.lvClients = New System.Windows.Forms.DataGridView()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.TELEFONE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BAIRRO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOCALIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENDEREÇO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientRegistrySchema = New StockLib.ClientRegistry()
        CType(Me.lvClients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientRegistrySchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvClients
        '
        Me.lvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.lvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvClients.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvClients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIENTE, Me.TELEFONE, Me.RUA, Me.BAIRRO, Me.LOCALIDADE, Me.ENDEREÇO, Me.ID})
        Me.lvClients.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvClients.DefaultCellStyle = DataGridViewCellStyle2
        Me.lvClients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvClients.Location = New System.Drawing.Point(0, 0)
        Me.lvClients.MultiSelect = False
        Me.lvClients.Name = "lvClients"
        Me.lvClients.Size = New System.Drawing.Size(1199, 624)
        Me.lvClients.TabIndex = 3
        '
        'CLIENTE
        '
        Me.CLIENTE.ActiveLinkColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLIENTE.DefaultCellStyle = DataGridViewCellStyle1
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.LinkColor = System.Drawing.Color.Navy
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLIENTE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CLIENTE.VisitedLinkColor = System.Drawing.Color.Navy
        Me.CLIENTE.Width = 81
        '
        'TELEFONE
        '
        Me.TELEFONE.HeaderText = "TELEFONE"
        Me.TELEFONE.Name = "TELEFONE"
        Me.TELEFONE.Width = 88
        '
        'RUA
        '
        Me.RUA.HeaderText = "RUA"
        Me.RUA.Name = "RUA"
        Me.RUA.Width = 53
        '
        'BAIRRO
        '
        Me.BAIRRO.HeaderText = "BAIRRO"
        Me.BAIRRO.Name = "BAIRRO"
        Me.BAIRRO.Width = 74
        '
        'LOCALIDADE
        '
        Me.LOCALIDADE.HeaderText = "LOCALIDADE"
        Me.LOCALIDADE.Name = "LOCALIDADE"
        Me.LOCALIDADE.Width = 102
        '
        'ENDEREÇO
        '
        Me.ENDEREÇO.HeaderText = "ENDEREÇO"
        Me.ENDEREÇO.Name = "ENDEREÇO"
        Me.ENDEREÇO.Width = 88
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 46
        '
        'ClientRegistrySchema
        '
        Me.ClientRegistrySchema.DataSetName = "ClientRegistry"
        Me.ClientRegistrySchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 624)
        Me.Controls.Add(Me.lvClients)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ClientForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.lvClients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientRegistrySchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvClients As DataGridView
    Friend WithEvents ClientRegistrySchema As StockLib.ClientRegistry
    Friend WithEvents CLIENTE As DataGridViewLinkColumn
    Friend WithEvents TELEFONE As DataGridViewTextBoxColumn
    Friend WithEvents RUA As DataGridViewTextBoxColumn
    Friend WithEvents BAIRRO As DataGridViewTextBoxColumn
    Friend WithEvents LOCALIDADE As DataGridViewTextBoxColumn
    Friend WithEvents ENDEREÇO As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
