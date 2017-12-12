Imports System.Windows.Forms

Imports CD = IntegraLab.ORM.CollectionClasses
Imports ED = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports TC = Integralab.ORM.TypedViewClasses

'impresion de produccion
Public Class ReportesClass

    Public Function ObtenerRecepcion(ByVal Opcion As Integer, ByVal IdProductor As Integer) As DataSet
        Try
            ObtenerRecepcion = SPR.UspRptRecepcionGanado(Opcion, IdProductor, "", Now, Now)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ObtenerRecepcion = Nothing
        End Try
    End Function

    Public Function ObtenerSacrificios(ByVal Opcion As Integer, ByVal IdProductor As Integer) As DataSet
        Try
            Return Nothing
            'ObtenerSacrificios = SPR.UspRptRegistroSacrificios(Opcion, IdProductor, "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ObtenerSacrificios = Nothing
        End Try
    End Function

    Public Function ObtenerCanales(ByVal Opcion As Integer, ByVal IdProductor As Integer) As DataSet
        Try
            Return Nothing
            'ObtenerCanales = SPR.UspRptRegistroSacrificiosDet(Opcion, IdProductor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ObtenerCanales = Nothing
        End Try
    End Function

    Public Function ObtenerCortes(ByVal Opcion As Integer, ByVal IdProductor As Integer) As DataSet
        Try
            ObtenerCortes = SPR.UspRptCortes(Opcion, IdProductor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ObtenerCortes = Nothing
        End Try
    End Function

End Class

'impresion de presupuestos de compra
Public Class ListadoPresupuestosClass
    Implements IEntidad

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Dim Presupuestos As Integralab.ORM.TypedViewClasses.VwCompReportePresupuestosRow
#End Region

#Region "Propiedades"

    Public Property Folio() As String
        Get
            Return Presupuestos.Folio
        End Get
        Set(ByVal value As String)
            Presupuestos.Folio = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return Presupuestos.FechaAlta
        End Get
        Set(ByVal value As Date)
            Presupuestos.FechaAlta = value
        End Set
    End Property

    Public Property PDDescripcion() As String
        Get
            Return Presupuestos.PdDescripcion
        End Get
        Set(ByVal value As String)
            Presupuestos.PdDescripcion = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Presupuestos.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Presupuestos.Cantidad = value
        End Set
    End Property

    Public Property UMDescripcion() As String
        Get
            Return Presupuestos.Umdescripcion
        End Get
        Set(ByVal value As String)
            Presupuestos.Umdescripcion = value
        End Set
    End Property


    Public Property Obserbaciones() As String
        Get
            Return Presupuestos.Obserbaciones
        End Get
        Set(ByVal value As String)
            Presupuestos.Obserbaciones = value
        End Set
    End Property

    Public Property SucursalId() As Integer
        Get
            Return Presupuestos.SucursalId
        End Get
        Set(ByVal value As Integer)
            Presupuestos.SucursalId = value
        End Set
    End Property

    Public Property SCIdPlaza() As Integer
        Get
            Return Presupuestos.ScidPlaza
        End Get
        Set(ByVal value As Integer)
            Presupuestos.ScidPlaza = value
        End Set
    End Property
    Public Property PlDescripcion() As String
        Get
            Return Presupuestos.Pldescripcion
        End Get
        Set(ByVal value As String)
            Presupuestos.Pldescripcion = value
        End Set
    End Property
    Public Property Presupuesto() As String
        Get
            Return Presupuestos.Presupuesto
        End Get
        Set(ByVal value As String)
            Presupuestos.Presupuesto = value
        End Set
    End Property
    Public Property ProductoId() As Integer
        Get
            Return Presupuestos.ProductoId
        End Get
        Set(ByVal value As Integer)
            Presupuestos.ProductoId = value
        End Set
    End Property
    Public Property SCDescripcion() As String
        Get
            Return Presupuestos.Scdescripcion
        End Get
        Set(ByVal value As String)
            Presupuestos.Scdescripcion = value
        End Set
    End Property
    Public Property TipoPresupuesto() As String
        Get
            Return Presupuestos.TipoPresupuesto
        End Get
        Set(ByVal value As String)
            Presupuestos.TipoPresupuesto = value
        End Set
    End Property
    Public Property TipoPresupuestoId() As Integer
        Get
            Return Presupuestos.TipoPresupuestoId
        End Get
        Set(ByVal value As Integer)
            Presupuestos.TipoPresupuestoId = value
        End Set
    End Property

    'Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
    '    Get
    '        Return Presupuestos
    '    End Get
    '    Set(ByVal value As EstatusEnum)
    '        Solicitud.Estatus = value
    '    End Set
    'End Property
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Row As TC.VwCompReportePresupuestosRow)
        Presupuestos = Row
    End Sub
