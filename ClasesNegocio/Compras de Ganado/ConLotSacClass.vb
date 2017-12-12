Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ConLotSacClass
    Inherits EC.ConLotSacEntity

#Region "Miembros"
    Private _SalidaGanadoRastro As SalidaGanadoCabeceroClass = Nothing
#End Region

#Region "Constructores"
    Sub New(ByVal IdSalidaGanadoRastro As Integer, ByVal RemanenteCabezas As Integer, ByVal RemanenteKilos As Decimal, ByVal CabezasSacrificadas As Integer, ByVal KilosSacrificados As Decimal)
        Me.IdSalidaGanadoRastro = IdSalidaGanadoRastro
        Me.RemanCabe = RemanenteCabezas
        Me.RemanKilos = RemanenteKilos
        Me.SacrifCabe = CabezasSacrificadas
        Me.SacrifKilos = KilosSacrificados
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property SalidaGanadoRastro() As SalidaGanadoCabeceroClass
        Get
            If _SalidaGanadoRastro Is Nothing OrElse _SalidaGanadoRastro.IdSalidaGanadoCab <> Me.IdSalidaGanadoRastro Then
                _SalidaGanadoRastro = New SalidaGanadoCabeceroClass(Me.SalidaGanadoCab)
            End If
            Return _SalidaGanadoRastro
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me)
        Me.Save()
    End Sub
#End Region

End Class
