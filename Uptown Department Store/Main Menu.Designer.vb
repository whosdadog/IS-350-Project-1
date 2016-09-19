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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Separator_Line = New System.Windows.Forms.Label()
        Me.CustName = New System.Windows.Forms.Label()
        Me.StreetAddress = New System.Windows.Forms.Label()
        Me.CityStateZip = New System.Windows.Forms.Label()
        Me.CustomerPhone = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CNameInput = New System.Windows.Forms.TextBox()
        Me.CAddressInput = New System.Windows.Forms.TextBox()
        Me.CCityInput = New System.Windows.Forms.TextBox()
        Me.CStateInput = New System.Windows.Forms.TextBox()
        Me.CZipInput = New System.Windows.Forms.TextBox()
        Me.CPhoneInput = New System.Windows.Forms.TextBox()
        Me.Shoes = New System.Windows.Forms.Button()
        Me.Handbags = New System.Windows.Forms.Button()
        Me.Jeans = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.Checkout = New System.Windows.Forms.Button()
        Me.Broadway = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, -3)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(504, 93)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'Separator_Line
        '
        Me.Separator_Line.AutoSize = True
        Me.Separator_Line.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Separator_Line.Location = New System.Drawing.Point(4, 53)
        Me.Separator_Line.Name = "Separator_Line"
        Me.Separator_Line.Size = New System.Drawing.Size(526, 46)
        Me.Separator_Line.TabIndex = 1
        Me.Separator_Line.Text = "______________________"
        '
        'CustName
        '
        Me.CustName.AutoSize = True
        Me.CustName.Location = New System.Drawing.Point(12, 103)
        Me.CustName.Name = "CustName"
        Me.CustName.Size = New System.Drawing.Size(108, 16)
        Me.CustName.TabIndex = 2
        Me.CustName.Text = "Customer Name:"
        '
        'StreetAddress
        '
        Me.StreetAddress.AutoSize = True
        Me.StreetAddress.Location = New System.Drawing.Point(20, 134)
        Me.StreetAddress.Name = "StreetAddress"
        Me.StreetAddress.Size = New System.Drawing.Size(100, 16)
        Me.StreetAddress.TabIndex = 3
        Me.StreetAddress.Text = "Street Address:"
        '
        'CityStateZip
        '
        Me.CityStateZip.AutoSize = True
        Me.CityStateZip.Location = New System.Drawing.Point(25, 170)
        Me.CityStateZip.Name = "CityStateZip"
        Me.CityStateZip.Size = New System.Drawing.Size(95, 16)
        Me.CityStateZip.TabIndex = 4
        Me.CityStateZip.Text = "City, State, Zip:"
        '
        'CustomerPhone
        '
        Me.CustomerPhone.AutoSize = True
        Me.CustomerPhone.Location = New System.Drawing.Point(19, 205)
        Me.CustomerPhone.Name = "CustomerPhone"
        Me.CustomerPhone.Size = New System.Drawing.Size(101, 16)
        Me.CustomerPhone.TabIndex = 5
        Me.CustomerPhone.Text = "Phone Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(533, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _"
        '
        'CNameInput
        '
        Me.CNameInput.Location = New System.Drawing.Point(127, 103)
        Me.CNameInput.Name = "CNameInput"
        Me.CNameInput.Size = New System.Drawing.Size(389, 22)
        Me.CNameInput.TabIndex = 7
        '
        'CAddressInput
        '
        Me.CAddressInput.Location = New System.Drawing.Point(127, 134)
        Me.CAddressInput.Name = "CAddressInput"
        Me.CAddressInput.Size = New System.Drawing.Size(389, 22)
        Me.CAddressInput.TabIndex = 8
        '
        'CCityInput
        '
        Me.CCityInput.Location = New System.Drawing.Point(127, 170)
        Me.CCityInput.Name = "CCityInput"
        Me.CCityInput.Size = New System.Drawing.Size(210, 22)
        Me.CCityInput.TabIndex = 9
        '
        'CStateInput
        '
        Me.CStateInput.Location = New System.Drawing.Point(344, 170)
        Me.CStateInput.Name = "CStateInput"
        Me.CStateInput.Size = New System.Drawing.Size(49, 22)
        Me.CStateInput.TabIndex = 10
        '
        'CZipInput
        '
        Me.CZipInput.Location = New System.Drawing.Point(400, 170)
        Me.CZipInput.Name = "CZipInput"
        Me.CZipInput.Size = New System.Drawing.Size(116, 22)
        Me.CZipInput.TabIndex = 11
        '
        'CPhoneInput
        '
        Me.CPhoneInput.Location = New System.Drawing.Point(127, 205)
        Me.CPhoneInput.Name = "CPhoneInput"
        Me.CPhoneInput.Size = New System.Drawing.Size(210, 22)
        Me.CPhoneInput.TabIndex = 12
        '
        'Shoes
        '
        Me.Shoes.Location = New System.Drawing.Point(28, 264)
        Me.Shoes.Name = "Shoes"
        Me.Shoes.Size = New System.Drawing.Size(125, 85)
        Me.Shoes.TabIndex = 13
        Me.Shoes.Text = "Shoes"
        Me.Shoes.UseVisualStyleBackColor = True
        '
        'Handbags
        '
        Me.Handbags.Location = New System.Drawing.Point(159, 264)
        Me.Handbags.Name = "Handbags"
        Me.Handbags.Size = New System.Drawing.Size(125, 85)
        Me.Handbags.TabIndex = 14
        Me.Handbags.Text = "Handbags"
        Me.Handbags.UseVisualStyleBackColor = True
        '
        'Jeans
        '
        Me.Jeans.Location = New System.Drawing.Point(290, 264)
        Me.Jeans.Name = "Jeans"
        Me.Jeans.Size = New System.Drawing.Size(125, 85)
        Me.Jeans.TabIndex = 15
        Me.Jeans.Text = "Jeans"
        Me.Jeans.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Location = New System.Drawing.Point(290, 355)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(125, 85)
        Me.About.TabIndex = 18
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'Checkout
        '
        Me.Checkout.Location = New System.Drawing.Point(159, 355)
        Me.Checkout.Name = "Checkout"
        Me.Checkout.Size = New System.Drawing.Size(125, 85)
        Me.Checkout.TabIndex = 17
        Me.Checkout.Text = "Check Out"
        Me.Checkout.UseVisualStyleBackColor = True
        '
        'Broadway
        '
        Me.Broadway.Location = New System.Drawing.Point(28, 355)
        Me.Broadway.Name = "Broadway"
        Me.Broadway.Size = New System.Drawing.Size(125, 85)
        Me.Broadway.TabIndex = 16
        Me.Broadway.Text = "Broadway Shows"
        Me.Broadway.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(422, 264)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(74, 176)
        Me.Quit.TabIndex = 19
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 464)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Checkout)
        Me.Controls.Add(Me.Broadway)
        Me.Controls.Add(Me.Jeans)
        Me.Controls.Add(Me.Handbags)
        Me.Controls.Add(Me.Shoes)
        Me.Controls.Add(Me.CPhoneInput)
        Me.Controls.Add(Me.CZipInput)
        Me.Controls.Add(Me.CStateInput)
        Me.Controls.Add(Me.CCityInput)
        Me.Controls.Add(Me.CAddressInput)
        Me.Controls.Add(Me.CNameInput)
        Me.Controls.Add(Me.CustomerPhone)
        Me.Controls.Add(Me.CityStateZip)
        Me.Controls.Add(Me.StreetAddress)
        Me.Controls.Add(Me.CustName)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Separator_Line)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Main Menu"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Logo As PictureBox
    Friend WithEvents Separator_Line As Label
    Friend WithEvents CustName As Label
    Friend WithEvents StreetAddress As Label
    Friend WithEvents CityStateZip As Label
    Friend WithEvents CustomerPhone As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CNameInput As TextBox
    Friend WithEvents CAddressInput As TextBox
    Friend WithEvents CCityInput As TextBox
    Friend WithEvents CStateInput As TextBox
    Friend WithEvents CZipInput As TextBox
    Friend WithEvents CPhoneInput As TextBox
    Friend WithEvents Shoes As Button
    Friend WithEvents Handbags As Button
    Friend WithEvents Jeans As Button
    Friend WithEvents About As Button
    Friend WithEvents Checkout As Button
    Friend WithEvents Broadway As Button
    Friend WithEvents Quit As Button
End Class
