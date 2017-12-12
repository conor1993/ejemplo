'Imports EC = IntegraLab.ORM.EntityClasses
'Imports CC = IntegraLab.ORM.CollectionClasses
'Imports HC = IntegraLab.ORM.HelperClasses
'Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
'Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
'Public Class ProveedorClass
'    Implements IEntidad

'    Private ProveedorCollection As New CC.CatProveedoresCollection
'    Private ProveedorEntity As New EC.CatProveedoresEntity
'    'Private ProveedorAvanzado As New EC.cProveedorAvanzadoEntity
'    'Private ProveedorDF As New EC.DomicilioFiscalEntity
'    Private ProveedorContable As New ProvDtosContablesCollectionClass
'    Private Mipoblacion As New PoblacionClass
'    Private _DomicilioFiscales As New DomicilioFiscalCollectionClass
'    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
'    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

'    Sub New()
'        AddHandler Modificado, AddressOf FueModificado
'        'Inicializacion de Todas las variables
'        ProveedorEntity = New EC.ProveedorEntity
'        Me.Mipoblacion = New PoblacionClass
'        Me.Poblacion = New PoblacionClass
'        ProveedorEntity.Rfc = ""
'        ProveedorEntity.RazonSocial = ""
'        ProveedorEntity.Beneficiario = ""
'        ProveedorEntity.Contacto = ""
'        ProveedorEntity.ReprecentanteLegal = ""
'        ProveedorEntity.Domicilio = ""
'        ProveedorEntity.Colonia = ""
'        ProveedorEntity.CodigoPostal = ""
'        ProveedorEntity.CodigoPoblacion = 0
'        ProveedorEntity.Estatus = EstatusEnum.Activo
'        ProveedorEntity.UsuarioAlta = 0
'        ProveedorAvanzado = New EC.ProveedorAvanzadoEntity
'        ProveedorAvanzado.Email = ""
'        ProveedorAvanzado.Web = ""
'        ProveedorAvanzado.PrioridadPago = PPagoEnum.No
'        ProveedorAvanzado.CodigoTipoProveedor = 0
'        ProveedorAvanzado.DiaRevision = 0
'        ProveedorAvanzado.DiaPago = 0
'        ProveedorAvanzado.Telefono1 = ""
'        ProveedorAvanzado.Telefono2 = ""
'        ProveedorAvanzado.Fax = ""
'        ProveedorAvanzado.LadaTel1 = ""
'        ProveedorAvanzado.LadaTel2 = ""
'        ProveedorAvanzado.LadaFax = ""
'        ProveedorAvanzado.DiasCredito = 0
'        ProveedorAvanzado.PorcentajeDescuento = 0
'        ProveedorAvanzado.ClaveBancaria = ""
'        ProveedorAvanzado.CodigoBanco = 0
'    End Sub

'    Sub New(ByVal Entidad As EC.ProveedorEntity)
'        ProveedorEntity = Entidad
'        ProveedorAvanzado = Entidad.ProveedorAvanzado
'    End Sub

'    Public Sub LeerEntidad(ByVal Entidad As Object())
'        Me.ProveedorEntity = Entidad(0)
'        Me.ProveedorAvanzado = Entidad(1)
'        'Me.ProveedorContable = Entidad(2)
'    End Sub

