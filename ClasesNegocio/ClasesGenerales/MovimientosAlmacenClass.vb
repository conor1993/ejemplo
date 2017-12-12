Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class MovimientosAlmacenClass
    Implements IEntidad

    Dim MovAlmacen As EC.InventarioMovimientoAlmacenEntity
    Dim _Detalle As MovAlmacenDetCollecionClass
#Region "Propiedades"
    Property AlmacenId() As Integer
        Get
            Return Me.MovAlmacen.AlmacenId
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacen.AlmacenId = value
        End Set
    End Property
    Property FolioMovimiento() As String
        Get
            Return Me.MovAlmacen.FolioMovimiento
        End Get
        Set(ByVal value As String)
            Me.MovAlmacen.FolioMovimiento = value
        End Set
    End Property
    Property FechaMovimiento() As Date
        Get
            Return Me.MovAlmacen.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Me.MovAlmacen.FechaMovimiento = value
        End Set
    End Property
    Property TipoMovimientoId() As Integer
        Get
            Return Me.MovAlmacen.TipoMovimientoId
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacen.TipoMovimientoId = value
        End Set
    End Property
    ReadOnly Property NombreTipoMovimiento() As String
        Get
            Dim tm As New TipoMovimientoClass
            tm.Obtener(Me.MovAlmacen.TipoMovimientoId)
            Return tm.ToString
        End Get
    End Property
    Property CostoTotal() As Decimal
        Get
            If Not IsNothing(Me.MovAlmacen.CostoTotal) Then
                Return Me.MovAlmacen.CostoTotal
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.MovAlmacen.CostoTotal = value
        End Set
    End Property
    Property Origen() As String
        Get
            Return Me.MovAlmacen.Origen
        End Get
        Set(ByVal value As String)
            Me.MovAlmacen.Origen = value
        End Set
    End Property
    Property Referencia() As String
        Get
            Return Me.MovAlmacen.Referencia
        End Get
        Set(ByVal value As String)
            Me.MovAlmacen.Referencia = value
        End Set
    End Property
    Property UsuarioId() As Integer
        Get
            Return Me.MovAlmacen.UsuarioId
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacen.UsuarioId = value
        End Set
    End Property
    Property EstatusContabilizado() As Integer
        Get
            Return Me.MovAlmacen.EstatusContabilizado
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacen.EstatusContabilizado = value
        End Set
    End Property
    Property FechaContabilizacion() As Date
        Get
            Return Me.MovAlmacen.FechaContabilizacion
        End Get
        Set(ByVal value As Date)
            Me.MovAlmacen.FechaContabilizacion = value
        End Set
    End Property
    Property PolizaContabilidad() As Integer
        Get
            Return Me.MovAlmacen.PolizaContabilidad
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacen.PolizaContabilidad = value
        End Set
    End Property
    ReadOnly Property Poliza() As PolizaClass
        Get
            Dim P As New PolizaClass
            If Not IsNothing(Me.MovAlmacen.PolizaContabilidad) Then
                P.Obtener(Me.MovAlmacen.PolizaContabilidad)
            Else
                Return Nothing
            End If
            Return P
        End Get
    End Property
    Property Entrega() As String
        Get
            Return MovAlmacen.Entrega
        End Get
        Set(ByVal value As String)
            MovAlmacen.Entrega = value
        End Set
    End Property
    Property Recibe() As String
        Get
            Return MovAlmacen.Recibe
        End Get
        Set(ByVal value As String)
            Me.MovAlmacen.Recibe = value
        End Set
    End Property
    Property Observaciones() As String
        Get
            Return Me.MovAlmacen.Observaciones
        End Get
        Set(ByVal value As String)
            Me.MovAlmacen.Observaciones = value
        End Set
    End Property
    ReadOnly Property Almacen() As AlmacenClass
        Get
            Dim Alm As New AlmacenClass
            Alm.Obtener(Me.MovAlmacen.AlmacenId)
            Return Alm
        End Get
    End Property


    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Me.MovAlmacen.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            MovAlmacen.Estatus = value
        End Set
    End Property

    Public Property AlmacenIdTran() As Integer
        Get
            Return MovAlmacen.AlmacenIdTrans
        End Get
        Set(ByVal value As Integer)
            MovAlmacen.AlmacenIdTrans = value
        End Set
    End Property

    Public Property Detalle() As MovAlmacenDetCollecionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New MovAlmacenDetCollecionClass
                _Detalle.RellenarMe(MovAlmacen.InventarioMovimientosAlmacenDetalles)
            End If
            Return _Detalle
        End Get
        Set(ByVal value As MovAlmacenDetCollecionClass)
            _Detalle = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Guardar() As Boolean

    End Function
    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            trans.Add(Me.MovAlmacen)
            Return Me.MovAlmacen.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
    End Function
    Public Function Obtener(ByVal AlmacenId As Integer, ByVal FolioMovimiento As String) As Boolean
        Try
            Return Me.MovAlmacen.FetchUsingPK(AlmacenId, FolioMovimiento)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ObtenerEntidad() As EC.InventarioMovimientoAlmacenEntity
        Return Me.MovAlmacen
    End Function
    Public Sub LeerEntidad(ByVal Entidad As EC.InventarioMovimientoAlmacenEntity)
        Me.MovAlmacen = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Me.MovAlmacen = New EC.InventarioMovimientoAlmacenEntity
    End Sub
    Sub New(ByVal Entidad As EC.InventarioMovimientoAlmacenEntity)
        Me.MovAlmacen = Entidad
    End Sub
    Sub New(ByVal AlmacenId As Integer, ByVal FolioMov As String)
        Me.MovAlmacen = New EC.InventarioMovimientoAlmacenEntity(AlmacenId, FolioMov)
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Function Reporte(ByVal empresa As String, ByVal usuario As String) As RptSalidaAlmacenXMateriales
        Try
            Dim rpt As New RptSalidaAlmacenXMateriales
            Dim dt As New DsSalidaAlmacenXMateriales.DtSalidaAlmacenxMaterialesDataTable
            Dim dt2 As New DsSalidaAlmacenXMateriales.DtSalidasAlmacenxMaterialesDetDataTable
            Dim ds As New DataSet


            dt.AddDtSalidaAlmacenxMaterialesRow(Me.Almacen.Descripcion, Me.FolioMovimiento, Me.FechaMovimiento.ToString(), Me.Observaciones, Me.Entrega, Me.Recibe, Me.CostoTotal.ToString("C"))
            For Each det As MovimientosAlmacenDetClass In Me.Detalle
                dt2.AddDtSalidasAlmacenxMaterialesDetRow(det.ProductoId, det.Producto.Descripcion, det.Cantidad, det.UnidadMed, det.Costo.ToString("C"), (det.Cantidad * det.Costo).ToString("C"), det.FolioMovimiento)
            Next

            ds.Tables.Add(dt)
            ds.Tables.Add(dt2)
            rpt.SetDataSource(ds)
            rpt.SetParameterValue(0, empresa)
            rpt.SetParameterValue(1, usuario)
            rpt.SetParameterValue(2, "Almacenes/Salidas de Almacén Por Materiales")

            Return rpt
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
End Class

