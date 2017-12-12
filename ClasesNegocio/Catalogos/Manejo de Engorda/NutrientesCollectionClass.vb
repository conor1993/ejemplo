Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class NutrientesCollectionClass
    Inherits ColleccionBase(Of EC.CatNutrientesEntity, CC.CatNutrientesCollection, NutrienteClass)

#Region "Metodos"
    Public Shared Sub Imprimir(ByVal NomEmpresa As String, ByVal NomUsuario As String, Optional ByVal Filtro As OC.IPredicate = Nothing)
        Dim Reporte As New RptNutrientes()
        Dim vent As New PreVisualizarForm

        Try
            Dim Nutrientes As DataTable = CC.CatNutrientesCollection.GetMultiAsDataTable(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatNutrientesFields.NomNutriente, OC.SortOperator.Ascending)))
            Nutrientes.Columns.Add("DescripcionUnidad", Type.GetType("System.String"))

            If Not Nutrientes.Rows.Count > 0 Then
                MsgBox("No se enconto ningun Nutriente", MsgBoxStyle.Information, "No hay Informacion")
                Exit Sub
            End If

            For Each Item As DataRow In Nutrientes.Rows
                Item.Item("DescripcionUnidad") = UnidadesMedidaClass.CargarUnidadMedida(Integer.Parse(Item.Item("Unidad").ToString())).Descripcion

                If Item.Item("Estatus").ToString() = "1" Then
                    Item.Item("Estatus") = "ACTIVO"
                Else
                    Item.Item("Estatus") = "INACTIVO"
                End If
            Next

            Reporte.SetDataSource(CType(Nutrientes, Object))
            vent.Text = "Recepcion de Pesadas"
            Reporte.SetParameterValue(0, NomEmpresa)
            Reporte.SetParameterValue(1, NomUsuario)
            Reporte.SetParameterValue(2, "Catalogos/Manejo de Ganado/Nutrientes")
            vent.Reporte = Reporte
            vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            vent.WindowState = Windows.Forms.FormWindowState.Maximized
            vent.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Shared Function CargarNutrientes(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Coleccion As New CC.CatNutrientesCollection()

        Try
            Coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatNutrientesFields.NomNutriente, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Coleccion.GetList()
    End Function
#End Region

End Class
