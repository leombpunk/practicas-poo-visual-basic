Imports TorneoEntidades
Module JugadorTest
    Sub main()
        Dim jugador1 As New Jugador
        jugador1.Numero = 99
        Console.WriteLine("Numero: {0}", jugador1.Numero)

        Dim jugador2 As New Jugador
        jugador2.Numero = 100
        Console.WriteLine("Numero: {0}", jugador2.Numero)
        jugador2.Numero = 0
        Console.WriteLine("Numero: {0}", jugador2.Numero)
        Console.ReadKey()
    End Sub
End Module
