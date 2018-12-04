Public Class frmStudent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
    End Sub
End Class