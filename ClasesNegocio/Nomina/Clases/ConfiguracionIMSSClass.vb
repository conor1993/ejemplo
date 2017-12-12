Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Public Class ConfiguracionIMSSClass
    Inherits ClassBase(Of EC.NomImssinfonavitEntity)

#Region "Propiedades"
    Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property
    Property CuotFijaObrero() As Decimal
        Get
            Return Entity.EnfyMatEnEspecieCuotaFijaObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnEspecieCuotaFijaObrero = value
        End Set
    End Property
    Property CuotaFijaPatronal() As Decimal
        Get
            Return Entity.EnfyMatEnEspecieCuotaFijaPatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnEspecieCuotaFijaPatronal = value
        End Set
    End Property
    Property TopeIntegrarCuotaFija() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcuotaFija
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcuotaFija = value
        End Set
    End Property
    Property TopeCalcularCuotaFija() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculocuotaFija
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculocuotaFija = value
        End Set
    End Property
    Property ExcedenteObrero() As Decimal
        Get
            Return Entity.EnfyMatEnEspecieExcedenteObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnEspecieExcedenteObrero = value
        End Set
    End Property
    Property ExcedentePatronal() As Decimal
        Get
            Return Entity.EnfyMatEnEspecieExcedentePatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnEspecieExcedentePatronal = value
        End Set
    End Property
    Property TopeIntegrarExcedente() As Integer
        Get
            Return Entity.TopeVssmdfintegrarexcedente
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarexcedente = value
        End Set
    End Property
    Property TopeCalcularExcedente() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoexcedente
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoexcedente = value
        End Set
    End Property
    Property EndineroObrero() As Decimal
        Get
            Return Entity.EnfyMatEnDineroObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnDineroObrero = value
        End Set
    End Property
    Property EndineroPatronal() As Decimal
        Get
            Return Entity.EnfyMatEnDineroPatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatEnDineroPatronal = value
        End Set
    End Property
    Property TopeIntegrarEndinero() As Integer
        Get
            Return Entity.TopeVssmdfintegrarendinero
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarendinero = value
        End Set
    End Property
    Property TopeCalcularEndinero() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoendinero
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoendinero = value
        End Set
    End Property
    Property GastosMedicosObrero() As Decimal
        Get
            Return Entity.EnfyMatGastosMedicosObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatGastosMedicosObrero = value
        End Set
    End Property
    Property GastosMedicosPatronal() As Decimal
        Get
            Return Entity.EnfyMatGastosMedicosPatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.EnfyMatGastosMedicosPatronal = value
        End Set
    End Property
    Property TopeIntegrarGastosMedicos() As Integer
        Get
            Return Entity.TopeVssmdfintegrargastosMedicos
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrargastosMedicos = value
        End Set
    End Property
    Property TopeCalcularGastosMedicos() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculogastosMedicos
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculogastosMedicos = value
        End Set
    End Property
    Property InvalidezyvidaObrero() As Decimal
        Get
            Return Entity.InvalidezyVidaObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.InvalidezyVidaObrero = value
        End Set
    End Property
    Property InvalidezyvidaPatronal() As Decimal
        Get
            Return Entity.InvalidezyVidaPatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.InvalidezyVidaPatronal = value
        End Set
    End Property
    Property TopeIntegrarInvalidezyvida() As Integer
        Get
            Return Entity.TopeVssmdfintegrarinvalidezyvida
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarinvalidezyvida = value
        End Set
    End Property
    Property TopeCalcularInvalidezyvida() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoinvalidezyvida
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoinvalidezyvida = value
        End Set
    End Property
    Property CesantiayvejezObrero() As Decimal
        Get
            Return Entity.RetCesantiayVejezObrero
        End Get
        Set(ByVal value As Decimal)
            Entity.RetCesantiayVejezObrero = value
        End Set
    End Property
    Property CesantiayVejezPatronal() As Decimal
        Get
            Return Entity.RetCesantiayVejezPatronal
        End Get
        Set(ByVal value As Decimal)
            Entity.RetCesantiayVejezPatronal = value
        End Set
    End Property
    Property TopeIntegrarCesantiayVejez() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcesantiayvejez
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcesantiayvejez = value
        End Set
    End Property
    Property TopeCalcularCesantiayVejez() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculocesantiayvejez
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculocesantiayvejez = value
        End Set
    End Property
    Property Guarderias() As Decimal
        Get
            Return Entity.Guarderias
        End Get
        Set(ByVal value As Decimal)
            Entity.Guarderias = value
        End Set
    End Property
    Property TopeIntegrarGuarderias() As Integer
        Get
            Return Entity.TopeVssmdfintegrarguarderias
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarguarderias = value
        End Set
    End Property
    Property TopeCalcularGuarderias() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoguarderias
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoguarderias = value
        End Set
    End Property
    Property Retiro() As Decimal
        Get
            Return Entity.Retiro
        End Get
        Set(ByVal value As Decimal)
            Entity.Retiro = value
        End Set
    End Property
    Property TopeIntegrarRetiro() As Integer
        Get
            Return Entity.TopeVssmdfintegrarretiro
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarretiro = value
        End Set
    End Property
    Property TopeCalcularRetiro() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoretiro
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoretiro = value
        End Set
    End Property
    Property INFONAVIT() As Decimal
        Get
            Return Entity.Infonavit
        End Get
        Set(ByVal value As Decimal)
            Entity.Infonavit = value
        End Set
    End Property
    Property TopeIntegrarINFONAVIT() As Integer
        Get
            Return Entity.TopeVssmdfintegrarinfonavit
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarinfonavit = value
        End Set
    End Property
    Property TopeCalcularINFONAVIT() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoinfonavit
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoinfonavit = value
        End Set
    End Property
    Property RiesgodeTrabajo() As Decimal
        Get
            Return Entity.Riesgotrabajo
        End Get
        Set(ByVal value As Decimal)
            Entity.Riesgotrabajo = value
        End Set
    End Property
    Property TopeIntegrarriesgodeTrabajo() As Integer
        Get
            Return Entity.TopeVssmdfintegrarriesgodeTrabajo
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarriesgodeTrabajo = value
        End Set
    End Property
    Property TopeCalcularriesgodeTrabajo() As Integer
        Get
            Return Entity.TopeVssmdfintegrarcalculoriesgodeTrabajo
        End Get
        Set(ByVal value As Integer)
            Entity.TopeVssmdfintegrarcalculoriesgodeTrabajo = value
        End Set
    End Property
#End Region
    
#Region "Costructores"
    Sub New()
        Entity = New EC.NomImssinfonavitEntity
    End Sub
    Sub New(ByVal Entidad As EC.NomImssinfonavitEntity)
        Entity = Entidad
    End Sub
    Sub New(ByVal IdPlaza As Integer, ByVal Codigo As Integer)
        Entity = New EC.NomImssinfonavitEntity(Codigo)
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

Public Class ConfiguracionCollectionClass
    Inherits ColleccionBase(Of EC.NomImssinfonavitEntity, CC.NomImssinfonavitCollection, ConfiguracionIMSSClass)

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
