Public Class frmUserAccess
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmPOSAccess.MdiParent = Me.ParentForm
        frmPOSAccess.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmBOSAccess.MdiParent = Me.ParentForm
        frmBOSAccess.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmConfirmPass.MdiParent = Me.ParentForm
        frmConfirmPass.Show()
    End Sub
End Class