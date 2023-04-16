Public Class FormExp

    Public Zoom As Double = 0.4
    Public Xpos As Integer = 640  'welche Bildkoordinaten sind in der Picbox-Mitte
    Public Ypos As Integer = 370   'welche Bildkoordinaten sind in der Picbox-Mitte
    Dim delta As Integer = 10

    Public testmode As Boolean = False
    Public expmode As Boolean = False


    '##### Test #####

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click
        If testmode Then
            testmode = False
            btTest.Text = "Test"
            btExposure.Visible = True

            Screen2.HideImage2()

        Else
            testmode = True
            btTest.Text = "Stop"
            btExposure.Visible = False

            Screen2.PictureBox1.Invalidate()
        End If

        If expmode Then
            ExpEnde()
            Form1.WriteLog("Stop ")

        End If

    End Sub

    Private Sub btZout_Click(sender As Object, e As EventArgs) Handles btZout.Click
        If testmode Then
            Zoom = Zoom / 1.1
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub
    Private Sub btZin_Click(sender As Object, e As EventArgs) Handles btZin.Click
        If testmode Then
            Zoom = Zoom * 1.1
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Sub Calc_Pos()
        'Dim relW As Double = FormImage.ImageNegSW.Width / PictureBox1.Width * FormExp.Zoom
        'Dim relH As Double = FormImage.ImageNegSW.Height / PictureBox1.Height * FormExp.Zoom

        Dim mitteX As Double = Screen2.PictureBox1.Width / Zoom / 2
        Dim mitteY As Double = Screen2.PictureBox1.Height / Zoom / 2

        Xpos = mitteX - FormImage.ImageNegSW.Width / 2
        Ypos = mitteY - FormImage.ImageNegSW.Height / 2

    End Sub


    Private Sub btUp_Click(sender As Object, e As EventArgs) Handles btUp.Click
        If testmode Then
            Ypos += delta / Zoom
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub btLeft_Click(sender As Object, e As EventArgs) Handles btLeft.Click
        If testmode Then
            Xpos -= delta / Zoom
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub btDown_Click(sender As Object, e As EventArgs) Handles btDown.Click
        If testmode Then
            Ypos -= delta / Zoom
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub btRight_Click(sender As Object, e As EventArgs) Handles btRight.Click
        If testmode Then
            Xpos += delta / Zoom
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    '##### Exposure #####

    Public GammaVal As Double = 1
    Public Duration As Double = 5
    Dim Remain As Double

    Private Sub btExposure_Click(sender As Object, e As EventArgs) Handles btExposure.Click

        expmode = True
        Timer1.Start()
        Remain = Duration
        Screen2.PictureBox1.Invalidate()
        btTest.Text = "Stop"
        btExposure.Text = Remain & " s"

        Form1.WriteLog("Exposure " & vbTab & FormImage.File & vbTab & Duration & vbTab & GammaVal & vbTab & CInt(100 * Zoom) & vbTab & Xpos & vbTab & Ypos)

    End Sub
    Private Sub btExpMin_Click(sender As Object, e As EventArgs) Handles btExpMin.Click
        Duration = Math.Max(1, Duration - 1)
        Label1.Text = Duration & " s"
    End Sub
    Private Sub btExpPlu_Click(sender As Object, e As EventArgs) Handles btExpPlu.Click
        Duration += 1
        Label1.Text = Duration & " s"
    End Sub

    Private Sub btGamMin_Click(sender As Object, e As EventArgs) Handles btGamMin.Click
        If testmode Then
            GammaVal = Math.Max(0.1, GammaVal - 0.1)
            Label2.Text = GammaVal.ToString("F1")
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub btGamPlu_Click(sender As Object, e As EventArgs) Handles btGamPlu.Click
        If testmode Then
            GammaVal += 0.1
            Label2.Text = GammaVal.ToString("F1")
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub bt100_Click(sender As Object, e As EventArgs) Handles bt100.Click

        If testmode Then
            InitAnjustParameters()
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub rotCCW_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If testmode Then
            FormImage.ImageNegSW.RotateFlip(RotateFlipType.Rotate270FlipNone)

            Dim tempX As Double = Xpos
            Xpos = Ypos
            Ypos = FormImage.ImageNegSW.Height - tempX
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Private Sub rotCW_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If testmode Then
            FormImage.ImageNegSW.RotateFlip(RotateFlipType.Rotate90FlipNone)

            Dim tempY As Double = Ypos
            Ypos = Xpos
            Xpos = FormImage.ImageNegSW.Width - tempY
            Screen2.PictureBox1.Invalidate()
        End If
    End Sub

    Sub InitAnjustParameters()
        If testmode Then
            Dim h = FormImage.ImageNegSW.Height
            Dim w = FormImage.ImageNegSW.Width
            Zoom = Math.Min(Screen2.PictureBox1.Width / w, Screen2.PictureBox1.Height / h)
            Xpos = w / 2
            Ypos = h / 2
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '1000 ms
        Beep()
        Remain = Remain - 1
        btExposure.Text = Remain & " s"

        If Remain <= 0 Then
            ExpEnde()
        End If

    End Sub


    Sub ExpEnde()

        Remain = 0
        Timer1.Stop()
        Screen2.HideImage2()
        expmode = False
        btExposure.Text = "Exposure"
        btExposure.Visible = True
        btTest.Text = "Test"

    End Sub

End Class