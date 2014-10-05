Public Class FrmMain

    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")

        If IO.File.Exists(rctText.Text.Trim) Then

            Dim texte = IO.File.ReadAllLines(rctText.Text.Trim)

            For Each ligne As String In texte

                SAPI.speak(ligne)

            Next

        Else

            SAPI.speak(rctText.Text.Trim)

        End If

    End Sub

End Class
