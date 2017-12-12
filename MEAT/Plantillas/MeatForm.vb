Imports ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses

Public Class MeatForm

#Region "Miembros"

    Private _Estado As FormState
    Private _IsClosing As Boolean
    Private _AutoValidate As Windows.Forms.AutoValidate

#End Region

#Region "Propiedades"

    Public Overridable Property Estado() As FormState
        Get
            Return _Estado
        End Get
        Set(ByVal value As FormState)
            _Estado = value
        End Set
    End Property

    Public ReadOnly Property IsClosing() As Boolean
        Get
            Return _IsClosing
        End Get
    End Property

#End Region

#Region "Metodos"

    Protected Overrides Sub WndProc(ByRef m As Message)
        Dim SC_CLOSE As Integer = &HF060
        Dim WM_SYSCOMMAND As Integer = &H112

        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32() = SC_CLOSE Then
            _AutoValidate = Me.AutoValidate
            Me.AutoValidate = Windows.Forms.AutoValidate.Disable
            _IsClosing = True
        End If
        MyBase.WndProc(m)
    End Sub

    Public Overridable Sub InicializarForma()

    End Sub

    Public Overridable Sub Modo(ByVal Edicion As Boolean)

    End Sub

#End Region

#Region "Acciones del Menu"

    Public Overridable Function Buscar() As Boolean

    End Function

    Public Overridable Function Limpiar() As Boolean

    End Function

    Public Overridable Function Cancelar() As Boolean
        Me.Limpiar()
        Me.Modo(False)
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        Me.Estado = FormState.Cancelar
        Return True
    End Function

    Public Overridable Function Nuevo() As Boolean

    End Function

    Public Overridable Function Guardar(ByVal Trans As HC.Transaction) As Boolean

    End Function

    Public Overridable Function Borrar(ByVal Trans As HC.Transaction) As Boolean

    End Function

    Public Overridable Function Editar() As Boolean
        Me.Modo(True)
        Return True
    End Function

    Public Overridable Function Imprimir() As Boolean

    End Function

    Public Overridable Function Salir() As Boolean
        _AutoValidate = Me.AutoValidate
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()

        If Not Me.IsClosing Then
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Eventos"

    Protected Sub tbrMenu_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles tbrMenu.ClickBuscar, tbrMenu.ClickBorrar, tbrMenu.ClickCancelar, tbrMenu.ClickEditar, tbrMenu.ClickGuardar, tbrMenu.ClickImprimir, tbrMenu.ClickLimpiar, tbrMenu.ClickNuevo, tbrMenu.ClickSalir
        Dim Resultado As Object = Nothing
        Dim Parametros As New Collection
        Dim Trans As HC.Transaction = Nothing

        Cursor = Cursors.WaitCursor

        If e.Button.Text = "Guardar" OrElse e.Button.Text = "Borrar" Then
            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, e.Button.Text)
            End If
            Parametros.Add(Trans)
        End If

        Resultado = Utilerias.RunControlException(Me, e.Button.Text, Parametros)

        If Resultado Is Nothing OrElse CType(Resultado, Boolean) = False Then
            Cancelar = True

            If Trans IsNot Nothing Then
                Trans.Rollback()
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub MeatForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If tbrMenu.CurrentToolBarButtonStatus And (MEAToolBar.MEAToolBar.ToolBarButtonEnum.Nuevo Or MEAToolBar.MEAToolBar.ToolBarButtonEnum.Editar) Then
            If MessageBox.Show("La Ventana se cerrara y los datos capturados se limpiaran, ¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                _IsClosing = False
                Me.AutoValidate = _AutoValidate
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

End Class