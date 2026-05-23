<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        PictureBox5 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(6, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 72)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.ForeColor = Color.LimeGreen
        GroupBox1.Location = New Point(21, 31)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(221, 107)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "caesar salad"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(122, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 60)
        Label1.TabIndex = 5
        Label1.Text = "Romaine lettuce" & vbCrLf & "Croutons" & vbCrLf & "Parmesan cheese " & vbCrLf & "chiken "
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(PictureBox5)
        GroupBox2.ForeColor = Color.LimeGreen
        GroupBox2.Location = New Point(333, 31)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(221, 107)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "chicken wrap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(122, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 60)
        Label2.TabIndex = 5
        Label2.Text = "Grilled chicken" & vbCrLf & "Tomato slices" & vbCrLf & "tortilla" & vbCrLf & "Lettuce"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(6, 22)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(110, 72)
        PictureBox5.TabIndex = 0
        PictureBox5.TabStop = False
        ' 
        ' Product
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Name = "Product"
        Text = "Products"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
