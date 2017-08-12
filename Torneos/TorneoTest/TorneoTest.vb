Imports TorneoEntidades
Module TorneoTest
    Sub Main()
        Dim torneillo As New Torneo
        torneillo.Nombre = "alto torneo(mentira)"
        Console.WriteLine("Nombre: {0}", torneillo.Nombre)

        Dim torneo1 As New Torneo("sarpado torneo que tiene que pasar los 50 de string en el nombre asasdasdasdasdasdadsd LISTO")
        Console.WriteLine("Nombre: {0}", torneo1.Nombre)
        Console.ReadKey()
    End Sub
End Module
