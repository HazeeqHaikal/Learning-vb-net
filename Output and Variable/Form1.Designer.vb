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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnVariable = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(62, 52)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(198, 112)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnVariable
        '
        Me.btnVariable.Location = New System.Drawing.Point(422, 52)
        Me.btnVariable.Name = "btnVariable"
        Me.btnVariable.Size = New System.Drawing.Size(219, 112)
        Me.btnVariable.TabIndex = 1
        Me.btnVariable.Text = "Variable"
        Me.btnVariable.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Location = New System.Drawing.Point(62, 219)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(198, 106)
        Me.btnData.TabIndex = 2
        Me.btnData.Text = "Data Types"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnVariable)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariable As Button
    Friend WithEvents btnData As Button
End Class
