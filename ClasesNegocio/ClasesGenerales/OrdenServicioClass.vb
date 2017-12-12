Imports System.Windows.Forms
Imports ORM = sd.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

Public Class OrdenServicioClass
    Implements IEntidad

    Dim OrdenServicio As EC.OrdenServicioEntity
    Dim _Detalle As OrdenServicioDetCollectionClass
    Dim _CotizCab As CotizacionSolicCabCollecionClass
    Dim _Sucursal As SucursalClass
    Dim _proveedor As ProveedorClass
    Dim _moneda As TipoMonedaClass

#Region "Propiedades"

    Public ReadOnly Property Plaza() As PlazaClass
        Get
            Return Me.Sucursal.Plaza
        End Get
    End Property

    Public Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing Then
                _Sucursal = New SucursalClass(Me.OrdenServicio.Sucursal)
            End If

            Return _Sucursal
        End Get
        Set(ByVal value As SucursalClass)
            _Sucursal = value
            If value Is Nothing Then
                OrdenServicio.Sucursal = Nothing
            Else
                OrdenServicio.Sucursal = value.ObtenerEntidad
            End If
        End Set
    End Property
    Public Property CotizacionesModificar() As CotizacionSolicCabCollecionClass
        Get
            If _CotizCab Is Nothing Then _CotizCab = New CotizacionSolicCabCollecionClass

            Return _CotizCab
        End Get
        Set(ByVal value As CotizacionSolicCabCollecionClass)
            _CotizCab = value
        End Set
    End Property
    Public Property Folio() As String
        Get
            Return Me.OrdenServicio.Folio
        End Get
        Set(ByVal value As String)
            Me.OrdenServicio.Folio = value
        End Set
    End Property
    Public Property SucursalId() As Integer
        Get
            Return Me.OrdenServicio.SucursalId
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.SucursalId = value
        End Set
    End Property
    Public Property ProveedorId() As Integer
        Get
            Return Me.OrdenServicio.ProveedorId
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.ProveedorId = value
        End Set
    End Property
    Public ReadOnly Property Proveedor() As String
        Get
            If _proveedor Is Nothing Then
                _proveedor = New ProveedorClass(Me.OrdenServicio.Proveedor)
            End If
            Return _proveedor.RazonSocial
        End Get
    End Property

    Public Property Observaciones() As String
        Get
            Return Me.OrdenServicio.Observaciones
        End Get
        Set(ByVal value As String)
            Me.OrdenServicio.Observaciones = value
        End Set
    End Property
    Public Property Monedaid() As Integer
        Get
            Return Me.OrdenServicio.MonedaId
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.MonedaId = value
        End Set
    End Property
    Public ReadOnly Property Moneda() As String
        Get
            If _moneda Is Nothing Then
                _moneda = New TipoMonedaClass(Me.OrdenServicio.TipoMoneda)
            End If
            Return _moneda.Descripcion
        End Get
    End Property
    Public Property TipoCambio() As Decimal
        Get
            Return Me.OrdenServicio.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServicio.TipoCambio = value
        End Set
    End Property
    Public Property FolioFactura() As String
        Get
            Return Me.OrdenServicio.FolioFactura
        End Get
        Set(ByVal value As String)
            Me.OrdenServicio.FolioFactura = value
        End Set
    End Property
    <System.ComponentModel.DisplayName("Días Crédito")> _
    Public Property DiasCredito() As Integer
        Get
            Return Me.OrdenServicio.DiasCredito
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.DiasCredito = value
        End Set
    End Property
    <System.ComponentModel.DisplayName("Fecha Alta")> _
    Public ReadOnly Property FechaAlta() As Date
        Get
            Return Me.OrdenServicio.FechaAlta
        End Get
        'Set(ByVal value As Date)
        '    Me.OrdenServicio.FechaAlta = value
        'End Set
    End Property
    Public Property UsuarioAltaId() As Integer
        Get
            Return Me.OrdenServicio.UsuarioAltaId
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.UsuarioAltaId = value
        End Set
    End Property
    Public Property FechaCancelacion() As Date
        Get
            Return CDate(Me.OrdenServicio.FechaCancelacion)
        End Get
        Set(ByVal value As Date)
            Me.OrdenServicio.FechaCancelacion = value
        End Set
    End Property
    Public Property UsuarioCancelacionId() As Integer
        Get
            Return CInt(Me.OrdenServicio.UsuarioCancelacionId)
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.UsuarioCancelacionId = value
        End Set
    End Property
    Public Property ObservacionesCancelacion() As String
        Get
            Return Me.OrdenServicio.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Me.OrdenServicio.ObservacionesCancelacion = value
        End Set
    End Property
    'Public Property Importe() As Decimal
    '    Get
    '        Return Me.OrdenServicio.Importe
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Me.OrdenServicio.Importe = value
    '    End Set
    'End Property
    Public Property Descuento() As Decimal
        Get
            Return Me.OrdenServicio.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServicio.Descuento = value
        End Set
    End Property
    Public Property SubTotal() As Decimal
        Get
            Return Me.OrdenServicio.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServicio.SubTotal = value
        End Set
    End Property
    Public Property IVA() As Decimal
        Get
            Return Me.OrdenServicio.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServicio.Iva = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return Me.OrdenServicio.Total
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServicio.Total = value
        End Set
    End Property
    Public Property MotivoCancelacionId() As Integer
        Get
            Return CInt(Me.OrdenServicio.MotivoCancelacionId)
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.MotivoCancelacionId = value
        End Set
    End Property
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Me.OrdenServicio.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Me.OrdenServicio.Estatus = value
        End Set
    End Property
    Public Property Autorizada() As Boolean
        Get
            Return Me.OrdenServicio.Autorizada
        End Get
        Set(ByVal value As Boolean)
            Me.OrdenServicio.Autorizada = value
        End Set
    End Property
    Public Property Recibida() As Byte
        Get
            Return CByte(Me.OrdenServicio.Recibida)
        End Get
        Set(ByVal value As Byte)
            Me.OrdenServicio.Recibida = value
        End Set
    End Property
    Public Property FechaAutorizacion() As Date
        Get
            Return CDate(Me.OrdenServicio.FechaAutorizacion)
        End Get
        Set(ByVal value As Date)
            Me.OrdenServicio.FechaAutorizacion = value
        End Set
    End Property
    Public Property FechaRecepcion() As Date
        Get
            Return CDate(Me.OrdenServicio.FechaRecepcion)
        End Get
        Set(ByVal value As Date)
            Me.OrdenServicio.FechaRecepcion = value
        End Set
    End Property
    Public Property UsuarioRecepOrdenId() As Integer
        Get
            Return CInt(Me.OrdenServicio.UsuarioRecepOrdenId)
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.UsuarioRecepOrdenId = value
        End Set
    End Property
    Public Property UsuarioCancelaRecepOrdenId() As Integer
        Get
            Return CInt(Me.OrdenServicio.UsuarioCancelaRecepOrdenId)
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServicio.UsuarioCancelaRecepOrdenId = value
        End Set
    End Property

    Public Property Detalle() As OrdenServicioDetCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New OrdenServicioDetCollectionClass
                _Detalle.RellenarMe(Me.OrdenServicio.UsrCompOrdenServicioDetalle)
            End If
            Return _Detalle
        End Get
        Set(ByVal value As OrdenServicioDetCollectionClass)
            _Detalle = value
        End Set
    End Property
    Public ReadOnly Property Cantidad() As Decimal
        Get
            Dim Cant As Decimal = 0
            For Each det As OrdenServicioDetClass In Detalle
                Cant += det.CantidadOrdenar
            Next
            Return Cant
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Dim Trans As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            Dim Cotiz As New EC.CotizacionServicioEntity
            Cotiz.FolioOrdenServicio = ""
            Dim col As New CC.CotizacionServicioCollection
            Trans.Add(col)
            col.UpdateMulti(Cotiz, HC.CotizacionServicioFields.FolioOrdenServicio = Me.Folio)

            Me.OrdenServicio.Estatus = EstatusEnum.INACTIVO
            Me.OrdenServicio.FechaCancelacion = Now
            Trans.Add(Me.OrdenServicio)
            Me.OrdenServicio.Save(True)
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try
    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Try
            Return Me.OrdenServicio.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function Guardar2() As Boolean 'ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Dim Trans As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            If Me.OrdenServicio.IsNew Then
                If Me.Detalle.Count = 0 Then
                    MsgBox("Debe agregar productos a la orden de compra", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Trans.Add(Me.OrdenServicio)
                'Se guarda el cabecero
                SPA.UspMcompFolioOrdenServIns(Me.OrdenServicio.Folio, Trans)
                If Not Me.OrdenServicio.Save() Then
                    Trans.Rollback()
                    Return False
                End If
                Dim ColDet As CC.OrdenServicioDetalleCollection = Me.Detalle.ObtenerColeccion
                Trans.Add(ColDet)
                For Each Entidad As EC.OrdenServicioDetalleEntity In ColDet
                    If Not Entidad.Save Then
                        Trans.Commit()
                        Return False
                    End If
                Next
                'If Not ColDet.SaveMulti Then
                '    Trans.Rollback()
                '    Return False
                'End If

                If Me.CotizacionesModificar.Count = 0 Then
                    Trans.Commit()
                    Return True
                Else
                    For Each Cotiz As CotizacionServicioClass In Me.CotizacionesModificar
                        Cotiz.FolioOrdenServicio = Me.OrdenServicio.Folio
                    Next
                    Dim col As CC.CotizacionServicioCollection = Me.CotizacionesModificar.ObtenerColeccion
                    Trans.Add(col)
                    If col.SaveMulti = 0 Then
                        Trans.Rollback()
                        Return False
                    Else
                        Trans.Commit()
                        Return True
                    End If
                End If
                Return True
            End If

        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Me.OrdenServicio.FetchUsingPK(Folio)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function ObtenerEntidad() As EC.OrdenServicioEntity
        Return Me.OrdenServicio
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.OrdenServicioEntity)
        Me.OrdenServicio = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Me.OrdenServicio = New EC.OrdenServicioEntity
    End Sub
    Sub New(ByVal Entidad As EC.OrdenServicioEntity)
        Me.OrdenServicio = Entidad
    End Sub
    Sub New(ByVal Folio As String)
        Me.OrdenServicio = New EC.OrdenServicioEntity(Folio)
    End Sub
