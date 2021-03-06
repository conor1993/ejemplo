Imports TC = IntegraLab.ORM.TypedViewClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CN = ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class _960BusquasedaLotesDeCortes
    Dim Introductores As New CN.ClientesIntroductoresColeccion

    Private Sub _960BusquedaLotesDeCortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim AuxCli As New CN.ClientesIntroductoresClass
            AuxCli.Nombre = "TODOS"
            Introductores.Add(AuxCli)

            Dim AuxCol As New CN.ClientesIntroductoresColeccion
            AuxCol.Obtener(True)

            For Each Introductor As CN.ClientesIntroductoresClass In AuxCol
                Introductores.Add(Introductor)
            Next

            Me.CmbIntroductor.DisplayMember = "Nombre"
            Me.CmbIntroductor.ValueMember = "Codigo"
            Me.CmbIntroductor.DataSource = Introductores
            Me.CmbIntroductor.SelectedIndex = 0

            'Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Buscar()
        Try
            'Dim query As String = "SELECT  dbo.MSCLoteCortesCab.LoteCorte, dbo.MSCLoteCortesCab.LoteSacrificio, dbo.MSCLoteCortesCab.FechaCorte, dbo.MSCLoteCortesCab.IdCliente, " &
            '          " ISNULL(dbo.MFacCatClientes.Nombre, '') AS Introductor, dbo.MSCLoteCortesCab.TotalKgs, " &
            '          " CASE dbo.MSCLoteCortesCab.Estatus WHEN 'A' THEN 'ABIERTO' WHEN 'C' THEN 'CERRADO' WHEN 'X' THEN 'CANCELADO' END AS EstatusCad, " &
            '          " dbo.MSCLoteCortesCab.Estatus, dbo.MSCLoteCortesCab.DiasCad, " &
            '          " CASE WHEN dbo.MSCLoteCortesCab.EsReproceso = 1 THEN 'REPROCESO' ELSE 'PRODUCCION' END AS TipoLote, dbo.MSCLoteCortesCab.EsReproceso, " &
            '          " dbo.MSCLoteCortesCab.TotalPzas, MSCLoteCortesCab.Producto, prod.Descripcion, dbo.MSCLoteCortesCab.precioxkilototal, dbo.MSCLoteCortesCab.KilosRecibidos, Nopiezas " &
            '          " FROM	dbo.MSCLoteCortesCab LEFT OUTER JOIN " &
            '          " dbo.MFacCatClientes ON dbo.MSCLoteCortesCab.IdCliente = dbo.MFacCatClientes.IdCliente " &
            '          " left outer join  MSCCatProductos as prod on prod.IdProducto = MSCLoteCortesCab.Producto "

            ''LoteCorte LIKE '%%'
            'query = String.Format(query, Me.txtLoteCorte.Text)
            'Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            'Dim sqlcom As New SqlCommand(query, sqlCon)
            'Dim adp As New SqlDataAdapter(sqlcom)

            'Dim tb As New DataTable

            'sqlCon.Open()
            'adp.Fill(tb)

            'sqlCon.Close()

            'Me.DgvLotes.AutoGenerateColumns = False


            'If DgvLotes.RowCount > 0 Then
            '    Me.DgvLotes.DataSource = tb
            'Else
            '    MessageBox.Show("No existen Lotes de Cortes Abiertos a la fecha especificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

            '----


            Dim Vista As New TC.VwBusquedaLoteCortesTypedView
            Dim Filtro As New OC.PredicateExpression


            If Not Me.txtLoteCorte.Text = "" Then
                Filtro.Add(HC.VwBusquedaLoteCortesFields.LoteCorte Mod String.Format("%{0}%", Me.txtLoteCorte.Text))
            Else
                If Me.CmbIntroductor.SelectedIndex > 0 Then
                    Filtro.Add(HC.VwBusquedaLoteCortesFields.IdCliente = Me.CmbIntroductor.SelectedValue)
                End If

                If Me.chkFecha.Checked Then
                    Filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaLoteCortesFields.FechaCorte, Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
                End If

                If Not (Me.chkCerrado.Checked AndAlso Me.chkVigentes.Checked) Then
                    If Me.chkCerrado.Checked Then
                        Filtro.Add(HC.VwBusquedaLoteCortesFields.Estatus = "C")
                    Else
                        Filtro.Add(HC.VwBusquedaLoteCortesFields.Estatus = "A")
                    End If
                End If

                If Not (Me.chkProduccion.Checked AndAlso Me.chkReproceso.Checked) Then
                    If Me.chkProduccion.Checked Then
                        Filtro.Add(HC.VwBusquedaLoteCortesFields.EsReproceso = 0)
                    Else
                        Filtro.Add(HC.VwBusquedaLoteCortesFields.EsReproceso = 1)
                    End If
                End If
            End If


            Vista.Fill(0, Nothing, False, Filtro)


            If Vista.Count > 0 Then
                Me.DgvLotes.AutoGenerateColumns = False
                Me.DgvLotes.DataSource = Vista
            Else
                MessageBox.Show("No existen Lotes de Cortes Abiertos a la fecha especificada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtLoteCorte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoteCorte.KeyPress
        If Me.txtLoteCorte.Text.Length > 3 Then
            Buscar()
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvLotes.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MessageBox.Show("Seleccione un Lote de Corte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub DgvLotes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvLotes.DoubleClick

        If Me.DgvLotes.SelectedRows.Count > 0 Then
            Dim Estatus As String = DgvLotes.SelectedRows.Item(0).Cells(clmEstatus.Index).Value
            If Estatus <> "C" And Estatus <> "CERRADO" Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("No es posible seleccionar un Lote de Corte que ya ha sido cerrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Else
            MessageBox.Show("Seleccione un Lote de Corte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Me.gbFechas.Enabled = Me.chkFecha.Checked
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkProduccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProduccion.CheckedChanged
        If Not Me.chkProduccion.Checked AndAlso Not Me.chkReproceso.Checked Then
            Me.chkProduccion.Checked = True
            Me.chkReproceso.Checked = True
        End If
    End Sub

    Private Sub chkReproceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReproceso.CheckedChanged
        If Not Me.chkProduccion.Checked AndAlso Not Me.chkReproceso.Checked Then
            Me.chkProduccion.Checked = True
            Me.chkReproceso.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class