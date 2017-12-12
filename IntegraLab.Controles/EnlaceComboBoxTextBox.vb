Imports CM = System.ComponentModel

Public Class EnlaceComboBoxTextBox

#Region "Declaraciones"
    Private m_IndiceXDefault As Integer = -1
#End Region

#Region "Propiedades"
    <CM.Category("Controles"), CM.Description("Caja de texto que tendra el valor del elemento seleccionado en el ComboBox")> _
    Public Property [TextBox]() As TextBoxMejorado
        Get
            Return Me.TextBoxMejorado1
        End Get
        Private Set(ByVal value As TextBoxMejorado)
            Me.TextBoxMejorado1 = value
        End Set
    End Property

    <CM.Category("Controles"), CM.Description("ComboBox que tendra el listado de los elementos")> _
    Public Property [ComboBox]() As ComboBoxMejorado
        Get
            Return Me.ComboBoxMejorado1
        End Get
        Private Set(ByVal value As ComboBoxMejorado)
            Me.ComboBoxMejorado1 = value
        End Set
    End Property

    <System.ComponentModel.Category("Configuración ComboBox"), System.ComponentModel.Description("Mensaje que se mostrara cuando no exista el código tecleado en la lista del ComboBox")> _
    Public Property MensajeNoExiste() As String
        Get
            Return Me.TextBoxMejorado1.MensajeNoExiste
        End Get
        Set(ByVal value As String)
            Me.TextBoxMejorado1.MensajeNoExiste = value
        End Set
    End Property

    <System.ComponentModel.Category("Configuración ComboBox"), System.ComponentModel.Description("Mensaje que se mostrara en el ComboBox cuando no este seleccionado ningun elemento")> _
    Public Property MensajeCombo() As String
        Get
            Return Me.TextBoxMejorado1.MensajeCombo
        End Get
        Set(ByVal value As String)
            Me.TextBoxMejorado1.MensajeCombo = value
        End Set
    End Property

    <System.ComponentModel.Category("Configuración ComboBox"), CM.Description("Indice que adquiere el ComboBox al limpiar su selección")> _
    Public Property IndiceDefault() As Integer
        Get
            Return m_IndiceXDefault
        End Get
        Set(ByVal value As Integer)
            m_IndiceXDefault = value
        End Set
    End Property

    <CM.Category("Configuración TextBox"), CM.Description("Tipo de valor que se ingresara en el TextBox")> _
    Public Property TipoValor() As TextBoxMejorado.TipoValorEnum
        Get
            Return Me.TextBoxMejorado1.TipoValor
        End Get
        Set(ByVal value As TextBoxMejorado.TipoValorEnum)
            Me.TextBoxMejorado1.TipoValor = value
        End Set
    End Property

    <System.ComponentModel.Category("Data")> _
    <System.ComponentModel.Description("Origen de datos")> _
    <System.ComponentModel.AttributeProvider(GetType(System.ComponentModel.IListSource))> _
    Public Property DataSource() As Object
        Get
            Return Me.ComboBoxMejorado1.DataSource
        End Get
        Set(ByVal value As Object)
            Me.ComboBoxMejorado1.DataSource = value
        End Set
    End Property

    <System.ComponentModel.Category("Data"), _
    System.ComponentModel.Description("Campo que se mostrara en el listado")> _
    Public Property DisplayMember() As String
        Get
            Return Me.ComboBoxMejorado1.DisplayMember
        End Get
        Set(ByVal value As String)
            Me.ComboBoxMejorado1.DisplayMember = value
        End Set
    End Property

    Public Property ValueMember() As String
        Get
            Return Me.ComboBoxMejorado1.ValueMember
        End Get
        Set(ByVal value As String)
            Me.ComboBoxMejorado1.ValueMember = value
        End Set
    End Property

    <CM.Category("Comportamiento"), CM.Description("control que tendra el focus ")> _
    Public Property SiguienteControl() As System.Windows.Forms.Control
        Get
            Return Me.ComboBox.SiguienteControl
        End Get
        Set(ByVal value As System.Windows.Forms.Control)
            Me.ComboBox.SiguienteControl = value
            Me.TextBox.SiguienteControl = value
        End Set
    End Property
#End Region

#Region "Eventos"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.ComboBox.SelectedIndex = IndiceDefault
        Me.ComboBox.Text = Me.MensajeCombo
        Me.TextBox.Clear()
    End Sub
#End Region
End Class