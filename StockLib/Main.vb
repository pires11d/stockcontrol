Imports StockLib.Extensions


Public Module Main

    Public companyName As String = "ChoppExpress"
    Public appDataFolder As String
    Public tableStock As New DataTable
    Public tableOrders As New DataTable
    Public tablePurchases As New DataTable
    Public tableClients As New DataTable

    Public Sub Start()

        appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                        "\StockControl\" &
                        companyName &
                        "\Data\"

        Try
            tableStock = DataTableFromCSV(appDataFolder & "tableStock2.csv", True, "|")
            tableOrders = DataTableFromCSV(appDataFolder & "tableOrders.csv", True, "|")
            tableOrders.Columns.Remove("ENDERECO")
            tablePurchases = DataTableFromCSV(appDataFolder & "tablePurchases.csv", True, "|")
            tableClients = DataTableFromCSV(appDataFolder & "tableClients.csv", True, "|")
        Catch ex As Exception

        End Try

        With tableStock
            For i = 0 To .Rows.Count - 1
                Select Case Len(.Rows(i).Item(2))
                    Case 1
                        .Rows(i).Item(2) = "00" + .Rows(i).Item(2)
                    Case 2
                        .Rows(i).Item(2) = "0" + .Rows(i).Item(2)
                End Select
            Next
        End With

    End Sub







End Module
