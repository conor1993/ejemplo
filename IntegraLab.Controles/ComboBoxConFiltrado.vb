Public Class ComboBoxConFiltrado

#Region "Declaraciones"
    Private m_From As String
    Private m_Where As String
    Private m_Campos As Campo()
    Private m_TamañoMax As Size
    Private m_Value As Object
#End Region

#Region "Propiedades"
    Public Property From() As String
        Get
            Return m_From
        End Get
        Set(ByVal value As String)
            m_From = value
        End Set
    End Property

    Public Property Where() As String
        Get
            Return m_Where
        End Get
        Set(ByVal value As String)
            m_Where = value
        End Set
    End Property

    Public Property MostrarCampos() As Campo()
        Get
            Return m_Campos
        End Get
        Set(ByVal value As Campo())
            m_Campos = value
        End Set
    End Property

    Public Property TamañoMaximo() As Size
        Get
            Return m_TamañoMax
        End Get
        Set(ByVal value As Size)
            m_TamañoMax = value
        End Set
    End Property

    Public Property Value(ByVal index As Integer) As Object
        Get
            Return m_Value
        End Get
        Set(ByVal value As Object)
            m_Value = value
        End Set
    End Property
#End Region
    
#Region "Clases"
    Public Class Campo
#Region "Declaraciones"
        Private m_NombreCampo As String
        Private m_TipoValor As TipoValorEnum
#End Region

#Region "Propiedades"
        Public Property NombreCampo() As String
            Get
                Return m_NombreCampo
            End Get
            Set(ByVal value As String)
                m_NombreCampo = value
            End Set
        End Property

        Public Property TipoValor() As TipoValorEnum
            Get
                Return m_TipoValor
            End Get
            Set(ByVal value As TipoValorEnum)
                m_TipoValor = value
            End Set
        End Property
#End Region
    End Class
#End Region

#Region "Enumeradores"
    Public Enum TipoValorEnum
        Cadena
        Numerico
        Fecha
    End Enum
#End Region

#Region "Eventos"
    Private Sub lvLista_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvLista.KeyPress
        If e.KeyChar = Chr(13) Then

        End If
    End Sub
#End Region
End Class