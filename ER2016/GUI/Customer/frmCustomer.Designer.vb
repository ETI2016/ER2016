<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageMain = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_find
        '
        Me.btn_find.Image = CType(resources.GetObject("btn_find.Image"), System.Drawing.Image)
        Me.btn_find.Location = New System.Drawing.Point(230, 319)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(49, 48)
        Me.btn_find.TabIndex = 31
        Me.btn_find.Text = "Find"
        Me.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.Location = New System.Drawing.Point(493, 319)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(49, 48)
        Me.btn_cancel.TabIndex = 30
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.Location = New System.Drawing.Point(175, 319)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(49, 48)
        Me.btn_delete.TabIndex = 29
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.Location = New System.Drawing.Point(120, 319)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(49, 48)
        Me.btn_save.TabIndex = 28
        Me.btn_save.Text = "Save"
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.Location = New System.Drawing.Point(65, 319)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(49, 48)
        Me.btn_edit.TabIndex = 27
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(10, 319)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(49, 48)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 51)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(68, 17)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(218, 20)
        Me.txtCustomer.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Customer:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageMain)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 252)
        Me.TabControl1.TabIndex = 33
        '
        'TabPageMain
        '
        Me.TabPageMain.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPageMain.Controls.Add(Me.GroupBox1)
        Me.TabPageMain.Controls.Add(Me.txtEmail)
        Me.TabPageMain.Controls.Add(Me.Label19)
        Me.TabPageMain.Controls.Add(Me.txtPostalCode)
        Me.TabPageMain.Controls.Add(Me.Label18)
        Me.TabPageMain.Controls.Add(Me.txtProvince)
        Me.TabPageMain.Controls.Add(Me.Label17)
        Me.TabPageMain.Controls.Add(Me.txtCountry)
        Me.TabPageMain.Controls.Add(Me.Label16)
        Me.TabPageMain.Controls.Add(Me.txtCity)
        Me.TabPageMain.Controls.Add(Me.Label15)
        Me.TabPageMain.Controls.Add(Me.txtCname)
        Me.TabPageMain.Controls.Add(Me.Label14)
        Me.TabPageMain.Controls.Add(Me.txtMname)
        Me.TabPageMain.Controls.Add(Me.Label13)
        Me.TabPageMain.Controls.Add(Me.cmbGroup)
        Me.TabPageMain.Controls.Add(Me.Label5)
        Me.TabPageMain.Controls.Add(Me.txtContact)
        Me.TabPageMain.Controls.Add(Me.Label4)
        Me.TabPageMain.Controls.Add(Me.txtAddress)
        Me.TabPageMain.Controls.Add(Me.Label3)
        Me.TabPageMain.Controls.Add(Me.txtLname)
        Me.TabPageMain.Controls.Add(Me.txtFname)
        Me.TabPageMain.Controls.Add(Me.Label2)
        Me.TabPageMain.Controls.Add(Me.Label1)
        Me.TabPageMain.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMain.Name = "TabPageMain"
        Me.TabPageMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMain.Size = New System.Drawing.Size(520, 226)
        Me.TabPageMain.TabIndex = 1
        Me.TabPageMain.Text = "Main"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkActive)
        Me.GroupBox1.Controls.Add(Me.chkInactive)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 32)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(8, 12)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 24
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Enabled = False
        Me.chkInactive.Location = New System.Drawing.Point(78, 13)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(64, 17)
        Me.chkInactive.TabIndex = 25
        Me.chkInactive.Text = "Inactive"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(358, 128)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(142, 20)
        Me.txtEmail.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(306, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Email:"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Enabled = False
        Me.txtPostalCode.Location = New System.Drawing.Point(399, 45)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(101, 20)
        Me.txtPostalCode.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(306, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Postal Code/Zip:"
        '
        'txtProvince
        '
        Me.txtProvince.Enabled = False
        Me.txtProvince.Location = New System.Drawing.Point(399, 16)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(101, 20)
        Me.txtProvince.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(306, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(82, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Province/State:"
        '
        'txtCountry
        '
        Me.txtCountry.Enabled = False
        Me.txtCountry.Location = New System.Drawing.Point(358, 71)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(142, 20)
        Me.txtCountry.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(306, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Country:"
        '
        'txtCity
        '
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(88, 189)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(175, 20)
        Me.txtCity.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 192)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "City:"
        '
        'txtCname
        '
        Me.txtCname.Enabled = False
        Me.txtCname.Location = New System.Drawing.Point(88, 96)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(175, 20)
        Me.txtCname.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Company Name:"
        '
        'txtMname
        '
        Me.txtMname.Enabled = False
        Me.txtMname.Location = New System.Drawing.Point(88, 41)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(175, 20)
        Me.txtMname.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Middlename:"
        '
        'cmbGroup
        '
        Me.cmbGroup.Enabled = False
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"Walkin", "Loyale", "Reseller"})
        Me.cmbGroup.Location = New System.Drawing.Point(358, 162)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(142, 21)
        Me.cmbGroup.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Group:"
        '
        'txtContact
        '
        Me.txtContact.Enabled = False
        Me.txtContact.Location = New System.Drawing.Point(358, 100)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(142, 20)
        Me.txtContact.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact:"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(88, 131)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(175, 52)
        Me.txtAddress.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        '
        'txtLname
        '
        Me.txtLname.Enabled = False
        Me.txtLname.Location = New System.Drawing.Point(88, 70)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(175, 20)
        Me.txtLname.TabIndex = 3
        '
        'txtFname
        '
        Me.txtFname.Enabled = False
        Me.txtFname.Location = New System.Drawing.Point(88, 16)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(175, 20)
        Me.txtFname.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lastname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firstname:"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(520, 226)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Transactions"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(506, 188)
        Me.DataGridView1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Quotation", "Order", "Sales Transaction", "Void", "Return"})
        Me.ComboBox2.Location = New System.Drawing.Point(103, 6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(133, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Transaction Type:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.TextBox18)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.TextBox10)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(520, 226)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Account"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(358, 44)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(140, 20)
        Me.TextBox18.TabIndex = 39
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(303, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Ship Via:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(186, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 20)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Details"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(358, 17)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(140, 20)
        Me.TextBox10.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(310, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Terms :"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(95, 100)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(85, 20)
        Me.TextBox9.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Acc. Balance :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(95, 71)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(85, 20)
        Me.TextBox8.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Credit Limit :"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(95, 44)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(145, 20)
        Me.TextBox7.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Customer No. :"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(95, 17)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(145, 20)
        Me.TextBox6.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Account No. :"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(552, 373)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Maintenance"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageMain.ResumeLayout(False)
        Me.TabPageMain.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_find As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageMain As TabPage
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCname As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents chkInactive As CheckBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
