Public Class CatAlmConsKardexPto

    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False
    Dim Mes As New ClasesNegocio.MesesClass
    Private WithEvents Plazas As New ClasesNegocio.PlazaCollectionClass
    Private WithEvents Productos As New ClasesNegocio.ProductoCollectionClass
    Private WithEvents Sublineas As New ClasesNegocio.SubLineaCollectionClass

    Private Sub CmbPlaza_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPlaza.KeyDown
        'If e.KeyCode = Keys.F12 Then
        '    Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'End If
    End Sub


    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbProducto.Focus()
            If CmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub CmbProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProducto.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLinea.Focus()
            If CmbProducto.Text = "" Then
                MsgBox("Seleccione una Producto")
                CmbProducto.Focus()
            End If
        End If
    End Sub

    Private Sub TxtLinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLinea.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtUnidad.Focus()
            If TxtLinea.Text = "" Then
                MsgBox("Agregue Información a Linea ")
                TxtLinea.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUnidad.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbSublinea.Focus()
            If TxtUnidad.Text = "" Then
                MsgBox("Agregue Información a Unidad ")
                TxtUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub CmbSublinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSublinea.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbMes.Focus()
            If CmbSublinea.Text = "" Then
                MsgBox("Seleccione una Linea")
                CmbSublinea.Focus()
            End If
        End If
    End Sub

    Private Sub CmbMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbMes.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DtpFecha.Focus()
            If CmbMes.Text = "" Then
                MsgBox("Seleccione un Mes")
                CmbMes.Focus()
            End If
        End If
    End Sub

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbAño.Focus()
        End If
    End Sub

    Private Sub CmbAño_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbAño.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtCosto.Focus()
            If CmbAño.Text = "" Then
                MsgBox("Seleccione un Año")
                CmbAño.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCosto.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtExisInicial.Focus()
            If TxtCosto.Text = "" Then
                MsgBox("Agregue Información a Costo Inicial ")
                TxtCosto.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtCosto.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtCosto.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtCosto.Text.Length - Me.TxtCosto.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtCosto.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtExisInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExisInicial.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtEntrada.Focus()
            If TxtExisInicial.Text = "" Then
                MsgBox("Agregue Información a Existencia Inicial ")
                TxtExisInicial.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtExisInicial.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtExisInicial.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtExisInicial.Text.Length - Me.TxtExisInicial.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtExisInicial.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtEntrada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEntrada.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtSalidas.Focus()
            If TxtEntrada.Text = "" Then
                MsgBox("Agregue Información a Total Entradas ")
                TxtEntrada.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtEntrada.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtEntrada.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtEntrada.Text.Length - Me.TxtEntrada.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtEntrada.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtSalidas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSalidas.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtExisActual.Focus()
            If TxtSalidas.Text = "" Then
                MsgBox("Agregue Información a Total Salidas ")
                TxtSalidas.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtSalidas.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtSalidas.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtSalidas.Text.Length - Me.TxtSalidas.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtSalidas.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtExisActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtExisActual.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtReferencia.Focus()
            If TxtExisActual.Text = "" Then
                MsgBox("Agregue Información a Existencia Actual ")
                TxtExisActual.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtExisActual.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtExisActual.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtExisActual.Text.Length - Me.TxtExisActual.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtExisActual.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        CmbPlaza.SelectedValue = "Seleccione Plaza"
        CmbProducto.SelectedValue = "Seleccione Plaza"
        TxtLinea.Clear()
        TxtUnidad.Clear()
        CmbSublinea.SelectedValue = "Seleccione Plaza"
        CmbMes.SelectedValue = "Seleccione Plaza"
        DtpFecha.Value = Now
        CmbAño.SelectedValue = "Seleccione Plaza"
        TxtCosto.Clear()
        TxtExisInicial.Clear()
        TxtEntrada.Clear()
        TxtSalidas.Clear()
        TxtExisActual.Clear()
        TxtReferencia.Clear()
    End Sub
    Private Sub Deshabilitar()
        CmbPlaza.Enabled = False
        CmbProducto.Enabled = False
        TxtLinea.Enabled = False
        TxtUnidad.Enabled = False
        CmbSublinea.Enabled = False
        CmbMes.Enabled = False
        DtpFecha.Enabled = False
        CmbAño.Enabled = False
        TxtCosto.Enabled = False
        TxtExisInicial.Enabled = False
        TxtEntrada.Enabled = False
        TxtSalidas.Enabled = False
        TxtExisActual.Enabled = False
        TxtReferencia.Enabled = False
        DataGrid.Enabled = True
    End Sub
    Private Sub Habilitar()
        CmbPlaza.Enabled = True
        CmbProducto.Enabled = True
        TxtLinea.Enabled = True
        TxtUnidad.Enabled = True
        CmbSublinea.Enabled = True
        CmbMes.Enabled = True
        DtpFecha.Enabled = True
        CmbAño.Enabled = True
        TxtCosto.Enabled = True
        TxtExisInicial.Enabled = True
        TxtEntrada.Enabled = True
        TxtSalidas.Enabled = True
        TxtExisActual.Enabled = True
        TxtReferencia.Enabled = True
        DataGrid.Enabled = False
    End Sub

#End Region

    Private Sub CatAlmConsKardexPto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
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
        Deshabilitar()

        ''Plazas
        'plazas.Obtener()
        'CmbPlaza.DataSource = plazas
        'CmbPlaza.DisplayMember = "Descripcion"
        'CmbPlaza.ValueMember = "Codigo"
        ''Productos
        'Productos.Obtener()
        'CmbProducto.DataSource = Productos
        'CmbProducto.DisplayMember = "Descripcion"
        'CmbProducto.ValueMember = "Codigo"
        ''Sublineas
        'Sublineas.Obtener()
        'CmbSublinea.DataSource = Sublineas
        'CmbSublinea.DisplayMember = "Descripcion"
        'CmbSublinea.ValueMember = "Codigo"
        ''Meses
        'CmbMes.DataSource = Mes
        'CmbMes.DisplayMember = "mes"
        'CmbMes.ValueMember = "mes"

    End Sub


    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Editar = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

End Class