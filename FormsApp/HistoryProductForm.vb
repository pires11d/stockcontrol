Imports StockLib


''' <summary>
''' Form responsible for loading history information for a specific Product 
''' </summary>
Public Class HistoryProductForm

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

                ProductHistorySchema.HistoryTable.AddHistoryTableRow(CInt(.Rows(i).Item(0)),
                                                                      .Rows(i).Item(1),
                                                                      .Rows(i).Item(2),
                                                                      .Rows(i).Item(3),
                                                                      CDbl(.Rows(i).Item(4).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(5).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(6).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(7).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(8).ToString.ToZero),
                                                                      CDbl(.Rows(i).Item(9).ToString.ToZero))
            Next
        End With

        'FORMATTING OF ACCOUNTING-RELATED COLUMNS
        With lvHistory
            .Columns(1).DefaultCellStyle.Format = "yyyy/MM/dd"
            .Columns(7).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(8).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(9).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(.DefaultCellStyle.Font, FontStyle.Bold)
        End With

        'SETS FORM INFORMATION BASED ON THE PRODUCT AND ITS TABLE
        Me.Text = product.Code

    End Sub

    Private Sub lvHistory_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvHistory.CellFormatting
        If {4, 5, 6}.Contains(e.ColumnIndex) And e.Value.ToString = "0" Then
            e.Value = "-"
        End If
    End Sub

End Class