Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMainMenu
    Private dataReader As SqlDataReader

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT StudentID, FirstName, LastName FROM dbo.Students"


            Dim command As New SqlCommand(queryString, connection)


            dataReader = command.ExecuteReader()
            While dataReader.Read
                ' Write code to insert an Item into dropdownlist
                cboStudents.Items.Add(dataReader("FirstName").ToString() & dataReader("LastName").ToString())
            End While
            connection.Close()
            'cboStudents.Items.AddRange({command})

        End Using
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddStudent.Show()

    End Sub
    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        frmStudent.Show()
    End Sub
End Class
