Imports System.Windows.Forms
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ConceptoGastosTransporteClass
    Inherits ClassBase(Of EC.McgcatConcepGastosEntity)

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs)
#End Region

#Region "Constructures"
    Public Sub New()
        Entity = New EC.McgcatConcepGastosEntity
    End Sub

    Sub New(ByVal Entidad As EC.McgcatConcepGastosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.McgcatConcepGastosEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property IdConceptoGasto() As Integer
        Get
            Return Entity.IdConceptoGasto
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

    Public Property DescCorta() As String
        Get
            Return Entity.DescCorta
        End Get
        Set(ByVal value As String)
            Entity.DescCorta = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return CType(Entity.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property AplicaIVA() As Boolean
        Get
            Return Entity.AplicaIva
        End Get
        Set(ByVal value As Boolean)
            Entity.AplicaIva = value
        End Set
    End Property

    Public Property PorcentajeIVA() As Decimal
        Get
            Return Entity.PorcentajeIva
        End Get
        Set(ByVal value As Decimal)
            Entity.PorcentajeIva = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusEnum.INACTIVO

            Return Entity.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            Dim coleccion As New CC.McgcatConcepGastosCollection

            If Entity.IsNew Then
                Estatus = EstatusEnum.ACTIVO

                If coleccion.GetDbCount(HC.McgcatConcepGastosFields.Descripcion = Descripcion) > 0 Then
                    MessageBox.Show("La Descripion del Concepto de Gasto ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                If coleccion.GetDbCount(HC.McgcatConcepGastosFields.Descripcion = DescCorta) > 0 Then
                    MessageBox.Show("La Descripion Corta del Concepto de Gasto ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                If coleccion.GetDbCount(Not HC.McgcatConcepGastosFields.IdConceptoGasto = IdConceptoGasto And HC.McgcatConcepGastosFields.Descripcion = Descripcion) > 0 Then
                    MessageBox.Show("La Descripion del Concepto de Gasto ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                If coleccion.GetDbCount(Not HC.McgcatConcepGastosFields.IdConceptoGasto = IdConceptoGasto And HC.McgcatConcepGastosFields.Descripcion = DescCorta) > 0 Then
                    MessageBox.Show("La Descripion Corta del Concepto de Gasto ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If

            Return Entity.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
#End Region
End Class