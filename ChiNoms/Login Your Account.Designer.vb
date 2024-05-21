<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Your_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Your_Account))
        Label1 = New Label()
        Panel1 = New Panel()
        txtPass = New TextBox()
        txtEmailAdd = New TextBox()
        lnlSignUp = New LinkLabel()
        lnlAdmin = New LinkLabel()
        btnLogin = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(326, 280)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtPass)
        Panel1.Controls.Add(txtEmailAdd)
        Panel1.Controls.Add(lnlSignUp)
        Panel1.Controls.Add(lnlAdmin)
        Panel1.Controls.Add(btnLogin)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 553)
        Panel1.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.Location = New Point(286, 262)
        txtPass.Margin = New Padding(2)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "Enter Password"
        txtPass.Size = New Size(446, 39)
        txtPass.TabIndex = 8
        txtPass.UseSystemPasswordChar = True
        ' 
        ' txtEmailAdd
        ' 
        txtEmailAdd.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailAdd.Location = New Point(286, 204)
        txtEmailAdd.Margin = New Padding(2)
        txtEmailAdd.Name = "txtEmailAdd"
        txtEmailAdd.PlaceholderText = "Enter Email Address"
        txtEmailAdd.Size = New Size(446, 39)
        txtEmailAdd.TabIndex = 7
        ' 
        ' lnlSignUp
        ' 
        lnlSignUp.AutoSize = True
        lnlSignUp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnlSignUp.LinkColor = Color.FromArgb(CByte(44), CByte(39), CByte(137))
        lnlSignUp.Location = New Point(667, 417)
        lnlSignUp.Margin = New Padding(2, 0, 2, 0)
        lnlSignUp.Name = "lnlSignUp"
        lnlSignUp.Size = New Size(65, 21)
        lnlSignUp.TabIndex = 5
        lnlSignUp.TabStop = True
        lnlSignUp.Text = "Sign Up"
        ' 
        ' lnlAdmin
        ' 
        lnlAdmin.AutoSize = True
        lnlAdmin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lnlAdmin.LinkColor = Color.FromArgb(CByte(44), CByte(39), CByte(137))
        lnlAdmin.Location = New Point(286, 417)
        lnlAdmin.Margin = New Padding(2, 0, 2, 0)
        lnlAdmin.Name = "lnlAdmin"
        lnlAdmin.Size = New Size(122, 21)
        lnlAdmin.TabIndex = 4
        lnlAdmin.TabStop = True
        lnlAdmin.Text = "Log in as Admin"
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
        btnLogin.Size = New Size(446, 58)
        btnLogin.TabIndex = 2
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Login_Your_Account
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Login_Your_Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login_Your_Account"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnlAdmin As LinkLabel
    Friend WithEvents lnlSignUp As LinkLabel



    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtPass As TextBox
End Class
