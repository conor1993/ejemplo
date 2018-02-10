<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapturaProdTerminado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapturaProdTerminado))
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEtiquetas = New System.Windows.Forms.DataGridView()
        Me.IdFolioEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_SubCorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantPzas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAlmacen = New System.Windows.Forms.TextBox()
        Me.txtLoteFapsa = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtPiezas = New System.Windows.Forms.TextBox()
        Me.txtSubCorte = New System.Windows.Forms.TextBox()
        Me.txtCodSubCorte = New System.Windows.Forms.TextBox()
        Me.txtCorte = New System.Windows.Forms.TextBox()
        Me.txtCodCorte = New System.Windows.Forms.TextBox()
        Me.txtDiasCad = New System.Windows.Forms.TextBox()
        Me.txtLoteCorte = New System.Windows.Forms.TextBox()
        Me.cmdBuscarCortes = New System.Windows.Forms.Button()
        Me.cmdBuscarPreCortes = New System.Windows.Forms.Button()
        Me.CmdImprimir = New System.Windows.Forms.Button()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtTotKgrs = New System.Windows.Forms.TextBox()
        Me.txtTotPzas = New System.Windows.Forms.TextBox()
        Me.txtTotEti = New System.Windows.Forms.TextBox()
        Me._LblEtiqueta_4 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_5 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_10 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_11 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_0 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_1 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_2 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_3 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_7 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_8 = New System.Windows.Forms.Label()
        Me._LblEtiqueta_9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.gpbCanales = New System.Windows.Forms.GroupBox()
        Me.txtKilosCanales = New System.Windows.Forms.TextBox()
        Me.txtPiezasCanales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFolioReferencia = New System.Windows.Forms.TextBox()
        Me.lblFolioReferencia = New System.Windows.Forms.Label()
        Me.cmdLeerArchivo = New System.Windows.Forms.Button()
        Me.imgCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.txtLeerPeso = New wclTextBoxSerial.TextBoxSerial()
        Me.chkActivarLectura = New System.Windows.Forms.CheckBox()
        Me.ppdVisor = New System.Windows.Forms.PrintPreviewDialog()
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.chkTipoCorte = New System.Windows.Forms.CheckBox()
        Me.chkEdadGanado = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LoteCortesDet = New Integralab.ORM.CollectionClasses.MscloteCortesDetCollection()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcajas = New System.Windows.Forms.TextBox()
        CType(Me.dgvEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.gpbCanales.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEtiquetas
        '
        Me.dgvEtiquetas.AllowUserToAddRows = False
        Me.dgvEtiquetas.AllowUserToDeleteRows = False
        Me.dgvEtiquetas.AllowUserToResizeRows = False
        Me.dgvEtiquetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEtiquetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvEtiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtiquetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFolioEtiqueta, Me.IdCorte, Me.Nom_Corte, Me.IdProducto, Me.Nom_SubCorte, Me.CantPzas, Me.CantKgrs})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEtiquetas.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvEtiquetas.Location = New System.Drawing.Point(12, 284)
        Me.dgvEtiquetas.MultiSelect = False
        Me.dgvEtiquetas.Name = "dgvEtiquetas"
        Me.dgvEtiquetas.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEtiquetas.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvEtiquetas.RowHeadersVisible = False
        Me.dgvEtiquetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEtiquetas.Size = New System.Drawing.Size(994, 270)
        Me.dgvEtiquetas.TabIndex = 17
        '
        'IdFolioEtiqueta
        '
        Me.IdFolioEtiqueta.HeaderText = "FolioEtiqueta"
        Me.IdFolioEtiqueta.Name = "IdFolioEtiqueta"
        Me.IdFolioEtiqueta.ReadOnly = True
        '
        'IdCorte
        '
        Me.IdCorte.HeaderText = "Código Pre-Corte"
        Me.IdCorte.Name = "IdCorte"
        Me.IdCorte.ReadOnly = True
        Me.IdCorte.Width = 70
        '
        'Nom_Corte
        '
        Me.Nom_Corte.HeaderText = "Pre-Corte"
        Me.Nom_Corte.Name = "Nom_Corte"
        Me.Nom_Corte.ReadOnly = True
        Me.Nom_Corte.Width = 150
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "Codigo"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Width = 60
        '
        'Nom_SubCorte
        '
        Me.Nom_SubCorte.HeaderText = "Descripcion"
        Me.Nom_SubCorte.Name = "Nom_SubCorte"
        Me.Nom_SubCorte.ReadOnly = True
        Me.Nom_SubCorte.Width = 200
        '
        'CantPzas
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.CantPzas.DefaultCellStyle = DataGridViewCellStyle16
        Me.CantPzas.HeaderText = "Piezas"
        Me.CantPzas.Name = "CantPzas"
        Me.CantPzas.ReadOnly = True
        Me.CantPzas.Width = 60
        '
        'CantKgrs
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "N3"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.CantKgrs.DefaultCellStyle = DataGridViewCellStyle17
        Me.CantKgrs.HeaderText = "Kilos"
        Me.CantKgrs.Name = "CantKgrs"
        Me.CantKgrs.ReadOnly = True
        Me.CantKgrs.Width = 80
        '
        'txtAlmacen
        '
        Me.txtAlmacen.AcceptsReturn = True
        Me.txtAlmacen.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlmacen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlmacen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAlmacen.Location = New System.Drawing.Point(924, 258)
        Me.txtAlmacen.MaxLength = 0
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAlmacen.Size = New System.Drawing.Size(82, 20)
        Me.txtAlmacen.TabIndex = 12
        Me.txtAlmacen.Visible = False
        '
        'txtLoteFapsa
        '
        Me.txtLoteFapsa.AcceptsReturn = True
        Me.txtLoteFapsa.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoteFapsa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoteFapsa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoteFapsa.Location = New System.Drawing.Point(813, 258)
        Me.txtLoteFapsa.MaxLength = 0
        Me.txtLoteFapsa.Name = "txtLoteFapsa"
        Me.txtLoteFapsa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoteFapsa.Size = New System.Drawing.Size(105, 20)
        Me.txtLoteFapsa.TabIndex = 11
        Me.txtLoteFapsa.Visible = False
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeso.Location = New System.Drawing.Point(389, 192)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(161, 50)
        Me.txtPeso.TabIndex = 7
        Me.txtPeso.Text = "0.000"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPiezas
        '
        Me.txtPiezas.AcceptsReturn = True
        Me.txtPiezas.BackColor = System.Drawing.SystemColors.Window
        Me.txtPiezas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiezas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPiezas.Location = New System.Drawing.Point(252, 190)
        Me.txtPiezas.MaxLength = 0
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPiezas.Size = New System.Drawing.Size(81, 50)
        Me.txtPiezas.TabIndex = 6
        Me.txtPiezas.Text = "0"
        Me.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubCorte
        '
        Me.txtSubCorte.AcceptsReturn = True
        Me.txtSubCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtSubCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubCorte.Enabled = False
        Me.txtSubCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSubCorte.Location = New System.Drawing.Point(173, 141)
        Me.txtSubCorte.MaxLength = 0
        Me.txtSubCorte.Name = "txtSubCorte"
        Me.txtSubCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSubCorte.Size = New System.Drawing.Size(377, 44)
        Me.txtSubCorte.TabIndex = 4
        '
        'txtCodSubCorte
        '
        Me.txtCodSubCorte.AcceptsReturn = True
        Me.txtCodSubCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodSubCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodSubCorte.Enabled = False
        Me.txtCodSubCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSubCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodSubCorte.Location = New System.Drawing.Point(102, 141)
        Me.txtCodSubCorte.MaxLength = 0
        Me.txtCodSubCorte.Name = "txtCodSubCorte"
        Me.txtCodSubCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodSubCorte.Size = New System.Drawing.Size(65, 44)
        Me.txtCodSubCorte.TabIndex = 3
        Me.txtCodSubCorte.Text = "0"
        Me.txtCodSubCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorte
        '
        Me.txtCorte.AcceptsReturn = True
        Me.txtCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorte.Enabled = False
        Me.txtCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorte.Location = New System.Drawing.Point(173, 108)
        Me.txtCorte.MaxLength = 0
        Me.txtCorte.Name = "txtCorte"
        Me.txtCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorte.Size = New System.Drawing.Size(377, 26)
        Me.txtCorte.TabIndex = 1
        '
        'txtCodCorte
        '
        Me.txtCodCorte.AcceptsReturn = True
        Me.txtCodCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodCorte.Enabled = False
        Me.txtCodCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodCorte.Location = New System.Drawing.Point(102, 108)
        Me.txtCodCorte.MaxLength = 0
        Me.txtCodCorte.Name = "txtCodCorte"
        Me.txtCodCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodCorte.Size = New System.Drawing.Size(65, 26)
        Me.txtCodCorte.TabIndex = 0
        Me.txtCodCorte.Text = "0"
        Me.txtCodCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasCad
        '
        Me.txtDiasCad.AcceptsReturn = True
        Me.txtDiasCad.BackColor = System.Drawing.SystemColors.Window
        Me.txtDiasCad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiasCad.Enabled = False
        Me.txtDiasCad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasCad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiasCad.Location = New System.Drawing.Point(334, 76)
        Me.txtDiasCad.MaxLength = 0
        Me.txtDiasCad.Name = "txtDiasCad"
        Me.txtDiasCad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiasCad.Size = New System.Drawing.Size(41, 26)
        Me.txtDiasCad.TabIndex = 54
        Me.txtDiasCad.Text = "0"
        Me.txtDiasCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.AcceptsReturn = True
        Me.txtLoteCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtLoteCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteCorte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLoteCorte.Location = New System.Drawing.Point(102, 41)
        Me.txtLoteCorte.MaxLength = 0
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoteCorte.Size = New System.Drawing.Size(100, 29)
        Me.txtLoteCorte.TabIndex = 53
        '
        'cmdBuscarCortes
        '
        Me.cmdBuscarCortes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscarCortes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuscarCortes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscarCortes.Image = CType(resources.GetObject("cmdBuscarCortes.Image"), System.Drawing.Image)
        Me.cmdBuscarCortes.Location = New System.Drawing.Point(628, 41)
        Me.cmdBuscarCortes.Name = "cmdBuscarCortes"
        Me.cmdBuscarCortes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBuscarCortes.Size = New System.Drawing.Size(51, 44)
        Me.cmdBuscarCortes.TabIndex = 5
        Me.cmdBuscarCortes.TabStop = False
        Me.cmdBuscarCortes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBuscarCortes.UseVisualStyleBackColor = False
        Me.cmdBuscarCortes.Visible = False
        '
        'cmdBuscarPreCortes
        '
        Me.cmdBuscarPreCortes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscarPreCortes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBuscarPreCortes.Enabled = False
        Me.cmdBuscarPreCortes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscarPreCortes.Image = CType(resources.GetObject("cmdBuscarPreCortes.Image"), System.Drawing.Image)
        Me.cmdBuscarPreCortes.Location = New System.Drawing.Point(485, 109)
        Me.cmdBuscarPreCortes.Name = "cmdBuscarPreCortes"
        Me.cmdBuscarPreCortes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBuscarPreCortes.Size = New System.Drawing.Size(31, 26)
        Me.cmdBuscarPreCortes.TabIndex = 2
        Me.cmdBuscarPreCortes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdBuscarPreCortes.UseVisualStyleBackColor = False
        Me.cmdBuscarPreCortes.Visible = False
        '
        'CmdImprimir
        '
        Me.CmdImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImprimir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdImprimir.Image = CType(resources.GetObject("CmdImprimir.Image"), System.Drawing.Image)
        Me.CmdImprimir.Location = New System.Drawing.Point(648, 91)
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdImprimir.Size = New System.Drawing.Size(31, 26)
        Me.CmdImprimir.TabIndex = 10
        Me.CmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdImprimir.UseVisualStyleBackColor = False
        Me.CmdImprimir.Visible = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.txtTotKgrs)
        Me.Frame2.Controls.Add(Me.txtTotPzas)
        Me.Frame2.Controls.Add(Me.txtTotEti)
        Me.Frame2.Controls.Add(Me._LblEtiqueta_4)
        Me.Frame2.Controls.Add(Me._LblEtiqueta_5)
        Me.Frame2.Controls.Add(Me._LblEtiqueta_10)
        Me.Frame2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Frame2.Location = New System.Drawing.Point(813, 36)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(193, 121)
        Me.Frame2.TabIndex = 60
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Totales"
        Me.Frame2.Visible = False
        '
        'txtTotKgrs
        '
        Me.txtTotKgrs.AcceptsReturn = True
        Me.txtTotKgrs.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotKgrs.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotKgrs.Enabled = False
        Me.txtTotKgrs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotKgrs.Location = New System.Drawing.Point(80, 88)
        Me.txtTotKgrs.MaxLength = 0
        Me.txtTotKgrs.Name = "txtTotKgrs"
        Me.txtTotKgrs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotKgrs.Size = New System.Drawing.Size(105, 20)
        Me.txtTotKgrs.TabIndex = 15
        Me.txtTotKgrs.Text = "0.000"
        Me.txtTotKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotPzas
        '
        Me.txtTotPzas.AcceptsReturn = True
        Me.txtTotPzas.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotPzas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotPzas.Enabled = False
        Me.txtTotPzas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotPzas.Location = New System.Drawing.Point(80, 56)
        Me.txtTotPzas.MaxLength = 0
        Me.txtTotPzas.Name = "txtTotPzas"
        Me.txtTotPzas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotPzas.Size = New System.Drawing.Size(105, 20)
        Me.txtTotPzas.TabIndex = 14
        Me.txtTotPzas.Text = "0"
        Me.txtTotPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotEti
        '
        Me.txtTotEti.AcceptsReturn = True
        Me.txtTotEti.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotEti.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotEti.Enabled = False
        Me.txtTotEti.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotEti.Location = New System.Drawing.Point(80, 24)
        Me.txtTotEti.MaxLength = 0
        Me.txtTotEti.Name = "txtTotEti"
        Me.txtTotEti.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotEti.Size = New System.Drawing.Size(105, 20)
        Me.txtTotEti.TabIndex = 13
        Me.txtTotEti.Text = "0"
        Me.txtTotEti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_LblEtiqueta_4
        '
        Me._LblEtiqueta_4.AutoSize = True
        Me._LblEtiqueta_4.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_4.Location = New System.Drawing.Point(16, 60)
        Me._LblEtiqueta_4.Name = "_LblEtiqueta_4"
        Me._LblEtiqueta_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_4.Size = New System.Drawing.Size(47, 13)
        Me._LblEtiqueta_4.TabIndex = 17
        Me._LblEtiqueta_4.Text = "Piezas : "
        '
        '_LblEtiqueta_5
        '
        Me._LblEtiqueta_5.AutoSize = True
        Me._LblEtiqueta_5.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_5.Location = New System.Drawing.Point(16, 92)
        Me._LblEtiqueta_5.Name = "_LblEtiqueta_5"
        Me._LblEtiqueta_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_5.Size = New System.Drawing.Size(35, 13)
        Me._LblEtiqueta_5.TabIndex = 16
        Me._LblEtiqueta_5.Text = "Kilos :"
        '
        '_LblEtiqueta_10
        '
        Me._LblEtiqueta_10.AutoSize = True
        Me._LblEtiqueta_10.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_10.Location = New System.Drawing.Point(16, 28)
        Me._LblEtiqueta_10.Name = "_LblEtiqueta_10"
        Me._LblEtiqueta_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_10.Size = New System.Drawing.Size(60, 13)
        Me._LblEtiqueta_10.TabIndex = 15
        Me._LblEtiqueta_10.Text = "Etiquetas : "
        '
        '_LblEtiqueta_11
        '
        Me._LblEtiqueta_11.AutoSize = True
        Me._LblEtiqueta_11.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_11.Location = New System.Drawing.Point(14, 157)
        Me._LblEtiqueta_11.Name = "_LblEtiqueta_11"
        Me._LblEtiqueta_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_11.Size = New System.Drawing.Size(38, 13)
        Me._LblEtiqueta_11.TabIndex = 68
        Me._LblEtiqueta_11.Text = "Corte :"
        '
        '_LblEtiqueta_0
        '
        Me._LblEtiqueta_0.AutoSize = True
        Me._LblEtiqueta_0.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_0.Location = New System.Drawing.Point(14, 55)
        Me._LblEtiqueta_0.Name = "_LblEtiqueta_0"
        Me._LblEtiqueta_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_0.Size = New System.Drawing.Size(88, 13)
        Me._LblEtiqueta_0.TabIndex = 67
        Me._LblEtiqueta_0.Text = "Folio de compra :"
        '
        '_LblEtiqueta_1
        '
        Me._LblEtiqueta_1.AutoSize = True
        Me._LblEtiqueta_1.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_1.Location = New System.Drawing.Point(14, 115)
        Me._LblEtiqueta_1.Name = "_LblEtiqueta_1"
        Me._LblEtiqueta_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_1.Size = New System.Drawing.Size(60, 13)
        Me._LblEtiqueta_1.TabIndex = 66
        Me._LblEtiqueta_1.Text = "Pre- Corte :"
        '
        '_LblEtiqueta_2
        '
        Me._LblEtiqueta_2.AutoSize = True
        Me._LblEtiqueta_2.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_2.Location = New System.Drawing.Point(14, 84)
        Me._LblEtiqueta_2.Name = "_LblEtiqueta_2"
        Me._LblEtiqueta_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_2.Size = New System.Drawing.Size(43, 13)
        Me._LblEtiqueta_2.TabIndex = 65
        Me._LblEtiqueta_2.Text = "Fecha :"
        '
        '_LblEtiqueta_3
        '
        Me._LblEtiqueta_3.AutoSize = True
        Me._LblEtiqueta_3.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LblEtiqueta_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_3.Location = New System.Drawing.Point(339, 211)
        Me._LblEtiqueta_3.Name = "_LblEtiqueta_3"
        Me._LblEtiqueta_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_3.Size = New System.Drawing.Size(44, 16)
        Me._LblEtiqueta_3.TabIndex = 64
        Me._LblEtiqueta_3.Text = "Kgrs. :"
        '
        '_LblEtiqueta_7
        '
        Me._LblEtiqueta_7.AutoSize = True
        Me._LblEtiqueta_7.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LblEtiqueta_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_7.Location = New System.Drawing.Point(191, 209)
        Me._LblEtiqueta_7.Name = "_LblEtiqueta_7"
        Me._LblEtiqueta_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_7.Size = New System.Drawing.Size(55, 16)
        Me._LblEtiqueta_7.TabIndex = 63
        Me._LblEtiqueta_7.Text = "Piezas :"
        '
        '_LblEtiqueta_8
        '
        Me._LblEtiqueta_8.AutoSize = True
        Me._LblEtiqueta_8.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_8.Location = New System.Drawing.Point(238, 80)
        Me._LblEtiqueta_8.Name = "_LblEtiqueta_8"
        Me._LblEtiqueta_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_8.Size = New System.Drawing.Size(90, 13)
        Me._LblEtiqueta_8.TabIndex = 62
        Me._LblEtiqueta_8.Text = "Días Caducidad :"
        '
        '_LblEtiqueta_9
        '
        Me._LblEtiqueta_9.AutoSize = True
        Me._LblEtiqueta_9.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_9.Location = New System.Drawing.Point(390, 80)
        Me._LblEtiqueta_9.Name = "_LblEtiqueta_9"
        Me._LblEtiqueta_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_9.Size = New System.Drawing.Size(65, 13)
        Me._LblEtiqueta_9.TabIndex = 61
        Me._LblEtiqueta_9.Text = "Fecha Cad :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(1018, 33)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = " Captura de Productos De terceros"
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCorte.Location = New System.Drawing.Point(102, 76)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(130, 26)
        Me.dtpFechaCorte.TabIndex = 72
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaducidad.Enabled = False
        Me.dtpFechaCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(461, 77)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(133, 26)
        Me.dtpFechaCaducidad.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Introductor :"
        Me.Label2.Visible = False
        '
        'txtProveedor
        '
        Me.txtProveedor.AcceptsReturn = True
        Me.txtProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtProveedor.Location = New System.Drawing.Point(102, 108)
        Me.txtProveedor.MaxLength = 0
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtProveedor.Size = New System.Drawing.Size(377, 26)
        Me.txtProveedor.TabIndex = 75
        Me.txtProveedor.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(14, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Cliente :"
        '
        'cmbClientes
        '
        Me.cmbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(102, 247)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(321, 28)
        Me.cmbClientes.TabIndex = 8
        '
        'gpbCanales
        '
        Me.gpbCanales.BackColor = System.Drawing.SystemColors.Control
        Me.gpbCanales.Controls.Add(Me.txtKilosCanales)
        Me.gpbCanales.Controls.Add(Me.txtPiezasCanales)
        Me.gpbCanales.Controls.Add(Me.Label4)
        Me.gpbCanales.Controls.Add(Me.Label5)
        Me.gpbCanales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gpbCanales.Location = New System.Drawing.Point(813, 163)
        Me.gpbCanales.Name = "gpbCanales"
        Me.gpbCanales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gpbCanales.Size = New System.Drawing.Size(193, 89)
        Me.gpbCanales.TabIndex = 61
        Me.gpbCanales.TabStop = False
        Me.gpbCanales.Text = "Total Producto De terceros"
        '
        'txtKilosCanales
        '
        Me.txtKilosCanales.AcceptsReturn = True
        Me.txtKilosCanales.BackColor = System.Drawing.SystemColors.Window
        Me.txtKilosCanales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKilosCanales.Enabled = False
        Me.txtKilosCanales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKilosCanales.Location = New System.Drawing.Point(80, 59)
        Me.txtKilosCanales.MaxLength = 0
        Me.txtKilosCanales.Name = "txtKilosCanales"
        Me.txtKilosCanales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKilosCanales.Size = New System.Drawing.Size(105, 20)
        Me.txtKilosCanales.TabIndex = 15
        Me.txtKilosCanales.Text = "0.000"
        Me.txtKilosCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPiezasCanales
        '
        Me.txtPiezasCanales.AcceptsReturn = True
        Me.txtPiezasCanales.BackColor = System.Drawing.SystemColors.Window
        Me.txtPiezasCanales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPiezasCanales.Enabled = False
        Me.txtPiezasCanales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPiezasCanales.Location = New System.Drawing.Point(80, 27)
        Me.txtPiezasCanales.MaxLength = 0
        Me.txtPiezasCanales.Name = "txtPiezasCanales"
        Me.txtPiezasCanales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPiezasCanales.Size = New System.Drawing.Size(105, 20)
        Me.txtPiezasCanales.TabIndex = 14
        Me.txtPiezasCanales.Text = "0"
        Me.txtPiezasCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Piezas : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Kilos :"
        '
        'txtFolioReferencia
        '
        Me.txtFolioReferencia.Location = New System.Drawing.Point(393, 44)
        Me.txtFolioReferencia.MaxLength = 14
        Me.txtFolioReferencia.Name = "txtFolioReferencia"
        Me.txtFolioReferencia.Size = New System.Drawing.Size(180, 20)
        Me.txtFolioReferencia.TabIndex = 82
        Me.txtFolioReferencia.Visible = False
        '
        'lblFolioReferencia
        '
        Me.lblFolioReferencia.AutoSize = True
        Me.lblFolioReferencia.Location = New System.Drawing.Point(285, 47)
        Me.lblFolioReferencia.Name = "lblFolioReferencia"
        Me.lblFolioReferencia.Size = New System.Drawing.Size(102, 13)
        Me.lblFolioReferencia.TabIndex = 81
        Me.lblFolioReferencia.Text = "Folio de Referencia:"
        Me.lblFolioReferencia.Visible = False
        '
        'cmdLeerArchivo
        '
        Me.cmdLeerArchivo.ImageIndex = 3
        Me.cmdLeerArchivo.ImageList = Me.imgCajas
        Me.cmdLeerArchivo.Location = New System.Drawing.Point(579, 36)
        Me.cmdLeerArchivo.Name = "cmdLeerArchivo"
        Me.cmdLeerArchivo.Size = New System.Drawing.Size(38, 33)
        Me.cmdLeerArchivo.TabIndex = 80
        Me.cmdLeerArchivo.UseVisualStyleBackColor = True
        Me.cmdLeerArchivo.Visible = False
        '
        'imgCajas
        '
        Me.imgCajas.ImageStream = CType(resources.GetObject("imgCajas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCajas.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCajas.Images.SetKeyName(0, "images.jpg")
        Me.imgCajas.Images.SetKeyName(1, "caja.jpg")
        Me.imgCajas.Images.SetKeyName(2, "MC9000Ga.jpg")
        Me.imgCajas.Images.SetKeyName(3, "pistola.jpg")
        '
        'txtLeerPeso
        '
        Me.txtLeerPeso.BaudRate = 9600
        Me.txtLeerPeso.DataBit = 8
        Me.txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtLeerPeso.Location = New System.Drawing.Point(436, 247)
        Me.txtLeerPeso.Name = "txtLeerPeso"
        Me.txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtLeerPeso.Port = 1
        Me.txtLeerPeso.Size = New System.Drawing.Size(80, 20)
        Me.txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtLeerPeso.TabIndex = 83
        Me.txtLeerPeso.TimeOut = 1500
        Me.txtLeerPeso.TimeToWaitForMoreData = 300
        Me.txtLeerPeso.Visible = False
        '
        'chkActivarLectura
        '
        Me.chkActivarLectura.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkActivarLectura.Location = New System.Drawing.Point(556, 192)
        Me.chkActivarLectura.Name = "chkActivarLectura"
        Me.chkActivarLectura.Size = New System.Drawing.Size(80, 50)
        Me.chkActivarLectura.TabIndex = 92
        Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
        Me.chkActivarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkActivarLectura.UseVisualStyleBackColor = True
        '
        'ppdVisor
        '
        Me.ppdVisor.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdVisor.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdVisor.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdVisor.Enabled = True
        Me.ppdVisor.Icon = CType(resources.GetObject("ppdVisor.Icon"), System.Drawing.Icon)
        Me.ppdVisor.Name = "ppdVisor"
        Me.ppdVisor.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "FolioEtiqueta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CodPreCorte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pre-Corte"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn6.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "fELCHA.JPG")
        Me.ListaImagenes.Images.SetKeyName(1, "GetAttachment.aspx.jpg")
        '
        'chkTipoCorte
        '
        Me.chkTipoCorte.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkTipoCorte.BackColor = System.Drawing.Color.MistyRose
        Me.chkTipoCorte.FlatAppearance.BorderSize = 0
        Me.chkTipoCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTipoCorte.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTipoCorte.Location = New System.Drawing.Point(642, 193)
        Me.chkTipoCorte.Name = "chkTipoCorte"
        Me.chkTipoCorte.Size = New System.Drawing.Size(92, 51)
        Me.chkTipoCorte.TabIndex = 94
        Me.chkTipoCorte.Text = "Fresco"
        Me.chkTipoCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkTipoCorte.UseVisualStyleBackColor = False
        '
        'chkEdadGanado
        '
        Me.chkEdadGanado.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEdadGanado.FlatAppearance.BorderSize = 0
        Me.chkEdadGanado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEdadGanado.Location = New System.Drawing.Point(740, 192)
        Me.chkEdadGanado.Name = "chkEdadGanado"
        Me.chkEdadGanado.Size = New System.Drawing.Size(66, 50)
        Me.chkEdadGanado.TabIndex = 96
        Me.chkEdadGanado.Text = "-30"
        Me.chkEdadGanado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkEdadGanado.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(102, 363)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 126)
        Me.Panel1.TabIndex = 97
        '
        'LoteCortesDet
        '
        Me.LoteCortesDet.ActiveContext = Nothing
        Me.LoteCortesDet.AllowEdit = True
        Me.LoteCortesDet.AllowNew = True
        Me.LoteCortesDet.AllowRemove = True
        Me.LoteCortesDet.Capacity = 32
        Me.LoteCortesDet.ConcurrencyPredicateFactoryToUse = Nothing
        Me.LoteCortesDet.DoNotPerformAddIfPresent = False
        Me.LoteCortesDet.EntityFactoryToUse = New Integralab.ORM.FactoryClasses.MscloteCortesDetEntityFactory()
        Me.LoteCortesDet.IsReadOnly = False
        Me.LoteCortesDet.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.LoteCortesDet.SortClauses = Nothing
        Me.LoteCortesDet.SuppressClearInGetMulti = False
        Me.LoteCortesDet.Transaction = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(48, 32)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Cajas/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bultos:"
        '
        'txtcajas
        '
        Me.txtcajas.AcceptsReturn = True
        Me.txtcajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtcajas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcajas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtcajas.Location = New System.Drawing.Point(102, 194)
        Me.txtcajas.MaxLength = 0
        Me.txtcajas.Name = "txtcajas"
        Me.txtcajas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtcajas.Size = New System.Drawing.Size(81, 50)
        Me.txtcajas.TabIndex = 99
        Me.txtcajas.Text = "0"
        Me.txtcajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmCapturaProdTerminado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 595)
        Me.Controls.Add(Me.txtcajas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkTipoCorte)
        Me.Controls.Add(Me.chkActivarLectura)
        Me.Controls.Add(Me.txtLeerPeso)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me.txtSubCorte)
        Me.Controls.Add(Me.txtCodSubCorte)
        Me.Controls.Add(Me.txtCorte)
        Me.Controls.Add(Me.txtCodCorte)
        Me.Controls.Add(Me.cmdBuscarCortes)
        Me.Controls.Add(Me._LblEtiqueta_11)
        Me.Controls.Add(Me._LblEtiqueta_1)
        Me.Controls.Add(Me._LblEtiqueta_3)
        Me.Controls.Add(Me._LblEtiqueta_7)
        Me.Controls.Add(Me.chkEdadGanado)
        Me.Controls.Add(Me.dgvEtiquetas)
        Me.Controls.Add(Me.txtFolioReferencia)
        Me.Controls.Add(Me.lblFolioReferencia)
        Me.Controls.Add(Me.cmdLeerArchivo)
        Me.Controls.Add(Me.gpbCanales)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaCaducidad)
        Me.Controls.Add(Me.dtpFechaCorte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.txtLoteFapsa)
        Me.Controls.Add(Me.txtDiasCad)
        Me.Controls.Add(Me.txtLoteCorte)
        Me.Controls.Add(Me.cmdBuscarPreCortes)
        Me.Controls.Add(Me.CmdImprimir)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me._LblEtiqueta_0)
        Me.Controls.Add(Me._LblEtiqueta_2)
        Me.Controls.Add(Me._LblEtiqueta_8)
        Me.Controls.Add(Me._LblEtiqueta_9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCapturaProdTerminado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Producto Terminado"
        CType(Me.dgvEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.gpbCanales.ResumeLayout(False)
        Me.gpbCanales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEtiquetas As System.Windows.Forms.DataGridView
    Friend WithEvents LoteCortesDet As IntegraLab.ORM.CollectionClasses.MscloteCortesDetCollection
    Friend WithEvents IdFolioLoteCorteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFolioEtquetaReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents txtAlmacen As System.Windows.Forms.TextBox
    Public WithEvents txtLoteFapsa As System.Windows.Forms.TextBox
    Public WithEvents txtPeso As System.Windows.Forms.TextBox
    Public WithEvents txtPiezas As System.Windows.Forms.TextBox
    Public WithEvents txtSubCorte As System.Windows.Forms.TextBox
    Public WithEvents txtCodSubCorte As System.Windows.Forms.TextBox
    Public WithEvents txtCorte As System.Windows.Forms.TextBox
    Public WithEvents txtCodCorte As System.Windows.Forms.TextBox
    Public WithEvents txtDiasCad As System.Windows.Forms.TextBox
    Public WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Public WithEvents cmdBuscarCortes As System.Windows.Forms.Button
    Public WithEvents cmdBuscarPreCortes As System.Windows.Forms.Button
    Public WithEvents CmdImprimir As System.Windows.Forms.Button
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents txtTotKgrs As System.Windows.Forms.TextBox
    Public WithEvents txtTotPzas As System.Windows.Forms.TextBox
    Public WithEvents txtTotEti As System.Windows.Forms.TextBox
    Public WithEvents _LblEtiqueta_4 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_5 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_10 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_11 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_0 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_1 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_2 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_3 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_7 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_8 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_9 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaCaducidad As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtProveedor As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents gpbCanales As System.Windows.Forms.GroupBox
    Public WithEvents txtKilosCanales As System.Windows.Forms.TextBox
    Public WithEvents txtPiezasCanales As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolioReferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblFolioReferencia As System.Windows.Forms.Label
    Friend WithEvents cmdLeerArchivo As System.Windows.Forms.Button
    Friend WithEvents txtLeerPeso As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents chkActivarLectura As System.Windows.Forms.CheckBox
    Friend WithEvents ppdVisor As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents imgCajas As System.Windows.Forms.ImageList
    Friend WithEvents chkTipoCorte As System.Windows.Forms.CheckBox
    'Friend WithEvents codigobarras As AxTALBarCode.AxTALBarCd
    Friend WithEvents chkEdadGanado As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IdFolioEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_Corte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom_SubCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantPzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtcajas As System.Windows.Forms.TextBox
End Class
