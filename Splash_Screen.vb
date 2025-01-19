Public Class Splash_Screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Loading_Bar.Width < 700 And Loading_Bar.Width <> 700 Then
            Loading_Bar.Width += 2
        Else
            LoginForm.Show()
            Me.Hide()
            Timer1.Dispose()
        End If

    End Sub
End Class
