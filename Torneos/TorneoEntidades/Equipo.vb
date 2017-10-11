Public Class Equipo
    Private _nombre As String
    Private _jugadores As List(Of Jugador)
    Sub New()
        _nombre = ""
        _jugadores = New List(Of Jugador)
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
            If ValidoLongiString(30, value) Then
                _nombre = value
            End If
        End Set
    End Property
    Private Function ValidoLongiString(maximocaracteres As Int32, elestring As String) As Boolean
        Return If(elestring.Length <= maximocaracteres And elestring.Length > 0, True, False)
    End Function
    Public Overrides Function ToString() As String
        Return "Nombre: " & Nombre
    End Function
    Public Sub addJugador(jugador As Jugador)
        If jugador.equipo IsNot Nothing Then
            Dim otroequipo = jugador.equipo
            otroequipo.removeJugador(jugador)
        End If
        jugador.equipo = Me
        _jugadores.Add(jugador)
    End Sub
    Private Sub removeJugador(jugador As Jugador)
        jugador.equipo = Nothing
        _jugadores.Remove(jugador)
    End Sub
    Public Function getAllJugadores() As List(Of Jugador)
        Return _jugadores
    End Function
End Class
