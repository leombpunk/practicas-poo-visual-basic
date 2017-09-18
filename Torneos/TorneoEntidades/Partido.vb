Public Class Partido
    'alternatica a contar los goles, usar el metodo count de la coleccion
    Private _fecha As Date
    Private _golesLocal As UShort
    Private _golesVisitante As UShort
    Private _minutosGolesLocal As List(Of UShort)
    Private _minutosGolesVisitante As List(Of UShort)
    Private _estadoDelPartido As Boolean
    'update
    Private _referee As Referee
    Private _local As Equipo
    Private _visitante As Equipo
    Sub New()
        _fecha = Nothing
        _golesLocal = 0
        _golesVisitante = 0
        _minutosGolesLocal = New List(Of UShort)
        _minutosGolesVisitante = New List(Of UShort)
        _estadoDelPartido = True
        _referee = New Referee
        _local = New Equipo
        _visitante = New Equipo
    End Sub
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    'update
    Public Property Referee As Referee
        Get
            Return _referee
        End Get
        Set(value As Referee)
            _referee = value
        End Set
    End Property
    Public Property Local As Equipo
        Get
            Return _local
        End Get
        Set(value As Equipo)
            _local = value
        End Set
    End Property
    Public Property Visitante As Equipo
        Get
            Return _visitante
        End Get
        Set(value As Equipo)
            _visitante = value
        End Set
    End Property
    'end update
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
    Public Overrides Function ToString() As String
        Return Local.Nombre & "(" & GolesLocal & ")-VS-" & Visitante.Nombre & "(" & GolesVisitante & ")"
    End Function
End Class
