#Region "Delegados"
Public Delegate Sub MensajeErrorHandler(ByVal sender As Object, ByVal mensaje As String)
#End Region

#Region "Enumeraciones"

Public Enum FormState As Byte
    Borrar
    Buscar
    Cancelar
    Editar
    Guardar
    Imprimir
    Limpiar
    Mostrar
    Nuevo
    Salir
End Enum

Public Enum FacFormasPagoEnum
    UNA_SOLA_EXHIBICION = 1
    PARCIALIDADES = 2
End Enum

Public Enum FacMetodoPagoEnum
    NO_IDENTIFICADO = 1
    CHEQUE = 2
    DEPOSITO_EN_CUENTA = 3
    EFECTIVO = 4
    TARJETA_DE_CREDITO = 5
    TARJETA_DE_DEBITO = 6
    TRANSFERENCIA_ELECTRONICA = 7
End Enum

Public Enum MotivoDevolucion
    CALIDAD_NO_DESEADA = 1
    PRODUCTO_PONCHADO
    PRODUCTO_CON_COLOR
    PRODUCTO_CON_OLOR
End Enum

Public Enum TipoCorte
    FRESCO = 1
    CONGELADO
    VALOR_AGREGADO_FRESCO
    VALOR_AGREGADO_CONGELADO
    HUESO_FRESCO
    HUESO_CONGELADO
    VENTA
    VALOR_AGREGADO_VENTA
    HUESO_VENTA
End Enum

Public Enum TipoProductoAlmacen As Byte
    GENERAL = 0
    FRESCO
    CONGELADO
    VENTA
End Enum

Public Enum EstatusDevolucion
    CANCELADA
    ACTIVA
End Enum

Public Enum EstatusCanal
    VIGENTE = Asc("V")
    EN_CORTE = Asc("T")
    EMBARCADO = Asc("E")
End Enum

Public Enum NotaCreditoEnum As Byte
    ''' <summary>
    ''' Indica que ha sido cancelada
    ''' </summary>
    ''' <remarks></remarks>
    CANCELADA
    ''' <summary>
    ''' Indica que esta pendiente por aplicar
    ''' </summary>
    ''' <remarks></remarks>
    VIGENTE
    ''' <summary>
    ''' Indica que ha sido aplicada
    ''' </summary>
    ''' <remarks></remarks>
    APLICADA
    ''' <summary>
    ''' Indica que parte de la nota ha sido aplicada
    ''' Nota: Solo se aplica en el encabezado
    ''' </summary>
    ''' <remarks></remarks>
    PARCIALMENTE_APLICADA
    ''' <summary>
    ''' Indica que la factura a la cual se destino la nota ya ha sido pagada
    ''' y por lo tanto la nota ya no es aplicable
    ''' </summary>
    ''' <remarks></remarks>
    NO_APLICABLE
    TODAS
End Enum

Public Enum EstatusCorte
    CANCELADO = 0
    VIGENTE
    REPROCESO
    AJUSTE
End Enum

Public Enum SexoEnum
    HEMBRA = 1
    MACHO = 2
End Enum

Public Enum TipoServicionEnum
    PRODUCCION = 1
    EMBARQUE = 2
End Enum

Public Enum TipoProductoEnum
    CANAL = 0
    CORTE = 1
    PRODUCTO = 2
End Enum

Public Enum ErroresPolizaEnum
    NINGUNO = 0
    LA_FECHA_DE_LA_POLIZA_NO_ESTA_DENTRO_DEL_EJERCICIO_CONTABLE = 1
    POLIZA_DESCUADRADA = 2
    ALGUNAS_DE_LAS_CUENTAS_CONTABLES_DE_PARTIDAS_NO_ESTAN_EN_EL_CATALOGO = 3
    ALGUNAS_DE_LAS_CUENTAS_CONTABLES_NO_SON_AFECTABLES = 4
    NO_SE_ENCONTRO_EL_DETALLE_DE_LA_POLIZA = 5
End Enum

Public Enum EstatusFacturasApagar
    PROGRAMADA = 0
    AUTORIZADA = 1
    PAGADA = 2
End Enum

Public Enum CondicionEstatusEnum
    ACTIVO = 1
    INACTIVO = 0
    TODOS = 2
