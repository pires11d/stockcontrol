Imports StockLib.Extensions


Public Module Main

    Public companyName As String
    Public appDataFolder As String
    Public clientTable As New DataTable

    Public Sub Start()
        companyName = "L'jaica"
        appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                        "\StockControl\" &
                        companyName &
                        "\Data\"

        clientTable = DataTableFromCSV(appDataFolder & "tableClients.csv", True, ";")








    End Sub







End Module
