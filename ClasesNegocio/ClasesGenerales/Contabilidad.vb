Imports IC = Integra.Clases
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel
Imports System.Windows.Forms
Imports Integra.Clases
Imports System.Data.SqlClient


Public Enum CuentaContableNaturalezaEnum
    DEUDORA = Asc("D")
    ACREEDORA = Asc("A")
End Enum

Public Enum CuentaContableNaturalezaCondicionEnum
    DEUDORAS = Asc("D")
    ACREEDORAS = Asc("A")
    TODAS = 2
End Enum

Public Enum PolizaTipoPolizaEnum
    INGRESO = Asc("I")
    EGRESO = Asc("E")
    CANCELACION = Asc("C")
    DIARIO = Asc("D")
    TODOS = 2
End Enum

Public Enum PolizaOrigenEnum As Byte
    ALMACEN = Asc("A")
    BANCOS = Asc("B")
    COMPRAS = Asc("C")
    CONTABILIDAD = Asc("N")
    CUENTASxCOBRAR = Asc("X")
    CUENTASxPAGAR = Asc("P")
    VENTAS = Asc("V")
    TODOS = 2
End Enum

Public Enum PolizaEstatusEnum
    CANCELADA
    ACTIVA
    APLICADA
End Enum

Public Enum PolizaOperacionEnum
    CARGO = Asc("C")
    ABONO = Asc("A")
End Enum

Public Enum PolizaOperacionEnum2
    A = Asc("A")
    C = Asc("C")
End Enum

'////////////// CUENTAS CONTABLES   ////////////////////////

Public Class CuentaContableClass
    Inherits ClassBase(Of EC.CuentaContableEntity)

#Region "Miembros"
    Public Event Modificado As EventHandler
    Public Event MensajeError As Integra.Clases.MensajeErrorHandler
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
    Private WithEvents PolizaDetalle As PolizaDetalleCollectionClass
#End Region

