Imports TorneoEntidades
Module TorneoTest
    Sub Main()
        Dim torneillo As New Torneo
        Dim partido1 As New Partido
        Dim eq1 As New Equipo("los secos")
        Dim eq2 As New Equipo("los menos secos")
        partido1.Local = eq1
        partido1.Visitante = eq2

        Dim partido2 As New Partido
        Dim eq11 As New Equipo("los secos")
        Dim eq22 As New Equipo("los menos secos")
        partido2.Local = eq11
        partido2.Visitante = eq22

        Dim partido3 As New Partido
        Dim eq111 As New Equipo("los secos")
        Dim eq222 As New Equipo("los menos secos")
        partido3.Local = eq111
        partido3.Visitante = eq222

        torneillo.Nombre = "alto torneo(mentira)"
        Console.WriteLine("Nombre: {0}", torneillo.Nombre)
        torneillo.addPartido(partido1)
        torneillo.addPartido(partido2)
        torneillo.addPartido(partido3)

        Console.WriteLine("lista de partidos")
        For Each partido As Partido In torneillo.getAllPartidos()
            Console.WriteLine(partido.ToString)
        Next

        Console.WriteLine("saco un partido no digo cual porque son todos iguales, que mas da")
        torneillo.removePartido(partido2)

        Console.WriteLine("lista de partidos (again pe)")
        For Each partido As Partido In torneillo.getAllPartidos()
            Console.WriteLine(partido.ToString)
        Next

        Dim torneo1 As New Torneo("sarpado torneo que tiene que pasar los 50 de string en el nombre asasdasdasdasdasdadsd LISTO")
        Console.WriteLine("Nombre: {0}", torneo1.Nombre)
        Console.ReadKey()
    End Sub
End Module
