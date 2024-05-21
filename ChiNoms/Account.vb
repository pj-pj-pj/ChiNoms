Imports System.IO
Imports System.Reflection.Emit
Imports ChiNoms.Form1
Imports Newtonsoft.Json

Public Class Account
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
        Application.Restart()
    End Sub

    Private Sub btnBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnBack.LinkClicked
        Me.Hide()
        Admin_Requests.Hide()
        Event_Hall.Show()
        Admin_Requests.Hide()
    End Sub

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAddress.Width = 200

        Dim user = Form1.currentUser

        Dim jsonFilePath As String = $"{Form1.currentUser.email}.json"
        Dim jsonCustomer As String = JsonConvert.SerializeObject(Form1.currentUser, Formatting.Indented)
        Using writer As New StreamWriter(jsonFilePath, False)
            writer.Write(jsonCustomer)
        End Using

        lblName.Text = user.name
        lblAge.Text = user.age
        lblBday.Text = user.birthday.ToString("MM-yyyy-dd")
        lblSex.Text = user.sex
        lblAddress.Text = user.address.Replace(", ", Environment.NewLine)
        lblEmail.Text = user.email
        lblPhoneNum.Text = user.phoneNumber

        updateView()
    End Sub

    Function updateView()
        DataGridView1.Rows.Clear()
        For Each reservation In Form1.currentUser.listOfReservations
            DataGridView1.Rows.Add(reservation.eventType, reservation.status, reservation.days, reservation.totalPayment, ">>")
        Next
    End Function

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < Form1.currentUser.listOfReservations.Count Then
            Dim rowIndex As Integer = e.RowIndex
            Debug.WriteLine(rowIndex)

            Form1.currentReservation = Form1.currentUser.listOfReservations.Item(rowIndex)

            With Reservation_Confirmation
                .CurrentReservation = Form1.currentReservation
                .btnBacktoo.Visible = False
                .Label12.Visible = True
                If Form1.currentReservation.status = "Approved" Then
                    .Label12.Text = "----------- This reservation has been approved and -----------" & Environment.NewLine & "waiting for payment"
                    .Label12.Text = "---- This reservation is pending and waiting for approval ----"
                    .Button1.Visible = True
                ElseIf Form1.currentReservation.status = "Approved & Paid" Then
                    .Label12.Text = "--------- This reservation has been approved and paid --------"
                    .Button1.Visible = False
                ElseIf Form1.currentReservation.status = "Cancelled" Then
                    .Label12.Text = "------- Reservation cancelled, please contact ChiNoms --------" & Environment.NewLine & "for more information"
                    .Button1.Visible = False
                Else
                    .Label12.Text = "---- This reservation is pending and waiting for approval ----"
                    .Button1.Visible = False
                End If
                .Show()
            End With

            Me.Hide()

            DataGridView1.ClearSelection()
        End If
    End Sub

End Class