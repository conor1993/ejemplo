Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient


Public Class frmDistribuciondeGastos
    Public Shared valor As Decimal

    Public Property valor1 As Decimal
        Get
            Return valor
        End Get
        Set(value As Decimal)
            valor = valor
        End Set
    End Property
    Private Sub frmDistribuciondeGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    If PolizaDiario.txtPoliza.Text <> "" Then
        '        Try
        '            Dim sucursal As DataSet = New DataSet
        '            Dim queryString As String = "select * from MCatGenSucursales"
        '            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
        '            adapter.Fill(sucursal)
        '            'For i As Integer = 0 To dgvMetodos.Rows.Count - 1
        '            Me.dgvMetodos.Rows(0).Cells(clmSucursal.Index + 1).Value.DataSource = sucursal.Tables(0)
        '            Me.dgvMetodos.Rows(0).Cells(clmSucursal.Index + 1).Value.DisplayMember = "SCDescripcionCorta"
        '            Me.dgvMetodos.Rows(0).Cells(clmSucursal.Index + 1).Value.ValueMember = "SCldSucursal"
        '            'Next
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message)
        '        End Try
        '        Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)
        '        'Try
        '        '    Dim FormasPago As DataSet = New DataSet
        '        '    Dim queryString As String = "select Nom_Depto, det.Porcentaje from GastosDepartamentos as a join usrContCuentas on  IdCuentaContable= codigo join MetodoDet  as det   on IdMetodoProrrateo= Cod_Metodo join usrContPolizas as d  on d.Codigo = IdPoliza join MetodoCab as cab on cab.Codigo = det.Cod_Metodo join CatDeptos on Cve_Depto = Cod_CentroCosto where IdPoliza= 18"
        '        '    Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
        '        '    adapter.Fill(FormasPago)
        '        '    Me.CmbClaveSAT.DataSource = FormasPago.Tables(0)
        '        '    Me.CmbClaveSAT.DisplayMember = "clavesat"
        '        '    Me.CmbClaveSAT.ValueMember = "clave"
        '        'Catch ex As Exception
        '        '    MessageBox.Show(ex.Message)
        '        'End Try
        '    Else
        '        Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
        '        Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)
        '    End If
        Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
        Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub dgvDetalledeProrrateo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalledeProrrateo.CellEndEdit
        Try
            If e.ColumnIndex = 1 Then
                Dim total As Integer

                total = valor1 / (dgvMetodos.Rows.Count - 1)
                For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                    If i <= 0 Then

                        dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString("C2")
                    Else
                        dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString("C2")

                    End If
                Next
                Dim Porcentaje As Decimal = 0
                For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                    Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                    Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = ((total * Porcentaje) / 100).ToString("C2")
                Next
            ElseIf e.ColumnIndex = 2 Then
                Dim total As Integer

                total = (CDec(PolizaDiario.dgvPoliza.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) / (dgvMetodos.Rows.Count - 1)
                For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                    If i <= 0 Then

                        dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString("C2")
                    Else
                        dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString("C2")

                    End If
                Next
                Dim Porcentaje As Decimal = 0
                Dim Importe As Decimal = 0
                Importe = Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                    Porcentaje = CDec((Importe * 100) / total)
                    Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells(Me.clmPorcentaje.Index).Value = Porcentaje
                Next
            Else
                Exit Sub
            End If

            Dim Sumaimporte As Decimal = 0
            Dim Sumaporentaje As Decimal = 0
            For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                Sumaimporte = Sumaimporte + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmImporteDepartamento").Value
                Sumaporentaje = Sumaporentaje + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmPorcentaje").Value
            Next
            Sumaporentaje = Sumaporentaje / 100
            Me.txtImporte.Text = Sumaimporte.ToString("C2")
            Me.txtPorcentaje.Text = Sumaporentaje.ToString("P")

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvMetodos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMetodos.CellEndEdit

        Try
            Dim Metodo As New CN.MetodoProrrateoClass
            If e.ColumnIndex = Me.clmMetodoProrrateo.Index Then
                Metodo.Obtener(Me.dgvMetodos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                Me.dgvDetalledeProrrateo.AutoGenerateColumns = False
                Me.dgvDetalledeProrrateo.DataSource = Metodo.Detalle
            End If
            If e.ColumnIndex < Me.clmImporte.Index Then
                If Me.dgvMetodos.Rows(e.RowIndex).Cells(Me.clmMetodoProrrateo.Index).Value = 0 Then
                    Exit Sub
                Else
                    Dim total As Decimal
                    total = valor1 / (dgvMetodos.Rows.Count - 1)

                    For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                        If i <= 0 Then

                            dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString("C2")
                        Else
                            dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString("C2")

                        End If
                    Next
                    Dim Porcentaje As Decimal = 0
                    Dim Importe As Decimal = 0
                    Importe = Me.dgvMetodos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                    For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                        Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                        Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = (total * Porcentaje) / 100

                    Next
                End If

            End If
            Dim Sumaimporte As Decimal = 0
            Dim Sumaporentaje As Decimal = 0
            For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                Sumaimporte = Sumaimporte + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmImporteDepartamento").Value
                Sumaporentaje = Sumaporentaje + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmPorcentaje").Value
            Next
            Sumaporentaje = Sumaporentaje / 100
            Me.txtImporte.Text = Sumaimporte.ToString("C2")
            Me.txtPorcentaje.Text = Sumaporentaje.ToString("P1")
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

End Class
