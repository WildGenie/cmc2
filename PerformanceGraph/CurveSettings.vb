Public Class CurveSettings

    Private _Name
    Private _LineThickness As Integer
    Private _LineTension As Single
    Private _Filled As Boolean
    Private _colour As Color

    Protected Friend Sub Add(ByVal Name As String)
        _Name = Name
    End Sub
    Protected Friend Sub Add(ByVal Name As String, ByVal LoadDefault As Boolean)
        _Name = Name
        Me.LoadDefaults()
    End Sub
    Protected Friend Sub Add(ByVal Name As String, ByVal LineThickness As Integer, ByVal LineTension As Single, ByVal filled As Boolean, ByVal LineColour As Color)
        _Name = Name
        _LineThickness = LineThickness
        _LineTension = LineTension
        _Filled = filled
        _colour = LineColour
    End Sub

    Protected Friend Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Protected Friend Property LineThickness() As Single
        Get
            Return _LineThickness
        End Get
        Set(ByVal value As Single)
            _LineThickness = value
        End Set
    End Property

    Protected Friend Property LineTension() As Single
        Get
            Return _LineTension
        End Get
        Set(ByVal value As Single)
            _LineTension = value
        End Set
    End Property

    Protected Friend Property Filled() As Boolean
        Get
            Return _Filled
        End Get
        Set(ByVal value As Boolean)
            _Filled = value
        End Set
    End Property

    Protected Friend Property LineColor() As Color
        Get
            Return _colour
        End Get
        Set(ByVal value As Color)
            _colour = value
        End Set
    End Property

    Private Sub LoadDefaults()
        Me.LineThickness = 1
        Me.LineTension = 0.2
        Select Case LCase(_Name)
            Case "cpu"
                _Filled = True
                _colour = Color.Red
            Case "ram"
                _Filled = True
                _colour = Color.FromArgb(120, 220, 20) ' green
            Case "diskpercent"
                _Filled = True
                _colour = Color.FromArgb(0, 120, 220) ' blue
            Case "diskqueueread"
                _Filled = False
                _colour = Color.Blue
            Case "diskqueuewrite"
                _Filled = False
                _colour = Color.FromArgb(80, 180, 255) 'Color.DeepSkyBlue
            Case "diskioread"
                _Filled = False
                _colour = Color.FromArgb(255, 0, 128) ' pink
            Case "diskiowrite"
                _Filled = False
                _colour = Color.FromArgb(128, 0, 255) ' purple
            Case Else
                _Filled = False
                _colour = Color.FromArgb(120, 220, 20)
        End Select
    End Sub


End Class
