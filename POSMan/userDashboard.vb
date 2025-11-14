Public Class userDashboard

    Private Sub userDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listProductSearch.Visible = False

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        listProductSearch.Visible = True
    End Sub
End Class