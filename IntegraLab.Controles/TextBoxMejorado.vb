Imports System

Public Class TextBoxMejorado
    Inherits TextBox

#Region "Delcaraciones"
    Private m_SiguienteControl As System.Windows.Forms.Control
    Private m_TipoValor As TipoValorEnum = TipoValor.Cadena
    Private m_NumeroDecimales As Integer
    Private m_ComboBoxEnlazado As System.Windows.Forms.ComboBox
    Private m_MensajeNoExiste As String = "No existe un item con este código o se encuentra inactivo"
    Private m_MensajeCombo As String = "Seleccionar un item..."
    Private m_ValidarCombo As Boolean = False
    Private m_Tipo As TipoValorEnum
    Private m_ultimoValor As String
    Private m_ValorMinimo As Decimal = 0D
    Private m_ValorMaximo As Decimal = 999999999D
    Private m_validarCambioTexto As Boolean = True
#End Region

#Region "Propiedades"
    <System.ComponentModel.Category("Comportamiento General"), _
    System.ComponentModel.Description("Establece el control que obtendra el focus al precionar la tecla ENTER. En caso que se ligue a un ComboBox y quiera que en el ComboBox se seleccione un elemento con el código tecleado, debe establecer el enlaze por medio de la propiedad ComboBoxEnlazado y esta propiedad enlazarla al siguiente control que tendra el focus en caso que el código sea correcto")> _
    Public Property SiguienteControl() As System.Windows.Forms.Control
        Get
            Return m_SiguienteControl
        End Get
        Set(ByVal value As System.Windows.Forms.Control)
            m_SiguienteControl = value
        End Set
    End Property

    <System.ComponentModel.Category("Formato"), System.ComponentModel.DisplayName("Tipo Valor"), System.ComponentModel.Description("Establece que datos permitira ingresar en el TextBox")> _
    Public Property TipoValor() As TipoValorEnum
        Get
            Return m_TipoValor
        End Get
        Set(ByVal value As TipoValorEnum)
            m_TipoValor = value

            If Not value = TipoValorEnum.Cadena Then
                Me.MaxLength = 3000
            End If
        End Set
    End Property

    <System.ComponentModel.Category("Formato"), System.ComponentModel.DisplayName("Valor Minimo"), _
    System.ComponentModel.Description("Valor Minimo que aceptara, es aplicable solo en valores numericos")> _
    Public Property ValorMinimo() As Decimal
        Get
            Return Me.m_ValorMinimo
        End Get
        Set(ByVal value As Decimal)
            m_ValorMinimo = value
        End Set
    End Property

    <System.ComponentModel.Category("Formato"), System.ComponentModel.DisplayName("Valor Maximo"), _
    System.ComponentModel.Description("Valor Maximo que aceptara, es aplicable solo en valores numericos")> _
    Public Property ValorMaximo() As Decimal
        Get
            Return Me.m_ValorMaximo
        End Get
        Set(ByVal value As Decimal)
            m_ValorMaximo = value
        End Set
    End Property

    <System.ComponentModel.Category("Formato"), System.ComponentModel.DisplayName("Decimales"), System.ComponentModel.Description("Establece la cantidad de decimales que tendra el numero (Solo para tipo Decimal")> _
    Public Property Decimales() As Integer
        Get
            Return m_NumeroDecimales
        End Get
        Set(ByVal value As Integer)
            m_NumeroDecimales = value
        End Set
    End Property

    <System.ComponentModel.Category("Configuracion ComboBox"), System.ComponentModel.Description("ComboBox con el que se enlazara")> _
    Public Property ComboBoxEnlazado() As ComboBox
        Get
            Return Me.m_ComboBoxEnlazado
        End Get
        Set(ByVal value As ComboBox)
            Me.m_ComboBoxEnlazado = value

            If value Is Nothing Then
                Me.ValidarEnlace = False
            Else
                Me.ValidarEnlace = True
            End If
        End Set
    End Property

    <System.ComponentModel.Category("Configuracion ComboBox"), System.ComponentModel.Description("Mensaje que se mostrara cuando no exista el código tecleado en la lista del ComboBox")> _
    Public Property MensajeNoExiste() As String
        Get
            Return Me.m_MensajeNoExiste
        End Get
        Set(ByVal value As String)
            Me.m_MensajeNoExiste = value
        End Set
    End Property

    <System.ComponentModel.Category("Configuracion ComboBox"), System.ComponentModel.Description("Mensaje que se mostrara en el ComboBox cuando no este seleccionado ningun elemento")> _
    Public Property MensajeCombo() As String
        Get
            Return Me.m_MensajeCombo
        End Get
        Set(ByVal value As String)
            Me.m_MensajeCombo = value
        End Set
    End Property

    <System.ComponentModel.Category("Comportamiento General")> _
    Public Property ValidarEnlace() As Boolean
        Get
            Return m_ValidarCombo
        End Get
        Private Set(ByVal value As Boolean)
            m_ValidarCombo = value
        End Set
    End Property

    Private Property UltimoValor() As String
        Get
            Return m_ultimoValor
        End Get
        Set(ByVal value As String)
            m_ultimoValor = value
        End Set
    End Property

    Private Property ValidadCambioTexto() As Boolean
        Get
            Return Me.m_validarCambioTexto
        End Get
        Set(ByVal value As Boolean)
            Me.m_validarCambioTexto = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region

