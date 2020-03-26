﻿Imports StockLib
Imports StockLib.Extensions


''' <summary>
''' Main Interface, contains a MenuStrip that works as a control panel.
''' <para></para>
''' Has all important tables displayed as DataGridView objects.
''' </summary>
Public Class MainForm

    Public stockSchema As New ProductStock

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbCompany.SelectedIndex = 0
        Main.Start()
        LoadTables()

    End Sub

    Public Sub LoadTables()

        ProductStockSchema.StockTable.Clear()

        With tableProducts
            For i = 0 To .Rows.Count - 1
                ProductStockSchema.StockTable.AddStockTableRow(.Rows(i).Item(0),
                                                        .Rows(i).Item(1),
                                                        CDbl(.Rows(i).Item(2).ToString.ToZero),
                                                        .Rows(i).Item(3),
                                                        CDbl(.Rows(i).Item(6).ToString.ToZero),
                                                        CDbl(.Rows(i).Item(7).ToString.ToZero))
            Next i
        End With

        lvPurchases.DataSource = tablePurchases
        lvOrders.DataSource = tableOrders
        lvClients.DataSource = tableClients

        ApplyStylesToTables("Century Gothic")

    End Sub

    Public Sub ApplyStylesToTables(fontName As String)

        lvStock.Columns(4).DefaultCellStyle.Format = "R$ 0.00"
        lvStock.Columns(5).DefaultCellStyle.Format = "R$ 0.00"
        lvStock.ColumnHeadersDefaultCellStyle.Font = New Font(lvStock.DefaultCellStyle.Font, FontStyle.Bold)
        lvStock.DefaultCellStyle.Font = New Font(fontName, 14, FontStyle.Bold)
        lvPurchases.DefaultCellStyle.Font = New Font(fontName, 12)
        lvPurchases.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvOrders.DefaultCellStyle.Font = New Font(fontName, 12)
        lvOrders.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)
        lvClients.DefaultCellStyle.Font = New Font(fontName, 12)
        lvClients.ColumnHeadersDefaultCellStyle.Font = New Font(fontName, 12, FontStyle.Bold)

    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cbbCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCompany.SelectedIndexChanged
        Main.companyName = cbbCompany.Text
        Main.Start()
        LoadTables()
        ChangePics()
        ChangeColors()
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
                RecursiveColorChange(Me, Color.Khaki, Color.Red)
                For Each item As ToolStripMenuItem In menu.Items
                    item.BackColor = Color.Khaki
                Next
                menu.BackColor = Color.Khaki
                MenuToolStripMenuItem.BackColor = Color.Red
            Case "L'jaica"
                RecursiveColorChange(Me, Color.PaleGreen, Color.ForestGreen)
                For Each item As ToolStripMenuItem In menu.Items
                    item.BackColor = Color.PaleGreen
                Next
                menu.BackColor = Color.PaleGreen
                MenuToolStripMenuItem.BackColor = Color.ForestGreen
            Case Else
                RecursiveColorChange(Me, SystemColors.Control, SystemColors.ControlDarkDark)
                For Each item As ToolStripMenuItem In menu.Items
                    item.BackColor = SystemColors.Control
                Next
                menu.BackColor = SystemColors.Control
                MenuToolStripMenuItem.BackColor = SystemColors.ControlDarkDark
        End Select

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

    Private Sub lvStock_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvStock.Click
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

    Private Sub lvClients_Change(sender As Object, e As DataGridViewCellEventArgs) Handles lvClients.CellLeave
        Try
            WriteCSV(tableClients, NameOf(tableClients), "|", True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lvOrders_Change(sender As Object, e As DataGridViewCellEventArgs) Handles lvOrders.CellLeave
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
        Dim newProductForm As New NewProductForm
        With newProductForm
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

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

End Class
