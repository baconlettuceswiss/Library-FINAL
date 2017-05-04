<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReview.Location = New System.Drawing.Point(126, 271)
        Me.btnReview.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnReview.Size = New System.Drawing.Size(103, 57)
        Me.btnReview.TabIndex = 28
        Me.btnReview.Text = "Account Review"
        Me.btnReview.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Location = New System.Drawing.Point(466, 271)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLogout.Size = New System.Drawing.Size(103, 57)
        Me.btnLogout.TabIndex = 27
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Location = New System.Drawing.Point(300, 271)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSearch.Size = New System.Drawing.Size(98, 57)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblWelcome)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(443, 174)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(73, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Your destination for learning!"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(40, 44)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(368, 37)
        Me.lblWelcome.TabIndex = 26
        Me.lblWelcome.Text = "Welcome to the Library"
        Me.lblWelcome.UseMnemonic = False
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Library.My.Resources.Resources.wooden_table_with_blurred_background_1134_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(707, 423)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnLogout)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "WelcomePage"
        Me.Text = "WelcomePage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReview As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
End Class