End Enum

Public Enum EstatusOrdenCompra
    CANCELADO = 0
    VIGENTE = 1
    'AUTORIZADO = 2
    'EMITIDA = 3
    FINIQUITADO = 4
    FACTURADA = 5
    'RECIBIDA_PARCIALMENTE = 3
    'RECIBIDA = 4
End Enum

Public Enum EstatusChar
    VIGENTE = Asc("V")
    CANCELADO = Asc("C")
    '************************* Estatus para Facturas
    PAGADO = Asc("P")
    ABONADO = Asc("A")
    '*************************
    TODOS
End Enum

Public Enum EstatusCharX
    VIGENTE = Asc("V")
    CANCELADO = Asc("X")
    FACTURADO = Asc("F")
    DEVUELTO = Asc("D")
    TODOS
End Enum

Public Enum EstatusDatos As Byte
    CANCELADO = 0
    VIGENTE = 1
End Enum

Public Enum TipoPagoEnum
    ANTICIPADO_MONTO = 1
    ANTICIPADO_PORCENTAJE = 2
End Enum

Public Enum TipoPagoFactura
    EFECTIVO = Asc("E")
    TARJETA = Asc("T")
    CHEQUE = Asc("C")
End Enum

Public Enum EstatusOrdenRetiroEnum
    CANCELADA
    VIGENTE
    RECIBIDA
End Enum

Public Enum EstatusRecepcionEnum
    CANCELADA
    RECEPCIONADA
    PARCIAL
    TOTAL
End Enum

Public Enum EstatusRecepcionOrden
    CANCELADA = 0
    VIGENTE = 1
    FACTURADA = 2
    FINIQUITADO = 3
End Enum

Public Enum EstatusOrdenRecibida
    NO_RECIBIDA = 0
    RECIBIDA = 1
    PARCIAL = 2
    TODAS = 4
End Enum

Public Enum EstatusAutorizada
    SI = True
    NO = False
    TODAS = 2
End Enum

Public Enum EstatusPagosProveedoresEnum
    CANCELADO
    VIGENTE
End Enum

Public Enum TipoCorral As Short
    ENGORDA = 1
    ENFERMERIA
    RECIBA
    TODOS
End Enum

Public Enum EstatusEnum As Byte
    ACTIVO = 1
    INACTIVO = 0
End Enum

Public Enum EstatusCotizacionEnum
    INACTIVA
    EN_VENTA
    VENDIDA
End Enum

Public Enum PersonaEnum
    FISICA = 1
    MORAL = 0
End Enum

Public Enum DiasEnum
    DOMINGO
    LUNES
    MARTES
    MIERCOLES
    JUEVES
    VIERNES
    SABADO
End Enum

Public Enum MesEnum As Byte
    ENERO
    FEBRERO
    MARZO
    ABRIL
    MAYO
    JUNIO
    JULIO
    AGOSTO
    SEPTIEMBRE
    OCTUBRE
    NOVIEMBRE
    DICIEMBRE
End Enum

Public Enum MesEnum2
    ENERO = 1
    FEBRERO
    MARZO
    ABRIL
    MAYO
    JUNIO
    JULIO
    AGOSTO
    SEPTIEMBRE
    OCTUBRE
    NOVIEMBRE
    DICIEMBRE
End Enum

Public Enum TCambioEnum
    NO = 4
    SI = 5
End Enum

Public Enum PPagoEnum
    NO = 0
    SI = 1
End Enum

Public Enum CondicionEnum As Byte
    ACTIVOS = 1
    INACTIVOS = 0
    TODOS = 2
End Enum

Public Enum CondicionCotizacionEnum
    TODAS = -1
    INACTIVA = 0
    ENVENTA = 1
    VENDIDA = 2
End Enum

Public Enum CondicionTipoVentaEnum
    CREDITO = 0
    CONTADO = 1
    TODAS = 2
End Enum

Public Enum AlmacenEnum As Integer
    ALMACEN = 3
    SUBALMACEN = 4
    TODOS = 5
End Enum

Public Enum TipoAlmacenEnum
    ALMACEN = False
    SUBALMACEN = True
End Enum

