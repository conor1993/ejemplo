Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = integralab.orm.HelperClasses
Imports CC = integralab.orm.CollectionClasses
Imports EC = integralab.orm.EntityClasses
Imports CN = ClasesNegocio

Public Class MotivoCancelacionCollectionClass
    Inherits CollectionClass(Of MotivoCancelacionClass)

    Private WithEvents Coleccion As New CC.MotivoCancelacionCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(ByVal FcCondicion As CondicionEnum) As Integer
        Try
            If FcCondicion = CondicionEnum.TODOS Then
                Coleccion.GetMulti(Nothing)
            Else
                Coleccion.GetMulti(HC.MotivoCancelacionFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each MotivoCancelacion As MotivoCancelacionClass In Me
            Coleccion.Add(MotivoCancelacion.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.MotivoCancelacionCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.MotivoCancelacionEntity In Coleccion
            Add(New MotivoCancelacionClass(ente))
        Next
    End Sub

    Public Function Reporte() As rptABCMotivosCancelacion
        Dim rpt As New rptABCMotivosCancelacion
        'Dim ds As New DataSet
        'Dim dtMCancelacion As New DSMotivosCancelacion.dtMotivosCancelacionDataTable
        'For Each MC As MotivoCancelacionClass In Me
        '    dtMCancelacion.AdddtMotivosCancelacionRow(MC.Codigo, MC.Descripcion, MC.DescripcionCorta, MC.Motivo.Descripcion, MC.Estatus.ToString())
        'Next
        'ds.Tables.Add(dtMCancelacion)
        'rpt.SetDataSource(ds)
        Return rpt
    End Function

End Class

Public Class MotivoCancelacionDetalleCollectionClass
    Inherits CollectionClass(Of MotivoCancelacionDetalleClass)

    Private Coleccion As New CC.MotivoCancelacionDetalleCollection

    Public Function Obtener(ByVal CodigoMotivo As Integer) As Integer
        Try
            Coleccion.GetMulti(HC.MotivoCancelacionDetalleFields.Idmotivo = CodigoMotivo)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        Clear()
        For Each ente As EC.MotivoCancelacionDetalleEntity In Coleccion
            Add(New MotivoCancelacionDetalleClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each det As MotivoCancelacionDetalleClass In Me
            Coleccion.Add(det.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As CC.MotivoCancelacionDetalleCollection)
        Coleccion = Col
        Rellenar()
    End Sub

    Public Function ObtenerColeccion() As CC.MotivoCancelacionDetalleCollection
        RellenarColeccion()
        Return Coleccion
    End Function
End Class