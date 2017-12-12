Public Class FrmNomImpuestosyDeducciones

    Private Sub FrmNomImpuestosyDeducciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = MdiParent.Icon
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001101111"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100011"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "100100011"
        tbEstados.StateBorrar = "100100011"
        tbEstados.StateEditar = "001011001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        Me.mtb.ToolBarButtonStatus = tbEstados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")
        Deshabilitar()
    End Sub
#Region "Metodos"
    Sub Limpiar()
        Me.txtCodigo.Text = 0
        Me.txtDescripcion.Text = ""
        Me.dgDistribucion = Nothing
    End Sub
    Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.dgDistribucion.Enabled = True
    End Sub
    Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.dgDistribucion.Enabled = False
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Habilitar()
        Limpiar()
    End Sub
#End Region

    
End Class