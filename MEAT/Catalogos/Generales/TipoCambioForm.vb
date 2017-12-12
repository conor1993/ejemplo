Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CN = ClasesNegocio
Imports ClasesNegocio

Public Class TipoCambioForm

#Region " Declaraciones "

    Private TipoCambio As ClasesNegocio.TipoCambioClass
    Private TipoMoneda As ClasesNegocio.TipoMonedaClass

#End Region

#Region " Forma "
    Private Sub TipoCambioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblTitulo.Text = Me.Text.ToUpper
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "001001101"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "010100001"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "010100001"
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados

            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Tipo de Cambio."
            Me.mtb.Buttons(6).ToolTipText = "Guarda el Tipo de Cambio o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Tipo de Cambio."
            Me.mtb.Buttons(10).ToolTipText = "Imprime el Tipo de Cambio Registrados."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
            mtb.sbCambiarEstadoBotones("Cancelar")

            RellenarTiposMoneda()
            Lectura()
            Limpiar()
            AddHandler txtTipoMoneda.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
            AddHandler txtTipoCambio.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
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

    Private Sub cmbTipoMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoMoneda.SelectedIndexChanged
        If cmbTipoMoneda.SelectedIndex > -1 Then
            txtTipoMoneda.Text = cmbTipoMoneda.SelectedValue
            ObtenerTiposCambio()
        End If
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
        txtTipoCambio.Enabled = True
        gpo.Enabled = False
        grpFechas.Enabled = False
        Me.dtFechaAlta.Enabled = True
    End Sub

    Private Sub Lectura()
        txtTipoCambio.Enabled = False
        gpo.Enabled = True
        grpFechas.Enabled = True
        Me.dtFechaAlta.Enabled = False
    End Sub

    Private Sub Limpiar()
        txtTipoMoneda.Clear()
        cmbTipoMoneda.SelectedIndex = -1
        cmbTipoMoneda.Text = "Seleccione la Moneda"

        Me.txtTipoCambio.Text = "0"
        Me.dtFechaIni.Value = Now.Date
        Me.dtFechaFin.Value = Now.Date
        Me.dtFechaAlta.Value = Now.Date

        ObtenerTiposCambio()

        If dgv.SelectedRows.Count > 0 Then
            dgv.SelectedRows(0).Selected = False
        End If
    End Sub

#End Region

    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        ObtenerTiposCambio()
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

    Private Sub mtb_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar
        Dim fecha As New Integralab.ORM.CollectionClasses.TipoCambioCollection

        If cmbTipoMoneda.SelectedItem Is Nothing Then
            MsgBox("Debe Seleccionar el Tipo de Moneda", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
            Exit Sub
        ElseIf Not IsNumeric(Me.txtTipoCambio.Text.Trim) Then
            MsgBox("Debe establecer un tipo de cambio valido", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
            Exit Sub
        End If

        For i As Integer = 0 To Me.dgv.Rows.Count - 1
            If Me.dtFechaAlta.Value.ToShortDateString = (dgv.Rows(i).Cells(clmFecha.Index).Value) Then
                MsgBox("Ya existe un tipo de cambio con la misma Fecha Especificada", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Cancelar = True
                Exit Sub
            End If
        Next
        CType(cmbTipoMoneda.SelectedItem, TipoMonedaClass).GuardarTipoCambio(CDec(txtTipoCambio.Text), dtFechaAlta.Value.ToShortDateString)
        Limpiar()
        Lectura()
        mtb.sbCambiarEstadoBotones("Cancelar")
        ObtenerTiposCambio()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Cancelar = True

        If Not IsNothing(TipoCambio) Then
            Cancelar = False
            txtTipoCambio.Enabled = True
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Lectura()
        TipoCambio = Nothing
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

#Region " DataGrid "

    Private Sub dgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex > -1 Then
            If mtb.CurrentToolBarButtonStatus <> MEAToolBar.MEAToolBar.ToolBarButtonEnum.Nuevo Then
                TipoCambio = Nothing
                TipoCambio = CType(CType(sender, DataGridView).Rows(e.RowIndex).DataBoundItem, TipoCambioClass)

                If Not IsNothing(TipoCambio) Then
                    mtb.sbCambiarEstadoBotones("Buscar")
                    txtTipoCambio.Text = TipoCambio.TipoCambio.ToString("C")
                    cmbTipoMoneda.SelectedValue = TipoCambio.TipoMoneda.Codigo
                    Me.dtFechaAlta.Value = TipoCambio.Fecha
                    txtTipoCambio.Enabled = False
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaIni.ValueChanged
        ObtenerTiposCambio()
    End Sub

    Private Sub dtFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFechaFin.ValueChanged
        ObtenerTiposCambio()
    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
    End Sub

End Class