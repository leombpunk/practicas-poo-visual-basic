Imports TelefoniaEntidades
Module PersonaTest
    Sub main()
        Dim persona1 As New Persona
        persona1.Apellido = "soyun apellido"
        persona1.Nombre = "osyun nombre"
        persona1.Documento = 3636363636
        Console.WriteLine("Apellido: {0}", persona1.Apellido)
        Console.WriteLine("Nombre: {0}", persona1.Nombre)
        Console.WriteLine("Documento: {0}", persona1.Documento)

        Dim persona2 As New Persona("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "mi apellido tiene muchas zetas", 123456789)
        persona2.Id = 12345
        Console.WriteLine("Apellido: {0}", persona2.Apellido)
        Console.WriteLine("Nombre: {0}", persona2.Nombre)
        Console.WriteLine("Documento: {0}", persona2.Documento)
        Console.WriteLine("Id.: {0}", persona2.Id)
        Console.ReadKey()
    End Sub
End Module
