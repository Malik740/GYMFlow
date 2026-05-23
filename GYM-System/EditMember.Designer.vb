<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMember
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
        btnsavechanges = New Button()
        nudheight = New NumericUpDown()
        lblsubplan = New Label()
        lblweight = New Label()
        Label5 = New Label()
        lblheight = New Label()
        rbfemale = New RadioButton()
        rbmale = New RadioButton()
        mskphone = New MaskedTextBox()
        lblphone = New Label()
        lblgender = New Label()
        dtpstartdate = New DateTimePicker()
        cmbsubplan = New ComboBox()
        nudweight = New NumericUpDown()
        txtfullname = New TextBox()
        lblfullname = New Label()
        btncancel = New Button()
        GroupBox1 = New GroupBox()
        grpuserinfo = New GroupBox()
        txtID = New TextBox()
        lblID = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblview = New Label()
        lblusername = New Label()
        txtusername = New TextBox()
        btnsearch = New Button()
        CType(nudheight, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudweight, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        grpuserinfo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnsavechanges
        ' 
        btnsavechanges.BackColor = Color.LimeGreen
        btnsavechanges.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnsavechanges.FlatStyle = FlatStyle.Flat
        btnsavechanges.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsavechanges.ForeColor = Color.White
        btnsavechanges.Location = New Point(417, 393)
        btnsavechanges.Name = "btnsavechanges"
        btnsavechanges.Size = New Size(132, 29)
        btnsavechanges.TabIndex = 35
        btnsavechanges.Text = "Save Changes"
        btnsavechanges.UseVisualStyleBackColor = False
        ' 
        ' nudheight
        ' 
        nudheight.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        nudheight.BorderStyle = BorderStyle.FixedSingle
        nudheight.ForeColor = Color.White
        nudheight.Location = New Point(147, 28)
        nudheight.Name = "nudheight"
        nudheight.Size = New Size(151, 23)
        nudheight.TabIndex = 21
        ' 
        ' lblsubplan
        ' 
        lblsubplan.AutoSize = True
        lblsubplan.BackColor = Color.Transparent
        lblsubplan.Font = New Font("Arial", 9F)
        lblsubplan.ForeColor = Color.Lime
        lblsubplan.Location = New Point(22, 113)
        lblsubplan.Name = "lblsubplan"
        lblsubplan.Size = New Size(104, 15)
        lblsubplan.TabIndex = 20
        lblsubplan.Text = "Subscription Plan"
        ' 
        ' lblweight
        ' 
        lblweight.AutoSize = True
        lblweight.BackColor = Color.Transparent
        lblweight.Font = New Font("Arial", 9F)
        lblweight.ForeColor = Color.Lime
        lblweight.Location = New Point(22, 76)
        lblweight.Name = "lblweight"
        lblweight.Size = New Size(69, 15)
        lblweight.TabIndex = 19
        lblweight.Text = "Weight (kg)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Lime
        Label5.Location = New Point(22, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 2
        Label5.Text = "Start Date"
        ' 
        ' lblheight
        ' 
        lblheight.AutoSize = True
        lblheight.ForeColor = Color.Lime
        lblheight.Location = New Point(22, 36)
        lblheight.Name = "lblheight"
        lblheight.Size = New Size(71, 15)
        lblheight.TabIndex = 0
        lblheight.Text = "Height (cm)"
        ' 
        ' rbfemale
        ' 
        rbfemale.AutoSize = True
        rbfemale.Location = New Point(215, 169)
        rbfemale.Name = "rbfemale"
        rbfemale.Size = New Size(63, 19)
        rbfemale.TabIndex = 22
        rbfemale.Text = "Female"
        rbfemale.UseVisualStyleBackColor = True
        ' 
        ' rbmale
        ' 
        rbmale.AutoSize = True
        rbmale.Checked = True
        rbmale.Location = New Point(119, 169)
        rbmale.Name = "rbmale"
        rbmale.Size = New Size(51, 19)
        rbmale.TabIndex = 21
        rbmale.TabStop = True
        rbmale.Text = "Male"
        rbmale.UseVisualStyleBackColor = True
        ' 
        ' mskphone
        ' 
        mskphone.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        mskphone.BorderStyle = BorderStyle.None
        mskphone.ForeColor = Color.White
        mskphone.Location = New Point(119, 115)
        mskphone.Mask = "000-000-0000"
        mskphone.Name = "mskphone"
        mskphone.Size = New Size(147, 16)
        mskphone.TabIndex = 20
        mskphone.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.BackColor = Color.Transparent
        lblphone.Font = New Font("Arial", 9F)
        lblphone.ForeColor = Color.Lime
        lblphone.Location = New Point(19, 116)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(91, 15)
        lblphone.TabIndex = 19
        lblphone.Text = "Phone Number"
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.ForeColor = Color.Lime
        lblgender.Location = New Point(19, 173)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(45, 15)
        lblgender.TabIndex = 2
        lblgender.Text = "Gender"
        ' 
        ' dtpstartdate
        ' 
        dtpstartdate.Location = New Point(86, 152)
        dtpstartdate.Name = "dtpstartdate"
        dtpstartdate.Size = New Size(212, 23)
        dtpstartdate.TabIndex = 24
        ' 
        ' cmbsubplan
        ' 
        cmbsubplan.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        cmbsubplan.ForeColor = Color.White
        cmbsubplan.FormattingEnabled = True
        cmbsubplan.Location = New Point(147, 105)
        cmbsubplan.Name = "cmbsubplan"
        cmbsubplan.Size = New Size(151, 23)
        cmbsubplan.TabIndex = 23
        ' 
        ' nudweight
        ' 
        nudweight.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        nudweight.BorderStyle = BorderStyle.FixedSingle
        nudweight.ForeColor = Color.White
        nudweight.Location = New Point(147, 68)
        nudweight.Name = "nudweight"
        nudweight.Size = New Size(151, 23)
        nudweight.TabIndex = 22
        ' 
        ' txtfullname
        ' 
        txtfullname.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtfullname.BorderStyle = BorderStyle.FixedSingle
        txtfullname.ForeColor = Color.White
        txtfullname.Location = New Point(119, 73)
        txtfullname.Name = "txtfullname"
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
        ' btncancel
        ' 
        btncancel.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btncancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncancel.ForeColor = Color.White
        btncancel.Location = New Point(263, 393)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(104, 29)
        btncancel.TabIndex = 36
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(dtpstartdate)
        GroupBox1.Controls.Add(cmbsubplan)
        GroupBox1.Controls.Add(nudweight)
        GroupBox1.Controls.Add(nudheight)
        GroupBox1.Controls.Add(lblsubplan)
        GroupBox1.Controls.Add(lblweight)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(lblheight)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(456, 129)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 220)
        GroupBox1.TabIndex = 34
        GroupBox1.TabStop = False
        GroupBox1.Text = "Body indicators and subscription"
        ' 
        ' grpuserinfo
        ' 
        grpuserinfo.BackColor = Color.Transparent
        grpuserinfo.Controls.Add(txtID)
        grpuserinfo.Controls.Add(lblID)
        grpuserinfo.Controls.Add(rbfemale)
        grpuserinfo.Controls.Add(rbmale)
        grpuserinfo.Controls.Add(mskphone)
        grpuserinfo.Controls.Add(lblphone)
        grpuserinfo.Controls.Add(lblgender)
        grpuserinfo.Controls.Add(txtfullname)
        grpuserinfo.Controls.Add(lblfullname)
        grpuserinfo.ForeColor = Color.White
        grpuserinfo.Location = New Point(49, 129)
        grpuserinfo.Name = "grpuserinfo"
        grpuserinfo.Size = New Size(334, 220)
        grpuserinfo.TabIndex = 33
        grpuserinfo.TabStop = False
        grpuserinfo.Text = "Member Information"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(179, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 19)
        Label1.TabIndex = 31
        Label1.Text = "Update Existing Member Information"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(0, -5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(224, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 29
        Label2.Text = "Members"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(179, 9)
        lblview.Name = "lblview"
        lblview.Size = New Size(46, 28)
        lblview.TabIndex = 28
        lblview.Text = "Edit"
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.BackColor = Color.Transparent
        lblusername.Font = New Font("Segoe UI", 10F)
        lblusername.ForeColor = Color.White
        lblusername.Location = New Point(230, 81)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(165, 19)
        lblusername.TabIndex = 37
        lblusername.Text = "Enter Member UserName"
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(411, 77)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(201, 23)
        txtusername.TabIndex = 38
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
        btnsearch.Location = New Point(652, 77)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(90, 23)
        btnsearch.TabIndex = 39
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' EditMember
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnsearch)
        Controls.Add(txtusername)
        Controls.Add(lblusername)
        Controls.Add(btnsavechanges)
        Controls.Add(btncancel)
        Controls.Add(GroupBox1)
        Controls.Add(grpuserinfo)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        DoubleBuffered = True
        Name = "EditMember"
        Text = "EditMember"
        CType(nudheight, ComponentModel.ISupportInitialize).EndInit()
        CType(nudweight, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpuserinfo.ResumeLayout(False)
        grpuserinfo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnsavechanges As Button
    Friend WithEvents nudheight As NumericUpDown
    Friend WithEvents lblsubplan As Label
    Friend WithEvents lblweight As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblheight As Label
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents mskphone As MaskedTextBox
    Friend WithEvents lblphone As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents dtpstartdate As DateTimePicker
    Friend WithEvents cmbsubplan As ComboBox
    Friend WithEvents nudweight As NumericUpDown
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpuserinfo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
End Class
