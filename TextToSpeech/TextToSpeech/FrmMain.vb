Public Class FrmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click

        Dim strHostName As String
        Dim strIPAddress As String

        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(My.Computer.Name)

    End Sub
End Class
