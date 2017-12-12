Imports System.Runtime.InteropServices
Imports CM = System.ComponentModel

Public Class FormManager(Of TypeForm As {System.Windows.Forms.Form, New}, TypeMdi As {System.Windows.Forms.Form, New})
    Sub New(ByRef miForma As TypeForm, ByRef miMdi As TypeMdi, ByVal Cerrado As System.Windows.Forms.FormClosedEventHandler)
        If IsNothing(miForma) Then
            miForma = New TypeForm
            miForma.MdiParent = miMdi
            miForma.Icon = miMdi.Icon
            AddHandler miForma.FormClosed, Cerrado
            miForma.Show()
        Else
            miForma.Focus()
        End If
    End Sub
End Class

Public Class CondicionClass

    Private _condicion As CondicionEnum
    Public Property Condicion() As CondicionEnum
        Get
            Return _condicion
        End Get
        Set(ByVal value As CondicionEnum)
            _condicion = value
        End Set
    End Property
    Sub New(ByVal condicion As CondicionEnum)
        _condicion = condicion
    End Sub
End Class
Public Class CondicionesClass
    Inherits CollectionGenClass(Of CondicionClass)
    Sub New()
        Me.Add(New CondicionClass(CondicionEnum.ACTIVOS))
        Me.Add(New CondicionClass(CondicionEnum.INACTIVOS))
        Me.Add(New CondicionClass(CondicionEnum.TODOS))
    End Sub
End Class

Public Class DiaClass
    Private _dia As DiasEnum
    Property Dia() As DiasEnum
        Get
            Return _dia
        End Get
        Set(ByVal value As DiasEnum)
            _dia = value
        End Set
    End Property
    Sub New(ByVal dia As DiasEnum)
        _dia = dia
    End Sub
End Class
Public Class DiasClass
    Inherits CollectionGenClass(Of DiaClass)
    Sub New()
        Me.Add(New DiaClass(DiasEnum.DOMINGO))
        Me.Add(New DiaClass(DiasEnum.LUNES))
        Me.Add(New DiaClass(DiasEnum.MARTES))
        Me.Add(New DiaClass(DiasEnum.MIERCOLES))
        Me.Add(New DiaClass(DiasEnum.JUEVES))
        Me.Add(New DiaClass(DiasEnum.VIERNES))
        Me.Add(New DiaClass(DiasEnum.SABADO))
    End Sub
End Class

Public Class BusquedaClass(Of TipoEntidad) ' As {IEntidad})
    Public Function ObtenerdeDataGrid(ByVal Datagrid As Windows.Forms.DataGridView) As TipoEntidad
        Dim Entidad As TipoEntidad = Nothing
        If Datagrid.SelectedRows.Count > 0 Then
            If Not Datagrid.SelectedRows(0).DataBoundItem Is Nothing Then
                Entidad = DirectCast(Datagrid.SelectedRows(0).DataBoundItem, TipoEntidad)
            End If
        End If
        Return Entidad
    End Function
End Class

