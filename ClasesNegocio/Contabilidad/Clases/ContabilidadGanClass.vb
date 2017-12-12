Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

''Public Class CuentasContabilidadGanClass
''    Implements IEntidad


''    Dim CtaCont As EC.CatCtaContEntity
''    Property CtaMay() As String
''        Get
''            Return CtaCont.CveCta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveCta = value
''        End Set
''    End Property
''    Property SubCta() As String
''        Get
''            Return CtaCont.CveSubCta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSubCta = value
''        End Set
''    End Property
''    Property SsbCta() As String
''        Get
''            Return CtaCont.CveSsubCta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSsubCta = value
''        End Set
''    End Property
''    Property SssCta() As String
''        Get
''            Return CtaCont.CveSssubCta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSssubCta = value
''        End Set
''    End Property
''    Property Descripcion() As String
''        Get
''            Return CtaCont.NomCuenta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.NomCuenta = value
''        End Set
''    End Property
''    Property Naturaleza() As String
''        Get
''            Return CtaCont.StaNaturaleza
''        End Get
''        Set(ByVal value As String)
''            CtaCont.StaNaturaleza = value
''        End Set
''    End Property
''    Property Resultado() As String
''        Get
''            Return CtaCont.BooResultad
''        End Get
''        Set(ByVal value As String)
''            CtaCont.BooResultad = value
''        End Set
''    End Property
''    Property Presupuesto() As String
''        Get
''            Return CtaCont.BooPresup
''        End Get
''        Set(ByVal value As String)
''            CtaCont.BooPresup = value
''        End Set
''    End Property
''    Property Afectable() As String
''        Get
''            Return CtaCont.BooAfectable
''        End Get
''        Set(ByVal value As String)
''            CtaCont.BooAfectable = value
''        End Set
''    End Property
''    Property Hijos() As Integer
''        Get
''            Return CtaCont.NumeroHijos
''        End Get
''        Set(ByVal value As Integer)
''            CtaCont.NumeroHijos = value
''        End Set
''    End Property
''    Property CtaEnt() As String
''        Get
''            Return CtaCont.CveCtaEnt
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveCtaEnt = value
''        End Set
''    End Property
''    Property SubCtaEnt() As String
''        Get
''            Return CtaCont.CveSubCtaEnt
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSubCtaEnt = value
''        End Set
''    End Property
''    Property SsbCtaEnt() As String
''        Get
''            Return CtaCont.CveSsubCtaEnt
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSsubCtaEnt = value
''        End Set
''    End Property
''    Property SssCtaEnt() As String
''        Get
''            Return CtaCont.CveSssubCtaEnt
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSssubCtaEnt = value
''        End Set
''    End Property
''    Property CtaSal() As String
''        Get
''            Return CtaCont.CveCtaSal
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveCtaSal = value
''        End Set
''    End Property
''    Property SubCtaSal() As String
''        Get
''            Return CtaCont.CveSubCtaSal
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSubCtaSal = value
''        End Set
''    End Property
''    Property SsbCtaSal() As String
''        Get
''            Return CtaCont.CveSsubCtaSal
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSsubCtaSal = value
''        End Set
''    End Property
''    Property SssCtaSal() As String
''        Get
''            Return CtaCont.CveSssubCtaSal
''        End Get
''        Set(ByVal value As String)
''            CtaCont.CveSssubCtaSal = value
''        End Set
''    End Property
''    Property SaldoAnterior() As Decimal
''        Get
''            Return CtaCont.SaldoAnoAnt
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.SaldoAnoAnt = value
''        End Set
''    End Property
''    Property SaldoInicial() As Decimal
''        Get
''            Return CtaCont.SaldoIniEjerc
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.SaldoIniEjerc = value
''        End Set
''    End Property
''    Property Cargos01() As Decimal
''        Get
''            Return CtaCont.Cargos01
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos01 = value
''        End Set
''    End Property
''    Property Cargos02() As Decimal
''        Get
''            Return CtaCont.Cargos02
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos02 = value
''        End Set
''    End Property
''    Property Cargos03() As Decimal
''        Get
''            Return CtaCont.Cargos03
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos03 = value
''        End Set
''    End Property
''    Property Cargos04() As Decimal
''        Get
''            Return CtaCont.Cargos04
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos04 = value
''        End Set
''    End Property
''    Property Cargos05() As Decimal
''        Get
''            Return CtaCont.Cargos05
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos05 = value
''        End Set
''    End Property
''    Property Cargos06() As Decimal
''        Get
''            Return CtaCont.Cargos06
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos06 = value
''        End Set
''    End Property
''    Property Cargos07() As Decimal
''        Get
''            Return CtaCont.Cargos07
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos07 = value
''        End Set
''    End Property
''    Property Cargos08() As Decimal
''        Get
''            Return CtaCont.Cargos08
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos08 = value
''        End Set
''    End Property
''    Property Cargos09() As Decimal
''        Get
''            Return CtaCont.Cargos09
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos09 = value
''        End Set
''    End Property
''    Property Cargos10() As Decimal
''        Get
''            Return CtaCont.Cargos10
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos10 = value
''        End Set
''    End Property
''    Property Cargos11() As Decimal
''        Get
''            Return CtaCont.Cargos11
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos11 = value
''        End Set
''    End Property
''    Property Cargos12() As Decimal
''        Get
''            Return CtaCont.Cargos12
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Cargos12 = value
''        End Set
''    End Property

