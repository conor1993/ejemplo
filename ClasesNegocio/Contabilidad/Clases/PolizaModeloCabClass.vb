Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class PolizaModeloCabClass
    Inherits ClassBase(Of EC.PolizasModeloCabEntity)

#Region "Miembros"
    Private WithEvents m_Detalle As PolizaModeloDetCollectionClass
    Private m_cta As PolizaModeloDetClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.PolizasModeloCabEntity()
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.PolizasModeloCabEntity(Codigo)
    End Sub

    Sub New(ByVal Entidad As EC.PolizasModeloCabEntity)
        Entity = Entidad
    End Sub
#End Region

#Region "Propiedad"
    Public ReadOnly Property IdPoliza() As Integer
        Get
            Return Entity.Codigo
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

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As PolizaModeloDetCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New PolizaModeloDetCollectionClass
                m_Detalle.RellenarMe(Entity.PolizasModeloDet)
            End If
            Return m_Detalle
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{0}", Me.Descripcion)
    End Function
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Nuevo As Boolean = False

            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            Else
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Poliza")
                Trans.Add(Entity)
                Nuevo = True
            End If

            For Each _detalle As PolizaModeloDetClass In Me.Detalle
                _detalle.Poliza = Me
            Next

            If Entity.IsNew Then
                Entity.Save(True)
            Else
                Dim TempPoliza As New PolizaModeloCabClass(Me.IdPoliza)

                For Each row As PolizaModeloDetClass In TempPoliza.Detalle
                    If Not CuentaModificada(row, Trans) Then
                        row.Borrar(Trans)
                    End If
                Next

                For Each row As PolizaModeloDetClass In Detalle
                    If row.Entidad.IsNew Then
                        row.Guardar(Trans)
                    Else
                        Dim nuevoDetalle As New PolizaModeloDetClass()
                        nuevoDetalle.IdPoliza = row.IdPoliza
                        nuevoDetalle.IdCuentaContable = row.IdCuentaContable
                        nuevoDetalle.CargoAbono = row.CargoAbono
                        nuevoDetalle.Guardar(Trans)
                    End If
                Next

                Entity.Save(False)
            End If

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function CuentaModificada(ByVal _detalle As PolizaModeloDetClass, ByVal Transaccion As HC.Transaction) As Boolean
        For Each row As PolizaModeloDetClass In Detalle
            If row.IdCuentaContable = _detalle.IdCuentaContable Then
                If row.CargoAbono <> _detalle.CargoAbono Then
                    row.Guardar(Transaccion)
                End If

                Detalle().Remove(row)
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Obtener(ByVal Id As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Id)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            Dim Nuevo As Boolean = False

            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            Else
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Poliza")
                Trans.Add(Entity)
                Nuevo = True
            End If

            'For Each _detalle As PolizaModeloDetClass In Detalle
            '_detalle.Borrar(Trans)
            'Next

            Estatus = EstatusEnum.INACTIVO
            Entity.Save()

            If Nuevo Then
                Trans.Commit()
            End If
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

#Region "Eventos"

#End Region
End Class
