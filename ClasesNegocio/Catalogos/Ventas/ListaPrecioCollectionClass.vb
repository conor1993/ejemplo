Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

''' <summary>
''' Clase para realizar consultas y obtener una coleccion con todos los datos que se obtuvieron de la consulta
''' </summary>
''' <remarks></remarks>
Public Class ListaPrecioCollectionClass
    Inherits CollectionClass(Of ListaPrecioClass)

    Private ListaPrecioCollection As New IntegraLab.ORM.CollectionClasses.ListaPrecioCollection
    Private Col As New IntegraLab.ORM.CollectionClasses.ListaPrecioCollection
    Public Event MensajeError As MensajeErrorHandler
    Private TipoLista As TipoListaPrecioEnum
    Dim Orden As New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

    ''' <summary>
    ''' Obtiene y establece el tipo de Lista de Precios que desea mostrar
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Mostrar() As TipoListaPrecioEnum
        Get
            Return TipoLista
        End Get
        Set(ByVal value As TipoListaPrecioEnum)
            TipoLista = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene una coleccion de Listas de Precios con las caracteristicas establecidas
    ''' </summary>
    ''' <param name="fcCondicion">Condicion en la que se establece el que estatus quieren que tengas las Listas de Precios que se obtendran de la consulta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(Optional ByVal fcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.Todos Then
                filtro.Add(HC.ListaPrecioFields.Estatus = fcCondicion)
            End If

            If Not Mostrar = TipoListaPrecioEnum.Todas Then
                filtro.Add(HC.ListaPrecioFields.EsListaBase = Mostrar)
            End If

            Col = New CC.ListaPrecioCollection
            Col.GetMulti(filtro)

            Rellenar()

            Return Col.Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal ListaPrecios As ListaPrecioClass) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.ListaPrecioFields.Descripcion = ListaPrecios.Descripcion)
            Filtro.AddWithOr(HC.ListaPrecioFields.DescripcionCorta = ListaPrecios.DescripcionCorta)
            Col = New CC.ListaPrecioCollection
            Col.GetMulti(filtro)
            Rellenar()
            Return Col.Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene las lista de precios que pertenescan a la plaza especificada
    ''' </summary>
    ''' <param name="Plaza">Plaza de la lista de precio</param>
    ''' <param name="FcCondicion">Estatus de la lista de precio</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Plaza As PlazaClass, ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.ListaPrecioFields.Estatus = FcCondicion)
            End If

            Filtro.Add(HC.ListaPrecioFields.Plaza = Plaza.Codigo)

            Col.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene una coleccion de Listas de Precios con las caracteristicas establecidas
    ''' </summary>
    ''' <param name="Descripcion">Descripción que quiere que tengan las Listas de Precios obtenidas de la consulta</param>
    ''' <param name="DescripcionCorta">Descripción Corta que quiere que tengan las Listas de Precios obtenidas de la consulta</param>
    ''' <param name="FcCondicion">Condicion en la que se establece el que estatus quieren que tengas las Listas de Precios que se obtendran de la consulta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Descripcion As String, ByVal DescripcionCorta As String, Optional ByVal plaza As Integer = 1, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression

            If Not fccondicion = CondicionEnum.Todos Then
                Filtro.Add(HC.ListaPrecioFields.Estatus = fccondicion)
            End If

            If Not plaza = -1 Then
                Filtro.Add(HC.ListaPrecioFields.Plaza = plaza)
            End If

            If Not Codigo = -1 Then
                Filtro.Add(HC.ListaPrecioFields.Codigo = Codigo)
            End If

            Filtro.Add(HC.ListaPrecioFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Filtro.Add(HC.ListaPrecioFields.DescripcionCorta Mod String.Format("%{0}%", DescripcionCorta))

            ListaPrecioCollection.GetMulti(Filtro)

            For Each listaprecioEntity As EC.ListaPrecioEntity In ListaPrecioCollection
                Dim Milistaprecio As New ListaPrecioClass
                Milistaprecio.LeerEntidad(listaprecioEntity)
                Me.Add(Milistaprecio)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try

    End Function

    Public Function Guardar() As Integer
        Col = New CC.ListaPrecioCollection
        For Each ListaPrecios As ListaPrecioClass In Me
            Dim ListaPreciosEntity As New EC.ListaPrecioEntity
            ListaPreciosEntity = ListaPrecios.ObtenerEntidad()
            Col.Add(ListaPreciosEntity)
        Next
        Try
            Dim Conteo As Integer = Col.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        Col = New CC.ListaPrecioCollection
        For Each ListaPrecios As ListaPrecioClass In Me
            Dim ListaPreciosEntity As New EC.ListaPrecioEntity
            ListaPreciosEntity = ListaPrecios.ObtenerEntidad()
            Col.Add(ListaPreciosEntity)
        Next
        Try
            Dim Conteo As Integer = Col.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    'Public Function Rpt() As CRepLListPrec
    '    Dim Reportes As New CRepLListPrec
    '    Dim ds As New DataSet
    '    Dim dtLisP As New DSetListaPrecio.DtListaPrecioDataTable
    '    Dim dtLispd As New DSetListaPrecio.DtListaPrecDetalleDataTable
    '    For Each lis As ListaPrecioClass In Me
    '        dtLisP.AddDtListaPrecioRow(lis.Codigo, lis.Descripcion, lis.EsListaBase.ToString, lis.DiasVigencia, lis.FechaAlta.ToString("d"), lis.Estatus.ToString, lis.FechaVigencia.ToString("d"), lis.TipoVenta.Descripcion)
    '    Next
    '    ds.Tables.Add(dtLisP)
    '    ds.Tables.Add(dtLispd)
    '    Reportes.SetDataSource(ds)
    '    Return Reportes
    'End Function

    ''' <summary>
    ''' Rellena la coleccion con los datos de la ListaPrecioCollection
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Rellenar()
        Clear()
        For Each entity As EC.ListaPrecioEntity In Col
            Add(New ListaPrecioClass(entity))
        Next
    End Sub

    ''' <summary>
    ''' Obtiene la Coleccion que contiene los datos de la consulta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerColeccion() As CC.ListaPrecioCollection
        Return Col
    End Function

    ''' <summary>
    ''' Rellena la coleccion con los datos de la Coleccion ListaPrecioCollection establecida
    ''' </summary>
    ''' <param name="Coleccion">ListaPrecioCollection que contiene los datos con los que llenara la coleccion</param>
    ''' <remarks></remarks>
    Public Sub RellenarMe(ByVal Coleccion As CC.ListaPrecioCollection)
        Col = Coleccion
        rellenar()
    End Sub

    Public Function Reporte() As CRepListaPrecio
        Dim Rep As New CRepListaPrecio
        Dim ds As New DataSet
        Dim dtLis As New DSetListaPrecio.DtListaPrecioDataTable
        Dim dtLisd As New DSetListaPrecio.DtListaPrecDetalleDataTable

        For Each lis As ListaPrecioClass In Me
            Dim lisp As DSetListaPrecio.DtListaPrecioRow = dtLis.AddDtListaPrecioRow(lis.Codigo, lis.Descripcion, lis.EsListaBase.ToString, lis.DiasVigencia, lis.FechaAlta.ToString("d"), lis.Estatus.ToString, lis.FechaVigencia.ToString("d"), lis.TipoVenta.Descripcion)

            For Each DetLista As ListaPrecioDetalleClass In lis.Detalle
                dtLisd.AddDtListaPrecDetalleRow(DetLista.Producto.Descripcion, DetLista.Utilidad, DetLista.PrecioVentaC.ToString("C"), DetLista.ComicionC.ToString("C2"), lisp)
            Next
        Next

        ds.Tables.Add(dtLis)
        ds.Tables.Add(dtLisd)

        Rep.SetDataSource(ds)

        Return Rep
    End Function

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Col As CC.ListaPrecioCollection)
        ListaPrecioCollection = Col
        Rellenar()
    End Sub

End Class
