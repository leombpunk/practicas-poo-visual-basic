Public Class Cuadrado
    Inherits Figura
    Private _lado As UInt16
    Sub New()
        MyBase.New()
        _lado = 0
    End Sub
    Public Property Lado As UInt16
        Get
            Return _lado
        End Get
        Set(value As UInt16)
            _lado = value
        End Set
    End Property
    Public Overrides Function CalcularArea() As Single
        Return Math.Pow(Lado, 2) 'o Lado*Lado
    End Function
End Class
