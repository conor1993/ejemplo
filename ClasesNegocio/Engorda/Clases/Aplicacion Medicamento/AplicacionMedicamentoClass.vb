Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum

Public Class AplicacionMedicamentoClass
    Inherits ClassBase(Of EC.AplicMediEntity)

#Region "Campos"
    Private m_Almacen As AlmacenClass
    Private m_MovimientoAlmacenSalida As AlmacenGeneral.MovimientoAlmacenClass
    Private m_Detalle As AplicacionMedicamentoDetalleCollectionClass
    Private m_ControlCantidadProductos As New Dictionary(Of Integer, ProductosUsadoAplicacionMedicamento)
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.AplicMediEntity
    End Sub

    Sub New(ByVal folioAplicacion As String)
        MyBase.New(New EC.AplicMediEntity(folioAplicacion))
    End Sub

    Sub New(ByVal entidad As EC.AplicMediEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioAplicacionMedicamento() As String
        Get
            Return Entity.FolAplicMedi
        End Get
        Set(ByVal value As String)
            Entity.FolAplicMedi = value
        End Set
    End Property

    Public Property IdAlmacen() As Integer
        Get
            Return Entity.IdAlmacen
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacen = value
        End Set
    End Property

    Public Property Almacen() As AlmacenClass
        Get
            If m_Almacen Is Nothing Then
                m_Almacen = New AlmacenClass(Entity.Almacen)
            ElseIf Not m_Almacen.Codigo = IdAlmacen Then
                m_Almacen.LeerEntidad(Entity.Almacen)
            End If

            Return m_Almacen
        End Get
        Set(ByVal value As AlmacenClass)
            m_Almacen = value

            If value Is Nothing Then
                Entity.Almacen = Nothing
            Else
                Entity.Almacen = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property FolioMovimientoAlmacenSalida() As String
        Get
            Return Entity.FolioMovimientoAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacen = value

            Me.CrearListadoProductosAUsar()
        End Set
    End Property

    Public Property MovimientoAlmacenSalida() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If m_MovimientoAlmacenSalida Is Nothing Then
                m_MovimientoAlmacenSalida = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen)
            ElseIf Not m_MovimientoAlmacenSalida.IdAlmacen = IdAlmacen AndAlso _
                    Not m_MovimientoAlmacenSalida.FolioMovimientoAlmacen = FolioMovimientoAlmacenSalida Then
                m_MovimientoAlmacenSalida.Entidad = Entity.InventarioMovimientoAlmacen
            End If

            Return m_MovimientoAlmacenSalida
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            m_MovimientoAlmacenSalida = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen = Nothing
            Else
                Entity.InventarioMovimientoAlmacen = value.Entidad
            End If

            Me.CrearListadoProductosAUsar()
        End Set
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property

    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdusuarioCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdusuarioCancelacion = value
        End Set
    End Property

    Public Property FechaAplicacionMedicamento() As Date
        Get
            Return Entity.FechaAplicacionMedicamento
        End Get
        Set(ByVal value As Date)
            Entity.FechaAplicacionMedicamento = value
        End Set
    End Property

    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property FechaContabilizacion() As Nullable(Of Date)
        Get
            Return Entity.FechaContabilizacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaContabilizacion = value
        End Set
    End Property

    Public ReadOnly Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
    End Property

    Public Property TotalCabezas() As Integer
        Get
            Return Entity.TotalCabezas
        End Get
        Set(ByVal value As Integer)
            Entity.TotalCabezas = value
        End Set
    End Property

    Public Property TotalKilos() As Decimal
        Get
            Return Entity.TotalKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.TotalKilos = value
        End Set
    End Property

    Public Property CostoTotal() As Decimal
        Get
            Return Entity.CostoTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoTotal = value
        End Set
    End Property

    Public Property NumeroPoliza() As String
        Get
            Return Entity.NumPoliza
        End Get
        Set(ByVal value As String)
            Entity.NumPoliza = value
        End Set
    End Property

    Public Property Estatus() As EstatusAplicacionMedicamento
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusAplicacionMedicamento)
            Entity.Estatus = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As AplicacionMedicamentoDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New AplicacionMedicamentoDetalleCollectionClass(Entity.AplicMediDet)
            End If

            Return m_Detalle
        End Get
    End Property

    Friend ReadOnly Property ControlCantidadDeProductosUsados() As Dictionary(Of Integer, ProductosUsadoAplicacionMedicamento)
        Get
            Return Me.m_ControlCantidadProductos
        End Get
    End Property
#End Region

