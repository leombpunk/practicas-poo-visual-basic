Imports TorneoEntidades
Module RefereeTest
    Sub main()
        Dim rifiri As New Referee
        Console.WriteLine("Internacional: {0}", rifiri.Internacional)
        rifiri.Internacional = True
        Console.WriteLine("Internacional: {0}", rifiri.Internacional)
        Console.ReadKey()
    End Sub
End Module
