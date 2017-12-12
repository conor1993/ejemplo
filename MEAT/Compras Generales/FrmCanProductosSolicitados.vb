Imports HC = IntegraLab.ORM.HelperClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports ClasesNegocio

Public Class FrmCanProductosSolicitados

    Private Sub ComCanProductosSolicitados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = ""
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "000100011"
            MtbEstados.StateNuevo = "111010001"
            MtbEstados.StateGuardar = "000100011"
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            'Dim x As TC.vwcom
            MEAToolBar1.ToolBarButtonStatus = MtbEstados
            MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

            Me.dgvProductos.AutoGenerateColumns = False

            PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

            Dim colplz As New ClasesNegocio.PlazaCollectionClass
            Dim p As New ClasesNegocio.PlazaClass

            p.Descripcion = "TODAS"
            colplz.Add(p)

            For Each plaza As ClasesNegocio.PlazaClass In PlazaC
                colplz.Add(plaza)
            Next
            cmbPlaza.DataSource = colplz
            cmbPlaza.DisplayMember = "Descripcion"
            cmbPlaza.ValueMember = "Codigo"

            Deshabilitar()
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(CType(sender, Control), True, True, False, True)
            cmbSucursal.Focus()
            If cmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza")
                cmbPlaza.Focus()
            End If
        End If
    End Sub

#Region "Private"

    Private Sub limpiar()
        Me.cmbPlaza.SelectedIndex = -1
        Me.cmbSucursal.SelectedIndex = -1
        cmbPlaza.Text = "Seleccione Plaza"
        cmbSucursal.Text = "Seleccione Sucursal"
        Me.dgvProductos.DataSource = Nothing
    End Sub

    Private Sub habilitar()
        cmbPlaza.Enabled = True
        cmbSucursal.Enabled = True
        Me.dgvProductos.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        cmbPlaza.Enabled = False
        cmbSucursal.Enabled = False
        Me.dgvProductos.Enabled = False
    End Sub

#End Region

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim Solicitudes As New SolicitudProductoDetalleCollectionClass
            Dim Filtro As New OC.PredicateExpression(HC.SolicitudProductoDetalleFields.Estatus = SolicitudProductoDetalleClass.EstatusSolicitudDetalle.VIGENTE)
            Dim Relacion As New OC.RelationCollection
            Dim PLazaId As Integer = -1
            Dim sucursalid As Integer = -1

            Relacion.Add(EC.SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)

            If cmbPlaza.SelectedIndex > 0 Then
                Relacion.Add(EC.SolicitudProductoEntity.Relations.SucursalEntityUsingIdSucursal)
                Filtro.Add(HC.SucursalFields.CodigoPlaza = CType(cmbPlaza.SelectedValue, Integer))
            End If

            If cmbSucursal.SelectedIndex > 0 Then
                Filtro.Add(HC.SolicitudProductoFields.IdSucursal = CType(cmbSucursal.SelectedValue, Integer))
            End If
            Solicitudes.Obtener(Filtro, Nothing, Relacion)
            Me.dgvProductos.DataSource = Solicitudes

            Me.Cantidad.DataPropertyName = "Cantidad"
            Me.Codigo.DataPropertyName = "IdProducto"
            Me.Folio.DataPropertyName = "FolioSolicitud"
            Me.Producto.DataPropertyName = "Producto"
            Me.clmFiniquito.DataPropertyName = "Seleccionado"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        Dim Trans As New IntegraLab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Cancela Productos")
        Dim Solicitudes As New SolicitudProductoCollectionClass

        Try
            If MessageBox.Show("Se cancelaran los productos solicitados que esta seleccionados, ¿Esta Seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To Me.dgvProductos.Rows.Count - 1
                    If CType(Me.dgvProductos.Rows(i).Cells(clmFiniquito.Index).Value, Boolean) Then
                        Dim SolicitudDetalle As SolicitudProductoDetalleClass = CType(Me.dgvProductos.Rows(i).DataBoundItem, SolicitudProductoDetalleClass)

                        If Not Solicitudes.Contains(SolicitudDetalle.IdSolicitud) Then
                            Solicitudes.Add(SolicitudDetalle.SolicitudProducto)
                        End If
                        SolicitudDetalle.Estatus = SolicitudProductoDetalleClass.EstatusSolicitudDetalle.CANCELADA
                        SolicitudDetalle.Guardar(Trans)
                    End If
                Next

                For Each Solicitud As SolicitudProductoClass In Solicitudes
                    Dim SolicitudesDetalle As New CC.SolicitudProductoDetalleCollection

                    Trans.Add(SolicitudesDetalle)
                    SolicitudesDetalle.GetMulti(HC.SolicitudProductoDetalleFields.Estatus <> SolicitudProductoDetalleClass.EstatusSolicitudDetalle.CANCELADA And _
                    HC.SolicitudProductoDetalleFields.IdSolicitud = Solicitud.IdSolicitud)

                    If SolicitudesDetalle.Count = 0 Then
                        Solicitud.IdUsuarioCancelacion = Controlador.Sesion.MiUsuario.Usrndx
                        Solicitud.ObservacionesCancelacion = "Cancelacion de Productos Solicitados"
                        Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.CANCELADA
                        Solicitud.FechaCancelacion = Now
                        Trans.Add(Solicitud.Entidad)
                        Solicitud.Entidad.Save()
                    End If
                Next
                limpiar()
                Deshabilitar()
                Trans.Commit()
                MsgBox("Se han cancelado los Productos Solicitado satisfactoriamente", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > 0 Then
            SucursalC.Clear()
            Dim suc As New ClasesNegocio.SucursalClass
            suc.Descripcion = "TODAS"
            SucursalC.Add(suc)

            For Each sucursal As ClasesNegocio.SucursalClass In DirectCast(cmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).Sucursales
                SucursalC.Add(sucursal)
            Next

            cmbSucursal.DataSource = SucursalC
            cmbSucursal.DisplayMember = "Descripcion"
            cmbSucursal.ValueMember = "Codigo"
        Else
            cmbSucursal.DataSource = Nothing
            cmbSucursal.Text = "TODAS"
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        limpiar()
        habilitar()
    End Sub

    Private Sub dgvProductos_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        If e.ColumnIndex = Me.clmFiniquito.Index Then
            Me.dgvProductos.EndEdit()
        End If
    End Sub

End Class