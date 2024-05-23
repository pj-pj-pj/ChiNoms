Imports System.IO
Imports System.Text.RegularExpressions
Imports ChiNoms.Form1
Imports Newtonsoft.Json

Public Class Admin_Cancelled_Reservations
    Public Property Customers As List(Of Customer)
    Private ReadOnly directoryPath As String = "C:\Users\peaks\Documents\a\Code\ChiNoms\ChiNoms\bin\Debug\net8.0-windows"
    Dim reservationList As List(Of Reservation) = New List(Of Reservation)

    Public Sub New()
        InitializeComponent()
        Customers = New List(Of Customer)()
        AddHandler Me.Activated, AddressOf Admin_Cancelled_Reservations_Activated
    End Sub

    Private Sub Admin_Cancelled_Reservations_Activated(sender As Object, e As EventArgs)
        LoadCustomers()
        UpdateDataGridView()
    End Sub

    Public Sub LoadCustomers()
        Customers.Clear()
        reservationList.Clear()
        DataGridView1.Rows.Clear()

        If Directory.Exists(directoryPath) Then
            Dim allFiles = Directory.GetFiles(directoryPath)
            Dim jsonFiles = allFiles.Where(Function(f) Regex.IsMatch(Path.GetFileName(f), ".*\.json$", RegexOptions.IgnoreCase)).ToArray()


            For Each jsonFile In jsonFiles
                Try
                    Dim jsonData = File.ReadAllText(jsonFile)
                    Dim customer = JsonConvert.DeserializeObject(Of Customer)(jsonData)
                    If customer IsNot Nothing Then
                        Customers.Add(customer)
                    Else
                        MessageBox.Show($"Failed to deserialize file: {jsonFile}. PLEASE RESTART.")
                    End If
                Catch ex As Exception
                    'HAHAHAHA
                End Try
            Next
        Else
            MessageBox.Show($"Directory not found: {directoryPath}")
        End If
    End Sub

    Private Sub UpdateDataGridView()
        DataGridView1.Rows.Clear()

        DataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        For Each customer In Customers
            For Each reservation In customer.listOfReservations
                If reservation.status = "Cancelled" Then
                    reservationList.Add(reservation)
                    Dim services = "No services acquired"
                    If reservation.services.Count > 0 Then
                        services = String.Join(Environment.NewLine, reservation.services)
                    End If
                    Dim formattedStartDate As String = reservation.startDate.ToString("MM-dd-yyyy")
                    DataGridView1.Rows.Add(customer.name, reservation.status, reservation.eventType, reservation.venue, formattedStartDate, reservation.days, services, reservation.numGuests, reservation.totalPayment, ">>")
                End If
            Next
        Next

        DataGridView1.Refresh()
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        Me.Hide()
        Admin_Approved_Reservations.Show()
    End Sub

    Private Sub btnRequests_Click_1(sender As Object, e As EventArgs) Handles btnRequests.Click
        Me.Hide()
        Admin_Requests.Show()
    End Sub

    Private Sub viewEventBtn_Click(sender As Object, e As EventArgs) Handles viewEventBtn.Click
        Me.Hide()
        Admin_Window.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Application.Exit()
        Application.Restart()
    End Sub

    Private Sub btnPending_Click(sender As Object, e As EventArgs) Handles btnPending.Click
        Me.Hide()
        Pending_Reservations.Show()
    End Sub

    Private Sub Admin_Cancelled_Reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
