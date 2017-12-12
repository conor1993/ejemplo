Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class TipoGanadoClass
    Inherits ClassBase(Of EC.McgcatTiposdeGanadoEntity)

#Region "Propiedades"
    ReadOnly Property IdTipoGanado() As Integer
        Get
            Return entity.IdTipoGanado
        End Get
    End Property

    Property Descripcion() As String
        Get
            Return entity.Descripcion
        End Get
        Set(ByVal value As String)
            entity.Descripcion = value
        End Set
    End Property

    Property DescCorta() As String
        Get
            Return entity.DescCorta
        End Get
        Set(ByVal value As String)
            entity.DescCorta = value
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

    Property AcumuladoCabezas() As Integer
        Get
            Return entity.AcumuladoCabezas
        End Get
        Set(ByVal value As Integer)
            entity.AcumuladoCabezas = value
        End Set
    End Property

    Property AcumuladoKilos() As Decimal
        Get
            Return entity.AcumuladoKilos
        End Get
        Set(ByVal value As Decimal)
            entity.AcumuladoKilos = value
        End Set
    End Property

    Property FechaUltimaEntrada() As Date
        Get
            Return entity.FechaUltimaEntrada
        End Get
        Set(ByVal value As Date)
            entity.FechaUltimaEntrada = value
        End Set
    End Property

    Property FechaUltimaSalida() As Date
        Get
            Return entity.FechaUltimaSalida
        End Get
        Set(ByVal value As Date)
            entity.FechaUltimaSalida = value
        End Set
    End Property

    Property Estatus() As EstatusDatos
        Get
            Return entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            entity.Estatus = value
        End Set
    End Property

    Property Lados() As Short
        Get
            Return Me.entity.Lados
        End Get
        Set(ByVal value As Short)
            Me.entity.Lados = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean
        Try
            Entity.Estatus = EstatusDatos.CANCELADO
            Return Entity.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            Dim coleccion As New CC.McgcatTiposdeGanadoCollection

            If Entity.IsNew Then
                If coleccion.GetDbCount(HC.McgcatTiposdeGanadoFields.Descripcion = Descripcion) > 0 Then
                    MessageBox.Show("La Descripcion del Tipo de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If

                If coleccion.GetDbCount(HC.McgcatTiposdeGanadoFields.DescCorta = DescCorta) > 0 Then
                    MessageBox.Show("Nombre Corto del Tipo de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                If coleccion.GetDbCount(Not HC.McgcatTiposdeGanadoFields.IdTipoGanado = IdTipoGanado And HC.McgcatTiposdeGanadoFields.Descripcion = Descripcion) > 0 Then
                    MessageBox.Show("La Descripcion del Tipo de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                ElseIf coleccion.GetDbCount(Not HC.McgcatTiposdeGanadoFields.IdTipoGanado = IdTipoGanado And HC.McgcatTiposdeGanadoFields.DescCorta = DescCorta) > 0 Then
                    MessageBox.Show("Nombre Corto del Tipo de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If

            Return Entity.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region

#Region "Constructores"
    Sub New()
        entity = New EC.McgcatTiposdeGanadoEntity
    End Sub

    Sub New(ByVal Entidad As EC.McgcatTiposdeGanadoEntity)
        entity = Entidad
    End Sub

    Sub New(ByVal idTipoGanado As Integer)
        Entity = New EC.McgcatTiposdeGanadoEntity(idTipoGanado)
    End Sub
#End Region

    Public Shared Function CargarTipoGanado(ByVal IdTipoGanado As Integer) As TipoGanadoClass
        Dim _TipoGanado As New TipoGanadoClass()
        _TipoGanado.Obtener(IdTipoGanado)
        Return _TipoGanado
    End Function

End Class

Public Class TipoGanadoColecttionClass
    Inherits ColleccionBase(Of EC.McgcatTiposdeGanadoEntity, CC.McgcatTiposdeGanadoCollection, TipoGanadoClass)

    Public Overloads Function Obtener(ByVal Estatus As EstatusDatos) As Integer
        Try
            Return Obtener(HC.McgcatTiposdeGanadoFields.Estatus = Estatus, New ORM.SortExpression(New ORM.SortClause(HC.McgcatTiposdeGanadoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Dim filtro As New ORM.PredicateExpression

            If Not Descripcion = "" Then
                filtro.Add(HC.McgcatTiposdeGanadoFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal fcEstatus As CondicionEstatusEnum) As Integer
        Try
            Dim filtro As New ORM.PredicateExpression

            If Not fcEstatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.McecatCorralesCabFields.Estatus = fcEstatus)
            End If

            Return Obtener(filtro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function CargarTiposGanado(Optional ByVal Filtro As ORM.IPredicate = Nothing) As CC.McgcatTiposdeGanadoCollection
        Dim TiposGanado As New CC.McgcatTiposdeGanadoCollection

        Try
            TiposGanado.GetMulti(Filtro, 0, New ORM.SortExpression(New ORM.SortClause(HC.McgcatTiposdeGanadoFields.Descripcion, ORM.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return TiposGanado
    End Function

    Public Function Reporte() As ClasesNegocio.rptCatTipoGanado
        Dim Reportes As New rptCatTipoGanado
        Dim ds As New DataSet
        Dim dtTipoGanado As New DSetCatTipoGanado.dtTipoGanadoDataTable
        For Each TipoGanado As TipoGanadoClass In Me
            dtTipoGanado.AdddtTipoGanadoRow(TipoGanado.IdTipoGanado, TipoGanado.DescCorta, TipoGanado.Descripcion, TipoGanado.Lados, TipoGanado.Estatus)
        Next
        ds.Tables.Add(dtTipoGanado)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class