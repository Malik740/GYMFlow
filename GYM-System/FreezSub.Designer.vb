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
        btnSearch = New Button()
        txtSearch = New TextBox()
        lblusername = New Label()
        btnCancel = New Button()
        grbfreezdetails = New GroupBox()
        txtNewEndDate = New TextBox()
        dtpFreezeStart = New DateTimePicker()
        numFreezeDays = New NumericUpDown()
        lblfreezdays = New Label()
        Label5 = New Label()
        lblfreezstartdate = New Label()
        grbcurrentinfo = New GroupBox()
        txtEndDate = New TextBox()
        Label4 = New Label()
        txtCurrentPlan = New TextBox()
        Label3 = New Label()
        txtID = New TextBox()
        lblID = New Label()
        txtFullName = New TextBox()
        lblfullname = New Label()
        btnConfirm = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grbfreezdetails.SuspendLayout()
        CType(numFreezeDays, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnSearch.BackgroundImageLayout = ImageLayout.Center
        btnSearch.FlatAppearance.BorderColor = Color.Lime
        btnSearch.FlatAppearance.MouseDownBackColor = Color.Green
        btnSearch.FlatAppearance.MouseOverBackColor = Color.Green
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(640, 79)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(90, 23)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtSearch.ForeColor = SystemColors.Info
        txtSearch.Location = New Point(399, 79)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(201, 23)
        txtSearch.TabIndex = 0
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
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(251, 395)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(104, 29)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' grbfreezdetails
        ' 
        grbfreezdetails.BackColor = Color.Transparent
        grbfreezdetails.Controls.Add(txtNewEndDate)
        grbfreezdetails.Controls.Add(dtpFreezeStart)
        grbfreezdetails.Controls.Add(numFreezeDays)
        grbfreezdetails.Controls.Add(lblfreezdays)
        grbfreezdetails.Controls.Add(Label5)
        grbfreezdetails.Controls.Add(lblfreezstartdate)
        grbfreezdetails.ForeColor = Color.White
        grbfreezdetails.Location = New Point(429, 131)
        grbfreezdetails.Name = "grbfreezdetails"
        grbfreezdetails.Size = New Size(359, 220)
        grbfreezdetails.TabIndex = 3
        grbfreezdetails.TabStop = False
        grbfreezdetails.Text = "Subscription freeze details"
        ' 
        ' txtNewEndDate
        ' 
        txtNewEndDate.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtNewEndDate.BorderStyle = BorderStyle.FixedSingle
        txtNewEndDate.ForeColor = Color.White
        txtNewEndDate.Location = New Point(116, 127)
        txtNewEndDate.Name = "txtNewEndDate"
        txtNewEndDate.ReadOnly = True
        txtNewEndDate.Size = New Size(212, 23)
        txtNewEndDate.TabIndex = 2
        ' 
        ' dtpFreezeStart
        ' 
        dtpFreezeStart.Location = New Point(116, 30)
        dtpFreezeStart.Name = "dtpFreezeStart"
        dtpFreezeStart.Size = New Size(212, 23)
        dtpFreezeStart.TabIndex = 0
        ' 
        ' numFreezeDays
        ' 
        numFreezeDays.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        numFreezeDays.BorderStyle = BorderStyle.FixedSingle
        numFreezeDays.ForeColor = Color.White
        numFreezeDays.Location = New Point(116, 68)
        numFreezeDays.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        numFreezeDays.Name = "numFreezeDays"
        numFreezeDays.Size = New Size(212, 23)
        numFreezeDays.TabIndex = 1
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
        grbcurrentinfo.Controls.Add(txtEndDate)
        grbcurrentinfo.Controls.Add(Label4)
        grbcurrentinfo.Controls.Add(txtCurrentPlan)
        grbcurrentinfo.Controls.Add(Label3)
        grbcurrentinfo.Controls.Add(txtID)
        grbcurrentinfo.Controls.Add(lblID)
        grbcurrentinfo.Controls.Add(txtFullName)
        grbcurrentinfo.Controls.Add(lblfullname)
        grbcurrentinfo.ForeColor = Color.White
        grbcurrentinfo.Location = New Point(37, 131)
        grbcurrentinfo.Name = "grbcurrentinfo"
        grbcurrentinfo.Size = New Size(334, 220)
        grbcurrentinfo.TabIndex = 2
        grbcurrentinfo.TabStop = False
        grbcurrentinfo.Text = "Current subscriber information"
        ' 
        ' txtEndDate
        ' 
        txtEndDate.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtEndDate.BorderStyle = BorderStyle.FixedSingle
        txtEndDate.ForeColor = Color.White
        txtEndDate.Location = New Point(119, 169)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.ReadOnly = True
        txtEndDate.Size = New Size(147, 23)
        txtEndDate.TabIndex = 3
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
        ' txtCurrentPlan
        ' 
        txtCurrentPlan.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtCurrentPlan.BorderStyle = BorderStyle.FixedSingle
        txtCurrentPlan.ForeColor = Color.White
        txtCurrentPlan.Location = New Point(119, 122)
        txtCurrentPlan.Name = "txtCurrentPlan"
        txtCurrentPlan.ReadOnly = True
        txtCurrentPlan.Size = New Size(147, 23)
        txtCurrentPlan.TabIndex = 2
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
        txtID.TabIndex = 0
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
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.ForeColor = Color.White
        txtFullName.Location = New Point(119, 73)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(147, 23)
        txtFullName.TabIndex = 1
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
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.Lime
        btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnConfirm.ForeColor = Color.White
        btnConfirm.Location = New Point(399, 395)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(146, 29)
        btnConfirm.TabIndex = 4
        btnConfirm.Text = "Confirm Freez"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' FreezSub
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnConfirm)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblusername)
        Controls.Add(btnCancel)
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
        CType(numFreezeDays, ComponentModel.ISupportInitialize).EndInit()
        grbcurrentinfo.ResumeLayout(False)
        grbcurrentinfo.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblusername As Label
    Friend WithEvents btnsavechanges As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grbfreezdetails As GroupBox
    Friend WithEvents dtpstartdate As DateTimePicker
    Friend WithEvents cmbsubplan As ComboBox
    Friend WithEvents numFreezeDays As NumericUpDown
    Friend WithEvents nudheight As NumericUpDown
    Friend WithEvents lblsubplan As Label
    Friend WithEvents lblfreezdays As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblfreezstartdate As Label
    Friend WithEvents grbcurrentinfo As GroupBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCurrentPlan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents dtpFreezeStart As DateTimePicker
    Friend WithEvents txtNewEndDate As TextBox
    Friend WithEvents btnConfirm As Button
End Class
