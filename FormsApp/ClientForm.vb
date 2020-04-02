Imports StockLib


''' <summary>
''' Form designed to display the list of <see cref="Client"/> objects and all of their information 
''' </summary>
Public Class ClientForm

    Public oldValue As String = ""
    Public rowAdded As Boolean = False

    Private Sub ClientForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ClientForm_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Main.UpdateTables()
    End Sub

    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadClients()

    End Sub

    Public Sub LoadClients()

        'With tableClients
        '    For i = 0 To .Rows.Count - 1
        '        lvClients.Rows.Add(.rows)
        '    Next
        'End With

        lvClients.Columns.Clear()
        lvClients.Rows.Clear()
        lvClients.DataSource = Main.tableClients

        lvClients.DefaultCellStyle.Font = New Font(Main.fontName, 12)
        lvClients.Columns(0).DefaultCellStyle.Font = New Font(lvClients.DefaultCellStyle.Font, FontStyle.Bold + FontStyle.Underline)
        lvClients.Columns(0).DefaultCellStyle.ForeColor = Color.Navy
        lvClients.ColumnHeadersDefaultCellStyle.Font = New Font(Main.fontName, 12, FontStyle.Bold)

    End Sub

    Private Sub lvClients_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles lvClients.CellBeginEdit

        oldValue = lvClients.Item(0, e.RowIndex).Value.ToString.NotNull

    End Sub
    Private Sub lvClients_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles lvClients.CellEndEdit

        If rowAdded Then
            Try
                Dim cli As New Client(lvClients.Item(0, e.RowIndex).Value)
                Main.clients.Add(cli.Name, cli)
                rowAdded = False
                oldValue = cli.Name
            Catch ex As Exception
                Exit Sub
            End Try
        Else
            If oldValue <> lvClients.Item(0, e.RowIndex).Value.ToString.NotNull Then
                Main.clients.Remove(oldValue)
                Dim cli As New Client(lvClients.Item(0, e.RowIndex).Value)
                Try
                    Main.clients.Add(cli.Name, cli)
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
        End If

        Try
            With Main.clients(lvClients.Item(0, e.RowIndex).Value)
                .Name = lvClients.Item(0, e.RowIndex).Value.ToString.NotNull
                .Phone = lvClients.Item(1, e.RowIndex).Value.ToString.NotNull
                .Address = lvClients.Item(2, e.RowIndex).Value.ToString.NotNull
                .Neighborhood = lvClients.Item(3, e.RowIndex).Value.ToString.NotNull
                .Location = lvClients.Item(4, e.RowIndex).Value.ToString.NotNull
            End With
        Catch ex As Exception

        End Try

        rowAdded = False

        Main.UpdateTables()
    End Sub

    Private Sub lvClients_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles lvClients.UserAddedRow

        rowAdded = True
        lvClients.Item(4, e.Row.Index - 1).Value = "Lages-SC"
        lvClients.Item(6, e.Row.Index - 1).Value = lvClients.Rows.Count - 1

        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()
    End Sub

    Private Sub lvClients_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles lvClients.UserDeletingRow

        Main.clients.Remove(lvClients.Item(0, e.Row.Index).Value)
        Main.tableClients.Rows.Remove(Main.tableClients.Rows(e.Row.Index))

        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()
    End Sub

    Private Sub lvClients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvClients.CellContentClick

        Dim cells = lvClients.SelectedCells

        For Each cell As DataGridViewCell In cells
            If Not cell.ColumnIndex = 0 Then Exit Sub
            Dim cName = lvClients(0, cell.RowIndex).Value.ToString
            For Each c In clients.Values
                If c.Name = cName Then
                    Dim historyForm As New HistoryForm(c)
                    historyForm.Show()
                    Exit Sub
                End If
            Next
        Next

    End Sub

End Class