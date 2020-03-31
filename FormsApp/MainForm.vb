Imports StockLib


''' <summary>
''' Main Interface, contains a MenuStrip that works as a control panel.
''' <para></para>
''' Has all important tables displayed as DataGridView objects.
''' </summary>
Public Class MainForm

    Public stockSchema As New ProductStock
    Public primaryColor As Color
    Public secondaryColor As Color
    Public oldValue As String
    Public rowAdded As Boolean = False

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpresaToolStripComboBox.SelectedIndex = 0
        Main.Start()
        LoadTables()

    End Sub

    Public Sub LoadTables()

        'LOADS STOCK TABLE INTO DATAGRIDVIEW
        ProductStockSchema.StockTable.Clear()
        Dim dv As New DataView(tableProducts)
        dv.Sort = "PRODUTO ASC, MARCA ASC"
        Dim dt = dv.ToTable
        With dt
            For i = 0 To .Rows.Count - 1
                ProductStockSchema.StockTable.AddStockTableRow(.Rows(i).Item(0),
                                                                .Rows(i).Item(1),
                                                                CDbl(.Rows(i).Item(2).ToString.ToZero),
                                                                .Rows(i).Item(3),
                                                                CDbl(.Rows(i).Item(6).ToString.ToZero),
                                                                CDbl(.Rows(i).Item(7).ToString.ToZero),
                                                                CDbl(.Rows(i).Item(2).ToString.ToZero) * CDbl(.Rows(i).Item(6).ToString.ToZero))
            Next i
        End With

        'LOADS PURCHASES TABLE INTO DATAGRIDVIEW
        lvPurchases.DataSource = tablePurchases

        'LOADS ORDERS TABLE INTO DATAGRIDVIEW
        lvOrders.DataSource = tableOrders

        'LOADS CLIENTS TABLE INTO DATAGRIDVIEW
        lvClients.DataSource = tableClients

        ApplyStylesToTables("Century Gothic")

    End Sub

    Public Sub ApplyStylesToTables(fontName As String)

        lvStock.Columns(4).DefaultCellStyle.Format = "R$ 0.00"
        lvStock.Columns(5).DefaultCellStyle.Format = "R$ 0.00"
        lvStock.Columns(6).DefaultCellStyle.Format = "R$ 0.00"
        lvStock.ColumnHeadersDefaultCellStyle.Font = New Font(lvStock.DefaultCellStyle.Font, FontStyle.Bold)
        lvStock.DefaultCellStyle.Font = New Font(fontName, 14, FontStyle.Bold)
        lvPurchases.DefaultCellStyle.Font = New Font(fontName, 12)
        lvPurchases.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvOrders.DefaultCellStyle.Font = New Font(fontName, 12)
        lvOrders.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvClients.DefaultCellStyle.Font = New Font(fontName, 12)
        lvClients.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)

        FormatStock()

    End Sub

    Public Sub FormatStock()
        With lvStock
            For i = 0 To .Rows.Count - 1
                If .Item(2, i).Value > 30 Then
                    .Item(2, i).Style.ForeColor = Color.Green
                ElseIf .Item(2, i).Value > 0 And .Item(2, i).Value <= 30 Then
                    .Item(2, i).Style.ForeColor = Color.DarkGoldenrod
                Else
                    .Item(2, i).Style.ForeColor = Color.Red
                End If
            Next
        End With
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub ChangePics()
        Select Case Main.companyName
            Case "ChoppExpress"
                picLogoCE.Visible = True
                picLogoLJ.Visible = False
            Case "L'jaica"
                picLogoCE.Visible = False
                picLogoLJ.Visible = True
            Case Else
                picLogoCE.Visible = False
                picLogoLJ.Visible = False
        End Select
    End Sub

    Public Sub ChangeColors()

        Select Case Main.companyName

            Case "ChoppExpress"
                primaryColor = Color.FromArgb(255, 255, 255, 128)
                secondaryColor = Color.DarkRed

            Case "L'jaica"
                primaryColor = Color.PaleGreen
                secondaryColor = Color.DarkGreen

            Case Else
                primaryColor = SystemColors.Control
                secondaryColor = SystemColors.ControlDarkDark

        End Select

        RecursiveColorChange(Me, primaryColor, secondaryColor)

        For Each item In menu.Items
            item.BackColor = primaryColor
        Next
        menu.BackColor = primaryColor
        MenuToolStripMenuItem.BackColor = secondaryColor


        split.BackColor = Color.Black
        lvOrders.DefaultCellStyle.BackColor = Color.PeachPuff
        lvPurchases.DefaultCellStyle.BackColor = Color.LightBlue
        lvClients.DefaultCellStyle.BackColor = SystemColors.Control

    End Sub

    Public Sub RecursiveColorChange(c As Object,
                                    color As Color,
                                    Optional color2 As Color = Nothing)
        Try
            c.BackColor = color
            If Not IsNothing(color2) Then
                If TypeOf c Is DataGridView Then
                    c.DefaultCellStyle.BackColor = color
                    c.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control
                    c.DefaultCellStyle.SelectionBackColor = color2
                End If
            End If
        Catch ex As Exception
        End Try

        For Each cc As Control In c.Controls
            Try
                RecursiveColorChange(cc, color, color2)
            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub lvStock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvStock.CellContentClick

        Dim cells = lvStock.SelectedCells

        For Each cell As DataGridViewCell In cells
            If Not cell.ColumnIndex = 0 Then Exit Sub
            Dim pID = lvStock(0, cell.RowIndex).Value.ToString
            For Each p In products.Values
                If p.Code = pID Then
                    Dim productForm As New ProductForm(p)
                    productForm.Show()
                    Exit Sub
                End If
            Next
        Next

    End Sub

    Private Sub lvClients_Change(sender As Object, e As DataGridViewCellEventArgs)
        Try
            WriteCSV(tableClients, NameOf(tableClients), "|", True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lvOrders_Change(sender As Object, e As DataGridViewCellEventArgs)
        Try
            WriteCSV(tableOrders, NameOf(tableOrders), "|", True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lvPurchases_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles lvPurchases.CellLeave
        Try
            WriteCSV(tablePurchases, NameOf(tablePurchases), "|", True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        Dim addProductForm As New ProductAddForm
        With addProductForm
            .Show()
        End With
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim purchaseForm As New OrderForm
        With purchaseForm
            .FormType = OrderForm.FormTypes.Purchase
            .Show()
        End With
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim orderForm As New OrderForm
        With orderForm
            .FormType = OrderForm.FormTypes.Order
            .Show()
        End With
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim inventoryForm As New InventoryForm
        inventoryForm.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim reportForm As New ReportForm
        reportForm.Show()
    End Sub

    Private Sub lvStock_Sorted(sender As Object, e As EventArgs) Handles lvStock.Sorted
        FormatStock()
    End Sub

    Private Sub lvStock_CellChanged(sender As Object, e As DataGridViewCellEventArgs) Handles lvStock.CellEndEdit
        Dim pCode As String
        Try
            pCode = lvStock.Item(0, e.RowIndex).Value.ToString
        Catch ex As Exception
            Exit Sub
        End Try

        Select Case e.ColumnIndex

            Case 4 'PREÇO  
                Try
                    products(pCode).Cost = CDbl(lvStock.Item(e.ColumnIndex, e.RowIndex).Value)
                Catch ex As Exception

                End Try
            Case 5 'CUSTO    
                Try
                    products(pCode).Price = CDbl(lvStock.Item(e.ColumnIndex, e.RowIndex).Value)
                Catch ex As Exception

                End Try

        End Select

        Main.UpdateTables()
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click

        If bgw.IsBusy Then
            isSyncing = False
            bgw.CancelAsync()
            bgw.Dispose()
            btnSync.Image = My.Resources.syncing_static
            Exit Sub
        End If

        isSyncing = True
        btnSync.Image = My.Resources.syncing
        bgw.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork

        Main.SyncTables()

    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted

        btnSync.Image = My.Resources.syncing_static
        lblSync.Text = "-"

    End Sub

    Private Sub EmpresaToolStripComboBox_TextChanged(sender As Object, e As EventArgs) Handles EmpresaToolStripComboBox.TextChanged

        Main.companyName = EmpresaToolStripComboBox.Text

        If Main.companyName = "ChoppExpress" Then
            Dim loginForm As New LoginForm
            loginForm.Show()
            Exit Sub
        End If

        Main.Start()
        LoadTables()
        ChangePics()
        ChangeColors()
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
        LoadTables()
    End Sub

    Private Sub lvClients_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles lvClients.UserDeletingRow

        Main.clients.Remove(lvClients.Item(0, e.Row.Index).Value)
        Main.tableClients.Rows.Remove(Main.tableClients.Rows(e.Row.Index))

        Main.UpdateTables()
        Main.GetTables()
        LoadTables()
    End Sub

    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        lblSync.Text = currentSync

    End Sub

    Private Sub lvStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvStock.CellFormatting

        If {6}.Contains(e.ColumnIndex) And e.Value.ToString = "0" Then
            e.Value = "-"
        End If

    End Sub

End Class
