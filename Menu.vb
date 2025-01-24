Public Class Menu



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginDialog.Show()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Active(Home)
        display(New Home)
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Active(Search)
        display(New Search)
    End Sub

    Private Sub Map_Click(sender As Object, e As EventArgs) Handles Map.Click
        Active(Map)
        display(New Map)
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Active(Settings)
        display(New Setting)
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display(New Home)

    End Sub

    Private Sub display(screen As UserControl)
        Main_Screen.Controls.Clear()
        screen.Dock = DockStyle.Fill
        Main_Screen.Controls.Add(screen)
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class