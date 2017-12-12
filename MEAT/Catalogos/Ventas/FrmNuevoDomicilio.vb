Public Class FrmNuevoDomicilio

    Private Estado As New ClasesNegocio.EstadoClass
    Private Ciudad As New ClasesNegocio.CiudadClass
    Private Poblacion As New ClasesNegocio.PoblacionClass
    Private WithEvents DomFiscal As New ClasesNegocio.DomicilioFiscalClass
    Private PuedoModificar As Boolean = False

    Public Property Domicilio() As ClasesNegocio.DomicilioFiscalClass
        Get
            Return DomFiscal
        End Get
        Set(ByVal value As ClasesNegocio.DomicilioFiscalClass)
            DomFiscal = value
        End Set
    End Property

    Private Sub sblimpiar()
        For Each txt As TextBox In Me.Panel1.Controls
            txt.Text = ""
        Next

        Me.cmbEstado.SelectedIndex = -1
        Me.txtCodigoEstado.Text = "Seleccione un estado..."
    End Sub

    Private Sub sbLectura()
        Panel1.Enabled = False
        'Me.DataGridView1.Enabled = True
    End Sub

    Private Sub sbEscritura()
        Panel1.Enabled = True
        'Me.DataGridView1.Enabled = False
    End Sub

    Private Sub Guardar()
        'DomFiscal.RFC = Me.TxtRFC.Text
        'DomFiscal.RazonSocial = Me.TxtRazonSocial.Text
        DomFiscal.Domicilio = Me.UltDomicilio.Text
        DomFiscal.Colonia = Me.UltColonia.Text
        DomFiscal.CP = Me.UltCodigoPostal.Text
        DomFiscal.Poblacion = DirectCast(Me.cmbPoblacion.SelectedItem, ClasesNegocio.PoblacionClass)
    End Sub

    Private Sub TxtRFCFiscal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            'TxtRazonSocial.Focus()
            'If TxtRFC.Text = "" Then
            MsgBox("Agregue Informacion . . . ")
            'TxtRFC.Focus()
            'End If
        End If
    End Sub

    Private Sub TxtRazonSocialFiscal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            UltDomicilio.Focus()
            'If TxtRazonSocial.Text = "" Then
            MsgBox("Agregue Informacion . . . ")
            'TxtRazonSocial.Focus()
            'End If
        End If
    End Sub

    Private Sub TxtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            UltColonia.Focus()
            If UltDomicilio.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                UltDomicilio.Focus()
            End If
        End If
    End Sub

    Private Sub TxtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            UltCodigoPostal.Focus()
            If UltColonia.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                UltColonia.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbEstado.Focus()
            If UltCodigoPostal.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                UltCodigoPostal.Focus()
            End If
        End If
        'Valida que el caracter ingresado sea numerico
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CmbcodigoEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbEstado.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbCiudad.Focus()
            If cmbEstado.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                cmbEstado.Focus()
            End If
        End If
    End Sub

    Private Sub CmbCodigoCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCiudad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbPoblacion.Focus()
            If cmbCiudad.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                cmbCiudad.Focus()
            End If
        End If
    End Sub

    Private Sub CmbCodigoPoblacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPoblacion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            'BtnAceptar.Focus()
            If cmbPoblacion.Text = "" Then
                MsgBox("Agregue Informacion . . . ")
                cmbPoblacion.Focus()
            End If
        End If
    End Sub

    'Ciudades del estado seleccionado
    Private Sub CmbcodigoEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstado.SelectedIndexChanged
        If cmbEstado.SelectedIndex > -1 Then
            'Me.CiudadC.Obtener(DirectCast(cmbEstado.SelectedItem, ClasesNegocio.EstadoClass), ClasesNegocio.CondicionEnum.VIGENTE)
            Me.CiudadC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbCiudad.SelectedIndex = -1
            Me.PoblacionC.Clear()
            cmbCiudad.Text = "Seleccione una Ciudad..."
            Me.txtCodigoEstado.Text = Me.cmbEstado.SelectedValue
            Me.txtCodigoPoblacion.Text = ""
            Me.txtCodigoCiudad.Text = ""
            Me.cmbPoblacion.Text = ""
        Else
            Me.CiudadC.Clear()
            Me.PoblacionC.Clear()
            Me.txtCodigoEstado.Text = ""
            Me.txtCodigoCiudad.Text = ""
            Me.txtCodigoPoblacion.Text = ""
        End If
    End Sub
    'Poblaciones de la ciudad seleccionada
    Private Sub CmbcodigoCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCiudad.SelectedIndexChanged
        If Me.cmbCiudad.SelectedIndex > -1 Then
            'Me.PoblacionC.Obtener(DirectCast(cmbCiudad.SelectedItem, ClasesNegocio.CiudadClass), ClasesNegocio.CondicionEnum.VIGENTE)
            Me.PoblacionC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbPoblacion.SelectedIndex = -1
            cmbPoblacion.Text = "Seleccione una Población..."
            Me.txtCodigoCiudad.Text = Me.cmbCiudad.SelectedValue
            Me.txtCodigoPoblacion.Text = ""
        Else
            Me.PoblacionC.Clear()
            Me.txtCodigoPoblacion.Text = ""
            Me.txtCodigoCiudad.Text = ""
        End If
    End Sub

    Private Sub cmbPoblacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPoblacion.SelectedIndexChanged
        If Me.cmbPoblacion.SelectedIndex > -1 Then
            Me.txtCodigoPoblacion.Text = Me.cmbPoblacion.SelectedValue
        Else
            Me.txtCodigoPoblacion.Text = ""
        End If
    End Sub

    Private Sub txtCodigoEstado_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoEstado.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodigoEstado.Text) Then
                cmbEstado.SelectedValue = CInt(Me.txtCodigoEstado.Text)

                If Me.cmbEstado.SelectedIndex = -1 Then
                    MsgBox("No existe un estado con ese código", MsgBoxStyle.Information, "Aviso")
                    Me.txtCodigoEstado.Text = ""
                Else
                    Me.txtCodigoCiudad.Focus()
                End If
            Else
                Me.txtCodigoEstado.Text = ""
                Me.cmbEstado.SelectedIndex = -1
                cmbEstado.Focus()
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCodigoCiudad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoCiudad.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodigoCiudad.Text) Then
                If Ciudad.Obtener(CInt(Me.txtCodigoCiudad.Text)) Then
                    If Ciudad.Estatus = ClasesNegocio.EstatusEnum.Inactivo Then
                        Me.cmbEstado.SelectedIndex = -1
                        Me.txtCodigoCiudad.Text = ""
                        Exit Sub
                    End If
                    Me.cmbEstado.SelectedValue = Ciudad.CodigoEstado
                    Me.cmbCiudad.SelectedValue = Ciudad.Codigo
                    Me.txtCodigoEstado.Text = Ciudad.CodigoEstado.ToString
                    Me.txtCodigoPoblacion.Focus()
                Else
                    Me.cmbEstado.SelectedIndex = -1
                    Me.txtCodigoCiudad.Text = ""
                End If
            Else
                Me.txtCodigoCiudad.Text = ""
                Me.cmbEstado.SelectedIndex = -1
                Me.cmbEstado.Focus()
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCodigoPoblacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPoblacion.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCodigoPoblacion.Text) Then
                If Poblacion.Obtener(CInt(Me.txtCodigoEstado.Text), CInt(Me.txtCodigoCiudad.Text), CInt(Me.txtCodigoPoblacion.Text)) Then
                    If Poblacion.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                        Me.txtCodigoPoblacion.Text = ""
                        Me.txtCodigoCiudad.Text = ""
                        Me.txtCodigoEstado.Text = ""
                        Me.cmbEstado.SelectedIndex = -1
                        Exit Sub
                    End If
                    Me.cmbEstado.SelectedValue = Poblacion.CodigoEstado
                    Me.cmbCiudad.SelectedValue = Poblacion.CodigoCiudad
                    Me.cmbPoblacion.SelectedValue = Poblacion.Codigo
                    Me.txtCodigoEstado.Text = Poblacion.CodigoEstado.ToString
                    Me.txtCodigoCiudad.Text = Poblacion.CodigoCiudad.ToString
                    Me.txtCodigoPoblacion.Text = Poblacion.Codigo.ToString
                Else
                    Me.txtCodigoPoblacion.Text = ""
                    Me.txtCodigoCiudad.Text = ""
                    Me.txtCodigoEstado.Text = ""
                    Me.cmbEstado.SelectedIndex = -1
                    'Me.CmbCiudad.DataSource = Nothing
                    'Me.CmbPoblacion.DataSource = Nothing
                End If
            Else
                Me.txtCodigoPoblacion.Text = ""
                Me.txtCodigoCiudad.Text = ""
                Me.txtCodigoEstado.Text = ""
                Me.cmbEstado.SelectedIndex = -1
                Me.cmbEstado.Focus()
            End If
        End If

        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstadoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.cmbEstado.SelectedIndex = -1
        Me.cmbEstado.Text = "Seleccione un Estado"
    End Sub

    Private Sub DomFiscal_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles DomFiscal.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")

        Select Case sender.ToString
            Case "RFC"
                'Me.TxtRFC.Focus()
            Case "Domicilio"
                Me.UltDomicilio.Focus()
            Case "Colonia"
                Me.UltColonia.Focus()
            Case "Poblacion"
                Me.cmbPoblacion.Focus()
            Case "RazonSocial"
                'Me.TxtRazonSocial.Focus()
            Case "CP"
                Me.UltCodigoPostal.Focus()
        End Select
    End Sub

    Private Sub DomFiscal_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles DomFiscal.Modificado
        If PuedoModificar Then
            'Me.TxtRFC.Text = DomFiscal.RFC
            'Me.TxtRazonSocial.Text = DomFiscal.RazonSocial
            Me.UltCodigoPostal.Text = DomFiscal.CP
            Me.UltDomicilio.Text = DomFiscal.Domicilio
            Me.UltColonia.Text = DomFiscal.Colonia
            Me.txtCodigoPoblacion.Text = DomFiscal.Codigo
            Me.txtCodigoPoblacion_KeyPress(Me, New KeyPressEventArgs(Chr(13)))
        End If
    End Sub

    Public Sub ValidarDatos()
        'Dim Mensaje() As String

        'If TxtDomicilio.Text.Trim = String.Empty Then
        '    Redim Mensaje "Debe seleccionar el domicilio"
        'ElseIf TxtColonia.Text.Trim = String.Empty Then
        '    Mensaje &= "Debe seleccionar la colonia"
        'ElseIf cmbEstado.SelectedValue Is Nothing Then
        '    Mensaje &= "Debe seleccionar el estado"
        'ElseIf cmbCiudad.SelectedValue Is Nothing Then
        '    Mensaje &= "Debe seleccionar la ciudad"
        'ElseIf cmbPoblacion.SelectedValue Is Nothing Then
        '    Mensaje &= "Debe seleccionar la poblacion"
        'End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        UlvDomicilio.Validate()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class