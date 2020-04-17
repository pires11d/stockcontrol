Imports StockLib


''' <summary>
''' Form designed to display the plotting of the annual balance
''' </summary>
Public Class GraphForm

    Public interval As Integer
    Public currentMonth As Integer = Month(Today)
    Public currentYear As Integer = Year(Today)
    Public firstDay As Date
    Public lastDay As Date

    Private Sub GraphForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rb1.Checked = True

        LoadGraph(interval)

    End Sub

    Public Sub LoadGraph(n As Integer)

        Dim balance = 0
        Dim xList As New List(Of String)
        Dim yList As New List(Of Double)

        For i = 1 To n

            If n = 12 Then
                Dim y = currentYear
                Dim m = i
                xList.Add(MonthName(i))

                firstDay = New Date(y, m, 1)
                lastDay = New Date(y, m, Date.DaysInMonth(y, m))
            ElseIf n > 12 Then
                Dim y = currentYear
                Dim m = Math.Ceiling(i / 4)
                Dim d = (i Mod 4)
                Dim entry = New Date(y, m, d * 7 + 1)
                xList.Add(entry.ToString("dd/MM/yyyy"))

                firstDay = New Date(y, m, 1)
                lastDay = New Date(y, m, d * 7 + 1)
            ElseIf n < 12 Then
                Dim y = currentYear - n + i - 1
                xList.Add(y.ToString)

                firstDay = New Date(y, 1, 1)
                lastDay = New Date(y, 12, 31)
            End If

            yList.Add(GetBalanceFrom(firstDay, lastDay))

        Next


        With cht.ChartAreas.First
            .BackColor = SystemColors.Control
            .AxisX.Interval = 1
            .AxisX.MajorGrid.LineColor = Color.Gray
            .AxisY.MajorGrid.LineColor = Color.Gray
            .AxisX.MajorGrid.Enabled = False
        End With
        With cht.Series.First
            .Points.Clear()
            If rb1.Checked Then
                '.ChartType = DataVisualization.Charting.SeriesChartType.Spline
                '.BorderWidth = 10
            Else
                .ChartType = DataVisualization.Charting.SeriesChartType.Column
            End If
            For i = 0 To xList.Count() - 1
                .Points.AddXY(xList(i), yList(i))
            Next
        End With

    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            interval = 48
            rb2.Checked = False
            rb3.Checked = False
            LoadGraph(interval)
        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            interval = 12
            rb1.Checked = False
            rb3.Checked = False
            LoadGraph(interval)
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            interval = 3
            rb1.Checked = False
            rb2.Checked = False
            LoadGraph(interval)
        End If
    End Sub

End Class