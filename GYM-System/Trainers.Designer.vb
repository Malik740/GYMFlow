<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trainers
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvTrainers = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblview = New Label()
        Label2 = New Label()
        TrainerID = New DataGridViewTextBoxColumn()
        TrainerName = New DataGridViewTextBoxColumn()
        TrainerSpecialty = New DataGridViewTextBoxColumn()
        TrainerSalary = New DataGridViewTextBoxColumn()
        btnclose = New Button()
        CType(dgvTrainers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTrainers
        ' 
        dgvTrainers.AllowUserToAddRows = False
        dgvTrainers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        DataGridViewCellStyle1.ForeColor = Color.White
        dgvTrainers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTrainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTrainers.BackgroundColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Font = New Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Lime
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTrainers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTrainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrainers.Columns.AddRange(New DataGridViewColumn() {TrainerID, TrainerName, TrainerSpecialty, TrainerSalary})
        dgvTrainers.EnableHeadersVisualStyles = False
        dgvTrainers.GridColor = Color.DarkGreen
        dgvTrainers.Location = New Point(88, 100)
        dgvTrainers.Name = "dgvTrainers"
        dgvTrainers.ReadOnly = True
        dgvTrainers.RowHeadersVisible = False
        dgvTrainers.Size = New Size(629, 263)
        dgvTrainers.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(175, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 19)
        Label1.TabIndex = 42
        Label1.Text = "Manage Gym Instructors & Staff"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(-4, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(175, 13)
        lblview.Name = "lblview"
        lblview.Size = New Size(107, 28)
        lblview.TabIndex = 40
        lblview.Text = "GYMFLOW"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(275, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 28)
        Label2.TabIndex = 43
        Label2.Text = "TRAINERS"
        ' 
        ' TrainerID
        ' 
        TrainerID.HeaderText = "Trainer ID"
        TrainerID.Name = "TrainerID"
        TrainerID.ReadOnly = True
        ' 
        ' TrainerName
        ' 
        TrainerName.HeaderText = "Trainer Name"
        TrainerName.Name = "TrainerName"
        TrainerName.ReadOnly = True
        ' 
        ' TrainerSpecialty
        ' 
        TrainerSpecialty.HeaderText = "Specialty"
        TrainerSpecialty.Name = "TrainerSpecialty"
        TrainerSpecialty.ReadOnly = True
        ' 
        ' TrainerSalary
        ' 
        TrainerSalary.HeaderText = "Salary"
        TrainerSalary.Name = "TrainerSalary"
        TrainerSalary.ReadOnly = True
        ' 
        ' btnclose
        ' 
        btnclose.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnclose.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclose.ForeColor = Color.White
        btnclose.Location = New Point(359, 369)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(104, 29)
        btnclose.TabIndex = 52
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' Trainers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(766, 432)
        Controls.Add(btnclose)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(lblview)
        Controls.Add(dgvTrainers)
        Name = "Trainers"
        Text = "Trainers"
        CType(dgvTrainers, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTrainers As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblview As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrainerID As DataGridViewTextBoxColumn
    Friend WithEvents TrainerName As DataGridViewTextBoxColumn
    Friend WithEvents TrainerSpecialty As DataGridViewTextBoxColumn
    Friend WithEvents TrainerSalary As DataGridViewTextBoxColumn
    Friend WithEvents btnclose As Button
End Class
