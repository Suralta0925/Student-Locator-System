Imports System.Runtime

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub Active(B As Button)
        Home.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Search.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Settings.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Map.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))

        Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Map.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))









        B.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        B.BackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Identifier.Text = B.Text

    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Logout = New Button()
        Settings = New Button()
        Map = New Button()
        Search = New Button()
        Home = New Button()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Identifier = New Label()
        Button1 = New Button()
        Main_Screen = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Panel1.Controls.Add(Logout)
        Panel1.Controls.Add(Settings)
        Panel1.Controls.Add(Map)
        Panel1.Controls.Add(Search)
        Panel1.Controls.Add(Home)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(281, 1000)
        Panel1.TabIndex = 0
        ' 
        ' Logout
        ' 
        Logout.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Logout.Dock = DockStyle.Bottom
        Logout.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Logout.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(56), CByte(56))
        Logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(77), CByte(77))
        Logout.FlatStyle = FlatStyle.Flat
        Logout.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logout.ForeColor = SystemColors.ButtonHighlight
        Logout.Image = My.Resources.Resources.logout
        Logout.Location = New Point(0, 951)
        Logout.Name = "Logout"
        Logout.Padding = New Padding(5, 0, 0, 0)
        Logout.Size = New Size(281, 49)
        Logout.TabIndex = 8
        Logout.Tag = "Logout"
        Logout.Text = "Logout"
        Logout.TextImageRelation = TextImageRelation.ImageBeforeText
        Logout.UseVisualStyleBackColor = False
        ' 
        ' Settings
        ' 
        Settings.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Settings.Dock = DockStyle.Top
        Settings.FlatAppearance.BorderSize = 0
        Settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Settings.FlatStyle = FlatStyle.Flat
        Settings.Font = New Font("Arial Black", 11F, FontStyle.Bold)
        Settings.ForeColor = SystemColors.ButtonHighlight
        Settings.Image = My.Resources.Resources.setting
        Settings.ImageAlign = ContentAlignment.MiddleLeft
        Settings.Location = New Point(0, 529)
        Settings.Name = "Settings"
        Settings.Padding = New Padding(10, 0, 0, 0)
        Settings.Size = New Size(281, 81)
        Settings.TabIndex = 7
        Settings.Tag = "Setting"
        Settings.Text = "Settings"
        Settings.UseVisualStyleBackColor = False
        ' 
        ' Map
        ' 
        Map.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Map.Dock = DockStyle.Top
        Map.FlatAppearance.BorderSize = 0
        Map.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Map.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Map.FlatStyle = FlatStyle.Flat
        Map.Font = New Font("Arial Black", 11F, FontStyle.Bold)
        Map.ForeColor = SystemColors.ButtonHighlight
        Map.Image = My.Resources.Resources.map
        Map.ImageAlign = ContentAlignment.MiddleLeft
        Map.Location = New Point(0, 448)
        Map.Name = "Map"
        Map.Padding = New Padding(10, 0, 0, 0)
        Map.Size = New Size(281, 81)
        Map.TabIndex = 6
        Map.Tag = "Map"
        Map.Text = "Map"
        Map.UseVisualStyleBackColor = False
        ' 
        ' Search
        ' 
        Search.BackColor = Color.FromArgb(CByte(75), CByte(75), CByte(75))
        Search.Dock = DockStyle.Top
        Search.FlatAppearance.BorderSize = 0
        Search.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Search.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(197), CByte(108), CByte(240))
        Search.FlatStyle = FlatStyle.Flat
        Search.Font = New Font("Arial Black", 11F, FontStyle.Bold)
        Search.ForeColor = SystemColors.ButtonHighlight
        Search.Image = My.Resources.Resources.search
        Search.ImageAlign = ContentAlignment.MiddleLeft
        Search.Location = New Point(0, 363)
        Search.Name = "Search"
        Search.Padding = New Padding(10, 0, 0, 0)
        Search.Size = New Size(281, 85)
        Search.TabIndex = 5
        Search.Tag = "Search"
        Search.Text = "Search"
        Search.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        Home.BackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Home.Dock = DockStyle.Top
        Home.FlatAppearance.BorderSize = 0
        Home.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(125), CByte(95), CByte(255))
        Home.FlatStyle = FlatStyle.Flat
        Home.Font = New Font("Arial Black", 11F, FontStyle.Bold)
        Home.ForeColor = SystemColors.ButtonHighlight
        Home.Image = My.Resources.Resources.home
        Home.ImageAlign = ContentAlignment.MiddleLeft
        Home.Location = New Point(0, 278)
        Home.Name = "Home"
        Home.Padding = New Padding(10, 0, 0, 0)
        Home.Size = New Size(281, 85)
        Home.TabIndex = 4
        Home.Tag = "Home"
        Home.Text = "Home"
        Home.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 47)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(281, 231)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(279, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1068, 698)
        Panel5.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(2, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(273, 28)
        Label1.TabIndex = 2
        Label1.Text = "Student Locator System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.globe
        PictureBox1.Location = New Point(63, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(129, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(113), CByte(88), CByte(226))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(281, 47)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(125), CByte(95), CByte(255))
        Panel3.Controls.Add(Identifier)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(281, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1101, 47)
        Panel3.TabIndex = 2
        ' 
        ' Identifier
        ' 
        Identifier.AutoSize = True
        Identifier.Font = New Font("Arial Black", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Identifier.ForeColor = SystemColors.ButtonHighlight
        Identifier.Location = New Point(506, 5)
        Identifier.Name = "Identifier"
        Identifier.Size = New Size(99, 36)
        Identifier.TabIndex = 1
        Identifier.Text = "HOME"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(1040, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 39)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Main_Screen
        ' 
        Main_Screen.Dock = DockStyle.Fill
        Main_Screen.Location = New Point(281, 47)
        Main_Screen.Name = "Main_Screen"
        Main_Screen.Size = New Size(1101, 953)
        Main_Screen.TabIndex = 3
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 1000)
        ControlBox = False
        Controls.Add(Main_Screen)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Screen"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Home As Button
    Friend WithEvents Map As Button
    Friend WithEvents Search As Button
    Friend WithEvents Settings As Button
    Friend WithEvents Logout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Identifier As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Main_Screen As Panel
End Class
