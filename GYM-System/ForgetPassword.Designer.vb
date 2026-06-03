<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgetPassword
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
        GroupBox1 = New GroupBox()
        txtconfnew = New TextBox()
        txtnewpass = New TextBox()
        txtusername = New TextBox()
        lblconfnew = New Label()
        lblnewpass = New Label()
        lblusername = New Label()
        btncancel = New Button()
        btnsave = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(txtconfnew)
        GroupBox1.Controls.Add(txtnewpass)
        GroupBox1.Controls.Add(txtusername)
        GroupBox1.Controls.Add(lblconfnew)
        GroupBox1.Controls.Add(lblnewpass)
        GroupBox1.Controls.Add(lblusername)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(5, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(369, 216)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Forget Password"
        ' 
        ' txtconfnew
        ' 
        txtconfnew.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtconfnew.BorderStyle = BorderStyle.FixedSingle
        txtconfnew.ForeColor = Color.White
        txtconfnew.Location = New Point(185, 137)
        txtconfnew.Name = "txtconfnew"
        txtconfnew.PasswordChar = "*"c
        txtconfnew.Size = New Size(153, 23)
        txtconfnew.TabIndex = 2
        ' 
        ' txtnewpass
        ' 
        txtnewpass.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtnewpass.BorderStyle = BorderStyle.FixedSingle
        txtnewpass.ForeColor = Color.White
        txtnewpass.Location = New Point(185, 91)
        txtnewpass.Name = "txtnewpass"
        txtnewpass.PasswordChar = "*"c
        txtnewpass.Size = New Size(153, 23)
        txtnewpass.TabIndex = 1
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.BorderStyle = BorderStyle.FixedSingle
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(185, 38)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(153, 23)
        txtusername.TabIndex = 0
        ' 
        ' lblconfnew
        ' 
        lblconfnew.AutoSize = True
        lblconfnew.Location = New Point(36, 140)
        lblconfnew.Name = "lblconfnew"
        lblconfnew.Size = New Size(131, 15)
        lblconfnew.TabIndex = 2
        lblconfnew.Text = "Confirm New Password"
        ' 
        ' lblnewpass
        ' 
        lblnewpass.AutoSize = True
        lblnewpass.Location = New Point(36, 94)
        lblnewpass.Name = "lblnewpass"
        lblnewpass.Size = New Size(84, 15)
        lblnewpass.TabIndex = 1
        lblnewpass.Text = "New Password"
        ' 
        ' lblusername
        ' 
        lblusername.AutoSize = True
        lblusername.Location = New Point(36, 41)
        lblusername.Name = "lblusername"
        lblusername.Size = New Size(62, 15)
        lblusername.TabIndex = 0
        lblusername.Text = "UserName"
        ' 
        ' btncancel
        ' 
        btncancel.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btncancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btncancel.FlatStyle = FlatStyle.Flat
        btncancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btncancel.ForeColor = Color.White
        btncancel.Location = New Point(48, 283)
        btncancel.Name = "btncancel"
        btncancel.Size = New Size(104, 29)
        btncancel.TabIndex = 1
        btncancel.Text = "Cancel"
        btncancel.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.LimeGreen
        btnsave.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnsave.FlatStyle = FlatStyle.Flat
        btnsave.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(202, 283)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(132, 29)
        btnsave.TabIndex = 0
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' ForgetPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        BackgroundImage = My.Resources.Resources.background
        ClientSize = New Size(386, 358)
        Controls.Add(btncancel)
        Controls.Add(btnsave)
        Controls.Add(GroupBox1)
        Name = "ForgetPassword"
        Text = "ForgetPassword"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtconfnew As TextBox
    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents lblconfnew As Label
    Friend WithEvents lblnewpass As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
End Class
