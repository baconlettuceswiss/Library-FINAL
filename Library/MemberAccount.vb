Public Class MemberAccount
    Dim CheckoutPeriod As Long
    Dim NumberOfRows As Integer
    Dim CheckedOutRecord As Integer
    Dim bookInfo As Object
    Dim resourceID As String
    Dim ResourceStatus As String
    Dim DueDate As Date

    Dim MemberID As String = Login.memberID
    Dim RowData As Object

    Private Sub LoadDataGrid()
        Dim CheckoutDate As Date

        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)


        'Results.Rows.Clear()
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckout(LibraryDataSet.Checkout, MemberID)

        If NumberOfRows > 0 Then

            Results.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = CheckoutTableAdapter.GetDataByMemberCheckout(MemberID)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                'calculate the due date for a book based on the check out date and the book’s checkout period.
                CheckoutDate = bookInfo.checkoutdate
                CheckoutPeriod = RowData.checkoutperiod
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, CheckoutDate)
                'at “due” to the due date so that the member knows when the book is due
                ResourceStatus = "Due " & DueDate.Date

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add ID to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ResourceID
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 8th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)



                'add title to the first column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author’s last name to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorFirstName & " " & RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add genre to the 3rd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Subject1
                dgvRow.Cells.Add(dgvCell)


                'add checkout data to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = CheckoutDate.Date
                dgvRow.Cells.Add(dgvCell)

                'add resourcestatus, created above, to the 6th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = ResourceStatus
                dgvRow.Cells.Add(dgvCell)

                Results.Rows.Add(dgvRow)
                'Results is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        End If



    End Sub

    Private Sub MemberAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.LibraryDataSet.Employees)
        'TODO: This line of code loads data into the 'LibraryDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.Members)
        LoadDataGrid()


    End Sub

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CheckoutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim currentdate As Date = Date.Today.Date
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckout(LibraryDataSet.Checkout, MemberID)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If Results.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew")
            Else
                'return book by altering the due date and updating the record selected in ‘the “results” data grid the numbers in parentheses are the index of the ‘data grid column holding the piece of information needed.
                resourceID = Results.SelectedCells(0).Value

                CheckoutTableAdapter.ReturnBookUpdateQuery(currentdate, resourceID)

                Results.SelectedCells(6).Value = currentdate

                MessageBox.Show("you have successfully returned your book.", " Book Return Successful", MessageBoxButtons.OK)

                Dim MemberAccountForm As MemberAccount
                MemberAccountForm = New MemberAccount
                MemberAccountForm.Show()
                Me.Visible = False
            End If
        End If
    End Sub

    Private Sub btn_Renew_Click(sender As Object, e As EventArgs)
        Dim currentdate As Date = Date.Today.Date
        NumberOfRows = CheckoutTableAdapter.FillByMemberCheckout(LibraryDataSet.Checkout, MemberID)

        If NumberOfRows = 0 Then
            MessageBox.Show("You have no items checked out at this time.")
        Else

            If Results.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select the book you wish to renew")
            Else

                'renew book by altering the due date and updating the record selected in ‘the “results” data grid the numbers in parentheses are the index of the ‘data grid column holding the piece of information needed.
                resourceID = Results.SelectedCells(0).Value

                CheckoutTableAdapter.RenewBookUpdateQuery(currentdate, resourceID)

                CheckoutPeriod = Results.SelectedCells(1).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                ResourceStatus = "Due " & DueDate.Date
                Results.SelectedCells(6).Value = ResourceStatus
                Results.SelectedCells(5).Value = currentdate

                MessageBox.Show("you have successfully renewed your book.", " Book Renewal Successful", MessageBoxButtons.OK)

                Dim MemberAccountForm As MemberAccount
                MemberAccountForm = New MemberAccount
                MemberAccountForm.Show()
                Me.Visible = False
            End If
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim NumberOfRows As Integer

        NumberOfRows = EmployeesTableAdapter.FillByEmployeeID(LibraryDataSet.Employees, MemberID)
        If NumberOfRows = 1 Then
            'go to employee
            Dim EmployeeWelcomeForm As EmployeeWelcome
            EmployeeWelcomeForm = New EmployeeWelcome
            EmployeeWelcomeForm.Show()
            Me.Visible = False

        Else
            NumberOfRows = MembersTableAdapter.FillByMemberID(LibraryDataSet.Members, MemberID)
            Dim WelcomePageForm As WelcomePage
            WelcomePageForm = New WelcomePage
            WelcomePageForm.Show()
            Me.Visible = False
        End If
    End Sub

    Private Sub Results_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles Results.CellContentClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim grid = DirectCast(sender, DataGridView)
        Dim currentdate As Date = Date.Today.Date
        'currentdate = currentdate.ToShortDateString()

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If grid.Columns(e.ColumnIndex).Name = "Renew" Then
                resourceID = Results.Rows(e.RowIndex).Cells(0).Value

                CheckoutTableAdapter.RenewBookUpdateQuery(currentdate, resourceID)

                CheckoutPeriod = Results.Rows(e.RowIndex).Cells(1).Value
                DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, currentdate)
                ResourceStatus = "Due " & DueDate.Date
                Results.Rows(e.RowIndex).Cells(6).Value = ResourceStatus
                Results.Rows(e.RowIndex).Cells(5).Value = currentdate

                MessageBox.Show("you have successfully renewed your book.", " Book Renewal Successful", MessageBoxButtons.OK)
            End If
        End If

        If grid.Columns(e.ColumnIndex).Name = "ReturnResource" Then
            resourceID = Results.Rows(e.RowIndex).Cells(0).Value
            CheckoutTableAdapter.ReturnBookUpdateQuery(currentdate, resourceID)
            Results.Rows(e.RowIndex).Cells(6).Value = currentdate

            MessageBox.Show("you have successfully returned your book.", " Book Return Successful", MessageBoxButtons.OK)
        End If

        Results.Rows.Clear()
        LoadDataGrid()
    End Sub

End Class