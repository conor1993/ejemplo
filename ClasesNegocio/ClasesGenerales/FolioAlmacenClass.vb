Imports System.Windows.Forms
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FolioAlmacenClass

    Implements IEntidad

    Dim Folio As EC.MgcnfFoliadorAlmacenEntity

    Property LetraSerie() As String
        Get
            Return Folio.LetraSerie
        End Get
        Set(ByVal value As String)
            Folio.LetraSerie = value
        End Set
    End Property

    Property Año() As String
        Get
            Return Folio.Año
        End Get
        Set(ByVal value As String)
            Folio.Año = value
        End Set
    End Property

    Property Mes() As String
        Get
            Return Folio.Mes
        End Get
        Set(ByVal value As String)
            Folio.Mes = value
        End Set
    End Property

    Property Consecutivo() As Integer
        Get
            Return Folio.Consecutivo
        End Get
        Set(ByVal value As Integer)
            Folio.Consecutivo = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Sub New()
        Folio = New EC.MgcnfFoliadorAlmacenEntity
    End Sub

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.ActionProcedures.UspMgcnfFoliadorInvMovAlmacen(LetraSerie, Año, Mes, Consecutivo, trans) = 0 Then
                RaiseEvent MensajeError(Me, "No se pudo generar folio")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "No se pudo generar folio")
            Return False
        End Try
    End Function

    Public Function Guardar1() As Boolean

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function

End Class
