Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum

Public Class AplicacionFormulaClass
    Inherits ClassBase(Of EC.CabAplForEntity)

#Region "Campos"
    ''' <summary>
    ''' Contiene la informacion del almacen donde se obtendra la formula
    ''' </summary>
    Private m_Almacen As AlmacenClass
    ''' <summary>
    ''' Contiene la informacion del movimiento almacen generado por la aplicacion de formulas
    ''' </summary>
    Private m_MovimeintoAlmacen As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene la informacion del movimeinto almacen generado al cancelar la aplicacion de formula
    ''' </summary>
    Private m_MovimientoAlmacenCancelacion As AlmacenGeneral.MovimientoAlmacenClass
    ''' <summary>
    ''' Contiene las formulas aplicadas en esta aplicacion de formulas
    ''' </summary>
    Private WithEvents m_Detalle As AplicacionFormulaDetalleCollectionClass
    Private m_FormulasAplicadas As FormulaAplicadaCollecion
    Private m_ConsumoXFormula As Decimal
    Friend m_ControlInventarioFormulas As New Dictionary(Of Integer, Dictionary(Of String, ControlCantidadDisponibleFormulaClass))
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.CabAplForEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal folioAplicacionFormula As String)
        Me.New(New EC.CabAplForEntity(folioAplicacionFormula))
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene el folio de aplicacion de formula
    ''' </summary>
    ''' <value>String</value>
    Public Property FolioAplicacionFormula() As String
        Get
            Return Entity.FolAplF
        End Get
        Set(ByVal value As String)
            Entity.FolAplF = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el almacen donde se preparo la formula
    ''' </summary>
    Public Property IdAlmacen() As Integer
        Get
            Return Entity.IdAlmacen
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacen = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha en que se aplica la formula
    ''' </summary>
    Public Property FechaAplicacion() As DateTime
        Get
            Return Entity.FechaAplicacion
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaAplicacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha en que se contabilizo la aplicacion
    ''' </summary>
    Public Property FechaContabilizacion() As Nullable(Of Date)
        Get
            Return Entity.FechaContabilizacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaContabilizacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el folio de la poliza que contabilizo la aplicacion
    ''' </summary>
    Public Property FolioPoliza() As String
        Get
            Return Entity.FolPoliza
        End Get
        Set(ByVal value As String)
            Entity.FolPoliza = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo total de la aplicacion de formulas
    ''' </summary>
    Public Property Costo() As Decimal
        Get
            Return Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Entity.Costo = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario que registro la aplicacion de formulas
    ''' </summary>
    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario que cancelo la aplicacion de formulas
    ''' </summary>
    Public Property IdUsuarioCancelacion() As Integer
        Get
            Return Entity.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la fecha en que fue capturada la aplicacion de formulas
    ''' </summary>
    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la establece la fecha en que fue cancelada la aplicacion
    ''' </summary>
    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus de la aplicacion de formulas
    ''' </summary>
    Public Property Estatus() As EstatusAplicacionFormula
        Get
            Return CType(Entity.Estatus, EstatusAplicacionFormula)
        End Get
        Set(ByVal value As EstatusAplicacionFormula)
            Entity.Estatus = CType(value, Short)
        End Set
    End Property

    Public Property Cabezas() As Integer
        Get
            Return Entity.Cabezas
        End Get
        Set(ByVal value As Integer)
            Entity.Cabezas = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Folio Movimeinto Almacen que se genera al aplicar la formulas
    ''' </summary>
    Public Property FolioMovimeintoAlmacen() As String
        Get
            Return Entity.FolioMovimientoAlmacen
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacen = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el Folio Movimiento Almacen con que se cancela la aplicacion de formulas
    ''' </summary>
    Public Property FolioMovimientoAlmacenCancelacion() As String
        Get
            Return Entity.FolioMovimientoAlmacenCancelacion
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoAlmacenCancelacion = value
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

    Public Property MovimientoAlmacen() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimeintoAlmacen Is Nothing Then
                Me.m_MovimeintoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen)
            ElseIf Not Me.m_MovimeintoAlmacen.FolioMovimientoAlmacen.Trim = Me.FolioMovimeintoAlmacen.Trim AndAlso _
                    Not Me.m_MovimeintoAlmacen.IdAlmacen = IdAlmacen Then
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
        End Set
    End Property

    Public Property MovimientoAlmacenCancelacion() As AlmacenGeneral.MovimientoAlmacenClass
        Get
            If Me.m_MovimientoAlmacenCancelacion Is Nothing Then
                Me.m_MovimientoAlmacenCancelacion = _
                            New AlmacenGeneral.MovimientoAlmacenClass(Entity.InventarioMovimientoAlmacen_)
            ElseIf Not Me.m_MovimientoAlmacenCancelacion.FolioMovimientoAlmacen.Trim = _
                    Me.FolioMovimientoAlmacenCancelacion.Trim AndAlso _
                    Not Me.m_MovimientoAlmacenCancelacion.IdAlmacen = IdAlmacen Then
                Me.m_MovimientoAlmacenCancelacion.Entidad = Entity.InventarioMovimientoAlmacen_
            End If

            Return Me.m_MovimientoAlmacenCancelacion
        End Get
        Set(ByVal value As AlmacenGeneral.MovimientoAlmacenClass)
            Me.m_MovimientoAlmacenCancelacion = value

            If value Is Nothing Then
                Entity.InventarioMovimientoAlmacen_ = Nothing
            Else
                Entity.InventarioMovimientoAlmacen_ = value.Entidad
            End If
        End Set
    End Property

    Public ReadOnly Property Detalle() As AplicacionFormulaDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New AplicacionFormulaDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.DetAplFor)
            End If

            Return m_Detalle
        End Get
    End Property

    ''' <summary>
    ''' Contiene las formulas que fueron aplicadas con su cantida aplicada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FormulasAplicadas() As FormulaAplicadaCollecion
        Get
            If Me.m_FormulasAplicadas Is Nothing Then
                Me.m_FormulasAplicadas = New FormulaAplicadaCollecion
                Me.CalcularFormulasAplicadas()
            End If

            Return Me.m_FormulasAplicadas
        End Get
    End Property

    Public Property TotalServidas() As Decimal
        Get
            Return Entity.TotalServidas
        End Get
        Set(ByVal value As Decimal)
            Entity.TotalServidas = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub CalcularFormulasAplicadas()
        Me.TotalServidas = 0D
        Me.Cabezas = 0
        Dim formulas As New Dictionary(Of Integer, FormulaAplicadaClass)

        Me.m_ControlInventarioFormulas.Clear()

        If Me.m_FormulasAplicadas Is Nothing Then
            m_FormulasAplicadas = New FormulaAplicadaCollecion
        Else
            Me.m_FormulasAplicadas.Clear()
        End If

        For Each aplicacionFormula As AplicacionFormulaDetalleClass In Detalle
            If formulas.ContainsKey(aplicacionFormula.IdFormula) Then
                formulas(aplicacionFormula.IdFormula).Cantidad += aplicacionFormula.CantidadTotalServida

                If CType(aplicacionFormula.Formula.SeManejaPorLotes, AsignadaEnum) = AsignadaEnum.SI Then
                    If Me.m_ControlInventarioFormulas(aplicacionFormula.IdFormula).ContainsKey(aplicacionFormula.LoteAlmacen) Then
                        Me.m_ControlInventarioFormulas(aplicacionFormula.IdFormula)(aplicacionFormula.LoteAlmacen).Cantidad += aplicacionFormula.CantidadTotalServida
                    Else
                        Dim nuevoControl As New Dictionary(Of String, ControlCantidadDisponibleFormulaClass)

                        m_ControlInventarioFormulas.Add(aplicacionFormula.IdFormula, nuevoControl)
                        nuevoControl.Add(aplicacionFormula.LoteAlmacen, New ControlCantidadDisponibleFormulaClass)
                        nuevoControl(aplicacionFormula.LoteAlmacen).CantidadDisponible = Me.ObtenerCantidadDisponibleFormula(aplicacionFormula.Formula, aplicacionFormula.LoteAlmacen)
                        nuevoControl(aplicacionFormula.LoteAlmacen).Cantidad = aplicacionFormula.CantidadTotalServida
                        nuevoControl(aplicacionFormula.LoteAlmacen).Formula = aplicacionFormula.Formula
                        nuevoControl(aplicacionFormula.LoteAlmacen).LoteAlmacen = aplicacionFormula.LoteAlmacen
                    End If
                Else
                    Me.m_ControlInventarioFormulas(aplicacionFormula.IdFormula)(aplicacionFormula.LoteAlmacen).Cantidad += aplicacionFormula.CantidadTotalServida
                End If

                Me.TotalServidas += aplicacionFormula.CantidadTotalServida
                Me.Cabezas += aplicacionFormula.Cabezas
            ElseIf Not aplicacionFormula.Formula.Entidad.IsNew Then
                Dim nuevoControl As New Dictionary(Of String, ControlCantidadDisponibleFormulaClass)

                formulas.Add(aplicacionFormula.IdFormula, New FormulaAplicadaClass)
                formulas(aplicacionFormula.IdFormula).Cantidad = aplicacionFormula.CantidadTotalServida
                formulas(aplicacionFormula.IdFormula).Formula = aplicacionFormula.Formula

                m_ControlInventarioFormulas.Add(aplicacionFormula.IdFormula, nuevoControl)

                nuevoControl.Add(aplicacionFormula.LoteAlmacen, New ControlCantidadDisponibleFormulaClass)
                nuevoControl(aplicacionFormula.LoteAlmacen).CantidadDisponible = Me.ObtenerCantidadDisponibleFormula(aplicacionFormula.Formula, aplicacionFormula.LoteAlmacen)
                nuevoControl(aplicacionFormula.LoteAlmacen).Cantidad = aplicacionFormula.CantidadTotalServida
                nuevoControl(aplicacionFormula.LoteAlmacen).Formula = aplicacionFormula.Formula
                nuevoControl(aplicacionFormula.LoteAlmacen).LoteAlmacen = aplicacionFormula.LoteAlmacen

                Me.FormulasAplicadas.Add(formulas(aplicacionFormula.IdFormula))
                Me.TotalServidas += aplicacionFormula.CantidadTotalServida
                Me.Cabezas += aplicacionFormula.Cabezas
            End If
        Next
    End Sub

    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Aplicacion Formula")

        Try
            GenerarMovimientoAlmacen()
            MovimientoAlmacen.Guardar(trans)
            GenerarFolioApicacion(trans)
            trans.Add(Entity)
            Estatus = EstatusAplicacionFormula.VIGENTE
            Entity.Save()
            Detalle.Guardar(trans)

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Throw ex
        End Try
    End Function

    Public Shadows Function Borrar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Aplicacion Formula")

        Try
            Me.Estatus = EstatusAplicacionFormula.CANCELADA
            Me.GenerarMovimientoAlmacenCancelacion()
            Me.MovimientoAlmacenCancelacion.Guardar(trans)
            Me.Detalle.Borrar(trans)
            trans.Add(Entity)
            Entity.Save()

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Me.Estatus = EstatusAplicacionFormula.VIGENTE
            Throw ex
        End Try
    End Function

    Private Sub GenerarMovimientoAlmacenCancelacion()
        Me.MovimientoAlmacenCancelacion = New AlmacenGeneral.MovimientoAlmacenClass

        With Me.MovimientoAlmacenCancelacion
            .IdAlmacen = Me.IdAlmacen
            .Entregar = ""
            .EstatusContabilizado = 0
            .FechaMovimiento = Me.FechaCancelacion.Value
            .IdUsuarioAlta = Me.IdUsuarioCancelacion
            .Observaciones = ""
            .Origen = "Aplicacion Formula"
            .Recibe = ""
            .Referencia = Me.FolioMovimeintoAlmacen
            '.TipoMovimientos = Entradas_X_Cacnelacion_Aplicacion_Formula
            .TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Entradas_X_Cacnelacion_Aplicacion_Formula
        End With

        For i As Integer = 0 To Me.Detalle.Count - 1
            Dim detalleAplicacion As AplicacionFormulaDetalleClass = Me.Detalle(i)

            With detalleAplicacion
                Me.MovimientoAlmacenCancelacion.Detalle.Add(Me.MovimientoAlmacenCancelacion, i + 1, .IdFormula, Me.FechaCancelacion.Value, _
                                .CantidadTotalServida, .CostoFormula, 0D, .LoteAlmacen, New Nullable(Of Date))
            End With
        Next
    End Sub

    Private Sub GenerarFolioApicacion(ByVal trans As HC.Transaction)
        Dim folio As New FoliosClass

        folio.Año = 1
        folio.Mes = 1
        folio.Codigo = CodigodeFolios.AplicacionFormula

        If Not folio.Guardar(trans) Then
            Throw New Exception("No se genero el folio de la aplicación de formula")
        End If

        Me.FolioAplicacionFormula = "F" & folio.Consecutivo.ToString("0000000")
    End Sub

    Private Sub GenerarMovimientoAlmacen()
        Me.MovimientoAlmacen = New AlmacenGeneral.MovimientoAlmacenClass

        With Me.MovimientoAlmacen
            .IdAlmacen = Me.IdAlmacen
            .Entregar = ""
            .EstatusContabilizado = 0
            .FechaMovimiento = Me.FechaAplicacion
            .IdUsuarioAlta = Me.IdUsuarioAlta
            .Observaciones = ""
            .Origen = "Aplicacion Formula"
            .Recibe = ""
            .Referencia = ""
            '.TipoMovimientos = Salidas_X_Aplicacion_Formula
            .TipoMovimientos = AlmacenGeneral.ConfiguracionMovimientoAlmacenGeneralClass.TipoMovimientoEnum.Salidas_X_Aplicacion_Formula
        End With

        Me.Costo = 0D

        For i As Integer = 0 To Me.Detalle.Count - 1
            Dim detalleAplicacion As AplicacionFormulaDetalleClass = Me.Detalle(i)
            With detalleAplicacion
                Me.MovimientoAlmacen.Detalle.Add(Me.MovimientoAlmacen, i + 1, .IdFormula, Me.FechaAplicacion, _
                                .CantidadTotalServida, .CostoFormula, 0D, .LoteAlmacen, New Nullable(Of Date))
                Me.Costo += .Importe
            End With
        Next
    End Sub

    Private Function ObtenerCantidadDisponibleFormula(ByVal Formula As ProductoClass, ByVal loteAlmacen As String) As Decimal
        If Formula.SeManejaPorLotes Then
            Dim invLote As New AlmacenGeneral.InventarioAlmacenLoteClass

            If invLote.ObteneryActualizarInventario(IdAlmacen, Formula.Codigo, loteAlmacen, Nothing) Then
                Return invLote.CantidadExistencia
            Else
                Return 0D
            End If
        Else
            Dim inv As New AlmacenGeneral.InventarioAlmacenClass

            If inv.ObteneryActualizarInventario(IdAlmacen, Formula.Codigo, Nothing) Then
                Return inv.CantidadExistencia
            Else
                Return 0D
            End If
        End If
    End Function
