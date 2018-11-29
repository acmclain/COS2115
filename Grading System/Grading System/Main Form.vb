Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Mercy
        Dim connectionString As String = "Data Source = DESKTOP-II3CLP1\SQLEXPRESS;Initial Catalog=LPA;Integrated Security=true"
        'Hannah
        ' Dim connectionString As String = "Data Source = MIS-W10-030\SQLEXPRESS;Initial Catalog=LPA;Integrated Security=true"
        'Andrew
        '  Dim connectionString As String = "Data Source = DESKTOP-6VVI9NG\SQLEXPRESS;Initial Catalog=LPA;Integrated Security=true"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            MessageBox.Show("Database is open")

            connection.Close()
            MessageBox.Show("Database is closed")

        End Using
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Connect.Show()

    End Sub
End Class
