Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesComunes
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.SqlClient

Public Class FrmABCClientes

#Region "Miembros"
    Dim tipoclientes = New ClasesNegocio.tiposclienteCollectionClass
    Dim Cliente As CN.ClientesIntroductoresClass
    Dim EstadosC As CN.EstadoCollectionClass
    Dim CiudadesC As CN.CiudadCollectionClass
    Dim PoblacionesC As CN.PoblacionCollectionClass
    Dim EstadosCFisc As CN.EstadoCollectionClass
    Dim CiudadesCFisc As CN.CiudadCollectionClass
    Dim PoblacionesCFisc As CN.PoblacionCollectionClass
    Dim Vendedores As CN.VendedorCollectionClass
    Private ClientesCol As CN.ClientesIntroductoresColeccion
    Private WithEvents CuentaCont As CN.CuentaContableClass
    Private WithEvents CuentaAnt As CN.CuentaContableClass
    Private WithEvents CuentaVenta As CN.CuentaContableClass
    Dim DiasCredito As Integer
    Dim Estatus As CN.FormState
    'Dim bit As CN.BitacoraPV
    Dim bandera As Boolean = False
#End Region

#Region "Load"
    Private Sub FrmABCClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgvDomicilios.AutoGenerateColumns = False
            bandera = False
            pbLogo.BorderStyle = BorderStyle.FixedSingle
            Dim tol As New ToolTip()
            tol.SetToolTip(lblBorrar, "Clic para borrar logo")

            Dim tt As New ToolTip()
            tt.SetToolTip(pbLogo, "Doble clic para agregar logo")
            'pbLogo.Image = DibujarTexto("Sin logo", New Drawing.Font("Arial", 8.5, FontStyle.Regular), Color.Black, Color.Transparent)
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados

            mtb.sbCambiarEstadoBotones("Cancelar")

            Me.CmbEstado.DisplayMember = "Descripcion"
            Me.CmbEstado.ValueMember = "Codigo"
            Me.CmbEstado.SelectedIndex = -1
            EstadosC = New CN.EstadoCollectionClass
            EstadosC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            CmbEstado.DataSource = EstadosC
            Me.CmbEstado.SelectedIndex = -1

            Me.cmbEstadoFisc.DisplayMember = "Descripcion"
            Me.cmbEstadoFisc.ValueMember = "Codigo"
            Me.EstadosCFisc = New CN.EstadoCollectionClass
            Me.EstadosCFisc.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbEstadoFisc.DataSource = EstadosCFisc
            Me.cmbEstadoFisc.SelectedIndex = -1

            Me.cmbDiasPago.DataSource = New ColeccionDias
            Me.cmbDiasRevision.DataSource = New ColeccionDias

            Me.cmbTipoFacturacion.DataSource = New ColeccionTipoFacturacion

            Me.cmbVendedor.DisplayMember = "NombreCompleto"
            Me.cmbVendedor.ValueMember = "Codigo"
            Vendedores = New CN.VendedorCollectionClass
            Vendedores.Obtener(Integra.Clases.CondicionEnum.ACTIVOS)
            Me.cmbVendedor.DataSource = Vendedores

            Me.cmbtipocliente.DisplayMember = "Descripcion"
            Me.cmbtipocliente.ValueMember = "Codigo"
            tipoclientes = New ClasesNegocio.tiposclienteCollectionClass
            tipoclientes.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbtipocliente.DataSource = tipoclientes

            llenarDepartamentos(True)


            llenarUsoCFDISAT()
            llenarFormasPago()

            'ClientesCol = New CN.ClientesIntroductoresColeccion
            'ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)

            'Me.dgvClientes.AutoGenerateColumns = False
            'Me.dgvClientes.DataSource = ClientesCol

            limpiar()
            DesHabilitar()
            bandera = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub llenarDepartamentos(ByVal tof As Boolean)
        Dim query As String = ""
        Dim tb As New DataTable
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
        query = "SELECT Cve_Depto, Nom_Depto" &
               " FROM CatDeptos"

        tb.Columns.Add("Nom_Depto")
        Dim dr As DataRow = tb.NewRow

        cmbDepartamento.DisplayMember = "Nom_Depto"
        cmbDepartamento.ValueMember = "Cve_Depto"

        Using sqlcom As New SqlCommand(query, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)
            sqlCon.Open()
            adp.Fill(tb)
            cmbDepartamento.DataSource = tb

            sqlCon.Close()
            cmbDepartamento.SelectedValue = -1
        End Using


    End Sub
    Public Sub llenarFormasPago()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave+'-'+Concepto as Concepto from CatFormasPagoSAT order by Clave"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            cmbFormaPago.DataSource = ds.Tables(0)
            cmbFormaPago.ValueMember = "Clave"
            cmbFormaPago.DisplayMember = "Concepto"
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los formas de pago ")
        End Try
    End Sub

    Public Sub llenarUsoCFDISAT()
        Dim connetionString As String = Nothing
        Dim connection As SqlConnection
        Dim command As SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Dim sql As String = Nothing
        connetionString = "Data Source=ServerName;Initial Catalog=databasename;User ID=userid;Password=yourpassword"
        sql = "select Clave,Clave +'-'+Concepto as Concepto from UsoCFDISAT order by 1"
        connection = New SqlConnection(HC.DbUtils.ActualConnectionString)
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            cmbUsoCFDI.DataSource = ds.Tables(0)
            cmbUsoCFDI.ValueMember = "Clave"
            cmbUsoCFDI.DisplayMember = "Concepto"
            'cmbUsoCFDI.ValueType = GetType(String)
            'connection.Close()
            connection.Dispose()
        Catch ex As Exception
            MessageBox.Show("Problema en llenar los uso de cfdi sat ")
        End Try
    End Sub
#End Region

#Region "Clases"
    Public Class ColeccionDias
        Inherits System.ComponentModel.BindingList(Of CN.DiasEnum)

        Sub New()
            For i As Integer = 1 To 6
                Add(i)
            Next
        End Sub
    End Class
    Public Class ColeccionTipoFacturacion
        Inherits System.ComponentModel.BindingList(Of CN.CondicionTipoVentaEnum)
        Sub New()
            For i As Integer = 0 To 2
                Add(i)
            Next
        End Sub
    End Class
#End Region

