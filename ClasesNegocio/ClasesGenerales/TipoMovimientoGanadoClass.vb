Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class TipoMovimientoGanadoClass
    Inherits ClassBase(Of EC.McgcatMovGanadoEntity)

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Entidad As EC.McgcatMovGanadoEntity)
        MyBase.New(Entidad)
    End Sub

    Sub New(ByVal codigo As Long)
        MyBase.New(New EC.McgcatMovGanadoEntity(codigo))
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property IdMovGanado() As Integer
        Get
            Return Entity.IdMovGanado
        End Get
    End Property

    Property Nombre() As String
        Get
            Return Entity.NombreMovGanado
        End Get
        Set(ByVal value As String)
            Entity.NombreMovGanado = value
        End Set
    End Property

    Property NomCorto() As String
        Get
            Return Entity.NomCorMovGanado
        End Get
        Set(ByVal value As String)
            Entity.NomCorMovGanado = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Property Salida() As Boolean
        Get
            Return Entity.Salida
        End Get
        Set(ByVal value As Boolean)
            Entity.Salida = value
        End Set
    End Property

    Property Estatus() As EstatusDatos
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Entity.Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusDatos.CANCELADO
            Return Entity.Save()
        Catch ex As Exception
            Estatus = EstatusDatos.VIGENTE
            Throw ex
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try
            Dim coleccion As New CC.McgcatMovGanadoCollection
            Dim mensajeError As String = ""

            If Entity.IsNew Then
                If coleccion.GetDbCount(HC.McgcatMovGanadoFields.NombreMovGanado = Nombre) > 0 Then
                    mensajeError = "La Descripion del Movimiento de Ganado ya Existe"
                End If

                If coleccion.GetDbCount(HC.McgcatMovGanadoFields.NomCorMovGanado = NomCorto) > 0 Then
                    mensajeError = "La Descripion Corta del Movimiento de Ganado ya Existe"
                End If
            Else
                If coleccion.GetDbCount(Not HC.McgcatMovGanadoFields.IdMovGanado = IdMovGanado And HC.McgcatMovGanadoFields.NombreMovGanado = Nombre) > 0 Then
                    mensajeError = "La Descripion del Movimiento de Ganado ya Existe"
                End If

                If coleccion.GetDbCount(Not HC.McgcatMovGanadoFields.IdMovGanado = IdMovGanado And HC.McgcatMovGanadoFields.NomCorMovGanado = NomCorto) > 0 Then
                    mensajeError = "La Descripion Corta del Movimiento de Ganado ya Existe"
                End If
            End If

            If Not mensajeError = "" Then Throw New Exception(mensajeError)

            Return Entity.Save
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean 'Implements IEntidad.Obtener
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function
#End Region
End Class

Public Class TipoMovimientoGanadoColeccionClass
    Inherits ColleccionBase(Of EC.McgcatMovGanadoEntity, CC.McgcatMovGanadoCollection, TipoMovimientoGanadoClass)

#Region "Miembros"

#End Region

#Region "Constructores"

#End Region

#Region "Metodos"

#Region "Consultas"

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not fcCondicion = CondicionEnum.TODOS Then filtro.Add(HC.McgcatMovGanadoFields.Estatus = fcCondicion)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not Descripcion = "" Then _
                filtro.Add(HC.McgcatMovGanadoFields.NombreMovGanado Mod String.Format("%{0}%", Descripcion))

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#End Region

#Region "Funcionalidad"

    Public Function Seleccionar(ByVal Nombre As String) As TipoMovimientoGanadoClass
        For Each tipo As TipoMovimientoGanadoClass In Me
            If tipo.Nombre = Nombre Then Return tipo
        Next

        Return Nothing
    End Function

    Public Function Seleccionar(ByVal Codigo As Integer) As TipoMovimientoGanadoClass
        For Each tipo As TipoMovimientoGanadoClass In Me
            If tipo.IdMovGanado = Codigo Then Return tipo
        Next

        Return Nothing
    End Function

    Public Function Reporte() As rptCatMovimientosGanado
        Dim Reportes As New rptCatMovimientosGanado
        Dim ds As New DataSet
        Dim dsCatMovimientosGanado As New DSetCatMovimientosGanado.dtMovimientosGanadoDataTable
        For Each MovimientosGanado As TipoMovimientoGanadoClass In Me
            dsCatMovimientosGanado.AdddtMovimientosGanadoRow(MovimientosGanado.IdMovGanado, MovimientosGanado.Nombre, MovimientosGanado.NomCorto, MovimientosGanado.Observaciones, MovimientosGanado.Salida, MovimientosGanado.Estatus.ToString())
        Next
        ds.Tables.Add(dsCatMovimientosGanado)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function
#End Region

#End Region
End Class