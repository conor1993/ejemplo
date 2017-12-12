Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses

Public Class ComprasGanadoCollectionClass
    Inherits ColleccionBase(Of EC.CabRegComEntity, CC.CabRegComCollection, CompraGanadoClass)

    Enum TipoImpresion
        Proveedor
        Comisionista
    End Enum

    Public Shared Function Imprimir(ByVal TipoImp As TipoImpresion, _
                    ByVal Session As ECS.SesionesEntity, _
                    Optional ByVal Condicion As OC.PredicateExpression = Nothing, _
                    Optional ByVal dtCabecero As DataTable = Nothing) As Boolean
        Try
            ' Declaraciones generales
            Dim ds As DataSet
            Dim dtDetalle As DataTable = Nothing

            ' Obtencion de datos
            ds = New DataSet()

            If dtCabecero Is Nothing Then
                If Condicion Is Nothing Then
                    dtCabecero = CC.CabRegComCollection.GetMultiAsDataTable(Nothing, _
                                0, New OC.SortExpression(New OC.SortClause(HC.CabRegComFields.FechaCaptura, _
                                OC.SortOperator.Ascending)))
                Else
                    dtCabecero = CC.CabRegComCollection.GetMultiAsDataTable(Condicion, 0, Nothing)
                End If
            End If

            Dim Filtro As New OC.PredicateExpression()

            For Each Row As DataRow In dtCabecero.Rows
                Filtro.AddWithOr(HC.DetRegComFields.FolRecep = Row.Item("FolRecep"))
            Next

            dtDetalle = CC.DetRegComCollection.GetMultiAsDataTable(Filtro, _
                        0, New OC.SortExpression(New OC.SortClause(HC.DetRegComFields.CveRenglon, _
                        OC.SortOperator.Ascending)))
            ds.Tables.Add(dtCabecero)
            ds.Tables.Add(dtDetalle)

            ' Aqui se definen las columnas de Proveedor, Comisionista, TipoGanado, Importe, KilosPromxCabeza y PrecioPromxCabeza
            CompletarEstructuraDataSet(ds)
            LlamarReporte(Session, TipoImp, ds)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ' Se proporiona los datos en el reporte y se llama al reporte correpondiene
    Private Shared Sub LlamarReporte(ByVal Session As ECS.SesionesEntity, ByVal TipoImp As TipoImpresion, ByVal ds As DataSet)
        Dim vent As New PreVisualizarForm

        If TipoImp = TipoImpresion.Proveedor Then
            Dim rep As New CrRptComprasGanado
            rep.SetDataSource(ds)
            vent.Text = "Reporte de Compras de Ganado"
            rep.SetParameterValue(0, "Compras de Ganado/Reportes/De Compras de Ganado")
            rep.SetParameterValue(1, Session.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, Session.MiEmpresa.Empnom)
            vent.Reporte = rep
        ElseIf TipoImp = TipoImpresion.Comisionista Then
            Dim rep As New CrRptComprasGanadoComi
            rep.SetDataSource(ds)
            vent.Text = "Reporte de Compras de Ganado por Comisionistas"
            rep.SetParameterValue(0, "Compras de Ganado/Reportes/De Compras de Ganado por Comisionistas")
            rep.SetParameterValue(1, Session.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, Session.MiEmpresa.Empnom)
            vent.Reporte = rep
        End If
        vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        vent.WindowState = Windows.Forms.FormWindowState.Maximized
        vent.ShowDialog()
    End Sub

    'Aqui se definen las columnas de Proveedor, Comisionista, TipoGanado, Importe, KilosPromxCabeza y PrecioPromxCabeza
    Private Shared Sub CompletarEstructuraDataSet(ByVal ds As DataSet)
        ' Obtener la descripción(Razón Social) del Proveedor
        If Not ds.Tables(0).Columns.Contains("Proveedor") Then
            ds.Tables(0).Columns.Add("Proveedor")

            For Each row As DataRow In ds.Tables(0).Rows
                row.Item("Proveedor") = ProveedorClass.CargarProveedor(row.Item("CveProveGan")).RazonSocial
            Next
        End If

        ' Obtener el Nombre completo del Comisionista
        If Not ds.Tables(0).Columns.Contains("Comisionista") Then
            ds.Tables(0).Columns.Add("Comisionista")

            For Each row As DataRow In ds.Tables(0).Rows
                row.Item("Comisionista") = ComisionistaClass.CargarComisionista(row.Item("CveComiGan")).NombreCompleto
            Next
        End If

        ' Calcular el Importe, el Promedio en Kilos por cabeza, Promedio en Precio por cabeza, y obtener la descripción del Tipo de Ganado
        Dim CampoTipoGanado As Boolean = False
        Dim CampoImporte As Boolean = False
        Dim CampoKilosPromxCabeza As Boolean = False
        Dim CampoPrecioPromxCabeza As Boolean = False

        If Not ds.Tables(1).Columns.Contains("TipoGanado") Then
            ds.Tables(1).Columns.Add("TipoGanado")
            CampoTipoGanado = True
        End If

        If Not ds.Tables(1).Columns.Contains("Importe") Then
            ds.Tables(1).Columns.Add("Importe", Type.GetType("System.Decimal"))
            CampoImporte = True
        End If

        If Not ds.Tables(1).Columns.Contains("KilosPromxCabeza") Then
            ds.Tables(1).Columns.Add("KilosPromxCabeza", Type.GetType("System.Decimal"))
            CampoKilosPromxCabeza = True
        End If

        If Not ds.Tables(1).Columns.Contains("PrecioPromxCabeza") Then
            ds.Tables(1).Columns.Add("PrecioPromxCabeza", Type.GetType("System.Decimal"))
            CampoPrecioPromxCabeza = True
        End If

        For Each row As DataRow In ds.Tables(1).Rows
            If CampoTipoGanado Then
                row.Item("TipoGanado") = TipoGanadoClass.CargarTipoGanado(CInt(row.Item("CveGanado"))).Descripcion
            End If

            If CampoImporte Then
                Dim Importe As Decimal = CDec(row.Item("PrecioXKilo")) * CDec(row.Item("CantKilos"))
                row.Item("Importe") = Importe
            End If

            If CampoKilosPromxCabeza Then
                Dim KilosPromedioxCabeza As Decimal = 0

                If CInt(row.Item("CantCabezas")) <> 0 Then
                    KilosPromedioxCabeza = CDec(row.Item("CantKilos")) / CInt(row.Item("CantCabezas"))
                End If

                row.Item("KilosPromxCabeza") = KilosPromedioxCabeza
            End If

            If CampoPrecioPromxCabeza Then
                Dim PrecioPromedioxCabeza As Decimal = 0

                If CInt(row.Item("CantCabezas")) <> 0 Then
                    PrecioPromedioxCabeza = CDec(row.Item("Importe")) / CInt(row.Item("CantCabezas"))
                End If

                row.Item("PrecioPromxCabeza") = PrecioPromedioxCabeza
            End If
        Next

        ' Especificación de datos dirigidos al reporte
        ds.Tables(0).TableName = "Cabecero"
        ds.Tables(1).TableName = "Detalle"
    End Sub
End Class