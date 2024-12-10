Public Class Form_SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer1.Enabled = False
            Me.Hide()
            Form_HalamanUtama.Show()
        End If
    End Sub

    Private Sub Form_SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class