Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class SucursalCollectionClass
    Inherits ColleccionBase(Of Ec.SucursalEntity, CC.SucursalCollection, SucursalClass)

    Private Filtro As OC.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Public Overloads Function IndexOf(ByVal Codigo As Integer) As Integer
        IndexOf = -1

        For i As Integer = 0 To Me.Items.Count - 1
            If Me.Items(i).Codigo = Codigo Then
                Return i
            End If
        Next
        Return IndexOf
    End Function

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Coleccion As CC.SucursalCollection)
        Me.coleccion = Coleccion
        Rellenar()
    End Sub

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()

            If FcCondicion = CondicionEnum.TODOS Then
                coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Else
                coleccion.GetMulti(HC.SucursalFields.Estatus = FcCondicion, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If
            Me.Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal PlazaId As Integer, ByVal FcCondicion As CondicionEnum) As Integer
        Try
            Me.Clear()

            If FcCondicion = CondicionEnum.TODOS Then
                coleccion.GetMulti(HC.SucursalFields.CodigoPlaza = PlazaId, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Else
                coleccion.GetMulti(HC.SucursalFields.Estatus = FcCondicion And HC.SucursalFields.CodigoPlaza = PlazaId, 0, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Sucursal As SucursalClass) As Integer
        Try
            Me.Clear()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.SucursalFields.Codigo = Sucursal.Codigo)
            Filtro.AddWithOr(HC.SucursalFields.DescripcionCorta = Sucursal.DescripcionCorta)
            Filtro.AddWithOr(HC.SucursalFields.Descripcion = Sucursal.Descripcion)
            Dim Conteo As Integer = coleccion.GetDbCount(Filtro)
            If Conteo > 0 Then
                coleccion.GetMulti(Filtro)
                For Each SucursalEntity As Ec.SucursalEntity In coleccion
                    Dim MiSucursal As New SucursalClass
                    MiSucursal.LeerEntidad(SucursalEntity)
                    Me.Add(MiSucursal)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function
    ''' <summary>
    ''' Obtiene las sucursales filtradas por su descripcion y las de una determinada plaza si se desea
    ''' </summary>
    ''' <param name="Descripcion"></param>
    ''' <param name="FcCondicion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Descripcion As String, ByVal FcCondicion As CondicionEnum, Optional ByVal IdPlaza As Integer = 0, Optional ByVal AgregarTodas As Boolean = False) As Integer
        Try
            Me.Clear()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.SucursalFields.Descripcion Mod (String.Format("%{0}%", Descripcion)))
            If FcCondicion <> CondicionEnum.TODOS Then
                Filtro.Add(HC.SucursalFields.Estatus = FcCondicion)
            End If
            If IdPlaza <> 0 Then
                Filtro.Add(HC.SucursalFields.CodigoPlaza = IdPlaza)
            End If
            Me.coleccion.GetMulti(Filtro, -1, New OC.SortExpression(New OC.SortClause(HC.SucursalFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            'Me.SucursalCollection.GetMulti(Filtro)
            If AgregarTodas Then
                Dim Sc As New SucursalClass
                Sc.Descripcion = "TODAS"
                Me.Add(Sc)
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

    Public Function Guardar() As Integer
        coleccion = New CC.SucursalCollection

        For Each Sucursal As SucursalClass In Me
            Dim SucursalEntity As New Ec.SucursalEntity
            SucursalEntity = Sucursal.ObtenerEntidad()
            coleccion.Add(SucursalEntity)
        Next
        Try
            Dim Conteo As Integer = coleccion.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        coleccion = New CC.SucursalCollection

        For Each Sucursal As SucursalClass In Me
            Dim SucursalEntity As New Ec.SucursalEntity
            SucursalEntity = Sucursal.ObtenerEntidad()
            coleccion.Add(SucursalEntity)
        Next
        Try
            Dim Conteo As Integer = coleccion.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptABCSucursales
        Dim rpt As New rptABCSucursales
        Dim ds As New DataSet
        Dim dtSucursales As New DSSucursales.dtSucursalesDataTable
        For Each Sucursal As SucursalClass In Me
            dtSucursales.AdddtSucursalesRow(Sucursal.Plaza.Descripcion, Sucursal.Codigo, Sucursal.Descripcion, Sucursal.DescripcionCorta, Sucursal.Observaciones, Sucursal.Estatus.ToString())
        Next
        ds.Tables.Add(dtSucursales)
        rpt.SetDataSource(ds)
        Return rpt
    End Function

End Class