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
        Me.btnGrade = New System.Windows.Forms.Button()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGrade
        '
        Me.btnGrade.Location = New System.Drawing.Point(418, 231)
        Me.btnGrade.Name = "btnGrade"
        Me.btnGrade.Size = New System.Drawing.Size(95, 35)
        Me.btnGrade.TabIndex = 0
        Me.btnGrade.Text = "Get Grade"
        Me.btnGrade.UseVisualStyleBackColor = True
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(331, 192)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(182, 22)
        Me.txtGrade.TabIndex = 1
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(136, 195)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(171, 16)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Enter the examination score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.btnGrade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGrade As Button
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents lblGrade As Label
End Class
