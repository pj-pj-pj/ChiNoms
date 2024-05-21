<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_Up2))
        btnCancel = New Button()
        btnRegister = New Button()
        Panel1 = New Panel()
        txtConfirmPass = New TextBox()
        txtCreatePass = New TextBox()
        txtEmailAdd = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkSlateBlue
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.LightCoral
        btnCancel.Location = New Point(317, 378)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(185, 30)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.DarkSlateBlue
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRegister.ForeColor = Color.LightCoral
        btnRegister.Location = New Point(533, 378)
        btnRegister.Margin = New Padding(2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(185, 30)
        btnRegister.TabIndex = 10
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtConfirmPass)
        Panel1.Controls.Add(txtCreatePass)
        Panel1.Controls.Add(txtEmailAdd)
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(btnCancel)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1017, 553)
        Panel1.TabIndex = 11
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmPass.Location = New Point(276, 309)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PlaceholderText = "Confirm Password"
        txtConfirmPass.Size = New Size(465, 35)
        txtConfirmPass.TabIndex = 13
        txtConfirmPass.UseSystemPasswordChar = True
        ' 
        ' txtCreatePass
        ' 
        txtCreatePass.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCreatePass.Location = New Point(276, 259)
        txtCreatePass.Name = "txtCreatePass"
        txtCreatePass.PlaceholderText = "Enter Password"
        txtCreatePass.Size = New Size(465, 35)
        txtCreatePass.TabIndex = 12
        txtCreatePass.UseSystemPasswordChar = True
        ' 
        ' txtEmailAdd
        ' 
        txtEmailAdd.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailAdd.Location = New Point(277, 206)
        txtEmailAdd.Name = "txtEmailAdd"
        txtEmailAdd.PlaceholderText = "Enter Email Address"
        txtEmailAdd.Size = New Size(465, 35)
        txtEmailAdd.TabIndex = 11
        ' 
        ' Sign_Up2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "Sign_Up2"
        Text = "Sign_Up2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents txtCreatePass As TextBox
End Class