#End Region

#Region "Tipos Anidados"
    Public Enum EstatusAplicacionFormula
        CANCELADA = 0
        VIGENTE
        CONTABILIZADA
    End Enum

    Public Class FormulaAplicadaClass
        Private m_Formula As ProductoClass
        Private m_Cantidad As Decimal

        Public Property Formula() As ProductoClass
            Get
                Return m_Formula
            End Get
            Set(ByVal value As ProductoClass)
                m_Formula = value
            End Set
        End Property

        Public Property Cantidad() As Decimal
            Get
                Return m_Cantidad
            End Get
            Set(ByVal value As Decimal)
                m_Cantidad = value
            End Set
        End Property

        Public Property CantidadDisponible() As Decimal
            Get

            End Get
            Set(ByVal value As Decimal)

            End Set
        End Property
    End Class

    Public Class FormulaAplicadaCollecion
        Inherits ColleccionBase(Of FormulaAplicadaClass)

    End Class

    Friend Class ControlCantidadDisponibleFormulaClass
        Private m_loteAlmacen As String
        Private m_Cantidad As Decimal
        Private m_CantidadDisponible As Decimal
        Private m_Formula As ProductoClass

        Public Property Formula() As ProductoClass
            Get
                Return m_Formula
            End Get
            Set(ByVal value As ProductoClass)
                m_Formula = value
            End Set
        End Property

        Public Property Cantidad() As Decimal
            Get
                Return m_Cantidad
            End Get
            Set(ByVal value As Decimal)
                m_Cantidad = value
            End Set
        End Property

        Public Property CantidadDisponible() As Decimal
            Get
                Return m_CantidadDisponible
            End Get
            Set(ByVal value As Decimal)
                m_CantidadDisponible = value
            End Set
        End Property

        Public Property LoteAlmacen() As String
            Get
                Return m_loteAlmacen
            End Get
            Set(ByVal value As String)
                m_loteAlmacen = value
            End Set
        End Property
    End Class
#End Region

    Private Sub m_Detalle_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles m_Detalle.AddingNew
        e.NewObject = New AplicacionFormulaDetalleClass
        DirectCast(e.NewObject, AplicacionFormulaDetalleClass).AplicacionFormula = Me
    End Sub



End Class