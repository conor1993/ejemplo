Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
Imports LoteCabFields = Integralab.ORM.McecatLotesCabFieldIndex
Imports CorralDetFields = Integralab.ORM.McecatCorralesDetFieldIndex

Public Class AplicacionMedicamentoDetalleClass
    Inherits ClassBase(Of EC.AplicMediDetEntity)

#Region "Campos"
    Private m_AplicacionMedicamento As AplicacionMedicamentoClass
    Private m_Medicamento As ProductoClass
    Private m_Lote As LoteClass
    Private m_Corral As CorralClass
    Private m_Detalle As AplicacionMedicamentoDetalleDetalleCollectionClass
    Private m_CantidadManipulada As Boolean = False
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.AplicMediDetEntity
    End Sub

    Sub New(ByVal folioAplicacionMedicamento As String, ByVal idLote As Integer, ByVal idMedicamento As Integer, ByVal idCorral As String)
        MyBase.New(New EC.AplicMediDetEntity(folioAplicacionMedicamento, idLote, idMedicamento, idCorral))
    End Sub

    Sub New(ByVal entidad As EC.AplicMediDetEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioAplicacionMedicamento() As String
        Get
            Return Entity.FolioAplicacionMedicamento
        End Get
        Set(ByVal value As String)
            Entity.FolioAplicacionMedicamento = value
        End Set
    End Property

    Public Property AplicacionMedicamento() As AplicacionMedicamentoClass
        Get
            If m_AplicacionMedicamento Is Nothing Then
                m_AplicacionMedicamento = New AplicacionMedicamentoClass
            ElseIf Not m_AplicacionMedicamento.FolioAplicacionMedicamento = FolioAplicacionMedicamento Then
                m_AplicacionMedicamento.Entidad = Entity.AplicMedi
            End If

            Return m_AplicacionMedicamento
        End Get
        Set(ByVal value As AplicacionMedicamentoClass)
            m_AplicacionMedicamento = value

            If value Is Nothing Then
                Entity.AplicMedi = Nothing
            Else
                Entity.AplicMedi = value.Entidad
            End If
        End Set
    End Property

    Public Property IdLote() As Integer
        Get
            Return Entity.IdLote
        End Get
        Set(ByVal value As Integer)
            Entity.IdLote = value

            Me.IdCorral = Lote.IdCorral
        End Set
    End Property

    Public Property Lote() As LoteClass
        Get
            If m_Lote Is Nothing Then
                m_Lote = New LoteClass(Entity.McecatLotesCab)
            ElseIf Not m_Lote.IdLote = IdLote Then
                m_Lote.Entidad = Entity.McecatLotesCab
            End If

            Return m_Lote
        End Get
        Set(ByVal value As LoteClass)
            m_Lote = value

            If value Is Nothing Then
                Entity.McecatLotesCab = Nothing
            Else
                Entity.McecatLotesCab = value.Entidad
            End If
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

    Public Property Medicamento() As ProductoClass
        Get
            If m_Medicamento Is Nothing Then
                m_Medicamento = New ProductoClass(Entity.Producto)
            ElseIf Not m_Medicamento.Codigo = IdMedicamento Then
                m_Medicamento.Entidad = Entity.Producto
            End If

            Return m_Medicamento
        End Get
        Set(ByVal value As ProductoClass)
            m_Medicamento = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.Entidad
            End If

            Me.ObtenerCosto()
        End Set
    End Property

    Public ReadOnly Property NombreMedicamento() As String
        Get
            Return Medicamento.Descripcion
        End Get
    End Property

    Public ReadOnly Property NombreUnidad() As String
        Get
            Return Medicamento.UnidadMedida.Descripcion
        End Get
    End Property

    Public Property IdCorral() As String
        Get
            Return Entity.IdCorral
        End Get
        Set(ByVal value As String)
            Entity.IdCorral = value
        End Set
    End Property

    Public Property Corral() As CorralClass
        Get
            If m_Corral Is Nothing Then
                m_Corral = New CorralClass(Entity.McecatCorralesCab)
            ElseIf Not m_Corral.IdCorral = IdCorral Then
                m_Corral.Entidad = Entity.McecatCorralesCab
            End If

            Return m_Corral
        End Get
        Set(ByVal value As CorralClass)
            m_Corral = value

            If value Is Nothing Then
                Entity.McecatCorralesCab = Nothing
            Else
                Entity.McecatCorralesCab = value.Entidad
            End If
        End Set
    End Property

    Public Property EsMedicamentoTrabajo() As Boolean
        Get
            Return Entity.BooTrab
        End Get
        Set(ByVal value As Boolean)
            Entity.BooTrab = value
        End Set
    End Property

    Public Property EsMedicamentoReimplante() As Boolean
        Get
            Return Entity.BooReim
        End Get
        Set(ByVal value As Boolean)
            Entity.BooReim = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Dim productoUsado As AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento

            productoUsado = Me.AplicacionMedicamento.ControlCantidadDeProductosUsados(Me.IdMedicamento)

            InicializarCantidadPorCabeza()

            If productoUsado.CantidadDisponible + Me.Cantidad - value >= 0D Then
                productoUsado.CantidaADescontar = productoUsado.CantidaADescontar - Me.Cantidad + value
                Entity.Cantidad = value
            ElseIf productoUsado.CantidadDisponible > 0D Then
                Entity.Cantidad += productoUsado.CantidadDisponible
                productoUsado.CantidaADescontar += productoUsado.CantidadDisponible
            End If

            Importe = Cantidad * Costo
            Me.CantidadManipulada = True
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return Entity.CosProm
        End Get
        Set(ByVal value As Decimal)
            Entity.CosProm = value

            Me.Importe = Costo * Cantidad
        End Set
    End Property

    Public Property Cabezas() As Short
        Get
            Return Entity.Cabezas
        End Get
        Set(ByVal value As Short)
            Entity.Cabezas = value
        End Set
    End Property

    Public Property kilos() As Decimal
        Get
            Return Entity.Kilos
        End Get
        Set(ByVal value As Decimal)
            Entity.Kilos = value
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

    Public ReadOnly Property Detalle() As AplicacionMedicamentoDetalleDetalleCollectionClass
        Get
            ConsultarAretes()

            Return m_Detalle
        End Get
    End Property

    Public Property CantidadManipulada() As Boolean
        Get
            Return Me.m_CantidadManipulada
        End Get
        Set(ByVal value As Boolean)
            Me.m_CantidadManipulada = value
        End Set
    End Property

    Public ReadOnly Property FechaAplicacion() As Date
        Get
            Return AplicacionMedicamento.FechaAplicacionMedicamento
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub ConsultarAretes()
        Try
            If Me.m_Detalle Is Nothing Then
                Me.m_Detalle = New AplicacionMedicamentoDetalleDetalleCollectionClass

                If Entity.IsNew Then
                    Dim detalleLote As New CC.McecatLotesDetCollection

                    detalleLote.GetMulti(HC.McecatLotesDetFields.IdLote = Me.IdLote, 0, _
                                        New OC.SortExpression(New OC.SortClause(HC.McecatLotesDetFields.AretePropio, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

                    For Each detLote As EC.McecatLotesDetEntity In detalleLote
                        Dim det As New AplicacionMedicamentoDetalleDetalleClass

                        det.AplicacionMedicamentoDetalle = Me
                        det.AretePropio = detLote.AretePropio
                        det.Costo = Me.Costo
                        det.Kilos = detLote.KilosEntrada + (detLote.McecatLotesCab.Gdpini * _
                                    (Me.AplicacionMedicamento.FechaAplicacionMedicamento - detLote.FechaEntrada).Days)
                    Next
                Else
                    Me.m_Detalle.RellenarMe(Entity.AplicMediDetDet)

                    For Each det As AplicacionMedicamentoDetalleDetalleClass In Me.Detalle
                        det.Seleccionado = True
                    Next
                End If
            Else
                If Entity.IsNew AndAlso Not Lote.Entidad.IsNew AndAlso _
                   Not Me.Medicamento.Entidad.IsNew AndAlso Me.m_Detalle.Count = 0 Then
                    Dim detalleLote As New CC.McecatLotesDetCollection

                    detalleLote.GetMulti(HC.McecatLotesDetFields.IdLote = Me.IdLote, 0, _
                                        New OC.SortExpression(New OC.SortClause(HC.McecatLotesDetFields.AretePropio, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

                    Me.m_Detalle.Clear()

                    For Each detLote As EC.McecatLotesDetEntity In detalleLote
                        Dim det As New AplicacionMedicamentoDetalleDetalleClass

                        det.AplicacionMedicamentoDetalle = Me
                        det.AretePropio = detLote.AretePropio
                        det.Costo = Me.Costo
                        det.Kilos = detLote.KilosEntrada + (detLote.McecatLotesCab.Gdpini * _
                                    (Me.AplicacionMedicamento.FechaAplicacionMedicamento - detLote.FechaEntrada).Days)
                        Me.m_Detalle.Add(det)
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ObtenerCosto()
        Try
            Dim col As New CC.InventarioMovimientoAlmacenDetallesCollection

            Me.Costo = CDec(col.GetScalar(Integralab.ORM.InventarioMovimientoAlmacenDetallesFieldIndex.Costo, _
                        New OC.Expression(HC.InventarioMovimientoAlmacenDetallesFields.Costo), _
                        SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                        HC.InventarioMovimientoAlmacenDetallesFields.ProductoId = _
                        IdMedicamento And HC.InventarioMovimientoAlmacenDetallesFields.FolioMovimiento = _
                        Me.AplicacionMedicamento.FolioMovimientoAlmacenSalida))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Shadows Function Guardar() As Boolean
        Try
            Dim colLote As New CC.McecatLotesCabCollection
            Dim colCorralDet As New CC.McecatCorralesDetCollection
            Dim entlote As New EC.McecatLotesCabEntity
            Dim entCorralDet As New EC.McecatCorralesDetEntity
            Dim importexCabeza As Decimal
            Dim numeroCabezas As Integer

            If Me.ParticipatesInTransaction Then
                Me.Transaction.Add(Entity)
                Me.Transaction.Add(colLote)
                Me.Transaction.Add(colCorralDet)
                Me.Transaction.Add(Detalle)
            End If

            numeroCabezas = CInt(colCorralDet.GetScalar(Integralab.ORM.McecatCorralesDetFieldIndex.ExistCabezas, _
                                New OC.Expression(HC.McecatCorralesDetFields.ExistCabezas), _
                                SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Sum, _
                                HC.McecatCorralesDetFields.IdCorral = Me.IdCorral))
            importexCabeza = Me.Importe / numeroCabezas

            entlote.Fields(LoteCabFields.SaldoImpteMed).ExpressionToApply = _
                                                                HC.McecatLotesCabFields.SaldoImpteMed + Me.Importe
            entlote.Fields(LoteCabFields.AcumImpteMedic).ExpressionToApply = _
                                                    HC.McecatLotesCabFields.AcumImpteMedic + Me.Importe
            entCorralDet.Fields(CorralDetFields.ImpteMedicamento).ExpressionToApply = _
                                                    HC.McecatCorralesDetFields.ImpteMedicamento + _
                                                    (HC.McecatCorralesDetFields.ExistCabezas * importexCabeza)
            Entity.Save()
            colLote.UpdateMulti(entlote, HC.McecatLotesCabFields.IdLote = Me.IdLote)
            colCorralDet.UpdateMulti(entCorralDet, HC.McecatCorralesDetFields.IdCorral = Me.IdCorral)

            Me.Detalle.ForEach(New Action(Of AplicacionMedicamentoDetalleDetalleClass)(AddressOf Me.Detalle.guardar))

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ProrratearCantidad()
        Dim cantidadCabezas As Integer = Me.Detalle.Count
        Dim cantidaRepartir As Decimal = 0D

        cantidaRepartir = Me.Cantidad / cantidadCabezas

        For Each arete As AplicacionMedicamentoDetalleDetalleClass In Me.Detalle
            arete.Entidad.Cantidad = cantidaRepartir
        Next
    End Sub

    Private Sub InicializarCantidadPorCabeza()
        'Dim cantidadRestada As Decimal = 0D

        For Each arete As AplicacionMedicamentoDetalleDetalleClass In Me.Detalle
            'cantidadRestada -= arete.Cantidad
            arete.Entidad.Cantidad = 0D
            arete.Seleccionado = False
        Next

        'Me.AplicacionMedicamento.ControlCantidadDeProductosUsados(Me.IdMedicamento).CantidaADescontar -= cantidadRestada
    End Sub
#End Region
End Class