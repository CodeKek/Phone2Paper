Public Class Numerik

    Dim Vunit As String
    Dim Vstep As Double
    Dim Vmin As Double
    Dim Vmax As Double
    Dim Vvalue As Double

    Event changed()

    Public Property Titel As String
        Get
            Return lbTitel.Text
        End Get
        Set(value As String)
            lbTitel.Text = value
        End Set
    End Property

    Public Property Unit As String
        Get
            Return Vunit
        End Get
        Set(value As String)
            Vunit = value
        End Set
    End Property

    Public Property Inc As Double
        Get
            Return Vstep
        End Get
        Set(value As Double)
            Vstep = value
        End Set
    End Property

    Public Property Min As Double
        Get
            Return Vmin
        End Get
        Set(value As Double)
            Vmin = value
        End Set
    End Property

    Public Property Max As Double
        Get
            Return Vmax
        End Get
        Set(value As Double)
            Vmax = value
        End Set
    End Property

    Public Property Value As Double
        Get
            Return Vvalue
        End Get
        Set(v As Double)
            Vvalue = v
            Label1.Text = Vvalue & Vunit
        End Set
    End Property

    Private Sub btExpMin_Click(sender As Object, e As EventArgs) Handles btExpMin.Click
        Vvalue = Math.Max(Vvalue - Vstep, Vmin)
        Label1.Text = Vvalue & Vunit
        RaiseEvent changed()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vvalue = Math.Min(Vvalue + Vstep, Vmax)
        Label1.Text = Vvalue & Vunit
        RaiseEvent changed()
    End Sub

End Class