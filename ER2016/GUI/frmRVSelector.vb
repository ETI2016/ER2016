Public Class frmRVSelector
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmRVSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Text = "Sales Returns" Then
            Dim formReturns As New frmReturns
            formReturns.MdiParent = Me.ParentForm
            Me.Hide()
            formReturns.Show()
            Me.Close()
        End If
    End Sub
End Class