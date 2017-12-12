Public Class _398CatPersonalFrm

    Private Sub _398CatPersonalFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = "000100011"
            MtbEstados.StateCancelar = "000100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "000100011"
            MtbEstados.StateBorrar = "000100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Limpiar()
        Me.TxtCodigo.Clear()
        Me.DtpFechaAlta.Value = Now
        Me.txtAPaterno.Clear()
        Me.TxtAMaterno.Clear()
        Me.txtNombre.Clear()
        Me.CmbDepartamento.SelectedIndex = -1
        Me.CmbDepartamento.Text = "Seleccione un Departamento"
        Me.CmbStatus.SelectedIndex = -1
        Me.CmbStatus.Text = "Seleccione un Status"
        Me.CmbPuesto.SelectedIndex = -1
        Me.CmbPuesto.Text = "Seleccione un Pues"
        Me.DtpFechaNac.Value = Now
        Me.TxtCurp.Clear()
        Me.TxtRFC.Clear()
        Me.TxtNSS.Clear()
    End Sub
    Private Sub Habilitar()
        Me.DtpFechaAlta.Enabled = True
        Me.txtAPaterno.Enabled = True
        Me.TxtAMaterno.Enabled = True
        Me.txtNombre.Enabled = True
        Me.CmbDepartamento.Enabled = True
        Me.CmbStatus.Enabled = True
        Me.CmbPuesto.Enabled = True
        Me.DtpFechaNac.Enabled = True
        Me.TxtCurp.Enabled = True
        Me.TxtRFC.Enabled = True
        Me.TxtNSS.Enabled = True
    End Sub
    Private Sub Deshabilitar()
        Me.DtpFechaAlta.Enabled = False
        Me.txtAPaterno.Enabled = False
        Me.TxtAMaterno.Enabled = False
        Me.txtNombre.Enabled = False
        Me.CmbDepartamento.Enabled = False
        Me.CmbStatus.Enabled = False
        Me.CmbPuesto.Enabled = False
        Me.DtpFechaNac.Enabled = False
        Me.TxtCurp.Enabled = False
        Me.TxtRFC.Enabled = False
        Me.TxtNSS.Enabled = False
    End Sub
End Class