Public Enum DireccionEnum
    ENTRADAS
    SALIDAS
End Enum

Public Enum CondicionDireccionEnum
    ENTRADAS
    SALIDAS
    TODAS
End Enum

''' <summary>
''' Sirve para especificar lo que decea mostrar del catalogo de cliente
''' </summary>
''' <remarks></remarks>
Public Enum MostrarEnum
    CLIENTES
    COMPRADORES
    TODOS
End Enum

''' <summary>
''' Sirve para especificar si se decea mostrar datos Facturados, Sin Facturar o Todos 
''' </summary>
''' <remarks></remarks>
Public Enum MostrarDatosEnum
    SIN_FACTURAR
    FACTURADOS
    TODOS
End Enum

''' <summary>
''' Sirve para especificar si la busqueda sera completa o basica
''' </summary>
''' <remarks></remarks>
Public Enum TipoBusquedaEnum
    BASICA
    COMPLETA
End Enum

Public Enum TipoListaPrecioEnum
    LISTA_NO_BASE
    LISTA_BASE
    TODAS
End Enum

Public Enum EsBaseEnum
    NO = False
    SI = True
End Enum

Public Enum TipoVentaEnum
    CREDITO
    CONTADO
End Enum

Public Enum TipoMonedaEnum
    DOLAR
    Peso
End Enum

''' <summary>
''' Sirve para especificar que tipo de dato se esta empleando
''' </summary>
''' <remarks></remarks>
Public Enum TipoDatoEnum
    FECHA
    NUMERO
    CADENA
End Enum

Public Enum AfectaCostoEnum
    SI = True
    NO = False
End Enum

Public Enum SiNoEnum As Byte
    NO
    SI
End Enum

Public Enum AsignadaEnum
    SI = True
    NO = False
End Enum

Public Enum CondicionAsignadaEnum
    NO = 0
    SI = 1
    TODOS = 2
End Enum

Public Enum EstadoRegistro
    Activo = 1
    Inactivo = 0
End Enum

Public Enum CondicionOrdenRecibida
    SI = 1
    NO = 0
    PARCIAL = 2
    TODOS = 3
    NOYPARCIAL = 4 'NO RECIBIDAS Y PARCIALMENTE RECIBIDAS
End Enum

Public Enum PendienteFacturarEnum
    SI = True
    NO = False
End Enum

Public Enum CondicionPendienteFacturarEnum
    NO = 0
    SI
    TODOS
End Enum

Public Enum SiNoCharEnum
    SI = Asc("S")
    NO = Asc("N")
End Enum

Public Enum BajaCancelacionEnum
    CANCELACIÓN
    BAJA
    TODOS
End Enum

Public Enum TipoMotivoEnum
    CANCELACIÓN
    BAJA
End Enum

Public Enum EstatusFacturasEnum
    CANCELADA = 0
    PAGADA = 1
    VIGENTE = 2
    ABONADA = 3
End Enum

Public Enum EstatusCalculoNomina
    IMPRESA
    GENERADA
End Enum

Public Enum CondicionEstatusCalculoNomina
    IMPRESA
    GENERADA
    TODOS
End Enum

Public Enum TipoFacturaEnum
    VENTA_DE_PRODUCTO = 1
    FACTURACION_DE_EMBARQUE = 2
    FACTURACION_DE_MAQUILA = 3
    FACTURACION_DE_VENTA_DE_RECIBA = 4
    FACTURACION_DE_MUERTE_EN_RECIBA = 5
    FACTURACION_DE_VENTA_DE_CORRAL = 6
    FACTURACION_DE_MUERTE_EN_CORRAL = 7
    FACTURACION_ESPECIAL = 8
End Enum
#End Region

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
    Inherits System.ComponentModel.BindingList(Of DiaClass)
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

Public Class MesClass
    Private _Mes As MesEnum

    Public Property Mes() As MesEnum
        Get
            Return _Mes
        End Get
        Set(ByVal value As MesEnum)
            _Mes = value
        End Set
    End Property

    Sub New(ByVal mes As MesEnum)
        _Mes = mes
    End Sub
End Class

