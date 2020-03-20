Imports StockLib
Imports StockLib.Main
Imports StockLib.Extensions


Public Class MainForm
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start()
        lvClients.DataSource = clientTable


    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class
