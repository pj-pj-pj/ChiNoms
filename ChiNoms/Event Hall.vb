Imports ChiNoms.Form1
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class Event_Hall
    Private jsonData As String
    Private eventVenues As JArray
    Public selectedVenue As JObject

    Private dbPrice As Double
    Private intAddCost As Integer
    Private servicePrice As Integer

    Private cateringPrice As Integer
    Private clownPrice As Integer
    Private singerPrice As Integer
    Private dancerPrice As Integer
    Private videokePrice As Integer

    Public newReservation As Reservation
    Public pricePerDay

    Dim availedServices As New List(Of String)()

    Private Sub Event_Hall_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEventVenues()
        UpdateServicePrices()
        UpdatePriceLabels()
        cbDaysAmount.SelectedIndex = 0
        cbEventVenue.SelectedIndex = 0
        cbTypeOfEvent.SelectedIndex = 0
        cbCatering.Checked = False
        cbClown.Checked = False
        cbSinger.Checked = False
        cbDancer.Checked = False
        cbKaraoke.Checked = False
    End Sub

    Private Sub LoadEventVenues()
        Dim jsonFilePath As String = "eventVenues.json"
        Dim jsonData As String

        Using reader As New StreamReader(jsonFilePath)
            jsonData = reader.ReadToEnd()
        End Using

        eventVenues = JArray.Parse(jsonData)

        For Each venue As JObject In eventVenues
            Dim venueName As String = venue("nameOfVenue").ToString()
            ' Check if the item already exists in the ComboBox before adding
            If Not cbEventVenue.Items.Contains(venueName) Then
                cbEventVenue.Items.Add(venueName)
            End If
        Next
    End Sub

    Private Sub UpdateServicePrices()
        Dim numGuests As Integer = If(String.IsNullOrEmpty(noOfGuests.Text), 0, CInt(noOfGuests.Text))
        cateringPrice = CalculateServiceCost(20000, numGuests)
        clownPrice = CalculateServiceCost(10000, numGuests)
        singerPrice = CalculateServiceCost(7000, numGuests)
        dancerPrice = CalculateServiceCost(7000, numGuests)
        videokePrice = CalculateServiceCost(1000, numGuests)
    End Sub

    Private Function CalculateServiceCost(pricePer50 As Integer, numGuests As Integer) As Integer
        Return Math.Ceiling(Math.Max(numGuests, 50) / 50) * pricePer50
    End Function

    Private Sub UpdatePriceLabels()
        Label25.Text = videokePrice.ToString()
        Label26.Text = dancerPrice.ToString()
        Label27.Text = singerPrice.ToString()
        Label28.Text = clownPrice.ToString()
        Label29.Text = cateringPrice.ToString()
    End Sub

    Private Function ComputeBasePrice() As Integer
        Return 10000 * CInt(cbDaysAmount.Text)
    End Function

    Private Sub cbDaysAmount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDaysAmount.SelectedIndexChanged
        UpdateTotalPrice()
    End Sub

    Private Sub btnReviewReservation_Click(sender As Object, e As EventArgs) Handles btnReviewReservation.Click
        Dim days As Integer
        Dim numGuests As Integer
        Dim totalPayment As Decimal

        If Integer.TryParse(cbDaysAmount.Text, days) AndAlso Integer.TryParse(noOfGuests.Text, numGuests) AndAlso Decimal.TryParse(lblprice.Text, totalPayment) Then
            newReservation = New Reservation(cbTypeOfEvent.Text, cbEventVenue.Text, Label40.Text, eventDatePicker.Value, days, numGuests, totalPayment, availedServices)
            Form1.currentReservation = newReservation

            Me.Hide()
            Reservation_Confirmation.btnBacktoo.Visible = True
            Reservation_Confirmation.Label12.Visible = False
            Reservation_Confirmation.Button1.Visible = False

            Reservation_Confirmation.lblPrice.Text = lblprice.Text
            Reservation_Confirmation.UpdateReservationDetails()
            Reservation_Confirmation.Show()
        End If
    End Sub

    Private Sub ToggleService(serviceName As String, isChecked As Boolean, price As Integer)
        If isChecked Then
            servicePrice += price
            availedServices.Add(serviceName)
        Else
            servicePrice -= price
            availedServices.Remove(serviceName)
        End If

        UpdateTotalPrice()

        Dim label As Label = CType(Reservation_Confirmation.Controls.Find("lbl" & serviceName, True).FirstOrDefault(), Label)
        If label IsNot Nothing Then
            label.Text = If(isChecked, price.ToString(), "0")
        End If
    End Sub

    Private Sub cbCatering_CheckedChanged(sender As Object, e As EventArgs) Handles cbCatering.CheckedChanged
        ToggleService("Catering", cbCatering.Checked, cateringPrice)
    End Sub

    Private Sub cbClown_CheckedChanged(sender As Object, e As EventArgs) Handles cbClown.CheckedChanged
        ToggleService("Clown", cbClown.Checked, clownPrice)
    End Sub

    Private Sub cbSinger_CheckedChanged(sender As Object, e As EventArgs) Handles cbSinger.CheckedChanged
        ToggleService("Singer", cbSinger.Checked, singerPrice)
    End Sub

    Private Sub cbDancer_CheckedChanged(sender As Object, e As EventArgs) Handles cbDancer.CheckedChanged
        ToggleService("Dancer", cbDancer.Checked, dancerPrice)
    End Sub

    Private Sub cbKaraoke_CheckedChanged(sender As Object, e As EventArgs) Handles cbKaraoke.CheckedChanged
        ToggleService("Videoke", cbKaraoke.Checked, videokePrice)
    End Sub

    Private Sub noOfGuests_TextChanged(sender As Object, e As EventArgs) Handles noOfGuests.TextChanged
        If selectedVenue IsNot Nothing AndAlso Not String.IsNullOrEmpty(noOfGuests.Text) Then
            cbCatering.Checked = False
            cbClown.Checked = False
            cbSinger.Checked = False
            cbDancer.Checked = False
            cbKaraoke.Checked = False

            UpdateTotalPrice()
            UpdateServicePrices()
            UpdatePriceLabels()

            Dim guests = CInt(noOfGuests.Text)
            Dim maxCapacity = CInt(selectedVenue("maxCapacity"))

            If guests > maxCapacity Then
                intAddCost = (guests - maxCapacity) * 100
            Else
                intAddCost = 0
            End If

            UpdateTotalPrice()
        End If
    End Sub

    Private Sub UpdateTotalPrice()
        Dim basePrice As Integer = ComputeBasePrice()
        Dim totalPrice As Integer = basePrice + intAddCost + servicePrice
        lblprice.Text = totalPrice.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEventVenue.SelectedIndexChanged
        selectedVenue = CType(eventVenues(cbEventVenue.SelectedIndex), JObject)
        If selectedVenue IsNot Nothing Then
            Label40.Text = selectedVenue("PlaceID").ToString()
            lblMaxCapacity.Text = selectedVenue("maxCapacity").ToString()
            Dim imgPath As String = selectedVenue("img").ToString()
            If Not String.IsNullOrEmpty(imgPath) AndAlso File.Exists(imgPath) Then
                imgVenueBtn.Image = Image.FromFile(imgPath)
            Else
                imgVenueBtn.Image = Image.FromFile("a.jpg")
            End If
        End If

        UpdateTotalPrice()
        UpdateServicePrices()
        UpdatePriceLabels()

        Dim guests = CInt(noOfGuests.Text)
        Dim maxCapacity = CInt(selectedVenue("maxCapacity"))

        If guests > maxCapacity Then
            intAddCost = (guests - maxCapacity) * 100
        Else
            intAddCost = 0
        End If

        UpdateTotalPrice()
    End Sub

    Private Sub btnBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnBack.LinkClicked
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back? Your reservation info won't be saved.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            LoadEventVenues()
            UpdateServicePrices()
            UpdatePriceLabels()
            cbDaysAmount.SelectedIndex = 0
            cbEventVenue.SelectedIndex = 0
            cbTypeOfEvent.SelectedIndex = 0
            cbCatering.Checked = False
            cbClown.Checked = False
            cbSinger.Checked = False
            cbDancer.Checked = False
            cbKaraoke.Checked = False

            Reservation_Confirmation.Dispose()

            Me.Hide()
            Account.Show()
        End If
    End Sub
End Class
