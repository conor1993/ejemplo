Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports FIELDSCAB = Integralab.ORM.McecatLotesCabFieldIndex
Imports FIELDSDET = Integralab.ORM.McecatLotesDetFieldIndex

Public Class ProrrateoMedicamentoClass
    Inherits ClassBase(Of EC.CabProMedEntity)

#Region "Campos"
    Private m_Almacen As AlmacenClass
    Private m_MovimeintoAlmacen As AlmacenGeneral.MovimientoAlmacenClass
    Private m_Detalle As ProrrateoMedicamentoDetalleCollectionClass
    Private m_ControlCantidadProductos As New Dictionary(Of Integer, AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento)
    Private m_TotalCabezas As Integer
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.CabProMedEntity
    End Sub

    Sub New(ByVal folioProrrateo As String)
        Me.New(New EC.CabProMedEntity(folioProrrateo))
    End Sub

    Sub New(ByVal entidad As EC.CabProMedEntity)
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioProrrateo() As String
        Get
            Return Entity.FolioProrrateoMedicamento
        End Get
        Set(ByVal value As String)
            Entity.FolioProrrateoMedicamento = value
        End Set
    End Property

    Public Property FolioMovimeintoSalida() As String
        Get
            Return Entity.FolioMovimientoAlmacenSalida
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenSalida = value

            CrearListadoProductosAUsar()
        End Set
    End Property

    Public Property MovimientoAlmacenSalida() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimeintoAlmacen Is Nothing Then
                Me.m_MovimeintoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen)
            ElseIf Not Me.m_MovimeintoAlmacen.IdAlmacen = IdAlmacen AndAlso Not Me.m_MovimeintoAlmacen.FolioMovimientoAlmacen = Me.FolioMovimeintoSalida Then
                Me.m_MovimeintoAlmacen.Entidad = Entity.InventarioMovimientoAlmacen
            End If

            Return Me.m_MovimeintoAlmacen
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimeintoAlmacen = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen = Nothing
            Else
                Entity.InventarioMovimientoAlmacen = value.Entidad
            End If

            CrearListadoProductosAUsar()
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
            If Me.m_Almacen Is Nothing Then
                Me.m_Almacen = New AlmacenClass(Entity.Almacen)
            ElseIf Not Me.m_Almacen.Codigo = IdAlmacen Then
                Me.m_Almacen.LeerEntidad(Entity.Almacen)
            End If

            Return Me.m_Almacen
        End Get
        Set(ByVal value As AlmacenClass)
            Me.m_Almacen = value

            If value Is Nothing Then
                Entity.Almacen = Nothing
            Else
                Entity.Almacen = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCaptura = value
        End Set
    End Property

    Public Property FechaProrrate() As Date
        Get
            Return Entity.FechaProrrateo
        End Get
        Set(ByVal value As Date)
            Entity.FechaProrrateo = value
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

    Public Property Estatus() As EstatusProrrateoMedicamento
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusProrrateoMedicamento)
            Entity.Estatus = value
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

    Public Property NumPoliza() As String
        Get
            Return Entity.NumPoliza
        End Get
        Set(ByVal value As String)
            Entity.NumPoliza = value
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

    Public ReadOnly Property Detalle() As ProrrateoMedicamentoDetalleCollectionClass
        Get
            If Me.m_Detalle Is Nothing Then
                Me.m_Detalle = New ProrrateoMedicamentoDetalleCollectionClass
                Me.m_Detalle.RellenarMe(Entity.DetProMed)
            End If
            
            Return Me.m_Detalle
        End Get
    End Property

    Friend ReadOnly Property ControlCantidadDeProductosUsados() As Dictionary(Of Integer, AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento)
        Get
            Return Me.m_ControlCantidadProductos
        End Get
    End Property

    Friend ReadOnly Property TotalCabezas() As Integer
        Get
            Return Me.m_TotalCabezas
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Try
            If Entity.IsNew Then
                Dim lotes As New CC.McecatLotesCabCollection
                Dim lote As New EC.McecatLotesCabEntity
                Dim lotesDet As New CC.McecatLotesDetCollection
                Dim loteDet As New EC.McecatLotesDetEntity
                Dim costoXCabeza As Decimal = 0D
                Dim rel As New OC.RelationCollection

                If Not Me.ParticipatesInTransaction Then
                    Me.Transaction = New HC.Transaction(IsolationLevel.ReadCommitted, "Prorrateo Medicamento")
                End If

                Me.Transaction.Add(Entity)
                Me.Transaction.Add(Detalle)
                Me.Transaction.Add(lotes)
                Me.Transaction.Add(lotesDet)

                Me.CostoTotal = 0D
                Me.Estatus = EstatusProrrateoMedicamento.VIGENTE

                For Each det As ProrrateoMedicamentoDetalleClass In Detalle
                    If det.Cantidad = 0D Then
                        Throw New Exception("El medicamento " & det.Medicamento.Descripcion & " debe tener una cantidad a prorratear")
                    End If

                    CostoTotal += det.Importe
                Next

                rel.Add(EC.McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

                Me.m_TotalCabezas = lotes.GetScalar(Integralab.ORM.McecatLotesCabFieldIndex.SaldoCabezas, _
                                New OC.Expression(HC.McecatLotesCabFields.SaldoCabezas), _
                                SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Sum, _
                                HC.McecatLotesCabFields.Estatus = EstatusEnum.ACTIVO)

                costoXCabeza = Me.CostoTotal / TotalCabezas

                lote.Fields(FIELDSCAB.SaldoImpteMed).ExpressionToApply = _
                            HC.McecatLotesCabFields.SaldoImpteMed + (HC.McecatLotesCabFields.SaldoCabezas * costoXCabeza)
                lote.Fields(FIELDSCAB.AcumImpteMedic).ExpressionToApply = _
                            HC.McecatLotesCabFields.AcumImpteMedic + (HC.McecatLotesCabFields.SaldoCabezas * costoXCabeza)
                loteDet.Fields(FIELDSDET.ImpteMed).ExpressionToApply = HC.McecatLotesDetFields.ImpteMed + costoXCabeza

                lotes.UpdateMulti(lote, HC.McecatLotesCabFields.Estatus = EstatusEnum.ACTIVO)
                lotesDet.UpdateMulti(loteDet, HC.McecatLotesCabFields.Estatus = EstatusEnum.ACTIVO, rel)

                GenerarFolio()
                Entity.Save()
                Me.Detalle.Guardar()
                Me.AfectarMovimientoAlmacen()
            End If

            Me.TransactionCommit()

            Return True
        Catch ex As Exception
            If Me.ParticipatesInTransaction Then Me.TransactionRollback()
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
                Dim controlProducto As AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento = ControlCantidadDeProductosUsados(det.IdProducto)

                controlProducto.CantidadSacada += det.Cantidad
                controlProducto.CantidadUsada += det.CantidadUsada
            Else
                Me.ControlCantidadDeProductosUsados.Add(det.IdProducto, _
                                                        New AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento(det.IdProducto, _
                                                        det.Cantidad, det.CantidadUsada))
            End If
        Next
    End Sub

    ''' <summary>
    ''' Genera el folio para guardar la aplicacion de medicamento. Es necesario que ya se haya inicializado la transacción
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerarFolio()
        Dim folio As New FoliosClass

        folio.Año = 1
        folio.Mes = 1
        folio.Codigo = CodigodeFolios.ProrrateoMedicamento

        If Not folio.Guardar(Me.Transaction) Then
            Throw New Exception("No se logro generar el folio de aplicación de medicamento")
        End If

        Me.FolioProrrateo = "P" & folio.Consecutivo.ToString("0000000")
    End Sub

    ''' <summary>
    ''' Afecta el movimiento de almacen con los medicamentos a aplicar en esta aplicacion de medicamento.
    ''' Es necesario que ya se haya inicializado la transaccion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AfectarMovimientoAlmacen()
        'inicializo la cantidad descontada para evitar problemas cuando se realizen mas de 1 intento
        'el guardado
        For Each det As ProrrateoMedicamentoDetalleClass In Me.Detalle
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
    Public Enum EstatusProrrateoMedicamento
        CANCELADO = 0
        VIGENTE
        CONTABILIZADO
    End Enum
#End Region
End Class