Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms

Public Class AgrupadorSAT
    Inherits ClassBase(Of EC.SatAgrupadorEntity)
#Region "Constructores"
    Sub New()
        'MyBase.New()
        Entity = New EC.SatAgrupadorEntity

    End Sub

    Sub New(ByVal CodAgrupador As Integer)
        'MyBase.New()
        Entity = New EC.SatAgrupadorEntity(CodAgrupador)
    End Sub

    Sub New(ByVal entidad As EC.SatAgrupadorEntity)
        'MyBase.New()
        Entity = entidad
    End Sub
#End Region

#Region "Propiedades"
    Public Property CodAgrupador() As String
        Get
            Return Entity.CodAgrupador
        End Get
        Set(ByVal value As String)
            Entity.CodAgrupador = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return Entity.NombreCuenta
        End Get
        Set(ByVal value As String)
            Entity.NombreCuenta = value
        End Set
    End Property

    Public ReadOnly Property CodDescripcion() As String
        Get
            Return Entity.CodAgrupador.ToString() + " " + Entity.NombreCuenta
        End Get

    End Property

    Public Property Nivel() As Integer
        Get
            Return Entity.Nivel
        End Get
        Set(ByVal value As Integer)
            Entity.Nivel = value
        End Set
    End Property


#End Region

#Region "Metodos"
    Public Function Obtener(ByVal CodAgrupador As String) As Boolean
        Return Entity.FetchUsingPK(CodAgrupador)
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Not Entity.IsNew Then
                Trans.Add(Entity)
                If Entity.Delete() Then
                    'Trans.Commit()
                    Return True
                End If
            Else

                Trans.Add(Entity)
                If Entity.Delete() Then
                    'Trans.Commit()
                    Return True
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction, Optional ByVal Referencia As Boolean = False, Optional ByVal AcuCuentaCont As EC.AcumuladoCuentasContablesEntity = Nothing) As Boolean
        ' Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cuentas")
        Try
            If Not Entity.IsNew Then
                Trans.Add(Entity)
                If Entity.Save() Then
                    'Trans.Commit()
                    Return True
                End If
            Else

                Trans.Add(Entity)
                If Entity.Save() Then
                    'Trans.Commit()
                    Return True
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class

Public Class AgrupadorSATColClass
    Inherits ColleccionBase(Of EC.SatAgrupadorEntity, CC.SatAgrupadorCollection, AgrupadorSAT)

    Private col As New CC.SatAgrupadorCollection

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.SatAgrupadorCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub

    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.SatAgrupadorEntity In col
            Dim n As New AgrupadorSAT(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.SatAgrupadorCollection
        Return col
    End Function

End Class

