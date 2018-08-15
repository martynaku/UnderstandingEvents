Imports System.Timers

Module Module1

    Sub Main()

        Dim timer As New Timers.Timer(1000)

        AddHandler timer.Elapsed, AddressOf Module1.HandleTheTimer1
        AddHandler timer.Elapsed, AddressOf Module1.HandleTheTimer2

        timer.Start()
        Console.WriteLine("Press enter to stop handling the event twice.")
        Console.ReadLine()
        timer.Stop()

        RemoveHandler timer.Elapsed, AddressOf Module1.HandleTheTimer2

        timer.Start()
        Console.ReadLine()
        timer.Stop()

    End Sub

    Private Sub HandleTheTimer2(sender As Object, e As ElapsedEventArgs)
        Console.WriteLine("HandleTheTimer2 Event: {0:HH:mm:ss.fff}", e.SignalTime)
    End Sub

    Private Sub HandleTheTimer1(sender As Object, e As ElapsedEventArgs)
        Console.WriteLine("HandleTheTimer1 Event: {0:HH:mm:ss.fff}", e.SignalTime)
    End Sub
End Module
