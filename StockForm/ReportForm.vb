Imports StockLib


''' <summary>
''' Form designed to show the monthly and annual Reports
''' </summary>
Public Class ReportForm

    Public currentMonth As Integer = Month(Today)
    Public currentYear As Integer = Year(Today)
    Public firstDay As Date
    Public lastDay As Date

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'LOADS STOCK TABLE ONLY ONCE IN THE BEGINNING
        ReloadStockTable()

        'LOADS COMBOBOX FOR YEAR SELECTION
        cbbYear.Text = currentYear.ToString

        'LOADS COMBOBOX FOR MONTH SELECTION
        cbbMonth.Items.Clear()
        For i = 1 To 12
            cbbMonth.Items.Add(MonthName(i))
        Next
        cbbMonth.SelectedIndex = currentMonth - 1

    End Sub

    Private Sub cbbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMonth.SelectedIndexChanged

        ReloadMonthlyTables()

    End Sub

    Private Sub cbbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbYear.SelectedIndexChanged

        ReloadYearlyTables()

    End Sub

    Public Sub ReloadMonthlyTables()

        'GETS MINIMUM AND MAXIMUM DATES FOR MONTHLY ANALYSIS
        currentMonth = cbbMonth.SelectedIndex + 1
        firstDay = New Date(currentYear, currentMonth, 1)
        lastDay = New Date(currentYear, currentMonth, Date.DaysInMonth(currentYear, currentMonth))

        LoadReportTables(lvReport, lvReport2, lvTotal)

        Me.Text = "Relatório Mensal para " + Extensions.Numberfy(cbbMonth.SelectedIndex + 1, 2) + "/" + currentYear.ToString

    End Sub

    Public Sub ReloadYearlyTables()

        'GETS MINIMUM AND MAXIMUM DATES FOR YEARLY ANALYSIS
        currentYear = CDbl(cbbYear.Text)
        firstDay = New Date(currentYear, 1, 1)
        lastDay = New Date(currentYear, 12, 31)

        LoadReportTables(lvReportY, lvReport2Y, lvTotalY)

        Me.Text = "Relatório Anual para " + cbbYear.Text

    End Sub

    Public Sub ReloadStockTable()

        'LOADS STOCK TABLE INTO DATAGRIDVIEW
        ProductStockSchema.StockTable.Rows.Clear()
        'For Each p In Main.productTables.Keys
        For Each p In Main.products.Values

            ProductStockSchema.StockTable.AddStockTableRow(p.Code,
                                                           p.Brand,
                                                           p.LastStock,
                                                           p.Size,
                                                           p.Cost,
                                                           p.Price,
                                                           p.LastStock * p.Cost)

        Next
        With lvStock
            .Columns(4).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(5).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(6).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 10, FontStyle.Bold)
        End With

        Me.Text = "Relatório dos Produtos em Estoque"

    End Sub

    Public Sub LoadReportTables(table1 As DataGridView,
                                table2 As DataGridView,
                                table3 As DataGridView)

        'LOADS BALANCE TABLE INTO DATAGRIDVIEW
        ProductStockSchema.BalanceTable.Rows.Clear()
        For Each p In Main.products.Values
            Dim pTable = Main.products(p.Code).Table
            Dim monthPurchases = p.Purchases.Values.Where(Function(y) y.BuyingDate >= firstDay And y.BuyingDate <= lastDay)
            Dim monthSales = p.Sales.Values.Where(Function(x) x.SellingDate >= firstDay And x.SellingDate <= lastDay)
            Dim monthQttyIn = monthPurchases.Sum(Function(y) y.Quantity)
            Dim monthQttyOut = monthSales.Sum(Function(x) x.Quantity)
            Dim monthMoneyOut = monthPurchases.Sum(Function(y) y.Value * CInt(y.Paid))
            Dim monthMoneyIn = monthSales.Sum(Function(x) x.Value * CInt(x.Paid))

            ProductStockSchema.BalanceTable.AddBalanceTableRow(p.Brand,
                                                               p.Code,
                                                               p.Size,
                                                               monthQttyIn,
                                                               monthQttyOut,
                                                               monthQttyIn - monthQttyOut,
                                                               monthMoneyOut,
                                                               monthMoneyIn,
                                                               monthMoneyIn - monthMoneyOut)

        Next
        With table1
            .Columns(6).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(7).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(8).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 10, FontStyle.Bold)
        End With

        'LOADS TOTAL TABLE INTO DATAGRIDVIEW
        ProductStockSchema.TotalTable.Rows.Clear()
        For Each v In Main.vendors.Values
            Dim monthTotalOut = 0
            Dim monthTotalIn = 0
            Dim stockTotal = 0

            For Each p In Main.products.Values.Where(Function(b) b.Brand = v.Name)
                Dim pTable = Main.products(p.Code).Table
                Dim monthPurchases = p.Purchases.Values.Where(Function(y) y.BuyingDate >= firstDay And y.BuyingDate <= lastDay)
                Dim monthSales = p.Sales.Values.Where(Function(x) x.SellingDate >= firstDay And x.SellingDate <= lastDay)
                monthTotalOut += monthPurchases.Sum(Function(y) y.Value)
                monthTotalIn += monthSales.Sum(Function(x) x.Value)
                stockTotal += p.LastStock * p.Cost
            Next

            ProductStockSchema.TotalTable.AddTotalTableRow(v.Name,
                                                           monthTotalOut,
                                                           monthTotalIn,
                                                           monthTotalIn - monthTotalOut,
                                                           stockTotal,
                                                           monthTotalIn - monthTotalOut + stockTotal)

        Next
        With table2
            .Columns(1).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(2).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(3).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(4).DefaultCellStyle.Format = "R$ 0.00"
            .Columns(5).DefaultCellStyle.Format = "R$ 0.00"
            .ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 10, FontStyle.Bold)
        End With

        With table3
            .Rows.Clear()
            .Rows.Add()
            Dim totals As New List(Of String)
            .Item(0, 0).Value = "TOTAL:"
            For j = 1 To table2.Columns.Count - 1
                Dim value = 0
                For i = 0 To table2.Rows.Count - 1
                    value += table2.Item(j, i).Value
                Next
                totals.Add(value.ToString("R$ 0.00"))
                .Item(j, 0).Value = totals(j - 1)
            Next
            .RowsDefaultCellStyle.Font = New Font(Main.fontName, 10, FontStyle.Bold)
        End With

    End Sub

    Private Sub tabs_Selected(sender As Object, e As TabControlEventArgs) Handles tabs.Selected

        If tabs.SelectedTab Is tpMonthly Then
            ReloadMonthlyTables()
        ElseIf tabs.SelectedTab Is tpYearly Then
            ReloadYearlyTables()
        Else
            ReloadStockTable()
        End If

    End Sub

    Private Sub lvStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvStock.CellFormatting
        If {6}.Contains(e.ColumnIndex) And e.Value.ToString = "0" Then
            e.Value = "-"
        End If
    End Sub
    Private Sub lvReport_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvReport.CellFormatting,
                                                                                                            lvReportY.CellFormatting
        If {6, 7, 8}.Contains(e.ColumnIndex) And Not IsNothing(e.Value) Then
            If e.Value.ToString = "0" Then
                e.Value = "-"
            End If
        End If
    End Sub
    Private Sub lvReport2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvReport2.CellFormatting,
                                                                                                             lvTotal.CellFormatting,
                                                                                                             lvReport2Y.CellFormatting,
                                                                                                             lvTotalY.CellFormatting
        If {1, 2, 3, 4, 5}.Contains(e.ColumnIndex) And Not IsNothing(e.Value) Then
            If e.Value.ToString = "0" Then
                e.Value = "-"
            End If
        End If
    End Sub

End Class