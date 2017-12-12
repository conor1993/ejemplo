Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class AplicacionFormulaDetalleClass
    Inherits ClassBase(Of EC.DetAplForEntity)

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.DetAplForEntity)
        MyBase.New(Entidad)
    End Sub

#End Region

#Region "Campos"
    ''' <summary>
    ''' Contiene la informacion de la aplicacion de formula a la que pertenerse esta formula aplicada
    ''' </summary>
    Private m_AplicacionFormula As AplicacionFormulaClass
    ''' <summary>
    ''' Contiene la informacion de lote donde se aplica la formula
    ''' </summary>
    Private m_Lote As LoteClass
    ''' <summary>
    ''' Contiene la informacion del corral donde se aplica la formula
    ''' </summary>
    Private m_Corral As CorralClass
    ''' <summary>
    ''' Contiene la informacion de la formula aplicada
    ''' </summary>
    Private m_Formula As ProductoClass
#End Region

#Region "Propiedades"
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

                Dim lotes As New CC.McecatLotesCabCollection

                IdLote = lotes.GetScalar(Integralab.ORM.McecatLotesCabFieldIndex.IdLote, _
                            New OC.Expression(HC.McecatLotesCabFields.IdLote), _
                            SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                            HC.McecatLotesCabFields.Estatus = 1 And HC.McecatLotesCabFields.IdCorral = IdCorral)

                If Lote.Descripcion = "" Then
                    Me.Cabezas = Corral.TotalCabezas
                    Me.Kilos = Corral.TotalKilos
                Else
                    Me.Cabezas = Lote.SaldoCabezas
                    Me.Kilos = Lote.SaldoKilos
                End If
            End If
        End Set
    End Property

    Public Property AplicacionFormula() As AplicacionFormulaClass
        Get
            If m_AplicacionFormula Is Nothing Then
                m_AplicacionFormula = New AplicacionFormulaClass(Entity.CabAplFor)
            ElseIf Not m_AplicacionFormula.FolioAplicacionFormula = Me.FolioAplicacionFormula Then
                m_AplicacionFormula.Entidad = Entity.CabAplFor
            End If

            Return m_AplicacionFormula
        End Get
        Set(ByVal value As AplicacionFormulaClass)
            m_AplicacionFormula = value

            If value Is Nothing Then
                Entity.CabAplFor = Nothing
            Else
                Entity.CabAplFor = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio de aplicacion de formulas
    ''' </summary>
    Public Property FolioAplicacionFormula() As String
        Get
            Return Entity.FolAplF
        End Get
        Set(ByVal value As String)
            Entity.FolAplF = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo del corral
    ''' </summary>
    Public Property IdCorral() As String
        Get
            Return Entity.CveCorral
        End Get
        Set(ByVal value As String)
            Entity.CveCorral = value

            Dim lotes As New CC.McecatLotesCabCollection

            IdLote = lotes.GetScalar(Integralab.ORM.McecatLotesCabFieldIndex.IdLote, _
                        New OC.Expression(HC.McecatLotesCabFields.IdLote), _
                        SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, _
                        HC.McecatLotesCabFields.Estatus = 1 And HC.McecatLotesCabFields.IdCorral = IdCorral)

            If Lote.Descripcion = "" Then
                Me.Cabezas = Corral.TotalCabezas
                Me.Kilos = Corral.TotalKilos
            Else
                Me.Cabezas = Lote.SaldoCabezas
                Me.Kilos = Lote.SaldoKilos
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo del lote
    ''' </summary>
    Public Property IdLote() As Integer
        Get
            Return Entity.CveLote
        End Get
        Set(ByVal value As Integer)
            Entity.CveLote = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el numero de renglon
    ''' </summary>
    Public Property Renglon() As Short
        Get
            Return Entity.CveRenglon
        End Get
        Set(ByVal value As Short)
            Entity.CveRenglon = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo de la formula que se aplica
    ''' </summary>
    Public Property IdFormula() As Integer
        Get
            Return Entity.CveFormula
        End Get
        Set(ByVal value As Integer)
            Entity.CveFormula = value

            ObtenerCostoFormula()
            InicializarCantidadServidas()
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el numero de cabezas del lote
    ''' </summary>
    Public Property Cabezas() As Integer
        Get
            Return Entity.Cabezas
        End Get
        Set(ByVal value As Integer)
            Entity.Cabezas = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece los kilos del lote
    ''' </summary>
    Public Property Kilos() As Integer
        Get
            Return Entity.KilosxLote
        End Get
        Set(ByVal value As Integer)
            Entity.KilosxLote = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de la primera servida
    ''' </summary>
    Public Property CantidadServida1() As Decimal
        Get
            Return Entity.CantServ1
        End Get
        Set(ByVal value As Decimal)
            If Me.ValidarCantidadServida(CantidadServida1, value) Then
                Entity.CantServ1 = value

                Me.NumeroServidas = (CType((Me.CantidadServida1 > 0D), Integer) + CType((Me.CantidadServida2 > 0D), Integer) + CType((Me.CantidadServida3 > 0D), Integer) + CType((Me.CantidadServida4 > 0D), Integer)) * -1

                Me.Importe = Me.CantidadTotalServida * Me.CostoFormula
            Else
                MsgBox("A sobrepasado la cantidad disponible de la formula", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de la segunda servida
    ''' </summary>
    Public Property CantidadServida2() As Decimal
        Get
            Return Entity.CantServ2
        End Get
        Set(ByVal value As Decimal)
            If Me.ValidarCantidadServida(CantidadServida2, value) Then
                Entity.CantServ2 = value

                Me.NumeroServidas = (CType((Me.CantidadServida1 > 0D), Integer) + CType((Me.CantidadServida2 > 0D), Integer) + CType((Me.CantidadServida3 > 0D), Integer) + CType((Me.CantidadServida4 > 0D), Integer)) * -1

                Me.Importe = Me.CantidadTotalServida * Me.CostoFormula
            Else
                MsgBox("A sobrepasado la cantidad disponible de la formula", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de la tercera servida
    ''' </summary>
    Public Property CantidadServida3() As Decimal
        Get
            Return Entity.CantServ3
        End Get
        Set(ByVal value As Decimal)
            If Me.ValidarCantidadServida(CantidadServida3, value) Then
                Entity.CantServ3 = value

                Me.NumeroServidas = (CType((Me.CantidadServida1 > 0D), Integer) + CType((Me.CantidadServida2 > 0D), Integer) + CType((Me.CantidadServida3 > 0D), Integer) + CType((Me.CantidadServida4 > 0D), Integer)) * -1

                Me.Importe = Me.CantidadTotalServida * Me.CostoFormula
            Else
                MsgBox("A sobrepasado la cantidad disponible de la formula", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de la cuarta servida
    ''' </summary>
    Public Property CantidadServida4() As Decimal
        Get
            Return Entity.CantServ4
        End Get
        Set(ByVal value As Decimal)
            If Me.ValidarCantidadServida(CantidadServida4, value) Then
                Entity.CantServ4 = value

                Me.NumeroServidas = (CType((Me.CantidadServida1 > 0D), Integer) + CType((Me.CantidadServida2 > 0D), Integer) + CType((Me.CantidadServida3 > 0D), Integer) + CType((Me.CantidadServida4 > 0D), Integer)) * -1

                Me.Importe = Me.CantidadTotalServida * Me.CostoFormula
            Else
                MsgBox("A sobrepasado la cantidad disponible de la formula", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End Set
    End Property

    Public ReadOnly Property CantidadTotalServida() As Decimal
        Get
            Return Me.CantidadServida1 + Me.CantidadServida2 + Me.CantidadServida3 + Me.CantidadServida4
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo de la formula
    ''' </summary>
    Public Property CostoFormula() As Decimal
        Get
            Return Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Entity.Costo = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el importe total de la aplicacion de formula
    ''' </summary>
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la formula aplicada
    ''' </summary>
    Public Property Formula() As ProductoClass
        Get
            If m_Formula Is Nothing Then
                m_Formula = New ProductoClass(Entity.Producto)
            ElseIf Not m_Formula.Codigo = IdFormula Then
                m_Formula.Entidad = Entity.Producto
            End If

            Return m_Formula
        End Get
        Set(ByVal value As ProductoClass)
            m_Formula = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.Entidad
            End If

            ObtenerCostoFormula()
            InicializarCantidadServidas()
        End Set
    End Property

    Public ReadOnly Property NombreFormula() As String
        Get
            Return Formula.Descripcion
        End Get
    End Property

    Public Property NumeroServidas() As Integer
        Get
            Return Entity.Servidas
        End Get
        Set(ByVal value As Integer)
            Entity.Servidas = value
        End Set
    End Property

    Public ReadOnly Property FechaAplicacion() As Date
        Get
            Return AplicacionFormula.FechaAplicacion
        End Get
    End Property

    Public Property LoteAlmacen() As String
        Get
            Return Entity.LoteAlmacen
        End Get
        Set(ByVal value As String)
            Entity.LoteAlmacen = value
        End Set
    End Property

    Public ReadOnly Property NombreUnidad() As String
        Get
            Return Formula.UnidadMedida.Descripcion
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub ObtenerCostoFormula()
        If Formula.SeManejaPorLotes Then
            Dim invLote As New AlmacenGeneral.InventarioAlmacenLoteClass

            If invLote.ObteneryActualizarInventario(Me.AplicacionFormula.IdAlmacen, IdFormula, LoteAlmacen, Nothing) Then
                CostoFormula = invLote.CostoPromedio
            Else
                CostoFormula = 0D
            End If
        Else
            Dim inv As New AlmacenGeneral.InventarioAlmacenClass

            If inv.ObteneryActualizarInventario(Me.AplicacionFormula.IdAlmacen, Me.IdFormula, Nothing) Then
                CostoFormula = inv.CostoPromedio
            Else
                CostoFormula = 0D
            End If
        End If
    End Sub

    Private Function ValidarCantidadServida(ByVal valorActual As Decimal, ByVal nuevoValor As Decimal) As Boolean
        Try
            Dim controlInventario As AplicacionFormulaClass.ControlCantidadDisponibleFormulaClass
            Dim formulas As Dictionary(Of String, AplicacionFormulaClass.ControlCantidadDisponibleFormulaClass)

            If Me.AplicacionFormula.m_ControlInventarioFormulas.ContainsKey(IdFormula) Then
                formulas = Me.AplicacionFormula.m_ControlInventarioFormulas(IdFormula)

                If formulas.ContainsKey(LoteAlmacen) Then
                    controlInventario = formulas(LoteAlmacen)
                    Return controlInventario.CantidadDisponible >= controlInventario.Cantidad - valorActual + nuevoValor
                ElseIf formulas.ContainsKey(Nothing) Then
                    controlInventario = formulas(Nothing)
                    Return controlInventario.CantidadDisponible >= controlInventario.Cantidad - valorActual + nuevoValor
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub InicializarCantidadServidas()
        Me.CantidadServida4 = 0D
        Me.CantidadServida3 = 0D
        Me.CantidadServida2 = 0D
        Me.CantidadServida1 = 0D
    End Sub

    Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean
        trans.Add(Entity)
        Entity.Save()
        AfectarCorralLote(trans)

        Return True
    End Function

    Public Shadows Function Borrar(ByVal trans As HC.Transaction) As Boolean
        trans.Add(Entity)
        Entity.Save()
        AfectarCorralLoteCancelacion(trans)

        Return True
    End Function

    Private Sub AfectarCorralLote(ByVal trans As HC.Transaction)
        Dim afectarLote As Boolean = False
        Dim lotes As New CC.McecatLotesCabCollection
        Dim detalleCorral As CC.McecatCorralesDetCollection

        trans.Add(Corral.Entidad)
        Corral.Entidad.Refetch()

        trans.Add(lotes)

        If lotes.GetDbCount(HC.McecatLotesCabFields.Estatus = 1 And HC.McecatLotesCabFields.IdCorral = IdCorral) > 0 Then
            trans.Add(Lote.Entidad)
            Lote.Entidad.Refetch()
            afectarLote = True
        End If

        For Each detCorral As CorralDetalleClass In Corral.Detalle
            Dim kilosAgregar As Decimal = ((Me.CantidadTotalServida / Corral.TotalCabezas) * detCorral.ExistCabezas)
            Dim importeAlimento As Decimal = ((Me.Importe / Corral.TotalCabezas) * detCorral.ExistCabezas)

            detCorral.KilosAlimento += kilosAgregar
            detCorral.ImpteAlimento += importeAlimento
        Next

        detalleCorral = Corral.Detalle.ObtenerColeccion
        trans.Add(detalleCorral)
        detalleCorral.SaveMulti()

        If afectarLote Then
            Dim kilosAlimento As Decimal
            Dim importeAlimento As Decimal
            Dim datosAfectadosLoteDetalle As New EC.McecatLotesDetEntity
            Dim afectarDatosLotesDetalle As New CC.McecatLotesDetCollection

            Lote.SaldoKilosAlim += Me.CantidadTotalServida
            Lote.SaldoImpteAlim += Me.Importe
            Lote.AcumKilosAlim += Me.CantidadTotalServida
            Lote.AcumImpteAlim += Me.Importe

            kilosAlimento = Me.CantidadTotalServida / Me.Cabezas
            importeAlimento = Me.Importe / Me.Cabezas

            datosAfectadosLoteDetalle.Fields("KilosAlim").ExpressionToApply = _
                                            (HC.McecatLotesDetFields.KilosAlim + kilosAlimento)
            datosAfectadosLoteDetalle.Fields("ImpteAlim").ExpressionToApply = _
                                        (HC.McecatLotesDetFields.ImpteAlim + importeAlimento)

            trans.Add(afectarDatosLotesDetalle)

            afectarDatosLotesDetalle.UpdateMulti(datosAfectadosLoteDetalle, HC.McecatLotesDetFields.IdLote = Me.IdLote)
            Lote.Entidad.Save()
        End If
    End Sub

    Private Sub AfectarCorralLoteCancelacion(ByVal trans As HC.Transaction)
        Dim afectarLote As Boolean = False
        Dim lotes As New CC.McecatLotesCabCollection
        Dim detalleCorral As CC.McecatCorralesDetCollection

        trans.Add(Corral.Entidad)
        Corral.Entidad.Refetch()

        trans.Add(lotes)

        If lotes.GetDbCount(HC.McecatLotesCabFields.Estatus = 1 And HC.McecatLotesCabFields.IdCorral = IdCorral) > 0 Then
            trans.Add(Lote.Entidad)
            Lote.Entidad.Refetch()
            afectarLote = True
        End If

        For Each detCorral As CorralDetalleClass In Corral.Detalle
            Dim kilosAgregar As Decimal = ((Me.CantidadTotalServida / Cabezas) * detCorral.ExistCabezas)
            Dim importeAlimento As Decimal = ((Me.Importe / Cabezas) * detCorral.ExistCabezas)

            detCorral.KilosAlimento -= kilosAgregar
            detCorral.ImpteAlimento -= importeAlimento
        Next

        detalleCorral = Corral.Detalle.ObtenerColeccion
        trans.Add(detalleCorral)
        detalleCorral.SaveMulti()

        If afectarLote Then
            Dim kilosAlimento As Decimal
            Dim importeAlimento As Decimal
            Dim datosAfectadosLoteDetalle As New EC.McecatLotesDetEntity
            Dim afectarDatosLotesDetalle As New CC.McecatLotesDetCollection

            Lote.SaldoKilosAlim -= Me.CantidadTotalServida
            Lote.SaldoImpteAlim -= Me.Importe
            Lote.AcumKilosAlim -= Me.CantidadTotalServida
            Lote.AcumImpteAlim -= Me.Importe

            kilosAlimento = Me.CantidadTotalServida / Me.Cabezas
            importeAlimento = Me.Importe / Me.Cabezas

            datosAfectadosLoteDetalle.Fields("KilosAlim").ExpressionToApply = _
                                            (HC.McecatLotesDetFields.KilosAlim - kilosAlimento)
            datosAfectadosLoteDetalle.Fields("ImpteAlim").ExpressionToApply = _
                                        (HC.McecatLotesDetFields.ImpteAlim - importeAlimento)

            trans.Add(afectarDatosLotesDetalle)

            afectarDatosLotesDetalle.UpdateMulti(datosAfectadosLoteDetalle, HC.McecatLotesDetFields.IdLote = Me.IdLote)
            Lote.Entidad.Save()
        End If
    End Sub
#End Region
End Class