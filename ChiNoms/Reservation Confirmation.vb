

Imports System.IO
Imports ChiNoms.Form1
Imports Newtonsoft.Json

Public Class Reservation_Confirmation
    Private cateringPrice As Integer
    Private clownPrice As Integer
    Private singerPrice As Integer
    Private dancerPrice As Integer
    Private videokePrice As Integer

    Private _currentReservation As Reservation
    Public Property CurrentReservation As Reservation
        Get
            Return _currentReservation
        End Get
        Set(value As Reservation)
            _currentReservation = value
            UpdateReservationDetails()
        End Set
    End Property

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Hide()
        Event_Hall.Show()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Hide()
        AddNewReservation()
        Account.Show()
    End Sub

    Public Sub AddNewReservation()
        Dim newReservation As Reservation = Form1.currentReservation

        Dim isDuplicate As Boolean = Form1.currentUser.listOfReservations.Any(Function(r) AreReservationsEqual(r, newReservation))


        If Not isDuplicate Then
            Dim currentReservations = Form1.currentUser.listOfReservations
            currentReservations.Add(newReservation)

            Dim jsonFilePath As String = $"{Form1.currentUser.email}.json"
            Dim jsonCustomer As String = JsonConvert.SerializeObject(Form1.currentUser, Formatting.Indented)
            Using writer As New StreamWriter(jsonFilePath, False)
                writer.Write(jsonCustomer)
            End Using

            MessageBox.Show("Your reservation has been confirmed. Upon approval, you will be able to proceed to billing and payment.", "Reservation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Account.DataGridView1.Rows.Clear()
            For Each reservation In Form1.currentUser.listOfReservations
                Account.DataGridView1.Rows.Add(reservation.eventType, reservation.status, reservation.days, reservation.totalPayment, ">>")
            Next
        End If
    End Sub

    Private Function AreReservationsEqual(res1 As Reservation, res2 As Reservation) As Boolean
        Return res1.eventType = res2.eventType AndAlso
           res1.status = res2.status AndAlso
           res1.days = res2.days AndAlso
           res1.totalPayment = res2.totalPayment
    End Function

    Private Function CalculateServiceCost(pricePer50 As Integer, numGuests As Integer) As Integer
        Return Math.Ceiling(Math.Max(numGuests, 50) / 50) * pricePer50
    End Function

    Private Sub btnBacktoo_Click(sender As Object, e As EventArgs) Handles btnBacktoo.Click
        Me.Hide()
        Event_Hall.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to go back? Your reservation info won't be saved.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Hide
            Account.Show
        End If
    End Sub

    Private Sub Reservation_Confirmation_Shown(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateReservationDetails()
    End Sub

    Public Sub UpdateReservationDetails()
        Dim reservation = Form1.currentReservation

        cateringPrice = CalculateServiceCost(20000, reservation.numGuests)
        clownPrice = CalculateServiceCost(10000, reservation.numGuests)
        singerPrice = CalculateServiceCost(7000, reservation.numGuests)
        dancerPrice = CalculateServiceCost(7000, reservation.numGuests)
        videokePrice = CalculateServiceCost(1000, reservation.numGuests)

        lblCatering.Text = If(reservation.services.Contains("Catering"), cateringPrice, "0")
        lblClown.Text = If(reservation.services.Contains("Clown"), clownPrice, "0")
        lblDancer.Text = If(reservation.services.Contains("Dancer"), dancerPrice, "0")
        lblSinger.Text = If(reservation.services.Contains("Singer"), singerPrice, "0")
        lblVideoke.Text = If(reservation.services.Contains("Videoke"), videokePrice, "0")

        lblEmail.Text = Form1.currentUser.email
        lblName.Text = Form1.currentUser.name
        lblPhoneNum.Text = Form1.currentUser.phoneNumber

        lblEvent.Text = reservation.venue
        lblNumOfGuest.Text = reservation.numGuests
        lblPlaceId.Text = reservation.placeID
        lblType.Text = reservation.eventType
        lblDate.Text = reservation.startDate.ToString("yyyy-MM-dd")

        Dim totalServiceCost As Integer = CInt(lblCatering.Text) + CInt(lblClown.Text) + CInt(lblDancer.Text) + CInt(lblSinger.Text) + CInt(lblVideoke.Text)
        Dim venuePrice As Integer = reservation.totalPayment - totalServiceCost

        Debug.WriteLine(totalServiceCost)
        Debug.WriteLine(venuePrice)

        lblVenue.Text = venuePrice
        lblPrice.Text = reservation.totalPayment

        If reservation.days > 1 Then
            Dim endDate = reservation.startDate.AddDays(reservation.days)
            lblDate.Text = $"{reservation.startDate.ToString("yyyy-MM-dd")} to {endDate.ToString("yyyy-MM-dd")}"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Confirm_Payment.Show()
    End Sub
End Class