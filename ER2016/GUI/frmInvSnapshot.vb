Public Class frmInvSnapshot
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        frmSnapshot.MdiParent = Me.ParentForm
        frmSnapshot.Show()
    End Sub
End Class