#Region "Metdos"
    Public Shadows Function Guardar() As Boolean
        Try
            'valido si la aplicacion es nueva
            If Entity.IsNew Then
                'valido si la aplicacion ya esta en una transaccion
                If Not ParticipatesInTransaction Then
                    ' si no esta le genero una transaccion
                    Me.Transaction = New HC.Transaction(IsolationLevel.ReadCommitted, "Aplicacion Medicamento")
                End If

                'agrego los objetos que contienen los datos para realizar la operaciones en la BD
                Me.Transaction.Add(Entity)
                Me.Transaction.Add(Detalle)

                Estatus = EstatusAplicacionMedicamento.VIGENTE

                'inicializo los datos para despues calcularlos de nuevo
                'es apra evitar que si se ejecuta mas de 1 ves el metodo guardar
                'todos los datos esten con sus valores iniciales en cada ejecucion
                Me.CostoTotal = 0D
                Me.TotalCabezas = 0
                Me.TotalKilos = 0D

                'calculo los totales
                For Each det As AplicacionMedicamentoDetalleClass In Me.Detalle
                    Me.TotalCabezas += det.Cabezas
                    Me.TotalKilos += det.kilos
                    Me.CostoTotal += det.Importe
                Next

                'genero el folio de la aplicacion de medicamento
                GenerarFolioAplicacionMedicamento()
                'guardo el cabecero de la aplicacion de medicamento
                Entity.Save()
                'guardo el detalle del la aplicacion de meciamento
                Me.Detalle.ForEach(New Action(Of AplicacionMedicamentoDetalleClass)(AddressOf Me.Detalle.Guardar))
                'inicializo los valores del movimeinto de almacen Salida de medicamento 
                'con los valores que tiene en la BD
                Me.MovimientoAlmacenSalida.Entidad.Refetch()
                'inicializo el detalle del movimiento de almacen salida de medicamento
                'con los valores que tiene en la BD
                Me.MovimientoAlmacenSalida.Detalle.RellenarMe(Me.MovimientoAlmacenSalida.Entidad.GetMultiInventarioMovimientosAlmacenDetalles(True))
                'afecto el  detalle del movmiento de almacen para aplicar el medicamento usado en esta aplicacion
                Me.AfectarMovimientoAlmacen()
            End If

            'termino la transaccion
            Me.TransactionCommit()

            Return True
        Catch ex As Exception
            'en caso de error deshago los cambios realizados en la bd dentro de la transaccion
            Me.TransactionRollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Crea un listado de productos que se pueden usar en la aplicacion de medicamento dependiendo del movimeinto de almacen
    ''' salida de medicament, para llevar el control de lo que se a aplicado, se queire aplicar y pendiente por aplicar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CrearListadoProductosAUsar()
        'Limpio el contenido del diccionario para evitar que si hubo cambio de movimeinto de almacen
        'salida de meciamento se mezclen los datos de diferentes moviemintos
        Me.ControlCantidadDeProductosUsados.Clear()

        'recorro el detalle del movimeinto y obtengo las cantidades requeridas para el control
        'de disponibiliad del medicamento en el inventario
        For Each det As AlmacenGeneral.MovimientoAlmacenDetalleClass In Me.MovimientoAlmacenSalida.Detalle
            If Me.ControlCantidadDeProductosUsados.ContainsKey(det.IdProducto) Then
                Dim controlProducto As ProductosUsadoAplicacionMedicamento = ControlCantidadDeProductosUsados(det.IdProducto)

                controlProducto.CantidadSacada += det.Cantidad
                controlProducto.CantidadUsada += det.CantidadUsada
            Else
                Me.ControlCantidadDeProductosUsados.Add(det.IdProducto, _
                                                        New ProductosUsadoAplicacionMedicamento(det.IdProducto, _
                                                        det.Cantidad, det.CantidadUsada))
            End If
        Next
    End Sub

    ''' <summary>
    ''' Genera el folio para guardar la aplicacion de medicamento. Es necesario que ya se haya inicializado la transacción
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerarFolioAplicacionMedicamento()
        Dim folio As New FoliosClass

        folio.Año = 1
        folio.Mes = 1
        folio.Codigo = CodigodeFolios.AplicacionMedicamento

        If Not folio.Guardar(Me.Transaction) Then
            Throw New Exception("No se logro generar el folio de aplicación de medicamento")
        End If

        Me.FolioAplicacionMedicamento = "A" & folio.Consecutivo.ToString("0000000")
    End Sub

    ''' <summary>
    ''' Afecta el movimiento de almacen con los medicamentos a aplicar en esta aplicacion de medicamento.
    ''' Es necesario que ya se haya inicializado la transaccion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AfectarMovimientoAlmacen()
        'inicializo la cantidad descontada para evitar problemas cuando se realizen mas de 1 intento
        'el guardado
        For Each det As AplicacionMedicamentoDetalleClass In Me.Detalle
            Me.ControlCantidadDeProductosUsados(det.IdMedicamento).CantidadDescontada = 0D
        Next

        'recorre el detalle del movimiento almacen salida de medicamento
        'para modificar la cantidad usada0
        For Each det As AlmacenGeneral.MovimientoAlmacenDetalleClass In Me.MovimientoAlmacenSalida.Detalle
            Dim productoUsado As AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento

            'obtengo el producto usado en la aplicacion
            productoUsado = Me.ControlCantidadDeProductosUsados(det.IdProducto)

            'valido si el detale del movimiento tiene suficiente disponibilidad de producto 
            'para descontar de el la cantidad adecuada
            If productoUsado.CantidadPorDescontar >= det.Cantidad - det.CantidadUsada Then
                'si no tiene suficiente cantidad disponible o es igual a la requerida
                productoUsado.CantidadDescontada += (det.Cantidad - det.CantidadUsada)
                det.CantidadUsada = det.Cantidad
            Else
                'si tiene suficiente cantidad disponible y no es igual a la requerida
                det.CantidadUsada += productoUsado.CantidadPorDescontar
                productoUsado.CantidadDescontada += productoUsado.CantidadPorDescontar
            End If

            Me.Transaction.Add(det.Entidad)
            det.Entidad.Save()
        Next
    End Sub
