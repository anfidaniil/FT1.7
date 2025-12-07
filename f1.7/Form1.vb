Public Class Form1
    Dim spriteSheet As Bitmap
    Dim frameWidth As Integer = 64
    Dim frameHeight As Integer = 64
    Dim totalFrames = 10

    Dim currBalance = 5000

    Dim currFrame1 = 8
    Dim currFrame2 = 8
    Dim currFrame3 = 8

    Dim Timer1_delta = 0
    Dim Timer2_delta = 0
    Dim Timer3_delta = 0

    Dim goals = New Integer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spriteSheet = New Bitmap(New Bitmap("C:\Users\daniel\Coding\School\FT1.7\f1.7\Assets\symbols.png"))
        PictureBox1.Image = Get_Frame(currFrame1)
        PictureBox2.Image = Get_Frame(currFrame2)
        PictureBox3.Image = Get_Frame(currFrame3)
        Debug.WriteLine("Im Loaded")
    End Sub

    Private Sub PB_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Function Get_Frame(currFrame As Integer) As Bitmap
        If (currFrame >= totalFrames) Then
            currFrame = 0
        End If
        Dim srcRect As New Rectangle(currFrame * frameWidth, 0, frameWidth, frameHeight)

        ' Destination image to display
        Dim frame = New Bitmap(frameWidth, frameHeight)
        Using g As Graphics = Graphics.FromImage(frame)
            g.DrawImage(spriteSheet, New Rectangle(0, 0, frameWidth, frameHeight), srcRect, GraphicsUnit.Pixel)
        End Using

        Return frame
    End Function

    Private Sub Scroll_Frames()
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If currBalance <= 0 Then
            Me.Close()
        End If
        goals = Utils.get_RandomNumbers()
        currFrame1 = goals(0)
        currFrame2 = goals(1)
        currFrame3 = goals(2)
        Scroll_Frames()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1_delta < 20 Then
            currFrame1 += 1
            If (currFrame1 >= totalFrames) Then
                currFrame1 = 0
            End If
            PictureBox1.Image = Get_Frame(currFrame1)
            Timer1_delta += 1
        Else
            Timer1.Stop()
            Timer1_delta = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Timer2_delta < 40 Then
            currFrame2 += 1
            If (currFrame2 >= totalFrames) Then
                currFrame2 = 0
            End If
            PictureBox2.Image = Get_Frame(currFrame2)
            Timer2_delta += 1
        Else
            Timer2.Stop()
            Timer2_delta = 0
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Timer3_delta < 60 Then
            currFrame3 += 1
            If (currFrame3 >= totalFrames) Then
                currFrame3 = 0
            End If
            PictureBox3.Image = Get_Frame(currFrame3)
            Timer3_delta += 1
        Else
            Timer3.Stop()
            Timer3_delta = 0
            OnAnimationEnd()
        End If
    End Sub

    Private Sub OnAnimationEnd()
        Dim balanceChange = Utils.calc_Win(goals)
        currBalance += balanceChange
        BalanceLabel.Text = "Balance: " & currBalance
    End Sub
End Class
