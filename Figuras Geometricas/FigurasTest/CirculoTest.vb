Imports FigurasEntidades
Module CirculoTest
    Sub main()
        Dim circulin As New Circulo
        circulin.Nombre = "triangulito"
        circulin.Radio = 6
        Console.WriteLine("Nombre: {0}" & vbCrLf & "Radio: {1}",
                          circulin.Nombre, circulin.Radio)
        Console.WriteLine("Calculo del area: {0} cm" & Chr(178) & "/m" & Chr(178), circulin.CalcularArea())
        Console.ReadKey()
    End Sub
End Module
