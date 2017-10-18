Imports TelefoniaEntidades

Public Class Paquete
    Implements Servicio
    Private _planes As List(Of Plan)

    Public Property Nombre As String Implements Servicio.Nombre
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property Precio As Single Implements Servicio.Precio
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Single)
            Throw New NotImplementedException()
        End Set
    End Property

    Sub New()
        _planes = New List(Of Plan)
    End Sub
    Public Sub addPlan(plan As Plan)
        If _planes.Count < 3 Then
            _planes.Add(plan)
        End If
    End Sub
    Public Function getAllPlan() As List(Of Plan)
        Return _planes
    End Function
    Public Sub removePlan(plan As Plan)
        _planes.Remove(plan)
    End Sub

    Public Function getDisponible() As String Implements Servicio.getDisponible
        Throw New NotImplementedException()
    End Function
End Class