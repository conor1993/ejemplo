Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmCambioCorral

#Region "Definiciones"

#End Region

#Region "Metodos"

    Public Sub Inicializar_Forma()
        cmbLote.DisplayMember = "Descripcion"
        cmbLote.ValueMember = "IdLote"
        cmbLote.DataSource = Controlador.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        cmbCorralNuevo.DisplayMember = "NombreCorral"
        cmbCorralNuevo.ValueMember = "IdCorral"
        cmbCorralNuevo.DataSource = Controlador.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.ENGORDA, EstatusAutorizada.NO, EstatusAutorizada.NO)
        Limpiar()
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Limpiar()
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
        cmbCorralNuevo.SelectedIndex = -1
        cmbCorralNuevo.Text = "Seleccione el Corral"
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim Lote As LoteClass = Nothing, Corral As CorralClass = Nothing

        If cmbLote.SelectedIndex <> -1 Then
            Lote = CType(cmbLote.SelectedItem, LoteClass)
        End If

        If cmbCorralNuevo.SelectedIndex <> -1 Then
            Corral = New CorralClass(CType(cmbCorralNuevo.SelectedItem, EC.McecatCorralesCabEntity))
        End If

        If Controlador.CambiarCorral(Lote, Corral, Trans) Then
            Trans.Commit()
            MessageBox.Show("Se ha realizado el cambio satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
            Inicializar_Forma()
        End If
    End Function

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar, mtb.ClickGuardar, mtb.ClickSalir
        If e.Button.Text = "Guardar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cambio de Corral")
            Dim Resultado As Object = Nothing

            Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})

            If Resultado Is Nothing OrElse Resultado = False Then
                Trans.Rollback()
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub

    Private Sub cmbLote_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.SelectedIndexChanged
        If sender.SelectedIndex <> -1 Then
            Dim Lote As LoteClass = CType(sender.SelectedItem, LoteClass)
            txtCorral.Text = Lote.NombreCorral
        Else
            txtCorral.ResetText()
        End If
    End Sub

    Private Sub FrmCambioCorral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

#End Region

End Class