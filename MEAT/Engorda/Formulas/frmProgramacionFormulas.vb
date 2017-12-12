Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmProgramacionFormulas
    Inherits MeatForm

#Region "Miembros"

    Private Editable As Boolean = True
    Private Lote As LoteClass = Nothing
    Private EsSeleccionable As Boolean = True

#End Region

#Region "Constructores"

    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByVal Lote As LoteClass, ByVal Editable As Boolean)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Lote = Lote
        Me.EsSeleccionable = False
        Me.Editable = Editable
    End Sub

#End Region

#Region "Metodos"

    Public Overrides Sub InicializarForma()
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

        dgvProgramacion.AutoGenerateColumns = False
        Controlador.LlenarComboLotes(cmbLote, LoteClass.EstatusLote.VIGENTE)
        clmFormula.DataSource = Controlador.ObtenerFormulas()
        clmFormula.DisplayMember = "Descripcion"
        clmFormula.ValueMember = "Codigo"

        If Not EsSeleccionable Then
            cmbLote.SelectedValue = Lote.IdLote
            cmbLote.Enabled = False
            dgvProgramacion.DataSource = Lote.ProgramacionFormulas
        End If
        Modo(Editable)
    End Sub

    Public Overrides Sub Modo(ByVal Edicion As Boolean)
        dgvProgramacion.ReadOnly = Not Edicion
        dgvProgramacion.AllowUserToAddRows = Edicion
        clmbtnEliminar.Visible = Edicion
        tbrMenu.Buttons("tbbtnGuardar").Enabled = Edicion
    End Sub

    Public Sub EliminarProgramacion(ByVal Index As Integer)
        If Not dgvProgramacion.Rows(Index).IsNewRow Then
            If Lote.ProgramacionFormulas.Count > Index Then
                If MessageBox.Show("¿Seguro que desea quitar la programacion?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Lote.ProgramacionFormulas.RemoveAt(Index)
                End If
            End If
        End If
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Overrides Function Limpiar() As Boolean
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
        Return True
    End Function

    Public Overrides Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        If dgvProgramacion.Rows.Count > 1 Then
            If dgvProgramacion.Rows(dgvProgramacion.Rows.Count - 1).IsNewRow Then
                If Lote.ProgramacionFormulas.Count > dgvProgramacion.Rows.Count - 1 Then
                    Lote.ProgramacionFormulas(dgvProgramacion.Rows.Count - 1).IsDirty = False
                End If
            End If
            Controlador.GuardarProgramacion(Lote.ProgramacionFormulas, Trans)
            Trans.Commit()
            MessageBox.Show("Se ha guardado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 6)
        End If
        Return True
    End Function

#End Region

#Region "Eventos"

    Private Sub frmProgramacionFormulas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "InicializarForma")
    End Sub

    Private Sub cmbLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.SelectedIndexChanged
        dgvProgramacion.DataSource = Nothing

        If cmbLote.SelectedIndex > -1 Then
            If EsSeleccionable Then
                Lote = CType(cmbLote.SelectedItem, LoteClass)
                dgvProgramacion.DataSource = Lote.ProgramacionFormulas
                Modo(Editable)
            End If
        Else
            Modo(False)
        End If
    End Sub

    Private Sub dgvProgramacion_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvProgramacion.RowValidating
        If Not dgvProgramacion.Rows(e.RowIndex).IsNewRow Then
            If Lote.ProgramacionFormulas.Count > e.RowIndex Then
                Dim Resultado As Object = Utilerias.RunControlException(Controlador, "ValidarLoteFormula", New Object() {Lote.ProgramacionFormulas(e.RowIndex)})

                If Resultado Is Nothing OrElse Not Resultado Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub dgvProgramacion_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvProgramacion.DataError

    End Sub

    Private Sub dgvProgramacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProgramacion.CellContentClick
        If e.ColumnIndex = clmbtnEliminar.Index Then
            EliminarProgramacion(e.RowIndex)
        End If
    End Sub

    Private Sub dgvProgramacion_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvProgramacion.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvProgramacion.CurrentRow IsNot Nothing AndAlso dgvProgramacion.CurrentRow.Index >= 0 Then
                EliminarProgramacion(dgvProgramacion.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub dgvProgramacion_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvProgramacion.EditingControlShowing
        If e.Control.GetType Is GetType(DataGridViewTextBoxEditingControl) Then
            RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

#End Region

End Class