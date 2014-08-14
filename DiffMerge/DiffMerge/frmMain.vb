Public Class frmMain

    Private Sub chkMerge_CheckedChanged(sender As Object, e As EventArgs) Handles chkMerge.CheckedChanged

        If chkMerge.Checked Then

            txtFile3.Enabled = True
            txtFile4.Enabled = True

        Else

            txtFile3.Enabled = False
            txtFile4.Enabled = False

        End If

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        If Not String.IsNullOrEmpty(txtFile1.Text.Trim) And Not String.IsNullOrEmpty(txtFile2.Text.Trim) Then

            Dim param As String = """" + txtFile1.Text.Trim + """ """ + txtFile2.Text.Trim + """"

            If chkMerge.Checked And Not String.IsNullOrEmpty(txtFile3.Text.Trim) And Not String.IsNullOrEmpty(txtFile4.Text.Trim) Then

                param += " """ + txtFile3.Text.Trim + """ """ + txtFile4.Text.Trim + """ /m"

            End If

            Process.Start("C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\vsDiffMerge.exe", param)

        End If

    End Sub

    Private Sub btnOuvrir_Click(sender As Object, e As EventArgs) Handles btnOuvrir.Click

        Dim file As OpenFileDialog = New OpenFileDialog()

        file.Title = "Fichier 1"
        file.ShowDialog()
        txtFile1.Text = file.FileName
        file.Title = "Fichier 2"
        file.ShowDialog()
        txtFile2.Text = file.FileName

        If chkMerge.Checked Then

            file.Title = "Fichier 3"
            file.ShowDialog()
            txtFile3.Text = file.FileName
            file.Title = "Fichier 4"
            file.ShowDialog()
            txtFile4.Text = file.FileName

        End If

    End Sub
End Class
