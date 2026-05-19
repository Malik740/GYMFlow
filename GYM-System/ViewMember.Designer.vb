<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMember
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
        btndelete = New Button()
        txtusername = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblview = New Label()
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Name = New DataGridViewTextBoxColumn()
        Phone = New DataGridViewTextBoxColumn()
        Plan = New DataGridViewTextBoxColumn()
        EndDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btndelete.FlatAppearance.BorderColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Segoe UI", 11F)
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(475, 83)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(96, 32)
        btndelete.TabIndex = 14
        btndelete.Text = "Search"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtusername.ForeColor = Color.White
        txtusername.Location = New Point(180, 90)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Search by Name, ID or Phone..."
        txtusername.Size = New Size(275, 23)
        txtusername.TabIndex = 12
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(230, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 10
        Label2.Text = "Members"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(180, 21)
        lblview.Name = "lblview"
        lblview.Size = New Size(53, 28)
        lblview.TabIndex = 9
        lblview.Text = "View"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Font = New Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Lime
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Name, Phone, Plan, EndDate, Status})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.DarkGreen
        DataGridView1.Location = New Point(57, 135)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(688, 303)
        DataGridView1.TabIndex = 15
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ' 
        ' Name
        ' 
        Name.HeaderText = "Name"
        Name.Name = "Name"
        Name.ReadOnly = True
        ' 
        ' Phone
        ' 
        Phone.HeaderText = "Phone"
        Phone.Name = "Phone"
        Phone.ReadOnly = True
        ' 
        ' Plan
        ' 
        Plan.HeaderText = "Plan"
        Plan.Name = "Plan"
        Plan.ReadOnly = True
        ' 
        ' EndDate
        ' 
        EndDate.HeaderText = "EndDate"
        EndDate.Name = "EndDate"
        EndDate.ReadOnly = True
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        ' 
        ' ViewMember
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btndelete)
        Controls.Add(txtusername)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)

        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btndelete As Button
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Phone As DataGridViewTextBoxColumn
    Friend WithEvents Plan As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
