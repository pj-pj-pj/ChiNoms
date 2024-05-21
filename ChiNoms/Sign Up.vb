Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Sign_Up
    Public newUser As Form1.Customer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login_Your_Account.Show()

        txtName.Text = ""
        txtAge.Text = ""
        txtPhoneNum.Text = ""
        cbSex.SelectedValue = 0
        txtAddress.Text = ""
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim isValid As Boolean = True

        If txtName.Text.Trim = "" Then
            MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        Dim phoneNumPattern As String = "^\d{11}$"

        If Not Regex.IsMatch(txtPhoneNum.Text, phoneNumPattern) Then
            MessageBox.Show("Invalid phone number format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If CInt(txtAge.Text) < 0 Then
            MessageBox.Show("Invalid birth date, please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If isValid Then
            newUser = New Form1.Customer(txtName.Text, txtAddress.Text,
                                            txtPhoneNum.Text, dtpBirthday.Value,
                                            cbSex.Text, CInt(txtAge.Text))
            Me.Hide()
            Sign_Up2.Show()
        End If
    End Sub

    Private Sub Sign_Up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSex.SelectedIndex = 0
    End Sub

    Private Function CalculateAge(birthday As DateTime, currentDate As DateTime) As Integer
        Dim age As Integer = currentDate.Year - birthday.Year
        If currentDate < birthday.AddYears(age) Then
            age -= 1
        End If
        Return age
    End Function

    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        Dim birthday As DateTime = dtpBirthday.Value
        Dim age As Integer = CalculateAge(birthday, DateTime.Now)
        txtAge.Text = age.ToString()
    End Sub
End Class