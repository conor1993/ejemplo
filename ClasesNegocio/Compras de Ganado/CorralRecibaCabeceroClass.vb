Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CorralRecibaCabeceroClass
    Inherits EC.CorralRecibaCabEntity

#Region "Declaraciones"
    Private _Rastro As RastroClass
    Private _Corral As CorralClass
    Private _LoteDestino As LoteClass
    Private _CausaMuerte As CausaMuertesClass
    Private _Poliza As PolizaClass
    Private _Detalle As CorralRecibaDetalleCollectionClass
    Private _MovimientoGanado As MovimientoGanadoClass

    Public Enum TipoReciba As Byte
        Rastro = 1
        Venta = 2
        Muerte = 3
        Corral = 4
    End Enum
#End Region

#Region "Constructores"
    Sub New(ByVal IdCorralReciba As Integer)
        MyBase.FetchUsingPK(IdCorralReciba)
    End Sub

    Sub New(ByVal Entidad As EC.CorralRecibaCabEntity)
        If Not MyBase.FetchUsingPK(Entidad.IdCorralReciba) AndAlso Not Entidad.IsDirty Then
            Me.IdCorral = Entidad.IdCorral
            Me.IdLoteDestino = Entidad.IdLoteDestino
            Me.IdPoliza = Entidad.IdPoliza
            Me.IdVenta = Entidad.IdVenta
            Me.IdRastro = Entidad.IdRastro
            Me.CostoAlimento = Entidad.CostoAlimento
            Me.CostoEntrada = Entidad.CostoEntrada
            Me.CostoMedicina = Entidad.CostoMedicina
            Me.CostoMovto = Entidad.CostoMovto
            Me.CostoxKilo = Entidad.CostoxKilo
            Me.Fecha = Entidad.Fecha
            Me.FecConta = Entidad.FecConta
            Me.Estatus = Entidad.Estatus
            Me.Cabezas = Entidad.Cabezas
            Me.Kilos = Entidad.Kilos
            Me.KilosAlimento = Entidad.KilosAlimento
            Me.IdTipoReciba = Entidad.IdTipoReciba
            Me.Aviso = Entidad.Aviso
            Me.IdCausaMuerte = Entidad.IdCausaMuerte
            Me.Recuperacion = Entidad.Recuperacion
            Me.ImporteVenta = Entidad.ImporteVenta
            Me.FolioMovimientoGanado = Entidad.FolioMovimientoGanado
            Me.IsNew = True
            Me.IsDirty = Entidad.IsDirty
        End If
    End Sub

    Sub New(ByVal IdCorral As String, ByVal IdLoteDestino As Integer, ByVal IdRastro As Integer, ByVal IdVenta As Integer, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoAlimento As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoMedicina As Decimal, ByVal CostoMovto As Nullable(Of Decimal), ByVal CostoxKilo As Decimal, ByVal Fecha As Date, ByVal Estatus As Byte, ByVal FecConta As Date, ByVal IdPoliza As Nullable(Of Integer), ByVal IdTipoReciba As Byte, ByVal Aviso As String, ByVal IdCausaMuerte As Byte, ByVal Recuperacion As Boolean, ByVal ImporteVenta As Decimal, ByVal FolioMovimientoGanado As String)
        Me.IdCorral = IdCorral
        Me.IdLoteDestino = IdLoteDestino
        Me.IdPoliza = IdPoliza
        Me.IdRastro = IdRastro
        Me.IdVenta = IdVenta
        Me.CostoAlimento = CostoAlimento
        Me.CostoEntrada = CostoEntrada
        Me.CostoMedicina = CostoMedicina
        Me.CostoMovto = CostoMovto
        Me.CostoxKilo = CostoxKilo
        Me.Fecha = Fecha
        Me.FecConta = FecConta
        Me.Estatus = Estatus
        Me.Cabezas = Cabezas
        Me.Kilos = Kilos
        Me.KilosAlimento = KilosAlimento
        Me.IdTipoReciba = IdTipoReciba
        Me.Aviso = Aviso
        Me.IdCausaMuerte = IdCausaMuerte
        Me.Recuperacion = Recuperacion
        Me.ImporteVenta = ImporteVenta
        Me.FolioMovimientoGanado = FolioMovimientoGanado
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public Shadows Property Estatus() As EstatusDatos
        Get
            Return MyBase.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            MyBase.Estatus = value
        End Set
    End Property

    Public Shadows Property IdTipoReciba() As TipoReciba
        Get
            Return MyBase.IdTipoReciba
        End Get
        Set(ByVal value As TipoReciba)
            MyBase.IdTipoReciba = value
        End Set
    End Property

    Public Overrides Property CostoxKilo() As Decimal
        Get
            Return MyBase.CostoxKilo
        End Get
        Set(ByVal value As Decimal)
            MyBase.CostoxKilo = value
        End Set
    End Property

    Public ReadOnly Property Folio() As String
        Get
            Return "R" & IdCorralReciba.ToString().PadLeft(10, "0")
        End Get
    End Property

    Public ReadOnly Property Rastro() As RastroClass
        Get
            If _Rastro Is Nothing OrElse (Me.IdRastro.HasValue AndAlso _Rastro.IdRastro <> Me.IdRastro.Value) Then
                _Rastro = New RastroClass(Me.CatRastros)
            End If
            Return _Rastro
        End Get
    End Property

    Public ReadOnly Property Corral() As CorralClass
        Get
            If _Corral Is Nothing OrElse _Corral.IdCorral <> Me.IdCorral Then
                _Corral = New CorralClass(Me.McecatCorralesCab)
            End If
            Return _Corral
        End Get
    End Property

    Public ReadOnly Property LoteDestino() As LoteClass
        Get
            If _LoteDestino Is Nothing OrElse (Me.IdLoteDestino.HasValue AndAlso _LoteDestino.IdLote <> Me.IdLoteDestino.Value) Then
                _LoteDestino = New LoteClass(Me.McecatLotesCab)
            End If
            Return _LoteDestino
        End Get
    End Property

    Public ReadOnly Property CausaMuerte() As CausaMuertesClass
        Get
            If _CausaMuerte Is Nothing OrElse (Me.IdCausaMuerte.HasValue AndAlso _CausaMuerte.IdCausaMuerte <> Me.IdCausaMuerte.Value) Then
                _CausaMuerte = New CausaMuertesClass(Me.McgcatCausasMuerte)
            End If
            Return _CausaMuerte
        End Get
    End Property

    Public Shadows ReadOnly Property Poliza() As PolizaClass
        Get
            If _Poliza Is Nothing Then
                _Poliza = New PolizaClass(MyBase.Poliza)
            End If
            Return _Poliza
        End Get
    End Property

    Public Property MovimientoGanado() As MovimientoGanadoClass
        Get
            If _MovimientoGanado Is Nothing OrElse _MovimientoGanado.FolioMovimeinto <> Me.FolioMovimientoGanado Then
                _MovimientoGanado = New MovimientoGanadoClass(Me.CabMovGan)
            End If
            Return _MovimientoGanado
        End Get
        Set(ByVal value As MovimientoGanadoClass)
            _MovimientoGanado = value

            If value Is Nothing Then
                Me.CabMovGan = Nothing
            Else
                Me.CabMovGan = value.Entidad
            End If
        End Set
    End Property

    Public ReadOnly Property Detalles() As CorralRecibaDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New CorralRecibaDetalleCollectionClass(Me)

                For Each _Det As EC.CorralRecibaDetEntity In Me.CorralRecibaDet
                    _Detalle.Add(_Det)
                Next
            End If
            Return _Detalle
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Function CalcularTotalCabezas() As Decimal
        Dim TotalCabezas As Integer = 0

        For Each Detalle As CorralRecibaDetalleClass In Me.Detalles
            TotalCabezas += Detalle.Cabezas
        Next
        Me.Cabezas = TotalCabezas
        Return Me.Cabezas
    End Function

    Public Function CalcularTotalKilos() As Decimal
        Dim TotalKilos As Decimal = 0D

        For Each Detalle As CorralRecibaDetalleClass In Me.Detalles
            TotalKilos += Detalle.Kilos
        Next
        Me.Kilos = TotalKilos
        Return Me.Kilos
    End Function

    Public Function CalcularCostoAlimento() As Decimal
        Me.CostoAlimento = 0D

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoAlimento += detalle.CostoAlimento
            End If
        Next
        Return Me.CostoAlimento
    End Function

    Public Function CalcularCostoEntrada() As Decimal
        Me.CostoEntrada = 0D

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoEntrada += detalle.CostoEntrada
            End If
        Next
        Return Me.CostoEntrada
    End Function

    Public Function CalcularCostoMedicina() As Decimal
        Me.CostoMedicina = 0D

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoMedicina += detalle.CostoMedicina
            End If
        Next
        Return Me.CostoMedicina
    End Function

    Public Function CalcularKilosAlimentos() As Decimal
        Me.KilosAlimento = 0D

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.KilosAlimento += detalle.KilosAlimento
            End If
        Next
        Return Me.KilosAlimento
    End Function

    Public Function CalcularCostoxKilo() As Decimal
        Me.CostoxKilo = 0D
        Dim NumDetalles As Integer = 0

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoxKilo += detalle.CostoxKilo
                NumDetalles += 1
            End If
        Next
        Me.CostoxKilo = Me.CostoxKilo / NumDetalles
        Return Me.CostoxKilo / NumDetalles
    End Function

    Public Function CalcularCostoMovimiento() As Decimal
        Me.CostoMovto = 0D

        For Each detalle As CorralRecibaDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoMovto += detalle.Importe
            End If
        Next
        Return Me.CostoMovto
    End Function

    Public Sub Calcular()
        CalcularCostoAlimento()
        CalcularCostoEntrada()
        CalcularCostoMedicina()
        CalcularCostoMovimiento()
        CalcularCostoxKilo()
        CalcularKilosAlimentos()
        CalcularTotalCabezas()
        CalcularTotalKilos()
    End Sub

    Private Sub GuardarDetalle(ByRef Trans As HC.Transaction)
        Trans.Add(Me.CorralRecibaDet)
        Me.CorralRecibaDet.DeleteMulti()

        For i As Integer = 0 To Me.Detalles.Count - 1
            If Me.Detalles(i).IsDirty OrElse Not Me.Detalles(i).IsNew Then
                Trans.Add(Me.Detalles(i))
                Me.Detalles(i).IdCorralRecibaDet = i + 1
                Me.Detalles(i).IsNew = True
                Me.Detalles(i).Save()
            End If
        Next
    End Sub

    Friend Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Calcular()
        Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusDatos.VIGENTE
        Me.Save()
        GuardarDetalle(Trans)
    End Sub

    Friend Sub Cancelar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusDatos.CANCELADO
        Me.Save()
    End Sub
#End Region
End Class

Public Class CorralRecibaCabeceroCollectionClass
    Inherits ColleccionBase(Of CorralRecibaCabeceroClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As CorralRecibaCabeceroClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.CorralRecibaCabEntity)
        Me.Add(New CorralRecibaCabeceroClass(Entidad))
    End Sub
#End Region
End Class