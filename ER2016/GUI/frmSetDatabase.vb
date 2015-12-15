Imports System.IO
Public Class frmSetDatabase
    Private Sub frmSetDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabasePublicValues.DatabaseName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\ERDatabase", "Server", Nothing)

        If DatabasePublicValues.DatabaseName = "" Then

        Else
            Me.Hide()
            frmLogin.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        DatabasePublicValues.DatabaseName = txtServer.Text
        ConnectionDatabase.ConnectionDB()
    End Sub
End Class