Imports StockLib


''' <summary>
''' 
''' </summary>
Public Class InventoryAddForm

    Public Sub New(kind As Item.Kinds, Optional item As Item = Nothing)

        InitializeComponent()

        Me.Kind = kind
        Me.Item = item

    End Sub

    Public Kind As Item.Kinds

    Public Item As Item

    Public Caller As InventoryForm

    Private Sub InventoryAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbKind.Items.Clear()
        cbbKind.Items.AddRange({"Barril", "Chopeira"})
        cbbKind.SelectedIndex = Kind

        cbbType.SelectedIndex = 0

        cbbKind.Enabled = IsNothing(Item)
        If Not IsNothing(Item) Then
            tbID.Text = Item.ID
            cbbType.Text = Item.Type
        End If

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
        Dim iID = tbID.Text

        If IsNothing(Item) Then

            Select Case cbbKind.SelectedIndex
                Case Item.Kinds.Barril
                    Dim i As New Barrel(iID)
                    i.Type = iType
                    Main.barrels.Add(i.ID, i)
                    tableBarrels.Rows.Add(i.ID,
                                          i.Type,
                                          i.State.ToString,
                                          "-")
                Case Item.Kinds.Chopeira
                    Dim i As New Cooler(iID)
                    i.Type = iType
                    Main.coolers.Add(iID, i)
                    tableCoolers.Rows.Add(i.ID,
                                          i.Type,
                                          i.State.ToString)
                Case Else
            End Select

        Else

            Select Case cbbKind.SelectedIndex
                Case Item.Kinds.Barril
                    Dim oldItem = Main.barrels(Item.ID)
                    oldItem.ID = iID
                    oldItem.Type = iType
                    Main.barrels.Remove(Item.ID)
                    Main.barrels.Add(oldItem.ID, oldItem)
                    With tableBarrels
                        For i = 0 To .Rows.Count - 1
                            If .Rows(i).Item("ID") = Item.ID Then
                                .Rows(i).Item("ID") = iID
                                .Rows(i).Item("TIPO") = iType
                            End If
                        Next
                    End With
                Case Item.Kinds.Chopeira
                    Dim oldItem = Main.coolers(Item.ID)
                    oldItem.ID = iID
                    oldItem.Type = iType
                    Main.coolers.Remove(Item.ID)
                    Main.coolers.Add(oldItem.ID, oldItem)
                    With tableCoolers
                        For i = 0 To .Rows.Count - 1
                            If .Rows(i).Item("ID") = Item.ID Then
                                .Rows(i).Item("ID") = iID
                                .Rows(i).Item("TIPO") = iType
                            End If
                        Next
                    End With
                Case Else
            End Select

        End If

        Main.UpdateTables()
        Caller.LoadTreeViews()
        Me.Close()

    End Sub


End Class