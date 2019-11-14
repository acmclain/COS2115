Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmHomePage
    Private dataReader As SqlDataReader
    Dim table As New DataTable("Table")



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Grid_load()

        'table.Columns.Add("ID", Type.GetType("System.Int32"))
        'table.Columns.Add("First Name", Type.GetType("System.String"))
        'table.Columns.Add("Last Name", Type.GetType("System.String"))
        'table.Columns.Add("Age", Type.GetType("System.Int32"))

        'table.Rows.Add(1, "xxxx", "yyyy", 21)
        'table.Rows.Add(1, "xxxx", "yyyy", 21)
        'table.Rows.Add(1, "xxxx", "yyyy", 21)
        'table.Rows.Add(1, "xxxx", "yyyy", 21)
        'table.Rows.Add(1, "xxxx", "yyyy", 21)
        'table.Rows.Add(1, "xxxx", "yyyy", 21)


        '    connection.Open()

        'Dim queryString As String = "SELECT StudentID, FirstName, LastName FROM dbo.Students"


        'Dim command As New SqlCommand(queryString, connection)
        'Dim comboSource As New Dictionary(Of String, String)()
        'comboSource.Add("", "")


        'dataReader = command.ExecuteReader()
        'While dataReader.Read
        'Add each student and student id to dictionary.
        'comboSource.Add(dataReader("StudentID"), dataReader("FirstName").ToString().Trim & " " & dataReader("LastName"))
        'End While
        'Display each student with hidden corresponding key in the combo box.
        'cboStudents.DataSource = New BindingSource(comboSource, Nothing)
        'cboStudents.DisplayMember = "Value"
        'cboStudents.ValueMember = "Key"
        'connection.Close()

        'End Using
    End Sub


    Public Sub Grid_load()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim adapter As New SqlDataAdapter("SELECT * FROM Peanuts", connection)

            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            connection.Close()
        End Using
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim queryString As String = "SELECT Butter, Food,  FROM dbo.Peanuts"

            '  Dim command As New SqlCommand(queryString, connection)
            Dim Command = New SqlCommand("INSERT INTO Peanuts (Butter) VALUES ('" & txtPeanut.Text.Trim & "')", connection)
            'Dim Command = New SqlCommand("INSERT INTO Students (FirstName, LastName, DOB, Status, Comments) VALUES ('" & txtFirst.Text.Trim & "','" & txtLast.Text.Trim & "','" & txtDOB.Text.Trim & "','" & txtStatus.Text.Trim & "','" & txtComments.Text.Trim & "')", connection)

            Command.ExecuteNonQuery()
            Grid_load()

            connection.Close()

        End Using
    End Sub



    'Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) 
    'Get the key from the selected item. 
    'Dim key As String = DirectCast(cboStudents.SelectedItem, KeyValuePair(Of String, String)).Key
    '   frmStudent.intStudentID = key
    '  frmStudent.Show()
    'End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    'End Sub
End Class