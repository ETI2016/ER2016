Public Class frmStore
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click

    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "<Add New>" Then
            ComboBox1.Text = Nothing
            frmStoreType.MdiParent = Me.ParentForm
            frmStoreType.Show()
        End If
    End Sub
End Class