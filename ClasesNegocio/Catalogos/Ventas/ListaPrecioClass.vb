Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

''' <summary>
''' Clase Para Guardar, Editar, Borrar y Obtener una Lista de precio
''' </summary>
''' <remarks></remarks>
Public Class ListaPrecioClass
    Implements IEntidad

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private listaPrecio As EC.ListaPrecioEntity
    Private _Plaza As PlazaClass
    Private _Detalles As ListaPrecioDetalleCollectionClass
    Private _ListaBase As ListaPrecioClass
    Private _TipoVenta As TipoVentaClass

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene y establece la plaza a la que pertenese la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>f
    <System.ComponentModel.DisplayName("Plaza"), ComponentModel.DataObjectField(False, False, False)> _
    Public Property Plaza() As PlazaClass
        Get
            If _Plaza Is Nothing Then
                _Plaza = New PlazaClass
                _Plaza.LeerEntidad(listaPrecio.Plaza_)
            End If

            Return _Plaza
        End Get
        Set(ByVal value As PlazaClass)
            listaPrecio.Plaza_ = value.ObtenerEntidad
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el código de la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Codigo Lista Precios"), ComponentModel.DataObjectField(True, True, False)> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return listaPrecio.Codigo
        End Get
    End Property

    ''' <summary>
    ''' Obtiene y establece la descripción de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Descripción"), ComponentModel.DataObjectField(False, False, False, 50)> _
    Public Property Descripcion() As String
        Get
            Return listaPrecio.Descripcion
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Descripción", "Debe ingresar una descripción")
                Throw New SystemException(" ")
            Else
                listaPrecio.Descripcion = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece la descripción corta de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Descripción Corta"), ComponentModel.DataObjectField(False, False, False, 15)> _
    Public Property DescripcionCorta() As String
        Get
            Return listaPrecio.DescripcionCorta
        End Get
        Set(ByVal value As String)
            listaPrecio.DescripcionCorta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece la fecha de alta de la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaAlta() As Date
        Get
            Return listaPrecio.Fecha
        End Get
        Set(ByVal value As Date)
            listaPrecio.Fecha = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la Fecha real en la que se capturo la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha Captura")> _
    Public Property FechaCaptura() As Date
        Get
            Return listaPrecio.FechaCaptura
        End Get
        Set(ByVal value As Date)
            listaPrecio.FechaCaptura = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece las observaciones de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Observaciones"), ComponentModel.DataObjectField(False, False, True, 200)> _
    Public Property Observaciones() As String
        Get
            Return listaPrecio.Observaciones
        End Get
        Set(ByVal value As String)
            listaPrecio.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece los dias de vigencia de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Dias de Vigencia")> _
    Public Property DiasVigencia() As Integer
        Get
            Return listaPrecio.DiasVigencia
        End Get
        Set(ByVal value As Integer)
            listaPrecio.DiasVigencia = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece la fecha de vigencia de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha Inicial de Vigencia")> _
    Public Property FechaVigencia() As Date
        Get
            Return listaPrecio.FechaVigenciaDe
        End Get
        Set(ByVal value As Date)
            listaPrecio.FechaVigenciaDe = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la fecha final de vigencia de la lista de precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha Final de Vigencia")> _
    Public Property FechaVigenciaA() As DateTime
        Get
            Return listaPrecio.FechaVigenciaA
        End Get
        Set(ByVal value As DateTime)
            listaPrecio.FechaVigenciaA = value
        End Set
    End Property

    ''' <summary> 
    ''' Obtiene y establece si es Lista Base la Lista de Precio 
    ''' </summary> 
    ''' <value></value> 
    ''' <returns></returns> 
    ''' <remarks></remarks> 
    <System.ComponentModel.DisplayName("Es Lista Base")> _
    Public Property EsListaBase() As EsBaseEnum
        Get
            Return listaPrecio.EsListaBase
        End Get
        Set(ByVal value As EsBaseEnum)
            listaPrecio.EsListaBase = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' 0btiene la fecha de cancelacion de la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Fecha de Cancelación")> _
    Public ReadOnly Property FechaCancela() As Date
        Get
            Return listaPrecio.FechaCancela
        End Get
    End Property

    ''' <summary>
    ''' Obtiene y establece las observaciones de cancelación  de la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Observaciones De Cancelacón")> _
    Public Property ObservacionesCancela() As String
        Get
            Return listaPrecio.ObservacionesCancela
        End Get
        Set(ByVal value As String)
            listaPrecio.ObservacionesCancela = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece el usuario que cancelo la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Usuario de Cancelación")> _
    Public Property UsuarioCancela() As Integer
        Get
            Return listaPrecio.UsuarioCancela
        End Get
        Set(ByVal value As Integer)
            listaPrecio.UsuarioCancela = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece los detalles de la Lista de Precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Detalles")> _
    Public Property Detalle As ListaPrecioDetalleCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New ListaPrecioDetalleCollectionClass
                If Not listaPrecio.IsNew Then

                    _Detalles.Obtener(Codigo, CondicionEnum.ACTIVOS)
                    '_Detalles.RellenarMe(listaPrecio.ListaPreciosDetalle)
                End If
            End If

            Return _Detalles
        End Get
        Set(ByVal value As ListaPrecioDetalleCollectionClass)
            _Detalles = value
        End Set
    End Property

    <ComponentModel.DisplayName("Detalles")> _
    Public Property DetalleSinKits As ListaPrecioDetalleCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New ListaPrecioDetalleCollectionClass
                If Not listaPrecio.IsNew Then

                    _Detalles.Obtener(Codigo, CondicionEnum.ACTIVOS, False)
                    '_Detalles.RellenarMe(listaPrecio.ListaPreciosDetalle)
                End If
            End If

            Return _Detalles
        End Get
        Set(ByVal value As ListaPrecioDetalleCollectionClass)
            _Detalles = value
        End Set
    End Property

    Public Property DetalleSinKits(ByVal nom As String) As ListaPrecioDetalleCollectionClass
        Get
            'If _Detalles Is Nothing Then
            _Detalles = New ListaPrecioDetalleCollectionClass
            If Not listaPrecio.IsNew Then

                _Detalles.Obtener(nom, False)
                '_Detalles.RellenarMe(listaPrecio.ListaPreciosDetalle)
            End If
            'End If

            Return _Detalles
        End Get
        Set(ByVal value As ListaPrecioDetalleCollectionClass)
            _Detalles = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece el estatus de la Lista de Precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return listaPrecio.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            listaPrecio.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene y establece la lista base de la lsita de precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ListaBase() As ListaPrecioClass
        Get
            If _ListaBase Is Nothing Then
                _ListaBase = New ListaPrecioClass
            End If
            _ListaBase.LeerEntidad(listaPrecio.ListaPrecioBase)
            Return _ListaBase
        End Get
        Set(ByVal value As ListaPrecioClass)
            listaPrecio.ListaBase = value.Codigo
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si caduca una lista de precios
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Caduca")> _
    Public Property Caduca() As AsignadaEnum
        Get
            Return listaPrecio.Vigencia
        End Get
        Set(ByVal value As AsignadaEnum)
            listaPrecio.Vigencia = value
        End Set
    End Property


    <ComponentModel.DisplayName("Actualizar")> _
    Public ReadOnly Property ActualizarLista() As Boolean
        Get
            listaPrecio.Refetch()

            Return True
        End Get

    End Property

    ''' <summary>
    ''' Obtiene o establece el tipo de venta de la lista de precio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Tipo de Venta")> _
    Public Property TipoVenta() As TipoVentaClass
        Get
            If _TipoVenta Is Nothing Then
                _TipoVenta = New TipoVentaClass(listaPrecio.TipoVenta)
            End If

            Return _TipoVenta
        End Get
        Set(ByVal value As TipoVentaClass)
            _TipoVenta = value
            listaPrecio.TipoVenta = value.ObtenerEntidad
        End Set
    End Property