Public Class MovAlmacenCollecionClass
    Inherits CollectionClass(Of MovimientosAlmacenClass)

    Private coleccion As New CC.InventarioMovimientoAlmacenCollection
    ' Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Solo obtiene los movimientos por su origen
    ''' </summary>
    ''' <param name="Fecha"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Fecha As DateTime, Optional ByVal origen As String = "") As Integer
        Try
            Dim filtro As New ORM.PredicateExpression
            If origen <> "" Then
                filtro.Add(HC.InventarioMovimientoAlmacenFields.Origen = origen)
            End If
            filtro.Add(HC.InventarioMovimientoAlmacenFields.FechaMovimiento = Now)
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try

    End Function

    Public Function Obtener(ByVal Folio As String, ByVal CondicionEstatus As CondicionEstatusEnum, Optional ByVal Origen As String = "") As Integer
        Try
            Dim filtro As New ORM.PredicateExpression

            If CondicionEstatus = CondicionEstatusEnum.TODOS Then
                If Origen <> "" Then
                    filtro.Add(HC.InventarioMovimientoAlmacenFields.FolioMovimiento = Folio And HC.InventarioMovimientoAlmacenFields.Origen = Origen)
                Else
                    filtro.Add(HC.InventarioMovimientoAlmacenFields.FolioMovimiento = Folio)
                End If
            Else
                If Origen <> "" Then
                    filtro.Add(HC.InventarioMovimientoAlmacenFields.FolioMovimiento = Folio And HC.InventarioMovimientoAlmacenFields.Estatus = CondicionEstatus And HC.InventarioMovimientoAlmacenFields.Origen = Origen)
                Else
                    filtro.Add(HC.InventarioMovimientoAlmacenFields.FolioMovimiento = Folio And HC.InventarioMovimientoAlmacenFields.Estatus = CondicionEstatus)
                End If
            End If

            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(ByVal FechaInicio As DateTime, ByVal FechaFinal As DateTime, ByVal CondicionEstatus As CondicionEstatusEnum, Optional ByVal origen As String = "") As Integer
        Try
            Dim filtro As New ORM.PredicateExpression
            FechaFinal.AddDays(1)

            If origen <> "" Then
                filtro.Add(HC.InventarioMovimientoAlmacenFields.Origen = origen)
            End If
            If CondicionEstatus <> CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.InventarioMovimientoAlmacenFields.Estatus = CondicionEstatus)
            End If
            filtro.Add(New ORM.FieldBetweenPredicate(HC.InventarioMovimientoAlmacenFields.FechaMovimiento, FechaInicio, FechaFinal))

            Me.coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(ByVal AlmacenId As Integer, ByVal Folio As String, ByVal TipoMov As Integer) As Integer
        Try
            Dim filtro As New ORM.PredicateExpression

            filtro.Add(HC.InventarioMovimientoAlmacenFields.AlmacenId = AlmacenId And HC.InventarioMovimientoAlmacenFields.FolioMovimiento = Folio And HC.InventarioMovimientoAlmacenFields.TipoMovimientoId = TipoMov)

            Me.coleccion.GetMulti(filtro)

            Rellenar()

            Return Count

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Reporte(ByVal empresa As String, ByVal usuario As String) As RptSalidaAlmacenXMateriales
        Try
            Dim rpt As New RptSalidaAlmacenXMateriales
            Dim dt As New DsSalidaAlmacenXMateriales.DtSalidaAlmacenxMaterialesDataTable
            Dim dt2 As New DsSalidaAlmacenXMateriales.DtSalidasAlmacenxMaterialesDetDataTable
            Dim ds As New DataSet

            For Each M As MovimientosAlmacenClass In Me
                dt.AddDtSalidaAlmacenxMaterialesRow(M.Almacen.Descripcion, M.FolioMovimiento, M.FechaMovimiento, M.Observaciones, M.Entrega, M.Recibe, M.CostoTotal)
                For Each det As MovimientosAlmacenDetClass In M.Detalle
                    dt2.AddDtSalidasAlmacenxMaterialesDetRow(det.ProductoId, det.Producto.Descripcion, det.Cantidad.ToString("N2"), det.UnidadMed, det.Costo.ToString("C"), det.Cantidad * det.Costo, det.FolioMovimiento)
                Next
            Next

            ds.Tables.Add(dt)
            ds.Tables.Add(dt2)
            rpt.SetDataSource(ds)
            rpt.SetParameterValue(0, empresa)
            rpt.SetParameterValue(1, usuario)
            rpt.SetParameterValue(2, "Almacenes/Salidas de Almacén Por Materiales")

            Return rpt
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

