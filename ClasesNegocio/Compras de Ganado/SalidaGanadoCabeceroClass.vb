Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class SalidaGanadoCabeceroClass
    Inherits EC.SalidaGanadoCabEntity

#Region "Miembros"

    Private _Rastro As RastroClass = Nothing
    Private _Corral As CorralClass = Nothing
    Private _LoteDestino As LoteClass = Nothing
    Private _LoteOrigen As LoteClass = Nothing
    Private _CausaMuerte As CausaMuertesClass = Nothing
    Private _Poliza As PolizaClass = Nothing
    Private _Detalle As SalidaGanadoDetalleCollectionClass = Nothing
    Private _MovimientoGanado As MovimientoGanadoClass = Nothing
    Private _Lotes_y_TiposGanado As dsLotesTiposGanado.LoteTipoGanadoDataTable

    Public Enum EstatusSalida As Byte
        CANCELADO = 0
        VIGENTE
        FACTURADO
    End Enum

    Public Enum TipoSalida As Byte
        Corral_de_Reciba_a_Rastro = 1
        Corral_de_Reciba_a_Venta = 2
        Corral_de_Reciba_por_Muerte = 3
        Transferencia_de_Reciba_a_Corral = 4
        Corral_de_Engorda_a_Rastro = 5
        Corral_de_Engorda_a_Venta = 6
        Corral_de_Engorda_por_Muerte = 7
        Corral_de_Engorda_por_Tranferencia = 8
    End Enum

#End Region

