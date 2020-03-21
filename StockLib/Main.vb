Imports StockLib.Extensions


''' <summary>
''' Main Module, where the program events are located
''' </summary>
Public Module Main

    Public companyName As String = "ChoppExpress"
    Public appDataFolder As String
    Public tableStock As New DataTable
    Public tableOrders As New DataTable
    Public tablePurchases As New DataTable
    Public tableClients As New DataTable
    Public clientList As New List(Of Cliente)

    ''' <summary>
    ''' Sub responsible for loading all necessary tables for the App
    ''' </summary>
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

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub LoadClients()
        With tableClients
            For i = 0 To .Rows.Count - 1
                Dim client As New Cliente
                client.Name = .Rows(i).Item(0)
                client.Phone = .Rows(i).Item(1)
                client.Address = .Rows(i).Item(2)
                client.AddressComplement = .Rows(i).Item(3)
                client.Neighborhood = .Rows(i).Item(4)
                client.Location = .Rows(i).Item(5)

                clientList.Add(client)
            Next
        End With
    End Sub





End Module
