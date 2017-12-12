Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum
Imports LoteDetFields = Integralab.ORM.McecatLotesDetFieldIndex

Public Class AplicacionMedicamentoDetalleDetalleClass
    Inherits ClassBase(Of EC.AplicMediDetDetEntity)

#Region "Campos"
    Private m_AplicacionMedicamento As AplicacionMedicamentoClass
    Private m_AplicacionMedicamentoDetalle As AplicacionMedicamentoDetalleClass
    Private m_Medicamento As ProductoClass
    Private m_Lote As LoteClass
    Private m_Corral As CorralClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.AplicMediDetDetEntity
    End Sub

    Sub New(ByVal folioAplicacionMedicamento As String, ByVal idLote As Integer, ByVal idCorral As String, _
            ByVal idMedicamento As Integer, ByVal aretePropio As String)
        MyBase.New(New EC.AplicMediDetDetEntity(folioAplicacionMedicamento, idLote, idMedicamento, idCorral, aretePropio))
    End Sub

    Sub New(ByVal entidad As EC.AplicMediDetDetEntity)
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

    Public Property AplicacionMedicamentoDetalle() As AplicacionMedicamentoDetalleClass
        Get
            If Me.m_AplicacionMedicamentoDetalle Is Nothing Then
                Me.m_AplicacionMedicamentoDetalle = New AplicacionMedicamentoDetalleClass(Entity.AplicMediDet)
            ElseIf Not Me.m_AplicacionMedicamentoDetalle.FolioAplicacionMedicamento = Me.FolioAplicacionMedicamento AndAlso _
                    Not Me.m_AplicacionMedicamentoDetalle.IdLote = Me.IdLote AndAlso _
                    Not Me.m_AplicacionMedicamentoDetalle.IdCorral = Me.IdCorral AndAlso _
                    Not Me.m_AplicacionMedicamentoDetalle.IdMedicamento = Me.IdMedicamento Then
                Me.m_AplicacionMedicamentoDetalle.Entidad = Entity.AplicMediDet
            End If

            Return Me.m_AplicacionMedicamentoDetalle
        End Get
        Set(ByVal value As AplicacionMedicamentoDetalleClass)
            Me.m_AplicacionMedicamentoDetalle = value

            If value Is Nothing Then
                Entity.AplicMediDet = Nothing
            Else
                Entity.AplicMediDet = value.Entidad
            End If
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
        End Set
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

    Public Property AretePropio() As String
        Get
            Return Entity.AretePropio
        End Get
        Set(ByVal value As String)
            Entity.AretePropio = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Dim productoUsado As AplicacionMedicamentoClass.ProductosUsadoAplicacionMedicamento

            productoUsado = Me.AplicacionMedicamentoDetalle.AplicacionMedicamento.ControlCantidadDeProductosUsados(Me.IdMedicamento)

            If Me.AplicacionMedicamentoDetalle.CantidadManipulada Then
                Dim cantidadUsada As Decimal = 0D 'cantidad usada por todos los aretes
                Dim cantidadDescontaraNoAplicada As Decimal

                cantidadDescontaraNoAplicada = Me.AplicacionMedicamentoDetalle.Cantidad

                'obtengo la cantidad que se a aplicado a los aretes
                For Each det As AplicacionMedicamentoDetalleDetalleClass In Me.AplicacionMedicamentoDetalle.Detalle
                    cantidadUsada += det.Cantidad
                Next

                Me.AplicacionMedicamentoDetalle.CantidadManipulada = False

                'valido si la cantidad que se a aplicado a los aretes es 0
                'para poder saber si hay otros aretes con cantidad aplicada o este es el primero en ser modificado
                If cantidadUsada = 0D Then
                    'este arete es el primero en ser modificado
                    'por lo que se modifico el detalle de este medicamento en este lote
                    'por primera vez depues de haber modificado la cantidad en el Cabecero de
                    'este detalle. Por esta razon solo es necesario descontar la cantidad del cabecero
                    'para que los calculos siguientes se realicen con la cantidad real disponible
                    productoUsado.CantidaADescontar -= cantidadDescontaraNoAplicada
                End If
            End If

            If productoUsado.CantidadDisponible + Me.Cantidad - value >= 0D Then
                productoUsado.CantidaADescontar = productoUsado.CantidaADescontar - Me.Cantidad + value
                Entity.Cantidad = value
            ElseIf productoUsado.CantidadDisponible > 0D Then
                Entity.Cantidad += productoUsado.CantidadDisponible
                productoUsado.CantidaADescontar += productoUsado.CantidadDisponible
            End If

            Importe = Cantidad * Costo
            Me.Seleccionado = Me.Cantidad > 0D
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Entity.Costo = value
        End Set
    End Property

    Public Property Kilos() As Decimal
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
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Try
            If Not Seleccionado Then Exit Function

            Dim colLoteDet As New CC.McecatLotesDetCollection
            Dim entLoteDet As New EC.McecatLotesDetEntity

            If Me.ParticipatesInTransaction Then
                Me.Transaction.Add(Entity)
                Me.Transaction.Add(colLoteDet)
            End If

            entLoteDet.Fields(LoteDetFields.ImpteMed).ExpressionToApply = HC.McecatLotesDetFields.ImpteMed + Me.Importe

            Entity.Save()
            colLoteDet.UpdateMulti(entLoteDet, HC.McecatLotesDetFields.IdLote = Me.IdLote And _
                                    HC.McecatLotesDetFields.AretePropio = Me.AretePropio)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Eventos"
    'Private Sub AplicacionMedicamentoDetalleDetalleClass_ItemSeleccionado(ByVal sender As Object, ByRef valor As Boolean) Handles Me.ItemSeleccionado
    '    Me.Cantidad = 0D
    'End Sub
#End Region
End Class