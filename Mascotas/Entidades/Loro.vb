Public Class Loro
    Private _fechaNacimiento As Date
    Private _memoria As Queue(Of String)
    Private _nombre As String
    Private _texto As String
    Public Sub New()
        _fechaNacimiento = Nothing
        _memoria = New Queue(Of String)
        _nombre = ""
        _texto = ""
    End Sub
    Public ReadOnly Property Edad(fecha_actual As Date, fecha As Date) As Short
        Get
            Return CalcularEdad(fecha, fecha_actual)
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
    Private Function CalcularEdad(fecha1 As Date, fecha2 As Date) As Int32
        Return DateDiff(DateInterval.Year, fecha1, fecha2)
    End Function
    Public Overrides Function ToString() As String
        Return _nombre.ToString
    End Function
    Public Sub Escuchar(value As String)
        _memoria.Enqueue(value)
    End Sub
    Public Function Hablar() As String
        For Each elemento In _memoria
            _texto += elemento + " "
            _memoria.Dequeue()
            Return _texto
        Next
        Return _texto
    End Function
End Class
