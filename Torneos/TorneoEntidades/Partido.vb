Public Class Partido
    Private _fecha As Date
    Private _golesLocal As UShort
    Private _golesVisitante As UShort
    Private _minutosGolesLocal As List(Of UShort)
    Private _minutosGolesVisitante As List(Of UShort)
    Private _estadoDelPartido As Boolean
    Sub New()
        _fecha = Nothing
        _golesLocal = 0
        _golesVisitante = 0
        _minutosGolesLocal = New List(Of UShort)
        _minutosGolesVisitante = New List(Of UShort)
        _estadoDelPartido = True
    End Sub
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public ReadOnly Property GolesLocal As UShort
        Get
            Return _golesLocal
        End Get
    End Property
    Public ReadOnly Property GolesVisitante As UShort
        Get
            Return _golesVisitante
        End Get
    End Property
    Public ReadOnly Property MinutosGolesLocal As List(Of UShort)
        Get
            Return _minutosGolesLocal
        End Get
    End Property
    Public ReadOnly Property MinutosGolesVisitante As List(Of UShort)
        Get
            Return _minutosGolesVisitante
        End Get
    End Property
    Public Sub Finalizado()
        _estadoDelPartido = False
    End Sub
    Public Sub nuevoGolLocal(minutos As UShort)
        If _estadoDelPartido Then
            _golesLocal += 1
            _minutosGolesLocal.Add(minutos)
        End If
    End Sub
    Public Sub nuevoGolVisitante(minutos As UShort)
        If _estadoDelPartido Then
            _golesVisitante += 1
            _minutosGolesVisitante.Add(minutos)
        End If
    End Sub
End Class
