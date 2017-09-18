Imports TelefoniaEntidades
Module LineaTest
    Sub main()
        Dim nlinea As New Linea
        nlinea.CodigoArea = 500
        nlinea.Numero = 99999
        nlinea.Equipo.Marca = "click bait"
        nlinea.Equipo.Modelo = "alto cel"
        nlinea.Equipo.Serie = "serie pro"
        Console.WriteLine("Codigo de area: {0}", nlinea.CodigoArea)
        Console.WriteLine("Numero: {0}", nlinea.Numero)
        Console.WriteLine("Equipo: Marca-{0}, Modelo-{1}, Serie-{2}", nlinea.Equipo.Marca, nlinea.Equipo.Modelo, nlinea.Equipo.Serie)

        Console.WriteLine("Estado de la linea por defecto: {0}", nlinea.Estado)
        nlinea.reactivar()
        Console.WriteLine("Estado de la linea: {0}", nlinea.Estado)
        Console.WriteLine()
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
