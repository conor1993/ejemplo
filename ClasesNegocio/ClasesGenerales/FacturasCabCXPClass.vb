Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class FacturasCabCXPClass
    Inherits ClassBase(Of EC.UsrCxpfacturasCabEntity)
    Dim _detalle As FacturaDetalleCXPRecepcionesColeccion
#Region "Constructores"
    Sub New(ByVal E As EC.UsrCxpfacturasCabEntity)
        Me.Entity = E
    End Sub
    Sub New()
        MyBase.New()
        Me.Estatus = EstatusFacturasEnum.VIGENTE
        Me.TasaIva = 0
        Me.TasaISR = 0
        Me.TasaRetIva = 0
    End Sub
    Sub New(ByVal EmpresaId As Integer, ByVal ProveedorId As Integer, ByVal NoFactura As String)
        Me.Obtener(EmpresaId, ProveedorId, NoFactura)
        'Entity = New EC.UsrCxpfacturasCabEntity(EmpresaId, ProveedorId, NoFactura)
    End Sub
#End Region

#Region "Propiedades"

    Public Property IdEmpresa() As Integer
        Get
            Return Entity.EmpresaId
        End Get
        Set(ByVal value As Integer)
            Entity.EmpresaId = value
        End Set
    End Property
    Public Property Proveedor() As ProveedorClass
        Get
            Dim prov As New ProveedorClass(Entity.Proveedor)
            Return prov
        End Get
        Set(ByVal value As ProveedorClass)
            'Ojo
            Entity.IdProveedor = value.Codigo
        End Set
    End Property

    Public ReadOnly Property CodigoProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get

    End Property

    Public ReadOnly Property ProveedorRazon() As String
        Get
            Return Me.Proveedor.RazonSocial
        End Get
    End Property
    Public ReadOnly Property DescripcionTipoProveedor() As String
        Get
            Return Me.Proveedor.ProveeorAvanzado.ObtenerEntidad.TipoProveedor.Descripcion
        End Get
    End Property
    Public Property NoFactura() As String
        Get
            Return Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Entity.NoFactura = value
        End Set
    End Property
    Public Property FechaFactura() As Date
        Get
            Return Entity.FechaFactura
        End Get
        Set(ByVal value As Date)
            Entity.FechaFactura = value
        End Set
    End Property
    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property
    Public Property FechaVencimiento() As Date
        Get
            Return Entity.FechaVencimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaVencimiento = value
        End Set
    End Property
    Public Property Subtotal() As Decimal
        Get
            Return Entity.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.SubTotal = value
        End Set
    End Property
    Public Property Iva() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Entity.Total = value
        End Set
    End Property

    Public Property Ieps() As Decimal
        Get
            Return Entity.Ieps.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    Public Property UUID() As String
        Get
            Return Entity.Uuid
        End Get
        Set(ByVal value As String)
            Entity.Uuid = value
        End Set
    End Property

    Public Property Anticipo() As Decimal
        Get
            Return Entity.Anticipo
        End Get
        Set(ByVal value As Decimal)
            Entity.Anticipo = value
        End Set
    End Property
    Public Property TasaIva() As Decimal
        Get
            Return Entity.TasaIva.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.TasaIva = value
        End Set
    End Property
    Public Property TasaISR() As Decimal
        Get
            Return Entity.TasaIsr.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.TasaIsr = value
        End Set
    End Property
    Public Property TasaRetIva() As Decimal
        Get
            Return Entity.TasaRetIva.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.TasaRetIva = value
        End Set
    End Property
    Public Property ImporteIsr() As Decimal
        Get
            Return Entity.ImporteIsr.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteIsr = value
        End Set
    End Property
    Public Property ImporteRetIva() As Decimal
        Get
            Return Entity.ImporteRetIva.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteRetIva = value
        End Set
    End Property

    Public Property Ivaflete() As Decimal?
        Get
            Return Entity.Ivaflete.Value
        End Get
        Set(ByVal value As Decimal?)
            Entity.Ivaflete = value
        End Set
    End Property



    Public Property Estatus() As EstatusFacturasEnum
        Get
            Return CType(Entity.Estatus, EstatusFacturasEnum)
        End Get
        Set(ByVal value As EstatusFacturasEnum)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property

    Public ReadOnly Property NomEstatus() As String
        Get
            If EstatusFacturasEnum.ABONADA = Me.Entity.Estatus Then
                Return "ABONADA"
            ElseIf EstatusFacturasEnum.VIGENTE = Me.Entity.Estatus Then
                Return "VIGENTE"
            ElseIf EstatusFacturasEnum.CANCELADA = Me.Entity.Estatus Then
                Return "CANCELADA"
            ElseIf EstatusFacturasEnum.PAGADA = Me.Entity.Estatus Then
                Return "PAGADA"
            End If

            Return "S/E"
        End Get

    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property
    Public Property IdMotivoCancelacion() As Integer
        Get
            Return Entity.IdMotivoCancelacion.Value
        End Get
        Set(ByVal value As Integer)
            Entity.IdMotivoCancelacion = value
        End Set
    End Property
    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancelacion.Value
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property
    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion.Value
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property
    Public Property FechaContabilizacion() As Date
        Get
            Return Entity.FechaContabilizacion.Value
        End Get
        Set(ByVal value As Date)
            Entity.FechaContabilizacion = value
        End Set
    End Property
    Public Property Saldo() As Decimal
        Get
            Return Entity.Saldo
        End Get
        Set(ByVal value As Decimal)
            Entity.Saldo = value
        End Set
    End Property
    Public Property Gastos() As Boolean
        Get
            Return Entity.Gastos.Value
        End Get
        Set(ByVal value As Boolean)
            Entity.Gastos = value
        End Set
    End Property
    Public Property Servicios() As Boolean
        Get
            Return Entity.Servicios.Value
        End Get
        Set(ByVal value As Boolean)
            Entity.Servicios = value
        End Set
    End Property
    Public ReadOnly Property Detalles() As FacturaDetalleCXPColeccion
        Get
            Dim det As New FacturaDetalleCXPColeccion(Entity.UsrCxpfacturasDet)
            Return det
        End Get
    End Property

    Public ReadOnly Property DetalleRecepciones() As FacturaDetalleCXPRecepcionesColeccion
        Get
            _detalle = New FacturaDetalleCXPRecepcionesColeccion
            _detalle.Obtener(NoFactura, IdProveedor)
            Return _detalle
        End Get
    End Property

    Public ReadOnly Property FechaPago() As Date
        Get
            Dim Pagos As New PagosProveedoresColeccionClass
            Dim Pago As New PagosProveedoresClass
            Pago = Pagos.Obtener(Me.Proveedor.Codigo, Me.NoFactura, Me.IdEmpresa)
            Return Pago.FechaPago
        End Get
    End Property
    Public ReadOnly Property NumeroPoliza() As String
        Get
            Dim Pagos As New PagosProveedoresColeccionClass
            Dim Pago As New PagosProveedoresClass
            Pago = Pagos.Obtener(Me.Proveedor.Codigo, Me.NoFactura, Me.IdEmpresa)
            Return Pago.Poliza.NumeroPoliza
        End Get
    End Property
    Public ReadOnly Property Abonado() As Decimal
        Get
            Return Me.Total - Me.Saldo
        End Get
    End Property
    Public Property IdProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdProveedor = value
        End Set
    End Property
    Public Property Concepto() As String
        Get
            Return Entity.Concepto
        End Get
        Set(ByVal value As String)
            Entity.Concepto = value
        End Set
    End Property
    Public Property Contabilizada() As Char
        Get
            Return Entity.Contabilizada(0)
        End Get
        Set(ByVal value As Char)
            Entity.Contabilizada = value
        End Set
    End Property
    Public Property IdPoliza() As Integer
        Get
            Return Entity.IdPoliza.Value
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoliza = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal EmpresaId As Integer, ByVal IdProveedor As Integer, ByVal NoFactura As String) As Boolean
        Try
            If Entity.FetchUsingPK(EmpresaId, IdProveedor, NoFactura) Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Entity.Estatus = CN.EstatusFacturasEnum.CANCELADA Then
                MsgBox("La factura ya fue Cancelada", MsgBoxStyle.Information, "Aviso")
            Else
                Entity.Estatus = CType(CN.EstatusFacturasEnum.CANCELADA, Short)
                Entity.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class

