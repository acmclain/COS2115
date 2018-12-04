Public Class frmStudent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled, good choice!")
        Else
            'Insert code to delete records from database
        End If
    End Sub
End Class