<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        grblog = New GroupBox()
        lblname = New Label()
        lblpass = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnlog = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grblog.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(803, 451)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' grblog
        ' 
        grblog.Controls.Add(btnlog)
        grblog.Controls.Add(TextBox2)
        grblog.Controls.Add(TextBox1)
        grblog.Controls.Add(lblpass)
        grblog.Controls.Add(lblname)
        grblog.Location = New Point(94, 70)
        grblog.Name = "grblog"
        grblog.Size = New Size(261, 291)
        grblog.TabIndex = 1
        grblog.TabStop = False
        grblog.Text = "login"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(32, 72)
        lblname.Name = "lblname"
        lblname.Size = New Size(59, 15)
        lblname.TabIndex = 0
        lblname.Text = "usernaem"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Location = New Point(34, 110)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(57, 15)
        lblpass.TabIndex = 1
        lblpass.Text = "password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(97, 69)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(97, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' btnlog
        ' 
        btnlog.Location = New Point(122, 191)
        btnlog.Name = "btnlog"
        btnlog.Size = New Size(75, 23)
        btnlog.TabIndex = 4
        btnlog.Text = "Login"
        btnlog.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grblog)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grblog.ResumeLayout(False)
        grblog.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grblog As GroupBox
    Friend WithEvents btnlog As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblpass As Label
    Friend WithEvents lblname As Label

End Class
