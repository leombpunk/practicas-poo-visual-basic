Public Class Equipo
    Private _marca As String
    Private _modelo As String
    Private _serie As String
    Private _fechaVenta As Date
    Sub New()
        _marca = ""
        _modelo = ""
        _serie = ""
        _fechaVenta = Nothing
    End Sub
    Sub New(marca As String, modelo As String, serie As String)
        Me.New()
        Me.Marca = marca
        Me.Modelo = modelo
        Me.Serie = serie
    End Sub
    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            If ValidoVacio(value) And ValidoLonguiString(30, value) Then
                _marca = value
            End If
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            If ValidoVacio(value) And ValidoLonguiString(50, value) Then
                _modelo = value
            End If
        End Set
    End Property
    Public Property Serie As String
        Get
            Return _serie
        End Get
        Set(value As String)
            If ValidoVacio(value) And ValidoLonguiString(15, value) Then
                _serie = value
            End If
        End Set
    End Property
    Public ReadOnly Property FechaVenta As Date
        Get
            Return _fechaVenta
        End Get
    End Property
    Public WriteOnly Property Venta As Date
        Set(value As Date)
            _fechaVenta = value
        End Set
    End Property
    Private Function ValidoVacio(value As String) As String
        Return Not (value Is Nothing)
    End Function
    Private Function ValidoLonguiString(maximo As Int32, elstring As String) As Boolean
        Return If(elstring.Length < maximo, True, False)
    End Function
End Class