'#Region "propiedades"
'    <System.ComponentModel.DisplayName("Código")> _
'    Public ReadOnly Property Codigo() As Integer
'        Get
'            Return ProveedorEntity.Codigo
'        End Get
'    End Property
'    <System.ComponentModel.DisplayName("Razón Social")> _
'    Public Property RazonSocial() As String
'        Get
'            Return ProveedorEntity.RazonSocial
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.RazonSocial = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Fecha")> _
'    Public Property FechaAlta() As Date
'        Get
'            Return ProveedorEntity.FechaAlta
'        End Get
'        Set(ByVal value As Date)
'            ProveedorEntity.FechaAlta = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Estatus")> _
'    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
'        Get
'            Return ProveedorEntity.Estatus
'        End Get
'        Set(ByVal value As EstatusEnum)
'            ProveedorEntity.Estatus = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("R.F.C.")> _
'    Public Property rfc() As String
'        Get
'            Return ProveedorEntity.Rfc
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.Rfc = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Beneficiario")> _
'    Public Property Beneficiario() As String
'        Get
'            Return ProveedorEntity.Beneficiario
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.Beneficiario = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Contacto")> _
'    Public Property Contacto() As String
'        Get
'            Return ProveedorEntity.Contacto
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.Contacto = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Representante")> _
'    Public Property RepLegal() As String
'        Get
'            Return ProveedorEntity.ReprecentanteLegal
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.ReprecentanteLegal = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Domicilio")> _
'    Public Property Domicilio() As String
'        Get
'            Return ProveedorEntity.Domicilio
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.Domicilio = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Colonia")> _
'    Public Property Colonia() As String
'        Get
'            Return ProveedorEntity.Colonia
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.Colonia = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("C.P.")> _
'    Public Property CP() As String
'        Get
'            Return ProveedorEntity.CodigoPostal
'        End Get
'        Set(ByVal value As String)
'            ProveedorEntity.CodigoPostal = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Estado")> _
'    Public ReadOnly Property Estado() As EstadoClass
'        Get
'            Mipoblacion.LeerEntidad(Me.ProveedorEntity.Poblacion)
'            Return Me.Mipoblacion.CodigoEstado
'        End Get
'    End Property
'    <System.ComponentModel.DisplayName("Ciudad")> _
'    Public ReadOnly Property Ciudad() As CiudadClass
'        Get
'            Mipoblacion.LeerEntidad(Me.ProveedorEntity.Poblacion)
'            Return Me.Mipoblacion.CodigoCiudad
'        End Get
'    End Property
'    <System.ComponentModel.DisplayName("Población")> _
'    Public Property Poblacion() As PoblacionClass
'        Get
'            Mipoblacion.LeerEntidad(Me.ProveedorEntity.Poblacion)
'            Return Mipoblacion
'        End Get
'        Set(ByVal value As PoblacionClass)
'            ProveedorEntity.Poblacion = value.ObtenerEntidad
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    'Datos Avanzados
'    <System.ComponentModel.DisplayName("Email")> _
'    Public Property Email() As String
'        Get
'            Return ProveedorAvanzado.Email
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.Email = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Prioridad Pago")> _
'    Public Property ppago() As PPagoEnum
'        Get
'            Return ProveedorAvanzado.PrioridadPago()
'        End Get
'        Set(ByVal value As PPagoEnum)
'            ProveedorAvanzado.PrioridadPago = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Web")> _
'    Public Property Web() As String
'        Get
'            Return ProveedorAvanzado.Web
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.Web = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Tipo Proveedor")> _
'    Public Property TipoProveedor() As Integer
'        Get
'            Return ProveedorAvanzado.CodigoTipoProveedor
'        End Get
'        Set(ByVal value As Integer)
'            ProveedorAvanzado.CodigoTipoProveedor = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Dia Revisión")> _
'    Public Property DiaRevision() As DiasEnum
'        Get
'            Return ProveedorAvanzado.DiaRevision
'        End Get
'        Set(ByVal value As DiasEnum)
'            ProveedorAvanzado.DiaRevision = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Dia Pago")> _
'    Public Property DiaPago() As DiasEnum
'        Get
'            Return ProveedorAvanzado.DiaPago
'        End Get
'        Set(ByVal value As DiasEnum)
'            ProveedorAvanzado.DiaPago = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Telefono")> _
'    Public Property Telefono1() As String
'        Get
'            Return ProveedorAvanzado.Telefono1
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.Telefono1 = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Telefono")> _
'    Public Property Telefono2() As String
'        Get
'            Return ProveedorAvanzado.Telefono2
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.Telefono2 = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Fax")> _
'    Public Property Fax() As String
'        Get
'            Return ProveedorAvanzado.Fax
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.Fax = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Lada")> _
'    Public Property lada1() As String
'        Get
'            Return ProveedorAvanzado.LadaTel1
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.LadaTel1 = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Lada")> _
'    Public Property lada2() As String
'        Get
'            Return ProveedorAvanzado.LadaTel2
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.LadaTel2 = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Lada Fax")> _
'    Public Property ladafax() As String
'        Get
'            Return ProveedorAvanzado.LadaFax
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.LadaFax = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Dia Credito")> _
'    Public Property DiasCredito() As Integer
'        Get
'            Return ProveedorAvanzado.DiasCredito
'        End Get
'        Set(ByVal value As Integer)
'            ProveedorAvanzado.DiasCredito = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Descuento")> _
'    Public Property PorcDescto() As Short
'        Get
'            Return ProveedorAvanzado.PorcentajeDescuento
'        End Get
'        Set(ByVal value As Short)
'            ProveedorAvanzado.PorcentajeDescuento = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Banco")> _
'    Public Property Banco() As Integer
'        Get
'            Return ProveedorAvanzado.CodigoBanco
'        End Get
'        Set(ByVal value As Integer)
'            ProveedorAvanzado.CodigoBanco = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Clave Interbancaria")> _
'    Public Property Clabe() As String
'        Get
'            Return ProveedorAvanzado.ClaveBancaria
'        End Get
'        Set(ByVal value As String)
'            ProveedorAvanzado.ClaveBancaria = value
'            RaiseEvent Modificado(Me, New EventArgs)
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Cuenta Contable")> _
'    Public Property cuentacontable() As ProvDtosContablesCollectionClass
'        Get
'            Return ProveedorContable
'        End Get
'        Set(ByVal value As ProvDtosContablesCollectionClass)
'            ProveedorContable = value
'        End Set
'    End Property
'    <System.ComponentModel.DisplayName("Domicilios Fiscales")> _
'   Public Property DomicilioFiscales() As DomicilioFiscalCollectionClass
'        Get
'            Return Me._DomicilioFiscales
'        End Get
'        Set(ByVal value As DomicilioFiscalCollectionClass)
'            Me._DomicilioFiscales = value
'        End Set
'    End Property
'#End Region

