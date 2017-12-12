Imports IC = Integra.Clases
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CM = System.ComponentModel

Public Class CabBalanceClass
    Inherits ClassBase(Of EC.CabBalanceEntity)

    Dim _Detalle As DetBalanceCollectionClass
    Dim _Agrupador As CatAgrupadoresBalGralEdoResClass

#Region "Constructores"
    Sub New()
        Entity = New EC.CabBalanceEntity
    End Sub

    Sub New(ByVal Entidad As EC.CabBalanceEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdBalance As String)
        Entity = New EC.CabBalanceEntity(IdBalance)
    End Sub
#End Region

#Region "Propiedades"

    Public Property IdBalance() As String
        Get
            Return Entity.CveBalance
        End Get
        Set(ByVal value As String)
            Entity.CveBalance = Microsoft.VisualBasic.Right("000" & value, 3)
        End Set
    End Property

    'Public Property IdEmpresa() As Integer
    '    Get
    '        Return Entity.IdEmpresa
    '    End Get
    '    Set(ByVal value As Integer)
    '        Entity.IdEmpresa = value
    '    End Set
    'End Property

    Public Property Nombre() As String
        Get
            Return Entity.NomBalance
        End Get
        Set(ByVal value As String)
            Entity.NomBalance = value
        End Set
    End Property

    Public Property Saldo() As Decimal
        Get
            Return Entity.Saldo
        End Get
        Set(ByVal value As Decimal)
            Entity.Saldo = value
        End Set
    End Property

    Public Property IdAgrupador() As Integer
        Get
            Return Entity.IdAgrupador
        End Get
        Set(ByVal value As Integer)
            Entity.IdAgrupador = value
        End Set
    End Property

    Public ReadOnly Property Agrupador() As CatAgrupadoresBalGralEdoResClass
        Get
            If _Agrupador Is Nothing Then
                _Agrupador = New CatAgrupadoresBalGralEdoResClass(Me.IdAgrupador)
            End If
            Return _Agrupador
        End Get
    End Property

    Public Property Detalles() As DetBalanceCollectionClass
        Get
            If _Detalle Is Nothing Then
                If Entity.IsNew Then
                    _Detalle = New DetBalanceCollectionClass
                Else
                    _Detalle = New DetBalanceCollectionClass
                    _Detalle.RellenarMe(Me.Entity.DetBalance)
                End If
            End If
            Return _Detalle
        End Get
        Set(ByVal value As DetBalanceCollectionClass)
            _Detalle = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal IdBalance As String) As Boolean
        Return Entity.FetchUsingPK(IdBalance)
    End Function

    Public Sub CalcularSaldo(ByVal Trans As HC.Transaction, ByVal Mes As MesEnum2)
        Me.Saldo = 0D

        'For Each Detalle As DetBalanceClass In Me.Detalles
        '    Select Case Mes
        '        Case MesEnum2.ENERO
        'Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.EneroCargo, Detalle.Cuenta.EneroAbono)
        '        Case MesEnum2.FEBRERO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.FebreroCargo, Detalle.Cuenta.FebreroAbono)
        '        Case MesEnum2.MARZO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.MarzoCargo, Detalle.Cuenta.MarzoAbono)
        '        Case MesEnum2.ABRIL
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.AbrilCargo, Detalle.Cuenta.AbrilAbono)
        '        Case MesEnum2.MAYO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.MayoCargo, Detalle.Cuenta.MayoAbono)
        '        Case MesEnum2.JUNIO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.JunioCargo, Detalle.Cuenta.JunioAbono)
        '        Case MesEnum2.JULIO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.JulioCargo, Detalle.Cuenta.JulioAbono)
        '        Case MesEnum2.AGOSTO
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.AgostoCargo, Detalle.Cuenta.AgostoAbono)
        '        Case MesEnum2.SEPTIEMBRE
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.SeptiembreCargo, Detalle.Cuenta.SeptiembreAbono)
        '        Case MesEnum2.OCTUBRE
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.OctubreCargo, Detalle.Cuenta.OctubreAbono)
        '        Case MesEnum2.NOVIEMBRE
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.NoviembreCargo, Detalle.Cuenta.NoviembreAbono)
        '        Case MesEnum2.DICIEMBRE
        '            Detalle.Saldo = Detalle.Cuenta.CalcularSaldo(Detalle.Cuenta.DiciembreCargo, Detalle.Cuenta.DiciembreAbono)
        '    End Select

        '    If Detalle.SumaResta.ToString.Trim = "+" Then
        '        Me.Saldo += (Detalle.Saldo)
        '    Else
        '        Me.Saldo -= (Detalle.Saldo)
        '    End If
        '    Trans.Add(Detalle.Entidad)
        '    Detalle.Entidad.Save()
        'Next
        Trans.Add(Me.Entity)
        Me.Entity.Save()
    End Sub

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Entity.IsNew Then
                Dim Col As New CC.CabBalanceCollection
                If Col.GetDbCount(HC.CabBalanceFields.CveBalance = Me.IdBalance) > 1 Then
                    MsgBox("Ya existe un Estado Finaciero con este Número de Rubro", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Trans.Add(Entity)
                Entity.Save()

                For Each Det As DetBalanceClass In Me.Detalles
                    If Not Det Is Nothing Then
                        Det.Balance = Me
                    End If
                Next

                Dim ColDet As CC.DetBalanceCollection = Me.Detalles.ObtenerColeccion
                Trans.Add(ColDet)
                ColDet.SaveMulti()

                Return True

            Else
                Dim Col As New CC.CabBalanceCollection
                If Col.GetDbCount(HC.CabBalanceFields.CveBalance = Me.IdBalance) > 1 Then
                    MsgBox("Ya existe un Estado Finaciero con este Número de Rubro", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
                Trans.Add(Entity)
                Entity.Save()

                Dim ColBD As New CC.DetBalanceCollection
                ColBD.GetMulti(HC.DetBalanceFields.CveBalance = Me.IdBalance)

                Dim ColNva As CC.DetBalanceCollection = Me.Detalles.ObtenerColeccion
                Dim Encuentra As Boolean

                For Each EntiBd As EC.DetBalanceEntity In ColBD
                    Encuentra = False
                    For Each EntiNva As EC.DetBalanceEntity In ColNva
                        If EntiNva.CveCuentaContable = EntiBd.CveCuentaContable Then
                            Encuentra = True
                            If EntiNva.StaSumaResta = EntiBd.StaSumaResta And EntiNva.CveRenglon = EntiBd.CveRenglon Then
                                ColNva.Remove(EntiNva)
                            Else
                                EntiNva.IsNew = False
                                EntiNva.IsDirty = True
                            End If
                            Exit For
                        End If
                    Next
                    If Not Encuentra Then
                        Trans.Add(EntiBd)
                        If Not EntiBd.Delete Then
                            Return False
                        End If
                    End If
                Next

                If ColNva.Count > 0 Then
                    Trans.Add(ColNva)
                    ColNva.SaveMulti()
                    'If Not ColNva.SaveMulti Then
                    'Return False
                    ' End If
                End If

                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region

End Class