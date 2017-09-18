Public Class Cliente
    Private _id As Int32
    'update
    Private _linea As List(Of Linea)
    Sub New()
        _id = 0
        _linea = New List(Of Linea)
    End Sub
    Public Property Id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property
    'update
    Public Sub addLinea(linea As Linea)
        _linea.Add(linea)
    End Sub
    Public Sub removeLinea(linea As Linea)
        _linea.Remove(linea)
    End Sub
    Public Function getAllLineas() As List(Of Linea)
        Return _linea
    End Function
End Class
