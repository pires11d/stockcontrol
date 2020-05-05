Imports StockLib


''' <summary>
''' Form responsible for loading history information for a specific Product 
''' </summary>
Public Class ProductForm

    Public Sub New(product As Product)

        InitializeComponent()

        LoadHistory(product)

        lvHistory.DefaultCellStyle.SelectionBackColor = MainForm.secondaryColor

    End Sub

    Public Sub LoadHistory(product As Product)

        Dim stock As Double = 0
        Dim balance As Double = 0

        'LOADING PRODUCT HISTORY TABLE
        Main.selectedTable = Main.products(product.Code).Table
        Dim v = Main.selectedTable.DefaultView
        v.Sort = "DATA ASC"
        Dim t = v.ToTable

        With t
            For i = 0 To Main.selectedTable.Rows.Count - 1
                Dim id = .Rows(i).Item(2).ToString

                Dim qttyIn As Double = 0
                Dim qttyOut As Double = 0
                Dim moneyOut As Double = 0
                Dim moneyIn As Double = 0

                If Main.purchases.ContainsKey(id) Then
                    Dim currentPurchase = product.Purchases.Values.Where(Function(p) p.ID = id).FirstOrDefault
                    qttyIn = currentPurchase.Quantity
                    moneyOut = currentPurchase.Value
                End If

                If Main.sales.ContainsKey(id) Then
                    Dim currentSale = product.Sales.Values.Where(Function(s) s.ID = id).FirstOrDefault
                    qttyOut = currentSale.Quantity
                    moneyIn = currentSale.Value
                End If

                stock += qttyIn - qttyOut
                balance += moneyIn - moneyOut

                ProductHistorySchema.HistoryTable.AddHistoryTableRow(.Rows(i).Item(1).ToString,
                                                                      .Rows(i).Item(2),
                                                                      .Rows(i).Item(3),
                                                                      qttyIn,
                                                                      qttyOut,
                                                                      stock,
                                                                      moneyOut,
                                                                      moneyIn,
                                                                      balance)

                'ProductHistorySchema.HistoryTable.AddHistoryTableRow(CInt(.Rows(i).Item(0)),
                '                                                      .Rows(i).Item(1),
                '                                                      .Rows(i).Item(2),
                '                                                      .Rows(i).Item(3),
                '                                                      CDbl(.Rows(i).Item(4).ToString.ToZero),
                '                                                      CDbl(.Rows(i).Item(5).ToString.ToZero),
                '                                                      CDbl(.Rows(i).Item(6).ToString.ToZero),
                '                                                      CDbl(.Rows(i).Item(7).ToString.ToZero),
                '                                                      CDbl(.Rows(i).Item(8).ToString.ToZero),
                '                                                      CDbl(.Rows(i).Item(9).ToString.ToZero))

            Next
        End With

        'ProductHistorySchema.HistoryTable.OrderBy(Function(x) x.N)

        'FORMATTING OF ACCOUNTING-RELATED COLUMNS
        With lvHistory
            .Columns(1).DefaultCellStyle.Format = "yyyy/MM/dd"
            .Columns(7).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(8).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(9).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 14, FontStyle.Bold)
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