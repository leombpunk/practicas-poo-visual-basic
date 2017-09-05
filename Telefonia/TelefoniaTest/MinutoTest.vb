Imports TelefoniaEntidades
Module MinutoTest
    Sub main()
        Dim planminutes As New Minuto
        planminutes.Nombre = "Plan de minutos"
        planminutes.Credito = 100
        planminutes.Precio = 1.45
        Console.WriteLine("Credito: {0}", planminutes.Credito)
        Console.WriteLine("Precio: {0}", planminutes.Precio)
        Console.WriteLine("Disponible: {0}", planminutes.disponible)
        Console.WriteLine("agrego consumo 50")
        planminutes.addConsumo(50)
        Console.WriteLine("Disponible: {0}", planminutes.disponible)
        Console.WriteLine("agrego consumo 51")
        planminutes.addConsumo(51)
        Console.WriteLine("Disponible: {0}", planminutes.disponible)
        Console.WriteLine("toString: {0}", planminutes.ToString)

        Dim plansoteminutes As New Minuto(800, "plansote iquisdi", 5.5)
        Console.WriteLine(vbCrLf & "Credito: {0}", plansoteminutes.Credito)
        Console.WriteLine("Precio: {0}", plansoteminutes.Precio)
        Console.WriteLine("Disponible: {0}", plansoteminutes.disponible)
        Console.WriteLine("agrego consumo 500")
        plansoteminutes.addConsumo(500)
        Console.WriteLine("Disponible: {0}", plansoteminutes.disponible)
        Console.WriteLine("agrego consumo 34")
        plansoteminutes.addConsumo(34)
        Console.WriteLine("Disponible: {0}", plansoteminutes.disponible)
        Console.WriteLine("toString: {0}", plansoteminutes.ToString)
        Console.ReadKey()
    End Sub
End Module
