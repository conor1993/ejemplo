Imports HC = Integralab.ORM.HelperClasses
Imports System.Data.SqlClient

'Joel Jimenez Carrillo
'02/07/2018
'busqueda  de cuentas(activo) para cierre contable
Public Class frmBusquedaCuentaCierre
    Public codigoCuenta As Integer
    Private Sub btnSelecionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecionar.Click
        seleccionarCodigoCuenta()
    End Sub
    'la cargar el formulario realiza la busqueda de las cuentas disponibles para el cierre
    Private Sub frmBusquedaCuentaCierre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT codigo, NomCuenta, (Cta + '-' + SubCta + '-' + SSubCta + '-' + SSSubCta) AS Cuenta, Naturaleza, SaldoAnoAnt, SaldoIniEjerc, " +
            "BooAfectable = CASE WHEN BooAfectable = 1 THEN 'Si' ELSE 'No' END, BooInactiva =  CASE WHEN BooInactiva = 1 THEN 'Si' ELSE 'No' END " +
            "from usrContCuentas  where Titulo = 3and BooAfectable = 1 and BooInactiva = 0"
        cargarDgv(query)
    End Sub
    'iguala  a la variable publica el codigo de la cuenta para pasarla al formualrio del cierre
    Private Sub seleccionarCodigoCuenta()
        Try
            codigoCuenta = dgvCuentasContables.CurrentRow.Cells("clmCodigo").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show("Debe seleccionar una cuenta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgvCuentasContables_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCuentasContables.DoubleClick
        seleccionarCodigoCuenta()
    End Sub

    Private Sub tbNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNombre.KeyPress
        Dim query As String = "SELECT codigo, NomCuenta, (Cta + '-' + SubCta + '-' + SSubCta + '-' + SSSubCta) AS Cuenta, Naturaleza, SaldoAnoAnt, SaldoIniEjerc, " +
            "BooAfectable = CASE WHEN BooAfectable = 1 THEN 'Si' ELSE 'No' END, BooInactiva =  CASE WHEN BooInactiva = 1 THEN 'Si' ELSE 'No' END " +
            "from usrContCuentas  where Titulo = 3 AND NomCuenta LIKE '%{0}%'"
        query = String.Format(query, tbNombre.Text)
        cargarDgv(query)
    End Sub

    'cargar el datagrid sin importar la busqueda que se utilice
    Private Sub cargarDgv(ByVal query As String)
        Dim tableCuentas As New DataTable()
        Using connectin As New SqlConnection(HC.DbUtils.ActualConnectionString)
            connectin.Open()
            dgvCuentasContables.AutoGenerateColumns = False
            Try
                Dim command As New SqlCommand(query, connectin)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(tableCuentas)
                adapter.Dispose()
                dgvCuentasContables.DataSource = tableCuentas
                dgvCuentasContables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al tratrar de cargar las cuentas contables: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            connectin.Close()
        End Using
    End Sub

    'para los eventos de keypress del los textbox cuentas
    Private Sub buscarKeydownCuenta()
        Dim query As String = "SELECT codigo, NomCuenta, (Cta + '-' + SubCta + '-' + SSubCta + '-' + SSSubCta) AS Cuenta, Naturaleza, SaldoAnoAnt, SaldoIniEjerc, " +
            "BooAfectable = CASE WHEN BooAfectable = 1 THEN 'Si' ELSE 'No' END, BooInactiva =  CASE WHEN BooInactiva = 1 THEN 'Si' ELSE 'No' END " +
            "from usrContCuentas  where Titulo = 1 AND Cta = '{0}' AND SubCta = '{1}' AND SSubCta = '{2}' AND SSSubCta = '{3}'"
        query = String.Format(query, tbCta.Text, tbSubCta.Text, tbSsubCta.Text, tbSssubCta.Text)
        cargarDgv(query)
    End Sub

    Private Sub tbSssubCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSssubCta.KeyPress
        buscarKeydownCuenta()
    End Sub

    Private Sub tbSsubCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSsubCta.KeyPress
        buscarKeydownCuenta()
    End Sub

    Private Sub tbSubCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSubCta.KeyPress
        buscarKeydownCuenta()
    End Sub

    Private Sub tbCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbCta.KeyPress
        buscarKeydownCuenta()
    End Sub
End Class