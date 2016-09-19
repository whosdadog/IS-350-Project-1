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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordEntry))
        Me.PasswordOK = New System.Windows.Forms.Button()
        Me.PasswordCancel = New System.Windows.Forms.Button()
        Me.PasswordField = New System.Windows.Forms.TextBox()
        Me.PasswordPrompt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordEmployee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PasswordOK
        '
        Me.PasswordOK.Location = New System.Drawing.Point(115, 141)
        Me.PasswordOK.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordOK.Name = "PasswordOK"
        Me.PasswordOK.Size = New System.Drawing.Size(69, 36)
        Me.PasswordOK.TabIndex = 2
        Me.PasswordOK.Text = "Ok"
        Me.PasswordOK.UseVisualStyleBackColor = True
        '
        'PasswordCancel
        '
        Me.PasswordCancel.Location = New System.Drawing.Point(192, 141)
        Me.PasswordCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordCancel.Name = "PasswordCancel"
        Me.PasswordCancel.Size = New System.Drawing.Size(69, 36)
        Me.PasswordCancel.TabIndex = 3
        Me.PasswordCancel.Text = "Cancel"
        Me.PasswordCancel.UseVisualStyleBackColor = True
        '
        'PasswordField
        '
        Me.PasswordField.Location = New System.Drawing.Point(192, 99)
        Me.PasswordField.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordField.Size = New System.Drawing.Size(160, 22)
        Me.PasswordField.TabIndex = 1
        '
        'PasswordPrompt
        '
        Me.PasswordPrompt.AutoSize = True
        Me.PasswordPrompt.Location = New System.Drawing.Point(68, 99)
        Me.PasswordPrompt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordPrompt.Name = "PasswordPrompt"
        Me.PasswordPrompt.Size = New System.Drawing.Size(105, 16)
        Me.PasswordPrompt.TabIndex = 3
        Me.PasswordPrompt.Text = "Enter Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter Employee Number:"
        '
        'PasswordEmployee
        '
        Me.PasswordEmployee.Location = New System.Drawing.Point(192, 62)
        Me.PasswordEmployee.Name = "PasswordEmployee"
        Me.PasswordEmployee.Size = New System.Drawing.Size(160, 22)
        Me.PasswordEmployee.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("abeatbyKai", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Login"
        '
        'PasswordEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(379, 195)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordEmployee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordPrompt)
        Me.Controls.Add(Me.PasswordField)
        Me.Controls.Add(Me.PasswordCancel)
        Me.Controls.Add(Me.PasswordOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PasswordEntry"
        Me.Text = "Password Attempt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordOK As Button
    Friend WithEvents PasswordCancel As Button
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents PasswordPrompt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordEmployee As TextBox
    Friend WithEvents Label2 As Label
End Class
