Public Class Processing_Payment




    Private Sub Processing_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Maximum = 0
        ProgressBar1.Maximum = 100
        Reservation_Confirmation.AddNewReservation()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 20
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Close()
            Successful_Transaction.Show()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class