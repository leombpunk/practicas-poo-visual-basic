Imports TorneoEntidades
Module EquipoTest
    Sub Main()
        Dim equipo1 As New Equipo
        equipo1.Nombre = "best equipo"
        Console.WriteLine("Nombre: {0}", equipo1.Nombre)

        Dim equipo2 As New Equipo("sarpado equipo que tiene que pasar los 30 de string en el nombre")
        Console.WriteLine("Nombre: {0}", equipo2.Nombre)
        Console.ReadKey()
    End Sub
End Module
