Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditStudent
    Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmStudent.Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmStudent.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Using connection As New SqlConnection(connectionString)
            'connection.Open()
            'MessageBox.Show("Database is open")

            'Dim Command = New SqlCommand("INSERT INTO Students (FirstName, LastName, DOB, Status, Comments) VALUES ('" & txtFirst.Text & "','" & txtLast.Text & "','" & txtDOB.Text & "','" & txtStatus.Text & "','" & txtComments.Text & "')", connection)

            'Command.ExecuteNonQuery()

            'MessageBox.Show("Row added")

            'connection.Close()
            'MessageBox.Show("Database is closed")

        'End Using

        Me.Close()
        frmStudent.Show()
    End Sub
End Class