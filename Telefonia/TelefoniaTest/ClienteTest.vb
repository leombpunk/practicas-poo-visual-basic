Imports TelefoniaEntidades
Module ClienteTest
    Sub main()
        Dim cliente1 As New Cliente
        cliente1.Id = 155
        Console.WriteLine("Cliente Id: {0}", cliente1.Id)
        Console.ReadKey()
    End Sub
End Module
