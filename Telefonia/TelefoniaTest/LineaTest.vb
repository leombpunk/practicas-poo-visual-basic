Imports TelefoniaEntidades
Module LineaTest
    Sub main()
        Dim nlinea As New Linea
        nlinea.CodigoArea = 500
        nlinea.Numero = 99999
        Console.WriteLine("Codigo de area: {0}", nlinea.CodigoArea)
        Console.WriteLine("Numero: {0}", nlinea.Numero)
        Console.WriteLine("Estado de la linea por defecto: {0}", nlinea.Estado)
        nlinea.reactivar()
        Console.WriteLine("Estado de la linea: {0}", nlinea.Estado)

        Dim nlinea1 As New Linea(99, 256369)
        Console.WriteLine("Codigo de area: {0}", nlinea1.CodigoArea)
        Console.WriteLine("Numero: {0}", nlinea1.Numero)
        Console.WriteLine("Estado de la linea por defecto: {0}", nlinea1.Estado)
        nlinea1.reactivar()
        Console.WriteLine("Estado de la linea: {0}", nlinea1.Estado)
        nlinea1.suspender()
        Console.WriteLine("Estado de la linea: {0}", nlinea1.Estado)

        Console.ReadKey()
    End Sub
End Module