#End Region

#Region "Metodos"
    Private Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Guardar() As Boolean

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region
    
End Class

Public Class ListadoPresupuestosCollectionClass
    Inherits CollectionClass(Of ListadoPresupuestosClass)

    Private Coleccion As New Integralab.ORM.TypedViewClasses.VwCompReportePresupuestosTypedView

    Public Function Obtener(Optional ByVal PlazaId As Integer = -1, Optional ByVal SucursalId As Integer = -1, Optional ByVal ProductoId As Integer = -1, Optional ByVal Folio As String = "", Optional ByVal FechaInicial As String = "", Optional ByVal FechaFinal As String = "", Optional ByVal RangoFechas As Integer = -1) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Folio = "" Then
                If PlazaId > -1 Then
                    Filtro.Add(HC.VwCompReportePresupuestosFields.ScidPlaza = PlazaId)
                End If

                If SucursalId > -1 Then
                    Filtro.Add(HC.VwCompReportePresupuestosFields.SucursalId = SucursalId)
                End If

                If ProductoId > -1 Then
                    Filtro.Add(HC.VwCompReportePresupuestosFields.ProductoId = ProductoId)
                End If

                If RangoFechas > -1 Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReportePresupuestosFields.FechaAlta, CDate(FechaInicial).ToShortDateString, CDate(FechaFinal).AddDays(1).ToShortDateString))
                End If
            Else
                Filtro.Add(HC.VwCompReportePresupuestosFields.Folio = Folio)
            End If

            Coleccion.Clear()
            Coleccion.Fill(0, Nothing, True, Filtro)

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
        For Each row As TC.VwCompReportePresupuestosRow In Coleccion
            Add(New ListadoPresupuestosClass(row))
        Next
    End Sub
#End Region
End Class

'impresion de cotizaciones de compra
Public Class ListadoCotizacionesClass
    Implements IEntidad

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Dim Cotizaciones As Integralab.ORM.TypedViewClasses.VwCompReporteCotizacionesRow
#End Region

