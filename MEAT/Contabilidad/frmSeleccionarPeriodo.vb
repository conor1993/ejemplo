Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class frmSeleccionarPeriodo
    Dim Ejercicio As CN.PeriodosContablesClass
    Private Sub frmSeleccionarPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            'MtbEstados.StateBuscar = "101101111"
            'MtbEstados.StateLimpiar = ""
            'MtbEstados.StateCancelar = "100100011"
            'MtbEstados.StateNuevo = "011010001"
            'MtbEstados.StateGuardar = "100100001"
            'MtbEstados.StateBorrar = "100100001"
            'MtbEstados.StateEditar = "001010001"
            'MtbEstados.StateImprimir = ""
            'MtbEstados.StateSalir = ""
            ''Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            'Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            'Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            'Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo periodo."
            'Me.mtb.Buttons(6).ToolTipText = "Guarda el periodo o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del periodo a Inactivo."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el periodo contable."
            '' Me.mtb.Buttons(10).ToolTipText = "Imprime las Ciudades Registradas."
            'Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            'Me.mtb.Buttons(1).Visible = False

            'mtb.ToolBarButtonStatus = MtbEstados
            'mtb.sbCambiarEstadoBotones("Nuevo")

            'obtener ejercicios dados de alta.
            Dim Periodos As New CN.PeriodosContablesCollectionClass
            Periodos.Obtener()
            Me.dgvPeriodos.AutoGenerateColumns = False
            Me.dgvPeriodos.DataSource = Periodos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Ejercicio = New CN.PeriodosContablesClass
            'cambiar el estado de cada uno de los periodos de activo a inactivo y viceversa
            For i As Integer = 0 To Me.dgvPeriodos.Rows.Count - 1
                Dim EjercicioContable As New CN.PeriodosContablesClass
                EjercicioContable.Obtener(Me.dgvPeriodos.Rows(i).Cells(Me.clmEjercicio.Index).Value)
                If Me.dgvPeriodos.Rows(i).Selected Then
                    EjercicioContable.Estatus = Integra.Clases.EstatusEnum.ACTIVO                   
                Else
                    EjercicioContable.Estatus = Integra.Clases.EstatusEnum.INACTIVO
                End If
                EjercicioContable.Borrar() 'este metodo tambien funciona para actualizar la lista de ejercicios contables
            Next

            'obtener de nuevo los periodos para mostrarlos a la vista
            Dim Periodos As New CN.PeriodosContablesCollectionClass
            Periodos.Obtener()
            Me.dgvPeriodos.AutoGenerateColumns = False
            Me.dgvPeriodos.DataSource = Periodos

            MessageBox.Show("El ejercicio ha sido activado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Me.mtb.sbCambiarEstadoBotones("Nuevo")
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class