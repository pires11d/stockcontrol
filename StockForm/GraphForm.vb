Imports StockLib


''' <summary>
''' Form designed to display the plotting of the annual balance
''' </summary>
Public Class GraphForm

    Public interval As Integer = 12
    Public currentMonth As Integer = Month(Today)
    Public currentYear As Integer = Year(Today)
    Public currentValue As String = "b"
    Public firstDay As Date
    Public lastDay As Date
    Dim xList As New List(Of Date)
    Dim yList As New List(Of Double)


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GraphForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbValues.Items.Clear()
        cbbValues.Items.AddRange({"Balanço", "Compras", "Pedidos"})
        cbbValues.SelectedIndex = 0

        rb0.Checked = True

        LoadGraph()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="n"></param>
    Public Sub LoadGraph()

        Dim n = interval
        Dim balance = 0
        xList.Clear()
        yList.Clear()

        For i = 1 To n

            Select Case n
                Case 365
                    Dim y = currentYear
                    Dim entry = New DateTime(currentYear, 1, 1).AddDays(i - 1)
                    'xList.Add(entry.ToString("dd/MM/yyyy"))
                    xList.Add(entry)

                    firstDay = entry
                    lastDay = entry.AddHours(23.999)
                Case 48
                    Dim y = currentYear
                    Dim m = Math.Ceiling(i / 4)
                    Dim d = (i Mod 4)
                    Dim entry = New Date(y, m, d * 7 + 1)
                    'xList.Add(entry.ToString("dd/MM/yyyy"))
                    xList.Add(entry)

                    firstDay = New Date(y, m, 1)
                    lastDay = New Date(y, m, d * 7 + 1)
                Case 12
                    Dim y = currentYear
                    Dim m = i
                    Dim entry = New Date(y, m, 1)
                    'xList.Add(MonthName(i))
                    xList.Add(entry)

                    firstDay = New Date(y, m, 1)
                    lastDay = New Date(y, m, Date.DaysInMonth(y, m))
                Case Else
                    Dim y = currentYear - n + i
                    Dim entry = New Date(y, 1, 1)
                    'xList.Add(y.ToString)
                    xList.Add(entry)

                    firstDay = New Date(y, 1, 1)
                    lastDay = New Date(y, 12, 31)

            End Select

            yList.Add(GetBalanceFrom(firstDay, lastDay, currentValue))

        Next


        With cht.ChartAreas.First

            .BackColor = SystemColors.Control
            .AxisX.Interval = 1
            .AxisX.MajorGrid.LineColor = Color.Gray
            .AxisY.MajorGrid.LineColor = Color.Gray
            .AxisX.MajorGrid.Enabled = False

        End With

        With cht.Series.First

            .Color = Color.FromArgb(100, MainForm.secondaryColor)
            .BorderColor = MainForm.secondaryColor
            .MarkerColor = MainForm.secondaryColor
            .MarkerBorderColor = MainForm.primaryColor

            .Points.Clear()
            Select Case interval
                Case > 48
                    cht.ChartAreas.First.AxisX.Interval = 7
                    .MarkerSize = 5
                    .BorderWidth = 1
                Case 48
                    cht.ChartAreas.First.AxisX.Interval = 1
                    .MarkerSize = 5
                    .BorderWidth = 2
                Case 12
                    cht.ChartAreas.First.AxisX.Interval = 1
                    .MarkerSize = 5
                    .BorderWidth = 3
                Case < 12
                    cht.ChartAreas.First.AxisX.Interval = 1
                    .MarkerSize = 5
                    .BorderWidth = 4
            End Select

            For i = 0 To xList.Count() - 1
                .Points.AddXY(xList(i).ToString("dd/MM/yyyy"), yList(i))
                .IsValueShownAsLabel = False
                If yList(i) <> 0 Then .Points.Item(i).Label = yList(i).ToString("R$ 0")
            Next

        End With

    End Sub

    Private Sub rb0_CheckedChanged(sender As Object, e As EventArgs) Handles rb0.CheckedChanged
        If rb0.Checked Then
            interval = 365
            rb1.Checked = False
            rb2.Checked = False
            rb3.Checked = False
            LoadGraph()
            Me.Text = "Gráfico Diário"
        End If
    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked Then
            interval = 48
            rb0.Checked = False
            rb2.Checked = False
            rb3.Checked = False
            LoadGraph()
            Me.Text = "Gráfico Semanal"
        End If
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked Then
            interval = 12
            rb0.Checked = False
            rb1.Checked = False
            rb3.Checked = False
            LoadGraph()
            Me.Text = "Gráfico Mensal"
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked Then
            interval = 3
            rb0.Checked = False
            rb1.Checked = False
            rb2.Checked = False
            LoadGraph()
            Me.Text = "Gráfico Anual"
        End If
    End Sub

    Private Sub cbbValues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbValues.SelectedIndexChanged
        currentValue = cbbValues.Text.ToLower.First
        LoadGraph()
    End Sub

    Private Sub Chart1_GetToolTipText(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs) Handles cht.GetToolTipText

        Select Case e.HitTestResult.ChartElementType
            Case System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint
                Dim dataPoint = e.HitTestResult.Series.Points(e.HitTestResult.PointIndex)
                e.Text = dataPoint.YValues(0).ToString
        End Select

        Try
            With cht.ChartAreas.First
                Dim x As Double
                Dim xx = .AxisX.PixelPositionToValue(e.X)
                Dim yy = .AxisY.PixelPositionToValue(e.Y)
                Dim ii = .AxisX.Interval
                Dim n = cht.Series.First.Points.Count - 1
                For i = 0 To n
                    ChangePoint(cht, i, 5, MainForm.secondaryColor, MainForm.primaryColor)
                    If rb0.Checked Then
                        ii = 1
                    End If
                    x = ii * (i + 1)
                    If xx > x Then
                        ChangePoint(cht, i, 10, MainForm.primaryColor, MainForm.secondaryColor)
                        If i = 0 Then
                            ChangePoint(cht, i + 1, 5, MainForm.secondaryColor, MainForm.primaryColor)
                        ElseIf i = n Then
                            ChangePoint(cht, i - 1, 5, MainForm.secondaryColor, MainForm.primaryColor)
                        Else
                            ChangePoint(cht, i + 1, 5, MainForm.secondaryColor, MainForm.primaryColor)
                            ChangePoint(cht, i - 1, 5, MainForm.secondaryColor, MainForm.primaryColor)
                        End If
                    End If
                Next
            End With
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ChangePoint(cht As System.Windows.Forms.DataVisualization.Charting.Chart,
                           i As Integer,
                           size As Integer,
                           color1 As Drawing.Color,
                           color2 As Drawing.Color)

        cht.Series.First.Points(i).MarkerSize = size
        cht.Series.First.Points(i).MarkerColor = color1
        cht.Series.First.Points(i).MarkerBorderColor = color2
        If size = 10 Then
            cht.Series.First.Points(i).Font = New Font(cht.Series.First.Points(i).Font, FontStyle.Bold)
        Else
            cht.Series.First.Points(i).Font = New Font(cht.Series.First.Points(i).Font, FontStyle.Regular)
        End If

    End Sub

    Private Sub cht_MouseLeave(sender As Object, e As EventArgs) Handles cht.MouseLeave
        With cht.Series.First.Points
            For i = 0 To .Count - 1
                .Item(i).MarkerSize = 5
                .Item(i).MarkerColor = MainForm.secondaryColor
                .Item(i).MarkerBorderColor = MainForm.primaryColor
            Next
        End With
    End Sub

End Class