Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmCierreDiarioEngorda

#Region "Miembros"

#End Region

#Region "Metodos"

    Public Function Inicializar_Forma() As Boolean
        Controlador.ValidarCierreDiarioEngorda()
        lblFechaUltimoCierre.Text = Controlador.Configuracion.Engorda.FechaCierreEngorda.ToShortDateString
        lblFechaACerrar.Text = Controlador.Configuracion.Engorda.FechaCierreEngorda.AddDays(1).ToShortDateString
        Return True
    End Function

#End Region

#Region "Acciones del Menu"

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        If MessageBox.Show("Se Realizara el Cierre de Engorda, ¿Esta Seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Controlador.RealizarCierreDiarioEngorda(Trans)
            Trans.Commit()
            MessageBox.Show("El Cierre se ha realizado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
            Return True
        End If
    End Function

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub FrmCierreDiarioEngorda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Resultado As Object = Nothing

        Resultado = Utilerias.RunControlException(Me, "Inicializar_Forma")

        If Resultado Is Nothing OrElse Not Resultado Then
            Me.mtb.HabilitarGuardar = False
        End If
    End Sub

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar, mtb.ClickSalir
        If e.Button.Text = "Guardar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar CDE")
            Dim Resultado As Object = Nothing

            Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})

            If Resultado Is Nothing OrElse Not Resultado Then
                Trans.Rollback()
                Cancelar = True
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub

#End Region

End Class