Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient


Public Class frmDistribuciondeGastosconsulta
    Public Shared valor As Decimal
    Public Shared idpoliza As Integer
    Public Shared factura As String
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
            Controlador.LlenarComboSucursales(clmSucursal, ClasesNegocio.CondicionEnum.ACTIVOS)
            Controlador.LlenarComboMetodosdeProrrateo(clmMetodoProrrateo)

            Dim datos As New DataSet
            Dim query = "EXEC  Consultardepartamentalizacion  '" + factura + "' , " + idcuentacontable.ToString()
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
                Me.dgvDetalledeProrrateo.AutoGenerateColumns = False
                Me.dgvDetalledeProrrateo.DataSource = datos.Tables(0)
                dgvMetodos.Rows(0).Cells(clmSucursal.Index).Value = datos.Tables(0).Rows(1).Item(2)
                dgvMetodos.Rows(0).Cells(clmMetodoProrrateo.Index).Value = datos.Tables(0).Rows(1).Item(3)
                dgvMetodos.Rows(0).Cells(clmImporte.Index).Value = datos.Tables(0).Rows(1).Item(4)
                Me.txtImporte.Text = datos.Tables(0).Rows(1).Item(4)
            End Using


  
            Dim total As Decimal
            valor1 = datos.Tables(0).Rows(1).Item(4)
            total = valor1 / (dgvMetodos.Rows.Count)


            Dim Porcentaje As Decimal = 0
            Dim Importe As Decimal = 0
            Dim Sumaimporte As Decimal = 0
            Dim Sumaporentaje As Decimal = 0
            Importe = dgvMetodos.Rows(0).Cells(clmImporte.Index).Value
            For i As Integer = 0 To Me.dgvDetalledeProrrateo.Rows.Count - 1
                Porcentaje = Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmPorcentaje.Index).Value
                Me.dgvDetalledeProrrateo.Rows(i).Cells(Me.clmImporteDepartamento.Index).Value = (total * Porcentaje) / 100
                Sumaimporte = Sumaimporte + ((total * Porcentaje) / 100)
                Sumaporentaje = Sumaporentaje + Porcentaje
            Next


            Me.txtPorcentaje.Text = Sumaporentaje.ToString()

            dgvMetodos.Enabled = True
            dgvDetalledeProrrateo.Enabled = True
        Catch ex As Exception

        End Try


    End Sub


    Private Sub dgvMetodos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMetodos.CellEndEdit

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
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

    End Sub
End Class
