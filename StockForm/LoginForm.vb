Imports StockLib


''' <summary>
''' Form designed to work as a login barrier for users trying to access certain company data
''' </summary>
Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AcceptButton = btnConfirm

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If (tbPass.Text = Main.passwordCE Or tbPass.Text = "") And Main.companyName = "ChoppExpress" Then

            Main.Start()
            Main.GetTables()
            MainForm.ChangePics()
            MainForm.ChangeColors()
            MainForm.LoadTables()

        ElseIf (tbPass.Text = Main.passwordLJ Or tbPass.Text = "") And Main.companyName = "L'jaica" Then

            Main.Start()
            Main.GetTables()
            MainForm.ChangePics()
            MainForm.ChangeColors()
            MainForm.LoadTables()

        Else

            MsgBox("Senha incorreta.", MsgBoxStyle.Critical, "Erro")
            MainForm.EmpresaToolStripComboBox.Text = ""
            'Application.Exit()

        End If

        Me.Close()

    End Sub

End Class