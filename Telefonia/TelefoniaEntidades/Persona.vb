Public Class Persona
    Inherits Cliente
    Private _apellido As String
    Private _nombre As String
    Private _documento As UInt32
    Sub New()
        MyBase.New()
        _apellido = ""
        _nombre = ""
        _documento = 0
    End Sub
    Sub New(apellido As String, nombre As String, documento As UInt32)
        Me.New()
        Me.Apellido = apellido
        Me.Nombre = nombre
        Me.Documento = documento
    End Sub
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If ValidoLongiString(30, value) Then
                _apellido = value
            End If
        End Set
    End Property
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
    Public Property Documento As UInt32
        Get
            Return _documento
        End Get
        Set(value As UInt32)
            _documento = value
        End Set
    End Property
    Private Function ValidoLongiString(maximocaracteres As Int32, elestring As String) As Boolean
        Return If(elestring.Length <= maximocaracteres, True, False)
    End Function
End Class
