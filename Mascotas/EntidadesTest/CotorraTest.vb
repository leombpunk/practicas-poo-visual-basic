Imports Entidades
Module CotorraTest
    Sub main()
        Dim oCotorra1 As New Cotorra
        'Dim oCotorra1 As Cotorra
        'oCotorra1 = New Cotorra

        'pruebo las mismas propiedaddes y metodos que en lorotest
        oCotorra1.Nombre = "John Cotorra"
        oCotorra1.FechaNacimiento = #12/19/1991# 'formato mm/dd/aaaa nunca me acuerdo

        oCotorra1.Escuchar("papita")
        oCotorra1.Escuchar("pal loro")
        oCotorra1.Escuchar("Juan")
        oCotorra1.Escuchar("buena esa pe!")
        oCotorra1.Escuchar("altoqueperro")
        oCotorra1.Escuchar("sexta frase")

        Console.WriteLine(oCotorra1.Hablar)
        Console.WriteLine(oCotorra1.Hablar)
        Console.WriteLine(oCotorra1.Hablar)
        Console.WriteLine(oCotorra1.Hablar)
        Console.WriteLine(oCotorra1.Hablar)
        Console.WriteLine("Nombre: {0}", oCotorra1.ToString)
        Console.WriteLine("Edad normal (x1): {0}", oCotorra1.Edad)
        Console.WriteLine("Edad Humana (x2): {0}", oCotorra1.EdadHumana)
        Console.ReadKey()
    End Sub
End Module