Public Class FacturasDetalleCXPClass
    Inherits ClassBase(Of EC.UsrCxpfacturasDetEntity)

    Sub New(ByVal E As EC.UsrCxpfacturasDetEntity)
        Me.Entity = E
    End Sub
    Sub New()
        Me.Importe = 0D
    End Sub
#Region "Propiedades"
    Public Property EmpresaID() As Integer
        Get
            Return Entity.EmpresaId
        End Get
        Set(ByVal value As Integer)
            Entity.EmpresaId = value
        End Set
    End Property
    Public Property IdProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdProveedor = value
        End Set
    End Property
    Public Property Factura() As FacturasCabCXPClass
        Get
            Dim Fac As New FacturasCabCXPClass(Entity.UsrCxpfacturasCab)
            Return Fac
        End Get
        Set(ByVal value As FacturasCabCXPClass)
            Entity.UsrCxpfacturasCab = value.ObtenerEntidad
        End Set
    End Property
    Public Property CuentaContable() As CuentaContableClass
        Get
            Dim CtaCont As New CuentaContableClass
            CtaCont.LeerEntidad(Entity.CuentaContable)
            Return CtaCont
        End Get
        Set(ByVal value As CuentaContableClass)
            Entity.CuentaContable = value.ObtenerEntidad
        End Set
    End Property
    Public Property CargoOAbono() As Char
        Get
            Return Entity.CarAbo(0)
        End Get
        Set(ByVal value As Char)
            Entity.CarAbo = value
        End Set
    End Property
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property
#End Region
End Class


