Imports FigurasEntidades
Module RectanguloTest
    Sub main()
        Dim rectangulin As New Rectangulo
        rectangulin.Nombre = "triangulito"
        rectangulin.Altura = 3
        rectangulin.Base = 5
        Console.WriteLine("Nombre: {0}" & vbCrLf & "Altura: {1}" & vbTab & "Base: {2}",
                          rectangulin.Nombre, rectangulin.Altura, rectangulin.Base)
        Console.WriteLine("Calculo del area: {0} cm" & Chr(178) & "/m" & Chr(178), rectangulin.CalcularArea())
        Console.ReadKey()
    End Sub
End Module
