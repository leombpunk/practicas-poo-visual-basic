Imports TelefoniaEntidades
Module EmpresaTest
    Sub main()
        Dim empresota As New Empresa
        empresota.RazonSocial = "Killswitch Engage"
        empresota.Cuit = "456889"
        Console.WriteLine("Razon Social: {0}", empresota.RazonSocial)
        Console.WriteLine("Cuit: {0}", empresota.Cuit)

        Dim empresita As New Empresa("80 de estring es mucho pruebo con el cuit", "12345678910111213")
        Console.WriteLine("Razon Social: {0}", empresita.RazonSocial)
        Console.WriteLine("Cuit: {0}", empresita.Cuit)
        Console.ReadKey()
    End Sub
End Module
