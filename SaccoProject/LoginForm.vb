Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        BunifuPage.SetPage(0)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        BunifuPage.SetPage(1)
    End Sub



    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        BunifuPage.SetPage(2)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        MainForm.Show()
        Me.Hide()
    End Sub
End Class
