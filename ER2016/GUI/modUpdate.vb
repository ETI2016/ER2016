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
        comm.Parameters.AddWithValue("@UserId", modPublicValues.UserId)
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
        comm.Parameters.AddWithValue("@UserId", modPublicValues.UserId)
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
        comm.Parameters.AddWithValue("@UserId", modPublicValues.UserId)
        comm.ExecuteNonQuery()
    End Sub

    Public Sub EditCustomerMain()

        con = New SqlConnection
        con.ConnectionString = "Data Source=ERSERVER;Initial Catalog=ERDB;User ID=erdbuser;Password=usererdb"
        con.Open()
        comm = New SqlCommand()
        comm.Connection = con
        comm.CommandText = "UpdateCustomerMain"
        comm.CommandType = CommandType.StoredProcedure

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
        comm.Parameters.AddWithValue("@Active", frmCustomer.Status)

        comm.Parameters.AddWithValue("@Update_Date", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"))
        comm.Parameters.AddWithValue("@Update_By", modPublicValues.UserId)
        comm.Parameters.AddWithValue("@Customer_ID", modPublicValues.CustomerID)



        comm.ExecuteNonQuery()


    End Sub
End Module
