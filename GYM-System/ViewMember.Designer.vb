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
        btnSearch = New Button()
        txtSearch = New TextBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblview = New Label()
        dgvMembers = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMembers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 11F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(475, 83)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(96, 32)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(180, 90)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "  Search by Name, ID or Phone..."
        txtSearch.Size = New Size(275, 23)
        txtSearch.TabIndex = 0
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
        ' dgvMembers
        ' 
        dgvMembers.AllowUserToAddRows = False
        dgvMembers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        DataGridViewCellStyle1.ForeColor = Color.White
        dgvMembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMembers.BackgroundColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Font = New Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Lime
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMembers.EnableHeadersVisualStyles = False
        dgvMembers.GridColor = Color.DarkGreen
        dgvMembers.Location = New Point(57, 135)
        dgvMembers.Name = "dgvMembers"
        dgvMembers.ReadOnly = True
        dgvMembers.RowHeadersVisible = False
        dgvMembers.Size = New Size(688, 303)
        dgvMembers.TabIndex = 2
        ' 
        ' ViewMember
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(dgvMembers)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        Name = "ViewMember"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMembers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents dgvMembers As DataGridView
End Class
