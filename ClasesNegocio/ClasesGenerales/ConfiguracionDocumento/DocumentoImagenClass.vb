Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DocumentoImagenClass
    Inherits EC.DocumentoImagenEntity

#Region "Miembros Privados"

    Private _DocumentosDetalles As DocumentoDetalleCollectionClass
    Private _Documentos As DocumentoCollectionClass

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdDocumentoImagen As Integer)
        Me.FetchUsingPK(IdDocumentoImagen)
    End Sub

    Sub New(ByVal Entidad As EC.DocumentoImagenEntity)
        If Not Entidad.IsNew Then Me.FetchUsingPK(IdDocumentoImagen)

        If Entidad.IsDirty Then
            Me.Descripcion = Entidad.Descripcion
            Me.Imagen = Entidad.Imagen
        End If
    End Sub

    Sub New(ByVal Descripcion As String, ByVal EsCampo As Boolean, ByVal Imagen() As Byte)
        Me.Descripcion = Descripcion
        Me.Imagen = Imagen
    End Sub

#End Region

#Region "Propiedades"

    Public Shadows ReadOnly Property IdDocumentoImagen() As Integer
        Get
            Return MyBase.IdDocumentoImagen
        End Get
    End Property

    Public ReadOnly Property DocumentosDetalles() As DocumentoDetalleCollectionClass
        Get
            If _DocumentosDetalles Is Nothing Then
                Dim DetallesCol As New CC.DocumentoDetalleCollection

                _DocumentosDetalles = New DocumentoDetalleCollectionClass()
                DetallesCol.GetMulti(HC.DocumentoDetalleFields.EsImagen = True And HC.DocumentoDetalleFields.IdDocumentoDato = Me.IdDocumentoImagen)

                For Each DocumentoDetalle As EC.DocumentoDetalleEntity In DetallesCol
                    _DocumentosDetalles.Add(DocumentoDetalle)
                Next
            End If
            Return _DocumentosDetalles
        End Get
    End Property

    Public ReadOnly Property Documentos() As DocumentoCollectionClass
        Get
            If _Documentos Is Nothing Then
                _Documentos = New DocumentoCollectionClass

                For Each DocumentoDetalle As DocumentoDetalleClass In Me.DocumentosDetalles
                    If _Documentos.IndexOf(DocumentoDetalle.IdDocumento) = -1 Then
                        _Documentos.Add(DocumentoDetalle.DocumentoCabecero)
                    End If
                Next
            End If
            Return _Documentos
        End Get
    End Property

#End Region

#Region "Metodos Publicos"

#End Region

End Class

Public Class DocumentoImagenCollectionClass
    Inherits ColleccionBase(Of DocumentoImagenClass)

End Class
