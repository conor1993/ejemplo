Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.FileIO
Imports CN = ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports Microsoft.Win32
Imports System.Windows.Forms

Public Class UtileriasCN

    'Public Shared Function ObtenerControlTurnoActual() As CN.ControlTurnoClass
    '    Dim IdUsuario As Integer = Controlador.Sesion.Usrndx
    '    Dim filtro As New OC.PredicateExpression
    '    filtro.Add(HC.ControlTurnoFields.FechaFin = System.Convert.DBNull)
    '    filtro.Add(HC.ControlTurnoFields.CodUsuario = IdUsuario)
    '    If Utilerias.ObtenerCodSucursal = 0 Then
    '        'MessageBox.Show("Es necesario configurar una sucursal del punto de venta.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Return Nothing
    '    End If

    '    filtro.Add(HC.ControlTurnoFields.CodSucursal = Utilerias.ObtenerCodSucursal)
    '    Dim ctrcol As New CN.ControlTurnoCollectionClass
    '    If ctrcol.Obtener(filtro) > 0 Then
    '        Return ctrcol.Item(0)
    '    Else
    '        Dim ventana As New frmIniciaTurno()
    '        If ventana.ShowDialog() = DialogResult.OK Then
    '            Return ventana.ControlTurnoActual
    '        Else
    '            ventana.Close()
    '            ventana.Dispose()
    '            Return Nothing
    '        End If
    '    End If
    'End Function

    Public Shared Function ObtenerCodSucursal() As Integer

        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)

        If reg.GetValue("CodigoSucursal", Nothing) = "0" Or reg.GetValue("CodigoSucursal", Nothing) Is Nothing Then
            MessageBox.Show("Es necesario configurar la sucursal antes de continuar.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Application.DoEvents()
            'Application.Exit()
            Return 0
        End If


        '#If Not Debug Then
        '        Return 2
        '#Else
        '        Return 1      ' pendiente programar lectura de sucursal
        '#End If

        Return CInt(reg.GetValue("CodigoSucursal", Nothing).ToString)
    End Function

    Public Shared Function ObtenerNomImpresora() As String
        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)

        If reg.GetValue("NombreImpresora", Nothing) = "" Or reg.GetValue("NombreImpresora", Nothing) Is Nothing Then
            MessageBox.Show("Es necesario configurar el nombre de la impresora antes de continuar.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return ""
        End If

        Return reg.GetValue("NombreImpresora", Nothing).ToString
    End Function


    Public Shared Function ObtenerCodConceptoRetiro() As Integer

        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)

        If reg.GetValue("ConceptoRetiro", Nothing) = "0" Or reg.GetValue("ConceptoRetiro", Nothing) Is Nothing Then
            MessageBox.Show("Es necesario el concepto para retiro en el pago de compras.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Application.DoEvents()
            'Application.Exit()
            Return 0
        End If


        '#If Not Debug Then
        '        Return 2
        '#Else
        '        Return 1      ' pendiente programar lectura de sucursal
        '#End If

        Return CInt(reg.GetValue("ConceptoRetiro", Nothing).ToString)
    End Function

    'Public Shared Function EjecutarSQL(ByVal strConsultaSQL As String, ByVal strTabla As String, ByVal ConexionString As String) As DataSet
    '    Dim sqlAdapter As New SqlClient.SqlDataAdapter(strConsultaSQL, ConexionString)
    '    Dim dsDatos As New DataSet

    '    Try
    '        sqlAdapter.Fill(dsDatos, strTabla)
    '        Return dsDatos
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return dsDatos
    '    End Try
    'End Function

    'Public Shared Function LlenarCombo(ByVal ConexionString As String, ByVal Combo As Windows.Forms.ComboBox, ByVal strTabla As String, ByVal strCampoLlave As String, ByVal strCampoDescripcion As String, ByVal strOrden As TipoOrden, ByVal strCampoOrdenar As String, Optional ByVal strFiltro As String = "") As Integer
    '    Dim strSql As String
    '    Dim strWhere As String
    '    Dim dsdatos As DataSet

    '    Try
    '        If Not Combo.Items.Count = 0 Then
    '            LlenarCombo = 1
    '            Exit Function
    '        End If
    '        If strFiltro = "" Then
    '            strWhere = ""
    '        Else
    '            strWhere = strFiltro
    '        End If
    '        strSql = "Select " + strCampoDescripcion + "," + strCampoLlave + " From " + strTabla + " " + strWhere + " Order by " + strCampoOrdenar + " "

    '        If strOrden = TipoOrden.Ascendente Then
    '            strSql += "ASC"
    '        Else
    '            strSql += "DESC"
    '        End If
    '        dsdatos = EjecutarSQL(strSql, strTabla, ConexionString)

    '        Combo.DataSource = dsdatos.Tables(0)
    '        Combo.DisplayMember = dsdatos.Tables(0).Columns(0).ColumnName
    '        Combo.ValueMember = dsdatos.Tables(0).Columns(1).ColumnName
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '        LlenarCombo = -1
    '    End Try
    'End Function

    'Public Enum TipoOrden As Integer
    '    Ascendente = 1
    '    Descendente = 2
    'End Enum

    'Public Shared Function LeerArchivodeTexto(ByVal Ruta As String) As List(Of String)
    '    Dim Lista As New List(Of String)

    '    Try
    '        Dim fileReader As System.IO.StreamReader

    '        fileReader = My.Computer.FileSystem.OpenTextFileReader(Ruta) '("C:\\testfile.txt")

    '        If Not fileReader.EndOfStream Then

    '            Do
    '                Dim linea As String = fileReader.ReadLine

    '                If linea.Trim.Length = 0 Then
    '                    Exit Do
    '                End If

    '                Lista.Add(linea)

    '                If fileReader.EndOfStream Then
    '                    Exit Do
    '                End If

    '            Loop
    '        End If
    '        Return Lista
    '    Catch Ex As Exception
    '        MessageBox.Show(Ex.Message)
    '        Return Lista
    '    End Try
    'End Function

    'Public Shared Sub RegistrarTalbcActiveX()
    '    Shell("Regsvr32 /s """ & Application.StartupPath & "\Talbc\TALBarCd.OCX""", AppWinStyle.Hide, True)
    'End Sub

    'Public Shared Sub AplicarCambiosBaseDatos()
    '    Dim NombreBasedeDatos As String = Controlador.Sesion.MiEmpresa.Empcat
    '    Dim Queries As New List(Of String), conn As SqlConnection = Nothing, Actualizar As Boolean = False

    '    Select Case My.Application.Info.Version.ToString
    '        'Case "1.0.14.39"
    '        '    Queries.Add("ALTER TABLE dbo.ConfiguracionFactura ADD" & _
    '        '     " DatosClienteCP_C int NOT NULL CONSTRAINT DF_ConfiguracionFactura_DatosClienteCP_C DEFAULT 0," & _
    '        '     " DatosClienteCP_R int NOT NULL CONSTRAINT DF_ConfiguracionFactura_DatosClienteCP_R DEFAULT 0")
    '        '    Actualizar = True
    '    End Select

    '    If Actualizar Then
    '        Try
    '            conn = New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)
    '            conn.Open()
    '            'Dim dt As DataTable = conn.GetSchema("Tables")
    '            Dim Comando As New SqlCommand()
    '            Comando.Connection = conn

    '            For Each Querie As String In Queries
    '                Comando.CommandText = Querie.Replace("GO", " ")
    '                Comando.ExecuteNonQuery()
    '            Next
    '            MsgBox("Actualizacion de Estructura de base de datos aplicada")
    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
    '        End Try
    '    End If
    'End Sub

    'Public Shared Function RunControlException(ByVal Objeto As Object, ByVal Metodo As String, Optional ByVal Parametros As Object() = Nothing) As Object
    '    Return ClasesNegocio.BusinessException.Run(Objeto, Metodo, Parametros, Controlador.Sesion, Application.StartupPath)
    'End Function

    'Public Shared Function RunControlException(ByVal Objeto As Object, ByVal Metodo As String, ByVal Parametros As Collection) As Object
    '    Dim Parameters As Object = Nothing

    '    If Parametros.Count > 0 Then
    '        Dim Par(Parametros.Count - 1) As Object
    '        Parameters = Par

    '        For i As Integer = 0 To Parametros.Count - 1
    '            Parameters(i) = Parametros.Item(i + 1)
    '        Next
    '    End If
    '    Return ClasesNegocio.BusinessException.Run(Objeto, Metodo, Parameters, Controlador.Sesion, Application.StartupPath)
    'End Function

    'Friend Shared Sub ValidarEntradaNumerosEnteros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Not IsNumeric(e.KeyChar) And Not e.KeyChar = vbBack Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Friend Shared Sub ValidarEntradaNumerosDecimales(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = vbBack AndAlso Not e.KeyChar = "." Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = "." AndAlso CType(sender, Control).Text.Contains(".") Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Friend Shared Sub DataGridViewComboBoxEditingControl_SelectionChangeCommitted(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim Grid As DataGridView = CType(CType(sender, DataGridViewComboBoxEditingControl).Parent.Parent, DataGridView)

    '    If CType(sender, DataGridViewComboBoxEditingControl).SelectedValue IsNot Nothing Then
    '        Dim Coleccion As New Collection()

    '        Coleccion.Add(CType(sender, DataGridViewComboBoxEditingControl).SelectedValue)
    '        CType(sender.Parent.Parent, DataGridView).EndEdit()

    '        If Grid.CurrentCell.Value Is Nothing Then
    '            Grid.CurrentCell.Value = Coleccion(1)
    '        ElseIf Grid.CurrentCell.Value <> Coleccion.Item(1) Then
    '            Grid.CurrentCell.Value = Coleccion(1)
    '        End If

    '        If Grid.CurrentCell.ColumnIndex + 1 < Grid.Columns.Count Then
    '            For i As Integer = Grid.CurrentCell.ColumnIndex + 1 To Grid.Columns.Count - 1
    '                If Grid.CurrentRow.Cells(i).Visible AndAlso Not Grid.CurrentRow.Cells(i).ReadOnly Then
    '                    Grid.CurrentCell = Grid.CurrentRow.Cells(i)
    '                    Exit Sub
    '                End If
    '            Next
    '        End If
    '    End If
    'End Sub

    'Public Shared Sub Forma_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Forma As Form = CType(sender, Form)
    '    Forma.AutoValidate = Windows.Forms.AutoValidate.Inherit
    'End Sub

    'Public Shared Sub Forma_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim Forma As Form = CType(sender, Form)
    '    Forma.AutoValidate = Windows.Forms.AutoValidate.Disable
    'End Sub

    'Public Shared Sub EnviarCorreo(ByVal ServidorHost As String, ByVal Puerto As Integer, ByVal Mensaje As System.Net.Mail.MailMessage)
    '    Dim Mail As New System.Net.Mail.SmtpClient(ServidorHost, Puerto)
    '    Mail.Send(Mensaje)
    '    'Dim Mail As New System.Net.Mail.SmtpClient("integra-01", 26)
    '    'Mail.Send("pepe@integra-01", "jorgephantom@integra-01", "hola", "nada")
    'End Sub

End Class
