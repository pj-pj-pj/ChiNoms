Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json


Public Class Sign_Up2
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Sign_Up.Show()

        txtEmailAdd.Text = ""
        txtConfirmPass.Text = ""
        txtCreatePass.Text = ""
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function
    Private Function DoPasswordsMatch(pass1 As String, pass2 As String) As Boolean
        Return pass1 = pass2
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim email As String = txtEmailAdd.Text
        Dim createPass As String = txtCreatePass.Text
        Dim confirmPass As String = txtConfirmPass.Text
        Dim newUser As Form1.Customer = Sign_Up.newUser

        If Not IsValidEmail(email) Then
            MessageBox.Show("The email address is not valid.", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not DoPasswordsMatch(createPass, confirmPass) Then
            MessageBox.Show("The passwords do not match.", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim jsonFilePath As String = $"{email}.json"

        If File.Exists(jsonFilePath) Then
            MessageBox.Show("The email address is already registered.", "Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        newUser.email = email
        newUser.password = confirmPass

        Dim jsonCustomer As String = JsonConvert.SerializeObject(newUser, Newtonsoft.Json.Formatting.Indented)

        Using writer As New StreamWriter($"{newUser.email}.json", False)
            writer.Write(jsonCustomer)
        End Using

        Me.Hide()
        Login_Your_Account.Show()
    End Sub
End Class