Public Class Login_as_Admin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtEmailAdd.Text = "noms@chinoms.com" And txtPass.Text = "noms" Then
            Me.Hide()
            Admin_Requests.Show()
        Else
            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lnlGuest_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnlGuest.LinkClicked
        Login_Your_Account.txtEmailAdd.Clear()
        Login_Your_Account.txtPass.Clear()

        Me.Hide()
        Login_Your_Account.Show()
    End Sub

    Private Sub Login_as_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmailAdd.Clear()
        txtPass.Clear()
    End Sub
End Class