#Region "Codigo de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each entc As EC.InventarioMovimientoAlmacenEntity In coleccion
            Add(New MovimientosAlmacenClass(entc))
        Next
    End Sub
    Public Sub RellenarMe(ByVal Collection As CC.InventarioMovimientoAlmacenCollection)
        coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        coleccion.Clear()
        For Each entc As MovimientosAlmacenClass In Me
            coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.InventarioMovimientoAlmacenCollection
        RellenarColeccion()
        Return coleccion
    End Function
#End Region
End Class

Public Class MovimientosAlmacenDetClass
    Implements IEntidad

    Dim MovAlmacenDet As EC.InventarioMovimientoAlmacenDetallesEntity
    Dim _Producto As Productos

#Region "Propiedades"
    Property Indice() As Integer
        Get
            Return Me.MovAlmacenDet.Indice
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacenDet.Indice = value
        End Set
    End Property
    Property AlmacenId() As Integer
        Get
            Return Me.MovAlmacenDet.AlmacenId
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacenDet.AlmacenId = value
        End Set
    End Property
    Property FolioMovimiento() As String
        Get
            Return Me.MovAlmacenDet.FolioMovimiento
        End Get
        Set(ByVal value As String)
            Me.MovAlmacenDet.FolioMovimiento = value
        End Set
    End Property
    Property ProductoId() As Integer
        Get
            Return Me.MovAlmacenDet.ProductoId
        End Get
        Set(ByVal value As Integer)
            Me.MovAlmacenDet.ProductoId = value
        End Set
    End Property
    Property FechaMovimiento() As Date
        Get
            Return Me.MovAlmacenDet.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Me.MovAlmacenDet.FechaMovimiento = value
        End Set
    End Property
    Property Cantidad() As Decimal
        Get
            Return Me.MovAlmacenDet.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Me.MovAlmacenDet.Cantidad = value
        End Set
    End Property
    Property Costo() As Decimal
        Get
            Return Me.MovAlmacenDet.Costo
        End Get
        Set(ByVal value As Decimal)
            Me.MovAlmacenDet.Costo = value
        End Set
    End Property
    Property Descuento() As Decimal
        Get
            Return Me.MovAlmacenDet.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.MovAlmacenDet.Descuento = value
        End Set
    End Property
    Property IVA() As Decimal
        Get
            Return Me.MovAlmacenDet.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.MovAlmacenDet.Iva = value
        End Set
    End Property
    Property DescripcionMov() As String
        Get
            Return MovAlmacenDet.DescMov
        End Get
        Set(ByVal value As String)
            MovAlmacenDet.DescMov = value
        End Set
    End Property

    Public Property UnidadMed() As String
        Get
            Return MovAlmacenDet.Producto.UnidadMedida.DescripcionCorta
        End Get
        Set(ByVal value As String)
            MovAlmacenDet.Unidad = value
        End Set
    End Property

    Public Property Producto() As Productos
        Get
            If _Producto Is Nothing Then
                _Producto = New Productos(MovAlmacenDet.Producto)
            ElseIf Not _Producto.Codigo = ProductoId Then
                _Producto.LeerEntidad(MovAlmacenDet.Producto)
            End If
            Return _Producto
        End Get
        Set(ByVal value As Productos)
            _Producto = value
            If value Is Nothing Then
                MovAlmacenDet.Producto = Nothing
            Else
                MovAlmacenDet.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property UnidadMedida() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Private Function Guardar() As Boolean

    End Function
    Public Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try

            Trans.Add(Me.MovAlmacenDet)
            Return Me.MovAlmacenDet.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            'RaiseEvent MensajeError(Me, "No se pudo Guardar el Detalle del Movimiento de Almacen")
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
    End Function
    Public Function Obtener(ByVal Indice As Integer, ByVal AlmacenId As Integer, ByVal FolioMov As String, ByVal ProductoId As Integer) As Boolean
        Try
            Return Me.MovAlmacenDet.FetchUsingPK(Indice, AlmacenId, FolioMov, ProductoId)
            'Return Me.MovAlmacenDet.FetchUsingPK(AlmacenId, FolioMov, ProductoId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ObtenerEntidad() As EC.InventarioMovimientoAlmacenDetallesEntity
        Return Me.MovAlmacenDet
    End Function
    Public Sub LeerEntidad(ByVal Entidad As EC.InventarioMovimientoAlmacenDetallesEntity)
        Me.MovAlmacenDet = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Me.MovAlmacenDet = New EC.InventarioMovimientoAlmacenDetallesEntity
    End Sub
    Sub New(ByVal Entidad As EC.InventarioMovimientoAlmacenDetallesEntity)
        Me.MovAlmacenDet = Entidad
    End Sub
    Sub New(ByVal Indice As Integer, ByVal AlmacenId As Integer, ByVal FolioMov As String, ByVal ProductoId As Integer)
        Me.MovAlmacenDet = New EC.InventarioMovimientoAlmacenDetallesEntity(Indice, AlmacenId, FolioMov, ProductoId)
        'Me.MovAlmacenDet = New EC.InventarioMovimientoAlmacenDetallesEntity(AlmacenId, FolioMov, ProductoId)
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class MovAlmacenDetCollecionClass
    Inherits CollectionClass(Of MovimientosAlmacenDetClass)

    Private coleccion2 As New CC.InventarioMovimientoAlmacenDetallesCollection
    'Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Function Obtener() As Integer
        Try
            coleccion2.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Folio As String) As Integer
        Try
            If Not Folio = "" Then
                coleccion2.GetMulti(HC.InventarioMovimientoAlmacenDetallesFields.FolioMovimiento = Folio)
            Else
                coleccion2.GetMulti(Nothing)
            End If

            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function
