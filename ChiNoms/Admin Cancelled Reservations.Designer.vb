<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Cancelled_Reservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Cancelled_Reservations))
        Panel1 = New Panel()
        btnPending = New Button()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        viewEventBtn = New Button()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnCancelled = New Button()
        btnApproved = New Button()
        btnRequests = New Button()
        pnlCancelled = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        PictureBox7 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCancelled.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(247), CByte(234), CByte(243))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnPending)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(viewEventBtn)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnCancelled)
        Panel1.Controls.Add(btnApproved)
        Panel1.Controls.Add(btnRequests)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 553)
        Panel1.TabIndex = 1
        ' 
        ' btnPending
        ' 
        btnPending.BackColor = Color.FromArgb(CByte(230), CByte(155), CByte(178))
        btnPending.FlatAppearance.BorderSize = 0
        btnPending.FlatStyle = FlatStyle.Flat
        btnPending.ForeColor = SystemColors.ButtonFace
        btnPending.Location = New Point(51, 356)
        btnPending.Name = "btnPending"
        btnPending.Size = New Size(169, 36)
        btnPending.TabIndex = 18
        btnPending.Text = "Pending Reservations"
        btnPending.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 76)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 25)
        Label3.TabIndex = 8
        Label3.Text = "Admin Dashboard"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(27, 280)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(216, 19)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' viewEventBtn
        ' 
        viewEventBtn.BackColor = Color.FromArgb(CByte(230), CByte(155), CByte(178))
        viewEventBtn.FlatAppearance.BorderSize = 0
        viewEventBtn.FlatStyle = FlatStyle.Flat
        viewEventBtn.ForeColor = SystemColors.ButtonFace
        viewEventBtn.Location = New Point(51, 314)
        viewEventBtn.Name = "viewEventBtn"
        viewEventBtn.Size = New Size(169, 36)
        viewEventBtn.TabIndex = 8
        viewEventBtn.Text = "View Event Reservation"
        viewEventBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(31, 475)
        PictureBox3.Margin = New Padding(2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(216, 19)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(59, 29)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(167, 45)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Zoom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(51, 498)
        btnLogout.Margin = New Padding(2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(163, 31)
        btnLogout.TabIndex = 5
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnCancelled
        ' 
        btnCancelled.BackColor = Color.FromArgb(CByte(239), CByte(192), CByte(208))
        btnCancelled.BackgroundImageLayout = ImageLayout.Zoom
        btnCancelled.FlatAppearance.BorderSize = 0
        btnCancelled.FlatStyle = FlatStyle.Flat
        btnCancelled.ForeColor = SystemColors.ControlLightLight
        btnCancelled.Location = New Point(51, 223)
        btnCancelled.Margin = New Padding(2)
        btnCancelled.Name = "btnCancelled"
        btnCancelled.Size = New Size(169, 35)
        btnCancelled.TabIndex = 4
        btnCancelled.Text = "Cancelled"
        btnCancelled.UseVisualStyleBackColor = False
        ' 
        ' btnApproved
        ' 
        btnApproved.BackColor = Color.FromArgb(CByte(230), CByte(155), CByte(178))
        btnApproved.BackgroundImageLayout = ImageLayout.Zoom
        btnApproved.FlatAppearance.BorderSize = 0
        btnApproved.FlatStyle = FlatStyle.Flat
        btnApproved.ForeColor = SystemColors.ControlLightLight
        btnApproved.Location = New Point(51, 185)
        btnApproved.Margin = New Padding(2)
        btnApproved.Name = "btnApproved"
        btnApproved.Size = New Size(169, 35)
        btnApproved.TabIndex = 3
        btnApproved.Text = "Approved"
        btnApproved.UseVisualStyleBackColor = False
        ' 
        ' btnRequests
        ' 
        btnRequests.BackColor = Color.FromArgb(CByte(230), CByte(155), CByte(178))
        btnRequests.BackgroundImageLayout = ImageLayout.Zoom
        btnRequests.FlatAppearance.BorderSize = 0
        btnRequests.FlatStyle = FlatStyle.Flat
        btnRequests.ForeColor = SystemColors.ControlLightLight
        btnRequests.Location = New Point(51, 146)
        btnRequests.Margin = New Padding(2)
        btnRequests.Name = "btnRequests"
        btnRequests.Size = New Size(169, 35)
        btnRequests.TabIndex = 2
        btnRequests.Text = "Requests"
        btnRequests.UseVisualStyleBackColor = False
        ' 
        ' pnlCancelled
        ' 
        pnlCancelled.BackColor = Color.FromArgb(CByte(250), CByte(251), CByte(250))
        pnlCancelled.Controls.Add(DataGridView1)
        pnlCancelled.Controls.Add(PictureBox7)
        pnlCancelled.Location = New Point(271, 0)
        pnlCancelled.Margin = New Padding(2)
        pnlCancelled.Name = "pnlCancelled"
        pnlCancelled.Size = New Size(755, 557)
        pnlCancelled.TabIndex = 11
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(246), CByte(234), CByte(242))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column10, Column3, Column4, Column5, Column6, Column7, Column8})
        DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
        DataGridView1.Location = New Point(-46, 79)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(797, 478)
        DataGridView1.TabIndex = 11
        ' 
        ' Column1
        ' 
        Column1.Frozen = True
        Column1.HeaderText = "Name"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 120
        ' 
        ' Column2
        ' 
        Column2.Frozen = True
        Column2.HeaderText = "Status"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 70
        ' 
        ' Column10
        ' 
        Column10.Frozen = True
        Column10.HeaderText = "Event"
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 110
        ' 
        ' Column3
        ' 
        Column3.Frozen = True
        Column3.HeaderText = "Venue"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 70
        ' 
        ' Column4
        ' 
        Column4.Frozen = True
        Column4.HeaderText = "Date"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 70
        ' 
        ' Column5
        ' 
        Column5.Frozen = True
        Column5.HeaderText = "Days"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 40
        ' 
        ' Column6
        ' 
        Column6.Frozen = True
        Column6.HeaderText = "Services"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.Frozen = True
        Column7.HeaderText = "Guests"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 50
        ' 
        ' Column8
        ' 
        Column8.Frozen = True
        Column8.HeaderText = "Total Costs"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(149, 11)
        PictureBox7.Margin = New Padding(2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(467, 64)
        PictureBox7.TabIndex = 4
        PictureBox7.TabStop = False
        ' 
        ' Admin_Cancelled_Reservations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(pnlCancelled)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Admin_Cancelled_Reservations"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_Cancelled_Reservations"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCancelled.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnCancelled As Button
    Friend WithEvents btnApproved As Button
    Friend WithEvents btnRequests As Button
    Friend WithEvents pnlCancelled As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Public WithEvents viewEventBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Public WithEvents btnPending As Button
End Class
