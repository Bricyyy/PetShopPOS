Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressbar.Width += 5

        If progressbar.Width >= 315 Then
            Timer1.Stop()
            Dim obj1 As New Login
            Dim obj2 As New Homepage
            If My.Settings.userRememberMe = True Then
                obj2.Show()
            Else
                obj1.Show()
            End If
            Me.Hide()
        End If
    End Sub
End Class
