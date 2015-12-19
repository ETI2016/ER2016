Imports System.Data.SqlClient
Module modAdd
    Dim con As SqlConnection
    Dim comm As SqlCommand
    Dim strSql As String
    Dim da1 As SqlDataAdapter
    Dim cmd1 As SqlCommandBuilder
    Dim ds1 As DataSet
    Dim rows As String
    Dim dr1 As DataRow

    Public Sub frmCustomerAdd()


        con = New SqlConnection
        con.ConnectionString = "Data Source=ERSERVER;Initial Catalog=ERDB;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "AddCustomer"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@Customer_Code", "asdf")
        comm.Parameters.AddWithValue("@FirstName", frmCustomer.txtFname.Text)
        comm.Parameters.AddWithValue("@MiddleName", frmCustomer.txtMname.Text)
        comm.Parameters.AddWithValue("@LastName", frmCustomer.txtLname.Text)
        comm.Parameters.AddWithValue("@CompanyName", frmCustomer.txtCname.Text)
        comm.Parameters.AddWithValue("@Customer_Address", frmCustomer.txtAddress.Text)
        comm.Parameters.AddWithValue("@City", frmCustomer.txtCity.Text)
        comm.Parameters.AddWithValue("@Province", frmCustomer.txtProvince.Text)
        comm.Parameters.AddWithValue("@PostalCode", frmCustomer.txtPostalCode.Text)
        comm.Parameters.AddWithValue("@Country", frmCustomer.txtCountry.Text)
        comm.Parameters.AddWithValue("@Contact", frmCustomer.txtContact.Text)
        comm.Parameters.AddWithValue("@EmailAddress", frmCustomer.txtEmail.Text)
        comm.Parameters.AddWithValue("@CustomerGroup_ID", frmCustomer.GroupId)
        comm.Parameters.AddWithValue("@PriceLevelHD_ID", frmCustomer.GroupId)
        comm.Parameters.AddWithValue("@Register_Date", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"))
        comm.Parameters.AddWithValue("@Active", frmCustomer.Status)
        comm.Parameters.AddWithValue("@UserID", modPublicValues.UserId)

        comm.ExecuteNonQuery()
    End Sub
End Module
