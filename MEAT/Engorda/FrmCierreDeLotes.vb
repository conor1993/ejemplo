Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmCierreDeLotes

#Region "Definiciones"
    Private Estado As FormState
#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001001011"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100011"
        tbEstados.StateNuevo = "001010001"
        tbEstados.StateGuardar = "100100011"
        tbEstados.StateBorrar = "100100011"
        tbEstados.StateEditar = "001010001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        Me.Icon = MdiParent.Icon
        Me.mtb.ToolBarButtonStatus = tbEstados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")
        dtgDatos.AutoGenerateColumns = False
        Deshabilitar()
    End Sub

    Sub Deshabilitar()
        Me.dtpFechaFinal.Enabled = False
        Me.dtgDatos.ReadOnly = True
    End Sub

    Sub Habilitar()
        Me.dtpFechaFinal.Enabled = True
        Me.dtgDatos.ReadOnly = False
        Me.clmLote.ReadOnly = True
        Me.clmCorral.ReadOnly = True
        Me.clmCabezas.ReadOnly = True
    End Sub

    Function RecolectarLotes(Optional ByVal Seleccionados As Boolean = True) As LoteCollectionClass
        Dim Lotes As New LoteCollectionClass

        If Seleccionados Then
            For Each Fila As DataGridViewRow In dtgDatos.Rows
                If Fila.Cells(clmSeleccionado.Index).Value Then
                    Lotes.Add(CType(Fila.DataBoundItem, LoteClass))
                End If
            Next
        Else
            For Each Fila As DataGridViewRow In dtgDatos.Rows
                Lotes.Add(CType(Fila.DataBoundItem, LoteClass))
            Next
        End If
        Return Lotes
    End Function

#End Region

#Region "Acciones Menu"
    Public Sub Limpiar()
        Me.dtpFechaFinal.Value = Now

        For Each Renglon As DataGridViewRow In dtgDatos.Rows
            Dim Seleccion As DataGridViewCheckBoxCell = CType(Renglon.Cells(clmSeleccionado.Index), DataGridViewCheckBoxCell)
            Seleccion.EditingCellFormattedValue = False
            Seleccion.Value = False
        Next
    End Sub

    Public Function Buscar() As Boolean
        Estado = FormState.Buscar
        clmSeleccionado.Visible = False
        Dim frmBusqueda As New frmBusquedaLotes(LoteClass.EstatusLote.CERRADO)

        If frmBusqueda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            dtgDatos.DataSource = frmBusqueda.ObtenerSeleccionados

            If dtgDatos.Rows.Count > 0 Then
                Return True
            End If
        End If
    End Function

    Public Sub Cancelar()
        Me.dtpFechaFinal.Value = Now
        dtgDatos.DataSource = Nothing
        Deshabilitar()
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim Lotes As LoteCollectionClass = Nothing

        Lotes = RecolectarLotes()
        Controlador.CerrarLotes(Lotes, dtpFechaFinal.Value, Trans)
        Trans.Commit()
        MessageBox.Show("Se ha realizado el cierre satifactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        dtgDatos.DataSource = Nothing
        Return True
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        Dim Lotes As LoteCollectionClass = RecolectarLotes()

        Lotes = RecolectarLotes(False)
        Controlador.CancelarCierreLotes(Lotes, Trans)
        Trans.Commit()
        MessageBox.Show("Se ha cancelado el cierre los lotes satifactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        dtgDatos.DataSource = Nothing
        Return True
    End Function

    Public Sub Nuevo()
        Estado = FormState.Nuevo
        clmSeleccionado.Visible = True
        dtgDatos.DataSource = Controlador.ObtenerLotes(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatLotesCabFields.SaldoCabezas = 0)
        Habilitar()
        dtpFechaFinal.Value = Now
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

    Public Sub Imprimir()
        Dim Lotes As LoteCollectionClass = Nothing

        If Estado = FormState.Buscar Then
            Lotes = RecolectarLotes(False)
        End If
        Controlador.ReporteCierreLotes(Lotes)
    End Sub

#End Region

#Region "Eventos"

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar, mtb.ClickCancelar, mtb.ClickImprimir, mtb.ClickSalir, mtb.ClickBuscar, mtb.ClickBorrar, mtb.ClickNuevo
        If e.Button.Text = "Guardar" Or e.Button.Text = "Borrar" Or e.Button.Text = "Buscar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cierre de Lote")
            Dim Resultado As Object = Nothing

            If e.Button.Text = "Buscar" Then
                Resultado = Utilerias.RunControlException(Me, e.Button.Text)
            Else
                Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})
            End If

            If Resultado Is Nothing OrElse Resultado = False Then
                Trans.Rollback()
                Cancelar = True
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub

    Private Sub FrmCorCierreDeLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub dtgDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellContentClick
        If e.ColumnIndex = clmSeleccionado.Index Then
            Dim ColSeleccionado As DataGridViewCheckBoxCell = CType(sender.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewCheckBoxCell)
            CType(dtgDatos.Rows(e.RowIndex).DataBoundItem, LoteClass).Seleccionado = CType(ColSeleccionado.EditedFormattedValue, Boolean)
        End If
    End Sub

#End Region

End Class