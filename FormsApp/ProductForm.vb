Imports StockLib


''' <summary>
''' Form responsible for loading history information for a specific Product 
''' </summary>
Public Class ProductForm

    Public historySchema As New ProductHistory

    Public Sub New(product As Product)

        InitializeComponent()

        LoadHistory(product)

        lvHistory.DefaultCellStyle.SelectionBackColor = MainForm.secondaryColor

    End Sub

    Public Sub LoadHistory(product As Product)

        'LOADING PRODUCT HISTORY TABLE
        Main.selectedTable = Main.productTables(product)
        With selectedTable
            For i = 0 To Main.selectedTable.Rows.Count - 1

                ProductHistorySchema.HistoryTable.AddHistoryTableRow(.Rows(i).Item(0),
                                                                      .Rows(i).Item(1),
                                                                      .Rows(i).Item(2),
                                                                      CDbl(.Rows(i).Item(3).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(4).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(5).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(6).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(7).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(8).ToString.ToZero))
            Next
        End With

        'FORMATTING OF ACCOUNTING-RELATED COLUMNS
        With lvHistory
            .Columns(6).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(7).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(8).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(.DefaultCellStyle.Font, FontStyle.Bold)
        End With

        'SETS FORM INFORMATION BASED ON THE PRODUCT AND ITS TABLE
        Me.Text = product.Code
        Me.Size = lvHistory.Size

    End Sub

End Class