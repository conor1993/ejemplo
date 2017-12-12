Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class AlmacenProduccionClass
    Implements IEntidad


    Dim Almacenes As EC.MscmovtosAlmacenCabEntity
    Dim _Func As String
    Dim _NumOpc As Integer

    Property IdFolioMovimiento() As String
        Get
            Return Almacenes.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Almacenes.IdFolioMovimiento = value
        End Set
    End Property
    Property IdCodAlmacen() As Integer
        Get
            Return Almacenes.IdCodAlmacen
        End Get
        Set(ByVal value As Integer)
            Almacenes.IdCodAlmacen = value
        End Set
    End Property
    Property FechaMovimiento() As Date
        Get
            Return Almacenes.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Almacenes.FechaMovimiento = value
        End Set
    End Property
    Property FechaCaptura() As Date
        Get
            Return Almacenes.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Almacenes.FechaCaptura = value
        End Set
    End Property
    Property IdCodMovimiento() As Integer
        Get
            Return Almacenes.IdCodMovimiento
        End Get
        Set(ByVal value As Integer)
            Almacenes.IdCodMovimiento = value
        End Set
    End Property
    Property CantPzas() As Integer
        Get
            Return Almacenes.CantPzas
        End Get
        Set(ByVal value As Integer)
            Almacenes.CantPzas = value
        End Set
    End Property
    Property CantKilos() As Decimal
        Get
            Return Almacenes.CantKilos
        End Get
        Set(ByVal value As Decimal)
            Almacenes.CantKilos = value
        End Set
    End Property

    Property Contabilizado() As String
        Get
            Return Almacenes.Contabilizado
        End Get
        Set(ByVal value As String)
            Almacenes.Contabilizado = value
        End Set
    End Property
    Property FechaContabilizacion() As Date
        Get
            Return Almacenes.FechaContabilizacion
        End Get
        Set(ByVal value As Date)
            Almacenes.FechaContabilizacion = value
        End Set
    End Property
    Property IdPoliza() As String
        Get
            Return Almacenes.IdPoliza
        End Get
        Set(ByVal value As String)
            Almacenes.IdPoliza = value
        End Set
    End Property

    Property QuienContabilizo() As String
        Get
            Return Almacenes.QuienContabilizo
        End Get
        Set(ByVal value As String)
            Almacenes.QuienContabilizo = value
        End Set
    End Property
    Property FechaCancelacion() As Date
        Get
            Return Almacenes.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Almacenes.FechaCancelacion = value
        End Set
    End Property
    Property QuienCancelo() As String
        Get
            Return Almacenes.QuienCancelo
        End Get
        Set(ByVal value As String)
            Almacenes.QuienCancelo = value
        End Set
    End Property
    Property ObservacionCancela() As String
        Get
            Return Almacenes.ObservacionCancela
        End Get
        Set(ByVal value As String)
            Almacenes.ObservacionCancela = value
        End Set
    End Property

    'propiedades para saber que accion realizara el procedimiento almacenado llamado
    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property
    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property


    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function


    Public Property Estatus() As String
        Get
            Return Almacenes.Estatus
        End Get
        Set(ByVal value As String)
            Almacenes.Estatus = value
        End Set
    End Property

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMscmovtosAlmacenCab(IdFolioMovimiento, IdCodAlmacen, FechaMovimiento, FechaCaptura, IdCodMovimiento, CantPzas, CantKilos, Estatus, Contabilizado, FechaContabilizacion, IdPoliza, QuienContabilizo, FechaCancelacion, QuienCancelo, ObservacionCancela, Func, NumOpc, trans) = 0 Then
                'RaiseEvent MensajeError(Me, "Error al guardar información en almacen")
                Return False
            End If

            Return True
        Catch ex As Exception
            'RaiseEvent MensajeError(Me, "Error al guardar información en almacen")
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Sub New()
        Almacenes = New EC.MscmovtosAlmacenCabEntity
        Almacenes.FechaCancelacion = New Date(1900, 1, 1)
        Almacenes.FechaContabilizacion = New Date(1900, 1, 1)
        Almacenes.Contabilizado = "N"
        Almacenes.IdPoliza = ""
        Almacenes.CantKilos = 0
        Almacenes.CantPzas = 0
        Almacenes.Estatus = "V"
        Almacenes.FechaCaptura = New Date(1900, 1, 1)
        Almacenes.FechaMovimiento = New Date(1900, 1, 1)
        Almacenes.IdCodMovimiento = 0
        Almacenes.IdCodAlmacen = 0
        Almacenes.ObservacionCancela = ""
        Almacenes.QuienCancelo = ""
        Almacenes.QuienContabilizo = ""
    End Sub

    Public Function Cancelar() As Boolean

    End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class AlmacenDetalleClass
    Implements IEntidad


    Dim AlmacenDetalle As EC.MscmovtosAlmacenDetEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Property IdFolioMovimiento() As String
        Get
            Return AlmacenDetalle.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            AlmacenDetalle.IdFolioMovimiento = value
        End Set
    End Property
    Property IdCodProducto() As Integer
        Get
            Return AlmacenDetalle.IdCodProducto
        End Get
        Set(ByVal value As Integer)
            AlmacenDetalle.IdCodProducto = value
        End Set
    End Property
    Property CantPzas() As Integer
        Get
            Return AlmacenDetalle.CantPzas
        End Get
        Set(ByVal value As Integer)
            AlmacenDetalle.CantPzas = value
        End Set
    End Property
    Property CantKilos() As Decimal
        Get
            Return AlmacenDetalle.CantKilos
        End Get
        Set(ByVal value As Decimal)
            AlmacenDetalle.CantKilos = value
        End Set
    End Property
    Property CostoUnitario() As Decimal
        Get
            Return AlmacenDetalle.CostoUnitario
        End Get
        Set(ByVal value As Decimal)
            AlmacenDetalle.CostoUnitario = value
        End Set
    End Property
    Property IVA() As Decimal
        Get
            Return AlmacenDetalle.Iva
        End Get
        Set(ByVal value As Decimal)
            AlmacenDetalle.Iva = value
        End Set
    End Property
    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property
    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMscmovtosAlmacenDet(IdFolioMovimiento, IdCodProducto, CantKilos, CantPzas, CostoUnitario, IVA, Func, NumOpc, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información del detalle de almacen")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Error al guardar información del detalle de almacen")
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    Sub New()
        AlmacenDetalle = New EC.MscmovtosAlmacenDetEntity
        AlmacenDetalle.CantKilos = 0
        AlmacenDetalle.CantPzas = 0
        AlmacenDetalle.CostoUnitario = 0
        AlmacenDetalle.IdCodProducto = 0
        AlmacenDetalle.Iva = 0
    End Sub

    Sub New(ByVal Entidad As EC.MscmovtosAlmacenDetEntity)
        AlmacenDetalle = Entidad
    End Sub

    Sub New(ByVal FolioMov As String, ByVal IdProducto As Integer)
        AlmacenDetalle = New EC.MscmovtosAlmacenDetEntity(FolioMov, IdProducto)
    End Sub

    Public Function Cancelar() As Boolean

    End Function

    Private Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Private Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class AlmacenCatalogoClass
    Implements IEntidad

