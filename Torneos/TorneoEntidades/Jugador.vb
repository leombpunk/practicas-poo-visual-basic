﻿Public Class Jugador
    Inherits Persona
    Private _numero As UShort
    Sub New()
        MyBase.New()
        _numero = 0
    End Sub
    Sub New(nombre As String, fechanacimiento As Date, numero As UShort)
        Me.New()
        Me.Nombre = nombre
        Me.FechaNacimiento = fechanacimiento
        Me.Numero = numero
    End Sub
    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If ValidoRango(1, 99, value) Then
                _numero = value
            End If
        End Set
    End Property
    Private Function ValidoRango(valmin As UShort, valmax As UShort, numero As UShort)
        Return If(numero >= valmin And numero <= valmax, True, False)
    End Function
    Public Overrides Function ToString() As String
        Return "Nombre(num.): " & Nombre & "(" & Numero & ")"
    End Function
End Class