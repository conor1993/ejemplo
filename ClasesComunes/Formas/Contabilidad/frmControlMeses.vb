Imports HC = Integralab.ORM.HelperClasses

Public Class frmControlMeses

#Region "Miembros"
    Dim mes As ClasesNegocio.ControlMesClass
    Dim Estatus As String = ""
    Dim Editando As Boolean = False
    Dim PeriodosContablesC As New ClasesNegocio.PeriodosContablesCollectionClass

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        'Me.nudAño.Value = 2000
        'Me.nudMes.Value = 1
        Me.cmbAño.SelectedIndex = -1
        Me.cmbMes.SelectedIndex = -1
        Me.chkEstatus.Checked = False
        editando = False
    End Sub

    Private Sub Deshabilitar()
        'Me.nudMes.Enabled = False
        'Me.nudAño.Enabled = False
        Me.cmbAño.Enabled = False
        Me.cmbMes.Enabled = False
        'Me.btnGenerarMeses.Enabled = False
        Me.chkEstatus.Enabled = False
        Me.dgLista.Enabled = True
    End Sub

    Private Sub Habilitar()
        'Me.nudMes.Enabled = True
        ' Me.nudAño.Enabled = True
        Me.cmbAño.Enabled = True
        Me.cmbMes.Enabled = True
        'Me.btnGenerarMeses.Enabled = True
        Me.chkEstatus.Enabled = True
        Me.dgLista.Enabled = False
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmControlMeses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.mtb.Buttons(1).Visible = False
            Me.ControlMesCollectionClass1.Obtener()

            PeriodosContablesC.Obtener()
            Me.cmbAño.DataSource = PeriodosContablesC
            Me.cmbAño.DisplayMember = "Ejercicio"
            Me.cmbAño.ValueMember = "Ejercicio"

            Me.cmbMes.DataSource = System.Enum.GetValues(GetType(ClasesNegocio.MesEnum2))

            Limpiar()
            Deshabilitar()

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana", MsgBoxStyle.Critical, "Error")
#End If
            Close()
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If cmbAño.SelectedIndex = -1 Then
            MsgBox("Seleccione un año.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
            Return
        End If
        If cmbMes.SelectedIndex = -1 Then
            MsgBox("Seleccione un mes.", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Cancelar = True
            Return
        End If
        If Editando = True Then
            Editar()
        Else
            Guardar()
        End If

        '        Try
        '            validar que el periodo a crear meses se encuentre dado de alta.
        '            Dim Ejercicios As New ClasesNegocio.PeriodosContablesClass
        '            Ejercicios.Obtener(Me.nudAño.Value)
        '            If Ejercicios.Ejercicio = Me.nudAño.Value Then
        '                mes.Año = CInt(Me.nudAño.Value)
        '                mes.Mes = CInt(Me.nudMes.Value)
        '                mes.Estatus = dgLista.SelectedRows(0).Cells(2).Value
        '                If Not mes.Entidad.IsNew Then
        '                    If IIf(chkEstatus.Checked, 83, 78) <> mes.Estatus Then
        '                        If Me.chkEstatus.Checked Then
        '                            If CInt(Me.mes.Año) = Now.Year And Me.mes.Mes = Now.Month Then
        '                            ElseIf CInt(Me.mes.Año) = Now.Year And Me.mes.Mes < Now.Month Then
        '                                If MessageBox.Show("El mes que intenta abrir es anterior al mes actual, los saldos de sus cuentas seran modificados, ¿desea abrirlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '                                    dgLista.Enabled = True
        '                                    Exit Sub
        '                                End If
        '                            ElseIf CInt(Me.mes.Año) < Now.Year And Me.mes.Mes = ClasesNegocio.MesEnum2.DICIEMBRE Then
        '                                If MessageBox.Show("El mes que intenta abrir es diciembre del pasado año, los saldos de sus cuentas seran modificados, ¿desea abrirlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '                                    dgLista.Enabled = True
        '                                    Exit Sub
        '                                End If
        '                            Else
        '                                MsgBox("Solo se permite modificar periodos actuales o pasados", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
        '                                dgLista.Enabled = True
        '                                Exit Sub
        '                            End If
        '                        Else
        '                            If Not (CInt(Me.mes.Año) = Now.Year And Me.mes.Mes = Now.Month) Then
        '                                If MessageBox.Show("Si cierra el mes ya no se le podran realizar modificaciones, ¿desea cerrarlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '                                    dgLista.Enabled = True
        '                                    Exit Sub
        '                                End If
        '                            End If
        '                        End If
        '                    Else
        '                        dgLista.Enabled = True
        '                        Exit Sub
        '                    End If
        '                End If
        '                If Me.chkEstatus.Checked Then
        '                    mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO
        '                Else
        '                    mes.Estatus = ClasesNegocio.EstatusMes.CERRADO
        '                End If
        '                If mes.Guardar Then
        '                    MsgBox("Se guardo el mes", MsgBoxStyle.Information, "Aviso")
        '                    Limpiar()
        '                    Deshabilitar()
        '                    Me.ControlMesCollectionClass1.Obtener()
        '                    dgLista.Enabled = True
        '                Else
        '                    Cancelar = True
        '                End If
        '            Else
        '                MsgBox("Ejercicio contable no se enecuentra disponible para asignarle meses", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
        '       End If
        '        Catch ex As Exception
        '#If CONFIG = "Debug" Then
        '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '#Else
        '            MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
        '#End If
        '            Cancelar = True
        '        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Editando = False
        mes = New ClasesNegocio.ControlMesClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        Me.chkEstatus.Enabled = True
        Me.chkEstatus.Focus()
        Editando = True
        chkEstatus.Enabled = True
        dgLista.Enabled = False
    End Sub

#End Region

    Private Sub Editar()
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "ModificarEstatus")
        Try
            Me.Validate()

            If Me.chkEstatus.Checked = True Then
                Estatus = "S"
            Else
                Estatus = "N"
            End If

            mes.ModificarEstatus(Estatus, trans)
            trans.Commit()
            Deshabilitar()
            Limpiar()
            MessageBox.Show("Se ha modificado correctamente.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ControlMesCollectionClass1.Obtener()
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Guardar()
        Try
            'validar que el periodo a crear meses se encuentre dado de alta.
            Dim Ejercicios As New ClasesNegocio.PeriodosContablesClass
            'Ejercicios.Obtener(Me.nudAño.Value)
            Ejercicios.Obtener(Me.cmbAño.SelectedValue)
            If Ejercicios.Estatus = Integra.Clases.EstatusEnum.INACTIVO Then
                MsgBox("Ejercicio contable no se encuentra disponible para asignarle meses contables", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Else
                
                mes.Año = Me.cmbAño.SelectedValue
                mes.Mes = Me.cmbMes.Items(Me.cmbMes.SelectedValue - 1).GetHashCode

                'mes.Año = CInt(Me.nudAño.Value)
                'mes.Mes = CInt(Me.nudMes.Value)
                If dgLista.RowCount > 0 Then
                    mes.Estatus = dgLista.SelectedRows(0).Cells(2).Value
                Else
                    mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO
                End If

                If Not mes.Entidad.IsNew Then
                    If IIf(chkEstatus.Checked, 83, 78) <> mes.Estatus Then
                        If Me.chkEstatus.Checked Then
                            If CInt(Me.mes.Año) = Now.Year And Me.mes.Mes = Now.Month Then

                            ElseIf CInt(Me.mes.Año) = Now.Year And Me.mes.Mes < Now.Month Then
                                If MessageBox.Show("El mes que intenta abrir es anterior al mes actual, los saldos de sus cuentas seran modificados, ¿desea abrirlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                    dgLista.Enabled = True
                                    Exit Sub
                                End If
                            ElseIf CInt(Me.mes.Año) < Now.Year And Me.mes.Mes = ClasesNegocio.MesEnum2.DICIEMBRE Then
                                If MessageBox.Show("El mes que intenta abrir es diciembre del pasado año, los saldos de sus cuentas seran modificados, ¿desea abrirlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                    dgLista.Enabled = True
                                    Exit Sub
                                End If
                            Else
                                MsgBox("Solo se permite modificar periodos actuales o pasados", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                                dgLista.Enabled = True
                                Exit Sub
                            End If
                        Else
                            If Not (CInt(Me.mes.Año) = Now.Year And Me.mes.Mes = Now.Month) Then
                                If MessageBox.Show("Si cierra el mes ya no se le podran realizar modificaciones, ¿desea cerrarlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                                    dgLista.Enabled = True
                                    Exit Sub
                                End If
                            End If
                        End If
                    Else
                        dgLista.Enabled = True
                        Exit Sub
                    End If
                End If

                If Me.chkEstatus.Checked Then
                    mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO
                Else
                    mes.Estatus = ClasesNegocio.EstatusMes.CERRADO
                End If

                If mes.Guardar Then
                    MsgBox("Se Guardo el Mes", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                    Me.ControlMesCollectionClass1.Obtener()
                    dgLista.Enabled = True
                End If

            End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
#End If
        End Try
        'If mes.GenerarMeses(Me.nudAño.Value) Then
        '    MsgBox("Se generaron lo mes", MsgBoxStyle.Information, "Aviso")
        '    Limpiar()
        '    Deshabilitar()
        '    Me.mtb.sbCambiarEstadoBotones("Cancelar")
        '    Me.ControlMesCollectionClass1.Obtener()
        'End If
    End Sub

    Private Sub dgLista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLista.CellClick
        Try
            If e.RowIndex > -1 Then
                mes = New ClasesNegocio.ControlMesClass(Me.ControlMesCollectionClass1(e.RowIndex).Año, CInt(Me.ControlMesCollectionClass1(e.RowIndex).Mes).ToString("00"))

                'Me.nudAño.Value = CDec(mes.Año)
                'Me.nudMes.Value = CDec(mes.Mes)

                Me.cmbAño.Text = CDec(mes.Año)
                If mes.Mes = ClasesNegocio.MesEnum2.ENERO Then
                    Me.cmbMes.SelectedIndex = 0
                Else
                    Me.cmbMes.SelectedIndex = Me.cmbMes.Items(CDec(mes.Mes - 2)).GetHashCode()
                End If

                Me.chkEstatus.Checked = mes.Estatus = ClasesNegocio.EstatusMes.ABIERTO
                Me.mtb.sbCambiarEstadoBotones("Buscar")
                chkEstatus.Enabled = False
            Else
                Limpiar()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class