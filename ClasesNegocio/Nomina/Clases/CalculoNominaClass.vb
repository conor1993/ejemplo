Imports ORM = Integralab.ORM
Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CalculoNominaClass

    Inherits ClassBase(Of EC.NomImportesEntity)
    'Dim Entity As EC.NomImportesEntity

#Region "Propiedades"
    Public Property Folio() As String
        Get
            Return Entity.Folio
        End Get
        Set(ByVal value As String)
            Entity.Folio = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return Entity.Fecha
        End Get
        Set(ByVal value As DateTime)
            Entity.Fecha = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Quincena
        End Get
        Set(ByVal value As String)
            Entity.Quincena = value
        End Set
    End Property

    'Public Property SMRegionA() As Decimal
    '    Get
    '        Return Entity.
    '    End Get
    '    Set(ByVal value As Decimal)
    '        SMRegionA_ = value
    '    End Set
    'End Property

    'Public Property SMRegionC() As Decimal
    '    Get
    '        Return SMRegionC_
    '    End Get
    '    Set(ByVal value As Decimal)
    '        SMRegionC_ = value
    '    End Set
    'End Property

    'Public Property MesComercial() As Decimal
    '    Get
    '        Return MesComercial_
    '    End Get
    '    Set(ByVal value As Decimal)
    '        MesComercial_ = value
    '    End Set
    'End Property

#End Region

    #Region "Costructores"
    Sub New()
        Entity = New EC.NomImportesEntity
    End Sub

    Sub New(ByVal Entidad As EC.NomImportesEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal folio As Integer, ByVal idempleado As Integer)
        Entity = New EC.NomImportesEntity(folio, Idempleado)
    End Sub

    Public Function Obtener(ByVal folio As Integer, ByVal idempleado As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(folio, idempleado)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

#End Region

   
End Class

Public Class CalculoNominaColeccion

    Inherits ColleccionBase(Of EC.NomImportesEntity, CC.NomImportesCollection, CalculoNominaClass)

    Public Overloads Function Obtener(ByVal Folio As String, ByVal Descripcion As String) As Integer
        Try
            Me.Clear()
            coleccion.GetMulti(HC.NomImportesFields.Folio = Folio)

            For Each entidad As EC.NomImportesEntity In coleccion
                Dim MiCalculo As New CalculoNominaClass
                MiCalculo.LeerEntidad(entidad)
                Me.Add(MiCalculo)
            Next
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error.", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function




End Class


