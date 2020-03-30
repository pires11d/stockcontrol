Imports StockLib

''' <summary>
''' Form designed to work as a login barrier for users trying to access certain company data
''' </summary>
Public Class LoginForm

    Private passwordLJ As String = "positividade"
    Private passwordCE As String = "pires223"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnConfirm
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If tbPass.Text = passwordCE Then

            Main.Start()
            MainForm.LoadTables()
            MainForm.ChangePics()
            MainForm.ChangeColors()

        Else

            MsgBox("Senha incorreta.", MsgBoxStyle.Critical, "Erro")
            MainForm.EmpresaToolStripComboBox.SelectedIndex = 0

        End If

        Me.Close()

    End Sub

End Class