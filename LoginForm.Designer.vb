<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Panel3 = New Panel()
        Identifier = New Label()
        CoverDesign = New Panel()
        RegisterBtn = New Button()
        Label1 = New Label()
        Greetings = New Label()
        Anim = New Timer(components)
        loginBtn = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        lblLogin = New Label()
        password = New TextBox()
        PictureBox2 = New PictureBox()
        showPswrd = New CheckBox()
        lognPanel = New Panel()
        passworChng = New Label()
        Panel4 = New Panel()
        username = New TextBox()
        Panel2 = New Panel()
        Panel3.SuspendLayout()
        CoverDesign.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        lognPanel.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 12.0F)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(1040, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 39)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(125), CByte(95), CByte(255))
        Panel3.Controls.Add(Identifier)
        Panel3.Controls.Add(Button1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1105, 47)
        Panel3.TabIndex = 3
        ' 
        ' Identifier
        ' 
        Identifier.AutoSize = True
        Identifier.Font = New Font("Arial Black", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Identifier.ForeColor = SystemColors.ButtonHighlight
        Identifier.Location = New Point(506, 5)
        Identifier.Name = "Identifier"
        Identifier.Size = New Size(105, 36)
        Identifier.TabIndex = 1
        Identifier.Text = "LOGIN"
        ' 
        ' CoverDesign
        ' 
        CoverDesign.BackColor = Color.FromArgb(CByte(84), CByte(109), CByte(229))
        CoverDesign.Controls.Add(RegisterBtn)
        CoverDesign.Controls.Add(Label1)
        CoverDesign.Controls.Add(Greetings)
        CoverDesign.Location = New Point(0, 47)
        CoverDesign.Name = "CoverDesign"
        CoverDesign.Size = New Size(508, 693)
        CoverDesign.TabIndex = 4
        ' 
        ' RegisterBtn
        ' 
        RegisterBtn.BackColor = Color.FromArgb(CByte(84), CByte(109), CByte(229))
        RegisterBtn.BackgroundImageLayout = ImageLayout.Stretch
        RegisterBtn.FlatAppearance.BorderSize = 3
        RegisterBtn.FlatAppearance.MouseOverBackColor = Color.White
        RegisterBtn.FlatStyle = FlatStyle.Flat
        RegisterBtn.Font = New Font("Arial", 12.0F)
        RegisterBtn.ForeColor = SystemColors.ButtonHighlight
        RegisterBtn.Location = New Point(159, 350)
        RegisterBtn.Name = "RegisterBtn"
        RegisterBtn.Size = New Size(203, 58)
        RegisterBtn.TabIndex = 1
        RegisterBtn.Text = "Register"
        RegisterBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 17.0F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(119, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 33)
        Label1.TabIndex = 0
        Label1.Text = "Don't Have an Account?"
        ' 
        ' Greetings
        ' 
        Greetings.AutoSize = True
        Greetings.Font = New Font("Arial Black", 28.0F, FontStyle.Bold)
        Greetings.ForeColor = Color.White
        Greetings.Location = New Point(40, 207)
        Greetings.Name = "Greetings"
        Greetings.Size = New Size(443, 67)
        Greetings.TabIndex = 0
        Greetings.Text = "Hello, Welcome!"
        ' 
        ' Anim
        ' 
        Anim.Interval = 10
        ' 
        ' loginBtn
        ' 
        loginBtn.BackColor = Color.FromArgb(CByte(84), CByte(109), CByte(229))
        loginBtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginBtn.ForeColor = SystemColors.ButtonHighlight
        loginBtn.Location = New Point(152, 514)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(262, 64)
        loginBtn.TabIndex = 5
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(890, 866)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 60)
        Label2.TabIndex = 7
        Label2.Text = "Login"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonHighlight
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(336, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Segoe UI", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.Location = New Point(189, 62)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(193, 81)
        lblLogin.TabIndex = 9
        lblLogin.Text = "Login"
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.None
        password.Font = New Font("Segoe UI", 13.8F)
        password.Location = New Point(21, 12)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.PlaceholderText = "Password"
        password.Size = New Size(316, 31)
        password.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.lock
        PictureBox2.Location = New Point(336, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' showPswrd
        ' 
        showPswrd.AutoSize = True
        showPswrd.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        showPswrd.Location = New Point(88, 441)
        showPswrd.Name = "showPswrd"
        showPswrd.Size = New Size(193, 35)
        showPswrd.TabIndex = 10
        showPswrd.Text = "Show Password"
        showPswrd.UseVisualStyleBackColor = True
        ' 
        ' lognPanel
        ' 
        lognPanel.Controls.Add(passworChng)
        lognPanel.Controls.Add(Panel4)
        lognPanel.Controls.Add(Panel2)
        lognPanel.Controls.Add(lblLogin)
        lognPanel.Controls.Add(showPswrd)
        lognPanel.Controls.Add(loginBtn)
        lognPanel.Location = New Point(533, 47)
        lognPanel.Name = "lognPanel"
        lognPanel.Size = New Size(572, 693)
        lognPanel.TabIndex = 11
        ' 
        ' passworChng
        ' 
        passworChng.AutoSize = True
        passworChng.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        passworChng.ForeColor = SystemColors.GrayText
        passworChng.Location = New Point(190, 395)
        passworChng.Name = "passworChng"
        passworChng.Size = New Size(189, 31)
        passworChng.TabIndex = 13
        passworChng.Text = "Forgot Password"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Controls.Add(username)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(88, 219)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(378, 55)
        Panel4.TabIndex = 12
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Segoe UI", 13.8F)
        username.Location = New Point(21, 12)
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(316, 31)
        username.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(password)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(88, 314)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(378, 55)
        Panel2.TabIndex = 11
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1105, 740)
        Controls.Add(CoverDesign)
        Controls.Add(lognPanel)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CoverDesign.ResumeLayout(False)
        CoverDesign.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        lognPanel.ResumeLayout(False)
        lognPanel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Identifier As Label
    Friend WithEvents CoverDesign As Panel
    Friend WithEvents Greetings As Label
    Friend WithEvents RegisterBtn As Button
    Friend WithEvents Label1 As Label
    Public WithEvents Anim As Timer
    Friend WithEvents loginBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents showPswrd As CheckBox
    Friend WithEvents lognPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents passworChng As Label
End Class
