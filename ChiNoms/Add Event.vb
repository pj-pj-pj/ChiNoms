Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class Add_Event
    Private selectedImagePath As String

    Private Sub btnAddVenue_Click(sender As Object, e As EventArgs) Handles btnAddVenue.Click
        ' Check if all required fields are filled
        If String.IsNullOrEmpty(txtNewEvent.Text) OrElse
           String.IsNullOrEmpty(txtPlaceID.Text) OrElse
           String.IsNullOrEmpty(txtCapacity.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if an image is selected
        If String.IsNullOrEmpty(selectedImagePath) Then
            MessageBox.Show("Please select an image for the venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check for duplicate venue name
        Dim jsonFilePath = "eventVenues.json"
        Dim jsonData As String
        Dim eventVenues As JArray

        ' Read existing data from JSON file
        If File.Exists(jsonFilePath) Then
            jsonData = File.ReadAllText(jsonFilePath)
            eventVenues = JArray.Parse(jsonData)
        Else
            eventVenues = New JArray()
        End If

        ' Check for duplicate venue name
        Dim existingVenue = eventVenues.FirstOrDefault(Function(v As JObject) v("nameOfVenue").ToString().Equals(txtNewEvent.Text, StringComparison.OrdinalIgnoreCase))
        If existingVenue IsNot Nothing Then
            MessageBox.Show("A venue with the same name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Add new venue to the JSON array
        Dim newVenue As New JObject()
        newVenue.Add("nameOfVenue", txtNewEvent.Text)
        newVenue.Add("PlaceID", txtPlaceID.Text)
        newVenue.Add("maxCapacity", CInt(txtCapacity.Text))
        newVenue.Add("img", If(String.IsNullOrEmpty(selectedImagePath), String.Empty, selectedImagePath))

        eventVenues.Add(newVenue)

        ' Write updated data back to the JSON file
        File.WriteAllText(jsonFilePath, eventVenues.ToString())

        MessageBox.Show("Venue added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Admin_Window.LoadEventVenues()
        Me.Hide()
        Admin_Window.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Admin_Window.Show()
    End Sub

    Private Sub addImgBtn_Click(sender As Object, e As EventArgs) Handles addImgBtn.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Select an Image"
        openFileDialog1.Filter = "Image Files (.bmp;.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Button1.Image = Image.FromFile(openFileDialog1.FileName)
                selectedImagePath = openFileDialog1.FileName ' Store the selected image path
            Catch ex As Exception
                MessageBox.Show("Error loading the image: " & ex.Message)
            End Try
        End If
    End Sub
End Class