Public Class cNum2Text
    'Declaradas a nivel de módulo
    Dim unidad(9) As String
    Dim decena(9) As String
    Dim centena(10) As String
    Dim deci(9) As String
    Dim otros(15) As String

    Private m_Sexo1 As String
    Private m_Sexo2 As String
    Private m_LenSexo1 As Integer

    Public Enum eSexo
        Femenino
        Masculino
    End Enum

    Public Function Numero2Letra(ByVal strNum As String, Optional ByVal NumDecimales As Integer = 2, Optional ByVal sMoneda As String = "", Optional ByVal sPlural As String = "", Optional ByVal sAbreviatura As String = "") As String
        '----------------------------------------------------------
        ' La moneda debe especificarse en singular, ya que la función
        ' se encarga de convertirla en plural.
        ' Se puede indicar el número de decimales a devolver
        ' por defecto son dos.
        '----------------------------------------------------------
        Dim Entero As String
        Dim Fraccion As String
        sMoneda = " " & sMoneda

        If InStr(strNum, "$") Then
            Strings.Replace(strNum, "$", "")
        End If
        strNum = FormatNumber(strNum, NumDecimales)
        Entero = Mid(strNum, 1, InStr(strNum, ".") - 1)
        Fraccion = Mid(strNum, InStr(strNum, ".") + 1)
        If Entero <> "1" Then
            sMoneda &= sPlural
            Numero2Letra = "Son " & UnNumero(Entero, sMoneda) & " " & sMoneda & " " & Fraccion & "/100 " & sAbreviatura
        Else
            Numero2Letra = "Es " & UnNumero(Entero, sMoneda) & " " & sMoneda & " " & Fraccion & "/100 " & sAbreviatura
        End If

    End Function

    Private Function UnNumero(ByVal strNum As String, ByVal Sexo1 As String) As String
        '----------------------------------------------------------
        'Esta es la rutina principal                    (10/Jul/97)
        'Está separada para poder actuar con decimales
        '----------------------------------------------------------
        Dim dblNumero As Decimal

        Dim Negativo As Boolean
        Dim L As Short
        Dim Una As Boolean
        Dim Millon As Boolean
        Dim Millones As Boolean
        Dim vez As Integer
        Dim MaxVez As Integer
        Dim k As Integer
        Dim strQ As String
        Dim strB As String
        Dim strU As String
        Dim strD As String
        Dim strC As String
        Dim iA As Integer
        '
        Dim strN() As String
        Dim Sexo1Ant As String

        'Si se amplia este valor... no se manipularán bien los números
        Const cAncho As Short = 12
        Const cGrupos As Short = cAncho \ 3

        'Por si se especifica el sexo, para el caso de los decimales
        'que siempre será masculino
        Sexo1Ant = m_Sexo1
        m_Sexo1 = Sexo1

        m_LenSexo1 = Len(m_Sexo1)
        '
        ' idea aportada por Harvey Triana
        ' para no tener que estar reinicializando continuamente los arrays
        '
        ' Se ve que lo anterior fallaba si se usaba varias veces seguidas (05/Mar/99)
        If unidad(1) <> "un" & Sexo1 Then
            InicializarArrays()
        End If
        '
        '    If m_Sexo1 <> Sexo1Ant Then
        '        unidad(2) = ""
        '    End If
        '    '
        '    If unidad(2) <> "dos" Then
        '        InicializarArrays
        '    End If
        '

        'Si se produce un error que se pare el mundo!!!
        On Error GoTo 0

        If Len(strNum) = 0 Then
            strNum = "0"
        End If

        dblNumero = System.Math.Abs(CDbl(strNum))
        Negativo = (dblNumero <> CDbl(strNum))
        strNum = LTrim(RTrim(Str(dblNumero)))
        L = Len(strNum)

        If dblNumero < 1 Then
            UnNumero = "cero"
            Exit Function
        End If
        '
        Una = True
        Millon = False
        Millones = False
        If L < 4 Then Una = False
        If dblNumero > 999999 Then Millon = True
        If dblNumero > 1999999 Then Millones = True
        strB = ""
        strQ = strNum
        vez = 0

        'UPGRADE_WARNING: El límite inferior de la matriz strN ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
        ReDim strN(cGrupos)
        strQ = Right(New String("0", cAncho) & strNum, cAncho)
        For k = Len(strQ) To 1 Step -3
            vez = vez + 1
            strN(vez) = Mid(strQ, k - 2, 3)
        Next
        MaxVez = cGrupos
        For k = cGrupos To 1 Step -1
            If strN(k) = "000" Then
                MaxVez = MaxVez - 1
            Else
                Exit For
            End If
        Next
        For vez = 1 To MaxVez
            strU = ""
            strD = ""
            strC = ""
            strNum = strN(vez)
            L = Len(strNum)
            k = Val(Right(strNum, 2))
            If Right(strNum, 1) = "0" Then
                k = k \ 10
                strD = decena(k)
            ElseIf k > 10 And k < 16 Then
                k = Val(Mid(strNum, L - 1, 2))
                strD = otros(k)
            Else
                strU = unidad(Val(Right(strNum, 1)))
                If L - 1 > 0 Then
                    k = Val(Mid(strNum, L - 1, 1))
                    strD = deci(k)
                End If
            End If
            '---Parche de Esteve
            If L - 2 > 0 Then
                k = Val(Mid(strNum, L - 2, 1))
                'Con esto funcionará bien el 100100, por ejemplo...
                If k = 1 Then 'Parche
                    If Val(strNum) = 100 Then 'Parche
                        k = 10 'Parche
                    End If 'Parche
                End If
                strC = centena(k) & " "
            End If
            '------
            If strU = "uno" And Left(strB, 4) = " mil" Then strU = ""
            strB = strC & strD & strU & " " & strB

            If (vez = 1 Or vez = 3) Then
                If strN(vez + 1) <> "000" Then strB = " mil " & strB
            End If
            If vez = 2 And Millon Then
                If Millones Then
                    strB = " millones " & strB
                Else
                    strB = "un millón " & strB
                End If
            End If
        Next
        strB = Trim(strB)
        If Right(strB, 3) = "uno" Then
            strB = Left(strB, Len(strB) - 1) & m_Sexo1 '"a"
        End If
        Do  'Quitar los espacios dobles que haya por medio
            iA = InStr(strB, "  ")
            If iA = 0 Then Exit Do
            strB = Left(strB, iA - 1) & Mid(strB, iA + 1)
        Loop
        '
        If Left(strB, 5 + m_LenSexo1) = "un" & m_Sexo1 & " un" Then
            strB = Mid(strB, 4 + m_LenSexo1)
        End If
        '---Nueva comparación                                     (01:16 25/Ene/99)
        If Left(strB, 5) = "un un" Then
            strB = Mid(strB, 4)
        End If
        '
        ' Comprobar sólo si se especifica "un* mil ",                   (05/Mar/99)
        ' no "un* mil" ya que puede ser "un* millón"
        'If Left$(strB, 6 + m_LenSexo1) = "un" & m_Sexo1 & " mil" Then
        If Left(strB, 7 + m_LenSexo1) = "un" & m_Sexo1 & " mil " Then
            strB = Mid(strB, 4 + m_LenSexo1)
            ' Puede que el importe sea sólo "un mil" o "una mil"            (19/Ago/00)
        ElseIf strB = "un" & m_Sexo1 & " mil" Then
            strB = Mid(strB, 4 + m_LenSexo1)
        End If
        '
        '---Nueva comparación                                     (15:11 25/Ene/99)
        'If Left$(strB, 6) = "un mil" Then
        ' Que debe estar así, para que no quite "un millón"             (05/Mar/99)
        If Left(strB, 7) = "un mil " Then
            strB = Mid(strB, 4)
        End If
        '
        If Right(strB, 15 + m_LenSexo1) <> "millones mil un" & m_Sexo1 Then
            iA = InStr(strB, "millones mil un" & m_Sexo1)
            If iA Then strB = Left(strB, iA + 8) & Mid(strB, iA + 13)
        End If
        '---Nueva comparación                                   (15:13 25/Ene/99)
        If Right(strB, 15) <> "millones mil un" Then
            iA = InStr(strB, "millones mil un")
            If iA Then strB = Left(strB, iA + 8) & Mid(strB, iA + 13)
        End If
        '
        ' De algo sirve que la gente pruebe las rutinas...              (05/Mar/99)
        ' ¡¡¡ Gracias gente !!!
        If Millones Then
            ' Comprobación de -as ??? millones
            ' convertir en -os ??? millones
            ' Pero sólo si el sexo es femenino
            If m_Sexo1 = "a" Then
                'If (strB Like "*as * millones*") Then
                ' Usar un bucle Do por si hay varias coincidencias      (07/Dic/00)
                Do While (strB Like "*as * millones*")
                    ' Buscar la primera terminación "as " y cambiar por "os "
                    k = InStr(strB, "as ")
                    If k Then
                        Mid(strB, k) = "os "
                    End If
                Loop
                'End If
                ' La comparación anterior no funciona con x00 millones  (30/Jun/00)
                'If (strB Like "*as millones*") Then
                ' Usar un bucle Do por si hay varias coincidencias      (07/Dic/00)
                Do While (strB Like "*as millones*")
                    ' Buscar la primera terminación "as " y cambiar por "os "
                    k = InStr(strB, "as millones")
                    If k Then
                        Mid(strB, k) = "os millones"
                    End If
                Loop
                'End If
                '
                '
                '------------------------------------------------------------------
                ' Comprobar si dice algo así ...una millones            (08/Jul/00)
                ' Por ejemplo en 821.xxx.xxx decia ochocientos veintiuna millones
                '------------------------------------------------------------------
                k = InStr(strB, "una mill")
                If k Then
                    strB = Left(strB, k + 1) & Mid(strB, k + 3)
                End If
                '
                '
            End If
        End If
        '
        '
        '--------------------------------------------------------------------------
        ' Cambiar los veintiun por veintiún, etc por sus acentuadas     (08/Jul/00)
        Do
            k = InStr(strB, "veintiun ")
            If k Then
                Mid(strB, k) = "veintiún "
            End If
        Loop While k
        ' El veintidos creo que nunca lo he acentuado...                (08/Jul/00)
        ' pero en la enciclopedia consultada lo acentúa
        Do
            k = InStr(strB, "veintidos ")
            If k Then
                Mid(strB, k) = "veintidós "
            End If
        Loop While k
        Do
            k = InStr(strB, "veintitres ")
            If k Then
                Mid(strB, k) = "veintitrés "
            End If
        Loop While k
        Do
            k = InStr(strB, "veintiseis ")
            If k Then
                Mid(strB, k) = "veintiséis "
            End If
        Loop While k
        '--------------------------------------------------------------------------
        '
        '
        If Right(strB, 6) = "ciento" Then
            strB = Left(strB, Len(strB) - 2)
        End If
        If Negativo Then strB = "menos " & strB

        UnNumero = Trim(strB)

        ' Restablecer el valor anterior
        m_Sexo1 = Sexo1Ant
        m_LenSexo1 = Len(m_Sexo1)
    End Function
    Private Sub InicializarArrays()
        'Asignar los valores
        unidad(1) = "un"
        unidad(2) = "dos"
        unidad(3) = "tres"
        unidad(4) = "cuatro"
        unidad(5) = "cinco"
        unidad(6) = "seis"
        unidad(7) = "siete"
        unidad(8) = "ocho"
        unidad(9) = "nueve"
        '
        decena(1) = "diez"
        decena(2) = "veinte"
        decena(3) = "treinta"
        decena(4) = "cuarenta"
        decena(5) = "cincuenta"
        decena(6) = "sesenta"
        decena(7) = "setenta"
        decena(8) = "ochenta"
        decena(9) = "noventa"
        '
        centena(1) = "ciento"
        centena(2) = "doscient" & m_Sexo2
        centena(3) = "trescient" & m_Sexo2
        centena(4) = "cuatrocient" & m_Sexo2
        centena(5) = "quinient" & m_Sexo2
        centena(6) = "seiscient" & m_Sexo2
        centena(7) = "setecient" & m_Sexo2
        centena(8) = "ochocient" & m_Sexo2
        centena(9) = "novecient" & m_Sexo2
        centena(10) = "cien" 'Parche
        '
        deci(1) = "dieci"
        deci(2) = "veinti"
        deci(3) = "treinta y "
        deci(4) = "cuarenta y "
        deci(5) = "cincuenta y "
        deci(6) = "sesenta y "
        deci(7) = "setenta y "
        deci(8) = "ochenta y "
        deci(9) = "noventa y "
        '
        otros(1) = "1"
        otros(2) = "2"
        otros(3) = "3"
        otros(4) = "4"
        otros(5) = "5"
        otros(6) = "6"
        otros(7) = "7"
        otros(8) = "8"
        otros(9) = "9"
        otros(10) = "10"
        otros(11) = "once"
        otros(12) = "doce"
        otros(13) = "trece"
        otros(14) = "catorce"
        otros(15) = "quince"
    End Sub
    'UPGRADE_NOTE: Class_Initialize se actualizó a Class_Initialize_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
    Private Sub Class_Initialize_Renamed()
        m_Sexo1 = "o"
        m_Sexo2 = "os"
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
    Public Function ConvDecimal(ByVal strNum As String, Optional ByRef sDecimal As String = ",", Optional ByRef sDecimalNo As String = ".") As String
        ' Asigna el signo decimal adecuado (o lo intenta)               (10/Ene/99)
        ' Devuelve una cadena con el signo decimal del sistema
        Dim sNumero As String
        Dim i As Integer
        Dim j As Integer

        On Error Resume Next ' Si se produce un error, continuar (07/Jul/00)

        ' Averiguar el signo decimal
        sNumero = Format(25.5, "#.#")
        If InStr(sNumero, ".") Then
            sDecimal = "."
            sDecimalNo = ","
        Else
            sDecimal = ","
            sDecimalNo = "."
        End If

        strNum = Trim(strNum)
        If Left(strNum, 1) = sDecimalNo Then
            Mid(strNum, 1, 1) = sDecimal
        End If

        ' Si el número introducido contiene signos no decimales
        j = 0
        i = 1
        Do
            i = InStr(i, strNum, sDecimalNo)
            If i Then
                j = j + 1
                i = i + 1
            End If
        Loop While i

        If j = 1 Then
            ' cambiar ese símbolo por un espacio, si sólo hay uno de esos signos
            i = InStr(strNum, sDecimalNo)
            If i Then
                If InStr(strNum, sDecimal) Then
                    Mid(strNum, i, 1) = " "
                Else
                    Mid(strNum, i, 1) = sDecimal
                End If
            End If
        Else
            'En caso de que tenga más de uno de estos símbolos
            'convertirlos de manera adecuada.
            'Por ejemplo:
            'si el signo decimal es la coma:
            '   1,250.45 sería 1.250,45 y quedaría en 1250,45
            'si el signo decimal es el punto:
            '   1.250,45 sería 1,250.45 y quedaría en 1250.45
            '
            'Aunque no se arreglará un número erróneo:
            'si el signo decimal es la coma:
            '   1,250,45 será lo mismo que 1,25
            '   12,500.25 será lo mismo que 12,50
            'si el signo decimal es el punto:
            '   1.250.45 será lo mismo que 1.25
            '   12.500,25 será lo mismo que 12.50
            '
            i = 1
            Do
                i = InStr(i, strNum, sDecimalNo)
                If i Then
                    j = j - 1
                    If j = 0 Then
                        Mid(strNum, i, 1) = sDecimal
                    Else
                        Mid(strNum, i, 1) = " "
                    End If
                    i = i + 1
                End If
            Loop While i
        End If

        j = 0
        ' Quitar los espacios que haya por medio
        Do
            i = InStr(strNum, " ")
            If i = 0 Then Exit Do
            strNum = Left(strNum, i - 1) & Mid(strNum, i + 1)
        Loop

        ConvDecimal = strNum

        Err.Clear()
    End Function
