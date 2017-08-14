Public Class Jugador
    Private _numero As UShort
    Sub New()
        _numero = 0
    End Sub
    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If ValidoRango(1, 99, value) Then
                _numero = value
            End If
        End Set
    End Property
    Private Function ValidoRango(valmin As UShort, valmax As UShort, numero As UShort)
        Return If(numero >= valmin And numero <= valmax, True, False)
    End Function
End Class