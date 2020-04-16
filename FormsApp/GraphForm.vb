Imports StockLib
Imports System.Windows.Forms.DataVisualization


Public Class GraphForm

    Private Sub GraphForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGraph

    End Sub

    Public Sub LoadGraph()

        Dim balance = 0

        Dim xList As New List(Of String)
        For i = 1 To 12
            xList.Add(MonthName(i))
        Next

        With cht.Series    
            .Item(0).Points.Clear()
            For i = 0 To xList.Count() - 1
                .Item(0).Points.AddXY(xList(i), i)
            Next
        End With

    End Sub

End Class