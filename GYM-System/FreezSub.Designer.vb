<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreezSub
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
        btnsearch = New Button()
        txtusername = New TextBox()
        lblusername = New Label()
        btnconfirmfreez = New Button()
        btncancel = New Button()
        grbfreezdetails = New GroupBox()
        txtnewenddate = New TextBox()
        dtpfreezstart = New DateTimePicker()
        nudweight = New NumericUpDown()
        lblfreezdays = New Label()
        Label5 = New Label()
        lblfreezstartdate = New Label()
        grbcurrentinfo = New GroupBox()
        txtenddate = New TextBox()
        Label4 = New Label()
        txtcurrentplan = New TextBox()
        Label3 = New Label()
        txtID = New TextBox()
        lblID = New Label()
        txtfullname = New TextBox()
        lblfullname = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grbfreezdetails.SuspendLayout()
        CType(nudweight, ComponentModel.ISupportInitialize).BeginInit()
        grbcurrentinfo.SuspendLayout()
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
        Label1.Size = New Size(241, 19)
        Label1.TabIndex = 35
        Label1.Text = "Manage Subscription Freeze and Hold"
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
        Label2.Location = New Point(251, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 28)
        Label2.TabIndex = 33
        Label2.Text = "SUBSCRIPTION"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(177, 14)
        lblview.Name = "lblview"
        lblview.Size = New Size(75, 28)
        lblview.TabIndex = 32
        lblview.Text = "FREEZE"
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnsearch.BackgroundImageLayout = ImageLayout.Center
        btnsearch.FlatAppearance.BorderColor = Color.Lime
        btnsearch.FlatAppearance.MouseDownBackColor = Color.Green
        btnsearch.FlatAppearance.MouseOverBackColor = Color.Green
        btnsearch.FlatStyle = FlatStyle.Flat
        btnsearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnsearch.ForeColor = Color.White
        btnsearch.Location = New Point(640, 79)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(90, 23)
        btnsearch.TabIndex = 46
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.ForeColor = SystemColors.Info
        txtusername.Location = New Point(399, 79)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(201, 23)
        txtusername.TabIndex = 45
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.BackColor = Color.Transparent
        lblusername.Font = New Font("Segoe UI", 10F)
        lblusername.ForeColor = Color.White
        lblusername.Location = New Point(218, 83)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(165, 19)
        lblusername.TabIndex = 44
        lblusername.Text = "Enter Member UserName"
        ' 
        ' btnconfirmfreez
        ' 
        btnconfirmfreez.BackColor = Color.LimeGreen
        btnconfirmfreez.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnconfirmfreez.FlatStyle = FlatStyle.Flat
        btnconfirmfreez.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnconfirmfreez.ForeColor = Color.White
        btnconfirmfreez.Location = New Point(405, 395)
        btnconfirmfreez.Name = "btnconfirmfreez"
        btnconfirmfreez.Size = New Size(140, 29)
        btnconfirmfreez.TabIndex = 42
        btnconfirmfreez.Text = "Confirm Freeze"
        btnconfirmfreez.UseVisualStyleBackColor = False
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btncancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncancel.ForeColor = Color.White
        btncancel.Location = New Point(251, 395)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(104, 29)
        btncancel.TabIndex = 43
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' grbfreezdetails
        ' 
        grbfreezdetails.BackColor = Color.Transparent
        grbfreezdetails.Controls.Add(txtnewenddate)
        grbfreezdetails.Controls.Add(dtpfreezstart)
        grbfreezdetails.Controls.Add(nudweight)
        grbfreezdetails.Controls.Add(lblfreezdays)
        grbfreezdetails.Controls.Add(Label5)
        grbfreezdetails.Controls.Add(lblfreezstartdate)
        grbfreezdetails.ForeColor = Color.White
        grbfreezdetails.Location = New Point(429, 131)
        grbfreezdetails.Name = "grbfreezdetails"
        grbfreezdetails.Size = New Size(359, 220)
        grbfreezdetails.TabIndex = 41
        grbfreezdetails.TabStop = False
        grbfreezdetails.Text = "Subscription freeze details"
        ' 
        ' txtnewenddate
        ' 
        txtnewenddate.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtnewenddate.BorderStyle = BorderStyle.FixedSingle
        txtnewenddate.ForeColor = Color.White
        txtnewenddate.Location = New Point(116, 127)
        txtnewenddate.Name = "txtnewenddate"
        txtnewenddate.ReadOnly = True
        txtnewenddate.Size = New Size(212, 23)
        txtnewenddate.TabIndex = 29
        ' 
        ' dtpfreezstart
        ' 
        dtpfreezstart.Location = New Point(116, 30)
        dtpfreezstart.Name = "dtpfreezstart"
        dtpfreezstart.Size = New Size(212, 23)
        dtpfreezstart.TabIndex = 25
        ' 
        ' nudweight
        ' 
        nudweight.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        nudweight.BorderStyle = BorderStyle.FixedSingle
        nudweight.ForeColor = Color.White
        nudweight.Location = New Point(116, 68)
        nudweight.Name = "nudweight"
        nudweight.Size = New Size(212, 23)
        nudweight.TabIndex = 22
        ' 
        ' lblfreezdays
        ' 
        lblfreezdays.AutoSize = True
        lblfreezdays.BackColor = Color.Transparent
        lblfreezdays.Font = New Font("Arial", 9F)
        lblfreezdays.ForeColor = Color.Lime
        lblfreezdays.Location = New Point(22, 76)
        lblfreezdays.Name = "lblfreezdays"
        lblfreezdays.Size = New Size(75, 15)
        lblfreezdays.TabIndex = 19
        lblfreezdays.Text = "Freeze Days"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(22, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 15)
        Label5.TabIndex = 2
        Label5.Text = "New End Date"
        ' 
        ' lblfreezstartdate
        ' 
        lblfreezstartdate.AutoSize = True
        lblfreezstartdate.ForeColor = Color.Lime
        lblfreezstartdate.Location = New Point(22, 36)
        lblfreezstartdate.Name = "lblfreezstartdate"
        lblfreezstartdate.Size = New Size(94, 15)
        lblfreezstartdate.TabIndex = 0
        lblfreezstartdate.Text = "Freeze Start Date"
        ' 
        ' grbcurrentinfo
        ' 
        grbcurrentinfo.BackColor = Color.Transparent
        grbcurrentinfo.Controls.Add(txtenddate)
        grbcurrentinfo.Controls.Add(Label4)
        grbcurrentinfo.Controls.Add(txtcurrentplan)
        grbcurrentinfo.Controls.Add(Label3)
        grbcurrentinfo.Controls.Add(txtID)
        grbcurrentinfo.Controls.Add(lblID)
        grbcurrentinfo.Controls.Add(txtfullname)
        grbcurrentinfo.Controls.Add(lblfullname)
        grbcurrentinfo.ForeColor = Color.White
        grbcurrentinfo.Location = New Point(37, 131)
        grbcurrentinfo.Name = "grbcurrentinfo"
        grbcurrentinfo.Size = New Size(334, 220)
        grbcurrentinfo.TabIndex = 40
        grbcurrentinfo.TabStop = False
        grbcurrentinfo.Text = "Current subscriber information"
        ' 
        ' txtenddate
        ' 
        txtenddate.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtenddate.BorderStyle = BorderStyle.FixedSingle
        txtenddate.ForeColor = Color.White
        txtenddate.Location = New Point(119, 169)
        txtenddate.Name = "txtenddate"
        txtenddate.ReadOnly = True
        txtenddate.Size = New Size(147, 23)
        txtenddate.TabIndex = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Lime
        Label4.Location = New Point(19, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 27
        Label4.Text = "End Date"
        ' 
        ' txtcurrentplan
        ' 
        txtcurrentplan.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtcurrentplan.BorderStyle = BorderStyle.FixedSingle
        txtcurrentplan.ForeColor = Color.White
        txtcurrentplan.Location = New Point(119, 122)
        txtcurrentplan.Name = "txtcurrentplan"
        txtcurrentplan.ReadOnly = True
        txtcurrentplan.Size = New Size(147, 23)
        txtcurrentplan.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(19, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 25
        Label3.Text = "Current Plan"
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.ForeColor = Color.White
        txtID.Location = New Point(119, 27)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(147, 23)
        txtID.TabIndex = 24
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.Lime
        lblID.Location = New Point(19, 30)
        lblID.Name = "lblID"
        lblID.Size = New Size(18, 15)
        lblID.TabIndex = 23
        lblID.Text = "ID"
        ' 
        ' txtfullname
        ' 
        txtfullname.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtfullname.BorderStyle = BorderStyle.FixedSingle
        txtfullname.ForeColor = Color.White
        txtfullname.Location = New Point(119, 73)
        txtfullname.Name = "txtfullname"
        txtfullname.ReadOnly = True
        txtfullname.Size = New Size(147, 23)
        txtfullname.TabIndex = 1
        ' 
        ' lblfullname
        ' 
        lblfullname.AutoSize = True
        lblfullname.ForeColor = Color.Lime
        lblfullname.Location = New Point(19, 76)
        lblfullname.Name = "lblfullname"
        lblfullname.Size = New Size(61, 15)
        lblfullname.TabIndex = 0
        lblfullname.Text = "Full Name"
        ' 
        ' FreezSub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnsearch)
        Controls.Add(txtusername)
        Controls.Add(lblusername)
        Controls.Add(btnconfirmfreez)
        Controls.Add(btncancel)
        Controls.Add(grbfreezdetails)
        Controls.Add(grbcurrentinfo)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        DoubleBuffered = True
        Name = "FreezSub"
        Text = "FreezSub"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grbfreezdetails.ResumeLayout(False)
        grbfreezdetails.PerformLayout()
        CType(nudweight, ComponentModel.ISupportInitialize).EndInit()
        grbcurrentinfo.ResumeLayout(False)
        grbcurrentinfo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblusername As Label
    Private btnconfirmfreez As Button
    Friend WithEvents btnsavechanges As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents grbfreezdetails As GroupBox
    Friend WithEvents dtpstartdate As DateTimePicker
    Friend WithEvents cmbsubplan As ComboBox
    Friend WithEvents nudweight As NumericUpDown
    Friend WithEvents nudheight As NumericUpDown
    Friend WithEvents lblsubplan As Label
    Friend WithEvents lblfreezdays As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblfreezstartdate As Label
    Friend WithEvents grbcurrentinfo As GroupBox
    Friend WithEvents txtenddate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcurrentplan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents dtpfreezstart As DateTimePicker
    Friend WithEvents txtnewenddate As TextBox
End Class
