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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoard))
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
        ViewTrainersToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(175, 46)
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
        Label1.Location = New Point(167, 9)
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
        Label4.Location = New Point(313, 9)
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
        MenuStrip1.TabIndex = 34
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
        AboutToolStripMenuItem.Size = New Size(107, 22)
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
        PictureBox1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
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
        btnlogout.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        btnlogout.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnlogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnlogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        btnlogout.FlatStyle = FlatStyle.Flat
        btnlogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnlogout.ForeColor = Color.DarkRed
        btnlogout.Location = New Point(0, 478)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(150, 63)
        btnlogout.TabIndex = 52
        btnlogout.Text = "Logout"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.BackColor = Color.Transparent
        lblname.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblname.ForeColor = Color.LimeGreen
        lblname.Location = New Point(267, 46)
        lblname.Name = "lblname"
        lblname.Size = New Size(90, 20)
        lblname.TabIndex = 53
        lblname.Text = "Mohammad"
        ' 
        ' ViewTrainersToolStripMenuItem
        ' 
        ViewTrainersToolStripMenuItem.Name = "ViewTrainersToolStripMenuItem"
        ViewTrainersToolStripMenuItem.Size = New Size(180, 22)
        ViewTrainersToolStripMenuItem.Text = "View Trainers"
        ' 
        ' DashBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(863, 542)
        Controls.Add(lblname)
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
End Class
