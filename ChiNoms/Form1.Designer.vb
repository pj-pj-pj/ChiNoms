<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        btnBookNow = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-19, -9)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1056, 573)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBookNow
        ' 
        btnBookNow.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBookNow.BackColor = Color.GhostWhite
        btnBookNow.FlatAppearance.BorderSize = 0
        btnBookNow.FlatStyle = FlatStyle.Popup
        btnBookNow.Font = New Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookNow.ForeColor = SystemColors.Desktop
        btnBookNow.Location = New Point(379, 347)
        btnBookNow.Margin = New Padding(2)
        btnBookNow.Name = "btnBookNow"
        btnBookNow.Size = New Size(260, 41)
        btnBookNow.TabIndex = 1
        btnBookNow.Text = "Book Now "
        btnBookNow.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 553)
        Controls.Add(btnBookNow)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ChiNoms"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBookNow As Button

End Class