Public Class FacturasDetalleCXPRecepcionesClass
    Inherits ClassBase(Of EC.UsrCxpfacturasDetRecepcionesEntity)
    Dim _detalle As FacturaDetalleCXPRecepcionesColeccion
    Dim _recep As CN.RecepcionOrdenCompraClass
    Sub New(ByVal E As EC.UsrCxpfacturasDetRecepcionesEntity)
        Me.Entity = E
    End Sub
    Sub New(ByVal codempresa As Integer, ByVal codproveedor As Integer, ByVal nofactura As String, ByVal idrecep As Integer)
        Entidad.FetchUsingPK(codempresa, codproveedor, nofactura, idrecep)
    End Sub
    Sub New()

    End Sub
#Region "Propiedades"
    Public Property EmpresaID() As Integer
        Get
            Return Entity.EmpresaId
        End Get
        Set(ByVal value As Integer)
            Entity.EmpresaId = value
        End Set
    End Property
    Public Property IdProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdProveedor = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As FacturaDetalleCXPRecepcionesColeccion
        Get
            _detalle = New FacturaDetalleCXPRecepcionesColeccion
            _detalle.Obtener(NumFactura, IdProveedor)
            Return _detalle
        End Get
    End Property

    Public ReadOnly Property RecepcionOC() As CN.RecepcionOrdenCompraClass
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep
        End Get
    End Property

    Public ReadOnly Property FechaRecepcion() As String
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.FechaRecepcion
        End Get
    End Property

    Public ReadOnly Property IVA() As Decimal
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.IVA
        End Get
    End Property

    Public ReadOnly Property IEPS() As Decimal
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.Ieps
        End Get
    End Property

    Public ReadOnly Property Pagada() As Boolean
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.Pagada
        End Get
    End Property

    Public ReadOnly Property SubTotal() As Decimal
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.SubTotal
        End Get
    End Property

    Public ReadOnly Property Total() As Decimal
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.Total
        End Get
    End Property

    Public ReadOnly Property Estatus() As String
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.Estatus
        End Get
    End Property

    Public ReadOnly Property NoRemision() As String
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.NoRemision
        End Get
    End Property

    Public ReadOnly Property FolioRecepcion() As String
        Get
            _recep = New RecepcionOrdenCompraClass(IdRecepOC)
            Return _recep.FolioRecepcionOrdenCompra
        End Get
    End Property
    'Public Property Factura() As FacturasCabCXPClass
    '    Get
    '        Dim Fac As New FacturasCabCXPClass(Entity.UsrCxpfacturasCab)
    '        Return Fac
    '    End Get
    '    Set(ByVal value As FacturasCabCXPClass)
    '        Entity.UsrCxpfacturasCab = value.ObtenerEntidad
    '    End Set
    'End Property

    Public Property NumFactura() As String
        Get
            Return Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Entity.NoFactura = value
        End Set
    End Property


    Public Property IdRecepOC() As Integer
        Get
            Return Entity.IdRecepcionOrdenCompra
        End Get
        Set(ByVal value As Integer)
            Entity.IdRecepcionOrdenCompra = value
        End Set
    End Property

   

#End Region
End Class

