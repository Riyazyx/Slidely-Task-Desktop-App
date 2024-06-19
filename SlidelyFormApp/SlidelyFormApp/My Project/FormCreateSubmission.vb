Imports System.Net.Http
Imports System.Text

Public Class FormCreateSubmission

    Private stopwatch As Stopwatch = New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        lblStopwatch.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhoneNumber.Text,
            .GithubLink = txtGithubLink.Text,
            .StopwatchTime = lblStopwatch.Text
        }
        Await SubmitForm(submission)
    End Sub

    Private Async Function SubmitForm(submission As Submission) As Task
        Using client As New HttpClient()
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed. Please try again.")
            End If
        End Using
    End Function

    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
End Class

Public Class Submission
    Private Property Name As String
    Private Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String
End Class