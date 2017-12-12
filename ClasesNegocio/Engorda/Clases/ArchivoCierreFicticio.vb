Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ArchivoCierreFicticioClass
    Inherits EC.CierreFicticioEntity

#Region "Miembros"
    Private _Lote As LoteClass
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.CierreFicticioEntity)
        Me.IdLote = Entidad.IdLote
        Me.FechaInicio = Entidad.FechaInicio
        Me.FechaCierreFic = Entidad.FechaCierreFic
        Me.DiasCabeza = Entidad.DiasCabeza
        Me.KilosAlimento = Entidad.KilosAlimento
        Me.PesoEntrada = Entidad.PesoEntrada
        Me.PesoActual = Entidad.PesoActual
        Me.PesoPromEstimado = Entidad.PesoPromEstimado
        Me.CostoEntrada = Entidad.CostoEntrada
        Me.CostoAlimento = Entidad.CostoAlimento
        Me.CostoMedicina = Entidad.CostoMedicina
        Me.CostosIndirectos = Entidad.CostosIndirectos
    End Sub

    Sub New(ByVal IdLote As Integer, ByVal FechaInicio As Date, ByVal FechaCierreFic As Date, ByVal DiasCabeza As Integer, ByVal KilosAlimento As Decimal, ByVal PesoEntrada As Decimal, ByVal PesoActual As Decimal, ByVal PesoPromEstimado As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoAlimento As Decimal, ByVal CostoMedicina As Decimal, ByVal CostosIndirectos As Decimal)
        Me.IdLote = IdLote
        Me.FechaInicio = FechaInicio
        Me.FechaCierreFic = FechaCierreFic
        Me.DiasCabeza = DiasCabeza
        Me.KilosAlimento = KilosAlimento
        Me.PesoEntrada = PesoEntrada
        Me.PesoActual = PesoActual
        Me.PesoPromEstimado = PesoPromEstimado
        Me.CostoEntrada = CostoEntrada
        Me.CostoAlimento = CostoAlimento
        Me.CostoMedicina = CostoMedicina
        Me.CostosIndirectos = CostosIndirectos
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Lote() As LoteClass
        Get
            If _Lote Is Nothing Then
                _Lote = New LoteClass(IdLote)
            End If
            Return _Lote
        End Get
    End Property
#End Region

#Region "Metodos"

    Public Function Guardar(ByRef Trans As HC.Transaction) As Boolean
        Trans.Add(Me)
        Return Me.Save()
    End Function

#End Region

End Class

Public Class ArchivoCierreFicticioCollectionClass
    Inherits ColleccionBase(Of ArchivoCierreFicticioClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal Entidad As ArchivoCierreFicticioClass)
        Me.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.CierreFicticioEntity)
        Me.Add(New ArchivoCierreFicticioClass(Entidad))
    End Sub
#End Region
End Class
