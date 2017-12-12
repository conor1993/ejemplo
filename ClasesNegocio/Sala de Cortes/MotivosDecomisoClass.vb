Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MotivosDecomisoClass
    Inherits ClassBase(Of EC.MsccatDecomisosEntity)

#Region "Miembros"
    Dim _Func As String
    Dim _NumOpc As Integer
    'Private WithEvents MotivosDecomiso As EC.MsccatDecomisosEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Código")> _
    ReadOnly Property IdDecomiso() As Integer
        Get
            Return Entity.IdDecomiso
        End Get
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
        End Set
    End Property

    <ComponentModel.DisplayName("Observaciones")> _
    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Me.Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public ReadOnly Property EstatusStr() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.MsccatDecomisosEntity
    End Sub

    Sub New(ByVal Entidad As EC.MsccatDecomisosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Long)
        Entity = New EC.MsccatDecomisosEntity(Codigo)
    End Sub
#End Region

#Region "Metodos"
    Public Overloads Function Borrar() As Boolean
        Try
            'Dim col As New CC.MsccatMotivosDecomisoCollection

            'If col.GetDbCount(HC.MsccatMotivosDecomisoFields.IdMotivoDec = IdMotivoDec And HC.MsccatMotivosDecomisoFields.Estatus = 1) > 0 Then
            '    MsgBox("No se logro dar de baja el motivo de decomiso, tiene motivos activos", MsgBoxStyle.Exclamation, "Motivos de Decomiso Activos")
            '    Return False
            'End If

            Dim colProdDet As New CC.MsccatProductosDetalleCollection
            Dim rel As New OC.RelationCollection

            rel.Add(EC.MsccatDecomisosEntity.Relations.MsccatProductosDetalleEntityUsingIdDecomiso, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            If colProdDet.GetDbCount(HC.MsccatProductosDetalleFields.IdDecomiso = Me.IdDecomiso) > 0 AndAlso colProdDet.GetDbCount(HC.MsccatProductosDetalleFields.IdDecomiso = Me.IdDecomiso And HC.MsccatProductosFields.Estatus = EstatusEnum.ACTIVO, rel) > 0 Then
                MsgBox("No se logro dar de baja el motivo de decomiso, tiene relacionados productos activos", MsgBoxStyle.Exclamation, "Productos Activos")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            If Entity.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            Else
                RaiseEvent MensajeError(Me, "El Motivo de Decomiso especificado no existe.")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try
    End Function

    Public Overloads Function ObtenerEntidad() As EC.MsccatDecomisosEntity
        Return Me.Entity
    End Function

    Public Overloads Sub LeerEntidad(ByVal Entidad As EC.MsccatDecomisosEntity)
        Entity = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Function Guardar() As Boolean
        Try
            If Entity.IsNew Then
                Dim col As New CC.MsccatDecomisosCollection

                If col.GetDbCount(HC.MsccatDecomisosFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un motivo de decomiso con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                End If

                If col.GetDbCount(HC.MsccatDecomisosFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un motivo de decomiso con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el motivo de decomiso, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            Else
                Dim col As New CC.MsccatDecomisosCollection

                If col.GetDbCount(Not HC.MsccatDecomisosFields.IdDecomiso = IdDecomiso And _
                                    HC.MsccatDecomisosFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un motivo de decomiso con esta descripción", MsgBoxStyle.Exclamation, "Descripción Repetida")
                    Return False
                ElseIf col.GetDbCount(Not HC.MsccatDecomisosFields.IdDecomiso = IdDecomiso And _
                                    HC.MsccatDecomisosFields.DescripcionCorta = DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un motivo de decomiso con esta descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                    Return False
                End If

                If Entity.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar el motivo de decomiso, intente nuevamente", MsgBoxStyle.Exclamation, "No Guardo")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class

Public Class MotivosDecomisoCollectionClass
    Inherits ColleccionBase(Of EC.MsccatDecomisosEntity, CC.MsccatDecomisosCollection, MotivosDecomisoClass)

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            If Not fcCondicion = CondicionEnum.TODOS Then
                coleccion.GetMulti(HC.MsccatDecomisosFields.Estatus = fcCondicion)
            Else
                coleccion.GetMulti(Nothing)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Obtiene los decomisos que no se encuentran en el listado de decomisos especificado
    ''' </summary>
    ''' <param name="fcCondicion">Estatus por el que desea filtrar</param>
    ''' <param name="descartarIdDecomisos">Lista de idDecomisos que desean que no sean tomados encuenta en la consulta</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum, ByVal descartarIdDecomisos As Integer()) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.MsccatDecomisosFields.Estatus = fcCondicion)
            End If

            If descartarIdDecomisos.Length > 0 Then
                filtro.Add(New OC.FieldCompareRangePredicate(HC.MsccatDecomisosFields.IdDecomiso, True, descartarIdDecomisos))
            End If

            coleccion.GetMulti(filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal descripcion As String, ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.MsccatDecomisosFields.Descripcion Mod String.Format("%{0}%", descripcion))

            If Not fcCondicion = CondicionEnum.TODOS Then
                Filtro.Add(HC.MsccatDecomisosFields.Estatus = fcCondicion)
            End If

            coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#Region "Rellenar"
    Public Overloads Function Obtenercoleccion() As CC.MsccatDecomisosCollection
        RellenarColeccion()
        Return coleccion
    End Function

    Private Overloads Sub Rellenar()
        Clear()
        For Each ente As EC.MsccatDecomisosEntity In coleccion
            Add(New MotivosDecomisoClass(ente))
        Next
    End Sub

    Private Overloads Sub RellenarColeccion()
        coleccion.Clear()

        For Each MotivoDe As MotivosDecomisoClass In Me
            coleccion.Add(MotivoDe.ObtenerEntidad())
        Next
    End Sub

    Public Overloads Sub RellenarMe(ByVal col As CC.MsccatDecomisosCollection)
        Me.coleccion = col
        Rellenar()
    End Sub
#End Region

    Public Function Reporte(ByVal nombreEmpresa As String, ByVal nombreUsuario As String) As CRepMotivoDecomiso
        Dim rep As New CRepMotivoDecomiso

        rep.SetDataSource(Me)

        rep.SetParameterValue("NombreEmpresa", nombreEmpresa)
        rep.SetParameterValue("MenuOpcion", "Catalogos/Produccion/Motivos de Decomiso")
        rep.SetParameterValue("NombreUsuario", nombreUsuario)

        Return rep
    End Function
End Class