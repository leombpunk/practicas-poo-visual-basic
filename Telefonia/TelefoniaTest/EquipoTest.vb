Imports TelefoniaEntidades
Module EquipoTest
    Sub Main()
        Dim telefono1 As New Equipo
        telefono1.Marca = "Ñokia"
        telefono1.Modelo = "ladrillo"
        telefono1.Serie = "2000"
        telefono1.Venta = #03/25/2010#
        Console.WriteLine("Marca: {0}", telefono1.Marca)
        Console.WriteLine("modelo: {0}", telefono1.Modelo)
        Console.WriteLine("serie: {0}", telefono1.Serie)
        Console.WriteLine("fecha venta: {0}", telefono1.FechaVenta)

        Dim telefono2 As New Equipo
        telefono2.Marca = ""
        telefono2.Modelo = "ladrillito"
        telefono2.Serie = "2123654987654654654"
        telefono2.Venta = #12/11/2015#
        Console.WriteLine("Marca: {0}", telefono2.Marca)
        Console.WriteLine("modelo: {0}", telefono2.Modelo)
        Console.WriteLine("serie: {0}", telefono2.Serie)
        Console.WriteLine("fecha venta: {0}", telefono2.FechaVenta)

        Console.ReadKey()
    End Sub
End Module
