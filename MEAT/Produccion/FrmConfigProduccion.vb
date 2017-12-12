Imports CN = ClasesNegocio
Imports System.Text
Imports System.Security.Cryptography

Public Class FrmConfigProduccion

    Dim ColeccionCanales As CN.AlmacenCollectionClass
    Dim coleccionCortes As CN.AlmacenCollectionClass
    Dim ColeccionProductos As CN.AlmacenCollectionClass
    Dim ColeccionDecomisos As CN.AlmacenCollectionClass
    Dim ColeccionCongelados As CN.AlmacenCollectionClass
    Dim coleccionValorAgregado As CN.AlmacenCollectionClass
    Dim coleccionValorAgregadoCongelado As CN.AlmacenCollectionClass
    Dim Band As Boolean = False
    Dim ContraseñaInvalida As Boolean
    Dim TiposAlm As CN.TipoAlmacenCollectionClass

    Private Sub FrmAlmConfigProduccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TiposAlm = New CN.TipoAlmacenCollectionClass
            TiposAlm.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbTiposAlm.ValueMember = "Codigo"
            Me.CmbTiposAlm.DisplayMember = "Descripcion"

            RemoveHandler CmbTiposAlm.SelectedIndexChanged, AddressOf CmbTiposAlm_SelectedIndexChanged
            Me.CmbTiposAlm.DataSource = TiposAlm
            AddHandler CmbTiposAlm.SelectedIndexChanged, AddressOf CmbTiposAlm_SelectedIndexChanged

            Me.CmbTiposAlm.SelectedIndex = -1

            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.IdTipoAlmacen.HasValue Then
                Me.CmbTiposAlm.SelectedValue = Controlador.Configuracion.Produccion.IdTipoAlmacen.Value
            End If

            If Me.CmbTiposAlm.SelectedIndex > -1 Then
                LlenarCombox()
            End If

            PonerDatos()

            Band = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub LlenarCombox()
        Try
            Dim ColeccionCanales As New CN.AlmacenCollectionClass
            Dim coleccionCortes As New CN.AlmacenCollectionClass
            Dim ColeccionProductos As New CN.AlmacenCollectionClass
            Dim ColeccionDecomisos As New CN.AlmacenCollectionClass
            Dim ColeccionCongelados As New CN.AlmacenCollectionClass
            Dim coleccionValorAgregado As New CN.AlmacenCollectionClass
            Dim coleccionValorAgregadoCongelado As New CN.AlmacenCollectionClass
            Dim AuxAlm As New CN.AlmacenClass

            AuxAlm.Descripcion = "Ninguno"
            ColeccionCanales.Add(AuxAlm)
            coleccionCortes.Add(AuxAlm)
            ColeccionProductos.Add(AuxAlm)
            ColeccionDecomisos.Add(AuxAlm)
            ColeccionCongelados.Add(AuxAlm)
            coleccionValorAgregado.Add(AuxAlm)
            coleccionValorAgregadoCongelado.Add(AuxAlm)

            Dim Coleccion As New CN.AlmacenCollectionClass
            Coleccion.ObtenerPorTipo(ClasesNegocio.CondicionEnum.ACTIVOS, Me.CmbTiposAlm.SelectedValue)

            For Each alm As CN.AlmacenClass In Coleccion
                ColeccionCanales.Add(alm)
                coleccionCortes.Add(alm)
                ColeccionProductos.Add(alm)
                ColeccionDecomisos.Add(alm)
                ColeccionCongelados.Add(alm)
                coleccionValorAgregado.Add(alm)
                coleccionValorAgregadoCongelado.Add(alm)
            Next

            Me.CmbCanales.DataSource = ColeccionCanales
            Me.CmbCanales.DisplayMember = "Descripcion"
            Me.CmbCanales.ValueMember = "Codigo"
            Me.CmbCanales.SelectedIndex = 0

            Me.CmbProductos.DataSource = ColeccionProductos
            Me.CmbProductos.DisplayMember = "Descripcion"
            Me.CmbProductos.ValueMember = "codigo"
            Me.CmbProductos.SelectedIndex = 0

            Me.CmbCortes.DataSource = coleccionCortes
            Me.CmbCortes.DisplayMember = "Descripcion"
            Me.CmbCortes.ValueMember = "Codigo"
            Me.CmbCortes.SelectedIndex = 0

            Me.CmbDecomisos.DataSource = ColeccionDecomisos
            Me.CmbDecomisos.DisplayMember = "Descripcion"
            Me.CmbDecomisos.ValueMember = "Codigo"
            Me.CmbDecomisos.SelectedIndex = 0

            Me.cmbAlmacenCongelado.DataSource = ColeccionCongelados
            Me.cmbAlmacenCongelado.DisplayMember = "Descripcion"
            Me.cmbAlmacenCongelado.ValueMember = "Codigo"
            Me.cmbAlmacenCongelado.SelectedIndex = 0

            Me.cmbAlmacenValorAgregado.DataSource = coleccionValorAgregado
            Me.cmbAlmacenValorAgregado.DisplayMember = "Descripcion"
            Me.cmbAlmacenValorAgregado.ValueMember = "Codigo"
            Me.cmbAlmacenValorAgregado.SelectedIndex = 0

            Me.cmbAlmacenValorAgragadoCongelado.DataSource = coleccionValorAgregadoCongelado
            Me.cmbAlmacenValorAgragadoCongelado.DisplayMember = "Descripcion"
            Me.cmbAlmacenValorAgragadoCongelado.ValueMember = "Codigo"
            Me.cmbAlmacenValorAgragadoCongelado.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Try
            If Not Me.txtContraseñaNva.Text = Me.txtConfirmacion.Text Then
                MsgBox("La Confirmación de contraseña no es igual a la contraseña nueva", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function Guardar() As Boolean
        Try
            Controlador.Configuracion.Produccion.ObtenerCanalAutomaticamente = Me.chkObtenerCanalAutomaticamente.Checked
            Controlador.Configuracion.Produccion.ObtenerPeso = Me.chkObtenerPeso.Checked
            Controlador.Configuracion.Produccion.RecibirCanales = Me.ChkRecibirCanales.Checked
            Controlador.Configuracion.Produccion.EmbarcarMasDeUnCliente = Me.ChkEmbarcar.Checked
            Controlador.Configuracion.Produccion.EmbarcarDiferentesProd = Me.ChkCanales.Checked
            Controlador.Configuracion.Produccion.ImprimirEtiquetasCortes = Me.ChkimprimirCorte.Checked
            Controlador.Configuracion.Produccion.ImprimirEtiquetasCanales = Me.ChkEtiquetaCanal.Checked
            Controlador.Configuracion.Produccion.ImprimirEtiquetasProductos = Me.ChkEtiquetaProducto.Checked
            Controlador.Configuracion.Produccion.LlenarCajasDifProductos = Me.ChkLlenarCajas.Checked
            Controlador.Configuracion.Produccion.ImprimirEtiquetasDifProd = Me.ChkEtiquetaDifCortes.Checked
            Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos = Me.ChkTrabajarSacrificios.Checked
            Controlador.Configuracion.Produccion.TrabajarLotesCortesAbiertos = Me.ChkTrabajarCortes.Checked
            Controlador.Configuracion.Produccion.LoteCorteAsociado = Me.chkLoteCorteAsociado.Checked
            Controlador.Configuracion.Produccion.IdConfiguracion = 1
            Controlador.Configuracion.Produccion.TiempoEspera = Decimal.ToInt32(Me.nudTiempoEspera.Value)
            Controlador.Configuracion.Produccion.PrecioEmbarque = Me.chkPrecioenEmbarque.Checked
            Controlador.Configuracion.Produccion.ProductosDerivados = Me.chkProductosDerivados.Checked

            If Not Controlador.Configuracion.Produccion.PrecioEmbarque Then
                Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion = False
            Else
                Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion = Me.chkReferenciarPrecioEmbarqueEnFacturacion.Checked
            End If

            Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado = Decimal.ToInt32(Me.nudCongeladoDiasCaducidad.Value)
            Controlador.Configuracion.Produccion.DiasCaducidadProdFresco = Decimal.ToInt32(Me.nudFrescoDiasCaducidad.Value)
            Controlador.Configuracion.Produccion.TemperaturaProdCongelado = Decimal.ToInt32(Me.nudCongeladoTemperatura.Value)
            Controlador.Configuracion.Produccion.TemperaturaProdFresco = Decimal.ToInt32(Me.nudFrescoTemperatura.Value)
            Controlador.Configuracion.Produccion.TemperaturaValorAgregado = Decimal.ToInt32(Me.nudValorAgregadoTemperatura.Value)
            Controlador.Configuracion.Produccion.DiasCaducidadValorAgregado = Decimal.ToInt32(Me.nudValorAgregadoDiasCaducidad.Value)
            Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado = Decimal.ToInt32(Me.nudValorAgregadoDiasCadCongelado.Value)
            Controlador.Configuracion.Produccion.TemperaturaValorAgregadoCongelado = Decimal.ToInt32(Me.nudValorAgregadoTemperaturaCongelado.Value)
            Controlador.Configuracion.Produccion.DiasCaducidadHuesoFresco = Decimal.ToInt32(Me.nudDiasCaducidadHuesoFresco.Value)
            Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado = Decimal.ToInt32(Me.nudDiasCaducidadHuesoCongelado.Value)
            Controlador.Configuracion.Produccion.EsTIFLogo = chkEsTIFLogo.Checked

            If Me.CmbTiposAlm.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdTipoAlmacen = CType(Me.CmbTiposAlm.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdTipoAlmacen = Nothing

            End If

            If Me.CmbCanales.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenCanales = CType(Me.CmbCanales.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenCanales = Nothing

            End If

            If Me.CmbCortes.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenesCortes = CType(Me.CmbCortes.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenesCortes = Nothing
            End If

            If Me.CmbProductos.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenProductos = CType(Me.CmbProductos.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenProductos = Nothing
            End If

            If Me.CmbDecomisos.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenDecomisos = CType(Me.CmbDecomisos.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenDecomisos = Nothing
            End If

            If Me.cmbAlmacenValorAgragadoCongelado.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenValorAgregadoCongelado = CType(Me.cmbAlmacenValorAgragadoCongelado.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenValorAgregadoCongelado = Nothing
            End If

            If Me.cmbAlmacenValorAgregado.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenValorAgregado = CType(Me.cmbAlmacenValorAgregado.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenValorAgregado = Nothing
            End If

            If Me.cmbAlmacenCongelado.SelectedIndex > -1 Then
                Controlador.Configuracion.Produccion.IdAlmacenCorteCongelado = CType(Me.cmbAlmacenCongelado.SelectedValue, Integer)
            Else
                Controlador.Configuracion.Produccion.IdAlmacenCorteCongelado = Nothing
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.chkObtenerCanalAutomaticamente.Checked = Controlador.Configuracion.Produccion.ObtenerCanalAutomaticamente
        Me.chkObtenerPeso.Checked = Controlador.Configuracion.Produccion.ObtenerPeso
        Me.ChkRecibirCanales.Checked = Controlador.Configuracion.Produccion.RecibirCanales
        Me.ChkEmbarcar.Checked = Controlador.Configuracion.Produccion.EmbarcarMasDeUnCliente
        Me.ChkCanales.Checked = Controlador.Configuracion.Produccion.EmbarcarDiferentesProd
        Me.ChkimprimirCorte.Checked = Controlador.Configuracion.Produccion.ImprimirEtiquetasCortes
        Me.ChkEtiquetaCanal.Checked = Controlador.Configuracion.Produccion.ImprimirEtiquetasCanales
        Me.ChkEtiquetaProducto.Checked = Controlador.Configuracion.Produccion.ImprimirEtiquetasProductos
        Me.ChkLlenarCajas.Checked = Controlador.Configuracion.Produccion.LlenarCajasDifProductos
        Me.ChkEtiquetaDifCortes.Checked = Controlador.Configuracion.Produccion.ImprimirEtiquetasDifProd
        Me.ChkTrabajarSacrificios.Checked = Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos
        Me.ChkTrabajarCortes.Checked = Controlador.Configuracion.Produccion.TrabajarLotesCortesAbiertos
        Me.chkLoteCorteAsociado.Checked = Controlador.Configuracion.Produccion.LoteCorteAsociado
        Me.chkPrecioenEmbarque.Checked = Controlador.Configuracion.Produccion.PrecioEmbarque

        If Me.chkPrecioenEmbarque.Checked Then
            Me.chkReferenciarPrecioEmbarqueEnFacturacion.Enabled = True
            Me.chkReferenciarPrecioEmbarqueEnFacturacion.Checked = Controlador.Configuracion.Produccion.ReferenciarPrecioEmbarqueEnFacturacion
        Else
            Me.chkReferenciarPrecioEmbarqueEnFacturacion.Enabled = False
            Me.chkReferenciarPrecioEmbarqueEnFacturacion.Checked = False
        End If

        Me.chkProductosDerivados.Checked = Controlador.Configuracion.Produccion.ProductosDerivados

        If Controlador.Configuracion.Produccion.IdAlmacenCanales.HasValue Then
            Me.CmbCanales.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenCanales.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenesCortes.HasValue Then
            Me.CmbCortes.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenesCortes.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenProductos.HasValue Then
            Me.CmbProductos.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenProductos.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenDecomisos.HasValue Then
            Me.CmbDecomisos.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenDecomisos.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenCorteCongelado.HasValue Then
            Me.cmbAlmacenCongelado.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenCorteCongelado.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenValorAgregado.HasValue Then
            Me.cmbAlmacenValorAgregado.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenValorAgregado.Value
        End If

        If Controlador.Configuracion.Produccion.IdAlmacenValorAgregadoCongelado.HasValue Then
            Me.cmbAlmacenValorAgragadoCongelado.SelectedValue = Controlador.Configuracion.Produccion.IdAlmacenValorAgregadoCongelado.Value
        End If

        Me.nudCongeladoDiasCaducidad.Value = Controlador.Configuracion.Produccion.DiasCaducidadProdCongelado
        Me.nudCongeladoTemperatura.Value = Controlador.Configuracion.Produccion.TemperaturaProdCongelado
        Me.nudFrescoDiasCaducidad.Value = Controlador.Configuracion.Produccion.DiasCaducidadProdFresco
        Me.nudFrescoTemperatura.Value = Controlador.Configuracion.Produccion.TemperaturaProdFresco
        Me.nudValorAgregadoTemperatura.Value = Controlador.Configuracion.Produccion.TemperaturaValorAgregado
        Me.nudValorAgregadoDiasCaducidad.Value = Controlador.Configuracion.Produccion.DiasCaducidadValorAgregado
        Me.nudValorAgregadoDiasCadCongelado.Value = Controlador.Configuracion.Produccion.DiasCaducidadValorAgregadoCongelado
        Me.nudValorAgregadoTemperaturaCongelado.Value = Controlador.Configuracion.Produccion.TemperaturaValorAgregadoCongelado
        Me.nudDiasCaducidadHuesoFresco.Value = Controlador.Configuracion.Produccion.DiasCaducidadHuesoFresco
        Me.nudDiasCaducidadHuesoCongelado.Value = Controlador.Configuracion.Produccion.DiasCaducidadHuesoCongelado
        Me.chkEsTIFLogo.Checked = Controlador.Configuracion.Produccion.EsTIFLogo

        If Controlador.Configuracion.Produccion.TiempoEspera < 5 Then
            Me.nudTiempoEspera.Value = 5
            Controlador.Configuracion.Produccion.TiempoEspera = 5
        Else
            Me.nudTiempoEspera.Value = Controlador.Configuracion.Produccion.TiempoEspera
        End If

        If CmbTiposAlm.SelectedIndex > -1 Then
            Me.FiltrarCombo()
        End If
    End Sub

    Private Sub FiltrarCombo()
        Try
            Dim Cortes As Integer
            Dim Canales As Integer
            Dim Productos As Integer
            Dim Decomisos As Integer
            Dim Congelado As Integer
            Dim ValorAgregado As Integer
            Dim ValorAgregadoCongelado As Integer

            If Me.CmbCortes.SelectedIndex > 0 Then
                Cortes = CType(Me.CmbCortes.SelectedValue, Integer)
            Else
                Cortes = -1
            End If

            If Me.CmbCanales.SelectedIndex > 0 Then
                Canales = CType(Me.CmbCanales.SelectedValue, Integer)
            Else
                Canales = -1
            End If

            If Me.CmbProductos.SelectedIndex > 0 Then
                Productos = CType(Me.CmbProductos.SelectedValue, Integer)
            Else
                Productos = -1
            End If

            If Me.CmbDecomisos.SelectedIndex > 0 Then
                Decomisos = CType(Me.CmbDecomisos.SelectedValue, Integer)
            Else
                Decomisos = -1
            End If

            If Me.cmbAlmacenCongelado.SelectedIndex > 0 Then
                Congelado = CType(Me.cmbAlmacenCongelado.SelectedValue, Integer)
            Else
                Congelado = -1
            End If

            If Me.cmbAlmacenValorAgregado.SelectedIndex > 0 Then
                ValorAgregado = CType(Me.cmbAlmacenValorAgregado.SelectedValue, Integer)
            Else
                ValorAgregado = -1
            End If

            If Me.cmbAlmacenValorAgragadoCongelado.SelectedIndex > 0 Then
                ValorAgregadoCongelado = CType(Me.cmbAlmacenValorAgragadoCongelado.SelectedValue, Integer)
            Else
                ValorAgregadoCongelado = -1
            End If

            Dim CodigosCanales() As Integer = {Cortes, Productos, Decomisos, ValorAgregado, Congelado, ValorAgregadoCongelado}
            Dim codigosDecomisos() As Integer = {Cortes, Canales, Productos, ValorAgregado, Congelado, ValorAgregadoCongelado}
            Dim codigosCortes() As Integer = {Canales, Productos, Decomisos, ValorAgregado, Congelado, ValorAgregadoCongelado}
            Dim CodigosProductos() As Integer = {Cortes, Canales, Decomisos, ValorAgregado, Congelado, ValorAgregadoCongelado}
            Dim CodigosCongelado() As Integer = {Cortes, Canales, Decomisos, Productos, ValorAgregado, ValorAgregadoCongelado}
            Dim CodigosValorAgregado() As Integer = {Cortes, Canales, Decomisos, Productos, Congelado, ValorAgregadoCongelado}
            Dim CodigosValorAgregadoCongelado() As Integer = {Cortes, Canales, Decomisos, Productos, Congelado, ValorAgregado}

            ColeccionCanales = New CN.AlmacenCollectionClass
            ColeccionCanales.Obtener(CodigosCanales, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.CmbCanales.DisplayMember = "Descripcion"
            Me.CmbCanales.ValueMember = "Codigo"
            Me.CmbCanales.DataSource = ColeccionCanales

            If Canales = -1 Then
                Me.CmbCanales.SelectedIndex = 0
            Else
                Me.CmbCanales.SelectedValue = Canales
            End If

            coleccionCortes = New CN.AlmacenCollectionClass
            coleccionCortes.Obtener(codigosCortes, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.CmbCortes.DisplayMember = "Descripcion"
            Me.CmbCortes.ValueMember = "Codigo"
            Me.CmbCortes.DataSource = coleccionCortes

            If Cortes = -1 Then
                Me.CmbCortes.SelectedIndex = 0
            Else
                Me.CmbCortes.SelectedValue = Cortes
            End If

            ColeccionProductos = New CN.AlmacenCollectionClass
            ColeccionProductos.Obtener(CodigosProductos, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.CmbProductos.DisplayMember = "Descripcion"
            Me.CmbProductos.ValueMember = "Codigo"
            Me.CmbProductos.DataSource = ColeccionProductos

            If Productos = -1 Then
                Me.CmbProductos.SelectedIndex = 0
            Else
                Me.CmbProductos.SelectedValue = Productos
            End If

            ColeccionDecomisos = New CN.AlmacenCollectionClass
            ColeccionDecomisos.Obtener(codigosDecomisos, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.CmbDecomisos.DisplayMember = "Descripcion"
            Me.CmbDecomisos.ValueMember = "Codigo"
            Me.CmbDecomisos.DataSource = ColeccionDecomisos

            If Decomisos = -1 Then
                Me.CmbDecomisos.SelectedIndex = 0
            Else
                Me.CmbDecomisos.SelectedValue = Decomisos
            End If

            Me.ColeccionCongelados = New CN.AlmacenCollectionClass
            Me.ColeccionCongelados.Obtener(CodigosCongelado, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.cmbAlmacenCongelado.DisplayMember = "Descripcion"
            Me.cmbAlmacenCongelado.ValueMember = "Codigo"
            Me.cmbAlmacenCongelado.DataSource = Me.ColeccionCongelados

            If Congelado = -1 Then
                Me.cmbAlmacenCongelado.SelectedIndex = 0
            Else
                Me.cmbAlmacenCongelado.SelectedValue = Congelado
            End If

            Me.coleccionValorAgregado = New CN.AlmacenCollectionClass
            Me.coleccionValorAgregado.Obtener(CodigosValorAgregado, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.cmbAlmacenValorAgregado.DisplayMember = "Descripcion"
            Me.cmbAlmacenValorAgregado.ValueMember = "Codigo"
            Me.cmbAlmacenValorAgregado.DataSource = Me.coleccionValorAgregado

            If ValorAgregado = -1 Then
                Me.cmbAlmacenValorAgregado.SelectedIndex = 0
            Else
                Me.cmbAlmacenValorAgregado.SelectedValue = ValorAgregado
            End If

            Me.coleccionValorAgregadoCongelado = New CN.AlmacenCollectionClass
            Me.coleccionValorAgregadoCongelado.Obtener(CodigosValorAgregadoCongelado, ClasesNegocio.CondicionEnum.ACTIVOS, True, CType(Me.CmbTiposAlm.SelectedValue, Integer))
            Me.cmbAlmacenValorAgragadoCongelado.DisplayMember = "Descripcion"
            Me.cmbAlmacenValorAgragadoCongelado.ValueMember = "Codigo"
            Me.cmbAlmacenValorAgragadoCongelado.DataSource = Me.coleccionValorAgregadoCongelado

            If ValorAgregadoCongelado = -1 Then
                Me.cmbAlmacenValorAgragadoCongelado.SelectedIndex = 0
            Else
                Me.cmbAlmacenValorAgragadoCongelado.SelectedValue = ValorAgregadoCongelado
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If
         
            If Not Me.txtContraseñaNva.Text = "" Then
                If Controlador.Configuracion.Produccion.Contraseña = "" Then
                    Controlador.Configuracion.Produccion.Contraseña = Me.txtContraseñaNva.Text.GetHashCode.ToString
                Else
                    If Not Me.txtContraseñaAnt.Text = "" Then
                        If Not Me.txtContraseñaAnt.Text.GetHashCode.ToString = Controlador.Configuracion.Produccion.Contraseña Then
                            MsgBox("La Contraseña no es valida", MsgBoxStyle.Exclamation, "Aviso")
                            ContraseñaInvalida = True
                        Else
                            ContraseñaInvalida = False
                            Controlador.Configuracion.Produccion.Contraseña = Me.txtContraseñaNva.Text.GetHashCode.ToString
                        End If
                    End If
                End If
            End If

            If ContraseñaInvalida Then
                Cancelar = True
                Exit Sub
            End If
            If Not Me.Guardar() Then
                Cancelar = True
                Exit Sub
            End If
            If Controlador.Configuracion.Produccion.Guardar() Then
                MessageBox.Show("La Configuración ha sido guardada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtContraseñaNva.Text = ""
                Me.txtConfirmacion.Text = ""
                Me.txtContraseñaAnt.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub CmbCanales_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbCanales.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbCanales_SelectedIndexChanged(sender, New EventArgs)
                'Dim ColeccionCanales As New CN.AlmacenCollectionClass
                'Dim AuxAlm As New CN.AlmacenClass
                'AuxAlm.Descripcion = "Ninguno"
                'ColeccionCanales.Add(AuxAlm)

                'Dim Coleccion As New CN.AlmacenCollectionClass
                'Coleccion.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

                'For Each alm As CN.AlmacenClass In Coleccion
                '    ColeccionCanales.Add(alm)
                'Next

                'Me.CmbCanales.DataSource = ColeccionCanales
                'Me.CmbCanales.DisplayMember = "Descripcion"
                'Me.CmbCanales.ValueMember = "Codigo"
                'Me.CmbCanales.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCanales_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCanales.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub CmbCortes_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbCortes.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbCortes_SelectedIndexChanged(sender, New EventArgs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCortes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCortes.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub CmbProductos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbProductos.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbProductos_SelectedIndexChanged(sender, New EventArgs)
                'Dim ColeccionProductos As New CN.AlmacenCollectionClass

                'Dim AuxAlm As New CN.AlmacenClass
                'AuxAlm.Descripcion = "Ninguno"
                'ColeccionProductos.Add(AuxAlm)

                'Dim Coleccion As New CN.AlmacenCollectionClass
                'Coleccion.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

                'For Each alm As CN.AlmacenClass In Coleccion
                '    ColeccionProductos.Add(alm)
                'Next

                'Me.CmbProductos.DataSource = ColeccionProductos
                'Me.CmbProductos.DisplayMember = "Descripcion"
                'Me.CmbProductos.ValueMember = "codigo"
                'Me.CmbProductos.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbProductos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbProductos.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub CmbDecomisos_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbDecomisos.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbDecomisos_SelectedIndexChanged(sender, New EventArgs)

                'Dim ColeccionDecomisos As New CN.AlmacenCollectionClass
                'Dim AuxAlm As New CN.AlmacenClass
                'AuxAlm.Descripcion = "Ninguno"

                'ColeccionDecomisos.Add(AuxAlm)

                'Dim Coleccion As New CN.AlmacenCollectionClass
                'Coleccion.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)

                'For Each alm As CN.AlmacenClass In Coleccion
                '    ColeccionDecomisos.Add(alm)
                'Next

                'Me.CmbDecomisos.DataSource = ColeccionDecomisos
                'Me.CmbDecomisos.DisplayMember = "Descripcion"
                'Me.CmbDecomisos.ValueMember = "Codigo"
                'Me.CmbDecomisos.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbDecomisos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDecomisos.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub txtContraseñaAnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseñaAnt.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtContraseñaNva.Focus()
        End If
    End Sub

    Private Sub txtContraseñaAnt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContraseñaAnt.LostFocus
        Try
            If Not Controlador.Configuracion.Produccion.Contraseña = "" Then
                If Not Me.txtContraseñaAnt.Text = "" Then
                    If Not Me.txtContraseñaAnt.Text.GetHashCode.ToString = Controlador.Configuracion.Produccion.Contraseña Then
                        MsgBox("La Contraseña no es valida", MsgBoxStyle.Exclamation, "Aviso")
                        ContraseñaInvalida = True
                    Else
                        ContraseñaInvalida = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtContraseñaNva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseñaNva.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtConfirmacion.Focus()
        End If
    End Sub

    Private Sub txtConfirmacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmacion.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtContraseñaAnt.Focus()
        End If
    End Sub

    Private Sub CmbTiposAlm_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbTiposAlm.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                TiposAlm = New CN.TipoAlmacenCollectionClass
                TiposAlm.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                Me.CmbTiposAlm.ValueMember = "Codigo"
                Me.CmbTiposAlm.DisplayMember = "Descripcion"
                Me.CmbTiposAlm.DataSource = TiposAlm
                Me.CmbTiposAlm.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub CmbTiposAlm_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbTiposAlm.SelectedIndexChanged
        Try
            If Me.CmbTiposAlm.SelectedIndex > -1 Then
                Me.FiltrarCombo()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbAlmacenCongelado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacenCongelado.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub cmbAlmacenValorAgregado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacenValorAgregado.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub cmbAlmacenValorAgragadoCongelado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacenValorAgragadoCongelado.SelectedIndexChanged
        If Band Then
            Band = False
            FiltrarCombo()
            Band = True
        End If
    End Sub

    Private Sub chkPrecioenEmbarque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPrecioenEmbarque.CheckedChanged
        If chkPrecioenEmbarque.Checked Then
            chkReferenciarPrecioEmbarqueEnFacturacion.Enabled = True
        Else
            chkReferenciarPrecioEmbarqueEnFacturacion.Enabled = False
            chkReferenciarPrecioEmbarqueEnFacturacion.Checked = False
        End If
    End Sub

End Class