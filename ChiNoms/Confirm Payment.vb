Imports System.IO
Imports ChiNoms.Form1
Imports Newtonsoft.Json

Public Class Confirm_Payment
    Private cateringPrice As Integer
    Private clownPrice As Integer
    Private singerPrice As Integer
    Private dancerPrice As Integer
    Private videokePrice As Integer
    Dim reservation = Form1.currentReservation

    Private Sub btnBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnBack.LinkClicked
        Me.Hide()
        Reservation_Confirmation.Show()
    End Sub

    Private Function CalculateServiceCost(pricePer50 As Integer, numGuests As Integer) As Integer
        Return Math.Ceiling(Math.Max(numGuests, 50) / 50) * pricePer50
    End Function

    Private Sub rdbGcash_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGcash.CheckedChanged
        pnlCreditCard.Hide()
    End Sub

    Private Sub rdbCreditCard_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCreditCard.CheckedChanged
        pnlCreditCard.Show()
    End Sub

    Private Sub Confirm_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCardNum.Clear()
        txtCVC.Clear()
        txtPhoneNum.Clear()
        txtPINnum.Clear()

        UpdateReservationDetails()
        pnlCreditCard.Hide()
    End Sub

    Private Sub UpdateReservationDetails()
        cateringPrice = CalculateServiceCost(20000, reservation.numGuests)
        clownPrice = CalculateServiceCost(10000, reservation.numGuests)
        singerPrice = CalculateServiceCost(7000, reservation.numGuests)
        dancerPrice = CalculateServiceCost(7000, reservation.numGuests)
        videokePrice = CalculateServiceCost(1000, reservation.numGuests)

        ' Update service labels
        lblCatering.Text = If(reservation.services.Contains("Catering"), cateringPrice.ToString(), "0")
        lblClown.Text = If(reservation.services.Contains("Clown"), clownPrice.ToString(), "0")
        lblDancer.Text = If(reservation.services.Contains("Dancer"), dancerPrice.ToString(), "0")
        lblSinger.Text = If(reservation.services.Contains("Singer"), singerPrice.ToString(), "0")
        lblVideoke.Text = If(reservation.services.Contains("Videoke"), videokePrice.ToString(), "0")

        ' Calculate the venue price
        Dim totalServiceCost As Integer = CInt(lblCatering.Text) + CInt(lblClown.Text) + CInt(lblDancer.Text) + CInt(lblSinger.Text) + CInt(lblVideoke.Text)
        Dim venuePrice As Integer = reservation.totalPayment - totalServiceCost

        ' Update labels
        lblVenue.Text = venuePrice.ToString()
        lblTotalPrice.Text = reservation.totalPayment.ToString()
        Pay1.Text = $"Pay {reservation.totalPayment}"
        Pay2.Text = $"Pay {reservation.totalPayment}"
    End Sub

    Sub Successful()
        reservation.paymentMode = "Paid"
        reservation.status = "Approved & Paid"

        Dim jsonFilePath As String = $"{Form1.currentUser.email}.json"
        Dim jsonCustomer As String = JsonConvert.SerializeObject(Form1.currentUser, Formatting.Indented)
        Using writer As New StreamWriter(jsonFilePath, False)
            writer.Write(jsonCustomer)
        End Using

        Admin_Requests.LoadCustomers()
        Account.updateView()
        Reservation_Confirmation.Dispose()

        Me.Hide()
        Processing_Payment.Show()
    End Sub

    Private Sub Pay2_Click(sender As Object, e As EventArgs) Handles Pay2.Click
        If txtCardNum.TextLength = 16 AndAlso txtCVC.TextLength = 3 Then
            Successful()
        Else
            MessageBox.Show("Invalid input. Please enter a 16-digit card number and a 3-digit CVC.")
        End If
    End Sub


    Private Sub Pay1_Click(sender As Object, e As EventArgs) Handles Pay1.Click
        If txtPINnum.TextLength = 4 AndAlso txtPhoneNum.TextLength = 11 Then
            Successful()
        Else
            MessageBox.Show("Invalid input. Please enter a 4-digit PIN number and an 11-digit phone number.")
        End If
    End Sub

End Class
