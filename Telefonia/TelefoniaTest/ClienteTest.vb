Imports TelefoniaEntidades
Module ClienteTest
    Sub main()
        Dim cliente1 As New Cliente
        Dim linea1 As New Linea(376, 123465)
        Dim linea2 As New Linea(375, 654897)
        Dim linea3 As New Linea(976, 589632)
        cliente1.Id = 155
        Console.WriteLine("Cliente Id: {0}", cliente1.Id)
        Console.WriteLine("Agrago 3 lineas al cliente")
        cliente1.addLinea(linea1)
        cliente1.addLinea(linea2)
        cliente1.addLinea(linea3)
        Console.WriteLine("Muestro")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine("???, {0}-{1}", linea.CodigoArea, linea.Numero)
        Next
        Console.WriteLine("Saco la segunda linea")
        cliente1.removeLinea(linea2)
        Console.WriteLine("Muestro de nuevo")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine("???, {0}-{1}", linea.CodigoArea, linea.Numero)
        Next
        Console.ReadKey()
    End Sub
End Module
