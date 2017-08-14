Public Class Persona
    Private _fechaNacimiento As Date
    Private _nombre As String
    Sub New()
        _fechaNacimiento = Nothing
        _nombre = ""
    End Sub
    Sub New(fechanacimiento As Date, nombre As String)
        Me.New()
        Me.Nombre = nombre
        Me.FechaNacimiento = fechanacimiento
    End Sub
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
            'If CalcularEdad() >= 16 Then
            '    _fechaNacimiento = value
            'Else
            '    _fechaNacimiento = Nothing
            'End If
        End Set
    End Property
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
    Public ReadOnly Property Edad As UInt16
        Get
            Return CalcularEdad()
        End Get
    End Property
    Private Function CalcularEdad() As UShort
        If FechaNacimiento.Month < Today.Month Or (FechaNacimiento.Month = Today.Month And FechaNacimiento.Day < Today.Day) Then
            Return DateDiff(DateInterval.Year, FechaNacimiento, Today) - 1
        End If
        Return DateDiff(DateInterval.Year, FechaNacimiento, Today)
    End Function
    Private Function ValidoLongiString(maximocaracteres As Int32, elestring As String) As Boolean
        Return If(elestring.Length <= maximocaracteres And elestring.Length > 0, True, False)
    End Function
End Class