#Region "Miembros"
    Dim Almacen As EC.AlmacenCatalogoEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Dim _IdCodAlmacen As Integer
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
#End Region
    
#Region "Constructores"
    Public Sub New()
        Almacen = New EC.AlmacenCatalogoEntity
        Almacen.Consecutivo = 0
        Almacen.CtaMay = ""
        Almacen.Descripcion = ""
        Almacen.DescripcionCorta = ""
        Almacen.Estatus = "V"
        Almacen.IdCliente = 0
        Almacen.IdCodTipoAlmacen = 0
        Almacen.LetraSerie = ""
        Almacen.Observaciones = ""
        Almacen.Propio = True
        Almacen.SsbCta = ""
        Almacen.SssCta = ""
        Almacen.SubCta = ""
    End Sub

    Sub New(ByVal Entidad As EC.AlmacenCatalogoEntity)
        Almacen = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Almacen = New EC.AlmacenCatalogoEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property IdCodAlmacen() As Integer
        Get
            Return Almacen.IdCodAlmacen
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return Almacen.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError(Me, "Ingrese descripción")
                Throw New System.SystemException(" ")
            End If
            Almacen.Descripcion = value
        End Set
    End Property

    Property DescripcionCorta() As String
        Get
            Return Almacen.DescripcionCorta
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError(Me, "Ingrese descripción corta")
                Throw New System.SystemException(" ")
            End If
            Almacen.DescripcionCorta = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Almacen.Observaciones
        End Get
        Set(ByVal value As String)
            Almacen.Observaciones = value
        End Set
    End Property

    Property IdCodTipoAlmacen() As Integer
        Get
            Return Almacen.IdCodTipoAlmacen
        End Get
        Set(ByVal value As Integer)
            Almacen.IdCodTipoAlmacen = value
        End Set
    End Property

    Property CtaMay() As String
        Get
            Return Almacen.CtaMay
        End Get
        Set(ByVal value As String)
            Almacen.CtaMay = value
        End Set
    End Property

    Property SubCta() As String
        Get
            Return Almacen.SubCta
        End Get
        Set(ByVal value As String)
            Almacen.SubCta = value
        End Set
    End Property

    Property SsbCta() As String
        Get
            Return Almacen.SsbCta
        End Get
        Set(ByVal value As String)
            Almacen.SsbCta = value
        End Set
    End Property

    Property SssCta() As String
        Get
            Return Almacen.SssCta
        End Get
        Set(ByVal value As String)
            Almacen.SssCta = value
        End Set
    End Property

    Property Propio() As Boolean
        Get
            Return Almacen.Propio
        End Get
        Set(ByVal value As Boolean)
            Almacen.Propio = value
        End Set
    End Property

    Property IdCliente() As Integer
        Get
            Return Almacen.IdCliente
        End Get
        Set(ByVal value As Integer)
            Almacen.IdCliente = value
        End Set
    End Property

    Property Consecutivo() As Decimal
        Get
            Return Almacen.Consecutivo
        End Get
        Set(ByVal value As Decimal)
            Almacen.Consecutivo = value
        End Set
    End Property

    Property LetraSerie() As String
        Get
            Return Almacen.LetraSerie
        End Get
        Set(ByVal value As String)
            Almacen.LetraSerie = value
        End Set
    End Property

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Property CodAlmacen() As Integer
        Get
            Return _IdCodAlmacen
        End Get
        Set(ByVal value As Integer)
            _IdCodAlmacen = value
        End Set
    End Property

    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Property Estatus() As String
        Get
            Return Almacen.Estatus
        End Get
        Set(ByVal value As String)
            Almacen.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMsccatAlmacenes(Descripcion, DescripcionCorta, CtaMay, SubCta, SsbCta, SssCta, Propio, IdCliente, IdCodTipoAlmacen.ToString, Consecutivo, LetraSerie, Estatus, Func, NumOpc, CodAlmacen, IdCodAlmacen, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de almacen")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(ex.Message, "Error al guardar información de almacen")
            Return False
        End Try

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspMsccatAlmacenes(Descripcion, DescripcionCorta, CtaMay, SubCta, SsbCta, SssCta, Propio, IdCliente, IdCodTipoAlmacen.ToString, Consecutivo, LetraSerie, Estatus, Func, NumOpc, CodAlmacen, IdCodAlmacen, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de almacen")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(ex.Message, "Error al guardar información de almacen")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            Return Almacen.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.AlmacenCatalogoEntity
        Return Almacen
    End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
#End Region

End Class

Public Class AlamacenCatalagoColletionClass
    Inherits CollectionClass(Of AlmacenCatalogoClass)

#Region "Miembros"
    Private coleccion As New CC.AlmacenCatalogoCollection
    Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler
#End Region

#Region "Consultas"
    Public Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing, 0, Nothing)
            rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function
#End Region

#Region "Codigo de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.AlmacenCatalogoEntity In coleccion
            Add(New AlmacenCatalogoClass(ente))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Collection As CC.AlmacenCatalogoCollection)
        coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As AlmacenCatalogoClass In Me
            coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.AlmacenCatalogoCollection
        RellenarColeccion()
        Return coleccion
    End Function
#End Region
End Class