Imports EC = integralab.ORM.EntityClasses
Imports CC = integralab.ORM.CollectionClasses
Imports HC = integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports System.IO
Imports System.Drawing

Public Class EmpresasForm

    Private _empresa As ECS.EmpresasEntity
    Private icono As System.Drawing.Icon

    Private Sub sbLectura()
        EmpresasDataGridView.Enabled = True
        tabla.Enabled = False
    End Sub

    Private Sub sbEscritura()
        EmpresasDataGridView.Enabled = False
        tabla.Enabled = True
    End Sub

    Private Sub sbLimpiar()
        CodigoTextBox.Clear()
        NombreTextBox.Clear()
        ServidorTextBox.Clear()
        CatalogoTextBox.Clear()
        chkSI.Checked = False
        UserNameTextBox.Clear()
        PassWordTextBox.Clear()
        pic.BackColor = Color.FromName("Control")
        pcbIcono.Image = Nothing
    End Sub

    Private Sub sbInicializarToolBar()
        Dim mtbStructure As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        mtbStructure.StateBuscar = "010101101"
        mtbStructure.StateLimpiar = "000100001"
        mtbStructure.StateCancelar = "000100001"
        mtbStructure.StateNuevo = "011010000"
        mtbStructure.StateGuardar = "000100001"
        mtbStructure.StateBorrar = "000100001"
        mtbStructure.StateEditar = "011010000"
        mtbStructure.StateSalir = "000000000"
        mtb.ToolBarButtonStatus = mtbStructure
        mtb.sbCambiarEstadoBotones("Cancelar")
    End Sub

    Private Sub EmpresasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sbInicializarToolBar()
        sbLectura()
        Empresas.GetMulti(Nothing)
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try

            If _empresa.Delete() Then
                MsgBox("Empresa eliminada.")
            Else
                MsgBox("No se ha podido eliminar la empresa.")
            End If
            Empresas.GetMulti(Nothing)
        Catch ex As Exception
            Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Empresas")
            Try
                If InStr(ex.Message, "FK_detalleempresas_empresas") > 0 Then
                    If MsgBox("La empresa tiene usuarios asociados, si elimina la empresa esos usuarios ya no tendran acceso a la misma." & vbCrLf & "¿ Desea eliminar la empresa ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim DetalleEmpresas As New CCS.DetalleempresasCollection
                        Dim filtro As New OC.PredicateExpression
                        filtro.Add(HCS.DetalleempresasFields.Empndx = _empresa.Empid)
                        trans.Add(DetalleEmpresas)
                        DetalleEmpresas.DeleteMulti(filtro)
                        trans.Add(_empresa)
                        If _empresa.Delete() Then
                            MsgBox("Empresa eliminada.")
                        Else
                            MsgBox("No se ha podido eliminar la empresa.")
                        End If
                        trans.Add(Empresas)
                        Empresas.GetMulti(Nothing)
                        trans.Commit()
                    End If
                ElseIf InStr(ex.Message, "FK_sesiones_empresas") > 0 Then
                    Dim Sesiones As New CCS.SesionesCollection
                    Dim filtro As New OC.PredicateExpression
                    filtro.Add(HCS.SesionesFields.Empndx = _empresa.Empid)
                    trans.Add(Sesiones)
                    Sesiones.DeleteMulti(filtro)
                    trans.Add(_empresa)
                    If _empresa.Delete() Then
                        MsgBox("Empresa eliminada.")
                    Else
                        MsgBox("No se ha podido eliminar la empresa.")
                    End If
                    trans.Add(Empresas)
                    Empresas.GetMulti(Nothing)
                    trans.Commit()
                Else
                    MsgBox(ex.Message)
                End If
            Catch ex2 As Exception
                trans.Rollback()
                MsgBox(ex2.Message)
            Finally
                trans.Dispose()
            End Try
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        sbLimpiar()
        sbLectura()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        sbEscritura()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            _empresa.Empid = CodigoTextBox.Text
            _empresa.Empnom = NombreTextBox.Text
            _empresa.Empsrv = ServidorTextBox.Text
            _empresa.Empcat = CatalogoTextBox.Text
            _empresa.Empsi = chkSI.Checked
            _empresa.Empuser = ""
            _empresa.Emppass = ""
            _empresa.A = pic.BackColor.A
            _empresa.R = pic.BackColor.R
            _empresa.G = pic.BackColor.G
            _empresa.B = pic.BackColor.B

            If Not _empresa.Empsi Then
                _empresa.Empuser = UserNameTextBox.Text
                _empresa.Emppass = PassWordTextBox.Text
            End If

            If _empresa.Save Then
                If _empresa.Empid = Controlador.Sesion.MiEmpresa.Empid AndAlso _empresa.EmpIcono.Length > 0 Then
                    Controlador.Sesion.MiEmpresa = _empresa
                    Me.MdiParent.Icon = New System.Drawing.Icon(New System.IO.MemoryStream(Controlador.Sesion.MiEmpresa.EmpIcono))
                ElseIf _empresa.Empid = Controlador.Sesion.MiEmpresa.Empid Then
                    Me.MdiParent.Icon = My.Resources.JSLogo32
                End If
                MsgBox("Empresa guardada.")
            End If

            Empresas.GetMulti(Nothing)
            sbLectura()
            sbLimpiar()
        Catch ex As Exception
            Cancelar = True
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        sbLimpiar()
        Cancelar = NombreTextBox.Enabled
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        _empresa = New ECS.EmpresasEntity
        sbLimpiar()
        sbEscritura()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub EmpresasDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles EmpresasDataGridView.DataError

    End Sub

    Private Sub EmpresasDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmpresasDataGridView.DoubleClick
        Try
            _empresa = New ECS.EmpresasEntity
            _empresa = EmpresasDataGridView.SelectedCells(0).OwningRow.DataBoundItem
            CodigoTextBox.Text = _empresa.Empid
            NombreTextBox.Text = _empresa.Empnom
            ServidorTextBox.Text = _empresa.Empsrv
            CatalogoTextBox.Text = _empresa.Empcat
            chkSI.Checked = _empresa.Empsi
            UserNameTextBox.Text = _empresa.Empuser
            PassWordTextBox.Text = _empresa.Emppass
            pic.BackColor = Color.FromArgb(_empresa.A, _empresa.R, _empresa.G, _empresa.B)

            If _empresa.EmpIcono.Length > 0 Then
                Dim Stream As New System.IO.MemoryStream(_empresa.EmpIcono)
                Dim Icono As New System.Drawing.Icon(Stream)
                pcbIcono.Image = Icono.ToBitmap
            Else
                pcbIcono.Image = Nothing
            End If

            mtb.sbCambiarEstadoBotones("Buscar")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSI.CheckedChanged
        UserNameTextBox.Enabled = Not chkSI.Checked
        PassWordTextBox.Enabled = Not chkSI.Checked
    End Sub

    Private Sub brnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnCambiar.Click
        ColorDg.ShowDialog()
        pic.BackColor = ColorDg.Color
    End Sub

    Private Sub btnCambiarIcono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarIcono.Click
        Try
            If AbrirArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileLen(AbrirArchivo.FileName) < 8192 Then
                    Dim ms As System.IO.FileStream = AbrirArchivo.OpenFile()
                    Dim IconoBytes(ms.Length - 1) As Byte
                    ms.Read(IconoBytes, 0, ms.Length)
                    _empresa.EmpIcono = IconoBytes
                    pcbIcono.Image = (New Icon(New MemoryStream(IconoBytes))).ToBitmap
                    Exit Sub
                Else
                    MessageBox.Show("El icono no debe ser mayor a 8 Kilobytes", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch
            MessageBox.Show("El archivo no es compatible, por favor seleccione un icono", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub pcbIcono_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pcbIcono.MouseDoubleClick
        If MessageBox.Show("¿Desea quitar el icono?", "Catalogo de Empresas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            _empresa.EmpIcono = Nothing
            pcbIcono.Image = Nothing
        End If
    End Sub
End Class