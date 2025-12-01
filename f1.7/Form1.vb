Public Class Form1
    Dim spriteSheet As Bitmap
    Dim frameWidth As Integer = 64
    Dim frameHeight As Integer = 64
    Dim currentFrame = 0
    Dim totalFrames = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spriteSheet = New Bitmap(New Bitmap("C:\Users\daniel\Coding\School\FT1.7\f1.7\Assets\symbols.png"))

        Debug.WriteLine("Im Loaded")
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentFrame += 1
        If (currentFrame >= totalFrames) Then
            currentFrame = 0
        End If

        Debug.WriteLine("Im working")

        Dim srcRect As New Rectangle(currentFrame * frameWidth, 0, frameWidth, frameHeight)

        ' Destination image to display
        Dim frame = New Bitmap(frameWidth, frameHeight)
        Using g As Graphics = Graphics.FromImage(frame)
            g.DrawImage(spriteSheet, New Rectangle(0, 0, frameWidth, frameHeight), srcRect, GraphicsUnit.Pixel)
        End Using

        PictureBox1.Image = frame
    End Sub
    Private Sub PB_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
