Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TiposProveedoresClass
    Inherits ClassBase(Of EC.TipoProveedorEntity)

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entity As EC.TipoProveedorEntity)
        MyBase.New(entity)
    End Sub

    Sub New(ByVal fcCodigo As Integer)
        MyBase.New(New EC.TipoProveedorEntity(fcCodigo))
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Codigo() As Integer
        Get
            Return entity.Codigo
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return entity.Descripcion
        End Get
        Set(ByVal value As String)
            entity.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property DescripcionCorta() As String
        Get
            Return entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            entity.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return entity.Observaciones
        End Get
        Set(ByVal value As String)
            entity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Estatus() As EstatusEnum 'Implements IEntidad.Estatus
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return entity.UsuarioAlta
        End Get
        Set(ByVal value As Integer)
            entity.UsuarioAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            entity.FechaAlta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property IdUsuarioBaja() As Integer
        Get
            Return entity.UsuarioBaja
        End Get
        Set(ByVal value As Integer)
            entity.UsuarioBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property FechaBaja() As Date
        Get
            Return entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            entity.FechaBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property IdMotivoBaja() As Integer
        Get
            Return entity.MotivoBaja
        End Get
        Set(ByVal value As Integer)
            entity.MotivoBaja = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property ObservacionesBaja() As String
        Get
            Return entity.Observaciones
        End Get
        Set(ByVal value As String)
            entity.Observaciones = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusEnum.INACTIVO

            Return Entity.Save()
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "El Tipo de Proveedor no pudo ser dado de baja.")
            Return False
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            Dim col As New CC.TipoProveedorCollection

            If Entity.IsNew Then
                If col.GetDbCount(HC.TipoProveedorFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de proveedor con la misma descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If col.GetDbCount(Not HC.TipoProveedorFields.Codigo = Me.Codigo And HC.TipoProveedorFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe un tipo de proveedor con la misma descripción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If

            Return Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean 'Implements IEntidad.Obtener
        Try
            If Entity.FetchUsingPK(Codigo) Then
                Return True
            End If

            RaiseEvent MensajeError(Me, "El Tipo de Proveedor no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try

        Return False
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
#End Region

End Class

Public Class TiposProveedorCollectionClass
    Inherits ColleccionBase(Of EC.TipoProveedorEntity, CC.TipoProveedorCollection, TiposProveedoresClass)

#Region "Miembros"

#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub
#End Region

#Region "Metodos"
    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEnum) As Integer
        Dim res As Integer

        Try
            If fcEstatus = CondicionEnum.TODOS Then
                res = Me.Obtener()
            Else
                res = Me.Obtener(HC.TipoProveedorFields.Estatus = fcEstatus)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            res = 0
        End Try

        Return res
    End Function

    Public Function Reporte() As rptABCTiposProveedores
        Try
            Dim rpt As New rptABCTiposProveedores

            Dim ds As New DataSet
            Dim dtTiposProveedores As New DSTiposProveedores.dtTiposProveedoresDataTable

            For Each TipoProveedor As TiposProveedoresClass In Me
                dtTiposProveedores.AdddtTiposProveedoresRow(TipoProveedor.Codigo, TipoProveedor.Descripcion, TipoProveedor.DescripcionCorta, TipoProveedor.Estatus)
            Next

            ds.Tables.Add(dtTiposProveedores)
            rpt.SetDataSource(ds)

            Return rpt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
#End Region
End Class