Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = INTEGRALAB.orm.StoredProcedureCallerClasses.ActionProcedures

Public Class TipoAlmacenCollectionClass
    Inherits CollectionClass(Of TipoAlmacenClass)

    Private col As CC.TipoAlmacenCollection

    Public Function Obtener(ByVal condicion As CondicionEnum) As Integer
        Try
            Me.Clear()

            If condicion = CondicionEnum.Todos Then
                col.GetMulti(Nothing)
            Else
                col.GetMulti(HC.TipoAlmacenFields.Estatus = condicion)
            End If

            For Each entidad As EC.TipoAlmacenEntity In col
                Dim Tipo As New TipoAlmacenClass
                Tipo.LeerEntidad(entidad)
                Me.Add(Tipo)
            Next

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String, ByVal DescripcionCorta As String, ByVal condicion As CondicionEnum) As Integer
        Try
            Me.Clear()
            Dim num As Integer = 0
            If condicion = CondicionEnum.Todos Then
                col.GetMulti((HC.TipoAlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or (HC.TipoAlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%")))
            Else
                col.GetMulti(((HC.TipoAlmacenFields.Descripcion Mod ("%" & Descripcion & "%")) Or (HC.TipoAlmacenFields.DescripcionCorta Mod ("%" & DescripcionCorta & "%"))) And HC.TipoAlmacenFields.Estatus = condicion)
            End If

            For Each entidad As EC.TipoAlmacenEntity In col
                Dim Tipo As New TipoAlmacenClass
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

    Public Function Obtener(ByVal Codigo As Integer) As Integer
        Try
            Me.Clear()
            Dim num As Integer = 0
            col.GetMulti(HC.TipoAlmacenFields.Codigo = Codigo)
            For Each entidad As EC.TipoAlmacenEntity In col
                Dim Tipo As New TipoAlmacenClass
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

    Public Sub New()
        col = New CC.TipoAlmacenCollection
    End Sub

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As CRepTAlmacen
        Dim Reportes As New CRepTAlmacen
        Dim ds As New DataSet
        Dim dtTalm As New DsetTAlmacen.DtTAlmacenDataTable
        For Each Talm As TipoAlmacenClass In Me
            dtTalm.AddDtTAlmacenRow(Talm.Codigo, Talm.Descripcion, Talm.DescripcionCorta.ToString, Talm.SubAlmacen.ToString, Talm.Estatus.ToString())
        Next
        ds.Tables.Add(dtTalm)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catalogos/Alacenes/Tipos de Almacenes")
        Return Reportes
    End Function

End Class
