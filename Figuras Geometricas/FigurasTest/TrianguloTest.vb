Imports FigurasEntidades
Module TrianguloTest
    Sub main()
        Dim triangulin As New Triangulo
        triangulin.Nombre = "triangulito"
        triangulin.Altura = 12
        triangulin.Base = 15
        Console.WriteLine("Nombre: {0}" & vbCrLf & "Altura: {1}" & vbTab & "Base: {2}",
                          triangulin.Nombre, triangulin.Altura, triangulin.Base)
        Console.WriteLine("Calculo del area: {0} cm" & Chr(178) & "/m" & Chr(178), triangulin.CalcularArea())
        Console.ReadKey()
    End Sub
End Module
