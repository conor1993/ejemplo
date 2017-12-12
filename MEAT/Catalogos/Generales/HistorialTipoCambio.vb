Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CN = ClasesNegocio
Imports ClasesNegocio

Public Class HistorialTipoCambio

#Region " Declaraciones "

    Private TipoCambio As ClasesNegocio.TipoCambioClass
    Private TipoMoneda As ClasesNegocio.TipoMonedaClass

#End Region

#Region " Forma "
    Private Sub TipoCambioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblTitulo.Text = Me.Text.ToUpper
            RellenarTiposMoneda()
            Lectura()
            Limpiar()
            AddHandler txtTipoMoneda.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al cargar la ventana", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

#Region " Rellenar "

    Private Sub LimpiarTiposMoneda()
        txtTipoMoneda.Clear()
        cmbTipoMoneda.SelectedIndex = -1
        cmbTipoMoneda.Text = "Seleccione un Tipo de Moneda..."
    End Sub

    Private Sub RellenarTiposMoneda()
        TiposMoneda.Obtener(CondicionEnum.ACTIVOS, True)
        txtTipoMoneda.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtTipoMoneda.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtTipoMoneda.AutoCompleteCustomSource.AddRange(TiposMoneda.Listar)
    End Sub

    Private Sub txtTipoMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMoneda.KeyDown, cmbTipoMoneda.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                TiposMoneda.Obtener(CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtTipoMoneda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMoneda.TextChanged
        If IsNumeric(txtTipoMoneda.Text) Then
            cmbTipoMoneda.SelectedValue = CInt(txtTipoMoneda.Text)
        Else
            cmbTipoMoneda.SelectedIndex = -1
            cmbTipoMoneda.Text = "Seleccione la Moneda"
        End If
    End Sub

#End Region

#Region " Metodos "
    Private Sub Escritura()
        gpo.Enabled = False
        grpFechas.Enabled = False
    End Sub

    Private Sub Lectura()
        gpo.Enabled = True
        grpFechas.Enabled = True
    End Sub

    Private Sub Limpiar()
        txtTipoMoneda.Clear()
        cmbTipoMoneda.SelectedIndex = -1
        cmbTipoMoneda.Text = "Seleccione la Moneda"

        chkFecha.Checked = False
        Me.dtFechaIni.Enabled = False
        Me.dtFechaFin.Enabled = False
        Me.dtFechaIni.Value = Now.Date
        Me.dtFechaFin.Value = Now.Date

        If dgv.SelectedRows.Count > 0 Then
            dgv.SelectedRows(0).Selected = False
        End If
    End Sub

#End Region

    Private Sub cmbTipoMoneda_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoMoneda.SelectionChangeCommitted
        If cmbTipoMoneda.SelectedIndex > -1 Then
            txtTipoMoneda.Text = cmbTipoMoneda.SelectedValue.ToString
            ObtenerTiposCambio()
        End If
    End Sub

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        Me.dtFechaIni.Enabled = chkFecha.Checked
        Me.dtFechaFin.Enabled = chkFecha.Checked
    End Sub

    Private Sub ObtenerTiposCambio()
        If chkFecha.Checked Then
            If cmbTipoMoneda.SelectedItem Is Nothing Then
                TiposCambio.Obtener(Me.dtFechaIni.Value, Me.dtFechaFin.Value)
            Else
                TiposCambio.Obtener(CType(cmbTipoMoneda.SelectedItem, TipoMonedaClass).Codigo, Me.dtFechaIni.Value, Me.dtFechaFin.Value)
            End If
        Else
            Dim Moneda As TipoMonedaClass = Nothing

            If cmbTipoMoneda.SelectedItem IsNot Nothing Then
                Moneda = CType(cmbTipoMoneda.SelectedItem, TipoMonedaClass)
            End If
            TiposCambio.Obtener(Moneda)
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        ObtenerTiposCambio()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean)
        Limpiar()
        Escritura()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        If TiposCambio Is Nothing OrElse TiposCambio.Count = 0 Then
            MessageBox.Show("No hay informacion", Controlador.Sesion.MiEmpresa.Empnom)
        Else
            Controlador.ReporteHistorialDeTiposCambio(TiposCambio)
        End If
    End Sub

#Region " DataGrid "

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

#End Region

End Class