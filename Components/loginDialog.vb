Public Class loginDialog
    Private Sub tryagain_Click(sender As Object, e As EventArgs) Handles tryagain.Click
        Me.Close()
    End Sub

    Private Sub loginDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoginForm.username.Text = "" And LoginForm.password.Text = "" Then
            message.Text = "Username and password cannot be empty, please try again"
        ElseIf LoginForm.username.Text = "" Then
        message.Text = "Username cannot be empty, please try again"
        ElseIf LoginForm.password.Text = "" Then
        message.Text = "Password cannot be empty, please try again"

        End If
    End Sub
End Class