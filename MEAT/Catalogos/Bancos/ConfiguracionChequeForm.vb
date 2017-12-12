Imports CN = ClasesNegocio
Imports System.Runtime.InteropServices
Imports Integra.Clases

Public Class ConfiguracionChequeForm
    Implements InterfaceForm

#Region " Forma "
    Private Sub ConfiguracionChequeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
        Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
        Me.mtb.Buttons(6).ToolTipText = "Guarda La configuración."
        Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Configuración."
        Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        RellenarBancos()
        Lectura()
        LimpiarBancos()
    End Sub
#End Region

#Region " Rellenar "
    Private Cuentas As New CN.CuentaCollectionClass
    Private Cuenta As CN.CuentaClass

    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
        Me.txtCuenta.Clear()
        lv.Items.Clear()
    End Sub
    Private Sub RellenarBancos()
        Bancos.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(Bancos.Listar)
    End Sub
    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = Me.cmbBanco.SelectedValue
            Dim banco As CN.BancosClass = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuentas.Obtener(banco.Codigo, ClasesNegocio.EstatusEnum.ACTIVO)
            RellenarCuentas()
        End If
    End Sub
    Private Sub txtBanco_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged, txtCuenta.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub
    Private Sub RellenarCuentas()
        lv.Items.Clear()
        For Each cta As CN.CuentaClass In Cuentas
            Dim lvi As New ListViewItem(cta.Cuenta)
            lvi.Tag = cta
            Dim lvsi As New ListViewItem.ListViewSubItem(lvi, cta.Descripcion)
            Dim lvsi1 As New ListViewItem.ListViewSubItem(lvi, cta.FolioActual)
            lvi.SubItems.Add(lvsi)
            lvi.SubItems.Add(lvsi1)
            Me.lv.Items.Add(lvi)
        Next
    End Sub
    Private Sub lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv.SelectedIndexChanged
        If lv.SelectedItems.Count > 0 Then
            For Each indice As ListViewItem In lv.SelectedItems
                txtCuenta.Text = String.Format("{0} - {1}", indice.SubItems(0).Text, indice.SubItems(1).Text)
                Cuenta = DirectCast(indice.Tag, CN.CuentaClass)
                mtb.sbCambiarEstadoBotones("Buscar")
            Next
        Else
            txtCuenta.Clear()
            Cuenta = Nothing
        End If
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = False
        txtFolioActual.Enabled = True
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = True
        txtFolioActual.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        LimpiarBancos()
        txtFolioActual.Text = 0
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtFolioActual.Text = Cuenta.FolioActual
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False
        If Not Bl Then
            Cadena = Nothing
            Cuenta.FolioActual = txtFolioActual.Valor
        End If
        Return Cadena
    End Function
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Cuenta = Nothing
        Lectura()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Escritura()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True

        If IsNothing(Validar()) Then
            If Cuenta.Guardar() Then
                MsgBox("La configuración ha sido Guardada Satisfactoriamente", MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Lectura()
                Cancelar = False
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

    Private Sub btnCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarpeta.Click
        If Carpeta.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtCarpeta.Text = Carpeta.SelectedPath
        End If
    End Sub

    Private Sub btnImpresora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpresora.Click
        If Impresora.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Impresora.PrinterSettings.IsValid Then
                Dim pd As New PrintDevice(Impresora.PrinterSettings)
                txtImpresora.Text = pd.DeviceName
            End If
        End If
    End Sub
End Class

