Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports Microsoft.Win32

Public Class frmRetiroDeCaja
    Dim lnCantidad As Decimal = 0D
    Public Retiro = New CN.RetiroDeCajaClass
    Dim Turno As New CN.ControlTurnoClass()

    Public Sub New(ByVal Tipo As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.llenarComboConceptos(Tipo)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmRetiroDeCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                If BtnAceptar.Focused Then
                    e.Handled = False
                Else
                    e.Handled = True
                    SendKeys.Send(ChrW(Keys.Tab))
                End If
            Case Chr(27)
                BtnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub VentaPgoEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BtnAceptar.Enabled = False
        lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom
        'txtFondo.Focus()
        cmbConcepto.Focus()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim valor As Decimal
        If System.Decimal.TryParse(Me.txtFondo.Text, valor) Then
            If MessageBox.Show("¿Realizar el retiro de caja?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Return
            End If
            Turno = Utilerias.ObtenerControlTurnoActual()
            Retiro.CodUsuario = Controlador.Sesion.Usrndx
            Retiro.FechaHora = DateTime.Now
            Retiro.Importe = CDec(txtFondo.Text)
            Retiro.CodControlTurno = Turno.Id
            Retiro.IdConcepto = cmbConcepto.SelectedValue
            Retiro.Observaciones = txtObservaciones.Text

            If Retiro.Guardar() Then
                Try
                    Dim rep As New crRetiroTck
                    Dim concepto As New CN.ConceptoCajaClass
                    concepto.Obtener(cmbConcepto.SelectedValue)
                    rep.SetParameterValue("IdRetiro", Retiro.Id)
                    rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                    rep.SetParameterValue("IdControlTurno", Retiro.Id)
                    rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                    rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                    rep.SetParameterValue("Importe", Retiro.Importe)
                    rep.SetParameterValue("Concepto", concepto.Concepto)
                    rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                    rep.SetParameterValue("Copia", "")

                    rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora
                    'rep.PrintOptions.PrinterName = "TICKET"
                    rep.PrintToPrinter(1, False, 0, 0)
#If DEBUG Then
                    '.....prueba del ticket visualmente
                    Dim Prev As New ClasesNegocio.PreVisualizarForm
                    Prev.Reporte = rep
                    Prev.Text = "TICKET"
                    Prev.ShowDialog()
#End If
                    ''IMPRIME LA COPIA
                    rep = New crRetiroTck
                    rep.SetParameterValue("IdRetiro", Retiro.Id)
                    rep.SetParameterValue("Sucursal", Turno.Sucursal.DescripcionCorta)
                    rep.SetParameterValue("IdControlTurno", Retiro.Id)
                    rep.SetParameterValue("Cajero", Controlador.Sesion.MiUsuario.Usrnomcom)
                    rep.SetParameterValue("FechaHora", Retiro.FechaHora)
                    rep.SetParameterValue("Importe", Retiro.Importe)
                    rep.SetParameterValue("Concepto", concepto.Concepto)
                    rep.SetParameterValue("Observaciones", UCase(Retiro.Observaciones))
                    rep.SetParameterValue("Copia", "Copia")

                    rep.PrintOptions.PrinterName = Utilerias.ObtenerNomImpresora
                    'rep.PrintOptions.PrinterName = "TICKET"
                    rep.PrintToPrinter(1, False, 0, 0)
#If DEBUG Then
                    '.....prueba del ticket visualmente
                    Prev = New ClasesNegocio.PreVisualizarForm
                    Prev.Reporte = rep
                    Prev.Text = "TICKET"
                    Prev.ShowDialog()
#End If

                    rep.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Finally
                    MsgBox("El retiro se ha guadado con el codigo " + Retiro.Id.ToString, MsgBoxStyle.Information, Application.ProductName)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End Try
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub txtFondo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFondo.KeyPress
        If Not IsNumeric(Me.txtFondo.Text & e.KeyChar) Then
            If e.KeyChar <> "." Or txtFondo.Text.Contains(".") Then
                If Not e.KeyChar = Chr(Keys.Back) Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtFondo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFondo.TextChanged
        If Not (IsNumeric(Me.txtFondo.Text) Or txtFondo.Text.Trim = ".") Then
            Me.txtFondo.Text = ""
            Me.BtnAceptar.Enabled = False
        Else
            Dim lnCant As Decimal = 0
            If IsNumeric(Me.txtFondo.Text) Then lnCant = CDec(txtFondo.Text) Else lnCant = 0
            If (lnCant > 0) Then
                Me.BtnAceptar.Enabled = True
            Else
                Me.BtnAceptar.Enabled = False
            End If
        End If
    End Sub

    Public Sub llenarComboConceptos(ByVal Tipo As String)
        Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
        Filtro.Add(HC.ConceptoCajaFields.Tipo Mod String.Format("%{0}%", Tipo))
        Dim Conceptos = New ClasesNegocio.ConceptoCajaCollectionClass
        Try
            'DataGrid.AutoGenerateColumns = False
            Conceptos.Obtener(Filtro)
            cmbConcepto.DataSource = Conceptos
            cmbConcepto.ValueMember = "IdConCaja"
            cmbConcepto.DisplayMember = "Concepto"
            'Me.DataGrid.DataSource = Conceptos
            'ClmCodigo.DataPropertyName = "IdConCaja"
            'ClmTipo.DataPropertyName = "Tipo"
            'ClmConcepto.DataPropertyName = "Concepto"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class