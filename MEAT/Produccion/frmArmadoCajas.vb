Imports System.Data.SqlClient

Public Class frmArmadoCajas

#Region "Miembros"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.txtFolio.Clear()
        Me.dtFecha.Value = Now
        Me.dgDetalle.DataSource = Nothing
    End Sub

    Private Sub Habilitar()
        Me.dtFecha.Enabled = True
        Me.dgDetalle.Enabled = True
    End Sub

    Private Sub Deshabilitar()
        Me.txtFolio.Enabled = False
        Me.dtFecha.Enabled = False
        Me.dgDetalle.Enabled = False
    End Sub

    Private Sub LlenarGrid()
        Dim sqlCon As New SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim consulta As String = "SELECT MSCDevolucionProductos.Folio, MSCDevolucionProductos.IdProducto, " & _
                                            "MSCDevolucionProductos.Piezas, MSCDevolucionProductos.Kilos, MSCDevolucionProductos.Embarque, " & _
                                            "MSCDevolucionProductos.IdCliente, MSCDevolucionProductos.UtilparaVenta, MSCCatProductos.Descripcion " & _
                                     "FROM  MSCDevolucionProductos INNER JOIN MSCCatProductos ON MSCDevolucionProductos.IdProducto = " & _
                                            "MSCCatProductos.IdProducto WHERE (MSCDevolucionProductos.EnCaja = 0) AND " & _
                                            "(MSCDevolucionProductos.UtilparaVenta = 1)"

            Dim sqlCom As New SqlCommand(consulta, sqlCon)
            Dim dr As SqlDataReader
            Dim cont As Integer = 0

            sqlCom.Connection.Open()
            dr = sqlCom.ExecuteReader

            While dr.Read
                Me.dgDetalle.Rows.Add(1)

                With Me.dgDetalle.Rows(cont)
                    .Cells(Me.clmFolio.Index).Value = dr("Folio")
                    .Cells(Me.clmIdProducto.Index).Value = dr("IdProducto")
                    .Cells(Me.clmDescripcion.Index).Value = dr("Descripcion")
                    .Cells(Me.clmKilos.Index).Value = dr("Kilos")
                    .Cells(Me.clmPiezas.Index).Value = dr("Piezas")
                End With

                cont += 1
            End While
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los productos devueltos", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmArmadoCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""


        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar

    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar

    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar

    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar

    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Cursor = Cursors.WaitCursor
        Limpiar()
        Habilitar()
        Me.LlenarGrid()
        Cursor = Cursors.Default
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
#End Region
End Class