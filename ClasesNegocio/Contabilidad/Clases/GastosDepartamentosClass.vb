Imports EC = Integralab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class GastosDepartamentosClass
    Inherits ClassBase(Of EC.GastosDepartamentosEntity)

#Region "Constructores"
    Sub New()
        'MyBase.New()
        Entity = New EC.GastosDepartamentosEntity

    End Sub

    Sub New(ByVal Codigo As Integer, ByVal Ejercicio As Short)
        'MyBase.New()
        Entity = New EC.GastosDepartamentosEntity
    End Sub

    Sub New(ByVal entidad As EC.GastosDepartamentosEntity)
        'MyBase.New()
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    Property IdPoliza() As Integer
        Get
            Return Entity.IdPoliza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoliza = value
        End Set
    End Property
    Property IdSucursal() As Integer
        Get
            Return Entity.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Entity.IdSucursal = value
        End Set
    End Property
    Property IdMetodoProrrateo() As Integer
        Get
            Return Entity.IdMetodoProrrateo
        End Get
        Set(ByVal value As Integer)
            Entity.IdMetodoProrrateo = value
        End Set
    End Property
    Property IdCuentaContable() As Integer
        Get
            Return Entity.IdCuentaContable
        End Get
        Set(ByVal value As Integer)
            Entity.IdCuentaContable = value
        End Set
    End Property
    Property Porcentaje() As Decimal
        Get
            Return Entity.PtjImporte
        End Get
        Set(ByVal value As Decimal)
            Entity.PtjImporte = value
        End Set
    End Property
    Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property
    Property FechaPolizas() As Date
        Get
            Return Entity.FechaPoliza
        End Get
        Set(ByVal value As Date)
            Entity.FechaPoliza = value
        End Set
    End Property
    Property Estatus() As Short
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As Short)
            Entity.Estatus = value
        End Set
    End Property
#End Region

#Region "METODOS"
    'Public Function Obtener(ByVal Ejercicio As Integer) As Boolean
    '    Return Entity.FetchUsingPK(Ejercicio)
    'End Function
    Public Overloads Function Borrar() As Boolean
        Try

            Entity.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Overloads Function Guardar() As Boolean
        Try
            Dim Col As New CC.PeriodosContCollection

            Entity.Save()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class
