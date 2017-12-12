<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramacionFormulas

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramacionFormulas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.cmbLote = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvProgramacion = New System.Windows.Forms.DataGridView
        Me.clmFormula = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmFechaInicio = New Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn(Me.components)
        Me.clmFechaFin = New Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn(Me.components)
        Me.clmConsxCabKil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorServida1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorServida2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorServida3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorServida4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmbtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(547, 33)
        Me.lblEstatus.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Size = New System.Drawing.Size(810, 29)
        Me.lblTitulo.Text = "PROGRAMACIÓN DE FÓRMULAS ALIMENTICIAS"
        '
        'tbrMenu
        '
        Me.tbrMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrMenu.Location = New System.Drawing.Point(0, -27)
        Me.tbrMenu.MostrarBorrar = False
        Me.tbrMenu.MostrarBuscar = False
        Me.tbrMenu.MostrarCancelar = False
        Me.tbrMenu.MostrarEditar = False
        Me.tbrMenu.MostrarImprimir = False
        Me.tbrMenu.MostrarLimpiar = False
        Me.tbrMenu.MostrarNuevo = False
        Me.tbrMenu.Size = New System.Drawing.Size(50, 266)
        '
        'cmbLote
        '
        Me.cmbLote.FormattingEnabled = True
        Me.cmbLote.Location = New System.Drawing.Point(98, 40)
        Me.cmbLote.Name = "cmbLote"
        Me.cmbLote.Size = New System.Drawing.Size(211, 21)
        Me.cmbLote.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Lote:"
        '
        'dgvProgramacion
        '
        Me.dgvProgramacion.AllowUserToDeleteRows = False
        Me.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFormula, Me.clmFechaInicio, Me.clmFechaFin, Me.clmConsxCabKil, Me.clmPorServida1, Me.clmPorServida2, Me.clmPorServida3, Me.clmPorServida4, Me.clmbtnEliminar})
        Me.dgvProgramacion.Location = New System.Drawing.Point(56, 71)
        Me.dgvProgramacion.MultiSelect = False
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.RowHeadersVisible = False
        Me.dgvProgramacion.Size = New System.Drawing.Size(742, 232)
        Me.dgvProgramacion.TabIndex = 66
        '
        'clmFormula
        '
        Me.clmFormula.DataPropertyName = "IdFormula"
        Me.clmFormula.HeaderText = "Formula"
        Me.clmFormula.Name = "clmFormula"
        Me.clmFormula.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmFormula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmFormula.Width = 170
        '
        'clmFechaInicio
        '
        Me.clmFechaInicio.DataPropertyName = "FecInicio"
        Me.clmFechaInicio.DefaultNewRowValue = CType(resources.GetObject("clmFechaInicio.DefaultNewRowValue"), Object)
        Me.clmFechaInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.clmFechaInicio.DropDownCalendarAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.clmFechaInicio.HeaderText = "Fecha Inicio"
        Me.clmFechaInicio.MaskInput = Nothing
        Me.clmFechaInicio.Name = "clmFechaInicio"
        Me.clmFechaInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmFechaInicio.SpinButtonAlignment = Infragistics.Win.SpinButtonDisplayStyle.None
        Me.clmFechaInicio.Width = 90
        '
        'clmFechaFin
        '
        Me.clmFechaFin.DataPropertyName = "FecFinal"
        Me.clmFechaFin.DefaultNewRowValue = CType(resources.GetObject("clmFechaFin.DefaultNewRowValue"), Object)
        Me.clmFechaFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.clmFechaFin.DropDownCalendarAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.clmFechaFin.HeaderText = "Fecha Fin"
        Me.clmFechaFin.MaskInput = Nothing
        Me.clmFechaFin.Name = "clmFechaFin"
        Me.clmFechaFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmFechaFin.SpinButtonAlignment = Infragistics.Win.SpinButtonDisplayStyle.None
        Me.clmFechaFin.Width = 90
        '
        'clmConsxCabKil
        '
        Me.clmConsxCabKil.DataPropertyName = "ConsxCabKil"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0D"
        Me.clmConsxCabKil.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmConsxCabKil.HeaderText = "Cons/Cbz en Kgs."
        Me.clmConsxCabKil.Name = "clmConsxCabKil"
        Me.clmConsxCabKil.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmConsxCabKil.Width = 80
        '
        'clmPorServida1
        '
        Me.clmPorServida1.DataPropertyName = "PorServida1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0D"
        Me.clmPorServida1.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPorServida1.HeaderText = "Porcentaje 1ra Servida"
        Me.clmPorServida1.Name = "clmPorServida1"
        Me.clmPorServida1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmPorServida1.Width = 60
        '
        'clmPorServida2
        '
        Me.clmPorServida2.DataPropertyName = "PorServida2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0D"
        Me.clmPorServida2.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPorServida2.HeaderText = "Porcentaje 2da Servida"
        Me.clmPorServida2.Name = "clmPorServida2"
        Me.clmPorServida2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmPorServida2.Width = 60
        '
        'clmPorServida3
        '
        Me.clmPorServida3.DataPropertyName = "PorServida3"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0D"
        Me.clmPorServida3.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPorServida3.HeaderText = "Porcentaje 3ra Servida"
        Me.clmPorServida3.Name = "clmPorServida3"
        Me.clmPorServida3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmPorServida3.Width = 60
        '
        'clmPorServida4
        '
        Me.clmPorServida4.DataPropertyName = "PorServida4"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0D"
        Me.clmPorServida4.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPorServida4.HeaderText = "Porcentaje 4ta Servida"
        Me.clmPorServida4.Name = "clmPorServida4"
        Me.clmPorServida4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmPorServida4.Width = 60
        '
        'clmbtnEliminar
        '
        Me.clmbtnEliminar.HeaderText = "Eliminar"
        Me.clmbtnEliminar.Name = "clmbtnEliminar"
        Me.clmbtnEliminar.Text = "Eliminar"
        Me.clmbtnEliminar.UseColumnTextForButtonValue = True
        Me.clmbtnEliminar.Width = 50
        '
        'frmProgramacionFormulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 315)
        Me.Controls.Add(Me.dgvProgramacion)
        Me.Controls.Add(Me.cmbLote)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmProgramacionFormulas"
        Me.Text = "PROGRAMACIÓN DE FÓRMULAS ALIMENTICIAS"
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cmbLote, 0)
        Me.Controls.SetChildIndex(Me.dgvProgramacion, 0)
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbLote As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvProgramacion As System.Windows.Forms.DataGridView
    Friend WithEvents clmFormula As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmFechaInicio As Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn
    Friend WithEvents clmFechaFin As Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn
    Friend WithEvents clmConsxCabKil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorServida1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorServida2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorServida3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorServida4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmbtnEliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
