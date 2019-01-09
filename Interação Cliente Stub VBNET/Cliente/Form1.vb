Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Arquivo EXE|*.exe"

        If (sfd.ShowDialog() = DialogResult.OK) Then
            Dim fnSaida As String = sfd.FileName
            Dim fnStub As String = Path.GetDirectoryName(Application.ExecutablePath) & "\Stub.exe"

            File.Copy(fnStub, fnSaida)

            'Acrescenta dados
            Dim delimitador As String = "[D]"

            Dim saidaDados As String = ""
            Dim dados As String() = {TextBox1.Text}

            For Each dado As String In dados
                saidaDados = saidaDados & delimitador & dado
            Next

            File.AppendAllText(fnSaida, saidaDados)

        End If

    End Sub
End Class
