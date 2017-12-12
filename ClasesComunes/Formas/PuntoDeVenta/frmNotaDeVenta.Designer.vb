<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaDeVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotaDeVenta))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.grpCaptura = New System.Windows.Forms.GroupBox()
        Me.btnAbrirCajon = New System.Windows.Forms.Button()
        Me.grpUltimaOper = New System.Windows.Forms.GroupBox()
        Me.lblImpCambioAnt = New System.Windows.Forms.Label()
        Me.lblImpPagoAnt = New System.Windows.Forms.Label()
        Me.lblImpTotalAnt = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnCantidad = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGranTotal = New System.Windows.Forms.Label()
        Me.btnAltRap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpFunciones = New System.Windows.Forms.GroupBox()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.Button()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.txthistorial = New System.Windows.Forms.TextBox()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.lblNotRet = New System.Windows.Forms.Label()
        Me.lblNotasRet = New System.Windows.Forms.Label()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.btnRetener = New System.Windows.Forms.Button()
        Me.btnCorteZ = New System.Windows.Forms.Button()
        Me.btnRetiro = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCorteX = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.clmCodProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioUnitSIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDesctoUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIVAUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcIEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIEPSUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIeps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmContKit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodprodComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpLogo = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.TmrListaPrecios = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel.SuspendLayout()
        Me.grpCaptura.SuspendLayout()
        Me.grpUltimaOper.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpFunciones.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogo.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Controls.Add(Me.grpCaptura, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.grpFunciones, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.grpLogo, 0, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 2
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(1000, 668)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'grpCaptura
        '
        Me.grpCaptura.Controls.Add(Me.btnAbrirCajon)
        Me.grpCaptura.Controls.Add(Me.grpUltimaOper)
        Me.grpCaptura.Controls.Add(Me.txtArticulo)
        Me.grpCaptura.Controls.Add(Me.btnCobrar)
        Me.grpCaptura.Controls.Add(Me.btnCantidad)
        Me.grpCaptura.Controls.Add(Me.Panel1)
        Me.grpCaptura.Controls.Add(Me.btnAltRap)
        Me.grpCaptura.Controls.Add(Me.Label1)
        Me.grpCaptura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCaptura.Location = New System.Drawing.Point(249, 485)
        Me.grpCaptura.Name = "grpCaptura"
        Me.grpCaptura.Size = New System.Drawing.Size(748, 180)
        Me.grpCaptura.TabIndex = 1
        Me.grpCaptura.TabStop = False
        '
        'btnAbrirCajon
        '
        Me.btnAbrirCajon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbrirCajon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirCajon.Location = New System.Drawing.Point(405, 19)
        Me.btnAbrirCajon.Name = "btnAbrirCajon"
        Me.btnAbrirCajon.Size = New System.Drawing.Size(80, 54)
        Me.btnAbrirCajon.TabIndex = 17
        Me.btnAbrirCajon.Text = "Alt+F8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abrir Cajón"
        Me.btnAbrirCajon.UseVisualStyleBackColor = True
        Me.btnAbrirCajon.Visible = False
        '
        'grpUltimaOper
        '
        Me.grpUltimaOper.Controls.Add(Me.lblImpCambioAnt)
        Me.grpUltimaOper.Controls.Add(Me.lblImpPagoAnt)
        Me.grpUltimaOper.Controls.Add(Me.lblImpTotalAnt)
        Me.grpUltimaOper.Controls.Add(Me.Label11)
        Me.grpUltimaOper.Controls.Add(Me.Label10)
        Me.grpUltimaOper.Controls.Add(Me.Label2)
        Me.grpUltimaOper.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUltimaOper.Location = New System.Drawing.Point(6, 79)
        Me.grpUltimaOper.Name = "grpUltimaOper"
        Me.grpUltimaOper.Size = New System.Drawing.Size(244, 95)
        Me.grpUltimaOper.TabIndex = 16
        Me.grpUltimaOper.TabStop = False
        Me.grpUltimaOper.Text = "Última operación"
        Me.grpUltimaOper.Visible = False
        '
        'lblImpCambioAnt
        '
        Me.lblImpCambioAnt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpCambioAnt.Location = New System.Drawing.Point(92, 63)
        Me.lblImpCambioAnt.Name = "lblImpCambioAnt"
        Me.lblImpCambioAnt.Size = New System.Drawing.Size(125, 18)
        Me.lblImpCambioAnt.TabIndex = 12
        Me.lblImpCambioAnt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpPagoAnt
        '
        Me.lblImpPagoAnt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpPagoAnt.Location = New System.Drawing.Point(92, 45)
        Me.lblImpPagoAnt.Name = "lblImpPagoAnt"
        Me.lblImpPagoAnt.Size = New System.Drawing.Size(125, 18)
        Me.lblImpPagoAnt.TabIndex = 11
        Me.lblImpPagoAnt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpTotalAnt
        '
        Me.lblImpTotalAnt.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImpTotalAnt.Location = New System.Drawing.Point(92, 27)
        Me.lblImpTotalAnt.Name = "lblImpTotalAnt"
        Me.lblImpTotalAnt.Size = New System.Drawing.Size(125, 18)
        Me.lblImpTotalAnt.TabIndex = 10
        Me.lblImpTotalAnt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cambio:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Pago:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtArticulo
        '
        Me.txtArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArticulo.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(6, 42)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(393, 31)
        Me.txtArticulo.TabIndex = 3
        '
        'btnCobrar
        '
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCobrar.Location = New System.Drawing.Point(662, 19)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(80, 54)
        Me.btnCobrar.TabIndex = 4
        Me.btnCobrar.Text = "F8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'btnCantidad
        '
        Me.btnCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidad.Location = New System.Drawing.Point(490, 19)
        Me.btnCantidad.Name = "btnCantidad"
        Me.btnCantidad.Size = New System.Drawing.Size(80, 54)
        Me.btnCantidad.TabIndex = 4
        Me.btnCantidad.Text = "F4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cantidad"
        Me.btnCantidad.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblGranTotal)
        Me.Panel1.Location = New System.Drawing.Point(256, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 62)
        Me.Panel1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(107, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 56)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total"
        '
        'lblGranTotal
        '
        Me.lblGranTotal.AutoSize = True
        Me.lblGranTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblGranTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGranTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblGranTotal.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGranTotal.Location = New System.Drawing.Point(242, 0)
        Me.lblGranTotal.MinimumSize = New System.Drawing.Size(241, 58)
        Me.lblGranTotal.Name = "lblGranTotal"
        Me.lblGranTotal.Size = New System.Drawing.Size(241, 58)
        Me.lblGranTotal.TabIndex = 17
        Me.lblGranTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnAltRap
        '
        Me.btnAltRap.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAltRap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAltRap.Location = New System.Drawing.Point(576, 19)
        Me.btnAltRap.Name = "btnAltRap"
        Me.btnAltRap.Size = New System.Drawing.Size(80, 54)
        Me.btnAltRap.TabIndex = 5
        Me.btnAltRap.Text = "F5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alta Rápida"
        Me.btnAltRap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código de artículo"
        '
        'grpFunciones
        '
        Me.grpFunciones.Controls.Add(Me.btnReimprimir)
        Me.grpFunciones.Controls.Add(Me.txtBuscar)
        Me.grpFunciones.Controls.Add(Me.btnAyuda)
        Me.grpFunciones.Controls.Add(Me.txthistorial)
        Me.grpFunciones.Controls.Add(Me.btnCompras)
        Me.grpFunciones.Controls.Add(Me.btnIngreso)
        Me.grpFunciones.Controls.Add(Me.lblNotRet)
        Me.grpFunciones.Controls.Add(Me.lblNotasRet)
        Me.grpFunciones.Controls.Add(Me.btnRecuperar)
        Me.grpFunciones.Controls.Add(Me.btnRetener)
        Me.grpFunciones.Controls.Add(Me.btnCorteZ)
        Me.grpFunciones.Controls.Add(Me.btnRetiro)
        Me.grpFunciones.Controls.Add(Me.btnSalir)
        Me.grpFunciones.Controls.Add(Me.btnCorteX)
        Me.grpFunciones.Controls.Add(Me.Label9)
        Me.grpFunciones.Controls.Add(Me.Label8)
        Me.grpFunciones.Controls.Add(Me.Label7)
        Me.grpFunciones.Controls.Add(Me.lblCajero)
        Me.grpFunciones.Controls.Add(Me.lblCaja)
        Me.grpFunciones.Controls.Add(Me.lblSucursal)
        Me.grpFunciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpFunciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFunciones.Location = New System.Drawing.Point(3, 3)
        Me.grpFunciones.Name = "grpFunciones"
        Me.grpFunciones.Size = New System.Drawing.Size(240, 476)
        Me.grpFunciones.TabIndex = 4
        Me.grpFunciones.TabStop = False
        '
        'btnReimprimir
        '
        Me.btnReimprimir.BackColor = System.Drawing.Color.LightGray
        Me.btnReimprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimprimir.Location = New System.Drawing.Point(123, 241)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(111, 41)
        Me.btnReimprimir.TabIndex = 19
        Me.btnReimprimir.Text = " Ctrl+R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Imp. Ultimo"
        Me.btnReimprimir.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.LightGray
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(6, 241)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(109, 41)
        Me.txtBuscar.TabIndex = 18
        Me.txtBuscar.Text = " Ctrl+B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Buscar Nota"
        Me.txtBuscar.UseVisualStyleBackColor = False
        '
        'btnAyuda
        '
        Me.btnAyuda.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAyuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.Location = New System.Drawing.Point(7, 78)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(74, 22)
        Me.btnAyuda.TabIndex = 17
        Me.btnAyuda.Text = "AYUDA"
        Me.btnAyuda.UseVisualStyleBackColor = False
        '
        'txthistorial
        '
        Me.txthistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txthistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthistorial.Location = New System.Drawing.Point(8, 320)
        Me.txthistorial.Multiline = True
        Me.txthistorial.Name = "txthistorial"
        Me.txthistorial.Size = New System.Drawing.Size(222, 78)
        Me.txthistorial.TabIndex = 16
        Me.txthistorial.Visible = False
        '
        'btnCompras
        '
        Me.btnCompras.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Location = New System.Drawing.Point(123, 194)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(111, 41)
        Me.btnCompras.TabIndex = 15
        Me.btnCompras.Text = "Alt+F1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Compra"
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnIngreso
        '
        Me.btnIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.Location = New System.Drawing.Point(123, 106)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(111, 40)
        Me.btnIngreso.TabIndex = 14
        Me.btnIngreso.Text = "F3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingreso"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'lblNotRet
        '
        Me.lblNotRet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotRet.Location = New System.Drawing.Point(87, 78)
        Me.lblNotRet.Name = "lblNotRet"
        Me.lblNotRet.Size = New System.Drawing.Size(100, 16)
        Me.lblNotRet.TabIndex = 13
        Me.lblNotRet.Text = "Notas retenidas:"
        Me.lblNotRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNotRet.Visible = False
        '
        'lblNotasRet
        '
        Me.lblNotasRet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotasRet.BackColor = System.Drawing.SystemColors.Window
        Me.lblNotasRet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNotasRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotasRet.Location = New System.Drawing.Point(190, 76)
        Me.lblNotasRet.Name = "lblNotasRet"
        Me.lblNotasRet.Size = New System.Drawing.Size(44, 20)
        Me.lblNotasRet.TabIndex = 12
        Me.lblNotasRet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNotasRet.Visible = False
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperar.Location = New System.Drawing.Point(123, 19)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(111, 54)
        Me.btnRecuperar.TabIndex = 0
        Me.btnRecuperar.Text = "F7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'btnRetener
        '
        Me.btnRetener.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetener.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetener.Location = New System.Drawing.Point(6, 19)
        Me.btnRetener.Name = "btnRetener"
        Me.btnRetener.Size = New System.Drawing.Size(111, 54)
        Me.btnRetener.TabIndex = 5
        Me.btnRetener.Text = "F6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retener"
        Me.btnRetener.UseVisualStyleBackColor = True
        '
        'btnCorteZ
        '
        Me.btnCorteZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCorteZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorteZ.Location = New System.Drawing.Point(123, 150)
        Me.btnCorteZ.Name = "btnCorteZ"
        Me.btnCorteZ.Size = New System.Drawing.Size(111, 40)
        Me.btnCorteZ.TabIndex = 8
        Me.btnCorteZ.Text = "F11" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Corte Z"
        Me.btnCorteZ.UseVisualStyleBackColor = True
        '
        'btnRetiro
        '
        Me.btnRetiro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetiro.Location = New System.Drawing.Point(6, 106)
        Me.btnRetiro.Name = "btnRetiro"
        Me.btnRetiro.Size = New System.Drawing.Size(111, 40)
        Me.btnRetiro.TabIndex = 9
        Me.btnRetiro.Text = "F9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Retiro"
        Me.btnRetiro.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(6, 194)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 41)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "F12" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCorteX
        '
        Me.btnCorteX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCorteX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorteX.Location = New System.Drawing.Point(6, 150)
        Me.btnCorteX.Name = "btnCorteX"
        Me.btnCorteX.Size = New System.Drawing.Size(111, 40)
        Me.btnCorteX.TabIndex = 7
        Me.btnCorteX.Text = "F10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Corte X"
        Me.btnCorteX.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Cajero:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Caja:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Sucursal:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCajero
        '
        Me.lblCajero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCajero.BackColor = System.Drawing.SystemColors.Window
        Me.lblCajero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(84, 453)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(150, 20)
        Me.lblCajero.TabIndex = 8
        Me.lblCajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCaja
        '
        Me.lblCaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaja.BackColor = System.Drawing.SystemColors.Window
        Me.lblCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(84, 427)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(150, 20)
        Me.lblCaja.TabIndex = 7
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSucursal
        '
        Me.lblSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSucursal.BackColor = System.Drawing.SystemColors.Window
        Me.lblSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(84, 401)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(150, 20)
        Me.lblSucursal.TabIndex = 6
        Me.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(748, 476)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeColumns = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodProducto, Me.clmCantidad, Me.clmDescripcion, Me.clmPrecioUnitSIva, Me.clmPrecioUnit, Me.clmDesctoUnit, Me.clmDescuento, Me.clmPorcIVA, Me.clmIVAUnit, Me.clmIva, Me.clmPorcIEPS, Me.clmIEPSUnit, Me.clmIeps, Me.clmTotal, Me.clmContKit, Me.clmCodprodComp})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.RowTemplate.Height = 44
        Me.dgvDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(742, 457)
        Me.dgvDetalle.TabIndex = 0
        '
        'clmCodProducto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.clmCodProducto.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCodProducto.HeaderText = "CodProducto"
        Me.clmCodProducto.Name = "clmCodProducto"
        Me.clmCodProducto.ReadOnly = True
        Me.clmCodProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmCodProducto.Visible = False
        '
        'clmCantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCantidad.FillWeight = 12.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmDescripcion
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmDescripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescripcion.FillWeight = 40.0!
        Me.clmDescripcion.HeaderText = "Descripción"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmPrecioUnitSIva
        '
        Me.clmPrecioUnitSIva.FillWeight = 12.0!
        Me.clmPrecioUnitSIva.HeaderText = "Precio Unitario Sin IVA"
        Me.clmPrecioUnitSIva.Name = "clmPrecioUnitSIva"
        Me.clmPrecioUnitSIva.ReadOnly = True
        Me.clmPrecioUnitSIva.Visible = False
        '
        'clmPrecioUnit
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.clmPrecioUnit.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPrecioUnit.FillWeight = 12.0!
        Me.clmPrecioUnit.HeaderText = "Precio Unitario"
        Me.clmPrecioUnit.Name = "clmPrecioUnit"
        Me.clmPrecioUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmDesctoUnit
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.clmDesctoUnit.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmDesctoUnit.FillWeight = 12.0!
        Me.clmDesctoUnit.HeaderText = "Descuento"
        Me.clmDesctoUnit.Name = "clmDesctoUnit"
        Me.clmDesctoUnit.ReadOnly = True
        Me.clmDesctoUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmDescuento
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N2"
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmDescuento.FillWeight = 12.0!
        Me.clmDescuento.HeaderText = "Total Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.ReadOnly = True
        Me.clmDescuento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmDescuento.Visible = False
        '
        'clmPorcIVA
        '
        Me.clmPorcIVA.HeaderText = "PorcIVA"
        Me.clmPorcIVA.Name = "clmPorcIVA"
        Me.clmPorcIVA.Visible = False
        '
        'clmIVAUnit
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.clmIVAUnit.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmIVAUnit.FillWeight = 12.0!
        Me.clmIVAUnit.HeaderText = "I.V.A."
        Me.clmIVAUnit.Name = "clmIVAUnit"
        Me.clmIVAUnit.ReadOnly = True
        Me.clmIVAUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmIva
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N2"
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmIva.FillWeight = 12.0!
        Me.clmIva.HeaderText = "Total I.V.A."
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        Me.clmIva.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmIva.Visible = False
        '
        'clmPorcIEPS
        '
        Me.clmPorcIEPS.HeaderText = "Porc IEPS"
        Me.clmPorcIEPS.Name = "clmPorcIEPS"
        Me.clmPorcIEPS.Visible = False
        '
        'clmIEPSUnit
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.clmIEPSUnit.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmIEPSUnit.FillWeight = 12.0!
        Me.clmIEPSUnit.HeaderText = "I.E.P.S."
        Me.clmIEPSUnit.Name = "clmIEPSUnit"
        Me.clmIEPSUnit.ReadOnly = True
        Me.clmIEPSUnit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmIeps
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.clmIeps.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmIeps.FillWeight = 12.0!
        Me.clmIeps.HeaderText = "Total I.E.P.S."
        Me.clmIeps.Name = "clmIeps"
        Me.clmIeps.ReadOnly = True
        Me.clmIeps.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmIeps.Visible = False
        '
        'clmTotal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmTotal.FillWeight = 12.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        Me.clmTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmContKit
        '
        Me.clmContKit.FillWeight = 8.0!
        Me.clmContKit.HeaderText = "ContKit"
        Me.clmContKit.Name = "clmContKit"
        Me.clmContKit.Visible = False
        '
        'clmCodprodComp
        '
        Me.clmCodprodComp.FillWeight = 8.0!
        Me.clmCodprodComp.HeaderText = "CodProdComp"
        Me.clmCodprodComp.Name = "clmCodprodComp"
        Me.clmCodprodComp.Visible = False
        '
        'grpLogo
        '
        Me.grpLogo.Controls.Add(Me.picLogo)
        Me.grpLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLogo.Location = New System.Drawing.Point(3, 485)
        Me.grpLogo.Name = "grpLogo"
        Me.grpLogo.Size = New System.Drawing.Size(240, 180)
        Me.grpLogo.TabIndex = 10
        Me.grpLogo.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.SystemColors.Window
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(3, 16)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(234, 161)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 11
        Me.picLogo.TabStop = False
        '
        'TmrListaPrecios
        '
        Me.TmrListaPrecios.Enabled = True
        Me.TmrListaPrecios.Interval = 5000
        '
        'frmNotaDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 668)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmNotaDeVenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.grpCaptura.ResumeLayout(False)
        Me.grpCaptura.PerformLayout()
        Me.grpUltimaOper.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpFunciones.ResumeLayout(False)
        Me.grpFunciones.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogo.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpFunciones As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents grpCaptura As System.Windows.Forms.GroupBox
    Friend WithEvents btnAltRap As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGranTotal As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCorteX As System.Windows.Forms.Button
    Friend WithEvents btnCantidad As System.Windows.Forms.Button
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents btnCorteZ As System.Windows.Forms.Button
    Friend WithEvents btnRetiro As System.Windows.Forms.Button
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents btnRetener As System.Windows.Forms.Button
    Friend WithEvents grpUltimaOper As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblImpCambioAnt As System.Windows.Forms.Label
    Friend WithEvents lblImpPagoAnt As System.Windows.Forms.Label
    Friend WithEvents lblImpTotalAnt As System.Windows.Forms.Label
    Friend WithEvents grpLogo As System.Windows.Forms.GroupBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblNotRet As System.Windows.Forms.Label
    Friend WithEvents lblNotasRet As System.Windows.Forms.Label
    Friend WithEvents TmrListaPrecios As System.Windows.Forms.Timer
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents txthistorial As System.Windows.Forms.TextBox
    Friend WithEvents btnAbrirCajon As System.Windows.Forms.Button
    Friend WithEvents btnAyuda As System.Windows.Forms.Button
    Friend WithEvents clmCodProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioUnitSIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDesctoUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcIEPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIEPSUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIeps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmContKit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodprodComp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.Button
    Friend WithEvents btnReimprimir As System.Windows.Forms.Button
End Class
