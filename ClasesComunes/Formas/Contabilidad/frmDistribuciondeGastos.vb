Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Public Class frmDistribuciondeGastos

    Private Sub frmDistribuciondeGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
            Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDetalledeProrrateo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalledeProrrateo.CellEndEdit
       
    End Sub

    
    Private Sub dgvMetodos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMetodos.CellEndEdit
        Try
            Dim Metodo As New CN.MetodoProrrateoClass
            If e.ColumnIndex = Me.clmMetodoProrrateo.Index Then
                Metodo.Obtener(Me.dgvMetodos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Me.dgvDetalledeProrrateo.AutoGenerateColumns = False
                Me.dgvDetalledeProrrateo.DataSource = Metodo.Detalle
            End If            
            If e.ColumnIndex = Me.clmImporte.Index Then
                If Me.dgvMetodos.Rows(e.RowIndex).Cells(Me.clmMetodoProrrateo.Index).Value = 0 Then
                    Exit Sub
                Else
                    Dim Porcentaje As Decimal = 0
                    Dim Importe As Decimal = 0
                    Importe = Me.dgvMetodos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                    For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                        Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                        Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = Importe * (Porcentaje / 100)
                    Next
                End If
             
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class