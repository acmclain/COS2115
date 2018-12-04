Public Class frmStudent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class