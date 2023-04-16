Public Class Form1

    Dim full As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        FormCali.Init()

        Screen1.Show()
        Screen2.Show()

        'Screen2.Location = New Point(-1200, 180)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MinMax()
    End Sub

    Public Sub MinMax()
        If full Then
            Screen1_min()
            Screen2_min()
            Button1.Text = "Fullscreen"
            full = False
        Else
            Screen1_max()
            Screen2_max()
            Screen2.Label1.Visible = False
            Button1.Text = "Fenster"
            Screen2.Label1.Visible = False
            full = True
        End If
    End Sub

    Public Sub Screen2_max()
        Screen2.FormBorderStyle = FormBorderStyle.None
        Screen2.TopMost = True
        Screen2.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub Screen1_max()
        Screen1.FormBorderStyle = FormBorderStyle.None
        Screen1.TopMost = True
        Screen1.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub Screen2_min()
        Screen2.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Screen2.TopMost = False
        Screen2.WindowState = FormWindowState.Normal
    End Sub

    Public Sub Screen1_min()
        Screen1.FormBorderStyle = FormBorderStyle.SizableToolWindow
        Screen1.TopMost = False
        Screen1.WindowState = FormWindowState.Normal
    End Sub

    Public Sub WriteLog(s As String)
        Dim sr As New IO.StreamWriter(FileIO.SpecialDirectories.MyDocuments & "\ExposatorLog_" & DateAndTime.Now.ToString("yyyy-MM-dd") & ".txt", True)
        sr.WriteLine(DateAndTime.Now() & vbTab & s)
        sr.Close()
    End Sub

End Class
