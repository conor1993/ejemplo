Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports CN = ClasesNegocio

Public Class ModInvCargaInicialForm

#Region " Declaraciones "
    Dim Liberado As Boolean = False
    Dim WithEvents tmr As New Timer
    Dim config As New EC.InventarioConfiguracionEntity
    Dim Coleccion As New ClasesNegocio.ProductoCargaInicialCollectionClass
#End Region

#Region " Formulario "
    Private Sub ModInvCargaInicialForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgv.AutoGenerateColumns = False

        If Not config.FetchUsingPK(1) Then
            MsgBox("Se requiere que se realize antes la configuración del almacén", MsgBoxStyle.Exclamation, "Aviso")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        ElseIf Not config.ExInventarioInicial.HasValue Then
            MsgBox("Se requiere que se realize antes la configuración del almacén", MsgBoxStyle.Exclamation, "Aviso")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        RemoveHandler cmbAlmacen.SelectedIndexChanged, AddressOf cmbAlmacen_SelectedIndexChanged
        Controlador.LlenarComboAlmacenesParaCargaInicial(cmbAlmacen, ClasesNegocio.CondicionEnum.ACTIVOS)
        AddHandler cmbAlmacen.SelectedIndexChanged, AddressOf cmbAlmacen_SelectedIndexChanged

        RellenarAlmacen(CType(cmbAlmacen.DataSource, CN.AlmacenCollectionClass))
        lblFecha.Text = Now.ToShortDateString
        tmr.Interval = 1000
        tmr.Start()
    End Sub
#End Region

#Region " Metodos "
    Private Sub Rellenar()
        Try
            Dim Almacen As CN.AlmacenClass = CType(Me.cmbAlmacen.SelectedItem, CN.AlmacenClass)
            Dim tabla As DataTable = Controlador.ObtenerProductosParaCargaInicialNueva(Almacen.Codigo, Almacen.Familias)
            Me.Coleccion = New ClasesNegocio.ProductoCargaInicialCollectionClass

            For Each row As DataRow In tabla.Rows
                Dim prod As New ClasesNegocio.ProductoCargaInicialClass

                prod.Caduca = row("Caduca")

                If Not DBNull.Value.Equals(row("Caducidad")) Then
                    prod.Caducidad = row("Caducidad")
                End If

                prod.Cantidad = row("Cantidad")
                prod.Clave = row("Clave")
                prod.CostoPromedio = row("CostoPromedio")
                prod.Lote = row("Lote")
                prod.Producto = row("Producto")
                prod.ProductoId = row("ProductoId")
                prod.SeManejaPorLotes = row("SeManejaPorLotes")
                prod.Linea = row("Linea")
                prod.UltimoCosto = row("UltimoCosto")

                Me.Coleccion.Add(prod)
            Next

            Me.dgv.AutoGenerateColumns = False
            Me.dgv.DataSource = Me.Coleccion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RellenarAlmacen(ByVal Almacenes As CN.AlmacenCollectionClass)
        Dim list As New List(Of String)

        For Each almacen As ClasesNegocio.AlmacenClass In Almacenes
            list.Add(almacen.Codigo.ToString)
        Next

        txtClave.AutoCompleteCustomSource.AddRange(list.ToArray)
        cmbAlmacen.SelectedIndex = -1
        cmbAlmacen.Text = "Seleccione un Almacén"
    End Sub

    Private Function HayProductosParaCargar() As Boolean
        Try
            Dim encontro As Boolean = False

            For i As Integer = 0 To Me.dgv.Rows.Count - 1
                If Me.ValidarFila(i) Then
                    encontro = True
                End If
            Next
            Return encontro
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function ValidarFila(ByVal indice As Integer) As Boolean
        Try
            Dim ColCve As Integer = Me.clmClave.Index 'ObtenerIndiceColumna("Cláve")
            Dim ColCan As Integer = Me.clmCantidad.Index 'ObtenerIndiceColumna("Cantidad")
            Dim ColLot As Integer = Me.clmLote.Index 'ObtenerIndiceColumna("Lote")
            Dim ColCad As Integer = Me.clmCaduca.Index 'ObtenerIndiceColumna("Caduca")
            Dim ColFecCad As Integer = Me.clmFechaCaducidad.Index 'ObtenerIndiceColumna("Fecha de Caducidad")
            Dim ColUC As Integer = Me.clmUltimoCosto.Index
            Dim colCP As Integer = Me.clmCostoPromedio.Index
            Dim Val As Boolean = False
            Dim msg As String = "Debe especificar:" & vbCrLf
            Dim c As New CeldaClass(dgv, indice)
            Dim prod As New CN.ProductoClass(c.ValorCelda(ColCve).ToString)

            If IsDBNull(c.ValorCelda(ColFecCad)) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
                Val = True
                msg &= "La fecha de caducidad del producto." & vbCrLf
                'ElseIf Not IsDBNull(c.ValorCelda(ColFecCad)) Then
                '    If CDate(c.ValorCelda(ColFecCad)) < CDate(Now.ToShortDateString).AddDays(prod.DiasminCaducidad) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
                '        Val = True
                '        msg &= String.Format("Una fecha de caducidad que tenga como minimo {0} a partir de la fecha de hoy.", prod.DiasminCaducidad) & vbCrLf
                '    End If
            End If

            If c.ValorCelda(ColLot).ToString.Replace(" ", "").Length = 0 And prod.SeManejaPorLotes <> 0 And c.ValorCelda(ColCan) Then
                Val = True
                msg &= "El lote al que pertenece el producto." & vbCrLf
            End If

            If CDec(c.ValorCelda(colCP).ToString.Replace("$", "").Replace(",", "")) = 0 Then
                Val = True
                msg &= "El Costo Promedio actual del producto." & vbNewLine
            End If

            If Not prod.SeManejaPorLotes AndAlso CDec(c.ValorCelda(ColUC).ToString.Replace("$", "").Replace(",", "")) = 0 Then
                Val = True
                msg &= "El Ultimo Costo actual del producto." & vbNewLine
            End If

            If Val Then
                'MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgv.Rows(indice).DefaultCellStyle.BackColor = Color.Tomato
                Return False
            Else
                dgv.Rows(indice).DefaultCellStyle.BackColor = Color.LightGreen
                Return True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

