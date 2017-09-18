Public Class Referee
    Inherits Persona
    Private _internacional As Boolean
    Sub New()
        MyBase.New()
        _internacional = False
    End Sub
    Sub New(nombre As String, fechanacimiento As Date, internacional As Boolean)
        Me.New()
        Me.Nombre = nombre
        Me.FechaNacimiento = fechanacimiento
        Me.Internacional = internacional
    End Sub
    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        If Internacional Then
            Return "Nombre: " & Nombre & "(I)"
        End If
        Return "Nombre: " & Nombre
    End Function
End Class