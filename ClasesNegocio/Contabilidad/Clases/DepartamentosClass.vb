Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DepartamentosClass
    Inherits ClassBase(Of EC.CatDeptosEntity)

#Region "Miembros"

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.CatDeptosEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal codigo As Integer)
        Entity = New EC.CatDeptosEntity(codigo)
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return Entity.CveDepto
        End Get
        Private Set(ByVal value As Integer)
            Entity.CveDepto = value
        End Set
    End Property

    <ComponentModel.DisplayName("Nombre")> _
    Public Property Descripcion() As String
        Get
            Return Entity.NomDepto
        End Get
        Set(ByVal value As String)
            Entity.NomDepto = value
        End Set
    End Property

    Public Property Estatus() As EstatusDepartamento
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusDepartamento)
            Entity.Estatus = value
        End Set
    End Property

    <ComponentModel.DisplayName("Estatus")> _
    Public ReadOnly Property EstatusStr() As String
        Get
            Return Estatus.ToString
        End Get
    End Property
#End Region

#Region "Metodos"
    Protected Overrides Function ValidarGuardar() As Boolean
        Dim col As New CC.CatDeptosCollection

        If Descripcion = "" Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If

        If Entity.IsNew Then
            If col.GetDbCount(HC.CatDeptosFields.NomDepto = Descripcion) > 0 Then
                MsgBox("El nombre del departamento ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            If col.GetDbCount(Not HC.CatDeptosFields.CveDepto = Codigo And HC.CatDeptosFields.NomDepto = Descripcion) > 0 Then
                MsgBox("El nombre del departamento ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If

        Return True
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        If Entity.IsNew Then
            Estatus = EstatusDepartamento.ACTIVO
        End If

        Return MyBase.Guardar(Trans)
    End Function

    Protected Overrides Function ValidarBorrar() As Boolean
        Estatus = EstatusDepartamento.INACTIVO

        Return MyBase.ValidarBorrar()
    End Function

    Public Function Obtener(ByVal idDepartamento As Short) As Boolean
        Try
            Return Entity.FetchUsingPK(idDepartamento)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al obtener el departamento", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
#End Region

#Region "Eventos"

#End Region
End Class