Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures

Public Class CortesClass
    Inherits ClassBase(Of EC.MscloteCortesCabEntity)

    Private _Func As String
    Private _NumOpc As Integer
    Private _Introductor As ClientesIntroductoresClass

    Property LoteCorte() As String
        Get
            Return Entity.LoteCorte
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    RaiseEvent MensajeError(Me, "Especifique Lote de Corte")
            '    Throw New System.SystemException(" ")
            'End If
            Entity.LoteCorte = value
        End Set

    End Property

    Property LoteSacrificio() As String
        Get
            Return Entity.LoteSacrificio
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            '    RaiseEvent MensajeError(Me, "Especifique Lote de Sacrificio")
            '    Throw New System.SystemException(" ")
            'End If
            Entity.LoteSacrificio = value
        End Set
    End Property

    Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    Property FechaCad() As Date
        Get
            Return Entity.FechaCad
        End Get
        Set(ByVal value As Date)
            Entity.FechaCad = value
        End Set
    End Property

    Property FechaCancela() As Date
        Get
            Return Entity.FechaCancela
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancela = value
        End Set
    End Property

    Property FechaCierre() As Date
        Get
            Return Entity.FechaCierre
        End Get
        Set(ByVal value As Date)
            Entity.FechaCierre = value
        End Set
    End Property

    Property FechaCorte() As Date
        Get
            Return Entity.FechaCorte
        End Get
        Set(ByVal value As Date)
            Entity.FechaCorte = value
        End Set
    End Property

    Property FechaFapsa() As Date
        Get
            Return Entity.FechaFapsa
        End Get
        Set(ByVal value As Date)
            Entity.FechaFapsa = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            If _Introductor Is Nothing Then
                _Introductor = New ClientesIntroductoresClass(Entity.IdCliente)
            End If
            Return _Introductor
        End Get
    End Property

    Property IdUsuarioCancela() As Integer
        Get
            Return Entity.IdUsuarioCancela
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioCancela = value
        End Set
    End Property

    Property ConsecEtiquetas() As Integer
        Get
            Return Entity.ConsecEtiquetas
        End Get
        Set(ByVal value As Integer)
            Entity.ConsecEtiquetas = value
        End Set
    End Property

    Property DiasCad() As Integer
        Get
            Return Entity.DiasCad
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                MsgBox("Especifique Dias de Caducidad del Lote de Corte", MsgBoxStyle.Critical, "Error")
                Throw New System.SystemException(" ")
            End If
            Entity.DiasCad = value
        End Set
    End Property

    Property FolCorPza() As String
        Get
            Return Entity.FolCorPza
        End Get
        Set(ByVal value As String)
            Entity.FolCorPza = value
        End Set
    End Property

    Property MotivoCancela() As String
        Get
            Return Entity.MotivoCancela
        End Get
        Set(ByVal value As String)
            Entity.MotivoCancela = value
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

    Property ObservacionesCancela() As String
        Get
            Return Entity.ObservacionesCancela
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesCancela = value
        End Set
    End Property

    Property TotalKgs() As Decimal
        Get
            Return Entity.TotalKgs
        End Get
        Set(ByVal value As Decimal)
            Entity.TotalKgs = value
        End Set
    End Property

    Property TotalPzas() As Integer
        Get
            Return Entity.TotalPzas
        End Get
        Set(ByVal value As Integer)
            Entity.TotalPzas = value
        End Set
    End Property

    Property Estatus() As String
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As String)
            Entity.Estatus = value
        End Set
    End Property
    ''------------------------------------------------------------------------------------
    Property Nopiezas() As Integer?
        Get
            Return Entity.Nopiezas
        End Get
        Set(ByVal value As Integer?)
            Entity.Nopiezas = value
        End Set
    End Property

    Property Producto() As Integer?
        Get
            Return Entity.Producto
        End Get
        Set(ByVal value As Integer?)
            Entity.Producto = value
        End Set
    End Property

    Property Unidad() As String
        Get
            Return Entity.Unidad
        End Get
        Set(ByVal value As String)
            Entity.Unidad = value
        End Set
    End Property

    Property Condutor() As String
        Get
            Return Entity.Conductor
        End Get
        Set(ByVal value As String)
            Entity.Conductor = value
        End Set
    End Property

    Property Placas() As String
        Get
            Return Entity.Placas
        End Get
        Set(ByVal value As String)
            Entity.Placas = value
        End Set
    End Property

    Property Horaviaje() As Decimal?
        Get
            Return Entity.Horaviaje
        End Get
        Set(ByVal value As Decimal?)
            Entity.Horaviaje = value
        End Set
    End Property

    Property Idproveedor() As Integer?
        Get
            Return Entity.Idproveedor
        End Get
        Set(ByVal value As Integer?)
            Entity.Idproveedor = value
        End Set
    End Property

    Property Cvelugcom() As Integer?
        Get
            Return Entity.Cvelugcomp
        End Get
        Set(ByVal value As Integer?)
            Entity.Cvelugcomp = value
        End Set
    End Property

    Property Cvecomprador() As Integer?
        Get
            Return Entity.Cvecomprador
        End Get
        Set(ByVal value As Integer?)
            Entity.Cvecomprador = value
        End Set
    End Property

    Property Observacioneslote() As String
        Get
            Return Entity.ObservacionesLotes
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesLotes = value
        End Set
    End Property

    Property KilosRecibidos() As Decimal?
        Get
            Return Entity.KilosRecibidos
        End Get
        Set(ByVal value As Decimal?)
            Entity.KilosRecibidos = value
        End Set
    End Property

    Property Nofactura() As String
        Get
            Return Entity.Nofactura
        End Get
        Set(ByVal value As String)
            Entity.Nofactura = value
        End Set
    End Property



    Property Importe() As Decimal?
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal?)
            Entity.Importe = value
        End Set
    End Property


    Property Conductor() As String
        Get
            Return Entity.Unidad
        End Get
        Set(ByVal value As String)
            Entity.Unidad = value
        End Set
    End Property


    ''---------------datos kilos nuevos -------------------------------------------------
    Property Precioxkilo() As Decimal?
        Get
            Return Entity.Precioxkilo
        End Get
        Set(ByVal value As Decimal?)
            Entity.Precioxkilo = value
        End Set
    End Property

    Property Precioxkilogasto() As Decimal?
        Get
            Return Entity.Precioxkilogasto
        End Get
        Set(ByVal value As Decimal?)
            Entity.Precioxkilogasto = value
        End Set
    End Property

    Property Precioxkilototal() As Decimal?
        Get
            Return Entity.Precioxkilototal
        End Get
        Set(ByVal value As Decimal?)
            Entity.Precioxkilototal = value
        End Set
    End Property
    ''------------------------------------------------------------------------------------

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer?
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer?)
            _NumOpc = value
        End Set
    End Property

    Public Overloads Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMscloteCortesCab(LoteSacrificio, FechaCorte, IdCliente, FechaCad, DiasCad, TotalPzas, TotalKgs, ConsecEtiquetas, Observaciones, Estatus, FechaCierre, FechaCancela, MotivoCancela, FechaCaptura, IdUsuarioCancela, ObservacionesCancela, FolCorPza, FechaFapsa, Nopiezas, Producto, Unidad, Conductor, Placas, Horaviaje, Idproveedor, Cvelugcom, Cvecomprador, Observacioneslote, KilosRecibidos, Nofactura, Importe, Precioxkilo, Precioxkilogasto, Precioxkilototal, Func, NumOpc, LoteCorte, trans) = 0 Then
                MsgBox("Error al guardar información de lote de corte", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox("Error al guardar información de lote de corte", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal opcion As Integer, ByVal LoteCorte As String) As DataSet
        Try
            Obtener = SPR.UspConMscloteCortesCab(opcion, LoteCorte)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Sub New()
        Entity = New EC.MscloteCortesCabEntity
        Entity.FechaCad = "01/01/1900"
        Entity.FechaCancela = "01/01/1900"
        Entity.FechaCaptura = "01/01/1900"
        Entity.FechaCierre = "01/01/1900"
        Entity.FechaCorte = "01/01/1900"
        Entity.FechaFapsa = "01/01/1900"
        Entity.ConsecEtiquetas = 0
        Entity.DiasCad = 30
        Entity.Estatus = "A"
        Entity.FolCorPza = ""
        Entity.MotivoCancela = ""
        Entity.Observaciones = ""
        Entity.ObservacionesCancela = ""
        Entity.TotalKgs = 0
        Entity.TotalPzas = 0
    End Sub

    Sub New(ByVal Entidad As EC.MscloteCortesCabEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal LoteCorte As String)
        Entity = New EC.MscloteCortesCabEntity(LoteCorte)
    End Sub
End Class
'clase para el detalle de cortes
Public Class CorteDetalleClass
    Inherits ClassBase(Of EC.MscloteCortesDetEntity)

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.MscloteCortesDetEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal LoteCorte As String, ByVal IdFolioEtiqueta As String)
        Entity = New EC.MscloteCortesDetEntity(LoteCorte, IdFolioEtiqueta)
    End Sub
