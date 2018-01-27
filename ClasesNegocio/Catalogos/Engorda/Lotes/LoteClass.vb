Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ORM = Integralab.ORM
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports ClasesNegocio

Public Class LoteClass
    Inherits ClassBase(Of EC.McecatLotesCabEntity)

#Region "Definiciones"

    Public Enum EstatusLote As Short
        CANCELADO = 0
        VIGENTE = 1
        CERRADO = 2
        TODOS = 3
    End Enum

#End Region

#Region "Miembros"

    Private _Detalles As LoteDetCollectionClass = Nothing
    Private _Corral As CorralClass = Nothing
    Private _Detalles_Vigentes As LoteDetCollectionClass = Nothing
    Private _SalidasARastro As CC.SalidaGanadoDetCollection = Nothing
    Private _SalidasAVenta As CC.SalidaGanadoDetCollection = Nothing
    Private _SalidasPorMuerte As CC.SalidaGanadoDetCollection = Nothing
    Private _SalidasDeTransferencia As CC.SalidaGanadoCabCollection = Nothing
    Private _EntradasDeReciba As CC.SalidaGanadoCabCollection = Nothing
    Private _EntradasDeTransferencia As CC.SalidaGanadoCabCollection = Nothing
    Private _FormulasAplicadas As AplicacionFormulaDetalleCollectionClass = Nothing
    Private _MedicamentosAplicados As AplicacionMedicamentoDetalleCollectionClass = Nothing
    Private _OrdenMovimientosGanado As New OC.SortExpression(New OC.SortClause(HC.SalidaGanadoCabFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
    Private _DetallesPorTiposGanado As dsDetalleTiposGanado.DataTable1DataTable
    Private _ProgramacionFormulas As LoteFormulaCollectionClass

#End Region

#Region "Constructores"

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal entidad As EC.McecatLotesCabEntity)
        MyBase.New(entidad)
    End Sub

    Public Sub New(ByVal lote As Integer)
        MyBase.New(New EC.McecatLotesCabEntity(lote))
    End Sub

#End Region

#Region "Propiedades"

    ReadOnly Property IdLote() As Integer
        Get
            Return Entity.IdLote
        End Get
    End Property

    Property IdCorral() As String
        Get
            Return Entity.IdCorral
        End Get
        Set(ByVal value As String)
            Entity.IdCorral = value
        End Set
    End Property

    Public ReadOnly Property Corral() As CorralClass
        Get
            If _Corral Is Nothing Then
                _Corral = New CorralClass(Entity.McecatCorralesCab)
            ElseIf Not Me.IdCorral = _Corral.IdCorral Then
                _Corral.Entidad = Entity.McecatCorralesCab
            End If
            Return _Corral
        End Get
    End Property

    Public ReadOnly Property NombreCorral() As String
        Get
            Return Corral.Descripcion
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return Entity.NombreLote
        End Get
        Set(ByVal value As String)
            Entity.NombreLote = value
        End Set
    End Property

    Property DescCorta() As String
        Get
            Return Entity.NomCorLote
        End Get
        Set(ByVal value As String)
            Entity.NomCorLote = value
        End Set
    End Property

    ReadOnly Property FechaInicio() As Date
        Get
            If Me.Detalles.Count > 0 Then
                Return Me.Detalles(0).FechaEntrada
            End If
            Return #1/1/1900#
        End Get
    End Property

    Public ReadOnly Property FechaCaptura() As Date
        Get
            Return Me.Entity.FechaCaptura
        End Get
    End Property

 

    Property SaldoCabezas() As Decimal
        Get
            Return Entity.SaldoCabezas
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoCabezas = value
        End Set
    End Property

    Property SaldoKilos() As Decimal
        Get
            Return Entity.SaldoKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoKilos = value
        End Set
    End Property

    Property SaldoKilosAlim() As Decimal
        Get
            Return Entity.SaldoKilosAlim
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoKilosAlim = value
        End Set
    End Property

    Property SaldoImpteAlim() As Decimal
        Get
            Return Entity.SaldoImpteAlim
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoImpteAlim = value
        End Set
    End Property

    Property SaldoimpteMed() As Decimal
        Get
            Return Entity.SaldoImpteMed
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoImpteMed = value
        End Set
    End Property

    Property AcumCabMuerte() As Decimal
        Get
            Return Entity.AcumCabMuerte
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumCabMuerte = value
        End Set
    End Property

    Property AcumKilosMuerte() As Decimal
        Get
            Return Entity.AcumKilosMuerte
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumKilosMuerte = value
        End Set
    End Property

    Property AcumKilosAlim() As Decimal
        Get
            Return Entity.AcumKilosAlim
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumKilosAlim = value
        End Set
    End Property

    Property AcumImpteMuerte() As Decimal
        Get
            Return Entity.AcumImpteMuerte
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumImpteMuerte = value
        End Set
    End Property

    Property AcumEntCab() As Decimal
        Get
            Return Entity.AcumEntCab
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumEntCab = value
        End Set
    End Property

    Property AcumEntImpte() As Decimal
        Get
            Return Entity.AcumEntImpte
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumEntImpte = value
        End Set
    End Property

    Property AcumImpteMedic() As Decimal
        Get
            Return Entity.AcumImpteMedic
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumImpteMedic = value
        End Set
    End Property

    Property AcumSalCab() As Decimal
        Get
            Return Entity.AcumSalCab
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumSalCab = value
        End Set
    End Property

    Property AcumSalKilos() As Decimal
        Get
            Return Entity.AcumSalKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumSalKilos = value
        End Set
    End Property

    Property AcumEntKilos() As Decimal
        Get
            Return Entity.AcumEntKilos
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumEntKilos = value
        End Set
    End Property

    Property AcumImpteAlim() As Decimal
        Get
            Return Entity.AcumImpteAlim
        End Get
        Set(ByVal value As Decimal)
            Entity.AcumImpteAlim = value
        End Set
    End Property

    Property CantSemReimplante() As Decimal
        Get
            Return Entity.CantSemReimplante
        End Get
        Set(ByVal value As Decimal)
            Entity.CantSemReimplante = value
        End Set
    End Property

    Property GDPINI() As Decimal
        Get
            Return Entity.Gdpini
        End Get
        Set(ByVal value As Decimal)
            Entity.Gdpini = value
        End Set
    End Property

    Property GDP() As Decimal
        Get
            Return Entity.Gdp
        End Get
        Set(ByVal value As Decimal)
            Entity.Gdp = value
        End Set
    End Property

    Property CKI() As Decimal
        Get
            Return Entity.Cki
        End Get
        Set(ByVal value As Decimal)
            Entity.Cki = value
        End Set
    End Property

    Property ECA() As Decimal
        Get
            Return Entity.Eca
        End Get
        Set(ByVal value As Decimal)
            Entity.Eca = value
        End Set
    End Property

    ReadOnly Property TotalCantidadFormulaAplicada() As Decimal
        Get
            TotalCantidadFormulaAplicada = 0D

            For Each AplicacionFormula As AplicacionFormulaDetalleClass In FormulasAplicadas
                TotalCantidadFormulaAplicada += AplicacionFormula.CantidadTotalServida
            Next
            Return TotalCantidadFormulaAplicada
        End Get
    End Property

    Property PesoEstimado() As Decimal
        Get
            Return Entity.PesoEstimado
        End Get
        Set(ByVal value As Decimal)
            Entity.PesoEstimado = value
        End Set
    End Property

    ReadOnly Property TotalPesoProyectado() As Decimal
        Get
            TotalPesoProyectado = 0D

            For Each Arete As LoteDetClass In Me.Detalles_Vigentes
                TotalPesoProyectado += Arete.PesoEstimado
            Next
            Return TotalPesoProyectado
        End Get
    End Property

    ReadOnly Property PesoProyectadoxCbz() As Decimal
        Get
            If Me.SaldoCabezas > 0D Then
                Return Me.TotalPesoProyectado / Me.SaldoCabezas
            End If
            Return 0D
        End Get
    End Property

    ReadOnly Property PesoPromedioxCabeza() As Decimal
        Get
            PesoPromedioxCabeza = 0D

            For Each Arete As LoteDetClass In Me.Detalles_Vigentes
                PesoPromedioxCabeza += Arete.KilosEntrada
            Next

            If Not Me.SaldoCabezas > 0D Then
                Return 0D
            End If
            PesoPromedioxCabeza /= Me.SaldoCabezas
            Return PesoPromedioxCabeza
        End Get
    End Property

    Property FechaCierre() As Date
        Get
            Return Entity.FechaCierre
        End Get
        Set(ByVal value As Date)
            Entity.FechaCierre = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Property ObservacionesReimplante() As String
        Get
            Return Entity.ObservacioneReimplante
        End Get
        Set(ByVal value As String)
            Entity.ObservacioneReimplante = value
        End Set
    End Property

    Property SaldoCostoInd() As Decimal
        Get
            Return Entity.SaldoCostoInd
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoCostoInd = value
        End Set
    End Property

    Property SaldoImpte() As Decimal
        Get
            Return Entity.SaldoImpte
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoImpte = value
        End Set
    End Property

    Public Property Estatus() As EstatusLote
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusLote)
            Entity.Estatus = value
        End Set
    End Property

    Public Property IdCierreLote() As Integer
        Get
            If Entity.IdCierreLote.HasValue Then
                Return Entity.IdCierreLote.Value
            End If
            Return 0
        End Get
        Set(ByVal value As Integer)
            If value <> 0 Then
                Entity.IdCierreLote = value
            End If
            Entity.IdCierreLote = Nothing
        End Set
    End Property

    Public ReadOnly Property CierreLote() As CierreLoteClass
        Get
            Return New CierreLoteClass(Me.IdCierreLote)
        End Get
    End Property

    Public ReadOnly Property Detalles() As LoteDetCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New LoteDetCollectionClass(Me)

                Dim Dets As CC.McecatLotesDetCollection = Me.Entity.McecatLotesDet

                Dets.Sort(ORM.McecatLotesDetFieldIndex.FechaEntrada, ComponentModel.ListSortDirection.Ascending)

                For Each _Det As EC.McecatLotesDetEntity In Dets
                    _Detalles.Add(_Det)
                Next
            End If
            Return _Detalles
        End Get
    End Property

    Public ReadOnly Property Detalles_Vigentes() As LoteDetCollectionClass
        Get
            If _Detalles_Vigentes Is Nothing Then
                _Detalles_Vigentes = New LoteDetCollectionClass(Me)

                Dim Dets As CC.McecatLotesDetCollection = Me.Entity.McecatLotesDet

                Dets.Sort(ORM.McecatLotesDetFieldIndex.FechaEntrada, ComponentModel.ListSortDirection.Ascending)

                For Each _Det As EC.McecatLotesDetEntity In Dets
                    If _Det.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE Then
                        _Detalles_Vigentes.Add(_Det)
                    End If
                Next
            End If
            Return _Detalles_Vigentes
        End Get
    End Property

    Public ReadOnly Property DetallesPorTiposGanado() As dsDetalleTiposGanado.DataTable1DataTable
        Get
            If _DetallesPorTiposGanado Is Nothing Then
                _DetallesPorTiposGanado = New dsDetalleTiposGanado.DataTable1DataTable()

                For Each Arete As LoteDetClass In Me.Detalles
                    Dim RegistroEncontrado() As dsDetalleTiposGanado.DataTable1Row = _DetallesPorTiposGanado.Select("IdTipoGanado = '" & Arete.IdTipoGanado & "'")
                    Dim GananciaKilos As Decimal = 0D

                    If Arete.KilosSalida > 0 Then
                        GananciaKilos = Arete.KilosSalida - Arete.KilosEntrada
                    End If

                    If RegistroEncontrado.Length > 0 Then
                        RegistroEncontrado(0).Cabezas += 1
                        RegistroEncontrado(0).KilosEntrada += Arete.KilosEntrada
                        RegistroEncontrado(0).KilosSalida += Arete.KilosSalida
                        RegistroEncontrado(0).GananciaKilos += GananciaKilos
                    Else
                        _DetallesPorTiposGanado.AddDataTable1Row(Arete.IdTipoGanado, Arete.TipoGanado.Descripcion, 1, Arete.KilosEntrada, Arete.KilosSalida, GananciaKilos)
                    End If
                Next
            End If
            Return _DetallesPorTiposGanado
        End Get
    End Property

    Public ReadOnly Property DetallesPorTiposGanado_Vigentes() As dsDetalleTiposGanado.DataTable1DataTable
        Get
            If _DetallesPorTiposGanado Is Nothing Then
                _DetallesPorTiposGanado = New dsDetalleTiposGanado.DataTable1DataTable()

                For Each Arete As LoteDetClass In Me.Detalles_Vigentes
                    Dim RegistroEncontrado() As dsDetalleTiposGanado.DataTable1Row = _DetallesPorTiposGanado.Select("IdTipoGanado = '" & Arete.IdTipoGanado & "'")
                    Dim GananciaKilos As Decimal = 0D

                    If Arete.KilosSalida > 0 Then
                        GananciaKilos = Arete.KilosSalida - Arete.KilosEntrada
                    End If

                    If RegistroEncontrado.Length > 0 Then
                        RegistroEncontrado(0).Cabezas += 1
                        RegistroEncontrado(0).KilosEntrada += Arete.KilosEntrada
                        RegistroEncontrado(0).KilosSalida += Arete.KilosSalida
                        RegistroEncontrado(0).GananciaKilos += GananciaKilos
                    Else
                        _DetallesPorTiposGanado.AddDataTable1Row(Arete.IdTipoGanado, Arete.TipoGanado.Descripcion, 1, Arete.KilosEntrada, Arete.KilosSalida, GananciaKilos)
                    End If
                Next
            End If
            Return _DetallesPorTiposGanado
        End Get
    End Property

    Public ReadOnly Property SalidasARastro() As CC.SalidaGanadoDetCollection
        Get
            If _SalidasARastro Is Nothing Then
                Dim Relacion As New OC.RelationCollection()
                Relacion.Add(EC.SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)

                _SalidasARastro = New CC.SalidaGanadoDetCollection()
                _SalidasARastro.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
                And HC.SalidaGanadoDetFields.IdLote = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado, Relacion)
            End If
            Return _SalidasARastro
        End Get
    End Property

    Public ReadOnly Property SalidasAVenta() As CC.SalidaGanadoDetCollection
        Get
            If _SalidasAVenta Is Nothing Then
                Dim Relacion As New OC.RelationCollection()
                Relacion.Add(EC.SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)

                _SalidasAVenta = New CC.SalidaGanadoDetCollection()
                _SalidasAVenta.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
                And HC.SalidaGanadoDetFields.IdLote = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado, Relacion)
            End If
            Return _SalidasAVenta
        End Get
    End Property

    Public ReadOnly Property SalidasPorMuerte() As CC.SalidaGanadoDetCollection
        Get
            If _SalidasPorMuerte Is Nothing Then
                Dim Relacion As New OC.RelationCollection()
                Relacion.Add(EC.SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)

                _SalidasPorMuerte = New CC.SalidaGanadoDetCollection()
                _SalidasPorMuerte.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
                And HC.SalidaGanadoDetFields.IdLote = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado, Relacion)
            End If
            Return _SalidasPorMuerte
        End Get
    End Property

    Public ReadOnly Property SalidasDeTransferencia() As CC.SalidaGanadoCabCollection
        Get
            If _SalidasDeTransferencia Is Nothing Then
                Dim Relacion As New OC.RelationCollection()
                Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab)

                _SalidasDeTransferencia = New CC.SalidaGanadoCabCollection()
                _SalidasDeTransferencia.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia _
                And HC.SalidaGanadoDetFields.IdLote = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado, Relacion)
            End If
            Return _SalidasDeTransferencia
        End Get
    End Property

    Public ReadOnly Property EntradasDeReciba() As CC.SalidaGanadoCabCollection
        Get
            If _EntradasDeReciba Is Nothing Then
                _EntradasDeReciba = New CC.SalidaGanadoCabCollection()
                _EntradasDeReciba.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral _
                And HC.SalidaGanadoCabFields.IdLoteDestino = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado)
            End If
            Return _EntradasDeReciba
        End Get
    End Property

    Public ReadOnly Property EntradasDeTransferencia() As CC.SalidaGanadoCabCollection
        Get
            If _EntradasDeTransferencia Is Nothing Then
                _EntradasDeTransferencia = New CC.SalidaGanadoCabCollection()
                _EntradasDeTransferencia.GetMulti(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia _
                And HC.SalidaGanadoCabFields.IdLoteDestino = Me.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE, 0, _OrdenMovimientosGanado)
            End If
            Return _EntradasDeTransferencia
        End Get
    End Property

    Public ReadOnly Property EntradasDeTransferenciaEnCabezas() As Integer
        Get
            EntradasDeTransferenciaEnCabezas = 0

            For Each EntradaporTransferencia As EC.SalidaGanadoCabEntity In EntradasDeTransferencia
                EntradasDeTransferenciaEnCabezas += EntradaporTransferencia.Cabezas
            Next
            Return EntradasDeTransferenciaEnCabezas
        End Get
    End Property

    Public ReadOnly Property EntradasDeRecibaEnCabezas() As Integer
        Get
            EntradasDeRecibaEnCabezas = 0

            For Each EntradaDeReciba As EC.SalidaGanadoCabEntity In EntradasDeReciba
                EntradasDeRecibaEnCabezas += EntradaDeReciba.Cabezas
            Next
            Return EntradasDeRecibaEnCabezas
        End Get
    End Property

    Public ReadOnly Property SalidasDeTransferenciaEnCabezas() As Integer
        Get
            SalidasDeTransferenciaEnCabezas = 0

            For Each EntradaDeReciba As EC.SalidaGanadoCabEntity In SalidasDeTransferencia
                SalidasDeTransferenciaEnCabezas += EntradaDeReciba.Cabezas
            Next
            Return SalidasDeTransferenciaEnCabezas
        End Get
    End Property

    Public ReadOnly Property SalidasPorMuerteEnCabezas() As Integer
        Get
            SalidasPorMuerteEnCabezas = 0

            For Each EntradaDeReciba As EC.SalidaGanadoDetEntity In SalidasPorMuerte
                SalidasPorMuerteEnCabezas += EntradaDeReciba.Cabezas
            Next
            Return SalidasPorMuerteEnCabezas
        End Get
    End Property

    Public ReadOnly Property TotalCabezasMenosMuertesYSalidasDeTransferencia() As Integer
        Get
            Return EntradasDeTransferenciaEnCabezas + EntradasDeRecibaEnCabezas - SalidasDeTransferenciaEnCabezas - SalidasPorMuerteEnCabezas
        End Get
    End Property

    Public ReadOnly Property DiasEngorda() As Integer
        Get
            If Estatus = EstatusLote.CERRADO Then
                Return CType((Me.FechaCierre.Ticks - Me.FechaInicio.Ticks) / TimeSpan.TicksPerDay, Integer)
            Else
                If Not Me.FechaInicio.Year = 1900 Then
                    Return CType((Now.Ticks - Me.FechaInicio.Ticks) / TimeSpan.TicksPerDay, Integer)
                End If
                Return 0I
            End If
        End Get
    End Property

    Public ReadOnly Property DiasEngordaProyectado() As Integer
        Get
            If Not Me.FechaInicio.Year = 1900 Then
                Return CType((FechaEstimadaDeSalida.Ticks - Me.FechaInicio.Ticks) / TimeSpan.TicksPerDay, Integer)
            End If
            Return 0I
        End Get
    End Property

    Public ReadOnly Property TotalSalidasEnKg() As Decimal
        Get
            TotalSalidasEnKg = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasARastro
                TotalSalidasEnKg += Salida.Kilos
            Next

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasAVenta
                TotalSalidasEnKg += Salida.Kilos
            Next

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasPorMuerte
                TotalSalidasEnKg += Salida.Kilos
            Next

            For Each Salida As EC.SalidaGanadoCabEntity In SalidasDeTransferencia
                TotalSalidasEnKg += Salida.Kilos
            Next
            Return TotalSalidasEnKg
        End Get
    End Property

    Public ReadOnly Property TotalEntradasEnKg() As Decimal
        Get
            TotalEntradasEnKg = 0

            For Each Entrada As EC.SalidaGanadoCabEntity In EntradasDeReciba
                TotalEntradasEnKg += Entrada.Kilos
            Next

            For Each Entrada As EC.SalidaGanadoCabEntity In EntradasDeTransferencia
                TotalEntradasEnKg += Entrada.Kilos
            Next
            Return TotalEntradasEnKg
        End Get
    End Property

    Public ReadOnly Property AumentoBrutoEnKgs() As Decimal
        Get
            Return TotalSalidasEnKg - TotalEntradasEnKg
        End Get
    End Property

    Public ReadOnly Property SalidasPorMuerteEnKg() As Decimal
        Get
            SalidasPorMuerteEnKg = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasPorMuerte
                SalidasPorMuerteEnKg += Salida.Kilos
            Next
            Return SalidasPorMuerteEnKg
        End Get
    End Property

    Public ReadOnly Property AumentoNetoEnKgs() As Decimal
        Get
            Return TotalSalidasEnKg - TotalEntradasEnKg - SalidasPorMuerteEnKg
        End Get
    End Property

    Public ReadOnly Property SalidasARastroEnCabezas() As Integer
        Get
            SalidasARastroEnCabezas = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasARastro
                SalidasARastroEnCabezas += Salida.Cabezas
            Next
            Return SalidasARastroEnCabezas
        End Get
    End Property

    Public ReadOnly Property SalidasAVentaEnCabezas() As Integer
        Get
            SalidasAVentaEnCabezas = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasAVenta
                SalidasAVentaEnCabezas += Salida.Cabezas
            Next
            Return SalidasAVentaEnCabezas
        End Get
    End Property

    Public ReadOnly Property SalidasARastroEnKg() As Decimal
        Get
            SalidasARastroEnKg = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasARastro
                SalidasARastroEnKg += Salida.Kilos
            Next
            Return SalidasARastroEnKg
        End Get
    End Property

    Public ReadOnly Property SalidasAVentaEnKg() As Decimal
        Get
            SalidasAVentaEnKg = 0

            For Each Salida As EC.SalidaGanadoDetEntity In SalidasAVenta
                SalidasAVentaEnKg += Salida.Kilos
            Next
            Return SalidasAVentaEnKg
        End Get
    End Property

    Public ReadOnly Property TotalDeSalidasEnCabezas() As Integer
        Get
            Return SalidasPorMuerteEnCabezas + SalidasARastroEnCabezas + SalidasAVentaEnCabezas
        End Get
    End Property

    Public ReadOnly Property TotalDeSalidasSinTransferenciasEnKg() As Integer
        Get
            Return SalidasPorMuerteEnKg + SalidasARastroEnKg + SalidasAVentaEnKg
        End Get
    End Property

    Public ReadOnly Property TotalCostoIndirecto() As Decimal
        Get
            TotalCostoIndirecto = 0D

            For Each SalidaGanadoDet As EC.SalidaGanadoDetEntity In Me.SalidasARastro
                TotalCostoIndirecto += SalidaGanadoDet.CostoxKilo - SalidaGanadoDet.CostoAlimento - SalidaGanadoDet.CostoEntrada - SalidaGanadoDet.CostoMedicina
            Next

            For Each SalidaGanadoDet As EC.SalidaGanadoDetEntity In Me.SalidasAVenta
                TotalCostoIndirecto += SalidaGanadoDet.CostoxKilo - SalidaGanadoDet.CostoAlimento - SalidaGanadoDet.CostoEntrada - SalidaGanadoDet.CostoMedicina
            Next

            For Each SalidaGanadoDet As EC.SalidaGanadoDetEntity In Me.SalidasPorMuerte
                TotalCostoIndirecto += SalidaGanadoDet.CostoxKilo - SalidaGanadoDet.CostoAlimento - SalidaGanadoDet.CostoEntrada - SalidaGanadoDet.CostoMedicina
            Next
            Return TotalCostoIndirecto + Me.SaldoCostoInd
        End Get
    End Property

    Public ReadOnly Property CostoTotal() As Decimal
        Get
            Return Me.AcumEntImpte + Me.AcumImpteAlim + Me.AcumImpteMedic + Me.TotalCostoIndirecto
        End Get
    End Property

    Public ReadOnly Property CostoxCabeza() As Decimal
        Get
            If Me.TotalCabezasMenosMuertesYSalidasDeTransferencia <> 0 Then
                Return Me.CostoTotal / Me.TotalCabezasMenosMuertesYSalidasDeTransferencia
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property SalidasxCabezaEnKg() As Decimal
        Get
            If Me.TotalSalidasEnKg <> 0 Then
                Return Me.TotalSalidasEnKg / Me.TotalSalidasEnKg
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property EntradasxCabezaEnKg() As Decimal
        Get
            If Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas <> 0 Then
                Return Me.TotalEntradasEnKg / (Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas)
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoEntradaxCabeza() As Decimal
        Get
            If Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas <> 0 Then
                Return Me.AcumEntImpte / (Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas)
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoAlimentoxCabeza() As Decimal
        Get
            If Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas <> 0 Then
                Return Me.AcumImpteAlim / (Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas)
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoMedicamentoxCabeza() As Decimal
        Get
            If Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas <> 0 Then
                Return Me.AcumImpteMedic / (Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas)
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property AumentoNetoxCabeza() As Decimal
        Get
            If Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas <> 0 Then
                Return Me.AumentoNetoEnKgs / (Me.EntradasDeTransferenciaEnCabezas + Me.EntradasDeRecibaEnCabezas)
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CostoDeSalidasxKg() As Decimal
        Get
            If Me.SalidasxCabezaEnKg <> 0 Then
                Return Me.CostoxCabeza / Me.SalidasxCabezaEnKg
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property DiasCabeza() As Decimal
        Get
            DiasCabeza = 0D

            For Each Detalle As LoteDetClass In Me.Detalles
                DiasCabeza += Detalle.DiasEngorda
            Next
            Return DiasCabeza
        End Get
    End Property

    Public ReadOnly Property FormulasAplicadas() As AplicacionFormulaDetalleCollectionClass
        Get
            If _FormulasAplicadas Is Nothing Then
                Dim Relacion As New OC.RelationCollection(), Orden As New OC.SortExpression(New OC.SortClause(HC.CabAplForFields.FechaAplicacion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
                Relacion.Add(EC.DetAplForEntity.Relations.CabAplForEntityUsingFolAplF)
                _FormulasAplicadas = New AplicacionFormulaDetalleCollectionClass()
                _FormulasAplicadas.Obtener(HC.DetAplForFields.CveLote = Me.IdLote And HC.CabAplForFields.Estatus = AplicacionFormulaClass.EstatusAplicacionFormula.VIGENTE, Orden, Relacion)
            End If
            Return _FormulasAplicadas
        End Get
    End Property

    Public ReadOnly Property MedicamentosAplicados() As AplicacionMedicamentoDetalleCollectionClass
        Get
            If _MedicamentosAplicados Is Nothing Then
                Dim Relacion As New OC.RelationCollection, Orden As New OC.SortExpression(New OC.SortClause(HC.AplicMediFields.FechaAplicacionMedicamento, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
                Relacion.Add(EC.AplicMediDetEntity.Relations.AplicMediEntityUsingFolioAplicacionMedicamento)
                _MedicamentosAplicados = New AplicacionMedicamentoDetalleCollectionClass()
                _MedicamentosAplicados.Obtener(HC.AplicMediDetFields.IdLote = Me.IdLote And HC.AplicMediFields.Estatus = AplicacionMedicamentoClass.EstatusAplicacionMedicamento.VIGENTE, Orden, Relacion)
            End If
            Return _MedicamentosAplicados
        End Get
    End Property

    Public ReadOnly Property FormulaActual() As AplicacionFormulaDetalleClass
        Get
            Dim UltimaAplicacionFormula As New CC.DetAplForCollection(), Filtro As New OC.PredicateExpression, Relacion As New OC.RelationCollection
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.CabAplForFields.FechaAplicacion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

            Relacion.Add(EC.DetAplForEntity.Relations.CabAplForEntityUsingFolAplF, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            UltimaAplicacionFormula.GetMulti(HC.DetAplForFields.CveLote = Me.IdLote And HC.CabAplForFields.Estatus <> AplicacionFormulaClass.EstatusAplicacionFormula.CANCELADA, 1, Orden, Relacion)

            If UltimaAplicacionFormula.Count > 0 Then
                FormulaActual = New AplicacionFormulaDetalleClass(UltimaAplicacionFormula(0))
            Else
                FormulaActual = Nothing
            End If
            Return FormulaActual
        End Get
    End Property

    Public ReadOnly Property DiasAplFormulaActual() As Integer
        Get
            Dim PrimeraAplicacionFormula As New CC.CabAplForCollection(), Filtro As New OC.PredicateExpression, Relacion As New OC.RelationCollection
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.CabAplForFields.FechaAplicacion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            DiasAplFormulaActual = 0

            If FormulaActual IsNot Nothing Then
                Relacion.Add(EC.CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
                PrimeraAplicacionFormula.GetMulti(HC.CabAplForFields.Estatus <> AplicacionFormulaClass.EstatusAplicacionFormula.CANCELADA And HC.DetAplForFields.CveLote = Me.IdLote And HC.DetAplForFields.CveFormula = FormulaActual.IdFormula, 1, Orden, Relacion)

                If PrimeraAplicacionFormula.Count > 0 Then
                    If FormulaActual.FolioAplicacionFormula <> PrimeraAplicacionFormula(0).FolAplF Then
                        DiasAplFormulaActual = Decimal.ToInt32((FormulaActual.FechaAplicacion.Ticks - PrimeraAplicacionFormula(0).FechaAplicacion.Ticks) / TimeSpan.TicksPerDay)
                    Else
                        DiasAplFormulaActual = 1
                    End If
                End If
            End If
            Return DiasAplFormulaActual
        End Get
    End Property

    Public ReadOnly Property FechaEstimadaDeSalida() As Date
        Get
            If Me.SaldoCabezas > 0D AndAlso Me.GDPINI > 0D Then
                If Not Me.FechaInicio.Year = 1900 Then
                    Return Me.FechaInicio.AddDays(Decimal.ToDouble((Me.PesoEstimado - Me.PesoProyectadoxCbz) / Me.GDPINI))
                End If
            End If
            Return FechaInicio
        End Get
    End Property

    Public ReadOnly Property Cerrado() As String
        Get
            If Me.Estatus = EstatusLote.VIGENTE Then
                Return "NO"
            Else 'If Me.Estatus = EstatusLote.CERRADO Then
                Return "SI"
            End If
        End Get
    End Property

    Public ReadOnly Property FechaReimplante() As Date
        Get
            If Not Me.FechaInicio.Year = 1900 Then
                Return Me.FechaInicio.AddDays(Me.CantSemReimplante * 7)
            End If
            Return FechaInicio
        End Get
    End Property

    Public ReadOnly Property DiaSemanaReimplante() As String
        Get
            If Not Me.FechaInicio.Year = 1900 Then
                Return Globalization.CultureInfo.CurrentCulture().DateTimeFormat.GetDayName(FechaReimplante.DayOfWeek).ToString().ToUpper()
            End If
            Return ""
        End Get
    End Property

    Public ReadOnly Property ProgramacionFormulas() As LoteFormulaCollectionClass
        Get
            If _ProgramacionFormulas Is Nothing Then
                _ProgramacionFormulas = New LoteFormulaCollectionClass(Me)

                For Each Programacion As EC.McecatLotesCabForEntity In Me.Entidad.McecatLotesCabFor
                    _ProgramacionFormulas.Add(Programacion)
                Next
            End If
            Return _ProgramacionFormulas
        End Get
    End Property

#Region "Campos Especiales Utilizados para el cierre Ficticio"

    Public ReadOnly Property TotalSalidasFicticiaEnKg() As Decimal
        Get
            Return Me.AumentoLoteFictisio + Me.TotalEntradasEnKg
        End Get
    End Property

    Public ReadOnly Property DiasEngorda_Ficticio() As Decimal
        Get
            If Not Me.FechaInicio.Year = 1900 Then
                Return (Now.Ticks - Me.FechaInicio.Ticks) / TimeSpan.TicksPerDay
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property AumentoLoteFictisio() As Decimal
        Get
            Return Me.GDPINI * Me.DiasEngorda_Ficticio * (Me.TotalCabezasMenosMuertesYSalidasDeTransferencia - Me.SalidasARastroEnKg - Me.SalidasAVentaEnKg)
        End Get
    End Property

    Public ReadOnly Property GDP_Fictisio() As Decimal
        Get
            If Me.DiasCabeza <> 0 Then
                Return Me.AumentoLoteFictisio / Me.DiasCabeza
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property ECA_Fictisio() As Decimal
        Get
            If Me.AumentoLoteFictisio <> 0 Then
                Return Me.TotalCantidadFormulaAplicada / Me.AumentoLoteFictisio
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property CKI_Fictisio() As Decimal
        Get
            If Me.AumentoLoteFictisio <> 0 Then
                Return (Me.AcumImpteAlim + Me.AcumImpteMedic) / Me.AumentoLoteFictisio
            End If
            Return 0D
        End Get
    End Property

#End Region

#End Region

#Region "Metodos"

    Public Function Aretes(ByVal Estatus As LoteDetClass.EstatusLoteDetalle, ByVal IdTipoGanado As Integer) As LoteDetCollectionClass
        Aretes = New LoteDetCollectionClass(Me)

        For Each Arete As LoteDetClass In Me.Detalles
            If Arete.Estatus = Estatus AndAlso Arete.IdTipoGanado = IdTipoGanado Then
                Aretes.Add(Arete)
            End If
        Next
        Return Aretes
    End Function

    Public Function CalcularPesoEntrada() As Decimal
        CalcularPesoEntrada = 0D

        For Each Detalle As LoteDetClass In Me.Detalles
            CalcularPesoEntrada += Detalle.KilosEntrada
        Next
        Return CalcularPesoEntrada
    End Function

    Public Function CalcularPesoSalida() As Decimal
        CalcularPesoSalida = 0D

        For Each Detalle As LoteDetClass In Me.Detalles
            If Detalle.Estatus = LoteDetClass.EstatusLoteDetalle.CERRADO Then
                CalcularPesoSalida += Detalle.KilosSalida
            End If
        Next
        Return CalcularPesoSalida
    End Function

    Public Function CalcularPesoActual() As Decimal
        CalcularPesoActual = 0

        For Each Detalle As LoteDetClass In Me.Detalles
            If Detalle.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE Then
                CalcularPesoActual += Detalle.KilosEntrada
            Else
                CalcularPesoActual -= Detalle.KilosSalida
            End If
        Next
        Return CalcularPesoActual
    End Function

    Public Function CalcularGDP() As Decimal
        GDP = 0D

        If Me.DiasCabeza <> 0 Then
            GDP = Me.AumentoBrutoEnKgs / Me.DiasCabeza
        End If
        Return GDP
    End Function

    Public Function CalcularCKI() As Decimal
        CKI = 0D

        If Me.AumentoNetoEnKgs <> 0 Then
            CKI = Me.AcumImpteAlim + Me.AcumImpteMedic / Me.AumentoNetoEnKgs
        End If
        Return CKI
    End Function

    Public Function CalcularECA() As Decimal
        ECA = 0D

        If Me.AumentoNetoEnKgs <> 0 Then
            ECA = TotalCantidadFormulaAplicada / Me.AumentoNetoEnKgs
        End If
        Return ECA
    End Function

    Public Shadows Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Try
            If CC.McecatLotesCabCollection.GetMultiAsDataTable(HC.McecatLotesCabFields.IdCorral = Me.IdCorral And HC.McecatLotesCabFields.IdLote <> Me.IdLote, 1, Nothing).Rows.Count > 0 Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CATALOGO_LOTES, 0, Me.Corral.IdCorral)
            End If

            If Me.Entidad.IsNew Then
                Me.Entidad.FechaCaptura = Now
            End If
            Trans.Add(Me.Entity)
            Return Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Sub CancelarCerrado(ByRef Trans As HC.Transaction)
        Dim TiempoEngorda As Decimal = 0D, numDias As Integer = 0

        Me.Estatus = LoteClass.EstatusLote.VIGENTE
        Me.GDP = Me.GDPINI
        Me.CKI = 0D
        Me.ECA = 0D

        If Me.PesoEstimado = 0D OrElse Me.GDPINI = 0D Then
            Me.FechaCierre = Me.FechaInicio
        End If

        TiempoEngorda = Me.PesoEstimado / Me.GDPINI

        If TiempoEngorda - Math.Truncate(TiempoEngorda) = 0D Then
            numDias = CInt(TiempoEngorda)
        Else
            numDias = CInt(Math.Truncate(TiempoEngorda)) + 1
        End If

        Me.FechaCierre = Me.FechaInicio.AddDays(numDias)
        Me.CierreLote.Estatus = False
        Me.CierreLote.Guardar(Trans)
        Me.IdCierreLote = 0
        Me.Guardar(Trans)
    End Sub

    Public Sub Cerrar(ByVal FechaCierre As Date, ByRef Trans As HC.Transaction)
        Me.Estatus = LoteClass.EstatusLote.CERRADO
        Me.FechaCierre = FechaCierre
        Me.CalcularGDP()
        Me.CalcularCKI()
        Me.CalcularECA()

        Dim CierreLote As New CierreLoteClass(Me.IdLote, Me.DiasCabeza, Me.FechaCierre, True, Me.CKI, Me.GDP, Me.ECA)
        CierreLote.Guardar(Trans)
        Me.IdCierreLote = CierreLote.IdCierreLote
        Me.Guardar(Trans)
    End Sub

#End Region

End Class