End Class

<Security.Permissions.FileIOPermission(Security.Permissions.SecurityAction.Assert)> _
Public Class ImpresorClass

    Private _dir As String
    Public Property Directorio() As String
        Get
            Return _dir
        End Get
        Set(ByVal value As String)
            _dir = value
        End Set
    End Property

    Private _puerto As String
    Public Property Puerto() As String
        Get
            Return _puerto
        End Get
        Set(ByVal value As String)
            _puerto = value
        End Set
    End Property

    Sub New(ByVal directorio As String, ByVal puerto As String)
        _dir = directorio
        _puerto = puerto
    End Sub

    Sub Imprime(ByVal Texto As String)
        Dim f As New IO.FileStream(String.Format("{0}\tmp.txt", _dir), IO.FileMode.Create)
        Texto = vbCr & Texto & vbCrLf
        Dim mensaje As Byte() = System.Text.Encoding.UTF8.GetBytes(Texto)
        f.Write(mensaje, 0, mensaje.Length)
        f.Close()
        Dim a As String = Chr(34)
        Shell("cmd /Q /U /C " & a & String.Format("type {0}\tmp.txt > {1}", _dir, _puerto) & a, AppWinStyle.NormalFocus, True)
    End Sub

End Class

Public Class EscritorClass

#Region " Variables "
    Private _Ancho As Byte = 0
    Private _Alto As Byte = 0
    Private _PosX As Byte = 0
    Private _PosY As Byte = 0
    Private _Long As Byte = 0
    Private _Cadena As String = ""
    Private _Hoja() As String
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

