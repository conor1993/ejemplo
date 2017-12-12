Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ProductosDetalleDecomisoClass
    Inherits ClassBase(Of EC.MsccatProductosDetalleEntity)

#Region "Miembros"
    Private _ProductoSalaCortes As ProductosClass
    Private _ProductoId As Integer
    Private _ProductoNombre As String
    Private _Decomiso As MotivosDecomisoClass
    Private _DecomisoId As Integer
    Private _DecomisoNombre As String
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.MsccatProductosDetalleEntity
    End Sub

    Sub New(ByVal entidad As EC.MsccatProductosDetalleEntity)
        Entity = entidad
    End Sub

    Sub New(ByVal IdProducto As Integer, ByVal IdDecomiso As Integer)
        Entity = New EC.MsccatProductosDetalleEntity(IdProducto, IdDecomiso)
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Código Producto")> _
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    Public Property Producto() As ProductosClass
        Get
            If Me._ProductoSalaCortes Is Nothing Then
                Me._ProductoSalaCortes = New ProductosClass
                Me._ProductoSalaCortes.LeerEntidad(Entity.MsccatProductos)
            End If

            Return Me._ProductoSalaCortes
        End Get
        Set(ByVal value As ProductosClass)
            Me._ProductoSalaCortes = value

            If value Is Nothing Then
                Me.Entity.MsccatProductos = Nothing
            Else
                Me.Entity.MsccatProductos = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el nombre del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns><b>String:</b> Nombre Producto</returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Producto")> _
    Public ReadOnly Property ProductoNombre() As String
        Get
            If Me._ProductoSalaCortes Is Nothing Then
                If Me._ProductoId = 0 Then
                    If Not Me.IdProducto = 0 Then
                        Me.ObtenerNombreProducto(Me.IdProducto)
                        Me._ProductoId = Me.IdProducto
                    Else
                        Me._ProductoNombre = ""
                    End If
                ElseIf Not Me._ProductoId = Me.IdProducto Then
                    Me.ObtenerNombreProducto(Me.IdProducto)
                    Me._ProductoId = Me.IdProducto
                End If
            Else
                Me._ProductoNombre = Me._ProductoSalaCortes.Descripcion
                Me._ProductoId = Me._ProductoSalaCortes.IdProducto
            End If

            Return Me._ProductoNombre
        End Get
    End Property

    <ComponentModel.DisplayName("Código Decomiso")> _
    Public Property IdDecomiso() As Integer
        Get
            Return Entity.IdDecomiso
        End Get
        Set(ByVal value As Integer)
            Entity.IdDecomiso = value
        End Set
    End Property

    Public Property Decomiso() As MotivosDecomisoClass
        Get
            If Me._Decomiso Is Nothing Then
                Me._Decomiso = New MotivosDecomisoClass
                Me._Decomiso.LeerEntidad(Me.Entity.MsccatDecomisos)
            End If

            Return Me._Decomiso
        End Get
        Set(ByVal value As MotivosDecomisoClass)
            Me._Decomiso = value

            If value Is Nothing Then
                Entity.MsccatDecomisos = Nothing
            Else
                Entity.MsccatDecomisos = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el nombre del decomiso
    ''' </summary>
    ''' <value></value>
    ''' <returns><b>String:</b> Nombre Decomiso</returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Decomiso")> _
    Public ReadOnly Property DecomisoNombre() As String
        Get
            If Me._Decomiso Is Nothing Then
                If Me._DecomisoId = 0 Then
                    If Not Me.IdDecomiso = 0 Then
                        Me.ObtenerNombreDecomiso(Me.IdDecomiso)
                        Me._DecomisoId = Me.IdDecomiso
                    Else
                        Me._DecomisoNombre = ""
                    End If
                ElseIf Not Me._DecomisoId = Me.IdDecomiso Then
                    Me.ObtenerNombreDecomiso(Me.IdDecomiso)
                    Me._DecomisoId = Me.IdDecomiso
                End If
            Else
                Me._DecomisoNombre = Me._Decomiso.Descripcion
                Me._DecomisoId = Me._Decomiso.IdDecomiso
            End If

            Return Me._DecomisoNombre
        End Get
    End Property

    Private Property Estatus() As EstatusEnum
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overloads Sub LeerEntidad(ByVal entidad As EC.MsccatProductosDetalleEntity)
        Entity = entidad
    End Sub

    Public Overloads Function ObtenerEntidad() As EC.MsccatProductosDetalleEntity
        Return Entity
    End Function

    ''' <summary>
    ''' Obtiene el nombre del producto con el idProducto Especificado
    ''' </summary>
    ''' <param name="idProducto">Código del Producto</param>
    ''' <remarks></remarks>
    Private Sub ObtenerNombreProducto(ByVal idProducto As Integer)
        Try
            Dim col As New CC.MsccatProductosCollection
            Me._ProductoNombre = CStr(col.GetScalar(Integralab.ORM.MsccatProductosFieldIndex.Descripcion, New OC.Expression(HC.MsccatProductosFields.Descripcion), _
                                        SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, HC.MsccatProductosFields.IdProducto = idProducto))
        Catch ex As Exception
            MsgBox("No se logró obtener el nombre del producto", MsgBoxStyle.Critical, "Error")
            Me._ProductoNombre = ""
        End Try
    End Sub

    ''' <summary>
    ''' Obtiene el nombre del decomiso con el idDecomiso Especificado
    ''' </summary>
    ''' <param name="idDecomiso">Código del Decomiso</param>
    ''' <remarks></remarks>
    Private Sub ObtenerNombreDecomiso(ByVal idDecomiso As Integer)
        Try
            Dim col As New CC.MsccatDecomisosCollection
            Me._DecomisoNombre = CStr(col.GetScalar(Integralab.ORM.MsccatDecomisosFieldIndex.Descripcion, New OC.Expression(HC.MsccatDecomisosFields.Descripcion), _
                                        SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.None, HC.MsccatDecomisosFields.IdDecomiso = idDecomiso))
        Catch ex As Exception
            MsgBox("No se logró obtener el nombre del decomiso", MsgBoxStyle.Critical, "Error")
            Me._DecomisoNombre = ""
        End Try
    End Sub
#End Region
End Class

Public Class ProductosDetalleDecomisoCollectionClass
    Inherits ColleccionBase(Of EC.MsccatProductosDetalleEntity, CC.MsccatProductosDetalleCollection, ProductosDetalleDecomisoClass)

    Public Overloads Function Obtener(Of Tipo)(ByVal campo As Integralab.ORM.MsccatProductosDetalleFieldIndex, ByVal Value As Tipo) As Integer
        Try
            Dim field As OC.EntityField = Integralab.ORM.FactoryClasses.EntityFieldFactory.Create(campo)

            If field Is Nothing Then
                coleccion.GetMulti(Nothing)
            Else
                coleccion.GetMulti(field = Value)
            End If


            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#Region "Metodos de Relleno"
    Private Overloads Sub Rellenar()
        Clear()

        For Each ente As EC.MsccatProductosDetalleEntity In coleccion
            Add(New ProductosDetalleDecomisoClass(ente))
        Next
    End Sub

    Private Overloads Sub RellenarColeccion()
        coleccion.Clear()

        For Each det As ProductosDetalleDecomisoClass In Me
            coleccion.Add(det.ObtenerEntidad)
        Next
    End Sub

    Public Overloads Sub RellenarMe(ByVal col As CC.MsccatProductosDetalleCollection)
        coleccion = col
        Rellenar()
    End Sub

    Public Overloads Function ObtenerColeccion() As CC.MsccatProductosDetalleCollection
        RellenarColeccion()
        Return coleccion
    End Function
#End Region

End Class