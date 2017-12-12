Imports ClasesNegocio
Imports System.Windows.Forms

Public Class frmSeleccionConfiguracionFactura

    Public ReadOnly Property ConfiguracionSeleccionada() As ConfiguracionFacturaClass
        Get
            Return CType(Me.lsbConfiguraciones.SelectedItem, ConfiguracionFacturaClass)
        End Get
    End Property

    Private Sub frmSeleccionConfiguracionFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Controlador.Configuracion.ActualizarVenta()
            lsbConfiguraciones.DataSource = Controlador.Configuracion.Venta
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsbConfiguraciones_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lsbConfiguraciones.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.Configuracion.ActualizarVenta()
            lsbConfiguraciones.DataSource = Controlador.Configuracion.Venta
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.lsbConfiguraciones.SelectedIndex > -1 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Debe seleccionar una configuración", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
End Class
