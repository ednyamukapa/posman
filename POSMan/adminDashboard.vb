
Public Class adminDashboard

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PosmanDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.PosmanDataSet.Sales)
        timerAdminDateTime.Enabled = True
    End Sub

    Private Sub timerAdminDateTime_Tick(sender As Object, e As EventArgs) Handles timerAdminDateTime.Tick
        dateTime.Text = DateAndTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss")
    End Sub

End Class