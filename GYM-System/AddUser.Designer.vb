<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Label3 = New Label()
        lblfullname = New Label()
        lblgender = New Label()
        lbldate = New Label()
        lblphone = New Label()
        lblemail = New Label()
        lbllocation = New Label()
        lblplan = New Label()
        lblfee = New Label()
        lblnote = New Label()
        txtfullname = New TextBox()
        rdbmale = New RadioButton()
        rdbfemale = New RadioButton()
        Label4 = New Label()
        Label5 = New Label()
        dtpBirthDate = New DateTimePicker()
        mskphone = New MaskedTextBox()
        txtemail = New TextBox()
        txtlocation = New TextBox()
        cmbplan = New ComboBox()
        txtsal = New TextBox()
        txtnote = New TextBox()
        btnsavemember = New Button()
        btnreset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(383, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 37)
        Label1.TabIndex = 0
        Label1.Text = "ADD User"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label2.ForeColor = Color.LimeGreen
        Label2.Location = New Point(519, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 37)
        Label2.TabIndex = 1
        Label2.Text = "TO GYM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(383, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 20)
        Label3.TabIndex = 2
        Label3.Text = "Register new member"
        ' 
        ' lblfullname
        ' 
        lblfullname.AutoSize = True
        lblfullname.BackColor = Color.Transparent
        lblfullname.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblfullname.ForeColor = Color.White
        lblfullname.Location = New Point(396, 105)
        lblfullname.Name = "lblfullname"
        lblfullname.Size = New Size(62, 15)
        lblfullname.TabIndex = 3
        lblfullname.Text = "Full Name"
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.BackColor = Color.Transparent
        lblgender.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblgender.ForeColor = Color.White
        lblgender.Location = New Point(396, 144)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(48, 15)
        lblgender.TabIndex = 4
        lblgender.Text = "Gender"
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.BackColor = Color.Transparent
        lbldate.Font = New Font("Arial", 9F, FontStyle.Bold)
        lbldate.ForeColor = Color.White
        lbldate.Location = New Point(396, 182)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(77, 15)
        lbldate.TabIndex = 5
        lbldate.Text = "Date of Birth"
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.BackColor = Color.Transparent
        lblphone.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblphone.ForeColor = Color.White
        lblphone.Location = New Point(396, 220)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(91, 15)
        lblphone.TabIndex = 6
        lblphone.Text = "Phone Number"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.BackColor = Color.Transparent
        lblemail.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblemail.ForeColor = Color.White
        lblemail.Location = New Point(396, 257)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(38, 15)
        lblemail.TabIndex = 7
        lblemail.Text = "Email"
        ' 
        ' lbllocation
        ' 
        lbllocation.AutoSize = True
        lbllocation.BackColor = Color.Transparent
        lbllocation.Font = New Font("Arial", 9F, FontStyle.Bold)
        lbllocation.ForeColor = Color.White
        lbllocation.Location = New Point(396, 295)
        lbllocation.Name = "lbllocation"
        lbllocation.Size = New Size(56, 15)
        lbllocation.TabIndex = 8
        lbllocation.Text = "Location"
        ' 
        ' lblplan
        ' 
        lblplan.AutoSize = True
        lblplan.BackColor = Color.Transparent
        lblplan.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblplan.ForeColor = Color.White
        lblplan.Location = New Point(396, 331)
        lblplan.Name = "lblplan"
        lblplan.Size = New Size(66, 15)
        lblplan.TabIndex = 9
        lblplan.Text = "User sheft"
        ' 
        ' lblfee
        ' 
        lblfee.AutoSize = True
        lblfee.BackColor = Color.Transparent
        lblfee.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblfee.ForeColor = Color.White
        lblfee.Location = New Point(396, 373)
        lblfee.Name = "lblfee"
        lblfee.Size = New Size(72, 15)
        lblfee.TabIndex = 10
        lblfee.Text = "User salary"
        ' 
        ' lblnote
        ' 
        lblnote.AutoSize = True
        lblnote.BackColor = Color.Transparent
        lblnote.Font = New Font("Arial", 9F, FontStyle.Bold)
        lblnote.ForeColor = Color.White
        lblnote.Location = New Point(396, 411)
        lblnote.Name = "lblnote"
        lblnote.Size = New Size(89, 15)
        lblnote.TabIndex = 11
        lblnote.Text = "Note (optional)"
        ' 
        ' txtfullname
        ' 
        txtfullname.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtfullname.BorderStyle = BorderStyle.FixedSingle
        txtfullname.ForeColor = SystemColors.Info
        txtfullname.Location = New Point(510, 98)
        txtfullname.Multiline = True
        txtfullname.Name = "txtfullname"
        txtfullname.PlaceholderText = "Enter full name"
        txtfullname.Size = New Size(198, 23)
        txtfullname.TabIndex = 0
        ' 
        ' rdbmale
        ' 
        rdbmale.BackColor = Color.Transparent
        rdbmale.Checked = True
        rdbmale.FlatStyle = FlatStyle.System
        rdbmale.Font = New Font("Segoe UI", 11F)
        rdbmale.ForeColor = Color.White
        rdbmale.Location = New Point(508, 138)
        rdbmale.Name = "rdbmale"
        rdbmale.Size = New Size(66, 25)
        rdbmale.TabIndex = 13
        rdbmale.TabStop = True
        rdbmale.TextAlign = ContentAlignment.MiddleCenter
        rdbmale.UseVisualStyleBackColor = False
        ' 
        ' rdbfemale
        ' 
        rdbfemale.BackColor = Color.Transparent
        rdbfemale.FlatStyle = FlatStyle.System
        rdbfemale.Font = New Font("Segoe UI", 11F)
        rdbfemale.ForeColor = Color.White
        rdbfemale.Location = New Point(627, 140)
        rdbfemale.Name = "rdbfemale"
        rdbfemale.Size = New Size(81, 25)
        rdbfemale.TabIndex = 2
        rdbfemale.TextAlign = ContentAlignment.MiddleCenter
        rdbfemale.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(532, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 19)
        Label4.TabIndex = 1
        Label4.Text = "Male"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label5.Location = New Point(649, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 20)
        Label5.TabIndex = 2
        Label5.Text = "Female"
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.CalendarForeColor = Color.Transparent
        dtpBirthDate.CalendarMonthBackground = Color.Transparent
        dtpBirthDate.CalendarTitleBackColor = Color.Transparent
        dtpBirthDate.CalendarTitleForeColor = Color.Transparent
        dtpBirthDate.CalendarTrailingForeColor = Color.Transparent
        dtpBirthDate.Location = New Point(510, 175)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(200, 23)
        dtpBirthDate.TabIndex = 3
        ' 
        ' mskphone
        ' 
        mskphone.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        mskphone.BorderStyle = BorderStyle.None
        mskphone.ForeColor = SystemColors.Info
        mskphone.Location = New Point(510, 220)
        mskphone.Mask = "000-000-0000"
        mskphone.Name = "mskphone"
        mskphone.Size = New Size(202, 16)
        mskphone.TabIndex = 4
        mskphone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtemail.BorderStyle = BorderStyle.None
        txtemail.ForeColor = SystemColors.Info
        txtemail.Location = New Point(510, 257)
        txtemail.Name = "txtemail"
        txtemail.PlaceholderText = "Enter the Email"
        txtemail.Size = New Size(200, 16)
        txtemail.TabIndex = 5
        ' 
        ' txtlocation
        ' 
        txtlocation.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtlocation.BorderStyle = BorderStyle.None
        txtlocation.ForeColor = SystemColors.Info
        txtlocation.Location = New Point(508, 295)
        txtlocation.Name = "txtlocation"
        txtlocation.PlaceholderText = "Enter the Location"
        txtlocation.Size = New Size(200, 16)
        txtlocation.TabIndex = 6
        ' 
        ' cmbplan
        ' 
        cmbplan.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        cmbplan.FlatStyle = FlatStyle.Flat
        cmbplan.ForeColor = Color.White
        cmbplan.FormattingEnabled = True
        cmbplan.Location = New Point(508, 323)
        cmbplan.Name = "cmbplan"
        cmbplan.Size = New Size(202, 23)
        cmbplan.TabIndex = 7
        ' 
        ' txtsal
        ' 
        txtsal.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtsal.BorderStyle = BorderStyle.None
        txtsal.ForeColor = SystemColors.Info
        txtsal.Location = New Point(508, 372)
        txtsal.Name = "txtsal"
        txtsal.PlaceholderText = "Enter the Regetration Fee"
        txtsal.Size = New Size(200, 16)
        txtsal.TabIndex = 8
        ' 
        ' txtnote
        ' 
        txtnote.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtnote.BorderStyle = BorderStyle.None
        txtnote.ForeColor = SystemColors.Info
        txtnote.Location = New Point(508, 411)
        txtnote.Multiline = True
        txtnote.Name = "txtnote"
        txtnote.PlaceholderText = "Add any additional notes..."
        txtnote.Size = New Size(200, 40)
        txtnote.TabIndex = 9
        ' 
        ' btnsavemember
        ' 
        btnsavemember.BackColor = Color.LimeGreen
        btnsavemember.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnsavemember.FlatStyle = FlatStyle.Flat
        btnsavemember.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsavemember.ForeColor = Color.White
        btnsavemember.Location = New Point(587, 468)
        btnsavemember.Name = "btnsavemember"
        btnsavemember.Size = New Size(132, 29)
        btnsavemember.TabIndex = 10
        btnsavemember.Text = "Save Member"
        btnsavemember.UseVisualStyleBackColor = False
        ' 
        ' btnreset
        ' 
        btnreset.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnreset.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnreset.FlatStyle = FlatStyle.Flat
        btnreset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnreset.ForeColor = Color.White
        btnreset.Location = New Point(433, 468)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(104, 29)
        btnreset.TabIndex = 11
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = False
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Add_People_Form__2_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 532)
        Controls.Add(btnreset)
        Controls.Add(btnsavemember)
        Controls.Add(txtnote)
        Controls.Add(txtsal)
        Controls.Add(cmbplan)
        Controls.Add(txtlocation)
        Controls.Add(txtemail)
        Controls.Add(mskphone)
        Controls.Add(dtpBirthDate)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(rdbfemale)
        Controls.Add(rdbmale)
        Controls.Add(txtfullname)
        Controls.Add(lblnote)
        Controls.Add(lblfee)
        Controls.Add(lblplan)
        Controls.Add(lbllocation)
        Controls.Add(lblemail)
        Controls.Add(lblphone)
        Controls.Add(lbldate)
        Controls.Add(lblgender)
        Controls.Add(lblfullname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlLightLight
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "AddUser"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblfullname As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblphone As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lbllocation As Label
    Friend WithEvents lblplan As Label
    Friend WithEvents lblfee As Label
    Friend WithEvents lblnote As Label
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents rdbmale As RadioButton
    Friend WithEvents rdbfemale As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents mskphone As MaskedTextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtlocation As TextBox
    Friend WithEvents cmbplan As ComboBox
    Friend WithEvents txtsal As TextBox
    Friend WithEvents txtnote As TextBox
    Friend WithEvents btnsavemember As Button
    Friend WithEvents btnreset As Button
End Class