'    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

'    End Sub

'    Public Overrides Function ToString() As String
'        Return Me.RazonSocial
'    End Function

'    Public Function Borrar() As Boolean Implements IEntidad.Borrar
'        Try
'            Dim Proveedor As New CC.ProveedorCollection
'            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'            filtro.Add(HC.ProveedorFields.Estatus = EstatusEnum.Activo)
'            filtro.Add(HC.ProveedorAvanzadoFields.Codigo = Me.Codigo)
'            Dim y As Integer = Proveedor.GetDbCount(filtro)
'            If y > 0 Then
'                RaiseEvent MensajeError(Me, "El Proveedor tiene ciudades activas.")
'            Else
'                ProveedorEntity.Estatus = EstatusEnum.Inactivo
'                If ProveedorEntity.Save() Then Return True
'                RaiseEvent MensajeError(Me, "El Proveedor no se pudo borrar.")
'            End If
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'        End Try
'        Return False
'    End Function

'    Public Function Guardar() As Boolean 
'        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")

'        Try
'            trans.Add(ProveedorEntity)
'            If ProveedorEntity.IsNew Then
'                If Not SPA.ProveedoresIns(Me.rfc, Me.RazonSocial, Me.Beneficiario, Me.Contacto, Me.RepLegal, _
'                        Estatus, Me.Domicilio, Me.Colonia, Me.CP, Me.Poblacion.Codigo, 0, _
'                        Me.ProveedorEntity.Codigo, trans) = 0 Then
'                    trans.Add(ProveedorEntity)
'                    ProveedorEntity.Refetch()
'                    ProveedorAvanzado.Proveedor = ProveedorEntity
'                    trans.Add(ProveedorAvanzado)

