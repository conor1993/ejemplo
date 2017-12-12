Imports EC = Integralab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms
Public Class AcumuladodeCuentasContablesClass
    Inherits ClassBase(Of EC.AcumuladoCuentasContablesEntity)
    Public Event Mensajes(ByVal sender As Object, ByVal Message As MensajeClass)

#Region "Constructores"
    Sub New()
        'MyBase.New()
        Entity = New EC.AcumuladoCuentasContablesEntity
       
    End Sub

    Sub New(ByVal Codigo As Integer, ByVal Ejercicio As Short)
        'MyBase.New()
        Entity = New EC.AcumuladoCuentasContablesEntity(Codigo, Ejercicio)
    End Sub

    Sub New(ByVal entidad As EC.AcumuladoCuentasContablesEntity)
        'MyBase.New()
        Entity = entidad
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
    Public Property Ejercicio() As Integer
        Get
            Return Entity.Ejercicio
        End Get
        Set(ByVal value As Integer)
            Entity.Ejercicio = value
        End Set
    End Property

    Public Property EneroAbono() As Decimal
        Get
            Return Entity.Abonos01
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos01 = value
        End Set
    End Property

    Public Property EneroCargo() As Decimal
        Get
            Return Entity.Cargos01
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos01 = value
        End Set
    End Property
    Public Property EneroPresupuesto() As Decimal
        Get
            Return Entity.Presup01
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup01 = value
        End Set
    End Property

    'Public ReadOnly Property EneroSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(EneroCargo, EneroAbono)
    '    End Get
    'End Property

    Public Property FebreroAbono() As Decimal
        Get
            Return Entity.Abonos02
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos02 = value
        End Set
    End Property

    Public Property FebreroCargo() As Decimal
        Get
            Return Entity.Cargos02
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos02 = value
        End Set
    End Property

    Public Property FebreroPresupuesto() As Decimal
        Get
            Return Entity.Presup02
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup02 = value
        End Set
    End Property

    'Public ReadOnly Property FebreroSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(FebreroCargo, FebreroAbono)
    '    End Get
    'End Property

    Public Property MarzoAbono() As Decimal
        Get
            Return Entity.Abonos03
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos03 = value
        End Set
    End Property

    Public Property MarzoCargo() As Decimal
        Get
            Return Entity.Cargos03
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos03 = value
        End Set
    End Property
    Public Property MarzoPresupuesto() As Decimal
        Get
            Return Entity.Presup03
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup03 = value
        End Set
    End Property
    'Public ReadOnly Property MarzoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(MarzoCargo, MarzoAbono)
    '    End Get
    'End Property

    Public Property AbrilAbono() As Decimal
        Get
            Return Entity.Abonos04
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos04 = value
        End Set
    End Property

    Public Property AbrilCargo() As Decimal
        Get
            Return Entity.Cargos04
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos04 = value
        End Set
    End Property
    Public Property AbrilPresupuesto() As Decimal
        Get
            Return Entity.Presup04
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup04 = value
        End Set
    End Property

    'Public ReadOnly Property AbrilSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(AbrilCargo, AbrilAbono)
    '    End Get
    'End Property

    Public Property MayoAbono() As Decimal
        Get
            Return Entity.Abonos05
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos05 = value
        End Set
    End Property

    Public Property MayoCargo() As Decimal
        Get
            Return Entity.Cargos05
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos05 = value
        End Set
    End Property
    Public Property MayoPresupuesto() As Decimal
        Get
            Return Entity.Presup05
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup05 = value
        End Set
    End Property
    'Public ReadOnly Property MayoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(MayoCargo, MayoAbono)
    '    End Get
    'End Property

    Public Property JunioAbono() As Decimal
        Get
            Return Entity.Abonos06
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos06 = value
        End Set
    End Property

    Public Property JunioCargo() As Decimal
        Get
            Return Entity.Cargos06
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos06 = value
        End Set
    End Property
    Public Property JunioPresupuesto() As Decimal
        Get
            Return Entity.Presup06
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup06 = value
        End Set
    End Property
    'Public ReadOnly Property JunioSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(JunioCargo, JunioAbono)
    '    End Get
    'End Property

    Public Property JulioAbono() As Decimal
        Get
            Return Entity.Abonos07
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos07 = value
        End Set
    End Property

    Public Property JulioCargo() As Decimal
        Get
            Return Entity.Cargos07
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos07 = value
        End Set
    End Property
    Public Property JulioPresupuesto() As Decimal
        Get
            Return Entity.Presup07
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup07 = value
        End Set
    End Property
    'Public ReadOnly Property JulioSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(JulioCargo, JulioAbono)
    '    End Get
    'End Property

    Public Property AgostoAbono() As Decimal
        Get
            Return Entity.Abonos08
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos08 = value
        End Set
    End Property

    Public Property AgostoCargo() As Decimal
        Get
            Return Entity.Cargos08
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos08 = value
        End Set
    End Property
    Public Property AgostoPresupuesto() As Decimal
        Get
            Return Entity.Presup08
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup08 = value
        End Set
    End Property
    'Public ReadOnly Property AgostoSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(AgostoCargo, AgostoAbono)
    '    End Get
    'End Property

    Public Property SeptiembreAbono() As Decimal
        Get
            Return Entity.Abonos09
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos09 = value
        End Set
    End Property

    Public Property SeptiembreCargo() As Decimal
        Get
            Return Entity.Cargos09
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos09 = value
        End Set
    End Property
    Public Property SeptiembrePresupuesto() As Decimal
        Get
            Return Entity.Presup09
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup09 = value
        End Set
    End Property
    'Public ReadOnly Property SeptiembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(SeptiembreCargo, SeptiembreAbono)
    '    End Get
    'End Property

    Public Property OctubreAbono() As Decimal
        Get
            Return Entity.Abonos10
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos10 = value
        End Set
    End Property

    Public Property OctubreCargo() As Decimal
        Get
            Return Entity.Cargos10
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos10 = value
        End Set
    End Property
    Public Property OctubrePresupuesto() As Decimal
        Get
            Return Entity.Presup10
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup10 = value
        End Set
    End Property
    'Public ReadOnly Property OctubreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(OctubreCargo, OctubreAbono)
    '    End Get
    'End Property

    Public Property NoviembreAbono() As Decimal
        Get
            Return Entity.Abonos11
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos11 = value
        End Set
    End Property

    Public Property NoviembreCargo() As Decimal
        Get
            Return Entity.Cargos11
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos11 = value
        End Set
    End Property
    Public Property NoviembrePresupuesto() As Decimal
        Get
            Return Entity.Presup11
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup11 = value
        End Set
    End Property
    'Public ReadOnly Property NoviembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(NoviembreCargo, NoviembreAbono)
    '    End Get
    'End Property

    Public Property DiciembreAbono() As Decimal
        Get
            Return Entity.Abonos12
        End Get
        Set(ByVal value As Decimal)
            Entity.Abonos12 = value
        End Set
    End Property

    Public Property DiciembreCargo() As Decimal
        Get
            Return Entity.Cargos12
        End Get
        Set(ByVal value As Decimal)
            Entity.Cargos12 = value
        End Set
    End Property
    Public Property DiciembrePresupuesto() As Decimal
        Get
            Return Entity.Presup12
        End Get
        Set(ByVal value As Decimal)
            Entity.Presup12 = value
        End Set
    End Property
    'Public ReadOnly Property DiciembreSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(DiciembreCargo, DiciembreAbono)
    '    End Get
    'End Property

    Public ReadOnly Property TotalAbono() As Decimal
        Get
            Return EneroAbono + FebreroAbono + MarzoAbono + AbrilAbono + MayoAbono + JunioAbono + JulioAbono + AgostoAbono + SeptiembreAbono + OctubreAbono + NoviembreAbono + DiciembreAbono
        End Get
    End Property

    Public ReadOnly Property TotalCargo() As Decimal
        Get
            Return EneroCargo + FebreroCargo + MarzoCargo + AbrilCargo + MayoCargo + JunioCargo + JulioCargo + AgostoCargo + SeptiembreCargo + OctubreCargo + NoviembreCargo + DiciembreCargo
        End Get
    End Property

    'Public ReadOnly Property TotalSaldo() As Decimal
    '    Get
    '        Return CalcularSaldo(TotalCargo, TotalAbono)
    '    End Get
    'End Property

    'Public Function CalcularSaldo(ByVal cargo As Decimal, ByVal abono As Decimal) As Decimal
    '    If Me.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
    '        Return abono - cargo
    '    Else
    '        Return cargo - abono
    '    End If
    'End Function
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Codigo As Integer, ByVal Ejercicio As Short) As Boolean
        Return Entity.FetchUsingPK(Codigo, Ejercicio)
    End Function

    Public Overrides Function Borrar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean

    End Function

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction, Optional ByVal Referencia As Boolean = False, Optional ByVal AcuCuentaCont As EC.AcumuladoCuentasContablesEntity = Nothing) As Boolean
        ' Dim tr As New HC.Transaction(IsolationLevel.ReadCommitted, "Cuentas")
        Try
            Dim cuentas As New CuentaContableCollectionClass

            If Not Entity.IsNew Then            

                Dim AcumuladosCol As New CC.AcumuladoCuentasContablesCollection
                AcumuladosCol.GetMulti(HC.AcumuladoCuentasContablesFields.Codigo = Entity.Codigo And HC.AcumuladoCuentasContablesFields.Ejercicio = Entity.Ejercicio)

                For Each item As EC.AcumuladoCuentasContablesEntity In AcumuladosCol
                    Trans.Add(item)

                    If item.Codigo = Entity.Codigo And item.Ejercicio = Entity.Ejercicio Then
                        'actualiza cargos
                        item.Cargos01 += Entity.Cargos01
                        item.Cargos02 += Entity.Cargos02
                        item.Cargos03 += Entity.Cargos03
                        item.Cargos04 += Entity.Cargos04
                        item.Cargos05 += Entity.Cargos05
                        item.Cargos06 += Entity.Cargos06
                        item.Cargos07 += Entity.Cargos07
                        item.Cargos08 += Entity.Cargos08
                        item.Cargos09 += Entity.Cargos09
                        item.Cargos10 += Entity.Cargos10
                        item.Cargos11 += Entity.Cargos11
                        item.Cargos12 += Entity.Cargos12
                        'actualiza abonos
                        item.Abonos01 += Entity.Abonos01
                        item.Abonos02 += Entity.Abonos02
                        item.Abonos03 += Entity.Abonos03
                        item.Abonos04 += Entity.Abonos04
                        item.Abonos05 += Entity.Abonos05
                        item.Abonos06 += Entity.Abonos06
                        item.Abonos07 += Entity.Abonos07
                        item.Abonos08 += Entity.Abonos08
                        item.Abonos09 += Entity.Abonos09
                        item.Abonos10 += Entity.Abonos10
                        item.Abonos11 += Entity.Abonos11
                        item.Abonos12 += Entity.Abonos12
                        'actualiza presupuestos
                        item.Presup01 += Entity.Presup01
                        item.Presup02 += Entity.Presup02
                        item.Presup03 += Entity.Presup03
                        item.Presup04 += Entity.Presup04
                        item.Presup05 += Entity.Presup05
                        item.Presup06 += Entity.Presup06
                        item.Presup07 += Entity.Presup07
                        item.Presup08 += Entity.Presup08
                        item.Presup09 += Entity.Presup09
                        item.Presup10 += Entity.Presup10
                        item.Presup11 += Entity.Presup11
                        item.Presup12 += Entity.Presup12
                    End If
                    item.Save()
                Next
                Trans.Commit()
                Return True
            Else
                
                Trans.Add(Entity)
                If Entity.Save() Then
                    Trans.Commit()
                    Return True
                End If
            End If
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    'Private Sub AplicarCambiosCuentasHijas(ByVal Cuenta As EC.CuentaContableEntity, ByRef transaccion As HC.Transaction)
    '    Try
    '        For Each hija As EC.CuentaContableEntity In Cuenta.CuentasHijas
    '            transaccion.Add(hija)
    '            hija.BooBancos = Entity.BooBancos
    '            hija.BooDepta = Entity.BooDepta
    '            hija.BooInactiva = Entity.BooInactiva
    '            hija.BooPresup = Entity.BooPresup
    '            hija.BooResultad = Entity.BooResultad
    '            hija.Naturaleza = Entity.Naturaleza
    '            If hija.Cta <> Cuenta.Cta And hija.SubCta <> "0000" Then hija.Cta = Cuenta.Cta
    '            If hija.SubCta <> Cuenta.SubCta And hija.SsubCta <> "0000" Then hija.SubCta = Cuenta.SubCta
    '            If hija.SsubCta <> Cuenta.SsubCta And hija.SssubCta <> "0000" Then hija.SsubCta = Cuenta.SsubCta
    '            hija.Save()
    '            AplicarCambiosCuentasHijas(hija, transaccion)
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Public Overrides Function ToString() As String
    '    Return String.Format("{0}:{1}", Me.NombreCuenta, Me.CuentaContable)
    'End Function

    'Public Function CalcularSaldo(ByVal cargo As Decimal, ByVal abono As Decimal) As Decimal
    '    If Me.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
    '        Return abono - cargo
    '    Else
    '        Return cargo - abono
    '    End If
    'End Function

    'Public Function CalcularSaldoInicial(ByVal FechaTope As Date, Optional ByVal ConSubCuentas As Boolean = False) As Decimal
    '    Dim PolizasDetalle As New CC.PolizaDetalleCollection
    '    Dim Relacion As New SC.RelationCollection()
    '    Dim Filtro As New SC.PredicateExpression()
    '    Dim Abonos As Decimal = 0D, Cargos As Decimal = 0D

    '    If ConSubCuentas Then
    '        Dim Cuentas As New CC.CuentaContableCollection()
    '        Dim FiltroCuenta As New SC.PredicateExpression(HC.CuentaContableFields.Cta = Me.CuentaMayor)
    '        Dim Lista As New List(Of Integer)

    '        If Me.SubCuenta <> "0000" Then
    '            FiltroCuenta.Add(HC.CuentaContableFields.SubCta = Me.SubCuenta)
    '        End If

    '        If Me.SSubCuenta = "0000" Then
    '            FiltroCuenta.Add(HC.CuentaContableFields.SsubCta = Me.SSubCuenta)
    '        End If

    '        If Me.SSSubCuenta = "0000" Then
    '            FiltroCuenta.Add(HC.CuentaContableFields.SssubCta = Me.SSSubCuenta)
    '        End If
    '        Cuentas.GetMulti(FiltroCuenta)

    '        If Cuentas.Count > 0 Then
    '            For Each cuenta As EC.CuentaContableEntity In Cuentas
    '                Lista.Add(cuenta.Codigo)
    '            Next
    '            Filtro.Add(New SC.FieldCompareRangePredicate(HC.PolizaDetalleFields.CuentaContableId, Lista))
    '            'Else
    '            'Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONTABILIDAD, "0")
    '        End If
    '    Else
    '        Filtro.Add(HC.PolizaDetalleFields.CuentaContableId = Me.Codigo)
    '    End If

    '    Filtro.Add(HC.PolizaFields.FechaPoliza <= FechaTope)
    '    Filtro.Add(HC.PolizaFields.Estatus = 2)
    '    Relacion.Add(EC.PolizaDetalleEntity.Relations.PolizaEntityUsingPolizaId)
    '    PolizasDetalle.GetMulti(Filtro, 0, Nothing, Relacion)

    '    For Each polizadet As EC.PolizaDetalleEntity In PolizasDetalle
    '        If polizadet.OperacionCa = "C" Then
    '            Cargos += polizadet.Importe
    '        Else
    '            Abonos += polizadet.Importe
    '        End If
    '    Next
    '    Return Me.CalcularSaldo(Cargos, Abonos)
    'End Function

    
#End Region


End Class
'''Coleccion de cuentas para acumulados
Public Class AcumuladodeCuentasContablesCollectionClass
    Inherits ColleccionBase(Of EC.AcumuladoCuentasContablesEntity, CC.AcumuladoCuentasContablesCollection, AcumuladodeCuentasContablesClass)

    Private col As New CC.AcumuladoCuentasContablesCollection

    Sub New()
        MyBase.New()
    End Sub
    Sub New(ByVal coleccion As CC.AcumuladoCuentasContablesCollection)
        MyBase.New()
        col = coleccion
        Rellenar()
    End Sub
   
    Private Sub Rellenar()
        Me.Clear()
        For Each e As EC.AcumuladoCuentasContablesEntity In col
            Dim n As New AcumuladodeCuentasContablesClass(e)
            Me.Add(n)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.AcumuladoCuentasContablesCollection
        Return col
    End Function
End Class
