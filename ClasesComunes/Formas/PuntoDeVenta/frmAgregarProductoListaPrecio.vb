Public Class frmAgregarProductoListaPrecio

    Private _Editar As Boolean = False
    Private _Detalle As ClasesNegocio.ListaPrecioDetalleClass
    Private PuedoModificar As Boolean = False
    Private producto As New ClasesNegocio.ProductoGeneralClass

    Public Property Editar() As Boolean
        Get
            Return _Editar
        End Get
        Set(ByVal value As Boolean)
            _Editar = value
            If Me.Editar Then
                Me.txtCodigo.ReadOnly = True
            End If
        End Set
    End Property

    Public Property Detalle() As ClasesNegocio.ListaPrecioDetalleClass
        Get
            Return _Detalle
        End Get
        Set(ByVal value As ClasesNegocio.ListaPrecioDetalleClass)
            _Detalle = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return Me.txtCodigo.Text
        End Get
        Set(ByVal value As Integer)
            Me.txtCodigo.Text = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Me.txtDescripcion.Text
        End Get
        Set(ByVal value As String)
            Me.txtDescripcion.Text = value
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return Decimal.Parse(Me.txtCosto.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.txtCosto.Text = value.ToString
        End Set
    End Property

    Public Property PrecioVentaC() As Decimal
        Get
            Return Decimal.Parse(Me.txtPrecioVentaC.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.txtPrecioVentaC.Text = value.ToString
        End Set
    End Property

    Public Property PrecioVetaP() As Decimal
        Get
            Return Decimal.Parse(Me.txtPrecioVentaP.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.txtPrecioVentaP.Text = value.ToString
        End Set
    End Property

    Public Property ComicionC() As Decimal
        Get
            Return Decimal.Parse(Me.txtComicionC.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.txtComicionC.Text = value.ToString
        End Set
    End Property

    Public Property ComicionP() As Decimal
        Get
            Return Decimal.Parse(Me.txtComicionP.Text)
        End Get
        Set(ByVal value As Decimal)
            Me.txtComicionP.Text = value.ToString
        End Set
    End Property

    Private Function validar() As Boolean
        Dim mensaje As String = ""
        'If Me.txtCosto.Text = "" Then
        '    mensaje &= "Debe proporcionar un costo" & Chr(13)
        'Else
        '    If Not IsNumeric(Me.txtCosto.Text) Then mensaje &= "Debe ingresar numeros en el Campo de Costo" & Chr(13)
        'End If

        If Me.txtPrecioVentaC.Text = "" Then
            mensaje &= "Debe proporcionar una Cantidad de Pecio de Venta" & Chr(13)
        Else
            If Not IsNumeric(Me.txtPrecioVentaC.Text) Then mensaje &= "Debe ingresar numeros en el Campo de Precio de Venta $" & Chr(13)
        End If

        If Me.txtPrecioVentaP.Text = "" Then
            mensaje &= "Debe proporcionar un Porcentaje del Precio de Venta" & Chr(13)
        Else
            If Not IsNumeric(Me.txtPrecioVentaP.Text) Then mensaje &= "Debe ingresar numeros en el Campo de Precio de Venta %" & Chr(13)
        End If

        If Me.txtComicionC.Text = "" Then
            mensaje &= "Debe proporcionar la Cantidad de Comicion" & Chr(13)
        Else
            If Not IsNumeric(Me.txtComicionC.Text) Then mensaje &= "Debe ingresar numeros en el campo de Comision $" & Chr(13)
        End If

        If Me.txtComicionP.Text = "" Then
            mensaje &= "Debe proporcionar el Procentaje de Comision" & Chr(13)
        Else
            If Not IsNumeric(Me.txtComicionP.Text) Then mensaje &= "Debe ingresar numeros en el Campo de Comicion %" & Chr(13)
        End If


        If Not mensaje = "" Then
            MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If validar() Then
                Detalle.Producto = producto
                Detalle.Costo = txtCosto.Text
                Detalle.PrecioVentaC = txtPrecioVentaC.Text
                Detalle.PrecioVentaP = txtPrecioVentaP.Text
                Detalle.ComicionC = txtComicionC.Text
                Detalle.ComisionP = txtComicionP.Text
                Detalle.Utilidad = txtutilidad.text
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub txtCodigo_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles txtCodigo.HelpRequested
        If Editar Then Exit Sub
        Dim ventana As New frmListaProdReg
        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each prod As ClasesNegocio.ProductoGeneralClass In ventana.ProductosSeleccionados
                Me.txtCodigo.Text = prod.Codigo.ToString
                Me.txtDescripcion.Text = prod.Descripcion
                Me.txtCosto.Text = prod.Piezas
                producto = prod
            Next
        End If
    End Sub

    Private Sub TxtUtilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUtilidad.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.TxtUtilidad.Text) And IsNumeric(Me.txtCosto.Text) Then
                Dim util As Decimal = Decimal.Parse(Me.TxtUtilidad.Text)
                Dim costo As Decimal = Decimal.Parse(Me.txtCosto.Text)
                Dim pvc As Decimal
                Dim pvp As Decimal
                Dim cc As Decimal
                Dim cp As Decimal
                pvc = costo + util
                pvp = ((util / costo) * 100)
                Me.txtPrecioVentaC.Text = pvc.ToString
                Me.txtPrecioVentaP.Text = pvp.ToString
                If IsNumeric(txtComicionP.Text) Then
                    cp = txtComicionP.Text
                    cc = ((cp / 100) * util)
                    Me.txtComicionC.Text = cc.ToString("0.00")
                ElseIf IsNumeric(txtComicionC.Text) Then
                    cc = txtComicionC.Text
                    cp = ((cc / util) * 100)
                    Me.txtComicionP.Text = cp.ToString("0.00")
                End If
                Me.txtComicionC.Focus()

            Else
                MsgBox("Debe teclear numeros en los campos de  costo y Utilidad...", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub txtPrecioVentaC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVentaC.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtPrecioVentaC.Text) And IsNumeric(Me.txtCosto.Text) Then
                If Decimal.Parse(Me.txtPrecioVentaC.Text) > Decimal.Parse(Me.txtCosto.Text) Then
                    Dim costo As Decimal = Decimal.Parse(Me.txtCosto.Text)
                    Dim ventaC As Decimal = Decimal.Parse(Me.txtPrecioVentaC.Text)
                    Dim util As Decimal
                    Dim cp As Decimal
                    Dim cc As Decimal
                    If costo = 0 Then
                        MsgBox("No es posible calcular un porcentaje de Precio de Venta, debido a que el costo es = 0", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If
                    util = ventaC - costo
                    Me.TxtUtilidad.Text = util.ToString("0.00")
                    Dim ventaP As Decimal = ((util / costo) * 100)
                    Me.txtPrecioVentaP.Text = ventaP.ToString("0.00")
                    If IsNumeric(txtComicionP.Text) Then
                        cp = txtComicionP.Text
                        cc = ((cp / 100) * util)
                        Me.txtComicionC.Text = cc.ToString("0.00")
                    ElseIf IsNumeric(txtComicionC.Text) Then
                        cc = txtComicionC.Text
                        cp = ((cc / util) * 100)
                        Me.txtComicionP.Text = cp.ToString("0.00")
                    End If
                    Me.txtComicionC.Focus()
                Else
                    MsgBox("El precio de venta debe ser mayor al de costo...", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("Debe teclear numeros en los campos de  costo y precio de venta...", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub txtPrecioVentaP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVentaP.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtPrecioVentaP.Text) And IsNumeric(Me.txtCosto.Text) Then
                Dim VentaP As Decimal = Decimal.Parse(Me.txtPrecioVentaP.Text)
                Dim VentaC As Decimal
                Dim util As Decimal
                Dim cc As Decimal
                Dim cp As Decimal
                Dim Costo As Decimal = Decimal.Parse(Me.txtCosto.Text)
                VentaC = Costo * ((VentaP / 100) + 1)
                util = VentaC - Costo
                Me.TxtUtilidad.Text = util.ToString("0.00")
                Me.txtPrecioVentaC.Text = Math.Round(VentaC, 2)
                Me.txtPrecioVentaP.Text = VentaP.ToString("0.00")
                If IsNumeric(txtComicionP.Text) Then
                    cp = txtComicionP.Text
                    cc = ((cp / 100) * util)
                    Me.txtComicionC.Text = cc.ToString("0.00")
                ElseIf IsNumeric(txtComicionC.Text) Then
                    cc = txtComicionC.Text
                    cp = ((cc / util) * 100)
                    Me.txtComicionP.Text = cp.ToString("0.00")
                End If
                Me.txtComicionC.Focus()
            Else
                MsgBox("Debe teclear numeros en los campos de  costo y porcentaje de venta", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub txtComicionC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComicionC.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtComicionC.Text) And IsNumeric(Me.txtPrecioVentaC.Text) Then
                If Decimal.Parse(Me.txtPrecioVentaC.Text) > Decimal.Parse(Me.txtComicionC.Text) Then
                    Dim VentaC As Decimal = Decimal.Parse(Me.txtPrecioVentaC.Text)
                    Dim Comc As Decimal = Decimal.Parse(Me.txtComicionC.Text)
                    Dim util As Decimal = Decimal.Parse(Me.TxtUtilidad.Text)
                    Dim ComP As Decimal
                    If VentaC = 0 Then
                        MsgBox("No es posible calcular el porcentaje de Comisión, debido a que Precio Venta = 0", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If
                    If Comc > util Then
                        MsgBox("La Comisión, No puede ser mayor a utilidad", MsgBoxStyle.Exclamation, "Aviso")
                        Exit Sub
                    End If
                    ComP = ((Comc / util) * 100)
                    Me.txtComicionP.Text = ComP.ToString("0.00")
                    Me.btnAceptar.Focus()
                Else
                    MsgBox("La comisión debe ser menor al de precio de venta...", MsgBoxStyle.Exclamation, "Aviso")
                End If
            Else
                MsgBox("Debe teclear numeros en los campos de  costo y precio de venta...", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub txtComicionP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtComicionP.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtComicionP.Text) And IsNumeric(Me.txtPrecioVentaC.Text) Then
                Dim VentaC As Decimal = Decimal.Parse(Me.txtPrecioVentaC.Text)
                Dim ComC As Decimal
                Dim util As Decimal = Decimal.Parse(Me.TxtUtilidad.Text)
                Dim ComP As Decimal = Decimal.Parse(Me.txtComicionP.Text)
                If ComP > 100 Then
                    MsgBox("No es posible que la comsión $ sea mayor al precio de venta $", MsgBoxStyle.Exclamation, "Aviso")
                    Me.txtComicionP.Text = ""
                    Exit Sub
                End If
                ComC = util * (ComP / 100)
                Me.txtComicionC.Text = Math.Round(ComC, 2)
                Me.btnAceptar.Focus()
            Else
                MsgBox("Debe teclear numeros en los campos de costo y porcentaje de venta...", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtCodigo.Text = "" Or Editar Then Exit Sub
            If producto.Obtener(Me.txtCodigo.Text) Then
                Me.txtCodigo.Text = producto.Codigo
                Me.txtDescripcion.Text = producto.Descripcion
                Me.txtCosto.Text = producto.Piezas
                Me.txtPrecioVentaC.Focus()
            Else
                MsgBox("No se encontro el producto...", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    Private Sub frmAgregarProductoListaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Detalle = New ClasesNegocio.ListaPrecioDetalleClass
    End Sub

End Class