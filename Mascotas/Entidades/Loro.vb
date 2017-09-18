Public Class Loro
    Private _fechaNacimiento As Date
    Private _memoria As Queue(Of String)
    Private _nombre As String
    Private _texto As String
    Sub New()
        _fechaNacimiento = Nothing
        _memoria = New Queue(Of String)
        _nombre = ""
        _texto = ""
    End Sub
    Public ReadOnly Property Edad() As Short
        Get
            Return CalcularEdad(_fechaNacimiento)
        End Get
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private Function CalcularEdad(fechanaci As Date) As Int32
        If FechaNacimiento.Month < Today.Month Or (FechaNacimiento.Month = Today.Month And FechaNacimiento.Day < Today.Day) Then
            Return DateDiff(DateInterval.Year, FechaNacimiento, Today) - 1
        End If
        Return DateDiff(DateInterval.Year, FechaNacimiento, Today)
    End Function
    Public Overrides Function ToString() As String
        Return _nombre.ToString
    End Function
    Public Overridable Sub Escuchar(value As String)
        _memoria.Enqueue(value)
    End Sub
    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            _texto += _memoria.Dequeue() + " "
        End If
        Return _texto
    End Function
End Class
