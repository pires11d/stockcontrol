Imports StockLib


''' <summary>
''' 
''' </summary>
Public Class InventoryAddForm

    Public Sub New(kind As Item.Kinds)

        InitializeComponent()

        Me.Kind = kind

    End Sub

    Public Kind As Item.Kinds

    Public Caller As InventoryForm

    Private Sub InventoryAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbKind.Items.Clear()
        cbbKind.Items.AddRange({"Barril", "Chopeira"})
        cbbKind.SelectedIndex = Kind

        cbbType.SelectedIndex = 0

    End Sub

    Private Sub cbbKind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbKind.SelectedIndexChanged, cbbKind.SelectedValueChanged

        cbbType.Items.Clear()
        If cbbKind.Text = Item.Kinds.Barril.ToString Then
            cbbType.Items.AddRange(Barrel.Types.ToArray)
        Else
            cbbType.Items.AddRange(Cooler.Types.ToArray)
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim iKind = cbbKind.Text
        Dim iType = cbbType.Text
        Dim iCode = tbID.Text

        Select Case cbbKind.SelectedIndex
            Case Item.Kinds.Barril
                Dim i As New Barrel(iCode)
                i.Type = iType
                barrels.Add(i.ID, i)
                tableBarrels.Rows.Add(i.ID,
                                      i.Type,
                                      i.State.ToString,
                                      "-")

            Case Item.Kinds.Chopeira
                Dim i As New Cooler(iCode)
                i.Type = iType
                coolers.Add(iCode, i)
                tableCoolers.Rows.Add(i.ID,
                                      i.Type,
                                      i.State.ToString)

            Case Else

        End Select

        Main.UpdateTables()
        Caller.LoadTreeViews()
        Me.Close()

    End Sub


End Class