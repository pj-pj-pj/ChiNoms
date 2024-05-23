Imports System.IO
Imports System.Text.RegularExpressions
Imports ChiNoms.Form1
Imports Newtonsoft.Json

Public Class Admin_Requests
    Public Property Customers As List(Of Customer)
    Private ReadOnly directoryPath As String = "C:\Users\peaks\Documents\a\Code\ChiNoms\ChiNoms\bin\Debug\net8.0-windows"
    Dim reservationList As List(Of Reservation) = New List(Of Reservation)

    Public Sub New()
        InitializeComponent()
        Customers = New List(Of Customer)()
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
                    ' NO HAHAHAHAHAHAHAHA
                End Try
            Next
        Else
            MessageBox.Show($"Directory not found: {directoryPath}")
        End If

        UpdateDataGridView()
    End Sub

    Private Sub UpdateDataGridView()
        DataGridView1.Rows.Clear()

        DataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        For Each customer In Customers
            For Each reservation In customer.listOfReservations
                reservationList.Add(reservation)
                Dim services = "No services acquired"
                If reservation.services.Count > 0 Then
                    services = String.Join(Environment.NewLine, reservation.services)
                End If
                Dim formattedStartDate As String = reservation.startDate.ToString("MM-dd-yyyy")
                DataGridView1.Rows.Add(customer.name, reservation.status, reservation.eventType, reservation.venue, formattedStartDate, reservation.days, services, reservation.numGuests, reservation.totalPayment, ">>")
            Next
        Next

        DataGridView1.Refresh()
    End Sub

    Private Sub Admin_Requests_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadCustomers()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            Dim rowIndex As Integer = e.RowIndex

            If rowIndex < reservationList.Count Then
                Dim selectedReservation = reservationList(rowIndex)
                Dim selectedCustomer = Customers.FirstOrDefault(Function(c) c.listOfReservations.Contains(selectedReservation))

                If selectedCustomer IsNot Nothing Then
                    Admin_Check_Reservation.SetReservationAndCustomer(selectedReservation, selectedCustomer)
                    Me.Hide()
                    With Admin_Check_Reservation
                        .btnBacktoo.Visible = True
                        .Label12.Visible = True
                        If selectedReservation.status = "Approved" Then
                            .Label12.Text = "--- This reservation is approved and waiting for payment ---"
                            .approveBtn.Visible = False
                            .cancelBtn.Visible = False
                        ElseIf selectedReservation.status = "Approved & Paid" Then
                            .Label12.Text = "-------- This reservation has been approved and paid -------"
                            .approveBtn.Visible = False
                            .cancelBtn.Visible = False
                        ElseIf selectedReservation.status = "Cancelled" Then
                            .Label12.Text = "------------ This reservation has been cancelled -----------"
                            .approveBtn.Visible = False
                            .cancelBtn.Visible = False
                        Else
                            .Label12.Text = "--- This reservation is pending and waiting confirmation ---"
                            .approveBtn.Visible = True
                            .cancelBtn.Visible = True
                        End If
                        .Show()
                    End With
                Else
                    MessageBox.Show("System Error. No worries, please try again.")
                End If
            End If
        End If
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        Me.Hide()
        Admin_Approved_Reservations.Show()
    End Sub

    Private Sub btnCancelled_Click(sender As Object, e As EventArgs) Handles btnCancelled.Click
        Me.Hide()
        Admin_Cancelled_Reservations.Show()
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
End Class
