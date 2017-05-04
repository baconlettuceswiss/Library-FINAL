<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.MembersTableAdapter = New Library.LibraryDataSetTableAdapters.MembersTableAdapter()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataSet = New Library.LibraryDataSet()
        Me.TableAdapterManager = New Library.LibraryDataSetTableAdapters.TableAdapterManager()
        Me.EmployeesTableAdapter = New Library.LibraryDataSetTableAdapters.EmployeesTableAdapter()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.SystemColors.Control
        Label2.Location = New System.Drawing.Point(94, 48)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 23
        Label2.Text = "Email:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.SystemColors.Control
        Label4.Location = New System.Drawing.Point(94, 105)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(56, 13)
        Label4.TabIndex = 24
        Label4.Text = "Password:"
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.LibraryDataSet
        '
        'LibraryDataSet
        '
        Me.LibraryDataSet.DataSetName = "LibraryDataSet"
        Me.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CheckoutTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.ResourcesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.LibraryDataSet
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel1.Location = New System.Drawing.Point(465, 434)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 13)
        Me.LinkLabel1.TabIndex = 42
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create an account"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.txtPW)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 175)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(471, 232)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(314, 157)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 40)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUsername.Location = New System.Drawing.Point(201, 43)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(148, 20)
        Me.txtUsername.TabIndex = 26
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPW.Location = New System.Drawing.Point(201, 100)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(148, 20)
        Me.txtPW.TabIndex = 27
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Location = New System.Drawing.Point(99, 157)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 40)
        Me.btnLogin.TabIndex = 25
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(337, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Welcome to the E-Library. Please enter your email and password below."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label6.Location = New System.Drawing.Point(416, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 37)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "ELibrary"
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Library.My.Resources.Resources.wooden_table_with_blurred_background_1134_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 979)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.MinimumSize = New System.Drawing.Size(1024, 1018)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MembersTableAdapter As LibraryDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents LibraryDataSet As LibraryDataSet
    Friend WithEvents TableAdapterManager As LibraryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesTableAdapter As LibraryDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
