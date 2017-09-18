Imports TorneoEntidades
Module RefereeTest
    Sub main()
        Dim rifiri As New Referee
        Console.WriteLine("Internacional: {0}", rifiri.Internacional)
        rifiri.Internacional = True
        Console.WriteLine("Internacional: {0}", rifiri.Internacional)

        rifiri.Nombre = "el rifiri"
        rifiri.FechaNacimiento = #6/8/1995#
        Console.WriteLine("Nombre: {0}", rifiri.Nombre)
        Console.WriteLine("Fecha de Nacimiento: {0}", rifiri.FechaNacimiento)
        Console.WriteLine("ToString: {0}", rifiri.ToString)
        Console.WriteLine()

        Dim rifiri2 As New Referee("chicato", #2/15/1997#, False)
        Console.WriteLine("Internacional: {0}", rifiri2.Internacional)
        Console.WriteLine("Nombre: {0}", rifiri2.Nombre)
        Console.WriteLine("Fecha de Nacimiento: {0}", rifiri2.FechaNacimiento)
        Console.WriteLine("ToString: {0}", rifiri2.ToString)
        Console.ReadKey()
    End Sub
End Module
