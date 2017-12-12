Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = integralab.orm.HelperClasses
Imports CC = integralab.orm.CollectionClasses
Imports EC = integralab.orm.EntityClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures

Public Class MotivoCancelacionClass
    Implements IEntidad


    Private Motivo As EC.MotivoCancelacionEntity
    Private _Detalles As MotivoCancelacionDetalleCollectionClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

#Region "propiedades"
    <System.ComponentModel.DisplayName("Código")> _
   Public ReadOnly Property Codigo() As Integer
        Get
            Return Motivo.IdMotivo
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Motivo.Descripcion
        End Get
        Set(ByVal value As String)
            Motivo.Descripcion = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Descripción Corta")> _
    Public Property DescripcionCorta() As String
        Get
            Return Motivo.DescripcionCorta
        End Get
        Set(ByVal value As String)
            Motivo.DescripcionCorta = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    <System.ComponentModel.DisplayName("Fecha de Alta")> _
    Public ReadOnly Property FechaAlta() As Date
        Get
            Return Motivo.FechaAlta
        End Get
    End Property

    <System.ComponentModel.DisplayName("Observaciones")> _
    Public Property Observaciones() As String
        Get
            Return Motivo.Observaciones
        End Get
        Set(ByVal value As String)
            Motivo.Observaciones = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Estatus")> _
    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            Return Motivo.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Motivo.Estatus = value
        End Set
    End Property

    Public Property Detalles() As MotivoCancelacionDetalleCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New MotivoCancelacionDetalleCollectionClass
                _Detalles.RellenarMe(Motivo.MotivosCancelacionDetalle)
            End If

            Return _Detalles
        End Get
        Set(ByVal value As MotivoCancelacionDetalleCollectionClass)
            _Detalles = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()
        Motivo = New EC.MotivoCancelacionEntity
    End Sub

    Sub New(ByVal Codigo As Integer)
        Motivo = New EC.MotivoCancelacionEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.MotivoCancelacionEntity)
        Motivo = Entidad
    End Sub
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            If SPA.MotivoCancelacionUsado(Codigo) = 0 Then
                MsgBox("No es posible inactivarla, por que ya esta usada", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Estatus = EstatusEnum.INACTIVO

            Return Motivo.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")
        Try
            If Detalles.Count = 0 Then
                MsgBox("Debe agregar modulos", MsgBoxStyle.Exclamation, "Sin Modulos")
                Return False
            End If

            Dim col As New CC.MotivoCancelacionCollection

            If Motivo.IsNew Then
                If col.GetDbCount(HC.MotivoCancelacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un motivo de cancelación con esa descripcion", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If col.GetDbCount(HC.MotivoCancelacionFields.DescripcionCorta = Me.DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un motivo de cancelación don esa descripción corta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Estatus = EstatusEnum.ACTIVO

                Trans.Add(Motivo)

                If Not Motivo.Save Then
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Dim coldet As CC.MotivoCancelacionDetalleCollection = Detalles.ObtenerColeccion

                Trans.Add(coldet)

                If coldet.SaveMulti = 0 Then
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                Else
                    Trans.Commit()
                    Return True
                End If
            Else
                If col.GetDbCount(Not HC.MotivoCancelacionFields.IdMotivo = Codigo And HC.MotivoCancelacionFields.Descripcion = Descripcion) > 0 Then
                    MsgBox("Ya existe un motivo de cancelación con esa descripcion", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                If col.GetDbCount(Not HC.MotivoCancelacionFields.IdMotivo = Codigo And HC.MotivoCancelacionFields.DescripcionCorta = Me.DescripcionCorta) > 0 Then
                    MsgBox("Ya existe un motivo de cancelación don esa descripción corta", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Trans.Add(Motivo)

                If Not Motivo.Save Then
                    Trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Dim coldet As New CC.MotivoCancelacionDetalleCollection

                Trans.Add(coldet)

                coldet.GetMulti(HC.MotivoCancelacionDetalleFields.Idmotivo = Codigo)

                Dim encontro As Boolean = False
                For Each ente As EC.MotivoCancelacionDetalleEntity In coldet
                    encontro = False
                    For Each det As MotivoCancelacionDetalleClass In Detalles
                        If det.Modulo.Codigo = ente.Idmodulo And det.Motivo.Codigo = ente.Idmotivo Then
                            encontro = True
                            Detalles.Remove(det)
                            Exit For
                        End If
                    Next

                    If Not encontro Then
                        Trans.Add(ente)

                        If Not ente.Delete Then
                            Trans.Rollback()
                            MsgBox("No se logro guardar intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                            Return False
                        End If
                    End If
                Next

                If Detalles.Count = 0 Then
                    Trans.Commit()
                    Return True
                Else
                    Dim det As CC.MotivoCancelacionDetalleCollection = Detalles.ObtenerColeccion

                    Trans.Add(det)

                    If det.SaveMulti = 0 Then
                        Trans.Rollback()
                        MsgBox("No se logro guardar intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        Return False
                    Else
                        Trans.Commit()
                        Return True
                    End If
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If Motivo.FetchUsingPK(Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.MotivoCancelacionEntity)
        Me.Motivo = Entidad
    End Sub

    Public Function ObtenerEntidad() As Integralab.ORM.EntityClasses.MotivoCancelacionEntity
        Return Me.Motivo
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class MotivoCancelacionDetalleClass
    Implements IEntidad


    Private Detalle As EC.MotivoCancelacionDetalleEntity
    Private _Modulo As ModuloClass
    Private _Motivo As MotivoCancelacionClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

#Region "Propiedades"
    Public Property Motivo() As MotivoCancelacionClass
        Get
            If _Motivo Is Nothing Then
                _Motivo = New MotivoCancelacionClass
                _Motivo.LeerEntidad(Detalle.MotivosCancelacion)
            End If

            Return _Motivo
        End Get
        Set(ByVal value As MotivoCancelacionClass)
            _Motivo = value
            Detalle.MotivosCancelacion = value.ObtenerEntidad
        End Set
    End Property

    Public Property Modulo() As ModuloClass
        Get
            If _Modulo Is Nothing Then
                _Modulo = New ModuloClass
                _Modulo.LeerEntidad(Detalle.Modulo)
            End If

            Return _Modulo
        End Get
        Set(ByVal value As ModuloClass)
            _Modulo = value
            Detalle.Modulo = value.ObtenerEntidad
        End Set
    End Property

    Private Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Guardar() As Boolean

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try

        Catch ex As Exception

        End Try
    End Function

    Public Function Obtener(ByVal CodigoMotivo As Integer, ByVal CodigoModulo As Integer) As Boolean
        Try
            Return Detalle.FetchUsingPK(CodigoMotivo, CodigoModulo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function ObtenerEntidad() As EC.MotivoCancelacionDetalleEntity
        Return Detalle
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.MotivoCancelacionDetalleEntity)
        Detalle = Entidad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Modulo.Descripcion
    End Function

#End Region

#Region "Contructores"
    Sub New()
        Detalle = New EC.MotivoCancelacionDetalleEntity
    End Sub

    Sub New(ByVal CodigoMotivo As Integer, ByVal CodigoModulo As Integer)
        Detalle = New EC.MotivoCancelacionDetalleEntity(CodigoMotivo, CodigoModulo)
    End Sub

    Sub New(ByVal Entidad As EC.MotivoCancelacionDetalleEntity)
        Detalle = Entidad
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class