Public Class frmInvoice
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim choice As Integer = MessageBox.Show("Do you wan't to exit?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choice = DialogResult.Yes Then
            Dim formTransType As New frmTranType
            formTransType.Text = "Invoice Transaction"
            formTransType.Button2.Text = "New Transaction"
            formTransType.MdiParent = Me.ParentForm
            Me.Hide()
            formTransType.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmInvoice_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Button6_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmCusSearch.MdiParent = Me.ParentForm
        frmCusSearch.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmProdSearch.MdiParent = Me.ParentForm
        frmProdSearch.Show()
    End Sub
End Class