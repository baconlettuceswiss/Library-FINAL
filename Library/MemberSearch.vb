Public Class MemberSearch
    Dim CheckoutPeriod As Long
    Dim NumberOfRows As Integer
    Dim CheckedOutRecord As Integer
    Dim bookInfo As Object
    Dim resourceID As String
    Dim ResourceStatus As String
    Dim DueDate As Date
    Dim CheckoutDate As Date
    Dim checkedoutbooks As Integer
    Dim checkedoutbookinfo As Object
    Dim MemberID As String = Login.memberID
    Dim RowData As Object


    Private Sub SearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchResults.CellContentClick



        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim grid = DirectCast(sender, DataGridView)

        If TypeOf grid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            If grid.Columns(e.ColumnIndex).Name = "MoreInfo" Then

                MessageBox.Show(SearchResults.Rows(e.RowIndex).Cells(3).Value)
            End If
        End If

        If grid.Columns(e.ColumnIndex).Name = "Checkout" Then

        End If


    End Sub

    Private Sub ResourcesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub MemberSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.LibraryDataSet.Employees)
        'TODO: This line of code loads data into the 'LibraryDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.Members)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)
        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)
        SearchResults.Rows.Clear()

        Dim num As Integer

        num = EmployeesTableAdapter.FillByEmployeeID(LibraryDataSet.Employees, MemberID)
        If num = 1 Then
            'go to employee
            btnCheckOut.Visible = False
        Else
            btnCheckOut.Visible = True
        End If
    End Sub

    Private Sub LoadDataGrid()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
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

    Private Sub btnTitleSearch_Click(sender As Object, e As EventArgs) Handles btnTitleSearch.Click
        SearchResults.Rows.Clear()
        Dim BookTitle As String = ("%" & tbTitle.Text & "%")
        'ResourcesTableAdapter.GetDataByTitle(BookTitle)

        'Results.Rows.Clear()
        NumberOfRows = ResourcesTableAdapter.FillByTitle(LibraryDataSet.Resources, BookTitle)

        If NumberOfRows > 0 Then

            SearchResults.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = ResourcesTableAdapter.GetDataByTitle(BookTitle)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                CheckoutPeriod = RowData.checkoutperiod

                If checkedoutbooks = 1 Then
                    checkedoutbookinfo = CheckoutTableAdapter.GetDataByResourceID(resourceID)(0)
                    CheckoutDate = checkedoutbookinfo.checkoutdate
                    DueDate = DateAdd(DateInterval.Day, CheckoutPeriod, CheckoutDate)
                    ResourceStatus = "Due " & DueDate
                Else
                    ResourceStatus = "Available"
                End If

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add ID to the 1st column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ResourceID
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                'add availability to the 3rd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "availability"
                Dim Availability As Boolean
                'CheckoutTableAdapter.Get
                dgvRow.Cells.Add(dgvCell)

                'add book info to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.BookInfo
                dgvRow.Cells.Add(dgvCell)

                'add Title to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author to the 6th of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorFirstName & " " & RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add Genre to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Subject1
                dgvRow.Cells.Add(dgvCell)

                'add ISBN to the 8th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ISBN
                dgvRow.Cells.Add(dgvCell)

                SearchResults.Rows.Add(dgvRow)
                'SearchResults is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No items found using your search parameters")
        End If
    End Sub

    Private Sub btnAuthorSearch_Click(sender As Object, e As EventArgs) Handles btnAuthorSearch.Click
        SearchResults.Rows.Clear()
        'ResourcesTableAdapter.GetDataByAuthorLastName(tbAuthorSearch.Text)

        Dim AuthorLastName As String = ("%" & tbAuthorSearch.Text & "%")
        'ResourcesTableAdapter.GetDataByTitle(BookTitle)

        'Results.Rows.Clear()
        NumberOfRows = ResourcesTableAdapter.FillByAuthorLastName(LibraryDataSet.Resources, AuthorLastName)

        If NumberOfRows > 0 Then

            SearchResults.Visible = True

            Dim x As Integer = 0
            'begin a loop that will add information for each of the currently checked out books one at a time, to the DataGridView
            'you can reorder these columns, remove some of them or add new ones as you wish
            For x = 0 To NumberOfRows - 1 Step 1

                bookInfo = ResourcesTableAdapter.GetDataByAuthorLastName(AuthorLastName)(x)
                resourceID = bookInfo.resourceID

                RowData = ResourcesTableAdapter.GetDataByResourceID(resourceID)(0)
                CheckoutPeriod = RowData.checkoutperiod

                'add information for the checked out resource to the DataGridView
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                'add ID to the 1st column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ResourceID
                dgvRow.Cells.Add(dgvCell)

                'add checkout period to the 2nd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.CheckOutPeriod
                dgvRow.Cells.Add(dgvCell)

                'add availability to the 3rd column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = "availability"
                Dim Availability As Boolean
                'CheckoutTableAdapter.Get
                dgvRow.Cells.Add(dgvCell)

                'add book info to the 4th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.BookInfo
                dgvRow.Cells.Add(dgvCell)

                'add Title to the 5th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Title
                dgvRow.Cells.Add(dgvCell)

                'add author to the 6th of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.AuthorFirstName & " " & RowData.AuthorLastName
                dgvRow.Cells.Add(dgvCell)

                'add Genre to the 7th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.Subject1
                dgvRow.Cells.Add(dgvCell)

                'add ISBN to the 8th column of the DataGridView
                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = RowData.ISBN
                dgvRow.Cells.Add(dgvCell)

                SearchResults.Rows.Add(dgvRow)
                'SearchResults is the name of the DataGridView Control added to the Form

            Next
        ElseIf NumberOfRows = 0 Then
            MessageBox.Show("No items found using your search parameters")
        End If
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim currentdate As Date = Date.Today.Date
        Dim checkoutperiod As Long
        'Dim MemberID As String
        Dim resourceid As String
        Dim returndate As Nullable(Of Date) = Date.Now
        returndate = Nothing
        If SearchResults.RowCount = 0 Then
            MsgBox("please search for a resource")
        Else
            'if no row is selected, a message box will appear 
            If SearchResults.SelectedRows.Count = 0 Then
                MsgBox("Please select a resource for checkout")
            Else
                'the resources that are available will be shown
                If SearchResults.SelectedCells(2).Value = "availability" Then
                    resourceid = SearchResults.SelectedCells(0).Value

                    RowData = MembersTableAdapter.GetDataByEmail(Login.txtUsername.Text)(0)
                    MemberID = RowData.memberID
                    CheckoutDate = currentdate.Date

                    Dim rand As New Random
                    Dim number1 As String = CInt(rand.Next(0, 9999))
                    'inserts New Data of checkout into the record
                    CheckoutTableAdapter.Insert(resourceid, MemberID, CheckoutDate, returndate)
                    'updates the checkout history

                    'CheckoutTableAdapter.UpdateCheckOut(CheckoutDate, resourceid)
                    checkoutperiod = SearchResults.SelectedCells(1).Value
                    'adds the date of the resource is due
                    DueDate = DateAdd(DateInterval.Day, checkoutperiod, currentdate)
                    'displays the new due date in the resource status 
                    ResourceStatus = "Unavailable"
                    SearchResults.SelectedCells(2).Value = ResourceStatus
                    MsgBox("You have successfully checked out the resource: " & resourceid)
                    MsgBox("The due date is " + DueDate.ToShortDateString)
                Else
                    MsgBox("This resource is currently unavailable.")

                End If
            End If
        End If
    End Sub
End Class