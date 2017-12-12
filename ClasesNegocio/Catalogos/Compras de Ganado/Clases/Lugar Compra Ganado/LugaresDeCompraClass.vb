Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class LugaresDeCompraClass
    Inherits ClassBase(Of EC.CatLugaresDeCompraEntity)

#Region "Miembros"
    Private m_Poblacion As PoblacionClass
    Private m_Estado As EstadoClass
    Private m_Ciudad As CiudadClass
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.CatLugaresDeCompraEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal idLugarCompra As Integer)
        MyBase.New(New EC.CatLugaresDeCompraEntity(idLugarCompra))
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DataObjectField(True, True, False), ComponentModel.Description("Código del Lugar de Compra")> _
    Public ReadOnly Property IdLugarCompra() As Integer
        Get
            Return Entity.IdLugarCompra
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If m_Poblacion Is Nothing Then
                m_Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            ElseIf Not m_Poblacion.Codigo = Me.IdPoblacion Then
                m_Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If

            Return m_Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            m_Poblacion = value

            'If value Is Nothing Then
            '    Entity.Poblacion = Nothing
            'Else
            '    Entity.Poblacion = value.ObtenerEntidad
            'End If
        End Set
    End Property

    Public Property Estado() As EstadoClass
        Get
            If m_Estado Is Nothing Then
                m_Estado = New EstadoClass(Entity.IdEstado)
            End If

            Return m_Estado
        End Get
        Set(ByVal value As EstadoClass)
            m_Estado = value
            'If value Is Nothing Then
            '    Entity.Poblacion.Ciudad.CodigoEstado = -1
            'Else
            '    Entity.Poblacion.Ciudad.CodigoEstado = value.Codigo
            'End If
        End Set
    End Property

    Public Property Ciudad() As CiudadClass
        Get
            If m_Ciudad Is Nothing Then
                m_Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return m_Ciudad
        End Get
        Set(ByVal value As CiudadClass)
            m_Ciudad = value
            'If value Is Nothing Then
            '    Entity.Poblacion.CodigoCiudad = -1
            'Else
            '    Entity.Poblacion.CodigoCiudad = value.Codigo
            'End If
        End Set
    End Property

    Public Property HorasTransporte() As Integer
        Get
            Return Entity.HorasTransporte
        End Get
        Set(ByVal value As Integer)
            Entity.HorasTransporte = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Dim terminarTrans As Boolean = False

        Try
            Dim col As New CC.CatLugaresDeCompraCollection

            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
                terminarTrans = True
            End If

            Trans.Add(Entity)

            If Entity.IsNew Then
                Estatus = EstatusEnum.ACTIVO

                If Trans IsNot Nothing Then Trans.Add(col)

                col.GetMulti(HC.CatLugaresDeCompraFields.Descripcion = Me.Descripcion.Trim)

                For Each ent As EC.CatLugaresDeCompraEntity In col
                    If ent.IdPoblacion = Me.IdPoblacion Then
                        If terminarTrans Then
                            Trans.Rollback()
                            MsgBox("Este lugar de compra ya esta registrado en la población " & Me.Poblacion.Descripcion, MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        Else
                            Throw New Exception("Este lugar de compra ya esta registrado en la población " & Me.Poblacion.Descripcion)
                        End If
                    End If
                Next
            Else
                col.GetMulti(HC.CatLugaresDeCompraFields.Descripcion = Me.Descripcion.Trim And Not HC.CatLugaresDeCompraFields.IdLugarCompra = Me.IdLugarCompra)

                For Each ent As EC.CatLugaresDeCompraEntity In col
                    If ent.IdPoblacion = Me.IdPoblacion Then
                        If terminarTrans Then
                            Trans.Rollback()
                            MsgBox("Este lugar de compra ya esta registrado en la población " & Me.Poblacion.Descripcion, MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        Else
                            Throw New Exception("Este lugar de compra ya esta registrado en la población " & Me.Poblacion.Descripcion)
                        End If
                    End If
                Next
            End If

            Entity.Save()

            If terminarTrans Then Trans.Commit()

            Return True
        Catch ex As Exception
            If terminarTrans Then
                Trans.Rollback()
            End If

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

            Return False
        End Try
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Dim terminarTrans As Boolean = False

        Try
            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar")
                terminarTrans = True
            End If

            Trans.Add(Entity)

            Me.Estatus = EstatusEnum.INACTIVO

            Entity.Save()

            If terminarTrans Then Trans.Commit()

            Return True
        Catch ex As Exception
            If terminarTrans Then Trans.Rollback()
            Throw ex
        End Try
    End Function

    Public Shared Function CargarLugarCompra(ByVal IdLugarCompra As Integer) As LugaresDeCompraClass
        Try
            Return New LugaresDeCompraClass(IdLugarCompra)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
#End Region

End Class