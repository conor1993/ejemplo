''Imports Ec = IntegraLab.ORM.EntityClasses
''Imports CC = IntegraLab.ORM.CollectionClasses
''Imports HC = IntegraLab.ORM.HelperClasses
''Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

''''' <summary>
''''' Clase para gurdar, borrar, modificar y obtener un lmite de credito
''''' </summary>
''''' <remarks></remarks>
''Public Class ClienteLimiteCreditoClass
''    Implements IEntidad


''    Private Entidad As Ec.ClienteLimiteCreditoLineaEntity
''    Private _Cliente As ClienteClass
''    Private _Linea As LineaClass
''    Private _TipoVenta As TipoVentaClass
''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''#Region "Propiedades"
''    <ComponentModel.DisplayName("Código")> _
''       Public ReadOnly Property Codigo() As Long
''        Get
''            Return Entidad.ClienteId
''        End Get
''    End Property

''    <ComponentModel.DisplayName("Limite de Credito")> _
''    Public Property LimiteCredito() As Decimal
''        Get
''            Return Entidad.LimiteCredito
''        End Get
''        Set(ByVal value As Decimal)
''            Entidad.LimiteCredito = value
''        End Set
''    End Property

''    <ComponentModel.DisplayName("Crédito Usado")> _
''    Public Property LimiteCreditoUsado() As Decimal
''        Get
''            Return Entidad.LimiteCreditoUsado
''        End Get
''        Set(ByVal value As Decimal)
''            Entidad.LimiteCreditoUsado = value
''        End Set
''    End Property

''    <ComponentModel.DisplayName("Crédito Disponible")> _
''    Public ReadOnly Property LimiteCreditoDisponible() As Decimal
''        Get
''            Dim Disponible As Decimal = LimiteCredito - LimiteCreditoUsado

''            If Disponible < 0 Then
''                Disponible = 0
''            End If

''            Return Disponible
''        End Get
''    End Property

''    <ComponentModel.DisplayName("Dias de Credito")> _
''    Public Property DiasCredito() As Integer
''        Get
''            Return Entidad.LimiteDiasCredito
''        End Get
''        Set(ByVal value As Integer)
''            Entidad.LimiteDiasCredito = value
''        End Set
''    End Property

''    <ComponentModel.DisplayName("Cliente")> _
''    Public Property Cliente() As ClienteClass
''        Get
''            If _Cliente Is Nothing Then
''                _Cliente = New ClienteClass
''                _Cliente.LeerEntidad(Entidad.Cliente_)
''            End If

''            Return _Cliente
''        End Get
''        Set(ByVal value As ClienteClass)
''            _Cliente = value
''            Entidad.Cliente = value.ObtenerEntidad(0)
''        End Set
''    End Property

''    <ComponentModel.DisplayName("Linea")> _
''    Public Property Linea() As LineaClass
''        Get
''            If _Linea Is Nothing Then
''                _Linea = New LineaClass
''                _Linea.LeerEntidad(Entidad.Linea_)
''            End If

''            Return _Linea
''        End Get
''        Set(ByVal value As LineaClass)
''            _Linea = value
''            Entidad.Linea_ = value.ObtenerEntidad
''        End Set
''    End Property

''    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get
''            Return Entidad.Estatus
''        End Get
''        Set(ByVal value As EstatusEnum)
''            Entidad.Estatus = value
''        End Set
''    End Property

''    Public Property TipoVenta() As TipoVentaClass
''        Get
''            If _TipoVenta Is Nothing Then
''                _TipoVenta = New TipoVentaClass(Entidad.TipoVenta)
''            End If

''            Return _TipoVenta
''        End Get
''        Set(ByVal value As TipoVentaClass)
''            If value Is Nothing Then
''                _TipoVenta = Nothing
''                Entidad.TipoVenta = Nothing
''            Else
''                _TipoVenta = value
''                Entidad.TipoVenta = value.ObtenerEntidad
''            End If
''        End Set
''    End Property

''    Public Property CodigoTipoVenta() As Integer
''        Get
''            Return Entidad.TipoVentaId
''        End Get
''        Set(ByVal value As Integer)
''            Entidad.TipoVentaId = value
''        End Set
''    End Property
''#End Region

''#Region "Metodos"
''    Public Function Borrar() As Boolean Implements IEntidad.Borrar
''        Try
''            Estatus = EstatusEnum.INACTIVO

''            Return Entidad.Save
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return False
''        End Try
''    End Function

''    Public Function Guardar() As Boolean
''        Try
''            If Entidad.IsNew Then
''                Estatus = EstatusEnum.ACTIVO
''            End If

''            If Entidad.Save Then
''                Return True
''            Else
''                MsgBox("No se logro guardar el limite de credito", MsgBoxStyle.Exclamation, "Aviso")
''                Return False
''            End If
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return False
''        End Try
''    End Function

''    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

''    End Function

''    ''' <summary>
''    ''' Obtiene un limite de credito por medio de su código
''    ''' </summary>
''    ''' <param name="Codigo">Código del limite de credito</param>
''    ''' <returns></returns>
''    ''' <remarks></remarks>
''    Public Function Obtener(ByVal Codigo As Long) As Boolean
''        Try
''            Return Entidad.FetchUsingPK(Codigo)
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return False
''        End Try
''    End Function

