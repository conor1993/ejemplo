Imports IC = Integra.Clases
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports SC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class BalanceGeneralClass
    Inherits ClassBase(Of EC.CuentaContableEntity)
    Dim _CuentaContable As CuentaContableClass
    Dim _AcumCuentas As AcumuladodeCuentasContablesClass
    Dim _Saldo As Decimal
    Dim _IdCuentaContable As Integer
    Dim _Ejercicio As Integer



    Property Saldo() As Decimal
        Get
            Return _Saldo
        End Get
        Set(ByVal value As Decimal)
            _Saldo = value
        End Set
    End Property
    Property IdCuenta() As Integer
        Get
            Return _IdCuentaContable
        End Get
        Set(ByVal value As Integer)
            _IdCuentaContable = value
        End Set
    End Property
    Property Ejercicio() As Short
        Get
            Return _Ejercicio
        End Get
        Set(ByVal value As Short)
            _Ejercicio = value
        End Set
    End Property
    'sacar datos de la tabla de acumulados
    Public ReadOnly Property AcumuladosCC() As AcumuladodeCuentasContablesClass
        Get
            If _AcumCuentas Is Nothing Then
                _AcumCuentas = New AcumuladodeCuentasContablesClass(Me.IdCuenta, Me.Ejercicio)
            End If
            Return _AcumCuentas
        End Get
    End Property
    'sacar la cuenta contable
    Public ReadOnly Property CuentaContable() As CuentaContableClass
        Get
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass(Me.IdCuenta)
            End If
            Return _CuentaContable
        End Get
    End Property
    Public Sub CalcularSaldo(ByVal Mes As MesEnum2)
        Me.Saldo = 0D
        CuentaContable.Obtener(IdCuenta)
        AcumuladosCC.Obtener(IdCuenta, Ejercicio)
        Select Case Mes
            Case MesEnum2.ENERO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.EneroCargo, AcumuladosCC.EneroAbono)
            Case MesEnum2.FEBRERO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.FebreroCargo, AcumuladosCC.FebreroAbono)
            Case MesEnum2.MARZO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.MarzoCargo, AcumuladosCC.MarzoAbono)
            Case MesEnum2.ABRIL
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.AbrilCargo, AcumuladosCC.AbrilAbono)
            Case MesEnum2.MAYO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.MayoCargo, AcumuladosCC.MayoAbono)
            Case MesEnum2.JUNIO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.JunioCargo, AcumuladosCC.JunioAbono)
            Case MesEnum2.JULIO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.JulioCargo, AcumuladosCC.JulioAbono)
            Case MesEnum2.AGOSTO
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.AgostoCargo, AcumuladosCC.AgostoAbono)
            Case MesEnum2.SEPTIEMBRE
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.SeptiembreCargo, AcumuladosCC.SeptiembreAbono)
            Case MesEnum2.OCTUBRE
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.OctubreCargo, AcumuladosCC.OctubreAbono)
            Case MesEnum2.NOVIEMBRE
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.NoviembreCargo, AcumuladosCC.NoviembreAbono)
            Case MesEnum2.DICIEMBRE
                Saldo = CuentaContable.CalcularSaldo(AcumuladosCC.DiciembreCargo, AcumuladosCC.DiciembreAbono)
        End Select

        'If CuentaContable.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
        '    Me.Saldo += (Saldo)
        'Else
        '    Me.Saldo -= (Saldo)
        'End If

    End Sub
End Class


