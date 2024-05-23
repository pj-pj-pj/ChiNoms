Imports ChiNoms.Form1
Imports Newtonsoft.Json
Imports System.IO

Public Class Login_Your_Account

    Private Sub lnlAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnlAdmin.LinkClicked
        Login_as_Admin.txtEmailAdd.Clear()
        Login_as_Admin.txtPass.Clear()

        txtEmailAdd.Clear()
        txtPass.Clear()
        Me.Hide()
        Login_as_Admin.Show()
    End Sub

    Private Sub lnlSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnlSignUp.LinkClicked
        txtEmailAdd.Clear()
        txtPass.Clear()
        Me.Hide()
        Sign_Up.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmailAdd.Text
        Dim password As String = txtPass.Text

        Dim jsonFilePath As String = $"{email}.json"

        If File.Exists(jsonFilePath) Then
            Dim jsonData As String

            Using reader As New StreamReader(jsonFilePath)
                jsonData = reader.ReadToEnd()
            End Using

            Dim customer As Customer = JsonConvert.DeserializeObject(Of Customer)(jsonData)

            If customer IsNot Nothing AndAlso customer.email = email AndAlso customer.password = password Then
                Form1.currentUser = customer
                Me.Hide()
                Account.Show()
            Else
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Your_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmailAdd.Clear()
        txtPass.Clear()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class