''    ''' <summary>
''    ''' Obtiene la entidad con todos sus valores y referencias
''    ''' </summary>
''    ''' <returns></returns>
''    ''' <remarks></remarks>
''    Public Function ObtenerEntidad() As Ec.ClienteLimiteCreditoLineaEntity
''        Return Entidad
''    End Function

''    ''' <summary>
''    ''' Lee la entidad con todo sus valores y referencias
''    ''' </summary>
''    ''' <param name="FcEntidad">Entidad que desea leer</param>
''    ''' <remarks></remarks>
''    Public Sub LeerEntidad(ByVal FcEntidad As Ec.ClienteLimiteCreditoLineaEntity)
''        Entidad = FcEntidad
''    End Sub
''#End Region

''#Region "Contructores"
''    Sub New()
''        Entidad = New Ec.ClienteLimiteCreditoLineaEntity
''    End Sub

''    Sub New(ByVal Codigo As Long)
''        Entidad = New Ec.ClienteLimiteCreditoLineaEntity(Codigo)
''    End Sub

''    Sub New(ByVal NewEntidad As Ec.ClienteLimiteCreditoLineaEntity)
''        Entidad = NewEntidad
''    End Sub
''#End Region

''    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class

''Public Class ClienteLimiteCreditoCollectionClass
''    Inherits CollectionClass(Of ClienteLimiteCreditoClass)

''    Private col As New CC.ClienteLimiteCreditoLineaCollection

''    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
''        Try

''            If FcCondicion = CondicionEnum.TODOS Then
''                col.GetMulti(Nothing)
''            Else
''                ''col.GetMulti(HC.ClienteLimiteCreditoLineaFields.Estatus = FcCondicion)
''            End If

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal Cliente As Integer, ByVal FcCondicion As CondicionEnum) As Integer
''        Try
''            If FcCondicion = CondicionEnum.TODOS Then
''                ''col.GetMulti(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente)
''            Else
''                ''col.GetMulti(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente And HC.ClienteLimiteCreditoLineaFields.Estatus = FcCondicion)
''            End If

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal Cliente As ClienteClass, ByVal FcCondicion As CondicionEnum) As Integer
''        Try
''            If FcCondicion = CondicionEnum.TODOS Then
''                ''col.GetMulti(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente.Codigo)
''            Else
''                ''col.GetMulti(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente And HC.ClienteLimiteCreditoLineaFields.Estatus = FcCondicion)
''            End If

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal Cliente As Integer, ByVal Linea As Integer, ByVal FcCondicion As CondicionEnum) As Integer
''        Try
''            Dim filtro As New OC.PredicateExpression

''            If Not FcCondicion = CondicionEnum.TODOS Then
''                ''   filtro.Add(HC.ClienteLimiteCreditoLineaFields.Estatus = FcCondicion)
''            End If

''            ''filtro.Add(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente)
''            ''filtro.Add(HC.ClienteLimiteCreditoLineaFields.ClienteId = Linea)

''            col.GetMulti(filtro)

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal Cliente As ClienteClass, ByVal Linea As LineaClass, ByVal FcCondicion As CondicionEnum) As Integer
''        Try
''            Dim filtro As New OC.PredicateExpression

''            If Not FcCondicion = CondicionEnum.TODOS Then
''                filtro.Add(HC.ClienteLimiteCreditoLineaFields.Estatus = FcCondicion)
''            End If

''            filtro.Add(HC.ClienteLimiteCreditoLineaFields.ClienteId = Cliente.Codigo)
''            filtro.Add(HC.ClienteLimiteCreditoLineaFields.LineaId = Linea.Codigo)

''            col.GetMulti(filtro)

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Public Function Obtener(ByVal CodigoCliente As Integer, ByVal CodigoTipoVenta As Integer, ByVal CodigoLinea As Integer) As Integer
''        Try
''            Dim filtro As New OC.PredicateExpression

''            filtro.Add(HC.ClienteLimiteCreditoLineaFields.LineaId = CodigoLinea)
''            filtro.Add(HC.ClienteLimiteCreditoLineaFields.ClienteId = CodigoCliente)
''            filtro.Add(HC.ClienteLimiteCreditoLineaFields.TipoVentaId = CodigoTipoVenta)

''            col.GetMulti(filtro)

''            Rellenar()

''            Return Count
''        Catch ex As Exception
''            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
''            Return -1
''        End Try
''    End Function

''    Private Sub Rellenar()
''        Clear()

''        For Each ente As Ec.ClienteLimiteCreditoLineaEntity In col
''            Add(New ClienteLimiteCreditoClass(ente))
''        Next
''    End Sub

''    Private Sub RellenarColeccion()
''        col.Clear()

''        For Each lim As ClienteLimiteCreditoClass In Me
''            col.Add(lim.ObtenerEntidad)
''        Next
''    End Sub

''    Public Sub RellenarMe(ByVal Coleccion As CC.ClienteLimiteCreditoLineaCollection)
''        col = Coleccion
''        Rellenar()
''    End Sub

''    Public Function ObtenerColeccion() As CC.ClienteLimiteCreditoLineaCollection
''        RellenarColeccion()
''        Return col
''    End Function

''End Class