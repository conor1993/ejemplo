Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports ClasesNegocio.AlmacenGeneral

Public Class CorralColecttionClass
    Inherits ColleccionBase(Of EC.McecatCorralesCabEntity, CC.McecatCorralesCabCollection, CorralClass)

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEstatusEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcEstatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.McecatCorralesCabFields.Estatus = fcEstatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCorrales(ByVal IdTipoGanado As Integer) As CorralColecttionClass
        ObtenerCorrales = New CorralColecttionClass()

        For Each Corral As CorralClass In Me.Items
            If Corral.IdTipoCorral = IdTipoGanado Then
                ObtenerCorrales.Add(Corral)
            End If
        Next
        Return ObtenerCorrales
    End Function

    Public Function Reporte() As RptCatCorrales
        Dim Reportes As New RptCatCorrales
        Dim ds As New DataSet
        Dim dtCorrales As New DSetCatCorrales.dtCatCorralesDataTable
        For Each Corrales As CorralClass In Me
            dtCorrales.AdddtCatCorralesRow(Corrales.IdCorral, Corrales.Descripcion, Corrales.DescCorta, Corrales.Capacidad, Corrales.Superficie, Corrales.Estatus.ToString, Corrales.TipoCorral.ToString)
        Next
        ds.Tables.Add(dtCorrales)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class


'Public Class CorralIdTipoGanado
'    Implements IEnumerable

'    Private IEnum As IEnumerable, IdTipoGanado As Integer

'    Public Sub New(ByVal iEnumerable As IEnumerable, ByVal IdTipoGanado As Integer)
'        Me.IEnum = iEnumerable.GetEnumerator
'        Me.IdTipoGanado = IdTipoGanado
'    End Sub

'    Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
'        Return New EnumeratorIdTipoCorral(Me.IEnum, IdTipoGanado)
'    End Function

'    Private Class EnumeratorIdTipoCorral
'        Implements IEnumerator

'        Private IEnum As IEnumerator, IdTipoGanado As Integer

'        Public Sub New(ByVal iEnumerator As IEnumerator, ByVal IdTipoGanado As Integer)
'            Me.IEnum = iEnumerator
'            Me.IdTipoGanado = IdTipoGanado
'        End Sub

'        Public ReadOnly Property Current() As Object Implements System.Collections.IEnumerator.Current
'            Get
'                Return IEnum.Current
'            End Get
'        End Property

'        Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext

'        End Function

'        Public Sub Reset() Implements System.Collections.IEnumerator.Reset
'            IEnum.Reset()
'        End Sub
'    End Class
'End Class