<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        lblFname = New Label()
        Label2 = New Label()
        lblPhoneNO = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(801, 449)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(447, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(447, 197)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.WhiteSmoke
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(447, 160)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(164, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.WhiteSmoke
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(447, 123)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(164, 23)
        TextBox4.TabIndex = 4
        ' 
        ' lblFname
        ' 
        lblFname.AutoSize = True
        lblFname.BackColor = Color.Transparent
        lblFname.Location = New Point(347, 90)
        lblFname.Name = "lblFname"
        lblFname.Size = New Size(64, 15)
        lblFname.TabIndex = 5
        lblFname.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.DimGray
        Label2.Location = New Point(347, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 6
        Label2.Text = "LastName"
        ' 
        ' lblPhoneNO
        ' 
        lblPhoneNO.AutoSize = True
        lblPhoneNO.BackColor = Color.DimGray
        lblPhoneNO.Location = New Point(347, 163)
        lblPhoneNO.Name = "lblPhoneNO"
        lblPhoneNO.Size = New Size(85, 15)
        lblPhoneNO.TabIndex = 7
        lblPhoneNO.Text = "PhoneNumber"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DimGray
        Label3.Location = New Point(357, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(lblPhoneNO)
        Controls.Add(Label2)
        Controls.Add(lblFname)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblFname As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPhoneNO As Label
    Friend WithEvents Label3 As Label
End Class
