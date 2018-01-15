Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports System.Data.SqlClient

Public Class FrmRegistroSacrificios
    Dim WithEvents RegistroSacrificio As New RegistroSacrificiosClass
    Dim Registros As New RegistroSacrificioColeccionClass
    Dim WithEvents RecepcionGanado As New RecepcionGanadoClass
    Dim CabezasASacrificar As Integer
    Dim Introductores As New ClientesIntroductoresColeccion
    Dim recepciones As TC.VwRegistroSacrificioTypedView
    Dim CantidadCabezas As Decimal = 0 ' se utiiliza para controlar la resta de las cabezas muertas}
    Dim ultimaTecla As Date
    Dim cargobien As Boolean = False
    Dim sacrificioSeleccionado As Boolean = False

    Private Sub FrmRegistroSacrificios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargobien = True
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "101101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")

            Controlador.Configuracion.ActualizarProduccion()

            If Controlador.Configuracion.Produccion.Entidad.IsNew Then
                MsgBox("Debe registrar una configuración de producción, antes de realizar alguna operación en esta ventana", MsgBoxStyle.Exclamation, "Aviso")
                cargobien = False

                If MessageBox.Show("¿Quiere registrar una configuración en este momento?", "Registrar una Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    My.Forms.FrmConfigProduccion.MdiParent = Me.MdiParent
                    My.Forms.FrmConfigProduccion.Show()
                    Exit Sub
                End If
            End If

            If Controlador.Configuracion.Produccion.RecibirCanales Then
                Me.TabControl1.TabPages(1).Hide()
            Else
                Introductores.Obtener(True)
                Me.cmbIntroductor.DisplayMember = "Nombre"
                Me.cmbIntroductor.ValueMember = "Codigo"
                Me.cmbIntroductor.DataSource = Introductores
                Me.cmbIntroductor.SelectedIndex = -1
                Me.dgvRecepcionesGanado.AutoGenerateColumns = False
            End If

            Me.Tiempo.Interval = Controlador.Configuracion.Produccion.TiempoEspera * 1000
            Me.Limpiar()
            Deshabilitar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub ActualizarDatos()
        Try
            Dim consulta As String = "SELECT FolioSacrificio,Res," & _
                                     "(select top 1 det2.KgrsBascula " & _
                                     "from [MSCRecepcionCanalesDet] as det2 " & _
                                     "where det2.FolioSacrificio = det.FolioSacrificio " & _
                                     "AND det2.res = det.res and det2.lado=1) as KgsLado1, " & _
                                     "(select top 1 det2.KgrsBascula from [MSCRecepcionCanalesDet] as det2 " & _
                                     "where	det2.FolioSacrificio=det.FolioSacrificio " & _
                                     "AND det2.res = det.res and det2.lado=2) as KgsLado2 " & _
                                     "FROM MSCRecepcionCanalesDet as det " & _
                                     "WHERE foliosacrificio='" & Me.txtLoteSacrificio.Text.Trim & "' " & _
                                     "GROUP BY foliosacrificio,res"


            '"SELECT FolioSacrificio, SUBSTRING(det.[IdFolioCanal], 0, CHARINDEX ('-',det.[IdFolioCanal])) as Res " & _
            '                                    ",(select top 1 det2.KgrsBascula " & _
            '                                       "from  [MSCRecepcionCanalesDet] as det2 " & _
            '                                       "where det2.FolioMovimiento=det.FolioMovimiento AND " & _
            '                                               "det2.FolioSacrificio=det.FolioSacrificio AND " & _
            '                                               "det2.IdFolioCanal=SUBSTRING(det.[IdFolioCanal], 0, " & _
            '                                               "CHARINDEX ('-',det.[IdFolioCanal]))+'-1') as KgsLado1 " & _
            '                                   ",(select top 1 det3.KgrsBascula " & _
            '                                       "from [MSCRecepcionCanalesDet] as det3 " & _
            '                                       "where det3.FolioMovimiento=det.FolioMovimiento AND " & _
            '                                               "det3.FolioSacrificio=det.FolioSacrificio AND " & _
            '                                               "det3.IdFolioCanal=SUBSTRING(det.[IdFolioCanal], 0, " & _
            '                                               "CHARINDEX ('-',det.[IdFolioCanal]))+'-2') as kgsLado2 " & _
            '                                    "FROM [dbo].[MSCRecepcionCanalesDet] as det " & _
            '                                    "WHERE FolioSacrificio='" & Me.txtLoteSacrificio.Text.Trim & "'" & _
            '                                    "group by FolioMovimiento,FolioSacrificio,SUBSTRING(det.[IdFolioCanal], 0, CHARINDEX ('-',det.[IdFolioCanal])) " & _
            '                                    "order by FolioSacrificio,cast(SUBSTRING(det.[IdFolioCanal], 0, CHARINDEX ('-',det.[IdFolioCanal])) as int) "

            Dim tb As New DataTable

            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()

                ad.Fill(tb)

                ad.SelectCommand.Connection.Close()
            End Using

            Me.dgCanales.AutoGenerateColumns = False
            Me.dgCanales.DataSource = tb

            consulta = "SELECT     UsrProdRegistroSacrificiosProductos.IdProducto, UsrProdRegistroSacrificiosProductos.Piezas, " & _
                       "           UsrProdRegistroSacrificiosProductos.Kilos, MSCCatProductos.Descripcion AS Producto " & _
                       "FROM       UsrProdRegistroSacrificiosProductos INNER JOIN " & _
                       "            MSCCatProductos ON UsrProdRegistroSacrificiosProductos.IdProducto = MSCCatProductos.IdProducto " & _
                       "WHERE FolioSacrificio='" & Me.txtLoteSacrificio.Text.Trim & "' and Decomiso=0 and UsrProdRegistroSacrificiosProductos.Estatus=1"

            Dim tbProd As New DataTable

            Using ad As New SqlDataAdapter(New SqlCommand(consulta, New SqlConnection(HC.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()

                ad.Fill(tbProd)

                ad.SelectCommand.Connection.Close()
            End Using

            Me.dgProductosRecibidos.AutoGenerateColumns = False
            Me.dgProductosRecibidos.DataSource = tbProd

            consulta = "SELECT      UsrProdRegistroSacrificiosDecomiso.IdProducto, " & _
                       "            MSCCatProductos.Descripcion AS Producto, " & _
                       "            UsrProdRegistroSacrificiosDecomiso.Piezas, " & _
                       "            UsrProdRegistroSacrificiosDecomiso.Kilos, UsrProdRegistroSacrificiosDecomiso.IdDecomiso, " & _
                       "            MSCCatDecomisos.Descripcion AS Decomiso " & _
                       "FROM        UsrProdRegistroSacrificiosDecomiso INNER JOIN " & _
                       "            MSCCatProductos ON UsrProdRegistroSacrificiosDecomiso.IdProducto = MSCCatProductos.IdProducto " & _
                       "            INNER JOIN MSCCatDecomisos ON UsrProdRegistroSacrificiosDecomiso.IdDecomiso = MSCCatDecomisos.IdDecomiso " & _
                       "WHERE	    UsrProdRegistroSacrificiosDecomiso.FolioSacrificio='" & Me.txtLoteSacrificio.Text.Trim & "'"

            Dim tbProdDec As New DataTable

            Using ad As New SqlDataAdapter(New SqlCommand(consulta, New SqlConnection(HC.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()

                ad.Fill(tbProdDec)

                ad.SelectCommand.Connection.Close()
            End Using

            Me.DgvDecomisos.AutoGenerateColumns = False
            Me.DgvDecomisos.DataSource = tbProdDec
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al actualizar los datos del sacrificio", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            'variables para el recalculo de kilos a sacrificio
            Dim KilosPromedio As Decimal
            Dim KilosSacrificar As Decimal
            Dim CabezasSinSacrificar As Integer
            Dim BanderaIntroductor As Boolean
            Dim sacrificios As New CC.MscregistroSacrificioCabCollection
            Dim filtro As New OC.PredicateExpression
            Dim numeroSacrificios As Integer
            Dim FechaInicio As Date = Date.Parse(Now.ToString("yyyy-MM-01"))



            filtro.Add(New OC.FieldBetweenPredicate(HC.MscregistroSacrificioCabFields.FechaCaptura, FechaInicio, Now.AddDays(1)))

            numeroSacrificios = sacrificios.GetDbCount(filtro) + 1
            Me.txtLoteSacrificio.Text = Now.Year & Now.Month.ToString.PadLeft(2, "0") & numeroSacrificios.ToString.PadLeft(5, "0")

            If sacrificios.GetDbCount(HC.MscregistroSacrificioCabFields.IdFolioSacrificio = Me.txtLoteSacrificio.Text.Trim) > 0 Then
                Trans.Rollback()
                MsgBox("El lote de sacrificio ya existe, ingrese otro", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'validar que no se encuentren sacrificios abiertos
            BanderaIntroductor = False

            If Not Controlador.Configuracion.Produccion.RecibirCanales Then
                If Controlador.Configuracion.Produccion.TrabajarLotesSacrificiosAbiertos Then
                    Registros.Obtener("", Me.cmbIntroductor.SelectedValue)
                    If Registros.Count > 0 Then
                        For I As Integer = 0 To Registros.Count - 1
                            If Me.Registros(I).Estatus = "A" Then
                                MessageBox.Show("Existe lote de sacrificios en apertura para este introductor, debe cerra el lote de sacrificio para continuar", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return False
                            End If
                        Next
                    End If
                Else
                    Registros.Obtener("A")

                    If Registros.Count > 0 Then
                        MessageBox.Show("Existe lote de sacrificios en apertura, debe cerra el lote de sacrificio para continuar", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                End If
            End If

            If Me.cmbIntroductor.SelectedValue = -1 Then
                If Me.txtLoteRastro.Text.Trim = "" Then
                    Trans.Rollback()
                    MsgBox("Debe teclear el lote e sacrificio del rastro", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                BanderaIntroductor = True
            End If

            ''genera un folio de sacrificio si es que el usuario no proporciono algun folio
            'If Me.txtLoteSacrificio.Text = "" Then
            '    Integralab.ORM.StoredProcedureCallerClasses.ActionProcedures.FolioRegistroSacrificios(Me.RegistroSacrificio.IdLoteSacrificio)
            '    Me.txtLoteSacrificio.Text = Me.RegistroSacrificio.IdLoteSacrificio
            '    BanderaIntroductor = True
            'End If

            'guarda el cabecero del lote de sacrificio y apertura el mismo            
            If CabezasASacrificar <> CInt(Me.txtCantCabezas.Text) Then
                CabezasSinSacrificar = Me.CabezasASacrificar - CInt(Me.txtCantCabezas.Text)
                KilosPromedio = Me.txtKilosEnPie.Text / Me.CabezasASacrificar
                KilosSacrificar = Me.txtKilosEnPie.Text - (KilosPromedio * CabezasSinSacrificar)
            End If

            RegistroSacrificio.IdLoteSacrificio = Me.txtLoteSacrificio.Text
            RegistroSacrificio.CantCabezasEnmantadas = Me.txtCantCabezasEnmantadas.Text
            RegistroSacrificio.CantCabezasSacrificio = Me.txtCantCabezas.Text

            If BanderaIntroductor = True Then
                RegistroSacrificio.Introductor = Me.cmbIntroductor.SelectedValue
            Else
                RegistroSacrificio.Introductor = 0
            End If




            RegistroSacrificio.CantCanales = Me.txtCantCanales.Text
            RegistroSacrificio.Rendimiento = Me.txtRendimiento.Text
            RegistroSacrificio.KilosCanal = Me.txtCantCanales.Text
            RegistroSacrificio.KilosEnPie = Me.txtKilosEnPie.Text
            RegistroSacrificio.Estatus = "A"
            RegistroSacrificio.LoteRastro = Me.txtLoteRastro.Text
            RegistroSacrificio.FechaSacrificio = Me.dtpFechaSacrificio.Value
            RegistroSacrificio.Func = "I"
            RegistroSacrificio.NumOpc = 1





            'RegistroSacrificioIDE = RegistroSacrificio.Clonar()

            If Not RegistroSacrificio.Guardar(Trans) Then
                Trans.Rollback()
                Return False
            End If

            'actualiza recepciones de ganado con folios de lote de sacrifcio
            For i As Integer = 0 To Me.dgvRecepcionesGanado.Rows.Count - 1
                If CBool(Me.dgvRecepcionesGanado.Rows(i).Cells("Checar").Value) Then
                    Dim RecDet As New RecepcionGanadoDetalleClass
                    RecDet.LoteRecepcion = Me.dgvRecepcionesGanado.Rows(i).Cells("LoteRecepcion").Value
                    RecDet.LoteSacrificio = Me.txtLoteSacrificio.Text
                    RecDet.KilosEnPie = Me.txtKilosEnPie.Text
                    RecDet.CantidadCabezas = Me.dgvRecepcionesGanado.Rows(i).Cells("ClmCabezasSacrificio").Value
                    RecDet.Estatus = 1
                    If Not RecDet.Guardar(Trans) Then
                        Trans.Rollback()
                        Return False
                    End If
                End If
            Next

            Trans.Commit()






            '''''--------GUARDAR IDE FOODS------'''''
            '------------V---V---------V-------------
            '''''--------V---V---------V-------------

            If CInt(Me.cmbIntroductor.SelectedValue) = 2 Then
                Trans.Dispose()

                HC.DbUtils.ActualConnectionString = HC.DbUtils.ActualConnectionString.Replace("MEATLA20", "MEATIDE")

                Dim RegistroSacrificioIDE As New ClasesNegocio.RegistroSacrificiosClass
                RegistroSacrificioIDE.IdLoteSacrificio = Me.txtLoteSacrificio.Text
                RegistroSacrificioIDE.CantCabezasEnmantadas = Me.txtCantCabezasEnmantadas.Text
                RegistroSacrificioIDE.CantCabezasSacrificio = Me.txtCantCabezas.Text
                If BanderaIntroductor = True Then
                    RegistroSacrificioIDE.Introductor = Me.cmbIntroductor.SelectedValue
                Else
                    RegistroSacrificioIDE.Introductor = 0
                End If
                RegistroSacrificioIDE.CantCanales = Me.txtCantCanales.Text
                RegistroSacrificioIDE.Rendimiento = Me.txtRendimiento.Text
                RegistroSacrificioIDE.KilosCanal = Me.txtCantCanales.Text
                RegistroSacrificioIDE.KilosEnPie = Me.txtKilosEnPie.Text
                RegistroSacrificioIDE.Estatus = "A"
                RegistroSacrificioIDE.LoteRastro = Me.txtLoteRastro.Text
                RegistroSacrificioIDE.FechaSacrificio = Me.dtpFechaSacrificio.Value
                RegistroSacrificioIDE.Func = "I"
                RegistroSacrificioIDE.NumOpc = 1

                'Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")
                If Not RegistroSacrificioIDE.Guardar() Then
                    Trans.Rollback()
                    Return False
                End If

                'IDEFOODS----->actualiza recepciones de ganado con folios de lote de sacrifcio<-----IDEFOODS
                For i As Integer = 0 To Me.dgvRecepcionesGanado.Rows.Count - 1
                    If CBool(Me.dgvRecepcionesGanado.Rows(i).Cells("Checar").Value) Then
                        Dim RecDet As New RecepcionGanadoDetalleClass
                        RecDet.LoteRecepcion = Me.dgvRecepcionesGanado.Rows(i).Cells("LoteRecepcion").Value
                        RecDet.LoteSacrificio = Me.txtLoteSacrificio.Text
                        RecDet.KilosEnPie = Me.txtKilosEnPie.Text
                        RecDet.CantidadCabezas = Me.dgvRecepcionesGanado.Rows(i).Cells("ClmCabezasSacrificio").Value
                        RecDet.Estatus = 1
                        If Not RecDet.Guardar() Then
                            'Trans.Rollback()
                            Return False
                        End If
                    End If
                Next
            End If
            
            'Trans.Commit()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function Limpiar() As Boolean
        Me.txtLoteRastro.Clear()
        Me.txtCantCabezas.Text = "0"
        Me.txtCantCanales.Text = "0"
        Me.txtRendimiento.Text = "0"
        Me.txtKilosCalientes.Text = "0"
        Me.txtKilosEnPie.Text = "0"
        'Me.txtCantCabezasCalsificadas.Text = "0"
        Me.txtCantCabezasEnmantadas.Text = "0"
        'Me.txtImpteClasificacion.Text = "0"
        'Me.txtImpteEnmantado.Text = "0"
        'Me.txtImpteSacrificio.Text = "0"
        Me.txtLoteSacrificio.Text = ""
        Me.txtIntroductor.Text = ""
        Me.txtRendimiento.Text = "0"
        Me.cmbIntroductor.SelectedIndex = -1
        Me.sacrificioSeleccionado = False
        Me.Tiempo.Stop()
    End Function

    Private Sub Habilitar()
        If Controlador.Configuracion.Produccion.RecibirCanales Then
            Me.dtpFechaSacrificio.Enabled = True
            Me.txtLoteSacrificio.Enabled = True
            Me.txtLoteRastro.Enabled = True
            Me.txtIntroductor.Text = Controlador.Sesion.MiEmpresa.Empnom
            Me.txtCantCabezas.Enabled = True
            Me.txtKilosEnPie.Enabled = True
            Me.txtCantCanales.Enabled = False
            Me.txtCantCabezasEnmantadas.Enabled = False
            Me.txtRendimiento.Enabled = False
            Me.txtKilosCalientes.Enabled = False
        Else
            Me.cmbIntroductor.Enabled = True
            Me.dtpFechaSacrificio.Enabled = True
            Me.txtCantCabezas.Enabled = True
            Me.txtKilosEnPie.Enabled = True
            Me.txtCantCanales.Enabled = False
            Me.txtCantCabezasEnmantadas.Enabled = False
            Me.txtRendimiento.Enabled = False
            Me.txtKilosCalientes.Enabled = False
        End If

    End Sub

    Private Sub Deshabilitar()
        Me.cmbIntroductor.Enabled = False
        Me.cmbIntroductor.Enabled = False
        Me.dtpFechaSacrificio.Enabled = False
        Me.cmbIntroductor.Enabled = False
        Me.txtCantCabezas.Enabled = False
        Me.txtKilosEnPie.Enabled = False
        Me.txtCantCanales.Enabled = False
        Me.txtCantCabezasEnmantadas.Enabled = False
        Me.txtRendimiento.Enabled = False
        Me.txtKilosCalientes.Enabled = False
        Me.txtLoteRastro.Enabled = False
    End Sub

    Private Sub ObtenerValores()
        Me.txtLoteSacrificio.Text = RegistroSacrificio.IdLoteSacrificio
        Me.txtCantCabezas.Text = RegistroSacrificio.CantCabezasSacrificio
        Me.txtCantCanales.Text = RegistroSacrificio.CantCanales
        Me.txtCantCabezasEnmantadas.Text = RegistroSacrificio.CantCabezasEnmantadas
        Me.txtKilosEnPie.Text = RegistroSacrificio.KilosEnPie.ToString("N2")
        Me.txtRendimiento.Text = RegistroSacrificio.Rendimiento
        Me.dtpFechaSacrificio.Value = RegistroSacrificio.FechaSacrificio
        Me.txtIntroductor.Text = RegistroSacrificio.NombreIntroductor
        Me.txtLoteRastro.Text = RegistroSacrificio.LoteRastro
    End Sub

    Private Sub ObtenerRendimiento()
        Dim KilosCal As Decimal = 0
        Dim Kilos As Decimal = 0
        Dim RecCanales As New CC.MscrecepcionCanalesCabCollection
        Dim RegSacrificioProd As New CC.RegistroSacrificiosDecomisosCollection

        If RecCanales.GetMulti(HC.MscrecepcionCanalesCabFields.FolioSacrificio = Me.RegistroSacrificio.IdLoteSacrificio) Then
            If RecCanales.Count = 1 Then
                KilosCal = RecCanales(0).KgrsCalientes
            End If
        End If
        If RegSacrificioProd.GetMulti(HC.RegistroSacrificiosDecomisosFields.LoteSacrificio = Me.RegistroSacrificio.IdLoteSacrificio) Then
            For i As Integer = 0 To RegSacrificioProd.Count - 1
                Kilos += RegSacrificioProd(i).Kilos
            Next
        End If
        Me.txtRendimiento.Text = ((Kilos + KilosCal) / Me.RegistroSacrificio.KilosEnPie) * 100
    End Sub

    Private Function Buscar() As Boolean
        Try
            Dim Consultas As New ReporteRegistroSacrificios
            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.RegistroSacrificio = Consultas.Sacrificio
                ObtenerValores()
                ObtenerRendimiento()
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CancelarSacrificio() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Transaccion")

        Try
            Dim Canales As New CC.MscrecepcionCanalesCabCollection

            Canales.GetMulti(HC.MscrecepcionCanalesCabFields.FolioSacrificio = Me.RegistroSacrificio.IdLoteSacrificio)

            If Canales.Count = 0 Then
                RegistroSacrificio.Estatus = "X"
                RegistroSacrificio.Func = "M"
                RegistroSacrificio.NumOpc = 1

                If Not RegistroSacrificio.Guardar(Trans) Then
                    Trans.Rollback()
                    Return False
                End If

                Trans.Commit()
                MessageBox.Show("Se canceló registro de sacrifcio : " & Me.txtLoteSacrificio.Text, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                MsgBox("El sacrificio tiene canales recibidos, no se puede cancelar", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            Trans.Rollback()
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Imprimir()
        Dim ventana As New ReporteRegistroSacrificio
        ventana.ShowDialog()
    End Sub
#End Region

#Region "MEAToolBar"
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        If Not CancelarSacrificio() Then
            MsgBox("No se pudo cancelar registro de sacrificios", MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Else
            Me.Limpiar()
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim Consultas As New ReporteRegistroSacrificios

            Me.Tiempo.Stop()

            If Consultas.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.RegistroSacrificio = Consultas.Sacrificio
                ObtenerValores()
                ObtenerRendimiento()
                Me.ActualizarDatos()
                Me.Tiempo.Interval = Controlador.Configuracion.Produccion.TiempoEspera * 1000
                Me.Tiempo.Start()
                Me.sacrificioSeleccionado = True
                Me.TabControl1.SelectedIndex = 1

                If Me.RegistroSacrificio.Estatus = "A" Then
                    Me.lblEstatus.Text = "VIGENTE"
                ElseIf Me.RegistroSacrificio.Estatus = "C" Then
                    Me.lblEstatus.Text = "CERRADO"
                Else
                    Me.lblEstatus.Text = "CANCELADO"
                End If
            Else
                If Me.sacrificioSeleccionado Then
                    Me.Tiempo.Start()
                End If

                Cancelar = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Me.Tiempo.Stop()
        Deshabilitar()
        Limpiar()
        Me.sacrificioSeleccionado = False
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Habilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        If Not Guardar() Then
            'MessageBox.Show("No se pudo guardar el Registro de Sacrificios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cancelar = True
        Else
            MessageBox.Show("Se guardó el Registro de Sacrificios con el folio : " & Me.txtLoteSacrificio.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Deshabilitar()
            Limpiar()
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Me.Tiempo.Stop()
        Me.Limpiar()
        Habilitar()
        RegistroSacrificio = New RegistroSacrificiosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Tiempo.Stop()
        Me.Close()
    End Sub
#End Region

    Private Sub RecepcionGanado_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RecepcionGanado.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            For i As Integer = 0 To Me.dgvRecepcionesGanado.Rows.Count - 1
                If CBool(Me.dgvRecepcionesGanado.Rows(i).Cells("Checar").Value) Then
                    If IsNumeric(Me.dgvRecepcionesGanado.Rows(i).Cells("ClmCabezasSacrificio").Value) Then
                        Me.txtCantCabezas.Text = Me.txtCantCabezas.Text + CInt(Me.dgvRecepcionesGanado.Rows(i).Cells("ClmCabezasSacrificio").Value)
                        Me.txtKilosEnPie.Text = Me.txtKilosEnPie.Text + (CDbl(Me.dgvRecepcionesGanado.Rows(i).Cells(Me.ClmCabezasSacrificio.Index).Value) * CDbl(Me.dgvRecepcionesGanado.Rows(i).Cells(Me.KiloPromedio.Index).Value))
                        'Me.txtKilosEnPie.Text = Me.txtKilosEnPie.Text + CDec(Me.dgvRecepcionesGanado.Rows(i).Cells("KilosRecibidos").Value)
                    End If
                End If
            Next
            CantidadCabezas = Me.txtCantCabezas.Text
            'ClasesNegocio.TipoGanadoClass tipogan = New ClasesNegocio.TipoGanadoClass(
            Me.txtCantCanales.Text = (CantidadCabezas).ToString("N2")
            If Me.txtCantCabezas.Text = 0 Then
                MessageBox.Show("Seleccione al menos una recepción de ganado para realizar lote de sacrifcio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.CabezasASacrificar = Me.txtCantCabezas.Text
                Me.txtIntroductor.Text = Me.cmbIntroductor.Text
                Me.txtCantCanales.Text = Me.txtCantCabezas.Text
                Me.TabControl1.SelectedIndex = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbIntroductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbIntroductor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TmIntroductor.Stop()
            Me.ultimaTecla = Now
            Me.TmIntroductor.Start()
        End If
    End Sub

    Private Sub cmbIntroductor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbIntroductor.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Introductores.Obtener(True)
        End If
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIntroductor.SelectedIndexChanged
        Try
            If Me.cmbIntroductor.SelectedIndex > -1 Then
                Me.dgvRecepcionesGanado.AutoGenerateColumns = False
                If Not IsNothing(Me.cmbIntroductor.SelectedValue) Then
                    recepciones = New TC.VwRegistroSacrificioTypedView
                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HC.VwRegistroSacrificioFields.Estatus = "V")
                    filtro.Add(HC.VwRegistroSacrificioFields.IdCliente = Me.cmbIntroductor.SelectedValue)
                    recepciones.Fill(0, Nothing, True, filtro)
                    Me.dgvRecepcionesGanado.DataSource = recepciones
                End If
            Else
                Me.dgvRecepcionesGanado.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegistroSacrificio_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles RegistroSacrificio.MensajeError
        MessageBox.Show(mensaje)
    End Sub

    Private Sub txtCantCabezasEnmantadas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantCabezasEnmantadas.TextChanged
        If Me.txtCantCabezas.Text <> "0" And Me.txtCantCabezas.Text <> "" Then
            Me.txtCantCabezas.Text = CantidadCabezas - CDec(Me.txtCantCabezasEnmantadas.Text)
            CantidadCabezas = Me.txtCantCabezas.Text
            Me.txtCantCanales.Text = (CantidadCabezas).ToString("N2")
        End If
    End Sub

    Private Sub Tiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tiempo.Tick
        If Me.sacrificioSeleccionado Then
            Me.Tiempo.Stop()

            Me.Tiempo.Interval = Controlador.Configuracion.Produccion.TiempoEspera * 1000

            Me.ActualizarDatos()
            Me.dgCanales.MultiSelect = False

            If Me.dgCanales.Rows.Count > 0 Then
                Me.dgCanales.Rows(Me.dgCanales.Rows.Count - 1).Cells(0).Selected = True
            End If

            Me.Tiempo.Start()
        End If

        ''dim RecCanales as New 
        'Dim Dec As New DecomisosColeccionClass
        'Dec.Obtener(Me.RegistroSacrificio.IdLoteSacrificio)
        'Me.DgvDecomisos.AutoGenerateColumns = False
        'Me.DgvDecomisos.DataSource = Dec
    End Sub

    Private Sub TmIntroductor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmIntroductor.Tick
        If Not Me.cmbIntroductor.Text = "" Then
            Introductores.Obtener(Me.cmbIntroductor.Text)
            Me.cmbIntroductor.DataSource = Introductores
            Me.cmbIntroductor.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtCantCabezas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantCabezas.KeyPress        
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtCantCabezas.Text) Then
                CabezasASacrificar = Me.txtCantCabezas.Text
                Me.txtCantCanales.Text = Me.txtCantCabezas.Text
                Me.txtKilosEnPie.Focus()
            Else
                Me.txtCantCabezas.Text = "0"
            End If

            CabezasASacrificar = Me.txtCantCabezas.Text
            Me.txtCantCanales.Text = Me.txtCantCabezas.Text
            If CabezasASacrificar = 0 Then
                MsgBox("Debe ingresar mas de 0 cabezas", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.txtKilosEnPie.Focus()
            End If
        End If
    End Sub

    Private Sub txtLoteSacrificio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoteSacrificio.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtCantCabezas.Focus()
        End If
    End Sub

    Private Sub dgvRecepcionesGanado_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepcionesGanado.CellContentClick
        If e.ColumnIndex = Me.Checar.Index Then
            If CBool(Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.Checar.Index).Value) = True Then
                Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.ClmCabezasSacrificio.Index).Value = Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.CantCabezas.Index).Value - Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.clmCabezasSacrificadas.Index).Value
            Else
                Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.ClmCabezasSacrificio.Index).Value = 0
            End If
        End If
    End Sub

    Private Sub dgvRecepcionesGanado_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRecepcionesGanado.CellEndEdit
        Try
            If e.ColumnIndex = Me.ClmCabezasSacrificio.Index Then
                If Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.CantCabezas.Index).Value < Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.ClmCabezasSacrificio.Index).Value Then
                    MessageBox.Show("La cantidad de cabezas a sacrificio debe ser menor o igual a la cantidad de cabezas por sacrificar " & Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.CantCabezas.Index).Value, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.ClmCabezasSacrificio.Index).Value = Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.CantCabezas.Index).Value
                    Exit Sub
                Else
                    If Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.ClmCabezasSacrificio.Index).Value > 0 Then
                        Me.dgvRecepcionesGanado.Rows(e.RowIndex).Cells(Me.Checar.Index).Value = True
                    Else
                        Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.Checar.Index).Value = False
                    End If
                End If
            End If

            If e.ColumnIndex = Me.Checar.Index Then
                If Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.Checar.Index).Value = True Then
                    Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.ClmCabezasSacrificio.Index).Value = Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.CantCabezas.Index).Value
                Else
                    Me.dgvRecepcionesGanado.CurrentRow.Cells(Me.ClmCabezasSacrificio.Index).Value = ""
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRecepcionesGanado_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRecepcionesGanado.EditingControlShowing
        If Me.dgvRecepcionesGanado.CurrentCell.ColumnIndex = Me.ClmCabezasSacrificio.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf Numeros
            AddHandler e.Control.KeyPress, AddressOf Numeros
        Else
            RemoveHandler e.Control.KeyPress, AddressOf Numeros
        End If
    End Sub

    Private Sub Numeros(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(8) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub FrmRegistroSacrificios_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Not cargobien Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCantCabezas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantCabezas.TextChanged
        Try
            If IsNumeric(Me.txtCantCabezas.Text) Then
                CabezasASacrificar = Me.txtCantCabezas.Text
                Me.txtCantCanales.Text = Me.txtCantCabezas.Text
            Else
                Me.txtCantCabezas.Text = "0"
            End If

            CabezasASacrificar = Me.txtCantCabezas.Text
            Me.txtCantCanales.Text = Me.txtCantCabezas.Text
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    
End Class