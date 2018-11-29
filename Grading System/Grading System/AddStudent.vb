Public Class frmAddStudent
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class