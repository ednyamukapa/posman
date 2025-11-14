Public Class splashScreen

    Private Sub splashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        timerSplash.Interval = 100
        timerSplash.Start()
        progressSplash.Minimum = 0
        progressSplash.Maximum = 100
        
    End Sub

    Private Sub timerSplash_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        progressSplash.Value += 1
        progressSplash.Refresh()

        If progressSplash.Value = 5 Then
            Label1.Visible = True
            Label1.Text = "Starting modules..."
        ElseIf progressSplash.Value = 25 Then
            Label1.Text = "Loading modules..."
        ElseIf progressSplash.Value = 55 Then
            Label1.Text = "Starting database files..."
        ElseIf progressSplash.Value = 75 Then
            Label1.Text = "Loading database files..."
        ElseIf progressSplash.Value = 90 Then
            Label1.Text = "Finishing loading dependencies..."
        End If

        If progressSplash.Value = 100 Then
            Me.Hide()
            timerSplash.Stop()
            login.Show()
        End If
    End Sub
End Class
