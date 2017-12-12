Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ConfigImpresionChequeClass
    Inherits ClassBase(Of EC.ConfiguracionChequesImpEntity)
    Dim _Banco As BancosClass

#Region "Constructores"
    Sub New()
        Entity = New EC.ConfiguracionChequesImpEntity
    End Sub

    Sub New(ByVal Entidad As EC.ConfiguracionChequesImpEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdConfig As Integer, ByVal IdBanco As Integer)
        Entity = New EC.ConfiguracionChequesImpEntity(idconfig, IdBanco)
    End Sub
#End Region

#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    Public Property IdBanco() As Integer
        Get
            Return Entity.IdBanco
        End Get
        Set(ByVal value As Integer)
            Entity.IdBanco = value
        End Set
    End Property

    Public ReadOnly Property NomBanco() As String
        Get
            If _Banco Is Nothing Then
                _Banco = New BancosClass(Me.IdBanco)
            End If
            Return _Banco.Descripcion
        End Get
    End Property

    Public Property FechaImpRen() As Integer
        Get
            Return Entity.FechaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.FechaImpRen = value
        End Set
    End Property

    Public Property FechaImpCol() As Integer
        Get
            Return Entity.FechaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.FechaImpCol = value
        End Set
    End Property

    Public Property BeneficiarioRen() As Integer
        Get
            Return Entity.BeneficiarioImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.BeneficiarioImpRen = value
        End Set
    End Property

    Public Property BeneficiarioCol() As Integer
        Get
            Return Entity.BeneficiarioImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.BeneficiarioImpCol = value
        End Set
    End Property

    Public Property ImporteRen() As Integer
        Get
            Return Entity.ImporteImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteImpRen = value
        End Set
    End Property

    Public Property ImporteCol() As Integer
        Get
            Return Entity.ImporteImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteImpCol = value
        End Set
    End Property

    Public Property ImpteLetraRen() As Integer
        Get
            Return Entity.ImporteConLetraImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteConLetraImpRen = value
        End Set
    End Property

    Public Property ImpteLetraCol() As Integer
        Get
            Return Entity.ImporteConLetraImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteConLetraImpCol = value
        End Set
    End Property

    Public Property FechaCopiaRen() As Integer
        Get
            Return Entity.FechaCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.FechaCopiaImpRen = value
        End Set
    End Property

    Public Property FechaCopiaCol() As Integer
        Get
            Return Entity.FechaCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.FechaCopiaImpCol = value
        End Set
    End Property

    Public Property BeneCopiaRen() As Integer
        Get
            Return Entity.BeneficiarioCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.BeneficiarioCopiaImpRen = value
        End Set
    End Property

    Public Property BeneCopiaCol() As Integer
        Get
            Return Entity.BeneficiarioCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.BeneficiarioCopiaImpCol = value
        End Set
    End Property

    Public Property ImporteCopiaRen() As Integer
        Get
            Return Entity.ImporteCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteCopiaImpRen = value
        End Set
    End Property

    Public Property ImporteCopiaCol() As Integer
        Get
            Return Entity.ImporteCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteCopiaImpCol = value
        End Set
    End Property

    Public Property ImporteLetraCopiaRen() As Integer
        Get
            Return Entity.ImporteConLetraCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteConLetraCopiaImpRen = value
        End Set
    End Property

    Public Property ImporteLetraCopiaCol() As Integer
        Get
            Return Entity.ImporteConLetraCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ImporteConLetraCopiaImpCol = value
        End Set
    End Property

    Public Property CuentaRen() As Integer
        Get
            Return Entity.CuentaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.CuentaImpRen = value
        End Set
    End Property

    Public Property CuentaCol() As Integer
        Get
            Return Entity.CuentaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.CuentaImpCol = value
        End Set
    End Property

    Public Property SubCuentaCol() As Integer
        Get
            Return Entity.SubCtaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.SubCtaImpCol = value
        End Set
    End Property

    Public Property SubCuentaRen() As Integer
        Get
            Return Entity.SubCtaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.SubCtaImpRen = value
        End Set
    End Property

    Public Property SSubCuentaCol() As Integer
        Get
            Return Entity.SubSubCtaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.SubSubCtaImpCol = value
        End Set
    End Property

    Public Property SSubCuentaRen() As Integer
        Get
            Return Entity.SubSubCtaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.SubSubCtaImpRen = value
        End Set
    End Property

    Public Property SSSubCuentaCol() As Integer
        Get
            Return Entity.SubSubSubCtaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.SubSubSubCtaImpCol = value
        End Set
    End Property

    Public Property SSSubCuentaRen() As Integer
        Get
            Return Entity.SubSubSubCtaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.SubSubSubCtaImpRen = value
        End Set
    End Property

    Public Property DescripcionCol() As Integer
        Get
            Return Entity.DescripcionImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.DescripcionImpCol = value
        End Set
    End Property

    Public Property DescripcionRen() As Integer
        Get
            Return Entity.DescripcionImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.DescripcionImpRen = value
        End Set
    End Property

    Property CargoCol() As Integer
        Get
            Return Entity.CargoImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.CargoImpCol = value
        End Set
    End Property

    Public Property CargoRen() As Integer
        Get
            Return Entity.CargoImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.CargoImpRen = value
        End Set
    End Property

    Public Property AbonoCol() As Integer
        Get
            Return Entity.AbonoImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoImpCol = value
        End Set
    End Property

    Property AbonoRen() As Integer
        Get
            Return Entity.AbonoImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoImpRen = value
        End Set
    End Property

    Property AbonoACuentaCol() As Integer
        Get
            Return Entity.AbonoAcuentaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoAcuentaImpCol = value
        End Set
    End Property

    Property AbonoACuentaRen() As Integer
        Get
            Return Entity.AbonoAcuentaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoAcuentaImpRen = value
        End Set
    End Property

    Property ImpCuentaDetallada() As Boolean
        Get
            Return Entity.ImprimirCuentaDetallada
        End Get
        Set(ByVal value As Boolean)
            Entity.ImprimirCuentaDetallada = value
        End Set
    End Property

    Public Property ImpCuentaConcentrada() As Boolean
        Get
            Return Entity.ImprimirCuentaConcentrada
        End Get
        Set(ByVal value As Boolean)
            Entity.ImprimirCuentaConcentrada = value
        End Set
    End Property

    Public Property ConceptoCol() As Integer
        Get
            Return Entity.ConceptoImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ConceptoImpCol = value
        End Set
    End Property

    Public Property ConceptoRen() As Integer
        Get
            Return Entity.ConceptoImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ConceptoImpRen = value
        End Set
    End Property

    Public Property AbonoACuentaCopiaCol() As Integer
        Get
            Return Entity.AbonoAcuentaCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoAcuentaCopiaImpCol = value
        End Set
    End Property

    Public Property AbonoACuentaCopiaRen() As Integer
        Get
            Return Entity.AbonoAcuentaCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoAcuentaCopiaImpRen = value
        End Set
    End Property

    Public Property FolioCol() As Integer
        Get
            Return Entity.FolioChequeImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.FolioChequeImpCol = value
        End Set
    End Property

    Public Property FolioRen() As Integer
        Get
            Return Entity.FolioChequeImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.FolioChequeImpRen = value
        End Set
    End Property

    Public Property FolioCopiaCol() As Integer
        Get
            Return Entity.FolioChequeCopiaImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.FolioChequeCopiaImpCol = value
        End Set
    End Property

    Public Property FolioCopiaRen() As Integer
        Get
            Return Entity.FolioChequeCopiaImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.FolioChequeCopiaImpRen = value
        End Set
    End Property

    Public Property CargoTotalCol() As Integer
        Get
            Return Entity.CargoTotalImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.CargoTotalImpCol = value
        End Set
    End Property

    Public Property CargoTotalRen() As Integer
        Get
            Return Entity.CargoTotalImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.CargoTotalImpRen = value
        End Set
    End Property

    Public Property AbonoTotalCol() As Integer
        Get
            Return Entity.AbonoTotalImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoTotalImpCol = value
        End Set
    End Property

    Public Property AbonoTotalRen() As Integer
        Get
            Return Entity.AbonoTotalImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.AbonoTotalImpRen = value
        End Set
    End Property

    Public Property BancoCol() As Integer
        Get
            Return Entity.BancoImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.BancoImpCol = value
        End Set
    End Property

    Public Property BancoRen() As Integer
        Get
            Return Entity.BancoImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.BancoImpRen = value
        End Set
    End Property

    Public Property CuentaBancoCol() As Integer
        Get
            Return Entity.CuentaBancoImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.CuentaBancoImpCol = value
        End Set
    End Property

    Public Property CuentaBancoRen() As Integer
        Get
            Return Entity.CuentaBancoImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.CuentaBancoImpRen = value
        End Set
    End Property

    Public Property ChequeCol() As Integer
        Get
            Return Entity.ChequeImpCol
        End Get
        Set(ByVal value As Integer)
            Entity.ChequeImpCol = value
        End Set
    End Property

    Property ChequeRen() As Integer
        Get
            Return Entity.ChequeImpRen
        End Get
        Set(ByVal value As Integer)
            Entity.ChequeImpRen = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer, ByVal IdBanco As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo, IdBanco)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class


Public Class ConfigImpresionChequesCollectionClass
    Inherits ColleccionBase(Of EC.ConfiguracionChequesImpEntity, CC.ConfiguracionChequesImpCollection, ConfigImpresionChequeClass)

    Public Overloads Function Obtener(ByVal Codigo As Integer) As Integer
        Try
            'coleccion.Clear()
            'coleccion.GetMulti(HC.ConfiguracionChequesImpFields.Codigo = Codigo)
            'Rellenar()
            'Return Count
            Dim filtro As New OC.PredicateExpression

            If Not Codigo = 0 Then _
                filtro.Add(HC.ConfiguracionChequesImpFields.Codigo = Codigo)

            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class