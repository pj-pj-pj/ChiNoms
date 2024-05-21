Public Class Form1
    Public currentUser As Customer
    Public currentReservation As Reservation
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Me.Hide()
        Login_Your_Account.Show()
    End Sub

    Public Class Customer
        Public Property password As String
        Public Property email As String

        Public Property name As String
        Public Property address As String
        Public Property phoneNumber As String
        Public Property age As Integer
        Public Property birthday As Date
        Public Property sex As String
        Public Property listOfReservations As List(Of Reservation)

        Public Sub New(name As String, address As String, phoneNumber As String,
                 birthday As Date, sex As String, age As Integer)
            Dim servicesList As New List(Of String)
            servicesList.Add("Catering")
            servicesList.Add("Decoration")

            Me.name = name
            Me.address = address
            Me.phoneNumber = phoneNumber
            Me.birthday = birthday
            Me.sex = sex
            Me.age = age
            Me.listOfReservations = New List(Of Reservation)
        End Sub
    End Class

    Public Class Reservation
        Public Property eventType As String
        Public Property venue As String
        Public Property placeID As String
        Public Property startDate As Date
        Public Property days As Integer
        Public Property numGuests As Integer
        Public Property totalPayment As Decimal
        Public Property pricePerDay As Integer
        Public Property services As List(Of String)
        Public Property paymentMode As String
        Public Property status As String

        Public Sub New(eventType As String, venue As String, placeID As String, startDate As Date, days As Integer, numGuests As Integer, totalPayment As Decimal, services As List(Of String))
            Me.eventType = eventType
            Me.venue = venue
            Me.placeID = placeID
            Me.startDate = startDate
            Me.days = days
            Me.numGuests = numGuests
            Me.totalPayment = totalPayment
            Me.services = services
            Me.pricePerDay = days * 10000
            Me.status = "Pending"
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
