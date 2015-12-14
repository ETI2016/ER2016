Public Class frmQuote
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim choice As Integer = MessageBox.Show("Do you wan't to exit?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choice = DialogResult.Yes Then
            Dim formTransType As New frmTranType
            formTransType.Text = "Quotations"
            formTransType.Button2.Text = "New Quotation"
            formTransType.MdiParent = Me.ParentForm
            Me.Hide()
            formTransType.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmQuote_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Button7_Click(sender, e)
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