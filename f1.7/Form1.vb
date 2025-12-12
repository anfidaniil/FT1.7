Imports System.Media

Public Class Form1
    Dim spriteSheet As Bitmap
    Dim jackpotSpriteSheet As Bitmap
    Dim frameWidth As Integer = 64
    Dim frameHeight As Integer = 64
    Dim totalFrames = 10

    Dim currBalance = 5000

    Dim currFrame1 = 8
    Dim currFrame2 = 8
    Dim currFrame3 = 8
    Dim jackPotFrame = 0

    Dim Timer1_delta = 0
    Dim Timer2_delta = 0
    Dim Timer3_delta = 0
    Dim Timer4_delta = 0

    Dim isAnimationFinished = True

    Dim goals = New Integer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spriteSheet = New Bitmap(New Bitmap(My.Resources.Resource1.symbols))
        jackpotSpriteSheet = New Bitmap(New Bitmap(My.Resources.Resource1.jackpot_anim))
        BalanceLabel_Update()
        PictureBox1.Image = Get_Frame(currFrame1)
        PictureBox2.Image = Get_Frame(currFrame2)
        PictureBox3.Image = Get_Frame(currFrame3)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim res = MsgBox("Are you sure?", vbYesNo, "Leave")

        If res = vbNo Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BalanceLabel_Update()
        BalanceLabel.Text = "Créditos: " & currBalance
    End Sub


    Private Function Get_Frame(currFrame As Integer) As Bitmap
        Dim prevFrame As Integer = (currFrame - 1 + totalFrames) Mod totalFrames
        Dim nextFrame As Integer = (currFrame + 1) Mod totalFrames
        currFrame = currFrame Mod totalFrames

        Dim outputWidth As Integer = 64
        Dim outputHeight As Integer = 113

        Dim spacer = 4
        Dim prevHeight As Integer = 24 - spacer
        Dim currHeight As Integer = 64
        Dim nextHeight As Integer = 113 - 64 - 24 - spacer



        ' Destination image to display
        Dim frame = New Bitmap(outputWidth, outputHeight)
        Using g As Graphics = Graphics.FromImage(frame)
            Dim srcPrev As New Rectangle(prevFrame * frameWidth, frameHeight - prevHeight, frameWidth, prevHeight)
            Dim dstPrev As New Rectangle(0, 0, outputWidth, prevHeight)
            g.DrawImage(spriteSheet, dstPrev, srcPrev, GraphicsUnit.Pixel)

            Dim srcCurr As New Rectangle(currFrame * frameWidth, 0, frameWidth, currHeight)
            Dim dstCurr As New Rectangle(0, prevHeight + spacer, outputWidth, currHeight)
            g.DrawImage(spriteSheet, dstCurr, srcCurr, GraphicsUnit.Pixel)

            Dim srcNext As New Rectangle(nextFrame * frameWidth, 0, frameWidth, nextHeight)
            Dim dstNext As New Rectangle(0, prevHeight + currHeight + spacer * 2, outputWidth, nextHeight)
            g.DrawImage(spriteSheet, dstNext, srcNext, GraphicsUnit.Pixel)
        End Using

        Return frame
    End Function

    Private Sub Scroll_Frames()
        goals = Utils.get_RandomNumbers()
        currFrame1 = goals(0)
        currFrame2 = goals(1)
        currFrame3 = goals(2)
        isAnimationFinished = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If isAnimationFinished = True Then
            If currBalance <= 0 Then
                Dim msg =
                    "Would you like to receive 10000 balance?" & vbCrLf &
                    "By continuing you guarantee to award 100% as the final note for our project"
                Dim res = MsgBox(msg, vbYesNo, "New funds are required")

                If res = vbYes Then
                    currBalance += 10000
                    BalanceLabel_Update()
                Else
                    Me.Close()
                End If
            End If

            If currBalance >= 500 Then
                Scroll_Frames()
            End If
        End If
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
            isAnimationFinished = True
        End If
    End Sub

    Private Sub OnAnimationEnd()
        Dim balanceChange = Utils.calc_Win(goals)
        currBalance += balanceChange
        BalanceLabel_Update()
        If balanceChange = 100000 Then
            JackPotConratsMsg_Show()

        ElseIf balanceChange > 0 Then
            PlayBeeps()
        Else
            PlayBeepsOnLose()
        End If

    End Sub

    Private Async Sub PlayBeeps()
        Await Task.Run(
            Sub()
                Using player As New System.Media.SoundPlayer(My.Resources.Resource1.beep_sound)
                    player.PlaySync()
                End Using
            End Sub
        )
    End Sub
    Private Async Sub PlayBeepsOnLose()
        Await Task.Run(
            Sub()
                Using player As New System.Media.SoundPlayer(My.Resources.Resource1.beep_lost)
                    player.PlaySync()
                End Using
            End Sub
        )
    End Sub

    Private Sub JackPotConratsMsg_Show()
        JackPotCongratsMsg.Visible = True
        Timer4.Start()
        PlayBeeps()

    End Sub
    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        PlayButton.PerformClick()
    End Sub

    Private Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        Dim msg As String =
        "Regras do jogo:" & vbCrLf &
        "- O saldo inicial é 5000 créditos." & vbCrLf &
        "- Cada jogada faz os números rodarem." & vbCrLf &
        "- Obter números 7 dá prémios:" & vbCrLf &
        "    * 1x 7 → +1000 créditos" & vbCrLf &
        "    * 2x 7 → +2000 créditos" & vbCrLf &
        "    * 3x 7 → +100000 créditos" & vbCrLf &
        "- Sem 7 → perde 500 créditos." & vbCrLf &
        "- Quando o saldo chega a 0, o jogo termina."

        MsgBox(msg, vbInformation, "Índice de Ajuda")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Slot Machine VB" & vbCrLf &
           "Versão gráfica" & vbCrLf &
           "Autor: Daniil Anfinogenov, Shamin Sayed",
           vbInformation,
           "Acerca")
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
    End Sub

    Private Sub PlayButtonManual_Click(sender As Object, e As EventArgs) Handles PlayButtonManual.Click
        PlayButton.PerformClick()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        jackPotFrame = jackPotFrame Mod 2
        Dim frameWidth = 480
        Dim frameHeight = 200
        Dim frame = New Bitmap(480, 200)
        Using g As Graphics = Graphics.FromImage(frame)
            Dim srcPrev As New Rectangle(0, frameHeight * jackPotFrame, frameWidth, frameHeight)
            Dim dstPrev As New Rectangle(0, 0, frameWidth, frameHeight)
            g.DrawImage(jackpotSpriteSheet, dstPrev, srcPrev, GraphicsUnit.Pixel)
        End Using
        JackPotCongratsMsg.Image = frame
        Timer4_delta += 1
        jackPotFrame += 1

        If Timer4_delta >= 20 Then
            JackPotCongratsMsg.Visible = False
            jackPotFrame = 0
            Timer4_delta = 0
            Timer4.Stop()
        End If

    End Sub
End Class
