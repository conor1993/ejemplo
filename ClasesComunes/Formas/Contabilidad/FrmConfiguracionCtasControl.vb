Imports ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class FrmConfiguracionCtasControl

    Dim CuentasContables As CuentaContableCollectionClass
    Dim ConfiCol As ConfiguracionCtasCtrolColeccion

#Region "Forma"

    Private Sub ConfiguracionCtasControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Limpiar")

            Me.dgvcuentas.AutoGenerateColumns = False

            'obtener cuentas contables
            CuentasContables = New CuentaContableCollectionClass
            ConfiCol = New ConfiguracionCtasCtrolColeccion

            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub Limpiar()
        Me.clmCuentaContable.DataSource = Nothing
        Me.dgvcuentas.DataSource = Nothing

        CuentasContables.Obtener()
        ConfiCol.ObtenerConceptos()

        Me.clmCuentaContable.DisplayMember = "NombreYCuenta"
        Me.clmCuentaContable.ValueMember = "Codigo"
        Me.clmCuentaContable.DataSource = CuentasContables
        Me.dgvcuentas.DataSource = ConfiCol
    End Sub

#End Region

#Region "MEAToolBar"

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "guardar")

        Try
            Me.Validate()
            Dim ConfiguracionesControl As New ConfiguracionCtasCtrolColeccion

            For Each Configuracion As ConfiguracionCtasCtrlClass In Me.ConfiCol
                If Configuracion.IdCuentaContable <> 0 Then
                    ConfiguracionesControl.Add(Configuracion)
                End If
            Next

            If Not ConfiguracionesControl.Count > 0 Then
                MessageBox.Show("No se ha especificado ninguna configuracion", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            ConfiguracionesControl.Guardar(Trans)
            Trans.Commit()
            MessageBox.Show("Se ha registrado la configuracion satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Trans.Rollback()

#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim previsualizar As New PreVisualizarForm
            previsualizar.Reporte = Me.ConfiCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            previsualizar.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub dgvcuentas_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvcuentas.DataError

    End Sub

    Private Sub dgvcuentas_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvcuentas.EditingControlShowing
        If clmCuentaContable.Index = dgvcuentas.CurrentCell.ColumnIndex Then
            Dim CmbCuentasContables As DataGridViewComboBoxEditingControl = CType(e.Control, DataGridViewComboBoxEditingControl)
            Dim ConceptoConfiguracion As ConCfgCtasClass = CType(dgvcuentas.CurrentRow.DataBoundItem, ConfiguracionCtasCtrlClass).Concepto
            Dim Lista As New List(Of CuentaContableClass)

            If CmbCuentasContables.DataSource IsNot Nothing Then
                For Each CuentaContable As CuentaContableClass In CType(CmbCuentasContables.DataSource, CuentaContableCollectionClass)
                    If ConceptoConfiguracion.Afectable.HasValue Then
                        If ConceptoConfiguracion.Afectable.Value Then
                            If CuentaContable.Afectable = Integra.Clases.SiNoEnum.SI Then
                                Lista.Add(CuentaContable)
                            End If
                        Else
                            If CuentaContable.Afectable = Integra.Clases.SiNoEnum.NO Then
                                Lista.Add(CuentaContable)
                            End If
                        End If
                    Else
                        Lista.Add(CuentaContable)
                    End If
                Next
            End If
            CmbCuentasContables.DataSource = Lista
        End If
    End Sub

#End Region

End Class