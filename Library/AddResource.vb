Public Class AddResource
    Dim newResourceID As String
    Dim ResourceID As String
    Dim BookTitle As String
    Dim AuthorFirstName As String
    Dim AuthorLastName As String
    Dim ISBN As String
    Dim CheckoutPeriod As Integer
    Dim PublicationDate As Integer
    Dim Series As String
    Dim Subject As String
    Dim BookInfo As String

    Dim book As Object
    Dim RowData As Object

    Dim MemberID As String = Login.memberID

    Private Sub CheckoutBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CheckoutBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub AddResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.Resources' table. You can move, or remove it, as needed.
        Me.ResourcesTableAdapter.Fill(Me.LibraryDataSet.Resources)
        'TODO: This line of code loads data into the 'LibraryDataSet.Checkout' table. You can move, or remove it, as needed.
        Me.CheckoutTableAdapter.Fill(Me.LibraryDataSet.Checkout)
        lblPageTitle.Left = (lblPageTitle.Parent.Width \ 2) - (lblPageTitle.Width \ 2)

        For x = 1 To 30 Step 1
            comboCheckoutPeriod.Items.Add(x)
        Next

        For x = 1900 To 2018 Step 1
            comboPublicationDate.Items.Add(x)
        Next

        comboSubject.Items.Add("Fiction")
        comboSubject.Items.Add("Non-Fiction")
        comboSubject.Items.Add("ScienceFiction")
        comboSubject.Items.Add("Fantasy")
        comboSubject.Items.Add("Mystery/Thriller")
        comboSubject.Items.Add("Crime")
        comboSubject.Items.Add("YouthFiction")
    End Sub

    Private Sub btnAddResource_Click(sender As Object, e As EventArgs) Handles btnAddResource.Click
        Dim NumberOfRows As Integer
        NumberOfRows = ResourcesTableAdapter.FillByTitle(LibraryDataSet.Resources, txtTitle.Text)

        If NumberOfRows > 0 Then
            ResourcesTableAdapter.InsertNewResource(newResourceID, txtTitle.Text, AuthorLastName, AuthorFirstName, "", PublicationDate, Series, ISBN, CheckoutPeriod, Subject, "", BookInfo)
            MessageBox.Show("Successfully Added Existing Resource")
            emptyBoxes()
        ElseIf txtTitle.Text = String.Empty Or txtAuthorLastName.Text = String.Empty Or txtAuthorFirstName.Text = String.Empty Or
            txtBookInfo.Text = String.Empty Or txtISBN.Text = String.Empty Or
            comboPublicationDate.Text = String.Empty Or comboSubject.Text = String.Empty Then
            MessageBox.Show("Please Enter All the Required Information")
        ElseIf Int32.TryParse(txtISBN.Text, ISBN) = False Then
            MessageBox.Show("Not a valid ISBN. Must be numerical")
        ElseIf ISBN > 9999999999999 Or ISBN < 10 Then
            MessageBox.Show("Not a valid ISBN")
        ElseIf Int32.TryParse(comboCheckoutPeriod.Text, CheckoutPeriod) = False Then
            MessageBox.Show("Not a valid checkout period")
        ElseIf Int32.TryParse(comboPublicationDate.Text, PublicationDate) = False Then
            MessageBox.Show("Not a valid publication date")
        Else
            BookTitle = txtTitle.Text
            AuthorFirstName = txtAuthorFirstName.Text
            AuthorLastName = txtAuthorLastName.Text
            ISBN = txtISBN.Text
            CheckoutPeriod = comboCheckoutPeriod.Text
            PublicationDate = comboPublicationDate.Text
            Series = comboSeries.Text
            Subject = comboSubject.Text
            BookInfo = txtBookInfo.Text

            'random number
            Dim LRandomNumber As Integer
            LRandomNumber = Int((2099999 - 2090000 + 1) * Rnd() + 2090000)

            ResourceID = "b" & LRandomNumber.ToString & "_1"

            ResourcesTableAdapter.InsertNewResource(ResourceID, BookTitle, AuthorLastName, AuthorFirstName, "", PublicationDate, Series, ISBN, CheckoutPeriod, Subject, "", BookInfo)

            MessageBox.Show("Successfully Added New Resource")

            emptyBoxes()
        End If


    End Sub

    Private Sub emptyBoxes()
        txtTitle.Clear()
        txtAuthorFirstName.Clear()
        txtAuthorLastName.Clear()
        txtISBN.Clear()
        comboCheckoutPeriod.Text = String.Empty
        comboPublicationDate.Text = String.Empty
        comboSeries.Text = String.Empty
        comboSubject.Text = String.Empty
        txtBookInfo.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim EmployeeWelcomeForm As EmployeeWelcome
        EmployeeWelcomeForm = New EmployeeWelcome
        EmployeeWelcomeForm.Show()
        Me.Visible = False
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        Dim NumberOfRows As Integer
        NumberOfRows = ResourcesTableAdapter.FillByTitle(LibraryDataSet.Resources, txtTitle.Text)

        If NumberOfRows > 0 Then
            MessageBox.Show("book already in library" & NumberOfRows)

            book = ResourcesTableAdapter.GetDataByTitle(txtTitle.Text)(0)
            ResourceID = book.resourceID

            'RowData = ResourcesTableAdapter.GetDataByResourceID(ResourceID)(0)
            CheckoutPeriod = book.checkoutperiod
            AuthorFirstName = book.AuthorFirstName
            AuthorLastName = book.AuthorLastName
            ISBN = book.ISBN
            CheckoutPeriod = book.CheckOutPeriod
            PublicationDate = book.PublicationDate
            Series = book.Series
            Subject = book.Subject1
            BookInfo = book.BookInfo
            ResourceID = book.ResourceID

            txtAuthorFirstName.Text = AuthorFirstName
            txtAuthorLastName.Text = AuthorLastName
            txtISBN.Text = ISBN
            comboCheckoutPeriod.Text = CheckoutPeriod
            comboPublicationDate.Text = PublicationDate
            comboSeries.Text = Series
            comboSubject.Text = Subject
            txtBookInfo.Text = BookInfo

            Dim int As Integer = NumberOfRows
            int += 1

            newResourceID = ResourceID
            newResourceID = newResourceID.Substring(0, newResourceID.Length - 1) & int

            MessageBox.Show(newResourceID)

            'ResourcesTableAdapter.InsertNewResource(newResourceID, BookTitle, AuthorLastName, AuthorFirstName, "", PublicationDate, Series, ISBN, CheckoutPeriod, Subject, "", BookInfo)
            'emptyBoxes()
        End If
    End Sub
End Class