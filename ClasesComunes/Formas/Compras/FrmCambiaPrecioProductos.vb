Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Partial Public Class FrmCambiaPrecioProducto
#Region "Miembros"
    Private cargo As Boolean = False
    'Dim Linea As New ClasesNegocio.LineaClass()
    'Dim SubLinea As New ClasesNegocio.SubLineaClass()
    'Dim marca As New ClasesNegocio.MarcaClass()
    'Dim Lineas As New ClasesNegocio.LineaCollectionClass()
    'Dim marcas As New ClasesNegocio.MarcaCollectionClass()
    'Dim SubLineas As New ClasesNegocio.SubLineaCollectionClass()

    'Dim productos As New ClasesNegocio.ProductoCollectionClass
    Dim edit As Boolean
    Dim m_ing As Boolean
    Dim pr As New ProductoCollectionClass()
    Dim prod As New ClasesNegocio.ProductoGeneralClass

    Public CodLista As Integer
#End Region

    Private Sub FrmCambiaPrecioProducto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter     '' seleccionar artículo
                e.Handled = True
                If btnAceptar.Focused Then btnAceptar_Click(sender, New System.EventArgs())
            Case Keys.Escape    '' seleccionar artículo
                e.Handled = True
                btnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub FrmCambiaPrecioProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPorcUtilidad.Focus()
    End Sub


