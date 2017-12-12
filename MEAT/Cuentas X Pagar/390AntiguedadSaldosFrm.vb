Imports CN = ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports SP = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Public Class _390AntiguedadSaldosFrm

    Dim Proveedores As New CN.ProveedorCollectionClass
    Dim UltimaTecla As DateTime


    Private Sub _390AntiguedadSaldosFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "111001111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "111111111"
            MtbEstados.StateNuevo = "111010001"
            MtbEstados.StateGuardar = "100100001"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Busca las Facturas Registradas."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            ' Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Factura."
            'Me.mtb.Buttons(6).ToolTipText = "Guarda la Factura o los cambios que se le hayan Realizado."
            'Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Factura a Inactiva."
            'Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Factura."
            Me.mtb.Buttons(10).ToolTipText = "Imprime las Facturas Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "Codigo"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.CmbProveedor.SelectedIndex = -1
        Me.CmbProveedor.Text = "Seleccione un Proveedor"
        Me.dtpFechaCorte.Value = Now
    End Sub

    Private Function Imprimir() As CN.RptAntiguedadSaldos
        Dim Reporte As New CN.RptAntiguedadSaldos
        Dim ds As New DataSet
        ' Dim dt As CN.DsReporteAntiguedadSaldos.DtAntiguedadSaldosDataTable = Tabla
        ds.Tables.Add(SP.AntiguedadSaldosCxp(Me.dtpFechaCorte.Value, Me.CmbProveedor.SelectedValue))
        Reporte.SetDataSource(ds.Tables(0))
        Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Me.dtpFechaCorte.Value)
        Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnom)
        Reporte.SetParameterValue(3, "Cuentas Por Pagar / Reporte de Antigüedades de Saldo")
        Return Reporte
    End Function

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        If Not IsNothing(Me.CmbProveedor.SelectedValue) Then
            Me.DgvFacturas.AutoGenerateColumns = False
            Me.DgvFacturas.DataSource = SP.AntiguedadSaldosCxp(Me.dtpFechaCorte.Value, Me.CmbProveedor.SelectedValue)
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim previsualizar As New CN.PreVisualizarForm
        previsualizar.Reporte = Imprimir()
        previsualizar.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNothing(Me.CmbProveedor.SelectedValue) Then
                MsgBox("Seleccione un Proveedor")
            End If
        ElseIf e.KeyChar = Chr(Keys.F12) Then
            Proveedores.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, True)
            Me.CmbProveedor.ValueMember = "IDProveedor"
            Me.CmbProveedor.DataSource = Proveedores
            Me.CmbProveedor.DisplayMember = "RazonSocial"
            Me.CmbProveedor.SelectedIndex = -1
            Me.CmbProveedor.Text = "Seleccione un Proveedor..."
        Else
            Me.TmProveedor.Stop()
            Me.UltimaTecla = Now
            Me.TmProveedor.Start()
        End If
    End Sub

    Private Sub CmbProveedor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbProveedor.TextChanged

    End Sub

    Private Sub TmProveedor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmProveedor.Tick
        Try
            If Me.UltimaTecla.AddSeconds(1).ToShortDateString = Now.ToShortDateString Then
                Me.TmProveedor.Stop()
                Proveedores.Obtener(True, Me.CmbProveedor.Text.Trim, ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class