#Region "Propiedades"

    Public ReadOnly Property Folio() As String
        Get
            Return "C" & Cotizaciones.IdCotizacion.ToString.PadLeft(10, "0")
        End Get
    End Property

    Public ReadOnly Property IdCotizacion() As Integer
        Get
            Return Cotizaciones.IdCotizacion
        End Get
    End Property

    Public Property FechaAlta() As Date
        Get
            Return Cotizaciones.FechaAlta
        End Get
        Set(ByVal value As Date)
            Cotizaciones.FechaAlta = value
        End Set
    End Property

    Public Property PDDescripcion() As String
        Get
            Return Cotizaciones.PdDescripcion
        End Get
        Set(ByVal value As String)
            Cotizaciones.PdDescripcion = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Cotizaciones.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Cotizaciones.Cantidad = value
        End Set
    End Property

    Public Property UMDescripcion() As String
        Get
            Return Cotizaciones.Umdescripcion
        End Get
        Set(ByVal value As String)
            Cotizaciones.Umdescripcion = value
        End Set
    End Property


    Public Property Observaciones() As String
        Get
            Return Cotizaciones.Observaciones
        End Get
        Set(ByVal value As String)
            Cotizaciones.Observaciones = value
        End Set
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Cotizaciones.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Cotizaciones.IdSucursal = value
        End Set
    End Property

    Public Property SCIdPlaza() As Integer
        Get
            Return Cotizaciones.ScidPlaza
        End Get
        Set(ByVal value As Integer)
            Cotizaciones.ScidPlaza = value
        End Set
    End Property

    Public Property PlDescripcion() As String
        Get
            Return Cotizaciones.Pldescripcion
        End Get
        Set(ByVal value As String)
            Cotizaciones.Pldescripcion = value
        End Set
    End Property

    Public Property PrRazSocial() As String
        Get
            Return Cotizaciones.PrRazSocial
        End Get
        Set(ByVal value As String)
            Cotizaciones.PrRazSocial = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Cotizaciones.IdProducto
        End Get
        Set(ByVal value As Integer)
            Cotizaciones.IdProducto = value
        End Set
    End Property

    Public Property SCDescripcion() As String
        Get
            Return Cotizaciones.Scdescripcion
        End Get
        Set(ByVal value As String)
            Cotizaciones.Scdescripcion = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Cotizaciones.Descuento
        End Get
        Set(ByVal value As Decimal)
            Cotizaciones.Descuento = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return Cotizaciones.Importe
        End Get
        Set(ByVal value As Decimal)
            Cotizaciones.Importe = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Cotizaciones.Precio
        End Get
        Set(ByVal value As Decimal)
            Cotizaciones.Precio = value
        End Set
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Cotizaciones.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Cotizaciones.IdProveedor = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Row As TC.VwCompReporteCotizacionesRow)
        Cotizaciones = Row
    End Sub
#End Region

#Region "Metodos"
    Private Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Guardar() As Boolean

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region

End Class

Public Class ListadoCotizacionesCollectionClass
    Inherits CollectionClass(Of ListadoCotizacionesClass)

    Private Coleccion As New Integralab.ORM.TypedViewClasses.VwCompReporteCotizacionesTypedView

    Public Function Obtener(Optional ByVal PlazaId As Integer = -1, Optional ByVal SucursalId As Integer = -1, Optional ByVal ProductoId As Integer = -1, Optional ByVal ProveedorId As Integer = -1, Optional ByVal IdCotizacion As Integer = 0, Optional ByVal FechaInicial As String = "", Optional ByVal FechaFinal As String = "", Optional ByVal RangoFechas As Integer = -1) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If IdCotizacion = 0 Then

                If PlazaId > -1 Then
                    Filtro.Add(HC.VwCompReporteCotizacionesFields.ScidPlaza = PlazaId)
                End If

                If SucursalId > -1 Then
                    Filtro.Add(HC.VwCompReporteCotizacionesFields.IdSucursal = SucursalId)
                End If

                If ProductoId > -1 Then
                    Filtro.Add(HC.VwCompReporteCotizacionesFields.IdProducto = ProductoId)
                End If

                If ProveedorId > -1 Then
                    Filtro.Add(HC.VwCompReporteCotizacionesFields.IdProveedor = ProveedorId)
                End If

                If RangoFechas > -1 Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReporteCotizacionesFields.FechaAlta, CDate(FechaInicial).ToShortDateString, CDate(FechaFinal).AddDays(1).ToShortDateString))
                End If
            Else
                Filtro.Add(HC.VwCompReporteCotizacionesFields.IdCotizacion = IdCotizacion)
            End If


            Coleccion.Clear()
            Coleccion.Fill(0, Nothing, True, Filtro)

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
        For Each row As TC.VwCompReporteCotizacionesRow In Coleccion
            Add(New ListadoCotizacionesClass(row))
        Next
    End Sub
#End Region
End Class

'impresion de ordenes de compra
Public Class ListadoOrdenesdeCompraClass
    Implements IEntidad

#Region "Miembros"

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Dim OrdenesdeCompra As Integralab.ORM.TypedViewClasses.VwCompReporteOrdenesCompraRow

#End Region

