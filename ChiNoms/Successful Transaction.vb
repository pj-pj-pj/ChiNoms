Imports ChiNoms.Form1
Imports Newtonsoft.Json
Imports System.IO

Public Class Successful_Transaction
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Close()
        Account.Show()
    End Sub

    Private Sub Successful_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 1500
    End Sub

End Class