#Region "Propiedades"

    ' Propiedad que indica cuando se da una edición...
    Public Property CostoUnitarioAnterior() As Decimal
        Get
            Return Decimal.Parse(txtCostoAnterior.Text)
        End Get
        Set(ByVal value As Decimal)
            txtCostoAnterior.Text = Format(value, "C2")
        End Set
    End Property

    Public Property CUImpuestos() As Decimal
        Get
            Return Decimal.Parse(txtCUImpuestos.Text.Replace("$", ""))
        End Get
        Set(ByVal value As Decimal)
            txtCUImpuestos.Text = Format(value, "C2")
        End Set
    End Property

    Public Property CUImpuestosN() As Decimal
        Get
            Return Decimal.Parse(txtCUImpuestosN.Text)
        End Get
        Set(ByVal value As Decimal)
            txtCUImpuestosN.Text = Format(value, "C2")
        End Set
    End Property

    Public Property IvaCUAnterior() As Decimal
        Get
            Return Decimal.Parse(txtIvaAnt.Text)
        End Get
        Set(ByVal value As Decimal)
            txtIvaAnt.Text = Format(value, "C2")
        End Set
    End Property

    Public Property IvaCUNuevo() As Decimal
        Get
            Return Decimal.Parse(txtIvaNuevo.Text)
        End Get
        Set(ByVal value As Decimal)
            txtIvaNuevo.Text = Format(value, "C2")
        End Set
    End Property

    Public Property IepsCUAnterior() As Decimal
        Get
            Return Decimal.Parse(txtIepsAnt.Text)
        End Get
        Set(ByVal value As Decimal)
            txtIepsAnt.Text = Format(value, "C2")
        End Set
    End Property

    Public Property IepsCUNuevo() As Decimal
        Get
            Return Decimal.Parse(txtIepsNuevo.Text)
        End Get
        Set(ByVal value As Decimal)
            txtIepsNuevo.Text = Format(value, "C2")
        End Set
    End Property

    Public Property NuevoCostoUnitario() As Decimal
        Get
            Return Decimal.Parse(txtNuevoCosto.Text)
        End Get
        Set(ByVal value As Decimal)
            txtNuevoCosto.Text = Format(value, "C2")
        End Set
    End Property

    Public Property PorcentajeUtilidad() As Decimal
        Get
            Return Decimal.Parse(txtPorcUtilidad.Text)
        End Get
        Set(ByVal value As Decimal)
            txtPorcUtilidad.Text = Format(value, "N2")
            ''txtPorcUtilidad.Text = Format(Format(txtPorcUtilidad.Text, "N0") + "}", value)
            ''txtPorcUtilidad.Text = Format("{0:" + Format(txtPorcUtilidad.Text, "N0") + "}", value)
            ''txtPorcUtilidad.Text = Format("{0:" + txtPorcUtilidad.Text + "}", value)
            ''txtPorcUtilidad.Text = Format("{0:#0.##%}", value)
            ''"{0:" + perMilleFmt + "}", value
            'Console.WriteLine(String.Format(CultureInfo.InvariantCulture, 
            '                    "{0:#0.##%}", value))

        End Set
    End Property

    ''Kareli 09/01/2015 comentado para hacer pruebas y dejar la función original
    'Public WriteOnly Property PrecioVentaActual() As Decimal
    '    'Get
    '    '    Return Decimal.Parse(txtPrecioVentaActual.Text)
    '    'End Get
    '    ''quitar el signo de pesos para poder convertir
    '    'Replace(txtPrecioVentaActual.text,
    '    Set(ByVal value As Decimal)
    '        txtPrecioVentaActual.Text = Format(value, "C2")
    '    End Set
    'End Property
    ''/******Así era originalmente
    'Public Property PrecioVentaActual() As Decimal
    '    Get
    '        Return Decimal.Parse(txtPrecioVentaActual.Text)
    '    End Get
    '    Set(ByVal value As Decimal)
    '        txtPrecioVentaActual.Text = Format(value, "C2")
    '    End Set
    'End Property
    ''Kareli 09/01/2015 comentado (termina)

    Public Property PrecioVentaActual() As Decimal
        'txtPrecioVentaActual.Text= Left (txtPrecioVentaActual.Text.Trim,1)
        ''Replace(txtPrecioVentaActual.Text.Trim, "$", "")
        Get
            Return Decimal.Parse(txtPrecioVentaActual.Text.Replace("$", ""))
        End Get
        Set(ByVal value As Decimal)
            txtPrecioVentaActual.Text = Format(value, "C2")
        End Set
    End Property

    Public Property NuevoPrecioVenta() As Decimal

        Get
            Return Decimal.Parse(txtNuevoPrecio.Text.Replace("$", ""))
        End Get
        Set(ByVal value As Decimal)
            txtNuevoPrecio.Text = Format(value, "C2")
        End Set
    End Property

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

#Region "Eventos"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtNuevoPrecio.Text.Trim = "" Then
            MessageBox.Show("Debe capturar el Nuevo Precio", "Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub FrmCambiaPrecioProducto_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtPorcUtilidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcUtilidad.KeyPress
        e.Handled = ProcesaDecimal(txtPorcUtilidad.Text, e.KeyChar)
    End Sub

    Private Sub txtPorcUtilidad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcUtilidad.Leave
        'txtNuevoPrecio.Text = Format(txtNuevoCosto.Text * (1 + (txtPorcUtilidad.Text / 100)), "N2")
        ''NUEVO COSTO
        txtNuevoPrecio.Text = Format(txtCUImpuestosN.Text * (1 + (txtPorcUtilidad.Text / 100)), "C2")

    End Sub

    Private Sub txtNuevoPrecio_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNuevoPrecio.Leave
        txtPorcUtilidad.Text = Format(((txtNuevoPrecio.Text / txtNuevoCosto.Text) - 1) * 100, "N2")
    End Sub

    Private Sub txtNuevoPrecio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevoPrecio.KeyPress
        e.Handled = ProcesaDecimal(txtNuevoPrecio.Text, e.KeyChar)
    End Sub
#End Region

    Function ProcesaDecimal(ByVal Texto As String, ByVal Caracter As Char) As Boolean
        Dim punto As String = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator
        If (Not (Asc(Caracter) < 32 Or Char.IsDigit(Caracter) Or (Caracter.ToString() = punto And Not Texto.Contains(punto)))) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub FrmCambiaPrecioProducto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCUImpuestosN.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtPrecioVentaActual_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPrecioVentaActual.TextChanged

    End Sub

    Private Sub txtNuevoPrecio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNuevoPrecio.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
End Class