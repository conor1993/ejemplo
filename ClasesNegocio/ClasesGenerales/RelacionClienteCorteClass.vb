Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports PA = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class RelacionClienteCorteClass
    Inherits ClassBase(Of EC.MscrelacionCortesClientesEntity)

#Region "Miembros"
    Private _Productos As ProductosClass
    Private _Cliente As ClientesIntroductoresClass
    Private _Destino As PuntosEntregaClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.MscrelacionCortesClientesEntity
    End Sub

    Sub New(ByVal Entidad As EC.MscrelacionCortesClientesEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal CodCliente As Integer, ByVal CodCorte As Integer, ByVal idDestino As Integer)
        Entity = New EC.MscrelacionCortesClientesEntity(idDestino, CodCliente, CodCorte)
    End Sub
#End Region

#Region "Propiedades"

    Public Property CodCliente() As Integer
        Get
            Return Entity.CodCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CodCliente = value
        End Set
    End Property

    Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Entity.CodCliente)
            End If
            Return _Cliente
        End Get
        Set(ByVal value As ClientesIntroductoresClass)
            _Cliente = value
        End Set
    End Property

    ReadOnly Property NomCliente() As String
        Get
            Return Cliente.Nombre
        End Get
    End Property

    Public Property CodCorte() As Integer
        Get
            Return Entity.CodCorte
        End Get
        Set(ByVal value As Integer)
            Entity.CodCorte = value
        End Set
    End Property

    Public Property CodCorteCliente() As String
        Get
            Return Entity.CodCorteCliente
        End Get
        Set(ByVal value As String)
            Entity.CodCorteCliente = value
        End Set
    End Property

    Public Property DescripcionClie() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public ReadOnly Property Descripcion() As String
        Get
            If _Productos Is Nothing Then
                _Productos = New ProductosClass(Entity.MsccatProductos)
            ElseIf Not _Productos.IdProducto = CodCorte Then
                _Productos.Entidad = Entity.MsccatProductos
            End If

            Return _Productos.Descripcion
        End Get
    End Property

    Public Property IdDestino() As Integer
        Get
            Return Entity.IdDestino
        End Get
        Set(ByVal value As Integer)
            Entity.IdDestino = value
        End Set
    End Property

    Public Property Destino() As PuntosEntregaClass
        Get
            If Me._Destino Is Nothing Then
                _Destino = New PuntosEntregaClass(Entity.MgralcatPuntosEntrega)
            ElseIf Not _Destino.Codigo = IdDestino Then
                _Destino.Entidad = Entity.MgralcatPuntosEntrega
            End If

            Return _Destino
        End Get
        Set(ByVal value As PuntosEntregaClass)
            _Destino = value

            If value Is Nothing Then
                Entity.MgralcatPuntosEntrega = Nothing
            Else
                Entity.MgralcatPuntosEntrega = value.Entidad
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overloads Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Entity)

            If Entity.IsNew Then
                If Not Entity.Descripcion = "" AndAlso Not Entity.CodCorteCliente.Trim = "" Then
                    Entity.Save()
                End If
            Else
                If Entity.Descripcion = "" OrElse Entity.CodCorteCliente.Trim = "" Then
                    Entity.Delete()
                Else
                    Entity.Save()
                End If
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal CodCliente As Integer, ByVal CodCorte As Integer, ByVal idDestino As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(idDestino, CodCliente, CodCorte)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerCortes(ByVal Opcion As Integer, ByVal CodCliente As Integer) As DataSet
        Try
            ObtenerCortes = PA.UspConMsccortes(Opcion, CodCliente)

        Catch ex As Exception
            ObtenerCortes = Nothing
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

End Class