''    Property Abonos01() As Decimal
''        Get
''            Return CtaCont.Abonos01
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos01 = value
''        End Set
''    End Property

''    Property Abonos02() As Decimal
''        Get
''            Return CtaCont.Abonos02
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos02 = value
''        End Set
''    End Property
''    Property Abonos03() As Decimal
''        Get
''            Return CtaCont.Abonos03
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos03 = value
''        End Set
''    End Property
''    Property Abonos04() As Decimal
''        Get
''            Return CtaCont.Abonos04
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos04 = value
''        End Set
''    End Property
''    Property Abonos05() As Decimal
''        Get
''            Return CtaCont.Abonos05
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos05 = value
''        End Set
''    End Property
''    Property Abonos06() As Decimal
''        Get
''            Return CtaCont.Abonos06
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos06 = value
''        End Set
''    End Property
''    Property Abonos07() As Decimal
''        Get
''            Return CtaCont.Abonos07
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos07 = value
''        End Set
''    End Property
''    Property Abonos08() As Decimal
''        Get
''            Return CtaCont.Abonos08
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos08 = value
''        End Set
''    End Property
''    Property Abonos09() As Decimal
''        Get
''            Return CtaCont.Abonos09
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos09 = value
''        End Set
''    End Property
''    Property Abonos10() As Decimal
''        Get
''            Return CtaCont.Abonos10
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos10 = value
''        End Set
''    End Property
''    Property Abonos11() As Decimal
''        Get
''            Return CtaCont.Abonos11
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos11 = value
''        End Set
''    End Property
''    Property Abonos12() As Decimal
''        Get
''            Return CtaCont.Abonos12
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Abonos12 = value
''        End Set
''    End Property
''    Property Presupuesto01() As Decimal
''        Get
''            Return CtaCont.Presup01
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup01 = value
''        End Set
''    End Property

''    Property Presupuesto02() As Decimal
''        Get
''            Return CtaCont.Presup02
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup02 = value
''        End Set
''    End Property
''    Property Presupuesto03() As Decimal
''        Get
''            Return CtaCont.Presup03
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup03 = value
''        End Set
''    End Property
''    Property Presupuesto04() As Decimal
''        Get
''            Return CtaCont.Presup04
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup04 = value
''        End Set
''    End Property
''    Property Presupuesto05() As Decimal
''        Get
''            Return CtaCont.Presup05
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup05 = value
''        End Set
''    End Property
''    Property Presupuesto06() As Decimal
''        Get
''            Return CtaCont.Presup06
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup06 = value
''        End Set
''    End Property
''    Property Presupuesto07() As Decimal
''        Get
''            Return CtaCont.Presup07
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup07 = value
''        End Set
''    End Property
''    Property Presupuesto08() As Decimal
''        Get
''            Return CtaCont.Presup08
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup08 = value
''        End Set
''    End Property
''    Property Presupuesto09() As Decimal
''        Get
''            Return CtaCont.Presup09
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup09 = value
''        End Set
''    End Property
''    Property Presupuesto10() As Decimal
''        Get
''            Return CtaCont.Presup10
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup10 = value
''        End Set
''    End Property
''    Property Presupuesto11() As Decimal
''        Get
''            Return CtaCont.Presup11
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup11 = value
''        End Set
''    End Property
''    Property Presupuesto12() As Decimal
''        Get
''            Return CtaCont.Presup12
''        End Get
''        Set(ByVal value As Decimal)
''            CtaCont.Presup12 = value
''        End Set
''    End Property
''    Property Inactiva() As String
''        Get
''            Return CtaCont.BooInactiva
''        End Get
''        Set(ByVal value As String)
''            CtaCont.BooInactiva = value
''        End Set
''    End Property
''    Property departamental() As String
''        Get
''            Return CtaCont.BooDepta
''        End Get
''        Set(ByVal value As String)
''            CtaCont.BooDepta = value
''        End Set
''    End Property


''    Public Function Borrar() As Boolean Implements IEntidad.Borrar

''    End Function

''    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

''    End Function


''    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

''    End Function

''    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

''    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

