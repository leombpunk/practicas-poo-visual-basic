Imports Entidades
Module LoroTest

    Sub Main()
        Dim oLorito As New Loro
        oLorito.Nombre = "John"
        oLorito.FechaNacimiento = #12/19/1991# 'formato mm/dd/aaaa nunca me acuerdo

        oLorito.Escuchar("papita")
        oLorito.Escuchar("pal loro")
        oLorito.Escuchar("Juan")
        Console.WriteLine(oLorito.Hablar)
        Console.WriteLine(oLorito.Hablar)
        Console.WriteLine(oLorito.Hablar)
        Console.WriteLine(oLorito.Hablar)
        Console.WriteLine(oLorito.Hablar)
        Console.WriteLine("Nombre: {0}", oLorito.ToString)
        Console.WriteLine("Edad: {0}", oLorito.Edad)
        Console.ReadKey()
    End Sub

End Module
