Public Class Jaula
    Private _nombre As String
    Private _loro As Loro
    Private _cotorras As List(Of Cotorra)
    Sub New()
        _nombre = ""
        _loro = New Loro
        _cotorras = New List(Of Cotorra)
    End Sub
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return "Esta es la jaula: " + Nombre
    End Function
    Public Sub AddCotorra(coto As Cotorra)
        If _cotorras.Count < 3 Then
            _cotorras.Add(coto)
        End If
    End Sub
    Public Function getAllcotorras() As List(Of Cotorra)
        Return _cotorras
    End Function
End Class
