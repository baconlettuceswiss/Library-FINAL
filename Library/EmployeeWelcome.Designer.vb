<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddResource = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(266, 248)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(84, 57)
        Me.btnSearch.TabIndex = 40
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnAddResource
        '
        Me.btnAddResource.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddResource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddResource.Location = New System.Drawing.Point(377, 248)
        Me.btnAddResource.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddResource.Name = "btnAddResource"
        Me.btnAddResource.Size = New System.Drawing.Size(95, 57)
        Me.btnAddResource.TabIndex = 39
        Me.btnAddResource.Text = "Add Resource"
        Me.btnAddResource.UseVisualStyleBackColor = False
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReview.Location = New System.Drawing.Point(143, 248)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(94, 57)
        Me.btnReview.TabIndex = 38
        Me.btnReview.Text = "Account Review"
        Me.btnReview.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Location = New System.Drawing.Point(498, 248)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(88, 57)
        Me.btnLogout.TabIndex = 37
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(62, 44)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(315, 37)
        Me.lblWelcome.TabIndex = 36
        Me.lblWelcome.Text = "Welcome Employee"
        Me.lblWelcome.UseMnemonic = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblWelcome)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 172)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'EmployeeWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library.My.Resources.Resources.wooden_table_with_blurred_background_1134_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(724, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAddResource)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "EmployeeWelcome"
        Me.Text = "EmployeeWelcome"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddResource As Button
    Friend WithEvents btnReview As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
