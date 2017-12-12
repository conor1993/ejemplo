Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

Public Class PresupuestoCompraClass
    Inherits ClassBase(Of EC.PresupuestoEntity)

#Region "Miembros"
    Private _Sucursal As SucursalClass
    Private _TipoPresupuesto As TipoPresupuestoClass
    Private _MotivoCancelacion As MotivoCancelacionClass
    Private _UsuarioAlta As UsuarioClass
    Private _UsuarioCan As UsuarioClass
    Private _Detalle As PresupuestoCompraDetalleCollectionClass
    Private _Cotizaciones As CotizacionCompraCollectionClass
    Public _ProductosSolicitados As SolicitudProductoDetalleCollectionClass
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio del presupuesto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Folio() As String
        Get
            Return Entidad.Folio
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la descripción del presupuesto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entidad.Descripcion
        End Get
        Set(ByVal value As String)
            Entidad.Descripcion = value.Trim
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la observaciones 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Observaciones() As String
        Get
            Return Entidad.Obserbaciones
        End Get
        Set(ByVal value As String)
            Entidad.Obserbaciones = value.Trim
        End Set
    End Property

    Public Property IdTipoPresupuesto() As Integer
        Get
            Return Entidad.TipoPresupuestoId
        End Get
        Set(ByVal value As Integer)
            Entidad.TipoPresupuestoId = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el tipo de presupuesto del presupuesto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Tipo de Presupuesto")> _
    Public ReadOnly Property TipoPresupuesto() As TipoPresupuestoClass
        Get
            If _TipoPresupuesto Is Nothing OrElse _TipoPresupuesto.Codigo <> Me.IdTipoPresupuesto Then
                _TipoPresupuesto = New TipoPresupuestoClass(Entidad.TipoPresupuesto)
            End If
            Return _TipoPresupuesto
        End Get
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Entidad.SucursalId
        End Get
        Set(ByVal value As Integer)
            Entidad.SucursalId = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la sucursal donde se realiza el presupuesto
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

    Public Property IdMotivoCancelacion() As Integer
        Get
            Return Entidad.MotivoCancelacionId
        End Get
        Set(ByVal value As Integer)
            Entidad.MotivoCancelacionId = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el motivo de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Motivo de Cancelación")> _
    Public ReadOnly Property MotivoCancelacion() As MotivoCancelacionClass
        Get
            If _MotivoCancelacion Is Nothing OrElse _MotivoCancelacion.Codigo <> Me.IdMotivoCancelacion Then
                _MotivoCancelacion = New MotivoCancelacionClass(Entidad.MotivoCancelacion)
            End If
            Return _MotivoCancelacion
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entidad.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entidad.UsuarioAlta = value
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
                _UsuarioAlta = New UsuarioClass(Entidad.UsuarioAlta)
            End If
            Return _UsuarioAlta
        End Get
    End Property

    Public Property IdUsuarioCancelacion() As Nullable(Of Integer)
        Get
            Return Entidad.UsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.UsuarioCancelacion = value
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
            If _UsuarioCan Is Nothing OrElse Me.IdUsuarioCancelacion.HasValue AndAlso _UsuarioCan.Codigo <> Me.IdUsuarioCancelacion.Value Then
                _UsuarioCan = New UsuarioClass(Entidad.UsuarioCancelacion)
            End If
            Return _UsuarioCan
        End Get
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
            Return Entidad.ObserbacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entidad.ObserbacionesCancelacion = value.Trim
        End Set
    End Property

    ''' <summary>
    ''' Obtiene oe stablece el estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Estatus() As EstatusEnum
        Get
            Return CType(Entidad.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entidad.Estatus = CType(value, Short)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la fecha de alta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public ReadOnly Property FechaAlta() As Date
        Get
            Return Entidad.FechaAlta
        End Get
    End Property

    ''' <summary>
    ''' Obtiene la fecha de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Cancelación")> _
    Public ReadOnly Property FechaCacelacion() As Nullable(Of Date)
        Get
            Return Entidad.FechaCancelacion
        End Get
    End Property

    Public Property OrdenCompraGenerada() As AsignadaEnum
        Get
            If Entidad.OrdenCompraGenerada.HasValue AndAlso Entidad.OrdenCompraGenerada.Value Then
                Return AsignadaEnum.SI
            Else
                Return AsignadaEnum.NO
            End If
        End Get
        Set(ByVal value As AsignadaEnum)
            Entidad.OrdenCompraGenerada = value
        End Set
    End Property

    Public Property Detalle() As PresupuestoCompraDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New PresupuestoCompraDetalleCollectionClass
                _Detalle.RellenarMe(Entidad.McomPresupuestoDetalle)
            End If

            Return _Detalle
        End Get
        Set(ByVal value As PresupuestoCompraDetalleCollectionClass)
            _Detalle = value
        End Set
    End Property

    Public ReadOnly Property Cotizaciones() As CotizacionCompraCollectionClass
        Get
            If Me._Cotizaciones Is Nothing Then
                _Cotizaciones = New CotizacionCompraCollectionClass
                '_Cotizaciones.RellenarMe(Entidad.CotizacionCompra)
            End If

            Return _Cotizaciones
        End Get
    End Property

#End Region

#Region "Metodos"

    Private Sub GenerarFolio()
        Dim UltimoFolio As String = "001", Presupuestos As New CC.PresupuestoCollection, Fecha As Date = Now.Date

        Presupuestos.GetMulti(New OC.FieldBetweenPredicate(HC.PresupuestoFields.FechaAlta, Fecha, Fecha.AddDays(1).AddTicks(-1)), 1, New OC.SortExpression(New OC.SortClause(HC.PresupuestoFields.Folio, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

        If Presupuestos.Count > 0 Then
            UltimoFolio = (Integer.Parse(Presupuestos(0).Folio.Substring(7)) + 1).ToString.PadLeft(3, "0"c)
        End If
        Me.Entidad.Folio = Fecha.ToString("yyMMdd") & "-" & UltimoFolio
    End Sub

    Public Function Borrar(ByRef Trans As HC.Transaction) As Boolean
        Try
            Me.Entidad.Estatus = EstatusDatos.CANCELADO
            Me.Entidad.FechaCancelacion = Now

            Dim Solicitud As New EC.SolicitudProductoDetalleEntity
            Solicitud.Estatus = EstatusEnum.ACTIVO
            Dim ColeccionProdBD As New CC.SolicitudProductoDetalleCollection
            Trans.Add(ColeccionProdBD)
            'ColeccionProdBD.UpdateMulti(Solicitud, HC.SolicitudProductoDetalleFields.FolioPresupuesto = Entidad.Folio)

            Trans.Add(Solicitud)
            Solicitud.Save()
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MEAT")
        End Try
    End Function

    Public Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Try
            If Entidad.IsNew Then
                Trans.Add(Entidad)
                Me.GenerarFolio()

                If Not Entidad.Save Then
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Dim col As CC.PresupuestoCompraDetalleCollection = Detalle.ObtenerColeccion

                Trans.Add(col)

                If col.SaveMulti = 0 Then
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Else
                    Return True
                End If
            Else
                If Me._ProductosSolicitados Is Nothing Then
                    MsgBox("Necesita la lista de productos solicitados", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Trans.Add(Entidad)
                If Not Entidad.Save Then
                    MsgBox("No se logró guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                'Dim Entidad As New EC.SolicitudProductoDetalleEntity
                'Entidad.FolioPresupuesto = ""
                'Entidad.Estatus = EstatusEnum.ACTIVO
                'Se obtienen los producto del detalle de la solicitud de la BD
                Dim ColeccionProdBD As New CC.SolicitudProductoDetalleCollection
                'Trans.Add(Coleccion)
                'ColeccionProdBD.GetMulti(HC.SolicitudProductoDetalleFields.FolioPresupuesto = Entidad.Folio)

                Dim ColeccionProdNva As CC.SolicitudProductoDetalleCollection = _ProductosSolicitados.ObtenerColeccion
                Dim encontro As Boolean

                For Each EntidadProdBD As EC.SolicitudProductoDetalleEntity In ColeccionProdBD
                    encontro = False
                    For Each EntidadProdNva As EC.SolicitudProductoDetalleEntity In ColeccionProdNva
                        If EntidadProdBD.IdProducto = EntidadProdNva.IdProducto Then
                            encontro = True

                            ColeccionProdNva.Remove(EntidadProdNva)
                            Exit For
                            'If EntidadProdBD.Estatus = EntidadProdNva.Estatus Then

                            'End If
                        End If
                    Next
                    If Not encontro Then
                        EntidadProdBD.Estatus = EstatusEnum.ACTIVO
                        Trans.Add(EntidadProdBD)
                        If Not EntidadProdBD.Save Then
                            Trans.Rollback()
                        End If
                    End If
                Next

                Trans.Add(ColeccionProdNva)
                ColeccionProdNva.SaveMulti()
                ' se consultan los productos que se tienen en la BD
                Dim ColeccionDetalleBD As New CC.PresupuestoCompraDetalleCollection
                ' Trans.Add(ColeccionDetalleBD)
                ColeccionDetalleBD.GetMulti(HC.PresupuestoCompraDetalleFields.PresupuestoId = Entidad.Folio)

                'Creo una coleccion con los datos que se tienen en el grid
                Dim ColeccionDetalleNva As CC.PresupuestoCompraDetalleCollection = Detalle.ObtenerColeccion
                'creo una coleccion nueva en la cual se agregaran los productos a guardar
                ' Dim ColeccionAGuardar As New CC.PresupuestoCompraDetalleCollection

                For Each EntidadBD As EC.PresupuestoCompraDetalleEntity In ColeccionDetalleBD
                    encontro = False
                    For Each EntidadNva As EC.PresupuestoCompraDetalleEntity In ColeccionDetalleNva
                        If EntidadBD.ProductoId = EntidadNva.ProductoId Then
                            encontro = True
                            If EntidadBD.Cantidad = EntidadNva.Cantidad Then
                                ColeccionDetalleNva.Remove(EntidadNva)
                            Else
                                EntidadNva.IsNew = False
                                EntidadNva.IsDirty = True
                            End If
                            Exit For
                        End If
                    Next
                    If Not encontro Then
                        Trans.Add(EntidadBD)
                        If Not EntidadBD.Delete Then
                            Trans.Rollback()
                            Return False
                        End If
                    End If
                Next

                Trans.Add(ColeccionDetalleNva)
                Dim Var As Integer
                Var = ColeccionDetalleNva.SaveMulti()
                Return True
                'End If
            End If

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entidad.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.PresupuestoEntity
        Return Entidad
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.PresupuestoEntity)
        Entidad = Entidad
    End Sub

#End Region

#Region "Constructores"

    Sub New()
        Entidad = New EC.PresupuestoEntity
    End Sub

    Sub New(ByVal Folio As String)
        Entidad = New EC.PresupuestoEntity(Folio)
    End Sub

    Sub New(ByVal Entidad As EC.PresupuestoEntity)
        Me.Entidad = Entidad
    End Sub

#End Region

End Class

Public Class PresupuestoCompraDetalleClass
    Implements IEntidad


#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private Detalle As EC.PresupuestoCompraDetalleEntity
    Private Presupuesto As PresupuestoCompraClass
    Private _Producto As ProductoGeneralClass
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el presupuesto de compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Presupuesto de Compra")> _
    Public Property PresupuestoCompra() As PresupuestoCompraClass
        Get
            If Presupuesto Is Nothing Then
                Presupuesto = New PresupuestoCompraClass(Detalle.McomPresupuesto)
            End If

            Return Presupuesto
        End Get
        Set(ByVal value As PresupuestoCompraClass)
            Presupuesto = value
            If value Is Nothing Then
                Detalle.McomPresupuesto = Nothing
            Else
                Detalle.McomPresupuesto = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Código")> _
    Public Property CodigoProducto() As Integer
        Get
            Return Detalle.ProductoId
        End Get
        Set(ByVal value As Integer)
            Detalle.ProductoId = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass(Detalle.Producto)
            ElseIf Not CodigoProducto = _Producto.Codigo Then
                _Producto.LeerEntidad(Detalle.Producto)
            End If

            Return _Producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            _Producto = value
            If value Is Nothing Then
                Detalle.Producto = Nothing
            Else
                Detalle.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la unidad de medida del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Unidad() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cantidad() As Decimal
        Get
            Return Detalle.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Detalle.Cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el precio de la ultima compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Precio Ultima Compra")> _
    Public Property PrecioUltimaCompra() As Decimal
        Get
            Return Detalle.PrecioUltimaCompra
        End Get
        Set(ByVal value As Decimal)
            Detalle.PrecioUltimaCompra = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Detalle.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Detalle.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodo"
    Private Function Guardar() As Boolean

    End Function

    Public Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Detalle)
            Return Detalle.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function ObtenerEntidad() As EC.PresupuestoCompraDetalleEntity
        Return Detalle
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.PresupuestoCompraDetalleEntity)
        Detalle = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Detalle = New EC.PresupuestoCompraDetalleEntity
    End Sub

    Sub New(ByVal Entidad As EC.PresupuestoCompraDetalleEntity)
        Detalle = Entidad
    End Sub

    Sub New(ByVal FolioPresupuesto As String, ByVal ProductoId As Integer)
        Detalle = New EC.PresupuestoCompraDetalleEntity(FolioPresupuesto, ProductoId)
    End Sub
#End Region

    Private Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Private Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class PresupuestoCompraCollectionClass
    Inherits ColleccionBase(Of EC.PresupuestoEntity, CC.PresupuestoCollection, PresupuestoCompraClass)

    Private Coleccion As New CC.PresupuestoCollection

    Public Function Obtener(Optional ByVal Folio As String = "", Optional ByVal Descripcion As String = "", Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.TODOS, Optional ByVal Plaza As PlazaClass = Nothing, Optional ByVal Sucursal As SucursalClass = Nothing, Optional ByVal TipoPresupuesto As TipoPresupuestoClass = Nothing) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not Folio = "" Then
                Filtro.Add(HC.PresupuestoFields.Folio = Folio)
            End If

            If Not Descripcion = "" Then
                Filtro.Add(HC.PresupuestoFields.Descripcion Mod String.Format("{0}%", Descripcion))
            End If

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.PresupuestoFields.Estatus = FcCondicion)
            End If

            If Not TipoPresupuesto Is Nothing Then
                Filtro.Add(HC.PresupuestoFields.TipoPresupuestoId = TipoPresupuesto.Codigo)
            End If

            Dim relac As OC.RelationCollection = Nothing

            If Not Plaza Is Nothing Then
                If Sucursal Is Nothing Then
                    relac = New OC.RelationCollection
                    relac.Add(EC.PresupuestoEntity.Relations.SucursalEntityUsingSucursalId)
                    'For Each suc As SucursalClass In Plaza.Sucursales
                    Filtro.Add(HC.SucursalFields.CodigoPlaza = Plaza.Codigo)
                    ' Next
                Else
                    Filtro.Add(HC.PresupuestoFields.SucursalId = Sucursal.Codigo)
                End If
            End If

            If relac Is Nothing Then
                Coleccion.GetMulti(Filtro)
            Else
                Coleccion.GetMulti(Filtro, relac)
            End If


            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#Region "Metodos de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.PresupuestoEntity In Coleccion
            Add(New PresupuestoCompraClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each presup As PresupuestoCompraClass In Me
            Coleccion.Add(presup.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.PresupuestoCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function ObtenerColeccion() As CC.PresupuestoCollection
        RellenarColeccion()
        Return Coleccion
    End Function
#End Region

End Class

Public Class PresupuestoCompraDetalleCollectionClass
    Inherits CollectionClass(Of PresupuestoCompraDetalleClass)

    Private Coleccion As New CC.PresupuestoCompraDetalleCollection

    Public Function Obtener(ByVal FolioPresupuesto As String, ByVal FcCondicion As CondicionEnum) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(HC.PresupuestoCompraDetalleFields.PresupuestoId = FolioPresupuesto)
            Else
                Coleccion.GetMulti(HC.PresupuestoCompraDetalleFields.PresupuestoId = FolioPresupuesto And HC.PresupuestoCompraDetalleFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#Region "Metodos de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.PresupuestoCompraDetalleEntity In Coleccion
            Add(New PresupuestoCompraDetalleClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each det As PresupuestoCompraDetalleClass In Me
            Coleccion.Add(det.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.PresupuestoCompraDetalleCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Public Sub RellenarMe(ByVal Col As CC.PresupuestoCompraDetalleCollection)
        Coleccion = Col
        Rellenar()
    End Sub
#End Region

End Class