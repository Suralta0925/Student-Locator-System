<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash_Screen
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ContainerBar = New Panel()
        Loading_Bar = New Panel()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ContainerBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(176, 355)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 48)
        Label1.TabIndex = 3
        Label1.Text = "Student Locator System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Loading__anim
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(255, 87)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(289, 265)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' ContainerBar
        ' 
        ContainerBar.BackColor = Color.FromArgb(CByte(140), CByte(82), CByte(255))
        ContainerBar.Controls.Add(Loading_Bar)
        ContainerBar.Location = New Point(0, 528)
        ContainerBar.Name = "ContainerBar"
        ContainerBar.Size = New Size(816, 20)
        ContainerBar.TabIndex = 5
        ' 
        ' Loading_Bar
        ' 
        Loading_Bar.BackColor = Color.White
        Loading_Bar.Location = New Point(0, 0)
        Loading_Bar.Name = "Loading_Bar"
        Loading_Bar.Size = New Size(16, 20)
        Loading_Bar.TabIndex = 6
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Splash_Screen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(140), CByte(0), CByte(255))
        ClientSize = New Size(816, 549)
        ControlBox = False
        Controls.Add(ContainerBar)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash_Screen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Locator System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ContainerBar.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContainerBar As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Loading_Bar As Panel

End Class
