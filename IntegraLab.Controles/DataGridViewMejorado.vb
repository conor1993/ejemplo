Public Class DataGridViewMejorado
    Inherits DataGridView

    Private m_KeyReemplazar As Keys = Keys.Enter
    Private m_KeyParaReemplazar As Keys = Keys.Enter
    Private col As DataGridViewColumn

    <System.ComponentModel.Category("Edición"), System.ComponentModel.Description("Tecla que va a reemplazar")> _
    Public Property ReemplazarKey() As Keys
        Get
            Return Me.m_KeyReemplazar
        End Get
        Set(ByVal value As Keys)
            Me.m_KeyReemplazar = value
        End Set
    End Property

    <System.ComponentModel.Description("Tecla con la que quiere reemplazar"), System.ComponentModel.Category("Edición")> _
    Public Property ReemplazarKeyPor() As Keys
        Get
            Return Me.m_KeyParaReemplazar
        End Get
        Set(ByVal value As Keys)
            Me.m_KeyParaReemplazar = value
        End Set
    End Property

    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'en el 'processDialogKey'... cuando estamos en edicion
        If keyData = Me.ReemplazarKey Then                'si es la tecla que se quiere reemplazar
            SendKeys.Send(Chr(Me.ReemplazarKeyPor))       'Enviar la tecla con la que se reemplazara
            Return True                                   'Marcar como procesado
        Else                                              'en caso contrario
            Return MyBase.ProcessDialogKey(keyData)       'devolver KeyData
        End If
    End Function

    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        ' en 'OnKeyDown'... cuando no estamos en edicion
        If e.KeyData = Me.ReemplazarKey Then              'Si es la telca que se queire reemplazar'
            SendKeys.Send(Chr(Me.ReemplazarKeyPor))       'Enviar tecla con que se reemplaza'
        Else
            MyBase.OnKeyDown(e)                           'Devolver el KeyEventArgs
        End If
    End Sub

    ' funcion agregada para asegurar el reemplazo de la tecla
    Protected Overloads Overrides Function ProcessDataGridViewKey(ByVal e As KeyEventArgs) As Boolean
        If e.KeyCode = Me.ReemplazarKey Then
            MyBase.ProcessTabKey(Me.ReemplazarKeyPor)
            Return True
        End If
        Return MyBase.ProcessDataGridViewKey(e)
    End Function
End Class