#Region "Propiedades"

    Public Property IdOrdenCompra() As Integer
        Get
            Return OrdenesdeCompra.IdOrdenCompra
        End Get
        Set(ByVal value As Integer)
            OrdenesdeCompra.IdOrdenCompra = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return OrdenesdeCompra.FechaAlta
        End Get
        Set(ByVal value As Date)
            OrdenesdeCompra.FechaAlta = value
        End Set
    End Property

    Public Property PDDescripcion() As String
        Get
            Return OrdenesdeCompra.PdDescripcion
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.PdDescripcion = value
        End Set
    End Property

    Public Property CantidadSolicitada() As Decimal
        Get
            Return OrdenesdeCompra.CantidadSolicitada
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.CantidadSolicitada = value
        End Set
    End Property

    Public Property UMDescripcion() As String
        Get
            Return OrdenesdeCompra.Umdescripcion
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.Umdescripcion = value
        End Set
    End Property


    Public Property Observaciones() As String
        Get
            Return OrdenesdeCompra.Observaciones
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.Observaciones = value
        End Set
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return OrdenesdeCompra.IdSucursal
        End Get
        Set(ByVal value As Integer)
            OrdenesdeCompra.IdSucursal = value
        End Set
    End Property

    Public Property SCIdPlaza() As Integer
        Get
            Return OrdenesdeCompra.ScidPlaza
        End Get
        Set(ByVal value As Integer)
            OrdenesdeCompra.ScidPlaza = value
        End Set
    End Property
    Public Property PlDescripcion() As String
        Get
            Return OrdenesdeCompra.Pldescripcion
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.Pldescripcion = value
        End Set
    End Property
    Public Property PrRazSocial() As String
        Get
            Return OrdenesdeCompra.PrRazSocial
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.PrRazSocial = value
        End Set
    End Property
    Public Property IdProducto() As Integer
        Get
            Return OrdenesdeCompra.IdProducto
        End Get
        Set(ByVal value As Integer)
            OrdenesdeCompra.IdProducto = value
        End Set
    End Property
    Public Property SCDescripcion() As String
        Get
            Return OrdenesdeCompra.Scdescripcion
        End Get
        Set(ByVal value As String)
            OrdenesdeCompra.Scdescripcion = value
        End Set
    End Property
    Public Property Descuento() As Decimal
        Get
            Return OrdenesdeCompra.Descuento
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.Descuento = value
        End Set
    End Property
    
    Public Property Importe() As Decimal
        Get
            Return OrdenesdeCompra.Importe
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.Importe = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return OrdenesdeCompra.Precio
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.Precio = value
        End Set
    End Property

    Public Property ProveedorId() As Integer
        Get
            Return OrdenesdeCompra.IdProveedor
        End Get
        Set(ByVal value As Integer)
            OrdenesdeCompra.IdProveedor = value
        End Set
    End Property

    Public Property CantidadOrdenar() As Decimal
        Get
            Return OrdenesdeCompra.CantidadOrdenar
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.CantidadOrdenar = value
        End Set
    End Property

    Public Property CantPendientexRecibir() As Decimal
        Get
            Return OrdenesdeCompra.CantPendientexRecibir
        End Get
        Set(ByVal value As Decimal)
            OrdenesdeCompra.CantPendientexRecibir = value
        End Set
    End Property

    Private Property Estatus2() As EstatusEnum Implements IEntidad.Estatus
        Get
        End Get
        Set(ByVal value As EstatusEnum)
        End Set
    End Property

    Public Property Autorizada() As String
        Get
            Return Me.OrdenesdeCompra.Autorizada
        End Get
        Set(ByVal value As String)
            Me.OrdenesdeCompra.Autorizada = value
        End Set
    End Property

    Public Property Estatus() As String
        Get
            Return Me.OrdenesdeCompra.Estatus
        End Get
        Set(ByVal value As String)
            Me.OrdenesdeCompra.Estatus = value
        End Set
    End Property

    Public Property Recibida() As String
        Get
            Return Me.OrdenesdeCompra.Recibida
        End Get
        Set(ByVal value As String)
            Me.OrdenesdeCompra.Recibida = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Row As TC.VwCompReporteOrdenesCompraRow)
        OrdenesdeCompra = Row
    End Sub
