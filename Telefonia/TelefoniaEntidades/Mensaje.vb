Public Class Mensaje
    Inherits Plan
    Sub New()
        MyBase.New()
    End Sub
    Sub New(credito As UInt32, nombre As String, precio As Single)
        MyBase.New(credito, nombre, precio)
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.Nombre
    End Function

    Public Overrides Function disponible() As String
        Return Me.Credito - _consumo & " mensajes"
    End Function
End Class
