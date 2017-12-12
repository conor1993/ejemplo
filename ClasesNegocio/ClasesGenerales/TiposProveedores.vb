Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports System.Windows.Forms
Public Class TipoProveedorClass
    Implements IEntidad

    Dim Entity As EC.TipoProveedorEntity

#Region "Miembros"
    'Private WithEvents TipoProveedor As IntegraLab.ORM.EntityClasses.TipoProveedorEntity
    Private _Error As Boolean = False
    'Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements Integra.Clases.IEntidad.MensajeError
    'Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements Integra.Clases.IEntidad.Modificado

#End Region

#Region "Propiedades"
    <System.ComponentModel.DisplayName("Código")> _
   ReadOnly Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
    End Property
    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            'If value.Replace(" ", "").Length = 0 Then
            '    _Error = True
            '    RaiseEvent MensajeError(Me, "La Descripción es Obligatoria.")
            'Else
            Entity.Descripcion = value
            'End If
        End Set
    End Property
    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            'If value.Replace(" ", "").Length = 0 Then
            '    _Error = True
            '    RaiseEvent MensajeError(Me, "La Descripción Corta es Obligatoria.")
            'Else
            Entity.DescripcionCorta = value
            'End If
        End Set
    End Property

    '<System.ComponentModel.DisplayName("Descripción Corta")> _
    'Public Property Fletes() As Boolean
    '    Get
    '        Return Entity.Fletes
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Entity.Fletes = value
    '    End Set
    'End Property

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    <System.ComponentModel.Browsable(False)> _
    ReadOnly Property [Error]() As Boolean
        Get
            Return _Error
        End Get
    End Property
#End Region

#Region "Metodos"

    Sub New()
        Entity = New Integralab.ORM.EntityClasses.TipoProveedorEntity
        Entity.UsuarioAlta = 0
        Entity.FechaAlta = Now
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub
    Sub New(ByVal Entidad As EC.TipoProveedorEntity)
        Me.Entity = Entidad
    End Sub
    Public Sub LimpiarError()
        _Error = False
    End Sub

    Public Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Entity.Estatus = EstatusEnum.INACTIVO
        Return Entity.Save
    End Function
    Protected Function ValidarGuardar() As Boolean
        If IsNothing(Validar) Then
            Return True
        Else
            _Error = True
            MsgBox(Validar, MsgBoxStyle.Critical, "Error")
            Return False
        End If
    End Function
    'Public Function Borrar() As Boolean
    '    TipoProveedor.Estatus = Integra.Clases.EstatusEnum.INACTIVO
    '    Return TipoProveedor.Save
    'End Function

    'Public Function Guardar() As Boolean Implements Integra.Clases.IEntidad.Guardar
    '    Try
    '        If IsNothing(Validar) Then
    '            Return TipoProveedor.Save()
    '        Else
    '            _Error = True
    '            RaiseEvent MensajeError(Me, Validar)
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, ex.Message)
    '        Return False
    '    End Try
    'End Function


    Private Function Validar() As String
        Dim flt As Boolean = False
        Dim tmp As String = "Faltan los siguientes campos que son obligatorios:" & vbCrLf
        If Me.Descripcion.Replace(" ", "").Length = 0 Then
            flt = True
            tmp &= "Descripción." & vbCrLf
        End If
        If Me.DescripcionCorta.Replace(" ", "").Length = 0 Then
            flt = True
            tmp &= "Descripción Corta." & vbCrLf
        End If
        If Not flt Then tmp = Nothing
        Return tmp
    End Function

    'Public Sub LeerEntidad(ByVal Entidad As IntegraLab.ORM.EntityClasses.TipoProveedorEntity)
    '    TipoProveedor = Entidad
    'End Sub

    'Public Function ObtenerEntidad() As IntegraLab.ORM.EntityClasses.TipoProveedorEntity
    '    Return TipoProveedor
    'End Function
    'Este método se agregó para que en la forma de proveedores apareciera la descrpcion de el Tipo de proveedor.
    Public Overrides Function ToString() As String
        Return Descripcion
    End Function
#End Region

    Public Function Borrar1() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function



    Public Function Guardar() As Boolean Implements IEntidad.Guardar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            Return Me.Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.TipoProveedorEntity
        Return Me.Entity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.TipoProveedorEntity)
        Me.Entity = Entidad
    End Sub
End Class