#Region "Constructores"
    Sub New(ByVal IdSalidaGanadoCab As Integer)
        MyBase.FetchUsingPK(IdSalidaGanadoCab)
    End Sub

    Sub New(ByVal Entidad As EC.SalidaGanadoCabEntity)
        If Not MyBase.FetchUsingPK(Entidad.IdSalidaGanadoCab) AndAlso Not Entidad.IsDirty Then
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
            Me.CostoIndirecto = Entidad.CostoIndirecto
            Me.IsNew = True
            Me.IsDirty = Entidad.IsDirty
        End If
    End Sub

    Sub New(ByVal IdCorral As String, ByVal IdLoteDestino As Integer, ByVal IdRastro As Integer, ByVal IdVenta As Integer, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoAlimento As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoMedicina As Decimal, ByVal CostoMovto As Nullable(Of Decimal), ByVal CostoxKilo As Decimal, ByVal Fecha As Date, ByVal Estatus As Byte, ByVal FecConta As Date, ByVal IdPoliza As Nullable(Of Integer), ByVal IdTipoReciba As Byte, ByVal Aviso As String, ByVal IdCausaMuerte As Byte, ByVal Recuperacion As Boolean, ByVal ImporteVenta As Decimal, ByVal FolioMovimientoGanado As String, ByVal CostoIndirecto As Decimal)
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
        Me.CostoIndirecto = CostoIndirecto
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"

    Public Shadows Property Estatus() As EstatusSalida
        Get
            Return MyBase.Estatus
        End Get
        Set(ByVal value As EstatusSalida)
            MyBase.Estatus = value
        End Set
    End Property

    Public Shadows Property IdTipoReciba() As TipoSalida
        Get
            Return MyBase.IdTipoReciba
        End Get
        Set(ByVal value As TipoSalida)
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

    Public ReadOnly Property Detalles() As SalidaGanadoDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New SalidaGanadoDetalleCollectionClass(Me)

                For Each _Det As EC.SalidaGanadoDetEntity In Me.SalidaGanadoDet
                    _Detalle.Add(_Det)
                Next
            End If
            Return _Detalle
        End Get
    End Property

    Public ReadOnly Property LoteOrigen() As LoteClass
        Get
            If Me.IdTipoReciba = TipoSalida.Corral_de_Engorda_por_Tranferencia Then
                If _LoteOrigen Is Nothing AndAlso Me.Detalles.Count > 0 Then
                    _LoteOrigen = New LoteClass(Me.Detalles(0).IdLote)
                ElseIf Me.Detalles.Count > 0 AndAlso Me.Detalles(0).IdLote.Value <> _LoteDestino.IdLote Then
                    _LoteOrigen = New LoteClass(Me.Detalles(0).IdLote)
                Else
                    _LoteOrigen = New LoteClass()
                End If
                Return _LoteOrigen
            Else
                Return Nothing
            End If
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Function Lotes_y_TiposGanado() As dsLotesTiposGanado.LoteTipoGanadoDataTable
        If _Lotes_y_TiposGanado Is Nothing Then
            _Lotes_y_TiposGanado = New dsLotesTiposGanado.LoteTipoGanadoDataTable()

            For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In Me.Detalles
                Dim Fila As dsLotesTiposGanado.LoteTipoGanadoRow

                Dim Filas() As dsLotesTiposGanado.LoteTipoGanadoRow = _Lotes_y_TiposGanado.Select("IdLote = '" & SalidaGanadoDetalle.IdLote.ToString & "' AND IdTipoGanado = '" & SalidaGanadoDetalle.IdTipoGanado.ToString & "'")

                If Filas.Length > 0 Then
                    Fila = Filas(0)
                Else
                    Fila = _Lotes_y_TiposGanado.NewLoteTipoGanadoRow
                    Fila.IdLote = SalidaGanadoDetalle.IdLote
                    Fila.IdTipoGanado = SalidaGanadoDetalle.IdTipoGanado
                    Fila.CorralDescripcion = SalidaGanadoDetalle.Lote.Corral.Descripcion
                    Fila.LoteDescripcion = SalidaGanadoDetalle.Lote.Descripcion
                    Fila.TipoGanadoDescripcion = SalidaGanadoDetalle.TipoGanado.Descripcion
                    _Lotes_y_TiposGanado.AddLoteTipoGanadoRow(Fila)
                End If
                Fila.Cabezas += SalidaGanadoDetalle.Cabezas
                Fila.Kilos += SalidaGanadoDetalle.Kilos
                Fila.Importe += SalidaGanadoDetalle.Importe
                Fila.ImporteVenta += SalidaGanadoDetalle.ImporteVenta
            Next
        End If
        Return _Lotes_y_TiposGanado
    End Function

    Public Function Aretes(ByVal IdLote As Integer, ByVal IdTipoGanado As Integer) As SalidaGanadoDetalleCollectionClass
        Aretes = New SalidaGanadoDetalleCollectionClass(Me)

        For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In Me.Detalles
            If SalidaGanadoDetalle.IdLote.HasValue AndAlso SalidaGanadoDetalle.IdLote.Value = IdLote Then
                If SalidaGanadoDetalle.IdTipoGanado = IdTipoGanado Then
                    Aretes.Add(SalidaGanadoDetalle)
                End If
            End If
        Next
        Return Aretes
    End Function

    Public Function CalcularTotalCabezas() As Decimal
        Dim TotalCabezas As Integer = 0

        For Each Detalle As SalidaGanadoDetalleClass In Me.Detalles
            TotalCabezas += Detalle.Cabezas
        Next
        Me.Cabezas = TotalCabezas
        Return Me.Cabezas
    End Function

    Public Function CalcularTotalKilos() As Decimal
        Dim TotalKilos As Decimal = 0D

        For Each Detalle As SalidaGanadoDetalleClass In Me.Detalles
            TotalKilos += Detalle.Kilos
        Next
        Me.Kilos = TotalKilos
        Return Me.Kilos
    End Function

    Public Function CalcularCostoAlimento() As Decimal
        Me.CostoAlimento = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoAlimento += detalle.CostoAlimento * detalle.Kilos
            End If
        Next
        Return Me.CostoAlimento
    End Function

    Public Function CalcularCostoEntrada() As Decimal
        Me.CostoEntrada = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoEntrada += detalle.CostoEntrada * detalle.Kilos
            End If
        Next
        Return Me.CostoEntrada
    End Function

    Public Function CalcularCostoMedicina() As Decimal
        Me.CostoMedicina = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoMedicina += detalle.CostoMedicina * detalle.Kilos
            End If
        Next
        Return Me.CostoMedicina
    End Function

    Public Function CalcularKilosAlimentos() As Decimal
        Me.KilosAlimento = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.KilosAlimento += detalle.KilosAlimento * detalle.Kilos
            End If
        Next
        Return Me.KilosAlimento
    End Function

    Public Function CalcularCostoIndirecto() As Decimal
        Me.CostoIndirecto = 0D

        For Each Detalle As SalidaGanadoDetalleClass In Me.Detalles
            If Detalle.IsDirty OrElse Not Detalle.IsNew Then
                Me.CostoIndirecto += Detalle.CostoIndirecto * Detalle.Kilos
            End If
        Next
        Return Me.CostoIndirecto
    End Function

    Public Function CalcularCostoOperacional() As Decimal
        For Each Detalle As SalidaGanadoDetalleClass In Me.Detalles
            If Detalle.IsDirty OrElse Not Detalle.IsNew Then
                Detalle.CostoOperacional = Detalle.CostoxKilo * Detalle.Kilos
            End If
        Next
    End Function

    Public Function CalcularCostoxKilo() As Decimal
        Me.CostoxKilo = 0D
        Dim NumDetalles As Integer = 0

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoxKilo += detalle.CostoxKilo
                NumDetalles += 1
            End If
        Next
        Me.CostoxKilo = Me.CostoxKilo / NumDetalles
        Return Me.CostoxKilo
    End Function

    Public Function CalcularCostoMovimiento() As Decimal
        Me.CostoMovto = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                Me.CostoMovto += detalle.Importe
            End If
        Next
        Return Me.CostoMovto
    End Function

    Public Function CalcularImporteVenta() As Decimal
        CalcularImporteVenta = 0D

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                If detalle.PrecioxKilo.HasValue Then
                    CalcularImporteVenta += detalle.PrecioxKilo.Value * detalle.Kilos
                End If
            End If
        Next
        ImporteVenta = CalcularImporteVenta
        Return CalcularImporteVenta
    End Function

    Public Sub Calcular()
        CalcularTotalCabezas()
        CalcularTotalKilos()

        For Each detalle As SalidaGanadoDetalleClass In Me.Detalles
            detalle.Calcular_CostoxKilo()
        Next

        CalcularCostoAlimento()
        CalcularCostoEntrada()
        CalcularCostoMedicina()
        CalcularKilosAlimentos()
        CalcularCostoIndirecto()

        If Me.IdTipoReciba = TipoSalida.Corral_de_Engorda_a_Rastro _
                OrElse Me.IdTipoReciba = TipoSalida.Corral_de_Engorda_a_Venta _
                OrElse Me.IdTipoReciba = TipoSalida.Corral_de_Engorda_por_Muerte Then
            CalcularCostoOperacional()
        End If

        CalcularCostoMovimiento()
        CalcularCostoxKilo()

        If Me.IdTipoReciba = TipoSalida.Corral_de_Reciba_a_Venta Or Me.IdTipoReciba = TipoSalida.Corral_de_Engorda_a_Venta Then
            CalcularImporteVenta()
        End If
    End Sub

    Private Sub GuardarDetalle(ByRef Trans As HC.Transaction, Optional ByVal RequerirArete As Boolean = True)
        Dim LoteDetalleSinArete As New CC.McecatLotesDetCollection, UltimaCabezaSinArete As String = "0"
        Trans.Add(Me.SalidaGanadoDet)
        Trans.Add(LoteDetalleSinArete)
        Me.SalidaGanadoDet.DeleteMulti()

        For i As Integer = 0 To Me.Detalles.Count - 1
            If Me.Detalles(i).IsDirty OrElse Not Me.Detalles(i).IsNew Then
                Trans.Add(Me.Detalles(i))
                Me.Detalles(i).IdSalidaGanadoDet = i + 1
                Me.Detalles(i).IsNew = True

                If Not RequerirArete AndAlso Me.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral _
                AndAlso Me.Detalles(i).Arete.Trim = String.Empty Then

                    If UltimaCabezaSinArete = "0" Then
                        LoteDetalleSinArete.GetMulti(HC.McecatLotesDetFields.AretePropio Mod String.Format("{0}%{1}", "[[]", "]"), 1, New OC.SortExpression(New OC.SortClause(HC.McecatLotesDetFields.AretePropio, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

                        If LoteDetalleSinArete.Count > 0 Then
                            UltimaCabezaSinArete = LoteDetalleSinArete(0).AretePropio.Replace("[", "").Replace("]", "").ToString
                        End If
                    End If
                    UltimaCabezaSinArete = (Integer.Parse(UltimaCabezaSinArete) + 1).ToString
                    Me.Detalles(i).Arete = "[" & UltimaCabezaSinArete.PadLeft(8, "0") & "]"
                End If
                Me.Detalles(i).Save()
            End If
        Next
    End Sub

    Friend Sub Guardar(ByRef Trans As HC.Transaction, Optional ByVal RequerirArete As Boolean = True)
        Trans.Add(Me)
        Me.Calcular()
        Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusSalida.VIGENTE
        Me.Save()
        GuardarDetalle(Trans, RequerirArete)
    End Sub

    Friend Sub Cancelar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusSalida.CANCELADO
        Me.Save()
    End Sub

    Friend Sub Facturar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        'Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusSalida.FACTURADO
        Me.Save()
    End Sub

    Friend Sub QuitarFacturado(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        'Me.FolioMovimientoGanado = Me.MovimientoGanado.FolioMovimeinto
        Me.Estatus = EstatusSalida.VIGENTE
        Me.Save()
    End Sub

#End Region
End Class

Public Class SalidaGanadoCabeceroCollectionClass
    Inherits ColleccionBase(Of SalidaGanadoCabeceroClass)

#Region "Metodos"

    Public Shadows Sub Add(ByVal Entidad As SalidaGanadoCabeceroClass)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.SalidaGanadoCabEntity)
        Me.Add(New SalidaGanadoCabeceroClass(Entidad))
    End Sub

#End Region

End Class