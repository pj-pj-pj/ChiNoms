<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Window))
        Panel3 = New Panel()
        viewEventBtn = New Button()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        lblMaxCapacity = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label37 = New Label()
        cbDaysAmount = New ComboBox()
        Label1 = New Label()
        eventDatePicker = New DateTimePicker()
        cbTypeOfEvent = New ComboBox()
        cbEventVenue = New ComboBox()
        Label42 = New Label()
        lblPlace = New Label()
        Label24 = New Label()
        Label43 = New Label()
        Label44 = New Label()
        Label25 = New Label()
        Label45 = New Label()
        Label26 = New Label()
        Label46 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        cbKaraoke = New CheckBox()
        cbDancer = New CheckBox()
        cbSinger = New CheckBox()
        cbCatering = New CheckBox()
        cbClown = New CheckBox()
        noOfGuests = New TextBox()
        lblprice = New Label()
        Label40 = New Label()
        btnBack = New LinkLabel()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        imgVenueBtnAdmin = New Button()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(250), CByte(251), CByte(250))
        Panel3.Controls.Add(viewEventBtn)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(lblMaxCapacity)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label37)
        Panel3.Controls.Add(cbDaysAmount)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(eventDatePicker)
        Panel3.Controls.Add(cbTypeOfEvent)
        Panel3.Controls.Add(cbEventVenue)
        Panel3.Controls.Add(Label42)
        Panel3.Controls.Add(lblPlace)
        Panel3.Controls.Add(Label24)
        Panel3.Controls.Add(Label43)
        Panel3.Controls.Add(Label44)
        Panel3.Controls.Add(Label25)
        Panel3.Controls.Add(Label45)
        Panel3.Controls.Add(Label26)
        Panel3.Controls.Add(Label46)
        Panel3.Controls.Add(Label27)
        Panel3.Controls.Add(Label28)
        Panel3.Controls.Add(Label29)
        Panel3.Controls.Add(Label31)
        Panel3.Controls.Add(Label32)
        Panel3.Controls.Add(Label33)
        Panel3.Controls.Add(Label34)
        Panel3.Controls.Add(Label35)
        Panel3.Controls.Add(cbKaraoke)
        Panel3.Controls.Add(cbDancer)
        Panel3.Controls.Add(cbSinger)
        Panel3.Controls.Add(cbCatering)
        Panel3.Controls.Add(cbClown)
        Panel3.Controls.Add(noOfGuests)
        Panel3.Controls.Add(lblprice)
        Panel3.Controls.Add(Label40)
        Panel3.Location = New Point(-1, 281)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1022, 299)
        Panel3.TabIndex = 39
        ' 
        ' viewEventBtn
        ' 
        viewEventBtn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        viewEventBtn.BackColor = Color.PaleVioletRed
        viewEventBtn.Font = New Font("Sitka Small", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        viewEventBtn.ForeColor = SystemColors.ButtonFace
        viewEventBtn.Location = New Point(713, 219)
        viewEventBtn.Name = "viewEventBtn"
        viewEventBtn.Size = New Size(251, 59)
        viewEventBtn.TabIndex = 74
        viewEventBtn.Text = "Add Event Venue"
        viewEventBtn.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(810, 166)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(22, 23)
        Label8.TabIndex = 73
        Label8.Text = "₱"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(810, 140)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(22, 23)
        Label7.TabIndex = 72
        Label7.Text = "₱"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(810, 117)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 23)
        Label6.TabIndex = 71
        Label6.Text = "₱"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(810, 69)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(22, 23)
        Label5.TabIndex = 70
        Label5.Text = "₱"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(810, 92)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 23)
        Label4.TabIndex = 69
        Label4.Text = "₱"
        ' 
        ' lblMaxCapacity
        ' 
        lblMaxCapacity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblMaxCapacity.AutoSize = True
        lblMaxCapacity.Font = New Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMaxCapacity.ForeColor = Color.RosyBrown
        lblMaxCapacity.Location = New Point(359, 41)
        lblMaxCapacity.Margin = New Padding(2, 0, 2, 0)
        lblMaxCapacity.Name = "lblMaxCapacity"
        lblMaxCapacity.Size = New Size(30, 35)
        lblMaxCapacity.TabIndex = 68
        lblMaxCapacity.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Sitka Small", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.RosyBrown
        Label3.Location = New Point(359, 15)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 30)
        Label3.TabIndex = 67
        Label3.Text = "Maximum Capacity:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Text", 15.7499981F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(139, 213)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 30)
        Label2.TabIndex = 66
        Label2.Text = "₱"
        ' 
        ' Label37
        ' 
        Label37.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label37.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label37.ForeColor = SystemColors.ControlDarkDark
        Label37.Location = New Point(38, 191)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.Size = New Size(458, 20)
        Label37.TabIndex = 65
        Label37.Text = "*note: Additional ₱100 will be charged per head for succeeding guest/s"
        ' 
        ' cbDaysAmount
        ' 
        cbDaysAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbDaysAmount.FormattingEnabled = True
        cbDaysAmount.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cbDaysAmount.Location = New Point(359, 250)
        cbDaysAmount.Name = "cbDaysAmount"
        cbDaysAmount.Size = New Size(59, 23)
        cbDaysAmount.TabIndex = 64
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label1.Location = New Point(300, 250)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 23)
        Label1.TabIndex = 63
        Label1.Text = "Days:"
        ' 
        ' eventDatePicker
        ' 
        eventDatePicker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        eventDatePicker.DropDownAlign = LeftRightAlignment.Right
        eventDatePicker.Format = DateTimePickerFormat.Short
        eventDatePicker.Location = New Point(139, 251)
        eventDatePicker.Name = "eventDatePicker"
        eventDatePicker.Size = New Size(132, 23)
        eventDatePicker.TabIndex = 62
        ' 
        ' cbTypeOfEvent
        ' 
        cbTypeOfEvent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbTypeOfEvent.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbTypeOfEvent.FormattingEnabled = True
        cbTypeOfEvent.Items.AddRange(New Object() {"Wedding and Reception", "Birthday Party", "Social Celebrations", "Corporate Meeting and Events"})
        cbTypeOfEvent.Location = New Point(169, 96)
        cbTypeOfEvent.Name = "cbTypeOfEvent"
        cbTypeOfEvent.Size = New Size(185, 31)
        cbTypeOfEvent.TabIndex = 61
        ' 
        ' cbEventVenue
        ' 
        cbEventVenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbEventVenue.Font = New Font("Sitka Banner", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbEventVenue.FormattingEnabled = True
        cbEventVenue.Location = New Point(38, 41)
        cbEventVenue.Name = "cbEventVenue"
        cbEventVenue.Size = New Size(316, 50)
        cbEventVenue.TabIndex = 60
        ' 
        ' Label42
        ' 
        Label42.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label42.AutoSize = True
        Label42.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label42.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label42.Location = New Point(35, 250)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(99, 23)
        Label42.TabIndex = 10
        Label42.Text = "Start Date:"
        ' 
        ' lblPlace
        ' 
        lblPlace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPlace.Font = New Font("Sitka Small", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlace.Location = New Point(38, 11)
        lblPlace.Margin = New Padding(2, 0, 2, 0)
        lblPlace.Name = "lblPlace"
        lblPlace.Size = New Size(202, 30)
        lblPlace.TabIndex = 59
        lblPlace.Text = "Pick Venue:"
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Font = New Font("Sitka Text", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label24.Location = New Point(713, 21)
        Label24.Margin = New Padding(2, 0, 2, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(227, 28)
        Label24.TabIndex = 47
        Label24.Text = "Pick Included Services:"
        ' 
        ' Label43
        ' 
        Label43.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label43.AutoSize = True
        Label43.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label43.ForeColor = Color.Black
        Label43.Location = New Point(36, 219)
        Label43.Margin = New Padding(2, 0, 2, 0)
        Label43.Name = "Label43"
        Label43.Size = New Size(103, 23)
        Label43.TabIndex = 9
        Label43.Text = "Total Price:"
        ' 
        ' Label44
        ' 
        Label44.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label44.AutoSize = True
        Label44.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label44.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label44.Location = New Point(38, 160)
        Label44.Margin = New Padding(2, 0, 2, 0)
        Label44.Name = "Label44"
        Label44.Size = New Size(159, 23)
        Label44.TabIndex = 8
        Label44.Text = "Number of Guests:"
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(836, 161)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(47, 23)
        Label25.TabIndex = 46
        Label25.Text = "1000"
        ' 
        ' Label45
        ' 
        Label45.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label45.AutoSize = True
        Label45.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label45.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label45.Location = New Point(38, 134)
        Label45.Margin = New Padding(2, 0, 2, 0)
        Label45.Name = "Label45"
        Label45.Size = New Size(82, 23)
        Label45.TabIndex = 7
        Label45.Text = "Place ID:"
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label26.AutoSize = True
        Label26.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(836, 139)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(49, 23)
        Label26.TabIndex = 45
        Label26.Text = "7000"
        ' 
        ' Label46
        ' 
        Label46.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label46.AutoSize = True
        Label46.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label46.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label46.Location = New Point(38, 98)
        Label46.Margin = New Padding(2, 0, 2, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(126, 23)
        Label46.TabIndex = 6
        Label46.Text = "Type of Event:"
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label27.AutoSize = True
        Label27.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label27.ForeColor = Color.Black
        Label27.Location = New Point(836, 112)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(49, 23)
        Label27.TabIndex = 44
        Label27.Text = "7000"
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label28.AutoSize = True
        Label28.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label28.ForeColor = Color.Black
        Label28.Location = New Point(836, 89)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(62, 23)
        Label28.TabIndex = 43
        Label28.Text = "10,000"
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label29.AutoSize = True
        Label29.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label29.ForeColor = Color.Black
        Label29.Location = New Point(836, 63)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(64, 23)
        Label29.TabIndex = 42
        Label29.Text = "20,000"
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label31.AutoSize = True
        Label31.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label31.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label31.Location = New Point(713, 161)
        Label31.Margin = New Padding(2, 0, 2, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(76, 23)
        Label31.TabIndex = 40
        Label31.Text = "Karaoke"
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label32.AutoSize = True
        Label32.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label32.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label32.Location = New Point(713, 139)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(66, 23)
        Label32.TabIndex = 39
        Label32.Text = "Dancer"
        ' 
        ' Label33
        ' 
        Label33.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label33.AutoSize = True
        Label33.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label33.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label33.Location = New Point(713, 112)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.Size = New Size(62, 23)
        Label33.TabIndex = 38
        Label33.Text = "Singer"
        ' 
        ' Label34
        ' 
        Label34.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label34.AutoSize = True
        Label34.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label34.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label34.Location = New Point(713, 89)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(59, 23)
        Label34.TabIndex = 37
        Label34.Text = "Clown"
        ' 
        ' Label35
        ' 
        Label35.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label35.AutoSize = True
        Label35.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label35.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label35.Location = New Point(713, 63)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(78, 23)
        Label35.TabIndex = 36
        Label35.Text = "Catering"
        ' 
        ' cbKaraoke
        ' 
        cbKaraoke.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbKaraoke.Location = New Point(931, 160)
        cbKaraoke.Margin = New Padding(2)
        cbKaraoke.Name = "cbKaraoke"
        cbKaraoke.RightToLeft = RightToLeft.Yes
        cbKaraoke.Size = New Size(33, 30)
        cbKaraoke.TabIndex = 32
        cbKaraoke.TextAlign = ContentAlignment.MiddleCenter
        cbKaraoke.TextImageRelation = TextImageRelation.TextBeforeImage
        cbKaraoke.UseVisualStyleBackColor = True
        ' 
        ' cbDancer
        ' 
        cbDancer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbDancer.Location = New Point(931, 138)
        cbDancer.Margin = New Padding(2)
        cbDancer.Name = "cbDancer"
        cbDancer.RightToLeft = RightToLeft.Yes
        cbDancer.Size = New Size(33, 30)
        cbDancer.TabIndex = 31
        cbDancer.TextAlign = ContentAlignment.MiddleCenter
        cbDancer.TextImageRelation = TextImageRelation.TextBeforeImage
        cbDancer.UseVisualStyleBackColor = True
        ' 
        ' cbSinger
        ' 
        cbSinger.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbSinger.Location = New Point(931, 111)
        cbSinger.Margin = New Padding(2)
        cbSinger.Name = "cbSinger"
        cbSinger.RightToLeft = RightToLeft.Yes
        cbSinger.Size = New Size(33, 30)
        cbSinger.TabIndex = 30
        cbSinger.TextAlign = ContentAlignment.MiddleCenter
        cbSinger.TextImageRelation = TextImageRelation.TextBeforeImage
        cbSinger.UseVisualStyleBackColor = True
        ' 
        ' cbCatering
        ' 
        cbCatering.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbCatering.Location = New Point(931, 63)
        cbCatering.Margin = New Padding(2)
        cbCatering.Name = "cbCatering"
        cbCatering.RightToLeft = RightToLeft.Yes
        cbCatering.Size = New Size(33, 30)
        cbCatering.TabIndex = 29
        cbCatering.TextAlign = ContentAlignment.MiddleCenter
        cbCatering.TextImageRelation = TextImageRelation.TextBeforeImage
        cbCatering.UseVisualStyleBackColor = True
        ' 
        ' cbClown
        ' 
        cbClown.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbClown.Location = New Point(931, 86)
        cbClown.Margin = New Padding(2)
        cbClown.Name = "cbClown"
        cbClown.RightToLeft = RightToLeft.Yes
        cbClown.Size = New Size(33, 30)
        cbClown.TabIndex = 28
        cbClown.TextAlign = ContentAlignment.MiddleCenter
        cbClown.TextImageRelation = TextImageRelation.TextBeforeImage
        cbClown.UseVisualStyleBackColor = True
        ' 
        ' noOfGuests
        ' 
        noOfGuests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        noOfGuests.BackColor = SystemColors.ControlLightLight
        noOfGuests.BorderStyle = BorderStyle.FixedSingle
        noOfGuests.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        noOfGuests.Location = New Point(202, 156)
        noOfGuests.Margin = New Padding(2)
        noOfGuests.Name = "noOfGuests"
        noOfGuests.Size = New Size(69, 33)
        noOfGuests.TabIndex = 25
        noOfGuests.Text = "10"
        ' 
        ' lblprice
        ' 
        lblprice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblprice.AutoSize = True
        lblprice.Font = New Font("Sitka Text", 15.7499981F, FontStyle.Bold)
        lblprice.ForeColor = Color.Black
        lblprice.Location = New Point(169, 213)
        lblprice.Margin = New Padding(2, 0, 2, 0)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(27, 30)
        lblprice.TabIndex = 9
        lblprice.Text = "0"
        ' 
        ' Label40
        ' 
        Label40.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label40.AutoSize = True
        Label40.Font = New Font("Sitka Text", 12F, FontStyle.Bold)
        Label40.ForeColor = Color.FromArgb(CByte(209), CByte(158), CByte(184))
        Label40.Location = New Point(124, 134)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(74, 23)
        Label40.TabIndex = 7
        Label40.Text = "Label40"
        ' 
        ' btnBack
        ' 
        btnBack.ActiveLinkColor = Color.RosyBrown
        btnBack.AutoSize = True
        btnBack.BackColor = Color.FromArgb(CByte(246), CByte(204), CByte(217))
        btnBack.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.Transparent
        btnBack.LinkColor = Color.Black
        btnBack.Location = New Point(11, 10)
        btnBack.Margin = New Padding(2, 0, 2, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(84, 32)
        btnBack.TabIndex = 40
        btnBack.TabStop = True
        btnBack.Text = "<Back"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-4, -28)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1023, 608)
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(246), CByte(204), CByte(217))
        Label9.Font = New Font("Sitka Small", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(320, 5)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(432, 41)
        Label9.TabIndex = 74
        Label9.Text = "Event Reservation Preview:"
        ' 
        ' imgVenueBtnAdmin
        ' 
        imgVenueBtnAdmin.BackColor = Color.Transparent
        imgVenueBtnAdmin.Image = CType(resources.GetObject("imgVenueBtnAdmin.Image"), Image)
        imgVenueBtnAdmin.Location = New Point(-4, 45)
        imgVenueBtnAdmin.Name = "imgVenueBtnAdmin"
        imgVenueBtnAdmin.Size = New Size(1022, 244)
        imgVenueBtnAdmin.TabIndex = 75
        imgVenueBtnAdmin.TextImageRelation = TextImageRelation.TextBeforeImage
        imgVenueBtnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Admin_Window
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 581)
        Controls.Add(imgVenueBtnAdmin)
        Controls.Add(Label9)
        Controls.Add(Panel3)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Admin_Window"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_Window"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMaxCapacity As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents cbDaysAmount As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents eventDatePicker As DateTimePicker
    Friend WithEvents cbTypeOfEvent As ComboBox
    Friend WithEvents cbEventVenue As ComboBox
    Friend WithEvents Label42 As Label
    Friend WithEvents lblPlace As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents cbKaraoke As CheckBox
    Friend WithEvents cbDancer As CheckBox
    Friend WithEvents cbSinger As CheckBox
    Friend WithEvents cbCatering As CheckBox
    Friend WithEvents cbClown As CheckBox
    Friend WithEvents noOfGuests As TextBox
    Friend WithEvents lblprice As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Public WithEvents viewEventBtn As Button
    Friend WithEvents imgVenueBtnAdmin As Button
End Class
