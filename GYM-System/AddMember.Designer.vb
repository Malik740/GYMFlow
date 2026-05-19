<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
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
        Label2 = New Label()
        lblview = New Label()
        Label1 = New Label()
        Label3 = New Label()
        grpuserinfo = New GroupBox()
        mskphone = New MaskedTextBox()
        lblphone = New Label()
        lblgender = New Label()
        txtfullname = New TextBox()
        lblfullname = New Label()
        GroupBox1 = New GroupBox()
        lblsubplan = New Label()
        lblweight = New Label()
        Label5 = New Label()
        lblheight = New Label()
        nudheight = New NumericUpDown()
        nudweight = New NumericUpDown()
        cmbsubplan = New ComboBox()
        dtpstartdate = New DateTimePicker()
        rbmale = New RadioButton()
        rbfemale = New RadioButton()
        btnclear = New Button()
        btnsavemember = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        grpuserinfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(nudheight, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudweight, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(225, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 13
        Label2.Text = "Members"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(180, 12)
        lblview.Name = "lblview"
        lblview.Size = New Size(49, 28)
        lblview.TabIndex = 12
        lblview.Text = "Add"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(180, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 19)
        Label1.TabIndex = 15
        Label1.Text = "Add New Member To Gym"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(346, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 19)
        Label3.TabIndex = 16
        Label3.Text = "Flow"
        ' 
        ' grpuserinfo
        ' 
        grpuserinfo.BackColor = Color.Transparent
        grpuserinfo.Controls.Add(rbfemale)
        grpuserinfo.Controls.Add(rbmale)
        grpuserinfo.Controls.Add(mskphone)
        grpuserinfo.Controls.Add(lblphone)
        grpuserinfo.Controls.Add(lblgender)
        grpuserinfo.Controls.Add(txtfullname)
        grpuserinfo.Controls.Add(lblfullname)
        grpuserinfo.ForeColor = Color.White
        grpuserinfo.Location = New Point(38, 100)
        grpuserinfo.Name = "grpuserinfo"
        grpuserinfo.Size = New Size(334, 220)
        grpuserinfo.TabIndex = 17
        grpuserinfo.TabStop = False
        grpuserinfo.Text = "Member Information"
        ' 
        ' mskphone
        ' 
        mskphone.BackColor = Color.White
        mskphone.BorderStyle = BorderStyle.None
        mskphone.ForeColor = Color.Black
        mskphone.Location = New Point(122, 75)
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
        lblphone.Location = New Point(22, 76)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(91, 15)
        lblphone.TabIndex = 19
        lblphone.Text = "Phone Number"
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.ForeColor = Color.Lime
        lblgender.Location = New Point(22, 133)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(45, 15)
        lblgender.TabIndex = 2
        lblgender.Text = "Gender"
        ' 
        ' txtfullname
        ' 
        txtfullname.ForeColor = Color.Black
        txtfullname.Location = New Point(122, 33)
        txtfullname.Name = "txtfullname"
        txtfullname.Size = New Size(147, 23)
        txtfullname.TabIndex = 1
        ' 
        ' lblfullname
        ' 
        lblfullname.AutoSize = True
        lblfullname.ForeColor = Color.Lime
        lblfullname.Location = New Point(22, 36)
        lblfullname.Name = "lblfullname"
        lblfullname.Size = New Size(61, 15)
        lblfullname.TabIndex = 0
        lblfullname.Text = "Full Name"
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
        GroupBox1.Location = New Point(445, 100)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 220)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Body indicators and subscription"
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
        ' nudheight
        ' 
        nudheight.Location = New Point(147, 28)
        nudheight.Name = "nudheight"
        nudheight.Size = New Size(151, 23)
        nudheight.TabIndex = 21
        ' 
        ' nudweight
        ' 
        nudweight.Location = New Point(147, 68)
        nudweight.Name = "nudweight"
        nudweight.Size = New Size(151, 23)
        nudweight.TabIndex = 22
        ' 
        ' cmbsubplan
        ' 
        cmbsubplan.FormattingEnabled = True
        cmbsubplan.Location = New Point(147, 105)
        cmbsubplan.Name = "cmbsubplan"
        cmbsubplan.Size = New Size(151, 23)
        cmbsubplan.TabIndex = 23
        ' 
        ' dtpstartdate
        ' 
        dtpstartdate.Location = New Point(86, 152)
        dtpstartdate.Name = "dtpstartdate"
        dtpstartdate.Size = New Size(212, 23)
        dtpstartdate.TabIndex = 24
        ' 
        ' rbmale
        ' 
        rbmale.AutoSize = True
        rbmale.Checked = True
        rbmale.Location = New Point(122, 129)
        rbmale.Name = "rbmale"
        rbmale.Size = New Size(51, 19)
        rbmale.TabIndex = 21
        rbmale.TabStop = True
        rbmale.Text = "Male"
        rbmale.UseVisualStyleBackColor = True
        ' 
        ' rbfemale
        ' 
        rbfemale.AutoSize = True
        rbfemale.Location = New Point(218, 129)
        rbfemale.Name = "rbfemale"
        rbfemale.Size = New Size(63, 19)
        rbfemale.TabIndex = 22
        rbfemale.Text = "Female"
        rbfemale.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnclear.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnclear.FlatStyle = FlatStyle.Flat
        btnclear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclear.ForeColor = Color.White
        btnclear.Location = New Point(252, 364)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(104, 29)
        btnclear.TabIndex = 27
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsavemember
        ' 
        btnsavemember.BackColor = Color.LimeGreen
        btnsavemember.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnsavemember.FlatStyle = FlatStyle.Flat
        btnsavemember.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsavemember.ForeColor = Color.White
        btnsavemember.Location = New Point(406, 364)
        btnsavemember.Name = "btnsavemember"
        btnsavemember.Size = New Size(132, 29)
        btnsavemember.TabIndex = 26
        btnsavemember.Text = "Add Member"
        btnsavemember.UseVisualStyleBackColor = False
        ' 
        ' AddMember
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnclear)
        Controls.Add(btnsavemember)
        Controls.Add(GroupBox1)
        Controls.Add(grpuserinfo)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        DoubleBuffered = True
        Name = "AddMember"
        Text = "AddMember"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        grpuserinfo.ResumeLayout(False)
        grpuserinfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(nudheight, ComponentModel.ISupportInitialize).EndInit()
        CType(nudweight, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpuserinfo As GroupBox
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents mskphone As MaskedTextBox
    Friend WithEvents lblphone As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblweight As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblheight As Label
    Friend WithEvents lblsubplan As Label
    Friend WithEvents dtpstartdate As DateTimePicker
    Friend WithEvents cmbsubplan As ComboBox
    Friend WithEvents nudweight As NumericUpDown
    Friend WithEvents nudheight As NumericUpDown
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsavemember As Button
End Class
