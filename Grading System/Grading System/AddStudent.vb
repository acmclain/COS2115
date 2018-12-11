Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddStudent

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Database is open")

            Dim Command = New SqlCommand("INSERT INTO Students (FirstName, LastName, DOB, Status, Comments) VALUES ('" & txtFirst.Text.Trim & "','" & txtLast.Text.Trim & "','" & txtDOB.Text.Trim & "','" & txtStatus.Text.Trim & "','" & txtComments.Text.Trim & "')", connection)

            Command.ExecuteNonQuery()

            MessageBox.Show("Row added")

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using

        Me.Close()
        frmMainMenu.Show()

    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDOB.KeyPress
        ' allows the text box to accept only numbers and
        ' the Backspace key and the "/"

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "/" Then
            e.Handled = True
        End If
    End Sub
End Class