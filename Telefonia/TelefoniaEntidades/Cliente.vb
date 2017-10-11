Public Class Cliente
    Private _id As Int32
    Private _lineas As List(Of Linea)
    Sub New()
        _id = 0
        _lineas = New List(Of Linea)
    End Sub
    Public Property Id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property
    Public Sub addLinea(linea As Linea)
        If linea.Cliente IsNot Nothing Then
            Dim otroCliente = linea.Cliente
            otroCliente.removeLinea(linea)
            'o
            'linea.Cliente.removeLinea(linea)
        End If
        linea.Cliente = Me
        _lineas.Add(linea)
    End Sub
    Public Sub removeLinea(linea As Linea)
        linea.Cliente = Nothing
        _lineas.Remove(linea)
    End Sub
    Public Function getAllLineas() As List(Of Linea)
        Return _lineas
    End Function
End Class
