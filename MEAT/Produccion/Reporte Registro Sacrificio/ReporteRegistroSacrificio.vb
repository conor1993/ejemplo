Imports CN = ClasesNegocio
Public Class ReporteRegistroSacrificio

    Dim Registros As New CN.RegistroSacrificioColeccionClass
    Dim Introductores As New CN.ClientesIntroductoresColeccion

    Private m_Busqueda As Boolean = False
    Public Property Busqueda() As Boolean
        Get
            Return m_Busqueda
        End Get
        Set(ByVal value As Boolean)
            m_Busqueda = value
        End Set
    End Property

    Private Sub ReporteRegistroSacrificio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Introductores.Obtener(True)
        Me.CmbIntroductor.DisplayMember = "Nombre"
        Me.CmbIntroductor.ValueMember = "Codigo"
        Me.CmbIntroductor.DataSource = Introductores
        Me.CmbIntroductor.SelectedIndex = -1
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        If Me.txtLoteSacrificio.Text <> "" Or Me.CmbIntroductor.SelectedIndex > -1 Then
            Registros.Obtener(Me.txtLoteSacrificio.Text, Me.CmbIntroductor.SelectedValue)
        Else
            Registros.Obtener(Me.DtpFechaInicio.Value, DtpFechaFinal.Value.AddDays(1))
        End If
        Me.DgvSacrificios.AutoGenerateColumns = False
        Me.DgvSacrificios.DataSource = Registros
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim Previsualizar As New CN.PreVisualizarForm
        Previsualizar.Reporte = Registros.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnom, "Produccion/Registro Sacrificios")
        Previsualizar.ShowDialog()
    End Sub

    Private Sub DgvSacrificios_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSacrificios.CellDoubleClick
        If Busqueda Then
            If e.RowIndex > -1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
End Class