Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProrrateoMedicamentoDetalleClass
    Inherits ClassBase(Of EC.DetProMedEntity)

#Region "Campos"
    Private m_ProrrateoMedicamento As ProrrateoMedicamentoClass
    Private m_Medicamento As ProductoClass
    Private m_Detalle As ProrrateoMedicamentoDetalleDetalleCollectionClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.DetProMedEntity
    End Sub

    Sub New(ByVal folioProrrateo As String, ByVal idMedicamento As Integer)
        Me.New(New EC.DetProMedEntity(folioProrrateo, idMedicamento))
    End Sub

    Sub New(ByVal entidad As EC.DetProMedEntity)
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioProrrateoMedicamento() As String
        Get
            Return Entity.FolioProrrateoMedicamento
        End Get
        Set(ByVal value As String)
            Entity.FolioProrrateoMedicamento = value
        End Set
    End Property

    Public Property IdMedicamento() As Integer
        Get
            Return Entity.IdMedicamento
        End Get
        Set(ByVal value As Integer)
            Entity.IdMedicamento = value

            Me.ObtenerCosto()
        End Set
    End Property

    Public Property ProrrateoMedicamento() As ProrrateoMedicamentoClass
        Get
            If Me.m_ProrrateoMedicamento Is Nothing Then
                Me.m_ProrrateoMedicamento = New ProrrateoMedicamentoClass(Entity.CabProMed)
            ElseIf Not Me.m_ProrrateoMedicamento.FolioMovimeintoSalida = Me.FolioProrrateoMedicamento Then
                Me.m_ProrrateoMedicamento.Entidad = Entity.CabProMed
            End If

            Return Me.m_ProrrateoMedicamento
        End Get
        Set(ByVal value As ProrrateoMedicamentoClass)
            Me.m_ProrrateoMedicamento = value

            If value Is Nothing Then
                Entity.CabProMed = Nothing
            Else
                Entity.CabProMed = value.Entidad
            End If
        End Set
    End Property

    Public Property Medicamento() As ProductoClass
        Get
            If Me.m_Medicamento Is Nothing Then
                Me.m_Medicamento = New ProductoClass(Entity.Producto)
            ElseIf Not Me.m_Medicamento.Codigo = IdMedicamento Then
                Me.m_Medicamento.Entidad = Entity.Producto
            End If

            Return Me.m_Medicamento
        End Get
        Set(ByVal value As ProductoClass)
            Me.m_Medicamento = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.Entidad
            End If

            Me.ObtenerCosto()
        End Set
    End Property

    Public ReadOnly Property UnidadMedida() As String
        Get
            Return Me.Medicamento.UnidadMedida.DescCorta
        End Get
    End Property

    Public Property CostoPromedio() As Decimal
        Get
            Return Entity.CostoProm
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoProm = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Dim productoUsado As AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento

            productoUsado = Me.ProrrateoMedicamento.ControlCantidadDeProductosUsados(Me.IdMedicamento)

            If productoUsado.CantidadDisponible + Me.Cantidad - value >= 0D Then
                productoUsado.CantidaADescontar = productoUsado.CantidaADescontar - Me.Cantidad + value
                Entity.Cantidad = value
            ElseIf productoUsado.CantidadDisponible > 0D Then
                Entity.Cantidad = productoUsado.CantidadDisponible
                productoUsado.CantidaADescontar += productoUsado.CantidadDisponible
            End If
        End Set
    End Property

    Public Property CostoPorCabeza() As Decimal
        Get
            Return Entity.CostoXcab
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoXcab = value
        End Set
    End Property

    Public ReadOnly Property Importe() As Decimal
        Get
            Return Me.CostoPromedio * Me.Cantidad
        End Get
    End Property

    Public ReadOnly Property Detalle() As ProrrateoMedicamentoDetalleDetalleCollectionClass
        Get
            If Me.m_Detalle Is Nothing Then
                Me.m_Detalle = New ProrrateoMedicamentoDetalleDetalleCollectionClass
                Me.m_Detalle.RellenarMe(Entity.DetDproMed)
            End If

            Return Me.m_Detalle
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Try
            If Me.ParticipatesInTransaction Then
                Me.Transaction.Add(Entity)
                Me.Transaction.Add(Detalle)
            End If

            Me.CostoPorCabeza = Me.Importe / Me.ProrrateoMedicamento.TotalCabezas

            Entity.Save()
            GenerarDetalle()
            Detalle.Guardar()

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub GenerarDetalle()
        Dim lotes As New CC.McecatLotesCabCollection

        Me.Transaction.Add(lotes)
        lotes.GetMulti(HC.McecatLotesCabFields.Estatus = EstatusEnum.ACTIVO)

        For Each lote As EC.McecatLotesCabEntity In lotes
            Dim det As New ProrrateoMedicamentoDetalleDetalleClass

            det.ProrrateoMedicamentoDetalle = Me
            det.IdLote = lote.IdLote
            det.CostoPorMedicamento = Me.CostoPorCabeza * lote.SaldoCabezas

            Me.Detalle.Add(det)
        Next
    End Sub

    Private Sub ObtenerCosto()
        Try
            Dim col As New CC.InventarioMovimientoAlmacenDetallesCollection

            Me.CostoPromedio = CDec(col.GetScalar(Integralab.ORM.InventarioMovimientoAlmacenDetallesFieldIndex.Costo, _
                        New OC.Expression(HC.InventarioMovimientoAlmacenDetallesFields.Costo), _
                        SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                        HC.InventarioMovimientoAlmacenDetallesFields.ProductoId = _
                        IdMedicamento And HC.InventarioMovimientoAlmacenDetallesFields.FolioMovimiento = _
                        Me.ProrrateoMedicamento.FolioMovimeintoSalida))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region
End Class