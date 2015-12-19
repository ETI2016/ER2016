Imports System.Data.SqlClient
Module modSearch

    Public con1 As SqlConnection
    Public strSql As String
    Public da1 As SqlDataAdapter
    Public cmd1 As SqlCommandBuilder
    Public ds1 As DataSet
    Dim dt1 As DataTable
    Dim dr1 As DataRow
    Dim Maxrow As String
    Public Sub frmCustomerSearch()
        Try
            con1 = New SqlConnection
            con1.ConnectionString = "Data Source=ERSERVER;Initial Catalog=ERDB;User ID=erdbuser;Password=usererdb"
            con1.Open()
            strSql = strSQLCust
            da1 = New SqlDataAdapter(strSql, con1)
            cmd1 = New SqlCommandBuilder(da1)
            ds1 = New DataSet

            Dim FindField As String
            FindField = frmCusSearch.cmbFind.Text
            Select Case FindField
                Case "FirstName"
                    strSql = "Select  * from  MCustomer where " + FindField + "=" + frmCusSearch.txtName.Text

                Case "LastName"
                    strSql = "Select  * from  MCustomer where " + FindField + "=" + frmCusSearch.txtName.Text
            End Select

            da1 = New SqlClient.SqlDataAdapter(strSql, con1)
            ds1 = New DataSet
            da1.Fill(ds1, "MCustomer")
            Maxrow = ds1.Tables("MCustomer").Rows.Count

            If Maxrow > 0 Then
                frmCusSearch.DataGridView1.DataSource = ConnectionCustomer.ds1.Tables(0).Columns
                frmCusSearch.DataGridView1.Refresh()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
