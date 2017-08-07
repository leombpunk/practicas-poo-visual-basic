Public Class Cotorra
    Inherits Loro
    Private validator As Int32
    Sub New()
        MyBase.New()
        validator = 0
    End Sub
    Public ReadOnly Property EdadHumana() As UShort
        Get
            Return MyBase.Edad * 2
        End Get
    End Property
    Public Overrides Sub Escuchar(value As String)
        If Valid() Then
            MyBase.Escuchar(value)
        End If
    End Sub
    Private Function Valid() As Boolean
        If validator = 1 Then
            validator = 0
            Return True
        Else
            validator = 1
            Return False
        End If
    End Function
End Class