''    Public Overloads Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener
''    End Function
''    Public Overloads Function Obtener(ByVal Opcion As Integer, ByVal CtaMay As String, ByVal SubCta As String, ByVal SsbCta As String, ByVal SssCta As String) As DataTable
''        Try
''            Dim TablaCuentas As DataTable = SPR.UspConCatCtaCont(Opcion, CtaMay, SubCta, SsbCta, SssCta)
''            If TablaCuentas.Rows.Count = 0 Then
''                RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
''            End If
''            Return TablaCuentas
''        Catch ex As Exception
''            RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
''            Return Nothing
''        End Try
''    End Function


''    Public Sub New()
''        CtaCont = New EC.CatCtaContEntity

''    End Sub

''    Public Function Guardar1() As Boolean

''    End Function

''    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

''    End Function

''    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
''        Get

''        End Get
''        Set(ByVal value As EstatusEnum)

''        End Set
''    End Property

''    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

''    End Function
''End Class

'Public Class CuentasdeControlGanClass
'    Implements IEntidad


'    Dim CuentasControl As EC.CfgCtrlCtasEntity
'    Property Folio() As String
'        Get
'            Return CuentasControl.Folio
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.Folio = value
'        End Set
'    End Property
'    Property Concepto() As String
'        Get
'            Return CuentasControl.NomConcepto
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.NomConcepto = value
'        End Set
'    End Property
'    Property CtaMay() As String
'        Get
'            Return CuentasControl.CveCta
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.CveCta = value
'        End Set
'    End Property
'    Property SubCta() As String
'        Get
'            Return CuentasControl.CveSubCta
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.CveSubCta = value
'        End Set
'    End Property

'    Property SsbCta() As String
'        Get
'            Return CuentasControl.CveSsubCta
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.CveSsubCta = value
'        End Set
'    End Property

'    Property SssCta() As String
'        Get
'            Return CuentasControl.CveSssubCta
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.CveSssubCta = value
'        End Set
'    End Property

'    Property TipCta() As String
'        Get
'            Return CuentasControl.StaTipCta
'        End Get
'        Set(ByVal value As String)
'            CuentasControl.StaTipCta = value
'        End Set
'    End Property

'    Public Function Borrar() As Boolean Implements IEntidad.Borrar

'    End Function

'    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

'    End Function


'    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
'    End Function

'    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

'    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

'    Public Overloads Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

'    End Function
'    'Public Overloads Function Obtener(ByVal Opcion As Integer, ByVal Folio As String) As DataTable
'    '    'Try
'    '    '    Dim TablaCuentas As DataTable = SPR.UspConCfgCtrlCtas(Opcion, Folio)
'    '    '    If TablaCuentas.Rows.Count = 0 Then
'    '    '        RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
'    '    '    End If
'    '    '    Return TablaCuentas
'    '    'Catch ex As Exception
'    '    '    RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
'    '    '    Return Nothing
'    '    'End Try
'    'End Function

'    Public Sub New()
'        CuentasControl = New EC.CfgCtrlCtasEntity
'    End Sub

'    Public Function Guardar1() As Boolean

'    End Function

'    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

'    End Function

'    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
'        Get

'        End Get
'        Set(ByVal value As EstatusEnum)

'        End Set
'    End Property

'    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

'    End Function
'End Class

