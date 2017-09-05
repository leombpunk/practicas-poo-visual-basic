Imports TelefoniaEntidades
Module MegaByteTest
    Sub main()
        Dim planmb As New MegaByte
        planmb.Nombre = "Plan de megas"
        planmb.Credito = 100
        planmb.Precio = 1.45
        Console.WriteLine("Credito: {0}", planmb.Credito)
        Console.WriteLine("Precio: {0}", planmb.Precio)
        Console.WriteLine("Disponible: {0}", planmb.disponible)
        Console.WriteLine("agrego consumo 9")
        planmb.addConsumo(9)
        Console.WriteLine("Disponible: {0}", planmb.disponible)
        Console.WriteLine("agrego consumo 51")
        planmb.addConsumo(51)
        Console.WriteLine("Disponible: {0}", planmb.disponible)
        Console.WriteLine("toString: {0}", planmb.ToString)

        Dim planmegasote As New MegaByte(800, "plansote iquisdi3", 5.5)
        Console.WriteLine(vbCrLf & "Credito: {0}", planmegasote.Credito)
        Console.WriteLine("Precio: {0}", planmegasote.Precio)
        Console.WriteLine("Disponible: {0}", planmegasote.disponible)
        Console.WriteLine("agrego consumo 500")
        planmegasote.addConsumo(2365998)
        Console.WriteLine("Disponible: {0}", planmegasote.disponible)
        Console.WriteLine("agrego consumo 34")
        planmegasote.addConsumo(34)
        Console.WriteLine("Disponible: {0}", planmegasote.disponible)
        Console.WriteLine("toString: {0}", planmegasote.ToString)
        Console.ReadKey()
    End Sub
End Module
