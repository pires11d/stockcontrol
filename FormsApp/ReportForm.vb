Imports StockLib

''' <summary>
''' Form designed to show the monthly and annual Reports
''' </summary>
Public Class ReportForm

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbMonth.Items.Clear()
        For i = 1 To 12
            cbbMonth.Items.Add(MonthName(i))
        Next
        cbbMonth.SelectedIndex = 0

    End Sub

    Private Sub cbbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbMonth.SelectedIndexChanged





    End Sub

End Class