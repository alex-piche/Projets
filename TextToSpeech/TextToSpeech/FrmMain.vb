Public Class FrmMain

    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(rctText.Text.Trim)

    End Sub

End Class
