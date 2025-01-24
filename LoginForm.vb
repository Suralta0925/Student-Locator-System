Public Class LoginForm
    Public isLeft As Boolean = True
    Dim coverLength As Integer = 550
    Dim max As Integer = 255
    Dim min As Integer = 0

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Anim.Start()
    End Sub

    Private Sub Anim_Tick(sender As Object, e As EventArgs) Handles Anim.Tick
        'Animation of Coverdesign to RIGHT'
        If CoverDesign.Width < Me.Width And CoverDesign.Left < 1 And isLeft Then
            CoverDesign.Width += 20
        ElseIf CoverDesign.Left < Me.Width - 500 And CoverDesign.Width > 500 And isLeft Then
            CoverDesign.Left += 20
            CoverDesign.Width -= 20
            lognPanel.Left -= 20
            username.Text = ""
            password.Text = ""
            Dim Alpha As Integer = If((CoverDesign.Left < 275),
                max - (((CoverDesign.Left / (coverLength / 2))) * max),
                        max * ((CoverDesign.Left - (coverLength / 2)) / (coverLength / 2)))
            SetControlOpacity(Greetings, Alpha)
            SetControlOpacity(Label1, Alpha)
            If CoverDesign.Left > 275 Then
                Greetings.Text = "Welcome Back!"
                Label1.Text = "Already have an account?"
                RegisterBtn.Text = "Login"
                loginBtn.Text = "Register"
                lblLogin.Text = "Register"

            End If



            'Animation of Coverdesign to LEFT'
        ElseIf CoverDesign.Width > 488 And CoverDesign.Left > 0 And Not isLeft Then
            CoverDesign.Width += 20
            CoverDesign.Left -= 20

            If CoverDesign.Left < coverLength / 2 Then
                Greetings.Text = "Hello, Welcome!"
                Label1.Text = "Don't have an account?"
                RegisterBtn.Text = "Register"
                loginBtn.Text = "Login"
                lblLogin.Text = "Login"
            End If

            Dim Alpha As Integer = If((CoverDesign.Left < 275),
                max - (((CoverDesign.Left / (coverLength / 2))) * max),
                max * ((CoverDesign.Left - (coverLength / 2)) / (coverLength / 2)))
            SetControlOpacity(Greetings, Alpha)
            SetControlOpacity(Label1, Alpha)
        ElseIf CoverDesign.Left = 0 And CoverDesign.Width > 488 And Not isLeft Then
            CoverDesign.Width -= 20
            lognPanel.Left += 20
            username.Text = ""
            password.Text = ""

        Else
            Greetings.Left = (CoverDesign.Width - Greetings.Width) \ 2
            Logo.Left = (CoverDesign.Width - Logo.Width) \ 2
            SetControlOpacity(Greetings, 255)
            SetControlOpacity(Label1, 255)
            lognPanel.Left = If(Not isLeft, 500, 0)
            isLeft = Not isLeft
            Anim.Stop()
        End If
    End Sub







    '1st Version'

    'Dim isLeft As Boolean = True
    'Dim coverLength As Integer = 550
    'Dim max As Integer = 255
    'Dim min As Integer = 0

    'Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
    '    Greetings.ForeColor = Color.FromArgb(50, Greetings.ForeColor.R, Greetings.ForeColor.G, Greetings.ForeColor.B)
    '    Anim.Start()

    'End Sub

    'Private Sub Anim_Tick(sender As Object, e As EventArgs) Handles Anim.Tick
    '    If CoverDesign.Left < coverLength And isLeft Then
    '        CoverDesign.Left += 10

    '        If CoverDesign.Left > coverLength / 2 Then
    '            Greetings.Text = "Welcome Back!"
    '            Label1.Text = "Already have an account?"

    '        End If

    '        'Opacity Changing or Animation Area'
    '        Dim Alpha As Integer = If((CoverDesign.Left < 275),
    '            max - (((CoverDesign.Left / (coverLength / 2))) * max),
    '            max * ((CoverDesign.Left - (coverLength / 2)) / (coverLength / 2)))
    '        SetControlOpacity(Greetings, Alpha)
    '        SetControlOpacity(RegisterBtn, Alpha)
    '        SetControlOpacity(Label1, Alpha)
    '    ElseIf CoverDesign.Left <> 0 And Not isLeft Then
    '        CoverDesign.Left -= 10

    '        If CoverDesign.Left > coverLength / 2 Then
    '            Greetings.Text = "Hello, Welcome!"
    '            Label1.Text = "Don't have an account?"
    '        End If

    '        Dim Alpha As Integer = If((CoverDesign.Left < 275),
    '            max - (((CoverDesign.Left / (coverLength / 2))) * max),
    '            max * ((CoverDesign.Left - (coverLength / 2)) / (coverLength / 2)))
    '        SetControlOpacity(Greetings, Alpha)
    '        SetControlOpacity(Label1, Alpha)
    '    Else
    '        isLeft = Not isLeft
    '        Anim.Stop()
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginDialog.Show()
    End Sub

    Private Sub RegisterBtn_MouseHover(sender As Object, e As EventArgs) Handles RegisterBtn.MouseEnter
        RegisterBtn.ForeColor = Color.Black
    End Sub
    Private Sub RegisterBtn_MouseLeave(sender As Object, e As EventArgs) Handles RegisterBtn.MouseLeave
        RegisterBtn.ForeColor = Color.White
    End Sub

    Private Sub SetControlOpacity(control As Control, opacity As Integer)
        ' Ensure the opacity is between 0 and 255
        If opacity < 0 Then opacity = 0
        If opacity > 255 Then opacity = 255

        ' Update the control's ForeColor with the new opacity
        control.Tag = opacity
        control.Invalidate()
    End Sub

    Private Sub Greetings_Paint(sender As Object, e As PaintEventArgs) Handles Greetings.Paint, Label1.Paint
        Dim control As Control = CType(sender, Control)
        Dim opacity As Integer = If(control.Tag IsNot Nothing, CInt(control.Tag), 255)
        Dim brush As New SolidBrush(Color.FromArgb(opacity, control.ForeColor.R, control.ForeColor.G, control.ForeColor.B))
        e.Graphics.Clear(control.ForeColor)
        e.Graphics.Clear(control.BackColor)
        e.Graphics.DrawString(control.Text, control.Font, brush, New PointF(0, 0))
    End Sub


    Private Sub RegisterPanel(ByVal originalPanel As Panel, ByVal Location As Point)
        Dim newPanel As New Panel()
        newPanel.Size = originalPanel.Size
        newPanel.BorderStyle = originalPanel.BorderStyle
        newPanel.Location = Location
    End Sub


    Private Sub showPswrd_CheckedChanged(sender As Object, e As EventArgs) Handles showPswrd.CheckedChanged
        If showPswrd.Checked Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    'TODO errors occured'
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginDialog.isButtonClicked = True
        If isLeft Then
            If DBUsername(username.Text, password.Text) Then
                loginDialog.isButtonClicked = False
                Menu.Show()
                Me.Close()
            ElseIf Not Database.Storedusername = username.Text Then
                loginDialog.message.Text = "Username is not yet registered"
                loginDialog.Show()
            Else
                loginDialog.Show()
            End If
        Else
            loginDialog.Show()
        End If
    End Sub

End Class
