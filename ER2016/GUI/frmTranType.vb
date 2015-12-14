Public Class frmTranType
    Private Sub frmTranType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "New Transaction" Then
            Dim formInvoice As New frmInvoice
            formInvoice.MdiParent = Me.ParentForm
            Me.Hide()
            formInvoice.Show()
            Me.Close()
        End If
        If Button2.Text = "New Quotation" Then
            Dim formQuote As New frmQuote
            formQuote.MdiParent = Me.ParentForm
            Me.Hide()
            formQuote.Show()
            Me.Close()
        End If
        If Button2.Text = "Payment" Then
            Dim formPayment As New frmPayment
            formPayment.MdiParent = Me.ParentForm
            Me.Hide()
            formPayment.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If Me.Text = "Invoice Transactions" Then
            Dim formInvoice As New frmInvoice
            formInvoice.MdiParent = Me.ParentForm
            Me.Hide()
            formInvoice.Show()
            Me.Close()
        End If
        If Me.Text = "Quotations" Then
            Dim formQuote As New frmQuote
            formQuote.MdiParent = Me.ParentForm
            Me.Hide()
            formQuote.Show()
            Me.Close()
        End If
        If Me.Text = "Payment" Then
            Dim formPayment As New frmPayment
            formPayment.MdiParent = Me.ParentForm
            Me.Hide()
            formPayment.Show()
            Me.Close()
        End If
    End Sub
End Class