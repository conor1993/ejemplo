Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesComunes
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Public Class CatAlmConsultaInventProd
    Dim productoColection As CN.ProductoCollectionClass
    Dim Producto As New ClasesNegocio.ProductoGeneralClass
    Dim Editar As Boolean = False
    Dim selesccionado As Boolean = False

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLinea.Focus()
            If CmbProducto.Text = "" Then
                MsgBox("Seleccione una Plaza")
                CmbProducto.Focus()
            End If
        End If
    End Sub

    Private Sub TxtLinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtUnidad.Focus()
            If TxtLinea.Text = "" Then
                MsgBox("Agregue Información a Linea")
                TxtLinea.Focus()
            End If
        End If
    End Sub

    Private Sub TxtUnidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtSublinea.Focus()
            If TxtUnidad.Text = "" Then
                MsgBox("Agregue Información a Unidad")
                TxtUnidad.Focus()
            End If
        End If
    End Sub

    Private Sub CatAlmConsultaInventProd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "000100011"
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtb.ToolBarButtonStatus = MtbEstados
        mtb.sbCambiarEstadoBotones("Cancelar")
        DesHabilitar()
        Me.AlmacenCol.Obtener()
        llenarCmbProducto()
    End Sub

#Region "MEtodos"
    Private Sub limpiar()
        TxtLinea.Clear()
        TxtUnidad.Clear()
        TxtSublinea.Clear()
        TxtTotalI.Clear()
    End Sub
    Private Sub habilitar()
        CmbProducto.Enabled = True
        TxtLinea.Enabled = True
        TxtUnidad.Enabled = True
        TxtSublinea.Enabled = True
        TxtTotalI.Enabled = False
        DataGrid.Enabled = False
    End Sub
    Private Sub DesHabilitar()
        CmbProducto.Enabled = False
        TxtLinea.Enabled = False
        TxtUnidad.Enabled = False
        TxtSublinea.Enabled = False
        TxtTotalI.Enabled = False
        DataGrid.Enabled = True
    End Sub

#End Region

    Private Sub mtb_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickCancelar
        limpiar()
        DesHabilitar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        If Me.selesccionado Then
            limpiar()
        Else
            limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickNuevo
        limpiar()
        habilitar()
        Editar = False
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub llenarCmbProducto()
        Try
            Me.CmbProducto.DisplayMember = "PdDescripcion"
            Me.CmbProducto.ValueMember = "pdidproducto"
            Me.productoColection = New CN.ProductoCollectionClass
            Me.productoColection.Obtener()
            Me.CmbProducto.SelectedIndex = -1
            Me.CmbProducto.DataSource = Me.productoColection
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub CmbProducto_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles CmbProducto.SelectionChangeCommitted
        BuscarProductos()
    End Sub

    Private Sub BuscarProductos()
        Producto.Obtener(CmbProducto.SelectedValue)
        TxtLinea.Text = Producto.DescCorta

    End Sub

End Class