Public Class FacturaDetalleCXPRecepcionesColeccion

    Inherits ColleccionBase(Of EC.UsrCxpfacturasDetRecepcionesEntity, CC.UsrCxpfacturasDetRecepcionesCollection, CN.FacturasDetalleCXPRecepcionesClass)
    Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Sub New(ByVal C As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetRecepcionesCollection)
        coleccion = C
    End Sub
    Sub New()
        filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    End Sub
    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Overloads Function Obtener(ByVal Nofactura As String, Optional ByVal ProveedorId As Integer = Nothing) As Integer
        Try
            Me.Clear()
            coleccion = New CC.UsrCxpfacturasDetRecepcionesCollection
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasDetRecepcionesFields.NoFactura = Nofactura)
            If Not IsNothing(ProveedorId) And ProveedorId <> 0 Then
                filtro.Add(HC.UsrCxpfacturasDetRecepcionesFields.IdProveedor = ProveedorId)
            End If
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class

Public Class FacturaDetalleCXPColeccion

    Inherits ColleccionBase(Of EC.UsrCxpfacturasDetEntity, CC.UsrCxpfacturasDetCollection, FacturasDetalleCXPClass)
    Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Sub New(ByVal C As Integralab.ORM.CollectionClasses.UsrCxpfacturasDetCollection)
        coleccion = C
    End Sub
    Sub New()
        filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    End Sub
    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Overloads Function Obtener(ByVal Nofactura As String, Optional ByVal ProveedorId As Integer = Nothing) As Integer
        Try
            Me.Clear()
            coleccion = New CC.UsrCxpfacturasDetCollection
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasDetFields.NoFactura = Nofactura)
            If Not IsNothing(ProveedorId) And ProveedorId <> 0 Then
                filtro.Add(HC.UsrCxpfacturasDetFields.IdProveedor = ProveedorId)
            End If
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class

