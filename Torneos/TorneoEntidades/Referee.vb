Public Class Referee
    Private _internacional As Boolean
    Sub New()
        _internacional = False
    End Sub
    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property
End Class