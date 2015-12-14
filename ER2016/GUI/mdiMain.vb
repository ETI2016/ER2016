Public Class mdiMain
    Private Sub mdiMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        modUpdate.ChangeInactive()
    End Sub

    Private Sub mdiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim formTranType As New frmTranType
        formTranType.Text = "Quotations"
        formTranType.Button2.Text = "New Quotation"
        formTranType.MdiParent = Me
        formTranType.Show()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim formProducts As New frmProduct
        formProducts.MdiParent = Me
        formProducts.Show()
    End Sub

    Private Sub InvoicingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicingToolStripMenuItem.Click
        Dim formTranType As New frmTranType
        formTranType.Text = "Invoice Transactions"
        formTranType.Button2.Text = "New Transaction"
        formTranType.MdiParent = Me
        formTranType.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        Dim formTranType As New frmTranType
        formTranType.Text = "Payment"
        formTranType.Button2.Visible = False
        formTranType.MdiParent = Me
        formTranType.Show()
    End Sub

    Private Sub SalesRefundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesRefundToolStripMenuItem.Click
        Dim formRVSelect As New frmRVSelector
        formRVSelect.Text = "Sales Returns"
        formRVSelect.MdiParent = Me
        formRVSelect.Show()
    End Sub

    Private Sub SalesVoidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesVoidToolStripMenuItem.Click
        Dim formRVSelect As New frmRVSelector
        formRVSelect.Text = "Sales Void"
        formRVSelect.MdiParent = Me
        formRVSelect.Show()
    End Sub

    Private Sub PurchasingToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim formPurchasing As New frmPurchasing
        formPurchasing.MdiParent = Me
        formPurchasing.Show()
    End Sub

    Private Sub RecievablesToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim formReceiving As New frmReceiving
        formReceiving.MdiParent = Me
        formReceiving.Show()
    End Sub

    Private Sub TransfersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransfersToolStripMenuItem.Click
        Dim formTransfer As New frmTransfers
        formTransfer.MdiParent = Me
        formTransfer.Show()
    End Sub

    Private Sub ReturnToVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToVendorToolStripMenuItem.Click
        Dim formRTV As New frmReturnToVendor
        formRTV.MdiParent = Me
        formRTV.Show()
    End Sub

    Private Sub InvAdjustmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvAdjustmentsToolStripMenuItem.Click
        Dim formInvAdjustment As New frmInvAdjustment
        formInvAdjustment.MdiParent = Me
        formInvAdjustment.Show()
    End Sub

    Private Sub InvLookupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvLookupToolStripMenuItem.Click
        Dim formInvLookup As New frmInvLookup
        formInvLookup.MdiParent = Me
        formInvLookup.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim formCustomer As New frmCustomer
        formCustomer.MdiParent = Me
        formCustomer.Show()
    End Sub

    Private Sub CustomerGroupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerGroupToolStripMenuItem.Click
        Dim formCusGroup As New frmCusGroup
        formCusGroup.MdiParent = Me
        formCusGroup.Show()
    End Sub

    Private Sub Splitter2_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim formDepartment As New frmDepartment
        formDepartment.MdiParent = Me
        formDepartment.Show()
    End Sub

    Private Sub StoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoreToolStripMenuItem.Click
        Dim formStore As New frmStore
        formStore.MdiParent = Me
        formStore.Show()
    End Sub

    Private Sub UserAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAccessToolStripMenuItem.Click
        Dim formUserAccess As New frmUserAccess
        formUserAccess.MdiParent = Me
        formUserAccess.Show()
    End Sub

    Private Sub VendorSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorSupplierToolStripMenuItem.Click
        Dim formVendorSupplier As New frmVendorSupplier
        formVendorSupplier.MdiParent = Me
        formVendorSupplier.Show()
    End Sub

    Private Sub InventorySnapshotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventorySnapshotToolStripMenuItem.Click
        Dim formInvSnapshot As New frmInvSnapshot
        formInvSnapshot.MdiParent = Me
        formInvSnapshot.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProduct.MdiParent = Me
        frmProduct.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmCustomer.MdiParent = Me
        frmCustomer.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmVendorSupplier.MdiParent = Me
        frmVendorSupplier.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmPurchasing.MdiParent = Me
        frmPurchasing.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        frmReceiving.MdiParent = Me
        frmReceiving.Show()
    End Sub
End Class