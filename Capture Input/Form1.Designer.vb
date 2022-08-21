<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.Label()
        Me.lastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(461, 253)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(109, 38)
        Me.submitBtn.TabIndex = 0
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(340, 160)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(230, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'firstName
        '
        Me.firstName.AutoSize = True
        Me.firstName.Location = New System.Drawing.Point(231, 166)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(72, 16)
        Me.firstName.TabIndex = 2
        Me.firstName.Text = "First Name"
        '
        'lastName
        '
        Me.lastName.AutoSize = True
        Me.lastName.Location = New System.Drawing.Point(231, 191)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(72, 16)
        Me.lastName.TabIndex = 4
        Me.lastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(340, 188)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(230, 22)
        Me.txtLastName.TabIndex = 3
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(340, 216)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(230, 22)
        Me.txtGender.TabIndex = 5
        '
        'gender
        '
        Me.gender.AutoSize = True
        Me.gender.Location = New System.Drawing.Point(241, 216)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(52, 16)
        Me.gender.TabIndex = 6
        Me.gender.Text = "Gender"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.submitBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitBtn As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents firstName As Label
    Friend WithEvents lastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents gender As Label
End Class
