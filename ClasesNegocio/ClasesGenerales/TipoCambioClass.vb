Imports EC = Integralab.ORM.EntityClasses
Imports CC = INTEGRAlab.orm.CollectionClasses
Imports HC = INTEGRAlab.orm.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TipoCambioClass
    Inherits ClassBase(Of EC.TipoCambioEntity)

    Sub New()

    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.TipoCambioEntity(Codigo)
    End Sub

    Sub New(ByVal entidad As EC.TipoCambioEntity)
        Entity = entidad
    End Sub

    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Indice
        End Get
    End Property

    Public Property Fecha() As DateTime
        Get
            Return Entity.Fecha
        End Get
        Set(ByVal value As DateTime)
            Entity.Fecha = value
        End Set
    End Property

    Public Property IdTipoMoneda() As Integer
        Get
            Return Entity.TipomonedaId
        End Get
        Set(ByVal value As Integer)
            Entity.TipomonedaId = value
        End Set
    End Property

    Public Property TipoMoneda() As TipoMonedaClass
        Get
            Dim tmp As TipoMonedaClass = Nothing
            If Entity.TipomonedaId > 0 Then tmp = New TipoMonedaClass(Entity.TipoMoneda)
            Return tmp
        End Get
        Set(ByVal value As TipoMonedaClass)
            Entity.TipomonedaId = 0
            If Not IsNothing(value) Then Entity.TipoMoneda = value.ObtenerEntidad
        End Set
    End Property

    Public ReadOnly Property TipoMonedaDescripcion() As String
        Get
            Return TipoMoneda.Descripcion
        End Get
    End Property

    Public Property TipoCambio() As Decimal
        Get
            Return Entity.Tipocambio
        End Get
        Set(ByVal value As Decimal)
            Entity.Tipocambio = value
        End Set
    End Property

    Public Function ObtenerEntidad() As EC.TipoCambioEntity
        Return Entity
    End Function

    Public Function Guardar() As Boolean
        Dim bl As Boolean = False
        Dim tipos As New TipoCambioCollectionClass()

        If tipos.Validar(Me) Then
            bl = Entity.Save
        Else
            MsgBox("No se puede guardar por que uno o mas datos ya existen.", Windows.Forms.MessageBoxIcon.Error, "Datos duplicados")
        End If
        Return bl
    End Function
End Class

Public Class TipoCambioCollectionClass
    Inherits ColleccionBase(Of EC.TipoCambioEntity, CC.TipoCambioCollection, TipoCambioClass)

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Collection As CC.TipoCambioCollection)
        MyBase.New(Collection)
    End Sub

#End Region

#Region "Metodos"

    Public Function Validar(ByVal TipoCambio As TipoCambioClass) As Boolean
        Return True
    End Function

    Public Function ObtenerTipoCambio(ByVal TipoMoneda As TipoMonedaClass, ByVal Fecha As Date) As TipoCambioClass
        Dim filtro As New SC.PredicateExpression
        Dim Orden As New SC.SortExpression(New SC.SortClause(HC.TipoCambioFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
        filtro.Add(HC.TipoCambioFields.TipomonedaId = TipoMoneda.Codigo)
        filtro.Add(HC.TipoCambioFields.Fecha = Fecha)
        Dim tmp As New CC.TipoCambioCollection
        tmp.GetMulti(filtro, -1, Orden)
        Dim ret As TipoCambioClass = Nothing
        If tmp.Count > 0 Then ret = New TipoCambioClass(tmp(0))
        Return ret
    End Function

    Public Function Obtener(Optional ByVal TipoMoneda As TipoMonedaClass = Nothing, Optional ByVal Fecha As Object = Nothing) As Integer
        Dim filtro As New SC.PredicateExpression
        Dim Orden As New SC.SortExpression(New SC.SortClause(HC.TipoCambioFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

        If Not IsNothing(TipoMoneda) Then
            filtro.Add(HC.TipoCambioFields.TipomonedaId = TipoMoneda.Codigo)
        End If

        If Not IsNothing(Fecha) Then
            filtro.Add(New SC.FieldBetweenPredicate(HC.TipoCambioFields.Fecha, #1/1/1900#, Fecha))
        End If
        coleccion.GetMulti(filtro, -1, Orden)
        Rellenar()
        Return Me.Count
    End Function

    Public Function Obtener(ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            filtro.Add(New OC.FieldBetweenPredicate(HC.TipoCambioFields.Fecha, _
                                    fechaIni.Date, CDate(fechaFin.AddDays(1).ToShortDateString).AddMilliseconds(-1)))

            coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.TipoCambioFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal idTipoMoneda As Integer, ByVal fechaIni As DateTime, ByVal fechaFin As DateTime) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.TipoCambioFields.TipomonedaId = idTipoMoneda)
            filtro.AddWithAnd(New OC.FieldBetweenPredicate(HC.TipoCambioFields.Fecha, _
                                    fechaIni.Date, CDate(fechaFin.AddDays(1).ToShortDateString).AddMilliseconds(-1)))

            coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(HC.TipoCambioFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function ObtenerColeccion() As CC.TipoCambioCollection
        Return coleccion
    End Function

#End Region

End Class