Public Class MIFolderBrowserDialog

    Private Function TraerCarpeta(ByVal sender As Object, ByVal e As EventArgs) As String
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return FolderBrowserDialog1.SelectedPath

        End If
        Return Nothing

    End Function

 
End Class
