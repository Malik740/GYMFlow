<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershipPlans
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        lblview = New Label()
        dgvPlans = New DataGridView()
        PlanID = New DataGridViewTextBoxColumn()
        PlanName = New DataGridViewTextBoxColumn()
        durationplan = New DataGridViewTextBoxColumn()
        planprice = New DataGridViewTextBoxColumn()
        action = New DataGridViewButtonColumn()
        btnclose = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPlans, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.ForeColor = Color.Gray
        Label1.Location = New Point(179, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 19)
        Label1.TabIndex = 39
        Label1.Text = "View Gym Subscription Packages"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 95)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 38
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(299, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 28)
        Label2.TabIndex = 37
        Label2.Text = "Plans"
        ' 
        ' lblview
        ' 
        lblview.AutoSize = True
        lblview.BackColor = Color.Transparent
        lblview.Font = New Font("Segoe UI", 15F)
        lblview.ForeColor = Color.White
        lblview.Location = New Point(179, 12)
        lblview.Name = "lblview"
        lblview.Size = New Size(130, 28)
        lblview.TabIndex = 36
        lblview.Text = "MemberShip "
        ' 
        ' dgvPlans
        ' 
        dgvPlans.AllowUserToAddRows = False
        dgvPlans.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        DataGridViewCellStyle3.ForeColor = Color.White
        dgvPlans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        dgvPlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPlans.BackgroundColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle4.Font = New Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Lime
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvPlans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPlans.Columns.AddRange(New DataGridViewColumn() {PlanID, PlanName, durationplan, planprice, action})
        dgvPlans.EnableHeadersVisualStyles = False
        dgvPlans.GridColor = Color.DarkGreen
        dgvPlans.Location = New Point(54, 111)
        dgvPlans.Name = "dgvPlans"
        dgvPlans.ReadOnly = True
        dgvPlans.RowHeadersVisible = False
        dgvPlans.Size = New Size(688, 229)
        dgvPlans.TabIndex = 40
        ' 
        ' PlanID
        ' 
        PlanID.HeaderText = "Plan ID"
        PlanID.Name = "PlanID"
        PlanID.ReadOnly = True
        ' 
        ' PlanName
        ' 
        PlanName.HeaderText = "Plan Name"
        PlanName.Name = "PlanName"
        PlanName.ReadOnly = True
        ' 
        ' durationplan
        ' 
        durationplan.HeaderText = "Duration"
        durationplan.Name = "durationplan"
        durationplan.ReadOnly = True
        ' 
        ' planprice
        ' 
        planprice.HeaderText = "Price (JD)"
        planprice.Name = "planprice"
        planprice.ReadOnly = True
        ' 
        ' action
        ' 
        action.HeaderText = "Action"
        action.Name = "action"
        action.ReadOnly = True
        ' 
        ' btnclose
        ' 
        btnclose.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnclose.FlatAppearance.BorderColor = Color.FromArgb(CByte(32), CByte(219), CByte(69))
        btnclose.FlatStyle = FlatStyle.Flat
        btnclose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnclose.ForeColor = Color.White
        btnclose.Location = New Point(357, 358)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(104, 29)
        btnclose.TabIndex = 53
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = False
        ' 
        ' MembershipPlans
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 422)
        Controls.Add(btnclose)
        Controls.Add(dgvPlans)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(lblview)
        Name = "MembershipPlans"
        Text = "MembershipPlans"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPlans, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblview As Label
    Friend WithEvents dgvPlans As DataGridView
    Friend WithEvents PlanID As DataGridViewTextBoxColumn
    Friend WithEvents PlanName As DataGridViewTextBoxColumn
    Friend WithEvents durationplan As DataGridViewTextBoxColumn
    Friend WithEvents planprice As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
    Friend WithEvents btnclose As Button
End Class
