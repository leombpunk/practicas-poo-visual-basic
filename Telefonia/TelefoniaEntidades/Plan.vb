Imports TelefoniaEntidades

Public MustInherit Class Plan
    Implements Servicio

    Private _credito As UInt32
    Private _nombre As String
    Private _precio As Single
    Protected _consumo As Double
    Sub New()
        _credito = 0
        _nombre = ""
        _precio = 0
        _consumo = 0
    End Sub
    Sub New(credito As UInt32, nombre As String, precio As Single)
        Me.New()
        Me.Credito = credito
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub
    Public Property Credito As UInt32 'monto minuto >= 50 para los megabytes?
        Get
            Return _credito
        End Get
        Set(value As UInt32)
            _credito = value
            'If value >= 50 Then
            '    _credito = value
            'End If
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Precio As Single
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property

    Private Property Servicio_Nombre As String Implements Servicio.Nombre
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property Servicio_Precio As Single Implements Servicio.Precio
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Single)
            Throw New NotImplementedException()
        End Set
    End Property

    Public MustOverride Function disponible() As String
    Public Overridable Sub addConsumo(valor As UInt32)
        If _consumo + valor < Credito Then
            _consumo += valor
        End If
    End Sub

    Public Function getDisponible() As String Implements Servicio.getDisponible
        Throw New NotImplementedException()
    End Function
End Class
