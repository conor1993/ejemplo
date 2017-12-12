Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses

Public Class FrmConfigContabilidad

    Private Sub Limpiar()
        Me.txtFlete.Text = 0
        Me.txtISR.Text = 0
        Me.txtIVA.Text = 0
        Me.txtTasaRetenida.Text = 0
    End Sub

    Private Sub FrmConfigContabilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        Limpiar()
        ObtenerConfiguracion()
        mtb.sbCambiarEstadoBotones("Cancelar")

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

        Dim ConfigConta As New CN.ConfiguracionContableClass
        If Me.rbContrarios.Checked = True Then
            ConfigConta.CancelaPolizaNeg = "N"
        Else
            ConfigConta.CancelaPolizaNeg = "S"
        End If
        ConfigConta.MostrarDomicilio = Me.ChkMostrarDomicilio.Checked
        ConfigConta.PorcISR = CDbl(Me.txtISR.Text)
        ConfigConta.PorcIVA = CDbl(Me.txtIVA.Text)
        ConfigConta.PorcRetencion = CDbl(Me.txtTasaRetenida.Text)
        If ConfigConta.Guardar() Then
            MessageBox.Show("Se guardo configuración de contabilidad", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se guardo configuración de contabilidad", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
    Private Sub ObtenerConfiguracion()
        Try
            Dim tabla As New DataSet
            'If dsConfig.Tables.Count > 0 Then
            ' If dsConfig.Tables("ConfigContable").Rows(0)("cancelacionPolizasNegativos") = "0" Then
            'Me.txtTasaRetenida.Text = CDec(dsConfig.Tables("ConfigContable").Rows(0)("TasaRetencion")).ToString("N2")
            'Me.txtIVA.Text = CDec(dsConfig.Tables("ConfigContable").Rows(0)("IVA")).ToString("N2")
            'Me.txtISR.Text = CDec(dsConfig.Tables("ConfigContable").Rows(0)("ISR")).ToString("N2")
            'Else
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("PaContUsrConfigContabilidad", _
                                    New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.CommandType = CommandType.StoredProcedure
                With ad.SelectCommand.Parameters
                    .Add("@Func", SqlDbType.Char).Value = "C"
                    .Add("@Opcion", SqlDbType.Int).Value = 1
                    .Add("@CancelaPolizaNegativos", SqlDbType.Char).Value = "S"
                    .Add("@IVA", SqlDbType.Money).Value = 0
                    .Add("@ISR", SqlDbType.Money).Value = 0
                    .Add("@TasaRetencion", SqlDbType.Money).Value = 0
                    .Add("@Flete", SqlDbType.Money).Value = 0
                    .Add("@MostrarDomicilio", SqlDbType.Bit).Value = 0
                End With

                ad.SelectCommand.CommandTimeout = 30
                ad.SelectCommand.Connection.Open()
                'ad.SelectCommand.ExecuteReader()
                If ad.Fill(tabla) = 0 Then Exit Sub
                ad.SelectCommand.Connection.Close()
            End Using
            If tabla.Tables.Count > 0 Then
                If tabla.Tables(0).Rows(0)("CancelacionPolizasNegativos") = "N" Then
                    Me.rbContrarios.Checked = True
                    Me.rbNegativos.Checked = False
                Else
                    Me.rbNegativos.Checked = True
                    Me.rbContrarios.Checked = False
                End If
                Me.txtTasaRetenida.Text = CDbl(tabla.Tables(0).Rows(0)("TasaRetencion"))
                Me.txtISR.Text = CDbl(tabla.Tables(0).Rows(0)("ISR"))
                Me.txtIVA.Text = CDbl(tabla.Tables(0).Rows(0)("iva"))
                Me.ChkMostrarDomicilio.Checked = tabla.Tables(0).Rows(0)("MostrarDomicPoliza")
                Me.txtFlete.Text = CDbl(tabla.Tables(0).Rows(0)("IVAFlete"))
            Else
                Me.txtTasaRetenida.Text = "0"
                Me.txtISR.Text = "0"
                Me.txtIVA.Text = "0"
                Me.txtFlete.Text = "0"
                Me.rbContrarios.Checked = False
                Me.rbNegativos.Checked = False
                Me.ChkMostrarDomicilio.Checked = False
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbNegativos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbNegativos.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rbContrarios.Focus()
        End If
    End Sub

    Private Sub rbContrarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rbContrarios.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtIVA.Focus()
        End If
    End Sub

    Private Sub txtIVA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVA.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtISR.Focus()
        End If
    End Sub

    Private Sub txtISR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISR.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTasaRetenida.Focus()
        End If
    End Sub

    Private Sub txtTasaRetenida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTasaRetenida.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.ChkMostrarDomicilio.Focus() 'Me.txtFlete.Focus()
        End If
    End Sub

    Private Sub ChkMostrarDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkMostrarDomicilio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rbNegativos.Focus()
        End If
    End Sub

    'Private Sub txtFlete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFlete.KeyPress
    '   If e.KeyChar = Chr(13) Then
    '       Me.ChkMostrarDomicilio.Focus()
    '  End If
    'End Sub
End Class