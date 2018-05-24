Imports IC = Integra.Clases
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = INTEGRAlab.orm.CollectionClasses
Imports HC = INTEGRAlab.orm.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel
Imports ClasesNegocio


Public Enum BancosMovimientosMedio
    CHEQUE = Asc("C")
    ELECTRONICO = Asc("E")
    OTROS = Asc("O")
End Enum

Public Enum BancosMovimientosOrigen
    BANCOS = Asc("B")
    PAGOPROVEEDORES = Asc("P")
    CUENTASxCOBRAR = Asc("C")
End Enum

Public Enum BancosMovimientosTipo
    DEPOSITO = Asc("D")
    RETIRO = Asc("R")
    TRASPASO = Asc("T")
    CARGO_DIVERSO = Asc("C")
    ABONO_DIVERSO = Asc("A")
End Enum

'Public Class BancoClass
'    Inherits GenericClass

'    Dim e As EC.BancoEntity

'    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
'    Sub New()
'        MyBase.New()
'        e = New EC.BancoEntity
'        e.Estatus = IC.EstatusEnum.ACTIVO
'    End Sub
'    Sub New(ByVal Codigo As Integer)
'        MyBase.New()
'        e = New EC.BancoEntity(Codigo)
'    End Sub
'    Sub New(ByVal entidad As EC.BancoEntity)
'        MyBase.New()
'        e = entidad
'    End Sub
'    <CM.DisplayName("Código")> _
'    Public ReadOnly Property Codigo() As Integer
'        Get
'            Return e.Codigo
'        End Get
'    End Property
'    <CM.DisplayName("Descripción")> _
'    Public Property Descripcion() As String
'        Get
'            Return e.Descripcion
'        End Get
'        Set(ByVal value As String)
'            e.Descripcion = value
'        End Set
'    End Property
'    <CM.DisplayName("Cláve")> _
'    Public Property Clave() As String
'        Get
'            Return e.Clave
'        End Get
'        Set(ByVal value As String)
'            e.Clave = value
'        End Set
'    End Property


'    Public Property Estatus() As IC.EstatusEnum
'        Get
'            Return e.Estatus
'        End Get
'        Set(ByVal value As IC.EstatusEnum)
'            e.Estatus = value
'        End Set
'    End Property
'    Public Function ObtenerEntidad() As EC.BancoEntity
'        Return e
'    End Function
'    Public Function Borrar() As Boolean
'        e.Estatus = IC.EstatusEnum.INACTIVO
'        Return e.Save
'    End Function
'    Public Function Guardar() As Boolean
'        Dim bl As Boolean = False
'        Dim bancos As New BancoCollectionClass
'        If bancos.Validar(Me) Then
'            bl = e.Save
'        Else
'            RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
'        End If

'        Return bl
'    End Function
'    Public Overrides Function ToString() As String
'        Return Me.Descripcion
'    End Function
'End Class
'Public Class BancoCollectionClass
'    Inherits CollectionGenericClass(Of BancoClass)

'    Private col As New CC.BancoCollection

'    Sub New()
'        MyBase.New()
'    End Sub
'    Sub New(ByVal coleccion As CC.BancoCollection)
'        MyBase.New()
'        col = coleccion
'        Rellenar()
'    End Sub
'    Public Function Validar(ByVal Banco As BancoClass) As Boolean

'        Dim xA As New SC.PredicateExpression
'        Dim xB As New SC.PredicateExpression

'        xA.Add(HC.BancoFields.Clave = Banco.Clave)
'        xA.AddWithOr(HC.BancoFields.Descripcion = Banco.Descripcion)
'        xB.Add(xA)
'        xB.AddWithAnd(HC.BancoFields.Codigo <> Banco.Codigo)

'        Dim tmp As New CC.BancoCollection
'        tmp.GetMulti(xB)
'        If tmp.Count > 0 Then Return False

'        Return True
'    End Function
'    Public Function Obtener(Optional ByVal Estatus As IC.CondicionEnum = CondicionEnum.TODOS) As Integer
'        'Obtener elementos y Llenar Coleccion
'        Dim filtro As New SC.PredicateExpression
'        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.BancoFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
'        If Estatus <> IC.CondicionEnum.TODOS Then filtro.Add(HC.BancoFields.Estatus = Estatus)
'        col.GetMulti(filtro, -1, Orden)
'        Rellenar()
'        Return Me.Count
'    End Function
'    Public Function Listar() As String()
'        Dim lista As New List(Of String)
'        For Each e As BancoClass In Me
'            lista.Add(e.Clave)
'        Next
'        Return lista.ToArray
'    End Function
'    Private Sub Rellenar()
'        Me.Clear()
'        For Each e As EC.BancoEntity In col
'            Dim n As New BancoClass(e)
'            Me.Add(n)
'        Next
'    End Sub

'    Public Function ObtenerColeccion() As CC.BancoCollection
'        Return col
'    End Function

'End Class

Public Class CuentaClass
    Inherits GenericClass

    Dim e As EC.CuentaEntity
    Private m_CuentaContable As CuentaContableClass
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
        e = New EC.CuentaEntity
        e.Estatus = EstatusEnum.ACTIVO
        e.Saldodiaant = 0
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New()
        e = New EC.CuentaEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.CuentaEntity)
        MyBase.New()
        e = entidad
    End Sub

    <CM.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return e.Codigo
        End Get
    End Property

    <CM.DisplayName("Cuenta Bancaria")> _
    Public Property Cuenta() As String
        Get
            Return e.Cuenta
        End Get
        Set(ByVal value As String)
            e.Cuenta = value
        End Set
    End Property
    <CM.DisplayName("Codigo Banco")> _
    Public Property CodBanco() As String
        Get
            Return e.BancoId
        End Get
        Set(ByVal value As String)
            e.BancoId = value
        End Set
    End Property

    <CM.DisplayName("Banco")> _
    Public Property Banco() As BancosClass
        Get
            Dim n As New BancosClass
            n.LeerEntidad(e.Bancos)
            'If e.BancoId > 0 Then n = New BancosClass()
            Return n
        End Get
        Set(ByVal value As BancosClass)
            If Not IsNothing(value) Then e.Bancos = value.ObtenerEntidad
        End Set
    End Property

    <CM.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return e.Descripcion
        End Get
        Set(ByVal value As String)
            e.Descripcion = value
        End Set
    End Property

    Public Property Estatus() As IC.EstatusEnum
        Get
            Return e.Estatus
        End Get
        Set(ByVal value As IC.EstatusEnum)
            e.Estatus = value
        End Set
    End Property

    <CM.DisplayName("Tipo de Moneda")> _
    Public Property TipoMoneda() As TipoMonedaClass
        Get
            Dim n As TipoMonedaClass = Nothing
            If n Is Nothing Then
                n = New TipoMonedaClass(e.TipoMoneda)
            End If
            Return n
        End Get
        Set(ByVal value As TipoMonedaClass)
            If Not IsNothing(value) Then e.TipoMoneda = value.ObtenerEntidad
        End Set
    End Property

    Public Property Empresa() As EmpresaClass
        Get
            Dim n As EmpresaClass = Nothing
            If e.EmpresaId > 0 Then n = New EmpresaClass(e.EmpresaId)
            Return n
        End Get
        Set(ByVal value As EmpresaClass)
            If Not IsNothing(value) Then e.EmpresaId = value.Index
        End Set
    End Property

    <CM.DisplayName("Cuenta Habiente")> _
    Public Property CuentaHabiente() As String
        Get
            Return e.Cuentahabiente
        End Get
        Set(ByVal value As String)
            e.Cuentahabiente = value
        End Set
    End Property

    <CM.DisplayName("Saldo Actual")> _
    Public Property SaldoActual() As Decimal
        Get
            Return e.Saldoactual
        End Get
        Set(ByVal value As Decimal)
            e.Saldoactual = value
        End Set
    End Property

    <CM.DisplayName("Saldo Inicial")> _
    Public Property SaldoInicial() As Decimal
        Get
            Return e.Saldoinicial
        End Get
        Set(ByVal value As Decimal)
            e.Saldoinicial = value
            e.Saldoactual = e.Saldoinicial
            e.Saldoreal = e.Saldoinicial
        End Set
    End Property

    Public Property SaldoDiaAnterior() As Decimal
        Get
            Return e.Saldodiaant
        End Get
        Set(ByVal value As Decimal)
            e.Saldodiaant = value
        End Set
    End Property

    <CM.DisplayName("Folio Actual")> _
    Public Property FolioActual() As Integer
        Get
            Return e.Folioactual
        End Get
        Set(ByVal value As Integer)
            e.Folioactual = value
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If m_CuentaContable Is Nothing Then
                m_CuentaContable = New CuentaContableClass(e.CuentaContable)
            ElseIf Not m_CuentaContable.Codigo = e.CuentacontableId Then
                m_CuentaContable.Entidad = e.CuentaContable
            End If

            Return m_CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            e.CuentacontableId = 0
            If Not IsNothing(value) Then e.CuentaContable = value.ObtenerEntidad
        End Set
    End Property

    Public Function ObtenerEntidad() As EC.CuentaEntity
        Return e
    End Function

    Public Sub LeerEntidad(ByVal entidad As EC.CuentaEntity)
        Me.e = entidad
    End Sub

    Public Function Borrar() As Boolean
        e.Estatus = EstatusEnum.INACTIVO
        Return e.Save
    End Function

    Public Function Guardar() As Boolean
        Dim bl As Boolean = False
        Dim cuentas As New CuentaCollectionClass
        If cuentas.Validar(Me) Then
            bl = e.Save
        Else
            RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
        End If
        Return bl
    End Function

    Public Overrides Function ToString() As String
        Return Me.Cuenta
    End Function
