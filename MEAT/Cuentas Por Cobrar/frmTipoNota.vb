Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient
Imports IntegraLab
Imports IntegraLab.FactDigital
Imports System.IO
Imports IntegraLab.CFDI.ComprobanteCfdiRelacionadosCfdiRelacionado
Imports System.Text
Public Class frmTipoNota

#Region "Miembros"
    Dim FacturaCabecero As FacturasClass
    Dim ClientesCol As ClientesIntroductoresColeccion
    Dim ProductosGenCol As ProductoCollectionClass
    Dim ConF As New CC.ConfiguracionFacturaCollection
    Dim NumRenglones As Integer
    Dim configurarImprecion As Boolean = True
    Dim SumaCargo As Decimal
    Dim SumaAbono As Decimal
    Dim Band As Boolean
    Dim PolizaACancelar As String
    Dim dtProdServ As New DataTable
    Dim dtUnidades As New DataTable
    Dim Buscarr As Boolean
    Dim frmNotas As FrmNotaCredito
#End Region

    Public Property FormPrincipal As FrmNotaCredito
        Get
            Return (frmNotas)
        End Get
        Set(ByVal value As FrmNotaCredito)
            frmNotas = value
        End Set
    End Property

    Private Sub frmTipoNota_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.frmNotas.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
        Try
            Dim Consultas As New frmBusquedaNotas
            Dim Clientes As New ClientesIntroductoresClass
            Dim ListaSalidas As New List(Of String)
            Dim i As Integer = 0
            Dim Poliza As New PolizaClass
            Dim PolizaDet As New PolizaDetalleClass

            Consultas.TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL

            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then

                FacturaCabecero = CType(Consultas.dgvFacturasCabecero.SelectedRows(0).DataBoundItem, FacturasClass)
                frmNotas.txtFolioFactura.Text = FacturaCabecero.NoFactura
                'Me.dgvDetalle.AutoGenerateColumns = False
                'Me.dgvDetalle.DataSource = FacturaCabecero.Detalles
                Clientes.Obtener(FacturaCabecero.CveCliente)
                frmNotas.txtCodigoCliente.Text = FacturaCabecero.CveCliente
                frmNotas.CmbCliente.Text = Clientes.Nombre
                frmNotas.txtlugarexpedicion.Text = FacturaCabecero.LugarExpedicion
                frmNotas.cmbUsoCFDI.SelectedValue = "G02" 'FacturaCabecero.UsoCfdi
                frmNotas.txtRFC.Text = Clientes.RFC
                'txtObservaciones.Text = Me.FacturaCabecero.ob
                frmNotas.cmbformadepago.SelectedValue = Me.FacturaCabecero.FormaPago
                frmNotas.cmbmetododepago.SelectedValue = Me.FacturaCabecero.MetodoPago
                frmNotas.txtNumCta.Text = Me.FacturaCabecero.NumCta
                frmNotas.txtSubTotal.Text = Me.FacturaCabecero.ImporteSubTotal.ToString("N2")
                frmNotas.txtDescuento.Text = Me.FacturaCabecero.ImporteDescuento.ToString("N2")
                frmNotas.txtIVA.Text = Me.FacturaCabecero.ImporteIVA.ToString("N2")
                frmNotas.txtTotal.Text = (Me.FacturaCabecero.ImporteSubTotal + Me.FacturaCabecero.ImporteIVA).ToString("N2")
                frmNotas.txtUUID.Text = Me.FacturaCabecero.Uuid
                frmNotas.txtObservaciones.Text = Me.FacturaCabecero.Observaciones
                frmNotas.txtDireccion.Text = Me.FacturaCabecero.Direccion
                If Me.FacturaCabecero.DiasCredito > 0 Then
                    frmNotas.rdCredito.Checked = True
                Else
                    frmNotas.rdContado.Checked = True
                End If
                frmNotas.txtDiasCredito.Text = Me.FacturaCabecero.DiasCredito.ToString()
                frmNotas.lblEstatus.Visible = True

                Buscarr = True

                'If FacturaCabecero.Estatus = EstatusFacturasEnum.ABONADA Then
                '    Me.lblEstatus.Text = "ABONADA"
                'End If

                'If FacturaCabecero.Estatus = EstatusFacturasEnum.CANCELADA Then
                '    Me.lblEstatus.Text = "CANCELADA"
                'End If
                'If FacturaCabecero.Estatus = EstatusFacturasEnum.PAGADA Then
                '    Me.lblEstatus.Text = "PAGADA"
                'End If
                'If FacturaCabecero.Estatus = EstatusFacturasEnum.VIGENTE Then
                '    Me.lblEstatus.Text = "VIGENTE"
                'End If
                If FacturaCabecero.Estatus = "V" Then
                    frmNotas.lblEstatus.Text = "VIGENTE"
                ElseIf FacturaCabecero.Estatus = "C" Then
                    frmNotas.lblEstatus.Text = "CANCELADA"
                End If


                'llenar datos del grid de detalle               
                frmNotas.dgvDetalle.AllowUserToAddRows = False
                For Each Detalle As FacturasDetalleClass In FacturaCabecero.Detalles
                    Dim Producto As New ProductoClass
                    frmNotas.clmDescripcionEspecial.Visible = True
                    frmNotas.clmProductoDes.Visible = False
                    If Detalle.IdProducto = 0 And Detalle.Descripcion = "" Then
                        Exit For
                    End If
                    If Detalle.IdProducto > 0 Then
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmCodigo.Index).Value = Detalle.IdProducto
                        Producto.Obtener(Detalle.IdProducto)
                        frmNotas.dgvDetalle.Rows.Add()
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmDescripcionEspecial.Index).Value = Producto.Descripcion
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmUnidad.Index).Value = Producto.UnidadMedida.Descripcion
                        frmNotas.clmCodigo.Visible = True
                        frmNotas.clmUnidad.Visible = True
                        frmNotas.OptProductos.Checked = True
                    Else
                        frmNotas.dgvDetalle.Rows.Add()
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmDescripcionEspecial.Index).Value = Detalle.Descripcion
                        frmNotas.clmCodigo.Visible = False
                        frmNotas.clmUnidad.Visible = False
                        frmNotas.OptExternos.Checked = True
                    End If
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmProductoServicio.Index).Value = Detalle.CveProductoServ
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmUnidadSat.Index).Value = Detalle.CveUnidad
                    If Detalle.IVA > 0 Then
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmConIVA.Index).Value = True
                    Else
                        frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmConIVA.Index).Value = False
                    End If
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmIVA.Index).Value = Detalle.IVA
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmIVAdecimales.Index).Value = Detalle.IVA
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmImporte.Index).Value = Detalle.Total
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmImporteDecimales.Index).Value = Detalle.Total


                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmCantidad.Index).Value = Detalle.CantidadxProducto
                    frmNotas.dgvDetalle.Rows(i).Cells(frmNotas.clmPrecio.Index).Value = Detalle.PrecioUnitario
                    'Me.dgvDetalle.Rows(i).Cells(Me.clmImporte.Index).Value = Detalle.CantidadxProducto * Detalle.PrecioUnitario
                    i = i + 1
                Next

                'llenar detalle de poliza
                i = 0
                frmNotas.dgvCuentasContables.AllowUserToAddRows = False
                If Poliza.Obtener(FacturaCabecero.FolPoliza) Then
                    PolizaACancelar = Poliza.NumeroPoliza
                    For Each DetallePol As PolizaDetalleClass In Poliza.Detalles2
                        frmNotas.dgvCuentasContables.Rows.Add()
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmCtaMayor.Index).Value = DetallePol.Cta
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmSubCta.Index).Value = DetallePol.SCta
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmSSubCta.Index).Value = DetallePol.SSCta
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmSSSubCta.Index).Value = DetallePol.SSSCta
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmDescripcion.Index).Value = DetallePol.CuentaContable.NombreCuenta
                        frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmCodigoCuenta.Index).Value = DetallePol.CuentaContable.Codigo
                        If DetallePol.Operacion2 = PolizaOperacionEnum2.C Then
                            frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmCargo.Index).Value = DetallePol.Importe
                            frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmAbono.Index).Value = CDec(0)
                        Else
                            frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmAbono.Index).Value = DetallePol.Importe
                            frmNotas.dgvCuentasContables.Rows(i).Cells(frmNotas.clmCargo.Index).Value = CDec(0)
                        End If
                        i = i + 1
                    Next
                End If
                frmNotas.calcular()

                'datos para el combo de domicilios fiscales
                frmNotas.ultcmbDomiciliosFiscales.DataSource = Clientes.DomiciliosFiscales
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdCliente").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdRenglon").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("IdPoblacion").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("Entidad").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("Contenedor").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("EsPrincipal").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("IndiceEnContenedor").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("Seleccionado").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("Cliente").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("Transaction").Hidden = True
                frmNotas.ultcmbDomiciliosFiscales.Rows.Band.Columns("ParticipatesInTransaction").Hidden = True

                If Clientes.DomiciliosFiscales.Count = 1 Then
                    frmNotas.ultcmbDomiciliosFiscales.Rows(0).Selected = True
                End If
                'Else
                '    frmNotas.Cancelar = True
            End If

        Catch ex As Exception
            'frmNotas.Cancelar = True
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class