<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceiving))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.prodCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyOrdered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baseCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierProdCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(194, 20)
        Me.TextBox1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(193, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Order Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Order No.:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(222, 40)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 20)
        Me.TextBox11.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Discount:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(80, 40)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(83, 20)
        Me.TextBox10.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Terms Rate:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(63, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Supplier:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(323, 71)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(95, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(222, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Supplier Terms:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(95, 13)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(222, 20)
        Me.TextBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Shipping Terms:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(336, 75)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 94)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(95, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(193, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Receive Date:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(95, 39)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(222, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Supplier Ref No.:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(95, 13)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(222, 20)
        Me.TextBox6.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Invoice Number:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox7)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 148)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(322, 95)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Remarks"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(9, 16)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox7.Size = New System.Drawing.Size(307, 73)
        Me.TextBox7.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TextBox9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.TextBox8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(336, 168)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 75)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(78, 43)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(110, 20)
        Me.TextBox9.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Now:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(78, 16)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(110, 20)
        Me.TextBox8.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Totals: P.O."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(541, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Receive line"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(541, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Receive all"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DataGridView1)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 244)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(653, 191)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodCode, Me.prodDesc, Me.storeCode, Me.storeName, Me.qtyOrdered, Me.prodRemarks, Me.baseCost, Me.prodDisc, Me.supplierProdCode, Me.prodStatus})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 169)
        Me.DataGridView1.TabIndex = 0
        '
        'prodCode
        '
        Me.prodCode.HeaderText = "Product Code"
        Me.prodCode.Name = "prodCode"
        '
        'prodDesc
        '
        Me.prodDesc.HeaderText = "Description"
        Me.prodDesc.Name = "prodDesc"
        '
        'storeCode
        '
        Me.storeCode.HeaderText = "Store Code"
        Me.storeCode.Name = "storeCode"
        '
        'storeName
        '
        Me.storeName.HeaderText = "Store Name"
        Me.storeName.Name = "storeName"
        '
        'qtyOrdered
        '
        Me.qtyOrdered.HeaderText = "Ordered"
        Me.qtyOrdered.Name = "qtyOrdered"
        '
        'prodRemarks
        '
        Me.prodRemarks.HeaderText = "Remarks"
        Me.prodRemarks.Name = "prodRemarks"
        '
        'baseCost
        '
        Me.baseCost.HeaderText = "Base Cost"
        Me.baseCost.Name = "baseCost"
        '
        'prodDisc
        '
        Me.prodDisc.HeaderText = "Disc %"
        Me.prodDisc.Name = "prodDisc"
        '
        'supplierProdCode
        '
        Me.supplierProdCode.HeaderText = "Supplier Product Cost"
        Me.supplierProdCode.Name = "supplierProdCode"
        '
        'prodStatus
        '
        Me.prodStatus.HeaderText = "Status"
        Me.prodStatus.Name = "prodStatus"
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(610, 441)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 48)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "Print"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(555, 441)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 48)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Cancel"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(117, 441)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(49, 48)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Delete"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(172, 441)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 48)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Find"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(62, 441)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(49, 48)
        Me.Button9.TabIndex = 36
        Me.Button9.Text = "Save"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(7, 441)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(49, 48)
        Me.Button10.TabIndex = 35
        Me.Button10.Text = "New"
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frmReceiving
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(668, 494)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmReceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents prodCode As DataGridViewTextBoxColumn
    Friend WithEvents prodDesc As DataGridViewTextBoxColumn
    Friend WithEvents storeCode As DataGridViewTextBoxColumn
    Friend WithEvents storeName As DataGridViewTextBoxColumn
    Friend WithEvents qtyOrdered As DataGridViewTextBoxColumn
    Friend WithEvents prodRemarks As DataGridViewTextBoxColumn
    Friend WithEvents baseCost As DataGridViewTextBoxColumn
    Friend WithEvents prodDisc As DataGridViewTextBoxColumn
    Friend WithEvents supplierProdCode As DataGridViewTextBoxColumn
    Friend WithEvents prodStatus As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label11 As Label
End Class
