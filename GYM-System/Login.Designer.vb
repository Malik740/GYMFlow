<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        grblog = New GroupBox()
        btnforgetpass = New Button()
        btnlogin = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        lblpass = New Label()
        lblname = New Label()
        PictureBox1 = New PictureBox()
        grblog.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grblog
        ' 
        grblog.BackColor = Color.Transparent
        grblog.Controls.Add(btnforgetpass)
        grblog.Controls.Add(btnlogin)
        grblog.Controls.Add(txtpassword)
        grblog.Controls.Add(txtusername)
        grblog.Controls.Add(lblpass)
        grblog.Controls.Add(lblname)
        grblog.ForeColor = SystemColors.ButtonHighlight
        grblog.Location = New Point(57, 71)
        grblog.Name = "grblog"
        grblog.Size = New Size(261, 243)
        grblog.TabIndex = 0
        grblog.TabStop = False
        grblog.Text = "login"
        ' 
        ' btnforgetpass
        ' 
        btnforgetpass.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnforgetpass.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnforgetpass.FlatStyle = FlatStyle.Flat
        btnforgetpass.Font = New Font("Segoe UI", 8F, FontStyle.Bold Or FontStyle.Underline)
        btnforgetpass.ForeColor = Color.White
        btnforgetpass.Location = New Point(21, 170)
        btnforgetpass.Name = "btnforgetpass"
        btnforgetpass.Size = New Size(121, 29)
        btnforgetpass.TabIndex = 3
        btnforgetpass.Text = "Forget Password?"
        btnforgetpass.UseVisualStyleBackColor = False
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.LimeGreen
        btnlogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(148, 170)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(89, 29)
        btnlogin.TabIndex = 2
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtpassword.ForeColor = Color.White
        txtpassword.Location = New Point(97, 107)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.PlaceholderText = "Password"
        txtpassword.Size = New Size(140, 23)
        txtpassword.TabIndex = 1
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(97, 69)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(140, 23)
        txtusername.TabIndex = 0
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.ForeColor = SystemColors.ControlLightLight
        lblpass.Location = New Point(34, 110)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(57, 15)
        lblpass.TabIndex = 1
        lblpass.Text = "Password"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.ForeColor = SystemColors.ControlLightLight
        lblname.Location = New Point(32, 72)
        lblname.Name = "lblname"
        lblname.Size = New Size(60, 15)
        lblname.TabIndex = 0
        lblname.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(78, -8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(214, 105)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(grblog)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Login"
        Text = "Login"
        grblog.ResumeLayout(False)
        grblog.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents grblog As GroupBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblpass As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnforgetpass As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
