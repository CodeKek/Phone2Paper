Public Class Screen2

    Dim g As Graphics

    Public calibmode As Boolean = False
    Public noimagemode As Boolean = False

    'Public Sub ShowImage()

    '    ' PictureBox1.Image = FormImage.ImageNegSW
    '    g = PictureBox1.CreateGraphics().FromImage(FormImage.ImageNegSW)
    '    g.ScaleTransform(FormExp.Zoom, FormExp.Zoom)
    '    If FormImage.ImageNegSW IsNot Nothing Then
    '        g.DrawImage(Gamma(FormImage.ImageNegSW, FormExp.GammaVal), 20, -20)
    '    End If
    '    'PictureBox1.Image = Gamma(FormImage.ImageNegSW, FormExp.GammaVal)

    'End Sub

    Public Sub HideImage()
        g = PictureBox1.CreateGraphics()
        g.Clear(Color.Black)
    End Sub

    Public Sub HideImage2()
        noimagemode = True
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        If noimagemode Then
            NoImage()
            noimagemode = False
        Else
            If Not calibmode Then
                Image(e)
            Else
                Greyscales(e)
            End If
        End If

        GC.Collect()

    End Sub

    Private Sub Image(ByVal e As System.Windows.Forms.PaintEventArgs)

        g = e.Graphics

        Try

            Dim pbW As Integer = PictureBox1.Width
            Dim pbH As Integer = PictureBox1.Height

            Dim imW As Integer = FormImage.ImageNegSW.Width
            Dim imH As Integer = FormImage.ImageNegSW.Height

            Dim z As Double = FormExp.Zoom

            Dim pX As Integer = FormExp.Xpos
            Dim pY As Double = FormExp.Ypos

            Dim eckeX As Integer = CInt(pbW / 2 / z - pX)
            Dim eckeY As Integer = CInt(pbH / 2 / z - pY)


            g.ScaleTransform(FormExp.Zoom, FormExp.Zoom)
            If FormImage.ImageNegSW IsNot Nothing Then
                g.DrawImage(Gamma(FormImage.ImageNegSW, FormExp.GammaVal), eckeX, eckeY)
            End If

            '          Console.WriteLine("Zoom: " & z.ToString("F2") & ", X0: " & eckeX & ", Y0: " & eckeY & ", px: " & FormExp.Xpos & ", py: " & FormExp.Ypos)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub NoImage()
        g = PictureBox1.CreateGraphics()
        g.Clear(Color.Black)
    End Sub

    Public Sub Greyscales(ByVal e As System.Windows.Forms.PaintEventArgs)

        g = e.Graphics

        Dim linewidth As Integer = 4
        Dim l As Integer = linewidth / 2

        Dim remain As Integer = FormCali.Remain
        Dim estps As Integer = FormCali.Esteps.Value
        Dim gmin As Double = FormCali.Gmin.Value
        Dim gmax As Double = FormCali.Gmax.Value
        Dim gstps As Double = FormCali.Gsteps.Value

        Dim posx As Double = FormCali.PosX.Value / 100
        Dim posy As Double = FormCali.PosY.Value / 100
        Dim zoom As Double = FormCali.Zoom.Value / 100


        Dim pbW As Integer = PictureBox1.Width
        Dim pbH As Integer = PictureBox1.Height

        Dim w As Integer = pbW / (estps) - l
        Dim h As Integer = pbH / (gstps) - l

        Dim x As Integer
        Dim y As Integer

        Dim m As New Drawing2D.Matrix(-1, 0, 0, 1, pbW * zoom, 0)
        g.Transform = m

        g.ScaleTransform(FormCali.Zoom.Value / 100, FormCali.Zoom.Value / 100)

        Dim tx As Integer = (pbW / zoom) * (-posx) * (1 - zoom) '-wegen spiegeln
        Dim ty As Integer = (pbH / zoom) * posy * (1 - zoom)
        g.TranslateTransform(tx, ty)


        'Zeit-schleife
        For t = 0 To estps - 1
            x = t * w + l

            If remain <= FormCali.CaliTimes(t) Then

                'Gamma Schleife
                For gstp = 0 To gstps - 1
                    y = gstp * h + l

                    Dim pen As Pen = New Pen(Color.Gray, linewidth)
                    g.DrawRectangle(pen, x, y, w, h)

                    'Gamma Wert
                    Dim gamma As Double = gmin + (gstp / (gstps - 1)) * (gmax - gmin)

                    Dim w2 As Integer = (w - linewidth) / 17 '16+1 !!!
                    Dim h2 As Integer = (h - linewidth) / 2
                    'Felder-Schleife
                    For i = 0 To 16
                        Dim grauwert As Byte = 255 * ((i / 16) ^ gamma)
                        Dim brush As Brush = New SolidBrush(Color.FromArgb(grauwert, grauwert, grauwert))

                        g.FillRectangle(brush, x + l + i * w2, y + l, w2, h2)

                    Next

                    Dim f As New Font(FontFamily.GenericSansSerif, h2 / 2, FontStyle.Bold, GraphicsUnit.Point)
                    Dim s As String = FormCali.CaliTimes(t) & " s, G" & Math.Round(gamma, 2)
                    g.DrawString(s, f, Brushes.White, x + w2, y + h2)

                Next

            End If
        Next

    End Sub

    Public Function Gamma(ByVal SourceImage As Image, value As Double) As Image

        Dim bmp As New Bitmap(SourceImage)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetGamma(value, Imaging.ColorAdjustType.Bitmap)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, bmp.Width, bmp.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using

        Return bmp
    End Function

End Class