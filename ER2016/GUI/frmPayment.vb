Public Class frmPayment
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim choice As Integer = MessageBox.Show("Do you wan't to exit?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If choice = DialogResult.Yes Then
            Dim formTransType As New frmTranType
            formTransType.Text = "Payament"
            formTransType.Button2.Visible = False
            formTransType.MdiParent = Me.ParentForm
            Me.Hide()
            formTransType.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmPayment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Button6_Click(sender, e)
    End Sub
End Class