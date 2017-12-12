Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmDevolucionProductos
    Dim Devolucion As CN.DevolucionProductosClass
    Dim Embarque As CN.EmbarquesClass
    Dim Cliente As CN.ClientesIntroductoresClass
    Dim Producto As CN.ProductosClass
    Dim Productos As CN.ProductosCollectionsClass

    Private Sub FrmDevolucionProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Productos = New CN.ProductosCollectionsClass
            Productos.Obtener(CN.CondicionEstatusEnum.ACTIVO)
            Me.cmbProducto.ValueMember = "IdProducto"
            Me.cmbProducto.DisplayMember = "Descripcion"
            Me.cmbProducto.DataSource = Productos

            Me.DevoluccioneProdC.Obtener()

            Limpiar()
            DesHabilitar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        Me.txtFolio.Text = ""
        Me.txtIdProducto.Text = ""
        Me.txtKilos.Text = 0D
        Me.txtPiezas.Text = 0D
        Me.txtTipoProducto.Text = ""
        Me.cmbProducto.SelectedIndex = -1
        Me.chkUtil.Checked = False
        Me.txtCliente.Text = ""
        Me.txtEmbarque.Text = ""
    End Sub

    Private Sub Habilitar()
        Me.txtIdProducto.Enabled = True
        Me.txtKilos.Enabled = True
        Me.txtPiezas.Enabled = True
        Me.cmbProducto.Enabled = True
        Me.txtEmbarque.Enabled = True
    End Sub

    Private Sub DesHabilitar()
        Me.txtIdProducto.Enabled = False
        Me.txtKilos.Enabled = False
        Me.txtPiezas.Enabled = False
        Me.cmbProducto.Enabled = False
        Me.txtEmbarque.Enabled = False
    End Sub

    Private Function Validar() As Boolean
        Try
            If Me.txtIdProducto.Text = "" Then
                MsgBox("Seleccione un producto", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtIdProducto.Focus()
                Return False
            End If

            If Me.txtEmbarque.Text = "" Then
                MsgBox("Ingrese el Folio de Embarque", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtEmbarque.Focus()
                Return False
            End If

            If Me.txtKilos.Text = 0D Then
                MsgBox("Ingrese el número de kilos", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtKilos.Focus()
                Return False
            End If

            If Me.txtPiezas.Text = 0D Then
                MsgBox("Ingrese el número de piezas", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtPiezas.Focus()
                Return False
            End If

            If IsNothing(Embarque) Then
                MsgBox("Ingrese un embarque valido", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtEmbarque.Focus()
                Return False
            End If

            If IsNothing(Cliente) Then
                MsgBox("Ingrese un embarque valido", MsgBoxStyle.Exclamation, "Aviso")
                Me.txtEmbarque.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Tool Bar"
    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        DesHabilitar()
        Limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            Devolucion.IdProducto = Me.txtIdProducto.Text
            Devolucion.Kilos = Me.txtKilos.Text
            Devolucion.Piezas = Me.txtPiezas.Text
            Devolucion.FolioEmbarque = Me.txtEmbarque.Text
            Devolucion.Cliente = Cliente
            Devolucion.FolioEmbarque = Embarque.FolioEmbarque
            Devolucion.UtilVenta = Me.chkUtil.Checked

            If Not Devolucion.Guardar Then
                MsgBox("No se logro guardar la devolción, intente de nuevo", MsgBoxStyle.Critical, "Aviso")
                Cancelar = True
                Exit Sub
            End If

            MsgBox("Se ha guardado la devolucón de productos con el Folio :" & Devolucion.Folio, MsgBoxStyle.Information, "Aviso")
            Limpiar()
            DesHabilitar()
            Me.DevoluccioneProdC.Obtener()

        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Habilitar()
        Me.txtEmbarque.Focus()
        Devolucion = New CN.DevolucionProductosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region

    Private Sub txtEmbarque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmbarque.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Not Me.txtEmbarque.Text = "" Then
                    Embarque = New CN.EmbarquesClass
                    If Not Embarque.Obtener(Me.txtEmbarque.Text) Then
                        MsgBox("No existe el embarque", MsgBoxStyle.Exclamation, "Aviso")
                    Else
                        Me.Productos.ObtenerXEmbarque(Embarque.FolioEmbarque)
                        Cliente = New CN.ClientesIntroductoresClass(Embarque.IdCliente)
                        Me.txtCliente.Text = Cliente.Nombre
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbProducto_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbProducto.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Productos.Obtener(CN.CondicionEstatusEnum.ACTIVO)
        End If
    End Sub

    Private Sub cmbProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProducto.SelectedIndexChanged
        Try
            If Me.cmbProducto.SelectedIndex > -1 Then
                Producto = DirectCast(Me.cmbProducto.SelectedItem, CN.ProductosClass)
                If Producto.Corte = True Then
                    Me.txtTipoProducto.Text = "CORTE"
                ElseIf Producto.Canal = True Then
                    Me.txtTipoProducto.Text = "CANAL"
                ElseIf Producto.PreCorte = False Then
                    Me.txtTipoProducto.Text = "PRECORTE"
                ElseIf Producto.SubProducto = True Then
                    Me.txtTipoProducto.Text = "SUB PRODUCTO"
                Else
                    Me.txtTipoProducto.Text = "PRODUCTO"
                End If
                If Not IsNothing(Embarque) Then
                    Dim IdProducto As Integer
                    IdProducto = DirectCast(Me.cmbProducto.SelectedItem, CN.ProductosClass).IdProducto
                    Dim Kilos As Decimal
                    Dim Piezas As Decimal

                    For Each Det As CN.EmbarqueDetalleClass In Embarque.Detalles
                        If Det.IdProducto = IdProducto Then
                            Kilos = Kilos + Det.CantKgrs
                            Piezas = Piezas + Det.CantPzas
                        End If
                    Next
                    Me.txtKilos.Text = Kilos
                    Me.txtPiezas.Text = Piezas
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvDevoluciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvDevoluciones.Click
        Try
            If Me.DgvDevoluciones.SelectedRows.Count > 0 Then
                Devolucion = DirectCast(Me.DgvDevoluciones.SelectedRows(0).DataBoundItem, CN.DevolucionProductosClass)

                Me.txtFolio.Text = Devolucion.Folio
                Me.txtIdProducto.Text = Devolucion.IdProducto
                Me.txtKilos.Text = Devolucion.Kilos
                Me.txtPiezas.Text = Devolucion.Piezas
                Me.txtEmbarque.Text = Devolucion.FolioEmbarque
                Cliente = Devolucion.Cliente
                Embarque.FolioEmbarque = Devolucion.FolioEmbarque
                Me.chkUtil.Checked = Devolucion.UtilVenta

                Me.mtb.sbCambiarEstadoBotones("Buscar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DgvDevoluciones_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvDevoluciones.DataError

    End Sub

    Private Sub txtEmbarque_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmbarque.TextChanged
        Try
            If Not Me.txtEmbarque.Text = "" Then
                Embarque = New CN.EmbarquesClass
                If Not Embarque.Obtener(Me.txtEmbarque.Text) Then
                    MsgBox("No existe el embarque", MsgBoxStyle.Exclamation, "Aviso")
                Else
                    Me.Productos.ObtenerXEmbarque(Embarque.FolioEmbarque)
                    Cliente = New CN.ClientesIntroductoresClass(Embarque.IdCliente)
                    Me.txtCliente.Text = Cliente.Nombre
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class