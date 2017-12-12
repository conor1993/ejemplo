Imports ClasesNegocio
Public Class FrmRegistroSacrificioGanadero


    Private Sub FrmRegistroSacrificioGanadero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
#Region "Metodos"
    Public Function Limpiar() As Boolean
        Me.txtCantCabezas.Text = 0
        Me.txtCantCabezasCalsificadas.Text = 0
        Me.txtCantCabezasEnmantadas.Text = 0
        Me.txtImpteClasificacion.Text = 0
        Me.txtImpteEnmantado.Text = 0
        Me.txtImpteSacrificio.Text = 0
        Me.txtKilosCalientes.Text = 0
        Me.txtKilosEnPie.Text = 0
        Me.txtRendimiento.Text = 0
        Me.cmbRastro.SelectedValue = -1
        Me.dtpFecha.Value = Now
        Me.lblEstatus.Visible = False
    End Function
    Public Function Deshabilitar() As Boolean
        Me.txtCantCabezas.Enabled = False
        Me.txtCantCabezasCalsificadas.Enabled = False
        Me.txtCantCabezasEnmantadas.Enabled = False
        Me.txtImpteClasificacion.Enabled = False
        Me.txtImpteEnmantado.Enabled = False
        Me.txtImpteSacrificio.Enabled = False
        Me.txtKilosCalientes.Enabled = False
        Me.txtKilosEnPie.Enabled = False
        Me.txtRendimiento.Enabled = False
        Me.cmbRastro.Enabled = False
        Me.dtpFecha.Enabled = False
    End Function
    Public Function Habilitar() As Boolean
        Me.txtCantCabezas.Enabled = True
        Me.txtCantCabezasCalsificadas.Enabled = True
        Me.txtCantCabezasEnmantadas.Enabled = True
        Me.txtImpteClasificacion.Enabled = True
        Me.txtImpteEnmantado.Enabled = True
        Me.txtImpteSacrificio.Enabled = True
        Me.txtKilosCalientes.Enabled = True
        Me.txtKilosEnPie.Enabled = True
        Me.txtRendimiento.Enabled = True
        Me.cmbRastro.Enabled = True
    End Function
    Public Function Guardar() As Boolean
       
    End Function
    Public Function PonerDatos() As Boolean
       
    End Function
    Public Function Validar() As Boolean
        Try
            If Me.txtCantCabezas.Text = 0 Then
                MessageBox.Show("Especifique nombre de introductor", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.txtCantCabezas.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

End Class