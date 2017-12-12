Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = INTEGRALAB.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports System.Windows.Forms

Public Class AlmacenFamiliaClass
    Inherits ClassBase(Of EC.AlmacenesFamiliasEntity)

#Region "Miembros"
   
#End Region

#Region "Constructores"
    Public Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Entidad As EC.AlmacenesFamiliasEntity)
        MyBase.New(Entidad)
    End Sub    
#End Region

#Region "Propiedades"
    Public Property AlmacenID() As Integer
        Get
            Return Entity.CodigoAlmacen
        End Get
        Set(ByVal value As Integer)
            Entity.CodigoAlmacen = value
        End Set
    End Property
    Public Property FamiliaID() As Integer
        Get
            Return Entity.CodigoLinea
        End Get
        Set(ByVal value As Integer)
            Entity.CodigoLinea = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean
        Return Entity.Delete
    End Function

    Public Shadows Function Guardar() As Boolean
        Return Entity.Save
    End Function
#End Region
End Class
