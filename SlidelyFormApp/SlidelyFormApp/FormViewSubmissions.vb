Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class FormViewSubmissions

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/api/read?index=" & currentIndex)
            If response.IsSuccessStatusCode Then
                Dim result As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(result)
            End If
        End Using
    End Function

    Private Function LoadSubmissions() As List(Of Submission)
        ' Load submissions from backend
        ' Replace this with actual code to load from your backend
        Dim mockData As New List(Of Submission)
        mockData.Add(New Submission With {.Name = "John Doe", .Email = "johndoe@gmail.com", .Phone = "9876543210", .GithubLink = "https://github.com/john_doe/my_slidely_task/", .StopwatchTime = "00:01:19"})
        Return mockData
    End Function
    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhoneNumber.Text = submission.Phone
            txtGithubLink.Text = submission.GithubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class

Private Sub FormViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.Control AndAlso e.KeyCode = Keys.P Then
        btnPrevious.PerformClick()
    ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
        btnNext.PerformClick()
    End If
End Sub

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class