#Region "Eventos"
    Private Sub TextBoxMejorado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.Text = Me.Text.Replace("$", "").Replace(",", "")
    End Sub

    Private Sub TextBoxKeyPress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            If ValidarEnlace Then

                If Me.Text.Trim.Length > 0 Then
                    If Me.TipoValor = TipoValorEnum.Cadena Then
                        Me.ComboBoxEnlazado.SelectedValue = Me.Text
                    ElseIf Me.TipoValor = TipoValorEnum.Numerico Then
                        Me.ComboBoxEnlazado.SelectedValue = CInt(Me.Text)
                    ElseIf Me.TipoValor = TipoValorEnum.Decimal Or Me.TipoValor = TipoValorEnum.Moneda Then
                        Me.ComboBoxEnlazado.SelectedValue = CDec(Me.Text)
                    End If

                    If Me.ComboBoxEnlazado.SelectedIndex = -1 Then
                        MsgBox(Me.MensajeNoExiste, MsgBoxStyle.Exclamation, "Aviso")
                        Me.ComboBoxEnlazado.Text = Me.MensajeCombo
                        Me.ComboBoxEnlazado.Focus()
                    Else
                        If m_SiguienteControl IsNot Nothing Then m_SiguienteControl.Focus()
                    End If
                Else
                    Me.Clear()
                    Me.ComboBoxEnlazado.SelectedIndex = -1
                    Me.ComboBoxEnlazado.Text = Me.MensajeCombo
                    Me.ComboBoxEnlazado.Focus()
                End If
            Else
                If m_SiguienteControl IsNot Nothing Then m_SiguienteControl.Focus()
            End If
        ElseIf Not TipoValor = TipoValorEnum.Cadena Then
            If TipoValor = TipoValorEnum.Decimal Or TipoValor = TipoValorEnum.Moneda Then
                If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = "."c) OrElse (e.KeyChar = "."c AndAlso Me.Text.IndexOf("."c) > -1) Then
                    e.Handled = True
                End If
            Else
                If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxMejorado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Me.ValidarEnlace Then Exit Sub

        If Me.Text.Trim.Length = 0 Then
            If Not TipoValor = TipoValorEnum.Cadena Then
                If TipoValor = TipoValorEnum.Decimal Then
                    Me.Text = ValorMinimo.ToString("N" & Decimales)
                ElseIf TipoValor = TipoValorEnum.Moneda Then
                    Me.Text = ValorMinimo.ToString("C" & Decimales)
                ElseIf TipoValor = TipoValorEnum.Numerico Then
                    Me.Text = CInt(ValorMinimo)
                End If
            End If
        Else
            If Not TipoValor = TipoValorEnum.Cadena Then
                Dim valor As Decimal = CDec(Me.Text.Replace("$", "").Replace(",", ""))

                If valor < ValorMinimo Then
                    Text = ValorMinimo
                ElseIf valor > ValorMaximo Then
                    Text = ValorMaximo
                End If

                If TipoValor = TipoValorEnum.Decimal Then
                    Me.Text = valor.ToString("N" & Decimales)
                ElseIf TipoValor = TipoValorEnum.Moneda Then
                    Me.Text = valor.ToString("C" & Decimales)
                End If
            End If
        End If
    End Sub

    Private Sub TextBoxMejorado_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        If Not Me.Text.Trim.Length > 0 AndAlso ValidarEnlace Then
            Me.Clear()
            Me.ComboBoxEnlazado.SelectedIndex = -1
            Me.ComboBoxEnlazado.Text = Me.MensajeCombo
        End If
    End Sub

#End Region

#Region "Enumeradores"
    Public Enum TipoValorEnum
        Cadena
        Numerico
        [Decimal]
        Moneda
    End Enum
#End Region

End Class