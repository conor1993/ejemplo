Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class NomConfiguracionClass
    Inherits ClassBase(Of EC.NomConfiguracionEntity)
#Region "Propiedades"
    ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property
    Property SalarioMinimoDF() As Decimal
        Get
            Return Entity.SalarioMinimoDf
        End Get
        Set(ByVal value As Decimal)
            Entity.SalarioMinimoDf = value
        End Set
    End Property
    Property SalarioMinimoSinaloa() As Decimal
        Get
            Return Entity.SalarioMininimoSinaloa
        End Get
        Set(ByVal value As Decimal)
            Entity.SalarioMininimoSinaloa = value
        End Set
    End Property
    Property MesComercial() As Decimal
        Get
            Return Entity.MesComercial
        End Get
        Set(ByVal value As Decimal)
            Entity.MesComercial = value
        End Set
    End Property
    Property DiasdeTrabajo() As Integer
        Get
            Return Entity.DiasdeTrabajo
        End Get
        Set(ByVal value As Integer)
            Entity.DiasdeTrabajo = value
        End Set
    End Property
    Property Horasdetrabajo() As Decimal
        Get
            Return Entity.HorasDiarias
        End Get
        Set(ByVal value As Decimal)
            Entity.HorasDiarias = value
        End Set
    End Property
#End Region
#Region "Costructores"
    Sub New()
        Entity = New EC.NomConfiguracionEntity
    End Sub

    Sub New(ByVal Entidad As EC.NomConfiguracionEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdPlaza As Integer, ByVal Codigo As Integer)
        Entity = New EC.NomConfiguracionEntity(Codigo)
    End Sub

#End Region
#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If
            If Entity.IsNew Then
                Return Entity.Save
            Else
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region

End Class

Public Class NomConfiguracionCollectionClass
    Inherits ColleccionBase(Of EC.NomConfiguracionEntity, CC.NomConfiguracionCollection, NomConfiguracionClass)

    Public Overloads Function Obtener() As Integer
        Try
            Me.Clear()
            'Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'If Not fcCondicion = CondicionEstatusDepartamento.TODOS Then
            '    Filtro.Add(HC.NomCatPuestosFields.Estatus = fcCondicion)
            '    'coleccion.GetMulti(HC.NomCatPuestosFields.Estatus = fcCondicion)
            'End If

            'If Not Descripcion = "" Then
            '    Filtro.Add(HC.NomCatPuestosFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            '    'coleccion.GetMulti(HC.NomCatPuestosFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            'End If

            coleccion.GetMulti(Nothing)

            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class

