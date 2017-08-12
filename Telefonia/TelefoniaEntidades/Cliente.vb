Public Class Cliente
    Private _id As Int32
    Sub New()
        _id = 0
    End Sub
    Public Property Id As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property
End Class
