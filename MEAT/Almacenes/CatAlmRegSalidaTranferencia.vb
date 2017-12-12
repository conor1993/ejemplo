Public Class CatAlmRegSalidaTranferencia
    Private Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Private WithEvents Plazas As ClasesNegocio.PlazaCollectionClass

    Private Sub sbLimpiar()
        Me.txtEntrega.Text = ""
        Me.txtFolio.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtRecive.Text = ""
        Me.txtTotal.Text = ""
        Me.cmbAlmacenDestino.SelectedIndex = -1
        Me.cmbAlmacenDestino.Text = "Seleccione un Almacen..."
        Me.cmbAlmacenOrigen.SelectedIndex = -1
        Me.cmbAlmacenOrigen.Text = "Seleccione un Almacen..."
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbPlaza.Text = "Seleccione un Almacen..."
        Me.lblestatus.Text = "Estatus"
        Editar = False
    End Sub

    Private Sub sbEscritura()
        Me.cmbPlaza.Enabled = True
        Me.cmbAlmacenOrigen.Enabled = True
        Me.cmbAlmacenDestino.Enabled = True
        Me.txtEntrega.Enabled = True
        Me.txtFolio.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtRecive.Enabled = True
    End Sub

    Private Sub sbLectura()
        Me.cmbPlaza.Enabled = False
        Me.cmbAlmacenOrigen.Enabled = False
        Me.cmbAlmacenDestino.Enabled = False
        Me.txtEntrega.Enabled = False
        Me.txtFolio.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtRecive.Enabled = False
        Me.txtTotal.Enabled = False
        Me.dtpFecha.Enabled = False
    End Sub

    Private Sub CatAlmRegSalidaTranferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MtbEstados As New MiToolBar.miToolBar.ToolBarButtonStatusStructure

        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""

        mtb.ToolBarButtonStatus = MtbEstados

        mtb.sbCambiarEstadoBotones("Cancelar")
        sbLectura()
        'Plazas
        plazas.Obtener()
        cmbPlaza.DataSource = plazas
        cmbPlaza.DisplayMember = "Descripcion"
        cmbPlaza.ValueMember = "Codigo"
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        MsgBox("El Archivo se a Dado de baja...", MsgBoxStyle.Information, "Aviso")
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        sbEscritura()
        Editar = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Editar Then
            MsgBox("Se an guardados los cambios...", MsgBoxStyle.Information, "Aviso")
            sbLimpiar()
            sbLectura()
            Editar = False
        Else
            MsgBox("Se a guardado el Registro de Salida...", MsgBoxStyle.Information, "Aviso")
            sbLimpiar()
            sbLectura()
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            sbLimpiar()
        Else
            sbLimpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        sbEscritura()
        sbLimpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtFolio.Text = "" Then
                MsgBox("Ingrese el Folio...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.dtpFecha.Focus()
            End If
        End If
    End Sub

    Private Sub txtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrega.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtEntrega.Text = "" Then
                MsgBox("Ingrese quien Entrega...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtRecive.Focus()
            End If
        End If
    End Sub


    Private Sub txtRecive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRecive.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtRecive.Text = "" Then
                MsgBox("Ingrese quien recive...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtObservaciones.Focus()
            End If
        End If
    End Sub

    Private Sub cmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPlaza.KeyPress
        If e.KeyChar = Chr(13) Then
            If cmbPlaza.SelectedIndex = -1 Then
                MsgBox("Seleccione una plaza...", MsgBoxStyle.Information, "Aviso")
            Else
                Me.txtFolio.Focus()
            End If
        End If
    End Sub

    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbAlmacenOrigen.Focus()
        End If
    End Sub

    Private Sub cmbAlmacenOrigen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacenOrigen.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.cmbAlmacenOrigen.SelectedIndex = -1 Then
                MsgBox("Seleccione un Almacen de Origen...", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.cmbAlmacenDestino.Focus()
            End If
        End If
    End Sub

    Private Sub cmbAlmacenDestino_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbAlmacenDestino.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.cmbAlmacenDestino.SelectedIndex = -1 Then
                MsgBox("Seleccione un Almacen de Destino...", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.txtEntrega.Focus()
            End If
        End If
    End Sub
End Class