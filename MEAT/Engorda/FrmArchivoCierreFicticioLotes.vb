Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmArchivoCierreFicticioLotes

#Region "Definiciones"
    Private Estado As FormState
#End Region

#Region "Métodos"

    Public Sub Inicializar_Forma()
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = ""
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "000100011"
        tbEstados.StateNuevo = "000010001"
        tbEstados.StateGuardar = "000100011"
        tbEstados.StateBorrar = ""
        tbEstados.StateEditar = ""
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        Me.Icon = MdiParent.Icon
        Me.mtb.ToolBarButtonStatus = tbEstados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")
        dtgDatos.AutoGenerateColumns = False
        Deshabilitar()
        lblFechaFinal.Text = Now.ToShortDateString
    End Sub

    Sub Deshabilitar()
        'Me.dtpFechaFinal.Enabled = False
        Me.dtgDatos.ReadOnly = True
    End Sub

    Sub Habilitar()
        'Me.dtpFechaFinal.Enabled = True
        Me.dtgDatos.ReadOnly = False
        Me.clmLote.ReadOnly = True
        Me.clmCorral.ReadOnly = True
        Me.clmCabezas.ReadOnly = True
    End Sub

    Function RecolectarLotes() As LoteCollectionClass
        Dim Lotes As New LoteCollectionClass

        For Each Fila As DataGridViewRow In dtgDatos.Rows
            Lotes.Add(CType(Fila.DataBoundItem, LoteClass))
        Next
        Return Lotes
    End Function

#End Region

#Region "Acciones Menu"

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim Lotes As LoteCollectionClass = Nothing

        Lotes = RecolectarLotes()
        Controlador.ArchivoCierreFicticioLote(Lotes, Date.Parse(lblFechaFinal.Text), Trans)
        Trans.Commit()
        MessageBox.Show("Se ha generado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        dtgDatos.DataSource = Nothing
        Return True
    End Function

    Public Sub Nuevo()
        Estado = FormState.Nuevo
        dtgDatos.DataSource = Controlador.ObtenerLotes(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatLotesCabFields.SaldoCabezas = 0)
        Habilitar()
        lblFechaFinal.Text = Now.ToShortDateString
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

    Public Sub Imprimir()
        Dim Lotes As LoteCollectionClass = Nothing

        If Estado = FormState.Buscar Then
            Lotes = RecolectarLotes()
        End If
        Controlador.ReporteCierreLotes(Lotes)
    End Sub

#End Region

#Region "Eventos"

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickGuardar, mtb.ClickImprimir, mtb.ClickNuevo, mtb.ClickSalir
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

#End Region

End Class