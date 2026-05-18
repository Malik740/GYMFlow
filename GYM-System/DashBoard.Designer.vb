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
        ToolStripMenuItem6 = New ToolStripMenuItem()
        TrainerToolStripMenuItem = New ToolStripMenuItem()
        PlansToolStripMenuItem = New ToolStripMenuItem()
        AshfjahToolStripMenuItem = New ToolStripMenuItem()
        TESTToolStripMenuItem2 = New ToolStripMenuItem()
        TESTToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        TESTToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        btnlogout = New Button()
        lblname = New Label()
        TESTToolStripMenuItem3 = New ToolStripMenuItem()
        TESTToolStripMenuItem4 = New ToolStripMenuItem()
        TESTToolStripMenuItem5 = New ToolStripMenuItem()
        TESTToolStripMenuItem6 = New ToolStripMenuItem()
        TESTToolStripMenuItem7 = New ToolStripMenuItem()
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
        Label4.Location = New Point(319, 9)
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
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem4, ToolStripMenuItem6, TrainerToolStripMenuItem, PlansToolStripMenuItem, AshfjahToolStripMenuItem, TESTToolStripMenuItem2, TESTToolStripMenuItem, ToolStripMenuItem2, ToolStripMenuItem3, TESTToolStripMenuItem1, ToolStripMenuItem1, ToolStripMenuItem5, TESTToolStripMenuItem3, TESTToolStripMenuItem4, TESTToolStripMenuItem5, TESTToolStripMenuItem6, TESTToolStripMenuItem7})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow
        MenuStrip1.Location = New Point(-3, 90)
        MenuStrip1.Margin = New Padding(20)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(153, 473)
        MenuStrip1.TabIndex = 34
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.DropDownItems.AddRange(New ToolStripItem() {addnewusertool, changeuserinfotool})
        ToolStripMenuItem4.ForeColor = Color.LimeGreen
        ToolStripMenuItem4.Margin = New Padding(0, 10, 0, 15)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(146, 19)
        ToolStripMenuItem4.Text = "Manage"
        ' 
        ' addnewusertool
        ' 
        addnewusertool.BackColor = Color.Transparent
        addnewusertool.Name = "addnewusertool"
        addnewusertool.Size = New Size(180, 22)
        addnewusertool.Text = "Add New User"
        ' 
        ' changeuserinfotool
        ' 
        changeuserinfotool.Name = "changeuserinfotool"
        changeuserinfotool.Size = New Size(180, 22)
        changeuserinfotool.Text = "Change User Info"
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.ForeColor = Color.LimeGreen
        ToolStripMenuItem6.Margin = New Padding(0, 0, 0, 15)
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(146, 19)
        ToolStripMenuItem6.Text = "Member"
        ' 
        ' TrainerToolStripMenuItem
        ' 
        TrainerToolStripMenuItem.ForeColor = Color.LimeGreen
        TrainerToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem"
        TrainerToolStripMenuItem.Size = New Size(146, 19)
        TrainerToolStripMenuItem.Text = "Trainer"
        ' 
        ' PlansToolStripMenuItem
        ' 
        PlansToolStripMenuItem.ForeColor = Color.LimeGreen
        PlansToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        PlansToolStripMenuItem.Name = "PlansToolStripMenuItem"
        PlansToolStripMenuItem.Size = New Size(146, 19)
        PlansToolStripMenuItem.Text = "Plans"
        ' 
        ' AshfjahToolStripMenuItem
        ' 
        AshfjahToolStripMenuItem.ForeColor = Color.LimeGreen
        AshfjahToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        AshfjahToolStripMenuItem.Name = "AshfjahToolStripMenuItem"
        AshfjahToolStripMenuItem.Size = New Size(146, 19)
        AshfjahToolStripMenuItem.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem2
        ' 
        TESTToolStripMenuItem2.ForeColor = Color.LimeGreen
        TESTToolStripMenuItem2.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem2.Name = "TESTToolStripMenuItem2"
        TESTToolStripMenuItem2.Size = New Size(146, 19)
        TESTToolStripMenuItem2.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem
        ' 
        TESTToolStripMenuItem.ForeColor = Color.LimeGreen
        TESTToolStripMenuItem.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem.Name = "TESTToolStripMenuItem"
        TESTToolStripMenuItem.Size = New Size(146, 19)
        TESTToolStripMenuItem.Text = "TEST"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(146, 4)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(146, 4)
        ' 
        ' TESTToolStripMenuItem1
        ' 
        TESTToolStripMenuItem1.ForeColor = Color.LimeGreen
        TESTToolStripMenuItem1.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem1.Name = "TESTToolStripMenuItem1"
        TESTToolStripMenuItem1.Size = New Size(146, 19)
        TESTToolStripMenuItem1.Text = "TEST"
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
        btnlogout.Location = New Point(0, 558)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(150, 46)
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
        lblname.Location = New Point(279, 46)
        lblname.Name = "lblname"
        lblname.Size = New Size(77, 20)
        lblname.TabIndex = 53
        lblname.Text = "Mohamad"
        ' 
        ' TESTToolStripMenuItem3
        ' 
        TESTToolStripMenuItem3.ForeColor = Color.LimeGreen
        TESTToolStripMenuItem3.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem3.Name = "TESTToolStripMenuItem3"
        TESTToolStripMenuItem3.Size = New Size(146, 19)
        TESTToolStripMenuItem3.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem4
        ' 
        TESTToolStripMenuItem4.ForeColor = Color.Lime
        TESTToolStripMenuItem4.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem4.Name = "TESTToolStripMenuItem4"
        TESTToolStripMenuItem4.Size = New Size(146, 19)
        TESTToolStripMenuItem4.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem5
        ' 
        TESTToolStripMenuItem5.ForeColor = Color.Lime
        TESTToolStripMenuItem5.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem5.Name = "TESTToolStripMenuItem5"
        TESTToolStripMenuItem5.Size = New Size(146, 19)
        TESTToolStripMenuItem5.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem6
        ' 
        TESTToolStripMenuItem6.ForeColor = Color.Lime
        TESTToolStripMenuItem6.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem6.Name = "TESTToolStripMenuItem6"
        TESTToolStripMenuItem6.Size = New Size(146, 19)
        TESTToolStripMenuItem6.Text = "TEST"
        ' 
        ' TESTToolStripMenuItem7
        ' 
        TESTToolStripMenuItem7.ForeColor = Color.Lime
        TESTToolStripMenuItem7.Margin = New Padding(0, 0, 0, 15)
        TESTToolStripMenuItem7.Name = "TESTToolStripMenuItem7"
        TESTToolStripMenuItem7.Size = New Size(146, 19)
        TESTToolStripMenuItem7.Text = "TEST"
        ' 
        ' DashBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1294, 605)
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
    Friend WithEvents TESTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents lblname As Label
    Friend WithEvents TESTToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem7 As ToolStripMenuItem
End Class
