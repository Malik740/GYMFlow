<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
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
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        txtusername = New TextBox()
        lblusername = New Label()
        btndelete = New Button()
        btncancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(192, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 0
        Label1.Text = "Delete"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(254, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 28)
        Label2.TabIndex = 1
        Label2.Text = "User"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(-6, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' txtusername
        ' 
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(244, 172)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(128, 23)
        txtusername.TabIndex = 3
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Font = New Font("Segoe UI", 11F)
        lblusername.ForeColor = Color.White
        lblusername.Location = New Point(143, 175)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(82, 20)
        lblusername.TabIndex = 5
        lblusername.Text = "User Name"
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btndelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Segoe UI", 13F)
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(276, 246)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(96, 33)
        btndelete.TabIndex = 7
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.Transparent
        btncancel.FlatAppearance.BorderColor = Color.LimeGreen
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Segoe UI", 13F)
        btncancel.ForeColor = Color.White
        btncancel.Location = New Point(143, 246)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(96, 33)
        btncancel.TabIndex = 8
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' DeleteUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(560, 390)
        Controls.Add(btncancel)
        Controls.Add(btndelete)
        Controls.Add(lblusername)
        Controls.Add(txtusername)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DeleteUser"
        Text = "DeleteUser"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btncancel As Button
End Class
