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
            Dim comboSource As New Dictionary(Of String, String)()
            comboSource.Add("", "")


            dataReader = command.ExecuteReader()
            While dataReader.Read
                'Add each student and student id to dictionary.
                comboSource.Add(dataReader("StudentID"), dataReader("FirstName").ToString().Trim & " " & dataReader("LastName"))
            End While
            'Display each student with hidden corresponding key in the combo box.
            cboStudents.DataSource = New BindingSource(comboSource, Nothing)
            cboStudents.DisplayMember = "Value"
            cboStudents.ValueMember = "Key"
            connection.Close()

        End Using
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddStudent.Show()

    End Sub
    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectionChangeCommitted
        'Get the key from the selected item. 
        Dim key As String = DirectCast(cboStudents.SelectedItem, KeyValuePair(Of String, String)).Key
        frmStudent.intStudentID = key
        frmStudent.Show()
    End Sub
End Class