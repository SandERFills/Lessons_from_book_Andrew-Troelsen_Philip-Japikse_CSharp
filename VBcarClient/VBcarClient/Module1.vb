Imports CarLib
Module Module1

    Sub Main()
        Console.WriteLine("VB Carlib client app")
        Dim miniVan As New MiniVan()
        miniVan.TurboBoost()
        Dim sportCar As New SportCar()
        sportCar.TurboBoost()
        Console.ReadLine()
        Dim perfoCar As New PerfomansCar()
        perfoCar.TurboBoost()
    End Sub

End Module
