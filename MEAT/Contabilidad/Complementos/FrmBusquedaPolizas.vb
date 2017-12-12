Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Public Class FrmBusquedaPolizas
    Dim Poliza As CN.PolizaClass

#Region "Propiedades"

    Private _OrigenDefault As CN.PolizaOrigenEnum = ClasesNegocio.PolizaOrigenEnum.TODOS
    Public Property Origen(Optional ByVal BloquearControl As Boolean = False) As CN.PolizaOrigenEnum
        Get
            Return _OrigenDefault
        End Get
        Set(ByVal value As CN.PolizaOrigenEnum)
            _OrigenDefault = value
            Me.GrpOrigen.Enabled = Not BloquearControl
        End Set
    End Property

    Private _TipoDefault As CN.PolizaTipoPolizaEnum = ClasesNegocio.PolizaTipoPolizaEnum.TODOS
    Public Property Tipo(Optional ByVal BloquearControl As Boolean = False) As CN.PolizaTipoPolizaEnum
        Get
            Return _TipoDefault
        End Get
        Set(ByVal value As CN.PolizaTipoPolizaEnum)
            _TipoDefault = value
            Me.GrpTipo.Enabled = Not BloquearControl
        End Set
    End Property
#End Region

    Private Sub FrmBusquedaPolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        'Buscar()
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        DgvPolizas.DataSource = Nothing
        txtNoPoliza.Text = ""
        DgvDetalles.DataSource = Nothing
        chkFechas.Checked = False
        rbtnVigentes.Checked = True
        'rbtnTodasEstatus.Checked = True

        Select Case Me.Origen
            Case ClasesNegocio.PolizaOrigenEnum.TODOS
                Me.rbtnTodasOrigen.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.ALMACEN
                Me.rbtnAlmacen.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.BANCOS
                Me.rbtnBancos.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.COMPRAS
                Me.rbtnCompras.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.CONTABILIDAD
                Me.rbtnContabilidad.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.CUENTASxCOBRAR
                Me.rbtnCxC.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
                Me.rbtnCxP.Checked = True
            Case ClasesNegocio.PolizaOrigenEnum.VENTAS
                Me.rbtnVentas.Checked = True
        End Select

        Select Case Me.Tipo
            Case ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
                Me.rbtnCancelacion.Checked = True
            Case ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
                Me.rbtnDiario.Checked = True
            Case ClasesNegocio.PolizaTipoPolizaEnum.EGRESO
                Me.RbtnEgreso.Checked = True
            Case ClasesNegocio.PolizaTipoPolizaEnum.INGRESO
                Me.RbtnIngreso.Checked = True
            Case ClasesNegocio.PolizaTipoPolizaEnum.TODOS
                Me.RbtnTodasTipo.Checked = True
        End Select
    End Sub

    Private Sub Buscar()
        Try
            Dim Vista As New TC.VwPolizasTypedView
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.VwPolizasFields.EmpresaId = Controlador.Sesion.Empndx)

            If Not Me.txtNoPoliza.Text = "" Then
                Filtro.Add(HC.VwPolizasFields.NumeroPoliza Mod String.Format("%{0}%", Me.txtNoPoliza.Text))
            End If

            If rbtnAlmacen.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.ALMACEN))
            End If

            If rbtnBancos.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.BANCOS))
            End If

            If rbtnCompras.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.COMPRAS))
            End If

            If rbtnContabilidad.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.CONTABILIDAD))
            End If

            If rbtnCxC.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.CUENTASxCOBRAR))
            End If

            If rbtnCxP.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.CUENTASxPAGAR))
            End If

            If rbtnVentas.Checked Then
                Filtro.Add(HC.VwPolizasFields.Origen = Chr(CN.PolizaOrigenEnum.VENTAS))
            End If

            If rbtnVigentes.Checked Then
                Filtro.Add(HC.VwPolizasFields.Estatus = CN.PolizaEstatusEnum.ACTIVA)
            End If

            If rbtnCanceladas.Checked Then
                Filtro.Add(HC.VwPolizasFields.Estatus = CN.PolizaEstatusEnum.CANCELADA)
            End If

            If rbtnCancelacion.Checked Then
                Filtro.Add(HC.VwPolizasFields.TipoPoliza = Chr(CN.PolizaTipoPolizaEnum.CANCELACION))
            End If

            If rbtnDiario.Checked Then
                Filtro.Add(HC.VwPolizasFields.TipoPoliza = Chr(CN.PolizaTipoPolizaEnum.DIARIO))
            End If

            If RbtnEgreso.Checked Then
                Filtro.Add(HC.VwPolizasFields.TipoPoliza = Chr(CN.PolizaTipoPolizaEnum.EGRESO))
            End If

            If RbtnIngreso.Checked Then
                Filtro.Add(HC.VwPolizasFields.TipoPoliza = Chr(CN.PolizaTipoPolizaEnum.INGRESO))
            End If

            If Validar() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwPolizasFields.FechaPoliza, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            Vista.Fill(0, Nothing, False, Filtro)

            Me.DgvPolizas.AutoGenerateColumns = False
            Me.DgvPolizas.DataSource = Vista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        If chkFechas.Checked Then
            If DtpFechaIni.Value > DtpFechaFin.Value Then
                MessageBox.Show("La Fecha Inicial debe ser menor o igual a la fecha final", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            Return True
        Else
            Return False
        End If
    End Function
#End Region


    Private Sub chkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFechas.CheckedChanged
        If chkFechas.Checked Then
            DtpFechaFin.Enabled = True
            DtpFechaIni.Enabled = True
        Else
            DtpFechaFin.Enabled = False
            DtpFechaIni.Enabled = False
        End If
    End Sub

    Private Sub DgvPolizas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvPolizas.Click
        Try
            If Me.DgvPolizas.SelectedRows.Count > 0 Then
                Poliza = New CN.PolizaClass(CInt(Me.DgvPolizas.SelectedRows(0).Cells(Me.clmCodPoliza.Index).Value))

                DgvDetalles.AutoGenerateColumns = False
                DgvDetalles.DataSource = Poliza.Detalles2
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If Me.DgvPolizas.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtNoPoliza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPoliza.KeyPress
        If txtNoPoliza.Text.Length > 4 Then
            Buscar()
        End If
    End Sub


    'Private Sub DgvPolizas_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvPolizas.RowEnter
    '    Try
    '        If Me.DgvPolizas.SelectedRows.Count > 0 Then
    '            Poliza = New CN.PolizaClass(CInt(Me.DgvPolizas.SelectedRows(0).Cells(Me.clmCodPoliza.Index).Value))

    '            DgvDetalles.AutoGenerateColumns = False
    '            DgvDetalles.DataSource = Poliza.Detalles2
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class