<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PlayButton = New Button()
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        BalanceLabel = New Label()
        MenuStrip1 = New MenuStrip()
        GameToolStripMenuItem = New ToolStripMenuItem()
        PlayToolStripMenuItem = New ToolStripMenuItem()
        LeaveToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(66, 240)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 64)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(144, 240)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 64)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(222, 240)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 64)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PlayButton
        ' 
        PlayButton.BackColor = Color.Red
        PlayButton.ForeColor = Color.Transparent
        PlayButton.Location = New Point(329, 231)
        PlayButton.Name = "PlayButton"
        PlayButton.Size = New Size(27, 45)
        PlayButton.TabIndex = 3
        PlayButton.TextImageRelation = TextImageRelation.ImageAboveText
        PlayButton.UseVisualStyleBackColor = False
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 25
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 25
        ' 
        ' BalanceLabel
        ' 
        BalanceLabel.BackColor = Color.Transparent
        BalanceLabel.Font = New Font("Segoe UI", 12F)
        BalanceLabel.Location = New Point(70, 107)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New Size(198, 73)
        BalanceLabel.TabIndex = 4
        BalanceLabel.Text = "Créditos: 5000"
        BalanceLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {GameToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(378, 24)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GameToolStripMenuItem
        ' 
        GameToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PlayToolStripMenuItem, LeaveToolStripMenuItem})
        GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        GameToolStripMenuItem.Size = New Size(43, 20)
        GameToolStripMenuItem.Text = "Joga"
        ' 
        ' PlayToolStripMenuItem
        ' 
        PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        PlayToolStripMenuItem.ShortcutKeys = Keys.F2
        PlayToolStripMenuItem.Size = New Size(180, 22)
        PlayToolStripMenuItem.Text = "Jogar"
        ' 
        ' LeaveToolStripMenuItem
        ' 
        LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        LeaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F4
        LeaveToolStripMenuItem.Size = New Size(180, 22)
        LeaveToolStripMenuItem.Text = "Sair"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IndexToolStripMenuItem, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(50, 20)
        HelpToolStripMenuItem.Text = "Ajuda"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.ShortcutKeys = Keys.F1
        IndexToolStripMenuItem.Size = New Size(180, 22)
        IndexToolStripMenuItem.Text = "Indice"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "Acerca"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resource1.slot_machine
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(378, 630)
        Controls.Add(BalanceLabel)
        Controls.Add(PlayButton)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Slot Machine"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PlayButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem

End Class
