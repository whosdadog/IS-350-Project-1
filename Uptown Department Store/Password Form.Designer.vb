<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordEntry
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
        Me.PasswordOK = New System.Windows.Forms.Button()
        Me.PasswordCancel = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordPrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PasswordOK
        '
        Me.PasswordOK.Location = New System.Drawing.Point(282, 13)
        Me.PasswordOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordOK.Name = "PasswordOK"
        Me.PasswordOK.Size = New System.Drawing.Size(67, 31)
        Me.PasswordOK.TabIndex = 0
        Me.PasswordOK.Text = "Ok"
        Me.PasswordOK.UseVisualStyleBackColor = True
        '
        'PasswordCancel
        '
        Me.PasswordCancel.Location = New System.Drawing.Point(286, 52)
        Me.PasswordCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PasswordCancel.Name = "PasswordCancel"
        Me.PasswordCancel.Size = New System.Drawing.Size(63, 36)
        Me.PasswordCancel.TabIndex = 1
        Me.PasswordCancel.Text = "Cancel"
        Me.PasswordCancel.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(30, 111)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(319, 22)
        Me.TextBox1.TabIndex = 2
        '
        'PasswordPrompt
        '
        Me.PasswordPrompt.AutoSize = True
        Me.PasswordPrompt.Location = New System.Drawing.Point(27, 39)
        Me.PasswordPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordPrompt.Name = "PasswordPrompt"
        Me.PasswordPrompt.Size = New System.Drawing.Size(102, 16)
        Me.PasswordPrompt.TabIndex = 3
        Me.PasswordPrompt.Text = "Enter Password"
        '
        'PasswordEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 172)
        Me.Controls.Add(Me.PasswordPrompt)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PasswordCancel)
        Me.Controls.Add(Me.PasswordOK)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PasswordEntry"
        Me.Text = "Password Attempt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordOK As Button
    Friend WithEvents PasswordCancel As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PasswordPrompt As Label
End Class
