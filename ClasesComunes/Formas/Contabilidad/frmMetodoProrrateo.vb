Imports ClasesNegocio

Public Class frmMetodoProrrateo

#Region "Miembros"
    Dim WithEvents metodo As New ClasesNegocio.MetodoProrrateoClass

#End Region

#Region "Eventos"

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.dgDetalle.DataSource = Nothing
        Me.txtTotalPorcentaje.Text = 0
    End Sub

    Private Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
        Me.txtCodigo.Enabled = False
        Me.dgDetalle.Enabled = False
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
        Me.txtCodigo.Enabled = False
        Me.dgDetalle.Enabled = True
    End Sub

    Private Sub ObtenerValores()
        Me.txtCodigo.Text = metodo.Codigo
        Me.txtDescripcion.Text = metodo.Descripcion
        Me.dgDetalle.AutoGenerateColumns = False
        Me.dgDetalle.DataSource = metodo.Detalle
        SumaPorcentajes()
    End Sub

    Private Sub Imprimir()

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMetodoProrrateo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "001101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Limpiar()
            Deshabilitar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana de metodos de prorrateo", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Cursor = Cursors.WaitCursor

            If metodo.Borrar Then
                MsgBox("Se a Inactivado el metodo de prorrateo.", MsgBoxStyle.Information, "Aviso")
                Deshabilitar()

                Limpiar()
                'Me.DepartamentosC.Obtener(ClasesNegocio.CondicionEstatusDepartamento.TODOS)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al inactivar el departamento", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim ventana As New frmBusquedaMetodoProrrateo

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.metodo = CType(ventana.DataGridView1.SelectedRows(0).DataBoundItem, ClasesNegocio.MetodoProrrateoClass)
                ObtenerValores()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los metodos", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            metodo.Descripcion = Me.txtDescripcion.Text
            'metodo.SumaPorcentaje = Me.txtTotalPorcentaje.Text

            If Me.metodo.Guardar Then
                MsgBox("Se a guardado con el código " & Me.metodo.Codigo, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            MetodoProrrateoCollectionClass.Imprimir(Controlador.Sesion)
        Catch ex As Exception
            If ex.Message <> "No se encuentro ningun metodo de prorrateo" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
            End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Try
            Cursor = Cursors.WaitCursor
            Limpiar()
            Habilitar()
            Me.metodo = New ClasesNegocio.MetodoProrrateoClass
            Me.dgDetalle.AutoGenerateColumns = False
            Me.dgDetalle.DataSource = Me.metodo.Detalle
            Me.txtDescripcion.Focus()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al inicializar los controles", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub dgDetalle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDetalle.CellEndEdit
        SumaPorcentajes()
    End Sub

    Private Sub dgDetalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgDetalle.DataError

    End Sub

    Private Sub dgDetalle_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgDetalle.EditingControlShowing
        If Me.dgDetalle.CurrentCell.ColumnIndex = Me.clmPorcentaje.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf KeyControl
            AddHandler e.Control.KeyPress, AddressOf KeyControl
            RemoveHandler e.Control.TextChanged, AddressOf textChange
            AddHandler e.Control.TextChanged, AddressOf textChange
        End If
    End Sub

    Private Sub KeyControl(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = Chr(8)) OrElse (e.KeyChar = "."c AndAlso TryCast(sender, TextBox).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub textChange(ByVal sender As Object, ByVal e As EventArgs)
        Dim t As TextBox = TryCast(sender, TextBox)

        If Not t.Text = "" AndAlso t.Text = "." Then
            If CDec(t.Text) > 100D Then
                t.Text = 100
            End If
        End If
    End Sub

    Private Sub metodo_ProcentajeModificado(ByVal sender As Object, ByRef valor As Decimal) Handles metodo.ProcentajeModificado
        Me.txtTotalPorcentaje.Text = metodo.SumaPorcentaje '& " %"
    End Sub

    Private Sub SumaPorcentajes()
        Try
            Me.txtTotalPorcentaje.Text = 0
            For i As Integer = 0 To Me.dgDetalle.Rows.Count - 1
                Me.txtTotalPorcentaje.Text = CDbl(Me.txtTotalPorcentaje.Text) + Me.dgDetalle.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                metodo.Detalle(i).Porcentaje = Me.dgDetalle.Rows(i).Cells(Me.clmPorcentaje.Index).Value
            Next
            'metodo.SumaPorcentaje = CDbl(Me.txtTotalPorcentaje.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class