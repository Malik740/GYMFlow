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
        TextBox2 = New TextBox()
        txtusername = New TextBox()
        lblpass = New Label()
        lblname = New Label()
        btnforgetpass = New Button()
        btnlogin = New Button()
        grblog.SuspendLayout()
        SuspendLayout()
        ' 
        ' grblog
        ' 
        grblog.BackColor = Color.Transparent
        grblog.Controls.Add(btnforgetpass)
        grblog.Controls.Add(btnlogin)
        grblog.Controls.Add(TextBox2)
        grblog.Controls.Add(txtusername)
        grblog.Controls.Add(lblpass)
        grblog.Controls.Add(lblname)
        grblog.ForeColor = SystemColors.ButtonHighlight
        grblog.Location = New Point(57, 71)
        grblog.Name = "grblog"
        grblog.Size = New Size(261, 243)
        grblog.TabIndex = 1
        grblog.TabStop = False
        grblog.Text = "login"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(24, 24, 24)
        TextBox2.Location = New Point(97, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(24, 24, 24)
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.Location = New Point(97, 69)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 2
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.ForeColor = SystemColors.ControlLightLight
        lblpass.Location = New Point(34, 110)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(57, 15)
        lblpass.TabIndex = 1
        lblpass.Text = "password"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.ForeColor = SystemColors.ControlLightLight
        lblname.Location = New Point(32, 72)
        lblname.Name = "lblname"
        lblname.Size = New Size(59, 15)
        lblname.TabIndex = 0
        lblname.Text = "usernaem"
        ' 
        ' btnforgetpass
        ' 
        btnforgetpass.BackColor = Color.FromArgb(24, 24, 24)
        btnforgetpass.FlatAppearance.BorderColor = Color.FromArgb(32, 219, 69)
        btnforgetpass.FlatStyle = FlatStyle.Flat
        btnforgetpass.Font = New Font("Segoe UI", 8F, FontStyle.Bold Or FontStyle.Underline)
        btnforgetpass.ForeColor = Color.White
        btnforgetpass.Location = New Point(21, 170)
        btnforgetpass.Name = "btnforgetpass"
        btnforgetpass.Size = New Size(121, 29)
        btnforgetpass.TabIndex = 29
        btnforgetpass.Text = "Forget Password?"
        btnforgetpass.UseVisualStyleBackColor = False
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.LimeGreen
        btnlogin.FlatAppearance.BorderColor = Color.FromArgb(32, 219, 69)
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(148, 170)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(89, 29)
        btnlogin.TabIndex = 28
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(grblog)
        DoubleBuffered = True
        Name = "Login"
        Text = "Login"
        grblog.ResumeLayout(False)
        grblog.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents grblog As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblpass As Label
    Friend WithEvents lblname As Label
    Friend WithEvents btnforgetpass As Button
    Friend WithEvents btnlogin As Button

End Class
