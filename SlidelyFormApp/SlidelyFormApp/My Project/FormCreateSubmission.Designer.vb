<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmission
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
        btnSubmit = New Button()
        btnToggleStopwatch = New Button()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblStopwatch = New TextBox()
        txtGithubLink = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSubmit.FlatStyle = FlatStyle.Popup
        btnSubmit.Font = New Font("Arial", 12F)
        btnSubmit.Location = New Point(12, 441)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(491, 40)
        btnSubmit.TabIndex = 29
        btnSubmit.Text = "SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnToggleStopwatch.FlatStyle = FlatStyle.Popup
        btnToggleStopwatch.Font = New Font("Arial", 12F)
        btnToggleStopwatch.Location = New Point(12, 375)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(326, 35)
        btnToggleStopwatch.TabIndex = 28
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F)
        Label7.Location = New Point(37, 321)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 23)
        Label7.TabIndex = 26
        Label7.Text = "For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F)
        Label5.Location = New Point(33, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 23)
        Label5.TabIndex = 24
        Label5.Text = "Github Link"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F)
        Label4.Location = New Point(37, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 23)
        Label4.TabIndex = 23
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(52, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 23)
        Label3.TabIndex = 22
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.Location = New Point(49, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 21
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13F)
        Label1.Location = New Point(33, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(479, 25)
        Label1.TabIndex = 20
        Label1.Text = "Riyaz Ahamed, Slidely Task 2 - Slidely Form App"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.Font = New Font("Arial", 10.2F)
        lblStopwatch.Location = New Point(360, 383)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(143, 27)
        lblStopwatch.TabIndex = 19
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.White
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Arial", 10.2F)
        txtGithubLink.Location = New Point(153, 304)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(350, 34)
        txtGithubLink.TabIndex = 18
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.White
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Arial", 10.2F)
        txtPhoneNumber.Location = New Point(153, 234)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(350, 27)
        txtPhoneNumber.TabIndex = 17
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Arial", 10.2F)
        txtEmail.Location = New Point(153, 163)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(350, 27)
        txtEmail.TabIndex = 16
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Arial", 10.2F)
        txtName.Location = New Point(153, 98)
        txtName.Name = "txtName"
        txtName.Size = New Size(350, 27)
        txtName.TabIndex = 15
        ' 
        ' FormCreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 541)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "FormCreateSubmission"
        Text = "FormCreateSubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
End Class