#End Region
End Class

Public Class OrdenServicioDetClass
    Implements IEntidad
    Dim _orden As OrdenServicioClass
    Dim _Servicio As SolicitudServiciosDetClass
    Dim _ServicioDet As SolicitudServiciosDetClass
    'Dim _cotizacion As CotizacionServicioDetClass
    Dim OrdenServDet As New EC.OrdenServicioDetalleEntity

#Region "Propiedades"

    Public ReadOnly Property Servicio() As String
        Get
            If _Servicio Is Nothing Then
                _Servicio = New SolicitudServiciosDetClass(Me.OrdenServDet.SolicitudServiciosDetalle)
            End If
            Return _Servicio.Servicio
        End Get
    End Property

    Public Property ServicioDet() As SolicitudServiciosDetClass
        Get
            If _ServicioDet Is Nothing Then
                _ServicioDet = New SolicitudServiciosDetClass(Me.OrdenServDet.SolicitudServiciosDetalle)
            End If
            Return _ServicioDet
        End Get

        Set(ByVal value As SolicitudServiciosDetClass)
            _ServicioDet = value
            If value Is Nothing Then
                Me.OrdenServDet.SolicitudServiciosDetalle = Nothing
            Else
                Me.OrdenServDet.SolicitudServiciosDetalle = value.ObtenerEntidad
            End If
        End Set
    End Property

    'Public ReadOnly Property FolioCotizacion() As String
    '    Get
    '        If _cotizacion Is Nothing Then
    '            _cotizacion = New CotizacionServicioDetClass(Me.OrdenServDet.SolicitudServiciosDetalle.CotizacionServicioDetalle)
    '        End If
    '        Return _cotizacion.FolioCotizacion
    '    End Get
    'End Property

    Public Property Folio() As String
        Get
            Return Me.OrdenServDet.Folio
        End Get
        Set(ByVal value As String)
            Me.OrdenServDet.Folio = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return Me.OrdenServDet.iva
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.Iva = value
        End Set
    End Property

    Public Property FolioDetSolic() As String
        Get
            Return Me.OrdenServDet.FolioDetalleSolicitud
        End Get
        Set(ByVal value As String)
            Me.OrdenServDet.FolioDetalleSolicitud = value
        End Set
    End Property

    Public Property Indice() As Integer
        Get
            Return Me.OrdenServDet.Indice
        End Get
        Set(ByVal value As Integer)
            Me.OrdenServDet.Indice = value
        End Set
    End Property

    Public Property CantidadSolic() As Decimal
        Get
            Return Me.OrdenServDet.CantidadSolicitada
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.CantidadSolicitada = value
        End Set
    End Property

    Public Property CantidadOrdenar() As Decimal
        Get
            Return Me.OrdenServDet.CantidadOrdenar
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.CantidadOrdenar = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Me.OrdenServDet.Precio
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.Precio = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Me.OrdenServDet.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.Descuento = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Me.OrdenServDet.Importe
        End Get
        Set(ByVal value As Decimal)
            Me.OrdenServDet.Importe = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Me.OrdenServDet.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Me.OrdenServDet.Estatus = value
        End Set
    End Property

    Public Property Orden() As OrdenServicioClass
        Get
            If _orden Is Nothing Then
                _orden = New OrdenServicioClass(Me.OrdenServDet.UsrCompOrdenServicio)
            End If
            Return _orden
        End Get
        Set(ByVal value As OrdenServicioClass)
            _orden = value
            If value Is Nothing Then
                Me.OrdenServDet.UsrCompOrdenServicio = Nothing
            Else
                Me.OrdenServDet.UsrCompOrdenServicio = value.ObtenerEntidad
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar() As Boolean Implements IEntidad.Guardar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Obtener(ByVal Folio As String, ByVal FolioDet As String, ByVal Indice As Integer) As Boolean
        Try
            Return Me.OrdenServDet.FetchUsingPK(Folio, FolioDet, Indice)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function ObtenerEntidad() As EC.OrdenServicioDetalleEntity
        Return Me.OrdenServDet
    End Function
    Public Sub LeerEntidad(ByVal Entidad As EC.OrdenServicioDetalleEntity)
        Me.OrdenServDet = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Me.OrdenServDet = New EC.OrdenServicioDetalleEntity
    End Sub
    Sub New(ByVal Entidad As EC.OrdenServicioDetalleEntity)
        Me.OrdenServDet = Entidad
    End Sub
    Sub New(ByVal Folio As String, ByVal FolioDetSol As String, ByVal indice As Integer)
        Me.OrdenServDet = New EC.OrdenServicioDetalleEntity(Folio, FolioDetSol, indice)
    End Sub
