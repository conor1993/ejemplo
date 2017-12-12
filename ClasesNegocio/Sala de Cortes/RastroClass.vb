Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class RastroClass
    Inherits ClassBase(Of EC.CatRastrosEntity)

#Region "Atributos"
    Dim m_ProductosRastro As MSCRelacionProductosRastrosCollectionClass
#End Region

#Region "Propiedades"
    ReadOnly Property IdRastro() As Integer
        Get
            Return Entity.IdRastro
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Property DescCorta() As String
        Get
            Return Entity.DescCorta
        End Get
        Set(ByVal value As String)
            Entity.DescCorta = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return CType(IIf(Entity.Estatus = "1", EstatusEnum.ACTIVO, EstatusEnum.INACTIVO), EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = IIf(value = EstatusEnum.ACTIVO, "1", "0").ToString
        End Set
    End Property

    Public ReadOnly Property ProductosRastro() As MSCRelacionProductosRastrosCollectionClass
        Get
            If m_ProductosRastro Is Nothing Then
                m_ProductosRastro = New MSCRelacionProductosRastrosCollectionClass(Me.IdRastro)
            End If

            Return m_ProductosRastro
        End Get
    End Property
#End Region

    Public Overloads Function Borrar() As Boolean
        Try
            'falta las validaciones con relacion a los sacrificios

            Estatus = EstatusEnum.INACTIVO
            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

#Region "Constructores"
    Sub New()
        Entity = New EC.CatRastrosEntity
    End Sub

    Sub New(ByVal Entidad As EC.CatRastrosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdRastro As Integer)
        Entity = New EC.CatRastrosEntity(IdRastro)
    End Sub
#End Region

    Public Overloads Function ObtenerEntidad() As EC.CatRastrosEntity
        Return Me.Entity
    End Function

    Public Overloads Sub LeerEntidad(ByVal Entidad As EC.CatRastrosEntity)
        Entity = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Overrides Function Guardar(Optional ByVal trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Entity.IsNew Then
                Dim col As New CC.CatRastrosCollection

                If col.GetDbCount(HC.CatRastrosFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un Rastro con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.CatRastrosFields.DescCorta = DescCorta) > 0 Then
                    MsgBox("Ya existe un Rastro con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el Rastro, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            Else
                Dim col As New CC.CatRastrosCollection

                If col.GetDbCount(Not HC.CatRastrosFields.IdRastro = IdRastro And HC.CatRastrosFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un Rastro con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(Not HC.CatRastrosFields.IdRastro = IdRastro And HC.CatRastrosFields.DescCorta = DescCorta) > 0 Then
                    MsgBox("Ya existe un Rastro con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el Rastro, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al querer guardar, intente nuevamente", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shared Function CargarRastro(ByVal IdRastro As Integer) As RastroClass
        Return New RastroClass(IdRastro)
    End Function

    Public Sub GuardarProductos(ByVal Trans As HC.Transaction)
        For Each Item As MSCRelacionProductosRastrosClass In New MSCRelacionProductosRastrosCollectionClass(Me.IdRastro)
            Trans.Add(Item.Entidad)
            Item.Entidad.Delete()
        Next

        For Each Item As MSCRelacionProductosRastrosClass In m_ProductosRastro
            Dim producto As New MSCRelacionProductosRastrosClass(Me.IdRastro, Item.Producto.Entidad, Item.CodigoProductoRastro)
            producto.Guardar(Trans)
        Next
    End Sub
End Class

Public Class RastroCollectionClass
    Inherits ColleccionBase(Of EC.CatRastrosEntity, CC.CatRastrosCollection, RastroClass)
    Public Event MensajeError As MensajeErrorHandler
    Private Shadows WithEvents Coleccion As New CC.CatRastrosCollection
    Private Filtro As OC.PredicateExpression

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()
            If Not fcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(HC.CatRastrosFields.Estatus = fcCondicion)
            Else
                Coleccion.GetMulti(Nothing)
            End If
            Dim Conteo As Integer = Me.Coleccion.Count
            For Each RastroEntity As EC.CatRastrosEntity In Coleccion
                Dim Rastro As New RastroClass
                Rastro.LeerEntidad(RastroEntity)
                Me.Add(Rastro)
            Next
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

#Region "Código de Relleno"
    Private Overloads Sub Rellenar()
        Clear()
        For Each ente As EC.CatRastrosEntity In Coleccion
            Add(New RastroClass(ente))
        Next
    End Sub

    Public Overloads Sub RellenarMe(ByVal Collection As CC.CatRastrosCollection)
        Coleccion = Collection
        Rellenar()
    End Sub

    Private Overloads Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As RastroClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Overloads Function ObtenerColeccion() As CC.CatRastrosCollection
        RellenarColeccion()
        Return Coleccion
    End Function
#End Region

    Public Shared Function CargarRastros(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Rastros As New CC.CatRastrosCollection()

        Try
            Rastros.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatRastrosFields.Descripcion, OC.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Rastros.GetList()
    End Function

    Public Shared Sub Imprimir(ByVal NomEmpresa As String, ByVal NomUsuario As String, Optional ByVal Filtro As OC.IPredicate = Nothing)
        Dim Reporte As New RptRastros()
        Dim vent As New PreVisualizarForm

        Try
            Dim Rastros As DataTable = CC.CatRastrosCollection.GetMultiAsDataTable(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatRastrosFields.Descripcion, OC.SortOperator.Ascending)))

            For Each Item As DataRow In Rastros.Rows
                If Item.Item("Estatus").ToString = "1" Then
                    Item.Item("Estatus") = "ACTIVO"
                Else
                    Item.Item("Estatus") = "INACTIVO"
                End If
            Next

            Reporte.SetDataSource(CType(Rastros, Object))
            vent.Text = "Recepcion de Pesadas"
            Reporte.SetParameterValue(0, NomEmpresa)
            Reporte.SetParameterValue(1, NomUsuario)
            Reporte.SetParameterValue(2, "Catalogos/Produccion/Rastros")
            vent.Reporte = Reporte
            vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            vent.WindowState = Windows.Forms.FormWindowState.Maximized
            vent.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class