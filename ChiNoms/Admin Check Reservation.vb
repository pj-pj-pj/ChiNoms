Imports ChiNoms.Form1
Imports Newtonsoft.Json
Imports System.IO

Public Class Admin_Check_Reservation
    Dim customer As Customer
    Dim reservation As Reservation

    Private cateringPrice As Integer
    Private clownPrice As Integer
    Private singerPrice As Integer
    Private dancerPrice As Integer
    Private videokePrice As Integer

    Private Function CalculateServiceCost(pricePer50 As Integer, numGuests As Integer) As Integer
        Return Math.Ceiling(Math.Max(numGuests, 50) / 50) * pricePer50
    End Function

    Private Sub btnBacktoo_Click(sender As Object, e As EventArgs) Handles btnBacktoo.Click
        Me.Hide()
        Admin_Requests.Show()
    End Sub

    Public Sub UpdateReservationDetails(selectedReservation As Reservation, selectedCustomer As Customer)
        If selectedReservation IsNot Nothing AndAlso selectedCustomer IsNot Nothing Then
            cateringPrice = CalculateServiceCost(20000, selectedReservation.numGuests)
            clownPrice = CalculateServiceCost(10000, selectedReservation.numGuests)
            singerPrice = CalculateServiceCost(7000, selectedReservation.numGuests)
            dancerPrice = CalculateServiceCost(7000, selectedReservation.numGuests)
            videokePrice = CalculateServiceCost(1000, selectedReservation.numGuests)

            lblCatering.Text = If(selectedReservation.services.Contains("Catering"), cateringPrice, "0")
            lblClown.Text = If(selectedReservation.services.Contains("Clown"), clownPrice, "0")
            lblDancer.Text = If(selectedReservation.services.Contains("Dancer"), dancerPrice, "0")
            lblSinger.Text = If(selectedReservation.services.Contains("Singer"), singerPrice, "0")
            lblVideoke.Text = If(selectedReservation.services.Contains("Videoke"), videokePrice, "0")

            lblEmail.Text = selectedCustomer.email
            lblName.Text = selectedCustomer.name
            lblPhoneNum.Text = selectedCustomer.phoneNumber

            lblEvent.Text = selectedReservation.venue
            lblNumOfGuest.Text = selectedReservation.numGuests
            lblPlaceId.Text = selectedReservation.placeID
            lblType.Text = selectedReservation.eventType
            lblDate.Text = selectedReservation.startDate.ToString("MM-dd-yyyy")

            Dim totalServiceCost As Integer = CInt(lblCatering.Text) + CInt(lblClown.Text) + CInt(lblDancer.Text) + CInt(lblSinger.Text) + CInt(lblVideoke.Text)
            Dim venuePrice As Integer = selectedReservation.totalPayment - totalServiceCost

            Debug.WriteLine(totalServiceCost)
            Debug.WriteLine(venuePrice)

            lblVenue.Text = venuePrice
            lblPrice.Text = selectedReservation.totalPayment

            If selectedReservation.days > 1 Then
                Dim endDate = selectedReservation.startDate.AddDays(selectedReservation.days)
                lblDate.Text = $"{selectedReservation.startDate.ToString("MM-dd-yyyy")} to {endDate.ToString("MM-dd-yyyy")}"
            End If
        End If
    End Sub

    Dim matchingReservation

    Public Sub SetReservationAndCustomer(selectedReservation As Reservation, selectedCustomer As Customer)
        reservation = selectedReservation
        customer = selectedCustomer

        ' Find the matching reservation in the customer's list of reservations
        matchingReservation = customer.listOfReservations.FirstOrDefault(Function(r) _
    r.eventType = selectedReservation.eventType AndAlso
    r.venue = selectedReservation.venue AndAlso
    r.startDate = selectedReservation.startDate AndAlso
    r.numGuests = selectedReservation.numGuests AndAlso
    r.totalPayment = selectedReservation.totalPayment AndAlso
    r.days = selectedReservation.days AndAlso
    r.pricePerDay = selectedReservation.pricePerDay AndAlso
    r.paymentMode = selectedReservation.paymentMode AndAlso
    r.status = selectedReservation.status)


        UpdateReservationDetails(matchingReservation, customer)
    End Sub

    Private Sub approveBtn_Click(sender As Object, e As EventArgs) Handles approveBtn.Click
        matchingReservation.status = "Approved"

        Dim jsonFilePath As String = $"{customer.email}.json"
        Dim jsonCustomer As String = JsonConvert.SerializeObject(customer, Formatting.Indented)
        Using writer As New StreamWriter(jsonFilePath, False)
            writer.Write(jsonCustomer)
        End Using

        Admin_Requests.LoadCustomers()

        Me.Hide()
        Admin_Requests.Show()
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        matchingReservation.status = "Cancelled"

        Dim jsonFilePath As String = $"{customer.email}.json"
        Dim jsonCustomer As String = JsonConvert.SerializeObject(customer, Formatting.Indented)
        Using writer As New StreamWriter(jsonFilePath, False)
            writer.Write(jsonCustomer)
        End Using

        Admin_Requests.LoadCustomers()

        Me.Hide()
        Admin_Requests.Show()
    End Sub
End Class
