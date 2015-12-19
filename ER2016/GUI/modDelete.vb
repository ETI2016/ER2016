Imports System.Data.SqlClient
Module modDelete

    Dim con As SqlConnection
    Dim comm As SqlCommand
    Dim strSql As String
    Dim da1 As SqlDataAdapter
    Dim cmd1 As SqlCommandBuilder
    Dim ds1 As DataSet
    Dim rows As String
    Public Sub DelCustomerMain()
        con = New SqlConnection
        con.ConnectionString = "Data Source=ERSERVER;Initial Catalog=ERDB;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "DeleteCustomerMain"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@Customer_ID", modPublicValues.CustomerID)

        comm.ExecuteNonQuery()

    End Sub
End Module
