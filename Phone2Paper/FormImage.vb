Public Class FormImage

    Public Path As String
    Public File As String
    Public FileNr As Integer
    Public Image As Image
    Public ImageNegSW As Image
    Public ImageList As New List(Of String)

    Private Sub btLoad_Click(sender As Object, e As EventArgs) Handles btLoad.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then

            File = (ofd.FileName)
            Path = IO.Path.GetDirectoryName(File)

            Show_Image(File)

            ImageList.Clear()
            'ImageList.AddRange(IO.Directory.GetFiles(Path))
            For Each f In IO.Directory.GetFiles(Path)
                Dim ex As String = IO.Path.GetExtension(f).ToLower
                If ex = ".jpg" Or ex = ".bmp" Or ex = ".png" Then
                    ImageList.Add(f)
                End If
            Next

            For i = 0 To ImageList.Count - 1
                If ImageList(i) = File Then
                    FileNr = i
                End If
            Next

        End If
    End Sub

    Private Sub btMinus_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If FileNr = 0 Then
            FileNr = ImageList.Count - 1
        Else
            FileNr -= 1
        End If

        File = ImageList(FileNr)
        Show_Image(File)

    End Sub

    Private Sub btPlus_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FileNr += 1

        If FileNr >= ImageList.Count Then
            FileNr = 0
        End If

        File = ImageList(FileNr)
        Show_Image(File)

    End Sub


    Sub Show_Image(file As String)

        Image = Image.FromFile(file)
        If Image.Height > Image.Width Then
            Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If

        PictureBox1.Image = Red(Image)
        ImageNegSW = Invert(Gray(Image))
        ImageNegSW.RotateFlip(RotateFlipType.RotateNoneFlipX)

        FormExp.InitAnjustParameters()

        Label1.Text = file

    End Sub

    Public Function Red(ByVal SourceImage As Image) As Image
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {1, 0, 0, 0, 0},
            New Single() {0, 0, 0, 0, 0},
            New Single() {0, 0, 0, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

        Dim bmp As New Bitmap(SourceImage)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, bmp.Width, bmp.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using

        System.GC.Collect()

        Return bmp
    End Function

    Public Function Invert(ByVal Image As Image) As Image
        Dim ImgAttr As New Imaging.ImageAttributes()
        'Standard-ColorMatrix für Invertierung

        Dim ColorMatrix As New Imaging.ColorMatrix(New Single()() {
           New Single() {-1, 0, 0, 0, 0},
           New Single() {0, -1, 0, 0, 0},
           New Single() {0, 0, -1, 0, 0},
           New Single() {0, 0, 0, 1, 0},
           New Single() {1, 1, 1, 0, 1}
        })

        ImgAttr.SetColorMatrix(ColorMatrix)
        Dim NewBitmap = New Bitmap(Image.Width, Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        NewBitmap.SetResolution(Image.HorizontalResolution, Image.VerticalResolution)
        Dim NewGraphics As Graphics = Graphics.FromImage(NewBitmap)
        NewGraphics.DrawImage(Image, New Rectangle(0, 0, NewBitmap.Width, NewBitmap.Height), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, ImgAttr)
        NewGraphics.Dispose()
        ImgAttr.Dispose()
        Return NewBitmap

    End Function

    Public Function Gray(ByVal SourceImage As Image) As Image
        Dim grayscale As New Imaging.ColorMatrix(New Single()() _
        {
            New Single() {0.299, 0.299, 0.299, 0, 0},
            New Single() {0.587, 0.587, 0.587, 0, 0},
            New Single() {0.114, 0.114, 0.114, 0, 0},
            New Single() {0, 0, 0, 1, 0},
            New Single() {0, 0, 0, 0, 1}
        })

        Dim bmp As New Bitmap(SourceImage)
        Dim imgattr As New Imaging.ImageAttributes()
        imgattr.SetColorMatrix(grayscale)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, bmp.Width, bmp.Height,
                    GraphicsUnit.Pixel, imgattr)
        End Using

        Return bmp
    End Function

End Class