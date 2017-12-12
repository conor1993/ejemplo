Imports CC = IntegraLab.orm.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class TipoMovimientoAlmacenClass
    Inherits ClassBase(Of EC.TipoMovimientoAlmacenEntity)

    ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
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

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

    Sub New()
        Entity = New EC.TipoMovimientoAlmacenEntity
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal Entidad As EC.TipoMovimientoAlmacenEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.TipoMovimientoAlmacenEntity(Codigo)
    End Sub

    Public Function Borrar() As Boolean
        Entity.Estatus = EstatusEnum.INACTIVO
        Return Entity.Save()
    End Function

    Public Function Guardar() As Boolean
        Dim col As New CC.TipoMovimientoAlmacenCollection

        If Entity.IsNew Then
            If col.GetDbCount(HC.TipoMovimientoAlmacenFields.Descripcion = Nombre) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripcion", MsgBoxStyle.Exclamation, "Descripción Repetida")
                Return False
            End If

            If col.GetDbCount(HC.TipoMovimientoAlmacenFields.DescripcionCorta = NombreCorto) > 0 Then
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
            If col.GetDbCount(Not HC.TipoMovimientoAlmacenFields.Codigo = Codigo And HC.TipoMovimientoAlmacenFields.Descripcion = Nombre) > 0 Then
                MsgBox("Ya existe otro movimiento con la misma descripcion", MsgBoxStyle.Exclamation, "Descripción Repetida")
                Return False
                Exit Function
            End If

            If col.GetDbCount(Not HC.TipoMovimientoAlmacenFields.Codigo = Codigo And HC.TipoMovimientoAlmacenFields.DescripcionCorta = NombreCorto) > 0 Then
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

    Sub LeerEntidad(ByVal Entidad As EC.TipoMovimientoAlmacenEntity)
        Entity = Entidad
    End Sub

    Function ObtenerEntidad() As EC.TipoMovimientoAlmacenEntity
        Return Entity
    End Function

End Class

Public Class TipoMovimientoAlmacenCollectionClass
    Inherits ColleccionBase(Of EC.TipoMovimientoAlmacenEntity, CC.TipoMovimientoAlmacenCollection, TipoMovimientoAlmacenClass)

    Public Function Seleccionar(ByVal Nombre As String) As TipoMovimientoAlmacenClass
        For Each tipo As TipoMovimientoAlmacenClass In Me
            If tipo.Nombre = Nombre Then Return tipo
        Next
        Return Nothing
    End Function

    Public Function Seleccionar(ByVal Codigo As Integer) As TipoMovimientoAlmacenClass
        For Each tipo As TipoMovimientoAlmacenClass In Me
            If tipo.Codigo = Codigo Then Return tipo
        Next
        Return Nothing
    End Function

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.TipoMovimientoAlmacenFields.Estatus = FcCondicion, 0, New OC.SortExpression(New OC.SortClause(HC.TipoMovimientoAlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
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
                Filtro.Add(HC.TipoMovimientoAlmacenFields.Estatus = FcCondicion)
            End If

            Filtro.Add(HC.TipoMovimientoAlmacenFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Filtro.Add(HC.TipoMovimientoAlmacenFields.DescripcionCorta Mod String.Format("%{0}", DescripcionCorta))

            Coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.TipoMovimientoAlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

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
            Filtro.Add(HC.TipoMovimientoAlmacenFields.Codigo = Codigo)
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

    Public Function Obtener(ByVal Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression) As Integer
        Try
            
            coleccion.GetMulti(Filtro)

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

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepTipoMovimientoAlmacen
        Try
            Dim rep As New CRepTipoMovimientoAlmacen
            Dim dst As New Data.DataSet
            Dim tb As New DSetTipoMovimientoAlmacen.TipoMovimientoDataTable

            For Each tip As TipoMovimientoAlmacenClass In Me
                tb.AddTipoMovimientoRow(tip.Codigo, tip.Nombre, tip.NombreCorto, tip.AfectaCosto.ToString, tip.Direccion.ToString, tip.Estatus.ToString, tip.FechaAlta.ToShortDateString)
            Next

            dst.Tables.Add(tb)

            rep.SetDataSource(dst)
            rep.SetParameterValue(0, Usuario)
            rep.SetParameterValue(1, Empresa)
            rep.SetParameterValue(2, "Catalogos/Almacenes/Movimientos de Almacén")
            Return rep
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String) As Integer
        Try
            If Not Descripcion = "" Then
                Coleccion.GetMulti(HC.TipoMovimientoAlmacenFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            Else
                Coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.TipoMovimientoAlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
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
                filtro.Add(HC.TipoMovimientoAlmacenFields.Estatus = FcEstatus)
            End If

            If Not fcdireccion = CondicionDireccionEnum.TODAS Then
                filtro.Add(HC.TipoMovimientoAlmacenFields.Direccion = fcdireccion)
            End If

            Coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.TipoMovimientoAlmacenFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

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