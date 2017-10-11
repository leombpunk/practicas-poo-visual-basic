Public Class Torneo
    Private _nombre As String
    Private _partidos As List(Of Partido)
    Sub New()
        _nombre = ""
        _partidos = New List(Of Partido)
    End Sub
    Sub New(nombre As String)
        Me.New()
        Me.Nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidoLongiString(50, value) Then
                _nombre = value
            End If
        End Set
    End Property
    Public Sub addPartido(partido As Partido)
        If partido.Torneo IsNot Nothing Then
            Dim otrotorneo = partido.Torneo
            otrotorneo.removePartido(partido)
        End If
        partido.Torneo = Me
        _partidos.Add(partido)
    End Sub
    Public Sub removePartido(partido As Partido)
        partido.Torneo = Nothing
        _partidos.Remove(partido)
    End Sub
    Public Function getAllPartidos() As List(Of Partido)
        Return _partidos
    End Function
    Private Function ValidoLongiString(maximocaracteres As Int32, elestring As String) As Boolean
        Return If(elestring.Length > 0 And elestring.Length <= maximocaracteres, True, False)
    End Function
End Class
