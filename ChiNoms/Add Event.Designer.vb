<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Event
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
        Label1 = New Label()
        pnlAddVenue = New Panel()
        Button1 = New Button()
        addImgBtn = New Button()
        txtPlaceID = New TextBox()
        txtCapacity = New TextBox()
        btnAddVenue = New Button()
        Label6 = New Label()
        Label3 = New Label()
        txtNewEvent = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        LinkLabel1 = New LinkLabel()
        pnlAddVenue.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(121, 24)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 23)
        Label1.TabIndex = 0
        Label1.Text = "Event Venue:"
        ' 
        ' pnlAddVenue
        ' 
        pnlAddVenue.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        pnlAddVenue.Controls.Add(Button1)
        pnlAddVenue.Controls.Add(addImgBtn)
        pnlAddVenue.Controls.Add(txtPlaceID)
        pnlAddVenue.Controls.Add(txtCapacity)
        pnlAddVenue.Controls.Add(btnAddVenue)
        pnlAddVenue.Controls.Add(Label6)
        pnlAddVenue.Controls.Add(Label3)
        pnlAddVenue.ForeColor = Color.White
        pnlAddVenue.Location = New Point(30, 127)
        pnlAddVenue.Margin = New Padding(2)
        pnlAddVenue.Name = "pnlAddVenue"
        pnlAddVenue.Size = New Size(724, 278)
        pnlAddVenue.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(230), CByte(154), CByte(179))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(196, 113)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 65)
        Button1.TabIndex = 9
        Button1.UseVisualStyleBackColor = False
        ' 
        ' addImgBtn
        ' 
        addImgBtn.BackColor = Color.FromArgb(CByte(230), CByte(154), CByte(179))
        addImgBtn.FlatStyle = FlatStyle.Flat
        addImgBtn.Font = New Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addImgBtn.ForeColor = Color.Transparent
        addImgBtn.Location = New Point(339, 113)
        addImgBtn.Margin = New Padding(2)
        addImgBtn.Name = "addImgBtn"
        addImgBtn.Size = New Size(205, 65)
        addImgBtn.TabIndex = 8
        addImgBtn.Text = "Add Image"
        addImgBtn.UseVisualStyleBackColor = False
        ' 
        ' txtPlaceID
        ' 
        txtPlaceID.Location = New Point(359, 33)
        txtPlaceID.Margin = New Padding(2)
        txtPlaceID.Name = "txtPlaceID"
        txtPlaceID.Size = New Size(185, 23)
        txtPlaceID.TabIndex = 3
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Location = New Point(359, 72)
        txtCapacity.Margin = New Padding(2)
        txtCapacity.Name = "txtCapacity"
        txtCapacity.Size = New Size(185, 23)
        txtCapacity.TabIndex = 4
        ' 
        ' btnAddVenue
        ' 
        btnAddVenue.BackColor = Color.FromArgb(CByte(230), CByte(154), CByte(179))
        btnAddVenue.FlatStyle = FlatStyle.Flat
        btnAddVenue.Font = New Font("Sitka Small", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddVenue.ForeColor = Color.Transparent
        btnAddVenue.Location = New Point(196, 191)
        btnAddVenue.Margin = New Padding(2)
        btnAddVenue.Name = "btnAddVenue"
        btnAddVenue.Size = New Size(348, 52)
        btnAddVenue.TabIndex = 7
        btnAddVenue.Text = "Add Event Venue"
        btnAddVenue.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(196, 70)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 23)
        Label6.TabIndex = 4
        Label6.Text = "Capacity:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(196, 31)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 23)
        Label3.TabIndex = 3
        Label3.Text = "Place ID:"
        ' 
        ' txtNewEvent
        ' 
        txtNewEvent.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewEvent.Location = New Point(106, 60)
        txtNewEvent.Margin = New Padding(2)
        txtNewEvent.Multiline = True
        txtNewEvent.Name = "txtNewEvent"
        txtNewEvent.Size = New Size(648, 50)
        txtNewEvent.TabIndex = 1
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Sitka Small", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(30, 24)
        LinkLabel1.Margin = New Padding(2, 0, 2, 0)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(58, 23)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "<Back"
        ' 
        ' Add_Event
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(154), CByte(179))
        ClientSize = New Size(787, 428)
        Controls.Add(LinkLabel1)
        Controls.Add(txtNewEvent)
        Controls.Add(pnlAddVenue)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Add_Event"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add_Event"
        pnlAddVenue.ResumeLayout(False)
        pnlAddVenue.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAddVenue As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddVenue As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNewEvent As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtPlaceID As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel

    Private Sub Add_Event_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin_Requests.Hide()
    End Sub

    Friend WithEvents addImgBtn As Button
    Friend WithEvents Button1 As Button
End Class