Public Class MesesClass
    Inherits System.ComponentModel.BindingList(Of MesClass)

    Sub New()
        Me.Add(New MesClass(MesEnum.ENERO))
        Me.Add(New MesClass(MesEnum.FEBRERO))
        Me.Add(New MesClass(MesEnum.MARZO))
        Me.Add(New MesClass(MesEnum.ABRIL))
        Me.Add(New MesClass(MesEnum.MAYO))
        Me.Add(New MesClass(MesEnum.JUNIO))
        Me.Add(New MesClass(MesEnum.JULIO))
        Me.Add(New MesClass(MesEnum.AGOSTO))
        Me.Add(New MesClass(MesEnum.SEPTIEMBRE))
        Me.Add(New MesClass(MesEnum.OCTUBRE))
        Me.Add(New MesClass(MesEnum.NOVIEMBRE))
        Me.Add(New MesClass(MesEnum.DICIEMBRE))
    End Sub
End Class

Public Class CondicionEstatusEnumCollectionClass
    Inherits System.ComponentModel.BindingList(Of CondicionEnum)

    Sub New()
        Add(CondicionEnum.TODOS)
        Add(CondicionEnum.ACTIVOS)
        Add(CondicionEnum.INACTIVOS)
    End Sub
End Class

Public Class ConvertirNumeroALetraClass
    Private Shared _TipoMoneda As TipoMonedaEnum
    Private Shared Moneda As MonedaStrc

    Private Shared Pointer1 As Integer = 0
    Private Shared Pointer2 As Integer = 0

    ''' <summary>
    ''' Convierte numeros de 1 a 9 a letra
    ''' </summary>
    ''' <param name="Digit">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetDigit(ByVal Digit As String) As String
        Select Case Val(Digit)
            Case 1 : GetDigit = "Un"
            Case 2 : GetDigit = "Dos"
            Case 3 : GetDigit = "Tres"
            Case 4 : GetDigit = "Cuatro"
            Case 5 : GetDigit = "Cinco"
            Case 6 : GetDigit = "Seis"
            Case 7 : GetDigit = "Siete"
            Case 8 : GetDigit = "Ocho"
            Case 9 : GetDigit = "Nueve"
            Case Else : GetDigit = ""
        End Select
    End Function

    ''' <summary>
    ''' Convierte numeros de 10 a 99 a letras
    ''' </summary>
    ''' <param name="TensText">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetTens(ByVal TensText As Integer) As String
        Dim Result As String

        Result = ""           'anula el valor temporal de la funcion
        If Val(Microsoft.VisualBasic.Left(TensText, 1)) = 1 Then   ' si el valor esta entre 10-19
            Select Case Val(TensText)
                Case 10 : Result = "Diez"
                Case 11 : Result = "Once"
                Case 12 : Result = "Doce"
                Case 13 : Result = "Trece"
                Case 14 : Result = "Catorce"
                Case 15 : Result = "Quince"
                Case 16 : Result = "Dieciseis"
                Case 17 : Result = "Diecisiete"
                Case 18 : Result = "Dieciocho"
                Case 19 : Result = "Diecinueve"
                Case Else
            End Select
        Else    ' Si el valor esta entre 20-99
            Select Case Val(Microsoft.VisualBasic.Left(TensText, 1))
                Case 2 : Result = "Veinte "
                Case 3 : Result = "Treinta "
                Case 4 : Result = "Cuarenta "
                Case 5 : Result = "Cincuenta "
                Case 6 : Result = "Sesenta "
                Case 7 : Result = "Setenta "
                Case 8 : Result = "Ochenta "
                Case 9 : Result = "Noventa "
                Case Else
            End Select
            Result = Result & GetDigit _
       (Microsoft.VisualBasic.Right(TensText, 1))  'Retrae el lugar
        End If
        GetTens = Result
    End Function

    ''' <summary>
    ''' Convierte numeros de 100 a 999 a letras
    ''' </summary>
    ''' <param name="MyNumber">Numero a Convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetHundreds(ByVal MyNumber As String) As String
        Dim Result As String = ""
        Dim Quinien As String = ""
        Dim Quinien2 As String = ""

        If Val(MyNumber) = 0 Then Return ""
        MyNumber = Microsoft.VisualBasic.Right("000" & MyNumber, 3)

        'Converte el lugar de las centenas
        Quinien2 = " Cientos "
        If Mid(MyNumber, 1, 1) <> "0" Then
            Quinien = GetDigit(Mid(MyNumber, 1, 1))
            If Quinien = "Cinco" Then
                Quinien = "Quinientos "
                Quinien2 = ""
            End If
            If Quinien = "Un" Then
                Quinien = ""
                Quinien2 = "Ciento "
            End If
            If Quinien = "Nueve" Then
                Quinien = "Nove"
                Quinien2 = "cientos "
            End If
            If Quinien = "Siete" Then
                Quinien = "Sete"
                Quinien2 = "cientos "
            End If
            Result = Quinien & Quinien2 ' aca le agrega al numero la palabra
        End If

        'Convierte el lugar de los miles
        If Mid(MyNumber, 2, 1) <> "0" Then
            Quinien = GetTens(Mid(MyNumber, 2))
            If Pointer1 = 0 Then
                Pointer1 = 1
                If Mid(MyNumber, 3, 1) <> "0" Then
                    Quinien = Replace(Quinien, " ", " y ")
                Else
                    Quinien = Replace(Quinien, " ", " ")
                End If

            End If
            Result = Result & Quinien
        Else
            Quinien = GetDigit(Mid(MyNumber, 3))
            Result = Result & Quinien
        End If

        GetHundreds = Result
    End Function

    ''' <summary>
    ''' Convierte un numero a letras
    ''' </summary>
    ''' <param name="MyNumber">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Convertir(ByVal MyNumber As String, ByVal TipoMoneda As TipoMonedaEnum) As String
        Dim OtroNumero As String = MyNumber
        Dim Dolares As String = ""
        Dim Centavos As String = ""
        Dim Temp As String = ""
        Dim DecimalPlace, Count As Integer
        Dim Place(9) As String

        Pointer1 = 0
        Pointer2 = 0



        Dim l As String = CStr(Right(TipoMoneda.ToString, 1))
        'Moneda.Plural = TipoMoneda.ToString
        Select Case l
            Case "o"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "a"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "i"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "e"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "u"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case Else
                If TipoMoneda <> TipoMonedaEnum.Peso Then
                    Moneda.Singular = TipoMoneda.ToString & " "
                    Moneda.Plural = TipoMoneda.ToString & "ES"
                End If
        End Select



        Place(2) = " Mil "
        Place(3) = " Millones "
        Place(4) = " Mil "
        Place(5) = " Billones "
        Place(6) = " Mil "
        Place(7) = " Trillones "
        Place(8) = " Mil "

        ' String representa la cantidad
        MyNumber = Trim(MyNumber)

        ' el lugar de la posicion decimal ) si ninguno
        DecimalPlace = InStr(MyNumber, ".")

        'Convierte Centavos and set MyNumber a la cantidad en pesos
        If DecimalPlace > 0 Then
            OtroNumero = Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1)
            Centavos = Microsoft.VisualBasic.Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            MyNumber = Trim(Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1))
        Else
            OtroNumero = MyNumber
            Centavos = "00"
        End If

        Dim enta, hacer As String
        Dim BuscaEspacio As Integer
        enta = CStr(MyNumber)
        hacer = ""
        If enta.Length = 2 And (Microsoft.VisualBasic.Right(enta, 1) = "0") Then
            hacer = "cero"
        End If

        Count = 1
        Do While MyNumber.ToString <> ""
            Temp = GetHundreds(Microsoft.VisualBasic.Right(MyNumber, 3))
            If Temp <> "" Then Dolares = Temp & Place(Count) & Dolares
            If Len(MyNumber) > 3 Then
                If Len(OtroNumero) = 4 And Microsoft.VisualBasic.Left(OtroNumero, 1) = "1" Then
                    Pointer2 = 1
                Else
                    Pointer1 = 0
                End If
                MyNumber = Microsoft.VisualBasic.Left(MyNumber, Len(MyNumber) - 3)
            Else
                MyNumber = ""
            End If
            Count = Count + 1
        Loop

        If Pointer2 = 1 Then
            Dolares = Microsoft.VisualBasic.Right(Dolares, Len(Dolares) - 3)
        End If

        If hacer = "cero" Then
            BuscaEspacio = InStr(Dolares, " ")
            Dolares = Microsoft.VisualBasic.Left(Dolares, BuscaEspacio - 1)
        End If

        Select Case Dolares
            Case ""
                Dolares = "Cero " & Moneda.Plural
            Case "Un"
                Dolares = "Un " & Moneda.Singular
            Case Else
                Dolares = Dolares & " " & Moneda.Plural
        End Select


        Centavos = Centavos & "/100"

        'para agregar la leyenda de Moneda Nacional a las facturas
        If TipoMoneda = TipoMonedaEnum.Peso Then
            Centavos = Centavos & " M.N"
        End If

        Return "SON: (" & Dolares & Centavos & ")"
    End Function