Public Class RelacionClienteCorteCollection
    Inherits ColleccionBase(Of EC.MscrelacionCortesClientesEntity, CC.MscrelacionCortesClientesCollection, RelacionClienteCorteClass)

    Private Sub RellenarProductosFaltantes(ByVal listaIdProductos As List(Of Integer), ByVal idDestino As Integer, ByVal idCliente As Integer)
        Try
            Dim campos As New HC.ResultsetFields(1)
            Dim filtro As New OC.PredicateExpression
            Dim typeList As New Integralab.ORM.DaoClasses.TypedListDAO
            Dim resultado As New DataTable

            campos.DefineField(HC.MsccatProductosFields.IdProducto, 0)

            If listaIdProductos Is Nothing OrElse listaIdProductos.Count = 0 Then
                filtro.Add(HC.MsccatProductosFields.Estatus = 1)
            Else
                filtro.Add(HC.MsccatProductosFields.Estatus = 1 And New OC.FieldCompareRangePredicate(HC.MsccatProductosFields.IdProducto, True, listaIdProductos.ToArray))
            End If

            typeList.GetMultiAsDataTable(campos, resultado, 0, Nothing, filtro, Nothing, False, Nothing, Nothing, 0, 0)

            For Each row As DataRow In resultado.Rows
                Dim relacion As New RelacionClienteCorteClass

                relacion.CodCorte = row(0)
                relacion.IdDestino = idDestino
                relacion.CodCliente = idCliente
                Me.Add(relacion)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function Reporte(ByVal Empresas As String, ByVal Usuario As String) As RptRelacionClienteCorte
        Try
            Dim Coleccion As New RelacionClienteCorteCollection()
            Coleccion.Obtener(Nothing)
            Dim Reportes As New RptRelacionClienteCorte
            Dim Ds As New DataSet
            Dim Tabla As New DsRelecionClienteProd.RelacionTablaDataTable()

            For Each Rela As RelacionClienteCorteClass In Coleccion
                Tabla.AddRelacionTablaRow(Rela.CodCliente, Rela.NomCliente, Rela.CodCorte, Rela.Descripcion, Rela.CodCorteCliente, Rela.DescripcionClie, Rela.Destino.Descripcion)
            Next

            Ds.Tables.Add(Tabla)
            Reportes.SetDataSource(Ds.Tables(0))
            Reportes.SetParameterValue(0, Empresas)
            Reportes.SetParameterValue(1, Usuario)
            Reportes.SetParameterValue(2, "Catalogos/Produccion/Relacion Productos Clientes")

            Return Reportes
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Overloads Function Obtener(ByVal IdCliente As Integer, ByVal idDestino As Integer) As Integer
        Try
            Dim rel As New OC.RelationCollection
            Dim listaIdProducto As List(Of Integer)

            rel.Add(EC.MscrelacionCortesClientesEntity.Relations.MsccatProductosEntityUsingCodCorte, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Left)

            coleccion.GetMulti(HC.MscrelacionCortesClientesFields.CodCliente = IdCliente And _
                                HC.MscrelacionCortesClientesFields.IdDestino = idDestino, 0, _
                                New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), rel)

            Rellenar()

            If Me.Count > 0 Then
                listaIdProducto = New List(Of Integer)

                For Each ent As RelacionClienteCorteClass In Me
                    listaIdProducto.Add(ent.CodCorte)
                Next

                Me.RellenarProductosFaltantes(listaIdProducto, idDestino, IdCliente)
            Else
                Me.RellenarProductosFaltantes(Nothing, idDestino, IdCliente)
            End If

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        Dim hacerRollBack As Boolean = False

        If trans Is Nothing Then
            trans = New HC.Transaction(IsolationLevel.ReadCommitted, "GuardarRelacionClienteCorte")
            hacerRollBack = True
        End If

        Try
            For Each item As RelacionClienteCorteClass In Me
                item.Guardar(trans)
            Next

            If hacerRollBack Then
                trans.Commit()
            End If

            Return True
        Catch ex As Exception
            If hacerRollBack Then
                trans.Rollback()
            End If

            Throw ex
        End Try
    End Function

    'Public Overloads Function Obtener(ByVal CodCliente As Integer) As Integer
    '    Try
    '        coleccion.GetMulti(HC.MscrelacionCortesClientesFields.CodCliente = CodCliente)
    '        Rellenar()
    '        Return Count
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Function
End Class