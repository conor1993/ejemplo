Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CN = ClasesNegocio

Public Class CostosIndirectosCollectionClass
    Inherits CollectionClass(Of CostosIndirectosClass)

    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Private col As CC.CostoIndirectoCollection

    'Public Function Obtener() As Integer
    '    Try
    '        Me.ClearItems()
    '        Dim Conteo As Integer = col.GetDbCount()
    '        If Conteo > 0 Then
    '            col.GetMulti(Nothing)
    '            For Each entidad As EC.CostoIndirectoEntity In col
    '                Dim costoentidad As New CostosIndirectosClass
    '                costoentidad.LeerEntidad(entidad)
    '                If costoentidad.Estatus = EstatusEnum.Activo Then
    '                    Me.Add(costoentidad)
    '                Else
    '                    Me.Add(costoentidad)
    '                End If
    '            Next
    '        End If
    '        Return Conteo
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return -1
    '    End Try
    'End Function

    'Public Function Obtener(ByVal Codigo As Integer, ByVal Descripcion As String) As Integer
    '    col = New CC.CostoIndirectoCollection
    '    Try
    '        Me.ClearItems()
    '        Dim Todos As Boolean = False
    '        Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    '        If Not Codigo <= 0 Then
    '            Filtro.Add(HC.CostoIndirectoFields.Codigo = Codigo)
    '            Todos = True
    '        End If
    '        If Descripcion <> "" Then
    '            Filtro.AddWithAnd(HC.CostoIndirectoFields.Descripcion Mod ("%" & Descripcion & "%"))
    '            Todos = True
    '        End If


    '        Dim Conteo As Integer = col.GetDbCount(Filtro)
    '        If Conteo > 0 Then
    '            If Todos = False Then
    '                col.GetMulti(Nothing)
    '            End If
    '            If Todos = True Then
    '                col.GetMulti(Filtro)
    '            End If
    '            For Each CostoIndirectoEntity As EC.CostoIndirectoEntity In col
    '                Dim MiCI As New CostosIndirectosClass
    '                MiCI.LeerEntidad(CostoIndirectoEntity)
    '                Me.Add(MiCI)
    '            Next
    '        End If
    '        Return Conteo
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return -1
    '    End Try
    'End Function

    Public Function Optener(ByVal Descripcion As String, ByVal DescripcionCorta As String) As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = col.GetDbCount()
            If Conteo > 0 Then
                col.GetMulti((HC.CostoIndirectoFields.Descripcion Mod ("%" & Descripcion & "%")) Or (HC.CostoIndirectoFields.Descripcion Mod ("%" & DescripcionCorta & "%")))
                For Each entidad As EC.CostoIndirectoEntity In col
                    Dim costoentidad As New CostosIndirectosClass
                    costoentidad.LeerEntidad(entidad)
                    Me.Add(costoentidad)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Optener(ByVal Codigo As Integer) As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = col.GetDbCount()
            If Conteo > 0 Then
                col.GetMulti(HC.CostoIndirectoFields.Codigo = Codigo)
                For Each entidad As EC.CostoIndirectoEntity In col
                    Dim costoentidad As New CostosIndirectosClass
                    costoentidad.LeerEntidad(entidad)
                    Me.Add(costoentidad)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            MsgBox(ex.Message)
            Return -1
        End Try
    End Function

    Public Sub New()
        col = New CC.CostoIndirectoCollection
    End Sub

    Public Function Reporte() As rptABCCostosIndirectos
        Dim rpt As New rptABCCostosIndirectos
        Dim ds As New DataSet
        Dim dtCostosIndirectos As New DSCostoIndirecto.dsCostoIndirectoDataTable
        For Each CI As CostosIndirectosClass In Me
            dtCostosIndirectos.AdddsCostoIndirectoRow(CI.IDCostosIndirectos, CI.Descripcion, CI.DescripcionCorta, CI.CuentaMayor, CI.CuentaS, CI.CuentaSS, CI.CuentaSSS, CI.DescripcionCuenta, CI.Estatus)
        Next
        ds.Tables.Add(dtCostosIndirectos)
        rpt.SetDataSource(ds)
        Return rpt
    End Function

End Class
