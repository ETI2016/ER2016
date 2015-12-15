Imports System.Data.SqlClient
Imports System.IO
Module ConnectionDatabase
    Dim ConnectDB As SqlConnection
    Public Sub ConnectionDB()
        'Test connection of database on 1st use
        Try
            ConnectDB = New SqlConnection
            ConnectDB.ConnectionString = "Data Source=" + DatabasePublicValues.DatabaseName + ";Initial Catalog=ERDB;Persist Security Info=True;User ID=erdbuser;Password=usererdb"
            ConnectDB.Open()
            MessageBox.Show("Connect Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Computer.Registry.CurrentUser.CreateSubKey("ERDatabase")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\ERDatabase", "Server", DatabasePublicValues.DatabaseName)
                frmSetDatabase.Hide()
                frmLogin.ShowDialog()
            frmSetDatabase.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'MessageBox.Show("Failed to connect database.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'ITDev Niel 12/15/2015
    End Sub

End Module