End Class

Public Class CuentaCollectionClass
    Inherits CollectionGenericClass(Of CuentaClass)
    ' Inherits ColleccionBase(Of EC.CuentaEntity, CC.CuentaCollection, CuentaClass)
    Private col As New CC.CuentaCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal coleccion As CC.CuentaCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub

    Public Function Validar(ByVal Cuenta As CuentaClass) As Boolean
        Dim filtro As New SC.PredicateExpression
        If Cuenta.ObtenerEntidad.IsNew = True Then
            filtro.Add(HC.CuentaFields.Cuenta = Cuenta.Cuenta)
        Else
            filtro.Add(HC.CuentaFields.Cuenta = Cuenta.Cuenta)
            filtro.Add(HC.CuentaFields.Codigo <> Cuenta.Codigo)
        End If
        Dim tmp As New CC.CuentaCollection
        tmp.GetMulti(filtro)
        If tmp.Count > 0 Then Return False
        Return True
    End Function

    Public Function Obtener(ByVal Empresa As EmpresaClass, Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentaFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        filtro.Add(HC.CuentaFields.EmpresaId = Empresa.Index)
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.CuentaFields.Estatus = Estatus)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Function Obtener(ByVal NumCta As String, Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentaFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        filtro.Add(HC.CuentaFields.Cuenta = NumCta)
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.CuentaFields.Estatus = Estatus)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Function Obtener(ByVal IdBanco As Integer, ByVal EStatus As EstatusEnum) As Integer
        Try
            Me.Clear()
            Dim filtro As New SC.PredicateExpression
            filtro.Add(HC.CuentaFields.BancoId = IdBanco)
            filtro.Add(HC.CuentaFields.Estatus = EStatus)
            col.GetMulti(filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentaFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.CuentaFields.Estatus = Estatus)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Function Obtener(ByVal condicion As String, ByVal Empresa As Integer) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If condicion = "" Then
                filtro.Add(Integralab.ORM.HelperClasses.CuentaFields.EmpresaId = Empresa)
                Me.col.GetMulti(filtro)
            Else
                filtro.Add(Integralab.ORM.HelperClasses.CuentaFields.Descripcion Mod (String.Format("%{0}%", condicion)))
                filtro.Add(Integralab.ORM.HelperClasses.CuentaFields.EmpresaId = Empresa)
                Me.col.GetMulti(Nothing)
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    ''' <summary>
    '''Obtener cuentas bancarias con respecto a una cuenta contable solo Activas
    ''' </summary>
    ''' <param name="CuentaContableId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal CuentaContableId As Integer) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.CuentaFields.CuentacontableId = CuentaContableId)
            filtro.Add(HC.CuentaFields.Estatus = EstatusEnum.ACTIVO)
            col.GetMulti(filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.CuentaEntity In col
            Dim n As New CuentaClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.CuentaCollection
        Return col
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptCuentaBancaria
        Dim Reportes As New RptCuentaBancaria
        Dim Ds As New DataSet
        Dim DtCu As New DsCuentaBancaria.DtCuentaBancariaDataTable
        Dim Empre As New DsCuentaBancaria.DtEmpresaDataTable
        For Each Cuen As CuentaClass In Me
            DtCu.AddDtCuentaBancariaRow(Cuen.Banco.Descripcion, Cuen.TipoMoneda.Descripcion, Cuen.CuentaHabiente, Cuen.Cuenta, Cuen.SaldoInicial.ToString("C2"), Cuen.Descripcion, Cuen.CuentaContable.CuentaContable, Cuen.Estatus.ToString)
        Next
        'Empre.AddDtEmpresaRow(Empresa)
        Ds.Tables.Add(Empre)
        Ds.Tables.Add(DtCu)
        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(0, Usuario)
        Reportes.SetParameterValue(1, "Catálogos/Bancos/Cuentas Bancarias")
        Reportes.SetParameterValue(2, Empresa)
        Return Reportes
    End Function
End Class

Public Class ChequeClass
    Inherits ClassBase(Of EC.ChequeEntity)

#Region "Miembros"
    Dim _Poliza As PolizaClass
    Dim _Cuenta As CuentaClass
    Dim _Beneficiario As BeneficiarioClass = Nothing
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
    Public Modificado As Boolean
    Public Conciliado As Boolean
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
        Entity = New EC.ChequeEntity
        Entity.FechaMovimiento = Now
        Entity.Estatus = EstatusEnum.ACTIVO
        Entity.Medio = Chr(BancosMovimientosMedio.CHEQUE)
        Entity.Emitido = False
    End Sub

    Sub New(ByVal Folio As Integer, ByVal Cuenta As CuentaClass, ByVal Medio As BancosMovimientosMedio)
        MyBase.New()
        Entity = New EC.ChequeEntity(Folio, Cuenta.Codigo, Chr(Medio), CodBanco)
    End Sub

    Sub New(ByVal entidad As EC.ChequeEntity)
        MyBase.New()
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    <CM.DisplayName("Folio")> _
    Public Property Folio() As String
        Get
            Return Entity.Folio
        End Get
        Set(ByVal value As String)
            Entity.Folio = value
        End Set
    End Property

    Public Property CodBanco() As Integer
        Get
            Return Entity.CodBanco
        End Get
        Set(ByVal value As Integer)
            Entity.CodBanco = value
        End Set
    End Property

    Public Property CodBancoDestino() As Integer
        Get
            Return Entity.CodBancoDestino
        End Get
        Set(ByVal value As Integer)
            Entity.CodBancoDestino = value
        End Set
    End Property

    Public Property CuentaDestinoReceptor() As String
        Get
            Return Entity.CuentaDestinoReceptor
        End Get
        Set(ByVal value As String)
            Entity.CuentaDestinoReceptor = value
        End Set
    End Property

    Public Property IdPoliza() As Integer
        Get
            Return Entity.PolizaId
        End Get
        Set(ByVal value As Integer)
            Entity.PolizaId = value
        End Set
    End Property

    Public ReadOnly Property Banco() As BancosClass
        Get
            Return Cuenta.Banco
        End Get
    End Property

    Public Property Medio() As BancosMovimientosMedio
        Get
            Return Asc(Entity.Medio)
        End Get
        Set(ByVal value As BancosMovimientosMedio)
            Entity.Medio = Chr(value)
        End Set
    End Property

    <CM.DisplayName("Cuenta Bancaria")> _
    Public Property Cuenta() As CuentaClass
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaClass(Entity.Cuenta)
            ElseIf Not _Cuenta.Codigo = Entity.CuentaId Then
                _Cuenta.LeerEntidad(Entity.Cuenta)
            End If

            Return _Cuenta
        End Get
        Set(ByVal value As CuentaClass)
            _Cuenta = value
            If value Is Nothing Then
                Entity.Cuenta = Nothing
            Else
                Entity.Cuenta = value.ObtenerEntidad
            End If
        End Set
    End Property

    <CM.DisplayName("IdBeneficiario")> _
    Public Property IdBeneficiario() As String
        Get
            Return Entity.BeneficiarioId
        End Get
        Set(ByVal value As String)
            Entity.BeneficiarioId = value
        End Set
    End Property

    <CM.DisplayName("Beneficiario")> _
    Public Property Beneficiario() As BeneficiarioClass
        Get
            Dim tmp As BeneficiarioClass = Nothing
            If tmp Is Nothing Then
                tmp = New BeneficiarioClass(Entity.Beneficiario)
            End If
            ' If e.BeneficiarioId.GetValueOrDefault(0) > 0 Then tmp = New BeneficiarioClass(e.Beneficiario)
            Return tmp
        End Get
        Set(ByVal value As BeneficiarioClass)
            Dim nulo As Nullable(Of Integer)
            Entity.BeneficiarioId = nulo
            If Not IsNothing(value) Then Entity.Beneficiario = value.ObtenerEntidad
        End Set
    End Property

    Public Property CveConciliacion() As Boolean
        Get
            If Modificado = True Then
                Return Conciliado
            End If
            For Each MovBan As MovimientosBancosClass In Me.Poliza.MovientosBancarios
                If MovBan.CveConciliacion = "S" Then
                    Return True
                End If
                Return False
            Next
            'Dim ClaveConciliacion As New MovimientosBancosClass(Entity.PolizaId, Entity.CuentaId)
            'If ClaveConciliacion.Entidad.CveConcil = "S" Then
            '    Return True
            'Else
            '    Return False
            'End If
        End Get
        Set(ByVal value As Boolean)
            Modificado = True
            Conciliado = value
            'Dim Conciliar As New MovimientosBancosClass(Entity.PolizaId, Entity.CuentaId)
            'If value = True Then
            '    Conciliar.Entidad.CveConcil = "S"
            'Else
            '    Conciliar.Entidad.CveConcil = "N"
            'End If
        End Set
    End Property

    Public Property Emitido() As Boolean
        Get
            Return Entity.Emitido
        End Get
        Set(ByVal value As Boolean)
            Entity.Emitido = value
        End Set
    End Property

    Public Property Estatus() As IC.EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As IC.EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    <CM.DisplayName("Fecha de Cancelaciòn")> _
    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion.GetValueOrDefault(Nothing)
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    <CM.DisplayName("Fecha de Movimiento")> _
    Public Property FechaMovimiento() As Date
        Get
            Return Entity.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaMovimiento = value
        End Set
    End Property

    <CM.DisplayName("Fecha de Documento")> _
    Public Property FechaDocumento() As Date
        Get
            Return Entity.FechaDocumento
        End Get
        Set(ByVal value As Date)
            Entity.FechaDocumento = value
        End Set
    End Property

    <CM.DisplayName("Fecha de Emisión")> _
    Public Property FechaEmision() As Date
        Get
            Return Entity.FechaEmision.GetValueOrDefault(Nothing)
        End Get
        Set(ByVal value As Date)
            Entity.FechaEmision = value
        End Set
    End Property

    <CM.DisplayName("Referencia")> _
    Public Property Referencia() As String
        Get
            Return Entity.Referencia
        End Get
        Set(ByVal value As String)
            Entity.Referencia = value
        End Set
    End Property

    <CM.DisplayName("Anticipo")> _
    Public Property Anticipo() As Boolean
        Get
            Return Entity.Anticipo
        End Get
        Set(ByVal value As Boolean)
            Entity.Anticipo = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            If Not IsNothing(Cuenta) Then
                Entity.Importe = value
            Else
                'RaiseEvent Mensajes(Me, New MensajeClass("Datos incompletos", "Falta la cuenta bancaria para determinar el tipo de moneda", Windows.Forms.MessageBoxIcon.Error))
            End If
        End Set
    End Property

    <CM.DisplayName("Importe con Letra")> _
    Public ReadOnly Property ImporteLetra() As String
        Get
            Dim toNumber As New Integra.Clases.cNum2Text
            If Not IsNothing(Me.Cuenta) Then
                Dim moneda As String = Me.Cuenta.TipoMoneda.Descripcion
                Dim Abrev As String = Me.Cuenta.TipoMoneda.DescripcionCorta
                Dim plural As String
                Select Case Mid(moneda, moneda.Length).ToUpper
                    Case "A", "E", "I", "O", "U"
                        plural = "S"
                    Case Else
                        plural = "ES"
                End Select
                Return toNumber.Numero2Letra(Entity.Importe.ToString, 2, moneda, plural, Abrev)
            Else
                Return toNumber.Numero2Letra(String.Format("0"), 2)
            End If
        End Get
    End Property

    Public Property Concepto() As String
        Get
            Return Entity.Concepto
        End Get
        Set(ByVal value As String)
            Entity.Concepto = value
        End Set
    End Property

    Public Property Poliza() As PolizaClass
        Get
            If _Poliza Is Nothing Then
                _Poliza = New PolizaClass(Entity.Poliza)
            End If
            ' tmp = New PolizaClass(e.Poliza)
            Return _Poliza
        End Get
        Set(ByVal value As PolizaClass)
            _Poliza = value
            If Not IsNothing(value) Then
                Entity.Poliza = value.ObtenerEntidad
            Else
                Entity.Poliza = Nothing
            End If
        End Set
    End Property

    Public Property PolizaCancelacion() As PolizaClass
        Get
            Dim tmp As PolizaClass
            If Entity.PolizaIdCancelacion.GetValueOrDefault(0) > 0 Or Entity.IsNew Then tmp = New PolizaClass(Entity.Poliza_)
            tmp = New PolizaClass(Entity.Poliza_)
            Return tmp
        End Get
        Set(ByVal value As PolizaClass)
            If Not IsNothing(value) Then
                Entity.Poliza_ = value.ObtenerEntidad
            Else
                Entity.PolizaIdCancelacion = 0
            End If
        End Set
    End Property

    Public Property Entregado() As Boolean
        Get
            Return Entity.Entregado
        End Get
        Set(ByVal value As Boolean)
            Entity.Entregado = value
        End Set
    End Property

    Public Property FechaEntrega() As Date
        Get
            Return Entity.FechaEntrega
        End Get
        Set(ByVal value As Date)
            Entity.FechaEntrega = value
        End Set
    End Property

    <CM.DisplayName("Cuenta Bancaria Destino")> _
    Public Property CuentaDestino() As CuentaClass
        Get
            Dim tmp As CuentaClass = Nothing
            If Entity.CuentaDestinoId.GetValueOrDefault(0) > 0 Then tmp = New CuentaClass(Entity.CuentaDestino)
            Return tmp
        End Get
        Set(ByVal value As CuentaClass)
            Entity.CuentaDestinoId = 0
            If Not IsNothing(value) Then Entity.CuentaDestino = value.ObtenerEntidad
        End Set
    End Property

    Public Property Origen() As BancosMovimientosOrigen
        Get
            Return Asc(Entity.Origen)
        End Get
        Set(ByVal value As BancosMovimientosOrigen)
            Entity.Origen = Chr(value)
        End Set
    End Property

    Public Property TipoMovimiento() As BancosMovimientosTipo
        Get
            Return Asc(Entity.TipoMovimiento)
        End Get
        Set(ByVal value As BancosMovimientosTipo)
            Entity.TipoMovimiento = Chr(value)
        End Set
    End Property

    Public Property Resguardo() As IC.SiNoEnum
        Get
            Return Entity.Resguardo
        End Get
        Set(ByVal value As IC.SiNoEnum)
            Entity.Resguardo = value
        End Set
    End Property

    Property TipoCambio() As Decimal
        Get
            Return Entity.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entity.TipoCambio = value
        End Set
    End Property

    Property Periodo() As Object
        Get
            Return Entity.PeriodoId
        End Get
        Set(ByVal value As Object)
            Entity.PeriodoId = value
        End Set
    End Property

#End Region

#Region "Metodos"
    'Public Function ObtenerEntidad() As EC.ChequeEntity
    '    Return Entity
    'End Function

    Public Overloads Function Borrar() As Boolean
        Entity.FechaCancelacion = Now
        Entity.Estatus = EstatusEnum.INACTIVO
        Return Entity.Save
    End Function

    Public Overloads Function Borrar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Dim bl As Boolean = False
        Try
            'cancelar el cheque que se ha generado
            Entity.FechaCancelacion = Now
            Entity.Estatus = EstatusEnum.INACTIVO
            Trans.Add(Entity)
            Entity.Save()
            'hacer la poliza de cancelacion
            If Me.PolizaCancelacion.Guardar(Trans) Then
                Entity.PolizaIdCancelacion = Me.PolizaCancelacion.Codigo
                Trans.Add(Entity)
                Entity.Save()
                Trans.Commit()
                bl = True
            Else
                Trans.Rollback()
                bl = False
            End If
            'hacer la cancelación en movimientos bancarios
            Return bl
        Catch ex As Exception
            Trans.Rollback()
            RaiseEvent Mensajes(Me, New MensajeClass("Error", ex.Message, Windows.Forms.MessageBoxIcon.Error))
        End Try
    End Function

    Public Overloads Function Guardar(ByVal tr As HC.Transaction) As Boolean
        Dim bl As Boolean = False
        Dim cheques As New ChequeCollectionClass
        If Me.TipoMovimiento = BancosMovimientosTipo.RETIRO Then
            If Me.Medio = BancosMovimientosMedio.CHEQUE And Entity.IsNew() Then
                Entity.Cuenta.Refetch()
                Entity.Folio = Entity.Cuenta.Folioactual + 1
                Entity.Cuenta.Folioactual += 1
            Else
                Entity.FechaEmision = Now
                Entity.Emitido = True
            End If
        ElseIf Me.TipoMovimiento = BancosMovimientosTipo.DEPOSITO Then
            Entity.FechaEmision = Now
            Entity.Emitido = True
        End If
        'Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cheque")
        Try
            If cheques.Validar(Me) Then
                'tr.Add(Entity)
                'Entity.Save()
                tr.Add(Entity.Cuenta)
                Entity.Cuenta.Save()
                Me.Poliza.Referencia = Me.Folio
                If Me.Poliza.Guardar(tr) Then
                    Entity.PolizaId = Me.Poliza.Codigo
                    tr.Add(Entity)
                    Entity.Save()
                    bl = True
                Else
                    tr.Rollback()
                    bl = False
                End If
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

    Public Overloads Function Guardar(Optional ByVal aplicaContabilidad As Boolean = True) As Boolean
        Dim bl As Boolean = False
        Dim cheques As New ChequeCollectionClass
        If Me.TipoMovimiento = BancosMovimientosTipo.RETIRO Then
            If aplicaContabilidad Then
                If Me.Medio = BancosMovimientosMedio.CHEQUE Then
                    Entity.Cuenta.Refetch()
                    Entity.Folio = Entity.Cuenta.Folioactual + 1
                    Entity.Cuenta.Folioactual += 1
                Else
                    Entity.Folio = Entity.Cuenta.Folioactual + 1
                    Entity.FechaEmision = Now
                    Entity.Emitido = True
                End If
            End If
        ElseIf Me.TipoMovimiento = BancosMovimientosTipo.DEPOSITO Then
            Entity.FechaEmision = Now
            Entity.Emitido = True
        End If
        Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cheque")
        Try
            If cheques.Validar(Me) Then
                tr.Add(Entity)

                ''Causaba un error en Transpasos bancarios porque lo contaba como nulo. wth
                If Entity.PolizaId = 0 Then
                    Entity.PolizaId = 0
                End If

                Entity.Save()
                tr.Add(Entity.Cuenta)
                Entity.Cuenta.Save()

                If aplicaContabilidad Then
                    Me.Poliza.Referencia = Me.Folio
                    If Me.Poliza.Guardar(tr) Then
                        Entity.PolizaId = Me.Poliza.Codigo
                        tr.Add(Entity)
                        Entity.Save()
                        tr.Commit()
                        bl = True
                    Else
                        tr.Rollback()
                        bl = False
                    End If
                Else
                    Entity.Save()
                    tr.Commit()
                    bl = True
                End If
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

    Friend Sub Imprimir()
        Entity.FechaEmision = Now
        Entity.Emitido = True
    End Sub
#End Region

End Class

Public Class ChequeCollectionClass
    Inherits ColleccionBase(Of EC.ChequeEntity, CC.ChequeCollection, ChequeClass)

#Region "Miembros"
    Private col As New CC.ChequeCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal coleccion As CC.ChequeCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
#End Region

#Region "Metodos"
    Public Function Validar(ByVal Cheque As ChequeClass) As Boolean
        Dim filtro As New SC.PredicateExpression
        filtro.Add(HC.ChequeFields.Folio = Cheque.Folio)
        filtro.AddWithAnd(HC.ChequeFields.Medio = Chr(Cheque.Medio))
        filtro.AddWithAnd(HC.ChequeFields.CuentaId = Cheque.Cuenta.Codigo)
        Dim tmp As New CC.ChequeCollection
        tmp.GetMulti(filtro)
        If tmp.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Overloads Function Obtener( _
            ByVal Beneficiario As BeneficiarioClass, _
   Optional ByVal Folio As String = "", _
   Optional ByVal Anticipo As Windows.Forms.CheckState = Windows.Forms.CheckState.Indeterminate, _
   Optional ByVal Electronico As Windows.Forms.CheckState = Windows.Forms.CheckState.Indeterminate, _
   Optional ByVal TipoMovimiento As Object = Nothing, _
   Optional ByVal Activo As Windows.Forms.CheckState = Windows.Forms.CheckState.Indeterminate, _
   Optional ByVal Inactivo As Windows.Forms.CheckState = Windows.Forms.CheckState.Indeterminate, _
   Optional ByVal Cheque As Windows.Forms.CheckState = Windows.Forms.CheckState.Indeterminate _
   ) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        'Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.CuentaContableFields.BooInactiva, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Not IsNothing(Beneficiario) Then
            filtro.Add(HC.ChequeFields.BeneficiarioId = Beneficiario.Codigo)
        End If
        If Folio.Replace(" ", "").Length > 0 Then
            filtro.Add(HC.ChequeFields.Folio = Folio)
        End If
        Select Case Anticipo
            Case Windows.Forms.CheckState.Checked
                filtro.Add(HC.ChequeFields.Anticipo = True)
            Case Windows.Forms.CheckState.Unchecked
                filtro.Add(HC.ChequeFields.Anticipo = False)
        End Select
        If Not IsNothing(TipoMovimiento) Then
            filtro.Add(HC.ChequeFields.TipoMovimiento = Chr(TipoMovimiento))
        End If

        If Electronico = Windows.Forms.CheckState.Checked And Cheque = Windows.Forms.CheckState.Checked Then
            '' No se añade un filtro para que agrege los Electronicos y los Cheque
        Else
            If Electronico = Windows.Forms.CheckState.Checked Then
                filtro.Add(HC.ChequeFields.Medio = Chr(BancosMovimientosMedio.ELECTRONICO))
            Else
                filtro.Add(HC.ChequeFields.Medio = Chr(BancosMovimientosMedio.CHEQUE))
            End If
        End If

        If Activo = Windows.Forms.CheckState.Checked And Inactivo = Windows.Forms.CheckState.Checked Then
            '' No se añade un filtro para que agrege los activos y los Inactivos
        Else
            If Activo = Windows.Forms.CheckState.Checked Then
                filtro.Add(HC.ChequeFields.Estatus = EstatusEnum.ACTIVO)
            Else
                filtro.Add(HC.ChequeFields.Estatus = EstatusEnum.INACTIVO)
            End If
        End If

        col.GetMulti(filtro) ', -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Overloads Function Obtener(ByVal Medio As BancosMovimientosMedio) As Integer
        Me.Clear()
        Dim filtro As New SC.PredicateExpression
        filtro.Add(HC.ChequeFields.Medio = Medio)
        filtro.Add(HC.ChequeFields.Estatus = 1)
        col.GetMulti(filtro)
        Rellenar()
        Return Count
    End Function

    ''' <summary>
    ''' Obtiene los cheques filtrado por cuenta, si el valor del parametro es 0 traerá solo
    ''' los cheques que no estén entregados y vigentes.
    ''' </summary>
    ''' <param name="CuentaID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal CuentaID As Integer) As Integer
        Try
            Me.Clear()
            Dim filtro As New SC.PredicateExpression
            If CuentaID <> 0 Then
                filtro.Add(HC.ChequeFields.CuentaId = CuentaID)
            End If
            filtro.Add(HC.ChequeFields.Entregado = False)
            filtro.Add(HC.ChequeFields.Estatus = 1)
            col.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.ChequeFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.ChequeFields.Estatus = Estatus)
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Overloads Function Obtener(ByVal TipoMovimiento As BancosMovimientosTipo, Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.ChequeFields.Estatus, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.ChequeFields.Estatus = Estatus)
        filtro.Add(HC.ChequeFields.TipoMovimiento = Chr(TipoMovimiento))
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Overloads Function Obtener(ByVal idCuentaBancaria As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As Integer
        Dim Filtro As New SC.PredicateExpression
        Filtro.Add(HC.ChequeFields.CuentaId = idCuentaBancaria And HC.ChequeFields.FechaMovimiento > FechaInicial And HC.ChequeFields.FechaMovimiento < FechaFinal)
        col.GetMulti(Filtro)
        Rellenar()
        Return Count
    End Function

    Public Overloads Function Obtener(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As Integer
        Dim Filtro As New SC.PredicateExpression
        Filtro.Add(HC.ChequeFields.FechaMovimiento > FechaInicial And HC.ChequeFields.FechaMovimiento < FechaFinal)
        col.GetMulti(Filtro)
        Rellenar()
        Return Count
    End Function

    Public Overloads Function Obtener(ByVal FolioCheque As String, ByVal Poliza As String, ByVal Importe As Decimal) As Integer
        Try
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            Dim filtro As New SC.PredicateExpression
            rel.Add(EC.ChequeEntity.Relations.PolizaEntityUsingPolizaId, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            filtro.Add(HC.ChequeFields.Folio = FolioCheque)
            If Poliza <> "" Then
                filtro.Add(HC.PolizaFields.NumeroPoliza = Poliza)
            End If
            filtro.Add(HC.ChequeFields.Importe = Importe)
            col.GetMulti(filtro, rel)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.ChequeEntity In col
            Dim n As New ChequeClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.ChequeCollection
        Return col
    End Function
#End Region
End Class

Public Class BeneficiarioClass
    Inherits GenericClass

#Region "Miembros"
    Dim e As EC.BeneficiarioEntity
    Dim tmp As ProveedorClass
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
        e = New EC.BeneficiarioEntity
        e.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New()
        e = New EC.BeneficiarioEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.BeneficiarioEntity)
        MyBase.New()
        e = entidad
    End Sub
#End Region

#Region "Propiedades"
    <CM.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return e.Codigo
        End Get
    End Property

    <CM.DisplayName("Proveedor")> _
    Public Property Proveedor() As ProveedorClass
        Get
            If tmp Is Nothing Then
                tmp = New ProveedorClass(e.Proveedor)
            End If
            'If e.CodigoProveedor.GetValueOrDefault(0) > 0 Then
            '    tmp = New ProveedorClass(e.Proveedor)
            'End If
            Return tmp
        End Get
        Set(ByVal value As ProveedorClass)
            tmp = value
            If value Is Nothing Then
                e.Proveedor = Nothing
            Else
                e.Proveedor = value.ObtenerEntidad(0)
            End If
        End Set
    End Property

    <CM.DisplayName("Es Proveedor")> _
    Public ReadOnly Property EsProveedor() As Integer
        Get
            Return e.EsProveedor
        End Get
    End Property

    <CM.DisplayName("ID Proveedor")> _
    Public ReadOnly Property IdProveedor() As Integer
        Get
            Return e.CodigoProveedor
        End Get
    End Property

    <CM.DisplayName("Beneficiario")> _
    Public Property Beneficiario() As String
        Get
            Return e.Beneficiario
        End Get
        Set(ByVal value As String)
            e.Beneficiario = value
        End Set
    End Property

    Public Property Estatus() As IC.EstatusEnum
        Get
            Return e.Estatus
        End Get
        Set(ByVal value As IC.EstatusEnum)
            e.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function ObtenerEntidad() As EC.BeneficiarioEntity
        Return e
    End Function

    Public Function Borrar() As Boolean
        e.Estatus = EstatusEnum.INACTIVO
        Return e.Save
    End Function

    Public Function Guardar(ByRef Editar As Boolean) As Boolean
        Dim bl As Boolean = False
        Dim beneficiario As New BeneficiarioCollectionClass
        If beneficiario.Validar(Me, Editar) Then
            bl = e.Save
        Else
            RaiseEvent Mensajes(Me, New MensajeClass("Datos duplicados", "No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error))
        End If
        Return bl
    End Function

    Public Overrides Function ToString() As String
        Return Me.Beneficiario
    End Function

#End Region
End Class

Public Class BeneficiarioCollectionClass
    Inherits CollectionGenericClass(Of BeneficiarioClass)

#Region "Miembros"
    Private col As New CC.BeneficiarioCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal coleccion As CC.BeneficiarioCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
#End Region

#Region "Metodos"

    Public Function Validar(ByVal Beneficiario As BeneficiarioClass, ByRef Editar As Boolean) As Boolean
        Dim filtro As New SC.PredicateExpression
        filtro.Add(HC.BeneficiarioFields.Beneficiario = Beneficiario.Beneficiario)
        Dim tmp As New CC.BeneficiarioCollection
        tmp.GetMulti(filtro)
        If Editar = False Then
            If tmp.Count > 0 Then Return False
        End If
        Return True
    End Function

    Public Function Listar() As String()
        Dim lista As New List(Of String)
        For Each b As BeneficiarioClass In Me
            lista.Add(b.Beneficiario)
        Next
        Return lista.ToArray
    End Function

    Public Function Obtener(Optional ByVal Estatus As CondicionEnum = CondicionEnum.TODOS, Optional ByVal SeanProveedores As Boolean = False) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        Dim Orden As SC.SortExpression = New SC.SortExpression(New SC.SortClause(HC.BeneficiarioFields.Beneficiario, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        If Estatus <> CondicionEnum.TODOS Then filtro.Add(HC.BeneficiarioFields.Estatus = Estatus)
        If Not IsNothing(SeanProveedores) And SeanProveedores = True Then
            filtro.Add(HC.BeneficiarioFields.EsProveedor <> 0)
        End If
        col.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Function Obtener(ByVal Condicion As String, ByVal Estatus As CondicionEnum) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Estatus = CondicionEnum.TODOS Then
                filtro.Add(Integralab.ORM.HelperClasses.BeneficiarioFields.Beneficiario Mod (String.Format("%{0}%", Condicion)))
            Else
                filtro.Add(Integralab.ORM.HelperClasses.BeneficiarioFields.Estatus = Estatus)
                filtro.Add(Integralab.ORM.HelperClasses.BeneficiarioFields.Beneficiario Mod (String.Format("%{0}%", Condicion)))
            End If
            Me.col.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener2(ByVal Codigo As Integer, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.ACTIVOS) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Codigo > -1 Then
                filtro.Add(HC.BeneficiarioFields.Codigo = Codigo)
            End If
            If Not FcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.BeneficiarioFields.Estatus = FcCondicion)
            End If
            Me.col.GetMulti(filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener2(ByVal Beneficiario As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Not Beneficiario = "" Then
                filtro.Add(Integralab.ORM.HelperClasses.BeneficiarioFields.Beneficiario = Beneficiario)
            End If
            Me.col.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.BeneficiarioEntity In col
            Dim n As New BeneficiarioClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.BeneficiarioCollection
        Return col
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptBeneficiario
        Dim Reportes As New RptBeneficiario
        Dim Ds As New DataSet
        Dim DtBe As New DsBeneficiario.DtBeneficiarioDataTable
        Dim Emp As New DsBeneficiario.DtEmpresaDataTable
        Dim EsPro As String
        For Each Be As BeneficiarioClass In Me
            If Be.EsProveedor = 0 Then
                EsPro = "NO"
            Else
                EsPro = "SI"
            End If
            DtBe.AddDtBeneficiarioRow(Be.Codigo, Be.Beneficiario, EsPro, Be.Estatus.ToString)
        Next
        'Emp.AddDtEmpresaRow(Empresa)
        Ds.Tables.Add(Emp)
        Ds.Tables.Add(DtBe)
        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(Reportes.Parameter_Modulo.ParameterFieldName, "Catálogos/Bancos/Beneficiarios")
        Reportes.SetParameterValue(Reportes.Parameter_NomEmpresa.ParameterFieldName, Empresa)
        Reportes.SetParameterValue(Reportes.Parameter_Usuario.ParameterFieldName, Usuario)
        Return Reportes
    End Function
#End Region

End Class

Public Class BitacoraCuentaFolioClass
    Inherits GenericClass

    Dim e As EC.BitacoraFolioEntity

    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
        e = New EC.BitacoraFolioEntity
    End Sub
    Sub New(ByVal id As Guid)
        MyBase.New()
        e = New EC.BitacoraFolioEntity(id)
    End Sub
    Sub New(ByVal entidad As EC.BitacoraFolioEntity)
        MyBase.New()
        e = entidad
    End Sub

    Public Property Id() As Guid
        Get
            Return e.Id
        End Get
        Set(ByVal value As Guid)
            e.Id = value
        End Set
    End Property
    Public Property Fecha() As DateTime
        Get
            Return e.Fecha
        End Get
        Set(ByVal value As DateTime)
            e.Fecha = value
        End Set
    End Property
    Public Property FolioNuevo() As Integer
        Get
            Return e.Folionuevo
        End Get
        Set(ByVal value As Integer)
            e.Folionuevo = value
        End Set
    End Property

    Public Property FolioAnterior() As Integer
        Get
            Return e.Folioanterior
        End Get
        Set(ByVal value As Integer)
            e.Folioanterior = value
        End Set
    End Property

    Public ReadOnly Property usuario() As UsuarioClass
        Get
            Dim tmp As New UsuarioClass(e.UsuarioId)
            Return tmp
        End Get
    End Property

    Public Function ObtenerEntidad() As EC.BitacoraFolioEntity
        Return e
    End Function
    Public Function Borrar() As Boolean
    End Function
    Public Function Guardar() As Boolean
    End Function

End Class

Public Class BitacoraCuentaFolioCollectionClass
    Inherits CollectionGenericClass(Of BitacoraCuentaFolioClass)

    Private col As New CC.BitacoraFolioCollection
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.BitacoraFolioCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
    Public Function Validar(ByVal Bitacora As BitacoraCuentaFolioClass) As Boolean
        Dim filtro As New SC.PredicateExpression
        'filtro.Add(HC.ChequeFields.Folio = Bitacora.Folio)
        'filtro.AddWithAnd(HC.ChequeFields.CuentaId = Bitacora.Cuenta.Codigo)
        'Dim tmp As New CC.ChequeCollection
        'tmp.GetMulti(filtro)
        'If tmp.Count > 0 Then Return False
        Return True
    End Function
    Public Function Obtener(Optional ByVal Estatus As EstatusEnum = CondicionEnum.TODOS) As Integer
        'Obtener elementos y Llenar Coleccion
        Dim filtro As New SC.PredicateExpression
        col.GetMulti(filtro)
        Rellenar()
        Return Me.Count
    End Function
    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.BitacoraFolioEntity In col
            Dim n As New BitacoraCuentaFolioClass(e)
            Me.Add(n)
        Next
    End Sub
    Public Function ObtenerColeccion() As CC.BitacoraFolioCollection
        Return col
    End Function
End Class

Public MustInherit Class GenericClass

    Public Event Modificado As EventHandler
    Public Event MensajeError As Integra.Clases.MensajeErrorHandler

End Class

Public MustInherit Class CollectionGenericClass(Of TipoClase)
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
        Dim sp As IServiceProvider = Nothing
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

Public Class MensajeClass

    Sub New()
    End Sub

    Sub New(ByVal Mensaje As String)
        nMensaje = Mensaje
    End Sub

    Sub New(ByVal Titulo As String, ByVal Mensaje As String)
        nMensaje = Mensaje
        nTitulo = Titulo
    End Sub

    Sub New(ByVal Titulo As String, ByVal mensaje As String, ByVal Tipo As System.Windows.Forms.MessageBoxIcon)
        nMensaje = mensaje
        nTitulo = Titulo
        nTipo = Tipo
    End Sub

    Private nMensaje As String
    Public Property Mensaje() As String
        Get
            Return nMensaje
        End Get
        Set(ByVal value As String)
            nMensaje = value
        End Set
    End Property

    Private nTitulo As String
    Public Property Titulo() As String
        Get
            Return nTitulo
        End Get
        Set(ByVal value As String)
            nTitulo = value
        End Set
    End Property

    Private nTipo As System.Windows.Forms.MessageBoxIcon
    Public Property Tipo() As System.Windows.Forms.MessageBoxIcon
        Get
            Return nTipo
        End Get
        Set(ByVal value As System.Windows.Forms.MessageBoxIcon)
            nTipo = value
        End Set
    End Property

End Class

Public Class FormatoChequeClass

    Private Escritor As New Integra.Clases.EscritorClass(130, 37)
    Const Abono As String = "PARA ABONO EN CUENTA DEL BENEFICIARIO"

    Private _AbonoEnCuenta As Windows.Forms.DialogResult
    Public Property ParaAbonoEnCuenta() As Windows.Forms.DialogResult
        Get
            Return _AbonoEnCuenta
        End Get
        Set(ByVal value As Windows.Forms.DialogResult)
            _AbonoEnCuenta = value
        End Set
    End Property

    Private _directorio As String
    Public Property Directorio() As String
        Get
            Return _directorio
        End Get
        Set(ByVal value As String)
            _directorio = value
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

    Private _cheque As ChequeClass
    Public Property Cheque() As ChequeClass
        Get
            Return _cheque
        End Get
        Set(ByVal value As ChequeClass)
            _cheque = value
        End Set
    End Property

    Public Sub Imprimir()
        Escritor.Escribe(Cheque.FechaDocumento.ToString("dd MMM' de 'yyyy"), 100, 1)
        Escritor.Escribe(Cheque.Beneficiario.Beneficiario, 17, 3)
        Escritor.Escribe(Cheque.Importe.ToString("C"), 104, 3)
        Escritor.Escribe(Cheque.ImporteLetra.ToUpper, 3, 6)
        If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escritor.Escribe(Abono, 15, 8)
        Escritor.Escribe(Cheque.Folio, 104, 20)
        Escritor.Escribe(Cheque.FechaDocumento.ToString("dd MMM' de 'yyyy"), 100, 22)
        Escritor.Escribe(Cheque.Beneficiario.Beneficiario, 17, 24)
        Escritor.Escribe(Cheque.Importe.ToString("C"), 104, 24)
        Escritor.Escribe(Cheque.ImporteLetra.ToUpper, 13, 25)
        If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escritor.Escribe(Abono, 25, 27)
        Escritor.Escribe(Cheque.Concepto, 2, 34)
        Dim impresor As New Integra.Clases.ImpresorClass(_directorio, _puerto)
        impresor.Imprime(Escritor.Lee)
    End Sub

    Public Sub ImpresionExitosa()
        Cheque.Imprimir()
    End Sub

End Class

Public Class FormatoPagoElectronicoClass

    Private Escritor As New Integra.Clases.EscritorClass(130, 37)

    Private _directorio As String
    Public Property Directorio() As String
        Get
            Return _directorio
        End Get
        Set(ByVal value As String)
            _directorio = value
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

    Private _cheque As ChequeClass
    Public Property Cheque() As ChequeClass
        Get
            Return _cheque
        End Get
        Set(ByVal value As ChequeClass)
            _cheque = value
        End Set
    End Property

    Public Sub Imprimir()
        Escritor.EscribeMed("COMPROBANTE DE PAGO ELECTRONICO", 1)
        Escritor.Escribe("FECHA: " & Cheque.FechaDocumento.ToString("dd MMM' de 'yyyy"), 50, 2)
        Escritor.Escribe("BENEFICIARIO: " & Cheque.Beneficiario.Beneficiario, 10, 3)
        Escritor.Escribe("IMPORTE:      " & Cheque.Importe.ToString("C"), 10, 4)
        Escritor.Escribe("              " & Cheque.ImporteLetra.ToUpper, 10, 5)
        Escritor.Escribe("FOLIO:        " & Cheque.Folio, 10, 6)
        Escritor.Escribe("CONCEPTO:     " & Cheque.Concepto, 10, 7)
        Dim impresor As New Integra.Clases.ImpresorClass(_directorio, _puerto)
        impresor.Imprime(Escritor.Lee)
    End Sub

    Public Sub ImpresionExitosa()
        Cheque.Imprimir()
    End Sub

End Class

Public Class PrintDocumentChequeClass
    Inherits Drawing.Printing.PrintDocument

    Const Abono As String = "PARA ABONO EN CUENTA DEL BENEFICIARIO"

    Private ch As ChequeClass
    Dim IdBanco As Integer


    Public Property Cheque() As ChequeClass
        Get
            Return ch
        End Get
        Set(ByVal value As ChequeClass)
            ch = value
        End Set
    End Property
    Public Property Banco() As Integer
        Get
            Return IdBanco
        End Get
        Set(ByVal value As Integer)
            IdBanco = value
        End Set
    End Property
    Private _AbonoEnCuenta As Windows.Forms.DialogResult
    Public Property AbonoEnCuenta() As Windows.Forms.DialogResult
        Get
            Return _AbonoEnCuenta
        End Get
        Set(ByVal value As Windows.Forms.DialogResult)
            _AbonoEnCuenta = value
        End Set
    End Property

    Const FC As String = "###,###,##0.00"


    Protected Overrides Sub OnPrintPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim ConfigCheques As New CC.ConfiguracionChequesImpCollection
        ConfigCheques.GetMulti(HC.ConfiguracionChequesImpFields.IdBanco = Banco)
        MyBase.OnPrintPage(e)
        'e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimete
        e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimeter
        e.Graphics.PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighSpeed
        'datos generales del cheque
        Escribe(e.Graphics, ch.Folio, ConfigCheques(0).FolioChequeImpCol, ConfigCheques(0).FolioChequeImpRen)
        Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), ConfigCheques(0).FechaImpCol, ConfigCheques(0).FechaImpRen)
        Escribe(e.Graphics, ch.Beneficiario.Beneficiario, ConfigCheques(0).BeneficiarioImpCol, ConfigCheques(0).BeneficiarioImpRen)
        Escribe(e.Graphics, ch.Importe.ToString(FC), ConfigCheques(0).ImporteImpCol, ConfigCheques(0).ImporteImpRen)
        Escribe(e.Graphics, ch.ImporteLetra.ToUpper, ConfigCheques(0).ImporteConLetraImpCol, ConfigCheques(0).ImporteConLetraImpRen)
        If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, ConfigCheques(0).AbonoAcuentaImpCol, ConfigCheques(0).AbonoAcuentaImpRen)
        'datos de copia del cheque
        If ConfigCheques(0).FolioChequeCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Folio, ConfigCheques(0).FolioChequeCopiaImpCol, ConfigCheques(0).FolioChequeCopiaImpRen)
        If ConfigCheques(0).FechaCopiaImpCol Then Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), ConfigCheques(0).FechaCopiaImpCol, ConfigCheques(0).FechaCopiaImpRen)
        If ConfigCheques(0).BeneficiarioCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Beneficiario.Beneficiario, ConfigCheques(0).BeneficiarioCopiaImpCol, ConfigCheques(0).BeneficiarioCopiaImpRen)
        If ConfigCheques(0).ImporteCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Importe.ToString(FC), ConfigCheques(0).ImporteCopiaImpCol, ConfigCheques(0).ImporteCopiaImpRen)
        If ConfigCheques(0).ImporteConLetraCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.ImporteLetra.ToUpper, ConfigCheques(0).ImporteConLetraCopiaImpCol, ConfigCheques(0).ImporteConLetraCopiaImpRen)
        If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, ConfigCheques(0).AbonoAcuentaCopiaImpCol, ConfigCheques(0).AbonoAcuentaCopiaImpRen)
        'detalle de poliza de cheque
        Escribe(e.Graphics, ch.Banco.Descripcion.ToUpper, ConfigCheques(0).BancoImpCol, ConfigCheques(0).BancoImpRen)
        Escribe(e.Graphics, ch.Cuenta.Cuenta.ToUpper, ConfigCheques(0).CuentaBancoImpCol, ConfigCheques(0).CuentaBancoImpRen)
        'Escribe(e.Graphics, ch.Folio.ToUpper, ConfigCheques(0).ChequeImpCol, ConfigCheques(0).ChequeImpRen)
        Escribe(e.Graphics, ch.Concepto, ConfigCheques(0).ConceptoImpCol, ConfigCheques(0).ConceptoImpRen)

        'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 10)
        'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 20, 20)
        'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 20)
        'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 10, 25)
        'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 37)
        'Escribe(e.Graphics, ch.Folio, 150, 90)
        'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 97)
        'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 30, 107)
        'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 107)
        'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 20, 117)
        'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 127)
        'Escribe(e.Graphics, ch.Concepto, 10, 150)

        Dim x As Single = ConfigCheques(0).CuentaImpCol
        Dim y As Single = ConfigCheques(0).CuentaImpRen

        Dim tx As Single
        Dim ty As Single

        Dim ImprimioPapa As Boolean = False
        Dim CtaMayor As String = ""
        For Each detalle As PolizaDetalleClass In ch.Poliza.Detalles
            If ConfigCheques(0).ImprimirCuentaConcentrada = True Then
                Dim params() As Object = {detalle.CuentaContable.CuentaMayor, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
                Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4} ", params), x, y)
                If detalle.Operacion = PolizaOperacionEnum.CARGO Then
                    Escribe(e.Graphics, detalle.Importe.ToString(FC), ConfigCheques(0).CargoImpCol, y)
                Else
                    Escribe(e.Graphics, detalle.Importe.ToString(FC), ConfigCheques(0).AbonoImpCol, y)
                End If
                y = y + 4
            Else
                If CtaMayor <> detalle.CuentaContable.CuentaMayor Then
                    ImprimioPapa = False
                    If Not ImprimioPapa Then
                        tx = x
                        ty = y
                        Dim CtaPadre As CuentaContableClass = ObtenerPadre(detalle.CuentaContable)
                        CtaMayor = CtaPadre.CuentaMayor
                        Dim Importe As Decimal = ObtenerTotalCuentaPadre(CtaPadre.CuentaMayor, ch.Poliza)
                        Escribe(e.Graphics, String.Format("{0} {1}", CtaPadre.CuentaMayor, CtaPadre.NombreCuenta), tx, ty)
                        If detalle.Operacion = PolizaOperacionEnum.ABONO Then
                            'tx += 180
                            tx = ConfigCheques(0).CargoImpCol
                        Else
                            'tx += 150
                            tx = ConfigCheques(0).AbonoImpCol
                        End If
                        Escribe(e.Graphics, Importe.ToString(FC), tx, ty)
                        y += 4
                        ImprimioPapa = True
                    End If
                    Dim params() As Object = {vbTab, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
                    Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
                    'Escribe(e.Graphics, detalle.Importe.ToString(FC), x + 110, y)
                    y += 4
                Else
                    Dim params() As Object = {vbTab, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
                    Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
                    'Escribe(e.Graphics, detalle.Importe.ToString(FC), x + 110, y)
                    'y += 4
                End If
            End If
        Next

        ''Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), x + 150, 330) ' cargo
        ''Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), x + 180, 330) 'abono
        Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), ConfigCheques(0).CargoTotalImpCol, ConfigCheques(0).CargoTotalImpRen) ' cargo
        Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), ConfigCheques(0).AbonoTotalImpCol, ConfigCheques(0).AbonoTotalImpRen) 'abono
    End Sub

    Private Function ObtenerPadre(ByVal CuentaContable As CuentaContableClass) As CuentaContableClass
        If IsNothing(CuentaContable.CuentaPadre) Then
            Return CuentaContable
        Else
            Return ObtenerPadre(CuentaContable.CuentaPadre)
        End If
    End Function

    Private Function ObtenerTotalCuentaPadre(ByVal CuentaMayor As String, ByVal Poliza As PolizaClass) As Decimal
        Dim tmp As Decimal = 0
        For Each Detalle As PolizaDetalleClass In Poliza.Detalles
            If Detalle.CuentaContable.CuentaMayor = CuentaMayor Then
                tmp += Detalle.Importe
            End If
        Next
        Return tmp
    End Function

    Private Sub Escribe(ByRef gr As System.Drawing.Graphics, ByVal Texto As String, ByVal x As Single, ByVal y As Single)
        Dim fn As New Drawing.Font("Courier New", 10)
        gr.DrawString(Texto, fn, Drawing.Brushes.Black, x, y)
    End Sub

    Public Sub ImpresionExitosa()
        Cheque.Imprimir()
    End Sub

End Class

Public Class PrintDocumentPagoElectronicoClass
    Inherits Drawing.Printing.PrintDocument

    Private ch As ChequeClass
    Public Property Cheque() As ChequeClass
        Get
            Return ch
        End Get
        Set(ByVal value As ChequeClass)
            ch = value
        End Set
    End Property

    Protected Overrides Sub OnPrintPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        MyBase.OnPrintPage(e)
        e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimeter
        e.Graphics.PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighSpeed
        Escribe(e.Graphics, "Comprobante de Pago Electronico", 20, 1)
        Escribe(e.Graphics, "Folio:               " & ch.Folio, 20, 10)
        Escribe(e.Graphics, "Fecha del Documento: " & ch.FechaDocumento.ToString("dd MMM' de 'yyyy"), 20, 20)
        Escribe(e.Graphics, "Beneficiario:        " & ch.Beneficiario.Beneficiario, 20, 30)
        Escribe(e.Graphics, "Importe:             " & ch.Importe.ToString("C"), 20, 40)
        Escribe(e.Graphics, "Importe con Letra:   " & ch.ImporteLetra.ToUpper, 20, 50)
        Escribe(e.Graphics, "Concepto:            " & ch.Concepto, 20, 60)
    End Sub

    Private Sub Escribe(ByRef gr As System.Drawing.Graphics, ByVal Texto As String, ByVal x As Single, ByVal y As Single)
        Dim fn As New Drawing.Font("Courier New", 10)
        gr.DrawString(Texto, fn, Drawing.Brushes.Black, x, y)
    End Sub

    Public Sub ImpresionExitosa()
        Cheque.Imprimir()
    End Sub

End Class

Public Class PrintDocumentPolizaCancelacionClass
    Inherits Drawing.Printing.PrintDocument

    Const Abono As String = "CANCELACIÓN ABONO EN CUENTA DEL BENEFICIARIO"

    Private ch As ChequeClass
    Public Property Cheque() As ChequeClass
        Get
            Return ch
        End Get
        Set(ByVal value As ChequeClass)
            ch = value
        End Set
    End Property

    Private _AbonoEnCuenta As Windows.Forms.DialogResult
    Public Property AbonoEnCuenta() As Windows.Forms.DialogResult
        Get
            Return _AbonoEnCuenta
        End Get
        Set(ByVal value As Windows.Forms.DialogResult)
            _AbonoEnCuenta = value
        End Set
    End Property

    Const FC As String = "###,###,##0.00"

    Protected Overrides Sub OnPrintPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        MyBase.OnPrintPage(e)
        e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimeter
        'e.Graphics.PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighSpeed
        'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 10)
        'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 20, 20)
        Escribe(e.Graphics, ch.Poliza.NumeroPoliza, 170, 10)
        Escribe(e.Graphics, ch.Poliza.Concepto, 15, 10)
        'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 20)
        'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 10, 25)
        'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 37)
        'Escribe(e.Graphics, ch.Folio, 150, 90)
        'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 97)
        'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 30, 107)
        'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 107)
        'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 20, 117)
        'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 127)
        'Escribe(e.Graphics, ch.Concepto, 10, 150)

        Dim x As Single = 10
        Dim y As Single = 15

        Dim tx As Single
        Dim ty As Single

        Dim ImprimioPapa As Boolean = False
        Dim CtaMayor As String = ""
        For i As Integer = ch.Poliza.Detalles.Count - 1 To 0 Step -1
            Dim Detalle As PolizaDetalleClass = ch.Poliza.Detalles(i)
            If CtaMayor <> Detalle.CuentaContable.CuentaMayor Then
                ImprimioPapa = False
                If Not ImprimioPapa Then
                    tx = x
                    ty = y
                    Dim CtaPadre As CuentaContableClass = ObtenerPadre(Detalle.CuentaContable)
                    CtaMayor = CtaPadre.CuentaMayor
                    Dim Importe As Decimal = ObtenerTotalCuentaPadre(CtaPadre.CuentaMayor, ch.PolizaCancelacion)
                    Escribe(e.Graphics, String.Format("{0} {1}", CtaPadre.CuentaMayor, CtaPadre.NombreCuenta), tx, ty)
                    If Detalle.Operacion = PolizaOperacionEnum.ABONO Then
                        tx += 180
                    Else
                        tx += 150
                    End If
                    Escribe(e.Graphics, Importe.ToString(FC), tx, ty)
                    y += 4
                    ImprimioPapa = True
                End If
                Dim params() As Object = {vbTab, Detalle.CuentaContable.SubCuenta, Detalle.CuentaContable.SSubCuenta, Detalle.CuentaContable.SSSubCuenta, Detalle.CuentaContable.NombreCuenta}
                Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
                Escribe(e.Graphics, Detalle.Importe.ToString(FC), x + 110, y)
                y += 4
            Else
                Dim params() As Object = {vbTab, Detalle.CuentaContable.SubCuenta, Detalle.CuentaContable.SSubCuenta, Detalle.CuentaContable.SSSubCuenta, Detalle.CuentaContable.NombreCuenta}
                Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
                Escribe(e.Graphics, Detalle.Importe.ToString(FC), x + 110, y)
                y += 4
            End If
        Next

        Escribe(e.Graphics, ch.PolizaCancelacion.Importe.ToString(FC), x + 150, 330)
        Escribe(e.Graphics, ch.PolizaCancelacion.Importe.ToString(FC), x + 180, 330)
    End Sub

    Private Function ObtenerPadre(ByVal CuentaContable As CuentaContableClass) As CuentaContableClass
        If IsNothing(CuentaContable.CuentaPadre) Then
            Return CuentaContable
        Else
            Return ObtenerPadre(CuentaContable.CuentaPadre)
        End If
    End Function

    Private Function ObtenerTotalCuentaPadre(ByVal CuentaMayor As String, ByVal Poliza As PolizaClass) As Decimal
        Dim tmp As Decimal = 0
        For Each Detalle As PolizaDetalleClass In Poliza.Detalles
            If Detalle.CuentaContable.CuentaMayor = CuentaMayor Then
                tmp += Detalle.Importe
            End If
        Next
        Return tmp
    End Function

    Private Sub Escribe(ByRef gr As System.Drawing.Graphics, ByVal Texto As String, ByVal x As Single, ByVal y As Single)
        Dim fn As New Drawing.Font("Courier New", 10)
        gr.DrawString(Texto, fn, Drawing.Brushes.Black, x, y)
    End Sub

    Public Sub ImpresionExitosa()
        Cheque.Imprimir()
    End Sub

End Class