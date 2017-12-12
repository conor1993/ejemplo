Imports EC = IntegraLab.ORM.EntityClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MetodoProrrateoCollectionClass
    Inherits ColleccionBase(Of EC.MetodoCabEntity, CC.MetodoCabCollection, MetodoProrrateoClass)

    Public Overloads Function Obtener(ByVal idMetodoProrrateo As Integer) As Integer
        Return Obtener(HC.MetodoCabFields.Codigo = idMetodoProrrateo)
    End Function

    Public Overloads Function Obtener(ByVal descripcion As String) As Integer
        Return Obtener(HC.MetodoCabFields.Descripcion Mod String.Format("%{0}%", descripcion))
    End Function

    Public Shared Sub Imprimir(ByVal Sesion As ECS.SesionesEntity, Optional ByVal Filtro As OC.IPredicate = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New rptMetodosProrrateo
        Dim dsMetodos As New DataSet()
        Dim dtMetodos As New dsRptMetodosProrrateo.MetodosProrrateoDataTable
        Dim MetodosProrrateo As New CC.MetodoDetCollection
        MetodosProrrateo.GetMulti(Filtro)

        If MetodosProrrateo.Count = 0 Then
            Throw New Exception("No se encuentro ningun metodo de prorrateo")
        End If

        For Each Metodo As EC.MetodoDetEntity In MetodosProrrateo
            dtMetodos.AddMetodosProrrateoRow(Metodo.CodMetodo, Metodo.CodCentroCosto, Metodo.MetodoCab.Descripcion, Metodo.CatDeptos.NomDepto, Metodo.Porcentaje)
        Next

        dsMetodos.Tables.Add(dtMetodos)
        Reporte.SetDataSource(dsMetodos)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Procesos Mensuales/Reporte de Diarios de Póliza")
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub
End Class