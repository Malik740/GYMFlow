<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoard
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label3 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        addnewusertool = New ToolStripMenuItem()
        changeuserinfotool = New ToolStripMenuItem()
        DeleteUserToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        ViewMemberToolStripMenuItem = New ToolStripMenuItem()
        AddMemberToolStripMenuItem = New ToolStripMenuItem()
        EditMemberToolStripMenuItem = New ToolStripMenuItem()
        FreezSubscriptionToolStripMenuItem = New ToolStripMenuItem()
        TrainerToolStripMenuItem = New ToolStripMenuItem()
        ViewTrainersToolStripMenuItem = New ToolStripMenuItem()
        PlansToolStripMenuItem = New ToolStripMenuItem()
        PlansToolStripMenuItem1 = New ToolStripMenuItem()
        AshfjahToolStripMenuItem = New ToolStripMenuItem()
        TakeAttendanceToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ViewProductsToolStripMenuItem = New ToolStripMenuItem()
        TESTToolStripMenuItem2 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        btnlogout = New Button()
        lblname = New Label()
        dgvLatestMembers = New DataGridView()
        pnlCardsActive = New Panel()
        Label5 = New Label()
        lblActiveCount = New Label()
        Panel2 = New Panel()
        Label6 = New Label()
        lblTrainersCount = New Label()
        Label7 = New Label()
        Panel3 = New Panel()
        lblExpiredCount = New Label()
        Label8 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvLatestMembers, ComponentModel.ISupportInitialize).BeginInit()
        pnlCardsActive.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(159, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 29
        Label3.Text = "Welcom Back"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(156, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 30
        Label1.Text = "Dashboard"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.LimeGreen
        Label4.Location = New Point(302, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 37)
        Label4.TabIndex = 2
        Label4.Text = "GYM Flow"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem4, ToolStripMenuItem6, TrainerToolStripMenuItem, PlansToolStripMenuItem, AshfjahToolStripMenuItem, ToolStripMenuItem2, TESTToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem1, ToolStripMenuItem5})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        MenuStrip1.Location = New Point(-3, 89)
        MenuStrip1.Margin = New Padding(20)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(153, 392)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {addnewusertool, changeuserinfotool, DeleteUserToolStripMenuItem})
        ToolStripMenuItem4.ForeColor = Color.LimeGreen
        ToolStripMenuItem4.Margin = New Padding(0, 40, 0, 15)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(146, 19)
        ToolStripMenuItem4.Text = "Manage Staff"
        ' 
        ' addnewusertool
        ' 
        addnewusertool.BackColor = Color.Transparent
        addnewusertool.Name = "addnewusertool"
        addnewusertool.Size = New Size(165, 22)
        addnewusertool.Text = "Add New User"
        ' 
        ' changeuserinfotool
        ' 
        changeuserinfotool.Name = "changeuserinfotool"
        changeuserinfotool.Size = New Size(165, 22)
        changeuserinfotool.Text = "Change User Info"
        ' 
        ' DeleteUserToolStripMenuItem
        ' 
        DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        DeleteUserToolStripMenuItem.Size = New Size(165, 22)
        DeleteUserToolStripMenuItem.Text = "Delete User"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.DropDownItems.AddRange(New ToolStripItem() {ViewMemberToolStripMenuItem, AddMemberToolStripMenuItem, EditMemberToolStripMenuItem, FreezSubscriptionToolStripMenuItem})
        ToolStripMenuItem6.ForeColor = Color.LimeGreen
        ToolStripMenuItem6.Margin = New Padding(0, 0, 0, 15)
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(146, 19)
        ToolStripMenuItem6.Text = "Members"
        ' 
        ' ViewMemberToolStripMenuItem
        ' 
        ViewMemberToolStripMenuItem.Name = "ViewMemberToolStripMenuItem"
        ViewMemberToolStripMenuItem.Size = New Size(179, 22)
        ViewMemberToolStripMenuItem.Text = "View Member"
        ' 
        ' AddMemberToolStripMenuItem
        ' 
        AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        AddMemberToolStripMenuItem.Size = New Size(179, 22)
        AddMemberToolStripMenuItem.Text = "Add Member "
        ' 
        ' EditMemberToolStripMenuItem
        ' 
        EditMemberToolStripMenuItem.Name = "EditMemberToolStripMenuItem"
        EditMemberToolStripMenuItem.Size = New Size(179, 22)
        EditMemberToolStripMenuItem.Text = "Edit Member"
        ' 
        ' FreezSubscriptionToolStripMenuItem
        ' 
        FreezSubscriptionToolStripMenuItem.Name = "FreezSubscriptionToolStripMenuItem"
        FreezSubscriptionToolStripMenuItem.Size = New Size(179, 22)
        FreezSubscriptionToolStripMenuItem.Text = "Freeze Subscription "
        ' 
        ' TrainerToolStripMenuItem
        ' 
        TrainerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewTrainersToolStripMenuItem})
        TrainerToolStripMenuItem.ForeColor = Color.LimeGreen
        TrainerToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        TrainerToolStripMenuItem.Size = New Size(146, 19)
        TrainerToolStripMenuItem.Text = "Trainers"
        ' 
        ' ViewTrainersToolStripMenuItem
        ' 
        ViewTrainersToolStripMenuItem.Name = "ViewTrainersToolStripMenuItem"
        ViewTrainersToolStripMenuItem.Size = New Size(143, 22)
        ViewTrainersToolStripMenuItem.Text = "View Trainers"
        ' 
        ' PlansToolStripMenuItem
        ' 
        PlansToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PlansToolStripMenuItem1})
        PlansToolStripMenuItem.ForeColor = Color.LimeGreen
        PlansToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        PlansToolStripMenuItem.Name = "PlansToolStripMenuItem"
        PlansToolStripMenuItem.Size = New Size(146, 19)
        PlansToolStripMenuItem.Text = "Membership"
        ' 
        ' PlansToolStripMenuItem1
        ' 
        PlansToolStripMenuItem1.Name = "PlansToolStripMenuItem1"
        PlansToolStripMenuItem1.Size = New Size(102, 22)
        PlansToolStripMenuItem1.Text = "Plans"
        ' 
        ' AshfjahToolStripMenuItem
        ' 
        AshfjahToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TakeAttendanceToolStripMenuItem})
        AshfjahToolStripMenuItem.ForeColor = Color.LimeGreen
        AshfjahToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        AshfjahToolStripMenuItem.Name = "AshfjahToolStripMenuItem"
        AshfjahToolStripMenuItem.Size = New Size(146, 19)
        AshfjahToolStripMenuItem.Text = "Attendance"
        ' 
        ' TakeAttendanceToolStripMenuItem
        ' 
        TakeAttendanceToolStripMenuItem.Name = "TakeAttendanceToolStripMenuItem"
        TakeAttendanceToolStripMenuItem.Size = New Size(162, 22)
        TakeAttendanceToolStripMenuItem.Text = "Take Attendance"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {ViewProductsToolStripMenuItem})
        ToolStripMenuItem2.ForeColor = Color.Lime
        ToolStripMenuItem2.Margin = New Padding(0, 0, 0, 15)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(146, 19)
        ToolStripMenuItem2.Text = "Product"
        ' 
        ' ViewProductsToolStripMenuItem
        ' 
        ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        ViewProductsToolStripMenuItem.Size = New Size(149, 22)
        ViewProductsToolStripMenuItem.Text = "View Products"
        ' 
        ' TESTToolStripMenuItem2
        ' 
        TESTToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        TESTToolStripMenuItem2.ForeColor = Color.LimeGreen
        TESTToolStripMenuItem2.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem2.Name = "TESTToolStripMenuItem2"
        TESTToolStripMenuItem2.Size = New Size(146, 19)
        TESTToolStripMenuItem2.Text = "System"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(146, 4)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(146, 4)
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(146, 4)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Logo
        PictureBox1.Location = New Point(-3, -15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(153, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.Transparent
        btnlogout.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnlogout.ForeColor = Color.DarkRed
        btnlogout.Location = New Point(0, 478)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(150, 63)
        btnlogout.TabIndex = 1
        btnlogout.Text = "Logout"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.BackColor = Color.Transparent
        lblname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.ForeColor = Color.LimeGreen
        lblname.Location = New Point(256, 46)
        lblname.Name = "lblname"
        lblname.Size = New Size(90, 20)
        lblname.TabIndex = 53
        lblname.Text = "Mohammad"
        ' 
        ' dgvLatestMembers
        ' 
        dgvLatestMembers.AllowUserToAddRows = False
        dgvLatestMembers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.LightGray
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(116), CByte(240), CByte(41))
        dgvLatestMembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvLatestMembers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLatestMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLatestMembers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvLatestMembers.BackgroundColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(41), CByte(240), CByte(116))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLatestMembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLatestMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.LightGray
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(116), CByte(240), CByte(41))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLatestMembers.DefaultCellStyle = DataGridViewCellStyle3
        dgvLatestMembers.EnableHeadersVisualStyles = False
        dgvLatestMembers.GridColor = Color.FromArgb(CByte(116), CByte(240), CByte(41))
        dgvLatestMembers.Location = New Point(199, 189)
        dgvLatestMembers.Name = "dgvLatestMembers"
        dgvLatestMembers.ReadOnly = True
        dgvLatestMembers.RowHeadersVisible = False
        dgvLatestMembers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvLatestMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLatestMembers.Size = New Size(614, 294)
        dgvLatestMembers.TabIndex = 5
        ' 
        ' pnlCardsActive
        ' 
        pnlCardsActive.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        pnlCardsActive.BorderStyle = BorderStyle.FixedSingle
        pnlCardsActive.Controls.Add(Label5)
        pnlCardsActive.Controls.Add(lblActiveCount)
        pnlCardsActive.Location = New Point(173, 89)
        pnlCardsActive.Name = "pnlCardsActive"
        pnlCardsActive.Size = New Size(215, 94)
        pnlCardsActive.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.LightGray
        Label5.Location = New Point(-1, -1)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 15)
        Label5.TabIndex = 63
        Label5.Text = "ACTIVE MEMBERS"
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.Font = New Font("Cascadia Code ExtraLight", 17F)
        lblActiveCount.ForeColor = Color.Lime
        lblActiveCount.Location = New Point(72, 36)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(0, 30)
        lblActiveCount.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(lblTrainersCount)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(408, 89)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(213, 94)
        Panel2.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.LightGray
        Label6.Location = New Point(-1, -1)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 15)
        Label6.TabIndex = 64
        Label6.Text = "TOTAL TRAINER"
        ' 
        ' lblTrainersCount
        ' 
        lblTrainersCount.AutoSize = True
        lblTrainersCount.Font = New Font("Cascadia Code ExtraLight", 17F)
        lblTrainersCount.ForeColor = Color.Lime
        lblTrainersCount.Location = New Point(77, 36)
        lblTrainersCount.Name = "lblTrainersCount"
        lblTrainersCount.Size = New Size(0, 30)
        lblTrainersCount.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.LightGray
        Label7.Location = New Point(-1, -1)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 58
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblExpiredCount)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(634, 89)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(217, 94)
        Panel3.TabIndex = 4
        ' 
        ' lblExpiredCount
        ' 
        lblExpiredCount.AutoSize = True
        lblExpiredCount.Font = New Font("Cascadia Code ExtraLight", 17F)
        lblExpiredCount.ForeColor = Color.Lime
        lblExpiredCount.Location = New Point(77, 36)
        lblExpiredCount.Name = "lblExpiredCount"
        lblExpiredCount.Size = New Size(0, 30)
        lblExpiredCount.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.ForeColor = Color.LightGray
        Label8.Location = New Point(-1, -1)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 15)
        Label8.TabIndex = 62
        Label8.Text = "EXPIRED PLANS"
        ' 
        ' DashBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        BackgroundImage = My.Resources.Resources.Dashboard_back
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(863, 546)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(dgvLatestMembers)
        Controls.Add(lblname)
        Controls.Add(pnlCardsActive)
        Controls.Add(btnlogout)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "DashBoard"
        Text = "Dashboard"
        TransparencyKey = Color.Transparent
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvLatestMembers, ComponentModel.ISupportInitialize).EndInit()
        pnlCardsActive.ResumeLayout(False)
        pnlCardsActive.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents addnewusertool As ToolStripMenuItem
    Friend WithEvents changeuserinfotool As ToolStripMenuItem
    Friend WithEvents TrainerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnlogout As Button
    Friend WithEvents AshfjahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents lblname As Label
    Friend WithEvents DeleteUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditMemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FreezSubscriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TakeAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewTrainersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvLatestMembers As DataGridView
    Friend WithEvents pnlCardsActive As Panel
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTrainersCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblExpiredCount As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
