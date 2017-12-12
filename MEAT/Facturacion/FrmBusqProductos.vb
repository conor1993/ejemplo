Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses

Public Class FrmBusqProductos
    Dim Sacrificios As CN.RegistroSacrificioColeccionClass
    Dim Introductores As CN.ClientesIntroductoresColeccion
    Dim Productos As CN.DecomisosColeccionClass
    Dim _Lista As List(Of ProductosSeleccionados)

    Public Property ListaProd() As List(Of ProductosSeleccionados)
        Get
            Return _Lista
        End Get
        Set(ByVal value As List(Of ProductosSeleccionados))
            _Lista = value
        End Set
    End Property

    Private Sub FrmBusqProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Sacrificios = New CN.RegistroSacrificioColeccionClass
            Sacrificios.Obtener()
            Me.CmbLoteSacrificio.DisplayMember = "IdLoteSacrificio"
            Me.CmbLoteSacrificio.ValueMember = "IdLoteSacrificio"
            Me.CmbLoteSacrificio.DataSource = Sacrificios

            Introductores = New CN.ClientesIntroductoresColeccion
            Introductores.Obtener(True)
            Me.CmbIntroductor.DisplayMember = "Nombre"
            Me.CmbIntroductor.ValueMember = "Codigo"
            Me.CmbIntroductor.DataSource = Introductores

            cmbProducto.ValueMember = "IdProducto"
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.DataSource = CN.ProductosCollectionsClass.CargarProductos(HC.MsccatProductosFields.SubProducto = 1 And HC.MsccatProductosFields.Estatus = 1)
            Limpiar()

            Productos = New CN.DecomisosColeccionClass
            Productos.Obtener(False, "", ClasesNegocio.CondicionEnum.ACTIVOS, False)
            Me.DgvDecomisos.AutoGenerateColumns = False
            Me.DgvDecomisos.DataSource = Productos
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Limpiar()
        Me.CmbIntroductor.SelectedIndex = -1
        Me.CmbIntroductor.Text = "Seleccione un Introductor"
        Me.CmbLoteSacrificio.SelectedIndex = -1
        Me.CmbLoteSacrificio.Text = "Seleccione un Lote de Sacrificio"
        cmbProducto.SelectedIndex = -1
        cmbProducto.Text = "Seleccione un Producto"
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Productos = New CN.DecomisosColeccionClass
            Productos.Obtener(Me.CmbLoteSacrificio.SelectedValue, Me.CmbIntroductor.SelectedValue, cmbProducto.SelectedValue, False, ClasesNegocio.CondicionEnum.ACTIVOS, False)
            Me.DgvDecomisos.AutoGenerateColumns = False
            Me.DgvDecomisos.DataSource = Productos

            For i As Integer = 0 To Me.DgvDecomisos.Rows.Count - 1
                Dim Final As Integer = 0
                For Each Prod As ProductosSeleccionados In ListaProd
                    With Me.DgvDecomisos.Rows(i)
                        If .Cells(Me.ClmLoteSacrificio.Index).Value = Prod.FolioSacrificio And .Cells(Me.ClmIdProducto.Index).Value = Prod.IdProducto Then
                            .Cells(Me.ClmSelccion.Index).Value = True
                            .Cells(Me.ClmSelccion.Index).ReadOnly = True
                            Final += 1
                            Exit For
                        End If
                    End With
                Next
                If Final = ListaProd.Count Then
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BrnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrnAceptar.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub
End Class