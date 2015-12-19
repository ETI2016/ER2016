Imports System.Data.SqlClient

Module ConnectionCustomer
    Public ds1 As DataSet
    Public strSQLCust As String
    Public con1 As SqlConnection
    Public strSql As String
    Public da1 As SqlDataAdapter
    Public cmd1 As SqlCommandBuilder
    Public rowpos As String


    Public Sub connect()


        Try
            con1 = New SqlConnection
            con1.ConnectionString = "Data Source=ERSERVER;Initial Catalog=ERDB;User ID=erdbuser;Password=usererdb"
            con1.Open()
            strSql = strSQLCust
            da1 = New SqlDataAdapter(strSql, con1)
            cmd1 = New SqlCommandBuilder(da1)
            ds1 = New DataSet
            da1.Fill(ds1, "MCustomer")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