Public Class PolizaCabeceroClass
    Implements IEntidad


    Dim Poliza As EC.PogrCbEntity
    Dim _Func As String
    Dim _NumOpc As Integer

    Property NumeroPoliza() As String
        Get
            Return Poliza.NumeroPol
        End Get
        Set(ByVal value As String)
            Poliza.NumeroPol = value
        End Set
    End Property
    Property Fecha() As Date
        Get
            Return Poliza.FecPoliza
        End Get
        Set(ByVal value As Date)
            Poliza.FecPoliza = value
        End Set
    End Property
    Property Importe() As Decimal
        Get
            Return Poliza.ImptePoliza
        End Get
        Set(ByVal value As Decimal)
            Poliza.ImptePoliza = value
        End Set
    End Property
    Property Concepto() As String
        Get
            Return Poliza.Concepto
        End Get
        Set(ByVal value As String)
            Poliza.Concepto = value
        End Set
    End Property
    Property Origen() As String
        Get
            Return Poliza.Origen
        End Get
        Set(ByVal value As String)
            Poliza.Origen = value
        End Set
    End Property
    Property CveError() As String
        Get
            Return Poliza.CveError
        End Get
        Set(ByVal value As String)
            Poliza.CveError = value
        End Set
    End Property
    Property Vigencia() As String
        Get
            Return Poliza.CveVigencia
        End Get
        Set(ByVal value As String)
            Poliza.CveVigencia = value
        End Set
    End Property
    Property Referencia() As String
        Get
            Return Poliza.Referencia
        End Get
        Set(ByVal value As String)
            Poliza.Referencia = value
        End Set
    End Property
    Property MotivoCanc() As String
        Get
            Return Poliza.MotivoCanc
        End Get
        Set(ByVal value As String)
            Poliza.MotivoCanc = value
        End Set
    End Property
    Property Beneficiario() As String
        Get
            Return Poliza.Benefic
        End Get
        Set(ByVal value As String)
            Poliza.Benefic = value
        End Set
    End Property
    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property
    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function


    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspPoGrCb(NumeroPoliza, Fecha, Importe, Concepto, Origen, CveError, Vigencia, Referencia, MotivoCanc, Beneficiario, Func, NumOpc, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de poliza de facturacion")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Error al guardar información de poliza de facturacion")
            Return False
        End Try
    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Overloads Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function
    'Public Overloads Function Obtener(ByVal Opcion As Integer, ByVal Poliza As String) As DataSet
    '    Try
    '        Dim TablaPolizas As DataSet = SPR.UspConPolizas(Opcion, Poliza)
    '        If TablaPolizas.Tables(0).Rows.Count = 0 Then
    '            RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
    '        End If
    '        Return TablaPolizas
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, "No se encuentra información en catalogo de cuentas contables")
    '        Return Nothing
    '    End Try
    'End Function

    Public Sub New()
        Poliza = New EC.PogrCbEntity
        Poliza.Concepto = ""
        Poliza.Benefic = ""
        Poliza.CveError = ""
        Poliza.CveVigencia = "V"
        Poliza.FecPoliza = "01/01/1900"
        Poliza.ImptePoliza = 0
        Poliza.MotivoCanc = ""
        Poliza.NumeroPol = ""
        Poliza.Origen = "Y"
        Poliza.Referencia = ""

    End Sub

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class
Public Class PolizaDetalleGanClass
    Implements IEntidad


    Dim Poliza As EC.PoGrDtEntity
    Dim _Func As String
    Dim _NumOpc As Integer

    Property NumeroPoliza() As String
        Get
            Return Poliza.NumeroPol
        End Get
        Set(ByVal value As String)
            Poliza.NumeroPol = value
        End Set
    End Property
    Property Renglon() As String
        Get
            Return Poliza.CveRenglon
        End Get
        Set(ByVal value As String)
            Poliza.CveRenglon = value
        End Set
    End Property
    Property Fecha() As Date
        Get
            Return Poliza.FechaPol
        End Get
        Set(ByVal value As Date)
            Poliza.FechaPol = value
        End Set
    End Property
    Property CtaMay() As String
        Get
            Return Poliza.CtaMayor
        End Get
        Set(ByVal value As String)
            Poliza.CtaMayor = value
        End Set
    End Property
    Property SubCta() As String
        Get
            Return Poliza.SubCta
        End Get
        Set(ByVal value As String)
            Poliza.SubCta = value
        End Set
    End Property
    Property SsbCta() As String
        Get
            Return Poliza.SsubCta
        End Get
        Set(ByVal value As String)
            Poliza.SsubCta = value
        End Set
    End Property
    Property SssCta() As String
        Get
            Return Poliza.SssubCta
        End Get
        Set(ByVal value As String)
            Poliza.SssubCta = value
        End Set
    End Property
    Property Concepto() As String
        Get
            Return Poliza.Concepto
        End Get
        Set(ByVal value As String)
            Poliza.Concepto = value
        End Set
    End Property
    Property CarAbo() As String
        Get
            Return Poliza.CarAbo
        End Get
        Set(ByVal value As String)
            Poliza.CarAbo = value
        End Set
    End Property
    Property Referencia() As String
        Get
            Return Poliza.Referencia
        End Get
        Set(ByVal value As String)
            Poliza.Referencia = value
        End Set
    End Property
    Property Importe() As Decimal
        Get
            Return Poliza.Importe
        End Get
        Set(ByVal value As Decimal)
            Poliza.Importe = value
        End Set
    End Property
    Property Vig() As String
        Get
            Return Poliza.CveVig
        End Get
        Set(ByVal value As String)
            Poliza.CveVig = value
        End Set
    End Property
    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property
    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function


    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If SPA.UspPoGrDt(NumeroPoliza, Renglon, Fecha, CtaMay, SubCta, SsbCta, SssCta, Concepto, CarAbo, Referencia, Importe, Vig, Func, NumOpc, trans) = 0 Then
                RaiseEvent MensajeError(Me, "Error al guardar información de poliza de facturacion")
                Return False
            End If
            Return True
        Catch ex As Exception
            RaiseEvent MensajeError(Me, "Error al guardar información de poliza de facturacion")
            Return False
        End Try

    End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError

    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Sub New()
        Poliza = New EC.PoGrDtEntity
    End Sub

    Public Function Guardar1() As Boolean

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
End Class