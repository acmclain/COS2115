﻿Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmMainMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' connection.close()
        Me.Close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Using connection As New SqlConnection(connectionString)
        '  connection.Open()
        '  MessageBox.Show("Database is open")

        ' connection.Close()
        ' MessageBox.Show("Database is closed")

        '  End Using
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddStudent.Show()

    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged

    End Sub
End Class
