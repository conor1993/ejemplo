Imports System.IO.Ports

Public Class LecturaBasculaClass
#Region "Miembros"

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Public Shared Function Leer(ByVal puerto As String, ByVal tipoLectura As TipoLectura, ByVal tipoRetorno As TipoLectura) As Decimal
        Try
            Dim encontroPuerto As Boolean = False
            Dim res As Decimal
            Dim cadenaLeida As String

            For Each nombrePuerto As String In My.Computer.Ports.SerialPortNames
                If nombrePuerto.ToUpper = puerto.Trim.ToUpper Then
                    encontroPuerto = True
                End If
            Next

            If Not encontroPuerto Then
                Throw New Exception("Puerto Invalido")
            End If

            Using serialport1 As New System.IO.Ports.SerialPort("COM1", 9600, IO.Ports.Parity.None, 8, IO.Ports.StopBits.One)
                serialport1.ReadTimeout = 10000
                serialport1.Encoding = System.Text.Encoding.ASCII

                If serialport1.IsOpen Then

                Else
                    serialport1.Open()
                End If

                cadenaLeida = serialport1.ReadExisting()
            End Using

            If cadenaLeida.Trim = "" Then
                MsgBox("No se logro leer el peso de la bascula, verifique que este conectada y encendida", MsgBoxStyle.Exclamation, "Aviso")
                cadenaLeida = "0"
            End If

            res = CDec(QuitarBasura(ObtenerCadenaBuena(cadenaLeida)))

            ConvertirPeso(res, tipoLectura, tipoRetorno)

            Return res
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un Error al leer", MsgBoxStyle.Critical, "Error")
#End If
            'Finally
            '    If lector.IsOpen Then lector.Close()
        End Try
    End Function

    Public Shared Function ObtenerPeso(ByVal cadenaLeida As String, ByVal tipoLectura As TipoLectura, ByVal tipoRetorno As TipoLectura) As Decimal
        Try
            Dim res As Decimal

            res = CDec(QuitarBasura(ObtenerCadenaBuena(cadenaLeida)))

            ConvertirPeso(res, tipoLectura, tipoRetorno)

            Return res
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Shared Sub ConvertirPeso(ByRef peso As Decimal, ByVal tipoLectura As TipoLectura, ByVal tipoRetorno As TipoLectura)
        Try
            Select Case tipoLectura
                Case LecturaBasculaClass.TipoLectura.GRAMOS
                    Select Case tipoRetorno
                        Case LecturaBasculaClass.TipoLectura.KILOGRAMOS
                            peso = peso / 1000D
                        Case LecturaBasculaClass.TipoLectura.TONELADAS
                            peso /= 1000000D
                    End Select
                Case LecturaBasculaClass.TipoLectura.KILOGRAMOS
                    Select Case tipoRetorno
                        Case LecturaBasculaClass.TipoLectura.GRAMOS
                            peso = peso * 1000D
                        Case LecturaBasculaClass.TipoLectura.TONELADAS
                            peso /= 100D
                    End Select
                Case LecturaBasculaClass.TipoLectura.TONELADAS
                    Select Case tipoRetorno
                        Case LecturaBasculaClass.TipoLectura.GRAMOS
                            peso *= 100000D
                        Case LecturaBasculaClass.TipoLectura.KILOGRAMOS
                            peso *= 100D
                    End Select
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Shared Function ObtenerCadenaBuena(ByVal cadenaLectura As String) As String
        Try
            If cadenaLectura.Trim.Length = 0 Then
                Throw New Exception("Cadena de lectura vacia")
            End If

            Dim indiceInicio As Integer = cadenaLectura.IndexOf(Chr(13)) + 1
            Dim indiceFinal As Integer = cadenaLectura.Length - indiceInicio - 1
            Dim cadenas As String = cadenaLectura.Substring(indiceInicio, indiceFinal)

            cadenas = cadenas.Substring(2, cadenas.IndexOf(Chr(13)) - 3)

            Return cadenas
        Catch ex As Exception
            Throw New Exception("No se logro obtener la cadena buena", ex)
        End Try
    End Function

    Private Shared Function QuitarBasura(ByVal cadenaLectura As String) As String
        Try
            If cadenaLectura.Trim.Length = 0 Then Throw New Exception("Cadena de lectura mayor vacia")

            Dim cadenaSinBasura As String = ""
            Dim cadenasSeparadas As String() = cadenaLectura.Split(" "c)
            Dim cadenaLarga As String = ""
            Dim tamañoMaximo As Integer = -1

            For Each cadena As String In cadenasSeparadas
                If cadena.Length > tamañoMaximo Then
                    cadenaLarga = cadena
                    tamañoMaximo = cadena.Length
                End If
            Next

            cadenaLarga = cadenaLarga.Trim

            For Each caracter As Char In cadenaLarga
                If IsNumeric(caracter) OrElse caracter = "."c Then
                    cadenaSinBasura &= caracter
                Else
                    cadenaSinBasura = ""
                End If
            Next

            Return cadenaSinBasura
        Catch ex As Exception
            Throw New Exception("Error al quitar la basura de la cadena", ex)
        End Try
    End Function
#End Region

#Region "Eventos"

#End Region

#Region "Enumeradores"
    Public Enum TipoLectura
        GRAMOS
        KILOGRAMOS
        TONELADAS
    End Enum
#End Region
End Class