Public Class WelcomePage
    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim LoginPage As Login
        LoginPage = New Login
        LoginPage.Show()
        Me.Visible = False
    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click
        Dim MemberAccountForm As MemberAccount
        MemberAccountForm = New MemberAccount
        MemberAccountForm.Show()
        Me.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim MemberSearchForm As MemberSearch
        MemberSearchForm = New MemberSearch
        MemberSearchForm.Show()
        Me.Visible = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class