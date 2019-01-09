Imports System.Windows.Forms
Imports System.IO
Imports System.Text

Module Main
    Public Sub main()
        'Auto leitura
        Dim b As Byte() = File.ReadAllBytes(Application.ExecutablePath)
        Dim byteToText As String = Encoding.UTF8.GetString(b)

        'Tratamento de string
        Dim delimitador As String = "[D]"
        Dim dados As String() = Strings.Split(byteToText, delimitador)

        'Mensagem
        MsgBox(dados(1))

    End Sub
End Module
