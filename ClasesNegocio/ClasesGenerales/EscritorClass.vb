Public Class EscritorClass

#Region " Variables "
    Private _Ancho As Byte = 0 'columna donde iniciara se imprimira el dato
    Private _Alto As Byte = 0 'renlgon donde se imprimira el dato
    Private _PosX As Byte = 0 'posicion de la columna de la configuracion de impresion
    Private _PosY As Byte = 0 'renglon de la configuración de impresion
    Private _Long As Byte = 0
    Private _Cadena As String = "" 'cadena que se envia para la impresión.
    Private _Hoja() As String 'matriz donde se especifica el tamaño de la hoja
#End Region

#Region " Constructores "
    Sub New()
        'Inicializa la matriz de tamaño 0
        DefineHoja(0, 0)
        Posicion(0, 0)
    End Sub

    Sub New(ByVal Ancho As Byte, ByVal Alto As Byte)
        'Inicializa la matriz con el tamaño especificado
        DefineHoja(Ancho, Alto)
        Posicion(1, 1)
    End Sub
#End Region

#Region "Metodos Sin Retorno"

    Public Sub DefineHoja(ByVal Ancho As Byte, ByVal Alto As Byte)
        _Ancho = Ancho
        _Alto = Alto
        ReDim _Hoja(_Alto)
        For Y As Int16 = 0 To _Alto - 1
            _Hoja(Y) = ""
            For X As Int16 = 1 To _Ancho
                _Hoja(Y) &= " "
            Next
        Next
    End Sub

    Public Sub Escribe(ByVal Cadena As String)
        'escribe una cadena
        _Cadena = Cadena
        If _Cadena.Length + _PosX > _Ancho Then
            Throw New ArgumentException("La longitud de la cadena excede de los limites de la hoja, verifique la posicion, o modifique la cadena." & Cadena)
        End If
        _Hoja(_PosY) = _Hoja(_PosY).Remove(_PosX, _Cadena.Length)
        _Hoja(_PosY) = _Hoja(_PosY).Insert(_PosX, _Cadena)
    End Sub

    Public Sub Escribe(ByVal Cadena As String, ByVal PosX As Byte, ByVal PosY As Byte)
        'escribe una cadena en la posición especificada
        Posicion(PosX, PosY)
        Escribe(Cadena)
    End Sub

    Public Sub EscribeIzq(ByVal Cadena As String, ByVal PosX As Byte, ByVal PosY As Byte)
        Posicion(PosX - (Cadena.Length - 1), PosY)
        Escribe(Cadena)
    End Sub

    Public Sub EscribeDer(ByVal Cadena As String, ByVal PosFinal As Integer, ByVal PosX As Byte, ByVal PosY As Byte)
        Posicion(PosFinal - Cadena.Length, PosY)
        'Posicion(PosX - (Cadena.Length - 1), PosY)
        Escribe(Cadena)
    End Sub

    Public Sub EscribeMed(ByVal Cadena As String, ByVal PosY As Byte)
        Posicion((_Ancho / 2) - (Cadena.Length / 2), PosY)
        Escribe(Cadena)
    End Sub

    Public Sub EscribeCar(ByVal Caracter As Char, ByVal PosX As Byte, ByVal PosY As Byte, Optional ByVal Repeticion As Integer = 1)
        For X As Integer = 1 To Repeticion
            If PosX = _Ancho Then
                PosX = 1
                PosY += 1
            End If
            Posicion(PosX, PosY)
            Escribe(Caracter)
            PosX += 1
        Next
    End Sub

    Public Sub EscribeCarMed(ByVal Caracter As Char, ByVal PosY As Byte, Optional ByVal Repeticion As Integer = 1)
        For X As Integer = 0 To Repeticion - 1
            Posicion(((_Ancho / 2) - (Repeticion / 2)) + X, PosY)
            Escribe(Caracter)
        Next
    End Sub

    Public Sub EscribeMarco(ByVal SupIzq As Char, ByVal SupDer As Char, ByVal InfIzq As Char, ByVal InfDer As Char, ByVal Horizontal As Char, ByVal Vertical As Char, ByVal X1 As Byte, ByVal Y1 As Byte, ByVal X2 As Byte, ByVal Y2 As Byte)
        EscribeCar(SupIzq, X1, Y1)
        EscribeCar(SupDer, X2, Y1)
        EscribeCar(InfIzq, X1, Y2)
        EscribeCar(InfDer, X2, Y2)
        EscribeCar(Horizontal, X1 + 1, Y1, X2 - X1 - 1)
        EscribeCar(Horizontal, X1 + 1, Y2, X2 - X1 - 1)
        For x As Integer = Y1 + 1 To Y2 - 1
            EscribeCar(Vertical, X1, x)
            EscribeCar(Vertical, X2, x)
        Next
    End Sub

    Public Sub Posicion(ByVal PosX As Byte, ByVal PosY As Byte)
        'Establece la posición
        If PosX > _Ancho Or PosY > _Alto Then
            Throw New ArgumentException("Uno o ambos valores de posicion exceden los limites de la hoja.")
        ElseIf PosX = 0 Or PosY = 0 Then
            Throw New ArgumentException("Uno o ambos valores de posicion es 0, el valor minimo permitido es 1.")
        Else
            PosX -= 1
            PosY -= 1
            _PosX = PosX
            _PosY = PosY
        End If
    End Sub

    Public Sub Imprime()
        Dim lpt1 As IO.StreamWriter = GetStreamWriter("LPT1")
        lpt1.WriteLine(Lee)
        lpt1.Close()
        'Dim Encode As System.Text.ASCIIEncoding = New System.Text.ASCIIEncoding()
        'Dim impresion As New IO.MemoryStream(Encode.GetBytes(Lee))

        'Try
        '    Dim streamToPrint As New IO.StreamReader(impresion)
        '    Try
        '        Dim pd As New System.Drawing.Printing.PrintDocument()
        '        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        '        pd.Print()
        '    Finally
        '        streamToPrint.Close()
        '    End Try
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs)
        Dim printFont As New System.Drawing.Font("Arial", 10)

        For i As Integer = 0 To Lee.Length - 1
            Dim Y As Single = printFont.GetHeight(ev.Graphics) * i
            ev.Graphics.DrawString(Lee(i), printFont, Drawing.Brushes.Black, 0, Y, New System.Drawing.StringFormat())
        Next
    End Sub


    Public Sub ImprimeA(ByVal Puerto As String)
        Dim lpt1 As IO.StreamWriter = GetStreamWriter(Puerto)
        lpt1.WriteLine(Lee)
        lpt1.Close()
    End Sub

    Public Sub Imprime(ByVal impresora As IntPtr)
        Dim escribir As New IO.StreamWriter(New IO.FileStream(impresora, IO.FileAccess.Write))

    End Sub

#End Region

#Region " Metodos Con Retorno "
    Public Function Lee() As String
        Dim Salida As String = ""
        For Y As Int16 = 0 To _Alto - 1
            For X As Int16 = 0 To _Ancho - 1
                Salida &= _Hoja(Y).Chars(X)
            Next
            Salida &= vbCrLf
        Next
        Return Salida
    End Function
#End Region

#Region " Impresor "
    Const GENERIC_WRITE As Int32 = &H40000000
    Const OPEN_EXISTING As Int32 = 3

    Public Declare Auto Function CreateFile Lib "kernel32.dll" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As IntPtr, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As IntPtr) As IntPtr

    Private Function GetStreamWriter(ByVal port As String) As IO.StreamWriter
        Dim hFich As IntPtr = CreateFile(port, GENERIC_WRITE, 0, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero)
        Dim stream As New IO.FileStream(hFich, IO.FileAccess.Write)
        Dim writer As New IO.StreamWriter(stream)
        Return writer
    End Function
#End Region

End Class