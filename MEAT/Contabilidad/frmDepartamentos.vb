Public Class frmDepartamentos

#Region "Miembros"
    Private departamento As ClasesNegocio.DepartamentosClass

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.lblEstatus.Text = "ESTATUS"
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub Habilitar()
        Me.txtDescripcion.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtDescripcion.Enabled = False
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.DepartamentosC.Obtener(ClasesNegocio.CondicionEstatusDepartamento.TODOS)

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al abrir la ventana de departamentos", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Cursor = Cursors.WaitCursor

            If departamento.Borrar Then
                MsgBox("Se a Inactivado el departamento", MsgBoxStyle.Information, "Aviso")
                Deshabilitar()
                Me.DepartamentosEdicion.Clear()
                Limpiar()
                Me.DepartamentosC.Obtener(ClasesNegocio.CondicionEstatusDepartamento.TODOS)
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

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
        Me.DepartamentosEdicion.Clear()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Try
            Cursor = Cursors.WaitCursor

            If Me.departamento.Estatus = ClasesNegocio.EstatusDepartamento.INACTIVO Then
                If MessageBox.Show("El departamento se encuentra INACTIVO, ¿Quiere ACTIVAR el departamento?", "Ediar Departamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    departamento.Estatus = ClasesNegocio.EstatusDepartamento.ACTIVO
                    Habilitar()
                    Me.lblEstatus.Visible = True
                Else
                    Cancelar = True
                End If
            ElseIf departamento.Estatus = ClasesNegocio.EstatusDepartamento.ACTIVO Then
                Habilitar()
                Me.lblEstatus.Visible = True
                Me.txtDescripcion.Focus()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al editar el departamento", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            Cursor = Cursors.WaitCursor

            Me.dgLista.Focus()
            departamento.Descripcion = txtDescripcion.Text

            Dim nuevo As Boolean = departamento.Entidad.IsNew

            If departamento.Guardar Then
                If nuevo Then
                    MsgBox("Se guardo con el código: " & departamento.Codigo, MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("Se an guardado los cambios del departamento", MsgBoxStyle.Information, "Aviso")
                End If

                Limpiar()
                Deshabilitar()
                Me.DepartamentosEdicion.Clear()
                Me.DepartamentosC.Obtener(ClasesNegocio.CondicionEstatusDepartamento.TODOS)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al gurdar el departamento", MsgBoxStyle.Critical, "Error")
#End If
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        departamento = New ClasesNegocio.DepartamentosClass
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            'Dim ventana As New ClasesNegocio.PreVisualizarForm
            'ventana.Text = "ABC de Departamentos"
            'ventana.Reporte = Me.DepartamentosC.Reporte(Controlador.Sesion)
            'ventana.ShowDialog()

            Cursor = Cursors.WaitCursor
            DepartamentosC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            If DepartamentosC.Count.ToString > 0 Then
                Dim Reporte As New ClasesNegocio.rptDepartamentos
                Dim VerReporte As New FrmReportes
                Reporte.SetDataSource(DepartamentosC)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Contabilidad\Departamentos")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Departamento", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgLista_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLista.CellClick
        Try
            If e.RowIndex > -1 Then
                If departamento Is Nothing Then departamento = New ClasesNegocio.DepartamentosClass

                departamento.Obtener(Me.DepartamentosC(e.RowIndex).Codigo)
                Me.DepartamentosEdicion.Add(departamento)
                Me.mtb.sbCambiarEstadoBotones("Buscar")
                Me.lblEstatus.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class