'                    If ProveedorAvanzado.Save Then
'                        trans.Commit()
'                        Return True
'                    Else
'                        trans.Rollback()
'                        MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
'                        Return False
'                    End If
'                Else
'                    trans.Rollback()
'                    MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
'                    Return False
'                End If
'            Else
'                If ProveedorEntity.Save() Then
'                    trans.Add(ProveedorEntity)
'                    ProveedorEntity.Refetch()

'                    ProveedorAvanzado.Proveedor = ProveedorEntity
'                    ProveedorAvanzado.IsNew = False

'                    trans.Add(ProveedorAvanzado)

'                    If ProveedorAvanzado.Save Then
'                        trans.Commit()
'                        Return True
'                    Else
'                        trans.Rollback()
'                        MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
'                        Return False
'                    End If
'                Else
'                    trans.Rollback()
'                    MsgBox("El Proveedor no pudo ser guardado, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
'                    Return False
'                End If
'            End If
'        Catch ex As Exception
'            trans.Rollback()
'            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
'            Return False
'        Finally
'            trans.Dispose()
'        End Try
'    End Function

'    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
'        Try
'            If ProveedorEntity.FetchUsingPK(Codigo) Then
'                ProveedorAvanzado.FetchUsingPK(Codigo)
'                Dim COL As New CC.DomicilioFiscalCollection
'                COL.GetMulti(HC.DomicilioFiscalFields.Rfc = rfc)
'                For Each x As EC.DomicilioFiscalEntity In COL
'                    ProveedorDF = x
'                Next
'                RaiseEvent Modificado(Me, New EventArgs)
'                Return True
'            End If
'            RaiseEvent MensajeError(Me, "El Proveedor especificado no existe.")
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'        End Try
'        Return False
'    End Function

'    Public Function ObtenerEntidad() As Object()
'        Dim Entidad(1) As Object
'        Entidad(0) = Me.ProveedorEntity
'        Entidad(1) = Me.ProveedorAvanzado
'        Return Entidad
'    End Function

'    Public Sub AgregarDatosContables(ByVal DtoContable As ProvDtosContablesClass)
'        ProveedorContable.Add(DtoContable)
'    End Sub

'    Public Function obtenerDatos(ByVal Codigo As Integer) As Boolean
'        Try
'            If ProveedorEntity.FetchUsingPK(Codigo) Then
'                ProveedorAvanzado = ProveedorEntity.GetSingleProveedorAvanzado(True)
'                'provdtoscontablesCol = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
'                RaiseEvent Modificado(Me, New EventArgs)
'                Return True
'            End If
'            RaiseEvent MensajeError(Me, "El Proveedor especificado no existe.")
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'        End Try
'        Return False
'    End Function

'    Public Function Cancelar(ByRef trans As IntegraLab.ORM.HelperClasses.Transaction) As Boolean 

'    End Function

'    Public Function Guardar1(ByRef trans As IntegraLab.ORM.HelperClasses.Transaction) As Boolean 

'    End Function
'End Class

'Public Class ProveedorCollectionClass
'    Inherits CollectionClass(Of ProveedorClass)

'    Private ProveedorCollection As New CC.ProveedorCollection
'    Private ProveedorAVCollection As New CC.ProveedorAvanzadoCollection
'    Private _mostrar As MostrarEnum
'    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'    Public Event MensajeError As MensajeErrorHandler

'    Sub New()
'        MyBase.New()
'    End Sub

'    Public Property Mostrar() As MostrarEnum
'        Get
'            Return _mostrar
'        End Get
'        Set(ByVal value As MostrarEnum)
'            _mostrar = value
'        End Set
'    End Property

'    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
'        Try
'            Me.ClearItems()

'            If Not FcCondicion = CondicionEnum.TODOS Then
'                ProveedorCollection.GetMulti(HC.ProveedorFields.Estatus = FcCondicion)
'            Else
'                ProveedorCollection.GetMulti(Nothing)
'            End If

