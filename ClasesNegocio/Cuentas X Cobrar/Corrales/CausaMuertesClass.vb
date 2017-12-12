Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CausaMuertesClass
    Implements IEntidad

    Dim CausaMuerte As New EC.McgcatCausasMuerteEntity
    'Dim _Func As String
    'Dim _NumOpc As Integer
    'Dim _CodCausaMuerte As Integer

#Region "Propiedades"
    ReadOnly Property IdCausaMuerte() As Integer
        Get
            Return CausaMuerte.IdCausaMuerte
        End Get
    End Property
    'Property CodCausaMuerte() As Integer
    '    Get
    '        Return _CodCausaMuerte
    '    End Get
    '    Set(ByVal value As Integer)
    '        _CodCausaMuerte = value
    '    End Set
    'End Property
    Property Descripcion() As String
        Get
            Return CausaMuerte.NombreCausaMuerte
        End Get
        Set(ByVal value As String)
            CausaMuerte.NombreCausaMuerte = value
        End Set
    End Property
    Property DescCorta() As String
        Get
            Return CausaMuerte.NomCorCausaMuerte
        End Get
        Set(ByVal value As String)
            CausaMuerte.NomCorCausaMuerte = value
        End Set
    End Property
    Property Observaciones() As String
        Get
            Return CausaMuerte.Observaciones
        End Get
        Set(ByVal value As String)
            CausaMuerte.Observaciones = value
        End Set
    End Property
    Property Estatus() As EstatusDatos
        Get
            Return CausaMuerte.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            CausaMuerte.Estatus = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            CausaMuerte.Estatus = EstatusEnum.INACTIVO
            Return CausaMuerte.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    'Public Function Guardar(ByRef trans As IntegraLab.ORM.HelperClasses.Transaction) As Boolean 
    '    'Try
    '    '    If SPA.UspMcgcatCausasMuerte(Descripcion, DescCorta, Observaciones, Estatus, Func, NumOpc, CodCausaMuerte, trans) = 0 Then
    '    '        RaiseEvent MensajeError(Me, "Error al guardar información de causa de muerte")
    '    '        Return False
    '    '    End If
    '    '    trans.Add(CausaMuerte)
    '    '    CausaMuerte.FetchUsingPK(CodCausaMuerte)
    '    '    Return True
    '    'Catch ex As Exception
    '    '    RaiseEvent MensajeError(Me, "Error al guardar información de causa de muerte")
    '    '    Return False
    '    'End Try

    'End Function

    Public Function ObtenerEntidad() As EC.McgcatCausasMuerteEntity
        Return CausaMuerte
    End Function

    Public Function Guardar() As Boolean
        Try
            Dim coleccion As New CC.McgcatCausasMuerteCollection
            If CausaMuerte.IsNew Then
                If coleccion.GetDbCount(HC.McgcatCausasMuerteFields.NombreCausaMuerte = Descripcion) > 0 Then
                    MessageBox.Show("El Nombre de la Causa de Muerte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
                If coleccion.GetDbCount(HC.McgcatCausasMuerteFields.NomCorCausaMuerte = DescCorta) > 0 Then
                    MessageBox.Show("Nombre Corto de la Causa de Muerte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                If coleccion.GetDbCount(Not HC.McgcatCausasMuerteFields.IdCausaMuerte = IdCausaMuerte And HC.McgcatCausasMuerteFields.NombreCausaMuerte = Descripcion) > 0 Then
                    MessageBox.Show("El Nombre de la Causa de Muerte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                ElseIf coleccion.GetDbCount(Not HC.McgcatCausasMuerteFields.IdCausaMuerte = IdCausaMuerte And HC.McgcatCausasMuerteFields.NomCorCausaMuerte = DescCorta) > 0 Then
                    MessageBox.Show("Nombre Corto de la Causa de Muerte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return CausaMuerte.Save
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            Return CausaMuerte.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region

#Region "Constructores"
    Sub New()
        CausaMuerte = New EC.McgcatCausasMuerteEntity
    End Sub

    Sub New(ByVal Entidad As EC.McgcatCausasMuerteEntity)
        CausaMuerte = Entidad
    End Sub

    Sub New(ByVal Codigo As Long)
        CausaMuerte = New EC.McgcatCausasMuerteEntity(Codigo)
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus1() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function

    Public Overrides Function ToString() As String
        Return Me.Descripcion
    End Function
End Class


Public Class CausaMuerteColecttionClass

    Inherits CollectionClass(Of CausaMuertesClass)
    Private WithEvents Coleccion As New CC.McgcatCausasMuerteCollection

    Public Function Obtener() As Integer
        Try
            Coleccion.GetMulti(Nothing, 0, Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Descripcion As String) As Integer
        Try
            Me.Clear()
            If Not Descripcion = "" Then
                Coleccion.GetMulti(HC.McgcatCausasMuerteFields.NombreCausaMuerte Mod String.Format("%{0}%", Descripcion))
            Else
                Coleccion.GetMulti(Nothing)
            End If
            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Reporte() As rptCatCausaMuertes
        Dim Reportes As New rptCatCausaMuertes
        Dim ds As New DataSet
        Dim dtCausaMuertes As New DSetCatCausaMuertes.dtCausaMuertesDataTable
        For Each CausaMuertes As CausaMuertesClass In Me
            dtCausaMuertes.AdddtCausaMuertesRow(CausaMuertes.IdCausaMuerte, CausaMuertes.DescCorta, CausaMuertes.Descripcion, CausaMuertes.Observaciones, CausaMuertes.Estatus.ToString)
        Next
        ds.Tables.Add(dtCausaMuertes)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

#Region "Código de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each ente As EC.McgcatCausasMuerteEntity In Coleccion
            Add(New CausaMuertesClass(ente))
        Next
    End Sub

    Public Sub RellenarMe(ByVal Collection As CC.McgcatCausasMuerteCollection)
        Coleccion = Collection
        Rellenar()
    End Sub

    Private Sub RellenarColeccion()
        Coleccion.Clear()
        For Each entc As CausaMuertesClass In Me
            Coleccion.Add(entc.ObtenerEntidad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.McgcatCausasMuerteCollection
        RellenarColeccion()
        Return Coleccion
    End Function
#End Region

End Class
