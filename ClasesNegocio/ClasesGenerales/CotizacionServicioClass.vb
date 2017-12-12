Imports system.Windows.Forms
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CotizacionServicioClass
    Inherits ClassBase(Of EC.CotizacionServicioEntity)

    Private _Detalle As CotizacionSolicDetCollecionClass
    Private _Sucursal As SucursalClass
    Private _UsuarioAlta As UsuarioClass

#Region "Propiedades"

    Public Property Folio() As String
        Get
            Return Me.Entity.Folio
        End Get
        Set(ByVal value As String)
            Me.Entity.Folio = value
        End Set
    End Property

    Public Property SucursalId() As Integer
        Get
            Return Me.Entity.SucursalId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.SucursalId = value
        End Set
    End Property

    Public Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing Then
                _Sucursal = New SucursalClass(Entity.Sucursal)
            End If

            Return _Sucursal
        End Get
        Set(ByVal value As SucursalClass)
            _Sucursal = value
            If value Is Nothing Then
                Entity.Sucursal = Nothing
            Else
                Entity.Sucursal = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Me.Entity.ProveedorId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.ProveedorId = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Me.Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Me.Entity.Observaciones = value
        End Set
    End Property

    Public ReadOnly Property FechaAlta() As Date
        Get
            Return Me.Entity.FechaAlta
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Me.Entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioAlta = value
        End Set
    End Property

    Public ReadOnly Property UsuarioAlta() As UsuarioClass
        Get
            If _UsuarioAlta Is Nothing OrElse _UsuarioAlta.Codigo <> Me.IdUsuarioAlta Then
                _UsuarioAlta = New UsuarioClass(Me.IdUsuarioAlta)
            End If
            Return _UsuarioAlta
        End Get
    End Property

    Public Property UsuarioCancelacion() As Integer
        Get
            Return Me.Entity.UsuarioCancelacion.Value
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioCancelacion = value
        End Set
    End Property

    Public Property MotivoCancelacionId() As Integer
        Get
            Return Me.Entity.MotivoCancelacionId.Value
        End Get
        Set(ByVal value As Integer)
            Me.Entity.MotivoCancelacionId = value
        End Set
    End Property

    Public Property FechaCancelacion() As Date
        Get
            Return Me.Entity.FechaCancelacion.Value
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property ObservacionesCancelacion() As String
        Get
            Return Me.Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Me.Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return CType(Me.Entity.Estatus, EstatusDatos)
        End Get
        Set(ByVal value As EstatusDatos)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public Property OrdenServicioGenerada() As Boolean
        Get
            Return Me.Entity.OrdenServicioGenerada.Value
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.OrdenServicioGenerada = value
        End Set
    End Property

    Public Property SubTotal() As Decimal
        Get
            Return Me.Entity.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.SubTotal = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return Me.Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Iva = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Me.Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Descuento = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return Me.Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Total = value
        End Set
    End Property

    Public Property TipoMonedaId() As Integer
        Get
            Return Me.Entity.TipoMonedaId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.TipoMonedaId = value
        End Set
    End Property

    Public Property FolioOrdenServicio() As String
        Get
            Return Me.Entity.FolioOrdenServicio
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioOrdenServicio = value
        End Set
    End Property

    Public Property Detalle() As CotizacionSolicDetCollecionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New CotizacionSolicDetCollecionClass
                _Detalle.RellenarMe(Entity.UsrCompCotizacionServicioDetalle)
            End If
            Return _Detalle
        End Get
        Set(ByVal value As CotizacionSolicDetCollecionClass)
            _Detalle = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Overloads Function Borrar() As Boolean
        Try
            Me.Entity.Estatus = EstatusEnum.INACTIVO
            Me.Entity.FechaCancelacion = Now
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            'If Me.Cotizacion.IsNew Then
            '    Dim Coleccion As New CC.CotizacionServicioCollection
            '    Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            '    Filtro.Add(HC.CotizacionServicioFields.SucursalId = SucursalId And HC.CotizacionServicioFields.ProveedorId = Me.IdProveedor)
            '    If Coleccion.GetDbCount(Filtro) > 0 Then
            '        MessageBox.Show("La Cotización de este Proveedor ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            'End If
            Trans.Add(Me.Entity)
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.CotizacionServicioEntity
    End Sub
    Sub New(ByVal Entidad As EC.CotizacionServicioEntity)
        Me.Entity = Entidad
    End Sub
    Sub New(ByVal codigo As Integer)
        Me.Entity = New EC.CotizacionServicioEntity(codigo.ToString())
    End Sub
#End Region

End Class

Public Class CotizacionServicioDetClass
    Inherits ClassBase(Of EC.CotizacionServicioDetalleEntity)

    Private _Servicio As SolicitudServiciosDetClass
    Private _Seleccion As Boolean = True