#Region "Codigo de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each entc As EC.InventarioMovimientoAlmacenDetallesEntity In coleccion2
            Add(New MovimientosAlmacenDetClass(entc))
        Next
    End Sub
    Public Sub RellenarMe(ByVal Collection As CC.InventarioMovimientoAlmacenDetallesCollection)
        coleccion2 = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        coleccion2.Clear()
        For Each entc As MovimientosAlmacenDetClass In Me
            coleccion2.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.InventarioMovimientoAlmacenDetallesCollection
        RellenarColeccion()
        Return coleccion2
    End Function
#End Region
End Class

Public Class MInvAlmacenClass
    Implements IEntidad

    Dim InvAlmacen As New EC.InventarioAlmacenEntity
    Dim _Producto As Productos

#Region "Propiedades"
    Property AlmacenId() As Integer
        Get
            Return Me.InvAlmacen.AlmacenId
        End Get
        Set(ByVal value As Integer)
            Me.InvAlmacen.AlmacenId = value
        End Set
    End Property
    Property ProductoId() As Integer
        Get
            Return Me.InvAlmacen.ProductoId
        End Get
        Set(ByVal value As Integer)
            Me.InvAlmacen.ProductoId = value
        End Set
    End Property
    Property CantidadInicial() As Integer
        Get
            Return Me.InvAlmacen.CantidadInicial
        End Get
        Set(ByVal value As Integer)
            Me.InvAlmacen.CantidadInicial = value
        End Set
    End Property
    Property Cantidad() As Decimal
        Get
            Return Me.InvAlmacen.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Me.InvAlmacen.Cantidad = value
        End Set
    End Property
    Property UltimoCosto() As Decimal
        Get
            Return Me.InvAlmacen.UltimoCosto.GetValueOrDefault(0)
        End Get
        Set(ByVal value As Decimal)
            Me.InvAlmacen.UltimoCosto = value
        End Set
    End Property
    Property CostoPromedio() As Decimal
        Get
            Return Me.InvAlmacen.CostoPromedio
        End Get
        Set(ByVal value As Decimal)
            Me.InvAlmacen.CostoPromedio = value
        End Set
    End Property
    Property FechaUltimoCosto() As Date
        Get
            Return Me.InvAlmacen.FechaUltimoCosto
        End Get
        Set(ByVal value As Date)
            Me.InvAlmacen.FechaUltimoCosto = value
        End Set
    End Property
    Property PorSurtir() As Integer
        Get
            Return Me.InvAlmacen.PorSurtir
        End Get
        Set(ByVal value As Integer)
            Me.InvAlmacen.PorSurtir = value
        End Set
    End Property
    Property CantidadEntrada() As Decimal
        Get
            Return Me.InvAlmacen.CantidadEntrada
        End Get
        Set(ByVal value As Decimal)
            Me.InvAlmacen.CantidadEntrada = value
        End Set
    End Property
    Property CantidadSalida() As Decimal
        Get
            Return Me.InvAlmacen.CantidadSalida
        End Get
        Set(ByVal value As Decimal)
            Me.InvAlmacen.CantidadSalida = value
        End Set
    End Property
    Public Property Año() As String
        Get
            Return Me.InvAlmacen.Año
        End Get
        Set(ByVal value As String)
            Me.InvAlmacen.Año = value
        End Set
    End Property
    Public Property Mes() As String
        Get
            Return Me.InvAlmacen.Mes
        End Get
        Set(ByVal value As String)
            Me.InvAlmacen.Mes = value
        End Set
    End Property

    Public Property Producto() As Productos
        Get
            If _Producto Is Nothing Then
                _Producto = New Productos(InvAlmacen.Producto)
            ElseIf Not _Producto.Codigo = ProductoId Then
                _Producto.LeerEntidad(InvAlmacen.Producto)
            End If
            Return _Producto
        End Get
        Set(ByVal value As Productos)
            _Producto = value
            If value Is Nothing Then
                InvAlmacen.Producto = Nothing
            Else
                InvAlmacen.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property UnidadMedida() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Private Function Guardar() As Boolean

    End Function

    Public Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Trans.Add(Me.InvAlmacen)
            Return Me.InvAlmacen.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Obtener(ByVal AlmacenId As Integer, ByVal ProductoId As Integer, ByVal Año As String, ByVal Mes As String) As Boolean
        Try
            Return Me.InvAlmacen.FetchUsingPK(AlmacenId, ProductoId, Año, Mes)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.InventarioAlmacenEntity
        Return Me.InvAlmacen
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.InventarioAlmacenEntity)
        Me.InvAlmacen = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()
        Me.InvAlmacen = New EC.InventarioAlmacenEntity
    End Sub

    Sub New(ByVal Entidad As EC.InventarioAlmacenEntity)
        Me.InvAlmacen = Entidad
    End Sub

    Sub New(ByVal AlmacenId As Integer, ByVal ProductoId As Integer, ByVal Año As String, ByVal Mes As String)
        Me.InvAlmacen = New EC.InventarioAlmacenEntity(AlmacenId, ProductoId, Año, Mes)
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class MInvAlmacenCollecionClass
    Inherits CollectionClass(Of MInvAlmacenClass)

    Private coleccion As New CC.InventarioAlmacenCollection
    'Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

#Region "Codigo de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each entc As EC.InventarioAlmacenEntity In coleccion
            Add(New MInvAlmacenClass(entc))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Collection As CC.InventarioAlmacenCollection)
        coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        coleccion.Clear()
        For Each entc As MInvAlmacenClass In Me
            coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.InventarioAlmacenCollection
        RellenarColeccion()
        Return coleccion
    End Function
#End Region
End Class