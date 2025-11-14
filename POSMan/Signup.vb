Imports System.Data.OleDb
Imports System.Text

Public Class Signup

    Private Conn As OleDbConnection
    Private cmd As OleDbCommand

    Private Sub ConnectDB()
        Try
            Conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CAPTAIN\documents\posman.Accdb;")
            Conn.Open()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database." & ex.Message)
        End Try
    End Sub


    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDB()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If Conn.State = ConnectionState.Closed Then
            ConnectDB()
        End If
        Try
            cmd = New OleDbCommand("INSERT INTO Users (AccountType, Username, Password) VALUES (@AccountType, @Username, @Password)", Conn)
            cmd.Parameters.AddWithValue("@AccountType", userType.SelectedText)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User saved successfully!")
            userType.ResetText()
            txtUsername.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message)
        End Try
    End Sub
End Class