Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmStudent
    Private dataReader As SqlDataReader
    Private txtFirstName As String
    Private txtLastName As String
    Private txtDOB As String
    Private txtStatus As String
    Private txtComments As String


    Public intStudentID As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMainMenu.Hide()
        lblStudentID.Text = intStudentID
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT FirstName, LastName, DOB, Status, Comments FROM dbo.Students WHERE StudentID = " & intStudentID
            Dim command As New SqlCommand(queryString, connection)

            dataReader = command.ExecuteReader()
            While dataReader.Read
                txtFirstName = dataReader("FirstName")
                txtLastName = dataReader("LastName")
                txtDOB = dataReader("DOB")
                txtStatus = dataReader("Status")
                txtComments = dataReader("Comments")
            End While

            connection.Close()
        End Using
        lblFullName.Text = txtFirstName.Trim & " " & txtLastName
        lblDOB.Text = txtDOB
        lblStatus.Text = txtStatus
        lblComments.Text = txtComments

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
                    Using connection As New SqlConnection(connectionString)
                        connection.Open()

                        Dim queryString As String = "DELETE FROM dbo.Students WHERE StudentID = " & intStudentID
                        Dim command As New SqlCommand(queryString, connection)

                        command.ExecuteNonQuery()
                        connection.Close()
                    End Using
                End If
                'Insert code to delete records from database
            End If
        End If
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEditStudent.Show()

    End Sub
End Class