Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmABCAlmacenes
    Dim LbNuevo As Boolean
    Private WithEvents Almacen As New AlmacenCatalogoClass

    Private Sub FrmABCAlmacenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Limpiar()
        Me.CatAlmacenes.GetMulti(Nothing)
        Me.MEAToolBar1.HabilitarBorrar = False
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = False
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = False
        Me.MEAToolBar1.HabilitarImprimir = False
        Me.MEAToolBar1.HabilitarLimpiar = False
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
    End Sub
    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            'variable para la clase de catalogo de almacen
            Almacen.Descripcion = Me.txtDescripcion.Text
            Almacen.DescripcionCorta = Me.txtDescripcionCorta.Text
            Almacen.Consecutivo = 0
            Almacen.Propio = True
            Almacen.IdCliente = 0
            Almacen.LetraSerie = Me.txtLetraSerie.Text
            Almacen.Observaciones = ""
            Almacen.CtaMay = ""
            Almacen.SsbCta = ""
            Almacen.SssCta = ""
            Almacen.SubCta = ""
            Almacen.Estatus = "V"
            Almacen.CodAlmacen = Me.txtCodigo.Text
            If Not Me.LbNuevo Then
                Almacen.Func = "M"
                Almacen.NumOpc = 1
            Else
                Almacen.Func = "I"
                Almacen.NumOpc = 1
            End If
            'llama el guardar del detalle de cortes
            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            If Me.LbNuevo Then
                Me.txtCodigo.Text = Almacen.IdCodAlmacen
            End If
            Trans.Commit()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.txtCodigo.Text = 0
        Me.txtCuentaContable.Text = ""
        Me.txtDescripcion.Text = ""
        Me.txtDescripcionCorta.Text = ""
        Me.txtLetraSerie.Text = ""
        Me.cmbCuentaContable.Text = ""
        Me.rdbCanales.Checked = False
        Me.rdbCortes.Checked = True
        Me.rdbOtro.Checked = False
        Me.rdbProductos.Checked = False
        Me.lblEstatus.Text = "ESTATUS"
    End Function
    Private Function Buscar() As Boolean
        'Dim TablaEmbarque As DataSet = SPA.UspConMfacEmbarquesCab(1, "")
        'Dim Consultas As New MConsEmbarques
        'Consultas.DgvEmbarques.AutoGenerateColumns = False
        'Consultas.DgvEmbarques.DataSource = TablaEmbarque.Tables(0)
        'Consultas.IdFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
        'Consultas.Fecha.DataPropertyName = "FechaEmbarque"
        'Consultas.Cliente.DataPropertyName = "Nombre"
        'Consultas.Piezas.DataPropertyName = "TotalPiezas"
        'Consultas.Kilos.DataPropertyName = "TotalKgrs"
        'If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Me.txtFolioEmbarque.Text = Consultas.DgvEmbarques.CurrentRow.Cells("IdFolioEmbarque").Value
        '    Me.dtFechaEmbarque.Value = Consultas.DgvEmbarques.CurrentRow.Cells("Fecha").Value
        '    Me.CmbCliente.Text = Consultas.DgvEmbarques.CurrentRow.Cells("Cliente").Value
        '    Dim TablaEmbarque1 As DataSet = IntegraLab.ORM..StoredProcedureCallerClasses.RetrievalProcedures.UspConMfacEmbarquesDet(2, Me.txtFolioEmbarque.Text)
        '    dgvRelaciondeCortes.DataSource = TablaEmbarque1.Tables(0)
        '    Me.Etiqueta.DataPropertyName = "IdFolioEtiqueta"
        '    Me.Corte.DataPropertyName = "Descripcion"
        '    Me.Piezas.DataPropertyName = "CantPzas"
        '    Me.Kilos.DataPropertyName = "CantKgrs"
        'End If
        'Me.txtFolioEmbarque.Focus()
    End Function
    Private Function FuncionCancelar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
        Try
            'variable para la clase de catalogo de almacen
            Almacen.CodAlmacen = Me.txtCodigo.Text
            Almacen.Descripcion = Me.txtDescripcion.Text
            Almacen.DescripcionCorta = Me.txtDescripcionCorta.Text
            Almacen.Consecutivo = 0
            Almacen.Propio = True
            Almacen.IdCliente = 0
            Almacen.IdCodTipoAlmacen = 1
            Almacen.LetraSerie = Me.txtLetraSerie.Text
            Almacen.Observaciones = ""
            Almacen.CtaMay = ""
            Almacen.SsbCta = ""
            Almacen.SssCta = ""
            Almacen.SubCta = ""
            Almacen.Estatus = "V"
            Almacen.Func = "M"
            Almacen.NumOpc = 2
            'llama el guardar del detalle de cortes
            If Not Almacen.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If
            Trans.Commit()
            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Trans.Rollback()
            Return False
        End Try

    End Function

    Private Sub rdbCortes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCortes.CheckedChanged
        If Not Me.rdbCortes.Checked Then
            Almacen.IdCodTipoAlmacen = 0
        Else
            Almacen.IdCodTipoAlmacen = 1
        End If
    End Sub

    Private Sub rdbCanales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCanales.CheckedChanged
        'Dim Alm As New AlmacenCatalogoClass
        If Not Me.rdbCanales.Checked Then
            Almacen.IdCodTipoAlmacen = 0
        Else
            Almacen.IdCodTipoAlmacen = 2
        End If

    End Sub

    Private Sub rdbProductos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbProductos.CheckedChanged
        'Dim Alm As New AlmacenCatalogoClass
        If Not Me.rdbProductos.Checked Then
            Almacen.IdCodTipoAlmacen = 0
        Else
            Almacen.IdCodTipoAlmacen = 3
        End If

    End Sub

    Private Sub rdbOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOtro.CheckedChanged
        'Dim Alm As New AlmacenCatalogoClass
        If Not Me.rdbOtro.Checked Then
            Almacen.IdCodTipoAlmacen = 0
        Else
            Almacen.IdCodTipoAlmacen = 4
        End If

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDescripcionCorta.Focus()
        End If
    End Sub

    Private Sub txtDescripcionCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcionCorta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLetraSerie.Focus()
        End If
    End Sub

    Private Sub Almacen_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Almacen.MensajeError
        MsgBox(mensaje)
    End Sub



    Private Sub dgvAlmacenes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAlmacenes.DoubleClick
        'Dim Almacen As ED.MsccatAlmacenesEntity
        'Almacen = DirectCast(dgvAlmacenes.SelectedRows(0).DataBoundItem, ED.MsccatAlmacenesEntity)
        'Me.txtCodigo.Text = Almacen.IdCodAlmacen
        'Me.txtDescripcion.Text = Almacen.Descripcion
        'Me.txtDescripcionCorta.Text = Almacen.DescripcionCorta
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        If Not Buscar() Then
            MessageBox.Show("No se encuentran almacenes disponibles", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickCancelar
        If Not FuncionCancelar() Then
            MessageBox.Show("No se pudo cancelar este almacén", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se cancelo almacén con codigo: " & Me.txtCodigo.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickEditar
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarNuevo = False
        Me.LbNuevo = False
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar
        If Not Guardar() Then
            MessageBox.Show("No se puede guardar información de almacen", "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Se guardo información de almacen : " & Me.txtCodigo.Text, "ERP FLEXI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar()
        Me.CatAlmacenes.GetMulti(Nothing)
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickNuevo
        Me.Limpiar()
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = False
        Me.LbNuevo = True
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Close()
    End Sub


    Private Sub txtLetraSerie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLetraSerie.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmbCuentaContable.Focus()
        End If

    End Sub

End Class