Public Class TipoProveedorCollectionClass
    'Inherits System.ComponentModel.BindingList(Of TipoProveedorClass)
    'Implements System.ComponentModel.IComponent, System.ComponentModel.ISite
    'Inherits ColleccionBase(Of Integralab.ORM.EntityClasses.TipoProveedorEntity, Integralab.ORM.CollectionClasses.TipoProveedorCollection, TipoProveedorClass)
    Inherits CollectionClass(Of TipoProveedorClass)
    Private Coleccion As New CC.TipoProveedorCollection
    Private AgregarTodos As Boolean = False
    'Private C As New IntegraLab.ORM.CollectionClasses.TipoProveedorCollection

#Region "Métodos"
    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener() As Integer
        coleccion = New Integralab.ORM.CollectionClasses.TipoProveedorCollection
        Me.Clear()
        If coleccion.GetDbCount() > 0 Then
            coleccion.GetMulti(Nothing)
            RellenarMe(AgregarTodos)
        End If
        Return coleccion.Count
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As TipoProveedorClass
        coleccion = New Integralab.ORM.CollectionClasses.TipoProveedorCollection
        Me.Clear()
        Dim tp As New TipoProveedorClass
        If coleccion.GetDbCount(Integralab.ORM.HelperClasses.TipoProveedorFields.Codigo = Codigo) > 0 Then
            coleccion.GetMulti(Integralab.ORM.HelperClasses.TipoProveedorFields.Codigo = Codigo)
            tp = New TipoProveedorClass
            tp.LeerEntidad(coleccion(0))
        End If
        Return tp
    End Function
    Public Function Obtener(ByVal Estatus As Integra.Clases.EstatusEnum, Optional ByVal ConProveedores As Boolean = False) As Integer
        Try
            coleccion = New IntegraLab.ORM.CollectionClasses.TipoProveedorCollection
            Dim rel As New OC.RelationCollection
            Dim filtro As New OC.PredicateExpression
            rel.Add(EC.TipoProveedorEntity.Relations.ProveedorAvanzadoEntityUsingCodigoTipoProveedor, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            rel.Add(EC.ProveedorAvanzadoEntity.Relations.ProveedorEntityUsingCodigo, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            rel.Add(EC.ProveedorEntity.Relations.UsrCxpfacturasApagarEntityUsingIdProveedor, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

            Me.Clear()
            If Not IsNothing(Estatus) Then
                filtro.Add(HC.TipoProveedorFields.Estatus = Estatus)
                If ConProveedores = True Then
                    coleccion.GetMulti(filtro, rel)
                Else
                    coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(IntegraLab.ORM.HelperClasses.TipoProveedorFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
                End If
            Else
                coleccion.GetMulti(Nothing, 0, New OC.SortExpression(New OC.SortClause(IntegraLab.ORM.HelperClasses.TipoProveedorFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If
            Rellenar()
            Return coleccion.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
    Public Function ListadoClaves() As String()
        Dim lista As New List(Of String)
        For Each tp As TipoProveedorClass In Me
            lista.Add(tp.DescripcionCorta)
        Next
        Return lista.ToArray
    End Function
    'Se realizó este método para obtener por estatus ya sea activo e inactivo, con el próposito,
    'De que en la forma de proveedores en el list aparecieran solo los tipos de proveedores Activos.
    Public Function Obtener(ByVal Estatus As EstatusEnum, Optional ByVal AgregarTodos As Boolean = False) As Integer
        Me.AgregarTodos = AgregarTodos
        Coleccion = New Integralab.ORM.CollectionClasses.TipoProveedorCollection
        Me.Clear()
        If Not IsNothing(Estatus) Then
            If Coleccion.GetDbCount(Integralab.ORM.HelperClasses.TipoProveedorFields.Estatus = Estatus) > 0 Then
                Coleccion.GetMulti(Integralab.ORM.HelperClasses.TipoProveedorFields.Estatus = Estatus, 0, New OC.SortExpression(New OC.SortClause(Integralab.ORM.HelperClasses.TipoProveedorFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
                RellenarMe(AgregarTodos)
            End If
        Else
            Coleccion.GetMulti(Nothing)
            RellenarMe(AgregarTodos)
        End If
        Me.AgregarTodos = False
        Return Coleccion.Count
    End Function
    Public Function Obtener(ByVal condicion As String) As Integer
        Try
            Me.ClearItems()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If condicion = "" Then
                Me.coleccion.GetMulti(Nothing)
            Else
                filtro.Add(Integralab.ORM.HelperClasses.TipoProveedorFields.Descripcion Mod (String.Format("%{0}%", condicion)))
                Me.coleccion.GetMulti(filtro, 0, New OC.SortExpression(New OC.SortClause(Integralab.ORM.HelperClasses.TipoProveedorFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            End If
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.TipoProveedorEntity In Coleccion
            Add(New TipoProveedorClass(ente))
        Next
    End Sub
    Private Sub RellenarMe(ByVal AgregarTodos As Boolean)
        Me.Clear()
        If AgregarTodos Then
            Dim Tip As New TipoProveedorClass
            Tip.Descripcion = "TODOS"
            Me.Add(Tip)
        End If
        For Each e As Integralab.ORM.EntityClasses.TipoProveedorEntity In Coleccion
            Dim l As New TipoProveedorClass
            l.LeerEntidad(e)
            Me.Add(l)
        Next
    End Sub

    Public Function ObtenerColeccion() As Integralab.ORM.CollectionClasses.TipoProveedorCollection
        Return RellenarColeccion()
    End Function

    Private Function RellenarColeccion() As Integralab.ORM.CollectionClasses.TipoProveedorCollection
        Dim c As New IntegraLab.ORM.CollectionClasses.TipoProveedorCollection
        For Each tipo As TipoProveedorClass In Me
            Dim e As IntegraLab.ORM.EntityClasses.TipoProveedorEntity
            e = tipo.ObtenerEntidad
            c.Add(e)
        Next
        Return c
    End Function

    'Public Function Reporte() As rptTiposProveedores
    '    Dim Rep As New rptTiposProveedores
    '    Dim ds As New DSTiposProveedores
    '    For Each Elemento As TipoProveedorClass In Me
    '        ds.dtTipoProveedores.AdddtTipoProveedoresRow(Elemento.Codigo, Elemento.Descripcion, Elemento.DescripcionCorta, Elemento.Estatus.ToString)
    '    Next
    '    Rep.SetDataSource(ds)
    '    Return Rep
    'End Function

#End Region

    '#Region "ISite"
    '    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.ComponentModel.IComponent.Disposed
    '    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    '    Private m_cursite As System.ComponentModel.ISite
    '    Private m_component As System.ComponentModel.IComponent
    '    Private m_container As System.ComponentModel.IContainer
    '    Private m_designmode As Boolean = False
    '    Private m_Name As String
    '    Private m_getservice As System.IServiceProvider

    '    Public Property Site() As System.ComponentModel.ISite Implements System.ComponentModel.IComponent.Site
    '        Get
    '            Return m_cursite
    '        End Get
    '        Set(ByVal value As System.ComponentModel.ISite)
    '            m_cursite = value
    '        End Set
    '    End Property

    '    Public ReadOnly Property Component() As System.ComponentModel.IComponent Implements System.ComponentModel.ISite.Component
    '        Get
    '            Return m_component
    '        End Get
    '    End Property

    '    Public ReadOnly Property Container() As System.ComponentModel.IContainer Implements System.ComponentModel.ISite.Container
    '        Get
    '            Return m_container
    '        End Get
    '    End Property

    '    Public ReadOnly Property DesignMode() As Boolean Implements System.ComponentModel.ISite.DesignMode
    '        Get
    '            Return m_designmode
    '        End Get
    '    End Property

    '    Public Property Name() As String Implements System.ComponentModel.ISite.Name
    '        Get
    '            Return m_Name
    '        End Get
    '        Set(ByVal value As String)
    '            m_Name = ""
    '        End Set
    '    End Property

    '    Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
    '        Return m_getservice.GetService(serviceType)
    '    End Function

    '    Public Overrides Function GetHashCode() As Integer
    '        Return MyBase.GetHashCode()
    '    End Function

    '    ' IDisposable
    '    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
    '        If Not Me.disposedValue Then
    '            If disposing Then
    '                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
    '            End If

    '            ' TODO: Liberar recursos no administrados compartidos
    '        End If
    '        Me.disposedValue = True
    '    End Sub

    '#Region " IDisposable Support "
    '    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    '    Public Sub Dispose() Implements IDisposable.Dispose
    '        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
    '        Dispose(True)
    '        GC.SuppressFinalize(Me)
    '    End Sub
    '#End Region

    '#End Region

End Class
