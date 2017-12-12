Imports CN = ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Public Class _390CancelacionPolizaPasivo
    Dim Poliza As CN.PolizaClass
    Private Sub _390CancelacionPolizaPasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Controlador.Sesion.MiEmpresa
                Me.lblEmpresa.Text = .Empnom
            End With
            Me.Icon = MdiParent.Icon
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = ""
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = ""
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            Me.mtb.Buttons(0).ToolTipText = "Abre una ventana de busqueda de polizas de Diario."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(4).ToolTipText = "Genera una la poliza de cancelación de la poliza de pasivo"
            Me.mtb.Buttons(10).ToolTipText = "Imprime la Poliza de Cancelación de Auxiliar de Pasivo"
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."

            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")


            Limpiar()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        txtAbono.Text = ""
        txtCargo.Text = ""
        txtConcepto.Text = ""
        txtImporte.Text = 0D
        txtPoliza.Text = ""
        DtpFecha.Value = Now
        Grid.DataSource = Nothing
        lblEstatus.Visible = False
    End Sub

    Private Sub Sumar()
        Dim Cargo As Decimal = 0D
        Dim Abono As Decimal = 0D

        For i As Integer = 0 To Grid.Rows.Count - 1
            With Grid.Rows(i)
                Cargo += .Cells(Me.clmCargo.Index).Value
                Abono += .Cells(Me.clmAbono.Index).Value
            End With
        Next

        txtCargo.Text = Cargo.ToString("C2")
        txtAbono.Text = Abono.ToString("C2")
    End Sub
#End Region
    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Ventana As New FrmBusquedaPolizas
            Ventana.Icon = Me.Icon
            Ventana.Origen(True) = ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
            Ventana.Tipo(True) = ClasesNegocio.PolizaTipoPolizaEnum.DIARIO
            Dim CodPoliza As String
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Me.txtCta.Text = VtaBuscaPolizas.gridCuentas.SelectedRows(0).Cells("Cta").Value
                CodPoliza = Ventana.DgvPolizas.SelectedRows(0).Cells(Ventana.clmCodPoliza.Index).Value
                Poliza = New CN.PolizaClass
                Poliza.Obtener(CodPoliza)

                Me.lblEstatus.Text = Poliza.Estatus.ToString
                Me.lblEstatus.Visible = True

                Me.txtConcepto.Text = Poliza.Concepto
                Me.txtPoliza.Text = Poliza.NumeroPoliza
                Me.txtImporte.Text = Poliza.Importe.ToString("C2")
                Me.DtpFecha.Value = Poliza.FechaPoliza

                Me.GroupBox1.Enabled = True
                Me.txtConcepto.Enabled = False

                Me.Grid.AutoGenerateColumns = False
                Grid.DataSource = Poliza.Detalles2

                Sumar()
                ' EstadoForma = "Buscando"
                'txtImporteCuenta.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cancelar Poliza")
        Try
            Dim PolizaAux As CN.PolizaClass
            If Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.CANCELADA Then
                MessageBox.Show("No se puede cancelar la poliza, debido a que ya se encuentra cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Cancelar = True
                Exit Sub
            End If
            If MessageBox.Show("¿Esta seguro de cancelar la poliza?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancelar = True
                Exit Sub
            End If

            Dim Facturas As New CC.UsrCxpfacturasCabCollection
            Facturas.GetMulti(HC.UsrCxpfacturasCabFields.IdPoliza = Poliza.Codigo)

            If Facturas.Count > 0 Then
                For Each Fact As EC.UsrCxpfacturasCabEntity In Facturas
                    Fact.Contabilizada = "N"
                    Fact.FechaContabilizacion = Nothing
                    Fact.IdPoliza = Nothing
                    Trans.Add(Fact)
                    If Not Fact.Save Then
                        Trans.Rollback()
                        Cancelar = True
                        MessageBox.Show("No se pudo generar la poliza de cancelación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next

                Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.CANCELADA
                If Not Poliza.Guardar2(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    MessageBox.Show("No se pudo generar la poliza de cancelación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                PolizaAux = New CN.PolizaClass
                PolizaAux.EmpresaId = Poliza.EmpresaId
                PolizaAux.TipoPoliza = ClasesNegocio.PolizaTipoPolizaEnum.CANCELACION
                PolizaAux.FechaCaptura = Now
                PolizaAux.FechaPoliza = Now
                PolizaAux.Importe = Poliza.Importe
                PolizaAux.Origen = ClasesNegocio.PolizaOrigenEnum.CUENTASxPAGAR
                PolizaAux.TipoError = ClasesNegocio.ErroresPolizaEnum.NINGUNO
                PolizaAux.TipoCambio = 1
                PolizaAux.Referencia = Poliza.Codigo
                PolizaAux.Mes = Now.Month
                PolizaAux.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                PolizaAux.Concepto = "Cancelacion de la Poliza: " & Poliza.Codigo

                For Each polDet As CN.PolizaDetalleClass In Poliza.Detalles2
                    Dim Det As New CN.PolizaDetalleClass
                    Det.Posicion = polDet.Posicion
                    Det.CuentaContable = polDet.CuentaContable
                    Det.Importe = polDet.Importe

                    If polDet.Operacion2 = CN.PolizaOperacionEnum2.C Then
                        Det.Operacion2 = CN.PolizaOperacionEnum2.A
                    Else
                        Det.Operacion2 = CN.PolizaOperacionEnum2.C
                    End If
                    PolizaAux.Detalles2.Add(Det)
                Next

                If Not PolizaAux.Guardar2(Trans) Then
                    Trans.Rollback()
                    Cancelar = True
                    MessageBox.Show("No se pudo generar la poliza de cancelación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Poliza.Estatus = ClasesNegocio.PolizaEstatusEnum.ACTIVA
                    Exit Sub
                End If
            Else
                Trans.Rollback()
                MessageBox.Show("La poliza que selecciono no es una poliza auxiliar de pasivo, seleccione otra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Trans.Commit()
            MessageBox.Show("Se genero la poliza de cancelacion con el número: " & PolizaAux.NumeroPoliza, "¡Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
            Me.GroupBox1.Enabled = False
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class