#End Region

#Region "Metodos"
    Private Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Guardar() As Boolean

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
#End Region



End Class

Public Class ListadoOrdenesdeCompraCollectionClass
    Inherits CollectionClass(Of ListadoOrdenesdeCompraClass)

    Private Coleccion As New Integralab.ORM.TypedViewClasses.VwCompReporteOrdenesCompraTypedView

    Public Function Obtener(Optional ByVal PlazaId As Integer = -1, Optional ByVal SucursalId As Integer = -1, Optional ByVal ProductoId As Integer = -1, Optional ByVal ProveedorId As Integer = -1, Optional ByVal IdOrdenCompra As Integer = 0, Optional ByVal FechaInicial As String = "", Optional ByVal FechaFinal As String = "", Optional ByVal RangoFechas As Integer = -1) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If IdOrdenCompra = 0 Then
                If PlazaId > -1 Then
                    Filtro.Add(HC.VwCompReporteOrdenesCompraFields.ScidPlaza = PlazaId)
                End If

                If SucursalId > -1 Then
                    Filtro.Add(HC.VwCompReporteOrdenesCompraFields.IdSucursal = SucursalId)
                End If

                If ProductoId > -1 Then
                    Filtro.Add(HC.VwCompReporteOrdenesCompraFields.IdProducto = ProductoId)
                End If

                If ProveedorId > -1 Then
                    Filtro.Add(HC.VwCompReporteOrdenesCompraFields.IdProveedor = ProveedorId)
                End If

                If RangoFechas > -1 Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReporteOrdenesCompraFields.FechaAlta, CDate(FechaInicial).ToShortDateString, CDate(FechaFinal).AddDays(1).ToShortDateString))
                End If
            Else
                Filtro.Add(HC.VwCompReporteOrdenesCompraFields.IdOrdenCompra = IdOrdenCompra)
            End If


            Coleccion.Clear()
            Coleccion.Fill(0, Nothing, True, Filtro)

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
        For Each row As TC.VwCompReporteOrdenesCompraRow In Coleccion
            Add(New ListadoOrdenesdeCompraClass(row))
        Next
    End Sub
#End Region
End Class

'impresion de recepciones de ordenes de compra
Public Class ListadoRecepciondeOrdenesdeCompraClass
    Implements IEntidad


#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Dim RecepciondeOrdenesdeCompra As Integralab.ORM.TypedViewClasses.VwCompReporteRecepcionesOrdenesCompraRow
#End Region

