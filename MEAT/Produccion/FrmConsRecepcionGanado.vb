Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CN = ClasesNegocio

Public Class FrmConsRecepcionGanado

    Dim Recepciones As New CN.RecepcionGanadoColeccion
    Private Sub DgvRecepcionGanado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvRecepcionGanado.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim tb As New DataTable
        Dim dr() As DataRow = tb.Select("")
        Dim roww As DataGridViewRow = DgvRecepcionGanado.CurrentRow
        Dim string11 As String
        string11 = CStr(roww.Cells("Estatus").Value)
        FrmRecepciondeGanado.lblEstatus.Text = string11
    End Sub

    Private Sub FrmConsRecepcionGanado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DgvRecepcionGanado.AutoGenerateColumns = False
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Recepciones.Obtener(Me.txtIntroductor.Text, Me.DtpFechaInicio.Value, Me.DtpFechaFin.Value.AddDays(1))
        Me.DgvRecepcionGanado.DataSource = Recepciones

    End Sub

    Private Sub txtIntroductor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntroductor.TextChanged
        Try
            Buscar()
            'Dim Filtro As New OC.PredicateExpression
            'Dim rel As New OC.RelationCollection

            'rel.Add(EC.RecepcionGanadoEntity.Relations.MfacCatClientesEntityUsingIdCliente, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            'Filtro.Add(New SD.LLBLGen.Pro.ORMSupportClasses.FieldBetweenPredicate(HC.RecepcionGanadoFields.FechaRecepcion, _
            '            Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            'Filtro.Add(HC.MfacCatClientesFields.Nombre Mod String.Format("%{0}%", Me.txtIntroductor.Text))

            'Dim col As New CC.RecepcionGanadoCollection

            'col.GetMulti(Filtro, rel)

            'Recepciones.RellenarMe(col)

            ''Recepciones.Obtener(Me.txtIntroductor.Text, Me.DtpFechaInicio.Value, Me.DtpFechaFin.Value.AddDays(1))
            'Me.DgvRecepcionGanado.DataSource = Recepciones
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.txtIntroductor.Clear()
        Me.DtpFechaFin.Value = Now
        Me.DtpFechaInicio.Value = Now
        Me.chkFiltrarFecha.Checked = False
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkFiltrarFecha.Checked
    End Sub

    Private Sub Buscar()
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            Dim cadenaConsulta As String = "SELECT usrProdRecepcionGanado.LoteRecepcion, usrProdRecepcionGanado.LoteEngorda, " & _
                                            "usrProdRecepcionGanado.CantCabezas, usrProdRecepcionGanado.FechaRecepcion, " & _
                                            "usrProdRecepcionGanado.IdCliente, MFacCatClientes.Nombre AS NombreIntroductor, " & _
                                            "usrProdRecepcionGanado.KilosEnviados, usrProdRecepcionGanado.KilosRecibidos, usrProdRecepcionGanado.Conductor, " & _
                                            "usrProdRecepcionGanado.Unidad, usrProdRecepcionGanado.Placas, usrProdRecepcionGanado.Observaciones, " & _
                                            "usrProdRecepcionGanado.Estatus, CASE usrProdRecepcionGanado.Estatus WHEN 'V' THEN 'VIGENTE' WHEN 'S' THEN 'SACRIFICADO' WHEN 'X' THEN 'CANCELADO' END as EstatusStr " & _
                                            "FROM usrProdRecepcionGanado INNER JOIN MFacCatClientes ON usrProdRecepcionGanado.IdCliente = " & _
                                            "MFacCatClientes.IdCliente "
            cadenaConsulta &= " WHERE "

            If Me.chkFiltrarFecha.Checked Then
                cadenaConsulta &= String.Format(" usrProdRecepcionGanado.FechaRecepcion BETWEEN  '{0}' AND '{1}' AND ", Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString)
            End If

            cadenaConsulta &= String.Format(" MFacCatClientes.Nombre LIKE '%{0}%'", Me.txtIntroductor.Text.Trim)

            Dim sqlcom As New SqlClient.SqlCommand(cadenaConsulta, sqlCon)
            Dim adp As New SqlClient.SqlDataAdapter(sqlcom)
            Dim tb As New DataTable

            sqlCon.Open()

            adp.Fill(tb)

            Me.DgvRecepcionGanado.DataSource = tb
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las recepciones", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If

            sqlCon.Dispose()
        End Try
    End Sub
End Class