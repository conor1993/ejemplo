Imports IC = Integra.Clases
Imports EC = IntegraLab.ORM.EntityClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel

Public Class CabBalanceCollectionClass
    Inherits ColleccionBase(Of EC.CabBalanceEntity, CC.CabBalanceCollection, CabBalanceClass)

    Public Overloads Function Obtener(Optional ByVal Rubro As String = "", Optional ByVal Descripcion As String = "") As Integer
        Try
            Me.Clear()
            Dim Filtro As New SC.PredicateExpression

            If Not Rubro = "" Then
                Filtro.Add(HC.CabBalanceFields.CveBalance Mod String.Format("%{0}%", Rubro))
            End If

            If Not Descripcion = "" Then
                Filtro.Add(HC.CabBalanceFields.NomBalance Mod String.Format("%{0}%", Descripcion))
            End If

            coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Sub Imprimir(ByVal Sesion As ECS.SesionesEntity, ByVal Periodo As String)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptBalanceGeneral
        Dim ds As New DataSet
        Dim dt As New dsRptBalanceGeneral.BalanceGeneralDataTable

        For Each Balance As CabBalanceClass In Me.Items
            'dt.AddBalanceGeneralRow(Balance.IdBalance, Balance.Nombre, IIf(Balance.Agrupador.EsActivo, "ACTIVO", "PASIVO"), Balance.Agrupador.Descripcion, Balance.Saldo)
        Next
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Balance General")
        Reporte.SetParameterValue(3, Periodo)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub
End Class