#End Region

#Region "Metodos"

    ''' <summary>
    ''' Guarda y actualiza los datos de la Lista de Precios y su detalle
    ''' </summary>
    ''' <returns>True si se guardo y False si no se guardo</returns>
    ''' <remarks></remarks>
    Public Function Guardar() As Boolean Implements IEntidad.Guardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")
        Try
            If listaPrecio.IsNew Then
                Estatus = EstatusEnum.Activo
                Dim col As New CC.ListaPrecioCollection

                If col.GetDbCount(HC.ListaPrecioFields.Descripcion = Descripcion) > 0 Then
                    RaiseEvent MensajeError("Descripcion", "Ya existe una Lista de Precios con esa Descripcion")
                    Return False
                End If

                If col.GetDbCount(HC.ListaPrecioFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    RaiseEvent MensajeError("DescripcionCorta", "Ya existe una Lista de Precios con esa Descripcion Corta")
                    Return False
                End If

                'trans.Add(Me.listaPrecio)
                'If Me.listaPrecio.Save Then
                If Not SPA.ListaPrecioIns(Plaza.Codigo, Me.Descripcion, Me.DescripcionCorta, Me.Observaciones, Me.Caduca, _
                        Me.DiasVigencia, Me.FechaVigencia, Me.FechaVigenciaA, Me.EsListaBase, Estatus, 0, _
                            Me.ListaBase.Codigo, 1, Me.listaPrecio.Codigo, trans) = 0 Then
                    ' Pendiente programar tipos de venta (Me.TipoVenta.Codigo)

                    Dim det As CC.ListaPrecioDetalleCollection
                    'If EsListaBase Then
                    '    trans.Add(listaPrecio)
                    '    ListaBase = Me
                    '    listaPrecio.IsNew = False
                    '    If Not listaPrecio.Save Then
                    '        trans.Rollback()
                    '        RaiseEvent MensajeError(Me, "No se logro guardar, intente nuevamente")
                    '        Return False
                    '    End If
                    'End If
                    det = Detalle.ObtenerColeccion
                    trans.Add(det)

                    For Each detlis As EC.ListaPrecioDetalleEntity In det
                        detlis.ListaPrecios = Codigo
                    Next

                    If det.SaveMulti > 0 Then
                        trans.Commit()
                        Return True
                    Else
                        trans.Rollback()
                        MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    End If
                Else
                    trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                Dim col As New CC.ListaPrecioCollection
                If col.GetDbCount(Not HC.ListaPrecioFields.Codigo = Codigo And HC.ListaPrecioFields.Descripcion = Descripcion) > 0 Then
                    RaiseEvent MensajeError("Descripcion", "Ya existe una Lista de Precios con esa Descripcion")
                    Return False
                End If
                If col.GetDbCount(Not HC.ListaPrecioFields.Codigo = Codigo And HC.ListaPrecioFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    RaiseEvent MensajeError("DescripcionCorta", "Ya existe una Lista de Precios con esa Descripcion Corta")
                    Return False
                End If
                trans.Add(Me.listaPrecio)
                If Me.listaPrecio.Save Then
                    Dim det As CC.ListaPrecioDetalleCollection
                    det = Detalle.ObtenerColeccion
                    Dim col2 As New CC.ListaPrecioDetalleCollection
                    Dim Encontro As Boolean = False
                    col2.GetMulti(HC.ListaPrecioDetalleFields.ListaPrecios = Codigo)
                    For Each ente As EC.ListaPrecioDetalleEntity In col2
                        Encontro = False
                        For Each ent As EC.ListaPrecioDetalleEntity In det
                            If ent.ListaPrecios = ente.ListaPrecios And ente.Producto = ent.Producto Then
                                If Not ent.IsDirty Then
                                    det.Remove(ent)
                                End If
                                Encontro = True
                                Exit For
                            End If
                        Next

                        If Not Encontro Then
                            trans.Add(ente)
                            If Not ente.Delete Then
                                trans.Rollback()
                                MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                                Return False
                            End If
                        End If
                    Next

                    trans.Add(det)

                    If det.Count > 0 Then
                        If det.SaveMulti > 0 Then
                            trans.Commit()
                            Return True
                        Else
                            trans.Rollback()
                            MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If
                    Else
                        trans.Commit()
                        Return True
                    End If
                Else
                    trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Actualiza los datos de la Lista de Precios
    ''' </summary>
    ''' <returns>True si se actualizó y False si no se actualizó</returns>
    ''' <remarks></remarks>
    Public Function Actualizar(ByVal trans As HC.Transaction) As Boolean
        Try
            If listaPrecio.IsNew Then Return False

            Estatus = EstatusEnum.ACTIVO
            'Dim col As New CC.ListaPrecioCollection

            'If col.GetDbCount(HC.ListaPrecioFields.Descripcion = Descripcion) > 0 Then
            '    RaiseEvent MensajeError("Descripcion", "Ya existe una Lista de Precios con esa Descripcion")
            '    Return False
            'End If

            'If col.GetDbCount(HC.ListaPrecioFields.DescripcionCorta = DescripcionCorta) > 0 Then
            '    RaiseEvent MensajeError("DescripcionCorta", "Ya existe una Lista de Precios con esa Descripcion Corta")
            '    Return False
            'End If

            trans.Add(Me.listaPrecio)
            If Me.listaPrecio.Save Then
                Return True
            Else
                RaiseEvent MensajeError("Error", "No se pudo actualiza la lista de precios")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Da de baja una Lista de Precios
    ''' </summary>
    ''' <returns>True si se dio de baja y False si no se dio de baja</returns>
    ''' <remarks></remarks>
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            listaPrecio.Estatus = EstatusEnum.Inactivo
            If listaPrecio.Save() Then Return True
            RaiseEvent MensajeError(Me, "La Lista de Precios no pudo ser eliminada")
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Cancela la Lista de Precios
    ''' </summary>
    ''' <returns>True si se guardo y False si no se guardo</returns>
    ''' <remarks></remarks>
    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar
    End Function

    ''' <summary>
    ''' Obtiene una Lista de Precio a partir de su Código
    ''' </summary>
    ''' <param name="Codigo">Código de la Lista de Precio que quiere obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If listaPrecio.FetchUsingPK(Codigo) Then
                Return True
                RaiseEvent MensajeError(Me, "La Lista de Precios especificada no existe.")
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Obtiene la Lista de Precios vigente para la plaza indicada
    ''' </summary>
    ''' <param name="CodPlaza">Código de la plaza de la lista de precios vigente que se quiere obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerVigente(ByVal CodPlaza As Integer, Optional ByVal mensaje As Boolean = True) As Boolean
        Dim ListasPrecio As New CC.ListaPrecioCollection
        Dim Filtro As New OC.PredicateExpression(HC.ListaPrecioFields.Plaza = CodPlaza)
        Filtro.AddWithAnd(HC.ListaPrecioFields.FechaVigenciaDe <= System.DateTime.Today)
        Filtro.AddWithAnd(HC.ListaPrecioFields.FechaVigenciaA >= System.DateTime.Today)
        Filtro.AddWithAnd(HC.ListaPrecioFields.Estatus = EstatusEnum.ACTIVO)

        Try
            ListasPrecio.GetMulti(Filtro)
            If mensaje Then
                If ListasPrecio.Count = 0 Then
                    Throw New Exception("No hay una lista de precios vigente para la plaza.")
                ElseIf ListasPrecio.Count > 1 Then
                    Throw New Exception("Hay más de una lista de precios vigente para la plaza.")
                End If
                listaPrecio = ListasPrecio.Items(0)
            Else
                Return False
            End If

           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Obtiene la Lista de Precios vigente para la plaza indicada
    ''' </summary>
    ''' <param name="CodPlaza">Código de la plaza de la lista de precios vigente que se quiere obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerDetalle(ByVal CodBarras As String) As ListaPrecioDetalleClass
        For Each det As ListaPrecioDetalleClass In Me.Detalle
            If det.Producto.CodigoBarra = CodBarras Then
                Return det
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Obtiene la Lista de Precios vigente para la plaza indicada
    ''' </summary>
    ''' <param name="CodPlaza">Código de la plaza de la lista de precios vigente que se quiere obtener</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerDetalle(ByVal Codigo As Integer) As ListaPrecioDetalleClass
        For Each det As ListaPrecioDetalleClass In Me.Detalle
            If det.Producto.Codigo = Codigo Then
                Return det
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Lee una ListaPrecioEntity y obtiene sus valores
    ''' </summary>
    ''' <param name="Entidad">Entidad que se desea leer </param>
    ''' <paramref name="Entidad">Topo: IntegraLab.ORM.EntityClasses.ListaPrecioEntity</paramref>
    ''' <remarks></remarks>
    Public Sub LeerEntidad(ByVal Entidad As Object())
        Me.listaPrecio = Entidad(0)
    End Sub

    Public Sub LeerEntidad(ByVal Entidad As EC.ListaPrecioEntity)
        Me.listaPrecio = Entidad
    End Sub

    Public Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    ''' <summary>
    ''' Obtiene la Entidad que contiene todos los datos de la Lista de Precios
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerEntidad() As EC.ListaPrecioEntity
        Return Me.listaPrecio
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    ''' <summary>
    ''' Obtiene una lista con todos los codigos de los productos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AgregarProductosNuevos() As Integer
        Try
            Dim list As New List(Of Integer)

            Dim com As New SqlClient.SqlCommand("ConsultarProductosNuevosLP", New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString))
            com.Parameters.Add("@ListaPrecio", SqlDbType.Int).Value = Me.Codigo
            com.CommandType = CommandType.StoredProcedure
            Dim dr As SqlClient.SqlDataReader
            com.Connection.Open()
            dr = com.ExecuteReader

            While dr.Read
                list.Add(dr(0))
            End While

            For Each valor As Integer In list
                Dim prod As New ProductoGeneralClass(valor)
                Dim det As New ListaPrecioDetalleClass

                det.Producto = prod
                det.ListaPrecio = Me

                '=================Obtener el costo del producto===========================

                Dim inv As New Integralab.ORM.CollectionClasses.InventarioAlmacenCollection

                inv.GetMulti(HC.InventarioAlmacenFields.ProductoId = valor, 1, New OC.SortExpression(New OC.SortClause(HC.InventarioAlmacenFields.FechaUltimoCosto, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

                If inv.Count > 0 Then det.Costo = inv(0).UltimoCosto Else det.Costo = 0D

                det.ComicionC = 0D
                det.ComisionP = 0D
                det.PrecioVentaC = det.Costo
                det.PrecioVentaP = 0D
                det.Utilidad = 0D
                det.Estatus = EstatusEnum.ACTIVO

                Detalle.Add(det)
            Next

            Return list.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#End Region

#Region "Constructores"
    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicialización de todas la variables...
        listaPrecio = New EC.ListaPrecioEntity
        listaPrecio.Plaza = 0
        listaPrecio.Estatus = 0
        listaPrecio.Descripcion = ""
        listaPrecio.DescripcionCorta = ""
        listaPrecio.Fecha = New Date(1900, 1, 1)
        listaPrecio.FechaCaptura = New Date(1900, 1, 1)
        listaPrecio.Observaciones = ""
        listaPrecio.DiasVigencia = 0
        listaPrecio.FechaVigenciaDe = New Date(1900, 1, 1)
        listaPrecio.ListaBase = 0
        listaPrecio.FechaCancela = New Date(1900, 1, 1)
        listaPrecio.ObservacionesCancela = ""
        listaPrecio.UsuarioCancela = 0
        'listaPrecio.lpmotivoCancelacion = ""
    End Sub

    Sub New(ByVal Codigo As Integer)
        listaPrecio = New EC.ListaPrecioEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.ListaPrecioEntity)
        listaPrecio = Entidad
    End Sub
#End Region

End Class