End Class

Public Class ConvertirNumeroInglesALetraClass
    Private Shared _TipoMoneda As TipoMonedaEnum
    Private Shared Moneda As MonedaStrc

    Private Shared Pointer1 As Integer = 0
    Private Shared Pointer2 As Integer = 0

    ''' <summary>
    ''' Convierte numeros de 1 a 9 a letra
    ''' </summary>
    ''' <param name="Digit">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetDigit(ByVal Digit As String) As String
        Select Case Val(Digit)
            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""
        End Select
    End Function

    ''' <summary>
    ''' Convierte numeros de 10 a 99 a letras
    ''' </summary>
    ''' <param name="TensText">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetTens(ByVal TensText As Integer) As String
        Dim Result As String

        Result = ""           'anula el valor temporal de la funcion
        If Val(Microsoft.VisualBasic.Left(TensText, 1)) = 1 Then   ' si el valor esta entre 10-19
            Select Case Val(TensText)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eightheen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else    ' Si el valor esta entre 20-99
            Select Case Val(Microsoft.VisualBasic.Left(TensText, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Fourty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eigthty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select
            Result = Result & GetDigit _
       (Microsoft.VisualBasic.Right(TensText, 1))  'Retrae el lugar
        End If
        GetTens = Result
    End Function

    ''' <summary>
    ''' Convierte numeros de 100 a 999 a letras
    ''' </summary>
    ''' <param name="MyNumber">Numero a Convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetHundreds(ByVal MyNumber As String) As String
        Dim Result As String = ""
        Dim Quinien As String = ""
        Dim Quinien2 As String = ""

        If Val(MyNumber) = 0 Then Return ""
        MyNumber = Microsoft.VisualBasic.Right("000" & MyNumber, 3)

        'Converte el lugar de las centenas
        Quinien2 = " Hundreds "
        If Mid(MyNumber, 1, 1) <> "0" Then
            Quinien = GetDigit(Mid(MyNumber, 1, 1))
            Quinien2 = "Houndres"
            'If Quinien = "Five" Then
            '    Quinien = "Houndreds "
            '    Quinien2 = "Houndreds "
            'End If
            'If Quinien = "One" Then
            '    Quinien = ""
            '    Quinien2 = "Hundred "
            'End If
            'If Quinien = "Nine" Then
            '    Quinien = "H"
            '    Quinien2 = "cientos "
            'End If
            'If Quinien = "Siete" Then
            '    Quinien = "Sete"
            '    Quinien2 = "cientos "
            'End If
            Result = Quinien & Quinien2 ' aca le agrega al numero la palabra
        End If

        'Convierte el lugar de los miles
        If Mid(MyNumber, 2, 1) <> "0" Then
            Quinien = GetTens(Mid(MyNumber, 2))
            If Pointer1 = 0 Then
                Pointer1 = 1
                If Mid(MyNumber, 3, 1) <> "0" Then
                    Quinien = Replace(Quinien, " ", " y ")
                Else
                    Quinien = Replace(Quinien, " ", " ")
                End If

            End If
            Result = Result & Quinien
        Else
            Quinien = GetDigit(Mid(MyNumber, 3))
            Result = Result & Quinien
        End If

        GetHundreds = Result
    End Function

    ''' <summary>
    ''' Convierte un numero a letras
    ''' </summary>
    ''' <param name="MyNumber">Numero a convertir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Convertir(ByVal MyNumber As String, ByVal TipoMoneda As TipoMonedaEnum) As String
        Dim OtroNumero As String = MyNumber
        Dim Dolares As String = ""
        Dim Centavos As String = ""
        Dim Temp As String = ""
        Dim DecimalPlace, Count As Integer
        Dim Place(9) As String

        Pointer1 = 0
        Pointer2 = 0



        Dim l As String = CStr(Right(TipoMoneda.ToString, 1))
        'Moneda.Plural = TipoMoneda.ToString
        Select Case l
            Case "o"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "a"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "i"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "e"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case "u"
                Moneda.Singular = TipoMoneda.ToString & " "
                Moneda.Plural = TipoMoneda.ToString & "s "
            Case Else
                If TipoMoneda <> TipoMonedaEnum.Peso Then
                    Moneda.Singular = TipoMoneda.ToString & " "
                    Moneda.Plural = TipoMoneda.ToString & "ES"
                End If
        End Select



        Place(2) = " Thosand "
        Place(3) = " Million "
        Place(4) = " Mil "
        Place(5) = " Billones "
        Place(6) = " Mil "
        Place(7) = " Trillones "
        Place(8) = " Mil "

        ' String representa la cantidad
        MyNumber = Trim(MyNumber)

        ' el lugar de la posicion decimal ) si ninguno
        DecimalPlace = InStr(MyNumber, ".")

        'Convierte Centavos and set MyNumber a la cantidad en pesos
        If DecimalPlace > 0 Then
            OtroNumero = Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1)
            Centavos = Microsoft.VisualBasic.Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            MyNumber = Trim(Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1))
        Else
            OtroNumero = MyNumber
            Centavos = "00"
        End If

        Dim enta, hacer As String
        Dim BuscaEspacio As Integer
        enta = CStr(MyNumber)
        hacer = ""
        If enta.Length = 2 And (Microsoft.VisualBasic.Right(enta, 1) = "0") Then
            hacer = "Zero"
        End If

        Count = 1
        Do While MyNumber.ToString <> ""
            Temp = GetHundreds(Microsoft.VisualBasic.Right(MyNumber, 3))
            If Temp <> "" Then Dolares = Temp & Place(Count) & Dolares
            If Len(MyNumber) > 3 Then
                If Len(OtroNumero) = 4 And Microsoft.VisualBasic.Left(OtroNumero, 1) = "1" Then
                    Pointer2 = 1
                Else
                    Pointer1 = 0
                End If
                MyNumber = Microsoft.VisualBasic.Left(MyNumber, Len(MyNumber) - 3)
            Else
                MyNumber = ""
            End If
            Count = Count + 1
        Loop

        If Pointer2 = 1 Then
            Dolares = Microsoft.VisualBasic.Right(Dolares, Len(Dolares) - 3)
        End If

        If hacer = "Zero" Then
            BuscaEspacio = InStr(Dolares, " ")
            Dolares = Microsoft.VisualBasic.Left(Dolares, BuscaEspacio - 1)
        End If

        Select Case Dolares
            Case ""
                Dolares = "Cero " & Moneda.Plural
            Case "Un"
                Dolares = "Un " & Moneda.Singular
            Case Else
                Dolares = Dolares & " " & Moneda.Plural
        End Select


        Centavos = Centavos

        'para agregar la leyenda de Moneda Nacional a las facturas
        If TipoMoneda = TipoMonedaEnum.Peso Then
            Centavos = Centavos
        End If

        Return "SON: (" & Dolares & Centavos & ")"
    End Function

End Class


#Region "Interfaces"
Public Interface IEntidad

    Event Modificado As EventHandler

    Event MensajeError As MensajeErrorHandler

    Property Estatus() As EstatusEnum

    Function Guardar() As Boolean

    Function Borrar() As Boolean

    Function Cancelar() As Boolean

    Function Obtener(ByVal Codigo As Integer) As Boolean

End Interface

Public Interface IEntidad2
    Inherits IEntidad

    Sub LeerEntidad(ByVal Entidad As Object)

    Function ObtenerEntidad() As Object

End Interface

#End Region

#Region "Estructuras"

Public Structure MonedaStrc
    Dim Singular As String
    Dim Plural As String
End Structure

#End Region