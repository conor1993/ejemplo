Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmAplicarNotadeCredito

#Region "Miembros"
    Public Factura As FacturasClientesCabClass
#End Region

#Region "Metodos"
    Public Sub InicializarForma()
        Dim Coleccion As New System.ComponentModel.BindingList(Of NotaCreditoDetClass)
        DgvNotas.AutoGenerateColumns = False
        txtCliente.Text = Factura.Cliente.Nombre
        txtFactura.Text = Factura.NoFactura

        For Each NotaDetalle As EC.NotaCreditoDetEntity In Factura.NotasCredito
            If CType(NotaDetalle.Estatus, NotaCreditoEnum) = NotaCreditoEnum.VIGENTE Then
                Dim NotDet As New NotaCreditoDetClass(NotaDetalle)
                NotDet.IsNew = False
                BuscarNotasPorAplicar(NotDet)
                Coleccion.Add(NotDet)
            End If
        Next
        DgvNotas.DataSource = Coleccion

        For Each Renglon As DataGridViewRow In DgvNotas.Rows
            If Renglon.Cells(clmAplicar.Index).Value Then
                Renglon.Cells(ClmTotal.Index).ReadOnly = False
                Renglon.Cells(ClmTotal.Index).Style.BackColor = Color.LightSalmon
            End If
        Next
    End Sub

    Private Sub BuscarNotasPorAplicar(ByVal NotDet As NotaCreditoDetClass)
        For Each NotaDetalle As NotaCreditoDetClass In Factura.NotasCreditoPorAplicar
            If NotaDetalle.FolNota = NotDet.FolNota And NotaDetalle.FolFactura = NotDet.FolFactura Then
                NotDet.Aplicar = True
                NotDet.Total = NotaDetalle.Total
            End If
        Next
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmAplicarNotadeCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Utilerias.RunControlException(Me, "InicializarForma")
        InicializarForma()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub clmAplicar_ValidateCheckState(ByVal sender As Object, ByVal e As Infragistics.Win.ValidateCheckStateEventArgs) Handles clmAplicar.ValidateCheckState
        If e.NewCheckState = CheckState.Checked Then
            DgvNotas.CurrentRow().Cells(ClmTotal.Index).ReadOnly = False
            DgvNotas.CurrentRow().Cells(ClmTotal.Index).Style.BackColor = Color.LightSalmon
        Else
            DgvNotas.CurrentRow().Cells(ClmTotal.Index).ReadOnly = True
            DgvNotas.CurrentRow().Cells(ClmTotal.Index).Style.BackColor = Color.White
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.Validate() Then
            Factura.NotasCreditoPorAplicar.Clear()

            For Each Renglon As DataGridViewRow In DgvNotas.Rows
                If Renglon.Cells(clmAplicar.Index).Value Then
                    Dim NotaDetalle As NotaCreditoDetClass = CType(Renglon.DataBoundItem, NotaCreditoDetClass)
                    Factura.NotasCreditoPorAplicar.Add(CType(NotaDetalle, EC.NotaCreditoDetEntity))
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
#End Region
End Class