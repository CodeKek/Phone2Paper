Public Class Screen1

    Public ActPanel As Panel

    Private Sub Screen1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Startseite
        ShowNewPanel(FormImage.Panel1)
    End Sub

    Private Sub btImage_Click(sender As Object, e As EventArgs) Handles btImage.Click
        ShowNewPanel(FormImage.Panel1)
        Screen2.HideImage2()
    End Sub

    Private Sub btExposure_Click(sender As Object, e As EventArgs) Handles btExposure.Click
        ShowNewPanel(FormExp.Panel1)
        Screen2.HideImage2()
    End Sub
    Private Sub btCalibrate_Click(sender As Object, e As EventArgs) Handles btCalibrate.Click
        ShowNewPanel(FormCali.Panel1)
        Screen2.HideImage2()
    End Sub

    Sub ShowNewPanel(p As Panel)
        If ActPanel IsNot Nothing Then
            TableLayoutPanel1.Controls.Remove(ActPanel)
        End If
        TableLayoutPanel1.Controls.Add(p, 0, 1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Now.ToString("HH:mm")
    End Sub

    Private Sub btX_Click(sender As Object, e As EventArgs) Handles btX.Click
        Form1.MinMax()
    End Sub
End Class