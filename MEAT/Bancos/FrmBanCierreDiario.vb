Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses

Public Class FrmBanCierreDiario

    Private Sub FrmBanCierreDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ColConfiguracionConta As New CC.UsrConfigContabilidadCollection

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Nuevo")

            ColConfiguracionConta.GetMulti(Nothing, 0, Nothing)
            Me.dtpFechaUltimoCierre.Value = ColConfiguracionConta.Items.Item(0).FechaCierreDiarioBanco

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Dim ConfigConta As New CN.ConfiguracionContableClass
            ConfigConta.FechaCierreBanco = Me.DtpFechadeCierre.Value

            If ConfigConta.Guardar1() Then
                MessageBox.Show("Se guardo cierre diario de banco", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se guardo cierre diario de banco", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Limpiar()
        Me.DtpFechadeCierre.Value = Now        
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class