Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses

Public Class GeneraArchivoFacturasForm

    Private Sub GeneraArchivoFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.dtpFechaVencimiento.Value = Now
            Me.dtpFechaVencimiento.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerar.Click
        Try
            Dim Facturas As New CN.FacturasAPagarCXPColeccion
            Dim FacturasApagar As New DataTable
            Facturas.Obtener()

            If Facturas.Count > 0 Then
                ''si existe por lo menos una factura qe este Autorizada Eso significa 
                '' que el archivo no puede borrarse o reemplazarse por uno nuevo
                'Facturas.Obtener(ClasesNegocio.EstatusFacturasApagar.AUTORIZADA)
                'If Facturas.Count > 0 Then
                '    MsgBox("No es posible Generar el archivo ya que en el archivo actual aún hay Facturas Autorizadas sin Pagar", MsgBoxStyle.Exclamation, "Aviso")
                'Else
                FacturasApagar = SPR.CxPfacturasApagar(Me.dtpFechaVencimiento.Value, Controlador.Sesion.Empndx)
                GenerarArchivo(FacturasApagar)
                'End If
            Else
                FacturasApagar = SPR.CxPfacturasApagar(Me.dtpFechaVencimiento.Value, Controlador.Sesion.Empndx)
                GenerarArchivo(FacturasApagar)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GenerarArchivo(ByVal Tabla As DataTable)
        Dim Tran As New HC.Transaction(IsolationLevel.ReadCommitted, "Prog")
        Try
            If Tabla.Rows.Count > 0 Then
                Dim FacturasAP As New CC.UsrCxpfacturasApagarCollection
                Tran.Add(FacturasAP)
                'FacturasAP.DeleteMulti(nothing)
                For i As Integer = 0 To Tabla.Rows.Count - 1
                    Dim GeneraArchivo As New EC.UsrCxpfacturasApagarEntity
                    GeneraArchivo.EmpresaId = Tabla.Rows(i)("EmpresaId")
                    GeneraArchivo.IdProveedor = Tabla.Rows(i)("IdProveedor")
                    GeneraArchivo.NoFactura = Tabla.Rows(i)("NoFactura")
                    GeneraArchivo.FechaVencimiento = Tabla.Rows(i)("FechaVencimiento")
                    GeneraArchivo.ImporteAbono = Tabla.Rows(i)("Anticipo")
                    GeneraArchivo.ImporteApagar = Tabla.Rows(i)("Saldo")
                    GeneraArchivo.ImporteTotal = Tabla.Rows(i)("Total")
                    GeneraArchivo.Saldo = Tabla.Rows(i)("Saldo")
                    GeneraArchivo.Estatus = CN.EstatusFacturasApagar.PROGRAMADA
                    GeneraArchivo.FechaProgramacion = Now
                    Tran.Add(GeneraArchivo)
                    GeneraArchivo.Save()
                Next
                Tran.Commit()
                MessageBox.Show("Se generó archivo con " & Tabla.Rows.Count & " Facturas a pagar.")
            Else
                MessageBox.Show("No se encuentran facturas a esta fecha de vencimiento")
            End If
        Catch ex As Exception
            Tran.Rollback()
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error al crear el Archivo de Programación de Pagos",MsgBoxStyle.Critical,"Error")
#End If
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea borrar todos los registros hasta esta Fecha de Vencimiento?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Dim GeneracionArchivo As New CC.UsrCxpfacturasApagarCollection
            Try
                Dim Facturas As New CC.UsrCxpfacturasApagarCollection
                If Facturas.GetMulti(HC.UsrCxpfacturasApagarFields.Estatus = 1) Then
                    MsgBox("No es posible Generar el archivo ya que en el archivo anterior aún hay Facturas Autorizadas sin Pagar", MsgBoxStyle.Exclamation, "Aviso")
                Else
                    GeneracionArchivo.DeleteMulti(Nothing)
                    MsgBox("El archivo ha sido Cancelado Satisfactoriamente...")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class