'            For Each ProveedorEntity As EC.ProveedorEntity In ProveedorCollection
'                Dim Proveedor As New ProveedorClass
'                Dim Entidades(1) As Object
'                Entidades(0) = ProveedorEntity
'                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
'                Proveedor.LeerEntidad(Entidades)
'                Me.Add(Proveedor)
'            Next

'            Return Count
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Obtener(ByVal RazonSocial As String, ByVal RFC As String, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.Todos) As Integer
'        Try
'            Me.Clear()
'            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'            If Codigo = -1 Then
'                Filtro.Add(HC.ProveedorFields.RazonSocial Mod String.Format("%{0}%", RazonSocial))
'                Filtro.Add(HC.ProveedorFields.Rfc Mod String.Format("%{0}%", RFC))
'            Else
'                Filtro.Add(HC.ProveedorFields.Codigo = Codigo)
'            End If

'            If Not fccondicion = CondicionEnum.Todos Then
'                Filtro.Add(HC.ProveedorFields.Estatus = fccondicion)
'            End If

'            Dim Conteo As Integer = 0

'            ProveedorCollection.GetMulti(Filtro)

'            For Each ProveedorEntity As EC.ProveedorEntity In ProveedorCollection
'                Dim MiProveedor As New ProveedorClass
'                Dim Entidades(1) As Object
'                Entidades(0) = ProveedorEntity
'                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
'                'Entidades(2) = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
'                MiProveedor.LeerEntidad(Entidades)
'                Me.Add(MiProveedor)
'                Conteo += 1
'            Next
'            Return Conteo
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Obtener(ByVal Proveedor As ProveedorClass) As Integer
'        Try
'            Me.ClearItems()
'            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
'            Filtro.Add(HC.ProveedorFields.Codigo = Proveedor.Codigo)
'            Dim Conteo As Integer = ProveedorCollection.GetDbCount(Filtro)
'            If Conteo > 0 Then
'                ProveedorCollection.GetMulti(Filtro)
'                For Each ProveedorEntity As EC.ProveedorEntity In ProveedorCollection
'                    Dim MiProveedor As New ProveedorClass
'                    Dim Entidades(1) As Object
'                    Entidades(0) = ProveedorEntity
'                    Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
'                    'Entidades(2) = ProveedorEntity.GetMultiMcatCompProveedoresControlContable(True)
'                    MiProveedor.LeerEntidad(Entidades)
'                    Me.Add(MiProveedor)
'                Next
'            End If
'            Return Conteo
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Obtener(ByVal TipoBusqueda As TipoBusquedaEnum, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.Todos) As Integer
'        Try
'            Me.Clear()
'            Dim Conteo As Integer = 0

'            If Mostrar = MostrarEnum.Todos Then
'                If fccondicion = CondicionEnum.Todos Then
'                    ProveedorCollection.GetMulti(Nothing)
'                Else
'                    ProveedorCollection.GetMulti(HC.ProveedorFields.Estatus = fccondicion)
'                End If
'            Else
'                If fccondicion = CondicionEnum.Todos Then
'                    ProveedorCollection.GetMulti(HC.ProveedorFields.Codigo = Mostrar)
'                Else
'                    ProveedorCollection.GetMulti(HC.ProveedorFields.Codigo = Mostrar And HC.ProveedorFields.Estatus = fccondicion)
'                End If
'            End If

