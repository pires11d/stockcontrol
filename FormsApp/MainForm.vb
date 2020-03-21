Imports StockLib
Imports StockLib.Main
Imports StockLib.Extensions


Public Class MainForm
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbCompany.SelectedIndex = 0
        Main.Start()
        LoadTables()

    End Sub

    Public Sub LoadTables()

        lvOrders.DataSource = tableOrders
        lvPurchases.DataSource = tablePurchases
        lvClients.DataSource = tableClients
        lvStock.DataSource = tableStock

        lvStock.DefaultCellStyle.Font = New Font("Century", 14, FontStyle.Bold)

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
        lvOrders.DefaultCellStyle.BackColor = Color.LightSalmon
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

    Private Sub lvClients_Change(sender As Object, e As DataGridViewCellEventArgs) Handles lvClients.CellLeave
        WriteCSV(tableClients, NameOf(tableClients), "|", True)
    End Sub
    Private Sub lvOrders_Change(sender As Object, e As DataGridViewCellEventArgs) Handles lvOrders.CellLeave
        WriteCSV(tableOrders, NameOf(tableOrders), "|", True)
    End Sub
    Private Sub lvPurchases_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles lvPurchases.CellLeave
        WriteCSV(tablePurchases, NameOf(tablePurchases), "|", True)
    End Sub

End Class
