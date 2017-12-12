Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class TipoVentaClass
    Implements IEntidad


    Private TipoVenta As EC.TipoVentaEntity
    'Private _ListasPrecios As ListaPrecioCollectionClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene el código del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return TipoVenta.Codigo
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la descripción del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return TipoVenta.Descripcion
        End Get
        Set(ByVal value As String)
            TipoVenta.Descripcion = value
        End Set
    End Property

    ''' <summary>
    ''' Optiene o establece la descripción corta del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return TipoVenta.DescripcionCorta
        End Get
        Set(ByVal value As String)
            TipoVenta.DescripcionCorta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return TipoVenta.Observaciones
        End Get
        Set(ByVal value As String)
            TipoVenta.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la fecha de alta del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public ReadOnly Property FechaAlta() As Date
        Get
            Return TipoVenta.FechaAlta
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el estatus del tipo de venta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return TipoVenta.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            TipoVenta.Estatus = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si es a credito
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Es Credito")> _
    Public Property EsCredito() As AsignadaEnum
        Get
            Return TipoVenta.EsCredito
        End Get
        Set(ByVal value As AsignadaEnum)
            TipoVenta.EsCredito = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si el tipo de venta es crédito normal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Crédito Normal")> _
    Public Property EsCreditoNormal() As AsignadaEnum
        Get
            Return TipoVenta.EsCreditoNormal
        End Get
        Set(ByVal value As AsignadaEnum)
            TipoVenta.EsCreditoNormal = value
        End Set
    End Property

    ''''' <summary>
    ''''' Obtiene las listas de precios asociadas a este tipo de venta
    ''''' </summary>
    ''''' <value></value>
    ''''' <returns></returns>
    ''''' <remarks></remarks>
    ''<ComponentModel.DisplayName("Listas de Precios")> _
    ''Public ReadOnly Property ListasPrecios() As ListaPrecioCollectionClass
    ''    Get
    ''        If _ListasPrecios Is Nothing Then
    ''            _ListasPrecios = New ListaPrecioCollectionClass(TipoVenta.ListaPrecio)
    ''        End If

    ''        Return _ListasPrecios
    ''    End Get
    ''End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Da de baja el tipo de venta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Estatus = EstatusEnum.INACTIVO
            Return TipoVenta.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Guarda el tipo de venta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar() As Boolean
        Try
            Dim col As New CC.TipoVentaCollection

            If TipoVenta.IsNew Then
                If col.GetDbCount(HC.TipoVentaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de venta con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.TipoVentaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un tipo de venta con esa descripcón corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return TipoVenta.Save
            Else
                If col.GetDbCount(Not HC.TipoVentaFields.Codigo = Codigo And HC.TipoVentaFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de venta con esa descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.TipoVentaFields.Codigo = Codigo And HC.TipoVentaFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un tipo de venta con esa descripcón corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                Return TipoVenta.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Obtiene un tipo de venta
    ''' </summary>
    ''' <param name="Codigo">Código del tipo de venta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            Return TipoVenta.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.TipoVentaEntity
        Return TipoVenta
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.TipoVentaEntity)
        TipoVenta = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
#End Region

#Region "Constructores"
    Sub New()
        TipoVenta = New EC.TipoVentaEntity
        TipoVenta.UsuarioAlta = 0
    End Sub

    Sub New(ByVal Codigo As Integer)
        TipoVenta = New EC.TipoVentaEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.TipoVentaEntity)
        TipoVenta = Entidad
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class TipoVentaCollectionClass
    Inherits CollectionClass(Of TipoVentaClass)

    Private Coleccion As New CC.TipoVentaCollection

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Col As CC.TipoVentaCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.TipoVentaFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal EsCredito As AsignadaEnum) As Integer
        Try
            Coleccion.GetMulti(HC.TipoVentaFields.EsCredito = EsCredito)
            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String, ByVal DescripcionCorta As String, ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.TipoVentaFields.Estatus = FcCondicion)
            End If

            Filtro.Add(HC.TipoVentaFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Filtro.Add(HC.TipoVentaFields.DescripcionCorta Mod String.Format("%{0}%", DescripcionCorta))

            Coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.TipoVentaEntity In Coleccion
            Add(New TipoVentaClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each tipo As TipoVentaClass In Me
            Coleccion.Add(tipo.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.TipoVentaCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function ObtenerColeccion() As CC.TipoVentaCollection
        RellenarColeccion()
        Return Coleccion
    End Function

End Class