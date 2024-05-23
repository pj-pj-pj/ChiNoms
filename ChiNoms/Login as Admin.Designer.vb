<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_as_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_as_Admin))
        Panel1 = New Panel()
        txtPass = New TextBox()
        txtEmailAdd = New TextBox()
        lnlGuest = New LinkLabel()
        btnLogin = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtPass)
        Panel1.Controls.Add(txtEmailAdd)
        Panel1.Controls.Add(lnlGuest)
        Panel1.Controls.Add(btnLogin)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 553)
        Panel1.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.Location = New Point(286, 265)
        txtPass.Margin = New Padding(2)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "Enter Password"
        txtPass.Size = New Size(445, 39)
        txtPass.TabIndex = 5
        txtPass.UseSystemPasswordChar = True
        ' 
        ' txtEmailAdd
        ' 
        txtEmailAdd.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailAdd.Location = New Point(286, 200)
        txtEmailAdd.Margin = New Padding(2)
        txtEmailAdd.Name = "txtEmailAdd"
        txtEmailAdd.PlaceholderText = "Enter Email Address"
        txtEmailAdd.Size = New Size(445, 39)
        txtEmailAdd.TabIndex = 4
        ' 
        ' lnlGuest
        ' 
        lnlGuest.AutoSize = True
        lnlGuest.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnlGuest.LinkColor = Color.FromArgb(CByte(44), CByte(39), CByte(137))
        lnlGuest.Location = New Point(448, 416)
        lnlGuest.Margin = New Padding(2, 0, 2, 0)
        lnlGuest.Name = "lnlGuest"
        lnlGuest.Size = New Size(116, 21)
        lnlGuest.TabIndex = 3
        lnlGuest.TabStop = True
        lnlGuest.Text = "Log in as Guest"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), Image)
        btnLogin.BackgroundImageLayout = ImageLayout.Zoom
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(286, 322)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(445, 58)
        btnLogin.TabIndex = 2
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Login_as_Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        MaximizeBox = False
        Name = "Login_as_Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lnlGuest As LinkLabel
    Friend WithEvents btnLogin As Button

    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtPass As TextBox
End Class
