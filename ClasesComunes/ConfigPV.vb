Imports System.Drawing.Printing
Imports Microsoft.Win32
Imports IntegraLab.ORMSeguridad
Imports IntegraLab.FormasSeguridad
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.Data.SqlClient

Public Class ConfigPV
    Public Property SeleccionarSucursal() As Integer
        Get
            Return cmbSucursal.SelectedValue
        End Get
        Set(value As Integer)
            cmbSucursal.SelectedValue = value
        End Set
    End Property

    Public Property NomImpresora() As String
        Get
            Return cmbImpresorasInstaladas.Text
        End Get
        Set(value As String)
            cmbImpresorasInstaladas.SelectedItem = value
        End Set
    End Property

    Public ReadOnly Property NomSucursal As String
        Get
            Return cmbSucursal.Text
        End Get
    End Property

    Public Property SeleccionarConcepto() As Integer
        Get
            Return cmbConceptos.SelectedValue
        End Get
        Set(value As Integer)
            cmbConceptos.SelectedValue = value
        End Set
    End Property
    Dim cambio(2) As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim sucursales As New ClasesNegocio.SucursalCollectionClass
        'Dim sucursal As New ClasesNegocio.SucursalClass
        'sucursal.Codigo = 0
        'sucursal.Descripcion = "No se ha seleccionado sucursal"

        sucursales.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Me.cmbSucursal.DataSource = sucursales
        cmbSucursal.DisplayMember = "DescripcionCorta"
        cmbSucursal.ValueMember = "Codigo"
        cmbSucursal.SelectedIndex = -1
        cmbSucursal.Text = "SELECCIONE UNA SUCURSAL"
        For i As Integer = 0 To PrinterSettings.InstalledPrinters.Count - 1
            cmbImpresorasInstaladas.Items.Add(PrinterSettings.InstalledPrinters.Item(i).ToString.Trim.ToUpper)
        Next
        cmbImpresorasInstaladas.SelectedIndex = -1
        cmbImpresorasInstaladas.Text = "SELECCIONE UNA IMPRESORA"


        ''llenar conceptos por retiro
        Dim conceptos As New ClasesNegocio.ConceptoCajaCollectionClass
        conceptos.Obtener("E")
        cmbConceptos.DisplayMember = "Concepto"
        cmbConceptos.ValueMember = "IdConCaja"
        cmbConceptos.DataSource = conceptos
        cmbConceptos.SelectedIndex = -1
        cmbConceptos.Text = "SELECCIONE UN CONCEPTO"
        ''llenar clientes
        'Dim clientes As New ClasesNegocio.ClientesColecttionClass




    End Sub


    Private Sub ConfigPV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        Try
            If Not IsNothing(reg.GetValue("CodigoSucursal", Nothing)) Then
                SeleccionarSucursal = CInt(reg.GetValue("CodigoSucursal", Nothing).ToString)
            End If

            If Not IsNothing(reg.GetValue("NombreImpresora", Nothing)) Then
                cmbImpresorasInstaladas.SelectedItem = reg.GetValue("NombreImpresora", Nothing).ToString.ToUpper
            End If
            'txtNomImpresora.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\INTEGRALAB\", "NombreImpresora", Nothing).ToString
            If Not IsNothing(reg.GetValue("ConceptoRetiro", Nothing)) Then
                SeleccionarConcepto = CInt(reg.GetValue("ConceptoRetiro", Nothing).ToString)
            End If
            If ClasesNegocio.ControladorGanadera.ObtenerVtaSinExistencia Then
                rbSI.Checked = True
            Else
                rbNO.Checked = True
            End If

            If ClasesNegocio.ControladorGanadera.ValidarCierreDiario Then
                rbSICorteDiario.Checked = True
            Else
                rbNOCorteDiario.Checked = True
            End If


            cambio(0) = rbSI.Checked
            cambio(1) = rbNO.Checked

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        ' cmbImpresorasInstaladas.SelectedText = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\INTEGRALAB\", "NombreImpresora", Nothing).ToString.ToUpper
        'Dim sucursales As New ClasesNegocio.SucursalCollectionClass
        ''Dim sucursal As New ClasesNegocio.SucursalClass
        ''sucursal.Codigo = 0
        ''sucursal.Descripcion = "No se ha seleccionado sucursal"

        'sucursales.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'Me.cmbSucursal.DataSource = sucursales
        'cmbSucursal.DisplayMember = "DescripcionCorta"
        'cmbSucursal.ValueMember = "Codigo"

        'cmbSucursal.SelectedValue = 
        'If cmbSucursal.SelectedIndex = -1 Then
        '    cmbSucursal.Text = "SIN SUCURSAL SELECCIONADA"
        'End If
        reg.Close()

    End Sub

    Private Sub Mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickGuardar

        'If cmbSucursal.SelectedIndex = -1 Then
        '    MsgBox("Seleccione una sucursal.", MsgBoxStyle.Exclamation, Application.ProductName)
        '    cmbSucursal.SelectedIndex = -1
        '    cmbSucursal.Text = "SIN SUCURSAL SELECCIONADA"
        '    cmbSucursal.Focus()
        '    Cancelar = True
        '    Exit Sub
        'End If

        'If cmbImpresorasInstaladas.SelectedIndex = -1 Then
        '    MsgBox("Se requiere del nombre de la impresora de ticket.", MsgBoxStyle.Exclamation, Application.ProductName)
        '    cmbImpresorasInstaladas.Focus()
        '    Cancelar = True
        '    Exit Sub
        'End If cmbSucursal

        If cambio(0) <> rbSI.Checked Or cambio(1) <> rbNO.Checked Then
            Dim permiso As New EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)
            If Not IsDBNull(permiso.Usrtipo) Then
                If Not permiso.Usrtipo.Equals("A") Then
                    Dim validar As New ValidateForm()
                    If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                        permiso = New EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)
                        If Not IsDBNull(permiso.Usrtipo) Then
                            If permiso.Usrtipo.Equals("A") Then
                                '(True)
                            Else
                                MsgBox("Usuario sin permisos para realizar este cambio.", MsgBoxStyle.Exclamation, "AVISO")
                                Return
                            End If
                        Else
                            MsgBox("Usuario sin permisos para realizar este cambio.", MsgBoxStyle.Exclamation, "AVISO")
                            Return
                        End If
                    Else
                        Return
                    End If
                End If
            Else
                Dim validar As New ValidateForm()
                If validar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    permiso = New EntityClasses.DetalleempresasEntity(validar.Usuario.Usrndx, Controlador.Empresa.CodEmpndx)
                    If Not IsDBNull(permiso.Usrtipo) Then
                        If Not permiso.Usrtipo.Equals("A") Then
                            MsgBox("Usuario sin permisos para realizar este cambio.", MsgBoxStyle.Exclamation, "AVISO")
                            Return
                        End If
                    Else
                        MsgBox("Usuario sin permisos para realizar este cambio.", MsgBoxStyle.Exclamation, "AVISO")
                        Return
                    End If
                Else
                    Return
                End If
            End If
        End If


        If cmbSucursal.SelectedIndex = -1 Then
            If cmbImpresorasInstaladas.SelectedIndex = -1 Then
                MsgBox("Se requiere seleccionar al menos una para guardar cambios.", MsgBoxStyle.Exclamation, Application.ProductName)
                'cmbImpresorasInstaladas.Focus()
                Cancelar = True
                Exit Sub
            End If
        End If


        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        If cmbSucursal.SelectedValue IsNot Nothing Then
            reg.SetValue("CodigoSucursal", cmbSucursal.SelectedValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        End If
        If cmbImpresorasInstaladas.SelectedIndex <> -1 Then
            reg.SetValue("NombreImpresora", cmbImpresorasInstaladas.Text.ToString, Microsoft.Win32.RegistryValueKind.String)
        End If
        If cmbConceptos.SelectedValue IsNot Nothing Then
            reg.SetValue("ConceptoRetiro", cmbConceptos.SelectedValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        End If




        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand

            con.ConnectionString = HC.DbUtils.ActualConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = ("UPDATE ConfigPuntoVta SET VenderSinExistencia = @SinExistencia,CortePorDia = @CortePorDia")
            cmd.Parameters.Add("@SinExistencia", SqlDbType.Bit).Value = IIf(rbSI.Checked, True, False)
            cmd.Parameters.Add("@CortePorDia", SqlDbType.Bit).Value = IIf(rbSICorteDiario.Checked, True, False)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As System.Exception
            MessageBox.Show(ex.Message.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        reg.Close()



        'reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        'Microsoft.Win32.Registry.LocalMachine.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\INTEGRALAB\", "CodigoSucursal", cmbSucursal.SelectedValue.ToString, Microsoft.Win32.RegistryValueKind.String)

        'Microsoft.Win32.Registry.LocalMachine.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\INTEGRALAB\", "NombreImpresora", cmbImpresorasInstaladas.Text, Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\INTEGRALAB\", "CodigoSucursal", cmbSucursal.SelectedValue.ToString, Microsoft.Win32.RegistryValueKind.String)
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\INTEGRALAB\", "NombreImpresora", cmbImpresorasInstaladas.Text, Microsoft.Win32.RegistryValueKind.String)

        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\INTEGRALAB\", "CodigoSucursal", "0", Microsoft.Win32.RegistryValueKind.String)
        'Dim value = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\INTEGRALAB\", "NombreImpresora", Nothing)
        ''My.Computer.Registry.CurrentUser.GetValue("HKEY_CURRENT_USER\INTEGRALAB\", "CodigoSucursal", Microsoft.Win32.RegistryValueOptions.None).ToString()
        'MsgBox("" & value, MsgBoxStyle.Exclamation, Application.ProductName)
        'If reg.GetValue("NombreImpresora", Nothing) <> cmbImpresorasInstaladas.Text And _
        '  reg.GetValue("CodigoSucursal", Nothing) <> cmbSucursal.SelectedValue.ToString And reg.GetValue("ConceptoRetiro", Nothing) <> cmbConceptos.SelectedValue.ToString Then
        '    MsgBox("Error al guardar, reintente nuevamente.", MsgBoxStyle.Exclamation, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
        '    reg.Close()
        '    Return
        'Else
        MsgBox("Se guardaron cambios correctamente." & vbLf & "SUCURSAL: " & cmbSucursal.Text & vbLf & "NOM. IMPRESORA: " & cmbImpresorasInstaladas.Text.Trim & vbLf & "CONCEPTO RETIRO: " & cmbConceptos.Text, MsgBoxStyle.Information, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
        reg.Close()
        Me.Close()
        Me.Dispose()
        ' End If

    End Sub

    Private Sub Mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ConfigPV_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        If reg.GetValue("CodigoSucursal", Nothing) = "0" And reg.GetValue("NombreImpresora", Nothing) = "" Then
            MsgBox("No se ha configurado la sucursal ni el nombre de la impresora." & vbLf & "Esto limitara el acceso algunas pantallas que requieren esta configuración.", MsgBoxStyle.Exclamation, Application.ProductName)
        Else
            If reg.GetValue("CodigoSucursal", Nothing) = "0" Then
                MsgBox("No se ha configurado la sucursal." & vbLf & "Esto limitara el acceso algunas pantallas que requieren esta configuración.", MsgBoxStyle.Exclamation, Application.ProductName)
            End If

            If reg.GetValue("NombreImpresora", Nothing) = "" Then
                MsgBox("No se ha configurado el nombre de la impresora. " & vbLf & "Esto limitara el acceso algunas pantallas que requieren esta configuración.", MsgBoxStyle.Exclamation, Application.ProductName)
            End If
        End If
        reg.Close()
    End Sub



    'Public Function permiso() As Boolean
    '    Dim permiso As New ECS.EntityClasses.DetalleempresasEntity(Controlador.Empresa.CodEmpndx, Controlador.Sesion.MiUsuario.Usrndx)

    'End Function
End Class