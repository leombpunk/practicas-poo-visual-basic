Imports TorneoEntidades
Module EquipoTest
    Sub Main()
        Dim equipo1 As New Equipo
        Dim j1 As New Jugador("AFK", #12/12/1991#, 5)
        Dim j2 As New Jugador("Flamer", #11/5/1986#, 1)
        Dim j3 As New Jugador("HyperCarry", #7/29/1995#, 11)
        equipo1.Nombre = "best equipo"
        Console.WriteLine("Nombre: {0}", equipo1.Nombre)
        Console.WriteLine("Agrego jugadores (3)")
        equipo1.addJugador(j1)
        equipo1.addJugador(j2)
        equipo1.addJugador(j3)
        Console.WriteLine("ToString: {0}", equipo1.ToString)
        For Each j As Jugador In equipo1.getAllJugadores
            Console.WriteLine(j.ToString)
        Next
        Console.WriteLine()

        Dim equipo2 As New Equipo("sarpado equipo que tiene que pasar los 30 de string en el nombre")
        Console.WriteLine("Nombre: {0}", equipo2.Nombre)
        Console.ReadKey()
    End Sub
End Module
