Public Class Circulo
    Inherits Figura
    Private _radio As UInt16
    Sub New()
        MyBase.New()
        _radio = 0
    End Sub
    Public Property Radio As UInt16
        Get
            Return _radio
        End Get
        Set(value As UInt16)
            _radio = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single
        Return Math.PI * Math.Pow(Radio, 2)
    End Function
End Class
