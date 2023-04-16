Public Class FormCali

    Public Gmax As New Numerik With {.Titel = "Gamma max", .Min = 0.1, .Max = 3, .Inc = 0.1, .Value = 1.2}
    Public Gmin As New Numerik With {.Titel = "Gamma min", .Min = 0.1, .Max = 3, .Inc = 0.1, .Value = 0.3}
    Public Gsteps As New Numerik With {.Titel = "Gamma steps", .Min = 2, .Max = 10, .Inc = 1, .Value = 6}

    Public Emax As New Numerik With {.Titel = "Exp max", .Unit = " s", .Min = 1, .Max = 300, .Inc = 1, .Value = 10}
    Public Emin As New Numerik With {.Titel = "Exp min", .Unit = " s", .Min = 1, .Max = 300, .Inc = 1, .Value = 2}
    Public Esteps As New Numerik With {.Titel = "Exp steps", .Min = 2, .Max = 10, .Inc = 1, .Value = 3}
    Public Estep As Integer

    Public Zoom As New Numerik With {.Titel = "Zoom", .Unit = " %", .Min = 1, .Max = 100, .Inc = 5, .Value = 50}
    Public PosX As New Numerik With {.Titel = "X", .Unit = " %", .Min = 0, .Max = 100, .Inc = 5, .Value = 10}
    Public PosY As New Numerik With {.Titel = "Y", .Unit = " %", .Min = 0, .Max = 100, .Inc = 5, .Value = 10}

    Public Remain As Integer
    Public CaliTimes As New List(Of Integer)
    Public testmode As Boolean = False


    Public Sub Init()

        TableLayoutPanel1.Controls.Add(Emin.Panel1, 1, 3)
        TableLayoutPanel1.Controls.Add(Emax.Panel1, 1, 5)
        TableLayoutPanel1.Controls.Add(Esteps.Panel1, 1, 7)

        TableLayoutPanel1.Controls.Add(Gmin.Panel1, 3, 3)
        TableLayoutPanel1.Controls.Add(Gmax.Panel1, 3, 5)
        TableLayoutPanel1.Controls.Add(Gsteps.Panel1, 3, 7)

        TableLayoutPanel1.Controls.Add(PosX.Panel1, 5, 3)
        TableLayoutPanel1.Controls.Add(PosY.Panel1, 5, 5)
        TableLayoutPanel1.Controls.Add(Zoom.Panel1, 5, 7)

        AddHandler Emin.changed, AddressOf ChangeDisplay
        AddHandler Emax.changed, AddressOf ChangeDisplay
        AddHandler Esteps.changed, AddressOf ChangeDisplay
        AddHandler Gmin.changed, AddressOf ChangeDisplay
        AddHandler Gmax.changed, AddressOf ChangeDisplay
        AddHandler Gsteps.changed, AddressOf ChangeDisplay
        AddHandler PosX.changed, AddressOf ChangeDisplay
        AddHandler PosY.changed, AddressOf ChangeDisplay
        AddHandler Zoom.changed, AddressOf ChangeDisplay

    End Sub

    Private Sub btTest_Click(sender As Object, e As EventArgs) Handles btTest.Click

        If testmode Then
            testmode = False
            btTest.Text = "Test"
            btCalibrate.Visible = True

            Screen2.HideImage2()

            Screen2.calibmode = False
        Else
            testmode = True
            btTest.Text = "Stop"
            btCalibrate.Visible = False

            Remain = 0
            Display()

        End If


    End Sub


    Private Sub btCalibrate_Click(sender As Object, e As EventArgs) Handles btCalibrate.Click

        Timer1.Interval = 1000
        Timer1.Start()

        Remain = Emax.Value
        Display()

    End Sub

    Sub ChangeDisplay()
        If testmode Then Display()
    End Sub

    Sub Display()
        Screen2.calibmode = True
        Calc_Calib()
        Estep = Esteps.Value
        Screen2.PictureBox1.Invalidate()
    End Sub


    Sub Calc_Calib()
        CaliTimes.Clear()
        Dim factor As Double = Math.Pow(Emax.Value / Emin.Value, 1 / (Esteps.Value - 1))
        For i = Esteps.Value - 1 To 0 Step -1
            CaliTimes.Add(CInt(Emin.Value * factor ^ i))
        Next
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '1000 ms
        Beep()
        Remain = Remain - 1
        btCalibrate.Text = Remain & " s"

        Screen2.PictureBox1.Invalidate()

        If Remain <= 0 Then
            End_Calib()
            Timer1.Stop()
        End If

    End Sub

    Sub End_Calib()

        Screen2.calibmode = False
        'Screen2.noimagemode = True
        'Screen2.Invalidate()
        Screen2.HideImage2()
        btCalibrate.Text = "Calibrate"
    End Sub

End Class