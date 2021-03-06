Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient


Public Class frmDistribuciondeGastos
    Public Shared valor As Decimal
    Public Shared idpoliza As Integer
    Public Shared idsucursal As Integer
    Public Shared idmetodoprorrateo As Integer
    Public Shared idcuentacontable As Integer
    Public Shared importe As Decimal
    Public Shared ptjimporte As Decimal
    Public Shared conteo As Decimal
#Region "propiedades publicas"
    Public Property valor1 As Decimal
        Get
            Return valor
        End Get
        Set(value As Decimal)
            valor = value
        End Set
    End Property
    Public Property poliza As Integer
        Get
            Return idpoliza
        End Get
        Set(value As Integer)
            idpoliza = value
        End Set
    End Property
    Public Property sucursal As Integer
        Get
            Return idsucursal
        End Get
        Set(value As Integer)
            idsucursal = value
        End Set
    End Property
    Public Property metodo As Integer
        Get
            Return idmetodoprorrateo
        End Get
        Set(value As Integer)
            idmetodoprorrateo = value
        End Set
    End Property
    Public Property cuenta As Integer
        Get
            Return idcuentacontable
        End Get
        Set(value As Integer)
            idcuentacontable = value
        End Set
    End Property
    Public Property importe1 As Decimal
        Get
            Return importe
        End Get
        Set(value As Decimal)
            importe = value
        End Set
    End Property
    Public Property porcentaje As Decimal
        Get
            Return ptjimporte
        End Get
        Set(value As Decimal)
            ptjimporte = value
        End Set
    End Property
    Public Property filas As Integer
        Get
            Return conteo
        End Get
        Set(value As Integer)
            conteo = value
        End Set
    End Property
#End Region


    Private Sub frmDistribuciondeGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If idpoliza <> 0 Then
                Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
                Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)
                For i As Integer = 0 To conteo - 1
                    dgvMetodos.Rows.Add()
                    dgvMetodos.Rows(i).Cells(clmSucursal.Index).Value = idsucursal
                    dgvMetodos.Rows(i).Cells(clmMetodoProrrateo.Index).Value = idmetodoprorrateo
                    dgvMetodos.Rows(i).Cells(clmImporte.Index).Value = valor1
                    'dgvMetodos.Rows.Add()
                Next
                Dim Metodo As New CN.MetodoProrrateoClass
                Metodo.Obtener(Me.dgvMetodos.CurrentRow.Cells(Me.clmMetodoProrrateo.Index).Value)
                Me.dgvDetalledeProrrateo.AutoGenerateColumns = True
                Me.dgvDetalledeProrrateo.DataSource = Metodo.Detalle

                'If e.ColumnIndex < Me.clmImporte.Index Then
                '    If Me.dgvMetodos.Rows(e.RowIndex).Cells(Me.clmMetodoProrrateo.Index).Value = 0 Then
                '        Exit Sub
                '    Else
                Dim total As Decimal
                total = valor1 / (dgvMetodos.Rows.Count - 1)

                For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                    If i <= 0 Then

                        dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString()

                    Else
                        dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString()

                    End If
                Next
                Dim Porcentaje As Decimal = 0
                Dim Importe As Decimal = 0

                For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                    Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                    Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = (total * Porcentaje) / 100

                Next
                'End If

                'End If
                Dim Sumaimporte As Decimal = 0
                Dim Sumaporentaje As Decimal = 0
                For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                    Sumaimporte = Sumaimporte + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmImporteDepartamento").Value
                    Sumaporentaje = Sumaporentaje + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmPorcentaje").Value
                Next
                Me.txtImporte.Text = Sumaimporte.ToString()
                Me.txtPorcentaje.Text = Sumaporentaje.ToString("N1")

            Else

            End If

            Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
            Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)

            'End If
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
                    total = valor1

                    For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                        If i <= 0 Then

                            dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString()

                        Else
                            dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString()
                            dgvMetodos.Columns(1).ReadOnly = True
                            dgvMetodos.Columns(0).ReadOnly = True


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

                dgvMetodos.Columns("clmImporte").ReadOnly = True


            End If
            Dim Sumaimporte As Decimal = 0
            Dim Sumaporentaje As Decimal = 0
            For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                Sumaimporte = Sumaimporte + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmImporteDepartamento").Value
                Sumaporentaje = Sumaporentaje + Me.dgvDetalledeProrrateo.Rows(i).Cells("ClmPorcentaje").Value

            Next
            Me.txtImporte.Text = Sumaimporte.ToString()
            Me.txtPorcentaje.Text = Sumaporentaje.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtPorcentaje.Text <> 100 Then
            MsgBox("El porcentaje de asignacion debe ser igual al 100% Favor de verificar", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    'Private Sub dgvMetodos_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMetodos.CellEnter
    '    If e.ColumnIndex = Me.clmPorcentaje.Index Then
    '        If String.IsNullOrEmpty(Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells("clmPorcentaje").Value) Then
    '            Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells("clmPorcentaje").Value = 0D
    '        End If
    '    End If
    'End Sub

    'Private Sub dgvDetalledeProrrateo_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvDetalledeProrrateo.KeyUp
    '    If e.KeyCode = Keys.Enter Then
    '        Dim test As Integer = 0
    '        'If String.IsNullOrEmpty(Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells("clmPorcentaje").Value) Then
    '        '    Me.dgvDetalledeProrrateo.Rows(e.RowIndex).Cells("clmPorcentaje").Value = 0D
    '        'End If
    '    End If
    'End Sub

    Private Sub dgvDetalledeProrrateo_CellEndEdit_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetalledeProrrateo.CellEndEdit
        Try
            If e.ColumnIndex = 2 Then

                Dim total As Decimal

                total = valor1 / (dgvMetodos.Rows.Count - 1)
                For i As Integer = 0 To dgvMetodos.Rows.Count - 1
                    If i <= 0 Then

                        dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString()
                    Else
                        dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString()

                    End If
                Next
                Dim Porcentaje As Decimal = 0
                For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1

                    Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                    Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = ((total * Porcentaje) / 100).ToString()
                Next
            ElseIf e.ColumnIndex = 3 Then
                Dim total As Decimal

                total = valor1 / (dgvMetodos.Rows.Count - 1)
                For i As Integer = 1 To dgvMetodos.Rows.Count - 1
                    If i <= 0 Then

                        dgvMetodos.Rows(i).Cells("clmImporte").Value = total.ToString()

                    Else
                        dgvMetodos.Rows(i - 1).Cells("clmImporte").Value = total.ToString()

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

            Me.txtImporte.Text = Sumaimporte.ToString()
            Me.txtPorcentaje.Text = Sumaporentaje.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
