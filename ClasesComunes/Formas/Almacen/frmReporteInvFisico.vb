Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports ClasesNegocio
Imports SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmReporteInvFisico
    Dim productos As New CN.ProductoCollectionClass
    Dim numchecked As Integer = 0
    Dim lineas As String = ""
    Dim paramMov As String = "0"
    Dim filLin As Boolean = False
    Dim autochecked As Boolean = False
    Dim bucket As New RelationCollection

    Private Sub frmReporteInvFisico_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        



        Dim x As Integer = 10, y As Integer = 10, i As Integer = 1
        Dim lineas As New ClasesNegocio.LineaCollectionClass
        lineas.Obtener(CondicionEnum.ACTIVOS)
        
        For Each row As CN.LineaClass In lineas
            Dim check As New CheckBox
            Me.Panel1.Controls.Add(check)
            check.Location = New Drawing.Point(x, y)
            check.AutoSize = True
            check.Text = row.DescripcionCorta
            check.Name = "chk" & row.DescripcionCorta
            check.Tag = row.Codigo.ToString
            AddHandler check.CheckedChanged, AddressOf checkboxCheckedChanged
            x += 170
            If i Mod 3 = 0 Then
                y += 23
                x = 10
            End If
            i += 1
        Next

            'For i As Integer = 1 To 26
            '    Dim check As New CheckBox
            '    Me.Panel1.Controls.Add(check)
            '    check.Location = New Drawing.Point(x, y)
            '    check.AutoSize = True
            '    check.Text = "Check" & i.ToString
            '    check.Name = "Checkbox" & i.ToString
            '    x += 100
            '    If i Mod 2 = 0 Then
            '        y += 30
            '        x = 10
            '    End If
            'Next

            Dim prods As New CC.ProductoCollection

            bucket.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)
            ' bucket.Relations.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea, JoinHint.Inner)



            prods.GetMulti(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
            Dim dt As New DataTable()
            dt.Columns.Add("Codigo")
            dt.Columns.Add("Descripcion")
            dt.Rows.Add("null", "< TODOS LOS PRODUCTOS >")
            For Each row As EC.ProductoEntity In prods
                dt.Rows.Add(row.Codigo, row.Descripcion)
            Next
            cmbProducto.ValueMember = "Codigo"
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.DataSource = dt
            rbSinMov.Checked = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Me.Cursor = Cursors.WaitCursor
        validar()
        Dim resultado As New DataSet()
        Dim consulta As String
        If lineas = "null" Then
            consulta = "execute dbo.Usp_ReporteInvFisico " & cmbProducto.SelectedValue & "," & lineas & "," & paramMov
        Else
            consulta = "execute dbo.Usp_ReporteInvFisico " & cmbProducto.SelectedValue & "," & "'" & lineas & "'" & "," & paramMov
        End If
        Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                    New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
            ad.SelectCommand.Connection.Open()
            ad.Fill(resultado)
            ad.SelectCommand.Connection.Close()
        End Using
        Try
            If resultado.Tables(0).Rows.Count <> 0 Then
                Dim rep As New crRepInvFisico
                rep.SetDataSource(resultado.Tables(0))
                rep.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                rep.SetParameterValue("Fecha", Now())
                rep.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnom)
                rep.SetParameterValue("Formulario", "Invenario/Reportes/Reporte de Inventario Fisico")
                Dim Prev As New ClasesNegocio.PreVisualizarForm
                Prev.Reporte = rep
                Prev.Text = "Reporte de Inventario Fisico"
                Prev.ShowDialog()
            Else
                MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, "AVISO")
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, "AVISO")
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub validar()
        Dim mensaje As String = "Los id de los checkbox seleecionados son: " & vbLf
        Dim i As Integer = 1
        lineas = ""
        For Each ctrl As Control In Panel1.Controls
            Dim check As CheckBox = CType(ctrl, CheckBox)
            If i = 1 Then
                If check.Checked Then
                    lineas = check.Tag.ToString
                    i += 1
                End If
            Else
                If check.Checked Then
                    lineas = lineas & "-" & check.Tag.ToString
                End If
            End If


            'If check.Checked Then
            '    'numchecked += 1
            '    'mensaje &= check.Tag.ToString & vbLf

            'End If
            'If ctrl.GetType() Is GetType(CheckBox) Then

            'End If

        Next

        If lineas = "" Then
            lineas = "null"
        End If

        'MsgBox(mensaje)
    End Sub

    Public Sub limpiar()
        For Each ctrl As Control In Panel1.Controls
            Dim check As CheckBox = CType(ctrl, CheckBox)
            check.Checked = False
            check.Enabled = True
        Next
        filLin = False
        autochecked = False
        cmbProducto.SelectedValue = "null"
        paramMov = "0"
        rbSinMov.Checked = True
    End Sub

    Private Sub rbConMov_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbConMov.CheckedChanged
        If rbConMov.Checked Then
            paramMov = "1"
        Else
            paramMov = "0"
        End If
    End Sub

    Private Sub rbSinMov_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbSinMov.CheckedChanged
        If rbSinMov.Checked Then
            paramMov = "0"
        Else
            paramMov = "1"
        End If
    End Sub

    ''evento cuando cambia algun check
    Private Sub checkboxCheckedChanged(sender As Object, e As EventArgs)
        'Dim myCheckbox As CheckBox = DirectCast(sender, CheckBox)
        'Dim c As Boolean = myCheckbox.Checked
        'Dim n As String = myCheckbox.Name
        ' etc.        
        If autochecked = False Then
            cmbProducto.DataSource = Nothing
            Dim Filtro As New PredicateExpression
            For Each ctrl As Control In Panel1.Controls
                Dim check As CheckBox = CType(ctrl, CheckBox)

                If check.Checked Then
                    Filtro.AddWithOr(HC.ProductoFields.PdIdLinea = CInt(check.Tag.ToString) And HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False)
                    'Filtro.Add()
                    filLin = True
                End If
            Next
            If Filtro.Count = 0 Then
                filLin = False
                Filtro.Add(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False And HC.LineaFields.Estatus = 1)
            End If

            'Filtro.Add(HC.ProductoFields.Estatus = 1 And HC.ProductoFields.PdEsKit = False)
            Dim prods As New CC.ProductoCollection
            prods.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), bucket)
            Dim dt As New DataTable()
            dt.Columns.Add("Codigo")
            dt.Columns.Add("Descripcion")
            dt.Rows.Add("null", "< TODOS LOS PRODUCTOS >")
            For Each row As EC.ProductoEntity In prods
                dt.Rows.Add(row.Codigo, row.Descripcion)
            Next
            cmbProducto.ValueMember = "Codigo"
            cmbProducto.DisplayMember = "Descripcion"
            cmbProducto.DataSource = dt
        End If
        
    End Sub




    Private Sub cmbProducto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProducto.SelectedIndexChanged
        If filLin = False And cmbProducto.SelectedValue <> "null" And cmbProducto.SelectedValue IsNot Nothing Then

            Dim prod As New CN.ProductoClass(CInt(cmbProducto.SelectedValue))
            For Each ctrl As Control In Panel1.Controls
                Dim check As CheckBox = CType(ctrl, CheckBox)
                If CInt(check.Tag.ToString) = prod.IdLinea Then
                    autochecked = True
                    check.Checked = True
                    check.Enabled = True
                Else
                    check.Enabled = False
                    check.Checked = False
                End If
            Next
        Else
            'If cmbProducto.SelectedValue = "null" Then
            '    For Each ctrl As Control In Panel1.Controls
            '        Dim check As CheckBox = CType(ctrl, CheckBox)
            '        check.Checked = False
            '        check.Enabled = True
            '    Next
            '    autochecked = False
            'End If
            If autochecked Then
                limpiar()
            End If


        End If
    End Sub

End Class