<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        btnLogout = New Button()
        lblPhoneNum = New Label()
        lblEmail = New Label()
        lblAddress = New Label()
        lblSex = New Label()
        lblBday = New Label()
        lblAge = New Label()
        lblName = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnBack = New LinkLabel()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewButtonColumn()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(lblPhoneNum)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblSex)
        Panel1.Controls.Add(lblBday)
        Panel1.Controls.Add(lblAge)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(326, 553)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(84, 463)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(167, 45)
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 510)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 24)
        Label1.TabIndex = 17
        Label1.Text = "ChiNoms Contact#: 09909808099"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogout
        ' 
        btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Zoom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(56, 401)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(218, 40)
        btnLogout.TabIndex = 16
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblPhoneNum.ForeColor = Color.RosyBrown
        lblPhoneNum.Location = New Point(160, 325)
        lblPhoneNum.Margin = New Padding(2, 0, 2, 0)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(77, 23)
        lblPhoneNum.TabIndex = 15
        lblPhoneNum.Text = "Number"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblEmail.ForeColor = Color.RosyBrown
        lblEmail.Location = New Point(105, 299)
        lblEmail.Margin = New Padding(2, 0, 2, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(60, 23)
        lblEmail.TabIndex = 14
        lblEmail.Text = "Email"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblAddress.ForeColor = Color.RosyBrown
        lblAddress.Location = New Point(134, 210)
        lblAddress.Margin = New Padding(2, 0, 2, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(44, 23)
        lblAddress.TabIndex = 13
        lblAddress.Text = "Add"
        ' 
        ' lblSex
        ' 
        lblSex.AutoSize = True
        lblSex.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblSex.ForeColor = Color.RosyBrown
        lblSex.Location = New Point(132, 182)
        lblSex.Margin = New Padding(2, 0, 2, 0)
        lblSex.Name = "lblSex"
        lblSex.Size = New Size(39, 23)
        lblSex.TabIndex = 12
        lblSex.Text = "Sex"
        ' 
        ' lblBday
        ' 
        lblBday.AutoSize = True
        lblBday.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblBday.ForeColor = Color.RosyBrown
        lblBday.Location = New Point(132, 152)
        lblBday.Margin = New Padding(2, 0, 2, 0)
        lblBday.Name = "lblBday"
        lblBday.Size = New Size(53, 23)
        lblBday.TabIndex = 11
        lblBday.Text = "Bday"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        lblAge.ForeColor = Color.RosyBrown
        lblAge.Location = New Point(132, 121)
        lblAge.Margin = New Padding(2, 0, 2, 0)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(32, 23)
        lblAge.TabIndex = 10
        lblAge.Text = "00"
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Sitka Small Semibold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(34, 37)
        lblName.Margin = New Padding(2, 0, 2, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(265, 45)
        lblName.TabIndex = 7
        lblName.Text = "Sample Acc"
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.RosyBrown
        Label7.Location = New Point(34, 325)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 23)
        Label7.TabIndex = 6
        Label7.Text = "Phone No. :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.RosyBrown
        Label6.Location = New Point(34, 299)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 23)
        Label6.TabIndex = 5
        Label6.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label5.ForeColor = Color.RosyBrown
        Label5.Location = New Point(35, 210)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 23)
        Label5.TabIndex = 4
        Label5.Text = "Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label4.ForeColor = Color.RosyBrown
        Label4.Location = New Point(35, 182)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 23)
        Label4.TabIndex = 3
        Label4.Text = "Sex:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.RosyBrown
        Label3.Location = New Point(35, 152)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 23)
        Label3.TabIndex = 2
        Label3.Text = "Birthday:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.RosyBrown
        Label2.Location = New Point(35, 121)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 23)
        Label2.TabIndex = 1
        Label2.Text = "Age:"
        ' 
        ' btnBack
        ' 
        btnBack.AutoSize = True
        btnBack.Font = New Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = Color.DarkMagenta
        btnBack.LinkColor = Color.Purple
        btnBack.Location = New Point(790, 507)
        btnBack.Margin = New Padding(2, 0, 2, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(218, 26)
        btnBack.TabIndex = 18
        btnBack.TabStop = True
        btnBack.Text = "ADD A RESERVATION >"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(341, 60)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(681, 436)
        Panel2.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(246), CByte(234), CByte(242))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column4, Column2, Column3, Column5})
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(13, 11)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(654, 411)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.Frozen = True
        Column1.HeaderText = "Type"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.NotSortable
        Column1.Width = 150
        ' 
        ' Column4
        ' 
        Column4.Frozen = True
        Column4.HeaderText = "Status"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.SortMode = DataGridViewColumnSortMode.NotSortable
        Column4.Width = 200
        ' 
        ' Column2
        ' 
        Column2.Frozen = True
        Column2.HeaderText = "Days"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.SortMode = DataGridViewColumnSortMode.NotSortable
        Column2.Width = 40
        ' 
        ' Column3
        ' 
        Column3.Frozen = True
        Column3.HeaderText = "Total"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.SortMode = DataGridViewColumnSortMode.NotSortable
        Column3.Width = 150
        ' 
        ' Column5
        ' 
        Column5.Frozen = True
        Column5.HeaderText = "Check Details"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Programmatic
        Column5.Text = ">>"
        Column5.UseColumnTextForButtonValue = True
        Column5.Width = 50
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(341, 16)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(235, 40)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1034, 553)
        Controls.Add(btnBack)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblBday As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents btnBack As LinkLabel
    Friend WithEvents lblAddress As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