#Region " Data Grid "
    Private Sub dgv_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        'Dim ColCve As Integer = Me.ClaveDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Cláve")
        'Dim ColCan As Integer = Me.CantidadDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Cantidad")
        'Dim ColLot As Integer = Me.LoteDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Lote")
        'Dim ColCad As Integer = Me.CaducaDataGridViewCheckBoxColumn.Index 'ObtenerIndiceColumna("Caduca")
        'Dim ColFecCad As Integer = Me.CaducidadDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Fecha de Caducidad")
        'Dim ColUC As Integer = Me.clmUltimoCosto.Index
        'Dim colCP As Integer = Me.clmCostoPromedio.Index
        'Dim Val As Boolean = False
        'Dim msg As String = "Debe especificar:" & vbCrLf
        'Dim c As New CeldaClass(dgv, e.RowIndex)
        'Dim prod As New CN.ProductoClass(c.ValorCelda(ColCve).ToString)

        'If IsDBNull(c.ValorCelda(ColFecCad)) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
        '    Val = True
        '    msg &= "La fecha de caducidad del producto." & vbCrLf
        '    'ElseIf Not IsDBNull(c.ValorCelda(ColFecCad)) Then
        '    '    If CDate(c.ValorCelda(ColFecCad)) < CDate(Now.ToShortDateString).AddDays(prod.DiasminCaducidad) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
        '    '        Val = True
        '    '        msg &= String.Format("Una fecha de caducidad que tenga como minimo {0} a partir de la fecha de hoy.", prod.DiasminCaducidad) & vbCrLf
        '    '    End If
        'End If

        'If c.ValorCelda(ColLot).ToString.Replace(" ", "").Length = 0 And prod.SeManejaPorLotes <> 0 And c.ValorCelda(ColCan) Then
        '    Val = True
        '    msg &= "El lote al que pertenece el producto." & vbCrLf
        'End If

        'If CDec(c.ValorCelda(colCP).ToString.Replace("$", "").Replace(",", "")) = 0 Then
        '    Val = True
        '    msg &= "El Costo Promedio actual del producto." & vbNewLine
        'End If

        'If Not prod.SeManejaPorLotes AndAlso CDec(c.ValorCelda(ColUC).ToString.Replace("$", "").Replace(",", "")) = 0 Then
        '    Val = True
        '    msg &= "El Ultimo Costo actual del producto." & vbNewLine
        'End If

        'If Val Then
        '    'MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
        'Else
        '    dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        'End If
    End Sub

    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv.DataError
        Dim TipoDato As String = ""
        Select Case dgv.Columns(e.ColumnIndex).ValueType.ToString
            Case GetType(System.Int32).ToString
                TipoDato = "Numerico"
            Case GetType(System.DateTime).ToString
                TipoDato = "Fecha"
        End Select
        Dim str As String = String.Format("El dato ingresado no es valido para esta columna, el tipo de dato de esta columna debe ser {0}.", TipoDato)
        MessageBox.Show(str, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv.KeyDown
        If e.Control And e.KeyCode = Keys.C Then
            Me.Liberado = False
            'Me.btnOk.Enabled = False
            Me.dgv.Enabled = False
            'Me.btnNo.Focus()
        End If
    End Sub

    Private Sub dgv_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.RowEnter
        Dim ColCad As Integer = Me.clmCaduca.Index
        Dim ColFecCad As Integer = Me.clmFechaCaducidad.Index

        dgv.Item(ColFecCad, e.RowIndex).ReadOnly = Not dgv.Item(ColCad, e.RowIndex).Value
        'dgv.Item(Me.clmUltimoCosto.Index, e.RowIndex).ReadOnly = dgv.Item(Me.clmManejaLote.Index, e.RowIndex).Value
        dgv.Item(Me.clmLote.Index, e.RowIndex).ReadOnly = Not dgv.Item(Me.clmSeManejaPorLotes.Index, e.RowIndex).Value
    End Sub

    Private Sub dgv_RowValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.RowValidating
        Dim ColCve As Integer = Me.clmClave.Index 'ObtenerIndiceColumna("Cláve")
        Dim ColCan As Integer = Me.clmCantidad.Index 'ObtenerIndiceColumna("Cantidad")
        Dim ColLot As Integer = Me.clmLote.Index 'ObtenerIndiceColumna("Lote")
        Dim ColCad As Integer = Me.clmCaduca.Index 'ObtenerIndiceColumna("Caduca")
        Dim ColFecCad As Integer = Me.clmFechaCaducidad.Index 'ObtenerIndiceColumna("Fecha de Caducidad")
        Dim ColUC As Integer = Me.clmUltimoCosto.Index
        Dim colCP As Integer = Me.clmCostoPromedio.Index
        Dim Val As Boolean = False
        Dim msg As String = "Debe especificar:" & vbCrLf
        Dim c As New CeldaClass(dgv, e.RowIndex)
        Dim prod As New CN.ProductoClass(c.ValorCelda(ColCve).ToString)

        If IsDBNull(c.ValorCelda(ColFecCad)) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
            Val = True
            msg &= "La fecha de caducidad del producto." & vbCrLf
            'ElseIf Not IsDBNull(c.ValorCelda(ColFecCad)) Then
            '    If CDate(c.ValorCelda(ColFecCad)) < CDate(Now.ToShortDateString).AddDays(prod.DiasminCaducidad) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
            '        Val = True
            '        msg &= String.Format("Una fecha de caducidad que tenga como minimo {0} a partir de la fecha de hoy.", prod.DiasminCaducidad) & vbCrLf
            '    End If
        End If

        If c.ValorCelda(ColLot).ToString.Replace(" ", "").Length = 0 And prod.SeManejaPorLotes <> 0 And c.ValorCelda(ColCan) Then
            Val = True
            msg &= "El lote al que pertenece el producto." & vbCrLf
        End If

        If CDec(c.ValorCelda(colCP).ToString.Replace("$", "").Replace(",", "")) = 0 Then
            Val = True
            msg &= "El Costo Promedio actual del producto." & vbNewLine
        End If

        If Not prod.SeManejaPorLotes AndAlso CDec(c.ValorCelda(ColUC).ToString.Replace("$", "").Replace(",", "")) = 0 Then
            Val = True
            msg &= "El Ultimo Costo actual del producto." & vbNewLine
        End If

        If Val Then
            'MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Tomato
        Else
            dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If

        'If Me.Liberado Then
        '    Dim ColCve As Integer = Me.ClaveDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Cláve")
        '    Dim ColCan As Integer = Me.CantidadDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Cantidad")
        '    Dim ColLot As Integer = Me.LoteDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Lote")
        '    Dim ColCad As Integer = Me.CaducaDataGridViewCheckBoxColumn.Index 'ObtenerIndiceColumna("Caduca")
        '    Dim ColFecCad As Integer = Me.CaducidadDataGridViewTextBoxColumn.Index 'ObtenerIndiceColumna("Fecha de Caducidad")
        '    Dim ColUC As Integer = Me.clmUltimoCosto.Index
        '    Dim colCP As Integer = Me.clmCostoPromedio.Index
        '    Dim Val As Boolean = False
        '    Dim msg As String = "Debe especificar:" & vbCrLf
        '    Dim c As New CeldaClass(dgv, e.RowIndex)
        '    Dim prod As New CN.ProductoClass(c.ValorCelda(ColCve).ToString)

        '    If IsDBNull(c.ValorCelda(ColFecCad)) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
        '        Val = True
        '        msg &= "La fecha de caducidad del producto." & vbCrLf
        '    ElseIf Not IsDBNull(c.ValorCelda(ColFecCad)) Then
        '        If CDate(c.ValorCelda(ColFecCad)) < CDate(Now.ToShortDateString).AddDays(prod.DiasminCaducidad) And prod.Caducidad And c.ValorCelda(ColCan) <> 0 Then
        '            Val = True
        '            msg &= String.Format("Una fecha de caducidad que tenga como minimo {0} a partir de la fecha de hoy.", prod.DiasminCaducidad) & vbCrLf
        '        End If
        '    End If

        '    If c.ValorCelda(ColLot).ToString.Replace(" ", "").Length = 0 And prod.SeManejaPorLotes <> 0 And c.ValorCelda(ColCan) Then
        '        Val = True
        '        msg &= "El lote al que pertenece el producto." & vbCrLf
        '    End If

        '    If CDec(c.ValorCelda(colCP).ToString.Replace("$", "").Replace(",", "")) = 0 Then
        '        Val = True
        '        msg &= "El Costo Promedio actual del producto." & vbNewLine
        '    End If

        '    If Not prod.SeManejaPorLotes AndAlso CDec(c.ValorCelda(ColUC).ToString.Replace("$", "").Replace(",", "")) = 0 Then
        '        Val = True
        '        msg &= "El Ultimo Costo actual del producto." & vbNewLine
        '    End If

        '    If Val Then
        '        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        e.Cancel = True
        '    End If

        '    If c.ValorCelda(ColCan) = 0 Then
        '        c.ValorCelda(ColFecCad) = DBNull.Value
        '        c.ValorCelda(ColLot) = ""
        '    End If
        'End If
    End Sub

    Private Function ObtenerIndiceColumna(ByVal TituloColumna As String) As Integer
        For Each columna As DataGridViewColumn In dgv.Columns
            If columna.HeaderText = TituloColumna Then Return columna.Index
        Next
        Return -1
    End Function

    Private Class CeldaClass
        Private ren As Integer
        Private dgv As DataGridView

        Sub New(ByVal myDataGridView As DataGridView, ByVal Renglon As Integer)
            dgv = myDataGridView
            ren = Renglon
        End Sub

        Public Property ValorCelda(ByVal indice As Integer) As Object
            Get
                Return dgv.Item(indice, ren).Value
            End Get
            Set(ByVal value As Object)
                dgv.Item(indice, ren).Value = value
            End Set
        End Property
    End Class
#End Region

#Region " Botones "
    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Liberado = False
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Almacen As CN.AlmacenClass = cmbAlmacen.SelectedItem
        'Dim Tipos As New CN.TipoMovimientoAlmacenCollectionClass

        'Tipos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

        'Dim AlmacenConf As New CN.InventarioConfiguracionClass(1, Tipos)
        'Dim TipoMovimiento As CN.TipoMovimientoClass = AlmacenConf.ObtenerTipoMovimiento(ClasesNegocio.InventarioConfiguracionClass.TipoMovimientoEnum.Entradas_X_Inventario_Inicial)

        'If Not IsNothing(Almacen) Then
        '    Dim Usuario As New CN.UsuarioClass(SesionActual.MiUsuario.Usrndx)
        '    Dim ControlInventario As New CN.ControlInventarioClass(Almacen, Usuario, TipoMovimiento, CDate(lblFecha.Text), ClasesNegocio.OrigenEnum.INVENTARIOS, "")

        '    For Each Row As DsStoredProcedures.ObtenerProductosParaCargaInicialRow In ds.ObtenerProductosParaCargaInicial
        '        If Row.Cantidad > 0 Then
        '            Dim producto As New CN.ProductoClass(Row.Clave)

        '            ControlInventario.AgregarMovimientoAlmacen(producto, CDate(lblFecha.Text), Row.Cantidad, 0)
        '        End If
        '    Next

        '    If ControlInventario.NumeroMovimientos > 0 Then
        '        Dim Folio As String = ControlInventario.Guardar()

        '        If Folio <> "" Then
        '            MessageBox.Show("El Folio asignado a este movimiento fue: " & Folio, "Operación Generada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, False)
        '        End If
        '    End If

        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        'Else
        '    MessageBox.Show("No ha seleccionado ningun almacén", "Aviso")
        'End If
    End Sub
#End Region

#Region " Otros Controles "
    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Liberado = True
        tmr.Stop()
    End Sub
#End Region

#Region " Controles del Formulario "
    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged
        If IsNumeric(txtClave.Text) Then
            cmbAlmacen.SelectedValue = CInt(txtClave.Text)

            If cmbAlmacen.SelectedValue Is Nothing Then
                dgv.DataSource = Nothing
            End If
        Else
            dgv.DataSource = Nothing
        End If
    End Sub

    Private Sub cmbAlmacen_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAlmacen.SelectedIndexChanged
        If cmbAlmacen.SelectedIndex > -1 Then
            RemoveHandler txtClave.TextChanged, AddressOf txtClave_TextChanged
            txtClave.Text = cmbAlmacen.SelectedValue.ToString
            AddHandler txtClave.TextChanged, AddressOf txtClave_TextChanged

            Me.Rellenar()
            Me.dgv.Enabled = True
            Me.btnGuardar.Enabled = True
            Me.txtProducto.Clear()
            Me.txtLinea.Clear()
        End If
    End Sub
#End Region

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.dgv.Rows.Count > 0 Then
            Me.Coleccion.Filtrar("", "")

            If Me.HayProductosParaCargar Then
                Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

                Try
                    Dim movimiento As New EC.InventarioMovimientoAlmacenEntity
                    Dim movimientoDetalles As New CC.InventarioMovimientoAlmacenDetallesCollection
                    Dim almacenId As Integer = DirectCast(Me.cmbAlmacen.SelectedItem, ClasesNegocio.AlmacenClass).Codigo
                    Dim indice As Integer = 1

                    trans.Add(movimiento)
                    trans.Add(movimientoDetalles)

                    movimiento.AlmacenId = almacenId
                    movimiento.FechaMovimiento = Now
                    movimiento.TipoMovimientoId = config.ExInventarioInicial.Value
                    movimiento.Origen = " "
                    movimiento.Referencia = " "
                    movimiento.UsuarioId = Controlador.Sesion.Usrndx
                    movimiento.EstatusContabilizado = 0S

                    For i As Integer = Me.dgv.Rows.Count - 1 To 0 Step -1
                        Dim row As DataGridViewRow = dgv.Rows(i)
                        'Dim s As String = row.Cells(Me.ProductoDataGridViewTextBoxColumn.Index).Value

                        If row.DefaultCellStyle.BackColor = Color.LightGreen Then
                            Dim movimientoDetalle As New EC.InventarioMovimientoAlmacenDetallesEntity
                            Dim InvAlm As New EC.InventarioAlmacenEntity
                            Dim productoId As Integer = row.Cells(Me.clmProductoId.Index).Value
                            Dim cantidad As Decimal = row.Cells(Me.clmCantidad.Index).Value
                            Dim mes As Integer = Now.Month
                            Dim año As Integer = Now.Year
                            Dim ultimoCosto As Decimal = row.Cells(Me.clmUltimoCosto.Index).Value
                            Dim costoPromedio As Decimal = row.Cells(Me.clmCostoPromedio.Index).Value
                            Dim lote As String = row.Cells(Me.clmLote.Index).Value

                            With movimientoDetalle
                                .InventarioMovimientosAlmacen = movimiento
                                .ProductoId = productoId
                                .FechaMovimiento = Now
                                .Cantidad = cantidad
                                .Costo = ultimoCosto
                                .Descuento = 0D
                                .Indice = indice
                            End With

                            movimientoDetalles.Add(movimientoDetalle)

                            trans.Add(InvAlm)

                            If InvAlm.FetchUsingPK(almacenId, productoId, año, mes) Then
                                '-=Si hay un registro en el mes actual=-
                                '=)
                                With InvAlm
                                    Dim cp As Decimal

                                    cp = ((.CantidadExistencia * .CostoPromedio) + (cantidad * ultimoCosto)) / _
                                        (.CantidadExistencia + cantidad)

                                    .CantidadExistencia += cantidad
                                    .CantidadEntrada += cantidad
                                    .FechaUltimaEntrada = Now.ToShortDateString
                                    .CostoPromedio = cp
                                    .UltimoCosto = ultimoCosto
                                    .FechaUltimoCosto = Now.ToShortDateString
                                End With
                            Else
                                '-=Si no un registro en el mes actual=-

                                If InvAlm.FetchUsingPK(almacenId, productoId, Now.AddMonths(-1).Year, _
                                                         Now.AddMonths(-1).Month) Then
                                    Dim almInvTemp As New EC.InventarioAlmacenEntity

                                    trans.Add(almInvTemp)

                                    '-=Si hay un registro del mes anterior=-
                                    With almInvTemp
                                        .AlmacenId = almacenId
                                        .ProductoId = productoId
                                        .Año = año
                                        .Mes = mes
                                        .CantidadEntrada = cantidad
                                        .FechaUltimaEntrada = Now.ToShortDateString
                                        .CantidadSalidas = 0D
                                        .CantidadExistencia = InvAlm.CantidadExistencia + cantidad
                                        .CantidadInicial = InvAlm.CantidadExistencia
                                        .CantidadPorSurtir = 0D

                                        Dim CP As Decimal = ((InvAlm.CantidadExistencia * InvAlm.CostoPromedio) + (cantidad * ultimoCosto)) / _
                                                            (InvAlm.CantidadExistencia + cantidad)

                                        .CostoPromedio = CP
                                        .UltimoCosto = ultimoCosto
                                        .FechaUltimoCosto = Now.ToShortDateString
                                    End With

                                    InvAlm = almInvTemp
                                Else
                                    '-=Si no hay un registro del mes anterior=-
                                    With InvAlm
                                        InvAlm.AlmacenId = almacenId
                                        InvAlm.ProductoId = productoId
                                        InvAlm.Año = año
                                        InvAlm.Mes = mes
                                        InvAlm.CantidadExistencia = cantidad
                                        InvAlm.CantidadInicial = cantidad
                                        InvAlm.CantidadEntrada = cantidad
                                        InvAlm.FechaUltimaEntrada = Now.ToShortDateString
                                        InvAlm.CantidadSalidas = 0D
                                        InvAlm.CostoPromedio = costoPromedio
                                        InvAlm.UltimoCosto = ultimoCosto
                                        InvAlm.FechaUltimaEntrada = Now.ToShortDateString
                                        InvAlm.FechaUltimoCosto = Now.ToShortDateString
                                        InvAlm.CantidadPorSurtir = 0D
                                    End With
                                End If
                            End If

                            If Not InvAlm.Save Then
                                trans.Rollback()
                                MsgBox("No se logro guardar", MsgBoxStyle.Exclamation, "Aviso")
                                Exit Sub
                            End If

                            If InvAlm.Producto.SeManejaPorLotes Then
                                Dim invAlmLote As New EC.InventarioAlmacenLotesEntity

                                Dim col As New CC.InventarioAlmacenLotesCollection

                                trans.Add(col)

                                If col.GetDbCount(HC.inventarioAlmacenLotesFields.AlmacenId = almacenId And _
                                                    HC.inventarioAlmacenLotesFields.ProductoId = productoId And _
                                                    HC.inventarioAlmacenLotesFields.Año = año And _
                                                    HC.inventarioAlmacenLotesFields.Mes = mes And _
                                                    HC.inventarioAlmacenLotesFields.Lote = _
                                                    row.Cells(Me.clmLote.Index).Value) > 0 Then
                                    trans.Rollback()
                                    MsgBox(String.Format("El lote {0} con el producto {1} en el almacén {2} ya se le genero una carga inicial", row.Cells(Me.clmLote.Index).Value, row.Cells(Me.clmProducto.Index).Value, Me.cmbAlmacen.Text), MsgBoxStyle.Exclamation, "Aviso")
                                    Exit Sub
                                End If

                                trans.Add(invAlmLote)

                                invAlmLote.AlmacenId = InvAlm.AlmacenId
                                invAlmLote.ProductoId = InvAlm.ProductoId
                                invAlmLote.Año = InvAlm.Año
                                invAlmLote.Mes = InvAlm.Mes
                                invAlmLote.Lote = row.Cells(Me.clmLote.Index).Value
                                invAlmLote.FechaUltimoCosto = Now.ToShortDateString
                                invAlmLote.UltimoCosto = row.Cells(Me.clmUltimoCosto.Index).Value
                                invAlmLote.CostoPromedio = row.Cells(Me.clmCostoPromedio.Index).Value
                                invAlmLote.CantidadInicial = row.Cells(Me.clmCantidad.Index).Value
                                invAlmLote.CantidadExistencia = row.Cells(Me.clmCantidad.Index).Value
                                invAlmLote.CantidadEntrada = 0
                                invAlmLote.CantidadSalidas = 0
                                If CBool(row.Cells(Me.clmCaduca.Index).Value) Then invAlmLote.FechaCaducidad = row.Cells(Me.clmFechaCaducidad.Index).Value
                                invAlmLote.FechaAlta = Now.ToShortDateString
                                invAlmLote.CantidadPorSurtir = 0

                                invAlmLote.Save()
                            End If
                        End If

                        indice += 1
                    Next

                    movimiento.FolioMovimiento = ClasesNegocio.AlmacenGeneral.MovimientoAlmacenClass.ObtenerFolioMovimiento(DirectCast(Me.cmbAlmacen.SelectedItem, ClasesNegocio.AlmacenClass).Codigo, trans)
                    'SPA.ObtenerFolioMovimiento(DirectCast(Me.cmbAlmacen.SelectedItem, ClasesNegocio.AlmacenClass).Letras, movimiento.FolioMovimiento, trans)

                    movimiento.Save()
                    movimientoDetalles.SaveMulti()

                    trans.Commit()

                    MsgBox("Se guardo la carga inicial de productos correctamente", MsgBoxStyle.Information, "Carga Inicial Guardada")
                    cmbAlmacen.SelectedIndex = -1
                    cmbAlmacen.Text = "Seleccione una almacén"
                    Me.txtProducto.Clear()
                    Me.txtLinea.Clear()
                    Me.dgv.DataSource = Nothing
                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtProducto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged
        Me.Coleccion.Filtrar(Me.txtProducto.Text, Me.txtLinea.Text)
    End Sub

    Private Sub txtLinea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLinea.TextChanged
        Me.Coleccion.Filtrar(Me.txtProducto.Text, Me.txtLinea.Text)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class