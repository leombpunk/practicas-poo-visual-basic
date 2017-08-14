Public Class Equipo
    Private _nombre As String
    Sub New()
        _nombre = ""
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
End Class
