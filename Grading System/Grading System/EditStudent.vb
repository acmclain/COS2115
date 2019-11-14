Imports System
Imports System.Data
Imports System.Data.SqlClient

'Public Class frmEditStudent
'Public intID As Integer
'
'Public txtStudentFirstName As String
'Public txtStudentLastName As String
'Public txtStudentDOB As String
'Public txtStudentStatus As String
'Public txtStudentComments As String

'Private Sub frmEditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'frmStudent.Hide()
'txtFirst.Text = txtStudentFirstName.Trim
'txtLast.Text = txtStudentLastName.Trim
'txtDOB.Text = txtStudentDOB.Trim
'txtStatus.Text = txtStudentStatus.Trim
'txtComments.Text = txtStudentComments.Trim
'
'End Sub
'
'Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'Me.Close()
'frmStudent.Show()
'End Sub
'
'Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
'Using connection As New SqlConnection(connectionString)
'connection.Open()

'Dim Command = New SqlCommand("UPDATE Students SET FirstName = '" & txtFirst.Text & "', LastName = '" & txtLast.Text & "', DOB = '" & txtDOB.Text & "', Status = '" & txtStatus.Text & "', Comments = '" & txtComments.Text & "' WHERE StudentID = '" & intID & "'", connection)

'Command.ExecuteNonQuery()

'connection.Close()

'End Using

'Me.Close()
'frmStudent.Show()
'End Sub
'End Class