'            For Each ProveedorEntity As EC.ProveedorEntity In ProveedorCollection
'                Dim Proveedor As New ProveedorClass
'                Dim Entidades(1) As Object
'                Entidades(0) = ProveedorEntity
'                Entidades(1) = ProveedorEntity.GetSingleProveedorAvanzado
'                Proveedor.LeerEntidad(Entidades)
'                Proveedor.DomicilioFiscales = New DomicilioFiscalCollectionClass
'                Me.Add(Proveedor)
'                Conteo += 1
'            Next
'            Return Conteo
'        Catch ex As Exception
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Guardar()
'        ProveedorCollection = New CC.ProveedorCollection
'        ProveedorAVCollection = New CC.ProveedorAvanzadoCollection
'        'ProveedorDCCollection = New CC.ProveedoresControlContableCollection
'        For Each Proveedor As ProveedorClass In Me
'            Dim ProveedorEntity As New EC.ProveedorEntity
'            Dim ProveedorAVEntity As New EC.ProveedorAvanzadoEntity
'            'Dim proveedorDCEntity As New EC.ProveedoresControlContableEntity
'            Dim Entidades(2) As Object
'            Entidades = Proveedor.ObtenerEntidad()
'            ProveedorEntity = Entidades(0)
'            ProveedorAVEntity = Entidades(1)
'            'proveedorDCEntity = Entidades(2)
'            ProveedorCollection.Add(ProveedorEntity)
'            ProveedorAVCollection.Add(ProveedorAVEntity)
'            'ProveedorDCCollection.Add(proveedorDCEntity)
'        Next
'        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")
'        Try
'            Trans.Add(ProveedorCollection)
'            Dim Conteo As Integer = ProveedorCollection.SaveMulti()
'            If Conteo <= 0 Then
'                Trans.Rollback()
'                RaiseEvent MensajeError(Me, "No se pudo Guardar Informacion del Proveedor.")
'            Else
'                Trans.Add(ProveedorAVCollection)
'                If ProveedorAVCollection.SaveMulti() <= 0 Then
'                    Trans.Rollback()
'                    RaiseEvent MensajeError(Me, "No se pudo Guardar Informacion del Proveedor.")
'                Else

'                    Trans.Commit()
'                End If
'            End If
'            Return Conteo
'        Catch ex As Exception
'            Trans.Rollback()
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Borrar()
'        ProveedorCollection = New CC.ProveedorCollection
'        ProveedorAVCollection = New CC.ProveedorAvanzadoCollection
'        For Each Proveedor As ProveedorClass In Me
'            Dim ProveedorEntity As New EC.ProveedorEntity
'            Dim ProveedorAVEntity As New EC.ProveedorAvanzadoEntity
'            Dim Entidades(1) As Object
'            Entidades = Proveedor.ObtenerEntidad()
'            ProveedorEntity = Entidades(0)
'            ProveedorAVEntity = Entidades(1)
'            ProveedorCollection.Add(ProveedorEntity)
'            ProveedorAVCollection.Add(ProveedorAVEntity)

'        Next
'        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")
'        Try
'            Dim Conteo As Integer = 0
'            Trans.Add(ProveedorAVCollection)
'            If ProveedorAVCollection.DeleteMulti() <= 0 Then
'                Trans.Rollback()
'                RaiseEvent MensajeError(Me, "No se pudieron borrar los Proveedores.")
'            Else
'                Trans.Add(ProveedorCollection)
'                Conteo = ProveedorCollection.DeleteMulti()
'                If Conteo <= 0 Then
'                    Trans.Rollback()
'                    RaiseEvent MensajeError(Me, "No se pudieron borrar los Proveedores.")
'                Else
'                    Trans.Commit()
'                End If
'            End If
'            Return Conteo
'        Catch ex As Exception
'            Trans.Rollback()
'            RaiseEvent MensajeError(Me, ex.Message)
'            Return -1
'        End Try
'    End Function

'    Public Function Reporte() As CRepProveedor
'        Dim Reportes As New CRepProveedor
'        Dim ds As New DataSet
'        Dim dtProv As New DSetProveedor.ProveedorDataTable
'        For Each Prov As ProveedorClass In Me
'            dtProv.AddProveedorRow(Prov.Codigo, Prov.RazonSocial, Prov.rfc, Prov.Contacto, Prov.RepLegal, Prov.Domicilio, Prov.Estatus.ToString)
'        Next
'        ds.Tables.Add(dtProv)
'        Reportes.SetDataSource(ds)
'        Return Reportes
'    End Function

'End Class