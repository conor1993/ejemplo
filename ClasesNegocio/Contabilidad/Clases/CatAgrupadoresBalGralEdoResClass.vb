Imports EC = Integralab.ORM.EntityClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CatAgrupadoresBalGralEdoResClass
    Inherits ClassBase(Of EC.CatAgrupadoresBalGralEdoResEntity)

#Region "Constructores"
    Sub New(ByVal Descripcion As String, ByVal BalanceGral As Boolean, ByVal Prioridad As Integer, ByVal EsActivo As Boolean)
        Entity = New EC.CatAgrupadoresBalGralEdoResEntity()
        Entity.Descripcion = Descripcion
        Entity.BalanceGral = BalanceGral
        Entity.EsActivo = EsActivo

        If Prioridad = 0 Then
            Dim Contador As Object = (New CC.CatAgrupadoresBalGralEdoResCollection).GetScalar(Integralab.ORM.CatAgrupadoresBalGralEdoResFieldIndex.Prioridad, Nothing, OC.AggregateFunction.Max, HC.CatAgrupadoresBalGralEdoResFields.BalanceGral = BalanceGral)

            If IsDBNull(Contador) Then
                Entity.Prioridad = 1
            Else
                Entity.Prioridad = Integer.Parse(Contador) + 1
            End If
        Else
            Entity.Prioridad = Prioridad
        End If
    End Sub

    Sub New(ByVal Entidad As EC.CatAgrupadoresBalGralEdoResEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.CatAgrupadoresBalGralEdoResEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"

    Public Property Codigo() As Integer
        Get
            Return Entity.Código
        End Get
        Set(ByVal value As Integer)
            Entity.Código = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property EsBalanceGral() As Boolean
        Get
            Return Entity.BalanceGral
        End Get
        Set(ByVal value As Boolean)
            Entity.BalanceGral = value
        End Set
    End Property

    Public Property Priodidad() As Integer
        Get
            Return Entity.Prioridad
        End Get
        Set(ByVal value As Integer)
            Entity.Prioridad = value
        End Set
    End Property

    Public Property EsActivo() As Boolean
        Get
            Return Entity.EsActivo
        End Get
        Set(ByVal value As Boolean)
            Entity.EsActivo = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Return Entity.Delete()
    End Function
#End Region

End Class

Public Class CatAgrupadoresBalGralEdoResCollectionClass

#Region "Delcaraciones"

#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Public Shared Sub Imprimir(ByVal sesion As ECS.SesionesEntity, Optional ByVal Filtro As OC.IPredicate = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New rptAgrupadoresEstadosFinancieros()
        Dim ds As New DataSet
        Dim dt As New dsRptAgrupadoresEstadosFinancieros.AgrupadoresDataTable
        Dim ColeccionAgrupadores As New CC.CatAgrupadoresBalGralEdoResCollection()
        ColeccionAgrupadores.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(HC.CatAgrupadoresBalGralEdoResFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

        If ColeccionAgrupadores.Count.ToString > 0 Then
            For Each Item As EC.CatAgrupadoresBalGralEdoResEntity In ColeccionAgrupadores
                dt.AddAgrupadoresRow(Item.Código, Item.Descripcion, IIf(Item.BalanceGral, "BALANCE GENERAL", "ESTADO DE RESULTADOS"), IIf(Item.EsActivo, "ACTIVO", "PASIVO"))
            Next
            ds.Tables.Add(dt)
            Reporte.SetDataSource(ds)
            Reporte.SetParameterValue(0, sesion.MiEmpresa.Empnom)
            Reporte.SetParameterValue(1, sesion.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(2, "Catalogos\Contabilidad\Agrupador Balance General")
            Previsualizar.Reporte = Reporte
            Previsualizar.ShowDialog()
        Else
            MsgBox("No se enconto ningun Agrupador para el Balance General", MsgBoxStyle.Information, "No hay Informacion")
        End If
    End Sub

    Public Shared Function CargarAgrupadoresBalanceGral(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Coleccion As New CC.CatAgrupadoresBalGralEdoResCollection

        Try
            Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.CatAgrupadoresBalGralEdoResFields.BalanceGral, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Ordenamiento.Add(New OC.SortClause(HC.CatAgrupadoresBalGralEdoResFields.Prioridad, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Coleccion.GetMulti(Filtro, 0, Ordenamiento)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Coleccion.GetList()
    End Function
#End Region

End Class
