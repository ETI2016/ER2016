Public Class frmCusGroup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAddEditCusGroup.Text = "Add Customer Group"
        frmAddEditCusGroup.MdiParent = Me.ParentForm
        frmAddEditCusGroup.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAddEditCusGroup.Text = "Edit Customer Group"
        frmAddEditCusGroup.MdiParent = Me.ParentForm
        frmAddEditCusGroup.Show()
    End Sub
End Class