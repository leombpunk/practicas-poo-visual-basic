Public Class Linea
    Private _codigoArea As UShort
    Private _estado As String
    Private _numero As UInteger
    Sub New()
        _codigoArea = 0
        _estado = ""
        _numero = 0
    End Sub
    Sub New(codigoarea As UShort, numero As UInteger)
        Me.New()
        Me.CodigoArea = codigoarea
        Me.Numero = numero
    End Sub
    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            _codigoArea = value
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            _numero = value
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property
    Public Sub suspender()
        _estado = "suspendida"
    End Sub
    Public Sub reactivar()
        _estado = "activa"
    End Sub
End Class
