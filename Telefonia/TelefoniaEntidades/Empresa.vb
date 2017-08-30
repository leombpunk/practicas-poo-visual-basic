Public Class Empresa
    Inherits Cliente
    Private _razonSocial As String
    Private _cuit As String
    Sub New()
        MyBase.New()
        _razonSocial = ""
        _cuit = ""
    End Sub
    Sub New(razonsocial As String, cuit As String)
        Me.New()
        Me.RazonSocial = razonsocial
        Me.Cuit = cuit
    End Sub
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If ValidoLongiString(80, value) Then
                _razonSocial = value
            End If
        End Set
    End Property
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If ValidoLongiString(13, value) Then
                _cuit = value
            End If
        End Set
    End Property
    Private Function ValidoLongiString(maximocaracteres As Int32, elestring As String) As Boolean
        Return If(elestring.Length <= maximocaracteres, True, False)
    End Function
End Class
