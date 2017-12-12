Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class EstadoResultadoClass
    Inherits ClassBase(Of EC.CabEdoResEntity)

#Region "Miembros"
    Private WithEvents m_Detalle As EstadoResultadoDetalleCollectionClas
#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal idEstadoResultado As String)
        Entity = New EC.CabEdoResEntity(idEstadoResultado)
    End Sub

    Sub New(ByVal entidad As EC.CabEdoResEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    Public Property Rubro() As String
        Get
            Return Entity.CveEdoRes
        End Get
        Set(ByVal value As String)
            Entity.CveEdoRes = value
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.NomEdoRes
        End Get
        Set(ByVal value As String)
            Entity.NomEdoRes = value
        End Set
    End Property

    <ComponentModel.DisplayName("Categoría")> _
    Public Property IdAgrupador() As Integer
        Get
            Return Entity.IdAgrupador
        End Get
        Set(ByVal value As Integer)
            Entity.IdAgrupador = value
        End Set
    End Property

    <ComponentModel.DisplayName("Saldo Mes")> _
    Public Property SaldoMes() As Decimal
        Get
            Return Entity.SaldoMes
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoMes = value
        End Set
    End Property

    <ComponentModel.DisplayName("Saldo Acumulado")> _
    Public Property SaldoAcumulado() As Decimal
        Get
            Return Entity.SaldoAcum
        End Get
        Set(ByVal value As Decimal)
            Entity.SaldoAcum = value
        End Set
    End Property

    Public Property Detalle() As EstadoResultadoDetalleCollectionClas
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New EstadoResultadoDetalleCollectionClas
                m_Detalle.RellenarMe(Entity.DetEdoRes)
            End If

            Return m_Detalle
        End Get
        Private Set(ByVal value As EstadoResultadoDetalleCollectionClas)
            m_Detalle = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Protected Overrides Function ValidarGuardar() As Boolean
        Dim col As New CC.CabEdoResCollection

        If Entity.IsNew Then
            If col.GetDbCount(HC.CabEdoResFields.CveEdoRes = Me.Rubro) > 0 Then
                MsgBox("El rubro ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If col.GetDbCount(HC.CabEdoResFields.NomEdoRes = Me.Descripcion) > 0 Then
                MsgBox("La descripción ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            If col.GetDbCount(Not HC.CabEdoResFields.CveEdoRes = Me.Rubro And HC.CabEdoResFields.NomEdoRes = Me.Descripcion) > 0 Then
                MsgBox("La descripción ya existe", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If

        'If IdAgrupador = 0 Then
        '    MsgBox("Debe especificar la categoria a la que pertenece", MsgBoxStyle.Exclamation, "Aviso")
        '    Return False
        'End If
        Return True
    End Function

    Protected Overrides Function ValidarBorrar() As Boolean
        Return True
    End Function

    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.RepeatableRead, "Guardar Rubro")

        Try
            If Not ValidarGuardar() Then
                Return False
            End If

            Dim num As Integer = Detalle.Count

            For i As Integer = 0 To num - 1
                If i > num - 1 Then
                    Exit For
                End If

                If Detalle(i).Entidad.CuentaContable.BooResultad AndAlso Not Detalle(i).SumaOResta = Nothing Then
                    Detalle(i).Renglon = i + 1
                    Detalle(i).EstadoResultado = Me
                Else
                    Detalle.Remove(Detalle(i))
                    num -= 1
                    i -= 1
                    Continue For
                End If
            Next

            If Detalle.Count = 0 Then
                MsgBox("Debe tener al menos 1 cuenta contable valida en el estado para poder guardarlo", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            'If Entidad.IsNew Then
            Return Entidad.Save(True)
            'Else
            'trans.Add(Entidad)
            'Entidad.Save()

            'Dim colDet As New CC.DetEdoResCollection

            'trans.Add(colDet)
            'colDet.GetMulti(HC.DetEdoResFields.CveEdoRes = Me.Rubro)

            'For Each det As EC.DetEdoResEntity In colDet
            '    Dim encontro As Boolean = False

            '    For Each deta As EstadoResultadoDetalleClass In Detalle

            '    Next
            'Next
            'End If

        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el estado de resultado", MsgBoxStyle.Critical, "Error")
#End If

            Return False
        End Try
    End Function

    Public Sub CalcularSaldo(ByVal Trans As HC.Transaction, ByVal Mes As MesEnum2)
        Me.SaldoMes = 0D

        'For Each Detalle As EstadoResultadoDetalleClass In Me.Detalle
        '    Select Case Mes
        '        Case MesEnum2.ENERO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.EneroCargo, Detalle.CuentaContable.EneroAbono)
        '        Case MesEnum2.FEBRERO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.FebreroCargo, Detalle.CuentaContable.FebreroAbono)
        '        Case MesEnum2.MARZO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.MarzoCargo, Detalle.CuentaContable.MarzoAbono)
        '        Case MesEnum2.ABRIL
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.AbrilCargo, Detalle.CuentaContable.AbrilAbono)
        '        Case MesEnum2.MAYO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.MayoCargo, Detalle.CuentaContable.MayoAbono)
        '        Case MesEnum2.JUNIO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.JunioCargo, Detalle.CuentaContable.JunioAbono)
        '        Case MesEnum2.JULIO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.JulioCargo, Detalle.CuentaContable.JulioAbono)
        '        Case MesEnum2.AGOSTO
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.AgostoCargo, Detalle.CuentaContable.AgostoAbono)
        '        Case MesEnum2.SEPTIEMBRE
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.SeptiembreCargo, Detalle.CuentaContable.SeptiembreAbono)
        '        Case MesEnum2.OCTUBRE
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.OctubreCargo, Detalle.CuentaContable.OctubreAbono)
        '        Case MesEnum2.NOVIEMBRE
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.NoviembreCargo, Detalle.CuentaContable.NoviembreAbono)
        '        Case MesEnum2.DICIEMBRE
        '            Detalle.SaldoMes = Detalle.CuentaContable.CalcularSaldo(Detalle.CuentaContable.DiciembreCargo, Detalle.CuentaContable.DiciembreAbono)
        '    End Select

        'If Detalle.SumaOResta.ToString.Trim = "+" Then
        '    Me.SaldoMes += (Detalle.SaldoMes)
        'Else
        '    Me.SaldoMes -= (Detalle.SaldoMes)
        'End If
        'Trans.Add(Detalle.Entidad)
        'Detalle.Entidad.Save()
        'Next
        Trans.Add(Me.Entity)
        Me.Entity.Save()
    End Sub

    Private Shadows Function Borrar() As Boolean
        Try

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Eventos"
    Private Sub m_Detalle_ItemModificado(ByRef coleccion As Object, ByVal index As Integer, ByRef itemSel As EstadoResultadoDetalleClass) Handles m_Detalle.ItemModificado
        If itemSel.CuentaMayor = "0000" AndAlso itemSel.SubCuenta = "0000" AndAlso itemSel.SSubCuenta = "0000" AndAlso itemSel.SSSubCuenta = "0000" Then
            Detalle.Remove(itemSel)
        Else
            For Each det As EstadoResultadoDetalleClass In Detalle
                If det.CuentaMayor = itemSel.CuentaMayor AndAlso det.SubCuenta = itemSel.SubCuenta AndAlso det.SSubCuenta = itemSel.SSubCuenta AndAlso det.SSSubCuenta = itemSel.SSSubCuenta Then
                    MsgBox("La cuenta ya se encuentra en el listado", MsgBoxStyle.Exclamation, "Aviso")
                    Detalle.Remove(itemSel)
                End If
            Next
        End If
    End Sub
#End Region
End Class