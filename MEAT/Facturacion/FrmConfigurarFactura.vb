Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmConfigurarFactura

    Dim Configuracion As New ConfiguracionFacturaClass

    Private Sub FrmConfigurarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Controlador.Configuracion.ActualizarVenta()
        Me.Limpiar()
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Configuracion.Serie = Me.txtSerie.Text
            Configuracion.Campo1X = Me.txtCampo1X.Text
            Configuracion.Campo1Y = Me.txtCampo1Y.Text
            Configuracion.Campo2X = Me.txtCampo2X.Text
            Configuracion.Campo2Y = Me.txtCampo2Y.Text
            Configuracion.DatosClienteCpC = Me.txtDatosClienteCP_C.Text
            Configuracion.DatosClienteCpR = Me.txtDatosClienteCP_R.Text
            Configuracion.Campo3X = Me.txtCampo3X.Text
            Configuracion.Campo3Y = Me.txtCampo3Y.Text
            Configuracion.Campo4X = Me.txtCampo4X.Text
            Configuracion.Campo4Y = Me.txtCampo4Y.Text
            Configuracion.Campo5X = Me.txtCampo5X.Text
            Configuracion.Campo5Y = Me.txtCampo5Y.Text
            Configuracion.Campo6X = Me.txtCampo6X.Text
            Configuracion.Campo6Y = Me.txtCampo6Y.Text
            Configuracion.Campo7X = Me.txtCampo7X.Text
            Configuracion.Campo7Y = Me.txtCampo7Y.Text
            Configuracion.Campo8X = Me.txtCampo8X.Text
            Configuracion.Campo8Y = Me.txtCampo8Y.Text
            Configuracion.Campo9X = Me.txtCampo9X.Text
            Configuracion.Campo9Y = Me.txtCampo9Y.Text
            Configuracion.Campo10X = Me.txtCampo10X.Text
            Configuracion.Campo10Y = Me.txtCampo10Y.Text
            Configuracion.Campo11X = Me.txtCampo11X.Text
            Configuracion.Campo11Y = Me.txtCampo11Y.Text
            Configuracion.Campo12X = Me.txtCampo12X.Text
            Configuracion.Campo12Y = Me.txtCampo12Y.Text
            Configuracion.Campo13X = Me.txtCampo13X.Text
            Configuracion.Campo13Y = Me.txtCampo13Y.Text
            Configuracion.Campo14X = Me.txtCampo14X.Text
            Configuracion.Campo14Y = Me.txtCampo14Y.Text
            Configuracion.Campo15X = Me.txtCampo15X.Text
            Configuracion.Campo15Y = Me.txtCampo15Y.Text
            Configuracion.Campo16X = Me.txtCampo16X.Text
            Configuracion.Campo16Y = Me.txtCampo16Y.Text
            Configuracion.Campo17X = Me.txtCampo17X.Text
            Configuracion.Campo17Y = Me.txtCampo17Y.Text
            Configuracion.Campo18X = Me.txtCampo18X.Text
            Configuracion.Campo18Y = Me.txtCampo18Y.Text
            Configuracion.Campo19X = Me.txtCampo19X.Text
            Configuracion.Campo19Y = Me.txtCampo19Y.Text
            Configuracion.TamañoLetra = Me.txtNumLetra.Text
            Configuracion.Renglones = Me.txtRenglones.Text
            Configuracion.Descripcion = Me.txtDescripcion.Text
            Configuracion.NumeroLetrasXFilaCantidadLetra = Me.txtLetrasPorFilaLeyenda.Text
            Configuracion.NumeroLetrasXFilaDomicilio = Me.txtNumeroLetrasDomicilio.Text
            Configuracion.Entidad.LetrasXrenglonCliente = CInt(Me.txtNumeroLetrasCliente.Text)
            Configuracion.Entidad.LetrasXrenglonDelTotalEnLetraPagare = CInt(Me.txtNumeroLetrasCantidadConLetrasPagare.Text)
            Configuracion.DatosFacturaObsrvC = Me.txtDatosFacturaObsrv_C.Text
            Configuracion.DatosFacturaObsrvR = Me.txtDatosFacturaObsrv_R.Text
            Configuracion.LetrasxRenglonObsrv = Me.txtLetrasPorFilaObsrv.Text
            Configuracion.DatosFacturaReferenciaC = Me.txtRefEmbarque_C.Text
            Configuracion.DatosFacturaReferenciaR = Me.txtRefEmbarque_R.Text
            Configuracion.LetrasxRenglonReferencia = Me.txtLetrasPorFilaRefEmb.Text

            If Configuracion.Entidad.IsNew Then
                Configuracion.Entidad.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Else
                Configuracion.Entidad.IdUsuarioUltimaModificacion = Controlador.Sesion.Usrndx
                Configuracion.Entidad.FechaUltimaModificacion = Now
            End If

            If Not Configuracion.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            Trans.Commit()
            Controlador.Configuracion.ActualizarVenta()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show("Error al guardar la configuración de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.txtSerie.Clear()
        Me.txtNumeroLetrasDomicilio.Text = 0
        Me.txtNumeroLetrasCantidadConLetrasPagare.Clear()
        Me.txtNumeroLetrasCliente.Clear()
        Me.txtCampo1X.Text = 0
        Me.txtCampo2X.Text = 0
        Me.txtDatosClienteCP_C.Text = 0
        Me.txtDatosClienteCP_R.Text = 0
        Me.txtCampo3X.Text = 0
        Me.txtCampo4X.Text = 0
        Me.txtCampo5X.Text = 0
        Me.txtCampo6X.Text = 0
        Me.txtCampo7X.Text = 0
        Me.txtCampo8X.Text = 0
        Me.txtCampo9X.Text = 0
        Me.txtCampo10X.Text = 0
        Me.txtCampo11X.Text = 0
        Me.txtCampo12X.Text = 0
        Me.txtCampo13X.Text = 0
        Me.txtCampo14X.Text = 0
        Me.txtCampo15X.Text = 0
        Me.txtCampo16X.Text = 0
        Me.txtCampo17X.Text = 0
        Me.txtCampo18X.Text = 0
        Me.txtCampo19X.Text = 0
        Me.txtCampo1Y.Text = 0
        Me.txtCampo2Y.Text = 0
        Me.txtCampo3Y.Text = 0
        Me.txtCampo4Y.Text = 0
        Me.txtCampo5Y.Text = 0
        Me.txtCampo6Y.Text = 0
        Me.txtCampo7Y.Text = 0
        Me.txtCampo8Y.Text = 0
        Me.txtCampo9Y.Text = 0
        Me.txtCampo10Y.Text = 0
        Me.txtCampo11Y.Text = 0
        Me.txtCampo12Y.Text = 0
        Me.txtCampo13Y.Text = 0
        Me.txtCampo14Y.Text = 0
        Me.txtCampo15Y.Text = 0
        Me.txtCampo16Y.Text = 0
        Me.txtCampo17Y.Text = 0
        Me.txtCampo18Y.Text = 0
        Me.txtCampo19Y.Text = 0
        Me.txtNumeroLetrasCliente.Text = 0
        Me.txtNumeroLetrasCantidadConLetrasPagare.Text = 0
        Me.txtDatosFacturaObsrv_C.Text = 0
        Me.txtDatosFacturaObsrv_R.Text = 0
        Me.txtLetrasPorFilaObsrv.Text = 0
        Me.txtRefEmbarque_C.Text = 0
        Me.txtRefEmbarque_R.Text = 0
        Me.txtLetrasPorFilaRefEmb.Text = 0
        Me.txtRenglones.Text = 0
        Me.txtNumLetra.Text = 0
        Me.txtLetrasPorFilaLeyenda.Text = 0
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.txtDescripcion.Clear()
        Me.cmbConfig.SelectedIndex = -1
        Me.cmbConfig.Text = "Seleccione una configuración"
    End Function

    Private Function ObtenerConfiguracion() As Boolean
        Try
            Me.txtSerie.Text = Configuracion.Serie
            Me.txtNumeroLetrasDomicilio.Text = Configuracion.NumeroLetrasXFilaDomicilio
            Me.txtLetrasPorFilaLeyenda.Text = Configuracion.NumeroLetrasXFilaCantidadLetra
            Me.txtCampo1X.Text = Configuracion.Campo1X
            Me.txtCampo1Y.Text = Configuracion.Campo1Y
            Me.txtCampo2X.Text = Configuracion.Campo2X
            Me.txtCampo2Y.Text = Configuracion.Campo2Y
            Me.txtDatosClienteCP_C.Text = Configuracion.DatosClienteCpC
            Me.txtDatosClienteCP_R.Text = Configuracion.DatosClienteCpR
            Me.txtCampo3X.Text = Configuracion.Campo3X
            Me.txtCampo3Y.Text = Configuracion.Campo3Y
            Me.txtCampo4X.Text = Configuracion.Campo4X
            Me.txtCampo4Y.Text = Configuracion.Campo4Y
            Me.txtCampo5X.Text = Configuracion.Campo5X
            Me.txtCampo5Y.Text = Configuracion.Campo5Y
            Me.txtCampo6X.Text = Configuracion.Campo6X
            Me.txtCampo6Y.Text = Configuracion.Campo6Y
            Me.txtCampo7X.Text = Configuracion.Campo7X
            Me.txtCampo7Y.Text = Configuracion.Campo7Y
            Me.txtCampo8X.Text = Configuracion.Campo8X
            Me.txtCampo8Y.Text = Configuracion.Campo8Y
            Me.txtCampo9X.Text = Configuracion.Campo9X
            Me.txtCampo9Y.Text = Configuracion.Campo9Y
            Me.txtCampo10X.Text = Configuracion.Campo10X
            Me.txtCampo10Y.Text = Configuracion.Campo10Y
            Me.txtCampo11X.Text = Configuracion.Campo11X
            Me.txtCampo11Y.Text = Configuracion.Campo11Y
            Me.txtCampo12X.Text = Configuracion.Campo12X
            Me.txtCampo12Y.Text = Configuracion.Campo12Y
            Me.txtCampo13X.Text = Configuracion.Campo13X
            Me.txtCampo13Y.Text = Configuracion.Campo13Y
            Me.txtCampo14X.Text = Configuracion.Campo14X
            Me.txtCampo14Y.Text = Configuracion.Campo14Y
            Me.txtCampo15X.Text = Configuracion.Campo15X
            Me.txtCampo15Y.Text = Configuracion.Campo15Y
            Me.txtCampo16X.Text = Configuracion.Campo16X
            Me.txtCampo16Y.Text = Configuracion.Campo16Y
            Me.txtCampo17X.Text = Configuracion.Campo17X
            Me.txtCampo17Y.Text = Configuracion.Campo17Y
            Me.txtCampo18X.Text = Configuracion.Campo18X
            Me.txtCampo18Y.Text = Configuracion.Campo18Y
            Me.txtCampo19X.Text = Configuracion.Campo19X
            Me.txtCampo19Y.Text = Configuracion.Campo19Y
            Me.txtRenglones.Text = Configuracion.Renglones
            Me.txtNumLetra.Text = Configuracion.TamañoLetra
            Me.txtDescripcion.Text = Configuracion.Descripcion
            Me.txtNumeroLetrasCantidadConLetrasPagare.Text = Me.Configuracion.Entidad.LetrasXrenglonDelTotalEnLetraPagare
            Me.txtNumeroLetrasCliente.Text = Me.Configuracion.Entidad.LetrasXrenglonCliente
            Me.txtDatosFacturaObsrv_C.Text = Configuracion.DatosFacturaObsrvC
            Me.txtDatosFacturaObsrv_R.Text = Configuracion.DatosFacturaObsrvR
            Me.txtLetrasPorFilaObsrv.Text = Me.Configuracion.LetrasxRenglonObsrv
            Me.txtRefEmbarque_C.Text = Configuracion.DatosFacturaReferenciaC
            Me.txtRefEmbarque_R.Text = Configuracion.DatosFacturaReferenciaR
            Me.txtLetrasPorFilaRefEmb.Text = Configuracion.LetrasxRenglonReferencia
            Return True
        Catch ex As Exception
            MessageBox.Show("Error al consultar la configurción de factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Not Guardar() Then
            MessageBox.Show("No se guardo configuración de facturacion", "Aviso", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Se guardo configuración de facturacion", "Aviso", MessageBoxButtons.OK)
            Me.Limpiar()
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Imp As New EscritorClass(80, 60)
            'Imprimir.DefineHoja(80, 60)
            'cabecero de factura
            Imp.Escribe(Me.Label1.Text, Me.txtCampo1X.Text, Me.txtCampo1Y.Text) ' nombre del cliente
            Imp.Escribe(Me.Label2.Text, Me.txtCampo2X.Text, Me.txtCampo2Y.Text) 'direccion del cliente
            Imp.Escribe(Me.Label2.Text, Me.txtDatosClienteCP_C.Text, Me.txtDatosClienteCP_R.Text) 'codigo postal del cliente
            Imp.Escribe(Me.Label2.Text, Me.txtCampo3X.Text, Me.txtCampo3Y.Text) 'ciudad del cliente
            Imp.Escribe(Me.Label2.Text, Me.txtCampo4X.Text, Me.txtCampo4Y.Text) 'rfc del cliente
            Imp.Escribe(Me.Label2.Text, Me.txtCampo5X.Text, Me.txtCampo5Y.Text) 'fecha de la factura
            ''detalle de factura
            Dim renglon As Byte
            renglon = 13
            For i As Integer = 0 To 3
                Imp.Escribe(Me.Label2.Text, 2, renglon)
                Imp.Escribe(Me.Label2.Text, 12, renglon)
                Imp.Escribe(Me.Label2.Text, 50, renglon)
                Imp.Escribe(Me.Label2.Text, 62, renglon)
                renglon = renglon + 1
            Next
            'total de factura
            Imp.Escribe(Me.Label2.Text, 65, 45)
            Imp.Escribe(Me.Label2.Text, 65, 46)
            Imp.Escribe(Me.Label2.Text, 65, 47)
            Imp.Escribe(Me.Label2.Text, 20, 49)
            Imp.ImprimeA("c:\archivo.txt")
            'Imp.Escribe(Me.txtCantidadEnLetra.Text, Me.txtCampo13X.Text, Me.txtCampo13Y.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = False
        Me.mtb.HabilitarSalir = True
        Me.Configuracion = New ClasesNegocio.ConfiguracionFacturaClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub cmbConfig_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConfig.SelectedIndexChanged
        If Me.cmbConfig.SelectedIndex > -1 Then
            Me.Configuracion.Obtener(Me.cmbConfig.SelectedValue)
            Me.ObtenerConfiguracion()
            Me.mtb.HabilitarBorrar = False
            Me.mtb.HabilitarBuscar = False
            Me.mtb.HabilitarCancelar = False
            Me.mtb.HabilitarEditar = False
            Me.mtb.HabilitarGuardar = True
            Me.mtb.HabilitarImprimir = False
            Me.mtb.HabilitarLimpiar = True
            Me.mtb.HabilitarNuevo = True
            Me.mtb.HabilitarSalir = True
        End If
    End Sub

    Private Sub txtCodigoConfig_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSerie.KeyDown, txtRenglones.KeyDown, txtRefEmbarque_R.KeyDown, txtRefEmbarque_C.KeyDown, txtNumLetra.KeyDown, txtNumeroLetrasDomicilio.KeyDown, txtNumeroLetrasCliente.KeyDown, txtNumeroLetrasCantidadConLetrasPagare.KeyDown, txtLetrasPorFilaRefEmb.KeyDown, txtLetrasPorFilaObsrv.KeyDown, txtLetrasPorFilaLeyenda.KeyDown, txtDescripcion.KeyDown, txtDatosFacturaObsrv_R.KeyDown, txtDatosFacturaObsrv_C.KeyDown, txtDatosClienteCP_R.KeyDown, txtDatosClienteCP_C.KeyDown, txtCodigoConfig.KeyDown, txtCampo9Y.KeyDown, txtCampo9X.KeyDown, txtCampo8Y.KeyDown, txtCampo8X.KeyDown, txtCampo7Y.KeyDown, txtCampo7X.KeyDown, txtCampo6Y.KeyDown, txtCampo6X.KeyDown, txtCampo5Y.KeyDown, txtCampo5X.KeyDown, txtCampo4Y.KeyDown, txtCampo4X.KeyDown, txtCampo3Y.KeyDown, txtCampo3X.KeyDown, txtCampo2Y.KeyDown, txtCampo2X.KeyDown, txtCampo1Y.KeyDown, txtCampo1X.KeyDown, txtCampo19Y.KeyDown, txtCampo19X.KeyDown, txtCampo18Y.KeyDown, txtCampo18X.KeyDown, txtCampo17Y.KeyDown, txtCampo17X.KeyDown, txtCampo16Y.KeyDown, txtCampo16X.KeyDown, txtCampo15Y.KeyDown, txtCampo15X.KeyDown, txtCampo14Y.KeyDown, txtCampo14X.KeyDown, txtCampo13Y.KeyDown, txtCampo13X.KeyDown, txtCampo12Y.KeyDown, txtCampo12X.KeyDown, txtCampo11Y.KeyDown, txtCampo11X.KeyDown, txtCampo10Y.KeyDown, txtCampo10X.KeyDown, cmbConfig.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoConfig_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRenglones.KeyPress, txtRefEmbarque_R.KeyPress, txtRefEmbarque_C.KeyPress, txtNumLetra.KeyPress, txtNumeroLetrasDomicilio.KeyPress, txtNumeroLetrasCliente.KeyPress, txtNumeroLetrasCantidadConLetrasPagare.KeyPress, txtLetrasPorFilaRefEmb.KeyPress, txtLetrasPorFilaObsrv.KeyPress, txtLetrasPorFilaLeyenda.KeyPress, txtDatosFacturaObsrv_R.KeyPress, txtDatosFacturaObsrv_C.KeyPress, txtDatosClienteCP_R.KeyPress, txtDatosClienteCP_C.KeyPress, txtCodigoConfig.KeyPress, txtCampo9Y.KeyPress, txtCampo9X.KeyPress, txtCampo8Y.KeyPress, txtCampo8X.KeyPress, txtCampo7Y.KeyPress, txtCampo7X.KeyPress, txtCampo6Y.KeyPress, txtCampo6X.KeyPress, txtCampo5Y.KeyPress, txtCampo5X.KeyPress, txtCampo4Y.KeyPress, txtCampo4X.KeyPress, txtCampo3Y.KeyPress, txtCampo3X.KeyPress, txtCampo2Y.KeyPress, txtCampo2X.KeyPress, txtCampo1Y.KeyPress, txtCampo1X.KeyPress, txtCampo19Y.KeyPress, txtCampo19X.KeyPress, txtCampo18Y.KeyPress, txtCampo18X.KeyPress, txtCampo17Y.KeyPress, txtCampo17X.KeyPress, txtCampo16Y.KeyPress, txtCampo16X.KeyPress, txtCampo15Y.KeyPress, txtCampo15X.KeyPress, txtCampo14Y.KeyPress, txtCampo14X.KeyPress, txtCampo13Y.KeyPress, txtCampo13X.KeyPress, txtCampo12Y.KeyPress, txtCampo12X.KeyPress, txtCampo11Y.KeyPress, txtCampo11X.KeyPress, txtCampo10Y.KeyPress, txtCampo10X.KeyPress, cmbConfig.KeyPress
        Utilerias.ValidarEntradaNumerosEnteros(sender, e)
    End Sub

End Class