Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class CotizacionCompraClass
    Inherits ClassBase(Of EC.McomCotizacionCompraEntity)

#Region "Miembros"

    Private _Sucursal As SucursalClass
    Private _UsuarioAlta As UsuarioClass
    Private _UsuarioCancelacion As UsuarioClass
    Private _Detalle As CotizacionCompraProveedorCollectionClass

    Public Enum EstatusCotizacion As Byte
        CANCELADO
        VIGENTE
        PARCIALMENTE_EMITIDO
        EMITIDO
    End Enum

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdCotizacion As Integer)
        Entidad = New EC.McomCotizacionCompraEntity(IdCotizacion)
    End Sub

    Sub New(ByVal Entidad As EC.McomCotizacionCompraEntity)
        Me.Entidad = Entidad
    End Sub

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de la cotización
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FolioCotizacion() As String
        Get
            Return Entity.FolioCotizacion
        End Get
    End Property

    Public ReadOnly Property IdCotizacion() As Integer
        Get
            Return Entity.IdCotizacion
        End Get
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Entidad.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Entidad.IdSucursal = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la sucursal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing OrElse _Sucursal.Codigo <> Me.IdSucursal Then
                _Sucursal = New SucursalClass(Entidad.Sucursal)
            End If
            Return _Sucursal
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entidad.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entidad.IdUsuarioAlta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario de alta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Usuario de Alta")> _
    Public ReadOnly Property UsuarioAlta() As UsuarioClass
        Get
            If _UsuarioAlta Is Nothing OrElse _UsuarioAlta.Codigo <> Me.IdUsuarioAlta Then
                _UsuarioAlta = New UsuarioClass(Entidad.IdUsuarioAlta)
            End If
            Return _UsuarioAlta
        End Get
    End Property

    Public Property IdUsuarioCancelacion() As Nullable(Of Integer)
        Get
            Return Entidad.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.IdUsuarioCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Usuario de Cancelación")> _
    Public ReadOnly Property UsuarioCancelacion() As UsuarioClass
        Get
            If _UsuarioCancelacion Is Nothing OrElse Me.IdUsuarioCancelacion.HasValue AndAlso _UsuarioCancelacion.Codigo <> Me.IdUsuarioCancelacion.Value Then
                _UsuarioCancelacion = New UsuarioClass(Entidad.IdUsuarioCancelacion.Value)
            End If
            Return _UsuarioCancelacion
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Observaciones() As String
        Get
            Return Entidad.Observaciones
        End Get
        Set(ByVal value As String)
            Entidad.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Observaciones de Cancelación")> _
    Public Property ObservacionesCancelacion() As String
        Get
            Return Entidad.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entidad.ObservacionesCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Cancelación")> _
    Public ReadOnly Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entidad.FechaCancelacion
        End Get
    End Property

    Public ReadOnly Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Estatus() As EstatusCotizacion
        Get
            Return CType(Entidad.Estatus, EstatusCotizacion)
        End Get
        Set(ByVal value As EstatusCotizacion)
            Entidad.Estatus = CType(value, Byte)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el detalle de la cotizacion de compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Detalle() As CotizacionCompraProveedorCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New CotizacionCompraProveedorCollectionClass(Me, Entidad.McomCotizacionCompraProveedor)
            End If
            Return _Detalle
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Function Borrar() As Boolean
        Try
            Me.Entidad.Estatus = EstatusEnum.INACTIVO
            Me.Entidad.FechaCancelacion = Now
            Return Me.Entidad.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        'Try
        '    If Entidad.IsNew Then
        '        Dim col As New CC.McomCotizacionCompraCollection

        '        If col.GetDbCount(HC.McomCotizacionCompraFields.IdProveedor = Proveedor.Codigo And HC.CotizacionCompraFields.Estatus = EstatusEnum.ACTIVO) > 0 Then
        '            MsgBox("Ya hay una cotización de compra con este proveedor", MsgBoxStyle.Exclamation, "Aviso")
        '            Return False
        '        End If
        '        Trans.Add(Me.Entidad)
        '        Me.Entidad.Save()

        '        Dim colDet As CC.McomCotizacionCompraProveedorDetalleCollection = Detalle.ObtenerColeccion

        '        Trans.Add(colDet)

        '        If colDet.SaveMulti = 0 Then
        '            MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
        '            Trans.Rollback()
        '            Return False
        '        Else
        '            Trans.Commit()
        '            Return True
        '        End If
        '    Else
        '        Return False
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '    Trans.Rollback()
        '    Return False
        'End Try
    End Function

    Public Function Obtener(ByVal IdCotizacion As Integer) As Boolean
        Try
            Return Entidad.FetchUsingPK(IdCotizacion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.McomCotizacionCompraEntity
        Return Entidad
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.McomCotizacionCompraEntity)
        Entidad = Entidad
    End Sub
#End Region

End Class

Public Class CotizacionCompraCollectionClass
    Inherits ColleccionBase(Of EC.McomCotizacionCompraEntity, CC.McomCotizacionCompraCollection, CotizacionCompraClass)

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As rptCompCotizacion
        Dim report As New rptCompCotizacion
        'Dim Ds As New DataSet
        'Dim TablaCab As New dsCotizacionComp.CabeceroDataTable
        'Dim TablaDet As New dsCotizacionComp.DetalleDataTable
        'For Each cotiz As CotizacionCompraClass In Me
        '    Dim Rowcab As dsCotizacionComp.CabeceroRow = TablaCab.AddCabeceroRow(cotiz.FolioCotizacion, cotiz.Sucursal.Plaza.Descripcion, cotiz.Sucursal.Descripcion, cotiz.Proveedor.RazonSocial, _
        '     cotiz.FechaCotizacion, cotiz.Estatus.ToString, "", cotiz.SubTotal.ToString("C2"), cotiz.IVA.ToString("C2"), cotiz.Total.ToString("C2"), cotiz.Descuento.ToString("C2"), _
        '     cotiz.Proveedor.Codigo, cotiz.Sucursal.Plaza.Codigo, cotiz.Sucursal.Codigo)
        '    For Each det As CotizacionCompraDetalleClass In cotiz.Detalle
        '        TablaDet.AddDetalleRow(Rowcab, det.IdProducto, det.Producto.Descripcion, det.Cantidad.ToString("N3"), det.Unidad, det.Precio.ToString("C2"), det.Descuento.ToString("C2"), det.Importe.ToString("C2"))
        '    Next
        'Next
        'Ds.Tables.Add(TablaCab)
        'Ds.Tables.Add(TablaDet)
        'report.SetDataSource(Ds)
        'report.SetParameterValue(0, Empresa)
        'report.SetParameterValue(1, Usuario)
        'report.SetParameterValue(2, "Compras Generales/Cotización de Compra")
        Return report
    End Function

End Class