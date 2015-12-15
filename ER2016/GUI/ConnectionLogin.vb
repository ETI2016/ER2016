Imports System.Data.SqlClient
Module ConnectionLogin
    Dim LoginConnect As SqlConnection
    Dim LoginCommand As SqlCommand
    Public Sub Connection()
        'Check login details
        Dim ConnectLogin As SqlConnection
        Dim CommandLogin As SqlCommandBuilder
        Dim LoginDataAdapter As SqlDataAdapter
        Dim LoginDataSet As DataSet
        Dim LoginSQL As String
        Dim LoginRows As Integer

        ConnectLogin = New SqlConnection
        ConnectLogin.ConnectionString = "Data Source=" + DatabasePublicValues.DatabaseName + ";Initial Catalog=ERDB;Persist Security Info=True;User ID=erdbuser;Password=usererdb"
        ConnectLogin.Open()
        LoginSQL = "SELECT * FROM MUser WHERE UserName = '" + frmLogin.txtUsername.Text + "' And UPassword ='" + frmLogin.txtPassword.Text + "' "
        LoginDataAdapter = New SqlDataAdapter(LoginSQL, ConnectLogin)
        CommandLogin = New SqlCommandBuilder(LoginDataAdapter)
        LoginDataSet = New DataSet
        LoginDataAdapter.Fill(LoginDataSet, "MUser")
        LoginRows = LoginDataSet.Tables(0).Rows.Count


        If LoginRows > 0 Then
            LoginPublicValues.UserId = LoginDataSet.Tables("MUser").Rows(0).Item(0)
            If LoginDataSet.Tables("MUser").Rows(0).Item(4) = True Then
                frmChangePassword.Show()
            End If
            If LoginDataSet.Tables("MUser").Rows(0).Item(4) = False Then
                LoginPublicValues.UserId = LoginDataSet.Tables("MUser").Rows(0).Item(0)
                modUpdate.ChangeActive()
                frmLogin.Hide()
                frmSplash.ShowDialog()
                frmLogin.Close()
            End If

        Else
            MessageBox.Show("Incorrect Login!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'ITDev Niel 12/15/2015
    End Sub
End Module