#End Region

#Region "Propiedades"
    Public Property LoteCorte() As String
        Get
            Return Entity.LoteCorte
        End Get
        Set(ByVal value As String)
            Entity.LoteCorte = value
        End Set
    End Property

    Public Property IdFolioEtiqueta() As String
        Get
            Return Entity.IdFolioEtiqueta
        End Get
        Set(ByVal value As String)
            Entity.IdFolioEtiqueta = value
        End Set
    End Property

    Public Property IdCorte() As Integer
        Get
            Return Entity.IdCorte
        End Get
        Set(ByVal value As Integer)
            Entity.IdCorte = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    Public Property CantPzas() As Decimal
        Get
            Return Entity.CantPzas
        End Get
        Set(ByVal value As Decimal)
            Entity.CantPzas = value
        End Set
    End Property

    Public Property CantKgrs() As Decimal
        Get
            Return Entity.CantKgrs
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKgrs = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public Property IdFolioEmbarque() As String
        Get
            Return Entity.IdFolioEmbarque
        End Get
        Set(ByVal value As String)
            Entity.IdFolioEmbarque = value
        End Set
    End Property

    Public Property IdFolioMovimiento() As String
        Get
            Return Entity.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimiento = value
        End Set
    End Property

    Public Property CodigoBarra() As String
        Get
            Return Entity.CodigoBarra
        End Get
        Set(ByVal value As String)
            Entity.CodigoBarra = value
        End Set
    End Property

    Public Property IdFolioEtiquetaReferencia() As String
        Get
            Return Entity.IdFolioEtiquetaReferencia
        End Get
        Set(ByVal value As String)
            Entity.IdFolioEtiquetaReferencia = value
        End Set
    End Property

    Public Property Grados() As Integer
        Get
            Return Entity.Grados
        End Get
        Set(ByVal value As Integer)
            Entity.Grados = value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public Property FechaCaptura() As DateTime
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCaptura = value
        End Set
    End Property

    Public Property LoteCorteReproceso() As String
        Get
            Return Entity.LoteCorteReproceso
        End Get
        Set(ByVal value As String)
            Entity.LoteCorteReproceso = value
        End Set
    End Property

    Public Property IdFolioMovimientoAlmacenReproceso() As String
        Get
            Return Entity.IdFolioMovimientoAlmacenReproceso
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimientoAlmacenReproceso = value
        End Set
    End Property

    Public Property IdFolioMovimientoAlmacenAjuste() As String
        Get
            Return Entity.IdFolioMovimientoAlmacenAjuste
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimientoAlmacenAjuste = value
        End Set
    End Property

    Public Property FechaCaducidad() As DateTime
        Get
            Return Entity.FechaCaducidad
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCaducidad = value
        End Set
    End Property

    Public Property FechaCaducidadAnterior() As DateTime
        Get
            Return Entity.FechaCaducidadAnterior
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCaducidadAnterior = value
        End Set
    End Property

    Public Property IdFolioMovimientoAlmacenCongelado() As String
        Get
            Return Entity.IdFolioMovimientoAlmacenCongelado
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimientoAlmacenCongelado = value
        End Set
    End Property

    Public Property GradosAnterior() As Integer
        Get
            Return Entity.GradosAnterior
        End Get
        Set(ByVal value As Integer)
            Entity.GradosAnterior = value
        End Set
    End Property

    Public Property TipoProducto() As Short
        Get
            Return Entity.TipoProducto
        End Get
        Set(ByVal value As Short)
            Entity.TipoProducto = value
        End Set
    End Property

    Public Property IdAlmacenActual() As Integer
        Get
            Return Entity.IdAlmacenActual
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacenActual = value
        End Set
    End Property

    Public Property IdAlmacenOrigen() As Integer
        Get
            Return Entity.IdAlmacenOrigen
        End Get
        Set(ByVal value As Integer)
            Entity.IdAlmacenOrigen = value
        End Set
    End Property

    Public Property TipoProductoAnterior() As Short
        Get
            Return Entity.TipoProductoAnterior
        End Get
        Set(ByVal value As Short)
            Entity.TipoProductoAnterior = value
        End Set
    End Property

    Public Property CantLibras() As Decimal
        Get
            Return Entity.CantLibras
        End Get
        Set(ByVal value As Decimal)
            Entity.CantLibras = value
        End Set
    End Property

    Public Property MasDe30Meses() As Boolean
        Get
            Return Entity.MasDe30Meses
        End Get
        Set(ByVal value As Boolean)
            Entity.MasDe30Meses = value
        End Set
    End Property

    Public Property Farenheit() As Decimal
        Get
            Return Entity.Farenheit
        End Get
        Set(ByVal value As Decimal)
            Entity.Farenheit = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region
