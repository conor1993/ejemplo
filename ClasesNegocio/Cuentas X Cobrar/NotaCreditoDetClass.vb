Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TVC = IntegraLab.ORM.TypedViewClasses

Public Class NotaCreditoDetClass
    Inherits EC.NotaCreditoDetEntity

#Region "Miembros"
    Dim _NotaCredito As NotaCreditoCabClass
    Dim _Factura As FacturasClientesCabClass
    Dim _Seleccionado As Boolean
#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Entidad As EC.NotaCreditoDetEntity)
        Me.FolNota = Entidad.FolNota
        Me.FolFactura = Entidad.FolFactura
        Me.SubTotal = Entidad.SubTotal
        Me.ImpteIva = Entidad.ImpteIva
        Me.Total = Entidad.Total
        Me.Estatus = Entidad.Estatus
        Me.FecAplica = Entidad.FecAplica
        Me.Cheque = Entidad.Cheque
        Me.OrigenCta = Entidad.OrigenCta
        Me.Aplicar = Entidad.Aplicar
        Me.FolPago = Entidad.FolPago
    End Sub

    Sub New(ByVal FolNota As String, ByVal FolFactura As String, ByVal SubTotal As Decimal, ByVal ImpteIva As Decimal, ByVal Total As Decimal, ByVal Estatus As NotaCreditoEnum, ByVal FecAplica As Date, ByVal Cheque As String, ByVal OrigenCta As String, ByVal Observaciones As String, ByVal Aplicar As Boolean, ByVal FolPago As String)
        Me.FolNota = FolNota
        Me.FolFactura = FolFactura
        Me.SubTotal = SubTotal
        Me.ImpteIva = ImpteIva
        Me.Total = Total
        Me.Estatus = Estatus
        Me.FecAplica = FecAplica
        Me.Cheque = Cheque
        Me.OrigenCta = OrigenCta
        Me.Aplicar = Aplicar
        Me.FolPago = FolPago
    End Sub
#End Region

#Region "Propiedades"
    
    Property EstatusDescripcion() As NotaCreditoEnum
        Get
            Return CType(Estatus, NotaCreditoEnum)
        End Get
        Set(ByVal value As NotaCreditoEnum)
            Estatus = value
        End Set
    End Property

    ReadOnly Property Factura() As FacturasClientesCabClass
        Get
            If _Factura Is Nothing Then
                _Factura = New FacturasClientesCabClass(SerieFactura, FolFactura)
            End If
            Return _Factura
        End Get
    End Property

    ReadOnly Property NotaCredito() As NotaCreditoCabClass
        Get
            If _NotaCredito Is Nothing Then
                _NotaCredito = New NotaCreditoCabClass(Me.NotaCreditoCab)
            End If
            Return _NotaCredito
        End Get
    End Property

    ReadOnly Property ConceptoDescripcion() As String
        Get
            Return NotaCredito.Concepto.Descripcion
        End Get
    End Property

    ReadOnly Property FechaNota() As Date
        Get
            Return NotaCredito.FechaNota
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Folio As String, ByVal folFactura As String) As Boolean
        Try
            Return Me.FetchUsingPK(Folio, folFactura)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Shadows Sub Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction)
        If Not Trans Is Nothing Then
            Trans.Add(Me)
        End If
        Me.Save()
    End Sub

    Public Sub Cancelar(ByVal Trans As HC.Transaction)
        If Not Me.Aplicar Then
            Trans.Add(Me)
            Me.EstatusDescripcion = NotaCreditoEnum.CANCELADA
            Me.Save()
        Else
            Throw New Exception("La nota de credito ya esta aplicada" & Chr(13) & "Nota Folio:" & FolNota & Chr(13) & "Factura Folio:" & FolFactura)
        End If
    End Sub
#End Region

End Class