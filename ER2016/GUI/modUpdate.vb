Imports System.Data.SqlClient
Module modUpdate
    Dim con As SqlConnection
    Dim comm As SqlCommand

    Public Sub ChangePassword()
        con = New SqlConnection
        con.ConnectionString = "Data Source=itdevjrgomez;Initial Catalog=ERDB;Persist Security Info=True;User ID=eti;Password=enigmatech2015"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangePassword"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.Parameters.AddWithValue("@NewPassword", frmChangePassword.txtConfirmPassword.Text)
        comm.ExecuteNonQuery()
        MessageBox.Show("Success")
    End Sub

    Public Sub ChangeActive()
        con = New SqlConnection
        con.ConnectionString = "Data Source=itdevjrgomez;Initial Catalog=ERDB;Persist Security Info=True;User ID=eti;Password=enigmatech2015"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangeActive"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.ExecuteNonQuery()
    End Sub

    Public Sub ChangeInactive()
        con = New SqlConnection
        con.ConnectionString = "Data Source=itdevjrgomez;Initial Catalog=ERDB;Persist Security Info=True;User ID=eti;Password=enigmatech2015"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "ChangeInactive"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@UserId", LoginPublicValues.UserId)
        comm.ExecuteNonQuery()
    End Sub
End Module
