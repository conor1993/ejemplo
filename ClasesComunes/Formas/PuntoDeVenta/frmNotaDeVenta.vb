Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports System.Drawing.Printing
Imports System.Threading
Imports System.ComponentModel
Imports ECS = IntegraLab.ORMSeguridad
Imports IntegraLab.FormasSeguridad
Imports ClasesNegocio
Imports Microsoft.Win32
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient




Public Class frmNotaDeVenta


    Dim lcCatProductos As New CN.ProductoCollectionClass
    Dim lcListaPrecios As New CN.ListaPrecioClass
    Dim ldIVA, ldGranTotal As Decimal
    Dim PuedoModificar As Boolean = True
    Dim Nota As CN.NotaVentaClass
    Dim NotasRetenidas As List(Of NotaRetenida)
    Dim Sucursal As New CN.SucursalClass()
    Dim ControlTurnoActual As CN.ControlTurnoClass
    Dim Bascula As New CN.LecturaBasculaClass
    Dim NotasRet As New List(Of NotaRetenida)
    ''Kareli 16/01/2015 inicia
    Dim UltimaHoraAct As Date
    Dim Almacen As ClasesNegocio.AlmacenClass
    'Dim Almacen As New AlmacenCatalogoClass
    ''kareli 03/12/2014
    Dim InvMovAlmacenCab As AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim _FolioAlm As String = ""
    Dim Referencia As String = ""
    Dim rowscroll As Integer = 0
    Dim finload As Boolean = False
    Dim PuedeIniciarTurno As Boolean = True
    ''Kareli 16/01/2015 Termina
    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    'Dim hilo1 As Thread 'Crear el hilo 1
    Dim hilo2 As Thread 'Crear el hilo 2

    Dim matriz(,) As String

    Dim j As Integer
    Dim Trans As HC.Transaction
    Dim TransMovAlm As HC.Transaction
    Dim i As Integer = 0
    Private So_Info As OperatingSystem
    Dim cobrando As Boolean = False
    Dim cargacodSucursal As Boolean
    Dim carganomimpresora As Boolean
    Dim ContKit As Integer = 0
    Dim CodNotaVentaTemp As Integer = 0
    Dim precioAnt As Double = 0
    Dim cobrarDirecto As Boolean = True
    Dim contador As Int16 = 0


    Private Class NotaRetenida
        Private _Id As String
        Private _Total As Decimal
        Private _CantArt As Integer
        Private _Renglones As List(Of DataGridViewRow)

        <System.ComponentModel.DisplayName("Id")> _
        Public Property Id() As String
            Get
                Return _Id
            End Get
            Set(ByVal value As String)
                _Id = value
            End Set
        End Property

        <System.ComponentModel.DisplayName("Cant Artículos")> _
        Public Property CantArt() As Integer
            Get
                Return _CantArt
            End Get
            Set(ByVal value As Integer)
                _CantArt = value
            End Set
        End Property

        <System.ComponentModel.DisplayName("Total")> _
        Public Property Total() As Decimal
            Get
                Return _Total
            End Get
            Set(ByVal value As Decimal)
                _Total = value
            End Set
        End Property

        <System.ComponentModel.DisplayName("Renglones")> _
        Public Property Renglones() As List(Of DataGridViewRow)
            Get
                Return _Renglones
            End Get
            Set(ByVal value As List(Of DataGridViewRow))
                _Renglones = value
            End Set
        End Property
    End Class

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'If Utilerias.ObtenerCodSucursal = 0 Then
        '    Application.Exit()
        '    'Me.Close()
        '    'Me.Dispose()
        'End If
    End Sub

    Private Sub frmNotaDeVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Dim lp As EC.ListaPrecioEntity = lcListaPrecios.ObtenerEntidad
        'lp.Refetch() 'Actualiza los valores de la base de datos, lo que aya cambiado lo trae otra vez
        'If UltimaHoraAct > lp.FechaCaptura Then
        '    lcListaPrecios.Obtener(Sucursal.Plaza.ListasPrecio(0).Codigo)  ' sustituir el uno por plaza cuando se programe plaza y sucursal para cajeros
        'End If
        'UltimaHoraAct = DateTime.Now
        Select Case e.KeyCode
            Case Keys.Enter     '' buscar artículo
                'txtArticulo_Leave(sender, New System.EventArgs())
                'e.Handled = True
                'If Me.ActiveControl.Name = "txtArticulo" Then
                '    cobrarDirecto = False
                'End If

                'Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                'SendKeys.Send("{TAB}")
                'contador += 1
                Me.txtArticulo_Leave(New Object, Nothing)
                If contador = 2 Then
                    If Not Guardar(False) Then Return
                End If



            Case Keys.Escape    '' cancelar captura
                txtArticulo.Text = ""
                txtArticulo.Focus()
                contador = 0
            Case Keys.Up
                dgvDetalle.Focus()
            Case e.Control And Keys.R
                If CodNotaVentaTemp <> 0 Then ReImprimir(CodNotaVentaTemp, "Reimpresión")
            Case e.Control And Keys.B
                Dim buscarnota As New frmBusqNotasVenta
                buscarnota.ShowDialog()
            Case Keys.Add
                If dgvDetalle.RowCount > 0 Then
                    'If dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                    If CInt(dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value) = 0 And CInt(dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value) = 0 Then
                        Dim codprodcomp As Integer = dgvDetalle.CurrentRow.Cells(clmCodProducto.Index).Value
                        Dim idkit As Integer = dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value

                        e.Handled = True
                        e.SuppressKeyPress = True
                        If dgvDetalle.RowCount > 0 Then
                            dgvDetalle.CurrentRow.Cells("clmCantidad").Value += 1
                            'Dim cant As Decimal = dgvDetalle.CurrentRow.Cells(clmCantidad.Index).Value
                            'For Each row As DataGridViewRow In dgvDetalle.Rows
                            '    If row.Cells(clmContKit.Index).Value = idkit And row.Cells(clmCodprodComp.Index).Value = codprodcomp Then
                            '        row.Cells(clmCantidad.Index).Value = cant * row.Cells(clmCantidad.Index).Value
                            '    End If
                            'Next
                        End If
                        CalculaRenglon()

                    Else
                        Beep()
                    End If
                    'Else
                    '    Beep()
                    'End If

                End If
            Case Keys.Subtract
                e.Handled = True
                e.SuppressKeyPress = True
                If dgvDetalle.RowCount > 0 Then
                    'If dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                    If CInt(dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value) = 0 And CInt(dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value) = 0 Then
                        If dgvDetalle.CurrentRow.Cells("clmCantidad").Value >= 2 Then
                            dgvDetalle.CurrentRow.Cells("clmCantidad").Value -= 1
                            CalculaRenglon()
                        End If
                    Else
                        Beep()
                    End If
                    'Else
                    '    Beep()
                    'End If
                End If

            Case Keys.Delete    '' Suprimir un renglon del grid
                If Me.ActiveControl.Name = "dgvDetalle" And dgvDetalle.RowCount <> 0 Then
                    If CInt(dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value) <> 0 Then
                        Dim x As Integer = CInt(dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value)
                        Dim rowCont As Integer = dgvDetalle.RowCount - 1
                        Dim i As Integer = -1
                        While (i < rowCont)
                            i += 1
                            With dgvDetalle.Rows(i)
                                If CInt(.Cells(clmContKit.Index).Value) = x Then
                                    If .Cells(clmCodprodComp.Index).Value Is Nothing Then
                                        ldGranTotal = ldGranTotal - (.Cells(clmTotal.Index).Value)
                                    End If
                                    Application.DoEvents()
                                    dgvDetalle.Rows.RemoveAt(i)
                                    Application.DoEvents()
                                    i -= 1
                                    rowCont = dgvDetalle.RowCount - 1
                                    Application.DoEvents()

                                End If
                            End With
                        End While
                    Else
                        ldGranTotal = ldGranTotal - dgvDetalle.CurrentRow.Cells("clmTotal").Value
                        dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow)

                    End If
                    lblGranTotal.Text = Format(ldGranTotal, "N2")

                    Totaliza()
                    txtArticulo.Focus()
                    'If CInt(dgvDetalle.CurrentRow.Cells(clmCodProdComp.Index).Value) <> 0 Then
                    '    For Each r As DataGridViewRow In dgvDetalle.Rows

                    '    Next
                    'End If


                End If
            Case e.Alt And Keys.F1
                btnCompras_Click(sender, New System.EventArgs())
            Case Keys.F1        '' buscar artículo
                If txtArticulo.Text <> "" Then
                    Dim BuscaProd As New FrmBuscarProductos()
                    BuscaProd.txtDescripcion.Text = txtArticulo.Text
                    BuscaProd.rbtActivos.Checked = True
                    BuscaProd.ING = True
                    BuscaProd.CodLista = lcListaPrecios.Codigo

                    If BuscaProd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        'txtArticulo.Text = BuscaProd.ProductosSeleccionados.Item(0).CodigoBarra
                        txtArticulo.Text = BuscaProd.dgvProductosReg.CurrentRow.Cells(clmCantidad.Index).Value
                        e.Handled = True
                        If txtArticulo.Text = "" Then
                            MessageBox.Show("El producto seleccionado no tiene código capturado.", "", MessageBoxButtons.OK, MessageBoxIcon.None)
                        Else
                            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
                        End If
                    End If
                End If

            Case Keys.F2
                If TableLayoutPanel.ColumnStyles(0).Width = 246 Then
                    TableLayoutPanel.ColumnStyles(0).Width = 0
                Else
                    TableLayoutPanel.ColumnStyles(0).Width = 246
                End If
            Case Keys.F3        '' ingreso
                btnIngreso_Click(sender, New System.EventArgs)
            Case Keys.F4
                '' capturar cantidad
                If dgvDetalle.RowCount > 0 Then
                    If CInt(dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value) = 0 And CInt(dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value) = 0 Then
                        CapturaCantidad()
                    End If
                End If
            Case Keys.F5        '' leer peso de la bascula
                btnAltRap_Click(sender, New System.EventArgs)
            Case Keys.F6        '' retener nota
                btnRetener_Click(Me, New System.EventArgs)

            Case Keys.F7        '' recuperar nota
                btnRecuperar_Click(Me, New System.EventArgs)
            Case e.Alt And Keys.F8 ''abrir cajon
                Dim s As String
                Dim pd As New PrintDialog()
                's = Chr(27) + Chr(112) + Chr(0) + Chr(50) + Chr(250)
                s = vbFormFeed
                'Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
                pd.PrinterSettings = New PrinterSettings()

                RawPrinterHelper.SendStringToPrinter(Utilerias.ObtenerNomImpresora.ToString, s)
                'RawPrinterHelper.SendStringToPrinter("HP Color LaserJet CP1510 series PCL6", s)


            Case Keys.F8        '' cobrar
                ''cobrarDirecto = True
                If Not Guardar(True) Then Return

            Case Keys.F10        '' corte X
                btnCorteX_Click(sender, New System.EventArgs)

            Case Keys.F11       '' corte Z
                btnCorteZ_Click(sender, New System.EventArgs)

            Case Keys.F9       '' arqueo retiro
                btnRetiro_Click(sender, New System.EventArgs)
            Case Keys.F12       '' salir
                btnSalir_Click(sender, New System.EventArgs())

        End Select
        ' ===== Controlador.Sesion.MiUsuario.Usrid
    End Sub


    Private Sub frmNotaDeVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Utilerias.ObtenerCodSucursal = 0 Then
            cargacodSucursal = False
            Exit Sub
        Else
            cargacodSucursal = True
        End If

        If Utilerias.ObtenerNomImpresora = "" Then
            carganomimpresora = False
            Exit Sub
        Else
            carganomimpresora = True
        End If





        finload = False
#If DEBUG Then
        dgvDetalle.Columns(clmCodprodComp.Index).Visible = True
        dgvDetalle.Columns(clmContKit.Index).Visible = True
        'dgvDetalle.Columns(clmPorcIVA.Index).Visible = True
        'clmPorcIVA

