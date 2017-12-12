Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class frmTraspasodeCuentas
    Private Sub frmTraspasodeCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010011"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            Me.mtb.Buttons(0).ToolTipText = "Busca los Registros de Estados Financieros Registrados"
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea un nuevo Registro de Estados Financieros."
            Me.mtb.Buttons(6).ToolTipText = "Guarda el Registro de Estados Financieros o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus del Banco."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar el Banco."
            Me.mtb.Buttons(10).ToolTipText = "Imprime Los resgistros de Estados Financieros Registrados."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            'mtb.sbCambiarEstadoBotones("Guardar")

        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Cuenta")
        Try
            Dim CuentasContables As New CN.CuentaContableCollectionClass 'obtener cuentas contables para traspaso
            Dim PeriodosContables As New CC.PeriodosContCollection 'obtener periodo vigente
            'verificar si el periodo existe y esta vigente
            If PeriodosContables.GetMulti(HC.PeriodosContFields.Estatus = CN.EstatusEnum.ACTIVO, 0, Nothing) Then
                If MessageBox.Show("¿ En el Periodo Contable Activo " + CStr(PeriodosContables(0).Ejercicio) + " Se traspasaran las cuenta, esta seguro ?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            Else
                MessageBox.Show("No existen periodos contables para la actualizacion de cuentas en acumulados de saldos", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If CuentasContables.Obtener > 0 Then
                For i As Integer = 0 To CuentasContables.Count - 1
                    Dim PasarCuentasAcumulados As New CN.AcumuladodeCuentasContablesClass
                    PasarCuentasAcumulados.Codigo = CuentasContables(i).Codigo
                    PasarCuentasAcumulados.Ejercicio = PeriodosContables(0).Ejercicio
                    If Not PasarCuentasAcumulados.Obtener(PasarCuentasAcumulados.Codigo, PasarCuentasAcumulados.Codigo) Then
                        If Not PasarCuentasAcumulados.Guardar(Trans) Then
                            Trans.Rollback()
                        End If
                    End If
                Next               
            End If
            Trans.Commit()
            MessageBox.Show("Traspaso de Cuentas de Realizo con Exito", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class