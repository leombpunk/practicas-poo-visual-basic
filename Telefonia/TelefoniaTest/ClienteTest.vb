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
        Console.WriteLine("la linea {0}-{1}, pertenece al cliente {2}", linea1.CodigoArea, linea1.Numero, linea1.Cliente.Id)
        Console.WriteLine("Muestro")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine("cliente id{2}, {0}-{1}", linea.CodigoArea, linea.Numero, linea.Cliente.Id)
        Next
        Console.WriteLine("Saco la segunda linea")
        cliente1.removeLinea(linea2)
        Console.WriteLine("Muestro de nuevo")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine("cliente id{2}, {0}-{1}", linea.CodigoArea, linea.Numero, linea.Cliente.Id)
        Next
        'Console.WriteLine("la linea {0}-{1}, pertenece al cliente {2}", linea2.CodigoArea, linea2.Numero, linea2.Cliente.Id)
        Console.WriteLine("Muestro de nuevo2")
        For Each linea As Linea In cliente1.getAllLineas
            Console.WriteLine("cliente id{2}, {0}-{1}", linea.CodigoArea, linea.Numero, linea.Cliente.Id)
        Next
        Console.ReadKey()
    End Sub
End Module
