Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class frmtiposproductos

    'Private tipoproducto As EC.TipoProductoEntity
    Private WithEvents TipoProducto As ClasesNegocio.TipoProductoClass
    Private puedomidificar As Boolean = True

    Private Sub sbLectura()
        Me.txtcodigo.Enabled = False
        Me.txtNombreCorto.Enabled = False
        Me.txtnombre.Enabled = False
        Me.chbEsParaVender.Enabled = False
        dgtiposproducto.Enabled = True
    End Sub

    Private Sub sbEscritura()
        Me.txtcodigo.Enabled = False
        Me.txtNombreCorto.Enabled = True
        Me.txtnombre.Enabled = True
        Me.chbEsParaVender.Enabled = True
        dgtiposproducto.Enabled = False
    End Sub

    Private Sub sbLimpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        Me.txtNombreCorto.Clear()
        Me.chbEsParaVender.Checked = False
        Me.lblEstatus.Text = "Estatus"
    End Sub

    Private Sub Guardar()
        TipoProducto.Descripcion = Me.txtnombre.Text
        TipoProducto.DescripcionCorta = Me.txtNombreCorto.Text
        TipoProducto.SeVende = Me.chbEsParaVender.Checked
    End Sub

    Private Sub frmtiposproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        mtbEstados.StateBuscar = "010101111"
        mtbEstados.StateLimpiar = "100100011"
        mtbEstados.StateCancelar = "100100011"
        mtbEstados.StateNuevo = "001010001"
        mtbEstados.StateGuardar = "100100011"
        mtbEstados.StateBorrar = "100100011"
        mtbEstados.StateEditar = "001010001"
        mtbEstados.StateImprimir = ""
        mtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = mtbEstados
        mtb.sbCambiarEstadoBotones("Limpiar")
        sbLectura()
        TipoProductoC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            If TipoProducto.Borrar Then
                MsgBox("Se a dado debaja exitosamente", MsgBoxStyle.Information, "Aviso")
                sbLimpiar()
                sbLectura()
                TipoProductoC.Obtener(ClasesNegocio.CondicionEnum.Todos)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        sbEscritura()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Me.txtnombre.Text = "" Then
                MessageBox.Show("Ingrese el nombre del tipo de producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtnombre.Focus()
                Cancelar = True
                Exit Sub
            End If

            If Me.txtNombreCorto.Text = "" Then
                MessageBox.Show("Ingrese el nombre corto del tipo de producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombreCorto.Focus()
                Cancelar = True
                Exit Sub
            End If
            Me.puedomidificar = False
            Guardar()
            Me.puedomidificar = False

            If TipoProducto.Guardar Then
                MsgBox("Se a guardado exitosamente", MsgBoxStyle.Information, "Aviso")
                sbLectura()
                sbLimpiar()
                TipoProductoC.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        sbLimpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        sbLimpiar()
        sbEscritura()
        TipoProducto = New ClasesNegocio.TipoProductoClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub dgtiposproducto_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgtiposproducto.DataError

    End Sub

    Private Sub dgtiposproducto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgtiposproducto.DoubleClick
        Dim buscar As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.TipoProductoClass)
        TipoProducto = buscar.ObtenerdeDataGrid(dgtiposproducto)
        If Not IsNothing(TipoProducto) Then
            Me.puedomidificar = True
            TipoProducto_Modificado(Me, e)
            mtb.sbCambiarEstadoBotones("Buscar")
            'Me.selesccionado = True
        Else
            Windows.Forms.MessageBox.Show("No selecciono un elemento valido.")
        End If
    End Sub

    Private Sub TipoProducto_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles TipoProducto.MensajeError
        MsgBox(mensaje, MsgBoxStyle.Information, "Aviso")
    End Sub

    Private Sub TipoProducto_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles TipoProducto.Modificado
        If Me.puedomidificar Then
            Me.txtNombreCorto.Text = TipoProducto.DescripcionCorta
            Me.txtnombre.Text = TipoProducto.Descripcion
            Me.txtcodigo.Text = TipoProducto.Codigo
            Me.chbEsParaVender.Checked = TipoProducto.SeVende
            Me.lblEstatus.Text = TipoProducto.Estatus.ToString
        End If
    End Sub

    Private Sub dgtiposproducto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgtiposproducto.CellContentClick

    End Sub
End Class