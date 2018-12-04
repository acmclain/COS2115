Public Class frmStudent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()
    End Sub
End Class