<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirm_Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirm_Payment))
        Panel1 = New Panel()
        btnBack = New LinkLabel()
        lblVideoke = New Label()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        lblDancer = New Label()
        lblSinger = New Label()
        lblClown = New Label()
        lblCatering = New Label()
        lblVenue = New Label()
        lblTotalPrice = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        pnlCreditCard = New Panel()
        txtCVC = New TextBox()
        txtCardNum = New TextBox()
        Pay2 = New Button()
        Pay1 = New Button()
        rdbGcash = New RadioButton()
        rdbCreditCard = New RadioButton()
        pnlGcash = New Panel()
        txtPINnum = New TextBox()
        txtPhoneNum = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCreditCard.SuspendLayout()
        pnlGcash.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(lblVideoke)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(lblDancer)
        Panel1.Controls.Add(lblSinger)
        Panel1.Controls.Add(lblClown)
        Panel1.Controls.Add(lblCatering)
        Panel1.Controls.Add(lblVenue)
        Panel1.Controls.Add(lblTotalPrice)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(1, -5)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(531, 565)
        Panel1.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.AutoSize = True
        btnBack.BackColor = Color.Transparent
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.LinkColor = Color.Black
        btnBack.Location = New Point(25, 518)
        btnBack.Margin = New Padding(2, 0, 2, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(53, 21)
        btnBack.TabIndex = 28
        btnBack.TabStop = True
        btnBack.Text = "<Back"
        ' 
        ' lblVideoke
        ' 
        lblVideoke.AutoSize = True
        lblVideoke.BackColor = Color.Transparent
        lblVideoke.Font = New Font("Segoe UI", 11F)
        lblVideoke.Location = New Point(403, 350)
        lblVideoke.Margin = New Padding(2, 0, 2, 0)
        lblVideoke.Name = "lblVideoke"
        lblVideoke.Size = New Size(36, 20)
        lblVideoke.TabIndex = 27
        lblVideoke.Text = "0.00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(80, 350)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 26
        Label2.Text = "Videoke"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(62, 400)
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
        PictureBox3.Location = New Point(62, 179)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(404, 24)
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' lblDancer
        ' 
        lblDancer.AutoSize = True
        lblDancer.BackColor = Color.Transparent
        lblDancer.Font = New Font("Segoe UI", 11F)
        lblDancer.Location = New Point(403, 321)
        lblDancer.Margin = New Padding(2, 0, 2, 0)
        lblDancer.Name = "lblDancer"
        lblDancer.Size = New Size(36, 20)
        lblDancer.TabIndex = 23
        lblDancer.Text = "0.00"
        ' 
        ' lblSinger
        ' 
        lblSinger.AutoSize = True
        lblSinger.BackColor = Color.Transparent
        lblSinger.Font = New Font("Segoe UI", 11F)
        lblSinger.Location = New Point(403, 296)
        lblSinger.Margin = New Padding(2, 0, 2, 0)
        lblSinger.Name = "lblSinger"
        lblSinger.Size = New Size(36, 20)
        lblSinger.TabIndex = 22
        lblSinger.Text = "0.00"
        ' 
        ' lblClown
        ' 
        lblClown.AutoSize = True
        lblClown.BackColor = Color.Transparent
        lblClown.Font = New Font("Segoe UI", 11F)
        lblClown.Location = New Point(403, 270)
        lblClown.Margin = New Padding(2, 0, 2, 0)
        lblClown.Name = "lblClown"
        lblClown.Size = New Size(36, 20)
        lblClown.TabIndex = 21
        lblClown.Text = "0.00"
        ' 
        ' lblCatering
        ' 
        lblCatering.AutoSize = True
        lblCatering.BackColor = Color.Transparent
        lblCatering.Font = New Font("Segoe UI", 11F)
        lblCatering.Location = New Point(403, 248)
        lblCatering.Margin = New Padding(2, 0, 2, 0)
        lblCatering.Name = "lblCatering"
        lblCatering.Size = New Size(36, 20)
        lblCatering.TabIndex = 20
        lblCatering.Text = "0.00"
        ' 
        ' lblVenue
        ' 
        lblVenue.AutoSize = True
        lblVenue.BackColor = Color.Transparent
        lblVenue.Font = New Font("Segoe UI", 11F)
        lblVenue.Location = New Point(403, 223)
        lblVenue.Margin = New Padding(2, 0, 2, 0)
        lblVenue.Name = "lblVenue"
        lblVenue.Size = New Size(36, 20)
        lblVenue.TabIndex = 19
        lblVenue.Text = "0.00"
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.BackColor = Color.Transparent
        lblTotalPrice.Font = New Font("Segoe UI", 16F)
        lblTotalPrice.Location = New Point(118, 436)
        lblTotalPrice.Margin = New Padding(2, 0, 2, 0)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(54, 30)
        lblTotalPrice.TabIndex = 18
        lblTotalPrice.Text = "0.00"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 16F)
        Label14.Location = New Point(62, 436)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(64, 30)
        Label14.TabIndex = 17
        Label14.Text = "Total:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 11F)
        Label13.Location = New Point(80, 321)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(56, 20)
        Label13.TabIndex = 16
        Label13.Text = "Dancer"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 11F)
        Label9.Location = New Point(80, 296)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 20)
        Label9.TabIndex = 15
        Label9.Text = "Singer"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 11F)
        Label10.Location = New Point(80, 270)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 20)
        Label10.TabIndex = 14
        Label10.Text = "Clown"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 11F)
        Label11.Location = New Point(80, 248)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 20)
        Label11.TabIndex = 13
        Label11.Text = "Catering"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 11F)
        Label12.Location = New Point(80, 223)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(49, 20)
        Label12.TabIndex = 12
        Label12.Text = "Venue"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(25, 29)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 47)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' pnlCreditCard
        ' 
        pnlCreditCard.Controls.Add(txtCVC)
        pnlCreditCard.Controls.Add(txtCardNum)
        pnlCreditCard.Controls.Add(Pay2)
        pnlCreditCard.Location = New Point(16, 155)
        pnlCreditCard.Margin = New Padding(2)
        pnlCreditCard.Name = "pnlCreditCard"
        pnlCreditCard.Size = New Size(454, 321)
        pnlCreditCard.TabIndex = 9
        ' 
        ' txtCVC
        ' 
        txtCVC.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        txtCVC.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCVC.Location = New Point(48, 127)
        txtCVC.Margin = New Padding(2)
        txtCVC.Name = "txtCVC"
        txtCVC.PlaceholderText = "CVC"
        txtCVC.Size = New Size(363, 43)
        txtCVC.TabIndex = 20
        ' 
        ' txtCardNum
        ' 
        txtCardNum.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        txtCardNum.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCardNum.Location = New Point(48, 68)
        txtCardNum.Margin = New Padding(2)
        txtCardNum.Name = "txtCardNum"
        txtCardNum.PlaceholderText = "Card Number"
        txtCardNum.Size = New Size(364, 43)
        txtCardNum.TabIndex = 18
        ' 
        ' Pay2
        ' 
        Pay2.BackgroundImage = CType(resources.GetObject("Pay2.BackgroundImage"), Image)
        Pay2.BackgroundImageLayout = ImageLayout.Zoom
        Pay2.FlatAppearance.BorderSize = 0
        Pay2.FlatStyle = FlatStyle.Flat
        Pay2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Pay2.Location = New Point(62, 185)
        Pay2.Margin = New Padding(2)
        Pay2.Name = "Pay2"
        Pay2.Size = New Size(346, 47)
        Pay2.TabIndex = 12
        Pay2.Text = "Pay   0.00"
        Pay2.UseVisualStyleBackColor = True
        ' 
        ' Pay1
        ' 
        Pay1.BackgroundImage = CType(resources.GetObject("Pay1.BackgroundImage"), Image)
        Pay1.BackgroundImageLayout = ImageLayout.Zoom
        Pay1.FlatAppearance.BorderSize = 0
        Pay1.FlatStyle = FlatStyle.Flat
        Pay1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Pay1.Location = New Point(74, 346)
        Pay1.Margin = New Padding(2)
        Pay1.Name = "Pay1"
        Pay1.Size = New Size(346, 47)
        Pay1.TabIndex = 2
        Pay1.Text = "Pay   0.00"
        Pay1.UseVisualStyleBackColor = True
        ' 
        ' rdbGcash
        ' 
        rdbGcash.AutoSize = True
        rdbGcash.Checked = True
        rdbGcash.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbGcash.Location = New Point(78, 75)
        rdbGcash.Margin = New Padding(2)
        rdbGcash.Name = "rdbGcash"
        rdbGcash.Size = New Size(95, 36)
        rdbGcash.TabIndex = 6
        rdbGcash.TabStop = True
        rdbGcash.Text = "Gcash"
        rdbGcash.UseVisualStyleBackColor = True
        ' 
        ' rdbCreditCard
        ' 
        rdbCreditCard.AutoSize = True
        rdbCreditCard.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdbCreditCard.Location = New Point(253, 75)
        rdbCreditCard.Margin = New Padding(2)
        rdbCreditCard.Name = "rdbCreditCard"
        rdbCreditCard.Size = New Size(152, 36)
        rdbCreditCard.TabIndex = 7
        rdbCreditCard.Text = "Credit Card"
        rdbCreditCard.UseVisualStyleBackColor = True
        ' 
        ' pnlGcash
        ' 
        pnlGcash.Controls.Add(pnlCreditCard)
        pnlGcash.Controls.Add(txtPINnum)
        pnlGcash.Controls.Add(txtPhoneNum)
        pnlGcash.Controls.Add(rdbCreditCard)
        pnlGcash.Controls.Add(rdbGcash)
        pnlGcash.Controls.Add(Pay1)
        pnlGcash.Location = New Point(536, -5)
        pnlGcash.Margin = New Padding(2)
        pnlGcash.Name = "pnlGcash"
        pnlGcash.Size = New Size(489, 565)
        pnlGcash.TabIndex = 8
        ' 
        ' txtPINnum
        ' 
        txtPINnum.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        txtPINnum.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPINnum.Location = New Point(64, 278)
        txtPINnum.Margin = New Padding(2)
        txtPINnum.Name = "txtPINnum"
        txtPINnum.PlaceholderText = "PIN Number"
        txtPINnum.Size = New Size(364, 43)
        txtPINnum.TabIndex = 21
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        txtPhoneNum.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNum.Location = New Point(64, 217)
        txtPhoneNum.Margin = New Padding(2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.PlaceholderText = "Phone Number"
        txtPhoneNum.Size = New Size(364, 43)
        txtPhoneNum.TabIndex = 21
        ' 
        ' Confirm_Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1017, 553)
        Controls.Add(pnlGcash)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "Confirm_Payment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Confirm_Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCreditCard.ResumeLayout(False)
        pnlCreditCard.PerformLayout()
        pnlGcash.ResumeLayout(False)
        pnlGcash.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblDancer As Label
    Friend WithEvents lblSinger As Label
    Friend WithEvents lblClown As Label
    Friend WithEvents lblCatering As Label
    Friend WithEvents lblVenue As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Pay1 As Button
    Friend WithEvents rdbGcash As RadioButton
    Friend WithEvents rdbCreditCard As RadioButton
    Friend WithEvents pnlGcash As Panel
    Friend WithEvents lblVideoke As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlCreditCard As Panel
    Friend WithEvents Pay2 As Button
    Friend WithEvents btnBack As LinkLabel
    Friend WithEvents txtCVC As TextBox
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtPINnum As TextBox
    Friend WithEvents txtPhoneNum As TextBox
End Class