#Region " Metodos Sin Retorno "
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
            Throw New ArgumentException("La longitud de la cadena excede de los limites de la hoja, verifique la posicion, o modifique la cadena.")
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
    End Sub

    Public Sub ImprimeA(ByVal Puerto As String)
        Dim lpt1 As IO.StreamWriter = GetStreamWriter(Puerto)
        lpt1.WriteLine(Lee)
        lpt1.Close()
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

Public Class PrintDevice

    Sub New(ByVal ps As System.Drawing.Printing.PrinterSettings)
        Dim s() As String = Imprimir(ps)
        sDriverName = s(0)
        sDeviceName = s(1)
        sOutputPort = s(2)
    End Sub

    Private sDriverName As String
    Public ReadOnly Property DriverName() As String
        Get
            Return sDriverName
        End Get
    End Property

    Private sDeviceName As String
    Public ReadOnly Property DeviceName() As String
        Get
            Return sDeviceName
        End Get
     End Property

    Private sOutputPort As String
    Public ReadOnly Property OutputPort() As String
        Get
            Return sOutputPort
        End Get
    End Property

    <StructLayout(LayoutKind.Sequential)> _
    Private Class DEVNAMES
        Public wDriverOffset As UShort
        Public wDeviceOffset As UShort
        Public wOutputOffset As UShort
        Public wDefault As UShort
    End Class

    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalLock", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, _
    CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function GlobalLock(ByVal hMem As IntPtr) As IntPtr
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalUnlock", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, _
    CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function GlobalUnlock(ByVal hMem As IntPtr) As Boolean
    End Function

    <DllImportAttribute("kernel32.dll", EntryPoint:="GlobalFree", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, _
    CallingConvention:=CallingConvention.StdCall)> _
    Private Shared Function GlobalFree(ByVal hMem As IntPtr) As Integer
    End Function

    Private Shared Function Imprimir(ByVal ps As System.Drawing.Printing.PrinterSettings) As String()
        Dim dev As New DEVNAMES
        Dim hDevNames As IntPtr = ps.GetHdevnames
        Dim pDevNames As IntPtr = GlobalLock(hDevNames)
        Marshal.PtrToStructure(pDevNames, dev)
        Dim _driverName As String = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wDriverOffset * Marshal.SystemDefaultCharSize)
        Dim _deviceName As String = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wDeviceOffset * Marshal.SystemDefaultCharSize)
        Dim _outputPort As String = Marshal.PtrToStringAuto(pDevNames.ToInt32 + dev.wOutputOffset * Marshal.SystemDefaultCharSize)
        GlobalUnlock(hDevNames)
        GlobalFree(hDevNames)
        Dim sArray() As String = {_driverName, _deviceName, _outputPort}
        Return sArray
    End Function

