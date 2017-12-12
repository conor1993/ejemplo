Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports ClasesNegocio

Public Class frmFoliosFacturas

#Region "Miembros"

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"

    Private Sub Validar()
        If Not IsNumeric(txtFolioInicial.Text.Trim) Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.FACTURACION_FOLIOS, 0)
        End If
    End Sub

    Public Sub Guardar(ByVal Trans As HC.Transaction)
        Validar()
        Controlador.Configuracion.FacturaFolios.FolioInicial = CType(txtFolioInicial.Text.Trim, Integer)
        Controlador.Configuracion.FacturaFolios.StaLetraSerie = txtSerie.Text.Trim
        Controlador.Configuracion.FacturaFolios.Guardar(Trans)
        Trans.Commit()

        MessageBox.Show("La Configuracion de folios se ha guardado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "Eventos"

    Private Sub frmFoliosFacturas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Controlador.Configuracion.ActualizarFacturaFolios(1)
        txtFolioInicial.Text = Controlador.Configuracion.FacturaFolios.FolioInicial
        txtSerie.Text = Controlador.Configuracion.FacturaFolios.StaLetraSerie
        txtConsecutivo.Text = Controlador.Configuracion.FacturaFolios.Consecutivo
    End Sub

    Private Sub Mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickGuardar
        Try
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "GuardarConf")

            Utilerias.RunControlException(Me, "Guardar", New Object() {Trans})
        Catch ex As BusinessException
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles Mtb.ClickSalir
        Me.Close()
    End Sub

#End Region

End Class