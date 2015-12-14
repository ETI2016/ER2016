Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashTimer.Interval = 3000
        splashTimer.Enabled = True
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick
        splashTimer.Enabled = False
        Me.Hide()
        mdiMain.ShowDialog()
        Me.Close()
    End Sub
End Class