Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PlazaCollectionClass
    Inherits ColleccionBase(Of Ec.PlazaEntity, CC.PlazaCollection, PlazaClass)

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

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Clear()

            If FcCondicion = CondicionEnum.Todos Then
                coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.PlazaFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Else
                coleccion.GetMulti(HC.PlazaFields.Estatus = FcCondicion, 0, New OC.SortExpression(New OC.SortClause(HC.PlazaFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If

            Rellenar()

            Return coleccion.Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene los elementos que cumplan con las condiciones (Codigo, Descripcion corta, Descripcion)
    ''' de la plaza y me regresa como resultado un valor de tipo Entero el cual representa el numero de
    ''' plazas obtenidas.
    ''' </summary>
    ''' <param name="Plaza">Representa la plaza que lleva los parametros de busqueda</param>
    ''' <returns>Entero, Numero de plazas obtenidas</returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Plaza As PlazaClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.PlazaFields.Codigo = Plaza.Codigo)
            Filtro.AddWithOr(HC.PlazaFields.DescripcionCorta = Plaza.DescripcionCorta)
            Filtro.AddWithOr(HC.PlazaFields.Descripcion = Plaza.Descripcion)
            Dim Conteo As Integer = coleccion.GetDbCount(Filtro)
            If Conteo > 0 Then
                coleccion.GetMulti(Filtro)
                For Each PlazaEntity As Ec.PlazaEntity In coleccion
                    Dim MiPlaza As New PlazaClass
                    MiPlaza.LeerEntidad(PlazaEntity)
                    Me.Add(MiPlaza)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal activo As Boolean) As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = coleccion.GetDbCount()
            If Conteo > 0 Then
                coleccion.GetMulti(Nothing)
                For Each plazaEntity As Ec.PlazaEntity In coleccion
                    Dim Plaza As New PlazaClass
                    Plaza.LeerEntidad(plazaEntity)
                    If Plaza.Estatus = EstatusEnum.ACTIVO Then
                        Me.Add(Plaza)
                    End If
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene las plazas filtrada por determinadas letras de descripcion
    ''' </summary>
    ''' <param name="Descripcion"></param>
    ''' <param name="FcCondicion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Obtener(ByVal Descripcion As String, ByVal FcCondicion As CondicionEnum, Optional ByVal AgregarTodas As Boolean = False) As Integer
        Try
            Me.Clear()
            Filtro = New OC.PredicateExpression
            Filtro.Add(HC.PlazaFields.Descripcion Mod (String.Format("%{0}%", Descripcion)))
            If FcCondicion <> CondicionEnum.TODOS Then
                Filtro.Add(HC.PlazaFields.Estatus = FcCondicion)
            End If
            Me.coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.PlazaFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            If AgregarTodas Then
                Dim pl As New PlazaClass
                pl.Descripcion = "TODAS"
                Me.Add(pl)
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
        coleccion = New CC.PlazaCollection
        For Each Plaza As PlazaClass In Me
            Dim PlazaEntity As New Ec.PlazaEntity
            PlazaEntity = Plaza.ObtenerEntidad()
            coleccion.Add(PlazaEntity)
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
        coleccion = New CC.PlazaCollection
        For Each Plaza As PlazaClass In Me
            Dim PlazaEntity As New Ec.PlazaEntity
            PlazaEntity = Plaza.ObtenerEntidad()
            coleccion.Add(PlazaEntity)
        Next
        Try
            Dim Conteo As Integer = coleccion.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptABCPlazas
        Dim rpt As New rptABCPlazas
        Dim ds As New DataSet
        Dim dtPlazas As New DSPlazas.dtPlazasDataTable
        For Each Plazas As PlazaClass In Me
            dtPlazas.AdddtPlazasRow(Plazas.Codigo, Plazas.Descripcion, Plazas.DescripcionCorta, Plazas.Observaciones, Plazas.Estatus.ToString())
        Next
        ds.Tables.Add(dtPlazas)
        rpt.SetDataSource(ds)
        Return rpt
    End Function

End Class
