<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvLookup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvLookup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.storeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.availQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyOnOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtySales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.minStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(873, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(188, 21)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(315, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Department:"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(643, 21)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(215, 20)
        Me.TextBox3.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.storeCode, Me.storeName, Me.availQty, Me.qtyOnHand, Me.qtyOnOrder, Me.qtySales, Me.minStock, Me.maxStock})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(870, 322)
        Me.DataGridView1.TabIndex = 1
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
        'availQty
        '
        Me.availQty.HeaderText = "Available"
        Me.availQty.Name = "availQty"
        '
        'qtyOnHand
        '
        Me.qtyOnHand.HeaderText = "On Hand"
        Me.qtyOnHand.Name = "qtyOnHand"
        '
        'qtyOnOrder
        '
        Me.qtyOnOrder.HeaderText = "On Order"
        Me.qtyOnOrder.Name = "qtyOnOrder"
        '
        'qtySales
        '
        Me.qtySales.HeaderText = "Sales"
        Me.qtySales.Name = "qtySales"
        '
        'minStock
        '
        Me.minStock.HeaderText = "Min Stock"
        Me.minStock.Name = "minStock"
        '
        'maxStock
        '
        Me.maxStock.HeaderText = "Max Stock"
        Me.maxStock.Name = "maxStock"
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(64, 396)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(49, 48)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Print"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(119, 396)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(49, 48)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Cancel"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(9, 396)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 48)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Find"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frmInvLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(894, 447)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmInvLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Lookup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents storeCode As DataGridViewTextBoxColumn
    Friend WithEvents storeName As DataGridViewTextBoxColumn
    Friend WithEvents availQty As DataGridViewTextBoxColumn
    Friend WithEvents qtyOnHand As DataGridViewTextBoxColumn
    Friend WithEvents qtyOnOrder As DataGridViewTextBoxColumn
    Friend WithEvents qtySales As DataGridViewTextBoxColumn
    Friend WithEvents minStock As DataGridViewTextBoxColumn
    Friend WithEvents maxStock As DataGridViewTextBoxColumn
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
End Class
