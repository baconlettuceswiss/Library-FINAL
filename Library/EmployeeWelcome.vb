Public Class EmployeeWelcome
    Private Sub EmployeeWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        Dim AddResourceForm As AddResource
        AddResourceForm = New AddResource
        AddResourceForm.Show()
        Me.Visible = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim MemberSearchForm As MemberSearch
        MemberSearchForm = New MemberSearch
        MemberSearch.Show()
        Me.Visible = False
    End Sub

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub
End Class