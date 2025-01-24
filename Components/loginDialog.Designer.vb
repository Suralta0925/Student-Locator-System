<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginDialog
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
        PictureBox1 = New PictureBox()
        tryagain = New Button()
        headerLbl = New Label()
        message = New Label()
        Panel1 = New Panel()
        closeBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.close__1_
        PictureBox1.Location = New Point(152, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(134, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' tryagain
        ' 
        tryagain.BackColor = Color.Red
        tryagain.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tryagain.ForeColor = SystemColors.ButtonHighlight
        tryagain.Location = New Point(125, 406)
        tryagain.Name = "tryagain"
        tryagain.Size = New Size(185, 64)
        tryagain.TabIndex = 1
        tryagain.Text = "Try Again"
        tryagain.UseVisualStyleBackColor = False
        ' 
        ' headerLbl
        ' 
        headerLbl.AutoSize = True
        headerLbl.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        headerLbl.ForeColor = Color.Red
        headerLbl.Location = New Point(167, 204)
        headerLbl.Name = "headerLbl"
        headerLbl.Size = New Size(110, 50)
        headerLbl.TabIndex = 2
        headerLbl.Text = "Error"
        ' 
        ' message
        ' 
        message.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        message.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        message.Location = New Point(35, 276)
        message.Name = "message"
        message.RightToLeft = RightToLeft.No
        message.Size = New Size(371, 117)
        message.TabIndex = 3
        message.Text = "Incorrect password, please try checking your password again!"
        message.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(closeBtn)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(tryagain)
        Panel1.Controls.Add(message)
        Panel1.Controls.Add(headerLbl)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(431, 578)
        Panel1.TabIndex = 4
        ' 
        ' closeBtn
        ' 
        closeBtn.BackColor = Color.Red
        closeBtn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        closeBtn.ForeColor = SystemColors.ButtonHighlight
        closeBtn.Location = New Point(125, 406)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(185, 64)
        closeBtn.TabIndex = 4
        closeBtn.Text = "Yes"
        closeBtn.UseVisualStyleBackColor = False
        closeBtn.Visible = False
        ' 
        ' loginDialog
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(455, 602)
        ControlBox = False
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "loginDialog"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "loginDialog"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tryagain As Button
    Friend WithEvents headerLbl As Label
    Friend WithEvents message As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeBtn As Button
End Class
