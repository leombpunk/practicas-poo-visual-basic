Imports FigurasEntidades
Module CuadradoTest
    Sub main()
        Dim cuadradin As New Cuadrado
        cuadradin.Nombre = "triangulito"
        cuadradin.Lado = 10
        Console.WriteLine("Nombre: {0}" & vbCrLf & "Lado: {1}",
                          cuadradin.Nombre, cuadradin.Lado)
        Console.WriteLine("Calculo del area: {0} cm" & Chr(178) & "/m" & Chr(178), cuadradin.CalcularArea())
        Console.ReadKey()
    End Sub
End Module
