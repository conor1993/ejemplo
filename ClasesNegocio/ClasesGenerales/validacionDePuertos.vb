Imports System
Imports System.IO.Ports


Public Class validacionDePuertos


    Public Function testsport() As Integer
        Dim numport As Integer = 4
        Dim flag As Boolean = False
        Dim ports As String() = SerialPort.GetPortNames()
        Dim port As String = ""


        For Each port In ports
            If numport = obtenerPuertodecadena(port) Then
                flag = True
            End If
        Next port

        If flag = False Then
            numport = -1
        End If
        Return numport
    End Function

    Private Function obtenerPuertodecadena(cadena As String) As Integer
        Dim port As Integer = 0

        cadena = cadena.Substring(3, cadena.Length - 3)
        If IsNumeric(cadena) Then
            port = CInt(cadena)
        End If

        Return port
    End Function

End Class
