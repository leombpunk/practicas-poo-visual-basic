Imports TelefoniaEntidades

Public Class Paquete
    Implements IServicio
    Private _planes As List(Of Plan)
    Private _nombre As String
    Private _precio As Single
    Sub New()
        _planes = New List(Of Plan)
        _nombre = ""
        _precio = 0
    End Sub
    Public Property Nombre As String Implements IServicio.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Precio As Single Implements IServicio.Precio
        Get
            Return _precio
        End Get
        Set(value As Single)
            _precio = value
        End Set
    End Property
    Public Sub addPlan(plan As Plan)
        If _planes.Count < 3 Then
            _planes.Add(plan)
        End If
    End Sub
    Public Function getAllPlanes() As List(Of Plan)
        Return _planes
    End Function
    Public Sub removePlan(plan As Plan)
        _planes.Remove(plan)
    End Sub
    Public Function getDisponible() As String Implements IServicio.getDisponible
        Dim muestro As String = Nothing
        If _planes.Count > 0 Then
            For Each disp As Plan In _planes
                'Return disp.getDisponible
                muestro &= disp.getDisponible & " "
            Next
        End If
        Return muestro
    End Function
End Class