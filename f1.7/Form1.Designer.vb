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
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        BalanceLabel.Font = New Font("Segoe UI", 12.0F)
        BalanceLabel.Location = New Point(70, 107)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New Size(198, 73)
        BalanceLabel.TabIndex = 4
        BalanceLabel.Text = "Balance: 5000"
        BalanceLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resource1.slot_machine
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(378, 630)
        Controls.Add(BalanceLabel)
        Controls.Add(PlayButton)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Slot Machine"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PlayButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BalanceLabel As Label

End Class
