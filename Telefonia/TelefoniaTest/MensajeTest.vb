Imports TelefoniaEntidades
Module MensajeTest
    Sub main()
        Dim planminsiji As New Mensaje
        planminsiji.Nombre = "Plan de mensajes"
        planminsiji.Credito = 50
        planminsiji.Precio = 2.3
        Console.WriteLine("Credito: {0}", planminsiji.Credito)
        Console.WriteLine("Precio: {0}", planminsiji.Precio)
        Console.WriteLine("Disponible: {0}", planminsiji.disponible)
        Console.WriteLine("agrego consumo 49")
        planminsiji.addConsumo(49)
        Console.WriteLine("Disponible: {0}", planminsiji.disponible)
        Console.WriteLine("toString: {0}", planminsiji.ToString)

        Dim plandemensajes As New Mensaje(99, "plansote iquisdi2", 1.1)
        Console.WriteLine(vbCrLf & "Credito: {0}", plandemensajes.Credito)
        Console.WriteLine("Precio: {0}", plandemensajes.Precio)
        Console.WriteLine("Disponible: {0}", plandemensajes.disponible)
        Console.WriteLine("agrego consumo 500")
        plandemensajes.addConsumo(500)
        Console.WriteLine("Disponible: {0}", plandemensajes.disponible)
        Console.WriteLine("agrego consumo 34")
        plandemensajes.addConsumo(34)
        Console.WriteLine("Disponible: {0}", plandemensajes.disponible)
        Console.WriteLine("toString: {0}", plandemensajes.ToString)
        Console.ReadKey()
    End Sub
End Module
