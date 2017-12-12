Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses

''' <summary>
''' Clase que obtiene una coleccion de Detalles de las Lista de Precios
''' </summary>
''' <remarks></remarks>
Public Class ListaPrecioDetalleCollectionClass
    Inherits CollectionClass(Of ListaPrecioDetalleClass)

    Private WithEvents col As New CC.ListaPrecioDetalleCollection
    Private MeCol As ListaPrecioDetalleCollectionClass

    ''' <summary>
    ''' Obtiene una coleccion con todos los detalles con el estatus especificado
    ''' </summary>
    ''' <param name="fccondicion">Estatus con el que se filtrara la consulta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Clear()
            col = New CC.ListaPrecioDetalleCollection

            If fccondicion = CondicionEnum.TODOS Then
                col.GetMulti(Nothing)
            Else
                col.GetMulti(HC.ListaPrecioDetalleFields.Estatus = fccondicion)
            End If

            Rellenar()

            Return col.Count
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene una coleccion con todos los detalles con las caracteristicas establecidas
    ''' </summary>
    ''' <param name="CodigoListaPrecio">Código de la Lista de Precios</param>
    ''' <param name="CodigoProducto">Código del Producto</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal CodigoListaPrecio As Integer, ByVal CodigoProducto As Integer) As Integer
        Try
            Clear()

            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.ListaPrecioDetalleFields.ListaPrecios = CodigoListaPrecio)
            filtro.Add(HC.ListaPrecioDetalleFields.Producto = CodigoProducto)

            col = New CC.ListaPrecioDetalleCollection

            col.GetMulti(filtro)

            Rellenar()

            Return col.Count
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene una coleccion con todoslos detalles con las caracteristicas especificadas
    ''' </summary>
    ''' <param name="CodigoListaPrecio">Código de la Lista de Precio</param>
    ''' <param name="fccondicion">Estatus con el que filtrara la consulta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal CodigoListaPrecio As Integer, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS, Optional ByVal IncluirKits As Boolean = True) As Integer
        Try
            Clear()

            Dim relations As IRelationCollection = New RelationCollection()
            relations.Add(EC.ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto)


            Dim filtro As New OC.PredicateExpression
            If IncluirKits = False Then
                filtro.Add(HC.ProductoFields.PdEsKit = False)
            End If

            If Not fccondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.ListaPrecioDetalleFields.Estatus = fccondicion)
                filtro.Add(HC.ProductoFields.Estatus = fccondicion)
            End If

            filtro.Add(HC.ListaPrecioDetalleFields.ListaPrecios = CodigoListaPrecio)

            col = New CC.ListaPrecioDetalleCollection

            ''New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            'col.GetMultiAsDataTable(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), relations)
            col.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), relations)

            Rellenar()

            Return col.Count
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal NomProducto As String, Optional ByVal IncluirKits As Boolean = True) As Integer
        Try
            Clear()

            Dim relations As IRelationCollection = New RelationCollection()
            relations.Add(EC.ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto)


            Dim filtro As New OC.PredicateExpression
            If IncluirKits = False Then
                filtro.Add(HC.ProductoFields.PdEsKit = False)
            End If

            'If Not fccondicion = CondicionEnum.TODOS Then
            '    filtro.Add(HC.ListaPrecioDetalleFields.Estatus = fccondicion)
            '    filtro.Add(HC.ProductoFields.Estatus = fccondicion)
            'End If

            'filtro.Add(HC.ListaPrecioDetalleFields.ListaPrecios = CodigoListaPrecio)
            filtro.Add(HC.ProductoFields.Descripcion Mod ("%" & NomProducto.Trim() & "%"))
            col = New CC.ListaPrecioDetalleCollection

            ''New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            'col.GetMultiAsDataTable(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), relations)
            col.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), relations)

            Rellenar()

            Return col.Count
        Catch ex As Exception
            Return -1
        End Try
    End Function






    ''' <summary>
    ''' Rellena la coleccion con los datos de una coleccion ListaPrecioDetalleCollection
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Rellenar()
        Clear()
        If MeCol Is Nothing Then
            MeCol = New ListaPrecioDetalleCollectionClass
        Else
            MeCol.Clear()
        End If

        For Each ente As EC.ListaPrecioDetalleEntity In col
            Dim det As New ListaPrecioDetalleClass(ente)
            Add(det)
            MeCol.Add(det)
        Next
    End Sub

    Private Sub rellenarcoleccion()
        col = New CC.ListaPrecioDetalleCollection
        For Each Listadet As ListaPrecioDetalleClass In Me
            Dim milistad As New EC.ListaPrecioDetalleEntity
            milistad = Listadet.ObtenerEntidad
            col.Add(milistad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal NuevaColeccion As CC.ListaPrecioDetalleCollection)
        Me.Clear()
        For Each Listadetalle As EC.ListaPrecioDetalleEntity In NuevaColeccion
            Dim miListad As New ListaPrecioDetalleClass
            miListad.LeerEntidad(Listadetalle)
            Me.Add(miListad)
        Next
    End Sub

    ''' <summary>
    ''' Filtra el contenido que se mostrara segun sus especificaciones
    ''' </summary>
    ''' <param name="Linea">Establesca una LineaClass, si no desea filtrar por linea solo establesca nothing</param>
    ''' <param name="Marca">Establesca una Marca, si no desea filtrar por marca solo establesca nothing</param>
    ''' <remarks></remarks>
    Public Sub Filtrar(ByVal Linea As LineaClass, ByVal Marca As MarcaClass)


        If MeCol Is Nothing Then
            MeCol = New ListaPrecioDetalleCollectionClass
            For Each det As ListaPrecioDetalleClass In Me
                MeCol.Add(det)
            Next
        End If

        Clear()
        For Each det As ListaPrecioDetalleClass In MeCol
            If Not Linea Is Nothing Then
                If Not det.Linea.Codigo = Linea.Codigo Then
                    Continue For
                End If
            End If

            If Not Marca Is Nothing Then
                If Not Marca.Codigo = det.Marca.Codigo Then
                    Continue For
                End If
            End If

            Add(det)
        Next


    End Sub

    Public Sub Filtrar(ByVal NomProducto As String)

    End Sub

    ''' <summary>
    ''' Busca en la coleccion un detalle y se lo encuentra regresa True y si no False
    ''' </summary>
    ''' <param name="Detalle">Detalle que se desa buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Existe(ByVal Detalle As ListaPrecioDetalleClass) As Boolean
        For Each entc As ListaPrecioDetalleClass In Me
            If entc.Producto.Codigo = Detalle.Producto.Codigo Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Obtiene la coleccion ListaPrecioDetalleCollection que contiene los datos de la coleccion
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ObtenerColeccion() As CC.ListaPrecioDetalleCollection
        rellenarcoleccion()
        Return col
    End Function

End Class