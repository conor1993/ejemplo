Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ConfiguracionFacturaClass
    Inherits ClassBase(Of EC.ConfiguracionFacturaEntity)

#Region "Miembros"

    Dim _Func As String
    Dim _NumOpc As Integer

#End Region

#Region "Constructores"

    Public Sub New()
        Me.Entity = New EC.ConfiguracionFacturaEntity
    End Sub

    Public Sub New(ByVal IdConfiguracionFactura As Integer)
        Me.Entity = New EC.ConfiguracionFacturaEntity(IdConfiguracionFactura)
    End Sub

    Public Sub New(ByVal Entidad As EC.ConfiguracionFacturaEntity)
        MyBase.New(Entidad)
    End Sub

#End Region

#Region "Propiedades"

    Public Property LetrasXrenglonDelTotalEnLetraPagare() As Integer
        Get
            Return Entity.LetrasXrenglonDelTotalEnLetraPagare
        End Get
        Set(ByVal value As Integer)
            Entity.LetrasXrenglonDelTotalEnLetraPagare = value
        End Set
    End Property

    Public Property NumeroLetrasXFilaCantidadLetra() As Integer
        Get
            Return Entity.LetrasXrenglonDelTotalEnLetra
        End Get
        Set(ByVal value As Integer)
            Entity.LetrasXrenglonDelTotalEnLetra = value
        End Set
    End Property

    Public Property NumeroLetrasXFilaDomicilio() As Integer
        Get
            Return Entity.LetrasXrenglonDomicilio
        End Get
        Set(ByVal value As Integer)
            Entity.LetrasXrenglonDomicilio = value
        End Set
    End Property

    ReadOnly Property IdConfiguracion() As Integer
        Get
            Return Entity.IdConfiguracion
        End Get
    End Property

    Property Campo1X() As Integer
        Get
            Return Entity.Campo1X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo1X = value
        End Set
    End Property

    Property Campo1Y() As Integer
        Get
            Return Entity.Campo1Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo1Y = value
        End Set
    End Property

    Property Campo2X() As Integer
        Get
            Return Entity.Campo2X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo2X = value
        End Set
    End Property

    Property Campo2Y() As Integer
        Get
            Return Entity.Campo2Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo2Y = value
        End Set
    End Property

    Property Campo3X() As Integer
        Get
            Return Entity.Campo3X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo3X = value
        End Set
    End Property

    Property Campo3Y() As Integer
        Get
            Return Entity.Campo3Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo3Y = value
        End Set
    End Property

    Property Campo4X() As Integer
        Get
            Return Entity.Campo4X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo4X = value
        End Set
    End Property

    Property Campo4Y() As Integer
        Get
            Return Entity.Campo4Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo4Y = value
        End Set
    End Property

    Property Campo5X() As Integer
        Get
            Return Entity.Campo5X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo5X = value
        End Set
    End Property

    Property Campo5Y() As Integer
        Get
            Return Entity.Campo5Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo5Y = value
        End Set
    End Property

    Property Campo6X() As Integer
        Get
            Return Entity.Campo6X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo6X = value
        End Set
    End Property

    Property Campo6Y() As Integer
        Get
            Return Entity.Campo6Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo6Y = value
        End Set
    End Property

    Property Campo7X() As Integer
        Get
            Return Entity.Campo7X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo7X = value
        End Set
    End Property

    Property Campo7Y() As Integer
        Get
            Return Entity.Campo7Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo7Y = value
        End Set
    End Property

    Property Campo8X() As Integer
        Get
            Return Entity.Campo8X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo8X = value
        End Set
    End Property

    Property Campo8Y() As Integer
        Get
            Return Entity.Campo8Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo8Y = value
        End Set
    End Property

    Property Campo9X() As Integer
        Get
            Return Entity.Campo9X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo9X = value
        End Set
    End Property

    Property Campo9Y() As Integer
        Get
            Return Entity.Campo9Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo9Y = value
        End Set
    End Property

    Property Campo10X() As Integer
        Get
            Return Entity.Campo10X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo10X = value
        End Set
    End Property

    Property Campo10Y() As Integer
        Get
            Return Entity.Campo10Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo10Y = value
        End Set
    End Property

    Property Campo11X() As Integer
        Get
            Return Entity.Campo11X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo11X = value
        End Set
    End Property

    Property Campo11Y() As Integer
        Get
            Return Entity.Campo11Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo11Y = value
        End Set
    End Property

    Property Campo12X() As Integer
        Get
            Return Entity.Campo12X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo12X = value
        End Set
    End Property

    Property Campo12Y() As Integer
        Get
            Return Entity.Campo12Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo12Y = value
        End Set
    End Property

    Property Campo13X() As Integer
        Get
            Return Entity.Campo13X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo13X = value
        End Set
    End Property

    Property Campo13Y() As Integer
        Get
            Return Entity.Campo13Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo13Y = value
        End Set
    End Property

    Property Campo14X() As Integer
        Get
            Return Entity.Campo14X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo14X = value
        End Set
    End Property

    Property Campo14Y() As Integer
        Get
            Return Entity.Campo14Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo14Y = value
        End Set
    End Property

    Property Campo15X() As Integer
        Get
            Return Entity.Campo15X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo15X = value
        End Set
    End Property

    Property Campo15Y() As Integer
        Get
            Return Entity.Campo15Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo15Y = value
        End Set
    End Property

    Property Campo16X() As Integer
        Get
            Return Entity.Campo16X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo16X = value
        End Set
    End Property

    Property Campo16Y() As Integer
        Get
            Return Entity.Campo16Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo16Y = value
        End Set
    End Property

    Property Campo17X() As Integer
        Get
            Return Entity.Campo17X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo17X = value
        End Set
    End Property

    Property Campo17Y() As Integer
        Get
            Return Entity.Campo17Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo17Y = value
        End Set
    End Property

    Property Campo18X() As Integer
        Get
            Return Entity.Campo18X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo18X = value
        End Set
    End Property

    Property Campo18Y() As Integer
        Get
            Return Entity.Campo18Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo18Y = value
        End Set
    End Property

    Property Campo19X() As Integer
        Get
            Return Entity.Campo19X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo19X = value
        End Set
    End Property

    Property Campo19Y() As Integer
        Get
            Return Entity.Campo19Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo19Y = value
        End Set
    End Property

    Property Campo20X() As Integer
        Get
            Return Entity.Campo20X
        End Get
        Set(ByVal value As Integer)
            Entity.Campo20X = value
        End Set
    End Property

    Property Campo20Y() As Integer
        Get
            Return Entity.Campo20Y
        End Get
        Set(ByVal value As Integer)
            Entity.Campo20Y = value
        End Set
    End Property

    Public Property DatosClienteCpC() As Integer
        Get
            Return Entity.DatosClienteCpC
        End Get
        Set(ByVal value As Integer)
            Entity.DatosClienteCpC = value
        End Set
    End Property

    Public Property DatosClienteCpR() As Integer
        Get
            Return Entity.DatosClienteCpR
        End Get
        Set(ByVal value As Integer)
            Entity.DatosClienteCpR = value
        End Set
    End Property

    Public Property DatosFacturaObsrvC() As Integer
        Get
            Return Entity.DatosFacturaObsrvC
        End Get
        Set(ByVal value As Integer)
            Entity.DatosFacturaObsrvC = value
        End Set
    End Property

    Public Property DatosFacturaObsrvR() As Integer
        Get
            Return Entity.DatosFacturaObsrvR
        End Get
        Set(ByVal value As Integer)
            Entity.DatosFacturaObsrvR = value
        End Set
    End Property

    Public Property LetrasxRenglonObsrv() As Integer
        Get
            Return Entity.LetrasxRenglonObsrv
        End Get
        Set(ByVal value As Integer)
            Entity.LetrasxRenglonObsrv = value
        End Set
    End Property

    Property Renglones() As Integer
        Get
            Return Entity.RenglonesEnDetalle
        End Get
        Set(ByVal value As Integer)
            Entity.RenglonesEnDetalle = value
        End Set
    End Property

    Property TamañoLetra() As Integer
        Get
            Return Entity.Tamaño
        End Get
        Set(ByVal value As Integer)
            Entity.Tamaño = value
        End Set
    End Property

    Property TipoLetra() As String
        Get
            Return Entity.TipoLetra
        End Get
        Set(ByVal value As String)
            Entity.TipoLetra = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return Entity.Serie
        End Get
        Set(ByVal value As String)
            Entity.Serie = value
        End Set
    End Property

    Public Property DatosFacturaReferenciaC() As Integer
        Get
            Return Entidad.DatosFacturaReferenciaC
        End Get
        Set(ByVal value As Integer)
            Entidad.DatosFacturaReferenciaC = value
        End Set
    End Property

    Public Property DatosFacturaReferenciaR() As Integer
        Get
            Return Entidad.DatosFacturaReferenciaR
        End Get
        Set(ByVal value As Integer)
            Entidad.DatosFacturaReferenciaR = value
        End Set
    End Property

    Public Property LetrasxRenglonReferencia() As Integer
        Get
            Return Entidad.LetrasxRenglonReferencia
        End Get
        Set(ByVal value As Integer)
            Entidad.LetrasxRenglonReferencia = value
        End Set
    End Property

    Public Property LetrasXrenglonCliente() As Integer
        Get
            Return Entity.LetrasXrenglonCliente
        End Get
        Set(ByVal value As Integer)
            Entity.LetrasXrenglonCliente = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Shadows Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            Return Entity.Save()
        Catch ex As Exception
            MsgBox("Error al guardar información de la caonfiguración de la factura", MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox("Error al consultar la configuración de factura", MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

#End Region

End Class

Public Class ConfiguracionFacturaCollectionClass
    Inherits ColleccionBase(Of EC.ConfiguracionFacturaEntity, CC.ConfiguracionFacturaCollection, ConfiguracionFacturaClass)

    
End Class