<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        Me.lvHistory = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITENSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADAENTREGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPONSÁVELENTREGADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADARETIRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESPONSÁVELRETIRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECOLHIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PEDIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREÇOSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderHistorySchema = New StockLib.OrderHistory()
        CType(Me.lvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderHistorySchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.AllowUserToAddRows = False
        Me.lvHistory.AllowUserToDeleteRows = False
        Me.lvHistory.AutoGenerateColumns = False
        Me.lvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CLIENTEDataGridViewTextBoxColumn, Me.ITENSDataGridViewTextBoxColumn, Me.DATADAENTREGADataGridViewTextBoxColumn, Me.RESPONSÁVELENTREGADataGridViewTextBoxColumn, Me.DATADARETIRADADataGridViewTextBoxColumn, Me.RESPONSÁVELRETIRADADataGridViewTextBoxColumn, Me.RECOLHIDODataGridViewTextBoxColumn, Me.PEDIDODataGridViewTextBoxColumn, Me.PREÇOSDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn, Me.OBSDataGridViewTextBoxColumn})
        Me.lvHistory.DataMember = "OrderTable"
        Me.lvHistory.DataSource = Me.OrderHistorySchema
        Me.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lvHistory.Location = New System.Drawing.Point(0, 0)
        Me.lvHistory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.RowHeadersVisible = False
        Me.lvHistory.Size = New System.Drawing.Size(1350, 281)
        Me.lvHistory.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 33.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'CLIENTEDataGridViewTextBoxColumn
        '
        Me.CLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.CLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE"
        Me.CLIENTEDataGridViewTextBoxColumn.Name = "CLIENTEDataGridViewTextBoxColumn"
        '
        'ITENSDataGridViewTextBoxColumn
        '
        Me.ITENSDataGridViewTextBoxColumn.DataPropertyName = "ITENS"
        Me.ITENSDataGridViewTextBoxColumn.HeaderText = "ITENS"
        Me.ITENSDataGridViewTextBoxColumn.Name = "ITENSDataGridViewTextBoxColumn"
        '
        'DATADAENTREGADataGridViewTextBoxColumn
        '
        Me.DATADAENTREGADataGridViewTextBoxColumn.DataPropertyName = "DATA DA ENTREGA"
        Me.DATADAENTREGADataGridViewTextBoxColumn.HeaderText = "DATA DA ENTREGA"
        Me.DATADAENTREGADataGridViewTextBoxColumn.Name = "DATADAENTREGADataGridViewTextBoxColumn"
        '
        'RESPONSÁVELENTREGADataGridViewTextBoxColumn
        '
        Me.RESPONSÁVELENTREGADataGridViewTextBoxColumn.DataPropertyName = "RESPONSÁVEL ENTREGA"
        Me.RESPONSÁVELENTREGADataGridViewTextBoxColumn.HeaderText = "RESPONSÁVEL ENTREGA"
        Me.RESPONSÁVELENTREGADataGridViewTextBoxColumn.Name = "RESPONSÁVELENTREGADataGridViewTextBoxColumn"
        '
        'DATADARETIRADADataGridViewTextBoxColumn
        '
        Me.DATADARETIRADADataGridViewTextBoxColumn.DataPropertyName = "DATA DA RETIRADA"
        Me.DATADARETIRADADataGridViewTextBoxColumn.HeaderText = "DATA DA RETIRADA"
        Me.DATADARETIRADADataGridViewTextBoxColumn.Name = "DATADARETIRADADataGridViewTextBoxColumn"
        '
        'RESPONSÁVELRETIRADADataGridViewTextBoxColumn
        '
        Me.RESPONSÁVELRETIRADADataGridViewTextBoxColumn.DataPropertyName = "RESPONSÁVEL RETIRADA"
        Me.RESPONSÁVELRETIRADADataGridViewTextBoxColumn.HeaderText = "RESPONSÁVEL RETIRADA"
        Me.RESPONSÁVELRETIRADADataGridViewTextBoxColumn.Name = "RESPONSÁVELRETIRADADataGridViewTextBoxColumn"
        '
        'RECOLHIDODataGridViewTextBoxColumn
        '
        Me.RECOLHIDODataGridViewTextBoxColumn.DataPropertyName = "RECOLHIDO"
        Me.RECOLHIDODataGridViewTextBoxColumn.HeaderText = "RECOLHIDO"
        Me.RECOLHIDODataGridViewTextBoxColumn.Name = "RECOLHIDODataGridViewTextBoxColumn"
        '
        'PEDIDODataGridViewTextBoxColumn
        '
        Me.PEDIDODataGridViewTextBoxColumn.DataPropertyName = "PEDIDO"
        Me.PEDIDODataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.PEDIDODataGridViewTextBoxColumn.HeaderText = "PEDIDO"
        Me.PEDIDODataGridViewTextBoxColumn.Name = "PEDIDODataGridViewTextBoxColumn"
        '
        'PREÇOSDataGridViewTextBoxColumn
        '
        Me.PREÇOSDataGridViewTextBoxColumn.DataPropertyName = "PREÇOS"
        Me.PREÇOSDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.PREÇOSDataGridViewTextBoxColumn.HeaderText = "PREÇOS"
        Me.PREÇOSDataGridViewTextBoxColumn.Name = "PREÇOSDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'OBSDataGridViewTextBoxColumn
        '
        Me.OBSDataGridViewTextBoxColumn.DataPropertyName = "OBS"
        Me.OBSDataGridViewTextBoxColumn.HeaderText = "OBS"
        Me.OBSDataGridViewTextBoxColumn.Name = "OBSDataGridViewTextBoxColumn"
        '
        'OrderHistorySchema
        '
        Me.OrderHistorySchema.DataSetName = "OrderHistory"
        Me.OrderHistorySchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 281)
        Me.Controls.Add(Me.lvHistory)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OrderHistoryForm"
        CType(Me.lvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderHistorySchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvHistory As DataGridView
    Friend WithEvents OrderHistorySchema As StockLib.OrderHistory
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ITENSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATADAENTREGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RESPONSÁVELENTREGADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATADARETIRADADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RESPONSÁVELRETIRADADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RECOLHIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PEDIDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PREÇOSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OBSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
