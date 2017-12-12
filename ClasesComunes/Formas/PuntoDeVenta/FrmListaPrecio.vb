Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
'Inicia codigo agregado version 1.2.0.03
Imports System.Data.SqlClient
'Termina codigo agregado version 1.2.0.03
Imports System.Windows.Forms
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports Integralab.ORM.EntityClasses

Public Class FrmListaPrecio

#Region "Declaraciones"
    Private puedorefrescar As Boolean = True
    Private Editar As Boolean = False
    Private seleccionado As Boolean = False
    Private buscando As Boolean = False
    Private nuevo As Boolean = False
    Private WithEvents listaprecio As New ClasesNegocio.ListaPrecioClass
    Private ListaBase As New ClasesNegocio.ListaPrecioClass
    Private listaprecioCol As New ClasesNegocio.ListaPrecioCollectionClass
    'Inicia Codigo agregado version 1.2.0.03
    Dim tablaDetalle As New DataTable
    Dim dv As DataView
    'Termina codigo agregado version 1.2.0.03
#End Region

    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtPlaza.Focus()
        End If
    End Sub

    Private Sub TxtPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPlaza.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.TxtPlaza.Text) Then
                Me.CmbPlaza.SelectedValue = CInt(Me.TxtPlaza.Text)
                Me.TxtDescripcion.Focus()
            Else
                Me.CmbPlaza.SelectedIndex = -1
                Me.CmbPlaza.Text = ""
            End If
        End If
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CmbPlaza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPlaza.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescripcion.Focus()
            If CmbPlaza.Text = "" Then
                MsgBox("Seleccione una Plaza . . . ", MsgBoxStyle.Exclamation, "Aviso")
                CmbPlaza.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtDescCorta.Focus()
            If TxtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Descripción ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDescCorta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescCorta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            ChkBase.Focus()
            If TxtDescCorta.Text = "" Then
                MsgBox("Agregue Información a Descripción Corta ", MsgBoxStyle.Exclamation, "Aviso")
                TxtDescCorta.Focus()
            End If
        End If
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub ChkBase_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkBase.KeyPress
        If e.KeyChar = Chr(13) Then
            ChkBase.Checked = Not ChkBase.Checked
            Me.SelectNextControl(sender, True, True, False, True)
            'ChkCaduca.Focus()
        End If
    End Sub

    Private Sub DtpFechaDe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaDe.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DtpFechaA.Focus()
        End If
    End Sub

    Private Sub DtpFechaA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechaA.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtPreVta1.Focus()
        End If
    End Sub

    Private Sub TxtUtilidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUtilidad.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DGDetalle.Focus()
            Dim Util As Decimal = Me.TxtUtilidad.Text
            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim x As ClasesNegocio.ListaPrecioDetalleClass
                x = DirectCast(DGDetalle.SelectedRows(i).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)
                Dim costo As Decimal = x.Costo
                Dim cp As Decimal = x.ComisionP
                If costo = 0 Then
                    MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & _
                    x.Producto.ToString & " es = 0," & _
                    Chr(13) & "los cambios no surtiran efecto sobre el", MsgBoxStyle.Exclamation, "Aviso")
                    Continue For
                Else
                    x.Utilidad = (Util).ToString("0.00")
                    x.PrecioVentaC = (costo + Util).ToString("0.00")
                    x.PrecioVentaP = ((Util / costo) * 100).ToString("0.00")
                    x.ComicionC = ((cp / 100) * Util).ToString("0.00")
                    'Dim cc As Decimal = x.ComicionC
                    'x.ComisionP = ((cc / Util) * 100).ToString("0.00")
                    LimpiarCaja()
                    DGDetalle.Focus()
                End If
            Next
            listaprecio.Detalle.ResetBindings()
        End If

        'Limite de Decimales 0.##
        Dim NDecimales As Integer = 2
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6
        'Si no presiona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtUtilidad.Text.IndexOf(".") >= 0 Then
                    e.Handled = True
                End If
            Else
                'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                If Me.TxtUtilidad.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtUtilidad.Text.Length - Me.TxtUtilidad.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtUtilidad.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtPreVta1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPreVta1.KeyPress
        If e.KeyChar = Chr(13) And DGDetalle.RowCount > 0 And TxtPreVta1.Text.Trim() <> "" Then
            Me.SelectNextControl(sender, True, True, False, True)
            DGDetalle.Focus()
            Dim PreVta1 As Decimal = Me.TxtPreVta1.Text

            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim x As New ClasesNegocio.ListaPrecioDetalleClass
                x.Obtener(1, CInt(DGDetalle.SelectedRows(i).Cells(LPdIdProducto.Index).Value))

                If x.Producto.EsKit Then
                    Dim TotKit As Double = 0D
                    Dim kitcol As New ClasesNegocio.DetalleKitCollectionClass
                    kitcol.Obtener(HC.DetalleKitPvFields.IdKit = x.Producto.Codigo)
                    For Each row As ClasesNegocio.DetalleKitClass In kitcol
                        TotKit += (ObtenerCosto(row.IdProd) * row.Cantidad)
                    Next

                    If TotKit > CDbl(TxtPreVta1.Text.Trim) Then
                        If MessageBox.Show("El precio del kit " & x.Producto.Descripcion.ToString() & " es menor al costo de los productos que los componen. " & vbLf & "Precio de costo: " & TotKit.ToString("C2") & "." & vbLf & "¿Desea continuar?" & vbLf & vbLf & "Nota: Solo se omitira este articulo.", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            'MsgBox("No se realizo ningun cambio.", MsgBoxStyle.Exclamation, "Aviso")
                            Application.DoEvents()
                            TxtPreVta1.Focus()
                            Continue For
                        End If
                        'MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & x.Producto.Descripcion.ToString() & " es = 0," & "los cambios no surtiran efecto sobre el.", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                Else
                    If ObtenerCosto(CInt(DGDetalle.SelectedRows(i).Cells(LPdIdProducto.Index).Value)) > CDbl(TxtPreVta1.Text.Trim) Then
                        If MessageBox.Show("El precio del producto " & x.Producto.Descripcion.ToString() & " es menor al costo. " & vbLf & "Precio de costo: " & ObtenerCosto(CInt(DGDetalle.SelectedRows(i).Cells(LPdIdProducto.Index).Value)).ToString & "." & vbLf & "¿Desea continuar?" & vbLf & vbLf & "Nota: Solo se omitira este articulo.", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                            'MsgBox("No se realizo ningun cambio.", MsgBoxStyle.Exclamation, "Aviso")
                            Application.DoEvents()
                            TxtPreVta1.Focus()
                            Continue For
                        End If
                        'MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & x.Producto.Descripcion.ToString() & " es = 0," & "los cambios no surtiran efecto sobre el.", MsgBoxStyle.Exclamation, "Aviso")
                    End If
                End If

                


                'x.Obtener(1, CInt(DGDetalle.CurrentRow.Cells(LPdIdProducto.Index).Value))
                'x = DirectCast(DGDetalle.SelectedRows(i).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)

                Dim costo As Decimal = x.Costo
                Dim util As Decimal = PreVta1 - costo
                If costo = 0 Then
                    'MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & _
                    'x.Producto.ToString & " es = 0," & _
                    'Chr(13) & "los cambios no surtiran efecto sobre el", MsgBoxStyle.Exclamation, "Aviso")
                    'Continue For
                    x.PrecioVentaP = "0.00"
                Else
                    'x.PrecioVentaC = (PreVta1).ToString("0.00")
                    'x.Utilidad = (PreVta1 - costo).ToString("0.00")
                    'Dim util As Decimal = x.Utilidad
                    x.PrecioVentaP = ((util / costo) * 100).ToString("0.00")
                    'Dim cp As Decimal = x.ComisionP
                    'x.ComicionC = ((cp / 100) * util).ToString("0.00")
                    ''Dim cc As Decimal = x.ComicionC
                    ''x.ComisionP = ((cc / util) * 100).ToString("0.00")
                    'LimpiarCaja()
                    'DGDetalle.Focus()
                End If
                x.PrecioVentaC = (PreVta1).ToString("0.00")
                x.Utilidad = (PreVta1 - costo).ToString("0.00")
                Dim cp As Decimal = x.ComisionP
                x.ComicionC = ((cp / 100) * util).ToString("0.00")

                listaprecio.Detalle.Add(x)
                With DGDetalle.SelectedRows(i)
                    .Cells(PrecioVentaCDataGridViewTextBoxColumn.Index).Value = x.PrecioVentaC.ToString("N4")
                    .Cells(UtilidadDataGridViewTextBoxColumn.Index).Value = x.Utilidad.ToString("N4")
                    .Cells(PrecioVentaPDataGridViewTextBoxColumn.Index).Value = x.PrecioVentaP.ToString("N4")
                    .Cells(ComicionCDataGridViewTextBoxColumn.Index).Value = x.ComicionC.ToString("N4")
                End With
                'Dim cc As Decimal = x.ComicionC
                'x.ComisionP = ((cc / util) * 100).ToString("0.00")
                LimpiarCaja()
                DGDetalle.Focus()

            Next
            listaprecio.Detalle.ResetBindings()
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 2
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6
        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'If IsNumeric(e.KeyChar) = False Then
            '    e.Handled = True
            '    Return
            'End If
            If NumConFrac(Me.TxtPreVta1, e) Then
                Beep()
                Return
            End If



            


            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtPreVta1.Text.IndexOf(".") >= 0 Then
                    e.Handled = True
                End If
            Else
                'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                If Me.TxtPreVta1.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtPreVta1.Text.Length - Me.TxtPreVta1.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtPreVta1.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtPreVta2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPreVta2.KeyPress
        If e.KeyChar = Chr(13) And DGDetalle.RowCount > 0 And TxtPreVta1.Text.Trim() <> "" Then
            Me.SelectNextControl(sender, True, True, False, True)
            DGDetalle.Focus()
            Dim Pvp As Decimal = Me.TxtPreVta2.Text
            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim x As New ClasesNegocio.ListaPrecioDetalleClass
                x.Obtener(1, CInt(DGDetalle.SelectedRows(i).Cells(LPdIdProducto.Index).Value))
                'x = DirectCast(DGDetalle.SelectedRows(i).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)
                Dim costo As Decimal = x.Costo
                Dim cp As Decimal = x.ComisionP
                If costo = 0 Then
                    MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & _
                    x.Producto.Descripcion.ToString() & " es = 0," & "los cambios no surtiran efecto sobre el.", MsgBoxStyle.Exclamation, "Aviso")

                    Continue For
                Else

                    x.PrecioVentaP = (Pvp).ToString("0.00")
                    x.PrecioVentaC = costo * ((Pvp / 100) + 1).ToString("0.00")
                    Dim pvc As Decimal = x.PrecioVentaC
                    x.Utilidad = (pvc - costo).ToString("0.00")
                    Dim Util As Decimal = x.Utilidad
                    x.ComicionC = ((cp / 100) * Util).ToString("0.00")
                    'Dim cc As Decimal = x.ComicionC
                    'x.ComisionP = ((cc / Util) * 100).ToString("0.00")

                    listaprecio.Detalle.Add(x)
                    With DGDetalle.SelectedRows(i)
                        .Cells(PrecioVentaCDataGridViewTextBoxColumn.Index).Value = x.PrecioVentaC.ToString("N4")
                        .Cells(UtilidadDataGridViewTextBoxColumn.Index).Value = x.Utilidad.ToString("N4")
                        .Cells(PrecioVentaPDataGridViewTextBoxColumn.Index).Value = x.PrecioVentaP.ToString("N4")
                        .Cells(ComicionCDataGridViewTextBoxColumn.Index).Value = x.ComicionC.ToString("N4")
                    End With

                    LimpiarCaja()
                    DGDetalle.Focus()
                End If
            Next
            listaprecio.Detalle.ResetBindings()
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 2
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6
        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then

            If NumConFrac(Me.TxtPreVta1, e) Then
                Beep()
                Return
            End If

            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtPreVta2.Text.IndexOf(".") >= 0 Then
                    e.Handled = True
                End If
            Else
                'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                If Me.TxtPreVta2.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtPreVta2.Text.Length - Me.TxtPreVta2.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtPreVta2.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtComVta1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComVta1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DGDetalle.Focus()
            Dim Cc As Decimal = Me.TxtComVta1.Text
            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim x As ClasesNegocio.ListaPrecioDetalleClass
                x = DirectCast(DGDetalle.SelectedRows(i).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)
                Dim costo As Decimal = x.Costo
                Dim util As Decimal = x.Utilidad
                If Cc > util Then
                    MsgBox("La Comision No puede ser mayor a la Utilidad " & _
                    x.Utilidad.ToString, MsgBoxStyle.Exclamation, "Aviso")
                Else
                    x.ComicionC = (Cc).ToString("0.00")
                    x.ComisionP = ((Cc / util) * 100).ToString("0.00")
                    DGDetalle.Focus()
                End If
            Next
            LimpiarCaja()
            listaprecio.Detalle.ResetBindings()
        End If

        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 2
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6
        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtComVta1.Text.IndexOf(".") >= 0 Then
                    e.Handled = True
                End If
            Else
                'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                If Me.TxtComVta1.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtComVta1.Text.Length - Me.TxtComVta1.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtComVta1.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtComVta2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtComVta2.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            DGDetalle.Focus()
            Dim Cp As Decimal = Me.TxtComVta2.Text
            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim x As ClasesNegocio.ListaPrecioDetalleClass
                x = DirectCast(DGDetalle.SelectedRows(i).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)
                Dim costo As Decimal = x.Costo
                Dim util As Decimal = x.Utilidad
                If costo = 0 Then
                    MsgBox("No se pudo calcular el Precio de Venta % por que el costo del producto " & _
                    x.Producto.ToString & " es = 0," & _
                    Chr(13) & "los cambios no surtiran efecto sobre el", MsgBoxStyle.Exclamation, "Aviso")
                    Continue For
                Else
                    x.ComisionP = (Cp).ToString("0.00")
                    x.ComicionC = ((Cp / 100) * util).ToString("0.00")
                    LimpiarCaja()
                    DGDetalle.Focus()
                End If
            Next
            listaprecio.Detalle.ResetBindings()
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 2
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6
        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtComVta2.Text.IndexOf(".") >= 0 Then
                    e.Handled = True
                End If
            Else
                'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                If Me.TxtComVta2.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtComVta2.Text.Length - Me.TxtComVta2.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtComVta2.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

#Region "Metodos"
    Private Sub Limpiar()
        TxtCodigo.Clear()
        TxtPlaza.Clear()
        CmbPlaza.SelectedIndex = -1
        CmbPlaza.SelectedValue = "Seleccione Plaza"
        TxtDescripcion.Clear()
        TxtDescCorta.Clear()
        'ChkCaduca.Checked = False
        ChkBase.Checked = False
        DtpFechaDe.Value = Now
        DtpFechaA.Value = Now
        TxtUtilidad.Clear()
        TxtPreVta1.Clear()
        TxtPreVta2.Clear()
        TxtComVta1.Clear()
        TxtComVta2.Clear()
        CmbTipoVenta.SelectedIndex = -1
        CmbTipoVenta.Text = "Seleccione un tipo de venta..."
        DGDetalle.DataSource = Nothing
        DGDetalle.Rows.Clear()
        seleccionado = False
        Editar = False
        Me.lblEstatus.Visible = False
        Me.TxtDescripcion.Focus()
        buscando = False
        nuevo = False
    End Sub

    Private Sub LimpiarCaja()
        TxtUtilidad.Clear()
        TxtPreVta1.Clear()
        TxtPreVta2.Clear()
        TxtComVta1.Clear()
        TxtComVta2.Clear()
    End Sub

    Private Sub Habilitar()
        TxtPlaza.Enabled = True
        CmbPlaza.Enabled = True
        TxtDescripcion.Enabled = True
        TxtDescCorta.Enabled = True
        ChkBase.Enabled = True
        DtpFechaDe.Enabled = True
        DtpFechaA.Enabled = True
        TxtUtilidad.Enabled = True
        TxtPreVta1.Enabled = True
        TxtPreVta2.Enabled = True
        TxtComVta1.Enabled = True
        TxtComVta2.Enabled = True
        DGDetalle.Enabled = True
        DGDetalle.ForeColor = Drawing.Color.Black
        DGDetalle.BackgroundColor = Drawing.Color.White
        BtnAgregar.Enabled = True
        BtnQuitar.Enabled = True
        CmbTipoVenta.Enabled = True
        txtBuscar.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        TxtPlaza.Enabled = False
        CmbPlaza.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescCorta.Enabled = False
        'ChkCaduca.Enabled = False
        ChkBase.Enabled = False
        DtpFechaDe.Enabled = False
        DtpFechaA.Enabled = False
        TxtUtilidad.Enabled = False
        TxtPreVta1.Enabled = False
        TxtPreVta2.Enabled = False
        TxtComVta1.Enabled = False
        TxtComVta2.Enabled = False
        DGDetalle.ForeColor = Drawing.Color.DimGray
        DGDetalle.BackgroundColor = Drawing.Color.Gray
        DGDetalle.Enabled = False
        BtnAgregar.Enabled = False
        BtnQuitar.Enabled = False
        CmbTipoVenta.Enabled = False
        txtBuscar.Enabled = False
    End Sub

    Private Sub Guardar()
        listaprecio.FechaAlta = DtpFecha.Value
        listaprecio.Plaza = DirectCast(Me.CmbPlaza.SelectedItem, ClasesNegocio.PlazaClass)
        listaprecio.Descripcion = TxtDescripcion.Text
        listaprecio.DescripcionCorta = TxtDescCorta.Text
        listaprecio.EsListaBase = ChkBase.Checked
        listaprecio.FechaVigencia = DtpFechaDe.Value.AddDays(-1)
        listaprecio.FechaVigenciaA = Me.DtpFechaA.Value
        'Me permite obtener la diferencia en dias de dos fechas
        Dim FechaDe As Date = DtpFechaDe.Value
        Dim FechaA As Date = DtpFechaA.Value
        listaprecio.DiasVigencia = DateDiff(DateInterval.Day, FechaDe, FechaA)

        If ChkBase.Checked Then
            listaprecio.EsListaBase = True
            listaprecio.ListaBase = listaprecio
        Else
            listaprecio.ListaBase = listaprecio.Plaza.ListaBase
        End If

        listaprecio.Caduca = Not Me.ChkBase.Checked

        'listaprecio.TipoVenta = DirectCast(CmbTipoVenta.SelectedItem, ClasesNegocio.TipoVentaClass)

    End Sub

    Private Function Validar() As Boolean
        If CmbPlaza.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar una plaza", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        Select Case ""
            Case Me.TxtDescripcion.Text
                MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Faltan Datos")
                Return False
            Case Me.TxtDescCorta.Text
                MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Faltan Datos")
                Return False
        End Select

        If Not Me.DtpFechaDe.Value >= Me.DtpFecha.Value Then
            MsgBox("La fecha de inicio debe ser mayor o igual a la fecha de alta", MsgBoxStyle.Exclamation, "Fecha Invalida")
            Return False
        End If

        If Me.DtpFechaDe.Value >= Me.DtpFechaA.Value Then
            MsgBox("La fecha final debe ser mayor que la fehca de inicio", MsgBoxStyle.Exclamation, "Fecha Invalida")
            Return False
        End If

        If listaprecio.Detalle.Count = 0 Then
            MsgBox("La lista de precio debe tener productos", MsgBoxStyle.Exclamation, "Faltan Datos")
            Return False
        End If

        'If CmbTipoVenta.SelectedIndex = -1 Then
        '    MsgBox("Debe seleccciona un tipo de venta", MsgBoxStyle.Exclamation, "Faltan Datos")
        '    Return False
        'End If

        Return True
    End Function
#End Region

#Region "ToolBar"
    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        Cursor = Cursors.WaitCursor
        Try
            If listaprecio.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                If listaprecio.Borrar Then
                    MsgBox("La Lista de Precios ha sido Inactivada.", MsgBoxStyle.Information, "Aviso")
                    Deshabilitar()
                    Limpiar()
                Else
                    Cancelar = True
                End If
            Else
                MsgBox("La Lista de Precios ya esta Inactivada.", MsgBoxStyle.Exclamation, "Aviso")
                Limpiar()
                Deshabilitar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBuscar
        Dim ventana As New frmBusquedaListaPrecio
        ventana.ListaPrecioCol.Mostrar = ClasesNegocio.TipoListaPrecioEnum.TODAS

        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            Application.DoEvents()
            'listaprecio.Detalle.Dispose()
            listaprecio = Nothing
            buscando = True
            listaprecio = New ClasesNegocio.ListaPrecioClass(CInt(ventana.TxtCodigo.Text))

            'Dim Buscar As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.ListaPrecioClass)
            'listaprecio = Buscar.ObtenerdeDataGrid(ventana.DataGrid)



            'Me.puedorefrescar = True
            'Me.listaprecio_Modificado(Me, New EventArgs)
            'Me.puedorefrescar = False
            Dim dt As DataTable
            'dt.Columns.Add("NomProducto")
            'dt.Columns.Add("Costo")
            'dt.Columns.Add("Utilidad")
            'dt.Columns.Add("PrecioVentaC")
            'dt.Columns.Add("PrecioVentaP")
            'dt.Columns.Add("ComicionC")
            'dt.Columns.Add("ComisionP")
            'dt.Columns.Add("NomMarca")
            'dt.Columns.Add("Linea")
            'dt.Columns.Add("LPDEstatus")
            'dt.Columns.Add("LPdIdProducto")
            'For Each entidad As ClasesNegocio.ListaPrecioDetalleClass In listaprecio.DetalleSinKits
            '    dt.Rows.Add(entidad.Producto.Descripcion, entidad.Costo, entidad.Utilidad, entidad.PrecioVentaC, entidad.PrecioVentaP, entidad.ComicionC, entidad.ComisionP, entidad.Marca.Nombre, entidad.Linea.Descripcion, entidad.Estatus, entidad.Producto.Codigo)

            'Next
            'dt = CType(listaprecio.DetalleSinKits.Container.Components.Item, DataTable)
            If listaprecio.AgregarProductosNuevos > 0 Then
                MsgBox("Se han agregado nuevos productos a la lista de precio", MsgBoxStyle.Information, "Productos Nuevos")
            End If
            If Not listaprecio.Guardar() Then
                MsgBox("No se guardaron cambios en la lista.", MsgBoxStyle.Information, "Aviso")
            End If

            listaprecio.Detalle = Nothing

            dt = CollectionHelper.ConvertTo(Of ClasesNegocio.ListaPrecioDetalleClass)(listaprecio.DetalleSinKits)
            dv = New DataView(dt)
            'dv = dt
            'dv = listaprecio.Detalle
            'DGDetalle.DataSource = listaprecio.Detalle
            'DGDetalle.DataSource = listaprecio.Detalle

            DGDetalle.DataSource = dv

            Me.Cursor = Cursors.Default
            buscando = False
            seleccionado = True
            listaprecioCol.Clear()
            listaprecioCol.Add(listaprecio)
            Me.lblEstatus.Visible = True


            CmbPlaza.SelectedValue = listaprecio.Plaza.Codigo
            TxtPlaza.Text = CmbPlaza.SelectedValue.ToString
            CmbTipoVenta.SelectedValue = listaprecio.TipoVenta.Codigo
            TxtDescripcion.Text = listaprecio.Descripcion
            TxtDescCorta.Text = listaprecio.DescripcionCorta
            ' DtpFechaA.Value = Now().AddDays(1)
            DtpFechaA.Value = listaprecio.FechaVigenciaA
            If listaprecio.Plaza.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                CmbPlaza.Text = listaprecio.Plaza.Descripcion
            End If

            If listaprecio.TipoVenta.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                CmbTipoVenta.Text = listaprecio.TipoVenta.Descripcion
            End If

            
        Else
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        Try
            Cursor = Cursors.WaitCursor
            If listaprecio.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
                Habilitar()
                If ChkBase.Checked Then
                    ChkBase.Enabled = False
                Else
                    ChkBase.Enabled = False
                End If
                Editar = True
                Me.TxtDescripcion.Focus()
            Else
                If MessageBox.Show("La Lista de Precios esta inactiva, ¿Desea Activarla?", "Activar Lista de Precio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    If listaprecio.Plaza.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                        MsgBox("No es posible activar la lista de precios, necesita activar la plaza " & listaprecio.Plaza.Descripcion, MsgBoxStyle.Exclamation, "Plaza Inactiva")
                        Cancelar = True
                        Exit Sub
                    End If

                    If listaprecio.TipoVenta.Estatus = ClasesNegocio.EstatusEnum.INACTIVO Then
                        MsgBox("No es posible activar la lista de precios, necesita activar el tipo de venta " & listaprecio.TipoVenta.Descripcion, MsgBoxStyle.Exclamation, "Tipo de Venta Inactiva")
                        Cancelar = True
                        Exit Sub
                    End If

                    Me.listaprecio.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                    Me.lblEstatus.Text = listaprecio.Estatus.ToString
                    Habilitar()
                    Editar = True
                    Me.TxtDescripcion.Focus()
                Else
                    Cancelar = True
                    MEAToolBar1.sbCambiarEstadoBotones("Guardar")
                    Limpiar()
                    Deshabilitar()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Cursor = Cursors.WaitCursor
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            puedorefrescar = False
            Guardar()
            puedorefrescar = True

            If listaprecio.Guardar Then
                If Editar Then
                    MsgBox("La Lista de Precios se ha modificado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                Else
                    MsgBox("La Lista de Precios se ha guardado satisfactoriamente.", MsgBoxStyle.Information, "Aviso")
                End If

                Limpiar()
                Deshabilitar()

                'se carga de nuevo las plazas por que mantienen en memoria las listas de precio
                'con sus detalles sin actualizar
                'y se ocupan volver a cargar para que se cargen actualizadas
                PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            listaprecioCol.Clear()
            listaprecioCol.Add(listaprecio)
            Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            Previsualizar.Text = "Imprimir Lista de Precios " & listaprecio.Descripcion
            Previsualizar.Reporte = listaprecioCol.Reporte
            Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.seleccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Habilitar()
        Limpiar()
        listaprecio = New ClasesNegocio.ListaPrecioClass
        DGDetalle.DataSource = listaprecio.Detalle
        nuevo = True
    End Sub
#End Region

    Private Sub listaprecio_MensajeError(ByVal sender As Object, ByVal mensaje As String)
        MsgBox(mensaje, MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub FrmListaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "010101111"
        MtbEstados.StateLimpiar = "100100001"
        MtbEstados.StateCancelar = "100100001"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")

        PlazaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        TipoVentaC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        Deshabilitar()
        Limpiar()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim ventana As New frmAgregarProductoListaPrecio
        If ventana.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If Not listaprecio.Detalle.Existe(ventana.Detalle) Then
                listaprecio.Detalle.Add(ventana.Detalle)
            Else
                MsgBox("Este producto ya se encuentra en la lista de precios", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    Private Sub CmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPlaza.SelectedIndexChanged
        'If Me.CmbPlaza.SelectedIndex > -1 Then
        '    Me.TxtPlaza.Text = Me.CmbPlaza.SelectedValue

        '    If Not buscando Then
        '        ListaBase = DirectCast(CmbPlaza.SelectedItem, ClasesNegocio.PlazaClass).ListaBase

        '        If ListaBase Is Nothing Then
        '            Me.ChkBase.Checked = True
        '            Me.DtpFechaDe.Value = Now
        '            Me.DtpFechaA.Value = Now.AddMonths(3)
        '            Me.ChkBase.Enabled = False
        '            Dim prods As New ClasesNegocio.ProductoCollectionClass
        '            prods.Obtener()
        '            listaprecio.Detalle.Clear()
        '            For Each pr As ClasesNegocio.ProductoGeneralClass In prods
        '                Dim det As New ClasesNegocio.ListaPrecioDetalleClass
        '                det.Producto = pr
        '                det.ListaPrecio = listaprecio

        '                '=================Obtener el costo del producto===========================

        '                Dim inv As New IntegraLab.ORM.CollectionClasses.InventarioAlmacenCollection

        '                inv.GetMulti(HC.InventarioAlmacenFields.ProductoId = pr.Codigo, 1, New OC.SortExpression(New OC.SortClause(HC.InventarioAlmacenFields.FechaUltimoCosto, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

        '                If inv.Count > 0 Then det.Costo = inv(0).UltimoCosto Else det.Costo = 0D

        '                det.ComicionC = 0
        '                det.ComisionP = 0
        '                det.PrecioVentaC = det.Costo
        '                det.PrecioVentaP = 0
        '                det.Utilidad = 0
        '                det.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
        '                listaprecio.Detalle.Add(det)
        '            Next
        '        Else
        '            Me.ChkBase.Checked = False
        '            Me.DtpFechaDe.Value = Now
        '            Me.DtpFechaA.Value = Now.AddDays(15)
        '            Me.ChkBase.Enabled = False
        '            listaprecio.Detalle.Clear()
        '            'Inicia codigo agregado version 1.2.0.03
        '            Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        '            Try
        '                Dim cadenaConsulta As String
        '                Dim sqlCom As SqlCommand
        '                Dim sqlDataAdapter As SqlDataAdapter
        '                'Dim listaproductos As New DataTable
        '                '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '                cadenaConsulta = "SELECT Ccp.PdDescripcion AS [Producto],Costo,Costo*([PrecioVentaP]/100) AS [Utilidad], " & _
        '                                "             Costo*([PrecioVentaP]/100)+Costo AS [PrecioVentaC],[PrecioVentaP],CASE LPDComicionP " & _
        '                                "                WHEN 0 THEN 0 " & _
        '                                "               ELSE Costo*([PrecioVentaP]/100)* (LPDComicionP/100) " & _
        '                                "               End " & _
        '                                "               AS [ComicionC],LPDComicionP AS [ComisionP],Cgm.marNombre AS [Marca],Ccl.LNDescripcion AS [Linea], " & _
        '                                "               Ccsb.SLDescripcion AS [SubLinea],LPDEstatus,LPdidProducto FROM " & _
        '                                "               (SELECT LPdidProducto,LPDUtilidad,LPDComicionP,LPDCosto,LPDPrecioVentaC, " & _
        '                                "                ISNULL((SELECT TOP 1 Imad.Costo FROM MinvMovimientosAlmacenDetalles Imad " & _
        '                                "                 INNER JOIN MinvMovimientosAlmacen Ima ON Imad.FolioMovimiento=Ima.FolioMovimiento " & _
        '                                "                 INNER JOIN McatTipoMovimiento Ctm ON Ima.TipoMovimientoID=Ctm.Codigo " & _
        '                                "                 INNER JOIN McatAlmacenes Ca ON Ca.Codigo=Ima.AlmacenId  " & _
        '                                "                 WHERE Ctm.Direccion=0 AND Imad.ProductoId=Cvlpd.LPdidProducto AND Ca.Plaza= '" & Me.TxtPlaza.Text & "'" & _
        '                                "                 ORDER BY Ima.FechaMovimiento DESC),LPDCosto)AS [Costo]," & _
        '                                "                  CAST((CASE lpdCosto " & _
        '                                "                   WHEN 0 THEN 0 " & _
        '                                "                   ELSE ((CAST(LPDPrecioVentaC AS FLOAT)/ CAST(lpdCosto AS FLOAT))-1)*100 " & _
        '                                "                  END) AS FLOAT) " & _
        '                                "                AS [PrecioVentaP],LPDEstatus " & _
        '                                "               FROM MCatVtasListasPreciosDet Cvlpd INNER JOIN MCatVtasListasPrecioscab Cvlpc ON Cvlpd.LPDidListaPrecios=Cvlpc.LPidListaPrecios AND " & _
        '                                "                           Cvlpc.LPEsListaBase=1 AND Cvlpc.LPidPlaza='" & Me.TxtPlaza.Text & "'" & ") AS [Subconsulta] " & _
        '                                "               INNER JOIN MCatCompProductos Ccp ON Ccp.PdIdProducto=Subconsulta.LpdIdProducto " & _
        '                                "               INNER JOIN MCatCompSubLineas Ccsb ON Ccsb.SlIdSublinea=Ccp.PdIdSublinea " & _
        '                                "               INNER JOIN MCatCompLineas Ccl ON Ccl.LnIdLinea=SlIdLinea " & _
        '                                "               INNER JOIN MCatGenMarcas Cgm ON Cgm.marIdMarca=Ccp.PdIdMarca"
        '                '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        '                sqlCom = New SqlCommand(cadenaConsulta, sqlCon)
        '                sqlDataAdapter = New SqlDataAdapter(sqlCom)
        '                sqlCon.Open()
        '                Me.tablaDetalle.Clear()
        '                sqlDataAdapter.Fill(Me.tablaDetalle)
        '            Catch ex As Exception
        '                MsgBox(ex.Message, MsgBoxStyle.Critical)
        '            End Try
        '            'Termina codigo agregado version 1.2.0.03
        '            'Inicia codigo modificado version 1.2.0.03
        '            'For Each ld As ClasesNegocio.ListaPrecioDetalleClass In ListaBase.Detalle
        '            '    Dim det As New ClasesNegocio.ListaPrecioDetalleClass

        '            '    det.ListaPrecio = listaprecio
        '            '    det.Costo = ld.Costo
        '            '    det.Utilidad = ld.Utilidad
        '            '    det.PrecioVentaC = ld.PrecioVentaC
        '            '    det.PrecioVentaP = ld.PrecioVentaP
        '            '    det.ComicionC = ld.ComicionC
        '            '    det.ComisionP = ld.ComisionP
        '            '    det.Producto = ld.Producto

        '            '    listaprecio.Detalle.Add(det)
        '            'Next

        '            For Each ld As DataRow In Me.tablaDetalle.Rows
        '                Dim det As New ClasesNegocio.ListaPrecioDetalleClass
        '                Dim Aux As New ClasesNegocio.ProductoGeneralClass
        '                det.ListaPrecio = listaprecio
        '                det.Costo = ld.Item("Costo")
        '                det.Utilidad = ld.Item("Utilidad")
        '                det.PrecioVentaC = ld.Item("PrecioVentaC")
        '                det.PrecioVentaP = ld.Item("PrecioVentaP")
        '                det.ComicionC = ld.Item("ComicionC")
        '                det.ComisionP = ld.Item("ComisionP")
        '                Aux.Obtener(ld.Item("LPdIdProducto"))
        '                det.Producto = Aux
        '                'Termina codigo modificado version 1.2.0.03
        '                listaprecio.Detalle.Add(det)
        '            Next
        '        End If
        '    Else
        '        ListaBase = listaprecio.ListaBase
        '    End If
        'Else
        '    Me.TxtPlaza.Text = ""
        'End If
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        If IsNothing(Me.DGDetalle.CurrentRow) Then
            MsgBox("Debe seleccionar primero un producto..", MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        If Me.DGDetalle.SelectedRows.Count > 0 Then
            For i As Integer = 0 To Me.DGDetalle.SelectedRows.Count - 1
                Dim det As ClasesNegocio.ListaPrecioDetalleClass = DirectCast(Me.DGDetalle.SelectedRows(0).DataBoundItem, ClasesNegocio.ListaPrecioDetalleClass)
                listaprecio.Detalle.Remove(det)
            Next
            DGDetalle.Refresh()
        End If
    End Sub

    Private Sub listaprecio_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles listaprecio.Modificado
        If puedorefrescar Then
            DtpFecha.Value = listaprecio.FechaAlta
            CmbPlaza.SelectedValue = listaprecio.Plaza.Codigo
            TxtCodigo.Text = listaprecio.Codigo
            TxtDescripcion.Text = listaprecio.Descripcion
            TxtDescCorta.Text = listaprecio.DescripcionCorta
            ChkBase.Checked = listaprecio.EsListaBase
            DtpFechaDe.Value = listaprecio.FechaAlta
            DtpFechaA.Value = listaprecio.FechaVigencia
            lblEstatus.Text = listaprecio.Estatus.ToString
            CmbTipoVenta.SelectedValue = listaprecio.TipoVenta.Codigo
        End If
    End Sub

    Private Sub DtpFechaDe_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaDe.ValueChanged
        If Me.DtpFechaDe.Value < Now Then
            Me.DtpFechaDe.Value = Now
        End If
    End Sub

    Private Sub DtpFechaA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFechaA.ValueChanged
        If Me.DtpFechaA.Value < Me.DtpFechaDe.Value Then
            Me.DtpFechaA.Value = Now
        End If
    End Sub

    Private Sub FrmListaPrecio_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F3 And (nuevo Or Editar Or buscando) Then
                Dim filtrar As New FrmFiltradoListaPrecioDetalle

                If filtrar.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim Linea As ClasesNegocio.LineaClass = Nothing
                    Dim SubLinea As ClasesNegocio.SubLineaClass = Nothing
                    Dim Marca As ClasesNegocio.MarcaClass = Nothing

                    If Not filtrar.CmbLinea.SelectedIndex = 0 Then
                        Linea = DirectCast(filtrar.CmbLinea.SelectedItem, ClasesNegocio.LineaClass)
                        If Not filtrar.CmbSubLinea.SelectedIndex = 0 Then
                            SubLinea = DirectCast(filtrar.CmbSubLinea.SelectedItem, ClasesNegocio.SubLineaClass)
                        End If
                    End If

                    If Not filtrar.CmbMarca.SelectedIndex = 0 Then
                        Marca = DirectCast(filtrar.CmbMarca.SelectedItem, ClasesNegocio.MarcaClass)
                    End If

                    listaprecio.Detalle.Filtrar(Linea, Marca)
                End If
            End If

            If e.KeyCode = Keys.Escape And (nuevo Or Editar Or buscando) Then
                listaprecio.Detalle.Filtrar(Nothing, Nothing)
            End If

            'If TxtPreVta1.Focused Then
            '    'If Not Char.IsDigit(ChrW(e.KeyCode)) AndAlso e.KeyData <> Keys.Enter AndAlso e.KeyData <> Keys.Back Then
            '    '    e.SuppressKeyPress = True
            '    'End If
            '    'If e.KeyCode <> 13 AndAlso e.KeyCode <> 8 AndAlso Not IsNumeric(ChrW(e.KeyCode)) AndAlso ChrW(e.KeyCode) <> "."c Then
            '    If Not (Char.IsNumber(ChrW(e.KeyCode)) Or ChrW(e.KeyCode).Equals(Application.CurrentCulture.NumberFormat.NumberDecimalSeparator) Or e.KeyData = Keys.Back) Then
            '        e.SuppressKeyPress = True
            '    Else
            '        If TxtPreVta1.Text.Contains(".") Then
            '            e.SuppressKeyPress = True
            '        End If
            '    End If

            'End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    'Public Function CollectToDT(ByVal collection As SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2(Of SD.LLBLGen.Pro.ORMSupportClasses.IEntity2)) As DataTable
    '    Dim dTable As New DataTable()
    '    Dim campos As SD.LLBLGen.Pro.ORMSupportClasses.IEntityFields2 = collection.EntityFactoryToUse.CreateFields

    '    For i As Integer = 0 To campos.Count
    '        dTable.Columns.Add(campos(i).Name, campos(i).DataType)
    '    Next

    '    For Each entidad As SD.LLBLGen.Pro.ORMSupportClasses.IEntity2 In collection
    '        Dim row As DataRow = dTable.NewRow()
    '        For j As Integer = 0 To campos.Count
    '            row(entidad.Fields(j).Name) = entidad.Fields(j).CurrentValue
    '        Next
    '        dTable.Rows.Add(row)
    '    Next

    '    Return dTable
    'End Function



    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged

        dv.RowFilter = "NomProducto LIKE '%" & txtBuscar.Text.Trim & "%'"

        DGDetalle.DataSource = dv
        ' DGDetalle.DataSource = listaprecio.DetalleSinKits(txtBuscar.Text.Trim)
    End Sub

    ''Este metodo es para obtener el costo actual del producto y comparar con el nuevo precio
    ''avisando al usuario que verifique el precio ya que esta por debajo del costo
    Public Function ObtenerCosto(ByVal Codprod As Integer) As Double
        Dim sucursal As New ClasesNegocio.SucursalClass(Utilerias.ObtenerCodSucursal)
        Dim sort As New SortExpression

        sort.Add(New SortClause(HC.InventarioAlmacenFields.Año, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        sort.Add(New SortClause(HC.InventarioAlmacenFields.Mes, _
                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))



        'ultimoInventario.GetMulti(HC.InventarioAlmacenFields.AlmacenId = idAlmacen And _
        '            HC.InventarioAlmacenFields.ProductoId = idProducto, 1, sort)
        Dim invs As New CC.InventarioAlmacenCollection

        invs.GetMulti(HC.InventarioAlmacenFields.AlmacenId = sucursal.IdAlmacen And _
                    HC.InventarioAlmacenFields.ProductoId = Codprod, 1, sort) 'And HC.InventarioAlmacenFields.Año = Now.Year And HC.InventarioAlmacenFields.Mes = Now.Month, 1)

        If invs.Count > 0 Then
            Dim invAlmacen As New InventarioAlmacenEntity
            invAlmacen = invs(0)
            Return CDbl(invAlmacen.CostoPromedio)
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = CDbl(invAlmacen.CostoPromedio * dgvKit.Rows(e.RowIndex).Cells(clmCantidad.Index).Value)

        Else
            'dgvKit.Rows(e.RowIndex).Cells(clmPreCosto.Index).Value = 0D
            Return 0D
        End If

    End Function

    ''solo numeros y decimal
    Public Function NumConFrac(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Return e.Handled
    End Function
End Class