#End Region

#Region "Tipos Anidados"
    Public Enum EstatusAplicacionMedicamento As Byte
        CANCELADA = 0
        VIGENTE
        CONTABILIZADO
    End Enum

    Public Class ProductosUsadoAplicacionMedicamento
        Private m_IdProducto As Integer
        Private m_CantidadExistencia As Decimal
        Private m_CantidadUsada As Decimal
        Private m_CantidadDescontada As Decimal
        Private m_CantidadPorDescontar As Decimal

        Sub New(ByVal idProducto As Integer, ByVal cantidadExistencia As Decimal, ByVal cantidadUsada As Decimal)
            Me.IdProducto = IdProducto
            Me.CantidadSacada = CantidadExistencia
            Me.CantidadUsada = CantidadUsada
        End Sub

        Public Property IdProducto() As Integer
            Get
                Return m_IdProducto
            End Get
            Set(ByVal value As Integer)
                m_IdProducto = value
            End Set
        End Property

        ''' <summary>
        ''' Cantidad que salio del almacen por salida de medicamento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CantidadSacada() As Decimal
            Get
                Return m_CantidadExistencia
            End Get
            Set(ByVal value As Decimal)
                m_CantidadExistencia = value
            End Set
        End Property

        ''' <summary>
        ''' Cantidad de medicamento que a sido aplicada en el movimeinto de almacen
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CantidadUsada() As Decimal
            Get
                Return m_CantidadUsada
            End Get
            Set(ByVal value As Decimal)
                m_CantidadUsada = value
            End Set
        End Property

        ''' <summary>
        ''' Cantidad de medicamento que se quiere aplicar
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CantidaADescontar() As Decimal
            Get
                Return Me.m_CantidadPorDescontar
            End Get
            Set(ByVal value As Decimal)
                Me.m_CantidadPorDescontar = value
            End Set
        End Property

        ''' <summary>
        ''' Cantidad de medicamento que estaba pendiente por aplicar, 
        ''' que se a aplicado al movimiento de almacen dentro de una
        ''' aplicacion de medicamento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CantidadDescontada() As Decimal
            Get
                Return Me.m_CantidadDescontada
            End Get
            Set(ByVal value As Decimal)
                Me.m_CantidadDescontada = value
            End Set
        End Property

        ''' <summary>
        ''' Cantidad disponible por aplicar al movimiento de almacen
        ''' </summary>
        ''' <value>Decimal</value>
        ''' <returns>Decimal: CantidadExistencia - CantidadUsada - CantidadADescontar</returns>
        ''' <remarks></remarks>
        Public ReadOnly Property CantidadDisponible() As Decimal
            Get
                Return CantidadSacada - CantidadUsada - Me.CantidaADescontar
            End Get
        End Property

        ''' <summary>
        ''' Cantidad de medicamento pendiente por aplicar al movimeinto de almacen
        ''' en la aplicacion de medicamento
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property CantidadPorDescontar() As Decimal
            Get
                Return CantidaADescontar - CantidadDescontada
            End Get
        End Property
    End Class
#End Region
End Class