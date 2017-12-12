Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class Mezcla
    Inherits ClassBase(Of EC.CabPrepFormEntity)

#Region "Campos"
    ''' <summary>
    ''' Contiene los ingredientes con que se preparo la mezcla
    ''' </summary>
    Private m_Ingredientes As IngredienteCollection
    ''' <summary>
    ''' Contiene el almacen donde se prepara la mezcla
    ''' </summary>
    Private m_Almacen As AlmacenClass
    ''' <summary>
    ''' Contirne la plaza en la que se prepara la mezcla
    ''' </summary>
    Private m_Plaza As PlazaClass
    ''' <summary>
    ''' Contiene el envase donde se almacenara la mezcla
    ''' </summary>
    Private m_Envase As ProductoClass
    ''' <summary>
    ''' Contiene el movimeinto de almacen de la entrada de mezcla
    ''' </summary>
    Private m_MovimientoAlmacenEntradaMezcla As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene el movimiento de almacen de la salida de ingredientes
    ''' </summary>
    Private m_MovimientoAlmacenSalidaIngrediente As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene el movimiento de almacen de la cancelacion de entrada de mezcla
    ''' </summary>
    Private m_MovimientoCancelacionEntradaMezcla As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene el movimiento de almacen de la cancelacion de salida de ingredientes
    ''' </summary>
    Private m_MovimientoCancelacionSalidaMezcla As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene la mezcla que serea preparada
    ''' </summary>
    Private m_Mezcla As ProductoClass
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Inicializa la clase y consulta la preparacion de mezcla con el 
    ''' folio y código de plaza especificado
    ''' </summary>
    ''' <param name="folioPreparacionMezcla">folio de la preparacion de la mezcla</param>
    ''' <param name="idPlaza">Código de la palza donde se prepara la mezcla</param>
    Sub New(ByVal folioPreparacionMezcla As String, ByVal idPlaza As Integer)
        MyBase.New(New EC.CabPrepFormEntity(folioPreparacionMezcla, idPlaza))
    End Sub

    ''' <summary>
    ''' Inicializa la clase con los datos de la entity ingresada
    ''' </summary>
    ''' <param name="entidad">Entity con los datos de la preparacion de mezcla</param>
    Sub New(ByVal entidad As EC.CabPrepFormEntity)
        MyBase.New(entidad)
    End Sub

    ''' <summary>
    ''' Inicializa la clase con los valores por default
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        MyBase.New()
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Folio que se genera al preparar la mezcla
    ''' </summary>
    Public Property FolioPreparacionMezcla() As String
        Get
            Return Entity.FolPrepForm
        End Get
        Set(ByVal value As String)
            Entity.FolPrepForm = value
        End Set
    End Property

    ''' <summary>
    ''' Código de la plaza donde se prepara la mezcla
    ''' </summary>
    Public Property IdPlaza() As Integer
        Get
            Return Entity.IdPlaza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPlaza = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha en que se preapara la mezcla
    ''' </summary>
    Public Property FechaPreparacion() As Date
        Get
            Return Entity.FecPrepForm
        End Get
        Set(ByVal value As Date)
            Entity.FecPrepForm = value
        End Set
    End Property

    ''' <summary>
    ''' Código del almacén donde se optienen los ingredientes y se prepara la mezcla
    ''' </summary>
    Public Property IdAlmacen() As Integer
        Get
            Return Entity.CveAlmacen
        End Get
        Set(ByVal value As Integer)
            Entity.CveAlmacen = value
        End Set
    End Property

    ''' <summary>
    ''' Código de la mezcla que se preparara
    ''' </summary>
    Public Property IdMezcla() As Integer
        Get
            Return Entity.CveFormula
        End Get
        Set(ByVal value As Integer)
            Entity.CveFormula = value

            If Not Me.ObtenerIngredientesDeLaMezcla Then Me.Ingredientes.Clear()
        End Set
    End Property

    ''' <summary>
    ''' Cantidad de mezcla que se preparara
    ''' </summary>
    Public Property CantidadPreparar() As Decimal
        Get
            Return Entity.CantaPreparar
        End Get
        Set(ByVal value As Decimal)
            Entity.CantaPreparar = value

            Me.CalcularCantidadSalidaDeIngredientes()
        End Set
    End Property

    ''' <summary>
    ''' Cantidad Real de mezcla preparada
    ''' </summary>
    Public Property CantidadRealPreparada() As Decimal
        Get
            Return Entity.CantRealaPrep
        End Get
        Set(ByVal value As Decimal)
            Entity.CantRealaPrep = value
        End Set
    End Property

    ''' <summary>
    ''' Costo total de la preparacion de mezcla
    ''' </summary>
    Public Property CostoTotal() As Decimal
        Get
            Return Entity.CostoTotal
        End Get
        Private Set(ByVal value As Decimal)
            Entity.CostoTotal = value
        End Set
    End Property

    Public ReadOnly Property CostoUnitario() As Decimal
        Get
            Return CostoTotal / CantidadRealPreparada
        End Get
    End Property

    ''' <summary>
    ''' Observaciones hechas a la preparacion
    ''' </summary>
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Fecha en la que se realiza
    ''' </summary>
    Public Property FechaContabilizacion() As Nullable(Of Date)
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FecConta = value
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

    ''' <summary>
    ''' Obtiene o establece la fecha de cancelacion de la preparacion de mezcla
    ''' </summary>
    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entity.FecCancela
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FecCancela = value
        End Set
    End Property

    Public Property ReferenciaCancelada() As String
        Get
            Return Entity.RefCancela
        End Get
        Set(ByVal value As String)
            Entity.RefCancela = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus de la preparacion de mezcla
    ''' </summary>
    Public Property Estatus() As EstatusPreparacionMezcla
        Get
            Return CType(Entity.Estatus, EstatusPreparacionMezcla)
        End Get
        Set(ByVal value As Mezcla.EstatusPreparacionMezcla)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacen de la entrada de la mezcla
    ''' </summary>
    Public Property FolioMoviminetoAlmacenEntradaMezcla() As String
        Get
            Return Entity.FolioMovimientoAlmacenEntradaFormula
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenEntradaFormula = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacen de la salida de los ingredientes
    ''' </summary>
    Public Property FolioMovimientoAlmacenSalidaIngredientes() As String
        Get
            Return Entity.FolioMovimientoAlmacenSalidaIngredientes
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenSalidaIngredientes = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del envase que se usara en la preparacion de mezcla
    ''' </summary>
    Public Property IdEnvase() As Nullable(Of Integer)
        Get
            Return Entity.IdEnvase
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdEnvase = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacen de la cancelacion de entrada de la mezcla
    ''' </summary>
    Public Property FolioMovimientoAlmacenCancelacionEntradaMezcla() As String
        Get
            Return Entity.FolioMovimientoAlmacenCancelacionEntradaFormula
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenCancelacionEntradaFormula = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio del movimiento de almacen de la cancelacion de salida de ingredientes
    ''' </summary>
    Public Property FolioMovimientoAlmacenCancelacionSalidaMezcla() As String
        Get
            Return Entity.FolioMovimientoAlmacenCancelacionSalidaIngredientes
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenCancelacionSalidaIngredientes = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de envases requeridos para la preparacion de mezcla
    ''' </summary>
    Public Property CantidadEnvase() As Integer
        Get
            Return Entity.CantidadEnvase
        End Get
        Set(ByVal value As Integer)
            Entity.CantidadEnvase = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el almacén donde se tomaran los ingredientes, envases y se agregara la mezcla preparada
    ''' </summary>
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

    ''' <summary>
    ''' Obtiene o establece la mezcla que se prepara
    ''' </summary>
    Public Property Mezcla() As ProductoClass
        Get
            If Me.m_Mezcla Is Nothing Then
                Me.m_Mezcla = New ProductoClass(Entity.Producto)
            ElseIf Not Me.m_Mezcla.Codigo = IdMezcla Then
                Me.m_Mezcla.LeerEntidad(Entity.Producto)
            End If

            Return Me.m_Mezcla
        End Get
        Set(ByVal value As ProductoClass)
            Me.m_Mezcla = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.ObtenerEntidad
            End If

            If Not Me.ObtenerIngredientesDeLaMezcla Then Me.Ingredientes.Clear()
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el envase requerido para la preparacion de mezcla
    ''' </summary>
    Public Property Envase() As ProductoClass
        Get
            If Me.m_Envase Is Nothing Then
                Me.m_Envase = New ProductoClass(Entity.Envase)
            ElseIf Me.IdEnvase.HasValue AndAlso Not Me.m_Envase.Codigo = Me.IdEnvase.Value Then
                Me.m_Envase.LeerEntidad(Entity.Envase)
            End If

            Return Me.m_Envase
        End Get
        Set(ByVal value As ProductoClass)
            Me.m_Envase = value

            If value Is Nothing Then
                Entity.Envase = Nothing
            Else
                Entity.Envase = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimiento de almacen de la entrada de mezcla
    ''' </summary>
    Public Property MovimientoAlmacenEntradaMezcla() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacenEntradaMezcla Is Nothing Then
                Me.m_MovimientoAlmacenEntradaMezcla = New AlmacenGeneral.MovimientoAlmacenClass(Entity.MovimientoAlmacenEntradaMezcla)
            ElseIf Not Me.m_MovimientoAlmacenEntradaMezcla.IdAlmacen = IdAlmacen AndAlso _
                    Not Me.m_MovimientoAlmacenEntradaMezcla.FolioMovimientoAlmacen.Trim = _
                    Me.FolioMoviminetoAlmacenEntradaMezcla.Trim Then
                Me.m_MovimientoAlmacenEntradaMezcla.Entidad = Entity.MovimientoAlmacenEntradaMezcla
            End If

            Return Me.m_MovimientoAlmacenEntradaMezcla
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoAlmacenEntradaMezcla = value

            If value Is Nothing Then
                Entity.MovimientoAlmacenEntradaMezcla = Nothing
            Else
                Entity.MovimientoAlmacenEntradaMezcla = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimeinto de almacén de la cancelacion de entrada de mezcla
    ''' </summary>
    Public Property MovimientoAlmacenCancelacionEntradaMezcla() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoCancelacionEntradaMezcla Is Nothing Then
                Me.m_MovimientoCancelacionEntradaMezcla = _
                                        New AlmacenGeneral.MovimientoAlmacenClass(Entity.MovimientoAlmacenCancelacionEntradaMezcla)
            ElseIf Not Me.m_MovimientoCancelacionEntradaMezcla.IdAlmacen = IdAlmacen AndAlso _
                    Not Me.m_MovimientoCancelacionEntradaMezcla.FolioMovimientoAlmacen.Trim = _
                                        Me.FolioMovimientoAlmacenCancelacionEntradaMezcla.Trim Then
                Me.m_MovimientoCancelacionEntradaMezcla.Entidad = Entity.MovimientoAlmacenCancelacionEntradaMezcla
            End If

            Return Me.m_MovimientoCancelacionEntradaMezcla
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoCancelacionEntradaMezcla = value

            If value Is Nothing Then
                Entity.MovimientoAlmacenCancelacionEntradaMezcla = Nothing
            Else
                Entity.MovimientoAlmacenCancelacionEntradaMezcla = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el movimiento de almacén de la salida de ingredientes y mateiral de envase
    ''' </summary>
    Public Property MovimientoAlmacenSalidaIngrediente() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacenSalidaIngrediente Is Nothing Then
                Me.m_MovimientoAlmacenSalidaIngrediente = _
                        New AlmacenGeneral.MovimientoAlmacenClass(Entity.MovimientoAlmacenSalidaIngrediente)
            ElseIf Not Me.m_MovimientoAlmacenSalidaIngrediente.IdAlmacen = IdAlmacen AndAlso _
                    Not Me.m_MovimientoAlmacenSalidaIngrediente.FolioMovimientoAlmacen.Trim = _
                    Me.FolioMovimientoAlmacenSalidaIngredientes.Trim Then
                Me.m_MovimientoAlmacenSalidaIngrediente.Entidad = Entity.MovimientoAlmacenSalidaIngrediente
            End If

            Return Me.m_MovimientoAlmacenSalidaIngrediente
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoAlmacenSalidaIngrediente = value

            If value Is Nothing Then
                Entity.MovimientoAlmacenSalidaIngrediente = Nothing
            Else
                Entity.MovimientoAlmacenSalidaIngrediente = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el moviento de almacén de la cancelacion de la salida de ingredientes y mateiral de envase
    ''' </summary>
    Public Property MovimientoAlmacenCancelacionSalidaIngrediente() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoCancelacionSalidaMezcla Is Nothing Then
                Me.m_MovimientoCancelacionSalidaMezcla = _
                        New AlmacenGeneral.MovimientoAlmacenClass(Entity.MovimientoAlmacenCancelacionSalidaIngrediente)
            ElseIf Not Me.m_MovimientoCancelacionSalidaMezcla.IdAlmacen = IdAlmacen AndAlso _
                    Not Me.m_MovimientoCancelacionSalidaMezcla.FolioMovimientoAlmacen.Trim = _
                    Me.FolioMovimientoAlmacenCancelacionSalidaMezcla.Trim Then
                Me.m_MovimientoCancelacionSalidaMezcla.Entidad = Entity.MovimientoAlmacenCancelacionSalidaIngrediente
            End If

            Return Me.m_MovimientoCancelacionSalidaMezcla
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoCancelacionSalidaMezcla = value

            If value Is Nothing Then
                Entity.MovimientoAlmacenCancelacionSalidaIngrediente = Nothing
            Else
                Entity.MovimientoAlmacenCancelacionSalidaIngrediente = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la plaza en la que se realiza la preparacion de mezcla
    ''' </summary>
    Public Property Plaza() As PlazaClass
        Get
            If Me.m_Plaza Is Nothing Then
                Me.m_Plaza = New PlazaClass
                Me.m_Plaza.LeerEntidad(Entity.Plaza)
            ElseIf Not m_Plaza.Codigo = IdPlaza Then
                m_Plaza.LeerEntidad(Entity.Plaza)
            End If

            Return m_Plaza
        End Get
        Set(ByVal value As PlazaClass)
            m_Plaza = value

            If value Is Nothing Then
                Entity.Plaza = Nothing
            Else
                Entity.Plaza = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Ingredientes con que se preparo la mezcla
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Ingredientes() As IngredienteCollection
        Get
            If m_Ingredientes Is Nothing Then
                m_Ingredientes = New IngredienteCollection(Entity.DetPrepForm)
            End If

            Return m_Ingredientes
        End Get
    End Property

    Public Property Lote() As String
        Get
            Return Entity.Lote
        End Get
        Set(ByVal value As String)
            Entity.Lote = value.Trim
        End Set
    End Property

    Public Property FechaCaducidad() As Nullable(Of Date)
        Get
            Return Entity.FechaCaducidad
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCaducidad = value
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

    Public Property IdUsuarioCacnelacion() As Nullable(Of Integer)
        Get
            Return Entity.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <param name="FolioPreparacionMezcla">Folio que se genera al preparar la mezcla</param>
    ''' <param name="IdPlaza">Código de la plaza donde se prepara la mezcla</param>
    Public Function Obtener(ByVal FolioPreparacionMezcla As String, ByVal IdPlaza As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(FolioPreparacionMezcla, IdPlaza)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al obtener la mezcla", MsgBoxStyle.Critical, "Error")
#End If

            Return False
        End Try
    End Function

    Protected Overrides Function ValidarGuardar() As Boolean
        If Me.Mezcla.SeManejaPorLotes Then
            If Me.Lote.Trim = "" Then
                MsgBox("Debe ingresar un lote, la mezcla se maneja en lotes", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Guarda la mezcla con los datos ingresados
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Mezcla")

        Try
            If Not ValidarGuardar() Then Return False

            Me.MovimientoAlmacenEntradaMezcla.Detalle.Clear()
            Me.MovimientoAlmacenSalidaIngrediente.Detalle.Clear()

            Me.MovimientoAlmacenEntradaMezcla.TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Preparacion_Mezcla
            Me.MovimientoAlmacenEntradaMezcla.EstatusContabilizado = 0
            Me.MovimientoAlmacenEntradaMezcla.FechaMovimiento = Me.FechaPreparacion
            Me.MovimientoAlmacenEntradaMezcla.IdUsuarioAlta = Me.IdUsuarioAlta
            Me.MovimientoAlmacenEntradaMezcla.Origen = "Preparacion Mezcla"
            Me.MovimientoAlmacenEntradaMezcla.Referencia = ""
            Me.MovimientoAlmacenEntradaMezcla.IdAlmacen = IdAlmacen

            Me.MovimientoAlmacenEntradaMezcla.Detalle.Add(Me.MovimientoAlmacenEntradaMezcla, 1, _
                                                IdMezcla, Me.FechaPreparacion, Me.CantidadRealPreparada, _
                                                Me.CostoUnitario, 0D, Me.Lote, Me.FechaCaducidad)

            Me.MovimientoAlmacenSalidaIngrediente.TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Preparacion_Mezcla
            Me.MovimientoAlmacenSalidaIngrediente.EstatusContabilizado = 0
            Me.MovimientoAlmacenSalidaIngrediente.FechaMovimiento = Me.FechaPreparacion
            Me.MovimientoAlmacenSalidaIngrediente.IdUsuarioAlta = Me.IdUsuarioAlta
            Me.MovimientoAlmacenSalidaIngrediente.Origen = "Preparacion Mezcla"
            Me.MovimientoAlmacenSalidaIngrediente.Referencia = ""
            Me.MovimientoAlmacenSalidaIngrediente.IdAlmacen = Me.IdAlmacen

            For Each ingrediente As Ingrediente In Me.Ingredientes
                If ingrediente.Producto.SeManejaPorLotes Then
                    Dim lotes As List(Of LotesIngrediente) = Me.ObtenerLotesSalida(ingrediente)

                    ingrediente.IngredienteLotes.Clear()

                    For Each lote As LotesIngrediente In lotes
                        Dim loteIngrediente As New IngredienteLote

                        With loteIngrediente
                            .IngredienteMezcla = ingrediente
                            .Lote = lote.lote
                            .Cantidad = lote.cantidad
                            .CostoUnitario = lote.costo
                        End With

                        ingrediente.IngredienteLotes.Add(loteIngrediente)
                        Me.MovimientoAlmacenSalidaIngrediente.Detalle.Add(Me.MovimientoAlmacenSalidaIngrediente, _
                                                           Me.MovimientoAlmacenSalidaIngrediente.Detalle.Count + 1, _
                                                           ingrediente.IdProducto, Me.FechaPreparacion, _
                                                           lote.cantidad, lote.costo, _
                                                           0D, lote.lote, New Nullable(Of Date))
                    Next
                Else
                    Me.MovimientoAlmacenSalidaIngrediente.Detalle.Add(Me.MovimientoAlmacenSalidaIngrediente, _
                                                    Me.MovimientoAlmacenSalidaIngrediente.Detalle.Count + 1, _
                                                    ingrediente.IdProducto, Me.FechaPreparacion, _
                                                    ingrediente.KilogramosSalidaMezcla, ingrediente.CostoUnitario, _
                                                    0D, " ", New Nullable(Of Date))
                End If
            Next

            trans.Add(Entidad)

            GenerarFolio(trans)
            Me.MovimientoAlmacenEntradaMezcla.Guardar(trans)
            Me.MovimientoAlmacenSalidaIngrediente.Guardar(trans)

            Estatus = EstatusPreparacionMezcla.PREPARADA

            Entidad.Save()
            Me.Ingredientes.Guardar(trans)

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Me.MovimientoAlmacenSalidaIngrediente = Nothing
            Me.MovimientoAlmacenEntradaMezcla = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub GenerarFolio(ByVal trans As HC.Transaction)
        Dim folio As New FoliosClass

        folio.Codigo = CodigodeFolios.PreparacionMezcla
        folio.Año = 1 ' Now.Year
        folio.Mes = 1 ' Now.Month

        folio.Guardar(trans)

        Me.FolioPreparacionMezcla = folio.Consecutivo.ToString("00000000")
    End Sub

    Private Function ObtenerLotesSalida(ByVal ingrediente As Ingrediente) As List(Of LotesIngrediente)
        Dim lotesInventario As New CC.InventarioAlmacenLotesCollection
        Dim resultado As New List(Of LotesIngrediente)
        Dim sort As New OC.SortExpression
        Dim cantidadSalida As Decimal = ingrediente.KilogramosSalidaMezcla

        sort.Add(New OC.SortClause(HC.InventarioAlmacenLotesFields.FechaAlta, _
                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

        lotesInventario.GetMulti(HC.InventarioAlmacenLotesFields.AlmacenId = Me.IdAlmacen And _
                                HC.InventarioAlmacenLotesFields.ProductoId = ingrediente.IdProducto And _
                                HC.InventarioAlmacenLotesFields.CantidadExistencia > 0D, 0, sort)

        If lotesInventario.Count > 0 Then
            For Each lote As EC.InventarioAlmacenLotesEntity In lotesInventario
                If cantidadSalida > lote.CantidadExistencia Then
                    cantidadSalida -= lote.CantidadExistencia
                    resultado.Add(New LotesIngrediente(lote.Lote, lote.CantidadExistencia, lote.CostoPromedio))
                Else
                    resultado.Add(New LotesIngrediente(lote.Lote, cantidadSalida, lote.CostoPromedio))
                    Exit For
                End If
            Next
        End If

        Return resultado
    End Function

    Private Function ObtenerIngredientesDeLaMezcla() As Boolean
        Try
            Me.Ingredientes.Clear()

            Dim ingredientesMezcla As New CC.ProductoMezclaCollection

            ingredientesMezcla.GetMulti(HC.ProductoMezclaFields.CodigoProducto = Me.IdMezcla)

            For Each ingrediente As EC.ProductoMezclaEntity In ingredientesMezcla
                Dim ingredientePreparacion As New Ingrediente
                Dim invAlm As New AlmacenGeneral.InventarioAlmacenClass

                With ingredientePreparacion
                    .PreparacionMezcla = Me
                    .IdProducto = ingrediente.CodigoIngrediente
                    .PorcentajeMezcla = ingrediente.Porcentaje

                    If invAlm.ObteneryActualizarInventario(IdAlmacen, .IdProducto, Nothing) Then
                        .CostoUnitario = invAlm.CostoPromedio
                        .CantidadDisponible = invAlm.CantidadExistencia - invAlm.CantidadPorSurtir
                    Else
                        MsgBox("No se cuenta con el ingrediente " & .Producto.Descripcion & _
                                " en el inventario del almacén seleccionado", _
                                MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If

                    .KilogramosMezcla = 0D
                    .KilogramosSalidaMezcla = 0D
                End With

                Me.Ingredientes.Add(ingredientePreparacion)
            Next

            Me.CalcularCantidadSalidaDeIngredientes()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function CalcularCantidadSalidaDeIngredientes() As Boolean
        Try
            For Each ingrediente As Ingrediente In Me.Ingredientes
                Dim cantidadSujeridaIngrediente As Decimal = 0D

                cantidadSujeridaIngrediente = ingrediente.PorcentajeMezcla / 100 * Me.CantidadPreparar

                If cantidadSujeridaIngrediente > ingrediente.CantidadDisponible Then
                    ingrediente.KilogramosSalidaMezcla = ingrediente.CantidadDisponible
                Else
                    ingrediente.KilogramosSalidaMezcla = cantidadSujeridaIngrediente
                End If

                ingrediente.KilogramosMezcla = cantidadSujeridaIngrediente
            Next

            Me.CalcularCantidadRealPrepararYCostoTotal()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub CalcularCantidadRealPrepararYCostoTotal()
        Dim cantidadRealPreparar As Decimal = 0D
        Dim costoTotal As Decimal = 0D

        For Each ingrediente As Ingrediente In Me.Ingredientes
            cantidadRealPreparar += ingrediente.KilogramosSalidaMezcla
            costoTotal += ingrediente.Importe
        Next

        Me.CantidadRealPreparada = cantidadRealPreparar

        'If Me.IdEnvase.HasValue Then
        '    Dim inva As New AlmacenGeneral.InventarioAlmacenClass

        'End If

        Me.CostoTotal = costoTotal
    End Sub

    Public Shadows Function Borrar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "PrepararMezcla")

        Try

            Me.MovimientoAlmacenCancelacionEntradaMezcla.TipoMovimientos = _
                        AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Cancelacion_Entrada_X_Preparacion_Mezcla
            Me.MovimientoAlmacenCancelacionEntradaMezcla.EstatusContabilizado = 0
            Me.MovimientoAlmacenCancelacionEntradaMezcla.FechaMovimiento = Me.FechaCancelacion.Value
            Me.MovimientoAlmacenCancelacionEntradaMezcla.IdUsuarioAlta = Me.IdUsuarioCacnelacion.Value
            Me.MovimientoAlmacenCancelacionEntradaMezcla.Origen = "Preparacion Mezcla"
            Me.MovimientoAlmacenCancelacionEntradaMezcla.Referencia = Me.MovimientoAlmacenEntradaMezcla.FolioMovimientoAlmacen
            Me.MovimientoAlmacenCancelacionEntradaMezcla.IdAlmacen = IdAlmacen

            Me.MovimientoAlmacenCancelacionEntradaMezcla.Detalle.Add(MovimientoAlmacenCancelacionEntradaMezcla, 1, _
                                                IdMezcla, Me.FechaCancelacion, Me.CantidadRealPreparada, _
                                                Me.CostoUnitario, 0D, Me.Lote, Me.FechaCaducidad)

            With Me.MovimientoAlmacenSalidaIngrediente
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.TipoMovimientos = _
                    AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cancelacion_Salida_X_Preparacion_Mezcla
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.EstatusContabilizado = 0
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.FechaMovimiento = Me.FechaCancelacion
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.IdUsuarioAlta = Me.IdUsuarioCacnelacion
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.Origen = "Preparacion Mezcla"
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.Referencia = .FolioMovimientoAlmacen
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.IdAlmacen = IdAlmacen
            End With

            For Each detMov As AlmacenGeneral.MovimientoAlmacenDetalleClass In Me.MovimientoAlmacenSalidaIngrediente.Detalle
                Me.MovimientoAlmacenCancelacionSalidaIngrediente.Detalle.Add(Me.MovimientoAlmacenCancelacionSalidaIngrediente, _
                                                                detMov.Indice, detMov.IdProducto, Me.FechaCancelacion, _
                                                                detMov.Cantidad, detMov.Costo, detMov.Descuento, _
                                                                detMov.Lote, detMov.FechaCaducidad)
            Next

            Me.MovimientoAlmacenCancelacionEntradaMezcla.Guardar(trans)
            Me.MovimientoAlmacenCancelacionSalidaIngrediente.Guardar(trans)

            Me.Estatus = EstatusPreparacionMezcla.CANCELADA

            trans.Add(Entidad)

            Entidad.Save()

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Me.MovimientoAlmacenCancelacionEntradaMezcla = Nothing
            Me.MovimientoAlmacenCancelacionSalidaIngrediente = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub Imprimir(ByVal empresa As String)
        Try
            Dim mezclaImprimir As New MezclaCollection

            mezclaImprimir.Add(Me)

            mezclaImprimir.Imprimir(empresa)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "Tipos Anidados"
    Public Enum EstatusPreparacionMezcla
        ''' <summary>
        ''' La mezcla esta preparada
        ''' </summary>
        PREPARADA = 1
        ''' <summary>
        ''' La mezcla esta cancelada
        ''' </summary>
        CANCELADA = 0
    End Enum

    Private Structure LotesIngrediente
        Public lote As String
        Public cantidad As Decimal
        Public costo As Decimal

        Sub New(ByVal lote As String, ByVal cantidad As Decimal, ByVal costo As Decimal)
            Me.Lote = lote
            Me.cantidad = cantidad
            Me.costo = costo
        End Sub
    End Structure
#End Region

End Class