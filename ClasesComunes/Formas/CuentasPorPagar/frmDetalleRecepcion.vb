Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class frmDetalleRecepcion
    Dim lnCantidad As Decimal = 0D
    Public Retiro = New CN.RetiroDeCajaClass
    Dim Turno As New CN.ControlTurnoClass()
    Dim IDRecep As Integer
    Dim RecepcionOCDetalles As CN.RecepcionOrdenCompraDetCollectionClass

    Public Sub New(ByVal IdRecepcionOC As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        IDRecep = IdRecepcionOC
        ' Me.llenarComboConceptos(Tipo)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dgvDetalleRecep.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvDetalleRecep.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRecep.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRecep.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRecep.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRecep.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvDetalleRecep.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub frmRetiroDeCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                BtnAceptar_Click(sender, New System.EventArgs())
            Case Chr(27)
                BtnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub VentaPgoEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.BtnAceptar.Enabled = False
        'lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom
        'txtFondo.Focus()
        dgvDetalleRecep.AllowUserToAddRows = False
        lblIdRecepcion.Text = IDRecep
        llenarGridDetalle()
        

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'Dim valor As Decimal
        'If System.Decimal.TryParse(Me.txtFondo.Text, valor) Then
        '    If MessageBox.Show("¿Realizar el retiro de caja?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
        '        Return
        '    End If
        '    Turno = Utilerias.ObtenerControlTurnoActual()
        '    Retiro.CodUsuario = Controlador.Sesion.Usrndx
        '    Retiro.FechaHora = DateTime.Now
        '    Retiro.Importe = CDec(txtFondo.Text)
        '    Retiro.CodControlTurno = Turno.Id
        '    Retiro.IdConcepto = cmbConcepto.SelectedValue
        '    Retiro.Observaciones = txtObservaciones.Text

        '    If Retiro.Guardar() Then
        '        Try
        '            Dim rep As New crRetiroTck
        '            Dim concepto As New CN.ConceptoCajaClass
        '            concepto.Obtener(cmbConcepto.SelectedValue)
        '            rep.SetParameterValue("IdRetiro", Retiro.Id)
        '            rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
        '            rep.SetParameterValue("IdControlTurno", Retiro.Id)
        '            rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
        '            rep.SetParameterValue("FechaHora", Retiro.FechaHora)
        '            rep.SetParameterValue("Importe", Retiro.Importe)
        '            rep.SetParameterValue("Concepto", concepto.Concepto)
        '            rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
        '            rep.PrintOptions.PrinterName = "TICKET"
        '            rep.PrintToPrinter(1, False, 0, 0)
        '            rep.Dispose()
        '        Catch ex As Exception
        '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '        Finally
        '            MsgBox("El retiro se ha guadado con el codigo " + Retiro.Id.ToString, MsgBoxStyle.Critical, "Error")
        '            Me.DialogResult = Windows.Forms.DialogResult.OK
        '        End Try
        '    End If
        'End If
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Public Sub llenarGridDetalle()
        RecepcionOCDetalles = New CN.RecepcionOrdenCompraDetCollectionClass
        'Dim RecepcionDetalles As New CN.RecepcionOrdenCompraDetCollectionClass
        Dim suma As Decimal = 0.0
        Dim dt As New DataTable
        'dgvDetalleRecep.AutoGenerateColumns = False
        Dim Filtro As New OC.PredicateExpression
        'Filtro.Add(HC.McomRecepcionOrdenCompraDetFields.IdRecepcionOrdenCompra = IDRecep)
        'RecepcionOCDetalles.Obtener(Filtro)
        RecepcionOCDetalles.Obtener(IDRecep)
        Dim col As New DataGridTextBoxColumn()
        dt.Columns.Add("NomProducto")
        dt.Columns.Add("Cantidad")
        dt.Columns.Add("Costo")
        dt.Columns.Add("Iva")
        dt.Columns.Add("Ieps")
        dt.Columns.Add("Descuento")
        dt.Columns.Add("Total")
        If RecepcionOCDetalles.Count = 0 Then
            MsgBox("Esta recepcion de compra no tiene ningun datalle de productos..", MsgBoxStyle.Information, "AVISO")
            Me.DialogResult = Windows.Forms.DialogResult.Abort
            Me.Close()
        End If
        For i As Integer = 0 To RecepcionOCDetalles.Count - 1
            Dim arr(6) As Object
            arr(0) = RecepcionOCDetalles(i).Producto.Descripcion
            arr(1) = RecepcionOCDetalles(i).Cantidad.ToString("N")
            arr(2) = RecepcionOCDetalles(i).Costo.ToString("N")
            If RecepcionOCDetalles(i).IVA = Nothing Then
                arr(3) = 0.0
            Else
                arr(3) = RecepcionOCDetalles(i).IVA.ToString("N")
            End If

            If RecepcionOCDetalles(i).Ieps = Nothing Then
                arr(4) = 0.0
            Else
                arr(4) = RecepcionOCDetalles(i).Ieps.ToString("N")
            End If
            arr(5) = RecepcionOCDetalles(i).Descuento.ToString("N")
            arr(6) = RecepcionOCDetalles(i).Total.ToString("N")
            suma = suma + RecepcionOCDetalles(i).Total
            dt.Rows.Add(arr)
            dgvDetalleRecep.DataSource = dt
            lblTotal.Text = suma.ToString("C02")
        Next
        dgvDetalleRecep.Columns(0).DataPropertyName = "NomProducto"
        dgvDetalleRecep.Columns(1).DataPropertyName = "Cantidad"
        dgvDetalleRecep.Columns(2).DataPropertyName = "Costo"
        dgvDetalleRecep.Columns(3).DataPropertyName = "Iva"
        dgvDetalleRecep.Columns(4).DataPropertyName = "Ieps"
        dgvDetalleRecep.Columns(5).DataPropertyName = "Descuento"
        dgvDetalleRecep.Columns(6).DataPropertyName = "Total"

       


       

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblIdRecepcion_Click(sender As System.Object, e As System.EventArgs) Handles lblIdRecepcion.Click

    End Sub

    Private Sub frmDetalleRecepcion_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                BtnAceptar.Focus()
        End Select

    End Sub
End Class