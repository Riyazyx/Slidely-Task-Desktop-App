<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewSubmissions
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
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Arial", 10.2F)
        txtName.Location = New Point(153, 110)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(296, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Arial", 10.2F)
        txtEmail.Location = New Point(153, 175)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(296, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Arial", 10.2F)
        txtPhoneNumber.Location = New Point(153, 246)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(296, 27)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Arial", 10.2F)
        txtGithubLink.Location = New Point(153, 316)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(296, 34)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        txtStopwatchTime.Font = New Font("Arial", 10.2F)
        txtStopwatchTime.Location = New Point(153, 395)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(296, 27)
        txtStopwatchTime.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13F)
        Label1.Location = New Point(33, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(479, 25)
        Label1.TabIndex = 5
        Label1.Text = "Riyaz Ahamed, Slidely Task 2 - Slidely Form App"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.Location = New Point(49, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 6
        Label2.Text = "Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F)
        Label3.Location = New Point(52, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 23)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F)
        Label4.Location = New Point(37, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 23)
        Label4.TabIndex = 8
        Label4.Text = "Phone Num"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F)
        Label5.Location = New Point(33, 310)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 23)
        Label5.TabIndex = 9
        Label5.Text = "Github Link"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F)
        Label6.Location = New Point(37, 391)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 23)
        Label6.TabIndex = 10
        Label6.Text = "Stopwatch"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F)
        Label7.Location = New Point(37, 333)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 23)
        Label7.TabIndex = 11
        Label7.Text = "For Task 2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F)
        Label8.Location = New Point(58, 414)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 23)
        Label8.TabIndex = 12
        Label8.Text = "Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrevious.FlatStyle = FlatStyle.Popup
        btnPrevious.Font = New Font("Arial", 12F)
        btnPrevious.Location = New Point(19, 482)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(249, 40)
        btnPrevious.TabIndex = 13
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext.FlatStyle = FlatStyle.Popup
        btnNext.Font = New Font("Arial", 12F)
        btnNext.Location = New Point(274, 482)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(249, 40)
        btnNext.TabIndex = 14
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' FormViewSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 581)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "FormViewSubmissions"
        Text = "FormViewSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
