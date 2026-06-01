<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        PictureBox3 = New PictureBox()
        Label9 = New Label()
        btnclose = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(160, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(163, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 20)
        Label1.TabIndex = 1
        Label1.Text = "Visual Basic .NET Course Project"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(248, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(160, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 3
        Label3.Text = "Developed by:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(163, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 15)
        Label4.TabIndex = 4
        Label4.Text = "Mohammad Baniyounis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(163, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 5
        Label5.Text = "Malek Shehadeh"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.ForeColor = Color.Lime
        Label6.Location = New Point(160, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 15)
        Label6.TabIndex = 6
        Label6.Text = "Supervised by:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(160, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 15)
        Label7.TabIndex = 7
        Label7.Text = "Dr. Issam Al-Hadid"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.line1
        PictureBox2.Location = New Point(151, 129)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(263, 11)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(200, 264)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 15)
        Label8.TabIndex = 9
        Label8.Text = "The University of Jordan -"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.line1
        PictureBox3.Location = New Point(151, 250)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(263, 11)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.ForeColor = Color.Lime
        Label9.Location = New Point(337, 264)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 15)
        Label9.TabIndex = 11
        Label9.Text = "Aqaba"
        ' 
        ' btnclose
        ' 
        btnclose.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnclose.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclose.ForeColor = Color.White
        btnclose.Location = New Point(224, 304)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(97, 29)
        btnclose.TabIndex = 0
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(563, 362)
        Controls.Add(btnclose)
        Controls.Add(Label9)
        Controls.Add(PictureBox3)
        Controls.Add(Label8)
        Controls.Add(PictureBox2)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "About"
        Text = "About"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnclose As Button
End Class