Public Class FacturaCabCXPColeccion
    Inherits ColleccionBase(Of EC.UsrCxpfacturasCabEntity, CC.UsrCxpfacturasCabCollection, FacturasCabCXPClass)
    Dim sort As New SortExpression(New SortClause(HC.UsrCxpfacturasCabFields.FechaFactura, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.UsrCxpfacturasCabFields.Gastos = True)
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Overloads Function Obtener(ByVal NoFactura As String, Optional ByVal IdProveedor As Integer = Nothing, Optional ByVal Gastos As Boolean = False, Optional ByVal IdTipoProveedor As Integer = 0) As Integer
        Try
            Me.Clear()
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection

            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If NoFactura <> "" Then
                filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = NoFactura)
            End If
            If IdTipoProveedor <> 0 And Not IsNothing(IdTipoProveedor) Then
                rel.Add(EC.ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor)
                rel.Add(EC.ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo)
                filtro.Add(Integralab.ORM.HelperClasses.ProveedorAvanzadoFields.CodigoTipoProveedor = IdTipoProveedor)
            End If
            'If IdProveedor <> 0 Then
            '    '  rel.Add(EC.UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor)

            '    '  
            '    filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = IdProveedor)
            'End If
            If Gastos Then
                filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.Gastos = True)
            End If
            filtro.Add(HC.UsrCxpfacturasCabFields.Gastos = True)
            coleccion.GetMulti(filtro, 0, sort)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Overloads Function Obtener(ByVal FechaInicio As Date, ByVal FechaFinal As Date) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.UsrCxpfacturasCabFields.FechaFactura, FechaInicio.ToString("dd/MM/yyyy"), FechaFinal.AddDays(1).ToString("dd/MM/yyyy")))
            filtro.Add(HC.UsrCxpfacturasCabFields.Gastos = True)
            coleccion.GetMulti(filtro)
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
    Public Overloads Function Obtener(ByVal FechaInicio As Date, ByVal FechaFinal As Date, ByVal IdTipoProveedor As Integer, Optional ByVal IdProveedor As Integer = Nothing) As Integer
        Try
            Me.Clear()
            Dim rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            rel.Add(EC.UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor)
            rel.Add(EC.ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo)
            rel.Add(EC.ProveedorAvanzadoEntity.Relations.TipoProveedorEntityUsingCodigoTipoProveedor)
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.UsrCxpfacturasCabFields.FechaFactura, FechaInicio.ToString("dd/MM/yyyy"), FechaFinal.AddDays(1).ToString("dd/MM/yyyy")))
            'If NoFactura <> "" Then
            '    filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.NoFactura = NoFactura)
            'End If
            If IdTipoProveedor <> 0 And Not IsNothing(IdTipoProveedor) Then
                filtro.Add(Integralab.ORM.HelperClasses.ProveedorAvanzadoFields.CodigoTipoProveedor = IdTipoProveedor)
            End If
            If Not IsNothing(IdProveedor) Then
                filtro.Add(Integralab.ORM.HelperClasses.UsrCxpfacturasCabFields.IdProveedor = IdProveedor)
            End If
            filtro.Add(HC.UsrCxpfacturasCabFields.Gastos = True)
            coleccion.GetMulti(filtro)
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
    ''' <summary>
    ''' Funcion que obtiene las facturas de un proveedor que estan contabilizadas
    ''' </summary>
    ''' <param name="IdProveedor"></param>
    ''' <param name="FechaContabilizacion"></param>
    ''' <param name="Contabilizada"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal EmpresaId As Integer, ByVal FechaContabilizacion As Date, ByVal Contabilizada As Char, Optional ByVal IdProveedor As Integer = -1) As Integer
        Try
            Me.Clear()
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            If IdProveedor > -1 Then
                Filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = IdProveedor)
            End If

            Filtro.Add(HC.UsrCxpfacturasCabFields.EmpresaId = EmpresaId And HC.UsrCxpfacturasCabFields.Contabilizada = Contabilizada)

            Filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.UsrCxpfacturasCabFields.FechaContabilizacion, FechaContabilizacion.ToShortDateString, FechaContabilizacion.AddDays(1).ToShortDateString))
            'Filtro.Add(HC.UsrCxpfacturasCabFields.IdPoliza = Nothing Or HC.UsrCxpfacturasCabFields.IdPoliza = "")
            coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            Return -1
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    ''' <summary>
    ''' Metodo para obtener Facturas Saldadas  y sin saldar
    ''' </summary>
    ''' <param name="IdProveedor"></param>
    ''' <param name="ConSaldo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal IdProveedor As Integer, ByVal FechaCorte As DateTime, Optional ByVal ConSaldo As Boolean = False) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'Dim Rel As New SD.LLBLGen.Pro.ORMSupportClasses.RelationCollection
            'Rel.Add(EC.UsrCxpfacturasCabEntity.Relations.UsrCxppagosProveedoresEntityUsingEmpresaIdIdProveedorNoFactura, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = IdProveedor)
            'filtro.Add(hc.UsrCxpfacturasCabFields.fecha
            If Not IsNothing(ConSaldo) Then
                If ConSaldo Then
                    filtro.Add(HC.UsrCxpfacturasCabFields.Saldo <> 0)
                    filtro.Add(HC.UsrCxpfacturasCabFields.Estatus = 2 Or HC.UsrCxpfacturasCabFields.Estatus = 3)
                    filtro.Add(HC.UsrCxpfacturasCabFields.FechaFactura <= FechaCorte.AddDays(1))
                    'coleccion.GetMulti(filtro, -1, New SC.SortExpression(New SC.SortClause(HC.UsrCxpfacturasCabFields.NoFactura, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
                Else
                    filtro.Add(HC.UsrCxpfacturasCabFields.Saldo = 0)
                    'filtro.Add(HC.UsrCxppagosProveedoresFields.FechaPago <= FechaCorte)
                    'coleccion.GetMulti(filtro, -1, New SC.SortExpression(New SC.SortClause(HC.UsrCxpfacturasCabFields.NoFactura, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Rel)
                End If
            End If
            coleccion.GetMulti(filtro, -1, New SC.SortExpression(New SC.SortClause(HC.UsrCxpfacturasCabFields.NoFactura, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Function Reporte(Optional ByVal TipoProveedorId As Integer = Nothing, Optional ByVal ProveedorId As Integer = Nothing, Optional ByVal FechaInicio As Date = Nothing, Optional ByVal FechaFinal As Date = Nothing) As Integer
        Try
            Me.Clear()
            Dim filtro As New SC.PredicateExpression
            Dim rel As New SC.RelationCollection
            rel.Add(EC.UsrCxpfacturasCabEntity.Relations.ProveedorEntityUsingIdProveedor, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            rel.Add(EC.ProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigo, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            If TipoProveedorId <> 0 Then
                filtro.Add(HC.ProveedorAvanzadoFields.CodigoTipoProveedor = TipoProveedorId)
            End If
            If ProveedorId <> 0 Then
                filtro.Add(HC.UsrCxpfacturasCabFields.IdProveedor = ProveedorId)
            End If
            If ProveedorId = 0 And TipoProveedorId = 0 Then
                filtro.Add(New SC.FieldBetweenPredicate(HC.UsrCxpfacturasCabFields.FechaFactura, FechaInicio.ToString("dd/MM/yyyy"), FechaFinal.AddDays(1).ToString("dd/MM/yyyy")))
            End If
            coleccion.GetMulti(filtro, rel)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function
End Class