#Region "Propiedades"

    Public ReadOnly Property Folio() As String
        Get
            Return "R" & RecepciondeOrdenesdeCompra.IdRecepcionOrdenCompra.ToString.PadLeft(10, "0")
        End Get
    End Property

    Public ReadOnly Property IdRecepcionOrdenCompra() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.IdRecepcionOrdenCompra
        End Get
    End Property

    Public Property FechaRecepcion() As Date
        Get
            Return RecepciondeOrdenesdeCompra.FechaRecepcion
        End Get
        Set(ByVal value As Date)
            RecepciondeOrdenesdeCompra.FechaRecepcion = value
        End Set
    End Property

    Public Property PDDescripcion() As String
        Get
            Return RecepciondeOrdenesdeCompra.PdDescripcion
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.PdDescripcion = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return RecepciondeOrdenesdeCompra.Cantidad
        End Get
        Set(ByVal value As Decimal)
            RecepciondeOrdenesdeCompra.Cantidad = value
        End Set
    End Property

    Public Property UMDescripcion() As String
        Get
            Return RecepciondeOrdenesdeCompra.Umdescripcion
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.Umdescripcion = value
        End Set
    End Property


    Public Property Observaciones() As String
        Get
            Return RecepciondeOrdenesdeCompra.Observaciones
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.Observaciones = value
        End Set
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.IdSucursal
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.IdSucursal = value
        End Set
    End Property

    Public Property SCIdPlaza() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.ScidPlaza
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.ScidPlaza = value
        End Set
    End Property
    Public Property PlDescripcion() As String
        Get
            Return RecepciondeOrdenesdeCompra.Pldescripcion
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.Pldescripcion = value
        End Set
    End Property
    Public Property PrRazSocial() As String
        Get
            Return RecepciondeOrdenesdeCompra.PrRazSocial
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.PrRazSocial = value
        End Set
    End Property
    Public Property IdProducto() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.IdProducto
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.IdProducto = value
        End Set
    End Property
    Public Property SCDescripcion() As String
        Get
            Return RecepciondeOrdenesdeCompra.Scdescripcion
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.Scdescripcion = value
        End Set
    End Property

    Public Property IdOrdenCompra() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.IdOrdenCompra
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.IdOrdenCompra = value
        End Set
    End Property

    Public Property ProveedorId() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.ProveedorId
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.ProveedorId = value
        End Set
    End Property

    Public Property FolioMovimientoAml() As String
        Get
            Return RecepciondeOrdenesdeCompra.FolioMovimientoAml
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.FolioMovimientoAml = value
        End Set
    End Property

    Public Property FolioMovimientoAlmCan() As String
        Get
            Return RecepciondeOrdenesdeCompra.FolioMovimientoAlmCan
        End Get
        Set(ByVal value As String)
            RecepciondeOrdenesdeCompra.FolioMovimientoAlmCan = value
        End Set
    End Property

    Public Property AlmacenId() As Integer
        Get
            Return RecepciondeOrdenesdeCompra.AlmacenId
        End Get
        Set(ByVal value As Integer)
            RecepciondeOrdenesdeCompra.AlmacenId = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Row As TC.VwCompReporteRecepcionesOrdenesCompraRow)
        RecepciondeOrdenesdeCompra = Row
    End Sub
#End Region

#Region "Metodos"
    Private Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Guardar() As Boolean

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region



End Class

Public Class ListadoRecepciondeOrdenesdeCompraCollectionClass
    Inherits CollectionClass(Of ListadoRecepciondeOrdenesdeCompraClass)

    Private Coleccion As New Integralab.ORM.TypedViewClasses.VwCompReporteRecepcionesOrdenesCompraTypedView

    Public Function Obtener(Optional ByVal PlazaId As Integer = -1, Optional ByVal SucursalId As Integer = -1, Optional ByVal ProductoId As Integer = -1, Optional ByVal ProveedorId As Integer = -1, Optional ByVal IdRecepcionOrdenCompra As Integer = 0, Optional ByVal FechaInicial As String = "", Optional ByVal FechaFinal As String = "", Optional ByVal RangoFechas As Integer = -1) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If IdRecepcionOrdenCompra = 0 Then

                If PlazaId > -1 Then
                    Filtro.Add(HC.VwCompReporteRecepcionesOrdenesCompraFields.ScidPlaza = PlazaId)
                End If

                If SucursalId > -1 Then
                    Filtro.Add(HC.VwCompReporteRecepcionesOrdenesCompraFields.IdSucursal = SucursalId)
                End If

                If ProductoId > -1 Then
                    Filtro.Add(HC.VwCompReporteRecepcionesOrdenesCompraFields.IdProducto = ProductoId)
                End If

                If ProveedorId > -1 Then
                    Filtro.Add(HC.VwCompReporteRecepcionesOrdenesCompraFields.ProveedorId = ProveedorId)
                End If

                If RangoFechas > -1 Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwCompReporteRecepcionesOrdenesCompraFields.FechaRecepcion, CDate(FechaInicial).ToShortDateString, CDate(FechaFinal).AddDays(1).ToShortDateString))
                End If
            Else
                Filtro.Add(HC.VwCompReporteRecepcionesOrdenesCompraFields.IdRecepcionOrdenCompra = IdRecepcionOrdenCompra)
            End If

            Coleccion.Clear()
            Coleccion.Fill(0, Nothing, True, Filtro)

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
        For Each row As TC.VwCompReporteRecepcionesOrdenesCompraRow In Coleccion
            Add(New ListadoRecepciondeOrdenesdeCompraClass(row))
        Next
    End Sub
#End Region
End Class