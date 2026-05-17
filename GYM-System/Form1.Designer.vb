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
        lblchangpass = New LinkLabel()
        btnlog = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        lblpass = New Label()
        lblname = New Label()
        grblog.SuspendLayout()
        SuspendLayout()
        ' 
        ' grblog
        ' 
        grblog.BackColor = Color.Transparent
        grblog.Controls.Add(lblchangpass)
        grblog.Controls.Add(btnlog)
        grblog.Controls.Add(TextBox2)
        grblog.Controls.Add(TextBox1)
        grblog.Controls.Add(lblpass)
        grblog.Controls.Add(lblname)
        grblog.ForeColor = SystemColors.ButtonHighlight
        grblog.Location = New Point(57, 71)
        grblog.Name = "grblog"
        grblog.Size = New Size(261, 291)
        grblog.TabIndex = 1
        grblog.TabStop = False
        grblog.Text = "login"
        ' 
        ' lblchangpass
        ' 
        lblchangpass.ActiveLinkColor = Color.Black
        lblchangpass.AutoSize = True
        lblchangpass.LinkColor = Color.Green
        lblchangpass.Location = New Point(24, 195)
        lblchangpass.Name = "lblchangpass"
        lblchangpass.Size = New Size(94, 15)
        lblchangpass.TabIndex = 5
        lblchangpass.TabStop = True
        lblchangpass.Text = "Forget Password"
        lblchangpass.VisitedLinkColor = Color.Green
        ' 
        ' btnlog
        ' 
        btnlog.BackColor = Color.Honeydew
        btnlog.ForeColor = SystemColors.ActiveCaptionText
        btnlog.Location = New Point(122, 191)
        btnlog.Name = "btnlog"
        btnlog.Size = New Size(97, 23)
        btnlog.TabIndex = 4
        btnlog.Text = "Login"
        btnlog.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TextBox2.Location = New Point(97, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.PlaceholderText = "User PassWord"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(97, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
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
    Friend WithEvents btnlog As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblpass As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblchangpass As LinkLabel

End Class
