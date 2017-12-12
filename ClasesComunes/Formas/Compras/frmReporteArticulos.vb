Imports ClasesNegocio
Imports System.Data.SqlClient

Public Class frmReporteArticulos
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim Previsualizar As New PreVisualizarForm

            'If Me.Prods.Count = 0 Then
            '    Prods.Obtener()
            'End If

            'Previsualizar.Reporte = Prods.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnom)

            Dim Sql As String = "select A.PdIdProducto as Codigo, A.CodigoBarra,  isnull(G.CantidadExistencia,0) as Piezas,A.PdDescripcion as Descripcion, A.PdDescrpcionCorta as DescripcionCorta,B.LNDescripcion as NomLinea,A.PdIdLinea,C.marnombre as NomMarca, D.UMDescCorta as NomUnidadMedida,isnull(E.PrNombre,'') as NomPresentacion,case when A.PdSeAplicaIva = 1 then 'SI' else 'NO' end as AplicaIVA, Case when A.PdSeAplicaIva = 1 then (Select top 1 IVA from usrConfigContabilidad) else 0 end as IVA, A.PorcIEPS as IEPS,isnull(A.UltimoCosto,0) as Costo,CAST(isnull(A.UltimoCosto,0) * Case when A.PdSeAplicaIva = 1 THEN ((Select top 1 IVA from usrConfigContabilidad)/100) ELSE 0 END as decimal(16,2)) as IvaCosto,CAST(isnull(A.UltimoCosto,0) * ((A.PorcIEPS)/100) as decimal(16,2)) as IepsCosto,  CAST(((isnull(A.UltimoCosto,0)) + (isnull(A.UltimoCosto,0) * ((Select top 1 IVA from usrConfigContabilidad)/100)) + (isnull(A.UltimoCosto,0) * ((A.PorcIEPS)/100))) as decimal(16,2)) as CostoImp,CAST(((isnull(F.LPDPrecioVentaC,0))/(1 +((Select top 1 IVA from usrConfigContabilidad)+A.PorcIEPS)/100) ) as decimal(16,2)) as PrecioSinImp   ,CAST(((isnull(F.LPDPrecioVentaC,0))/(1 +((Select top 1 IVA from usrConfigContabilidad)+A.PorcIEPS)/100) ) * Case when A.PdSeAplicaIva = 1 THEN ((Select top 1 IVA from usrConfigContabilidad)/100) ELSE 0 END as decimal(16,2)) as IvaPrecio,CAST(((isnull(F.LPDPrecioVentaC,0))/(1 +((Select top 1 IVA from usrConfigContabilidad)+A.PorcIEPS)/100) ) * (A.PorcIEPS/100) as decimal(16,2)) as IepsPrecio ,isnull(F.LPDPrecioVentaC,0) as PrecioConImp, Case when A.PdEsKit = 1  then 'SI' else 'NO' end as Kit from MCatCompProductos A" &
            " left join MCatCompLineas B on B.LNIdLinea = A.PdIdLinea left join MCatGenMarcas C on C.maridMarca = A.PdIdMarca left join MCatCompUnidadMedida D on D.UMIdUnidadMedida = A.PdIdUnidadMedida left join MCatCompPresentacion E on E.PrIdPresentacion = A.PdIdPresentacion left join MCatVtasListasPreciosDet F on F.LPdIdProducto = A.PdIdProducto" &
            " left join (SELECT * FROM( select ProductoId,Año,Mes,CantidadExistencia,ROW_NUMBER() OVER (PARTITION BY Almacenid,productoid ORDER BY Almacenid,productoid,Año desc,Mes desc ) as Renglon from MInvAlmacen ) as  X WHERE Renglon = 1 ) G on G.ProductoId = A.PdIdProducto " &
            " where A.PdEstatus = 1 " &
            IIf(cmbFamilia.SelectedValue <> 0, " and  A.PdIdLinea = " & cmbFamilia.SelectedValue.ToString(), " ") &
            " order by " & IIf(Not rbDescripcion.Checked, "A.CodigoBarra", "A.PdDescripcion")

            Dim cmd As New SqlClient.SqlCommand(Sql, New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString.ToString))
            cmd.CommandType = CommandType.Text
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.SelectCommand.CommandTimeout = 1500
            'Fill the dataset'
            Dim ds As New DataSet
            adapter.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim Rep As New ClasesNegocio.RptProductoComando
                Rep.SetDataSource(ds.Tables(0))
                Rep.SetParameterValue(0, Controlador.Empresa.Nombre)
                Rep.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnom)
                Rep.SetParameterValue(2, "Catálogos/Compras Generales/Productos")
                Previsualizar.Reporte = Rep
                Windows.Forms.Cursor.Current = Cursors.Default
                'Previsualizar.Reporte = Prods
                Previsualizar.ShowDialog()
            Else
                MessageBox.Show("No se encontraron resultados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        cmbFamilia.SelectedValue = 0
        rbDescripcion.Checked = True
    End Sub

    Private Sub frmResporteArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim lineas As New ClasesNegocio.LineaCollectionClass
        lineas.Obtener(CondicionEnum.ACTIVOS)
        cmbFamilia.DisplayMember = "Descripcion"
        cmbFamilia.ValueMember = "Codigo"
        Dim linea As New ClasesNegocio.LineaClass
        linea.Codigo = 0
        linea.Descripcion = "< TODAS LAS FAMILIAS >"
        lineas.Add(linea)
        cmbFamilia.DataSource = lineas
        cmbFamilia.SelectedValue = 0
    End Sub
End Class