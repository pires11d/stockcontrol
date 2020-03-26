Imports StockLib

''' <summary>
''' Form responsible for the addition of a new <see cref="Product"/> into the <see cref="Main.productTables"/> 
''' </summary>
Public Class NewProductForm

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

        tbCost.Text = "0"
        tbPrice.Text = "0"

    End Sub

    Public Function pCode()
        Return pKind + "-" + pName
    End Function

    Private Sub cbbKind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbKind.SelectedIndexChanged
        pKind = cbbKind.Text
        lblCode.Text = pCode()
    End Sub

    Private Sub cbbVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbVendor.SelectedIndexChanged
        pVendor = cbbVendor.Text
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        pName = tbName.Text
        lblCode.Text = pCode()
    End Sub

    Private Sub tbCost_TextChanged(sender As Object, e As EventArgs) Handles tbCost.TextChanged
        Try
            pCost = CDbl(tbCost.Text)
        Catch ex As Exception
            pCost = 0
        End Try
    End Sub

    Private Sub tbPrice_TextChanged(sender As Object, e As EventArgs) Handles tbPrice.TextChanged
        Try
            pPrice = CDbl(tbPrice.Text)
        Catch ex As Exception
            pPrice = 0
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click





    End Sub


End Class