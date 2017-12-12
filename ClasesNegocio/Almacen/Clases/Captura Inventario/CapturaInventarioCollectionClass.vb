Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CM = System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CapturaInventarioCollectionClass
    Inherits ColleccionBase(Of CapturaInventarioClass)

    Private colOriginal As CapturaInventarioCollectionClass

    Public Sub ObtenerProductos()
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            Dim consulta As String = "SELECT [IdProducto],[Descripcion],[SubProducto],[Corte],[Canal] " & _
                                     "FROM [dbo].[MSCCatProductos] " & _
                                     "WHERE  (Corte=1 OR SubProducto=1) AND Canal=0 OR (Corte=0 AND SubProducto=0)"
            Dim sqlCom As New SqlCommand(consulta, sqlCon)
            Dim dr As SqlDataReader

            sqlCon.Open()
            dr = sqlCom.ExecuteReader

            While dr.Read
                Add(New CapturaInventarioClass(CInt(dr("IdProducto")), CStr(dr("Descripcion")), 0, "", _
                    0, 0D, 0D, CBool(dr("SubProducto")), CBool(dr("Corte")), CBool(dr("Canal"))))
            End While
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al obtener los productos", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Public Function Guardar() As Boolean
        Try
            Dim idAlmacenCorte, idAlmacenProducto As Integer
            Dim ConfigProd As New CC.UsrProdConfiguracionCollection

            ConfigProd.GetMulti(Nothing)

            If Not ConfigProd.Count > 0 Then
                MessageBox.Show("Seleccione un Almacén para la recepción de canales en la configuracion del modulo de Producción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If

            idAlmacenCorte = ConfigProd(0).IdAlmacenCortes
            idAlmacenProducto = ConfigProd(0).IdAlmacenProductos

            Dim movCortes As New EC.MscmovtosAlmacenCabEntity
            Dim movProductos As New EC.MscmovtosAlmacenCabEntity

            movCortes.IdCodAlmacen = idAlmacenCorte
            movProductos.IdCodAlmacen = idAlmacenProducto

            For Each item As CapturaInventarioClass In colOriginal
                Dim movDet As New EC.MscmovtosAlmacenDetEntity

                If item.EsProducto Then

                End If
            Next


        Catch ex As Exception

        End Try
    End Function

    Public Function Filtrar(ByVal producto As String) As Integer
        Try
            If colOriginal Is Nothing Then
                colOriginal = New CapturaInventarioCollectionClass

                For Each item As CapturaInventarioClass In Me
                    colOriginal.Add(item)
                Next
            End If

            Clear()

            If producto = "" Then
                For Each item As CapturaInventarioClass In colOriginal
                    Add(item)
                Next
            Else
                For Each item As CapturaInventarioClass In colOriginal
                    If Regex.Matches(item.Producto, producto, RegexOptions.IgnoreCase).Count > 0 Then
                        Add(item)
                    End If
                Next
            End If

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al filtrar", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function
End Class