Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ABCPeriodosContables
    Dim Ejercicio As CN.PeriodosContablesClass

    Private Sub ABCPeriodosContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            'Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo periodo."
            Me.mtb.Buttons(6).ToolTipText = "Guarda el periodo o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del periodo a Inactivo."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el periodo contable."
            ' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            Me.mtb.Buttons(1).Visible = False

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Me.txtPeriodo.MaxLength = 4
            Me.txtPeriodo.Enabled = False
            Me.PeriodosContablesC.Obtener()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
    '    Try
    '        If Ejercicio.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
    '            MessageBox.Show("No se puede cancelar el ejercicio contable, ya se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Cancelar = True
    '            Exit Sub
    '        End If

    '        If MessageBox.Show("¿Esta seguro de cancelar el ejercicio contable?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            Ejercicio.Estatus = Integra.Clases.EstatusEnum.INACTIVO
    '            Ejercicio.Borrar()
    '            MessageBox.Show("El ejercicio contable ha sido cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Me.PeriodosContablesC.Obtener()
    '            Me.txtPeriodo.Text = ""
    '            Me.txtPeriodo.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        Cancelar = True
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub.

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.txtPeriodo.Text = ""
        Me.txtPeriodo.Enabled = False
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        If Ejercicio.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
            MessageBox.Show("No se puede editar el periodo, se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cancelar = True
            Exit Sub
        End If
        Me.txtPeriodo.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.txtPeriodo.Text = "" Then
                MessageBox.Show("Ingrese el ejercicio contable", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            'obtener los ejercicios actuales y cancelarlos
            For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                Dim EjercicioContable As New CN.PeriodosContablesClass
                EjercicioContable.Obtener(Me.DataGridView1.Rows(i).Cells(0).Value)
                EjercicioContable.Estatus = Integra.Clases.EstatusEnum.INACTIVO
                EjercicioContable.Borrar()
            Next
            'guardar nuevo ejercicio 
            Ejercicio.Ejercicio = Me.txtPeriodo.Text
            Ejercicio.Estatus = Integra.Clases.EstatusEnum.ACTIVO
            If Ejercicio.Guardar() Then
                Me.PeriodosContablesC.Obtener()
                Me.txtPeriodo.Text = ""
                Me.txtPeriodo.Enabled = False
                MessageBox.Show("El ejercicio ha sido guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.txtPeriodo.Text = ""
    End Sub


    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.txtPeriodo.Enabled = True
        Me.txtPeriodo.Text = ""
        Ejercicio = New CN.PeriodosContablesClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Ejercicio = DirectCast(Me.DataGridView1.SelectedRows(0).DataBoundItem, CN.PeriodosContablesClass)
                Me.txtPeriodo.Text = Ejercicio.Ejercicio
                Me.txtPeriodo.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Ejercicio = DirectCast(Me.DataGridView1.SelectedRows(0).DataBoundItem, CN.PeriodosContablesClass)
                Me.txtPeriodo.Text = Ejercicio.Ejercicio
                Me.txtPeriodo.Enabled = False
                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtPeriodo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeriodo.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.mtb_ClickGuardar(sender, New ToolBarButtonClickEventArgs(Me.mtb.Buttons(6)), False)
        End If
    End Sub
End Class