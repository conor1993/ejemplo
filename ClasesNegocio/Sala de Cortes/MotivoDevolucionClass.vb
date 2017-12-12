Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MotivoDevolucionClass
    Inherits ClassBase(Of EC.MsccatMotivoDevolucionEntity)

#Region "Propiedades"
    Public Property IdMotivoDevolucion() As Integer
        Get
            Return Entity.IdMotivoDevolucion
        End Get
        Set(ByVal value As Integer)
            Entity.IdMotivoDevolucion = value
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

    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Entity.DescripcionCorta = value
        End Set
    End Property

    Public ReadOnly Property EstatusDescripcion() As String
        Get
            If Me.Estatus = EstatusEnum.ACTIVO Then
                Return "ACTIVO"
            Else
                Return "INACTIVO"
            End If
        End Get
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property

    Public ReadOnly Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Estatus = EstatusEnum.ACTIVO

        Return MyBase.Guardar(Trans)
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Estatus = EstatusEnum.INACTIVO
        Return MyBase.Borrar(Trans)
    End Function

    Protected Overrides Function ValidarGuardar() As Boolean
        If Me.DescripcionCorta.Trim.Length = 0 Then
            MsgBox("Debe ingresar una descripción corta", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If

        If Me.Descripcion.Trim.Length = 0 Then
            MsgBox("Debe ingresar una descripción", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If

        Return MyBase.ValidarGuardar()
    End Function

    Protected Overrides Function ValidarBorrar() As Boolean
        Return MyBase.ValidarBorrar()
    End Function

    Public Function Obtener(ByVal idMotivoDevolucion As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(idMotivoDevolucion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class

Public Class MotivoDevolucionColeccionClass
    Inherits ColleccionBase(Of EC.MsccatMotivoDevolucionEntity, CC.MsccatMotivoDevolucionCollection, MotivoDevolucionClass)

    Public Overloads Function Obtener(ByVal estatus As CondicionEnum) As Boolean
        Try
            Dim filtro As New OC.PredicateExpression

            If Not estatus = CondicionEnum.TODOS Then
                filtro.Add(HC.MsccatMotivoDevolucionFields.Estatus = estatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overloads Function Obtener(ByVal descripcion As String, ByVal estatus As CondicionEnum) As Boolean
        Try
            Dim filtro As New OC.PredicateExpression

            If Not estatus = CondicionEnum.TODOS Then
                filtro.Add(HC.MsccatMotivoDevolucionFields.Estatus = estatus)
            End If

            filtro.Add(HC.MsccatMotivoDevolucionFields.Descripcion Mod String.Format("%{0}%", descripcion.Trim))

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class