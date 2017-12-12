Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class AlmacenCollectionClass
    Inherits CollectionClass(Of AlmacenClass)

    Private _Tipo As AlmacenEnum
    Private col As CC.AlmacenCollection
    Private Orden As New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

    Public Property Tipo() As AlmacenEnum
        Get
            Return _Tipo
        End Get
        Set(ByVal value As AlmacenEnum)
            _Tipo = value
        End Set
    End Property

    Public Function Obtener(ByVal Arreglo() As Integer, ByVal Estatus As CondicionEnum, ByVal AgregarNinguno As Boolean, ByVal IdTipoAlmacen As Integer) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.AlmacenFields.TipoAlmacen = IdTipoAlmacen)

            If Estatus = CondicionEnum.TODOS Then
                Filtro.Add(New OC.FieldCompareRangePredicate(HC.AlmacenFields.AlmacenId, True, Arreglo))
            Else
                Filtro.Add(New OC.FieldCompareRangePredicate(HC.AlmacenFields.AlmacenId, True, Arreglo) And HC.AlmacenFields.Estatus = Estatus)
            End If

            col.GetMulti(Filtro, 0, Orden)

            If AgregarNinguno Then
                Dim Alm As New AlmacenClass
                Alm.Descripcion = "NINGUNO"
                Me.Add(Alm)
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Alm As New AlmacenClass
                Alm.LeerEntidad(entidad)
                Me.Add(Alm)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(Optional ByVal condicion As CondicionEnum = CondicionEnum.TODOS, Optional ByVal AgregarTodos As Boolean = False) As Integer
        Try

            If Tipo = AlmacenEnum.ALMACEN Then
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti(HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen, 0, Orden)
                Else
                    col.GetMulti((HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And HC.AlmacenFields.Estatus = condicion, 0, Orden)
                End If
            ElseIf Tipo = AlmacenEnum.SUBALMACEN Then
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti(Not (HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen), 0, Orden)
                Else
                    col.GetMulti((Not (HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen)) And HC.AlmacenFields.Estatus = condicion, 0, Orden)
                End If
            Else
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti(Nothing, 0, Orden)
                Else
                    col.GetMulti(HC.AlmacenFields.Estatus = condicion, 0, Orden)
                End If
            End If

            If AgregarTodos Then
                Dim tipo As New AlmacenClass
                tipo.Descripcion = "-TODOS-"
                Me.Add(tipo)
            End If

            Clear()

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerPorTipo(ByVal Condicion As CondicionEnum, ByVal IdTipoAlmacen As Integer, Optional ByVal AgregarTodos As Boolean = False) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression

            If Not Condicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.AlmacenFields.Estatus = CInt(Condicion))
            End If

            If Not IdTipoAlmacen = -1 Then
                Filtro.Add(HC.AlmacenFields.TipoAlmacen = IdTipoAlmacen)
            End If

            col.GetMulti(Filtro, 0, Orden)

            If AgregarTodos Then
                Dim tipo As New AlmacenClass
                tipo.Descripcion = "-TODOS"
                Me.Add(tipo)
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String, ByVal DescripcionCorta As String, Optional ByVal condicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()
            Dim num As Integer = 0
            If Tipo = AlmacenEnum.Almacen Then
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti((HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And _
                                ((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))), 0, Orden)
                Else
                    col.GetMulti((HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And _
                                (((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))) And _
                                HC.AlmacenFields.Estatus = condicion), 0, Orden)
                End If
            ElseIf Tipo = AlmacenEnum.SubAlmacen Then
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti((Not HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And _
                                ((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))), 0, Orden)
                Else
                    col.GetMulti((Not HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And _
                                (((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))) And _
                                HC.AlmacenFields.Estatus = condicion), 0, Orden)
                End If
            Else
                If condicion = CondicionEnum.TODOS Then
                    col.GetMulti(((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))), 0, Orden)
                Else
                    col.GetMulti((((HC.AlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or _
                                (HC.AlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))) And _
                                HC.AlmacenFields.Estatus = condicion), 0, Orden)
                End If
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
                num += 1
            Next
            Return num
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal CodigoAlmacen As Integer, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()
            Dim num As Integer = 0
            If Tipo = AlmacenEnum.Almacen Or Tipo = AlmacenEnum.Todos Then
                col.GetMulti(HC.AlmacenFields.AlmacenId = CodigoAlmacen And HC.AlmacenFields.Estatus = fccondicion, 0, Orden)
            ElseIf Tipo = AlmacenEnum.SubAlmacen Then
                col.GetMulti((Not HC.AlmacenFields.AlmacenId = HC.AlmacenFields.AlmacenId) And HC.AlmacenFields.Estatus = fccondicion, 0, Orden)
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
                num += 1
            Next
            Return num
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String) As Integer
        Try
            If Not Descripcion = "" Then
                col.GetMulti(HC.AlmacenFields.Descripcion Mod String.Format("%{0}%", Descripcion), 0, Orden)
            Else
                col.GetMulti(Nothing, 0, Orden)
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal filtro As OC.IPredicate) As Integer
        Try
            Clear()

            Me.col.GetMulti(filtro, 0, Orden)

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal filtro As OC.IPredicate, ByVal rel As OC.RelationCollection) As Integer
        Try
            Clear()

            Me.col.GetMulti(filtro, 0, Orden, rel)

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal fcondicion As CondicionEnum, ByVal CodigoPlaza As Integer) As Integer
        Try
            Me.Clear()

            If Tipo = AlmacenEnum.ALMACEN Or Tipo = AlmacenEnum.TODOS Then
                col.GetMulti(HC.AlmacenFields.Plaza = CodigoPlaza And HC.AlmacenFields.Estatus = fcondicion, 0, Orden)
            ElseIf Tipo = AlmacenEnum.SUBALMACEN Then
                col.GetMulti((Not HC.AlmacenFields.AlmacenId = HC.AlmacenFields.Almacen) And HC.AlmacenFields.Estatus = fcondicion, 0, Orden)
            End If

            For Each entidad As EC.AlmacenEntity In col
                Dim Tipo As New AlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerDeProduccion(Optional ByVal idAlmacenesIgnorar As List(Of Integer) = Nothing) As Integer
        Try
            Dim rel As New OC.RelationCollection

            rel.Add(New OC.EntityRelation(HC.TipoAlmacenFields.Codigo, HC.AlmacenFields.TipoAlmacen, SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany))

            If idAlmacenesIgnorar Is Nothing Then
                Me.col.GetMulti(HC.TipoAlmacenFields.DeProduccion = 1 And HC.AlmacenFields.Estatus = 1, _
                                0, Orden, rel)
            Else
                Me.col.GetMulti(HC.TipoAlmacenFields.DeProduccion = 1 And HC.AlmacenFields.Estatus = 1 And _
                                New OC.FieldCompareRangePredicate(HC.AlmacenFields.AlmacenId, True, idAlmacenesIgnorar.ToArray), _
                                0, Orden, rel)
            End If

            Clear()

            For Each item As EC.AlmacenEntity In col
                Me.Add(New AlmacenClass(item))
            Next
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los almacenes", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Sub New()
        col = New CC.AlmacenCollection
        Tipo = AlmacenEnum.Almacen
    End Sub

    Public Shared Function CargarAlmacenes(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Almacenes As New CC.AlmacenCollection()

        Try
            Almacenes.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return Almacenes.GetList()
    End Function

    Public Sub RellenarMe(ByVal almacenes As CC.AlmacenCollection)
        col = almacenes

        Rellenar()
    End Sub

    Private Sub Rellenar()
        Me.Clear()

        For Each alm As EC.AlmacenEntity In col
            Add(New AlmacenClass(alm))
        Next
    End Sub
End Class