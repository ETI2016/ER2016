Imports System.Data.SqlClient
Module modUpdate
    Dim con As SqlConnection
    Dim comm As SqlCommand

    Public Sub ChangePassword()
        'Change password of the user
        con = New SqlConnection
        con.ConnectionString = "Data Source=" + DatabasePublicValues.DatabaseName + ";Initial Catalog=ERDB;Persist Security Info=True;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangePassword"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.Parameters.AddWithValue("@NewPassword", frmChangePassword.txtConfirmPassword.Text)
        comm.ExecuteNonQuery()
        MessageBox.Show("Change password complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ITDev Niel 12/15/2015
    End Sub


    Public Sub ChangeActive()
        'Change status active of the user
        con = New SqlConnection
        con.ConnectionString = "Data Source=" + DatabasePublicValues.DatabaseName + " ;Initial Catalog=ERDB;Persist Security Info=True;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangeActive"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.ExecuteNonQuery()
        'ITDev Niel 12/15/2015
    End Sub

    Public Sub ChangeInactive()
        'Change status inactive of the user
        con = New SqlConnection
        con.ConnectionString = "Data Source=" + DatabasePublicValues.DatabaseName + ";Initial Catalog=ERDB;Persist Security Info=True;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangeInactive"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.ExecuteNonQuery()
        'ITDev Niel 12/15/2015
    End Sub
End Module