#Region "Metodos"
    Private Sub limpiar()
        Vendedores.Obtener(Integra.Clases.CondicionEnum.ACTIVOS)
        Me.pktxtCodigo.Text = ""
        Me.txtDomicilio.Text = ""
        Me.txtCodigoPostal.Text = ""
        Me.txtColonia.Text = ""
        Me.txtColoniaFisc.Text = ""
        Me.txtCPfiscal.Text = ""
        Me.txtCtaAnticipo.Text = ""
        Me.txtCtaContable.Text = ""
        Me.txtDiasCred.Text = "0"
        Me.txtCalleFisc.Text = ""
        Me.txtNoExtFisc.Text = ""
        Me.txtNoIntFisc.Text = ""
        Me.txtEmail.Text = ""
        Me.txtFax.Text = ""
        Me.txtLimiteCred.Text = "0"
        Me.txtNombre.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtTelCel.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtTelefonoFisc.Text = ""
        Me.txtCtaVenta.Text = ""
        Me.DateTimePicker1.Text = ""
        Me.txtRfc.Text = ""
        Me.CmbEstado.SelectedIndex = -1
        Me.CmbEstado.Text = "Seleccione un Estado"
        Me.cmbEstadoFisc.SelectedIndex = -1
        Me.cmbEstadoFisc.Text = "Seleccione un Estado"
        Me.cmbDiasPago.SelectedIndex = -1
        Me.cmbDiasPago.Text = "Seleccione un Día"
        Me.cmbDiasRevision.SelectedIndex = -1
        Me.cmbDiasRevision.Text = "Seleccione un Día"
        Me.cmbTipoFacturacion.SelectedIndex = -1
        Me.cmbTipoFacturacion.Text = "Seleccioe un Tipo de Facturación"
        Me.cmbVendedor.SelectedIndex = -1
        Me.cmbVendedor.Text = "Seleccione un Vendedor"
        'Me.dgvClientes.DataSource = Nothing
        Me.lblEstatus.Text = ""
        Me.lblEstatus.Visible = False
        Me.chkIntroductor.Checked = False
        Me.RbtnPersonaFisica.Checked = False
        Me.RbtnPersonaMoral.Checked = True
        Me.chkPrincipal.Checked = False
        dgvDomicilios.DataSource = Nothing
        Me.pbLogo.Image = Nothing
        Me.pbLogo.Tag = Nothing
        cmbtipocliente.SelectedIndex = -1
        cmbtipocliente.Text = "Seleccione el tipo de cliente..."
        rdtcanaldis.Checked = True
        cmbUsoCFDI.SelectedValue = "P01"
        cmbFormaPago.SelectedValue = "99"
    End Sub

    Private Sub LimpiarCamposDomicilioFiscal()
        Me.txtCalleFisc.ResetText()
        Me.txtNoExtFisc.ResetText()
        Me.txtNoIntFisc.ResetText()
        Me.txtColoniaFisc.ResetText()
        Me.txtTelefonoFisc.ResetText()
        Me.txtTelCel.ResetText()
        Me.txtEmail.ResetText()
        Me.txtCPfiscal.ResetText()
        Me.txtFax.ResetText()
        Me.chkPrincipal.Checked = False
        Me.cmbEstadoFisc.SelectedIndex = -1
        Me.cmbEstadoFisc.Text = "Seleccione un Estado"
    End Sub

    Private Sub Habilitar()
        Me.txtCodigoPostal.Enabled = True
        Me.txtColonia.Enabled = True
        Me.txtCtaAnticipo.Enabled = True
        Me.txtCtaContable.Enabled = True
        Me.txtDiasCred.Enabled = True
        Me.txtDomicilio.Enabled = True
        Me.txtLimiteCred.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtRazonSocial.Enabled = True
        Me.txtRfc.Enabled = True
        Me.btnCtaVenta.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.CmbEstado.Enabled = True
        Me.CmbCiudades.Enabled = True
        Me.CmbPoblaciones.Enabled = True
        Me.cmbDiasPago.Enabled = True
        Me.cmbDiasRevision.Enabled = True
        Me.cmbTipoFacturacion.Enabled = True
        Me.chkIntroductor.Enabled = True
        Me.RbtnPersonaFisica.Enabled = True
        Me.RbtnPersonaMoral.Enabled = True
        Me.btnCtaAnticipo.Enabled = True
        Me.btnCtaContable.Enabled = True
        Me.cmbVendedor.Enabled = True
        Me.cmbPasarInformacion.Enabled = True
        Me.btnCrearDomicilio.Enabled = True
        Me.txtCtaContable.Enabled = True
        Me.txtColoniaFisc.Enabled = True
        Me.txtCPfiscal.Enabled = True
        Me.txtCalleFisc.Enabled = True
        Me.txtNoExtFisc.Enabled = True
        Me.txtNoIntFisc.Enabled = True
        Me.txtEmail.Enabled = True
        Me.txtFax.Enabled = True
        Me.txtTelCel.Enabled = True
        Me.txtTelefonoFisc.Enabled = True
        Me.cmbEstadoFisc.Enabled = True
        Me.cmbCiudadFisc.Enabled = True
        Me.cmbPoblacionFisc.Enabled = True
        Me.chkPrincipal.Enabled = True
        Me.pbLogo.Enabled = True
        Me.lblBorrar.Enabled = True
        Me.cmbtipocliente.Enabled = True
        Me.rdtcanaldis.Enabled = True
        Me.rdtcanaldis2.Enabled = True
        Me.cmbUsoCFDI.Enabled = True
        Me.cmbFormaPago.Enabled = True
    End Sub

    'Private Sub Modo(ByVal Edicion As Boolean)
    '    Me.txtColoniaFisc.Enabled = Edicion
    '    Me.txtCPfiscal.Enabled = Edicion
    '    Me.txtDomicilioFisc.Enabled = Edicion
    '    Me.txtEmail.Enabled = Edicion
    '    Me.txtFax.Enabled = Edicion
    '    Me.txtTelCel.Enabled = Edicion
    '    Me.txtTelefonoFisc.Enabled = Edicion
    '    Me.cmbEstadoFisc.Enabled = Edicion
    '    Me.cmbCiudadFisc.Enabled = Edicion
    '    Me.cmbPoblacionFisc.Enabled = Edicion
    '    Me.chkPrincipal.Enabled = Edicion
    'End Sub

    Private Sub DesHabilitar()
        Me.txtCodigoPostal.Enabled = False
        Me.txtColonia.Enabled = False
        Me.txtColoniaFisc.Enabled = False
        Me.txtCtaContable.Enabled = False
        Me.txtCPfiscal.Enabled = False
        Me.txtCtaAnticipo.Enabled = False
        Me.txtCtaContable.Enabled = False
        Me.txtDiasCred.Enabled = False
        Me.txtDomicilio.Enabled = False
        Me.txtCalleFisc.Enabled = False
        Me.txtNoExtFisc.Enabled = False
        Me.txtNoIntFisc.Enabled = False
        Me.txtEmail.Enabled = False
        Me.txtFax.Enabled = False
        Me.btnCtaVenta.Enabled = False
        Me.txtLimiteCred.Enabled = False
        Me.txtNombre.Enabled = False
        Me.txtRazonSocial.Enabled = False
        Me.txtRfc.Enabled = False
        Me.txtTelCel.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtTelefonoFisc.Enabled = False
        Me.cmbEstadoFisc.Enabled = False
        Me.CmbEstado.Enabled = False
        Me.CmbCiudades.Enabled = False
        Me.cmbCiudadFisc.Enabled = False
        Me.CmbPoblaciones.Enabled = False
        Me.cmbPoblacionFisc.Enabled = False
        Me.cmbDiasPago.Enabled = False
        Me.cmbDiasRevision.Enabled = False
        Me.cmbTipoFacturacion.Enabled = False
        Me.chkIntroductor.Enabled = False
        Me.RbtnPersonaFisica.Enabled = False
        Me.RbtnPersonaMoral.Enabled = False
        Me.btnCtaAnticipo.Enabled = False
        Me.btnCtaContable.Enabled = False
        Me.cmbVendedor.Enabled = False
        Me.btnCrearDomicilio.Enabled = False
        Me.chkPrincipal.Enabled = False
        Me.btnCrearDomicilio.Enabled = False
        Me.btnEditarDomicilio.Enabled = False
        Me.cmbPasarInformacion.Enabled = False
        Me.pbLogo.Enabled = False
        Me.lblBorrar.Enabled = False
        Me.cmbtipocliente.Enabled = False
        Me.rdtcanaldis.Enabled = False
        Me.rdtcanaldis2.Enabled = False
        Me.cmbUsoCFDI.Enabled = False
        Me.cmbFormaPago.Enabled = False
    End Sub

    Private Sub EstablecerDatos()
        Try
            Me.Cliente.CodigoPostal = Me.txtCodigoPostal.Text
            Me.Cliente.DiasCredito = Me.txtDiasCred.Text
            Me.Cliente.DiasPago = Me.cmbDiasPago.Text
            Me.Cliente.DiasRevision = Me.cmbDiasRevision.Text
            Me.Cliente.Domicilio = Me.txtDomicilio.Text
            Me.Cliente.FechaAlta = Me.DateTimePicker1.Value
            Me.Cliente.IdEstado = Me.CmbEstado.SelectedValue
            Me.Cliente.IdCiudad = Me.CmbCiudades.SelectedValue
            Me.Cliente.IdPoblacion = Me.CmbPoblaciones.SelectedValue
            Me.Cliente.Introductor = Me.chkIntroductor.Checked
            Me.Cliente.LimiteCredito = Me.txtLimiteCred.Text
            Me.Cliente.Nombre = Me.txtNombre.Text
            Me.Cliente.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
            Me.Cliente.Colonia = Me.txtColonia.Text
            Me.Cliente.RFC = Me.txtRfc.Text
            Me.Cliente.Telefono = Me.txtTelefono.Text
            Me.Cliente.TipoFacturacion = Me.cmbTipoFacturacion.SelectedValue
            Me.Cliente.EsPersonaFisica = RbtnPersonaFisica.Checked
            Me.Cliente.RazonSocial = IIf(txtRazonSocial.Text.Trim <> String.Empty, txtRazonSocial.Text.Trim, txtNombre.Text.Trim)
            Me.Cliente.Idtipocliente = Me.cmbtipocliente.SelectedValue
            If rdtcanaldis.Checked Then
                Me.Cliente.canaldistribucion = "MAYOREO"
            Else
                Me.Cliente.canaldistribucion = "DETALLE"
            End If

            If Me.txtCtaVenta.Text <> "" Then
                Cliente.Idcuentaventa = CuentaVenta.Codigo
            End If

            If Me.txtCtaContable.Text <> "" Then
                Me.Cliente.CuentaContableId = CuentaCont.Codigo
            End If

            If Me.txtCtaAnticipo.Text <> "" Then
                Me.Cliente.CuentaAntiId = CuentaAnt.Codigo
            End If

            If Me.cmbVendedor.SelectedValue <> Nothing Then
                Me.Cliente.IdVendedor = Me.cmbVendedor.SelectedValue
            End If

            ' If Not IsNothing(pbLogo.Tag) Then
            If Not IsNothing(pbLogo.Image) Then
                If Not IsNothing(pbLogo.Tag) Then
                    If Not pbLogo.Tag.ToString().Equals("") Then
                        Dim picStream As New MemoryStream


                        pbLogo.Image.Save(picStream, pbLogo.Image.RawFormat)

                        'If pbLogo.Tag.ToString().Equals("jpg") Then
                        '    pbLogo.Image.Save(picStream, ImageFormat.Jpeg)
                        'Else
                        '    pbLogo.Image.Save(picStream, ImageFormat.Bmp)
                        'End If
                        Dim PicByte As Byte() = picStream.ToArray
                        Me.Cliente.Logo = PicByte
                    End If
                End If
            Else
                Cliente.Logo = Nothing
            End If

            Cliente.UsoCFDI = cmbUsoCFDI.SelectedValue.ToString().Trim()
            Cliente.FormaPago = cmbFormaPago.SelectedValue.ToString().Trim()
            'End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PonerDatos()
        Try
            Me.pktxtCodigo.Text = Me.Cliente.Codigo
            If Not Cliente.CodigoPostal = "" Then
                Me.txtCodigoPostal.Text = Me.Cliente.CodigoPostal
            End If
            Me.txtDiasCred.Text = Me.Cliente.DiasCredito
            DiasCredito = Me.Cliente.DiasCredito
            Me.cmbDiasPago.Text = Me.Cliente.DiasPago
            Me.cmbDiasRevision.Text = Me.Cliente.DiasRevision
            Me.txtDomicilio.Text = Me.Cliente.Domicilio
            Me.txtColonia.Text = Cliente.Colonia
            Me.DateTimePicker1.Value = Me.Cliente.FechaAlta
            Me.CmbEstado.SelectedValue = Me.Cliente.Estado.Codigo
            Me.CmbCiudades.SelectedValue = Me.Cliente.Ciudad.Codigo
            Me.CmbPoblaciones.SelectedValue = Me.Cliente.IdPoblacion
            Me.chkIntroductor.Checked = Me.Cliente.Introductor
            Me.txtLimiteCred.Text = CDec(Me.Cliente.LimiteCredito).ToString("C2")
            Me.txtNombre.Text = Me.Cliente.Nombre
            Me.txtRfc.Text = Me.Cliente.RFC
            Me.txtRazonSocial.Text = Me.Cliente.RazonSocial
            Me.txtTelefono.Text = Me.Cliente.Telefono
            Me.cmbTipoFacturacion.SelectedIndex = Me.Cliente.TipoFacturacion
            Me.cmbDiasPago.Text = Me.Cliente.DiasPago
            Me.cmbDiasRevision.Text = Me.Cliente.DiasRevision
            Me.cmbtipocliente.SelectedValue = Me.Cliente.Idtipocliente


            If Cliente.canaldistribucion.Trim().Equals("MAYOREO") Then
                rdtcanaldis.Checked = True
            Else
                rdtcanaldis2.Checked = True
            End If



            If Me.Cliente.EsPersonaFisica Then
                Me.RbtnPersonaFisica.Checked = True
            Else
                Me.RbtnPersonaMoral.Checked = True
            End If

            If Not CuentaAnt Is Nothing Then
                Me.txtCtaAnticipo.Text = String.Format("{0} : {1}", Me.CuentaAnt.NombreCuenta, Me.CuentaAnt.CuentaContable)
            End If

            If Not CuentaCont Is Nothing Then
                Me.txtCtaContable.Text = String.Format("{0} : {1}", CuentaCont.NombreCuenta, CuentaCont.CuentaContable)
            End If

            If Not CuentaVenta Is Nothing Then
                Me.txtCtaVenta.Text = String.Format("{0} : {1}", CuentaVenta.NombreCuenta, CuentaVenta.CuentaContable)
            End If

            dgvDomicilios.DataSource = Cliente.DomiciliosFiscales

            Me.lblEstatus.Text = Cliente.Estatus.ToString
            Me.lblEstatus.Visible = True
            If Not Me.Cliente.Vendedor.Codigo = 0 Then
                If Me.Cliente.Vendedor.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                    Vendedores.Obtener(Integra.Clases.CondicionEnum.TODOS)
                End If
                Me.cmbVendedor.SelectedValue = Me.Cliente.IdVendedor
            Else
                Me.cmbVendedor.SelectedIndex = -1
                Me.cmbVendedor.Text = "Seleccione un Vendedor"
            End If
            If Me.Cliente.Logo.Length > 0 Then
                Dim ms As MemoryStream = New MemoryStream(Me.Cliente.Logo)
                Me.pbLogo.Image = Image.FromStream(ms)
            End If

            cmbUsoCFDI.SelectedValue = Cliente.UsoCFDI
            cmbFormaPago.SelectedValue = Cliente.FormaPago


        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            Dim Mensaje As New System.Text.StringBuilder()

            If Me.txtNombre.Text.Trim = "" Then Mensaje.AppendLine("*Nombre")
            If Me.txtRazonSocial.Text.Trim = "" Then Mensaje.AppendLine("*Razon Social/Nombre Fiscal")
            If Me.txtDomicilio.Text.Trim = "" Then Mensaje.AppendLine("*Domicilio")
            If Me.txtColonia.Text.Trim = "" Then Mensaje.AppendLine("*Colonia")
            If Me.CmbEstado.SelectedValue Is Nothing Then Mensaje.AppendLine("*Estado")
            If Me.cmbtipocliente.SelectedValue Is Nothing Then Mensaje.AppendLine("*tipo de cliente")
            If Me.CmbCiudades.SelectedValue Is Nothing Then Mensaje.AppendLine("*Ciudad")
            If Me.CmbPoblaciones.SelectedValue Is Nothing Then Mensaje.AppendLine("*Poblacion")
            If Me.txtRfc.Text.Trim = String.Empty OrElse Not ValidateRFC(txtRfc.Text.Trim) Then Mensaje.AppendLine("*RFC")
            If Me.txtCodigoPostal.Text.Trim = "" Then Mensaje.AppendLine("*Codigo Postal")



            If Mensaje.ToString() <> String.Empty Then
                TabControl1.SelectedTab = TbpDatosGen
                Mensaje.Insert(0, New System.Text.StringBuilder().AppendLine("En la seccion de " & TbpDatosGen.Text & ", debe especificar los siguientes datos correctamente:"))
                'Throw New Exception(Mensaje.ToString())
                MessageBox.Show(Mensaje.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If


            'If Not Me.txtLimiteCred.Text > 0 Then
            '    MsgBox("Ingrese una cantidad mayor que cero para el limite de crédito", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.txtLimiteCred.Focus()
            '    Return False
            'End If

            'If Not Me.txtDiasCred.Text > 0 Then
            '    MsgBox("Ingrese una cantidad mayor que cero en los días crédito", MsgBoxStyle.Exclamation, "Aviso")
            '    Me.txtDiasCred.Focus()
            '    Return False
            'End If
            'If Me.txtCodigoPostal.Text = "" Then
            '    MessageBox.Show("Ingrese el codigo postal", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtCodigoPostal.Focus()
            '    Return False
            'End If
            'If Me.txtTelefono.Text = "" Then
            '    MessageBox.Show("Ingrese el número de telefono", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtTelefono.Focus()
            '    Return False
            'End If
            'If Me.txtCtaContable.Text = "" Then
            '    MessageBox.Show("Seleccione una cuenta contable", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.btnCtaContable.Focus()
            '    Return False
            'End If
            'If Me.txtCtaAnticipo.Text = "" Then
            '    MessageBox.Show("Seleccione la cuenta de anticipo", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.btnCtaAnticipo.Focus()
            '    Return False
            'End If
            'If Me.txtLimiteCred.Text = "" Then
            '    MessageBox.Show("Ingrese el limite de crédito", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtLimiteCred.Focus()
            '    Return False
            'End If
            'If Me.txtDiasCred.Text = "" Then
            '    MessageBox.Show("Ingrese el número de dias de crédito para el cliente", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtDiasCred.Focus()
            '    Return False
            'End If
            'If Me.cmbTipoFacturacion.SelectedIndex = -1 Then
            '    MessageBox.Show("Seleccione un tipo de Facturación", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cmbTipoFacturacion.Focus()
            '    Return False
            'End If
            'If Me.cmbDiasPago.SelectedIndex = -1 Then
            '    MessageBox.Show("Seleccione el día de pago del cliente", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cmbDiasPago.Focus()
            '    Return False
            'End If
            'If Me.cmbDiasRevision.SelectedIndex = -1 Then
            '    MessageBox.Show("Seleccione el día de revisión", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.cmbDiasRevision.Focus()
            '    Return False
            'End If
            'If Me.txtRazonSocial.Text = "" Then
            '    MessageBox.Show("Ingrese la Razon Social del Cliente", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtRazonSocial.Focus()
            '    Return False
            'End If
            'If Me.txtRfc.Text = "" Then
            '    MessageBox.Show("Ingrese el RFC del Cliente", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Me.txtRazonSocial.Focus()
            '    Return False
            'End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom.Trim & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Function ValidarDatosFiscales() As Boolean
        If dgvDomicilios.RowCount > 0 Then
            Return True
        Else

            Dim Mensaje As New System.Text.StringBuilder()

            If txtCalleFisc.Text.Trim = "" Then Mensaje.AppendLine("*Calle")
            If cmbEstadoFisc.SelectedValue Is Nothing Then Mensaje.AppendLine("*Estado")
            If cmbCiudadFisc.SelectedValue Is Nothing Then Mensaje.AppendLine("*Ciudad")
            If txtCPfiscal.Text.Trim = "" Then Mensaje.AppendLine("*Codigo Postal")

            If Mensaje.ToString() <> String.Empty Then
                TabControl1.SelectedTab = TbpDatosFiscales
                Mensaje.Insert(0, New System.Text.StringBuilder().AppendLine("En la seccion de " & TbpDatosFiscales.Text & ", debe especificar los siguientes datos correctamente:"))
                'Throw New Exception(Mensaje.ToString())
                MessageBox.Show(Mensaje.ToString(), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            Else
                If dgvDomicilios.RowCount = 0 Then
                    MessageBox.Show("Agrega el domicilio fiscal antes de continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    Private Function ValidarFiscales() As Boolean
        Try
            If Not Me.txtRazonSocial.Text = "" Then
                Return True
            End If
            If Not Me.txtCalleFisc.Text = "" Then
                Return True
            End If
            If Not Me.txtColoniaFisc.Text = "" Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub Imprimir()
        Try
            Dim VerReporte As New FrmReportes
            ClientesCol = New CN.ClientesIntroductoresColeccion
            Me.ClientesCol.Add(Cliente)
            Me.ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
            If ClientesCol.Count.ToString > 0 Then
                VerReporte.CRV.ReportSource = ClientesCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
                VerReporte.Show()
            Else
                MsgBox("No se enconto ningun Cliente", MsgBoxStyle.Information, "No hay Informacion")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function DibujarTexto(ByVal text As String, ByRef font As Font, ByRef textColor As Color, ByRef backColor As Color) As Image
        ' first, create a dummy bitmap just to get a graphics object
        Dim img As Image = New Bitmap(300, 300)
        Dim drawing As Graphics = Graphics.FromImage(img)

        ' measure the string to see how big the image needs to be
        Dim textSize As SizeF = drawing.MeasureString(text, font)

        ' free up the dummy image and old graphics object
        img.Dispose()
        drawing.Dispose()

        ' create a new image of the right size
        img = New Bitmap(CType(textSize.Width, Integer), CType(textSize.Height, Integer))

        drawing = Graphics.FromImage(img)

        ' paint the background
        drawing.Clear(backColor)

        ' create a brush for the text
        Dim textBrush As Brush = New SolidBrush(textColor)

        drawing.DrawString(text, font, textBrush, 0, 0)

        drawing.Save()

        textBrush.Dispose()
        drawing.Dispose()

        Return img

    End Function
#End Region

#Region "Combos"
    Private Sub CmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.CmbCiudades.Focus()
        End If
    End Sub

    Private Sub CmbEstado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbEstado.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.EstadosC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub CmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        Try
            If Me.CmbEstado.SelectedIndex > -1 And Me.CmbEstado.SelectedItem IsNot Nothing And bandera Then
                Me.CmbCiudades.DisplayMember = "Descripcion"
                Me.CmbCiudades.ValueMember = "Codigo"
                Me.CiudadesC = New CN.CiudadCollectionClass
                'Me.CiudadesC.Obtener(Me.CmbEstado.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CiudadesC.Obtener(CInt(CmbEstado.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbCiudades.SelectedIndex = -1
                Me.CmbCiudades.DataSource = Me.CiudadesC
            Else
                Me.CmbCiudades.DataSource = Nothing
                Me.CmbCiudades.Text = "Seleccione una ciudad.."
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCiudades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCiudades.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CmbPoblaciones.Focus()
        End If
    End Sub

    Private Sub CmbCiudades_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbCiudades.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            If Me.CmbEstado.SelectedIndex > -1 Then
                Me.CmbCiudades.DisplayMember = "Descripcion"
                Me.CmbCiudades.ValueMember = "Codigo"
                Me.CiudadesC = New CN.CiudadCollectionClass
                Me.CiudadesC.Obtener(Me.CmbEstado.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbCiudades.SelectedIndex = -1
                Me.CmbCiudades.DataSource = Me.CiudadesC
            Else
                Me.CmbCiudades.DataSource = Nothing
                Me.CmbCiudades.Text = "Seleccione una ciudad.."
            End If
        End If
    End Sub

    Private Sub CmbCiudades_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCiudades.SelectedIndexChanged
        Try
            If Me.CmbCiudades.SelectedIndex > -1 And Me.CmbCiudades.SelectedItem IsNot Nothing And bandera Then
                Me.CmbPoblaciones.DisplayMember = "Descripcion"
                Me.CmbPoblaciones.ValueMember = "Codigo"
                PoblacionesC = New CN.PoblacionCollectionClass
                'PoblacionesC.Obtener(Me.CmbCiudades.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                PoblacionesC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(CmbEstado.SelectedValue), CInt(CmbCiudades.SelectedValue))
                Me.CmbPoblaciones.SelectedIndex = -1
                Me.CmbPoblaciones.DataSource = PoblacionesC
            Else
                Me.CmbPoblaciones.DataSource = Nothing
                Me.CmbPoblaciones.Text = "Seleccione una población"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbEstadoFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbEstadoFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbCiudadFisc.Focus()
        End If
    End Sub

    Private Sub cmbEstadoFisc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstadoFisc.SelectedIndexChanged
        Try
            If Me.cmbCiudadFisc.SelectedIndex >= -1 And Me.cmbEstadoFisc.SelectedItem IsNot Nothing And bandera Then
                Me.cmbCiudadFisc.DisplayMember = "Descripcion"
                Me.cmbCiudadFisc.ValueMember = "Codigo"
                Me.CiudadesCFisc = New CN.CiudadCollectionClass
                'Me.CiudadesCFisc.Obtener(Me.cmbEstadoFisc.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CiudadesCFisc.Obtener(CInt(cmbEstadoFisc.SelectedValue), ClasesNegocio.CondicionEnum.ACTIVOS)

                Me.cmbCiudadFisc.DataSource = Me.CiudadesCFisc
                Me.cmbCiudadFisc.SelectedIndex = -1
            Else
                Me.cmbCiudadFisc.DataSource = Nothing
                Me.cmbCiudadFisc.Text = "Seleccione una ciudad"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbCiudadFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCiudadFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbPoblacionFisc.Focus()
        End If
    End Sub

    Private Sub cmbCiudadFisc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCiudadFisc.SelectedIndexChanged
        Try
            If Me.cmbCiudadFisc.SelectedIndex > -1 And Me.cmbCiudadFisc.SelectedItem IsNot Nothing Then
                Me.cmbPoblacionFisc.DisplayMember = "Descripcion"
                Me.cmbPoblacionFisc.ValueMember = "Codigo"
                Me.PoblacionesCFisc = New CN.PoblacionCollectionClass
                'Me.PoblacionesCFisc.Obtener(Me.cmbCiudadFisc.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.PoblacionesCFisc.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(cmbEstadoFisc.SelectedValue), CInt(cmbCiudadFisc.SelectedValue))

                Me.cmbPoblacionFisc.DataSource = Me.PoblacionesCFisc
                Me.cmbPoblacionFisc.SelectedIndex = -1
            Else
                Me.cmbPoblacionFisc.DataSource = Nothing
                Me.cmbPoblacionFisc.Text = "Seleccione una población"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Botones Toolbar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            Me.Estatus = CN.FormState.Borrar

            If Me.Cliente.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MessageBox.Show("No se puede Cancelar el cliente porque ya se encuentra cancelado", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            Else
                Dim FacturasPagadas As Boolean = True

                'Nuevo Codigo
                'Inicio

                FacturasPagadas = comprobarFacturas(Cliente.Codigo)
                'Final


                'codigo anterior aqui marca error
                'For Each Factura As EC.FacturasClientesCabEntity In Cliente.Facturas
                'If Factura.Estatus = "V" OrElse Factura.Estatus = "A" Then
                '    FacturasPagadas = False
                '    Exit For
                'End If
                'Next

                If Not FacturasPagadas Then
                    MsgBox("No se puede desactivar ya que tiene facturas vigentes", MsgBoxStyle.Exclamation, "Catalogo de Clientes")
                    Cancelar = True
                    Exit Sub
                End If
            End If

            If MessageBox.Show("¿Seguro que desea cancelar el cliente?", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Not Cliente.Borrar() Then
                    MessageBox.Show("No se pudo Cancelar el cliente, intente de nuevo", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Cancelar = True
                    Exit Sub
                Else
                    MessageBox.Show("Se han cancelado los registros del Cliente", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    DesHabilitar()
                End If
            Else
                Cancelar = True
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Me.Estatus = CN.FormState.Buscar
            clmBtnEliminar.Visible = False
            Dim Ventana As New FrmBusquedaClientes
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                limpiar()

                Cliente = New CN.ClientesIntroductoresClass
                Cliente.Obtener(Ventana.dgvClientes.SelectedRows(0).Cells(Ventana.clmCodigo.Index).Value)
                Me.CuentaCont = Nothing
                Me.CuentaAnt = Nothing

                If Not Me.Cliente.CuentaAntiId = -1 Then
                    Me.CuentaAnt = New CN.CuentaContableClass
                    Me.CuentaAnt.Obtener(Cliente.CuentaAntiId)
                End If
                If Not Me.Cliente.CuentaContableId = -1 Then
                    Me.CuentaCont = New CN.CuentaContableClass
                    Me.CuentaCont.Obtener(Cliente.CuentaContableId)
                End If
                Me.PonerDatos()

                'bit = New CN.BitacoraPV
                'bit.llenarDatosTag(e.Button.Text, Controlador.Sesion.MiUsuario.Usrnom, Me.Controls)
                'MsgBox(bit.mensaje, MsgBoxStyle.Information, Application.ProductName)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Estatus = CN.FormState.Cancelar
        DesHabilitar()
        limpiar()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Me.Estatus = CN.FormState.Editar

        Try
            If Cliente.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                MessageBox.Show("El cliente se ha activado", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cliente.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                lblEstatus.Text = "ACTIVO"
            End If
            Habilitar()
            clmBtnEliminar.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Me.Estatus = CN.FormState.Guardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cliente")

        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
            If Not ValidarDatosFiscales() Then
                Cancelar = True
                Exit Sub
            End If


            EstablecerDatos()
            'If bit IsNot Nothing Then
            '    bit.diferencias(Me.Controls)
            'Else
            '    bit = New CN.BitacoraPV
            '    bit.diferencias(Me.Controls)
            'End If



            ' Dim Resultado As Object = Utilerias.RunControlException(Cliente, "Guardar", New Object() {Trans})

            If Me.Cliente.Guardar(Trans) = False Then
                Trans.Rollback()
                Cancelar = True
                MessageBox.Show("No se pudieron guardar los datos del cliente, intentelo de nuevo", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Me.Estatus = CN.FormState.Editar Then
                If Not Cliente.DiasCredito = 0 Then
                    If Not DiasCredito = Cliente.DiasCredito Then 'Actualiza la fecha de vencimiento de las facturas
                        Dim FacturasCol As New CC.FacturasClientesCabCollection
                        FacturasCol.GetMulti(HC.FacturasClientesCabFields.IdClienteCargo = Cliente.Codigo And Not HC.FacturasClientesCabFields.Estatus = "X" _
                        Or Not HC.FacturasClientesCabFields.Estatus = "P")

                        If Cliente.DiasCredito > DiasCredito Then
                            For Each Fact As EC.FacturasClientesCabEntity In FacturasCol
                                Fact.FechaVencimiento.AddDays(DiasCredito)
                                Trans.Add(Fact)
                                If Not Fact.Save() Then
                                    Trans.Rollback()
                                    Cancelar = True
                                    MsgBox("Ocurrió un error al actualizar las facturas", MsgBoxStyle.Critical, "Error")
                                    Exit Sub
                                End If
                            Next
                        Else
                            For Each Fact As EC.FacturasClientesCabEntity In FacturasCol
                                Fact.FechaVencimiento.AddDays(-DiasCredito)
                                Trans.Add(Fact)

                                If Not Fact.Save() Then
                                    Trans.Rollback()
                                    Cancelar = True
                                    MsgBox("Ocurrió un error al actualizar las facturas", MsgBoxStyle.Critical, "Error")
                                    Exit Sub
                                End If
                            Next
                        End If
                        'Trans.Add(FacturasCol)
                        'If Not FacturasCol.SaveMulti Then
                        '    Trans.Rollback()
                        '    Cancelar = True
                        '    MsgBox("Ocurrió un error al actualizar las facturas", MsgBoxStyle.Critical, "Error")
                        '    Exit Sub
                        'End If
                    End If
                End If
            End If
            Trans.Commit()
            MessageBox.Show("Se ha guardado el cliente con el código: " & Cliente.Codigo, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox(bit.mensaje, MsgBoxStyle.Information, Application.ProductName)

            limpiar()
            DesHabilitar()
            Me.ClientesCol = New CN.ClientesIntroductoresColeccion
            Me.ClientesCol.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
            'Me.dgvClientes.AutoGenerateColumns = False
            'Me.dgvClientes.DataSource = Me.ClientesCol

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Me.Estatus = CN.FormState.Imprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.Estatus = CN.FormState.Limpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Try
            Me.Estatus = CN.FormState.Nuevo
            Me.limpiar()
            Me.Habilitar()
            Me.txtNombre.Focus()
            Me.Cliente = New CN.ClientesIntroductoresClass
            clmBtnEliminar.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Estatus = CN.FormState.Salir
        Close()
    End Sub
#End Region

#Region "DataGrid"
    'Private Sub dgvClientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Me.dgvClientes.SelectedRows.Count > 0 Then
    '            Cliente = New CN.ClientesIntroductoresClass
    '            If Not Cliente.Obtener(DirectCast(Me.dgvClientes.SelectedRows(0).DataBoundItem, CN.ClientesIntroductoresClass).Codigo) Then
    '                MessageBox.Show("El cliente no existe", Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Else
    '                Me.ClienteDatosFiscales = New CN.ClientesDatosFiscalesclass
    '                Me.ClienteDatosFiscales.Obtener(Me.Cliente.Codigo)

    '                Inicio = False
    '                Me.CuentaCont = New CN.CuentaContableClass
    '                Me.CuentaAnt = New CN.CuentaContableClass
    '                Me.CuentaCont.Obtener(Cliente.CuentaContableId)
    '                Me.CuentaAnt.Obtener(Cliente.CuentaAntiId)
    '                PonerDatos()
    '                Me.mtb.sbCambiarEstadoBotones("Buscar")
    '                DesHabilitar()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    ''Private Sub dgvClientes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    'End Sub
#End Region

#Region "Botones"
    Private Sub btnCtaContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaContable.Click
        Try
            Dim CuentaConfiguracion As New CC.CfgCtrlCtasCollection
            Dim Relacion As New OC.RelationCollection
            Dim buscarCuenta As New BusquedaCuentasContablesForm

            buscarCuenta.chkAfe.Checked = True
            buscarCuenta.chkBan.CheckState = CheckState.Indeterminate
            buscarCuenta.chkDep.CheckState = CheckState.Indeterminate
            buscarCuenta.chkIna.Checked = False
            buscarCuenta.chkPre.CheckState = CheckState.Indeterminate
            buscarCuenta.chkRes.CheckState = CheckState.Indeterminate

            buscarCuenta.Var = False
            buscarCuenta.BloquearCaracteristicas = True
            buscarCuenta.AfectableDefault = ClasesNegocio.CondicionAsignadaEnum.SI

            Relacion.Add(EC.CfgCtrlCtasEntity.Relations.ConCfgCtasEntityUsingIdConCfgCtas)
            CuentaConfiguracion.GetMulti(HC.ConCfgCtasFields.Concepto Mod String.Format("%{0}%", "CLIENTES"), 0, Nothing, Relacion)

            If Not CuentaConfiguracion.Count > 0 Then
                MsgBox("No se ha establecido una configuracion contable para este concepto", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Exit Sub
            End If
            buscarCuenta.txtCta.Text = CuentaConfiguracion(0).CuentaContable.Cta
            buscarCuenta.txtSCta.Text = CuentaConfiguracion(0).CuentaContable.SubCta
            buscarCuenta.txtSSCta.Text = CuentaConfiguracion(0).CuentaContable.SsubCta
            buscarCuenta.txtSSSCta.Text = CuentaConfiguracion(0).CuentaContable.SssubCta


            buscarCuenta.txtNombre.Enabled = False
            buscarCuenta.txtCta.Enabled = False
            buscarCuenta.txtSCta.Enabled = False
            buscarCuenta.txtSSCta.Enabled = False
            buscarCuenta.txtSSSCta.Enabled = False

            If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                CuentaCont = New CN.CuentaContableClass
                CuentaCont = buscarCuenta.CuentaContable
                Me.txtCtaContable.Text = String.Format("{0} : {1}", CuentaCont.NombreCuenta, CuentaCont.CuentaContable)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCtaAnticipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaAnticipo.Click
        Try
            Dim buscarCuenta As New BusquedaCuentasContablesForm
            If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                CuentaAnt = New CN.CuentaContableClass
                CuentaAnt = buscarCuenta.CuentaContable
                Me.txtCtaAnticipo.Text = String.Format("{0} : {1}", CuentaAnt.NombreCuenta, CuentaAnt.CuentaContable)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCtaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaVenta.Click
        Try
            Dim buscarCuentaV As New BusquedaCuentasContablesForm
            If buscarCuentaV.ShowDialog = Windows.Forms.DialogResult.OK Then
                CuentaVenta = New CN.CuentaContableClass
                CuentaVenta = buscarCuentaV.CuentaContable
                Me.txtCtaVenta.Text = String.Format("{0} : {1}", CuentaVenta.NombreCuenta, CuentaVenta.CuentaContable)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Key Press"
    Private Sub txtLimiteCred_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLimiteCred.GotFocus
        If Me.txtLimiteCred.Text = "" Then
            Me.txtLimiteCred.Text = "0.00"
        Else
            Me.txtLimiteCred.Text = Me.txtLimiteCred.Text.Replace(",", "").Replace("$", "")
        End If
    End Sub

    Private Sub txtLimiteCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimiteCred.KeyPress
        Try
            If e.KeyChar = Chr(Keys.Enter) Then
                Me.txtDiasCred.Focus()
            ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = ".") OrElse (e.KeyChar = "." AndAlso Me.txtLimiteCred.Text.IndexOf(".") > -1) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtLimiteCred_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLimiteCred.LostFocus
        Try
            If IsNumeric(Me.txtLimiteCred.Text) Then
                Me.txtLimiteCred.Text = CDec(Me.txtLimiteCred.Text).ToString("C2")
            Else
                Me.txtLimiteCred.Text = 0.0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDiasCred_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiasCred.GotFocus
        If Me.txtDiasCred.Text = "" Then
            Me.txtDiasCred.Text = "0"
        Else
            Me.txtDiasCred.Text = Me.txtDiasCred.Text.Replace(",", "")
        End If
    End Sub

    Private Sub txtDiasCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasCred.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.cmbTipoFacturacion.Focus()
        ElseIf (Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) AndAlso Not e.KeyChar = ".") OrElse (e.KeyChar = "." AndAlso Me.txtDiasCred.Text.IndexOf(".") > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiasCred_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiasCred.LostFocus
        If Me.txtDiasCred.Text = "" Then
            Me.txtDiasCred.Text = 0
        End If
    End Sub

    Private Sub txtCodigoPostal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoPostal.GotFocus
        'If Not Me.txtCodigoPostal.Text = "" Then
        '    Me.txtCodigoPostal.Text = Me.txtCodigoPostal.Text.Replace("")
        'End If
    End Sub

    Private Sub txtCodigoPostal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoPostal.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.txtTelefono.Focus()
        ElseIf Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigoPostal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoPostal.LostFocus
        'If IsNumeric(Me.txtCodigoPostal.Text) Then
        '    Me.txtCodigoPostal.Text = CInt(Me.txtCodigoPostal.Text).ToString("N0")
        'End If
    End Sub

    Private Sub txtCPfiscal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPfiscal.GotFocus
        If Not Me.txtCPfiscal.Text = "" Then
            Me.txtCPfiscal.Text = Me.txtCPfiscal.Text.Replace(",", "")
        End If
    End Sub

    Private Sub txtCPfiscal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPfiscal.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.txtTelefonoFisc.Focus()
        ElseIf Not IsNumeric(Me.txtCPfiscal.Text) AndAlso e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCPfiscal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCPfiscal.LostFocus
        If IsNumeric(Me.txtCPfiscal.Text) Then
            Me.txtCPfiscal.Text = CInt(Me.txtCPfiscal.Text)
        End If
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtDomicilio.Focus()
        End If
    End Sub

    Private Sub txtDomicilio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDomicilio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtColonia.Focus()
        End If
    End Sub

    Private Sub txtColonia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColonia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CmbEstado.Focus()
        End If
    End Sub

    Private Sub CmbPoblaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbPoblaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbVendedor.Focus()
        End If
    End Sub

    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.chkIntroductor.Focus()
        End If
    End Sub

    Private Sub chkIntroductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkIntroductor.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.btnCtaContable.Focus()
        End If
    End Sub

    Private Sub cmbTipoFacturacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoFacturacion.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.cmbDiasRevision.Focus()
        End If
    End Sub

    Private Sub cmbDiasRevision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDiasRevision.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TabControl1.SelectedIndex = 2
            Me.txtRfc.Focus()
        End If
    End Sub

    Private Sub txtRazonSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.txtCalleFisc.Focus()
        End If
    End Sub

    Private Sub txtCalleFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCalleFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtNoExtFisc.Focus()
        End If
    End Sub

    Private Sub txtNoExtFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoExtFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtNoIntFisc.Focus()
        End If
    End Sub

    Private Sub txtNoIntFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNoIntFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtColoniaFisc.Focus()
        End If
    End Sub

    Private Sub txtColoniaFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtColoniaFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbEstadoFisc.Focus()
        End If
    End Sub

    Private Sub cmbPoblacionFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPoblacionFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCPfiscal.Focus()
        End If
    End Sub

    Private Sub txtTelefonoFisc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelefonoFisc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtFax.Focus()
        End If
    End Sub

    Private Sub txtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTelCel.Focus()
        End If
    End Sub

    Private Sub txtTelCel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTelCel.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtEmail.Focus()
        End If
    End Sub
#End Region

    'Private Sub cmbPasarInformacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPasarInformacion.Click
    '    Try
    '        dgvDomicilios.DataSource = Nothing
    '        Dim Domicilio As New CN.DomicilioClienteClass(Me.CmbPoblaciones.SelectedValue, Me.txtColonia.Text, Me.txtDomicilio.Text, Me.txtCodigoPostal.Text, Me.txtTelefono.Text, "", "", "")
    '        Cliente.ValidarDomicliosDiferentes(Domicilio)
    '        Cliente.DomiciliosFiscales.Add(Domicilio)
    '        LimpiarCamposDomicilioFiscal()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes")
    '    Finally
    '        dgvDomicilios.DataSource = Cliente.DomiciliosFiscales
    '        dgvDomicilios.Rows(dgvDomicilios.Rows.Count - 1).Selected = True
    '    End Try
    'End Sub

    Private Sub cmbVendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbVendedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtCodigoPostal.Focus()
        End If
    End Sub

    Private Sub CmbPoblaciones_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPoblaciones.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            If Me.CmbCiudades.SelectedIndex > -1 And Me.CmbCiudades.SelectedItem IsNot Nothing Then
                Me.CmbPoblaciones.DisplayMember = "Descripcion"
                Me.CmbPoblaciones.ValueMember = "Codigo"
                PoblacionesC = New CN.PoblacionCollectionClass
                PoblacionesC.Obtener(Me.CmbCiudades.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbPoblaciones.SelectedIndex = -1
                Me.CmbPoblaciones.DataSource = PoblacionesC
            Else
                Me.CmbPoblaciones.DataSource = Nothing
                Me.CmbPoblaciones.Text = "Seleccione una población"
            End If
        End If
    End Sub

    'agregar un nuevo domicilio
    Private Sub btnCrearDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearDomicilio.Click
        Try
            dgvDomicilios.DataSource = Nothing
            Dim Domicilio As New CN.DomicilioClienteClass(Me.cmbEstadoFisc.SelectedValue, Me.cmbCiudadFisc.SelectedValue, Me.cmbPoblacionFisc.SelectedValue, Me.txtColoniaFisc.Text.Trim, Me.txtCalleFisc.Text.Trim, Me.txtNoExtFisc.Text.Trim, Me.txtNoIntFisc.Text.Trim, Me.txtCPfiscal.Text.Trim, Me.txtTelefonoFisc.Text.Trim, txtTelCel.Text.Trim, txtFax.Text.Trim, txtEmail.Text.Trim)
            Cliente.ValidarDomicliosDiferentes(Domicilio)
            Cliente.DomiciliosFiscales.Add(Domicilio)

            If chkPrincipal.Checked Then
                Cliente.SeleccionarDomicilioPrincipal(Cliente.DomiciliosFiscales.Count - 1, Controlador.Sesion)
            End If
            LimpiarCamposDomicilioFiscal()
        Catch ex As Exception
            If ex.InnerException IsNot Nothing AndAlso ex.InnerException.Message = "Domicilio Fiscal" Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom & " - " & ex.InnerException.Message)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            End If
        Finally
            dgvDomicilios.DataSource = Cliente.DomiciliosFiscales
            dgvDomicilios.ClearSelection()
        End Try
    End Sub

    'modificar el domicilio seleccionado
    Private Sub btnModificarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarDomicilio.Click
        Try
            Dim Domicilio As New CN.DomicilioClienteClass(cmbEstadoFisc.SelectedValue, cmbCiudadFisc.SelectedValue, cmbPoblacionFisc.SelectedValue, txtColoniaFisc.Text.Trim, txtCalleFisc.Text.Trim, txtNoExtFisc.Text.Trim, txtNoIntFisc.Text.Trim, txtCPfiscal.Text.Trim, txtTelefonoFisc.Text.Trim, txtTelCel.Text.Trim, txtFax.Text.Trim, txtEmail.Text.Trim)

            Domicilio.validarDomicilio(Val(cmbEstadoFisc.SelectedValue), Val(cmbCiudadFisc.SelectedValue), Val(cmbPoblacionFisc.SelectedValue), txtColoniaFisc.Text.Trim, txtCalleFisc.Text.Trim, txtNoExtFisc.Text.Trim, txtNoIntFisc.Text.Trim, txtEmail.Text.Trim)
            Cliente.ValidarDomicliosDiferentes(Domicilio, dgvDomicilios.SelectedRows(0).Index)
            Cliente.DomiciliosFiscales(dgvDomicilios.SelectedRows(0).Index) = Domicilio

            If chkPrincipal.Checked Then
                Cliente.SeleccionarDomicilioPrincipal(dgvDomicilios.SelectedRows(0).Index, Controlador.Sesion)
            End If
            LimpiarCamposDomicilioFiscal()
            dgvDomicilios.Refresh()
            dgvDomicilios.ClearSelection()
        Catch ex As Exception
            If ex.InnerException IsNot Nothing AndAlso ex.InnerException.Message = "Domicilio Fiscal" Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom & " - " & ex.InnerException.Message)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            End If
        End Try
    End Sub

    'evento que se dispara cuando el usuario selecciona un domicilio
    Private Sub dgvDomicilios_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDomicilios.CellClick
        Try
            If dgvDomicilios.SelectedRows.Count > 0 Then
                Dim Domicilio As CN.DomicilioClienteClass = CType(dgvDomicilios.SelectedRows(0).DataBoundItem, CN.DomicilioClienteClass)

                'permitir editar o eliminar
                If Me.Estatus = CN.FormState.Editar Or Me.Estatus = CN.FormState.Nuevo Or Me.Estatus = CN.FormState.Guardar Then
                    btnEditarDomicilio.Enabled = True
                End If

                'mostrar en detalle el domicilio
                txtTelCel.Text = Domicilio.Celular
                txtCPfiscal.Text = Domicilio.CodigPostal
                txtColoniaFisc.Text = Domicilio.Colonia
                txtCalleFisc.Text = Domicilio.Calle
                txtNoExtFisc.Text = Domicilio.NoExt
                txtNoIntFisc.Text = Domicilio.NoInt
                'txtDomicilioFisc.Text = Domicilio.Domicilio
                txtEmail.Text = Domicilio.Email
                txtFax.Text = Domicilio.Fax
                cmbEstadoFisc.SelectedValue = Domicilio.Estado.Codigo
                cmbCiudadFisc.SelectedValue = Domicilio.Ciudad.Codigo
                cmbPoblacionFisc.SelectedValue = Domicilio.IdPoblacion
                txtTelefonoFisc.Text = Domicilio.Telefono1
                chkPrincipal.Checked = Domicilio.EsPrincipal
            End If
        Catch ex As Exception
            If ex.InnerException IsNot Nothing AndAlso ex.InnerException.Message = "Domicilio Fiscal" Then
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom & " - " & ex.InnerException.Message)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            End If
        End Try
    End Sub

    Private Sub btnEliminarDomicilio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim index As Integer = dgvDomicilios.SelectedRows(0).Index
            dgvDomicilios.DataSource = Nothing
            Cliente.EliminarDomicilioFiscal(index, Controlador.Sesion)
            dgvDomicilios.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
        Finally
            dgvDomicilios.DataSource = Cliente.DomiciliosFiscales
        End Try
    End Sub

    Private Sub dgvDomicilios_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgvDomicilios.RowsRemoved
        If dgvDomicilios.Rows.Count <= 0 Then
            'no permitir editar o eliminar
            btnEditarDomicilio.Enabled = False
        End If
    End Sub

    Private Sub dgvDomicilios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDomicilios.CellContentClick
        If e.ColumnIndex = clmBtnEliminar.Index Then
            Try
                Dim index As Integer = dgvDomicilios.SelectedRows(0).Index
                dgvDomicilios.DataSource = Nothing
                Cliente.EliminarDomicilioFiscal(index, Controlador.Sesion)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
            Finally
                dgvDomicilios.DataSource = Cliente.DomiciliosFiscales
                dgvDomicilios.ClearSelection()
            End Try
        End If
    End Sub

    'Funcion que me valida la forma de un RFC
    Function ValidateRFC(ByVal RFC As String) As Boolean
        Dim RFCRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z]{3,4}-?(\d{6})-?((\D|\d){3})?$")
        Dim RFCMatch As  _
            System.Text.RegularExpressions.Match = RFCRegex.Match(RFC)
        Return RFCMatch.Success
    End Function

    Private Sub cmbPasarInformacion_Click(sender As System.Object, e As System.EventArgs) Handles cmbPasarInformacion.Click

    End Sub

    Private Sub TbpDatosFiscales_Enter(sender As System.Object, e As System.EventArgs) Handles TbpDatosFiscales.Enter
        Try
            txtCPfiscal.Text = txtCodigoPostal.Text
            cmbEstadoFisc.SelectedValue = IIf(CmbEstado.SelectedValue Is Nothing, 0, CmbEstado.SelectedValue)
            cmbCiudadFisc.SelectedValue = IIf(CmbCiudades.SelectedValue Is Nothing, 0, CmbCiudades.SelectedValue)
            cmbPoblacionFisc.SelectedValue = IIf(CmbPoblaciones.SelectedValue Is Nothing, 0, CmbPoblaciones.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub pbLogo_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbLogo.DoubleClick
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Todas las imagenes (*.jpg, *.png, *.bmp) | *.jpg; *.png; *.bmp; |Bitmap|*.bmp|JPEG|*.jpg|PNG|*.png" 'If you like file type filters you can add them here
        ofd.Title = "Seleccione una imagen"
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        'any other modifications to the dialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            'var size = new FileInfo(ofd.FileName).Length; 

            Dim size As Integer
            size = New FileInfo(ofd.FileName).Length

            If CDec(size / 1024) > 2048 Then
                MsgBox("Imagen excede el tamaño de 2MB, verifique por favor.", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If


            Dim textos As String()
            textos = ofd.FileName.ToString().Split(".")
            pbLogo.Tag = textos(textos.Length - 1)
            pbLogo.Image = Image.FromFile(ofd.FileName)

        Catch
            MsgBox("Imagen no valida")
        End Try
    End Sub


    Private Sub lblBorrar_Click(sender As System.Object, e As System.EventArgs) Handles lblBorrar.Click
        Me.pbLogo.Image = Nothing
        Me.pbLogo.Tag = Nothing
    End Sub


    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub
    'Esta funcion verifica si el cliete tiene facturas pendientes
    Private Function comprobarFacturas(ByVal clv_cliente As Object) As Integer


        Dim val As String = ""
        Dim strConnection As String = "Server=integrasrv4;" & _
            "Database=MeatLa20;" & _
            "User Id=sa;" & _
            "Password=int3gr@"

        Try

            Using connection As New SqlConnection(strConnection)

                connection.Open()

                Dim rd As SqlDataReader
                Dim cmd As New SqlCommand("spComprobarFacturas", connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@idcliente", clv_cliente)
                rd = cmd.ExecuteReader()

                'mejorar esto
                While rd.Read()

                    val = rd(0)

                End While

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        'Si val = 1 etonces el cliente tiene facturas pendientes y no puede eliminarse(regresa False), sino pasa de largo y regresa True
        If val = "1" Then
            Return False
        End If

        Return True

    End Function

End Class