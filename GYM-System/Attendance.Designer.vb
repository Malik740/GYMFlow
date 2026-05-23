<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblview = New Label()
        grbenteringinfo = New GroupBox()
        btnsavechanges = New Button()
        txtusername = New TextBox()
        lblenter = New Label()
        grbtakeattendance = New GroupBox()
        txtExpiry = New TextBox()
        Label5 = New Label()
        txtStatus = New TextBox()
        Label4 = New Label()
        membername = New TextBox()
        Label3 = New Label()
        btncancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grbenteringinfo.SuspendLayout()
        grbtakeattendance.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(177, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 19)
        Label1.TabIndex = 35
        Label1.Text = "Track GymFlow Attendance"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 34
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(300, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 28)
        Label2.TabIndex = 33
        Label2.Text = "SCANNER"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(177, 14)
        lblview.Name = "lblview"
        lblview.Size = New Size(133, 28)
        lblview.TabIndex = 32
        lblview.Text = "ATTENDANCE"
        ' 
        ' grbenteringinfo
        ' 
        grbenteringinfo.BackColor = Color.Transparent
        grbenteringinfo.Controls.Add(btnsavechanges)
        grbenteringinfo.Controls.Add(txtusername)
        grbenteringinfo.Controls.Add(lblenter)
        grbenteringinfo.ForeColor = Color.White
        grbenteringinfo.Location = New Point(30, 116)
        grbenteringinfo.Name = "grbenteringinfo"
        grbenteringinfo.Size = New Size(354, 151)
        grbenteringinfo.TabIndex = 36
        grbenteringinfo.TabStop = False
        grbenteringinfo.Text = "Attendance"
        ' 
        ' btnsavechanges
        ' 
        btnsavechanges.BackColor = Color.LimeGreen
        btnsavechanges.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnsavechanges.FlatStyle = FlatStyle.Flat
        btnsavechanges.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnsavechanges.ForeColor = Color.White
        btnsavechanges.Location = New Point(84, 84)
        btnsavechanges.Name = "btnsavechanges"
        btnsavechanges.Size = New Size(174, 29)
        btnsavechanges.TabIndex = 37
        btnsavechanges.Text = "RECORD ATTENDANCE"
        btnsavechanges.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(178, 28)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(164, 23)
        txtusername.TabIndex = 1
        ' 
        ' lblenter
        ' 
        lblenter.AutoSize = True
        lblenter.ForeColor = Color.Lime
        lblenter.Location = New Point(6, 31)
        lblenter.Name = "lblenter"
        lblenter.Size = New Size(169, 15)
        lblenter.TabIndex = 0
        lblenter.Text = "Enter Member PhoneNumber :"
        ' 
        ' grbtakeattendance
        ' 
        grbtakeattendance.BackColor = Color.Transparent
        grbtakeattendance.Controls.Add(txtExpiry)
        grbtakeattendance.Controls.Add(Label5)
        grbtakeattendance.Controls.Add(txtStatus)
        grbtakeattendance.Controls.Add(Label4)
        grbtakeattendance.Controls.Add(membername)
        grbtakeattendance.Controls.Add(Label3)
        grbtakeattendance.ForeColor = Color.White
        grbtakeattendance.Location = New Point(415, 116)
        grbtakeattendance.Name = "grbtakeattendance"
        grbtakeattendance.Size = New Size(348, 151)
        grbtakeattendance.TabIndex = 38
        grbtakeattendance.TabStop = False
        grbtakeattendance.Text = "Member Attendance"
        ' 
        ' txtExpiry
        ' 
        txtExpiry.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtExpiry.BorderStyle = BorderStyle.FixedSingle
        txtExpiry.ForeColor = Color.White
        txtExpiry.Location = New Point(141, 106)
        txtExpiry.Name = "txtExpiry"
        txtExpiry.ReadOnly = True
        txtExpiry.Size = New Size(164, 23)
        txtExpiry.TabIndex = 41
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(15, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 40
        Label5.Text = "Expiry Date"
        ' 
        ' txtStatus
        ' 
        txtStatus.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtStatus.BorderStyle = BorderStyle.FixedSingle
        txtStatus.ForeColor = Color.White
        txtStatus.Location = New Point(141, 66)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(164, 23)
        txtStatus.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Lime
        Label4.Location = New Point(15, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 38
        Label4.Text = "Subscription Status"
        ' 
        ' membername
        ' 
        membername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        membername.BorderStyle = BorderStyle.FixedSingle
        membername.ForeColor = Color.White
        membername.Location = New Point(141, 28)
        membername.Name = "membername"
        membername.ReadOnly = True
        membername.Size = New Size(164, 23)
        membername.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(15, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 0
        Label3.Text = "Member Name"
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btncancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncancel.ForeColor = Color.White
        btncancel.Location = New Point(350, 321)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(104, 29)
        btncancel.TabIndex = 39
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(785, 450)
        Controls.Add(btncancel)
        Controls.Add(grbtakeattendance)
        Controls.Add(grbenteringinfo)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        Name = "Attendance"
        Text = "Attendance"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grbenteringinfo.ResumeLayout(False)
        grbenteringinfo.PerformLayout()
        grbtakeattendance.ResumeLayout(False)
        grbtakeattendance.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents grbenteringinfo As GroupBox
    Friend WithEvents lblenter As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnsavechanges As Button
    Friend WithEvents grbtakeattendance As GroupBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents membername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExpiry As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btncancel As Button
End Class
