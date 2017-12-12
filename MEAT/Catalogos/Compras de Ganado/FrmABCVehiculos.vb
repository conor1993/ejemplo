Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmABCVehiculos
    Dim Vehiculo As CN.VehiculosClass
    Dim VehiculosCol As CN.VehiculosCollectionClass

    Private Sub FrmABCVehiculos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "010101111"
            MtbEstados.StateLimpiar = "100100011"
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001011101"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            MEAToolBar1.ToolBarButtonStatus = MtbEstados

            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            Limpiar()
            DesHabilitar()

            LlenarGrid()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub LlenarGrid()
        VehiculosCol = New CN.VehiculosCollectionClass
        VehiculosCol.Obtener(ClasesNegocio.EstatusCharX.TODOS)
        Me.DgvVehiculos.AutoGenerateColumns = False
        Me.DgvVehiculos.DataSource = VehiculosCol
    End Sub

    Private Sub Limpiar()
        Me.DtpFechaCompra.Value = Now
        Me.TxtCodigo.Text = ""
        Me.TxtDescCorta.Text = ""
        Me.txtDescripcion.Text = ""
        txtModelo.Text = ""
        Me.txtObservaciones.Text = ""
        Me.txtPlacas.Text = ""
        Me.txtSerie.Text = ""
        Me.Txtfiltro.Text = ""
        Me.txtMarca.Text = ""
        Me.lblEstatus.Visible = False
        MEAToolBar1.sbCambiarEstadoBotones("Limpiar")
    End Sub

    Private Sub Habilitar()
        Me.DtpFechaCompra.Enabled = True
        Me.TxtDescCorta.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtModelo.Enabled = True
        Me.txtMarca.Enabled = True
        Me.txtObservaciones.Enabled = True
        Me.txtSerie.Enabled = True
        Me.txtPlacas.Enabled = True
        Me.DgvVehiculos.Enabled = False
        Me.Txtfiltro.Enabled = False
    End Sub

    Private Sub DesHabilitar()
        Me.DtpFechaCompra.Enabled = False
        Me.TxtDescCorta.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.txtModelo.Enabled = False
        Me.txtMarca.Enabled = False
        Me.txtObservaciones.Enabled = False
        Me.txtSerie.Enabled = False
        Me.txtPlacas.Enabled = False
        Me.DgvVehiculos.Enabled = True
        Me.Txtfiltro.Enabled = True
    End Sub

    Private Function Guardar() As Boolean
        Try
            Vehiculo.Descripcion = Me.txtDescripcion.Text
            Vehiculo.DesCorta = Me.TxtDescCorta.Text
            Vehiculo.FechaCompra = Me.DtpFechaCompra.Value
            Vehiculo.Marca = Me.txtMarca.Text
            Vehiculo.Placas = Me.txtPlacas.Text
            Vehiculo.NoSerie = Me.txtSerie.Text
            Vehiculo.Observaciones = Me.txtObservaciones.Text
            Vehiculo.Modelo = Me.txtModelo.Text


            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.TxtCodigo.Text = Vehiculo.Codigo
        Me.txtDescripcion.Text = Vehiculo.Descripcion
        Me.TxtDescCorta.Text = Vehiculo.DesCorta
        Me.DtpFechaCompra.Value = Vehiculo.FechaCompra
        Me.txtMarca.Text = Vehiculo.Marca
        Me.txtPlacas.Text = Vehiculo.Placas
        Me.txtSerie.Text = Vehiculo.NoSerie
        Me.txtObservaciones.Text = Vehiculo.Observaciones
        Me.txtModelo.Text = Vehiculo.Modelo
        Me.lblEstatus.Text = Vehiculo.Estatus.ToString
        Me.lblEstatus.Visible = True
    End Sub

    Private Function Validar() As Boolean

        If Me.txtDescripcion.Text = "" Then
            MessageBox.Show("Ingrese la Descripcion del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Me.TxtDescCorta.Text = "" Then
            MessageBox.Show("Ingrese la Descripcion Corta del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Me.txtMarca.Text = "" Then
            MessageBox.Show("Ingrese la marca del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Me.txtPlacas.Text = "" Then
            MessageBox.Show("Ingrese las placas del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Me.txtModelo.Text = "" Then
            MessageBox.Show("Ingrese el modelo del Vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Key Press"

    Private Sub DtpFechaCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaCompra.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtDescCorta.Focus()
        End If
    End Sub

    Private Sub TxtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtMarca.Focus()
        End If
    End Sub

    Private Sub txtMarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarca.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtModelo.Focus()
        End If
    End Sub

    Private Sub txtModelo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModelo.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtPlacas.Focus()
        End If
    End Sub

    Private Sub txtPlacas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPlacas.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSerie.Focus()
        End If
    End Sub

    Private Sub txtSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtObservaciones.Focus()
        End If
    End Sub

    Private Sub txtObservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcion.Focus()
        End If
    End Sub
#End Region

#Region "Tool Bar"

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBorrar
        Try
            If Vehiculo.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MessageBox.Show("No se puede cancelar el Vehiculo, ya se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If

            If MessageBox.Show("Esta seguro de cancelar el Vehiculo", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Vehiculo.Estatus = ClasesNegocio.EstatusEnum.INACTIVO
            Vehiculo.FechaBaja = Now
            Vehiculo.IdUsuarioBaja = Controlador.Sesion.MiUsuario.Usrndx

            If Not Vehiculo.Borrar() Then
                Cancelar = True
                Exit Sub
            End If

            MessageBox.Show("El Vehiculo ha sido Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            DesHabilitar()
            LlenarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        DesHabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        If Vehiculo.Estatus = ClasesNegocio.EstatusChar.CANCELADO Then
            If MessageBox.Show("El Vehiculo esta inactivo, ¿Quiere Activarlo?", "ACtivar Vehiculo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Vehiculo.Estatus = ClasesNegocio.EstatusChar.VIGENTE
                Habilitar()
            Else
                Cancelar = True
            End If
            'MessageBox.Show("No se puede editar el vehiculo, se encuentra cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Cancelar = True
            'Exit Sub
        Else
            Habilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Vehiculo.Guardar Then
                Cancelar = True
                Exit Sub
            End If

            MessageBox.Show("Se ha guardado el Vehiculo: " & Vehiculo.Codigo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            DesHabilitar()
            LlenarGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            VehiculosCol.Obtener()
            If VehiculosCol.Count.ToString > 0 Then
                Dim Reporte As ClasesNegocio.rptCatVehiculos = VehiculosCol.Reporte
                Dim VerReporte As New FrmReportes
                'Reporte.SetDataSource(VehiculosCol)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue(2, "Catalogos\Compras de Ganado\Vehiculos")
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Vehiculos", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        Habilitar()
        Me.Vehiculo = New CN.VehiculosClass
        Me.DtpFechaCompra.Focus()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub
#End Region

#Region "Grid"
    Private Sub DgvVehiculos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvVehiculos.Click
        Try
            If Me.DgvVehiculos.SelectedRows.Count > 0 Then
                Vehiculo = DirectCast(Me.DgvVehiculos.SelectedRows(0).DataBoundItem, CN.VehiculosClass)
                PonerDatos()
                Me.MEAToolBar1.sbCambiarEstadoBotones("Editar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvVehiculos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvVehiculos.DataError

    End Sub

    Private Sub DgvVehiculos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvVehiculos.RowEnter
        Try
            If Me.DgvVehiculos.SelectedRows.Count > 0 Then
                Vehiculo = DirectCast(Me.DgvVehiculos.SelectedRows(0).DataBoundItem, CN.VehiculosClass)
                PonerDatos()
                Me.MEAToolBar1.sbCambiarEstadoBotones("Editar")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub Txtfiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtfiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.VehiculosCol = New CN.VehiculosCollectionClass

            VehiculosCol.Obtener(ClasesNegocio.EstatusCharX.TODOS)
            Me.DgvVehiculos.AutoGenerateColumns = False
            Me.DgvVehiculos.DataSource = VehiculosCol
        End If
        If Me.Txtfiltro.Text.Length > 4 Then
            Me.VehiculosCol = New CN.VehiculosCollectionClass

            VehiculosCol.Obtener(ClasesNegocio.EstatusCharX.TODOS, Me.Txtfiltro.Text)
            Me.DgvVehiculos.AutoGenerateColumns = False
            Me.DgvVehiculos.DataSource = VehiculosCol
        End If
    End Sub

End Class