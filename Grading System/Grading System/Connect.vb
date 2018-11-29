Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Connect
    Private Sub Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source =DESKTOP-II3CLP\SQLEXPRESS;Initial Catalog=LPA;Integrated Security=true“

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Database is open")

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using
    End Sub
End Class