#End Region

    
End Class

Public Class OrdenServicioCollectionClass
    Inherits CollectionClass(Of OrdenServicioClass)
    Private Coleccion As New CC.OrdenServicioCollection
    Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Function Obtener() As Integer
        Try
            Coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    'Public Function Obtener(ByVal fcCondicion As CondicionEnum)
    '    Try
    '        Me.ClearItems()

    '        If Not fcCondicion = CondicionEnum.TODOS Then
    '            Coleccion.GetMulti(HC.OrdenServicioFields.Estatus = fcCondicion)
    '        Else
    '            Coleccion.GetMulti(Nothing)
    '        End If

    '        For Each enty As EC.OrdenServicioEntity In Coleccion
    '            Dim Orden As New OrdenServicioClass
    '            Orden.LeerEntidad(enty)
    '            Me.Add(Orden)
    '        Next

    '        Return Count
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '        Return -1
    '    End Try
    'End Function
    Public Function Obtener(ByVal FcCondicion As CondicionEnum, Optional ByVal Plaza As PlazaClass = Nothing, Optional ByVal Sucursal As SucursalClass = Nothing, Optional ByVal Proveedor As ProveedorClass = Nothing, Optional ByVal Autorizadas As CondicionAsignadaEnum = CondicionAsignadaEnum.TODOS, Optional ByVal Recibidas As CondicionOrdenRecibida = CondicionOrdenRecibida.TODOS) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Autorizadas = CondicionAsignadaEnum.TODOS Then
                Filtro.Add(HC.OrdenServicioFields.Autorizada = Autorizadas)
            End If

            If Not Recibidas = CondicionOrdenRecibida.TODOS Then
                Filtro.Add(HC.OrdenServicioFields.Recibida = Recibidas)
            End If

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.OrdenServicioFields.Estatus = FcCondicion)
            End If

            If Not Proveedor Is Nothing Then
                Filtro.Add(HC.OrdenServicioFields.ProveedorId = Proveedor.Codigo)
            End If
            Dim relacion As OC.RelationCollection = Nothing
            If Not Plaza Is Nothing Then
                If Sucursal Is Nothing Then
                    relacion = New OC.RelationCollection
                    relacion.Add(EC.OrdenServicioEntity.Relations.SucursalEntityUsingSucursalId)
                    Filtro.Add(HC.SucursalFields.CodigoPlaza = Plaza.Codigo)

                Else
                    Filtro.Add(HC.OrdenServicioFields.SucursalId = Sucursal.Codigo)
                End If
            End If

            If relacion Is Nothing Then
                Coleccion.GetMulti(Filtro)
            Else
                Coleccion.GetMulti(Filtro, relacion)
            End If
            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
    Public Function Obtener(ByVal IdProveedor As Integer, Optional ByVal NoFactura As String = "") As Integer
        Try
            Me.Clear()
            Coleccion = New CC.OrdenServicioCollection
            Filtro = New ORM.PredicateExpression
            'Dim rel As New ORM.RelationCollection
            'rel.Add(EC.OrdenServicioEntity.Relations.OrdenCompraEntityUsingOrdenCompraFolio, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            Filtro.Add(HC.OrdenServicioFields.ProveedorId = IdProveedor)

            If Not NoFactura = "" Then
                Filtro.Add(HC.OrdenServicioFields.FolioFactura = NoFactura)
            End If
            'Else
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = False)
            'End If
            Coleccion.GetMulti(Filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

#Region "Codigo Relleno"

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.OrdenServicioEntity In Coleccion
            Add(New OrdenServicioClass(ente))
        Next
    End Sub
    Public Sub RellenarMe(ByVal Collection As CC.OrdenServicioCollection)
        Coleccion = Collection
        Rellenar()
    End Sub
    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As OrdenServicioClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub
    Public Function ObtenerColeccion() As CC.OrdenServicioCollection
        RellenarColeccion()
        Return Coleccion
    End Function
    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As rptCompOrdenServicio
        Dim Reportes As New rptCompOrdenServicio
        Dim Ds As New DataSet
        Dim DsCab As New dsOrdenServicios.CabeceroDataTable
        Dim DsDet As New dsOrdenServicios.DetalleDataTable
        Dim IVA As Integer = 0
        For Each Orden As OrdenServicioClass In Me
            Dim OrdenRow As dsOrdenServicios.CabeceroRow = DsCab.AddCabeceroRow(Orden.Folio, Orden.ObtenerEntidad.Sucursal.Plaza.Descripcion, _
            Orden.Sucursal.Descripcion, Orden.ObtenerEntidad.Proveedor.RazonSocial, Orden.FechaAlta, (CDec(Orden.SubTotal)).ToString("C2"), (CDec(Orden.Descuento)).ToString("C2"), (CDec(Orden.IVA)).ToString("C2"), _
             (CDec(Orden.Total)).ToString("C2"), Orden.Estatus.ToString, Orden.Observaciones)
            For Each DetOrden As OrdenServicioDetClass In Orden.Detalle
                DsDet.AddDetalleRow(OrdenRow, DetOrden.ObtenerEntidad.SolicitudServiciosDetalle.Servicio, CStr(DetOrden.CantidadSolic), _
                CStr(DetOrden.CantidadOrdenar), (CDec(DetOrden.Precio)).ToString("C2"), (CDec(DetOrden.Descuento)).ToString("C2"), (CDec(DetOrden.Importe)).ToString("C2"))
            Next
        Next
        Ds.Tables.Add(DsCab)
        Ds.Tables.Add(DsDet)

        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, " Compras Generales\Orden de Servicios")
        Return Reportes
    End Function
#End Region
End Class

Public Class OrdenServicioDetCollectionClass
    Inherits CollectionClass(Of OrdenServicioDetClass)
    Private Coleccion As New CC.OrdenServicioDetalleCollection
    Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Function Obtener() As Integer
        Try
            Coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            If Not fcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(HC.OrdenServicioFields.Estatus = fcCondicion)
            Else
                Coleccion.GetMulti(Nothing)
            End If

            For Each enty As EC.OrdenServicioDetalleEntity In Coleccion
                Dim Orden As New OrdenServicioDetClass
                Orden.LeerEntidad(enty)
                Me.Add(Orden)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function
#Region "Codigo Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.OrdenServicioDetalleEntity In Coleccion
            Add(New OrdenServicioDetClass(ente))
        Next
    End Sub
    Public Sub RellenarMe(ByVal Collection As CC.OrdenServicioDetalleCollection)
        Coleccion = Collection
        Rellenar()
    End Sub
    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As OrdenServicioDetClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub
    Public Function ObtenerColeccion() As CC.OrdenServicioDetalleCollection
        RellenarColeccion()
        Return Coleccion
    End Function
#End Region
End Class