Imports HC = Integralab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Public Class FrmAlmBusqMovAmacen
    Dim AlmacenesCol As New CN.AlmacenCollectionClass


    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "101101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "111100011"
            tbEstados.StateNuevo = "111010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            AlmacenesCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Me.CmbAlmacenes.ValueMember = "Codigo"
            Me.CmbAlmacenes.DisplayMember = "Descripcion"
            Me.CmbAlmacenes.DataSource = AlmacenesCol

            Me.ObtenerTiposMovimientos()

            Limpiar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        Me.CmbAlmacenes.SelectedIndex = -1
        Me.CmbMovimientos.SelectedIndex = -1
        Me.txtFolio.Text = ""
        Me.ChkFechas.Checked = True
        Me.DgvMovimientos.DataSource = Nothing
        Me.DgvDetalle.DataSource = Nothing
    End Sub

    Private Function Validar() As Boolean
        If Me.ChkFechas.Checked Then
            If Me.DtpFechaIni.Value > Me.DtpFechaFin.Value Then
                MessageBox.Show("La Fecha Inicial debe ser mayor o igual a la Fecha Final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Function Buscar() As Boolean
        Try
            Dim Filtro As New OC.PredicateExpression

            If Me.CmbAlmacenes.SelectedIndex > -1 Then
                Filtro.Add(HC.VwMovAmacenCabFields.AlmacenId = Me.CmbAlmacenes.SelectedValue)
            End If

            If Not Me.CmbMovimientos.SelectedIndex > -1 Then
                MessageBox.Show("Seleccione un Movimiento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If

            Dim ConfigAlm As New CC.InventarioConfiguracionCollection
            ConfigAlm.GetMulti(Nothing, 0, Nothing)
            If ConfigAlm.Count < 1 Then
                MessageBox.Show("Configure los movimientos de almacén para poder continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If

            Select Case Me.CmbMovimientos.SelectedIndex
                Case Is = 0
                    Filtro.Add(HC.VwMovAmacenCabFields.TipoMovimientoId = ConfigAlm(0).ExInventarioInicial)
                Case Is = 1
                    Filtro.Add(HC.VwMovAmacenCabFields.TipoMovimientoId = ConfigAlm(0).ExTraspaso)
                Case Is = 2
                    Filtro.Add(HC.VwMovAmacenCabFields.TipoMovimientoId = ConfigAlm(0).ExConsignacion)
                Case Is = 3
                    Filtro.Add(HC.VwMovAmacenCabFields.TipoMovimientoId = ConfigAlm(0).ExOtros)
            End Select

            If Not Me.txtFolio.Text = "" Then
                Filtro.Add(HC.VwMovAmacenCabFields.FolioMovimiento Mod String.Format("%{0}%", Me.txtFolio.Text))
            End If

            If Validar() Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwMovAmacenCabFields.Fecha, Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))
            End If

            Dim Vista As New TC.VwMovAmacenCabTypedView
            Vista.Fill(0, Nothing, False, Filtro)

            Me.DgvMovimientos.AutoGenerateColumns = False
            Me.DgvMovimientos.DataSource = Vista
            Me.DgvDetalle.DataSource = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ObtenerTiposMovimientos()
        Me.TMovCol.Clear()
        'Obtener la configuracion general del almacen
        Dim Conf As New CC.InventarioConfiguracionCollection
        Dim Tm As New CN.TipoMovimientoAlmacenCollectionClass 'Variable auxiliar
        Conf.GetMulti(Nothing)
        If Conf.Count > 0 Then
            Dim TMovCodigo As Integer = IIf(IsNothing(Conf(0).ExInventarioInicial), 0, Conf(0).ExInventarioInicial)
            If TMovCodigo <> 0 Then
                Tm.Obtener(TMovCodigo)
                If Tm.Count = 1 Then
                    Me.TMovCol.Add(Tm(0))
                End If
            End If
            TMovCodigo = IIf(IsNothing(Conf(0).ExTraspaso), 0, Conf(0).ExTraspaso)
            If (TMovCodigo <> 0) Then
                Tm.Obtener(TMovCodigo)
                If Tm.Count = 1 Then
                    Me.TMovCol.Add(Tm(0))
                End If
            End If
            TMovCodigo = IIf(IsNothing(Conf(0).ExConsignacion), 0, Conf(0).ExConsignacion)
            If TMovCodigo <> 0 Then
                Tm.Obtener(TMovCodigo)
                If Tm.Count = 1 Then
                    Me.TMovCol.Add(Tm(0))
                End If
            End If
            TMovCodigo = IIf(IsNothing(Conf(0).ExOtros), 0, Conf(0).ExOtros)
            If TMovCodigo <> 0 Then
                Tm.Obtener(TMovCodigo)
                If Tm.Count = 1 Then
                    Me.TMovCol.Add(Tm(0))
                End If
            End If
        End If
    End Sub

#End Region

    Private Sub ChkFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFechas.CheckedChanged
        If Me.ChkFechas.Checked Then
            Me.GrpFechas.Enabled = True
        Else
            Me.GrpFechas.Enabled = False
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        If Not Buscar() Then
            Cancelar = True
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DgvMovimientos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvMovimientos.Click
        Try
            If Me.DgvMovimientos.SelectedRows.Count > 0 Then
                Dim Folio As String = Me.DgvMovimientos.SelectedRows(0).Cells(Me.ClmFolio.Index).Value
                Dim Vista As New TC.VwMovAlmacenDetTypedView
                Vista.Fill(0, Nothing, False, HC.VwMovAlmacenDetFields.Folio = Folio)

                Me.DgvDetalle.AutoGenerateColumns = False
                Me.DgvDetalle.DataSource = Vista
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvMovimientos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvMovimientos.DataError

    End Sub

    Private Sub DgvMovimientos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvMovimientos.DoubleClick
        If Me.DgvMovimientos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub DgvMovimientos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvMovimientos.RowEnter
        Try
            If Me.DgvMovimientos.SelectedRows.Count > 0 Then
                Dim Folio As String = Me.DgvMovimientos.SelectedRows(0).Cells(Me.ClmFolio.Index).Value
                Dim Vista As New TC.VwMovAlmacenDetTypedView
                Vista.Fill(0, Nothing, False, HC.VwMovAlmacenDetFields.Folio = Folio)

                Me.DgvDetalle.AutoGenerateColumns = False
                Me.DgvDetalle.DataSource = Vista
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvDetalle_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgvDetalle.DataError

    End Sub

    Private Sub txtFolio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress
        Try
            If Me.txtFolio.Text.Length > 4 Then
                Buscar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DgvMovimientos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class