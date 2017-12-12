Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = INTEGRALAB.orm.StoredProcedureCallerClasses.ActionProcedures

Public Class TipoMovimientoPVClass
    Inherits ClassBase(Of EC.CatMovimientosAlmacenPvEntity)



#Region "Propiedades"

    Public ReadOnly Property Codigo() As Integer
        Get
            Return entidad.IdMov
        End Get
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Property Nombre() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción Corta")> _
    Property NombreCorto() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Afecta a Costo")> _
    Property AfectaCosto() As AfectaCostoEnum
        Get
            Return Entity.AfectaCosto
        End Get
        Set(ByVal value As AfectaCostoEnum)
            Entity.AfectaCosto = value
        End Set
    End Property

    Property Direccion() As DireccionEnum
        Get
            Return Entity.Direccion
        End Get
        Set(ByVal value As DireccionEnum)
            Entity.Direccion = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Alta")> _
    Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Baja")> _
    Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

#End Region

#Region "Metodos y funciones"
    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

    Sub New()
        Entity = New EC.CatMovimientosAlmacenPvEntity
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.CatMovimientosAlmacenPvEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.CatMovimientosAlmacenPvEntity(Codigo)
    End Sub

    Public Function Borrar() As Boolean
        Entity.Estatus = EstatusEnum.INACTIVO
        Return Entity.Save()
    End Function

    Public Function Guardar() As Boolean
        Dim col As New CC.CatMovimientosAlmacenPvCollection

        If Entity.IsNew Then
            If col.GetDbCount(HC.CatMovimientosAlmacenPvFields.Descripcion = Nombre) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripcion", MsgBoxStyle.Exclamation, "Descripción Repetida")
                Return False
            End If

            If col.GetDbCount(HC.CatMovimientosAlmacenPvFields.DescripcionCorta = NombreCorto) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                Return False
            End If

            If Entity.Save Then
                Return True
            Else
                MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            If col.GetDbCount(Not HC.CatMovimientosAlmacenPvFields.IdMov = Codigo And HC.CatMovimientosAlmacenPvFields.Descripcion = Nombre) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripcion", MsgBoxStyle.Exclamation, "Descripción Repetida")
                Return False
                Exit Function
            End If

            If col.GetDbCount(Not HC.CatMovimientosAlmacenPvFields.IdMov = Codigo And HC.CatMovimientosAlmacenPvFields.DescripcionCorta = NombreCorto) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripción corta", MsgBoxStyle.Exclamation, "Descripción Corta Repetida")
                Return False
            End If

            If Entity.Save Then
                Return True
            Else
                MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Return Entity.FetchUsingPK(Codigo)
    End Function

    Sub LeerEntidad(ByVal Entidad As EC.CatMovimientosAlmacenPvEntity)
        Entity = Entidad
    End Sub

    Function ObtenerEntidad() As EC.CatMovimientosAlmacenPvEntity
        Return Entity
    End Function
#End Region

End Class

Public Class TipoMovimientoPVCollectionClass
    Inherits ColleccionBase(Of EC.CatMovimientosAlmacenPvEntity, CC.CatMovimientosAlmacenPvCollection, TipoMovimientoPVClass)

    Public Function Seleccionar(ByVal Nombre As String) As TipoMovimientoPVClass
        For Each tipo As TipoMovimientoPVClass In Me
            If tipo.Nombre = Nombre Then Return tipo
        Next
        Return Nothing
    End Function

    Public Function Seleccionar(ByVal Codigo As Integer) As TipoMovimientoPVClass
        For Each tipo As TipoMovimientoPVClass In Me
            If tipo.Codigo = Codigo Then Return tipo
        Next
        Return Nothing
    End Function

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Else
                coleccion.GetMulti(HC.CatMovimientosAlmacenPvFields.Estatus = FcCondicion, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If

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
                Filtro.Add(HC.CatMovimientosAlmacenPvFields.Estatus = FcCondicion)
            End If

            Filtro.Add(HC.CatMovimientosAlmacenPvFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Filtro.Add(HC.CatMovimientosAlmacenPvFields.DescripcionCorta Mod String.Format("%{0}", DescripcionCorta))

            coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Filtro As OC.PredicateExpression) As Integer
        Try
            'Dim Filtro As New OC.PredicateExpression

            'If Not FcCondicion = CondicionEnum.TODOS Then
            '    Filtro.Add(HC.CatMovimientosAlmacenPvFields.Estatus = FcCondicion)
            'End If

            'Filtro.Add(HC.CatMovimientosAlmacenPvFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            'Filtro.Add(HC.CatMovimientosAlmacenPvFields.DescripcionCorta Mod String.Format("%{0}", DescripcionCorta))

            coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.CatMovimientosAlmacenPvFields.IdMov = Codigo)
            Coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String) As Integer
        Try
            If Not Descripcion = "" Then
                coleccion.GetMulti(HC.CatMovimientosAlmacenPvFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Else
                coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If

            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal FcEstatus As CondicionEnum, ByVal fcdireccion As CondicionDireccionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not FcEstatus = CondicionEnum.TODOS Then
                filtro.Add(HC.CatMovimientosAlmacenPvFields.Estatus = FcEstatus)
            End If

            If Not fcdireccion = CondicionDireccionEnum.TODAS Then
                filtro.Add(HC.CatMovimientosAlmacenPvFields.Direccion = fcdireccion)
            End If

            coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.CatMovimientosAlmacenPvFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los tipos de movimientos", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

End Class


