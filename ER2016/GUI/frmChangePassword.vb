Public Class frmChangePassword
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If txtPassword.Text = txtConfirmPassword.Text Then
            modUpdate.ChangePassword()
            frmLogin.Hide()
            frmSplash.ShowDialog()
            frmLogin.Close()
            Me.Close()
        Else
            MessageBox.Show("Password did not match.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class