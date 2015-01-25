Imports System.IO

Public Class frmCopie

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Try

            Dim fichiers = New DirectoryInfo(txtSrc.Text.Trim).EnumerateFiles(txtExt.Text.Trim, SearchOption.AllDirectories)

            For Each fichier In fichiers

                File.Copy(fichier.FullName, Path.Combine(txtDst.Text.Trim, fichier.Name))

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Class
