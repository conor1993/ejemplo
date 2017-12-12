Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DocumentoDetalleClass
    Inherits EC.DocumentoDetalleEntity

#Region "Miembros Privados"

    Private _DocumentoCabecero As DocumentoClass
    Private _DocumentoImagen As DocumentoImagenClass
    Private _DocumentoTexto As DocumentoTextClass

#End Region

#Region "Contructores"

    Sub New()

    End Sub

    Sub New(ByVal IdDocumento As Integer, ByVal IdDocumentoDato As Integer)
        Me.FetchUsingPK(IdDocumento, IdDocumentoDetalle)
    End Sub

    Sub New(ByVal Entidad As EC.DocumentoDetalleEntity)
        Me.IdDocumento = Entidad.IdDocumentoDetalle
        Me.IdDocumentoDetalle = Entidad.IdDocumentoDetalle
        Me.IdDocumentoDato = Entidad.IdDocumentoDato
        Me.X = Entidad.X
        Me.Y = Entidad.Y
        Me.EsImagen = Entidad.EsImagen
        Me.IsNew = Entidad.IsNew
        Me.IsDirty = Entidad.IsDirty
    End Sub

    Sub New(ByVal IdDocumento As Integer, ByVal IdDocumentoDetalle As Integer, ByVal IdDocumentoDato As Integer, ByVal EsImagen As Boolean, ByVal X As Double, ByVal Y As Double)
        Me.IdDocumento = IdDocumento
        Me.IdDocumentoDetalle = IdDocumentoDetalle
        Me.IdDocumentoDato = IdDocumentoDato
        Me.EsImagen = EsImagen
        Me.X = X
        Me.Y = Y
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property DocumentoCabecero() As DocumentoClass
        Get
            If _DocumentoCabecero Is Nothing Then
                _DocumentoCabecero = New DocumentoClass(Me.IdDocumento)
            End If
            Return _DocumentoCabecero
        End Get
    End Property

    Public ReadOnly Property DocumentoImagen() As DocumentoImagenClass
        Get
            If Not Me.EsImagen Then
                _DocumentoImagen = Nothing
            Else
                If _DocumentoImagen Is Nothing Then
                    _DocumentoImagen = New DocumentoImagenClass(Me.IdDocumentoDato)
                End If
            End If
            Return _DocumentoImagen
        End Get
    End Property

    Public ReadOnly Property DocumentoTexto() As DocumentoTextClass
        Get
            If Me.EsImagen Then
                _DocumentoTexto = Nothing
            Else
                If _DocumentoTexto Is Nothing Then
                    _DocumentoTexto = New DocumentoTextClass(Me.IdDocumentoDato)
                End If
            End If
            Return _DocumentoTexto
        End Get
    End Property

#End Region

#Region "Metodos Publicos"

    Friend Sub EstablecerCabecero(ByRef Cabecero As DocumentoClass)
        _DocumentoCabecero = Cabecero
    End Sub

#End Region

End Class

Public Class DocumentoDetalleCollectionClass
    Inherits ColleccionBase(Of DocumentoDetalleClass)

#Region "Miembros"

    Dim _Cabecero As DocumentoClass

#End Region

#Region "Constructores"

    Sub New(ByRef Cabecero As DocumentoClass)
        _Cabecero = Cabecero
    End Sub

    Sub New()

    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Cabecero() As DocumentoClass
        Get
            Return _Cabecero
        End Get
    End Property

#End Region

#Region "Metodos"

    Protected Overrides Function AddNewCore() As Object
        Dim DocumentoDetalle As DocumentoDetalleClass = CType(MyBase.AddNewCore(), DocumentoDetalleClass)
        DocumentoDetalle.EstablecerCabecero(Cabecero)

        Return DocumentoDetalle
    End Function

    Public Shadows Sub Add(ByRef Entidad As DocumentoDetalleClass)
        Entidad.EstablecerCabecero(Cabecero)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByRef Entidad As EC.DocumentoDetalleEntity)
        Me.Add(New DocumentoDetalleClass(Entidad))
    End Sub

#End Region

End Class
