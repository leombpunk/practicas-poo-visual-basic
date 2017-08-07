Imports Entidades
Module JaulaTest
    Sub main()
        Dim oJaula1 As New Jaula
        Dim oCotorra1 As New Cotorra
        Dim oCotorra2 As New Cotorra
        Dim oCotorra3 As New Cotorra
        Dim oCotorra4 As New Cotorra
        Dim oLoro1 As New Loro

        oCotorra1.Nombre = "jakiro"
        oCotorra2.Nombre = "rambo"
        oCotorra3.Nombre = "penca"
        oCotorra4.Nombre = "el calla"
        oLoro1.Nombre = "loro OP"

        oJaula1.Nombre = "la cotorrera"
        'agrego cotorras
        oJaula1.AddCotorra(oCotorra3)
        oJaula1.AddCotorra(oCotorra1)
        oJaula1.AddCotorra(oCotorra2)
        oJaula1.AddCotorra(oCotorra4)
        oJaula1.AddCotorra(oCotorra1)
        'muestro datos de la jaula
        Console.WriteLine("Nombre: {0}", oJaula1.Nombre)
        Console.WriteLine("Nombre (ToString): {0}", oJaula1.ToString)
        'listo cotorras
        Console.WriteLine("Lista de cotorras (max.3):")
        For Each cotorra As Cotorra In oJaula1.getAllcotorras()
            Console.WriteLine(cotorra)
        Next
        Console.ReadKey()
    End Sub
End Module
