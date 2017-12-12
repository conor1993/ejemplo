Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses


Public Class TipoCorralClass
    Inherits ClassBase(Of EC.McecatTiposCorralEntity)

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Entidad As EC.McecatTiposCorralEntity)
        MyBase.New(Entidad)
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New(New EC.McecatTiposCorralEntity(Codigo))
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property IdTipoCorral() As Integer
        Get
            Return entity.IdTipoCorral
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return entity.DescTipoCorral
        End Get
        Set(ByVal value As String)
            entity.DescTipoCorral = value
        End Set
    End Property

    Property DescCorta() As String
        Get
            Return entity.DescCorTipoCorral
        End Get
        Set(ByVal value As String)
            entity.DescCorTipoCorral = value
        End Set
    End Property

    Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return entity.Observaciones
        End Get
        Set(ByVal value As String)
            entity.Observaciones = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Estatus = EstatusEnum.INACTIVO

            Return Entity.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            Dim TC As New CC.McecatTiposCorralCollection
            If Entity.IsNew Then
                If TC.GetDbCount(HC.McecatTiposCorralFields.DescTipoCorral = Descripcion) > 0 Then
                    MessageBox.Show("Esta descripción ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                If TC.GetDbCount(HC.McecatTiposCorralFields.DescCorTipoCorral = DescCorta) > 0 Then
                    MessageBox.Show("Esta descripción corta ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                If TC.GetDbCount(Not HC.McecatTiposCorralFields.IdTipoCorral = IdTipoCorral And HC.McecatTiposCorralFields.DescTipoCorral = Descripcion) > 0 Then
                    MessageBox.Show("Esta descripción ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                If TC.GetDbCount(Not HC.McecatTiposCorralFields.IdTipoCorral = IdTipoCorral And HC.McecatTiposCorralFields.DescCorTipoCorral = DescCorta) > 0 Then
                    MessageBox.Show("Esta descripción corta ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If

            Return Entity.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
#End Region

End Class

Public Class TipoCorralColecttionClass
    Inherits ColleccionBase(Of EC.McecatTiposCorralEntity, CC.McecatTiposCorralCollection, TipoCorralClass)

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEstatusEnum) As Integer
        Try
            Dim filtro As New ORM.PredicateExpression

            If Not fcEstatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.McecatTiposCorralFields.Estatus = fcEstatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function Reporte() As RptCatTipoCorral
        Dim Reportes As New RptCatTipoCorral
        Dim ds As New DataSet
        Dim dtTipoCorrales As New DSetCatTipoCorral.dsTipoCorralDataTable
        For Each TipoCorrales As TipoCorralClass In Me
            dtTipoCorrales.AdddsTipoCorralRow(TipoCorrales.IdTipoCorral, TipoCorrales.Descripcion, TipoCorrales.DescCorta, TipoCorrales.Estatus.ToString())
        Next
        ds.Tables.Add(dtTipoCorrales)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class
