﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation_Confirmation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation_Confirmation))
        Panel1 = New Panel()
        Label12 = New Label()
        lblVenue = New Label()
        Label16 = New Label()
        lblDate = New Label()
        lblPhoneNum = New Label()
        lblEmail = New Label()
        lblName = New Label()
        lblVideoke = New Label()
        Label26 = New Label()
        Label25 = New Label()
        lblNumOfGuest = New Label()
        lblPlaceId = New Label()
        lblType = New Label()
        lblEvent = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblDancer = New Label()
        lblSinger = New Label()
        lblClown = New Label()
        lblCatering = New Label()
        lblPrice = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnConfirm = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        btnBacktoo = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(lblVenue)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(lblDate)
        Panel1.Controls.Add(lblPhoneNum)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblVideoke)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label25)
        Panel1.Controls.Add(lblNumOfGuest)
        Panel1.Controls.Add(lblPlaceId)
        Panel1.Controls.Add(lblType)
        Panel1.Controls.Add(lblEvent)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(lblDancer)
        Panel1.Controls.Add(lblSinger)
        Panel1.Controls.Add(lblClown)
        Panel1.Controls.Add(lblCatering)
        Panel1.Controls.Add(lblPrice)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(208, -4)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(531, 622)
        Panel1.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.IndianRed
        Label12.Location = New Point(44, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(412, 21)
        Label12.TabIndex = 39
        Label12.Text = "-------------------------------------------------------------------"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        Label12.Visible = False
        ' 
        ' lblVenue
        ' 
        lblVenue.AutoSize = True
        lblVenue.BackColor = Color.Transparent
        lblVenue.Location = New Point(422, 368)
        lblVenue.Margin = New Padding(2, 0, 2, 0)
        lblVenue.Name = "lblVenue"
        lblVenue.Size = New Size(28, 15)
        lblVenue.TabIndex = 38
        lblVenue.Text = "0.00"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Location = New Point(62, 368)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(39, 15)
        Label16.TabIndex = 37
        Label16.Text = "Venue"
        ' 
        ' lblDate
        ' 
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Segoe UI", 11F)
        lblDate.Location = New Point(162, 182)
        lblDate.Margin = New Padding(2, 0, 2, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(251, 18)
        lblDate.TabIndex = 36
        lblDate.Text = "Date:"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.BackColor = Color.Transparent
        lblPhoneNum.Font = New Font("Segoe UI", 11F)
        lblPhoneNum.Location = New Point(160, 162)
        lblPhoneNum.Margin = New Padding(2, 0, 2, 0)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(281, 18)
        lblPhoneNum.TabIndex = 35
        lblPhoneNum.Text = "Phone Number:"
        ' 
        ' lblEmail
        ' 
        lblEmail.BackColor = Color.Transparent
        lblEmail.Font = New Font("Segoe UI", 11F)
        lblEmail.Location = New Point(160, 144)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(244, 18)
        lblEmail.TabIndex = 34
        lblEmail.Text = "Email:"
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Segoe UI", 11F)
        lblName.Location = New Point(160, 126)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(169, 18)
        lblName.TabIndex = 33
        lblName.Text = "Name:"
        ' 
        ' lblVideoke
        ' 
        lblVideoke.AutoSize = True
        lblVideoke.BackColor = Color.Transparent
        lblVideoke.Location = New Point(422, 487)
        lblVideoke.Margin = New Padding(2, 0, 2, 0)
        lblVideoke.Name = "lblVideoke"
        lblVideoke.Size = New Size(28, 15)
        lblVideoke.TabIndex = 32
        lblVideoke.Text = "0.00"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.BackColor = Color.Transparent
        Label26.Location = New Point(60, 487)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(49, 15)
        Label26.TabIndex = 31
        Label26.Text = "Videoke"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.BackColor = Color.Transparent
        Label25.Location = New Point(48, 348)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(52, 15)
        Label25.TabIndex = 30
        Label25.Text = "Services:"
        ' 
        ' lblNumOfGuest
        ' 
        lblNumOfGuest.BackColor = Color.Transparent
        lblNumOfGuest.Location = New Point(160, 308)
        lblNumOfGuest.Margin = New Padding(2, 0, 2, 0)
        lblNumOfGuest.Name = "lblNumOfGuest"
        lblNumOfGuest.Size = New Size(169, 15)
        lblNumOfGuest.TabIndex = 29
        lblNumOfGuest.Text = "250"
        ' 
        ' lblPlaceId
        ' 
        lblPlaceId.BackColor = Color.Transparent
        lblPlaceId.Location = New Point(139, 282)
        lblPlaceId.Margin = New Padding(2, 0, 2, 0)
        lblPlaceId.Name = "lblPlaceId"
        lblPlaceId.Size = New Size(177, 15)
        lblPlaceId.TabIndex = 28
        lblPlaceId.Text = "1234"
        ' 
        ' lblType
        ' 
        lblType.BackColor = Color.Transparent
        lblType.Location = New Point(139, 260)
        lblType.Margin = New Padding(2, 0, 2, 0)
        lblType.Name = "lblType"
        lblType.Size = New Size(177, 15)
        lblType.TabIndex = 27
        lblType.Text = "Garden"
        ' 
        ' lblEvent
        ' 
        lblEvent.BackColor = Color.Transparent
        lblEvent.Location = New Point(139, 235)
        lblEvent.Margin = New Padding(2, 0, 2, 0)
        lblEvent.Name = "lblEvent"
        lblEvent.Size = New Size(177, 15)
        lblEvent.TabIndex = 26
        lblEvent.Text = "Wedding"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(59, 502)
        PictureBox4.Margin = New Padding(2)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(404, 24)
        PictureBox4.TabIndex = 25
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(62, 325)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(404, 24)
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(62, 206)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(404, 24)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' lblDancer
        ' 
        lblDancer.AutoSize = True
        lblDancer.BackColor = Color.Transparent
        lblDancer.Location = New Point(422, 466)
        lblDancer.Margin = New Padding(2, 0, 2, 0)
        lblDancer.Name = "lblDancer"
        lblDancer.Size = New Size(28, 15)
        lblDancer.TabIndex = 23
        lblDancer.Text = "0.00"
        ' 
        ' lblSinger
        ' 
        lblSinger.AutoSize = True
        lblSinger.BackColor = Color.Transparent
        lblSinger.Location = New Point(422, 440)
        lblSinger.Margin = New Padding(2, 0, 2, 0)
        lblSinger.Name = "lblSinger"
        lblSinger.Size = New Size(28, 15)
        lblSinger.TabIndex = 22
        lblSinger.Text = "0.00"
        ' 
        ' lblClown
        ' 
        lblClown.AutoSize = True
        lblClown.BackColor = Color.Transparent
        lblClown.Location = New Point(422, 415)
        lblClown.Margin = New Padding(2, 0, 2, 0)
        lblClown.Name = "lblClown"
        lblClown.Size = New Size(28, 15)
        lblClown.TabIndex = 21
        lblClown.Text = "0.00"
        ' 
        ' lblCatering
        ' 
        lblCatering.AutoSize = True
        lblCatering.BackColor = Color.Transparent
        lblCatering.Location = New Point(422, 392)
        lblCatering.Margin = New Padding(2, 0, 2, 0)
        lblCatering.Name = "lblCatering"
        lblCatering.Size = New Size(28, 15)
        lblCatering.TabIndex = 20
        lblCatering.Text = "0.00"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.Transparent
        lblPrice.Location = New Point(419, 534)
        lblPrice.Margin = New Padding(2, 0, 2, 0)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(28, 15)
        lblPrice.TabIndex = 18
        lblPrice.Text = "0.00"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Location = New Point(363, 534)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(35, 15)
        Label14.TabIndex = 17
        Label14.Text = "Total:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Location = New Point(62, 466)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(44, 15)
        Label13.TabIndex = 16
        Label13.Text = "Dancer"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Location = New Point(62, 440)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 15)
        Label9.TabIndex = 15
        Label9.Text = "Singer"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Location = New Point(62, 415)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(41, 15)
        Label10.TabIndex = 14
        Label10.Text = "Clown"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Location = New Point(62, 392)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(52, 15)
        Label11.TabIndex = 13
        Label11.Text = "Catering"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(43, 308)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 11
        Label5.Text = "Number of Guests:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(43, 282)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 10
        Label6.Text = "Place ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(43, 260)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 15)
        Label7.TabIndex = 9
        Label7.Text = "Type:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Location = New Point(43, 235)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(39, 15)
        Label8.TabIndex = 8
        Label8.Text = "Event:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(46, 182)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 7
        Label4.Text = "Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(43, 164)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 20)
        Label3.TabIndex = 6
        Label3.Text = "Phone Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(43, 144)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(43, 124)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 4
        Label1.Text = "Name:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(62, 2)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(412, 64)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackgroundImage = CType(resources.GetObject("btnConfirm.BackgroundImage"), Image)
        btnConfirm.BackgroundImageLayout = ImageLayout.Stretch
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Location = New Point(34, 504)
        btnConfirm.Margin = New Padding(2)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(138, 33)
        btnConfirm.TabIndex = 2
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' btnBacktoo
        ' 
        btnBacktoo.BackgroundImage = CType(resources.GetObject("btnBacktoo.BackgroundImage"), Image)
        btnBacktoo.BackgroundImageLayout = ImageLayout.Stretch
        btnBacktoo.FlatAppearance.BorderSize = 0
        btnBacktoo.FlatStyle = FlatStyle.Flat
        btnBacktoo.Location = New Point(34, 461)
        btnBacktoo.Margin = New Padding(2)
        btnBacktoo.Name = "btnBacktoo"
        btnBacktoo.Size = New Size(138, 34)
        btnBacktoo.TabIndex = 4
        btnBacktoo.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.ForeColor = SystemColors.ControlLight
        Button1.Location = New Point(775, 500)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 49)
        Button1.TabIndex = 37
        Button1.Text = "Proceed to payment >"
        Button1.UseVisualStyleBackColor = False
        Button1.Visible = False
        ' 
        ' Reservation_Confirmation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(962, 567)
        Controls.Add(Button1)
        Controls.Add(btnBacktoo)
        Controls.Add(btnConfirm)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Reservation_Confirmation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reservation_Confirmation"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblDancer As Label
    Friend WithEvents lblSinger As Label
    Friend WithEvents lblClown As Label
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents lblNumOfGuest As Label
    Friend WithEvents lblPlaceId As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lblVideoke As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnBacktoo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblVenue As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
End Class
