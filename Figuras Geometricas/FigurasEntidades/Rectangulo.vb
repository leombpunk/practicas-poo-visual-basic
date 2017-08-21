Public Class Rectangulo
    Inherits Figura
    Private _altura As UInt16
    Private _base As UInt16
    Sub New()
        MyBase.New()
        _altura = 0
        _base = 0
    End Sub
    Public Property Altura As UInt16
        Get
            Return _altura
        End Get
        Set(value As UInt16)
            _altura = value
        End Set
    End Property
    Public Property Base As UInt16
        Get
            Return _base
        End Get
        Set(value As UInt16)
            _base = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single
        Return Base * Altura
    End Function
End Class
