Public Class frmDepartment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAddEditDep.Text = "Add Department"
        frmAddEditDep.MdiParent = Me.ParentForm
        frmAddEditDep.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAddEditDep.Text = "Edit Department"
        frmAddEditDep.MdiParent = Me.ParentForm
        frmAddEditDep.Show()
    End Sub
End Class