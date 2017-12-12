Imports CM = System.ComponentModel

Public Class ComboBoxMejorado
    Inherits System.Windows.Forms.ComboBox

#Region "Declaraciones"
    Private m_TextBoxEnlazado As TextBox
    Private m_SiguienteControl As System.Windows.Forms.Control
    Private m_Tecla As Keys = Keys.F12
    Private m_Parametros() As ComboParametro
    Private m_NombreMetodo As String

#Region "Eventos"
    Public Event ActualizarCombo As EventHandler
#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"
    <CM.Category("Comportamiento General"), CM.Description("TextBox con el que se enlazara el valor seleccionado en el ComboBox")> _
    Public Property TextBoxEnlazado() As TextBox
        Get
            Return m_TextBoxEnlazado
        End Get
        Set(ByVal value As TextBox)
            Me.m_TextBoxEnlazado = value
        End Set
    End Property

    <CM.Category("Comportamiento General"), CM.Description("Siguiente Control que obtendra el focus al precionar la tecla ENTER")> _
    Public Property SiguienteControl() As System.Windows.Forms.Control
        Get
            Return m_SiguienteControl
        End Get
        Set(ByVal value As System.Windows.Forms.Control)
            m_SiguienteControl = value
        End Set
    End Property

    <CM.Category("Actualización"), CM.Description("Tecla con la que se ejecutara el evento Actualizar")> _
    Public Property TeclaParaActualizar() As Keys
        Get
            Return Me.m_Tecla
        End Get
        Set(ByVal value As Keys)
            Me.m_Tecla = value
        End Set
    End Property

    <CM.Category("Actualización"), CM.Description("Ingrese los aprametros en el orden en que son requeridos en el metodo que realizara la consulta")> _
    Public Property Parametros() As ComboParametro()
        Get
            Return m_Parametros
        End Get
        Set(ByVal value As ComboParametro())
            m_Parametros = value
        End Set
    End Property

    <CM.Category("Actualización"), CM.Description("Ingrese el nombre del metodo que realizara la consulta, solo funciona si el DataSource es una coleccion, no acepta DataSet y DataTable")> _
    Public Property NombreMetodo() As String
        Get
            Return m_NombreMetodo
        End Get
        Set(ByVal value As String)
            m_NombreMetodo = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub OnActualizaCombo()
        RaiseEvent ActualizarCombo(Me, New EventArgs)
    End Sub
#End Region

#Region "Eventos"
    Private Sub ComboBoxMejorado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SelectedIndexChanged
        If Me.SelectedIndex > -1 AndAlso Not Me.ValueMember = "" Then
            If Me.m_TextBoxEnlazado IsNot Nothing Then Me.m_TextBoxEnlazado.Text = Me.SelectedValue
        Else
            If Me.m_TextBoxEnlazado IsNot Nothing Then Me.m_TextBoxEnlazado.Clear()
        End If
    End Sub

    Private Sub ComboBoxMejorado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.m_SiguienteControl.Focus()
        End If
    End Sub

    Private Sub ComboBoxMejorado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Me.PreviewKeyDown
        If e.KeyData = Me.TeclaParaActualizar Then
            If Me.NombreMetodo = Nothing Then
                RaiseEvent ActualizarCombo(Me, EventArgs.Empty)
            Else
                If Parametros Is Nothing Then
                    Dim met As System.Reflection.MethodInfo = Me.DataSource.GetType.GetMethod(Me.NombreMetodo)

                    met.Invoke(Me.DataSource, Nothing)
                Else
                    Dim types(Parametros.Length - 1) As System.Type
                    Dim param(types.Length - 1) As Object

                    For i As Integer = 0 To Parametros.Length - 1
                        Select Case Parametros(i).Tipo
                            Case TipoValorEnum.Date
                                types(i) = GetType(Date)
                                param(i) = CType(Parametros(i).Valor, Date)
                            Case TipoValorEnum.Decimal
                                types(i) = GetType(Decimal)
                                param(i) = CType(Parametros(i).Valor, Decimal)
                            Case TipoValorEnum.Double
                                types(i) = GetType(Double)
                                param(i) = CType(Parametros(i).Valor, Double)
                            Case TipoValorEnum.Integer
                                types(i) = GetType(Integer)
                                param(i) = CType(Parametros(i).Valor, Integer)
                            Case TipoValorEnum.Short
                                types(i) = GetType(Short)
                                param(i) = CType(Parametros(i).Valor, Short)
                            Case TipoValorEnum.Single
                                types(i) = GetType(Single)
                                param(i) = CType(Parametros(i).Valor, Single)
                            Case TipoValorEnum.String
                                types(i) = GetType(String)
                                param(i) = CType(Parametros(i).Valor, String)
                            Case TipoValorEnum.Boolean
                                types(i) = GetType(Boolean)
                                param(i) = CType(Parametros(i).Valor, Boolean)
                        End Select
                    Next

                    Dim metodos() As System.Reflection.MethodInfo = Me.DataSource.GetType.GetMethods
                    Dim encontroMetodo As Boolean = False

                    For Each metodo As System.Reflection.MethodInfo In metodos
                        Dim parametrosMetodo() As System.Reflection.ParameterInfo = metodo.GetParameters

                        If param.Length = parametrosMetodo.Length Then
                            For i As Integer = 0 To parametrosMetodo.Length - 1
                                If parametrosMetodo(i).Name = Parametros(i).NombreParametro Then
                                    'param(i) = Convert.GetTypeCode(Parametros(i), p(i).ParameterType)

                                    If i = parametrosMetodo.Length - 1 Then
                                        encontroMetodo = True
                                        metodo.Invoke(Me.DataSource, param)
                                        Me.SelectedIndex = -1
                                        Exit Sub
                                    End If
                                End If
                            Next
                        End If
                    Next

                    If Not encontroMetodo Then
                        MsgBox("No existe un metodo con los datos proporcionados", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If
            End If
        End If
    End Sub
#End Region

#Region "Clases"
    Public Class ComboParametro
        Private m_Tipo As TipoValorEnum
        Private m_Valor As String
        Private m_NombreParametro As String

        Public Property Tipo() As TipoValorEnum
            Get
                Return m_Tipo
            End Get
            Set(ByVal value As TipoValorEnum)
                m_Tipo = value
            End Set
        End Property

        Public Property Valor() As String
            Get
                Return m_Valor
            End Get
            Set(ByVal value As String)
                m_Valor = value
            End Set
        End Property

        Public Property NombreParametro() As String
            Get
                Return m_NombreParametro
            End Get
            Set(ByVal value As String)
                m_NombreParametro = value
            End Set
        End Property
    End Class
#End Region

#Region "Enumerador"
    Public Enum TipoValorEnum
        [Integer]
        [String]
        [Decimal]
        [Date]
        [Double]
        [Single]
        [Short]
        [Boolean]
    End Enum
#End Region
End Class