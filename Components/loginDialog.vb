Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class loginDialog
    Public isButtonClicked As Boolean
    Private Sub tryagain_Click(sender As Object, e As EventArgs) Handles tryagain.Click
        Me.Close()
    End Sub

    Private Sub loginDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Handles login and register'
        If String.IsNullOrEmpty(LoginForm.username.Text) And String.IsNullOrEmpty(LoginForm.password.Text) And isButtonClicked Then
            closeBtn.Top += 60
            isButtonClicked = False
            closeBtn.Visible = False
            tryagain.BackColor = Color.Red
            tryagain.Text = "Try Again"
            message.Text = "Username and password cannot be empty, please try again"

            'Handles login and register'
        ElseIf String.IsNullOrEmpty(LoginForm.username.Text) And isButtonClicked Then
            closeBtn.Top += 60
            isButtonClicked = False
            closeBtn.Visible = False
            tryagain.BackColor = Color.Red
            tryagain.Text = "Try Again"
            message.Text = "Username cannot be empty, please try again"
            'Handles login and register'
        ElseIf String.IsNullOrEmpty(LoginForm.password.Text) And isButtonClicked Then
            closeBtn.Top += 60
            isButtonClicked = False
            closeBtn.Visible = False
            tryagain.BackColor = Color.Red
            tryagain.Text = "Try Again"
            message.Text = "Password cannot be empty, please try again"
            'Handles exit'
        ElseIf Not isButtonClicked Then
            closeBtn.Visible = True
            tryagain.Top += 60
            tryagain.BackColor = Color.Green
            tryagain.Text = "Cancel"
            headerLbl.Text = "Exit"
            message.Text = "Are you sure you want to exit?"
        End If


        'Handles register'
        If Not LoginForm.isLeft And Not String.IsNullOrEmpty(LoginForm.username.Text) And Not String.IsNullOrEmpty(LoginForm.password.Text) And isButtonClicked Then
            If isUserValid(LoginForm.username.Text, LoginForm.password.Text) Then
                Me.BackColor = Color.Green
                headerLbl.Text = "Successful"
                headerLbl.Left = (Panel1.Width - headerLbl.Width) \ 2
                tryagain.Text = "Okay"
                tryagain.BackColor = Color.Green
                headerLbl.ForeColor = Color.Green
                PictureBox1.Image = My.Resources.check
                message.Text = "Username and Password are succesfully added!"
                LoginForm.username.Text = ""
                LoginForm.password.Text = ""
            Else
                message.Text = "Username is already used!"
            End If
        End If
    End Sub



    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Splash_Screen.Close()
    End Sub
End Class