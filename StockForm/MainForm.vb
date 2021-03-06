﻿Imports StockLib


''' <summary>
''' Main Interface, contains a MenuStrip that works as a control panel.
''' <para></para>
''' Has all important tables displayed as DataGridView objects.
''' </summary>
Public Class MainForm

    Public stockSchema As New ProductStock
    Public primaryColor As Color
    Public secondaryColor As Color
    Public greenColor As Color = Color.FromArgb(255, 128, 255, 128)
    Public redColor As Color = Color.FromArgb(255, 255, 128, 128)
    Public yellowColor As Color = Color.FromArgb(255, 255, 255, 128)
    Public blueColor As Color = Color.FromArgb(255, 224, 240, 240)
    Public orangeColor As Color = Color.FromArgb(255, 255, 240, 192)
    Public oldValue As String
    Public rowAdded As Boolean = False

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpresaToolStripComboBox.SelectedText = "<Empresa>"

        For Each item In menu.Items
            item.Enabled = Equals(item, EmpresaToolStripComboBox)
        Next

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
        OrderRegistrySchema.PurchasesTable.Clear()
        With tablePurchases
            For i = 0 To .Rows.Count - 1
                OrderRegistrySchema.PurchasesTable.AddPurchasesTableRow(.Rows(i).Item(0),
                                                                        .Rows(i).Item(6).ToString.ToBoolNotNull,
                                                                        CDbl(.Rows(i).Item(4)),
                                                                        .Rows(i).Item(1),
                                                                        .Rows(i).Item(2),
                                                                        .Rows(i).Item(3),
                                                                        .Rows(i).Item(5))
            Next
        End With

        'LOADS ORDERS TABLE INTO DATAGRIDVIEW
        OrderRegistrySchema.SalesTable.Clear()
        Dim dv2 As New DataView(tableOrders)
        dv2.Sort = "ID ASC"
        Dim dt2 = dv2.ToTable
        With tableOrders
            For i = 0 To .Rows.Count - 1
                OrderRegistrySchema.SalesTable.AddSalesTableRow(CInt(.Rows(i).Item(0)),
                                                                .Rows(i).Item(13).ToString.ToBoolNotNull,
                                                                CDbl(.Rows(i).Item(11)),
                                                                .Rows(i).Item(1),
                                                                .Rows(i).Item(3),
                                                                .Rows(i).Item(4),
                                                                .Rows(i).Item(9),
                                                                .Rows(i).Item(10),
                                                                .Rows(i).Item(2),
                                                                .Rows(i).Item(5),
                                                                .Rows(i).Item(6),
                                                                .Rows(i).Item(7),
                                                                .Rows(i).Item(8),
                                                                .Rows(i).Item(12))
            Next i
        End With

        ApplyStylesToTables()

        For Each item In menu.Items
            item.Enabled = True
        Next

    End Sub

    Public Sub ApplyStylesToTables()

        lvStock.DefaultCellStyle.Font = New Font(fontName, 14, FontStyle.Bold)
        lvStock.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 14, FontStyle.Bold)
        lvStock.Columns(4).DefaultCellStyle.Format = "0.00"
        lvStock.Columns(5).DefaultCellStyle.Format = "0.00"
        lvStock.Columns(6).DefaultCellStyle.Format = "R$ 0.00"

        lvPurchases.DefaultCellStyle.Font = New Font(fontName, 12)
        lvPurchases.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvPurchases.Columns(2).DefaultCellStyle.Format = "R$ 0.00"

        lvSales.DefaultCellStyle.Font = New Font(fontName, 12)
        lvSales.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvSales.Columns(2).DefaultCellStyle.Format = "R$ 0.00"
        'lvSales.Columns(0).DefaultCellStyle.Format = "000"

        FormatStock()
        FormatPurchases()
        FormatSales()

    End Sub

    Public Sub FormatPurchases()
        For i = 0 To lvPurchases.Rows.Count - 1
            FormatPayment(lvPurchases, i, lvPurchases.Item(1, i).Value)
        Next
    End Sub

    Public Sub FormatSales()
        For i = 0 To lvSales.Rows.Count - 1
            FormatPayment(lvSales, i, lvSales.Item(1, i).Value)
        Next
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
        CUSTODataGridViewTextBoxColumn.DefaultCellStyle.ForeColor = Color.Navy
        PREÇODataGridViewTextBoxColumn.DefaultCellStyle.ForeColor = Color.Navy
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
                Dim PaleYellow = Color.FromArgb(255, 255, 255, 128)
                primaryColor = PaleYellow
                secondaryColor = Color.Red

            Case "L'jaica"
                primaryColor = Color.PaleGreen
                secondaryColor = Color.Green

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
        lvSales.DefaultCellStyle.BackColor = orangeColor
        lvSales.DefaultCellStyle.SelectionBackColor = orangeColor
        lvPurchases.DefaultCellStyle.BackColor = blueColor
        lvPurchases.DefaultCellStyle.SelectionBackColor = blueColor

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
                    c.DefaultCellStyle.SelectionBackColor = color
                    c.DefaultCellStyle.SelectionForeColor = Color.Navy
                    c.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Control
                    c.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Navy
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

    Private Sub lvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvStock.CellContentClick

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

    Private Sub lvStock_Sorted(sender As Object, e As EventArgs) Handles lvStock.Sorted
        FormatStock()
    End Sub
    Private Sub lvPurchases_Sorted(sender As Object, e As EventArgs) Handles lvPurchases.Sorted
        FormatPurchases()
    End Sub
    Private Sub lvSales_Sorted(sender As Object, e As EventArgs) Handles lvSales.Sorted
        FormatSales()
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
                    Main.products(pCode).Cost = CDbl(lvStock.Item(e.ColumnIndex, e.RowIndex).Value)
                Catch ex As Exception
                End Try
            Case 5 'CUSTO    
                Try
                    Main.products(pCode).Price = CDbl(lvStock.Item(e.ColumnIndex, e.RowIndex).Value)
                Catch ex As Exception
                End Try

        End Select

        Main.UpdateTables()

    End Sub

    Private Sub lvClients_Change(sender As Object, e As DataGridViewCellEventArgs)
        Try
            WriteCSV(tableClients, NameOf(tableClients), "|", True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        Dim addProductForm As New ProductAddForm
        With addProductForm
            'Me.Hide()
            .Show()
        End With
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim purchaseForm As New OrderForm
        With purchaseForm
            'Me.Hide()
            .FormType = OrderForm.FormTypes.Purchase
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim orderForm As New OrderForm
        With orderForm
            'Me.Hide()
            .FormType = OrderForm.FormTypes.Sale
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim inventoryForm As New InventoryForm
        'Me.Hide()
        inventoryForm.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim reportForm As New ReportForm
        'Me.Hide()
        reportForm.Show()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientToolStripMenuItem.Click
        Dim clientForm As New ClientForm
        'Me.Hide()
        clientForm.Show()
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

        If EmpresaToolStripComboBox.Items.Contains(Main.companyName) Then
            Dim loginForm As New LoginForm
            loginForm.Show()
            loginForm.BringToFront()
        End If

    End Sub

    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        lblSync.Text = currentSync

    End Sub

    Private Sub lvStock_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles lvStock.CellFormatting
        If {6}.Contains(e.ColumnIndex) And e.Value.ToString = "0" Then
            e.Value = "-"
        End If
    End Sub

    Private Sub GraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphToolStripMenuItem.Click
        Dim graphForm As New GraphForm
        'Me.Hide()
        graphForm.Show()
    End Sub

    Private Sub notifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notifyIcon.MouseDoubleClick
        Show()
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Show()
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Hide()
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub lvSales_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles lvSales.CellMouseUp
        If e.ColumnIndex = 1 Then
            Try
                lvSales.Item(1, e.RowIndex).Value = Not lvSales.Item(1, e.RowIndex).Value

                Dim id = lvSales.Item(0, e.RowIndex).Value.ToString
                Dim paid = lvSales.Item(1, e.RowIndex).Value.ToString.ToBoolNotNull
                FormatPayment(lvSales, e.RowIndex, paid)
                PaySale(id, paid)
                lvSales.RefreshEdit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub lvPurchases_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles lvPurchases.CellMouseUp
        If e.ColumnIndex = 1 Then
            Try
                lvPurchases.Item(1, e.RowIndex).Value = Not lvPurchases.Item(1, e.RowIndex).Value

                Dim id = lvPurchases.Item(0, e.RowIndex).Value.ToString
                Dim paid = lvPurchases.Item(1, e.RowIndex).Value.ToString.ToBoolNotNull
                FormatPayment(lvPurchases, e.RowIndex, paid)
                PayPurchase(id, paid)
                lvPurchases.RefreshEdit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub lvSales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvSales.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Try
                lvSales.Item(1, e.RowIndex).Value = Not lvSales.Item(1, e.RowIndex).Value

                Dim id = lvSales.Item(0, e.RowIndex).Value.ToString
                Dim paid = lvSales.Item(1, e.RowIndex).Value.ToString.ToBoolNotNull
                FormatPayment(lvSales, e.RowIndex, paid)
                PaySale(id, paid)
                lvSales.RefreshEdit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub lvPurchases_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvPurchases.CellDoubleClick
        If e.ColumnIndex = 1 Then
            Try
                lvPurchases.Item(1, e.RowIndex).Value = Not lvPurchases.Item(1, e.RowIndex).Value

                Dim id = lvPurchases.Item(0, e.RowIndex).Value.ToString
                Dim paid = lvPurchases.Item(1, e.RowIndex).Value.ToString.ToBoolNotNull
                FormatPayment(lvPurchases, e.RowIndex, paid)
                PayPurchase(id, paid)
                lvPurchases.RefreshEdit()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub FormatPayment(dgv As DataGridView, row As Integer, state As Boolean)

        For col = 0 To dgv.Columns.Count - 1
            If state Then
                dgv.Item(col, row).Style.ForeColor = Color.Black
                'dgv.Item(col, row).Style.Font = New Font(dgv.Item(col, row).Style.Font, FontStyle.Regular)
            Else
                dgv.Item(col, row).Style.ForeColor = Color.Red
                'dgv.Item(col, row).Style.Font = New Font(dgv.Item(col, row).Style.Font, FontStyle.Bold)
            End If
        Next

    End Sub

    Public Sub PayPurchase(id As String, paid As Boolean)

        Main.purchases(id).Paid = paid
        For Each p In Main.products.Values
            If p.Purchases.ContainsKey(id) Then
                p.Purchases(id).Paid = paid
            End If
        Next

        Main.UpdateTables()

    End Sub

    Public Sub PaySale(id As String, paid As Boolean)

        Main.sales(id).Paid = paid
        For Each p In Main.products.Values
            If p.Sales.ContainsKey(id) Then
                p.Sales(id).Paid = paid
            End If
        Next

        Main.UpdateTables()

    End Sub

    Private Sub lvSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvSales.CellContentClick
        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
            Dim frm As New OrderForm
            frm.FormType = OrderForm.FormTypes.Sale
            frm.Show()
            frm.tbID.Text = lvSales.Item(0, e.RowIndex).Value
        End If
    End Sub

    Private Sub lvPurchases_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles lvPurchases.CellContentClick
        If e.ColumnIndex = 0 And e.RowIndex >= 0 Then
            Dim frm As New OrderForm
            frm.FormType = OrderForm.FormTypes.Purchase
            frm.Show()
            frm.tbID.Text = lvPurchases.Item(0, e.RowIndex).Value
        End If
    End Sub

End Class
