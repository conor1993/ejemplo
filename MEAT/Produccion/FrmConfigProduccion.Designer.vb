<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigProduccion
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
        Me.components = New System.ComponentModel.Container
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkObtenerPeso = New System.Windows.Forms.CheckBox
        Me.ChkRecibirCanales = New System.Windows.Forms.CheckBox
        Me.ChkEmbarcar = New System.Windows.Forms.CheckBox
        Me.ChkCanales = New System.Windows.Forms.CheckBox
        Me.ChkimprimirCorte = New System.Windows.Forms.CheckBox
        Me.ChkEtiquetaCanal = New System.Windows.Forms.CheckBox
        Me.ChkEtiquetaProducto = New System.Windows.Forms.CheckBox
        Me.ChkLlenarCajas = New System.Windows.Forms.CheckBox
        Me.ChkEtiquetaDifCortes = New System.Windows.Forms.CheckBox
        Me.ChkTrabajarSacrificios = New System.Windows.Forms.CheckBox
        Me.ChkTrabajarCortes = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbAlmacenValorAgragadoCongelado = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbAlmacenValorAgregado = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cmbAlmacenCongelado = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmbDecomisos = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbProductos = New System.Windows.Forms.ComboBox
        Me.CmbCortes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbCanales = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkLoteCorteAsociado = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtContraseñaNva = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtContraseñaAnt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtConfirmacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbTiposAlm = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.nudTiempoEspera = New System.Windows.Forms.NumericUpDown
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkObtenerCanalAutomaticamente = New System.Windows.Forms.CheckBox
        Me.chkPrecioenEmbarque = New System.Windows.Forms.CheckBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkEsTIFLogo = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.nudDiasCaducidadHuesoCongelado = New System.Windows.Forms.NumericUpDown
        Me.Label29 = New System.Windows.Forms.Label
        Me.nudDiasCaducidadHuesoFresco = New System.Windows.Forms.NumericUpDown
        Me.Label31 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.nudValorAgregadoDiasCadCongelado = New System.Windows.Forms.NumericUpDown
        Me.Label24 = New System.Windows.Forms.Label
        Me.nudValorAgregadoTemperaturaCongelado = New System.Windows.Forms.NumericUpDown
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.nudFrescoDiasCaducidad = New System.Windows.Forms.NumericUpDown
        Me.nudFrescoTemperatura = New System.Windows.Forms.NumericUpDown
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.nudValorAgregadoDiasCaducidad = New System.Windows.Forms.NumericUpDown
        Me.Label17 = New System.Windows.Forms.Label
        Me.nudValorAgregadoTemperatura = New System.Windows.Forms.NumericUpDown
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.nudCongeladoDiasCaducidad = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.nudCongeladoTemperatura = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkReferenciarPrecioEmbarqueEnFacturacion = New System.Windows.Forms.CheckBox
        Me.chkProductosDerivados = New System.Windows.Forms.CheckBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudTiempoEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.nudDiasCaducidadHuesoCongelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiasCaducidadHuesoFresco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nudValorAgregadoDiasCadCongelado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudValorAgregadoTemperaturaCongelado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nudFrescoDiasCaducidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrescoTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nudValorAgregadoDiasCaducidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudValorAgregadoTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudCongeladoDiasCaducidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCongeladoTemperatura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 491)
        Me.mtb.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(757, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CONFIGURACIÓN DE PRODUCCIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkObtenerPeso
        '
        Me.chkObtenerPeso.AutoSize = True
        Me.chkObtenerPeso.Location = New System.Drawing.Point(6, 10)
        Me.chkObtenerPeso.Name = "chkObtenerPeso"
        Me.chkObtenerPeso.Size = New System.Drawing.Size(145, 17)
        Me.chkObtenerPeso.TabIndex = 12
        Me.chkObtenerPeso.Text = "Obtener peso de bascula"
        Me.chkObtenerPeso.UseVisualStyleBackColor = True
        '
        'ChkRecibirCanales
        '
        Me.ChkRecibirCanales.AutoSize = True
        Me.ChkRecibirCanales.Location = New System.Drawing.Point(6, 31)
        Me.ChkRecibirCanales.Name = "ChkRecibirCanales"
        Me.ChkRecibirCanales.Size = New System.Drawing.Size(186, 17)
        Me.ChkRecibirCanales.TabIndex = 13
        Me.ChkRecibirCanales.Text = "Recibir canales en Sala de Cortes"
        Me.ChkRecibirCanales.UseVisualStyleBackColor = True
        '
        'ChkEmbarcar
        '
        Me.ChkEmbarcar.AutoSize = True
        Me.ChkEmbarcar.Location = New System.Drawing.Point(7, 21)
        Me.ChkEmbarcar.Name = "ChkEmbarcar"
        Me.ChkEmbarcar.Size = New System.Drawing.Size(286, 17)
        Me.ChkEmbarcar.TabIndex = 14
        Me.ChkEmbarcar.Text = "Embarcar para más de un cliente en un mismo vehiculo"
        Me.ChkEmbarcar.UseVisualStyleBackColor = True
        '
        'ChkCanales
        '
        Me.ChkCanales.AutoSize = True
        Me.ChkCanales.Location = New System.Drawing.Point(7, 44)
        Me.ChkCanales.Name = "ChkCanales"
        Me.ChkCanales.Size = New System.Drawing.Size(270, 17)
        Me.ChkCanales.TabIndex = 15
        Me.ChkCanales.Text = "Canales, Productos y cortes en un mismo embarque"
        Me.ChkCanales.UseVisualStyleBackColor = True
        '
        'ChkimprimirCorte
        '
        Me.ChkimprimirCorte.AutoSize = True
        Me.ChkimprimirCorte.Location = New System.Drawing.Point(6, 54)
        Me.ChkimprimirCorte.Name = "ChkimprimirCorte"
        Me.ChkimprimirCorte.Size = New System.Drawing.Size(258, 17)
        Me.ChkimprimirCorte.TabIndex = 16
        Me.ChkimprimirCorte.Text = "Imprimir etiqueta al momento de capturar un corte"
        Me.ChkimprimirCorte.UseVisualStyleBackColor = True
        '
        'ChkEtiquetaCanal
        '
        Me.ChkEtiquetaCanal.AutoSize = True
        Me.ChkEtiquetaCanal.Location = New System.Drawing.Point(6, 77)
        Me.ChkEtiquetaCanal.Name = "ChkEtiquetaCanal"
        Me.ChkEtiquetaCanal.Size = New System.Drawing.Size(260, 17)
        Me.ChkEtiquetaCanal.TabIndex = 17
        Me.ChkEtiquetaCanal.Text = "Imprimir etiqueta al momento de capturar un canal"
        Me.ChkEtiquetaCanal.UseVisualStyleBackColor = True
        '
        'ChkEtiquetaProducto
        '
        Me.ChkEtiquetaProducto.AutoSize = True
        Me.ChkEtiquetaProducto.Location = New System.Drawing.Point(6, 100)
        Me.ChkEtiquetaProducto.Name = "ChkEtiquetaProducto"
        Me.ChkEtiquetaProducto.Size = New System.Drawing.Size(276, 17)
        Me.ChkEtiquetaProducto.TabIndex = 18
        Me.ChkEtiquetaProducto.Text = "Imprimir etiqueta al momento de capturar un producto"
        Me.ChkEtiquetaProducto.UseVisualStyleBackColor = True
        '
        'ChkLlenarCajas
        '
        Me.ChkLlenarCajas.AutoSize = True
        Me.ChkLlenarCajas.Location = New System.Drawing.Point(6, 122)
        Me.ChkLlenarCajas.Name = "ChkLlenarCajas"
        Me.ChkLlenarCajas.Size = New System.Drawing.Size(185, 17)
        Me.ChkLlenarCajas.TabIndex = 19
        Me.ChkLlenarCajas.Text = "Llenar cajas con diferentes cortes"
        Me.ChkLlenarCajas.UseVisualStyleBackColor = True
        '
        'ChkEtiquetaDifCortes
        '
        Me.ChkEtiquetaDifCortes.AutoSize = True
        Me.ChkEtiquetaDifCortes.Location = New System.Drawing.Point(24, 145)
        Me.ChkEtiquetaDifCortes.Name = "ChkEtiquetaDifCortes"
        Me.ChkEtiquetaDifCortes.Size = New System.Drawing.Size(276, 17)
        Me.ChkEtiquetaDifCortes.TabIndex = 20
        Me.ChkEtiquetaDifCortes.Text = "Imprimir etiqueta con información de diferentes cortes"
        Me.ChkEtiquetaDifCortes.UseVisualStyleBackColor = True
        '
        'ChkTrabajarSacrificios
        '
        Me.ChkTrabajarSacrificios.AutoSize = True
        Me.ChkTrabajarSacrificios.Location = New System.Drawing.Point(6, 164)
        Me.ChkTrabajarSacrificios.Name = "ChkTrabajarSacrificios"
        Me.ChkTrabajarSacrificios.Size = New System.Drawing.Size(215, 17)
        Me.ChkTrabajarSacrificios.TabIndex = 21
        Me.ChkTrabajarSacrificios.Text = "Trabajar con lotes de sacrificios abiertos"
        Me.ChkTrabajarSacrificios.UseVisualStyleBackColor = True
        '
        'ChkTrabajarCortes
        '
        Me.ChkTrabajarCortes.AutoSize = True
        Me.ChkTrabajarCortes.Location = New System.Drawing.Point(6, 187)
        Me.ChkTrabajarCortes.Name = "ChkTrabajarCortes"
        Me.ChkTrabajarCortes.Size = New System.Drawing.Size(198, 17)
        Me.ChkTrabajarCortes.TabIndex = 22
        Me.ChkTrabajarCortes.Text = "Trabajar con lotes de cortes abiertos"
        Me.ChkTrabajarCortes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAlmacenValorAgragadoCongelado)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cmbAlmacenValorAgregado)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmbAlmacenCongelado)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.CmbDecomisos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbProductos)
        Me.GroupBox1.Controls.Add(Me.CmbCortes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbCanales)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(316, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 216)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacén de"
        '
        'cmbAlmacenValorAgragadoCongelado
        '
        Me.cmbAlmacenValorAgragadoCongelado.FormattingEnabled = True
        Me.cmbAlmacenValorAgragadoCongelado.Location = New System.Drawing.Point(122, 179)
        Me.cmbAlmacenValorAgragadoCongelado.Name = "cmbAlmacenValorAgragadoCongelado"
        Me.cmbAlmacenValorAgragadoCongelado.Size = New System.Drawing.Size(285, 21)
        Me.cmbAlmacenValorAgragadoCongelado.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 182)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(111, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Valor Agre. Cong.:"
        '
        'cmbAlmacenValorAgregado
        '
        Me.cmbAlmacenValorAgregado.FormattingEnabled = True
        Me.cmbAlmacenValorAgregado.Location = New System.Drawing.Point(123, 152)
        Me.cmbAlmacenValorAgregado.Name = "cmbAlmacenValorAgregado"
        Me.cmbAlmacenValorAgregado.Size = New System.Drawing.Size(285, 21)
        Me.cmbAlmacenValorAgregado.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Valor Agre. :"
        '
        'cmbAlmacenCongelado
        '
        Me.cmbAlmacenCongelado.FormattingEnabled = True
        Me.cmbAlmacenCongelado.Location = New System.Drawing.Point(123, 127)
        Me.cmbAlmacenCongelado.Name = "cmbAlmacenCongelado"
        Me.cmbAlmacenCongelado.Size = New System.Drawing.Size(285, 21)
        Me.cmbAlmacenCongelado.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Congelado :"
        '
        'CmbDecomisos
        '
        Me.CmbDecomisos.FormattingEnabled = True
        Me.CmbDecomisos.Location = New System.Drawing.Point(123, 102)
        Me.CmbDecomisos.Name = "CmbDecomisos"
        Me.CmbDecomisos.Size = New System.Drawing.Size(285, 21)
        Me.CmbDecomisos.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Decomisos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Productos:"
        '
        'CmbProductos
        '
        Me.CmbProductos.FormattingEnabled = True
        Me.CmbProductos.Location = New System.Drawing.Point(123, 75)
        Me.CmbProductos.Name = "CmbProductos"
        Me.CmbProductos.Size = New System.Drawing.Size(285, 21)
        Me.CmbProductos.TabIndex = 4
        '
        'CmbCortes
        '
        Me.CmbCortes.FormattingEnabled = True
        Me.CmbCortes.Location = New System.Drawing.Point(122, 48)
        Me.CmbCortes.Name = "CmbCortes"
        Me.CmbCortes.Size = New System.Drawing.Size(286, 21)
        Me.CmbCortes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cortes:"
        '
        'CmbCanales
        '
        Me.CmbCanales.FormattingEnabled = True
        Me.CmbCanales.Location = New System.Drawing.Point(122, 21)
        Me.CmbCanales.Name = "CmbCanales"
        Me.CmbCanales.Size = New System.Drawing.Size(286, 21)
        Me.CmbCanales.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Canales:"
        '
        'chkLoteCorteAsociado
        '
        Me.chkLoteCorteAsociado.AutoSize = True
        Me.chkLoteCorteAsociado.Location = New System.Drawing.Point(6, 210)
        Me.chkLoteCorteAsociado.Name = "chkLoteCorteAsociado"
        Me.chkLoteCorteAsociado.Size = New System.Drawing.Size(277, 17)
        Me.chkLoteCorteAsociado.TabIndex = 24
        Me.chkLoteCorteAsociado.Text = "Lote de corte asociado a diferentes lotes de sacrificio"
        Me.chkLoteCorteAsociado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Contraseña Nueva:"
        '
        'txtContraseñaNva
        '
        Me.txtContraseñaNva.Location = New System.Drawing.Point(145, 47)
        Me.txtContraseñaNva.MaxLength = 8
        Me.txtContraseñaNva.Name = "txtContraseñaNva"
        Me.txtContraseñaNva.Size = New System.Drawing.Size(113, 20)
        Me.txtContraseñaNva.TabIndex = 26
        Me.txtContraseñaNva.UseSystemPasswordChar = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtContraseñaAnt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtConfirmacion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtContraseñaNva)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autorización Embarcar Clientes con Saldo"
        '
        'txtContraseñaAnt
        '
        Me.txtContraseñaAnt.Location = New System.Drawing.Point(145, 21)
        Me.txtContraseñaAnt.MaxLength = 8
        Me.txtContraseñaAnt.Name = "txtContraseñaAnt"
        Me.txtContraseñaAnt.Size = New System.Drawing.Size(113, 20)
        Me.txtContraseñaAnt.TabIndex = 30
        Me.txtContraseñaAnt.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Contraseña Anterior:"
        '
        'txtConfirmacion
        '
        Me.txtConfirmacion.Location = New System.Drawing.Point(145, 73)
        Me.txtConfirmacion.MaxLength = 8
        Me.txtConfirmacion.Name = "txtConfirmacion"
        Me.txtConfirmacion.Size = New System.Drawing.Size(113, 20)
        Me.txtConfirmacion.TabIndex = 28
        Me.txtConfirmacion.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Confirmar Contraseña:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(313, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Tipos de Almacenes:"
        '
        'CmbTiposAlm
        '
        Me.CmbTiposAlm.FormattingEnabled = True
        Me.CmbTiposAlm.Location = New System.Drawing.Point(425, 8)
        Me.CmbTiposAlm.Name = "CmbTiposAlm"
        Me.CmbTiposAlm.Size = New System.Drawing.Size(192, 21)
        Me.CmbTiposAlm.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 42)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Tiempo de espera para la actualización de la información de un sacrificio"
        '
        'nudTiempoEspera
        '
        Me.nudTiempoEspera.Location = New System.Drawing.Point(177, 298)
        Me.nudTiempoEspera.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudTiempoEspera.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudTiempoEspera.Name = "nudTiempoEspera"
        Me.nudTiempoEspera.Size = New System.Drawing.Size(42, 20)
        Me.nudTiempoEspera.TabIndex = 31
        Me.nudTiempoEspera.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Segundos"
        '
        'chkObtenerCanalAutomaticamente
        '
        Me.chkObtenerCanalAutomaticamente.Location = New System.Drawing.Point(6, 229)
        Me.chkObtenerCanalAutomaticamente.Name = "chkObtenerCanalAutomaticamente"
        Me.chkObtenerCanalAutomaticamente.Size = New System.Drawing.Size(277, 30)
        Me.chkObtenerCanalAutomaticamente.TabIndex = 33
        Me.chkObtenerCanalAutomaticamente.Text = "Obtener canal automaticamente en la entrada de canales a almacén"
        Me.chkObtenerCanalAutomaticamente.UseVisualStyleBackColor = True
        '
        'chkPrecioenEmbarque
        '
        Me.chkPrecioenEmbarque.AutoSize = True
        Me.chkPrecioenEmbarque.Location = New System.Drawing.Point(7, 67)
        Me.chkPrecioenEmbarque.Name = "chkPrecioenEmbarque"
        Me.chkPrecioenEmbarque.Size = New System.Drawing.Size(153, 17)
        Me.chkPrecioenEmbarque.TabIndex = 34
        Me.chkPrecioenEmbarque.Text = "Incluir Precio en Embarque"
        Me.chkPrecioenEmbarque.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(51, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 447)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkEsTIFLogo)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.chkObtenerPeso)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ChkRecibirCanales)
        Me.TabPage1.Controls.Add(Me.nudTiempoEspera)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.chkObtenerCanalAutomaticamente)
        Me.TabPage1.Controls.Add(Me.CmbTiposAlm)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ChkimprimirCorte)
        Me.TabPage1.Controls.Add(Me.chkLoteCorteAsociado)
        Me.TabPage1.Controls.Add(Me.ChkEtiquetaCanal)
        Me.TabPage1.Controls.Add(Me.ChkTrabajarCortes)
        Me.TabPage1.Controls.Add(Me.ChkEtiquetaProducto)
        Me.TabPage1.Controls.Add(Me.ChkTrabajarSacrificios)
        Me.TabPage1.Controls.Add(Me.ChkLlenarCajas)
        Me.TabPage1.Controls.Add(Me.ChkEtiquetaDifCortes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(736, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Produccción"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkEsTIFLogo
        '
        Me.chkEsTIFLogo.AutoSize = True
        Me.chkEsTIFLogo.Location = New System.Drawing.Point(6, 262)
        Me.chkEsTIFLogo.Name = "chkEsTIFLogo"
        Me.chkEsTIFLogo.Size = New System.Drawing.Size(237, 17)
        Me.chkEsTIFLogo.TabIndex = 43
        Me.chkEsTIFLogo.Text = "Incrustar Imagen en Etiquetas para Logo TIF"
        Me.chkEsTIFLogo.UseVisualStyleBackColor = True
        Me.chkEsTIFLogo.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.nudDiasCaducidadHuesoCongelado)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.nudDiasCaducidadHuesoFresco)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 335)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(268, 72)
        Me.GroupBox8.TabIndex = 42
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Productos Con Hueso"
        '
        'nudDiasCaducidadHuesoCongelado
        '
        Me.nudDiasCaducidadHuesoCongelado.Location = New System.Drawing.Point(168, 42)
        Me.nudDiasCaducidadHuesoCongelado.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasCaducidadHuesoCongelado.Name = "nudDiasCaducidadHuesoCongelado"
        Me.nudDiasCaducidadHuesoCongelado.Size = New System.Drawing.Size(50, 20)
        Me.nudDiasCaducidadHuesoCongelado.TabIndex = 40
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(156, 13)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Dias De Caducidad Congelado:"
        '
        'nudDiasCaducidadHuesoFresco
        '
        Me.nudDiasCaducidadHuesoFresco.Location = New System.Drawing.Point(169, 16)
        Me.nudDiasCaducidadHuesoFresco.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudDiasCaducidadHuesoFresco.Name = "nudDiasCaducidadHuesoFresco"
        Me.nudDiasCaducidadHuesoFresco.Size = New System.Drawing.Size(50, 20)
        Me.nudDiasCaducidadHuesoFresco.TabIndex = 39
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(137, 13)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Dias De Caducidad Fresco:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.nudValorAgregadoDiasCadCongelado)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.nudValorAgregadoTemperaturaCongelado)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Location = New System.Drawing.Point(514, 334)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 71)
        Me.GroupBox6.TabIndex = 41
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Productos de Valor Agregado Congelado"
        '
        'nudValorAgregadoDiasCadCongelado
        '
        Me.nudValorAgregadoDiasCadCongelado.Location = New System.Drawing.Point(100, 43)
        Me.nudValorAgregadoDiasCadCongelado.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudValorAgregadoDiasCadCongelado.Name = "nudValorAgregadoDiasCadCongelado"
        Me.nudValorAgregadoDiasCadCongelado.Size = New System.Drawing.Size(50, 20)
        Me.nudValorAgregadoDiasCadCongelado.TabIndex = 40
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 45)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "Dias Caducidad :"
        '
        'nudValorAgregadoTemperaturaCongelado
        '
        Me.nudValorAgregadoTemperaturaCongelado.Location = New System.Drawing.Point(100, 17)
        Me.nudValorAgregadoTemperaturaCongelado.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudValorAgregadoTemperaturaCongelado.Name = "nudValorAgregadoTemperaturaCongelado"
        Me.nudValorAgregadoTemperaturaCongelado.Size = New System.Drawing.Size(50, 20)
        Me.nudValorAgregadoTemperaturaCongelado.TabIndex = 39
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(156, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 33
        Me.Label25.Text = "Grados"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 20)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 13)
        Me.Label26.TabIndex = 31
        Me.Label26.Text = "Temperatura :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nudFrescoDiasCaducidad)
        Me.GroupBox5.Controls.Add(Me.nudFrescoTemperatura)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Location = New System.Drawing.Point(285, 335)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(223, 71)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Productos Frescos"
        '
        'nudFrescoDiasCaducidad
        '
        Me.nudFrescoDiasCaducidad.Location = New System.Drawing.Point(100, 44)
        Me.nudFrescoDiasCaducidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFrescoDiasCaducidad.Name = "nudFrescoDiasCaducidad"
        Me.nudFrescoDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.nudFrescoDiasCaducidad.TabIndex = 38
        '
        'nudFrescoTemperatura
        '
        Me.nudFrescoTemperatura.Location = New System.Drawing.Point(100, 18)
        Me.nudFrescoTemperatura.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudFrescoTemperatura.Name = "nudFrescoTemperatura"
        Me.nudFrescoTemperatura.Size = New System.Drawing.Size(50, 20)
        Me.nudFrescoTemperatura.TabIndex = 37
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Dias Caducidad :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(151, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 33
        Me.Label22.Text = "Grados"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "Temperatura :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nudValorAgregadoDiasCaducidad)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.nudValorAgregadoTemperatura)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Location = New System.Drawing.Point(514, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(216, 71)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Productos de Valor Agregado"
        '
        'nudValorAgregadoDiasCaducidad
        '
        Me.nudValorAgregadoDiasCaducidad.Location = New System.Drawing.Point(100, 43)
        Me.nudValorAgregadoDiasCaducidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudValorAgregadoDiasCaducidad.Name = "nudValorAgregadoDiasCaducidad"
        Me.nudValorAgregadoDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.nudValorAgregadoDiasCaducidad.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Dias Caducidad :"
        '
        'nudValorAgregadoTemperatura
        '
        Me.nudValorAgregadoTemperatura.Location = New System.Drawing.Point(100, 17)
        Me.nudValorAgregadoTemperatura.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudValorAgregadoTemperatura.Name = "nudValorAgregadoTemperatura"
        Me.nudValorAgregadoTemperatura.Size = New System.Drawing.Size(50, 20)
        Me.nudValorAgregadoTemperatura.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(156, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "Grados"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Temperatura :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nudCongeladoDiasCaducidad)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.nudCongeladoTemperatura)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 72)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos Congelados"
        '
        'nudCongeladoDiasCaducidad
        '
        Me.nudCongeladoDiasCaducidad.Location = New System.Drawing.Point(100, 44)
        Me.nudCongeladoDiasCaducidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCongeladoDiasCaducidad.Name = "nudCongeladoDiasCaducidad"
        Me.nudCongeladoDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.nudCongeladoDiasCaducidad.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Dias Caducidad :"
        '
        'nudCongeladoTemperatura
        '
        Me.nudCongeladoTemperatura.Location = New System.Drawing.Point(100, 18)
        Me.nudCongeladoTemperatura.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudCongeladoTemperatura.Name = "nudCongeladoTemperatura"
        Me.nudCongeladoTemperatura.Size = New System.Drawing.Size(50, 20)
        Me.nudCongeladoTemperatura.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(153, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Grados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Temperatura :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkReferenciarPrecioEmbarqueEnFacturacion)
        Me.TabPage2.Controls.Add(Me.chkProductosDerivados)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.ChkEmbarcar)
        Me.TabPage2.Controls.Add(Me.chkPrecioenEmbarque)
        Me.TabPage2.Controls.Add(Me.ChkCanales)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(736, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ventas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkReferenciarPrecioEmbarqueEnFacturacion
        '
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.AutoSize = True
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.Location = New System.Drawing.Point(30, 90)
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.Name = "chkReferenciarPrecioEmbarqueEnFacturacion"
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.Size = New System.Drawing.Size(234, 17)
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.TabIndex = 41
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.Text = "Enlazar Precio de Embarque en Facturación"
        Me.chkReferenciarPrecioEmbarqueEnFacturacion.UseVisualStyleBackColor = True
        '
        'chkProductosDerivados
        '
        Me.chkProductosDerivados.AutoSize = True
        Me.chkProductosDerivados.Location = New System.Drawing.Point(7, 113)
        Me.chkProductosDerivados.Name = "chkProductosDerivados"
        Me.chkProductosDerivados.Size = New System.Drawing.Size(194, 17)
        Me.chkProductosDerivados.TabIndex = 40
        Me.chkProductosDerivados.Text = "Paquetes de Productos (Derivados)"
        Me.chkProductosDerivados.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 164)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(286, 86)
        Me.GroupBox7.TabIndex = 39
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Polizas de Venta de Carne"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 13)
        Me.Label27.TabIndex = 35
        Me.Label27.Text = "Nacional  :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 58)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 13)
        Me.Label28.TabIndex = 37
        Me.Label28.Text = "Dolares :"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(88, 55)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox2.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 36
        '
        'FrmConfigProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmConfigProduccion"
        Me.Text = "Configuración de Producción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudTiempoEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.nudDiasCaducidadHuesoCongelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiasCaducidadHuesoFresco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nudValorAgregadoDiasCadCongelado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudValorAgregadoTemperaturaCongelado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nudFrescoDiasCaducidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrescoTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nudValorAgregadoDiasCaducidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudValorAgregadoTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudCongeladoDiasCaducidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCongeladoTemperatura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkObtenerPeso As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRecibirCanales As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEmbarcar As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCanales As System.Windows.Forms.CheckBox
    Friend WithEvents ChkimprimirCorte As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEtiquetaCanal As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEtiquetaProducto As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLlenarCajas As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEtiquetaDifCortes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTrabajarSacrificios As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTrabajarCortes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCortes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbCanales As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDecomisos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkLoteCorteAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaNva As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbTiposAlm As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nudTiempoEspera As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkObtenerCanalAutomaticamente As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrecioenEmbarque As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacenCongelado As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacenValorAgregado As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nudFrescoDiasCaducidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudFrescoTemperatura As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudValorAgregadoDiasCaducidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudValorAgregadoTemperatura As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCongeladoDiasCaducidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCongeladoTemperatura As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbAlmacenValorAgragadoCongelado As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents nudValorAgregadoDiasCadCongelado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents nudValorAgregadoTemperaturaCongelado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents nudDiasCaducidadHuesoCongelado As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents nudDiasCaducidadHuesoFresco As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents chkProductosDerivados As System.Windows.Forms.CheckBox
    Friend WithEvents chkReferenciarPrecioEmbarqueEnFacturacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkEsTIFLogo As System.Windows.Forms.CheckBox
End Class
