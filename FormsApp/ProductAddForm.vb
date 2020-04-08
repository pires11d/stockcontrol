Imports StockLib


''' <summary>
''' Form responsible for the addition of new <see cref="Product"/> objects into the <see cref="Main.productTables"/> 
''' </summary>
Public Class ProductAddForm

    Public pKind As String = ""
    Public pName As String = ""
    Public pVendor As String = ""
    Public pCost As Double = 0
    Public pPrice As Double = 0

    Private Sub NewProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbKind.Items.Clear()
        For Each k In Product.Kinds
            cbbKind.Items.Add(k)
        Next
        cbbKind.SelectedIndex = 0

        cbbVendor.Items.Clear()
        For Each v In Main.vendors.Keys
            cbbVendor.Items.Add(v)
        Next
        cbbVendor.SelectedIndex = 0

        tbCost.Text = "0.00"
        tbPrice.Text = "0.00"

    End Sub

    Public Function pCode()
        Return pKind + "-" + pName
    End Function

    Private Sub cbbKind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbKind.SelectedIndexChanged
        pKind = cbbKind.Text
        lblCode.Text = pCode()
    End Sub

    Private Sub cbbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVendor.SelectedIndexChanged, cbbVendor.TextChanged
        pVendor = cbbVendor.Text
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        pName = tbName.Text
        lblCode.Text = pCode()
    End Sub

    Private Sub tbCost_TextChanged(sender As Object, e As EventArgs) Handles tbCost.TextChanged
        Try
            pCost = CDbl(tbCost.Text)
            tbCost.Text = pCost.ToString("0.00")
            If pCost > 0 Then
                Dim i = Len(CStr(CInt(pCost)))
                tbCost.Select(i, 0)
            End If
        Catch ex As Exception
            pCost = 0
            tbCost.Text = "0.00"
        End Try
    End Sub

    Private Sub tbPrice_TextChanged(sender As Object, e As EventArgs) Handles tbPrice.TextChanged
        Try
            pPrice = CDbl(tbPrice.Text)
            tbPrice.Text = pPrice.ToString("0.00")
            If pPrice > 0 Then
                Dim i = Len(CStr(CInt(pPrice)))
                tbPrice.Select(i, 0)
            End If
        Catch ex As Exception
            pPrice = 0
            tbPrice.Text = "0.00"
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If products.ContainsKey(pCode) Then
            MsgBox("O produto de código " + pCode() + " já existe!" + vbNewLine + "Por favor, altere o nome do produto.", MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End If

        Dim pNew As New Product(pCode)
        pNew.Brand = pVendor
        pNew.Stock = 0
        pNew.Quantity = 0
        pNew.Cost = pCost.ErrorsToZero
        pNew.Price = pPrice.ErrorsToZero
        pNew.Value = 0

        Dim pNewTable = New DataTable
        For Each column In Main.products.FirstOrDefault.Value.Table.Columns
            pNewTable.Columns.Add(column.ToString)
        Next
        pNew.Table = pNewTable

        Main.products.Add(pNew.Code, pNew)
        'Main.productTables.Add(pNew.Code, pNewTable)
        Main.tableProducts.Rows.Add()
        With Main.tableProducts
            Dim lastRow = .Rows.Count - 1
            .Rows(lastRow).Item("PRODUTO") = pNew.Code
            .Rows(lastRow).Item("MARCA") = pNew.Brand
            .Rows(lastRow).Item("ESTOQUE") = pNew.Stock
            .Rows(lastRow).Item("QTD") = pNew.Quantity
            .Rows(lastRow).Item("CUSTO") = pNew.Cost
            .Rows(lastRow).Item("PREÇO") = pNew.Price
            .Rows(lastRow).Item("VALOR") = pNew.Value
        End With

        If Not Main.vendors.ContainsKey(pVendor) Then
            Main.vendors.Add(pVendor, New Vendor(pVendor))
        End If

        Main.UpdateTables()
        Main.GetTables()
        MainForm.LoadTables()

        Me.Close()

    End Sub


End Class