#Region "Constructores"
    Sub New()
        'MyBase.New()
        Entity = New EC.CuentaContableEntity
        Entity.Cta = "0000"
        Entity.SubCta = "0000"
        Entity.SsubCta = "0000"
        Entity.SssubCta = "0000"
        Dim indiceA As Integer = 1
        Dim indiceC As Integer = 1
        Dim indiceP As Integer = 1
        For Each prop As Reflection.PropertyInfo In Entity.GetType.GetProperties
          
            Select Case prop.Name
                Case "Abonos" & indiceA.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceA += 1
                Case "Cargos" & indiceC.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceC += 1
                Case "Presup" & indiceP.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceP += 1
            End Select
        Next
    End Sub

    Sub New(ByVal Codigo As Integer)
        'MyBase.New()
        Entity = New EC.CuentaContableEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.CuentaContableEntity)
        'MyBase.New()
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    <CM.DisplayName("Código")> _
    ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property

    <CM.DisplayName("Cuenta Mayor")> _
    Public Property CuentaMayor() As String
        Get
            Return Entity.Cta
        End Get
        Set(ByVal value As String)
            Entity.Cta = value
        End Set
    End Property

    <CM.DisplayName("Sub Cuenta")> _
    Public Property SubCuenta() As String
        Get
            Return Entity.SubCta
        End Get
        Set(ByVal value As String)
            Entity.SubCta = value
        End Set
    End Property

    <CM.DisplayName("SSub Cuenta")> _
    Public Property SSubCuenta() As String
        Get
            Return Entity.SsubCta
        End Get
        Set(ByVal value As String)
            Entity.SsubCta = value
        End Set
    End Property

    <CM.DisplayName("SSSub Cuenta")> _
    Public Property SSSubCuenta() As String
        Get
            Return Entity.SssubCta
        End Get
        Set(ByVal value As String)
            Entity.SssubCta = value
        End Set
    End Property


    <CM.DisplayName("NumCuenta")> _
    Public Property NumCuenta() As String
        Get
            Return Entity.Cta + Entity.SubCta + Entity.SsubCta + Entity.SssubCta
        End Get
        Set(ByVal value As String)
            Entity.SssubCta = value
        End Set
    End Property

    <CM.DisplayName("Nombre de Cuenta")> _
    Public Property NombreCuenta() As String
        Get
            Return Entity.NomCuenta
        End Get
        Set(ByVal value As String)
            Entity.NomCuenta = value
        End Set
    End Property

    <CM.DisplayName("Codigo Agrupador SAT")> _
    Public Property CodAgrupSAT() As String
        Get
            Return Entity.CodAgrupSat
        End Get
        Set(ByVal value As String)
            Entity.CodAgrupSat = value
        End Set
    End Property

    Public Property Naturaleza() As CuentaContableNaturalezaEnum
        Get
            Return CType(Asc(Entity.Naturaleza), CuentaContableNaturalezaEnum)
        End Get
        Set(ByVal value As CuentaContableNaturalezaEnum)
            Entity.Naturaleza = Chr(value)
        End Set
    End Property

    <CM.DisplayName("N° de Hijos")> _
    Public Property NoHijos() As Short
        Get
            Return Entity.NumeroHijos
        End Get
        Set(ByVal value As Short)
            Entity.NumeroHijos = value
        End Set
    End Property

    <CM.DisplayName("Cuenta Contable")> _
    ReadOnly Property CuentaContable() As String
        Get
            Dim params() As Object = {Entity.Cta, Entity.SubCta, Entity.SsubCta, Entity.SssubCta}
            Return String.Format("{0}-{1}-{2}-{3}", params)
        End Get
    End Property

    <CM.DisplayName("Nombre Largo")> _
    ReadOnly Property NombreLargo() As String
        Get
            Dim params() As Object = {Entity.Cta, Entity.SubCta, Entity.SsubCta, Entity.SssubCta, Entity.NomCuenta}
            Return String.Format("{0}-{1}-{2}-{3} {4}", params)
        End Get
    End Property

    <CM.DisplayName("Cuenta Contable Padre")> _
    Public Property CuentaPadre() As CuentaContableClass

        Get
            Dim tmp As CuentaContableClass = Nothing
            If Entity.CtaPadre.GetValueOrDefault(0) > 0 Then tmp = New CuentaContableClass(Entity.CuentaPadre)
            Return tmp
        End Get
        Set(ByVal value As CuentaContableClass)
            If Not IsNothing(value) Then
                Entity.CuentaPadre = value.ObtenerEntidad
            Else
                Dim ni As New System.Nullable(Of Integer)
                Entity.CtaPadre = ni
            End If
        End Set
    End Property

    Public ReadOnly Property CuentasHijas() As CuentaContableCollectionClass
        Get
            Dim tmp As CuentaContableCollectionClass = Nothing
            If Entity.CuentasHijas.Count > 0 Then tmp = New CuentaContableCollectionClass(Entity.CuentasHijas)
            Return tmp
        End Get
    End Property

    Public ReadOnly Property NombreCuentaContable() As String
        Get
            Return Me.ToString
        End Get
    End Property

    <CM.DisplayName("Cuenta Contable Entrada")> _
    Public Property CuentaEntrada() As CuentaContableClass
        Get
            Dim tmp As New CuentaContableClass
            If Entity.CtaEnt.GetValueOrDefault(0) > 0 Then tmp = New CuentaContableClass(Entity.CuentaEntrada)
            Return tmp
        End Get
        Set(ByVal value As CuentaContableClass)
            If Not IsNothing(value) Then
                Entity.CuentaEntrada = value.ObtenerEntidad
            Else
                Dim ni As New System.Nullable(Of Integer)
                Entity.CtaEnt = ni
            End If
        End Set
    End Property

    <CM.DisplayName("Cuenta Contable Salida")> _
    Public Property CuentaSalida() As CuentaContableClass
        Get
            Dim tmp As New CuentaContableClass
            If Entity.CtaSal.GetValueOrDefault(0) > 0 Then tmp = New CuentaContableClass(Entity.CuentaSalida)
            Return tmp
        End Get
        Set(ByVal value As CuentaContableClass)
            If Not IsNothing(value) Then
                Entity.CuentaSalida = value.ObtenerEntidad
            Else
                Dim ni As New System.Nullable(Of Integer)
                Entity.CtaSal = ni
            End If
        End Set
    End Property

    Public ReadOnly Property Afectable() As IC.SiNoEnum
        Get
            Return Entity.BooAfectable
        End Get
    End Property

    Public Property Bancos() As IC.SiNoEnum
        Get
            Return Entity.BooBancos
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooBancos = value
        End Set
    End Property

    Public Property Resultado() As IC.SiNoEnum
        Get
            Return Entity.BooResultad
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooResultad = value
        End Set
    End Property

    Public Property Presupuesto() As IC.SiNoEnum
        Get
            Return Entity.BooPresup
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooPresup = value
        End Set
    End Property

    Public Property Inactiva() As IC.SiNoEnum
        Get
            Return Entity.BooInactiva
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooInactiva = value
        End Set
    End Property

    Public Property Departamentalizable() As IC.SiNoEnum
        Get
            Return Entity.BooDepta
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooDepta = value
        End Set
    End Property

    <CM.DisplayName("Saldo del Año Anterior")> _
    Public Property SaldoAñoAnterior() As Decimal
        Get
            Return Entity.SaldoAnoAnt
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoAnoAnt = value
        End Set
    End Property

    <CM.DisplayName("Saldo de Inicio del Ejercicio")> _
    Public Property SaldoInicioEjercicio() As Decimal
        Get
            Return Entity.SaldoIniEjerc
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoIniEjerc = value
        End Set
    End Property
    Public Property TitulodeEstadoFinanciero() As Integer
        Get
            Return Entity.Titulo
        End Get
        Set(ByVal value As Integer)
            Entity.Titulo = value
        End Set
    End Property
    Public Property SubTitulodeEstadoFinanciero() As Integer
        Get
            Return Entity.SubTitulo
        End Get
        Set(ByVal value As Integer)
            Entity.SubTitulo = value
        End Set
    End Property

    Public ReadOnly Property Nivel() As Integer
        Get
            Dim niv As Integer = 1
            If Entidad.SubCta <> "0000" Then
                If Entidad.SsubCta <> "0000" Then
                    If Entidad.SssubCta <> "0000" Then
                        niv = 4
                    Else
                        niv = 3
                    End If

                Else
                    niv = 2
                End If

            End If

            Return niv
        End Get

    End Property

    Public ReadOnly Property CtaPadre() As String
        Get
            Dim niv As String = ""
            If Entidad.SubCta <> "0000" Then
                If Entidad.SsubCta <> "0000" Then
                    If Entidad.SssubCta <> "0000" Then
                        niv = Entidad.Cta + "" + Entidad.SubCta + "" + Entidad.SsubCta + "0000"
                    Else
                        niv = Entidad.Cta + "" + Entidad.SubCta + "00000000"
                    End If

                Else
                    niv = Entidad.Cta + "000000000000"
                End If

            End If

            Return niv
        End Get

    End Property


    'Public Property EneroAbono() As Decimal
    '    Get
    '        Return Entity.Abonos01
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos01 = value
    '    End Set
    'End Property

    'Public Property EneroCargo() As Decimal
    '    Get
    '        Return Entity.Cargos01
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos01 = value
    '    End Set
    'End Property

    'Public ReadOnly Property EneroSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(EneroCargo, EneroAbono)
    '    End Get
    'End Property

    'Public Property FebreroAbono() As Decimal
    '    Get
    '        Return Entity.Abonos02
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos02 = value
    '    End Set
    'End Property

    'Public Property FebreroCargo() As Decimal
    '    Get
    '        Return Entity.Cargos02
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos02 = value
    '    End Set
    'End Property

    'Public ReadOnly Property FebreroSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(FebreroCargo, FebreroAbono)
    '    End Get
    'End Property

    'Public Property MarzoAbono() As Decimal
    '    Get
    '        Return Entity.Abonos03
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos03 = value
    '    End Set
    'End Property

    'Public Property MarzoCargo() As Decimal
    '    Get
    '        Return Entity.Cargos03
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos03 = value
    '    End Set
    'End Property

    'Public ReadOnly Property MarzoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(MarzoCargo, MarzoAbono)
    '    End Get
    'End Property

    'Public Property AbrilAbono() As Decimal
    '    Get
    '        Return Entity.Abonos04
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos04 = value
    '    End Set
    'End Property

    'Public Property AbrilCargo() As Decimal
    '    Get
    '        Return Entity.Cargos04
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos04 = value
    '    End Set
    'End Property

    'Public ReadOnly Property AbrilSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(AbrilCargo, AbrilAbono)
    '    End Get
    'End Property

    'Public Property MayoAbono() As Decimal
    '    Get
    '        Return Entity.Abonos05
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos05 = value
    '    End Set
    'End Property

    'Public Property MayoCargo() As Decimal
    '    Get
    '        Return Entity.Cargos05
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos05 = value
    '    End Set
    'End Property

    'Public ReadOnly Property MayoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(MayoCargo, MayoAbono)
    '    End Get
    'End Property

    'Public Property JunioAbono() As Decimal
    '    Get
    '        Return Entity.Abonos06
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos06 = value
    '    End Set
    'End Property

    'Public Property JunioCargo() As Decimal
    '    Get
    '        Return Entity.Cargos06
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos06 = value
    '    End Set
    'End Property

    'Public ReadOnly Property JunioSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(JunioCargo, JunioAbono)
    '    End Get
    'End Property

    'Public Property JulioAbono() As Decimal
    '    Get
    '        Return Entity.Abonos07
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos07 = value
    '    End Set
    'End Property

    'Public Property JulioCargo() As Decimal
    '    Get
    '        Return Entity.Cargos07
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos07 = value
    '    End Set
    'End Property

    'Public ReadOnly Property JulioSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(JulioCargo, JulioAbono)
    '    End Get
    'End Property

    'Public Property AgostoAbono() As Decimal
    '    Get
    '        Return Entity.Abonos08
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos08 = value
    '    End Set
    'End Property

    'Public Property AgostoCargo() As Decimal
    '    Get
    '        Return Entity.Cargos08
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos08 = value
    '    End Set
    'End Property

    'Public ReadOnly Property AgostoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(AgostoCargo, AgostoAbono)
    '    End Get
    'End Property

    'Public Property SeptiembreAbono() As Decimal
    '    Get
    '        Return Entity.Abonos09
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos09 = value
    '    End Set
    'End Property

    'Public Property SeptiembreCargo() As Decimal
    '    Get
    '        Return Entity.Cargos09
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos09 = value
    '    End Set
    'End Property

    'Public ReadOnly Property SeptiembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(SeptiembreCargo, SeptiembreAbono)
    '    End Get
    'End Property

    'Public Property OctubreAbono() As Decimal
    '    Get
    '        Return Entity.Abonos10
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos10 = value
    '    End Set
    'End Property

    'Public Property OctubreCargo() As Decimal
    '    Get
    '        Return Entity.Cargos10
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos10 = value
    '    End Set
    'End Property

    'Public ReadOnly Property OctubreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(OctubreCargo, OctubreAbono)
    '    End Get
    'End Property

    'Public Property NoviembreAbono() As Decimal
    '    Get
    '        Return Entity.Abonos11
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos11 = value
    '    End Set
    'End Property

    'Public Property NoviembreCargo() As Decimal
    '    Get
    '        Return Entity.Cargos11
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos11 = value
    '    End Set
    'End Property

    'Public ReadOnly Property NoviembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(NoviembreCargo, NoviembreAbono)
    '    End Get
    'End Property

    'Public Property DiciembreAbono() As Decimal
    '    Get
    '        Return Entity.Abonos12
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Abonos12 = value
    '    End Set
    'End Property

    'Public Property DiciembreCargo() As Decimal
    '    Get
    '        Return Entity.Cargos12
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.Cargos12 = value
    '    End Set
    'End Property

    'Public ReadOnly Property DiciembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(DiciembreCargo, DiciembreAbono)
    '    End Get
    'End Property

    'Public ReadOnly Property TotalAbono() As Decimal
    '    Get
    '        Return EneroAbono + FebreroAbono + MarzoAbono + AbrilAbono + MayoAbono + JunioAbono + JulioAbono + AgostoAbono + SeptiembreAbono + OctubreAbono + NoviembreAbono + DiciembreAbono
    '    End Get
    'End Property

    'Public ReadOnly Property TotalCargo() As Decimal
    '    Get
    '        Return EneroCargo + FebreroCargo + MarzoCargo + AbrilCargo + MayoCargo + JunioCargo + JulioCargo + AgostoCargo + SeptiembreCargo + OctubreCargo + NoviembreCargo + DiciembreCargo
    '    End Get
    'End Property

    'Public ReadOnly Property TotalSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(TotalCargo, TotalAbono)
    '    End Get
    'End Property



    Public ReadOnly Property Polizas() As PolizaDetalleCollectionClass
        Get
            If Me.PolizaDetalle Is Nothing Then
                Me.PolizaDetalle = New PolizaDetalleCollectionClass
                Me.PolizaDetalle.RellenarMe(Me.Entity.PolizaDetalle)
            End If
            Return Me.PolizaDetalle
        End Get
    End Property

    Public ReadOnly Property DescripcionNaturaleza() As String
        Get
            Return IIf(Me.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA, "ACREEDORA", "DEUDORA")
        End Get
    End Property

    Public ReadOnly Property NombreYCuenta() As String
        Get
            Return Me.ToString()
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Return Entity.FetchUsingPK(Codigo)
    End Function

    Public Function Obtener(ByVal Cta As String, ByVal SubCta As String, ByVal SsubCta As String, ByVal SssubCta As String)
        ' Dim filtro As New CN
    End Function
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean

    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction, Optional ByVal Referencia As Boolean = False, Optional ByVal CuentaCont As EC.CuentaContableEntity = Nothing) As Boolean
        ' Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cuentas")
        Try
            Dim cuentas As New CuentaContableCollectionClass

            If Not Entity.IsNew Then
                Dim Nivel As Byte = 1

                If Entity.SssubCta.Trim = "0000" Then
                    Nivel = 2
                    If Entity.SsubCta.Trim = "0000" Then
                        Nivel = 3
                        If Entity.SubCta.Trim = "0000" Then
                            Nivel = 4
                        End If
                    End If
                End If

                Dim coleccionCuentaContable As New CC.CuentaContableCollection()
                If Nivel = 2 Then
                    coleccionCuentaContable.GetMulti(HC.CuentaContableFields.Cta = Entity.Cta And HC.CuentaContableFields.SubCta = Entity.SubCta And HC.CuentaContableFields.SsubCta = Entity.SsubCta)
                ElseIf Nivel = 3 Then
                    coleccionCuentaContable.GetMulti(HC.CuentaContableFields.Cta = Entity.Cta And HC.CuentaContableFields.SubCta = Entity.SubCta)
                Else
                    coleccionCuentaContable.GetMulti(HC.CuentaContableFields.Cta = Entity.Cta)
                End If

                For Each item As EC.CuentaContableEntity In coleccionCuentaContable
                    Trans.Add(item)
                    item.Naturaleza = Entity.Naturaleza

                    If item.Cta = Entity.Cta Then
                        If item.Codigo = Entity.Codigo Then
                            item.NomCuenta = Entity.NomCuenta
                            item.SaldoAnoAnt = Entity.SaldoAnoAnt
                            item.SaldoIniEjerc = Entity.SaldoIniEjerc
                            item.CodAgrupSat = Entity.CodAgrupSat
                        End If
                        item.BooDepta = Entity.BooDepta
                        item.BooInactiva = Entity.BooInactiva
                        item.BooPresup = Entity.BooPresup
                        item.BooResultad = Entity.BooResultad
                        item.BooBancos = Entity.BooBancos
                    End If
                    item.Titulo = Entity.Titulo
                    item.SubTitulo = Entity.SubTitulo
                    item.Save()
                Next
                Trans.Commit()
                Return True
            ElseIf cuentas.Validar(Me) Or (Not cuentas.Validar(Me) And Referencia = True) Then
                If Entity.IsNew Then

                    Entity.NumeroHijos = CType(Entity.CuentasHijas.Count, Short)
                    Entity.BooAfectable = True
                    If Entity.NumeroHijos > 0 Then Entity.BooAfectable = False

                    Dim Cuenta As CuentaContableClass
                    If Referencia = True Then
                        Cuenta = cuentas.ObtenerCuentaContable(Me.CuentaMayor, Me.SubCuenta, Me.SSubCuenta, Me.SSSubCuenta)
                        If Not Cuenta Is Nothing Then
                            Entity = Cuenta.ObtenerEntidad
                            Dim NomCuentaEnt As String = ""
                            'Dim NomCuentaSal As String = ""
                            Dim Encuentra As Boolean
                            If Not Cuenta.CuentaEntrada Is Nothing And Not Cuenta.CuentaEntrada.Codigo = 0 Then
                                NomCuentaEnt = Cuenta.CuentaEntrada.NombreCuenta
                                Encuentra = True
                            End If
                            'If Not cuentas(0).CuentaSalida.Codigo = 0 Or Not cuentas(0).CuentaSalida Is Nothing Then
                            '    NomCuentaEnt = cuentas(0).CuentaSalida.NombreCuenta
                            '    Encuentra = True
                            'End If
                            If Encuentra Then
                                If MessageBox.Show("La cuenta contable ya existe y tiene Referencia fiscal, Cuenta: " & NomCuentaEnt & " ¿Desea asginarle esta cuenta fiscal como Referencia? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then '", Cuenta Salida: " & NomCuentaEnt & " ¿Desea asginarle esta cuenta fiscal como referencia? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                                    'If MessageBox.Show("¿Como cuenta de entrada?", "Confirmación", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                                    Entity.CuentaEntrada = CuentaCont
                                    'Else
                                    ' If MessageBox.Show("Se asignará como cuenta de Salida", "Aviso", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                                    'Entity.CuentaSalida = cuentas(0).CuentaSalida.ObtenerEntidad
                                    'End If
                                End If
                            Else
                                If MessageBox.Show("La cuenta contable ya existe y no tiene referencia fiscal, ¿Desea asignar esta cuenta fiscal como referencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                    Entity.CuentaEntrada = CuentaCont
                                End If
                            End If
                        End If
                    Else

                        If Entity.CtaPadre.GetValueOrDefault(0) > 0 Then
                            Entity.CuentaPadre.BooAfectable = False
                            'Entity.CuentaPadre.NumeroHijos = CType(Entity.CuentaPadre.CuentasHijas.Count, Short)
                            Entity.CuentaPadre.NumeroHijos = CType(determinarconsulta(Entity.CuentaPadre.Cta, Entity.CuentaPadre.SubCta, Entity.CuentaPadre.SsubCta, Entity.CuentaPadre.SssubCta), Short)


                            If Not Entity.CuentaEntrada Is Nothing And Not Entity.CuentaEntrada.Codigo = 0 Then 'Entity.CuentaSalida.Codigo = 0 Or Entity.CuentaEntrada Is Nothing Or Entity.CuentaSalida Is Nothing Then
                                If Not Entity.CuentaPadre.CuentaEntrada Is Nothing And Not Entity.CuentaPadre.CuentaEntrada.Codigo = 0 Then
                                    If MessageBox.Show("La cuenta de nivel superior a esta cuenta tiene referencia fiscal, Cuenta: " & Entity.CuentaPadre.CuentaEntrada.NomCuenta & " ¿Desea Heredarla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                        Entity.CuentaEntrada = Entity.CuentaPadre.CuentaEntrada
                                    End If
                                End If

                                'If Not Entity.CuentaPadre.CuentaSalida Is Nothing Or Not Entity.CuentaPadre.CuentaSalida.Codigo = 0 Then
                                '    If MessageBox.Show("La cuenta de nivel superior a esta cuenta tiene referencia fisca, Cuenta de Salida: " & Entity.CuentaPadre.CuentaSalida.NomCuenta & " ¿Desea Heredarla?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                '        Entity.CuentaSalida = Entity.CuentaPadre.CuentaSalida
                                '    End If
                                'End If

                                Entity.CuentaPadre.CuentaEntrada = Nothing
                                '  Entity.CuentaPadre.CuentaSalida = Nothing
                            End If
                        End If

                    End If
                End If

                Trans.Add(Entity)
                If Entity.Save() Then
                    Trans.Add(Entity.CuentaPadre)
                    If Entity.CuentaPadre.Save() Then
                        AplicarCambiosCuentasHijas(Entity, Trans)
                        Trans.Commit()
                        Return True
                    Else
                        Trans.Rollback()
                    End If
                Else
                    Trans.Rollback()
                End If
                Return False

            Else
                Trans.Rollback()
                RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Exclamation))
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub AplicarCambiosCuentasHijas(ByVal Cuenta As EC.CuentaContableEntity, ByRef transaccion As HC.Transaction)
        Try
            For Each hija As EC.CuentaContableEntity In Cuenta.CuentasHijas
                transaccion.Add(hija)
                'hija.BooBancos = Entity.BooBancos
                'hija.BooDepta = Entity.BooDepta
                'hija.BooInactiva = Entity.BooInactiva
                'hija.BooPresup = Entity.BooPresup
                'hija.BooResultad = Entity.BooResultad
                hija.Titulo = Entity.Titulo
                hija.SubTitulo = Entity.SubTitulo
                'hija.Naturaleza = Entity.Naturaleza
                If hija.Cta <> Cuenta.Cta And hija.SubCta <> "0000" Then hija.Cta = Cuenta.Cta
                If hija.SubCta <> Cuenta.SubCta And hija.SsubCta <> "0000" Then hija.SubCta = Cuenta.SubCta
                If hija.SsubCta <> Cuenta.SsubCta And hija.SssubCta <> "0000" Then hija.SsubCta = Cuenta.SsubCta
                hija.Save()
                AplicarCambiosCuentasHijas(hija, transaccion)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function determinarconsulta(cta As String, subcta As String, ssubcta As String, sssubcta As String)
        Dim valor As Integer = 0
        Dim ctapadre As New DataTable

        Dim consulta As String = ""

        If subcta = "0000" Then
            consulta = "select count(*)-1 from usrcontcuentas where cta = '" + cta + "' and SsubCta = '0000' and SSSubCta = '0000'"
        ElseIf ssubcta = "0000" Then
            consulta = "select count(*)-1 from usrcontcuentas where cta = '" + cta + "'  and subcta = '" + subcta + "' and SSSubCta = '0000'"
        ElseIf sssubcta = "0000" Then
            consulta = "select count(*)-1 from usrcontcuentas where cta = '" + cta + "'  and subcta = '" + subcta + "' and SSubCta = '" + ssubcta + "'"
        End If




        Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                    New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            ad.SelectCommand.Connection.Open()
            ad.Fill(ctapadre)
            ad.SelectCommand.Connection.Close()
        End Using

        valor = ctapadre.Rows(0)(0)

        Return valor + 1
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{0}:{1}", Me.NombreCuenta, Me.CuentaContable)
    End Function

    Public Function CalcularSaldo(ByVal cargo As Decimal, ByVal abono As Decimal) As Decimal
        If Me.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
            Return abono - cargo
        Else
            Return cargo - abono
        End If
    End Function

    Public Function CalcularSaldoInicial(ByVal FechaTope As Date, Optional ByVal ConSubCuentas As Boolean = False) As Decimal
        Dim PolizasDetalle As New CC.PolizaDetalleCollection
        Dim Relacion As New SC.RelationCollection()
        Dim Filtro As New SC.PredicateExpression()
        Dim Abonos As Decimal = 0D, Cargos As Decimal = 0D

        If ConSubCuentas Then
            Dim Cuentas As New CC.CuentaContableCollection()
            Dim FiltroCuenta As New SC.PredicateExpression(HC.CuentaContableFields.Cta = Me.CuentaMayor)
            Dim Lista As New List(Of Integer)

            If Me.SubCuenta <> "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SubCta = Me.SubCuenta)
            End If

            If Me.SSubCuenta = "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SsubCta = Me.SSubCuenta)
            End If

            If Me.SSSubCuenta = "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SssubCta = Me.SSSubCuenta)
            End If
            Cuentas.GetMulti(FiltroCuenta)

            If Cuentas.Count > 0 Then
                For Each cuenta As EC.CuentaContableEntity In Cuentas
                    Lista.Add(cuenta.Codigo)
                Next
                Filtro.Add(New SC.FieldCompareRangePredicate(HC.PolizaDetalleFields.CuentaContableId, Lista))
                'Else
                'Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONTABILIDAD, "0")
            End If
        Else
            Filtro.Add(HC.PolizaDetalleFields.CuentaContableId = Me.Codigo)
        End If

        Filtro.Add(HC.PolizaFields.FechaPoliza <= FechaTope)
        'Filtro.Add(HC.PolizaFields.Estatus = 2)
        Filtro.Add(HC.PolizaFields.Estatus = 1)
        Relacion.Add(EC.PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId)
        PolizasDetalle.GetMulti(Filtro, 0, Nothing, Relacion)

        For Each polizadet As EC.PolizaDetalleEntity In PolizasDetalle
            If polizadet.OperacionCa = "C" Then
                Cargos += polizadet.Importe
            Else
                Abonos += polizadet.Importe
            End If
        Next
        Return Me.CalcularSaldo(Cargos, Abonos)
    End Function

    Public Function ObtenerPolizasDetalleEnRangoDeFechas(ByVal FechaInicial As Date, ByVal FechaFinal As Date, Optional ByVal conSubCuentas As Boolean = False) As CC.PolizaDetalleCollection
        Dim PolizasDetalle As New CC.PolizaDetalleCollection
        Dim Relacion As New SC.RelationCollection()
        Dim Filtro As New SC.PredicateExpression()

        If conSubCuentas Then
            Dim Cuentas As New CC.CuentaContableCollection()
            Dim FiltroCuenta As New SC.PredicateExpression(HC.CuentaContableFields.Cta = Me.CuentaMayor)
            Dim Lista As New List(Of Integer)

            If Me.SubCuenta <> "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SubCta = Me.SubCuenta)
            End If

            If Me.SSubCuenta = "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SsubCta = Me.SSubCuenta)
            End If

            If Me.SSSubCuenta = "0000" Then
                FiltroCuenta.Add(HC.CuentaContableFields.SssubCta = Me.SSSubCuenta)
            End If
            Cuentas.GetMulti(FiltroCuenta)

            If Cuentas.Count > 0 Then
                For Each cuenta As EC.CuentaContableEntity In Cuentas
                    Lista.Add(cuenta.Codigo)
                Next
                Filtro.Add(New SC.FieldCompareRangePredicate(HC.PolizaDetalleFields.CuentaContableId, Lista))
                'Else
                'Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONTABILIDAD, "0")
            End If
        Else
            Filtro.Add(HC.PolizaDetalleFields.CuentaContableId = Me.Codigo)
        End If

        Filtro.Add(New SC.FieldBetweenPredicate(HC.PolizaFields.FechaPoliza, FechaInicial, FechaFinal))
        'Filtro.Add(HC.PolizaFields.Estatus = 2) correcta juan manuel 28/03/2018 --- el dos permite obtener solo las aplciadas 
        Filtro.Add(HC.PolizaFields.Estatus = 1)
        Relacion.Add(EC.PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId)
        PolizasDetalle.GetMulti(Filtro, 0, New SC.SortExpression(New SC.SortClause(HC.PolizaFields.FechaPoliza, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relacion)
        Return PolizasDetalle
    End Function
#End Region



End Class

Public Class CuentaContableCollectionClass
    Inherits CollectionGenericClass(Of CuentaContableClass)

    Private col As New CC.CuentaContableCollection

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.CuentaContableCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
    Public Function Validar(ByVal CuentaContable As CuentaContableClass) As Boolean

        Dim tmp As New CC.CuentaContableCollection
        If tmp.GetDbCount(HC.CuentaContableFields.Cta = CuentaContable.CuentaMayor And HC.CuentaContableFields.SubCta = CuentaContable.SubCuenta And _
               HC.CuentaContableFields.SsubCta = CuentaContable.SSubCuenta And HC.CuentaContableFields.SssubCta = CuentaContable.SSSubCuenta) > 0 Then
            Return False
        ElseIf tmp.GetDbCount(HC.CuentaContableFields.NomCuenta = CuentaContable.NombreCuenta And _
                HC.CuentaContableFields.Cta = CuentaContable.CuentaMayor And HC.CuentaContableFields.SubCta = CuentaContable.SubCuenta And _
                HC.CuentaContableFields.SsubCta = CuentaContable.SSubCuenta) > 0 Then
            Return False
        End If

        Return True

        'Dim xA As New SC.PredicateExpression
        'Dim xB As New SC.PredicateExpression

        'xA.Add(HC.CuentaContableFields.Cta = CuentaContable.CuentaMayor)
        'xA.Add(HC.CuentaContableFields.SubCta = CuentaContable.SubCuenta)
        'xA.Add(HC.CuentaContableFields.SsubCta = CuentaContable.SSubCuenta)
        'xA.Add(HC.CuentaContableFields.SssubCta = CuentaContable.SSSubCuenta)
        'xA.AddWithOr(HC.CuentaContableFields.NomCuenta = CuentaContable.NombreCuenta)
        'xB.Add(xA)
        'xB.AddWithAnd(HC.CuentaContableFields.Codigo <> CuentaContable.Codigo)
        'Dim tmp As New CC.CuentaContableCollection
        'tmp.GetMulti(xB)
        'If tmp.Count > 0 Then Return False
        'Return True

    End Function
    Public Function Obtener( _
                            Optional ByVal Inactiva As Object = Nothing, _
                            Optional ByVal Nombre As String = "", _
                            Optional ByVal CuentaMayor As String = "", _
                            Optional ByVal SubCuenta As String = "", _
                            Optional ByVal SSubCuenta As String = "", _
                            Optional ByVal SSSubCuenta As String = "", _
                            Optional ByVal Naturaleza As Object = Nothing, _
                            Optional ByVal Resultado As Object = Nothing, _
                            Optional ByVal Presupesto As Object = Nothing, _
                            Optional ByVal Departamentalizable As Object = Nothing, _
                            Optional ByVal Bancos As Object = Nothing, _
                            Optional ByVal Afectable As Object = Nothing) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentaContableFields.NomCuenta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Dim Orden1 As SC.SortExpression = New SC.SortExpression()
        Orden1.Add(New SC.SortClause(HC.CuentaContableFields.Cta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Orden1.Add(New SC.SortClause(HC.CuentaContableFields.SubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Orden1.Add(New SC.SortClause(HC.CuentaContableFields.SsubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Orden1.Add(New SC.SortClause(HC.CuentaContableFields.SssubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        If Nombre.Replace(" ", "").Length > 0 Then filtro.Add(New SC.FieldLikePredicate(HC.CuentaContableFields.NomCuenta, String.Format("%{0}%", Nombre)))
        If CuentaMayor <> "" Then filtro.Add(HC.CuentaContableFields.Cta = CuentaMayor)
        If SubCuenta <> "" Then filtro.Add(HC.CuentaContableFields.SubCta = SubCuenta)
        If SSubCuenta <> "" Then filtro.Add(HC.CuentaContableFields.SsubCta = SSubCuenta)
        If SSSubCuenta <> "" Then filtro.Add(HC.CuentaContableFields.SssubCta = SSSubCuenta)
        If Not IsNothing(Naturaleza) Then filtro.Add(HC.CuentaContableFields.Naturaleza = Chr(Naturaleza))
        If Not IsNothing(Resultado) Then filtro.Add(HC.CuentaContableFields.BooInactiva = Resultado)
        If Not IsNothing(Presupesto) Then filtro.Add(HC.CuentaContableFields.BooPresup = Presupesto)
        If Not IsNothing(Departamentalizable) Then filtro.Add(HC.CuentaContableFields.BooDepta = Departamentalizable)
        If Not IsNothing(Bancos) Then filtro.Add(HC.CuentaContableFields.BooBancos = Bancos)
        If Not IsNothing(Inactiva) Then
            Select Case Inactiva
                Case CondicionEnum.ACTIVOS
                    filtro.Add(HC.CuentaContableFields.BooInactiva = 0)
                Case CondicionEnum.INACTIVOS
                    filtro.Add(HC.CuentaContableFields.BooInactiva = 1)
                Case CondicionEnum.TODOS
            End Select
        End If
        If Not IsNothing(Afectable) Then filtro.Add(HC.CuentaContableFields.BooAfectable = Afectable)
        col.GetMulti(filtro, -1, Orden1)
        Rellenar()
        Return Me.Count
    End Function

    Public Function ObtenerCuentaContable(Optional ByVal CuentaMayor As String = "0000", Optional ByVal SubCuenta As String = "0000", _
    Optional ByVal SSubCuenta As String = "0000", Optional ByVal SSSubCuenta As String = "0000") As CuentaContableClass
        'Obtener elementos y Llenar Coleccion
        Dim Tmp As New CC.CuentaContableCollection
        Dim res As CuentaContableClass = Nothing
        Dim filtro As New SC.PredicateExpression
        filtro.Add(HC.CuentaContableFields.Cta = CuentaMayor)
        filtro.Add(HC.CuentaContableFields.SubCta = SubCuenta)
        filtro.Add(HC.CuentaContableFields.SsubCta = SSubCuenta)
        filtro.Add(HC.CuentaContableFields.SssubCta = SSSubCuenta)

        Tmp.GetMulti(filtro)
        If Tmp.Count > 0 Then res = New CuentaContableClass(Tmp(0))
        Return res
    End Function

    Public Function Listar() As String()
        Dim lista As New List(Of String)
        For Each e As CuentaContableClass In Me
            lista.Add(e.NombreCuenta)
        Next
        Return lista.ToArray
    End Function
    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.CuentaContableEntity In col
            Dim n As New CuentaContableClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.CuentaContableCollection
        Return col
    End Function

End Class

'//////////////  CUENTAS FISCALES  ///////////////////////////
Public Class CuentaFiscalClass
    'Inherits GenericClass
    Inherits ClassBase(Of EC.CuentasFiscalEntity)

    Public Event Modificado As EventHandler
    Public Event MensajeError As Integra.Clases.MensajeErrorHandler
    'Dim Entity As EC.CuentaContableEntity
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
        Entity = New EC.CuentasFiscalEntity
        Entity.Cta = "0000"
        Entity.SubCta = "0000"
        Entity.SsubCta = "0000"
        Entity.SssubCta = "0000"
        Dim indiceA As Integer = 1
        Dim indiceC As Integer = 1
        Dim indiceP As Integer = 1
        For Each prop As Reflection.PropertyInfo In Entity.GetType.GetProperties
            Select Case prop.Name
                Case "Abonos" & indiceA.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceA += 1
                Case "Cargos" & indiceC.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceC += 1
                Case "Presup" & indiceP.ToString("00")
                    prop.SetValue(Entity, 0D, Reflection.BindingFlags.SetProperty, Nothing, Nothing, Nothing)
                    indiceP += 1
            End Select
        Next
    End Sub
    Sub New(ByVal Codigo As Integer)
        MyBase.New()
        Entity = New EC.CuentasFiscalEntity(Codigo)
    End Sub
    Sub New(ByVal entidad As EC.CuentasFiscalEntity)
        MyBase.New()
        Entity = entidad
    End Sub

    <CM.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    <CM.DisplayName("Cuenta Mayor")> _
    Public Property CuentaMayor() As String
        Get
            Return Entity.Cta
        End Get
        Set(ByVal value As String)
            Entity.Cta = value
        End Set
    End Property
    <CM.DisplayName("Sub Cuenta")> _
    Public Property SubCuenta() As String
        Get
            Return Entity.SubCta
        End Get
        Set(ByVal value As String)
            Entity.SubCta = value
        End Set
    End Property
    <CM.DisplayName("SSub Cuenta")> _
    Public Property SSubCuenta() As String
        Get
            Return Entity.SsubCta
        End Get
        Set(ByVal value As String)
            Entity.SsubCta = value
        End Set
    End Property
    <CM.DisplayName("SSSub Cuenta")> _
    Public Property SSSubCuenta() As String
        Get
            Return Entity.SssubCta
        End Get
        Set(ByVal value As String)
            Entity.SssubCta = value
        End Set
    End Property
    <CM.DisplayName("Nombre de Cuenta")> _
    Public Property NombreCuenta() As String
        Get
            Return Entity.NomCuenta
        End Get
        Set(ByVal value As String)
            Entity.NomCuenta = value
        End Set
    End Property
    Public Property Naturaleza() As CuentaContableNaturalezaEnum
        Get
            Return Asc(Entity.Naturaleza)
        End Get
        Set(ByVal value As CuentaContableNaturalezaEnum)
            Entity.Naturaleza = Chr(value)
        End Set
    End Property
    <CM.DisplayName("N° de Hijos")> _
    Public Property NoHijos() As Short
        Get
            Return Entity.NumeroHijos
        End Get
        Set(ByVal value As Short)
            Entity.NumeroHijos = value
        End Set
    End Property
    <CM.DisplayName("Cuenta Contable")> _
    ReadOnly Property CuentaContable() As String
        Get
            Dim params() As Object = {Entity.Cta, Entity.SubCta, Entity.SsubCta, Entity.SssubCta}
            Return String.Format("{0}-{1}-{2}-{3}", params)
        End Get
    End Property
    <CM.DisplayName("Nombre Largo")> _
    ReadOnly Property NombreLargo() As String
        Get
            Dim params() As Object = {Entity.Cta, Entity.SubCta, Entity.SsubCta, Entity.SssubCta, Entity.NomCuenta}
            Return String.Format("{0}-{1}-{2}-{3} {4}", params)
        End Get
    End Property
    <CM.DisplayName("Cuenta Contable Padre")> _
    Public Property CuentaPadre() As CuentaFiscalClass

        Get
            Dim tmp As CuentaFiscalClass = Nothing
            If Entity.CtaPadre.GetValueOrDefault(0) > 0 Then tmp = New CuentaFiscalClass(Entity.CuentaPadre)
            Return tmp
        End Get
        Set(ByVal value As CuentaFiscalClass)
            If Not IsNothing(value) Then
                Entity.CuentaPadre = value.ObtenerEntidad
            Else
                Dim ni As New System.Nullable(Of Integer)
                Entity.CtaPadre = ni
            End If
        End Set
    End Property
    Public ReadOnly Property CuentasHijas() As CuentaFiscalCollectionClass
        Get
            Dim tmp As CuentaFiscalCollectionClass = Nothing
            If Entity.CuentasHijas.Count > 0 Then tmp = New CuentaFiscalCollectionClass(Entity.CuentasHijas)
            Return tmp
        End Get
    End Property
    Public ReadOnly Property NombreCuentaContable() As String
        Get
            Return Me.ToString
        End Get
    End Property

    '<CM.DisplayName("Cuenta Contable Entrada")> _
    'Public Property CuentaEntrada() As CuentaFiscalClass
    '    Get
    '        Dim tmp As New CuentaFiscalClass
    '        If Entity.CtaEnt.GetValueOrDefault(0) > 0 Then tmp = New CuentaFiscalClass(Entity.CuentaEntrada)
    '        Return tmp
    '    End Get
    '    Set(ByVal value As CuentaFiscalClass)
    '        If Not IsNothing(value) Then
    '            Entity.CuentaEntrada = value.ObtenerEntidad
    '        Else
    '            Dim ni As New System.Nullable(Of Integer)
    '            Entity.CtaEnt = ni
    '        End If
    '    End Set
    'End Property
    '<CM.DisplayName("Cuenta Contable Salida")> _
    'Public Property CuentaSalida() As CuentaFiscalClass
    '    Get
    '        Dim tmp As New CuentaFiscalClass
    '        If Entity.CtaSal.GetValueOrDefault(0) > 0 Then tmp = New CuentaFiscalClass(Entity.CuentaSalida)
    '        Return tmp
    '    End Get
    '    Set(ByVal value As CuentaFiscalClass)
    '        If Not IsNothing(value) Then
    '            Entity.CuentaSalida = value.ObtenerEntidad
    '        Else
    '            Dim ni As New System.Nullable(Of Integer)
    '            Entity.CtaSal = ni
    '        End If
    '    End Set
    'End Property

    Public ReadOnly Property Afectable() As IC.SiNoEnum
        Get
            Return Entity.BooAfectable
        End Get
    End Property
    Public Property Bancos() As IC.SiNoEnum
        Get
            Return Entity.BooBancos
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooBancos = value
        End Set
    End Property
    Public Property Resultado() As IC.SiNoEnum
        Get
            Return Entity.BooResultad
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooResultad = value
        End Set
    End Property
    Public Property Presupuesto() As IC.SiNoEnum
        Get
            Return Entity.BooPresup
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooPresup = value
        End Set
    End Property
    Public Property Inactiva() As IC.SiNoEnum
        Get
            Return Entity.BooInactiva
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooInactiva = value
        End Set
    End Property
    Public Property Departamentalizable() As IC.SiNoEnum
        Get
            Return Entity.BooDepta
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.BooDepta = value
        End Set
    End Property

    <CM.DisplayName("Saldo del Año Anterior")> _
    Public Property SaldoAñoAnterior() As Decimal
        Get
            Return Entity.SaldoAnoAnt
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoAnoAnt = value
        End Set
    End Property
    <CM.DisplayName("Saldo de Inicio del Ejercicio")> _
    Public Property SaldoInicioEjercicio() As Decimal
        Get
            Return Entity.SaldoIniEjerc
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoIniEjerc = value
        End Set
    End Property
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Return Entity.FetchUsingPK(Codigo)
    End Function
    'Public Function ObtenerEntidad() As EC.CuentaContableEntity
    '    Return Entity
    'End Function
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean

    End Function
    'Public Function Borrar() As Boolean
    '    Return Entity.Save
    'End Function
    Public Shadows Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        ' Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cuentas")
        Try
            Dim cuentas As New CuentaFiscalCollectionClass
            If cuentas.Validar(Me) Then

                Entity.NumeroHijos = Entity.CuentasHijas.Count
                Entity.BooAfectable = True
                If Entity.NumeroHijos > 0 Then Entity.BooAfectable = False

                If Entity.CtaPadre.GetValueOrDefault(0) > 0 Then
                    Entity.CuentaPadre.NumeroHijos = Entity.CuentaPadre.CuentasHijas.Count
                    Entity.CuentaPadre.BooAfectable = False
                End If

                Trans.Add(Entity)
                If Entity.Save() Then
                    Trans.Add(Entity.CuentaPadre)
                    If Entity.CuentaPadre.Save() Then
                        AplicarCambiosCuentasHijas(Entity, Trans)
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
                Return False

            Else
                Trans.Rollback()
                RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub AplicarCambiosCuentasHijas(ByVal Cuenta As EC.CuentasFiscalEntity, ByRef transaccion As HC.Transaction)
        For Each hija As EC.CuentasFiscalEntity In Cuenta.CuentasHijas
            transaccion.Add(hija)
            hija.BooBancos = Entity.BooBancos
            hija.BooDepta = Entity.BooDepta
            hija.BooInactiva = Entity.BooInactiva
            hija.BooPresup = Entity.BooPresup
            hija.BooResultad = Entity.BooResultad
            hija.Naturaleza = Entity.Naturaleza
            If hija.Cta <> Cuenta.Cta And hija.SubCta <> "0000" Then hija.Cta = Cuenta.Cta
            If hija.SubCta <> Cuenta.SubCta And hija.SsubCta <> "0000" Then hija.SubCta = Cuenta.SubCta
            If hija.SsubCta <> Cuenta.SsubCta And hija.SssubCta <> "0000" Then hija.SsubCta = Cuenta.SsubCta
            hija.Save()
            AplicarCambiosCuentasHijas(hija, transaccion)
        Next
    End Sub
    Public Overrides Function ToString() As String
        Return String.Format("{0}:{1}", Me.NombreCuenta, Me.CuentaContable)
    End Function

End Class

Public Class CuentaFiscalCollectionClass
    Inherits CollectionGenericClass(Of CuentaFiscalClass)

    Private col As New CC.CuentasFiscalCollection

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.CuentasFiscalCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
    Public Function Validar(ByVal CuentaFiscal As CuentaFiscalClass) As Boolean

        Dim xA As New SC.PredicateExpression
        Dim xB As New SC.PredicateExpression

        xA.Add(HC.CuentasFiscalFields.Cta = CuentaFiscal.CuentaMayor)
        xA.Add(HC.CuentasFiscalFields.SubCta = CuentaFiscal.SubCuenta)
        xA.Add(HC.CuentasFiscalFields.SsubCta = CuentaFiscal.SSubCuenta)
        xA.Add(HC.CuentasFiscalFields.SssubCta = CuentaFiscal.SSSubCuenta)
        xA.AddWithOr(HC.CuentasFiscalFields.NomCuenta = CuentaFiscal.NombreCuenta)
        xB.Add(xA)
        xB.AddWithAnd(HC.CuentasFiscalFields.Codigo <> CuentaFiscal.Codigo)
        Dim tmp As New CC.CuentasFiscalCollection
        tmp.GetMulti(xB)
        If tmp.Count > 0 Then Return False
        Return True

    End Function
    Public Function Obtener( _
                            Optional ByVal Inactiva As Object = Nothing, _
                            Optional ByVal Nombre As String = "", _
                            Optional ByVal CuentaMayor As String = "0000", _
                            Optional ByVal SubCuenta As String = "0000", _
                            Optional ByVal SSubCuenta As String = "0000", _
                            Optional ByVal SSSubCuenta As String = "0000", _
                            Optional ByVal Naturaleza As Object = Nothing, _
                            Optional ByVal Resultado As Object = Nothing, _
                            Optional ByVal Presupesto As Object = Nothing, _
                            Optional ByVal Departamentalizable As Object = Nothing, _
                            Optional ByVal Bancos As Object = Nothing, _
                            Optional ByVal Afectable As Object = Nothing) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentasFiscalFields.BooInactiva, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Nombre.Replace(" ", "").Length > 0 Then filtro.Add(New SC.FieldLikePredicate(HC.CuentasFiscalFields.NomCuenta, String.Format("%{0}%", Nombre)))
        If CuentaMayor <> "0000" Then filtro.Add(HC.CuentasFiscalFields.Cta = CuentaMayor)
        If SubCuenta <> "0000" Then filtro.Add(HC.CuentasFiscalFields.SubCta = SubCuenta)
        If SSubCuenta <> "0000" Then filtro.Add(HC.CuentasFiscalFields.SsubCta = SSubCuenta)
        If SSSubCuenta <> "0000" Then filtro.Add(HC.CuentasFiscalFields.SssubCta = SSSubCuenta)
        If Not IsNothing(Naturaleza) Then filtro.Add(HC.CuentasFiscalFields.Naturaleza = Chr(Naturaleza))
        If Not IsNothing(Resultado) Then filtro.Add(HC.CuentasFiscalFields.BooInactiva = Resultado)
        If Not IsNothing(Presupesto) Then filtro.Add(HC.CuentasFiscalFields.BooPresup = Presupesto)
        If Not IsNothing(Departamentalizable) Then filtro.Add(HC.CuentasFiscalFields.BooDepta = Departamentalizable)
        If Not IsNothing(Bancos) Then filtro.Add(HC.CuentasFiscalFields.BooBancos = Bancos)
        If Not IsNothing(Inactiva) Then
            Select Case Inactiva
                Case CondicionEnum.ACTIVOS
                    filtro.Add(HC.CuentasFiscalFields.BooInactiva = 0)
                Case CondicionEnum.INACTIVOS
                    filtro.Add(HC.CuentasFiscalFields.BooInactiva = 1)
                Case CondicionEnum.TODOS
            End Select
        End If
        If Not IsNothing(Afectable) Then filtro.Add(HC.CuentaContableFields.BooAfectable = Afectable)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function
    Public Function ObtenerCuentaContable(ByVal CuentaMayor As String, ByVal SubCuenta As String, _
     ByVal SSubCuenta As String, ByVal SSSubCuenta As String) As CuentaFiscalClass
        'Obtener elementos y Llenar Coleccion
        Dim Tmp As New CC.CuentasFiscalCollection
        Dim res As CuentaFiscalClass = Nothing
        Dim filtro As New SC.PredicateExpression
        filtro.Add(HC.CuentasFiscalFields.Cta = CuentaMayor)
        filtro.Add(HC.CuentasFiscalFields.SubCta = SubCuenta)
        filtro.Add(HC.CuentasFiscalFields.SsubCta = SSubCuenta)
        filtro.Add(HC.CuentasFiscalFields.SssubCta = SSSubCuenta)
        Tmp.GetMulti(filtro)
        If Tmp.Count > 0 Then res = New CuentaFiscalClass(Tmp(0))
        Return res
    End Function
    Public Function Listar() As String()
        Dim lista As New List(Of String)
        For Each e As CuentaFiscalClass In Me
            lista.Add(e.NombreCuenta)
        Next
        Return lista.ToArray
    End Function
    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.CuentasFiscalEntity In col
            Dim n As New CuentaFiscalClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.CuentasFiscalCollection
        Return col
    End Function

    'Public Function Reporte(ByVal Empresa As String) As ClasesNegocios.RptCuentaContable
    '    Dim Reportes As New RptCuentaContable
    '    Dim DS As New DataSet
    '    Dim DtCC As New DsCuentaContable.DtCuentaContableDataTable
    '    Dim Emp As New DsCuentaContable.DtEmpresaDataTable
    '    For Each cc As CuentaContableClass In Me
    '        DtCC.AddDtCuentaContableRow(cc.CuentaContable, cc.NombreLargo, cc.NombreCuenta, cc.Afectable.ToString, cc.SaldoAñoAnterior.ToString("C2"), cc.SaldoInicioEjercicio.ToString("C2"))
    '    Next
    '    Emp.AddDtEmpresaRow(Empresa)
    '    DS.Tables.Add(Emp)
    '    DS.Tables.Add(DtCC)
    '    Reportes.SetDataSource(DS)
    '    Return Reportes
    'End Function
End Class

'//////////////  POLIZAS  //////////////////
Public Class PolizaClass
    Inherits GenericClass

    Private DetCol As PolizaDetalleCollectionClass
    Dim e As EC.PolizaEntity
    Private _MovientosBancarios As MovimientosBancosColecctionClass
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
        e = New EC.PolizaEntity
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New()
        e = New EC.PolizaEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.PolizaEntity)
        MyBase.New()
        e = entidad
    End Sub

    Public ReadOnly Property Codigo() As Integer
        Get
            Return e.Codigo
        End Get
    End Property

    Public Property Empresa() As EmpresaClass
        Get
            Dim tmp As EmpresaClass = Nothing
            If e.EmpresaId > 0 Then tmp = New EmpresaClass(e.EmpresaId)
            Return tmp
        End Get
        Set(ByVal value As EmpresaClass)
            e.EmpresaId = 0
            If Not IsNothing(value) Then e.EmpresaId = value.Index
        End Set
    End Property

    Public Property EmpresaId() As Integer
        Get
            Return Me.e.EmpresaId
        End Get
        Set(ByVal value As Integer)
            e.EmpresaId = value
        End Set
    End Property

    Public Property TipoPoliza() As PolizaTipoPolizaEnum
        Get
            Return Asc(e.TipoPoliza)
        End Get
        Set(ByVal value As PolizaTipoPolizaEnum)
            e.TipoPoliza = Chr(value)
        End Set
    End Property

    Public Property Mes() As Integer
        Get
            Return e.Mes
        End Get
        Set(ByVal value As Integer)
            e.Mes = value
        End Set
    End Property

    Public ReadOnly Property Año() As Integer
        Get
            Return e.Ano
        End Get
    End Property

    Public Property Folio() As Integer
        Get
            Return e.Folio
        End Get
        Set(ByVal value As Integer)
            e.Folio = value
        End Set
    End Property

    Public ReadOnly Property NumeroPoliza() As String
        Get
            Return e.NumeroPoliza
        End Get
    End Property

    Public Property FechaPoliza() As DateTime
        Get
            Return e.FechaPoliza
        End Get
        Set(ByVal value As DateTime)
            e.FechaPoliza = value
            e.Mes = value.Month
            e.Ano = value.Year
        End Set
    End Property

    Public Property FechaCaptura() As DateTime
        Get
            Return e.FechaCaptura
        End Get
        Set(ByVal value As DateTime)
            e.FechaCaptura = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return e.Importe
        End Get
        Set(ByVal value As Decimal)
            e.Importe = value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return e.Concepto
        End Get
        Set(ByVal value As String)
            e.Concepto = value
        End Set
    End Property

    Public Property Origen() As PolizaOrigenEnum
        Get
            Return Asc(e.Origen)
        End Get
        Set(ByVal value As PolizaOrigenEnum)
            e.Origen = Chr(value)
        End Set
    End Property

    Public ReadOnly Property MovientosBancarios() As MovimientosBancosColecctionClass
        Get
            If _MovientosBancarios Is Nothing Then
                _MovientosBancarios = New MovimientosBancosColecctionClass()
                _MovientosBancarios.Obtener(HC.MvtosBancariosCbFields.NumeroPol = Me.Codigo)
            End If
            Return _MovientosBancarios
        End Get
    End Property

    Public ReadOnly Property AbrOrigen() As String
        Get
            Dim Origen As String = ""

            Select Case Me.Origen
                Case PolizaOrigenEnum.CUENTASxCOBRAR
                    Origen = "CXC"
                Case PolizaOrigenEnum.CUENTASxPAGAR
                    Origen = "CXP"
                Case PolizaOrigenEnum.ALMACEN
                    Origen = "ALM"
                Case PolizaOrigenEnum.BANCOS
                    Origen = "BAN"
                Case PolizaOrigenEnum.COMPRAS
                    Origen = "COM"
                Case PolizaOrigenEnum.CONTABILIDAD
                    Origen = "CON"
                Case PolizaOrigenEnum.VENTAS
                    Origen = "VEN"
            End Select
            Return Origen
        End Get
    End Property

    Public Property TipoError() As ErroresPolizaEnum
        Get
            Return e.TipoError
        End Get
        Set(ByVal value As ErroresPolizaEnum)
            e.TipoError = value
        End Set
    End Property

    Public Property Estatus() As PolizaEstatusEnum
        Get
            Return e.Estatus
        End Get
        Set(ByVal value As PolizaEstatusEnum)
            e.Estatus = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return e.Referencia
        End Get
        Set(ByVal value As String)
            e.Referencia = value
        End Set
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return e.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            e.TipoCambio = value
        End Set
    End Property

    Public ReadOnly Property Detalles() As PolizaDetalleCollectionClass
        Get
            Dim tmp As New PolizaDetalleCollectionClass
            If e.PolizaDetalle.Count > 0 Then tmp = New PolizaDetalleCollectionClass(e.PolizaDetalle)
            Return tmp
        End Get
    End Property

    Public Property Detalles2() As PolizaDetalleCollectionClass
        Get
            If DetCol Is Nothing Then
                If e.IsNew Then
                    DetCol = New PolizaDetalleCollectionClass
                Else
                    DetCol = New PolizaDetalleCollectionClass(e.PolizaDetalle)
                End If
            End If
            Return DetCol
        End Get
        Set(ByVal value As PolizaDetalleCollectionClass)
            DetCol = value
        End Set
    End Property

    Public Function ObtenerEntidad() As EC.PolizaEntity
        Return e
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return e.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Borrar() As Boolean
        e.Estatus = PolizaEstatusEnum.CANCELADA
        Return e.Save
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' Private Function Guardar() As Boolean
    'Dim bl As Boolean = False
    'Dim cheques As New ChequeCollectionClass
    'e.Folio = e.Cuenta.Folioactual + 1
    'Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cheque")
    'Try
    '    If cheques.Validar(Me) Then
    '        tr.Add(e)
    '        bl = e.Save
    '        e.Cuenta.Folioactual += 1
    '        tr.Add(e.Cuenta)
    '        e.Cuenta.Save()
    '        tr.Commit()
    '    Else
    '        RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
    '        tr.Rollback()
    '    End If
    '    Return bl
    'Catch ex As Exception
    '    tr.Rollback()
    '    RaiseEvent Mensajes(Me, New MensajeClass(ex.Message, "Error", Windows.Forms.MessageBoxIcon.Error))
    'End Try
    'End Function

    Public Function Guardar(ByVal tr As HC.Transaction) As Boolean
        Dim bl As Boolean = False
        Try
            tr.Add(e)
            Dim dt As DataTable = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.Generarfoliopoliza(e.EmpresaId, e.TipoPoliza, e.Mes, tr)

            If dt.Rows.Count > 0 Then
                e.Folio = dt.Rows(0)(0) + 1
            Else
                e.Folio = 1
            End If

            e.Save()
            'tr.Add(e.PolizaDetalle)
            e.PolizaDetalle.SaveMulti()
            bl = True
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return bl
    End Function

    Public Function Guardar2(ByVal Trans As HC.Transaction) As Boolean
        'aqui guarda poliza
        Dim Band As Boolean = False
        Try
            Trans.Add(e)
            If e.IsNew Then
                Dim dt As DataTable = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.Generarfoliopoliza(e.EmpresaId, e.TipoPoliza, e.Mes, Trans)
                If dt.Rows.Count > 0 Then
                    e.Folio = dt.Rows(0)(0) + 1
                Else
                    e.Folio = 1
                End If
            End If

            e.Save()
            'O detalles 2
            For Each Entidad As PolizaDetalleClass In Me.Detalles2
                If Not Entidad Is Nothing Then
                    Entidad.Poliza = Me
                    IIf(Entidad.Cargo = 0, PolizaOperacionEnum.ABONO, PolizaOperacionEnum.CARGO)
                End If
            Next
            Trans.Add(e.PolizaDetalle)
            e.PolizaDetalle.SaveMulti()
            Band = True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Band
    End Function

    Public Sub AgregarDetalle(ByVal PolizaDetalle As PolizaDetalleClass)
        PolizaDetalle.Poliza = Me
    End Sub
End Class

Public Class PolizaCollectionClass
    Inherits CollectionGenericClass(Of PolizaClass)

    Private col As New CC.PolizaCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal coleccion As CC.PolizaCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub

    Public Function Validar(ByVal Poliza As PolizaClass) As Boolean
        Dim filtro As New SC.PredicateExpression
        'filtro.Add(HC.ChequeFields.Folio = Cheque.Folio)
        'filtro.AddWithAnd(HC.PolizaDetalleFields.CuentaId = Cheque.Cuenta.Codigo)
        Dim tmp As New CC.PolizaCollection
        tmp.GetMulti(filtro)
        If tmp.Count > 0 Then Return False
        Return True
    End Function

    Public Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        'Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.ChequeFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        'If Estatus <> EstatusEnum.TODOS Then filtro.Add(HC.ChequeFields.Estatus = Estatus)
        col.GetMulti(filtro) ', -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.PolizaEntity In col
            Dim n As New PolizaClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.PolizaCollection
        Return col
    End Function

    Public Shared Function DiariosPolizas(ByVal Polizas As CC.PolizaCollection) As DataTable
        Dim dtPolizas As New dsRptDiariosPolizas.DataTable1DataTable()

        For Each Poliza As EC.PolizaEntity In Polizas
            Dim DetallesPoliza As New CC.PolizaDetalleCollection
            DetallesPoliza.GetMulti(HC.PolizaDetalleFields.PolizaId = Poliza.Codigo, 0, New SC.SortExpression(New SC.SortClause(HC.PolizaDetalleFields.OperacionCa, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            For Each detallePoliza As EC.PolizaDetalleEntity In DetallesPoliza
                With detallePoliza
                    Dim Cargo As Decimal = Nothing
                    Dim Abono As Decimal = Nothing
                    Dim cuentaContable As EC.CuentaContableEntity = .CuentaContable
                    Dim Origen As String

                    If .OperacionCa = "C" Then
                        Cargo = .Importe
                    Else
                        Abono = .Importe
                    End If

                    Dim Ori As PolizaOrigenEnum = CType(Asc(.Poliza.Origen), PolizaOrigenEnum)
                    Select Case Ori
                        Case PolizaOrigenEnum.CUENTASxCOBRAR
                            Origen = "CXC"
                        Case PolizaOrigenEnum.CUENTASxPAGAR
                            Origen = "CXP"
                        Case Else
                            Origen = Ori.ToString.Substring(0, 3).ToUpper()
                    End Select

                    dtPolizas.AddDataTable1Row(cuentaContable.Cta, cuentaContable.SubCta, cuentaContable.SsubCta, cuentaContable.SssubCta, cuentaContable.NomCuenta, Poliza.Concepto, Cargo, Abono, Poliza.NumeroPoliza, Origen, Poliza.FechaPoliza, CType(Asc(Poliza.TipoPoliza), PolizaTipoPolizaEnum).ToString(), CType(Poliza.Estatus, PolizaEstatusEnum).ToString(), .OperacionCa)
                End With
            Next
        Next
        Return dtPolizas
    End Function

    Public Shared Function EmisionPolizas(ByVal Polizas As CC.PolizaCollection) As DataTable
        Dim dtPolizas As New dsRptDiariosPolizas.DataTable1DataTable()

        For Each Poliza As EC.PolizaEntity In Polizas
            Dim DetallesPoliza As New CC.PolizaDetalleCollection
            DetallesPoliza.GetMulti(HC.PolizaDetalleFields.PolizaId = Poliza.Codigo, 0, New SC.SortExpression(New SC.SortClause(HC.PolizaDetalleFields.OperacionCa, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            For Each detallePoliza As EC.PolizaDetalleEntity In DetallesPoliza
                With detallePoliza
                    Dim Cargo As Decimal = Nothing
                    Dim Abono As Decimal = Nothing
                    Dim cuentaContable As EC.CuentaContableEntity = .CuentaContable
                    Dim Origen As String

                    If .OperacionCa = "C" Then
                        Cargo = .Importe
                    Else
                        Abono = .Importe
                    End If
                    Dim Ori As PolizaOrigenEnum = CType(Asc(.Poliza.Origen), PolizaOrigenEnum)

                    Select Case Ori
                        Case PolizaOrigenEnum.CUENTASxCOBRAR
                            Origen = "CXC"
                        Case PolizaOrigenEnum.CUENTASxPAGAR
                            Origen = "CXP"
                        Case Else
                            Origen = Ori.ToString.Substring(0, 3).ToUpper()
                    End Select
                    dtPolizas.AddDataTable1Row(cuentaContable.Cta, cuentaContable.SubCta, cuentaContable.SsubCta, cuentaContable.SssubCta, cuentaContable.NomCuenta, Poliza.Concepto, Cargo, Abono, Poliza.NumeroPoliza, Origen, Poliza.FechaPoliza, CType(Asc(Poliza.TipoPoliza), PolizaTipoPolizaEnum).ToString(), CType(Poliza.Estatus, PolizaEstatusEnum).ToString(), .OperacionCa)
                End With
            Next
        Next
        Dim dt As DataTable = dtPolizas.Clone()
        Dim dataRows() As DataRow = dtPolizas.Select("", "poliza, operacion desc") 'dtPolizas.Select("", "cta, scta, sscta, ssscta")

        Dim totalCargo As Decimal = 0
        Dim totalAbono As Decimal = 0

        For i As Integer = 0 To dataRows.Length - 1
            dt.ImportRow(dataRows(i))
            Dim IndexActual As Integer = dt.Rows.Count - 1
            Dim IndexAnterior As Integer = dt.Rows.Count - 2

            'dt.Rows(IndexActual).Item("cta") = dt.Rows(IndexActual).Item("cta").ToString.Replace("0000", "")
            'dt.Rows(IndexActual).Item("scta") = dt.Rows(IndexActual).Item("scta").ToString.Replace("0000", "")
            'dt.Rows(IndexActual).Item("sscta") = dt.Rows(IndexActual).Item("sscta").ToString.Replace("0000", "")
            'dt.Rows(IndexActual).Item("ssscta") = dt.Rows(IndexActual).Item("ssscta").ToString.Replace("0000", "")

            If IndexAnterior >= 0 Then
                If dt.Rows(IndexActual).Item("poliza") = dt.Rows(IndexAnterior).Item("poliza") Then
                    'totalCargo += dt.Rows(IndexActual).Item("cargo")
                    'totalAbono += dt.Rows(IndexActual).Item("abono")

                    totalCargo = dt.Rows(IndexActual).Item("cargo")
                    totalAbono = dt.Rows(IndexActual).Item("abono")

                    If dt.Rows(IndexActual).Item("cta") = dt.Rows(IndexAnterior).Item("cta") And _
                    dt.Rows(IndexActual).Item("scta") = dt.Rows(IndexAnterior).Item("scta") And _
                    dt.Rows(IndexActual).Item("sscta") = dt.Rows(IndexAnterior).Item("sscta") And _
                    dt.Rows(IndexActual).Item("ssscta") = dt.Rows(IndexAnterior).Item("ssscta") Then
                        'dt.Rows.RemoveAt(IndexActual)
                    Else
                        If dt.Rows(IndexActual).Item("operacion") = "C" Then
                            dt.Rows(IndexActual).Item("cargo") = totalCargo

                            'For index As Integer = IndexAnterior To 0 Step -1
                            '    If dt.Rows(index).Item("poliza") <> dt.Rows(IndexActual).Item("poliza") Then
                            '        Exit For
                            '    Else
                            '        If dt.Rows(index).Item("operacion") = "C" Then
                            '            dt.Rows(index).Item("cargo") = 0
                            '        End If
                            '    End If
                            'Next
                        Else
                            dt.Rows(IndexActual).Item("abono") = totalAbono

                            'For index As Integer = IndexAnterior To 0 Step -1
                            '    If dt.Rows(index).Item("poliza") <> dt.Rows(IndexActual).Item("poliza") Then
                            '        Exit For
                            '    Else
                            '        If dt.Rows(index).Item("operacion") = "A" Then
                            '            dt.Rows(index).Item("abono") = 0
                            '        End If
                            '    End If
                            'Next
                        End If
                    End If
                Else
                    totalCargo = dt.Rows(IndexActual).Item("cargo")
                    totalAbono = dt.Rows(IndexActual).Item("abono")

                    If dt.Rows(IndexActual).Item("operacion") = "C" Then
                        dt.Rows(IndexActual).Item("cargo") = totalCargo
                    Else
                        dt.Rows(IndexActual).Item("abono") = totalAbono
                    End If
                End If
            ElseIf (IndexAnterior = -1) Then
                
                    totalCargo = dt.Rows(IndexActual).Item("cargo")
                    totalAbono = dt.Rows(IndexActual).Item("abono")

                    If dt.Rows(IndexActual).Item("operacion") = "C" Then
                        dt.Rows(IndexActual).Item("cargo") = totalCargo
                    Else
                        dt.Rows(IndexActual).Item("abono") = totalAbono
                    End If
            End If
        Next
        dtPolizas.Clear()
        Return dt
    End Function

    Enum TipoReporte As Byte
        Diarios_de_Polizas
        Emision_de_Polizas
        Emision_de_Polizas_por_Pagina
    End Enum

    Public Shared Function Imprimir(ByVal Sesion As ECS.SesionesEntity, ByVal Tipo As TipoReporte, Optional ByVal Filtro As SC.IPredicate = Nothing) As Boolean
        Dim FechaInicio As DateTime
        Dim FechaFinal As DateTime
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As Object
        Dim dtPolizas As New DataSet()
        Dim Polizas As New CC.PolizaCollection
        Dim conFechas As Boolean

        Dim Ftr As SC.PredicateExpression = CType(Filtro, SC.PredicateExpression)

        If Ftr IsNot Nothing Then
            If Ftr.Count > 0 Then
                For Each Item As SC.PredicateExpressionElement In Ftr
                    If Item.Contents.GetType() Is (New SC.FieldBetweenPredicate().GetType()) Then
                        FechaInicio = CType(Ftr.Item(0).Contents, SC.FieldBetweenPredicate).ValueBegin
                        FechaFinal = CType(Ftr.Item(0).Contents, SC.FieldBetweenPredicate).ValueEnd
                        conFechas = True
                    End If
                Next
            End If
        End If

        Try
            Polizas.GetMulti(Filtro)

            If Polizas.Count < 1 Then
                Throw New Exception("No se encontraron polizas")
            End If

            Dim lsModulo As String
            If Tipo = TipoReporte.Diarios_de_Polizas Then
                dtPolizas.Tables.Add(DiariosPolizas(Polizas))
                Reporte = New RptDiariosPolizas()
                lsModulo = "Contabilidad/Procesos Mensuales/Reporte de Diarios de Póliza"
            ElseIf Tipo = TipoReporte.Emision_de_Polizas Then
                dtPolizas.Tables.Add(EmisionPolizas(Polizas))
                Reporte = New RptEmisionPolizas()
                lsModulo = "Contabilidad/Procesos Mensuales/Reporte de Emision de Polizas"
            Else    'If Tipo = TipoReporte.Emision_de_Polizas_por_Pagina Then
                dtPolizas.Tables.Add(EmisionPolizas(Polizas))
                Reporte = New RptEmisionPolizas_por_pagina()
                lsModulo = "Contabilidad/Procesos Mensuales/Reporte de Emision de Polizas"
            End If

            Reporte.SetDataSource(dtPolizas)
            Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, lsModulo)

            If conFechas Then
                Reporte.SetParameterValue(3, FechaInicio)
                Reporte.SetParameterValue(4, FechaFinal)
            End If
            Previsualizar.Reporte = Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            If ex.Message = "No se encontraron polizas" Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, Sesion.MiEmpresa.Empnom)
            End If
        End Try
    End Function

    Public Shared Function PolizasdeFacturaciondeVentas(ByVal Polizas As CC.PolizaCollection) As DataTable
        Dim dtPolizas As New dsRptDiariosPolizas.DataTable1DataTable()

        For Each Poliza As EC.PolizaEntity In Polizas
            Dim DetallesPoliza As New CC.PolizaDetalleCollection
            DetallesPoliza.GetMulti(HC.PolizaDetalleFields.PolizaId = Poliza.Codigo, 0, New SC.SortExpression(New SC.SortClause(HC.PolizaDetalleFields.OperacionCa, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

            For Each detallePoliza As EC.PolizaDetalleEntity In DetallesPoliza
                With detallePoliza
                    Dim Cargo As Decimal = Nothing
                    Dim Abono As Decimal = Nothing
                    Dim cuentaContable As EC.CuentaContableEntity = .CuentaContable
                    Dim Origen As String

                    If .OperacionCa = "C" Then
                        Cargo = .Importe
                    Else
                        Abono = .Importe
                    End If

                    Dim Ori As PolizaOrigenEnum = CType(Asc(.Poliza.Origen), PolizaOrigenEnum)
                    Select Case Ori
                        Case PolizaOrigenEnum.CUENTASxCOBRAR
                            Origen = "CXC"
                        Case PolizaOrigenEnum.CUENTASxPAGAR
                            Origen = "CXP"
                        Case Else
                            Origen = Ori.ToString.Substring(0, 3).ToUpper()
                    End Select

                    dtPolizas.AddDataTable1Row(cuentaContable.Cta, cuentaContable.SubCta, cuentaContable.SsubCta, cuentaContable.SssubCta, cuentaContable.NomCuenta, Poliza.Concepto, Cargo, Abono, Poliza.NumeroPoliza, Origen, Poliza.FechaPoliza, CType(Asc(Poliza.TipoPoliza), PolizaTipoPolizaEnum).ToString(), CType(Poliza.Estatus, PolizaEstatusEnum).ToString(), .OperacionCa)
                End With
            Next
        Next
        Return dtPolizas
    End Function

    Public Shared Function ImprimirPolizaFacturasdeVentas(ByVal Sesion As ECS.SesionesEntity, ByVal Tipo As TipoFacturaEnum, Optional ByVal Filtro As SC.IPredicate = Nothing) As Boolean
        Dim FechaInicio As DateTime
        Dim FechaFinal As DateTime
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As Object
        Dim dtPolizas As New DataSet()
        Dim Polizas As New CC.PolizaCollection
        Dim Modulo As String
        Dim Encabezado As String

        Dim Ftr As SC.PredicateExpression = CType(Filtro, SC.PredicateExpression)

        If Ftr IsNot Nothing Then
            If Ftr.Count > 0 Then
                For Each Item As SC.PredicateExpressionElement In Ftr
                    If Item.Contents.GetType() Is (New SC.FieldBetweenPredicate().GetType()) Then
                        FechaInicio = CType(Ftr.Item(0).Contents, SC.FieldBetweenPredicate).ValueBegin
                        FechaFinal = CType(Ftr.Item(0).Contents, SC.FieldBetweenPredicate).ValueEnd
                    End If
                Next
            End If
        End If

        Try
            Polizas.GetMulti(Filtro)

            If Polizas.Count < 1 Then
                Throw New Exception("No se encontraron polizas")
            End If

            dtPolizas.Tables.Add(PolizasdeFacturaciondeVentas(Polizas))
            Reporte = New RptPolizasdeFacturaciondeVentas

            If Tipo = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA Then
                Modulo = "Contabilidad/Polizas/Poliza de Facturación de Venta en Reciba"
                Encabezado = "Poliza de Facturación de Venta en Reciba"
            ElseIf Tipo = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_RECIBA Then
                Modulo = "Contabilidad/Polizas/Poliza de Facturación de Muerte en Reciba"
                Encabezado = "Poliza de Facturación de Muerte en Reciba"
            ElseIf Tipo = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_CORRAL Then
                Modulo = "Contabilidad/Polizas/Poliza de Facturación de Venta en Corral"
                Encabezado = "Poliza de Facturación de Venta en Corral"
            Else
                Modulo = "Contabilidad/Polizas/Poliza de Facturación de Muerte en Corral"
                Encabezado = "Poliza de Facturación de Muerte en Corral"
            End If
            Reporte.SetDataSource(dtPolizas)
            Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, FechaInicio)
            Reporte.SetParameterValue(2, FechaInicio)
            Reporte.SetParameterValue(3, Modulo)
            Reporte.SetParameterValue(4, Sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(5, Encabezado)
            Previsualizar.Reporte = Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            If ex.Message = "No se encontraron polizas" Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, Sesion.MiEmpresa.Empnom)
            End If
        End Try
    End Function
End Class

Public Class PolizaDetalleClass
    Inherits GenericClass
    Dim tmp As PolizaClass
    Dim _CuentaContable As CuentaContableClass
    Dim _Cargo As Decimal
    Dim _Abono As Decimal
    Dim e As EC.PolizaDetalleEntity
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        e = New EC.PolizaDetalleEntity
    End Sub

    Sub New(ByVal Poliza As PolizaClass, ByVal Posicion As Integer)
        e = New EC.PolizaDetalleEntity(Poliza.Codigo, Posicion)
    End Sub

    Sub New(ByVal entidad As EC.PolizaDetalleEntity)
        e = entidad
    End Sub

    Public Property Poliza() As PolizaClass
        Get
            If tmp Is Nothing Then
                tmp = New PolizaClass(e.Poliza)
            End If
            Return tmp
        End Get
        Set(ByVal value As PolizaClass)
            tmp = value
            '            e.polizaid = 0
            If Not IsNothing(value) Then e.Poliza = value.ObtenerEntidad
        End Set
    End Property

    Public Property Posicion() As Integer
        Get
            Return e.Posicion
        End Get
        Set(ByVal value As Integer)
            e.Posicion = value
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get

            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            _CuentaContable = value
            If IsNothing(value) Then
                e.CuentaContable = Nothing
            Else
                e.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property IdCuentaContable() As Integer
        Get
            Return e.CuentaContableId
        End Get
        Set(ByVal value As Integer)
            e.CuentaContableId = value
        End Set
    End Property

    Public ReadOnly Property CuentaPadre() As CuentaContableClass
        Get
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass(e.CuentaContable)
            End If
            Return _CuentaContable.CuentaPadre
        End Get
    End Property

    Public Property Cta() As String
        Get
            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable.CuentaMayor
        End Get
        Set(ByVal value As String)
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass
            End If
            _CuentaContable.CuentaMayor = Microsoft.VisualBasic.Right("0000" & CInt(IIf(IsNumeric(value), value, 0)), 4)
            Me.ObtenerCuentas()
        End Set
    End Property

    Public Property SCta() As String
        Get
            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable.SubCuenta
        End Get
        Set(ByVal value As String)
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass
            End If
            _CuentaContable.SubCuenta = Microsoft.VisualBasic.Right("0000" & CInt(IIf(IsNumeric(value), value, 0)), 4)
            ObtenerCuentas()
        End Set
    End Property

    Public Property SSCta() As String
        Get
            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable.SSubCuenta
        End Get
        Set(ByVal value As String)
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass
            End If
            _CuentaContable.SSubCuenta = Microsoft.VisualBasic.Right("0000" & CInt(IIf(IsNumeric(value), value, 0)), 4)
            ObtenerCuentas()
        End Set
    End Property

    Public Property SSSCta() As String
        Get
            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable.SSSubCuenta
        End Get
        Set(ByVal value As String)
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass
            End If
            _CuentaContable.SSSubCuenta = Microsoft.VisualBasic.Right("0000" & CInt(IIf(IsNumeric(value), value, 0)), 4)
            ObtenerCuentas()
        End Set
    End Property

    Public Property NombreCta() As String
        Get
            ' If Not e.Concepto.Replace(" ", "").Length = 0 Then
            '    Return e.Concepto
            '  Else
            If _CuentaContable Is Nothing Then
                If e.IsNew Then
                    _CuentaContable = New CuentaContableClass
                Else
                    _CuentaContable = New CuentaContableClass(e.CuentaContable)
                End If
            End If
            Return _CuentaContable.NombreCuenta
            'End If
        End Get
        Set(ByVal value As String)
            e.Concepto = value
        End Set
    End Property

    Public Property Operacion() As PolizaOperacionEnum
        Get
            Return Asc(e.OperacionCa)
        End Get
        Set(ByVal value As PolizaOperacionEnum)
            e.OperacionCa = Chr(value)
        End Set
    End Property

    Public Property Operacion2() As PolizaOperacionEnum2
        Get
            Return Asc(e.OperacionCa)
        End Get
        Set(ByVal value As PolizaOperacionEnum2)
            e.OperacionCa = value.ToString
        End Set
    End Property

    Public Property Cargo() As Decimal
        Get
            If Me.Operacion2 = PolizaOperacionEnum2.C Then
                Return e.Importe
            Else
                Return 0D
            End If
        End Get
        Set(ByVal value As Decimal)
            If Me.Operacion2 = PolizaOperacionEnum2.C Then
                e.Importe = value
            End If
        End Set
    End Property

    Public Property Abono() As Decimal
        Get
            If Me.Operacion2 = PolizaOperacionEnum2.A Then
                Return e.Importe
            Else
                Return 0D
            End If
        End Get
        Set(ByVal value As Decimal)
            If Me.Operacion2 = PolizaOperacionEnum2.A Then
                e.Importe = value
            End If
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return e.Importe
        End Get
        Set(ByVal value As Decimal)
            e.Importe = value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return e.Concepto
        End Get
        Set(ByVal value As String)
            e.Concepto = value
        End Set
    End Property

    Public ReadOnly Property Fecha() As Date
        Get
            Return Poliza.FechaPoliza
        End Get
    End Property

    Public Function ObtenerEntidad() As EC.PolizaDetalleEntity
        Return e
    End Function

#Region "Metodos"
    Public Function Guardar() As Boolean
        'Dim bl As Boolean = False
        'Dim cheques As New ChequeCollectionClass
        'e.Folio = e.Cuenta.Folioactual + 1
        'Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cheque")
        'Try
        '    If cheques.Validar(Me) Then
        '        tr.Add(e)
        '        bl = e.Save
        '        e.Cuenta.Folioactual += 1
        '        tr.Add(e.Cuenta)
        '        e.Cuenta.Save()
        '        tr.Commit()
        '    Else
        '        RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
        '        tr.Rollback()
        '    End If
        '    Return bl
        'Catch ex As Exception
        '    tr.Rollback()
        '    RaiseEvent Mensajes(Me, New MensajeClass(ex.Message, "Error", Windows.Forms.MessageBoxIcon.Error))
        'End Try
    End Function

    Private Function ObtenerCuentas() As Boolean
        Try
            Dim Coleccion As New CC.CuentaContableCollection
            Coleccion.GetMulti(HC.CuentaContableFields.Cta = Me.Cta And HC.CuentaContableFields.SubCta = Me.SCta And HC.CuentaContableFields.SsubCta = Me.SSCta And _
              HC.CuentaContableFields.SssubCta = Me.SSSCta And HC.CuentaContableFields.BooAfectable = True)

            If Coleccion.Count > 0 Then
                e.CuentaContable = Coleccion(0)
                _CuentaContable.LeerEntidad(e.CuentaContable)
            Else
                Dim TempCta As New CuentaContableClass
                TempCta.CuentaMayor = Me.Cta
                TempCta.SubCuenta = Me.SCta
                TempCta.SSubCuenta = Me.SSCta
                TempCta.SSSubCuenta = Me.SSSCta
                _CuentaContable = TempCta
                e.CuentaContable = Nothing
            End If

            'Me.Poliza.Detalles2.ResetItem(Me.Poliza.Detalles2.IndexOf(Me))
            ' Me.Poliza.Detalles2.Refrescar(Me)

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class

Public Class PolizaDetalleCollectionClass
    Inherits CollectionGenericClass(Of PolizaDetalleClass)

    Private col As New CC.PolizaDetalleCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        col = New CC.PolizaDetalleCollection
    End Sub
    Sub New(ByVal coleccion As CC.PolizaDetalleCollection)
        col = coleccion
        Rellenar()
    End Sub

    Public Sub Refrescar(ByVal Item As PolizaDetalleClass)
        Me.OnListChanged(New System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, Me.IndexOf(Item)))
    End Sub

    Public Function Validar(ByVal Detalle As PolizaDetalleClass) As Boolean
        Dim filtro As New SC.PredicateExpression
        'filtro.Add(HC.ChequeFields.Folio = Cheque.Folio)
        'filtro.AddWithAnd(HC.PolizaDetalleFields.CuentaId = Cheque.Cuenta.Codigo)
        Dim tmp As New CC.PolizaDetalleCollection
        tmp.GetMulti(filtro)
        If tmp.Count > 0 Then Return False
        Return True
    End Function
    Public Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        'Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.ChequeFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        'If Estatus <> EstatusEnum.TODOS Then filtro.Add(HC.ChequeFields.Estatus = Estatus)
        col.GetMulti(filtro) ', -1, Orden)
        Rellenar()
        Return Me.Count
    End Function
    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.PolizaDetalleEntity In col
            Dim n As New PolizaDetalleClass(e)
            Me.Add(n)
        Next
    End Sub
    Public Function ObtenerColeccion() As CC.PolizaDetalleCollection
        Return col
    End Function
    Public Sub RellenarMe(ByVal col As CC.PolizaDetalleCollection)
        Me.col = col
        Rellenar()
    End Sub
End Class


Public Class ConceptoFlujoClass
    Inherits GenericClass

    Dim e As EC.ConceptoFlujoEntity
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
        e = New EC.ConceptoFlujoEntity
        e.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New()
        e = New EC.ConceptoFlujoEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.ConceptoFlujoEntity)
        MyBase.New()
        e = entidad
    End Sub
    Public ReadOnly Property Codigo() As Integer
        Get
            Return e.Codigo
        End Get
    End Property

    Public ReadOnly Property CuentasContables() As CuentaContableCollectionClass
        Get
            Dim tmp As CuentaContableCollectionClass = RellenarCuentasContables()
            Return tmp
        End Get
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return e.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            e.Estatus = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return e.Nombre
        End Get
        Set(ByVal value As String)
            e.Nombre = value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return e.NombreCorto
        End Get
        Set(ByVal value As String)
            e.NombreCorto = value
        End Set
    End Property

    Public Function Borrar() As Boolean
        e.Estatus = EstatusEnum.INACTIVO
        Return e.Save
    End Function

    Public Function Guardar() As Boolean
        Dim bl As Boolean = False
        Dim Conceptos As New ConceptoFlujoCollectionClass
        Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Concepto")
        Try
            If Conceptos.Validar(Me) Then
                tr.Add(e)
                bl = e.Save
                tr.Add(e.Detalles)
                e.Detalles.SaveMulti()
                'e.Detalles.Save()
                tr.Add(cfcc)
                cfcc.DeleteMulti()
                tr.Commit()
            Else
                RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
                tr.Rollback()
            End If
            Return bl
        Catch ex As Exception
            tr.Rollback()
            RaiseEvent Mensajes(Me, New MensajeClass("Error", ex.Message, Windows.Forms.MessageBoxIcon.Error))
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.ConceptoFlujoEntity
        Return e
    End Function

    Private Function RellenarCuentasContables() As CuentaContableCollectionClass
        Dim tmp As New CuentaContableCollectionClass
        For Each cfc As EC.ConceptoFlujoCuentaEntity In e.Detalles
            tmp.Add(New CuentaContableClass(cfc.CuentaContable))
        Next
        Return tmp
    End Function

    Public Function AgregarCuentaContable(ByVal CuentaContable As CuentaContableClass) As Boolean
        For Each cc As CuentaContableClass In RellenarCuentasContables()
            If cc.Codigo = CuentaContable.Codigo Then
                Return False
            End If
        Next
        QuitarDeBasura(CuentaContable)
        Dim cfc As New EC.ConceptoFlujoCuentaEntity
        cfc.CuentaContable = CuentaContable.ObtenerEntidad
        cfc.ConceptoFlujo = e
        Return True
    End Function

    Public Function QuitarCuentaContable(ByVal CuentaContable As CuentaContableClass) As Boolean
        Dim tmp As EC.ConceptoFlujoCuentaEntity = Nothing
        For Each cfc As EC.ConceptoFlujoCuentaEntity In e.Detalles
            If cfc.CuentaContable.Codigo = CuentaContable.Codigo Then
                tmp = cfc
                cfcc.Add(cfc)
            End If
        Next
        If IsNothing(tmp) Then Return False
        e.Detalles.Remove(tmp)
        Return True
    End Function

    Private cfcc As New CC.ConceptoFlujoCuentaCollection

    Private Function QuitarDeBasura(ByVal CuentaContable As CuentaContableClass) As Boolean
        Dim tmp As EC.ConceptoFlujoCuentaEntity = Nothing
        For Each cfc As EC.ConceptoFlujoCuentaEntity In cfcc
            If cfc.CuentaContableId = CuentaContable.Codigo Then
                tmp = cfc
            End If
        Next
        If IsNothing(tmp) Then Return False
        cfcc.Remove(tmp)
        Return True
    End Function
End Class

Public Class ConceptoFlujoCollectionClass
    Inherits CollectionGenericClass(Of ConceptoFlujoClass)

    Private col As New CC.ConceptoFlujoCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal coleccion As CC.ConceptoFlujoCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub

    Public Function Validar(ByVal ConceptoFlujo As ConceptoFlujoClass) As Boolean
        Dim filtro1 As New SC.PredicateExpression
        Dim filtro2 As New SC.PredicateExpression

        filtro1.Add(HC.ConceptoFlujoFields.Nombre = ConceptoFlujo.Descripcion)
        filtro1.AddWithOr(HC.ConceptoFlujoFields.NombreCorto = ConceptoFlujo.Clave)
        filtro2.Add(filtro1)
        filtro2.AddWithAnd(HC.ConceptoFlujoFields.Codigo <> ConceptoFlujo.Codigo)
        Dim tmp As New CC.ConceptoFlujoCollection
        tmp.GetMulti(filtro2)
        If tmp.Count > 0 Then Return False
        Return True
    End Function

    Public Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.ConceptoFlujoFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.ConceptoFlujoFields.Estatus = Estatus)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.ConceptoFlujoEntity In col
            Dim n As New ConceptoFlujoClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.ConceptoFlujoCollection
        Return col
    End Function

    Public Function Reporte(ByVal Empresa As String) As RptFlujos
        Dim Reportes As New RptFlujos
        Dim ds As New DataSet
        Dim dtF As New DSConceptoDeFlujos.DtFlujoDataTable
        Dim Emp As New DSConceptoDeFlujos.DtEmpresaDataTable
        Dim DtCc As New DSConceptoDeFlujos.DtCuentaContableDataTable
        For Each F As ConceptoFlujoClass In Me
            dtF.AddDtFlujoRow(F.Codigo, F.Descripcion, F.Clave, F.Estatus.ToString)
            For i As Integer = 0 To F.CuentasContables.Count - 1
                DtCc.AddDtCuentaContableRow(F.CuentasContables(i).CuentaContable, F.CuentasContables(i).NombreLargo, F.CuentasContables(i).NombreCuenta, F.CuentasContables(i).Afectable, F.CuentasContables(i).SaldoAñoAnterior.ToString("C2"), F.CuentasContables(i).SaldoInicioEjercicio.ToString("C2"))
            Next
        Next
        Emp.AddDtEmpresaRow(Empresa)
        ds.Tables.Add(dtF)
        ds.Tables.Add(Emp)
        ds.Tables.Add(DtCc)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class
