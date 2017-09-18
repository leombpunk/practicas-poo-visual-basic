Imports TorneoEntidades
Module JugadorTest
    Sub main()
        Dim jugador1 As New Jugador
        jugador1.Numero = 99
        jugador1.Nombre = "El ultimo"
        Console.WriteLine("Numero: {0}", jugador1.Numero)
        Console.WriteLine("ToString: {0}", jugador1.ToString)
        Console.WriteLine()
        Dim jugador2 As New Jugador
        jugador2.Numero = 100
        Console.WriteLine("Numero: {0}", jugador2.Numero)
        jugador2.Numero = 0
        Console.WriteLine("Numero: {0}", jugador2.Numero)
        jugador2.Nombre = "El sin numero?"
        Console.WriteLine("ToString: {0}", jugador2.ToString)
        Console.WriteLine()
        Dim jugueador3 As New Jugador("el mas tronco", #8/13/1999#, 72)
        Console.WriteLine("Nombre: {0}", jugueador3.Nombre)
        Console.WriteLine("Fecha nacimiento: {0}", jugueador3.FechaNacimiento)
        Console.WriteLine("Numero: {0}", jugueador3.Numero)
        Console.WriteLine("ToString: {0}", jugueador3.ToString)
        Console.ReadKey()
    End Sub
End Module
