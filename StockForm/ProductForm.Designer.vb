﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
        Me.lvHistory = New System.Windows.Forms.DataGridView()
        Me.ProductHistorySchema = New StockLib.ProductHistory()
        Me.NDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIÇÃODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRADADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAÍDADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENTRADADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SAÍDADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.lvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductHistorySchema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvHistory
        '
        Me.lvHistory.AllowUserToAddRows = False
        Me.lvHistory.AllowUserToDeleteRows = False
        Me.lvHistory.AutoGenerateColumns = False
        Me.lvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.lvHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.lvHistory.BackgroundColor = System.Drawing.SystemColors.Control
        Me.lvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NDataGridViewTextBoxColumn, Me.DATADataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.DESCRIÇÃODataGridViewTextBoxColumn, Me.ENTRADADataGridViewTextBoxColumn, Me.SAÍDADataGridViewTextBoxColumn, Me.SALDODataGridViewTextBoxColumn, Me.ENTRADADataGridViewTextBoxColumn1, Me.SAÍDADataGridViewTextBoxColumn1, Me.SALDODataGridViewTextBoxColumn1})
        Me.lvHistory.DataMember = "HistoryTable"
        Me.lvHistory.DataSource = Me.ProductHistorySchema
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.lvHistory.DefaultCellStyle = DataGridViewCellStyle1
        Me.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.lvHistory.Location = New System.Drawing.Point(0, 0)
        Me.lvHistory.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lvHistory.MultiSelect = False
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(1284, 281)
        Me.lvHistory.TabIndex = 3
        '
        'ProductHistorySchema
        '
        Me.ProductHistorySchema.DataSetName = "ProductHistory"
        Me.ProductHistorySchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NDataGridViewTextBoxColumn
        '
        Me.NDataGridViewTextBoxColumn.DataPropertyName = "N"
        Me.NDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.NDataGridViewTextBoxColumn.HeaderText = "N"
        Me.NDataGridViewTextBoxColumn.Name = "NDataGridViewTextBoxColumn"
        Me.NDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DATADataGridViewTextBoxColumn
        '
        Me.DATADataGridViewTextBoxColumn.DataPropertyName = "DATA"
        Me.DATADataGridViewTextBoxColumn.FillWeight = 105.0!
        Me.DATADataGridViewTextBoxColumn.HeaderText = "DATA"
        Me.DATADataGridViewTextBoxColumn.Name = "DATADataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DESCRIÇÃODataGridViewTextBoxColumn
        '
        Me.DESCRIÇÃODataGridViewTextBoxColumn.DataPropertyName = "DESCRIÇÃO"
        Me.DESCRIÇÃODataGridViewTextBoxColumn.FillWeight = 250.0!
        Me.DESCRIÇÃODataGridViewTextBoxColumn.HeaderText = "DESCRIÇÃO"
        Me.DESCRIÇÃODataGridViewTextBoxColumn.Name = "DESCRIÇÃODataGridViewTextBoxColumn"
        '
        'ENTRADADataGridViewTextBoxColumn
        '
        Me.ENTRADADataGridViewTextBoxColumn.DataPropertyName = "ENTRADA"
        Me.ENTRADADataGridViewTextBoxColumn.HeaderText = "ENTRADA"
        Me.ENTRADADataGridViewTextBoxColumn.Name = "ENTRADADataGridViewTextBoxColumn"
        '
        'SAÍDADataGridViewTextBoxColumn
        '
        Me.SAÍDADataGridViewTextBoxColumn.DataPropertyName = "SAÍDA"
        Me.SAÍDADataGridViewTextBoxColumn.HeaderText = "SAÍDA"
        Me.SAÍDADataGridViewTextBoxColumn.Name = "SAÍDADataGridViewTextBoxColumn"
        '
        'SALDODataGridViewTextBoxColumn
        '
        Me.SALDODataGridViewTextBoxColumn.DataPropertyName = "SALDO"
        Me.SALDODataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SALDODataGridViewTextBoxColumn.Name = "SALDODataGridViewTextBoxColumn"
        '
        'ENTRADADataGridViewTextBoxColumn1
        '
        Me.ENTRADADataGridViewTextBoxColumn1.DataPropertyName = "ENTRADA($)"
        Me.ENTRADADataGridViewTextBoxColumn1.FillWeight = 110.0!
        Me.ENTRADADataGridViewTextBoxColumn1.HeaderText = "ENTRADA($)"
        Me.ENTRADADataGridViewTextBoxColumn1.Name = "ENTRADADataGridViewTextBoxColumn1"
        '
        'SAÍDADataGridViewTextBoxColumn1
        '
        Me.SAÍDADataGridViewTextBoxColumn1.DataPropertyName = "SAÍDA($)"
        Me.SAÍDADataGridViewTextBoxColumn1.FillWeight = 110.0!
        Me.SAÍDADataGridViewTextBoxColumn1.HeaderText = "SAÍDA($)"
        Me.SAÍDADataGridViewTextBoxColumn1.Name = "SAÍDADataGridViewTextBoxColumn1"
        '
        'SALDODataGridViewTextBoxColumn1
        '
        Me.SALDODataGridViewTextBoxColumn1.DataPropertyName = "SALDO($)"
        Me.SALDODataGridViewTextBoxColumn1.FillWeight = 110.0!
        Me.SALDODataGridViewTextBoxColumn1.HeaderText = "SALDO($)"
        Me.SALDODataGridViewTextBoxColumn1.Name = "SALDODataGridViewTextBoxColumn1"
        '
        'ProductForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1284, 281)
        Me.Controls.Add(Me.lvHistory)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximumSize = New System.Drawing.Size(2491, 1273)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico"
        CType(Me.lvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductHistorySchema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvHistory As DataGridView
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InletsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutletsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductHistorySchema As StockLib.ProductHistory
    Friend WithEvents NDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DATADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DESCRIÇÃODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTRADADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SAÍDADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALDODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENTRADADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SAÍDADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SALDODataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
