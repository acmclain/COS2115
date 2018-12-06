Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmStudent

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Warnings before deleting a student from the Student database
        If MessageBox.Show("Are you sure you want to delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled, good choice!")
        Else
            If MessageBox.Show("Are you absolutely positive you want to permanently delete this student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.No Then
                MessageBox.Show("Operation Cancelled, thank you for not breaking anything!")
            Else
                If MessageBox.Show("This is your last warning... are you sure you want to delete this record? Please say NO", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled!")
                Else
                    'Delete from Student database
                    'Dim command = New SqlCommmand("DELETE FROM Student WHERE ")

                End If
                'Insert code to delete records from database
            End If
        End If

    End Sub
End Class