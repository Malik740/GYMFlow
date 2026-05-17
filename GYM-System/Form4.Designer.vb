<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        MenuStrip1 = New MenuStrip()
        AddUserToolStripMenuItem = New ToolStripMenuItem()
        AddUserToolStripMenuItem1 = New ToolStripMenuItem()
        CangeUserINFOToolStripMenuItem = New ToolStripMenuItem()
        MembersToolStripMenuItem = New ToolStripMenuItem()
        TrainersToolStripMenuItem = New ToolStripMenuItem()
        AToolStripMenuItem = New ToolStripMenuItem()
        PlansToolStripMenuItem = New ToolStripMenuItem()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        Label2 = New Label()
        Label4 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddUserToolStripMenuItem, MembersToolStripMenuItem, TrainersToolStripMenuItem, AToolStripMenuItem, PlansToolStripMenuItem})
        MenuStrip1.LayoutStyle = ToolStripLayoutStyle.Table
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(80, 476)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AddUserToolStripMenuItem
        ' 
        AddUserToolStripMenuItem.BackColor = Color.LightGray
        AddUserToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddUserToolStripMenuItem1, CangeUserINFOToolStripMenuItem})
        AddUserToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        AddUserToolStripMenuItem.Size = New Size(56, 19)
        AddUserToolStripMenuItem.Text = "Mange"
        ' 
        ' AddUserToolStripMenuItem1
        ' 
        AddUserToolStripMenuItem1.Name = "AddUserToolStripMenuItem1"
        AddUserToolStripMenuItem1.Size = New Size(180, 22)
        AddUserToolStripMenuItem1.Text = "Add User"
        ' 
        ' CangeUserINFOToolStripMenuItem
        ' 
        CangeUserINFOToolStripMenuItem.Name = "CangeUserINFOToolStripMenuItem"
        CangeUserINFOToolStripMenuItem.Size = New Size(180, 22)
        CangeUserINFOToolStripMenuItem.Text = "Cange User INFO"
        ' 
        ' MembersToolStripMenuItem
        ' 
        MembersToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        MembersToolStripMenuItem.Size = New Size(69, 19)
        MembersToolStripMenuItem.Text = "Members"
        ' 
        ' TrainersToolStripMenuItem
        ' 
        TrainersToolStripMenuItem.ForeColor = Color.Snow
        TrainersToolStripMenuItem.Name = "TrainersToolStripMenuItem"
        TrainersToolStripMenuItem.Size = New Size(60, 19)
        TrainersToolStripMenuItem.Text = "Trainers"
        ' 
        ' AToolStripMenuItem
        ' 
        AToolStripMenuItem.ForeColor = SystemColors.ControlLightLight
        AToolStripMenuItem.Name = "AToolStripMenuItem"
        AToolStripMenuItem.Size = New Size(74, 19)
        AToolStripMenuItem.Text = "Attendanc"
        ' 
        ' PlansToolStripMenuItem
        ' 
        PlansToolStripMenuItem.ForeColor = SystemColors.ButtonFace
        PlansToolStripMenuItem.Name = "PlansToolStripMenuItem"
        PlansToolStripMenuItem.Size = New Size(47, 19)
        PlansToolStripMenuItem.Text = "Plans"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(115, 46)
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
        Label1.Location = New Point(115, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 37)
        Label1.TabIndex = 30
        Label1.Text = "Dashboard"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.ForeColor = SystemColors.ButtonFace
        GroupBox1.Location = New Point(115, 114)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(130, 71)
        GroupBox1.TabIndex = 32
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Member"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(279, 114)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(130, 71)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "Traener"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.ForeColor = SystemColors.ButtonHighlight
        GroupBox3.Location = New Point(444, 114)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(130, 71)
        GroupBox3.TabIndex = 33
        GroupBox3.TabStop = False
        GroupBox3.Text = "Today Attend"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.ForeColor = SystemColors.ButtonHighlight
        GroupBox4.Location = New Point(612, 114)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(130, 71)
        GroupBox4.TabIndex = 33
        GroupBox4.TabStop = False
        GroupBox4.Text = "Monthly Revenue"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label2.ForeColor = Color.LimeGreen
        Label2.Location = New Point(691, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 37)
        Label2.TabIndex = 3
        Label2.Text = "Flow"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(621, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 37)
        Label4.TabIndex = 2
        Label4.Text = "GYM"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 476)
        Controls.Add(Label2)
        Controls.Add(GroupBox4)
        Controls.Add(Label4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "Form4"
        TransparencyKey = Color.Transparent
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CangeUserINFOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrainersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
