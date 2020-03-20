Imports StockLib
Imports StockLib.Main
Imports StockLib.Extensions


Public Class MainForm
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start()
        lvClients.DataSource = clientTable


    End Sub

End Class
