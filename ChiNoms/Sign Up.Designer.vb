<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up))
        btnNext = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        LabelBday = New Label()
        txtPhoneNum = New TextBox()
        txtAddress = New TextBox()
        txtAge = New TextBox()
        txtName = New TextBox()
        btnBack = New Button()
        cbSex = New ComboBox()
        dtpBirthday = New DateTimePicker()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.DarkSlateBlue
        btnNext.BackgroundImageLayout = ImageLayout.Zoom
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext.ForeColor = Color.LightCoral
        btnNext.Location = New Point(245, 436)
        btnNext.Margin = New Padding(2)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(529, 43)
        btnNext.TabIndex = 8
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LabelBday)
        Panel1.Controls.Add(txtPhoneNum)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtAge)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(cbSex)
        Panel1.Controls.Add(dtpBirthday)
        Panel1.Controls.Add(btnNext)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 553)
        Panel1.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(571, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 21)
        Label2.TabIndex = 20
        Label2.Text = "Age:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(233, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 21)
        Label1.TabIndex = 19
        Label1.Text = "Sex:"
        ' 
        ' LabelBday
        ' 
        LabelBday.AutoSize = True
        LabelBday.BackColor = Color.Transparent
        LabelBday.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelBday.Location = New Point(233, 176)
        LabelBday.Name = "LabelBday"
        LabelBday.Size = New Size(80, 21)
        LabelBday.TabIndex = 18
        LabelBday.Text = "Birth date:"
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhoneNum.Location = New Point(233, 370)
        txtPhoneNum.Margin = New Padding(2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.PlaceholderText = "Enter Phone Number"
        txtPhoneNum.Size = New Size(554, 36)
        txtPhoneNum.TabIndex = 17
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAddress.Location = New Point(233, 320)
        txtAddress.Margin = New Padding(2)
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "Enter Address"
        txtAddress.Size = New Size(554, 36)
        txtAddress.TabIndex = 15
        ' 
        ' txtAge
        ' 
        txtAge.Enabled = False
        txtAge.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(571, 201)
        txtAge.Margin = New Padding(2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(216, 36)
        txtAge.TabIndex = 14
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(233, 129)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Enter Name"
        txtName.Size = New Size(554, 36)
        txtName.TabIndex = 13
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSlateBlue
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(27, 22)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(97, 29)
        btnBack.TabIndex = 12
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' cbSex
        ' 
        cbSex.DropDownStyle = ComboBoxStyle.DropDownList
        cbSex.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbSex.FormattingEnabled = True
        cbSex.Items.AddRange(New Object() {"Female", "Male"})
        cbSex.Location = New Point(233, 271)
        cbSex.Margin = New Padding(2)
        cbSex.MaxDropDownItems = 2
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(554, 38)
        cbSex.TabIndex = 11
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.DropDownAlign = LeftRightAlignment.Right
        dtpBirthday.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpBirthday.Location = New Point(233, 201)
        dtpBirthday.Margin = New Padding(2)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(333, 36)
        dtpBirthday.TabIndex = 10
        dtpBirthday.Value = New Date(2024, 5, 20, 0, 0, 0, 0)
        ' 
        ' Sign_Up
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "Sign_Up"
        Text = "Sign_Up"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelBday As Label
    Friend WithEvents Label2 As Label
End Class
