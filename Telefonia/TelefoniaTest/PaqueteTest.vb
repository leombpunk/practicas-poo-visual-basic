Imports TelefoniaEntidades
Module PaqueteTest
    Sub Main()
        Dim paqueton As New Paquete()
        Dim aaa As New Mensaje(50, "plan sms", 1.5)
        paqueton.addPlan(aaa)
        Dim aaa1 As New MegaByte(150, "plan mb", 5.5)
        Dim aaa2 As New Minuto(250, "plan min", 3.5)
        paqueton.addPlan(aaa1)
        paqueton.addPlan(aaa2)
        For Each plan As Plan In paqueton.getAllPlanes()
            Console.WriteLine("plan: {0}", plan)
        Next
        Console.WriteLine("---------------------------")
        Console.WriteLine("getDisponible: {0}", paqueton.getDisponible)
        'For Each mm In paqueton.getDisponible()
        '    Console.WriteLine("otro: {0}", mm)
        'Next
        Console.ReadKey()
    End Sub
End Module
