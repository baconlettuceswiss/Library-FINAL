Public Class Login
    Public Shared memberID As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim NumberOfRows As Integer
        Dim RowData As Object
        Dim Password As String = String.Empty
        If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
            MessageBox.Show("please enter your email and password")
        Else
            'how many records contain the email provided by the user?
            NumberOfRows = MembersTableAdapter.FillByEmail(LibraryDataSet.Members, txtUsername.Text)
            'if there is one existing record with the email then get the user's record with the getdataby method
            'and put the record (really point to the record) in the object "RowData" then get the email from the object.
            'The dataset's index names will match the names of the columns in the table. 
            'Thus RowData.Password points to the user's password
            If NumberOfRows = 1 Then

                RowData = MembersTableAdapter.GetDataByEmail(txtUsername.Text)(0)
                Password = RowData.Password

                'entered password = DB PW
                If Password = txtPW.Text Then
                    'MessageBox.Show("Login successful")

                    memberID = RowData.MemberID

                    Dim WelcomeForm As WelcomePage
                    WelcomeForm = New WelcomePage
                    WelcomeForm.Show()
                    Me.Visible = False
                    'txtbox PW != DB PW
                Else
                    MessageBox.Show("Login unsuccessful")
                    txtPW.Clear()
                End If

                'empty txtbox
            Else
                If txtUsername.Text = String.Empty Or txtPW.Text = String.Empty Then
                    MessageBox.Show("please enter your email and password")
                Else
                    'how many records contain the email provided by the user?
                    NumberOfRows = EmployeesTableAdapter.FillByEmployeeEmail(LibraryDataSet.Employees, txtUsername.Text)
                    'if there is one existing record with the email then get the user's record with the getdataby method
                    'and put the record (really point to the record) in the object "RowData" then get the email from the object.
                    'The dataset's index names will match the names of the columns in the table. 
                    'Thus RowData.Password points to the user's password
                    If NumberOfRows = 1 Then

                        RowData = EmployeesTableAdapter.GetDataByEmployeeEmail(txtUsername.Text)(0)
                        Password = RowData.Password

                        If Password = txtPW.Text Then
                            'MessageBox.Show("Login successful")

                            memberID = RowData.EmployeeID

                            Dim EmployeeWelcomeForm As EmployeeWelcome
                            EmployeeWelcomeForm = New EmployeeWelcome
                            EmployeeWelcomeForm.Show()
                            Me.Visible = False
                        Else
                            MessageBox.Show("Login unsuccessful")
                            txtPW.Clear()
                        End If

                    Else
                        MessageBox.Show("No user has registered with this email, please try a different email or register as a new user")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim RegistrationForm As Registration
        RegistrationForm = New Registration
        RegistrationForm.Show()
        Me.Visible = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPW.Clear()
    End Sub


End Class



