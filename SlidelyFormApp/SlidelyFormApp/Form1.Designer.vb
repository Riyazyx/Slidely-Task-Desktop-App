<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnViewSubmissions.FlatStyle = FlatStyle.Popup
        btnViewSubmissions.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(12, 100)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(471, 42)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnCreateNewSubmission.FlatStyle = FlatStyle.Popup
        btnCreateNewSubmission.Font = New Font("Arial", 12F)
        btnCreateNewSubmission.Location = New Point(12, 157)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(471, 42)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(436, 23)
        Label1.TabIndex = 2
        Label1.Text = "Riyaz Ahamed, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 234)
        Controls.Add(Label1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "Form1"
        Text = "Riyaz Form App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label

End Class
