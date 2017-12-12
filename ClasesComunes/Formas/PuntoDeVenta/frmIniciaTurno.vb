Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class frmIniciaTurno
    Dim lnCantidad As Decimal = 0D
    Public ControlTurnoActual = New CN.ControlTurnoClass
    Dim Sucursal As New CN.SucursalClass()
    Dim cargacodsucursal As Boolean

    Private Sub frmPagoEfectivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Chr(13)
                BtnAceptar_Click(sender, New System.EventArgs())
            Case Chr(27)
                BtnCancelar_Click(sender, New System.EventArgs())
        End Select
    End Sub

    Private Sub VentaPgoEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Utilerias.ObtenerCodSucursal = 0 Then
            cargacodsucursal = False
            Exit Sub
        Else
            cargacodsucursal = True
        End If

        Me.BtnAceptar.Enabled = False
        Sucursal.Obtener(Utilerias.ObtenerCodSucursal())
        lblSucursal.Text = Sucursal.DescripcionCorta
        lblCajero.Text = Controlador.Sesion.MiUsuario.Usrnom
        lblFechaHora.Text = Format(DateTime.Now, "dd/MM/yyyy hh:mm:ss")
        txtFondo.Focus()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim valor As Decimal
        If System.Decimal.TryParse(Me.txtFondo.Text, valor) Then
            ControlTurnoActual.CodSucursal = Utilerias.ObtenerCodSucursal      ' pendiente programar lectura de sucursal
            ControlTurnoActual.CodUsuario = Controlador.Sesion.Usrndx
            ControlTurnoActual.FechaInicio = DateTime.Now
            ControlTurnoActual.FondoInicial = CDec(txtFondo.Text)
            If ControlTurnoActual.Guardar() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
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

    Private Sub frmIniciaTurno_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        If cargacodsucursal = False Then
            Me.Close()
            Me.Dispose()
        End If

    End Sub
End Class