#End If
        'So_Info = Environment.OSVersion
        'If (So_Info.Version.Major = 5 And So_Info.Version.Minor = 1) Or So_Info.Version.Major < 5 Then
        '    txthistorial.Text += "SO WIN XP..... Hora: " & Now().ToString & vbLf
        '    Application.DoEvents()
        'ElseIf So_Info.Version.Major = 6 And So_Info.Version.Minor = 1 Then
        '    'hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
        '    'hilo1.Start()
        '    txthistorial.Text += "SO WIN 7..... Hora: " & Now().ToString & vbLf
        '    Application.DoEvents()
        'End If
        hilo2 = New Thread(AddressOf cargarlistapreciosMemoria) 'Crear el hilo 2
        hilo2.Start()
        ' hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
        txthistorial.Text += "inicia el Load.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
        txtArticulo.Focus()
        ldIVA = Controlador.ObtenerIVA()
        ' obtiene la lista de productos
        'lcCatProductos.Obtener(CN.CondicionEnum.ACTIVOS, CN.CondicionAsignadaEnum.TODOS, CondicionAsignadaEnum.TODOS, CondicionAsignadaEnum.TODOS, CondicionAsignadaEnum.NO)

        Sucursal.Obtener(Utilerias.ObtenerCodSucursal())
        txthistorial.Text += "Inicia obtener lista precios.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()

        If Not lcListaPrecios.ObtenerVigente(Sucursal.Plaza.Codigo) Then
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If


        'lcListaPrecios.Obtener(Sucursal.Plaza.ListasPrecio(0).Codigo)  ' sustituir el uno por plaza cuando se programe plaza y sucursal para cajeros
        txthistorial.Text += "Termina obtener lista precios.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
        UltimaHoraAct = DateTime.Now
        TmrListaPrecios.Enabled = True
        lblSucursal.Text = Sucursal.DescripcionCorta
        'lblCaja.Text = Caja.Nombre
        lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom

        '' Este codigo se programa solo para forzar a que se carguen en memoria 
        '' todos los productos de la lista de precios
        'txthistorial.Text += "Inicia carga de productos en memoria.. Hora: " & Now().ToString & vbLf
        'Application.DoEvents()
        'Dim y As Integer

        'For Each x As CN.ListaPrecioDetalleClass In lcListaPrecios.Detalle
        '    y = x.Producto.Codigo
        'Next
        'txthistorial.Text += "Termina carga de productos en memoria.. Hora: " & Now().ToString & vbLf
        'Application.DoEvents()

        dgvDetalle.Columns("clmCantidad").ValueType = GetType(Decimal)
        dgvDetalle.Columns("clmPrecioUnit").ValueType = GetType(Decimal)

        txthistorial.Text += "Inicia verificacion Turno.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
        Try
            While ControlTurnoActual Is Nothing
                ControlTurnoActual = Utilerias.ObtenerControlTurnoActual()
            End While


            If CN.ControladorGanadera.ValidarCierreDiario Then
                If ControlTurnoActual.FechaInicio.DayOfYear < Date.Now.DayOfYear Then
                    MessageBox.Show("Es necesario cerrar el turno actual e iniciar un nuevo turno.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    PuedeIniciarTurno = False

                    ''haciendo el corte z
                    Dim permiso As New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)

                    If Not IsDBNull(permiso.Usrtipo) Then
                        If permiso.Usrtipo.Equals("A") Then
                            Cortez(True)
                        Else
                            'Dim frmlogin As New LoginForm()
                            Dim validar As New ValidateForm()
                            If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                                permiso = New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, validar.Usuario.Usrndx)

                                If Not IsDBNull(permiso.Usrtipo) Then
                                    If permiso.Usrtipo.Equals("A") Then
                                        Cortez(True)
                                    Else
                                        MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                                    End If
                                Else
                                    MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                                End If



                            Else

                            End If


                        End If
                        Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))

                    Else
                        Dim validar As New ValidateForm()
                        If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                            permiso = New ECS.EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)

                            If Not IsDBNull(permiso.Usrtipo) Then
                                If permiso.Usrtipo.Equals("A") Then
                                    Cortez(True)
                                Else
                                    MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                                End If
                            Else
                                MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                            End If



                        Else

                        End If
                        Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))

                    End If
                    ''btnCorteZ_Click(New Object, Nothing)
                    Exit Sub
                End If
            End If

            If ControlTurnoActual.CodSucursal <> Sucursal.Codigo Then
                MessageBox.Show("Ya hay una sesión iniciada en la sucursal " + ControlTurnoActual.Sucursal.DescripcionCorta, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.None)
                'Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        cantArticulosRet()
        txthistorial.Text += "Termina verificacion Turno.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
        txtArticulo.Focus()

        txthistorial.Text += "termina el Load.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
    End Sub

    Private Sub txtArticulo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArticulo.Leave

        Dim Det As CN.ListaPrecioDetalleClass
        Try
            If Me.ParentForm Is Nothing Then Exit Sub
            If Me.ParentForm.ActiveMdiChild Is Nothing Then Exit Sub
            If Me.ParentForm.ActiveMdiChild.Name <> "frmNotaDeVenta" Then Exit Sub
            If Me.ActiveControl.Name = "btnRetener" Or Me.ActiveControl.Name = "btnRecuperar" Then Exit Sub

            If Trim(txtArticulo.Text) = "" Then
                contador += 1
                Exit Sub
            Else
                contador = 0
            End If


            If grpUltimaOper.Visible Then
                grpUltimaOper.Visible = False
                lblImpTotalAnt.Text = "0.00"
                lblImpPagoAnt.Text = "0.00"
                lblImpCambioAnt.Text = "0.00"
            End If
            Dim CadenaComp As String = txtArticulo.Text
            Dim ArrCad As String() = CadenaComp.Split("*")
            Det = lcListaPrecios.ObtenerDetalle(ArrCad(0))
            'Dim inventario As New AlmacenGeneral.InventarioAlmacenClass
            If Det Is Nothing Then
                MessageBox.Show("Producto no encontrado.", "", MessageBoxButtons.OK, MessageBoxIcon.None)
            Else
                Dim reng As Integer = dgvDetalle.RowCount
                If Det.Producto.EsKit Then
                    ContKit += 1

                    Dim kitcol As New ClasesNegocio.DetalleKitCollectionClass
                    kitcol.Obtener(HC.DetalleKitPvFields.IdKit = Det.Producto.Codigo)
                    reng += 1
                    With dgvDetalle
                        ''.RowCount = 1
                        .RowCount = reng
                        .CurrentCell = .Rows(reng - 1).Cells("clmCantidad")
                        .CurrentRow.Cells("clmCantidad").Value = 1
                        .CurrentRow.Cells("clmCodProducto").Value = Det.Producto.Codigo
                        .CurrentRow.Cells("clmDescripcion").Value = Det.Producto.Descripcion
                        .CurrentRow.Cells("clmPrecioUnit").Value = Det.PrecioVentaC
                        .CurrentRow.Cells("clmDesctoUnit").Value = 0
                        .CurrentRow.Cells("clmPrecioUnitSIva").Value = ""
                        .CurrentRow.Cells("clmDescuento").Value = 0
                        .CurrentRow.Cells("clmPorcIva").Value = ""
                        .CurrentRow.Cells("clmIvaUnit").Value = 0
                        .CurrentRow.Cells("clmIva").Value = 0
                        .CurrentRow.Cells("clmPorcIeps").Value = ""
                        .CurrentRow.Cells("clmIeps").Value = 0
                        .CurrentRow.Cells("clmIepsUnit").Value = 0
                        .CurrentRow.Cells("clmTotal").Value = Det.PrecioVentaC
                        ''.CurrentRow.Cells(clmCodprodComp.Index).Value = Det.Producto.Codigo
                        .CurrentRow.Cells(clmContKit.Index).Value = ContKit
                        'ldGranTotal = ldGranTotal + .CurrentRow.Cells("clmTotal").Value
                        'lblGranTotal.Text = Format(ldGranTotal, "N2")


                        .CurrentRow.Cells(clmTotal.Index).ReadOnly = True
                        .CurrentRow.Cells(clmCantidad.Index).ReadOnly = True
                        .CurrentRow.Cells(clmPrecioUnit.Index).ReadOnly = True

                    End With
                    'dgvDetalle.Rows.Add("", 1, Det.Producto.Descripcion, "", "", "", "", "", "", "", "", "", "", "", "", "")
                    'dgvDetalle.Refresh()
                    'dgvDetalle.CurrentCell = dgvDetalle.Rows(0).Cells("clmCantidad")
                    'dgvDetalle.Rows(0).Cells(clmTotal.Index).ReadOnly = True
                    'dgvDetalle.Rows(0).Cells(clmCantidad.Index).ReadOnly = True
                    'dgvDetalle.Rows(0).Cells(clmPrecioUnit.Index).ReadOnly = True
                    'dgvDetalle.Rows(0).DefaultCellStyle.Font = New Drawing.Font("Arial", 15.75, Drawing.FontStyle.Bold)
                    'dgvDetalle.Rows(0).DefaultCellStyle.ForeColor = Drawing.Color.Black
                    'Application.DoEvents()
                    'dgvDetalle.EndEdit()

                    ''proceso del marcado del kit en desglose
                    Dim count As Integer = 1
                    For Each row As ClasesNegocio.DetalleKitClass In kitcol
                        count += 1
                        Det = lcListaPrecios.ObtenerDetalle(row.Producto.CodigoBarra)
                        With dgvDetalle
                            reng += 1
                            Dim ldImp As Decimal = row.Producto.PorcIEPS
                            If row.Producto.SeAplicaIva Then ldImp += ldIVA
                            .RowCount = reng
                            .CurrentCell = .Rows(reng - 1).Cells("clmCantidad")
                            .CurrentRow.Cells("clmCantidad").Value = row.Cantidad
                            .CurrentRow.Cells("clmCodProducto").Value = Det.Producto.Codigo
                            .CurrentRow.Cells("clmDescripcion").Value = Det.Producto.Descripcion
                            .CurrentRow.Cells("clmPrecioUnit").Value = row.Precio
                            .CurrentRow.Cells("clmDesctoUnit").Value = Det.Descuento
                            .CurrentRow.Cells("clmPrecioUnitSIva").Value = (row.Precio - Det.Descuento) / (1 + ldImp / 100)
                            .CurrentRow.Cells("clmDescuento").Value = Det.Descuento
                            .CurrentRow.Cells("clmPorcIva").Value = IIf(row.Producto.SeAplicaIva, ldIVA, 0)
                            .CurrentRow.Cells("clmIvaUnit").Value = IIf(row.Producto.SeAplicaIva, .CurrentRow.Cells("clmPrecioUnitSIva").Value * ldIVA / 100, 0)
                            .CurrentRow.Cells("clmIva").Value = .CurrentRow.Cells("clmIvaUnit").Value
                            .CurrentRow.Cells("clmPorcIeps").Value = row.Producto.PorcIEPS
                            .CurrentRow.Cells("clmIeps").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * row.Producto.PorcIEPS / 100
                            .CurrentRow.Cells("clmIepsUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * row.Producto.PorcIEPS / 100
                            .CurrentRow.Cells("clmTotal").Value = (row.Precio * row.Cantidad) - Det.Descuento
                            'ldGranTotal = ldGranTotal + .CurrentRow.Cells("clmTotal").Value
                            'lblGranTotal.Text = Format(ldGranTotal, "N2")

                            If Det.Producto.UnidadMedida.DescCorta.StartsWith("KG") Then
                                .CurrentRow.Cells(clmTotal.Index).ReadOnly = False
                            Else
                                .CurrentRow.Cells(clmTotal.Index).ReadOnly = True
                            End If
                            ''.CurrentRow.Cells(clmTotal.Index).ReadOnly = True
                            .CurrentRow.Cells(clmCantidad.Index).ReadOnly = True
                            .CurrentRow.Cells(clmPrecioUnit.Index).ReadOnly = True

                            .CurrentRow.Cells(clmContKit.Index).Value = ContKit
                            .CurrentRow.Cells(clmCodprodComp.Index).Value = kitcol.Item(0).IdKit
#If Not Debug Then
                            .CurrentRow.DefaultCellStyle.BackColor = Drawing.Color.Gainsboro
                            .CurrentRow.DefaultCellStyle.SelectionBackColor = Drawing.Color.DodgerBlue
                            .CurrentRow.DefaultCellStyle.ForeColor = Drawing.Color.Black
                            .CurrentRow.Cells(clmPrecioUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .CurrentRow.Cells(clmIVAUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .CurrentRow.Cells(clmIEPSUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .CurrentRow.Cells(clmTotal.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .CurrentRow.Cells(clmDesctoUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro

                            .CurrentRow.Cells(clmPrecioUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .CurrentRow.Cells(clmIVAUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .CurrentRow.Cells(clmIEPSUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .CurrentRow.Cells(clmTotal.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .CurrentRow.Cells(clmDesctoUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
#End If
                            

                            If count = 1 Then
                                .CurrentRow.DefaultCellStyle.Font = New Drawing.Font("Arial", 15.75, Drawing.FontStyle.Bold)
                                .CurrentRow.DefaultCellStyle.ForeColor = Drawing.Color.Black
                            End If

                            dgvDetalle.Refresh()

                        End With
                    Next
                    calcularGranTotal()
                Else

                    ''producto individual
                    With dgvDetalle
                        reng += 1
                        ''reng  = .RowCount
                        Dim ldImp As Decimal = Det.Producto.PorcIEPS
                        If Det.Producto.SeAplicaIva Then ldImp += ldIVA
                        .RowCount = reng
                        .CurrentCell = .Rows(reng - 1).Cells("clmCantidad")
                        If ArrCad.Length = 1 Then
                            .CurrentRow.Cells("clmCantidad").Value = 1
                        Else
                            .CurrentRow.Cells("clmCantidad").Value = CDbl(ArrCad(1))
                        End If
                        .CurrentRow.Cells("clmCodProducto").Value = Det.Producto.Codigo
                        .CurrentRow.Cells("clmDescripcion").Value = Det.Producto.Descripcion
                        .CurrentRow.Cells("clmPrecioUnit").Value = Det.PrecioVentaC
                        .CurrentRow.Cells("clmDesctoUnit").Value = Det.Descuento
                        .CurrentRow.Cells("clmPrecioUnitSIva").Value = (Det.PrecioVentaC - Det.Descuento) / (1 + ldImp / 100)
                        .CurrentRow.Cells("clmDescuento").Value = Det.Descuento
                        .CurrentRow.Cells("clmPorcIva").Value = IIf(Det.Producto.SeAplicaIva, ldIVA, 0)
                        .CurrentRow.Cells("clmIvaUnit").Value = IIf(Det.Producto.SeAplicaIva, .CurrentRow.Cells("clmPrecioUnitSIva").Value * ldIVA / 100, 0)
                        .CurrentRow.Cells("clmIva").Value = .CurrentRow.Cells("clmIvaUnit").Value
                        .CurrentRow.Cells("clmPorcIeps").Value = Det.Producto.PorcIEPS
                        .CurrentRow.Cells("clmIeps").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * Det.Producto.PorcIEPS / 100
                        .CurrentRow.Cells("clmIepsUnit").Value = (.CurrentRow.Cells("clmPrecioUnitSIva").Value * Det.Producto.PorcIEPS / 100)
                        .CurrentRow.Cells("clmTotal").Value = (Det.PrecioVentaC - Det.Descuento) * .CurrentRow.Cells("clmCantidad").Value
                        'ldGranTotal = ldGranTotal + .CurrentRow.Cells("clmTotal").Value
                        'lblGranTotal.Text = Format(ldGranTotal, "N2")

                        If Det.Producto.UnidadMedida.DescCorta.StartsWith("KG") Then
                            .CurrentRow.Cells(clmTotal.Index).ReadOnly = False
                        Else
                            .CurrentRow.Cells(clmTotal.Index).ReadOnly = True
                        End If
                        dgvDetalle.CurrentRow.Cells(clmContKit.Index).Value = 0
                        dgvDetalle.CurrentRow.Cells(clmCodprodComp.Index).Value = 0
                        .CurrentRow.DefaultCellStyle.BackColor = Drawing.Color.White
                        dgvDetalle.Refresh()
                    End With
                    
                    If Det.Producto.UnidadMedida.DescCorta.StartsWith("KG") Then
                        If ArrCad.Length = 1 Then
                            CapturaCantidad()
                        End If
                    End If
                    calcularGranTotal()
                End If


                'With dgvDetalle
                '    Dim reng As Integer = .RowCount
                '    Dim ldImp As Decimal = Det.Producto.PorcIEPS
                '    If Det.Producto.SeAplicaIva Then ldImp += ldIVA
                '    .RowCount = reng + 1
                '    .CurrentCell = .Rows(reng).Cells("clmCantidad")
                '    .CurrentRow.Cells("clmCantidad").Value = 1
                '    .CurrentRow.Cells("clmCodProducto").Value = Det.Producto.Codigo
                '    .CurrentRow.Cells("clmDescripcion").Value = Det.Producto.Descripcion
                '    .CurrentRow.Cells("clmPrecioUnit").Value = Det.PrecioVentaC
                '    .CurrentRow.Cells("clmDesctoUnit").Value = Det.Descuento
                '    .CurrentRow.Cells("clmPrecioUnitSIva").Value = (Det.PrecioVentaC - Det.Descuento) / (1 + ldImp / 100)
                '    .CurrentRow.Cells("clmDescuento").Value = Det.Descuento
                '    .CurrentRow.Cells("clmPorcIva").Value = IIf(Det.Producto.SeAplicaIva, ldIVA, 0)
                '    .CurrentRow.Cells("clmIvaUnit").Value = IIf(Det.Producto.SeAplicaIva, .CurrentRow.Cells("clmPrecioUnitSIva").Value * ldIVA / 100, 0)
                '    .CurrentRow.Cells("clmIva").Value = .CurrentRow.Cells("clmIvaUnit").Value
                '    .CurrentRow.Cells("clmPorcIeps").Value = Det.Producto.PorcIEPS
                '    .CurrentRow.Cells("clmIeps").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * Det.Producto.PorcIEPS / 100
                '    .CurrentRow.Cells("clmIepsUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * Det.Producto.PorcIEPS / 100
                '    .CurrentRow.Cells("clmTotal").Value = Det.PrecioVentaC - Det.Descuento
                '    ldGranTotal = ldGranTotal + .CurrentRow.Cells("clmTotal").Value
                '    lblGranTotal.Text = Format(ldGranTotal, "N2")

                '    If Det.Producto.UnidadMedida.DescCorta.StartsWith("KG") Then
                '        .CurrentRow.Cells(clmTotal.Index).ReadOnly = False
                '    Else
                '        .CurrentRow.Cells(clmTotal.Index).ReadOnly = True
                '    End If
                'End With
                'If Det.Producto.UnidadMedida.DescCorta.StartsWith("KG") Then
                '    CapturaCantidad()
                'End If
            End If
            txtArticulo.Text = ""
            txtArticulo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Sub calcularGranTotal()
        ldGranTotal = 0
        For Each row As DataGridViewRow In dgvDetalle.Rows
            If row.Cells(clmCodprodComp.Index).Value Is Nothing Or row.Cells(clmCodprodComp.Index).Value = 0 Then
                ldGranTotal += CDec(row.Cells(clmTotal.Index).Value)
            End If
        Next
        lblGranTotal.Text = Format(ldGranTotal, "N2")
    End Sub

    Public Function GuardarMovAlmacenCab(ByVal TipoMov As Integer) As Boolean
        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            'Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            'ConfigAlm.GetMulti(Nothing, 0, Nothing)

            'If ConfigAlm.Count < 1 Then
            '    MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            Sucursal.Obtener(Utilerias.ObtenerCodSucursal)

            Me.InvMovAlmacenCab = New AlmacenGeneral.MovimientoAlmacenPVClass



            Me.InvMovAlmacenCab.IdAlmacen = Sucursal.IdAlmacen
            Me.InvMovAlmacenCab.FolioMovimientoAlmacen = _FolioAlm
            Me.InvMovAlmacenCab.FechaMovimiento = Now

            'If Modo = 1 Then
            '    If IsDBNull(ConfigAlm(0).ExCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).ExCompra
            'ElseIf Modo = 2 Then
            '    If IsDBNull(ConfigAlm(0).SxDevolucionCompra) Or ConfigAlm(0).ExCompra Is Nothing Then
            '        MessageBox.Show("Configure los movimientos de almácen para poder guardar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Return False
            '    End If
            '    Me.InvMovAlmacenCab.IdTipoMovimiento = ConfigAlm(0).SxDevolucionCompra
            'End If
            ' Me.InvMovAlmacenCab.ValorMovimientoId = ""

            Me.InvMovAlmacenCab.IdTipoMovimiento = TipoMov ''ENTRADA POR COMPRA
            Me.InvMovAlmacenCab.CostoTotal = CDec(lblGranTotal.Text)
            Me.InvMovAlmacenCab.Origen = "VENTA"
            Me.InvMovAlmacenCab.Referencia = Referencia
            Me.InvMovAlmacenCab.IdUsuarioAlta = Controlador.Sesion.Usrndx
            Me.InvMovAlmacenCab.EstatusContabilizado = 0

            Return True
            ' Me.InvMovAlmacenCab.FechaContabilizacion = ""
            'Me.InvMovAlmacenCab.PolizaContabilidad = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function Guardar(Optional ByVal presiono As Boolean = False) As Boolean


        Me.PuedoModificar = False

        If Me.dgvDetalle.RowCount < 1 Then
            'MsgBox("La lista de artículos está vacía." & vbNewLine & "Capture al menos un artículo para guardar la nota de venta.", MsgBoxStyle.Critical, " Aviso ")
            Me.PuedoModificar = True
            Return False
        End If





        'Trans.Add(Me.InvMovAlmacenCab.Entidad)

        'If Not Me.InvMovAlmacenCab.Entidad.Save Then
        '    Trans.Rollback()
        '    'Cancelar = True
        '    Exit Function
        'End If

        '----------------Arriba es parte de los movimientos de inventario.....................

        'If Comprobar_Tipo_Cambio() = False Then
        '    Cancelar = True
        '    Exit Function
        'End If

        ''-----------------------------------------------------------------------------------------------------
        ''Validar que cuente con Cuentas contables  
        'If Not Me.Cliente.CuentaContable.Codigo > 0 Then
        '    MsgBox("El cliente no tiene Cuenta Contable" & vbNewLine & "Para poder realizar la Nota Venta, debe asignar la Cuenta Contable", MsgBoxStyle.Critical, " Aviso ")
        '    Cancelar = True
        '    Exit Function
        'End If
        'If Not Me.Cliente.CuentaVentas.Codigo > 0 Then
        '    MsgBox("El cliente no tiene Cuenta Contable" & vbNewLine & "Para poder realizar la Nota Venta, debe asignar la Cuenta Ventas", MsgBoxStyle.Critical, " Aviso ")
        '    Cancelar = True
        '    Exit Function
        'End If
        ''-----------------------------------------------------------------------------------------------------
        If cobrando = False Then
            If CDec(Me.lblGranTotal.Text) > CDec(0) Then
                Cursor = Cursors.WaitCursor
                Dim Ventana As New frmCobroNota                             'Manda llamar la forma de pago
                Ventana.ImporteTotal = CDec(Me.lblGranTotal.Text)           'Le envio a la ventana de pago, cuanto es el total a pagar
                Ventana.PresionoF8 = presiono
                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then  'Si se realizo el pago
                    cobrando = True
                    Application.DoEvents()
                    txthistorial.Text += "Inicia metodo guardar (pago)..... Hora: " & Now().ToString & vbLf
                    Application.DoEvents()
                    Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "NotaVenta")

                    Dim Sucursal As New ClasesNegocio.SucursalClass
                    Sucursal.Obtener(Utilerias.ObtenerControlTurnoActual.CodSucursal)
                    'obtiene la letra serie del almacen seleccionado
                    Me.Almacen = New ClasesNegocio.AlmacenClass
                    Almacen.Obtener(Sucursal.IdAlmacen)
                    'genera el folio de movimiento de almacen en la clase
                    Dim FolioAlmacen As New FolioAlmacenClass
                    FolioAlmacen.LetraSerie = Almacen.Letras
                    FolioAlmacen.Año = Now.Year
                    FolioAlmacen.Mes = Now.ToString("MM")

                    If Not FolioAlmacen.Guardar(Trans) Then
                        Trans.Rollback()

                        'Cancelar = True
                        'Exit Function
                        Exit Function
                    End If



                    'asigna el folio de movimiento de almacen
                    _FolioAlm = AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(Almacen.Codigo, Trans)


                    ReDim matriz(dgvDetalle.RowCount, 4)

                    For Each ren As DataGridViewRow In dgvDetalle.Rows
                        ''If ren.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                        matriz(ren.Index, 0) = ren.Cells("clmCodProducto").Value.ToString
                        matriz(ren.Index, 1) = ren.Cells("clmCantidad").Value.ToString
                        matriz(ren.Index, 2) = ren.Cells("clmPrecioUnit").Value.ToString
                        matriz(ren.Index, 3) = ren.Cells("clmDescuento").Value.ToString
                        ''End If
                    Next


                    'If GetVersion() = "Windows XP" Then
                    '    MovAlmacenDetalle()
                    'Else
                    '    hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
                    '    hilo1.Start()
                    'End If

                    'If So_Info.Version.Major = 5 And So_Info.Version.Minor = 1 Then
                    '    MovAlmacenDetalle()
                    '    txthistorial.Text += "SO " & My.Computer.Info.OSFullName & "" & My.Computer.Info.OSVersion & "..... Hora: " & Now().ToString & vbLf
                    '    Application.DoEvents()
                    'Else

                    'End If

                    'If (So_Info.Version.Major = 5 And So_Info.Version.Minor = 1) Or So_Info.Version.Major < 5 Then


                    If Not MovAlmacenDetalle() Then
                        Trans.Rollback()
                        TransMovAlm.Rollback()
                        cobrando = False
                        Cursor = Cursors.Default
                        Return False
                    End If

                    'ElseIf (So_Info.Version.Major = 6 And So_Info.Version.Minor = 1) Or So_Info.Version.Major >= 6 Then
                    '    'hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
                    '    'hilo1.Start()
                    '    'txthistorial.Text += "SO WIN 7..... Hora: " & Now().ToString & vbLf
                    '    'Application.DoEvents()
                    '    hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
                    '    hilo1.Start()
                    'End If


                    'Me.MovAlmacenDetalle()


                    ''proceso nota venta detalle y almacen
                    Try
                        If ControlTurnoActual Is Nothing Then ControlTurnoActual = Utilerias.ObtenerControlTurnoActual()

                        Nota = New CN.NotaVentaClass()
                        Nota.Total = CDec(lblGranTotal.Text)
                        If IsNumeric(Ventana.txtEfectivo.Text) Then Nota.PagoEfectivo = CDec(Ventana.txtEfectivo.Text) Else Nota.PagoEfectivo = 0
                        If IsNumeric(Ventana.txtTarjeta.Text) Then Nota.PagoTarjeta = CDec(Ventana.txtTarjeta.Text) Else Nota.PagoTarjeta = 0
                        Nota.Cambio = CDec(Ventana.lblCambio.Text)
                        Nota.FechaVenta = Now
                        Nota.UsuarioAlta = Controlador.Sesion.Usrndx
                        Nota.IdSucursal = Sucursal.Codigo      ' pendiente programar lectura de sucursal
                        Nota.IVA = 0
                        Nota.IEPS = 0
                        Nota.Descuento = 0
                        Nota.Subtotal = 0
                        Nota.Estatus = CN.CondicionEnum.ACTIVOS
                        Nota.FechaCancelacion = Nothing
                        Nota.MotivoCancelacion = Nothing
                        Nota.ObservacionesCancelacion = Nothing
                        Nota.IdFactura = Nothing
                        Nota.IdControlTurno = ControlTurnoActual.Id
                        Nota.Detalles = New CN.NotaVentaDetalleCollectionClass()

                        txthistorial.Text += "Inicia proceso de guardado de los movimientos(FOR EACH) de la nota de venta. Hora: " & Now().ToString & vbLf
                        Application.DoEvents()




                        For i As Integer = 0 To dgvDetalle.RowCount - 1
                            With dgvDetalle

                                'Dim prod As New ProductoClass(CInt(ren(.Cells("clmCodProducto").Value))
                                'Dim prod As New ProductoClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
                                'If prod.EsKit Then
                                '    Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
                                '    Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prod.Codigo)
                                '    For Each row As CN.DetalleKitClass In Detkit
                                '        j += 1
                                '        Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                                '        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                                '        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                                '        Me.InvMovAlmacenDet.IdProducto = row.IdProd
                                '        Me.InvMovAlmacenDet.Cantidad = row.Cantidad
                                '        Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
                                '        Me.InvMovAlmacenDet.Costo = listpre.PrecioVentaC
                                '        Me.InvMovAlmacenDet.Descuento = listpre.Descuento
                                '        Me.InvMovAlmacenDet.Indice = j
                                '        Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
                                '        Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
                                '        Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
                                '        If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                                '            Trans.Rollback()
                                '            'Cancelar = True
                                '            Exit Function
                                '        Else
                                '            txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
                                '            Application.DoEvents()
                                '        End If
                                '    Next
                                'Else
                                '    j += 1
                                '    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                                '    Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                                '    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                                '    Me.InvMovAlmacenDet.IdProducto = CInt(.Rows(i).Cells("clmCodProducto").Value)
                                '    Me.InvMovAlmacenDet.Cantidad = CDec(.Rows(i).Cells("clmCantidad").Value)
                                '    Me.InvMovAlmacenDet.Costo = CDec(.Rows(i).Cells("clmPrecioUnit").Value)
                                '    Me.InvMovAlmacenDet.Descuento = CDec(.Rows(i).Cells("clmDescuento").Value)
                                '    Me.InvMovAlmacenDet.Indice = j


                                '    If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
                                '        Trans.Rollback()
                                '        'Cancelar = True
                                '        Exit Function
                                '    Else
                                '        txthistorial.Text += "Guarda y actualiza el mov. de inv. Hora: " & Now().ToString & vbLf
                                '        Application.DoEvents()
                                '    End If
                                'End If
                                'Dim hilo1 As New Thread(Sub() Me.MovAlmacenDetalle(i)) 'Crear el hilo 1

                                'hilo1 = New Thread(New ThreadStart(Sub() Me.MovAlmacenDetalle(i)))
                                'hilo1.Start()
                                'MovAlmacenDetalle(i)
                                Dim det As CN.NotaVentaDetalleClass
                                Dim prodKit As New CN.ProductoGeneralClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
                                Dim prod As CN.ProductoGeneralClass
                                If prodKit.EsKit Then
                                    Dim cantidad As Integer = CInt(.Rows(i).Cells(clmCantidad.Index).Value)
                                    For indice As Integer = 1 To cantidad
                                        Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
                                        Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prodKit.Codigo)
                                        For Each row As CN.DetalleKitClass In Detkit
                                            det = New NotaVentaDetalleClass
                                            'prod = New ProductoClass(row.IdProd)
                                            det.IdProducto = row.IdProd
                                            det.Cantidad = row.Cantidad
                                            'Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
                                            det.Precio = CDec(row.Precio)     ' Precio unitario
                                            det.Descuento = 0   ' Descuento total
                                            det.IVA = row.Iva * det.Cantidad
                                            det.IEPS = row.Ieps * det.Cantidad
                                            'Dim totimp As Decimal = 0

                                            'If prod.SeAplicaIva Then
                                            '    totimp += Controlador.ObtenerIVA
                                            'End If
                                            'If prod.PorcIEPS <> 0 Then
                                            '    totimp += prod.PorcIEPS
                                            'End If
                                            'Dim precioSImp As Decimal = (det.Precio - det.Descuento) / (1 + (totimp / 100))

                                            'If prod.SeAplicaIva Then
                                            '    det.IVA = (precioSImp * ((Controlador.ObtenerIVA / 100))) * det.Cantidad
                                            'Else
                                            '    det.IVA = CDec(0)
                                            'End If
                                            'If prod.PorcIEPS <> 0 And prod.PorcIEPS > 0 Then
                                            '    det.IEPS = (precioSImp * ((prod.PorcIEPS / 100))) * det.Cantidad
                                            'Else
                                            '    det.IEPS = CDec(0)
                                            'End If

                                            'If prod.PorcIEPS <> 0 Then
                                            '    If prod.SeAplicaIva Then
                                            '        det.IEPS = CDec((listpre.PrecioVentaC - det.IVA) - ((listpre.PrecioVentaC - det.IVA) / ((prod.PorcIEPS / 100) + 1)))
                                            '    Else
                                            '        det.IEPS = CDec((listpre.PrecioVentaC) / ((prod.PorcIEPS / 100) + 1))
                                            '    End If
                                            'End If

                                            det.Importe = (det.Cantidad * det.Precio) - det.Descuento
                                            det.IdProductoCompuesto = row.IdKit
                                            Nota.Subtotal = Nota.Subtotal + (det.Importe + det.Descuento - det.IVA - det.IEPS)
                                            Nota.Descuento = Nota.Descuento + det.Descuento
                                            Nota.IVA = Nota.IVA + det.IVA
                                            Nota.IEPS = Nota.IEPS + det.IEPS
                                            Nota.Detalles.Add(det)

                                            'j += 1
                                            'Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                                            'Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                                            'Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                                            'Me.InvMovAlmacenDet.IdProducto = row.IdProd
                                            'Me.InvMovAlmacenDet.Cantidad = row.Cantidad
                                            'Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
                                            'Me.InvMovAlmacenDet.Costo = listpre.PrecioVentaC
                                            'Me.InvMovAlmacenDet.Descuento = listpre.Descuento
                                            'Me.InvMovAlmacenDet.Indice = j
                                            'Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
                                            'Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
                                            'Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
                                            'If Not Me.InvMovAlmacenDet.Guardar(TransMovAlm) Then
                                            '    Trans.Rollback()
                                            '    TransMovAlm.Rollback()
                                            '    'Cancelar = True
                                            '    Exit Function
                                            'Else
                                            '    txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
                                            '    Application.DoEvents()
                                            'End If
                                        Next
                                    Next
                                Else
                                    If .Rows(i).Cells(clmCodprodComp.Index).Value = 0 Then
                                        det = New NotaVentaDetalleClass
                                        det.IdProducto = CInt(.Rows(i).Cells("clmCodProducto").Value)
                                        det.Cantidad = CDec(.Rows(i).Cells("clmCantidad").Value)
                                        det.Precio = CDec(.Rows(i).Cells("clmPrecioUnit").Value)     ' Precio unitario
                                        det.Descuento = CDec(.Rows(i).Cells("clmDescuento").Value)   ' Descuento total
                                        det.IVA = CDec(.Rows(i).Cells("clmIVA").Value)               ' IVA total
                                        det.IEPS = CDec(.Rows(i).Cells("clmIEPS").Value)             ' IEPS total
                                        det.Importe = (det.Cantidad * det.Precio) - det.Descuento '+ det.IVA + det.IEPS
                                        Nota.Subtotal = Nota.Subtotal + (det.Importe + det.Descuento - det.IVA - det.IEPS)
                                        Nota.Descuento = Nota.Descuento + det.Descuento
                                        Nota.IVA = Nota.IVA + (det.IVA)
                                        Nota.IEPS = Nota.IEPS + (det.IEPS)
                                        Nota.Detalles.Add(det)
                                        txthistorial.Text += "Guarda detalle de la nota de venta. Hor a: " & Now().ToString & vbLf
                                        Application.DoEvents()
                                    End If
                                End If


                                'Dim det As New CN.NotaVentaDetalleClass()



                            End With
                        Next




                        'MovAlmacenDetalle()





                        'MsgBox("Termina proceso de guardado de los movimientos de la nota de venta.", MsgBoxStyle.Information, Application.ProductName)
                        txthistorial.Text += "Termina proceso de guardado de los movimientos de la nota de venta. Hora: " & Now().ToString & vbLf
                        Application.DoEvents()


                        Me.PuedoModificar = True
                        If Nota.Guardar(Trans) Then
                            'If Not GetVersion() = "Windows XP" Then
                            '    hilo1.Join()
                            'End If

                            'If (So_Info.Version.Major = 6 And So_Info.Version.Minor = 1) Or So_Info.Version.Major >= 6 Then
                            '    hilo1.Join()
                            'End If

                            InvMovAlmacenCab.Referencia = Convert.ToString(Nota.Codigo)
                            'Trans.Add(Me.InvMovAlmacenCab.Entidad)

                            If Not Me.InvMovAlmacenCab.Guardar(TransMovAlm) Then
                                Trans.Rollback()
                                'Cancelar = True
                                Exit Function
                            End If




                            txthistorial.Text += "Commit de la transaccion.. Hora: " & Now().ToString & vbLf
                            Application.DoEvents()
                            Trans.Commit()
                            Application.DoEvents()
                            'Me.guardarrespaldonotaventa(Nota)


                            txthistorial.Text += "inicia el imprimir.. Hora: " & Now().ToString & vbLf
                            Application.DoEvents()
                            'hilo3 = New Thread(Sub() Imprimir(Nota.Codigo)) 'Crear el hilo 1
                            'hilo3.Start()
                            'Imprimir(Nota.Codigo)
                            ReImprimir(Nota.Codigo)
                            CodNotaVentaTemp = Nota.Codigo
                            txthistorial.Text += "termina el imprimir.. Hora: " & Now().ToString & vbLf
                            Application.DoEvents()


                            grpUltimaOper.Visible = True
                            lblImpTotalAnt.Text = lblGranTotal.Text
                            lblImpPagoAnt.Text = Format(Nota.PagoEfectivo + Nota.PagoTarjeta, "N2")
                            lblImpCambioAnt.Text = Ventana.lblCambio.Text


                            'Imprimir(Nota.Codigo)

                            'MessageBox.Show("Se ha guardado la nota de venta con el Codigo: " & Nota.Codigo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.None)

                            'Nota = Nothing

                            'If MsgBox("Se ha guardado la nota de venta con el Codigo: " & Nota.Codigo & vbNewLine & "¿Desea generar la Factura?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                            '    If Not Cliente.ObtenerDomiciliosFiscales.Count > 0 Then
                            '        MsgBox("El Cliente no cuenta con un Domicilio Fiscal, debe de tener almenos uno, para poder realizar la Factura", MsgBoxStyle.Exclamation, "Aviso")
                            '        Exit Function
                            '    End If

                            '    ObtenerRFCGeneral()
                            '    If Cliente.RFC = ClienteDefault.RFC Then
                            '        If MsgBox("El RFC de este Cliente, es Generico y la Factura será a Publico General" & vbNewLine & "¿Desea Continuar?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Cancel Then
                            '            Cancelar = True
                            '            Exit Function
                            '        End If
                            '    End If

                            '    Dim Numero As String
                            '    Numero = InputBox("Nota Venta: " & Nota.Codigo & vbNewLine & vbNewLine & "Para Generar la Factura, indique el Codigo de la Nota que se muestra ", "Aviso")
                            '    If Numero = Nota.Codigo.ToString Then
                            '        Dim ventana2 As New VentaFacturas(Nota.Codigo)
                            '        ventana2.ShowDialog()
                            '        Limpiar()
                            '    End If
                            'End If
                            'Esperar a que realmente mueran los hilos

                            'hilo1 = New Thread(AddressOf Me.MovAlmacenDetalle) 'Crear el hilo 1
                            'hilo1.Start()

                            TransMovAlm.Commit()
                            cobrando = False
                            Application.DoEvents()
                        Else
                            Return False
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                        Return False
                    Finally

                        Limpiar()
                        Cursor = Cursors.Default

                        'If Not GetVersion() = "Windows XP" Then
                        '    'hilo1.Abort()
                        '    'For Each hilo1 In System.Diagnostics.Process.GetCurrentProcess().Threads
                        '    '    hilo1.Abort()
                        '    'Next
                        '    'If hilo1.IsAlive Then
                        '    '    hilo1.Abort()
                        '    'End If
                        '    'If hilo1.IsAlive Then
                        '    '    hilo1.Abort()
                        '    'End If
                        '    While hilo1.IsAlive
                        '        txthistorial.Text += "hilo vivo.. Hora: " & Now().ToString & vbLf
                        '        Application.DoEvents()
                        '    End While
                        '    hilo1.Abort()
                        '    hilo1 = Nothing

                        'End If

                        'If (So_Info.Version.Major = 6 And So_Info.Version.Minor = 1) Or So_Info.Version.Major >= 6 Then
                        '    While hilo1.IsAlive
                        '        txthistorial.Text += "hilo vivo.. Hora: " & Now().ToString & vbLf
                        '        Application.DoEvents()
                        '    End While
                        '    hilo1.Abort()
                        '    hilo1 = Nothing
                        'End If
                        'hilo1.Abort()

                        'hilo1 = Nothing


                    End Try
                Else
                    'MsgBox("Pago no realizado", MsgBoxStyle.Information, "No se ha realizado el Pago")
                    'Trans.Rollback()
                    contador = 0
                    Cursor = Cursors.Default

                    Exit Function
                End If
            End If


        End If


    End Function

    Public Sub guardarrespaldonotaventa(ByVal row As CN.NotaVentaClass)
        Try
            Dim nvr As New CN.NotaVentaRespClass()
            nvr.Codigo = row.Codigo
            nvr.IdSucursal = row.IdSucursal
            nvr.Estatus = row.Estatus
            nvr.Subtotal = row.Subtotal
            nvr.Descuento = row.Descuento
            nvr.Total = row.Total
            nvr.FechaVenta = row.FechaVenta
            nvr.FechaCancelacion = row.FechaCancelacion
            nvr.UsuarioCancelacion = row.UsuarioCancelacion
            nvr.UsuarioAlta = row.UsuarioAlta
            nvr.MotivoCancelacion = row.MotivoCancelacion
            nvr.ObservacionesCancelacion = row.ObservacionesCancelacion
            nvr.IVA = row.IVA
            nvr.IEPS = row.IEPS
            nvr.IdFactura = row.IdFactura
            nvr.PagoEfectivo = row.PagoEfectivo
            nvr.PagoTarjeta = row.PagoTarjeta
            nvr.Cambio = row.Cambio
            nvr.CodCaja = row.CodCaja
            nvr.IdControlTurno = row.IdControlTurno
            'nvr.IdControlTurnoCanc = row.IdControlTurnoCanc
            nvr.SerieFactura = row.SerieFactura
            nvr.FolioFactura = row.FolioFactura
            'If nvr.Guardar(Trans) Then

            'End If
            If nvr.Guardar(Trans) Then


            End If


            ''DETALLE NOTA VENTA
            For Each rd As CN.NotaVentaDetalleClass In row.Detalles
                ''---RESPALDAR DETALLE NOTA
                Dim rdN As New CN.NotaVentaDetalleClass(rd.Codigo)

                Dim nvdr As New CN.NotaVentaDetalleRespClass
                nvdr.Codigo = rd.Codigo
                nvdr.NotaVenta = row.Codigo
                nvdr.IdProducto = rd.IdProducto
                nvdr.Cantidad = rd.Cantidad
                nvdr.Precio = rd.Precio
                nvdr.Importe = rd.Importe
                nvdr.Descuento = rd.Descuento
                nvdr.IVA = rd.IVA
                nvdr.IEPS = rd.IEPS
                nvdr.IdProductoCompuesto = rd.IdProductoCompuesto
                If nvdr.Guardar(Trans) Then

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
       
    End Sub


    Public Function GetVersion() As String
        So_Info = System.Environment.OSVersion 'Obtiene un objeto OperatingSystem que contiene el identificador de la plataforma actual y el número de versión.
        With So_Info
            Select Case .Platform
                Case .Platform.Win32Windows
                    Select Case (.Version.Minor)
                        Case 0
                            GetVersion = "Windows 95"
                        Case 10
                            If .Version.Revision.ToString() = "2222A" Then
                                GetVersion = "Windows 98 Second Edition"
                            Else
                                GetVersion = "Windows 98"
                            End If
                        Case 90
                            GetVersion = "Windows Me"
                    End Select

                Case .Platform.Win32NT
                    Select Case (.Version.Major)
                        Case 3
                            GetVersion = "Windows NT 3.51"
                        Case 4
                            GetVersion = "Windows NT 4.0"
                        Case 5
                            If .Version.Minor = 0 Then
                                GetVersion = "Windows 2000"
                            Else
                                GetVersion = "Windows XP"
                            End If
                    End Select

                Case Else
                    GetVersion = "S.O no conocido"
            End Select
        End With
    End Function

    Public Function MovAlmacenDetalle() As Boolean
        'With dgvDetalle 
        '    Dim prod As New ProductoClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
        '    If prod.EsKit Then
        '        Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
        '        Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prod.Codigo)
        '        For Each row As CN.DetalleKitClass In Detkit
        '            j += 1
        '            Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
        '            Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
        '            Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
        '            Me.InvMovAlmacenDet.IdProducto = row.IdProd
        '            Me.InvMovAlmacenDet.Cantidad = row.Cantidad
        '            Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
        '            Me.InvMovAlmacenDet.Costo = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.Descuento = listpre.Descuento
        '            Me.InvMovAlmacenDet.Indice = j
        '            Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
        '            Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
        '            If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
        '                Trans.Rollback()
        '                'Cancelar = True
        '                Exit Sub
        '            Else
        '                txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
        '                Application.DoEvents()
        '            End If
        '        Next
        '    Else
        '        j += 1
        '        Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
        '        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
        '        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
        '        Me.InvMovAlmacenDet.IdProducto = CInt(.Rows(i).Cells("clmCodProducto").Value)
        '        Me.InvMovAlmacenDet.Cantidad = CDec(.Rows(i).Cells("clmCantidad").Value)
        '        Me.InvMovAlmacenDet.Costo = CDec(.Rows(i).Cells("clmPrecioUnit").Value)
        '        Me.InvMovAlmacenDet.Descuento = CDec(.Rows(i).Cells("clmDescuento").Value)
        '        Me.InvMovAlmacenDet.Indice = j


        '        If Not Me.InvMovAlmacenDet.Guardar(Trans) Then
        '            Trans.Rollback()
        '            'Cancelar = True
        '            Exit Sub
        '        Else
        '            txthistorial.Text += "Guarda y actualiza el mov. de inv. Hora: " & Now().ToString & vbLf
        '            Application.DoEvents()
        '        End If
        '    End If
        'End With

        '------------------Abajo Parte de los movimientos de inventario-----------------------

        TransMovAlm = New HC.Transaction(IsolationLevel.ReadCommitted, "MovAlm")



        If Not GuardarMovAlmacenCab(2) Then 'salida
            Trans.Rollback()
            TransMovAlm.Rollback()

            'Cancelar = True
            'Exit Function
            Return False
        End If

        If Not InvMovAlmacenCab.Guardar(TransMovAlm) Then
            Trans.Rollback()
            TransMovAlm.Rollback()

            'Cancelar = True
            'Exit Function
            Return False
        End If

        j = 0
        For ind As Integer = 0 To dgvDetalle.RowCount - 1
            'Dim prod As New ProductoClass(CInt(.Rows(i).Cells("clmCodProducto").Value))
            Dim prod As New ProductoClass(CInt(matriz(ind, 0)))
            If prod.EsKit Then
                Dim cantidad As Integer = CInt(matriz(ind, 1))
                Dim Detkit As New ClasesNegocio.DetalleKitCollectionClass
                Detkit.Obtener(HC.DetalleKitPvFields.IdKit = prod.Codigo)
                For index As Integer = 1 To cantidad
                    For Each row As CN.DetalleKitClass In Detkit
                        j += 1
                        Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                        Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                        Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                        Me.InvMovAlmacenDet.IdProducto = row.IdProd
                        Me.InvMovAlmacenDet.Cantidad = row.Cantidad
                        'Dim listpre As New CN.ListaPrecioDetalleClass(1, row.IdProd)
                        Me.InvMovAlmacenDet.Costo = row.Precio
                        Me.InvMovAlmacenDet.Descuento = 0
                        Me.InvMovAlmacenDet.Indice = j
                        'Me.InvMovAlmacenDet.CostoPromedio = listpre.PrecioVentaC
                        'Me.InvMovAlmacenDet.CostoPromedioAnterior = listpre.PrecioVentaC
                        Me.InvMovAlmacenDet.IdProdComp = prod.Codigo
                        If Not Me.InvMovAlmacenDet.Guardar(TransMovAlm) Then
                            Trans.Rollback()
                            TransMovAlm.Rollback()
                            'Cancelar = True
                            Return False
                        Else

                            txthistorial.Text += "Guarda y actualiza el mov. de inv en kit. Hora: " & Now().ToString & vbLf
                            Application.DoEvents()
                        End If
                    Next
                Next

            Else
                If dgvDetalle.Rows(ind).Cells(clmCodprodComp.Index).Value = 0 Then
                    j += 1
                    Me.InvMovAlmacenDet = New AlmacenGeneral.MovimientoAlmacenPVDetalleClass
                    Me.InvMovAlmacenDet.IdAlmacen = Almacen.Codigo
                    Me.InvMovAlmacenDet.FolioMovimientoAlmacen = _FolioAlm
                    Me.InvMovAlmacenDet.IdProducto = CInt(matriz(ind, 0))
                    Me.InvMovAlmacenDet.Cantidad = CDec(matriz(ind, 1))
                    Me.InvMovAlmacenDet.Costo = CDec(matriz(ind, 2))
                    Me.InvMovAlmacenDet.Descuento = CDec(matriz(ind, 3))
                    Me.InvMovAlmacenDet.Indice = j



                    If Not Me.InvMovAlmacenDet.Guardar(TransMovAlm) Then
                        Trans.Rollback()
                        TransMovAlm.Rollback()
                        'Cancelar = True
                        Return False
                    Else

                        txthistorial.Text += "Guarda y actualiza el mov. de inv. Hora: " & Now().ToString & vbLf
                        Application.DoEvents()
                    End If
                End If
            End If
        Next

        Return True

    End Function

    Sub Limpiar()
        dgvDetalle.Rows.Clear()
        lblGranTotal.Text = "0.00"
        txtArticulo.Text = ""
        ldGranTotal = 0
        txtArticulo.Focus()
        i = 0
        If NotasRet.Count = 0 Then
            ContKit = 0
        End If
        contador = 0
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
        'Me.Dispose()
    End Sub

    'Private Sub frmNotaDeVenta_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
    '    If Not Me.Parent Is Nothing Then
    '        Me.Top = 0
    '        Me.Left = 0
    '        Me.Width = Me.Parent.Width - 4
    '        Me.Height = Me.Parent.Height - 35
    '    End If
    'End Sub

    Private Sub frmNotaDeVenta_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If dgvDetalle.RowCount > 0 Then
            If MessageBox.Show("No se ha terminado la nota pendiente. ¿Desea salir sin guardar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
        If NotasRet.Count > 0 Then
            If MessageBox.Show("Hay notas retenidas que se perderán si sale de la captura de notas de venta. ¿Desea salir finalizarlas?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmNotaDeVenta_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        If Not Guardar(True) Then Return
    End Sub

    Private Sub Imprimir(ByVal CodNota As Integer)
        Dim prtSet As New PrinterSettings

        Try
            'For Each nomprt As String In PrinterSettings.InstalledPrinters
            '    If nomprt.ToUpper = "TICKET" Then
            '        prtSet.PrinterName = nomprt
            '    End If
            'Next

            Dim ds As New dsNotaVenta()
            With ds
                .NotaVenta.AddNotaVentaRow(Nota.Codigo, Nota.IdSucursal, Nota.Sucursal.DescripcionCorta, Nota.Subtotal, Nota.Descuento, _
                                           Nota.Total, Nota.FechaVenta, Nota.IVA, Nota.IEPS, 0, Nota.PagoEfectivo + Nota.PagoTarjeta, Nota.Cambio, Nota.UsuarioAlta, _
                                           Nota.ObservacionesCancelacion)

                'For Each det As CN.NotaVentaDetalleClass In Nota.Detalles
                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, ds.NotaVenta.Rows(0))
                'Next
                'For i As Integer = 0 To dgvDetalle.RowCount - 1
                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo,dgvDetalle.Rows(i
                'Next


                For Each row As DataGridViewRow In dgvDetalle.Rows

                    Dim prod As New CN.ProductoGeneralClass(CInt(row.Cells(clmCodprodComp.Index).Value))

                    If prod.EsKit Then
                        'If CInt(row.Cells(clmContKit.Index).Value) <> CInt(dgvDetalle.Rows(row.Index - 1).Cells(clmContKit.Index).Value) Then

                        'End If
                        .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, 0, 0, 0, 0, "", 0, prod.Descripcion & "- " & row.Cells(clmContKit.Index).Value.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVenta.Rows(0))
                    Else
                        If row.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                            .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, row.Cells(clmPrecioUnit.Index).Value, row.Cells(clmCantidad.Index).Value * row.Cells(clmPrecioUnit.Index).Value, 0, 0, "", 0, "", 0, ds.NotaVenta.Rows(0))
                        End If
                    End If


                Next
            End With
            Dim rep As New crNotaVtaTck
            rep.SetDataSource(ds)
            rep.SetParameterValue("Encabezado", Controlador.Empresa.Nombre + vbNewLine + Controlador.Empresa.Domicilio + vbNewLine + Controlador.Empresa.RFC)
            rep.SetParameterValue("Reimpresion", "")
            'Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
            rep.PrintToPrinter(1, False, 0, 0)


#If DEBUG Then
            '.....prueba del ticket visualmente
            Dim Prev As New ClasesNegocio.PreVisualizarForm
            Prev.Reporte = rep
            Prev.Text = "TICKET"
            Prev.ShowDialog()
#End If

            rep.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ReImprimir(ByVal CodNota As Integer, Optional ByVal Reimp As String = "")
        Dim prtSet As New PrinterSettings

        Try
            'For Each nomprt As String In PrinterSettings.InstalledPrinters
            '    If nomprt.ToUpper = "TICKET" Then
            '        prtSet.PrinterName = nomprt
            '    End If
            'Next

            Dim NotaVenta As New CN.NotaVentaClass()
            NotaVenta.Obtener(CodNota)
            Dim usuario As New UsuarioClass(NotaVenta.UsuarioAlta)


            Dim ds As New dsNotaVenta()
            With ds
                .NotaVenta.AddNotaVentaRow(NotaVenta.Codigo, NotaVenta.IdSucursal, NotaVenta.Sucursal.DescripcionCorta, NotaVenta.Subtotal, NotaVenta.Descuento,
                                            NotaVenta.Total, NotaVenta.FechaVenta, NotaVenta.IVA, NotaVenta.IEPS, 0, NotaVenta.PagoEfectivo + NotaVenta.PagoTarjeta,
                                            NotaVenta.Cambio, usuario.UserName.ToUpper, NotaVenta.ObservacionesCancelacion)
                Dim cont As Integer = 0
                Dim Totalkit As Integer = 0
                Dim contKits As Integer = 1
                For Each det As CN.NotaVentaDetalleClass In Nota.Detalles

                    If det.IdProductoCompuesto <> 0 Then
                        cont += 1
                        Dim kitdet As New DetalleKitCollectionClass
                        Dim prod As New ProductoGeneralClass(det.IdProductoCompuesto)
                        kitdet.Obtener(det.IdProductoCompuesto)

                        If cont = 1 Then
                            Totalkit = kitdet.Count
                        End If


                        .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, 0, 0, 0, 0, "", 0, prod.Descripcion & "-" & contKits.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVenta.Rows(0))
                        If cont >= Totalkit Then
                            cont = 0
                            contKits += 1
                        End If

                    Else
                        .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVenta.Rows(0))
                    End If

                    'If det.IdProductoCompuesto <> 0 Then

                    'Else

                    'End If

                Next
                '.NotaVenta.AddNotaVentaRow(Nota.Codigo, Nota.IdSucursal, Nota.Sucursal.DescripcionCorta, Nota.Subtotal, Nota.Descuento, _
                '                           Nota.Total, Nota.FechaVenta, Nota.IVA, Nota.IEPS, 0, Nota.PagoEfectivo + Nota.PagoTarjeta, Nota.Cambio, Nota.UsuarioAlta, _
                '                           Nota.ObservacionesCancelacion)

                'For Each det As CN.NotaVentaDetalleClass In Nota.Detalles
                'Dim prod As New CN.ProductoGeneralClass(det.IdProducto)
                '    If prod.EsKit Then

                '    End If


                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(det.NotaVenta, det.IdProducto, det.Producto.Descripcion, det.Cantidad, det.Precio, det.Importe, det.Descuento, det.IVA, "", det.IEPS, "", 0, ds.NotaVenta.Rows(0))
                'Next
                'For i As Integer = 0 To dgvDetalle.RowCount - 1
                '    .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo,dgvDetalle.Rows(i
                'Next

                'For Each row As DataGridViewRow In dgvDetalle.Rows
                '    Dim prod As New CN.ProductoGeneralClass(CInt(row.Cells(clmCodprodComp.Index).Value))

                '    If prod.EsKit Then
                '        'If CInt(row.Cells(clmContKit.Index).Value) <> CInt(dgvDetalle.Rows(row.Index - 1).Cells(clmContKit.Index).Value) Then

                '        'End If
                '        .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, 0, 0, 0, 0, "", 0, prod.Descripcion & "- " & row.Cells(clmContKit.Index).Value.ToString, prod.Precio(1).PrecioVentaC, ds.NotaVenta.Rows(0))
                '    Else
                '        If row.Cells(clmCodprodComp.Index).Value IsNot Nothing Then
                '            .NotaVentaDetalle.AddNotaVentaDetalleRow(Nota.Codigo, row.Cells(clmCodProducto.Index).Value, row.Cells(clmDescripcion.Index).Value, row.Cells(clmCantidad.Index).Value, row.Cells(clmPrecioUnit.Index).Value, row.Cells(clmCantidad.Index).Value * row.Cells(clmPrecioUnit.Index).Value, 0, 0, "", 0, "", 0, ds.NotaVenta.Rows(0))
                '        End If
                '    End If


                'Next


            End With
            Dim rep As New crNotaVtaTck
            rep.SetDataSource(ds)
            rep.SetParameterValue("Encabezado", Controlador.Empresa.Nombre + vbNewLine + Controlador.Empresa.Domicilio + vbNewLine + Controlador.Empresa.RFC)
            rep.SetParameterValue("Reimpresion", Reimp)
            'Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString

            rep.PrintToPrinter(1, True, 0, 0)


#If DEBUG Then
            '.....prueba del ticket visualmente
            Dim Prev As New ClasesNegocio.PreVisualizarForm
            Prev.Reporte = rep
            Prev.Text = "TICKET"
            Prev.ShowDialog()
#End If

            rep.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CapturaCantidad()
        If dgvDetalle.RowCount > 0 Then
            Dim Ventana As New frmCantidad      'Manda llamar la forma de captura de cantidad
            Ventana.txtCantidad.Text = ""              'Le envio a la ventana de pago, cuanto es el total a pagar
            If Ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then  ' Si se capturó la cantidad
                If CDec(Ventana.txtCantidad.Text) > 0 Then
                    dgvDetalle.CurrentRow.Cells("clmCantidad").Value = CDec(Ventana.txtCantidad.Text)
                Else
                    dgvDetalle.CurrentRow.Cells("clmCantidad").Value = CDec(1)
                End If
                CalculaRenglon()
            End If
            Ventana.Dispose()
        End If

        Application.DoEvents()
        txtArticulo.Focus()
    End Sub

    Private Sub CalculaRenglon()
        With dgvDetalle.CurrentRow
            Dim lnCantidad As Decimal = CDec(.Cells("clmCantidad").Value)
            .Cells("clmDescuento").Value = .Cells("clmDesctoUnit").Value * lnCantidad
            .Cells("clmIva").Value = .Cells("clmIvaUnit").Value * lnCantidad
            .Cells("clmIeps").Value = .Cells("clmIepsUnit").Value * lnCantidad
            .Cells("clmTotal").Value = lnCantidad * (.Cells("clmPrecioUnit").Value - .Cells("clmDesctoUnit").Value)
            'txtCantidad.Text = ""
            Totaliza()
        End With
    End Sub

    Private Sub Totaliza()
        ldGranTotal = 0
        For Each reng As DataGridViewRow In dgvDetalle.Rows
            If reng.Cells(clmCodprodComp.Index).Value = 0 Then
                ldGranTotal = ldGranTotal + reng.Cells("clmTotal").Value
            End If
        Next
        lblGranTotal.Text = Format(ldGranTotal, "N2")
    End Sub

    Private Sub btnCorteX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorteX.Click

        'SEGORM.CollectionClasses.DetallegruposCollection.GetMultiAsDataTable()
        'Dim Grupo As New ECS.CollectionClasses.DetallegruposCollection()
        'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = Controlador.Sesion.MiUsuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
        'Dim gpo As Integer = 0
        'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
        '    gpo = elem.Gpondx
        'Next

        'If gpo = 1 Then
        '    Cortex()
        'Else
        '    Dim validar As New ValidateForm()
        '    If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Grupo = New ECS.CollectionClasses.DetallegruposCollection()
        '        Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
        '        gpo = 0
        '        For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
        '            gpo = elem.Gpondx
        '        Next

        '        If gpo = 1 Then
        '            Cortex()
        '        Else
        '            MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
        '        End If

        '    Else

        '    End If
        '    'MsgBox("Sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
        'End If
        Dim permiso As New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)
        If Not IsDBNull(permiso.Usrtipo) Then
            If permiso.Usrtipo.Equals("A") Then
                Cortex()
            Else
                'Dim frmlogin As New LoginForm()
                Dim validar As New ValidateForm()
                If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    permiso = New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, validar.Usuario.Usrndx)
                    'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                    'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                    'gpo = 0
                    'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                    '    gpo = elem.Gpondx
                    'Next
                    If Not IsDBNull(permiso.Usrtipo) Then
                        If permiso.Usrtipo.Equals("A") Then
                            Cortex()
                        Else
                            MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                        End If
                    Else
                        MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                    End If



                Else

                End If


            End If
        Else
            Dim validar As New ValidateForm()
            If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                permiso = New ECS.EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)
                'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                'gpo = 0
                'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                '    gpo = elem.Gpondx
                'Next
                If Not IsDBNull(permiso.Usrtipo) Then
                    If permiso.Usrtipo.Equals("A") Then
                        Cortex()
                    Else
                        MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                    End If
                Else
                    MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                End If



            Else

            End If
        End If


    End Sub

    Private Sub btnCorteZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorteZ.Click


        Dim permiso As New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)
        'Dim Grupo As New ECS.CollectionClasses.DetallegruposCollection()
        'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = Controlador.Sesion.MiUsuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
        'Dim gpo As Integer = 0
        'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
        '    gpo = elem.Gpondx
        'Next
        If Not IsDBNull(permiso.Usrtipo) Then
            If permiso.Usrtipo.Equals("A") Then
                Cortez()
            Else
                'Dim frmlogin As New LoginForm()
                Dim validar As New ValidateForm()
                If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    permiso = New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, validar.Usuario.Usrndx)
                    'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                    'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                    'gpo = 0
                    'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                    '    gpo = elem.Gpondx
                    'Next
                    If Not IsDBNull(permiso.Usrtipo) Then
                        If permiso.Usrtipo.Equals("A") Then
                            Cortez()
                        Else
                            MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                        End If
                    Else
                        MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                    End If



                Else

                End If


            End If
        Else
            Dim validar As New ValidateForm()
            If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                permiso = New ECS.EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)
                'Grupo = New ECS.CollectionClasses.DetallegruposCollection()
                'Grupo.GetMulti(ECS.HelperClasses.DetallegruposFields.Usrndx = validar.Usuario.Usrndx And ECS.HelperClasses.DetallegruposFields.Empndx = Controlador.Sesion.MiEmpresa.Empndx)
                'gpo = 0
                'For Each elem As ECS.EntityClasses.DetallegruposEntity In Grupo
                '    gpo = elem.Gpondx
                'Next
                If Not IsDBNull(permiso.Usrtipo) Then
                    If permiso.Usrtipo.Equals("A") Then
                        Cortez()
                    Else
                        MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                    End If
                Else
                    MsgBox("Usuario sin permisos para acceder a esta opcion.", MsgBoxStyle.Exclamation, "AVISO")
                End If



            Else

            End If
        End If


    End Sub

    Private Sub btnRetener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetener.Click
        If dgvDetalle.RowCount = 0 Then Return
        retener()
        'Dim NotaRet As New NotaRetenida()
        'NotaRet.Id = txtArticulo.Text
        'NotaRet.CantArt = dgvDetalle.RowCount
        'NotaRet.Total = CDec(lblGranTotal.Text)
        'NotaRet.Renglones = New List(Of DataGridViewRow)
        'For Each ren As DataGridViewRow In dgvDetalle.Rows
        '    NotaRet.Renglones.Add(ren)
        'Next
        'NotasRet.Add(NotaRet)
        'lblNotasRet.Text = CStr(NotasRet.Count)
        lblNotasRet.Visible = True
        lblNotRet.Visible = True
        dgvDetalle.Rows.Clear()
        lblGranTotal.Text = "0.00"
        ldGranTotal = 0
        txtArticulo.Text = ""
        txtArticulo.Focus()
        'MessageBox.Show("La nota se podrá recuperar con el identificador " + Nota.Id, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub retener()
        Try
            Dim NotaRetCab As New CN.NotasRentenerRecuperarCabClass
            NotaRetCab.NomId = txtArticulo.Text.Trim
            NotaRetCab.NumArticulos = dgvDetalle.RowCount
            NotaRetCab.Total = CDec(lblGranTotal.Text)
            NotaRetCab.Fecha = Date.Now
            NotaRetCab.CodUsuario = Controlador.Sesion.MiUsuario.Usrndx

            If Not NotaRetCab.Guardar() Then
                MessageBox.Show("No se retuvo la nota reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            Else
                For Each ren As DataGridViewRow In dgvDetalle.Rows

                    Dim NotaRetDet As New CN.NotasRentenerRecuperarDetClass
                    NotaRetDet.IdNota = NotaRetCab.Id
                    NotaRetDet.Consecutivo = ren.Index + 1
                    NotaRetDet.CodArticulo = CInt(ren.Cells(clmCodProducto.Index).Value)
                    Dim producto As New CN.ProductoGeneralClass(NotaRetDet.CodArticulo)
                    NotaRetDet.Cantidad = CDec(ren.Cells(clmCantidad.Index).Value)
                    NotaRetDet.PrecioUnitario = CDec(ren.Cells(clmPrecioUnit.Index).Value)
                    NotaRetDet.Descuento = CDec(ren.Cells(clmDescuento.Index).Value)
                    NotaRetDet.Iva = CDec(ren.Cells(clmIva.Index).Value)
                    NotaRetDet.Ieps = CDec(ren.Cells(clmIeps.Index).Value)
                    NotaRetDet.IdProdComp = CInt(ren.Cells(clmCodprodComp.Index).Value)
                    If producto.EsKit Then NotaRetDet.Eskit = True

                    If Not NotaRetDet.Guardar() Then
                        MessageBox.Show("No se retuvo la nota reintente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If


                Next
            End If
        
        




            'Dim str As String
            '' "insert into dbo.PVNotasVentaRetCab " &
            ''                    "values(" &
            ''                    "'" & txtArticulo.Text.Trim & "'" &
            ''                    "," & dgvDeMtalle.RowCount.ToString &
            ''                    "," & CDec(lblGranTotal.Text).ToString &
            ''                    ",(select getdate())" &
            ''                    "," & Controlador.Sesion.MiUsuario.Usrndx.ToString() &
            ''                    "); " &
            ''                    "SELECT CAST(scope_identity() AS int)"


            '    Dim cn As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
            '    cn.Open()
            '    Dim cmd As SqlCommand
            ''cmd.CommandType = CommandType.Text
            '    Dim ID As Integer = NotaRetCab.Id
            'Dim TotalRen As Integer = dgvDetalle.RowCount
            'str = "INSERT INTO dbo.PVNotasVentaRetDet VALUES "
            'For Each ren As DataGridViewRow In dgvDetalle.Rows
            '    If TotalRen = (ren.Index + 1) Then
            '        str &= "(" & ID.ToString & "," &
            '            (ren.Index + 1).ToString & "," &
            '            ren.Cells(clmCodProducto.Index).Value.ToString & "," &
            '            CDec(ren.Cells(clmCantidad.Index).Value).ToString &
            '            ")"
            '    Else
            '        str &= "(" & ID.ToString & "," &
            '            (ren.Index + 1).ToString & "," &
            '            ren.Cells(clmCodProducto.Index).Value.ToString & "," &
            '             CDec(ren.Cells(clmCantidad.Index).Value).ToString &
            '            "),"
            '    End If
            'Next

            'cmd = New SqlCommand(str, cn)
            'If cmd.ExecuteNonQuery = 0 Then
            '    MessageBox.Show("No se pudo guardar el detalle de la nota retenida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            cantArticulosRet()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub cantArticulosRet()
        Try
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.PvnotasVentaRetCabFields.CodUsuario = Controlador.Sesion.Usrndx)
            Dim notasretenidas As New CN.NotasRentenerRecuperarCabCollectionClass
            notasretenidas.Obtener(filtro)

            If notasretenidas.Count > 0 Then
                lblNotasRet.Text = (CInt(notasretenidas.Count))
                lblNotasRet.Visible = True
                lblNotRet.Visible = True
            Else
                lblNotasRet.Text = (0)
                lblNotasRet.Visible = False
                lblNotRet.Visible = False
            End If

            'Dim resultado As New DataSet()
            'Dim str As String = "select count(*) from dbo.PVNotasVentaRetCab where CodUsuario = " & Controlador.Sesion.MiUsuario.Usrndx.ToString()
            'Dim cmd As SqlCommand = New SqlCommand(str, New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
            'cmd.CommandType = CommandType.Text
            'Dim adapter As New SqlDataAdapter(cmd)
            'adapter.SelectCommand.CommandTimeout = 300

            'Dim DS As DataSet
            'adapter.Fill(resultado)
            'cmd.Dispose()

            'If CInt(resultado.Tables(0).Rows(0)(0)) > 0 Then
            '    lblNotasRet.Text = (CInt(resultado.Tables(0).Rows(0)(0)))
            '    lblNotasRet.Visible = True
            '    lblNotRet.Visible = True
            'Else
            '    lblNotasRet.Text = (0)
            '    lblNotasRet.Visible = False
            '    lblNotRet.Visible = False
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Public Sub ObtenerNotasRetenidas()
    '    Try
    '        Dim resultado As New DataSet()
    '        Dim str As String = "select * from dbo.PVNotasVentaRetCab"
    '        Dim cmd As SqlCommand = New SqlCommand(str, New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString))
    '        cmd.CommandType = CommandType.Text
    '        Dim adapter As New SqlDataAdapter(cmd)
    '        adapter.SelectCommand.CommandTimeout = 300

    '        Dim DS As DataSet
    '        adapter.Fill(resultado)
    '        cmd.Dispose()

    '        If resultado.Tables(0).Rows.Count > 0 Then

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try




    'End Sub

    Private Sub btnRecuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperar.Click
        'Dim vent1 As New frmNotasRet
        ''vent1.dgvNotasRet.DataSource = NotasRet
        'vent1.ShowDialog()
        'Return
        If dgvDetalle.RowCount > 0 Then
            MessageBox.Show("No se puede recuperar la nota porque hay artículos marcados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If CInt(lblNotasRet.Text) = 0 Then Return
        'Dim indice As Integer
        'If NotasRet.Count = 1 Then
        'indice = 0
        ' Else
        Dim vent As New frmNotasRet
        
        ' vent.dgvNotasRet.DataSource = NotasRet

        Dim result As DialogResult = vent.ShowDialog()
        Dim CodNota As Integer = vent.Indice
        vent.Close()
        vent.Dispose()
        Application.DoEvents()
        If result = Windows.Forms.DialogResult.OK Then
            'indice = vent.dgvNotasRet.CurrentRow.Index
            ' indice = vent.Indice
            Dim filtro As New OC.PredicateExpression
            filtro.Add(HC.PvnotasVentaRetCabFields.Id = CodNota)
            Dim NotaRetCab As New CN.NotasRentenerRecuperarCabCollectionClass
            NotaRetCab.Obtener(filtro)

            If NotaRetCab.Count > 0 Then
                Dim CodKit As Integer = -1
                For Each row As CN.NotasRentenerRecuperarDetClass In NotaRetCab(0).Detalle

                    If row.Eskit = True Then
                        ContKit += 1
                        CodKit = row.CodArticulo
                    End If

                    If row.IdProdComp = CodKit Then
                        dgvDetalle.Rows.Add(row.CodArticulo, row.Cantidad, row.Articulo.Descripcion, row.PrecioUnitario, row.PrecioUnitario, row.Descuento, row.Descuento, IIf(row.Articulo.SeAplicaIva, Controlador.ObtenerIVA(), 0), row.Iva, row.Iva, IIf(row.Articulo.PorcIEPS > 0, row.Articulo.PorcIEPS, 0), row.Ieps, row.Ieps, row.Cantidad * row.PrecioUnitario, ContKit, row.IdProdComp)

                        With dgvDetalle.Rows(dgvDetalle.RowCount - 1)
                            .ReadOnly = True
                            .DefaultCellStyle.BackColor = Drawing.Color.Gainsboro
                            .DefaultCellStyle.SelectionBackColor = Drawing.Color.DodgerBlue
                            .DefaultCellStyle.ForeColor = Drawing.Color.Black
                            .Cells(clmPrecioUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .Cells(clmIVAUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .Cells(clmIEPSUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .Cells(clmTotal.Index).Style.ForeColor = Drawing.Color.Gainsboro
                            .Cells(clmDesctoUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro

                            .Cells(clmPrecioUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .Cells(clmIVAUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .Cells(clmIEPSUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .Cells(clmTotal.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                            .Cells(clmDesctoUnit.Index).Style.SelectionForeColor = Drawing.Color.DodgerBlue
                        End With
                    Else
                        If row.Eskit Then
                            dgvDetalle.Rows.Add(row.CodArticulo, row.Cantidad, row.Articulo.Descripcion, row.PrecioUnitario, row.PrecioUnitario, row.Descuento, row.Descuento, 0, row.Iva, row.Iva, 0, row.Ieps, row.Ieps, row.Cantidad * row.PrecioUnitario, ContKit, Nothing)
                            With dgvDetalle.Rows(dgvDetalle.RowCount - 1)
                                .ReadOnly = True
                            End With
                        Else
                            dgvDetalle.Rows.Add(row.CodArticulo, row.Cantidad, row.Articulo.Descripcion, row.PrecioUnitario, row.PrecioUnitario, row.Descuento, row.Descuento, IIf(row.Articulo.SeAplicaIva, Controlador.ObtenerIVA(), 0), row.Iva, row.Iva, IIf(row.Articulo.PorcIEPS > 0, row.Articulo.PorcIEPS, 0), row.Ieps, row.Ieps, row.Cantidad * row.PrecioUnitario, 0, row.IdProdComp)
                        End If
                    End If




                    '.CurrentRow.DefaultCellStyle.BackColor = Drawing.Color.Gainsboro
                    '.CurrentRow.DefaultCellStyle.SelectionBackColor = Drawing.Color.DodgerBlue
                    '.CurrentRow.DefaultCellStyle.ForeColor = Drawing.Color.Black
                    '.CurrentRow.Cells(clmPrecioUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                    '.CurrentRow.Cells(clmIVAUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                    '.CurrentRow.Cells(clmIEPSUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro
                    '.CurrentRow.Cells(clmTotal.Index).Style.ForeColor = Drawing.Color.Gainsboro
                    '.CurrentRow.Cells(clmDesctoUnit.Index).Style.ForeColor = Drawing.Color.Gainsboro

                    'If row.IdProdComp <> 0 Then
                    '    dgvDetalle.Rows.Add(row.CodArticulo, row.Cantidad, row.Articulo.Descripcion, row.PrecioUnitario, row.PrecioUnitario, row.Descuento, row.Descuento, 0, row.Iva, row.Iva, 0, row.Ieps, row.Ieps, row.Cantidad * row.PrecioUnitario, ContKit, row.IdProdComp)
                    'Else
                    '    dgvDetalle.Rows.Add(row.CodArticulo, row.Cantidad, row.Articulo.Descripcion, row.PrecioUnitario, row.PrecioUnitario, row.Descuento, row.Descuento, 0, row.Iva, row.Iva, 0, row.Ieps, row.Ieps, row.Cantidad * row.PrecioUnitario, ContKit, row.IdProdComp)
                    'End If
                Next
                

                dgvDetalle.Refresh()
                lblGranTotal.Text = NotaRetCab(0).Total.ToString("N2")
                ldGranTotal = NotaRetCab(0).Total
            End If

            ''borrar detalle nota retenida
            For Each row As CN.NotasRentenerRecuperarDetClass In NotaRetCab(0).Detalle
                If Not row.Borrar() Then
                    MessageBox.Show("Error al eliminar detalle nota retenida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            ''borrar cabecero
            If Not NotaRetCab(0).Borrar() Then
                MessageBox.Show("Error al eliminar cabecero nota retenida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If



            'Dim resultado As New DataSet()
            'Dim str As String = "select D.IdNota,D.Consecutivo,D.CodArticulo,D.Cantidad from dbo.PVNotasVentaRetDet D " &
            '    "inner join dbo.PVNotasVentaRetCab C on C.Id = D.IdNota " &
            '    "where IdNota = " & CodNota.ToString & " and C.CodUsuario = " & Controlador.Sesion.MiUsuario.Usrndx.ToString()

            'Dim cmd As SqlCommand = New SqlCommand(str, New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))
            'cmd.CommandType = CommandType.Text

            'Dim adapter As New SqlDataAdapter(cmd)
            'adapter.SelectCommand.CommandTimeout = 300

            'Dim DS As DataSet
            'adapter.Fill(resultado)
            'Application.DoEvents()
            ' ''elimina la nota de venta de retenidas
            'str = "delete from dbo.PVNotasVentaRetDet " &
            '    "where IdNota = " & CodNota.ToString &
            '    "" & vbLf &
            '    " delete from dbo.PVNotasVentaRetCab " &
            '    "where Id = " & CodNota.ToString
            'Dim con As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)
            'con.Open()
            'cmd = New SqlCommand(str, con)

            'cmd.ExecuteNonQuery()
            'cmd.Dispose()
            'con.Close()
            'For Each row As DataRow In resultado.Tables(0).Rows
            '    Dim prod As New CN.ProductoGeneralClass(CInt(row("CodArticulo")))
            '    txtArticulo.Text = prod.CodigoBarra & "*" & row("Cantidad").ToString
            '    txtArticulo.Focus()
            '    Application.DoEvents()
            '    SendKeys.Send("{ENTER}")


            '    'txtArticulo_Leave(New Object(), Nothing)
            '    Application.DoEvents()
            'Next

            cantArticulosRet()
        Else
            Return
        End If

        ' cantArticulosRet()


        ' End If

        'Dim nr As NotaRetenida = NotasRet.Item(indice)
        'For Each ren As DataGridViewRow In nr.Renglones
        '    dgvDetalle.Rows.Add(ren)
        'Next
        'dgvDetalle.Refresh()
        'lblGranTotal.Text = Format(nr.Total, "N2")
        'ldGranTotal = nr.Total
        'NotasRet.RemoveAt(indice)
        'lblNotasRet.Text = CStr(NotasRet.Count)
        'If NotasRet.Count = 0 Then
        '    lblNotasRet.Visible = False
        '    lblNotRet.Visible = False
        'End If
        txtArticulo.Focus()
    End Sub

    Private Sub dgvDetalle_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEndEdit
        Select Case e.ColumnIndex
            Case 1      ' Cantidad
                CalculaRenglon()

            Case 4      ' Precio unitario
                With dgvDetalle
                    Dim ldImp As Decimal = .CurrentRow.Cells("clmPorcIva").Value + .CurrentRow.Cells("clmPorcIeps").Value
                    Dim PrecioVentaC As Decimal = .CurrentRow.Cells("clmPrecioUnit").Value
                    .CurrentRow.Cells("clmPrecioUnitSIva").Value = PrecioVentaC / (1 + ldImp / 100)
                    .CurrentRow.Cells("clmIvaUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * .CurrentRow.Cells("clmPorcIVA").Value / 100
                    .CurrentRow.Cells("clmIepsUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * .CurrentRow.Cells("clmPorcIEPS").Value / 100
                    .CurrentRow.Cells("clmIva").Value = .CurrentRow.Cells("clmIvaUnit").Value * .CurrentRow.Cells("clmCantidad").Value
                    .CurrentRow.Cells("clmIeps").Value = .CurrentRow.Cells("clmIepsUnit").Value * .CurrentRow.Cells("clmCantidad").Value
                    .CurrentRow.Cells("clmTotal").Value = (PrecioVentaC - .CurrentRow.Cells("clmDesctoUnit").Value) * .CurrentRow.Cells("clmCantidad").Value
                    Totaliza()
                    'Dim ldImp As Decimal = .CurrentRow.Cells("clmPorcIva").Value + .CurrentRow.Cells("clmPorcIeps").Value
                    'Dim PrecioVentaC As Decimal = .CurrentRow.Cells("clmPrecioUnit").Value
                    If MessageBox.Show("¿Desea actualizar la lista de precios con el nuevo precio?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        
                        '.CurrentRow.Cells("clmPrecioUnitSIva").Value = PrecioVentaC / (1 + ldImp / 100)
                        '.CurrentRow.Cells("clmIvaUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * .CurrentRow.Cells("clmPorcIVA").Value / 100
                        '.CurrentRow.Cells("clmIepsUnit").Value = .CurrentRow.Cells("clmPrecioUnitSIva").Value * .CurrentRow.Cells("clmPorcIEPS").Value / 100
                        '.CurrentRow.Cells("clmIva").Value = .CurrentRow.Cells("clmIvaUnit").Value * .CurrentRow.Cells("clmCantidad").Value
                        '.CurrentRow.Cells("clmIeps").Value = .CurrentRow.Cells("clmIepsUnit").Value * .CurrentRow.Cells("clmCantidad").Value
                        '.CurrentRow.Cells("clmTotal").Value = (PrecioVentaC - .CurrentRow.Cells("clmDesctoUnit").Value) * .CurrentRow.Cells("clmCantidad").Value
                        'Totaliza()

                        If ObtenerCosto(.CurrentRow.Cells(clmCodProducto.Index).Value) > .CurrentRow.Cells(clmPrecioUnit.Index).Value Then
                            If MessageBox.Show("Se detectó que el nuevo precio de venta del producto " & .CurrentRow.Cells(clmDescripcion.Index).Value.ToString & " es menor al precio de costo." & vbLf & "Costo: " & ObtenerCosto(.CurrentRow.Cells(clmCodProducto.Index).Value).ToString & "." & _
                                               vbLf & vbLf & "¿DESEA CONTINUAR?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                Try
                                    Dim Det As CN.ListaPrecioDetalleClass
                                    Det = lcListaPrecios.ObtenerDetalle(CInt(.CurrentRow.Cells("clmCodProducto").Value))
                                    If Not Det Is Nothing Then
                                        Det.PrecioVentaC = PrecioVentaC
                                        Det.Guardar()
                                    End If
                                Catch ex As Exception
                                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                                End Try
                            End If
                        Else
                            Try
                                Dim Det As CN.ListaPrecioDetalleClass
                                Det = lcListaPrecios.ObtenerDetalle(CInt(.CurrentRow.Cells("clmCodProducto").Value))
                                If Not Det Is Nothing Then
                                    Det.PrecioVentaC = PrecioVentaC
                                    Det.Guardar()
                                End If
                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                            End Try
                        End If
                        'Else
                        '    .CurrentRow.Cells("clmPrecioUnit").Value = precioAnt
                    End If
                End With
            Case 13
                With dgvDetalle
                    .CurrentRow.Cells(clmTotal.Index).Value = CDbl(.CurrentRow.Cells(clmTotal.Index).Value).ToString("N2")
                    Dim peso As Decimal = CDbl(.CurrentRow.Cells(clmTotal.Index).Value) / CDbl(.CurrentRow.Cells(clmPrecioUnit.Index).Value)
                    .CurrentRow.Cells(clmCantidad.Index).Value = peso.ToString("N3")
                    Totaliza()
                End With
        End Select
        txtArticulo.Focus()
    End Sub

    ''saber el costo del producto
    Public Function ObtenerCosto(ByVal Codprod As Integer) As Double
        Dim sucursal As New ClasesNegocio.SucursalClass(Utilerias.ObtenerCodSucursal)
        Dim sort As New SortExpression

        sort.Add(New SortClause(HC.InventarioAlmacenFields.Año, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        sort.Add(New SortClause(HC.InventarioAlmacenFields.Mes, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))



        'ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
        '            HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)
        Dim invs As New CC.InventarioAlmacenCollection

        invs.GetMulti(HC.InventarioAlmacenFields.AlmacenId = sucursal.IdAlmacen And _
                    HC.InventarioAlmacenFields.ProductoId = Codprod, 1, sort) 'And HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month, 1)

        If invs.Count > 0 Then
            Dim invAlmacen As New InventarioAlmacenEntity
            invAlmacen = invs(0)
            Return CDbl(invAlmacen.CostoPromedio)
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = CDbl(invAlmacen.CostoPromedio * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

        Else
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = 0D
            Return 0D
        End If

    End Function

    Private Sub btnCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidad.Click
        CapturaCantidad()
    End Sub

    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cellTextBox.KeyPress
        If Not (e.KeyChar < " " Or Char.IsDigit(e.KeyChar) Or e.KeyChar = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvDetalle_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvDetalle.CellValidating
        Select Case e.ColumnIndex
            Case 1      ' Cantidad
                If e.FormattedValue = "" Then e.Cancel = True
            Case 4      ' Precio Unitario
                If e.FormattedValue = "" Then e.Cancel = True

        End Select
    End Sub

    Private Sub dgvDetalle_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalle.EditingControlShowing
        ' Este evento se producirá cuando la celda pasa a modo de edición.
        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        If e.Control.GetType() Is GetType(DataGridViewTextBoxEditingControl) Then
            cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)
        End If
    End Sub

    Public Sub cargarlistapreciosMemoria()
        ' Este codigo se programa solo para forzar a que se carguen en memoria 
        ' todos los productos de la lista de precios
        txthistorial.Text += "Inicia carga de productos en memoria.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()
        Dim y As Integer

        For Each x As CN.ListaPrecioDetalleClass In lcListaPrecios.Detalle
            y = x.Producto.Codigo
        Next
        txthistorial.Text += "Termina carga de productos en memoria.. Hora: " & Now().ToString & vbLf
        Application.DoEvents()

    End Sub

    Private Sub frmNotaDeVenta_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Top = 0
        Me.Left = 0
        Me.Width = Me.Parent.Width - 4
        Me.Height = Me.Parent.Height - 35










        finload = True
        If cargacodSucursal = False Then
            Me.Close()
            Me.Dispose()
        End If

        If carganomimpresora = False Then
            Me.Close()
            Me.Dispose()
        End If


        'dgvDetalle.Dock = DockStyle.None
        'dgvDetalle.Width = GroupBox3.Width - 10
        'dgvDetalle.Height = (GroupBox3.Height - 15) - (dgvDetalle.ColumnHeadersHeight - 17)

        'Dim div As Integer = dgvDetalle.Height \ 40
        'Dim dif As Integer = (0.88 * div)
        ''Dim ent As Integer = div *
        'dgvDetalle.Height = (div * 40)
        'dgvDetalle.Refresh()
    End Sub

    '#Region "BackGroundWork"
    '    Private Sub bgwChecaDisposit_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgwChecaDisposit.DoWork
    '        ' Do not access the form's BackgroundWorker reference directly.
    '        ' Instead, use the reference provided by the sender parameter.
    '        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)

    '        ' Extract the argument.
    '        Dim arg As Integer = Fix(e.Argument)

    '        ' Start the time-consuming operation.
    '        e.Result = TimeConsumingOperation(bw, arg)

    '        ' If the operation was canceled by the user, 
    '        ' set the DoWorkEventArgs.Cancel property to true.
    '        If bw.CancellationPending Then
    '            e.Cancel = True
    '        End If

    '    End Sub

    '    ' This event handler demonstrates how to interpret 
    '    ' the outcome of the asynchronous operation implemented
    '    ' in the DoWork event handler.
    '    Private Sub bgwChecaDisposit_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles bgwChecaDisposit.RunWorkerCompleted

    '        If e.Cancelled Then
    '            ' The user canceled the operation.
    '            MessageBox.Show("Operation was canceled")
    '        ElseIf (e.Error IsNot Nothing) Then
    '            ' There was an error during the operation.
    '            Dim msg As String = String.Format("An error occurred: {0}", e.Error.Message)
    '            MessageBox.Show(msg)
    '        Else
    '            ' The operation completed normally.
    '            Dim msg As String = String.Format("Result = {0}", e.Result)
    '            MessageBox.Show(msg)
    '        End If
    '    End Sub

    '    ' This method models an operation that may take a long time 
    '    ' to run. It can be cancelled, it can raise an exception,
    '    ' or it can exit normally and return a result. These outcomes
    '    ' are chosen randomly.
    '    Private Function TimeConsumingOperation(ByVal bw As BackgroundWorker, ByVal sleepPeriod As Integer) As Integer
    '        Dim result As Integer = 0
    '        Dim rand As New Random()

    '        While Not bw.CancellationPending
    '            Dim [exit] As Boolean = False
    '            Select Case rand.Next(3)
    '                Case 0      ' Raise an exception.
    '                    Throw New Exception("An error condition occurred.")
    '                    Exit While
    '                Case 1      ' Sleep for the number of milliseconds specified by the sleepPeriod parameter.
    '                    Thread.Sleep(sleepPeriod)
    '                    Exit While
    '                Case 2      ' Exit and return normally.
    '                    result = 23
    '                    [exit] = True
    '                    Exit While
    '                Case Else
    '                    Exit While
    '            End Select

    '            If [exit] Then
    '                Exit While
    '            End If
    '        End While

    '        Return result
    '    End Function

    '    Private Sub startButton_Click(ByVal sender As Object, ByVal e As EventArgs) 'Handles startBtn.Click
    '        Me.bgwChecaDisposit.RunWorkerAsync(2000)
    '    End Sub

    '    Private Sub cancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) 'Handles cancelBtn.Click
    '        Me.bgwChecaDisposit.CancelAsync()
    '    End Sub

    '#End Region

    Private Sub btnRetiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetiro.Click
        Dim vent As New frmRetiroDeCaja("E")
        vent.ShowDialog()
    End Sub

    Private Sub TmrListaPrecios_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrListaPrecios.Tick
        'If Not lcListaPrecios.ObtenerVigente(Sucursal.Plaza.Codigo) Then
        '    Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        'End If
        'Dim lp As EC.ListaPrecioEntity = lcListaPrecios.ObtenerEntidad
        ''Dim lpx As New EC.ListaPrecioEntity(lcListaPrecios.ObtenerEntidad.Codigo)
        'lp.Refetch() 'Actualiza los valores de la base de datos, lo que aya cambiado lo trae otra vez
        'Dim listTemp As New CN.ListaPrecioClass
        'listTemp.ObtenerVigente(Sucursal.Plaza.Codigo)
        'If (listTemp Is lcListaPrecios) = False Then
        '    lcListaPrecios = listTemp
        'End If
        ' If lp.IsDirty Then
        If lcListaPrecios IsNot Nothing Then
            Dim bool As Boolean = lcListaPrecios.ActualizarLista()
        End If

        'lcListaPrecios = New CN.ListaPrecioClass(lp)
        'End If


        ' If UltimaHoraAct < lp.FechaCaptura Then
        ' lcListaPrecios.ObtenerVigente(Sucursal.Plaza.Codigo)  ' sustituir el uno por plaza cuando se programe plaza y sucursal para cajeros
        UltimaHoraAct = DateTime.Now
        'End If
    End Sub

    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngreso.Click
        Dim vent As New frmIngresoDeCaja("I")
        vent.ShowDialog()
    End Sub


    Private Sub btnCompras_Click(sender As System.Object, e As System.EventArgs) Handles btnCompras.Click
        'Abrir(New ClasesComunes.frmRecepcionesOrdenesDirectas())
        'Dim forma As New Forma(Of ClasesComunes.frmRecepcionesOrdenesDirectas)(Me)

        CType(Me.ParentForm, CN.iMainForm).LlamaForma(Of ClasesComunes.frmRecepcionesOrdenesDirectas)()
    End Sub

   

    Public Sub Cortez(Optional ByVal Autocerrar As Boolean = False)
        If MessageBox.Show("¿Realizar el corte Z?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Return
        End If
        Try
            ControlTurnoActual = Utilerias.ObtenerControlTurnoActual()
            ControlTurnoActual.FechaFin = DateTime.Now
            ''Manuel inostroza: no se estaba validando el guardado, se arreglo falla. 17/04/2015
            If Not ControlTurnoActual.Guardar() Then
                MsgBox("No se realizo corrrectamente el corte Z, reintente nuevamente.", MsgBoxStyle.Exclamation, "AVISO")
                Return
            End If





            Dim CorteZ As New DataSet
            'Dim consulta As String = "SELECT Count(Codigo) as Notas, Sum(SubTotal) as SubTotal, Sum(IVA) as IVA, Sum(IEPS) as IEPS, Sum(Total) as Total, Min(Codigo) as DelFolio, Max(Codigo) as AlFolio FROM MVentaNotasVenta " ' _
            '                       "Where Sucursal = " + "1" + " And UsuarioAlta = " + CStr(Controlador.Sesion.Usrndx) + " And Estatus = 1 And DateAdd(dd, 0, DateDiff(dd, 0, FechaVenta)) = '" + System.DateTime.Today() + "'"
            'consulta = consulta + "Where Sucursal = " + Sucursal.Codigo.ToString() + " And IdControlTurno = " + ControlTurnoActual.Id.ToString()
            Dim consulta As String = "execute dbo.Usp_MVtaImprimeCorte " + ControlTurnoActual.Id.ToString()
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()
                ad.Fill(CorteZ)
                ad.SelectCommand.Connection.Close()
            End Using
            Dim rep As New crCorteZTck
            rep.Subreports("Retiros").SetDataSource(CorteZ.Tables(1))
            rep.Subreports("Ingresos").SetDataSource(CorteZ.Tables(2))
            rep.SetDataSource(CorteZ.Tables(0))
            'rep.SetParameterValue("Sucursal", Sucursal.Descripcion)
            rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue("Fecha", System.DateTime.Today())
            rep.SetParameterValue("TipoCorte", "Z")
            'rep.SetParameterValue("ControlTurno", ControlTurnoActual.Id)
            ''Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
            rep.PrintToPrinter(1, False, 0, 0)


#If DEBUG Then
            '.....prueba del ticket visualmente
            'Dim Prev As New ClasesNegocio.PreVisualizarForm
            'Prev.Reporte = rep
            'Prev.Text = "TICKET"
            'Prev.ShowDialog()
#End If



            ControlTurnoActual = Nothing

            If Autocerrar = False Then
                rep.Dispose()
                Me.Close()
            End If





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If ControlTurnoActual IsNot Nothing Then
                ControlTurnoActual = Nothing
            End If
            If Autocerrar = False Then
                Me.Dispose()
            End If

        End Try
    End Sub

    Public Sub Cortex()
        Try
            'MsgBox(Controlador.fechaServidor.ToString, MsgBoxStyle.Exclamation, "FECHA")
            'Dim CorteX As New DataTable
            'Dim consulta As String = "SELECT Count(Codigo) as Notas,Sum(Total) as Total, Min(Codigo) as DelFolio, Max(Codigo) as AlFolio FROM MVentaNotasVenta " + _
            '                         "Where Sucursal = " + Sucursal.Codigo.ToString() + " And UsuarioAlta = " + CStr(Controlador.Sesion.Usrndx) + " And Estatus = 1 And DateAdd(dd, 0, DateDiff(dd, 0, FechaVenta)) = '" + System.DateTime.Today() + "'"
            'Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
            '            New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            '    ad.SelectCommand.Connection.Open()
            '    ad.Fill(CorteX)
            '    ad.SelectCommand.Connection.Close()
            'End Using
            'Dim rep As New crCorteXTck
            'rep.SetDataSource(CorteX)
            'rep.SetParameterValue("Sucursal", Sucursal.Descripcion)
            'rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
            'rep.PrintOptions.PrinterName = "TICKET"
            'rep.PrintToPrinter(1, False, 0, 0)

            Dim CorteX As New DataSet

            'Dim consulta As String = "SELECT Count(Codigo) as Notas, Sum(SubTotal) as SubTotal, Sum(IVA) as IVA, Sum(IEPS) as IEPS, Sum(Total) as Total, Min(Codigo) as DelFolio, Max(Codigo) as AlFolio FROM MVentaNotasVenta "
            'consulta = consulta + "Where Sucursal = " + Sucursal.Codigo.ToString() + " And IdControlTurno = " + ControlTurnoActual.Id.ToString()
            Dim consulta As String = "execute dbo.Usp_MVtaImprimeCorte " + ControlTurnoActual.Id.ToString()
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                        New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()
                ad.Fill(CorteX)
                ad.SelectCommand.Connection.Close()
            End Using

            Dim rep As New crCorteZTck
            rep.Subreports("Retiros").SetDataSource(CorteX.Tables(1))
            rep.Subreports("Ingresos").SetDataSource(CorteX.Tables(2))
            rep.SetDataSource(CorteX.Tables(0))
            'rep.Subreports("DetalleRetiros").SetDataSource(CorteX.Tables(1))
            ' Dim DataTable = (CorteX.Tables(1))

            'rep.SetParameterValue("Sucursal", Sucursal.Descripcion)
            rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue("Fecha", Controlador.fechaServidor)
            rep.SetParameterValue("TipoCorte", "X")
            'rep.SetParameterValue("ControlTurno", ControlTurnoActual.Id)
            ''Dim reg As RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\INTEGRALAB\", True)
            rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora.ToString
            rep.PrintToPrinter(1, False, 0, 0)
#If DEBUG Then
            '.....prueba del ticket visualmente
            Dim Prev As New ClasesNegocio.PreVisualizarForm
            Prev.Reporte = rep
            Prev.Text = "TICKET"
            Prev.ShowDialog()
#End If
            rep.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub dgvDetalle_RowLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.RowLeave
        dgvDetalle.EndEdit()
        dgvDetalle.Refresh()
        dgvDetalle.Parent.Refresh()
    End Sub


    'Private Sub dgvDetalle_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgvDetalle.RowsAdded

    '    'If dgvDetalle.Controls(1).Enabled Then
    '    '    dgvDetalle.Dock = DockStyle.None
    '    '    dgvDetalle.Height = 300
    '    '    dgvDetalle.Width = 650
    '    '    dgvDetalle.Refresh()
    '    'End If
    '    'If (dgvDetalle.RowCount * 44) > dgvDetalle.Height Then
    '    '    dgvDetalle.Dock = DockStyle.None
    '    '    dgvDetalle.Height = dgvDetalle.RowCount * 44
    '    '    'dgvDetalle.Width = 650
    '    '    dgvDetalle.Refresh()
    '    '    dgvDetalle.Dock = DockStyle.Fill
    '    'End If

    '    If True Then

    '    End If



    'End Sub




    Private Sub frmNotaDeVenta_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If finload Then
            Dim NListaPrecios As New CN.ListaPrecioClass(1)
            'lcListaPrecios = New CN.ListaPrecioClass(1)
            If NListaPrecios.Detalle.Count > lcListaPrecios.Detalle.Count Then
                lcListaPrecios = NListaPrecios
                If (So_Info.Version.Major = 5 And So_Info.Version.Minor = 1) Or So_Info.Version.Major < 5 Then
                    cargarlistapreciosMemoria()
                ElseIf So_Info.Version.Major = 6 And So_Info.Version.Minor = 1 Then
                    hilo2 = New Thread(AddressOf cargarlistapreciosMemoria) 'Crear el hilo 2
                    hilo2.Start()
                    hilo2.Join()
                End If
            End If


        End If
    End Sub



    Private Sub btnAltRap_Click(sender As System.Object, e As System.EventArgs) Handles btnAltRap.Click
        ''CType(Me.ParentForm, CN.iMainForm).LlamaForma(Of ClasesComunes.frmAltaRapidaProdGen)()
        Dim forma As New ClasesComunes.frmAltaRapidaProdGen
        forma.StartPosition = FormStartPosition.CenterScreen
        If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtArticulo.Focus()
        Else
            Me.txtArticulo.Focus()
        End If
        Dim NListaPrecios As New CN.ListaPrecioClass(1)
        lcListaPrecios = NListaPrecios
        'If NListaPrecios.Detalle.Count > lcListaPrecios.Detalle.Count Then
        '    lcListaPrecios = NListaPrecios
        '    If (So_Info.Version.Major = 5 And So_Info.Version.Minor = 1) Or So_Info.Version.Major < 5 Then
        '        cargarlistapreciosMemoria()
        '    ElseIf So_Info.Version.Major = 6 And So_Info.Version.Minor = 1 Then
        '        hilo2 = New Thread(AddressOf cargarlistapreciosMemoria) 'Crear el hilo 2
        '        hilo2.Start()
        '        hilo2.Join()
        '    End If
        'End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnAyuda.Click
        Dim forma As New ClasesComunes.frmAyudaPV()
        forma.StartPosition = FormStartPosition.CenterScreen
        If forma.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtArticulo.Focus()
        Else
            Me.txtArticulo.Focus()
        End If


    End Sub

    Private Sub btnAbrirCajon_Click(sender As System.Object, e As System.EventArgs) Handles btnAbrirCajon.Click
        Dim s As String
        Dim pd As New PrintDialog()
        's = Chr(27) + Chr(112) + Chr(0) + Chr(50) + Chr(250)
        s = vbFormFeed
        pd.PrinterSettings = New PrinterSettings()
        RawPrinterHelper.SendStringToPrinter(Utilerias.ObtenerNomImpresora, s)
        'RawPrinterHelper.SendStringToPrinter("TICKET", s)
    End Sub


    Private Sub dgvDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellContentClick

    End Sub


    Private Sub txtBuscar_Click(sender As System.Object, e As System.EventArgs) Handles txtBuscar.Click
        Dim busqNotas As New frmBusqNotasVenta()
        busqNotas.ShowDialog()
    End Sub


    Private Sub btnReimprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnReimprimir.Click
        If CodNotaVentaTemp <> 0 Then ReImprimir(CodNotaVentaTemp, "Reimpresión")
    End Sub

    Private Sub dgvDetalle_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalle.CellEnter
        If 4 = e.ColumnIndex And e.RowIndex >= 0 Then
            precioAnt = dgvDetalle.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        End If
    End Sub

    Private Sub btnCobrar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles btnCobrar.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cobrarDirecto = False
        End Select
    End Sub

    Private Sub txtArticulo_Enter(sender As System.Object, e As System.EventArgs) Handles txtArticulo.Enter
        contador = 0
    End Sub
End Class