#Region "Propiedades"

    Public ReadOnly Property Servicio() As String
        Get
            If _Servicio Is Nothing Then
                _Servicio = New SolicitudServiciosDetClass(Me.Entity.SolicitudServiciosDetalle)
            End If
            Return _Servicio.Servicio
        End Get
    End Property

    Public ReadOnly Property FechaServicio() As Date
        Get
            If _Servicio Is Nothing Then
                _Servicio = New SolicitudServiciosDetClass(Me.Entity.SolicitudServiciosDetalle)
            End If
            Return _Servicio.FechaServicio
        End Get
    End Property

    Public ReadOnly Property Urgente() As Boolean
        Get
            If _Servicio Is Nothing Then
                _Servicio = New SolicitudServiciosDetClass(Me.Entity.SolicitudServiciosDetalle)
            End If
            Return _Servicio.Urgente
        End Get
    End Property

    Public Property FolioCotizacion() As String
        Get
            Return Me.Entity.FolioCotizacion
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioCotizacion = value
        End Set
    End Property

    Public Property FolioSolicitud() As String
        Get
            Return Me.Entity.FolioSolicitud
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioSolicitud = value
        End Set
    End Property

    Public Property indice() As Integer
        Get
            Return Me.Entity.Indice
        End Get
        Set(ByVal value As Integer)
            Me.Entity.Indice = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Me.Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Cantidad = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return CType(Me.Entity.Estatus, EstatusDatos)
        End Get
        Set(ByVal value As EstatusDatos)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return Me.Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Costo = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Me.Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Descuento = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            Return Me.Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Iva = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return Me.Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Total = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Overloads Function Borrar() As Boolean
        Try
            Me.Estatus = EstatusDatos.CANCELADO
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Me.Entity)
            Return Me.Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal FolioPres As String, ByVal FolioSol As String, ByVal Indice As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(FolioPres, FolioSol, Indice)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

#Region "Constructores"
    Sub New() 'ByVal ValorSeleccion As Boolean)
        Me.Entity = New EC.CotizacionServicioDetalleEntity
        '_Seleccion = ValorSeleccion
    End Sub
    Sub New(ByVal Entidad As EC.CotizacionServicioDetalleEntity)
        Me.Entity = Entidad
    End Sub
    Sub New(ByVal FolioPres As String, ByVal FolioSol As String, ByVal Indice As Integer)
        Me.Entity = New EC.CotizacionServicioDetalleEntity(FolioPres, FolioSol, Indice)
    End Sub
#End Region

End Class

Public Class CotizacionSolicCabCollecionClass
    Inherits ColleccionBase(Of EC.CotizacionServicioEntity, CC.CotizacionServicioCollection, CotizacionServicioClass)

    Public Function Existe(ByVal FolioCotiz As String) As Boolean
        Try
            For Each Col As CotizacionServicioClass In Me
                If Col.Folio = FolioCotiz Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return True
        End Try

    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As rptCompCotizacionServicios
        Dim Reportes As New rptCompCotizacionServicios
        Dim Ds As New DataSet
        Dim DsCab As New dsCotizacionOrdenServicios.CabeceroDataTable
        Dim DsDet As New dsCotizacionOrdenServicios.DetalleDataTable
        Dim IVA As Decimal
        For Each Cotizacion As CotizacionServicioClass In Me
            Dim CotizaRow As dsCotizacionOrdenServicios.CabeceroRow = DsCab.AddCabeceroRow(Cotizacion.Folio, Cotizacion.ObtenerEntidad.Sucursal.Plaza.Descripcion, _
            Cotizacion.Sucursal.Descripcion, Cotizacion.Estatus.ToString, (CDec(Cotizacion.SubTotal)).ToString("C2"), (CDec(Cotizacion.IVA)).ToString("C2"), _
            (CDec(Cotizacion.Descuento)).ToString("C2"), (CDec(Cotizacion.Total)).ToString("C2"), _
            Cotizacion.Observaciones, Cotizacion.ObtenerEntidad.Proveedor.RazonSocial)
            For Each DetCotiz As CotizacionServicioDetClass In Cotizacion.Detalle
                IVA = (DetCotiz.Cantidad * DetCotiz.Costo - DetCotiz.Descuento) * (DetCotiz.IVA / 100)
                DsDet.AddDetalleRow(CotizaRow, DetCotiz.FolioSolicitud, DetCotiz.ObtenerEntidad.SolicitudServiciosDetalle.Servicio, _
                DetCotiz.ObtenerEntidad.SolicitudServiciosDetalle.Cantidad.ToString(), (CDec(DetCotiz.Costo)).ToString("C2"), (CDec(DetCotiz.Descuento)).ToString("C2"), IVA.ToString("C2"), (CDec(DetCotiz.Total)).ToString("C2"))
            Next
        Next
        Ds.Tables.Add(DsCab)
        Ds.Tables.Add(DsDet)

        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, " Compras Generales\Cotizacion de Orden de Servicios")
        Return Reportes
    End Function

End Class

Public Class CotizacionSolicDetCollecionClass
    Inherits ColleccionBase(Of EC.CotizacionServicioDetalleEntity, CC.CotizacionServicioDetalleCollection, CotizacionServicioDetClass)

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum, ByVal Folio As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.CotizacionServicioDetalleFields.Estatus = fcCondicion)
            End If

            If Not Folio = "" Then
                filtro.Add(HC.CotizacionServicioDetalleFields.FolioCotizacion = Folio)
            End If

            coleccion.GetMulti(filtro)

            For Each enty As EC.CotizacionServicioDetalleEntity In coleccion
                Dim cotizaDet As New CotizacionServicioDetClass
                cotizaDet.LeerEntidad(enty)
                Me.Add(cotizaDet)
            Next

            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

#Region "Código de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.CotizacionServicioDetalleEntity In Coleccion
            Add(New CotizacionServicioDetClass(ente))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Collection As CC.CotizacionServicioDetalleCollection)
        Coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As CotizacionServicioDetClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.CotizacionServicioDetalleCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Public Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Integer
        Dim band As Boolean
        Try
            RellenarColeccion()
            Trans.Add(Me.Coleccion)
            For Each Enty As EC.CotizacionServicioDetalleEntity In Coleccion
                If Enty.IsDirty Then
                    band = True
                    Exit For
                End If
            Next
            If band Then
                Return Coleccion.SaveMulti
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function
    
#End Region
End Class