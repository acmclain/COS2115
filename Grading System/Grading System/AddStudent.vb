Public Class frmAddStudent
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtComments.TextChanged

    End Sub

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirst As String = txtFirst.Text
        Dim strLast As String = txtLast.Text
        Dim strStatus As String = txtstatus.Text
        Dim strComments As String = txtComments.Text
        Dim dblDOB As Double

        Double.TryParse(txtDOB.Text, dblDOB)

    End Sub
End Class