End Class

Public Class CortesDetalleClass
    Inherits ColleccionBase(Of EC.MscloteCortesDetEntity, CC.MscloteCortesDetCollection, CorteDetalleClass)

    Public Enum OperacionEnum
        AsignarEmbarque
        AjustarInventario
    End Enum

    Private LotedeCortes As EC.MscloteCortesDetEntity
    Private _Operacion As OperacionEnum

    Property IdFolioLoteCorte() As String
        Get
            Return LotedeCortes.LoteCorte
        End Get
        Set(ByVal value As String)
            LotedeCortes.LoteCorte = value
        End Set
    End Property

    Property CantKgrs() As Decimal
        Get
            Return LotedeCortes.CantKgrs
        End Get
        Set(ByVal value As Decimal)
            LotedeCortes.CantKgrs = value
        End Set
    End Property

    Property CantPzas() As Integer
        Get
            Return LotedeCortes.CantPzas
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.CantPzas = value
        End Set
    End Property

    Property CodigoBarra() As String
        Get
            Return LotedeCortes.CodigoBarra
        End Get
        Set(ByVal value As String)
            LotedeCortes.CodigoBarra = value
        End Set
    End Property

    Property IdCorte() As Integer
        Get
            Return LotedeCortes.IdCorte
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.IdCorte = value
        End Set
    End Property

    Property IdFolioEtiqueta() As String
        Get
            Return LotedeCortes.IdFolioEtiqueta
        End Get
        Set(ByVal value As String)
            LotedeCortes.IdFolioEtiqueta = value
        End Set
    End Property

    Property IdFolioEmbarque() As String
        Get
            Return LotedeCortes.IdFolioEmbarque
        End Get
        Set(ByVal value As String)
            LotedeCortes.IdFolioEmbarque = value
        End Set
    End Property

    Property IdFolioMovimiento() As String
        Get
            Return LotedeCortes.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            LotedeCortes.IdFolioMovimiento = value
        End Set
    End Property

    Property IdProducto() As Integer
        Get
            Return LotedeCortes.IdProducto
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.IdProducto = value
        End Set
    End Property

    Property Operacion() As OperacionEnum
        Get
            Return _Operacion
        End Get
        Set(ByVal value As OperacionEnum)
            _Operacion = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return LotedeCortes.IdCliente
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.IdCliente = value
        End Set
    End Property

    Property Grados() As Integer
        Get
            Return LotedeCortes.Grados
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.Grados = value
        End Set
    End Property

    Property FolioEtiquetaReferencia() As String
        Get
            Return LotedeCortes.IdFolioEtiquetaReferencia
        End Get
        Set(ByVal value As String)
            LotedeCortes.IdFolioEtiquetaReferencia = value
        End Set
    End Property

    Public Property Estatus() As Integer
        Get
            Return LotedeCortes.Estatus
        End Get
        Set(ByVal value As Integer)
            LotedeCortes.Estatus = value
        End Set
    End Property

    Public Function FormarCodigoBarra() As String
        Return String.Format("{0}{1}{2}{3}", Me.IdProducto.ToString("000"), _
                                                    Me.CantPzas.ToString("000"), _
                                                    Math.Truncate(Me.CantKgrs).ToString("0000") & _
                                                    Me.CantKgrs.ToString("N2").Substring(Me.CantKgrs.ToString("N2").Length - 2, _
                                                    2), Me.IdFolioEtiqueta)
    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Dim Coleccion As New CC.MscloteCortesDetCollection

        trans.Add(Coleccion)

        Select Case Operacion
            Case OperacionEnum.AsignarEmbarque
                Coleccion.GetMulti(HC.MscloteCortesDetFields.LoteCorte = Me.IdFolioLoteCorte And HC.MscloteCortesDetFields.IdFolioEtiqueta = Me.IdFolioEtiqueta)

                For Each Caja As EC.MscloteCortesDetEntity In Coleccion
                    Caja.IdFolioEmbarque = Me.IdFolioEmbarque
                Next
                Coleccion.SaveMulti()
            Case OperacionEnum.AjustarInventario
                Coleccion.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = Me.IdFolioEtiqueta)

                For Each Caja As EC.MscloteCortesDetEntity In Coleccion
                    Caja.Estatus = 3 'Ajuste de Inventario
                    Caja.IdFolioMovimientoAlmacenAjuste = IdFolioMovimiento
                Next
                Coleccion.SaveMulti()
            Case Else
                Return False
        End Select
        Return True
    End Function

    Public Overloads Function Obtener(ByVal LoteCorte As String) As DataSet
        Try
            Dim Query As String = "Select IdFolioEtiqueta" & _
                ",LoteCorte" & _
                ",IdCorte" & _
                ",(Select Descripcion From MSCCatProductos Where IdProducto=Lcd.IdCorte and PreCorte = 1) as Nom_Corte" & _
                ",IdProducto" & _
                ",CASE WHEN (select top 1 Descripcion From MSCRelacionCortesClientes where CodCorte = IdProducto and CodCliente = Lcd.IdCliente) is null" & _
                " THEN (Select Descripcion From MSCCatProductos Where IdProducto = Lcd.IdProducto and (Corte = 1 or SubProducto = 1))" & _
                " ELSE (select top 1 Descripcion From MSCRelacionCortesClientes where CodCorte = IdProducto and CodCliente = Lcd.IdCliente)" & _
                " End as Nom_SubCorte" & _
                ",CantPzas" & _
                ",CantKgrs" & _
                " From MSCLoteCortesDet Lcd" & _
                " Where Lcd.LoteCorte = '" & LoteCorte & "' and Lcd.Estatus = 1 and Lcd.IdFolioEmbarque = ''" & _
                " ORDER BY Lcd.IdFolioEtiqueta desc"

            Dim da As New SqlClient.SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

            Obtener = New DataSet
            da.Fill(Obtener)
        Catch ex As Exception
            Obtener = Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.MscloteCortesDetEntity
        Return LotedeCortes
    End Function

    Public Function Folios(ByVal LoteCorte As String, ByVal Consecutivo As Integer, ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Integer
        Try
            Folios = SPA.UspMscloteCortesDetFolios(LoteCorte, Consecutivo, trans)
            If Folios = 0 Then
                MsgBox("Error al guardar la información del detalle de lote de cortes", MsgBoxStyle.Critical, "Error")
                Folios = 0
            Else
                Folios = Consecutivo
            End If
        Catch ex As Exception
            Folios = 0
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Sub New()
        LotedeCortes = New EC.MscloteCortesDetEntity
        LotedeCortes.CantKgrs = 0
        LotedeCortes.CantPzas = 0
        LotedeCortes.CodigoBarra = ""
        LotedeCortes.Estatus = 1
        LotedeCortes.Grados = 4
        LotedeCortes.IdCliente = 0
        LotedeCortes.IdCorte = 0
        LotedeCortes.IdFolioEmbarque = ""
        LotedeCortes.IdFolioEtiqueta = ""
        LotedeCortes.IdFolioEtiquetaReferencia = ""
        LotedeCortes.IdFolioMovimiento = ""
        LotedeCortes.IdProducto = 0
        LotedeCortes.LoteCorte = ""
    End Sub

    Sub New(ByVal Entidad As EC.MscloteCortesDetEntity)
        LotedeCortes = Entidad
    End Sub

    Sub New(ByVal LoteCorte As String, ByVal FolioEtiqueta As String)
        LotedeCortes = New EC.MscloteCortesDetEntity(LoteCorte, FolioEtiqueta)
    End Sub

End Class

Public Class DetCanalAcorteClass
    Inherits ClassBase(Of EC.MscdetCanalAcorteEntity)

#Region "Propiedades"
    Public Property FolioLoteCorte() As String
        Get
            Return Entity.IdFolioLoteCorte
        End Get
        Set(ByVal value As String)
            Me.Entity.IdFolioLoteCorte = value
        End Set
    End Property

    Public Property FolioSacrificio() As String
        Get
            Return Entity.FolioSacrificio
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioSacrificio = value
        End Set
    End Property

    Public Property FolioCanal() As String
        Get
            Return Entity.IdFolioCanal
        End Get
        Set(ByVal value As String)
            Entity.IdFolioCanal = value
        End Set
    End Property

    Public Property Lado() As Short
        Get
            Return Entity.Lado
        End Get
        Set(ByVal value As Short)
            Entity.Lado = value
        End Set
    End Property

    Public Property KgrsEnCorte() As Decimal
        Get
            Return Entity.KgrsEnCorte
        End Get
        Set(ByVal value As Decimal)
            Entity.KgrsEnCorte = value
        End Set
    End Property

    Public Property Estatus() As Char
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As Char)
            Entity.Estatus = value
        End Set
    End Property

    Public Property IdFolioMovimientoAlmacen() As String
        Get
            Return Entity.IdFolioMovimientoAlmacen
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimientoAlmacen = value
        End Set
    End Property

    Public Property IdFolioMovimeintoAlmacenCancelacion() As String
        Get
            Return Entity.IdFolioMovimientoAlmacenCancelacion
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimientoAlmacenCancelacion = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.MscdetCanalAcorteEntity
    End Sub

    Sub New(ByVal Entidad As EC.MscdetCanalAcorteEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal FolioLote As String, ByVal FolioSacrificio As String, ByVal FolioCanal As String, ByVal idFolioMovimientoAlmacen As String)
        Entity = New EC.MscdetCanalAcorteEntity(FolioLote, FolioSacrificio, FolioCanal, idFolioMovimientoAlmacen)
    End Sub
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal FolioLoteCorte As String, ByVal FolioSacrificio As String, ByVal FolioCanal As String, ByVal idFolioMovimientoAlmacen As String) As Boolean
        Try
            Return Entity.FetchUsingPK(FolioLoteCorte, FolioSacrificio, FolioCanal, idFolioMovimientoAlmacen)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
'Agregado de la coleccion en 5 nov. 2008
Public Class DetCanalACorteColeccion
    Inherits ColleccionBase(Of EC.MscdetCanalAcorteEntity, CC.MscdetCanalAcorteCollection, DetCanalAcorteClass)

    Public Overloads Function Obtener(ByVal FolioLoteCorte As String) As Integer
        Try
            Me.Clear()
            Me.coleccion.GetMulti(HC.MscdetCanalAcorteFields.IdFolioLoteCorte = FolioLoteCorte)

            Me.Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
End Class