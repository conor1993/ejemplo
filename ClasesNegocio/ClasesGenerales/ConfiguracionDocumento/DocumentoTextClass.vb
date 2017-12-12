Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DocumentoTextClass
    Inherits EC.DocumentoTextoEntity

#Region "Miembros Privados"

    Private _DocumentosDetalles As DocumentoDetalleCollectionClass
    Private _Documentos As DocumentoCollectionClass

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdDocumentoTexto As Integer)
        Me.FetchUsingPK(IdDocumentoTexto)
    End Sub

    Sub New(ByVal Entidad As EC.DocumentoTextoEntity)
        If Not Entidad.IsNew Then Me.FetchUsingPK(Entidad.IdDocumentoTexto)

        If Entidad.IsDirty Then
            Me.Descripcion = Entidad.Descripcion
        End If
    End Sub

    Sub New(ByVal Descripcion As String, ByVal EsCampo As Boolean, ByVal Texto As String, ByVal Fuente As String, ByVal TamanoFuente As Byte)
        Me.Descripcion = Descripcion
        Me.Texto = Texto
    End Sub

#End Region

#Region "Propiedades"

    Public Shadows ReadOnly Property IdDocumentoTexto() As Integer
        Get
            Return MyBase.IdDocumentoTexto
        End Get
    End Property

    Public ReadOnly Property DocumentosDetalles() As DocumentoDetalleCollectionClass
        Get
            If _DocumentosDetalles Is Nothing Then
                Dim DetallesCol As New CC.DocumentoDetalleCollection

                _DocumentosDetalles = New DocumentoDetalleCollectionClass()
                DetallesCol.GetMulti(HC.DocumentoDetalleFields.EsImagen = False And HC.DocumentoDetalleFields.IdDocumentoDato = Me.IdDocumentoTexto)

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

Public Class DocumentoTextCollectionClass
    Inherits ColleccionBase(Of DocumentoTextClass)

End Class
