Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses

Public Class BusquedaPolizasDiario

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim strConsulta As String
        Dim dsPolizas As DataSet
        Dim strCondicion As String = ""

        If Not (Me.chkFechas.Checked) Then
            strCondicion = " and FechaPoliza between '" & Me.DtpFechaIni.Value.ToShortDateString() & "' and '" & Me.DtpFechaFin.Value.ToShortDateString() & "'"
        Else
            strCondicion = ""
        End If

        strConsulta = " select * from usrcontpolizas" & _
                     " where tipopoliza='D'" & _
                     " and ano=" & Me.txtSubCta.Text & _
                     " and mes=" & Me.txtCta.Text & _
                     " and EmpresaId=" & Controlador.Sesion.MiEmpresa.Empndx & _
                      strCondicion
        '" and Estatus=1" & _
        dsPolizas = Utilerias.EjecutarSQL(strConsulta, "Polizas", HC.DbUtils.ActualConnectionString)
        If dsPolizas.Tables(0).Rows.Count > 0 Then
            Me.grid.DataSource = dsPolizas.Tables(0)
        End If
        FormatoGrid()
        Me.grid.Refresh()

    End Sub

    Private Sub FormatoGrid()
        'Mostrar Ocultar Columnas del Grid
        Me.grid.Columns("Codigo").Visible = False
        Me.grid.Columns("EmpresaId").Visible = False
        Me.grid.Columns("TipoPoliza").Visible = False
        Me.grid.Columns("Mes").Visible = False
        Me.grid.Columns("Ano").Visible = False
        Me.grid.Columns("Folio").Visible = False
        Me.grid.Columns("FechaPoliza").Visible = True
        Me.grid.Columns("NumeroPoliza").Visible = True
        Me.grid.Columns("FechaCaptura").Visible = False
        Me.grid.Columns("Importe").Visible = True
        Me.grid.Columns("Concepto").Visible = True
        Me.grid.Columns("Concepto").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.grid.Columns("Origen").Visible = False
        Me.grid.Columns("TipoError").Visible = False
        Me.grid.Columns("Estatus").Visible = False
        Me.grid.Columns("Referencia").Visible = False
        Me.grid.Columns("TipoCambio").Visible = False

        'Modificar el Texto del Encabezado que se muestra de las Columnas
        Me.grid.Columns("FechaPoliza").HeaderText = "Fecha"
        Me.grid.Columns("NumeroPoliza").HeaderText = "Poliza"
        Me.grid.Columns("Importe").HeaderText = "Importe"
        Me.grid.Columns("Concepto").HeaderText = "Concepto"

        'Modificar el ancho de las columnas
        Me.grid.Columns("FechaPoliza").Width = 100
        Me.grid.Columns("NumeroPoliza").Width = 100
        Me.grid.Columns("Importe").Width = 100
        Me.grid.Columns("Concepto").Width = 150

        'Formato del grid y sus columnas
        '   para los valores nulos
        Me.grid.DefaultCellStyle.NullValue = "Sin datos"
        '   para habilitar el ajuste automático de líneas en celdas basadas en texto
        Me.grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Me.grid.Columns("FechaPoliza").DefaultCellStyle.Format = "d"
        Me.grid.Columns("Importe").DefaultCellStyle.Format = "c"

        'para alineacion de las columnas
        Me.grid.Columns("Importe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


    End Sub

    Private Sub BusquedaPolizasDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.LlenarCombo(HC.DbUtils.ActualConnectionString, Me.cmbAño, "Años", "IdAño", "IdAño", Utilerias.TipoOrden.Descendente, "IdAño", "where estatus=" & CN.EstadoRegistro.Activo)
        Utilerias.LlenarCombo(HC.DbUtils.ActualConnectionString, Me.cmbMes, "Meses", "IdMes", "Descripcion", Utilerias.TipoOrden.Ascendente, "IdMes", "where estatus=" & CN.EstadoRegistro.Activo)
        Me.txtSubCta.Text = Me.cmbAño.SelectedValue.ToString()
        Me.txtCta.Text = Me.cmbMes.SelectedValue.ToString()
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMes.SelectedIndexChanged
        Me.txtCta.Text = Me.cmbMes.SelectedValue.ToString()
    End Sub

    Private Sub cmbAño_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAño.SelectedIndexChanged
        Me.txtSubCta.Text = Me.cmbAño.SelectedValue.ToString()
    End Sub

    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        If Me.chkFechas.Checked Then
            Me.DtpFechaIni.Enabled = False
            Me.DtpFechaFin.Enabled = False
        Else
            Me.DtpFechaIni.Enabled = True
            Me.DtpFechaFin.Enabled = True
        End If
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub

    Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        Try
            If Me.grid.SelectedRows.Count > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class