End Class

Public MustInherit Class CollectionGenClass(Of TipoClase)
    Inherits CM.BindingList(Of TipoClase)
    Implements CM.ISite, CM.IComponent

#Region " Componente "
    Private Com As CM.IComponent
    Private Con As CM.IContainer
    Private Sit As CM.ISite
    Private sName As String

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Cntr As CM.IContainer, ByVal Cmpn As CM.IComponent)
        Con = Cntr
        Com = Cmpn
        sName = Nothing
    End Sub

    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.ComponentModel.IComponent.Disposed

    Public Property Site() As System.ComponentModel.ISite Implements System.ComponentModel.IComponent.Site
        Get
            Return Sit
        End Get
        Set(ByVal value As System.ComponentModel.ISite)
            Sit = value
        End Set
    End Property

    Public ReadOnly Property Component() As System.ComponentModel.IComponent Implements System.ComponentModel.ISite.Component
        Get
            Return Com
        End Get
    End Property

    Public ReadOnly Property Container() As System.ComponentModel.IContainer Implements System.ComponentModel.ISite.Container
        Get
            Return Con
        End Get
    End Property

    Public ReadOnly Property DesignMode() As Boolean Implements System.ComponentModel.ISite.DesignMode
        Get
            Return True
        End Get
    End Property

    Public Property Name() As String Implements System.ComponentModel.ISite.Name
        Get
            Return sName
        End Get
        Set(ByVal value As String)
            sName = value
        End Set
    End Property

    Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
        Dim sp As IServiceProvider
        Return sp.GetService(Me.GetType)
    End Function

    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                Com = Nothing
                Con = Nothing
                sName = Nothing
            End If

            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region


End Class

Public Class FuncionesClass
    Public Shared Function QuitarCeros(ByVal Valor As String) As String
        Dim i As Integer = 0
        Dim tmp As String
        If IsNothing(Valor) Then
            tmp = "0000"
        Else
            For Each letra As Char In Valor
                If letra = "0" Then
                    i += 1
                Else
                    Exit For
                End If
            Next
        End If
        tmp = Mid(Valor, i)
        Return tmp
    End Function

    Public Shared Function PonerCeros(ByVal Valor As String) As String
        Dim tmp As String = ""
        If IsNothing(Valor) Then
            tmp = "0000"
        Else
            tmp = Valor
            For x As Integer = Valor.Length To 3
                tmp = "0" & tmp
            Next
        End If
        Return tmp
    End Function
End Class