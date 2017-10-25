Public Class MegaByte
    Inherits Plan
    Private Const unMB As UInt32 = 1048576
    Sub New()
        MyBase.New()
    End Sub
    Sub New(credito As UInt32, nombre As String, precio As Single)
        MyBase.New(credito, nombre, precio)
    End Sub
    Public Overrides Sub addConsumo(valor As UInteger)
        Dim losMbytes As Double
        losMbytes = valor / unMB
        If _consumo + losMbytes < 50 Then 'limite 50MB
            _consumo += losMbytes
        End If
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre & "-" & getDisponible()
    End Function
    Public Overrides Function getDisponible() As String
        Return Credito - _consumo & " megabytes"
    End Function
    'Public Overrides Function disponible() As String
    '    Return Me.Credito - _consumo & " megabytes"
    'End Function
End Class
