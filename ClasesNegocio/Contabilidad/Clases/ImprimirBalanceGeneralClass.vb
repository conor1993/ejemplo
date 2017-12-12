Public Class ImprimirBalanceGeneralClass
    Inherits Drawing.Printing.PrintDocument

    Const Encabezado As String = "BALANCE GENERAL"
    Const FC As String = "###,###,##0.00"

    Private acum As AcumuladodeCuentasContablesClass
    Dim IdBanco As Integer


    Public Property Acumulado() As AcumuladodeCuentasContablesClass
        Get
            Return acum
        End Get
        Set(ByVal value As AcumuladodeCuentasContablesClass)
            acum = value
        End Set
    End Property
    




    'Protected Overrides Sub OnPrintPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)
    '    Dim ConfigCheques As New CC.ConfiguracionChequesImpCollection
    '    ConfigCheques.GetMulti(HC.ConfiguracionChequesImpFields.IdBanco = Banco)
    '    MyBase.OnPrintPage(e)
    '    'e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimete
    '    e.Graphics.PageUnit = Drawing.GraphicsUnit.Millimeter
    '    e.Graphics.PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighSpeed
    '    'datos generales del cheque
    '    Escribe(e.Graphics, ch.Folio, ConfigCheques(0).FolioChequeImpCol, ConfigCheques(0).FolioChequeImpRen)
    '    Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), ConfigCheques(0).FechaImpCol, ConfigCheques(0).FechaImpRen)
    '    Escribe(e.Graphics, ch.Beneficiario.Beneficiario, ConfigCheques(0).BeneficiarioImpCol, ConfigCheques(0).BeneficiarioImpRen)
    '    Escribe(e.Graphics, ch.Importe.ToString(FC), ConfigCheques(0).ImporteImpCol, ConfigCheques(0).ImporteImpRen)
    '    Escribe(e.Graphics, ch.ImporteLetra.ToUpper, ConfigCheques(0).ImporteConLetraImpCol, ConfigCheques(0).ImporteConLetraImpRen)
    '    If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, ConfigCheques(0).AbonoAcuentaImpCol, ConfigCheques(0).AbonoAcuentaImpRen)
    '    'datos de copia del cheque
    '    If ConfigCheques(0).FolioChequeCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Folio, ConfigCheques(0).FolioChequeCopiaImpCol, ConfigCheques(0).FolioChequeCopiaImpRen)
    '    If ConfigCheques(0).FechaCopiaImpCol Then Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), ConfigCheques(0).FechaCopiaImpCol, ConfigCheques(0).FechaCopiaImpRen)
    '    If ConfigCheques(0).BeneficiarioCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Beneficiario.Beneficiario, ConfigCheques(0).BeneficiarioCopiaImpCol, ConfigCheques(0).BeneficiarioCopiaImpRen)
    '    If ConfigCheques(0).ImporteCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.Importe.ToString(FC), ConfigCheques(0).ImporteCopiaImpCol, ConfigCheques(0).ImporteCopiaImpRen)
    '    If ConfigCheques(0).ImporteConLetraCopiaImpCol <> 0 Then Escribe(e.Graphics, ch.ImporteLetra.ToUpper, ConfigCheques(0).ImporteConLetraCopiaImpCol, ConfigCheques(0).ImporteConLetraCopiaImpRen)
    '    If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, ConfigCheques(0).AbonoAcuentaCopiaImpCol, ConfigCheques(0).AbonoAcuentaCopiaImpRen)
    '    'detalle de poliza de cheque
    '    Escribe(e.Graphics, ch.Banco.Descripcion.ToUpper, ConfigCheques(0).BancoImpCol, ConfigCheques(0).BancoImpRen)
    '    Escribe(e.Graphics, ch.Cuenta.Cuenta.ToUpper, ConfigCheques(0).CuentaBancoImpCol, ConfigCheques(0).CuentaBancoImpRen)
    '    'Escribe(e.Graphics, ch.Folio.ToUpper, ConfigCheques(0).ChequeImpCol, ConfigCheques(0).ChequeImpRen)
    '    Escribe(e.Graphics, ch.Concepto, ConfigCheques(0).ConceptoImpCol, ConfigCheques(0).ConceptoImpRen)

    '    'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 10)
    '    'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 20, 20)
    '    'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 20)
    '    'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 10, 25)
    '    'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 37)
    '    'Escribe(e.Graphics, ch.Folio, 150, 90)
    '    'Escribe(e.Graphics, ch.FechaDocumento.ToString("dd MMMM' de 'yyyy"), 150, 97)
    '    'Escribe(e.Graphics, ch.Beneficiario.Beneficiario, 30, 107)
    '    'Escribe(e.Graphics, ch.Importe.ToString(FC), 150, 107)
    '    'Escribe(e.Graphics, ch.ImporteLetra.ToUpper, 20, 117)
    '    'If _AbonoEnCuenta = Windows.Forms.DialogResult.Yes Then Escribe(e.Graphics, Abono, 30, 127)
    '    'Escribe(e.Graphics, ch.Concepto, 10, 150)

    '    Dim x As Single = ConfigCheques(0).CuentaImpCol
    '    Dim y As Single = ConfigCheques(0).CuentaImpRen

    '    Dim tx As Single
    '    Dim ty As Single

    '    Dim ImprimioPapa As Boolean = False
    '    Dim CtaMayor As String = ""
    '    For Each detalle As PolizaDetalleClass In ch.Poliza.Detalles
    '        If ConfigCheques(0).ImprimirCuentaConcentrada = True Then
    '            Dim params() As Object = {detalle.CuentaContable.CuentaMayor, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
    '            Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4} ", params), x, y)
    '            If detalle.Operacion = PolizaOperacionEnum.CARGO Then
    '                Escribe(e.Graphics, detalle.Importe.ToString(FC), ConfigCheques(0).CargoImpCol, y)
    '            Else
    '                Escribe(e.Graphics, detalle.Importe.ToString(FC), ConfigCheques(0).AbonoImpCol, y)
    '            End If
    '            y = y + 4
    '        Else
    '            If CtaMayor <> detalle.CuentaContable.CuentaMayor Then
    '                ImprimioPapa = False
    '                If Not ImprimioPapa Then
    '                    tx = x
    '                    ty = y
    '                    Dim CtaPadre As CuentaContableClass = ObtenerPadre(detalle.CuentaContable)
    '                    CtaMayor = CtaPadre.CuentaMayor
    '                    Dim Importe As Decimal = ObtenerTotalCuentaPadre(CtaPadre.CuentaMayor, ch.Poliza)
    '                    Escribe(e.Graphics, String.Format("{0} {1}", CtaPadre.CuentaMayor, CtaPadre.NombreCuenta), tx, ty)
    '                    If detalle.Operacion = PolizaOperacionEnum.ABONO Then
    '                        'tx += 180
    '                        tx = ConfigCheques(0).CargoImpCol
    '                    Else
    '                        'tx += 150
    '                        tx = ConfigCheques(0).AbonoImpCol
    '                    End If
    '                    Escribe(e.Graphics, Importe.ToString(FC), tx, ty)
    '                    y += 4
    '                    ImprimioPapa = True
    '                End If
    '                Dim params() As Object = {vbTab, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
    '                Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
    '                'Escribe(e.Graphics, detalle.Importe.ToString(FC), x + 110, y)
    '                y += 4
    '            Else
    '                Dim params() As Object = {vbTab, detalle.CuentaContable.SubCuenta, detalle.CuentaContable.SSubCuenta, detalle.CuentaContable.SSSubCuenta, detalle.CuentaContable.NombreCuenta}
    '                Escribe(e.Graphics, String.Format("{0}{1}{2}{3} {4}", params), x, y)
    '                'Escribe(e.Graphics, detalle.Importe.ToString(FC), x + 110, y)
    '                'y += 4
    '            End If
    '        End If
    '    Next

    '    ''Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), x + 150, 330) ' cargo
    '    ''Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), x + 180, 330) 'abono
    '    Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), ConfigCheques(0).CargoTotalImpCol, ConfigCheques(0).CargoTotalImpRen) ' cargo
    '    Escribe(e.Graphics, ch.Poliza.Importe.ToString(FC), ConfigCheques(0).AbonoTotalImpCol, ConfigCheques(0).AbonoTotalImpRen) 'abono
    'End Sub

    Private Function ObtenerPadre(ByVal CuentaContable As CuentaContableClass) As CuentaContableClass
        If IsNothing(CuentaContable.CuentaPadre) Then
            Return CuentaContable
        Else
            Return ObtenerPadre(CuentaContable.CuentaPadre)
        End If
    End Function

    Private Function ObtenerTotalCuentaPadre(ByVal CuentaMayor As String, ByVal Poliza As PolizaClass) As Decimal
        Dim tmp As Decimal = 0
        For Each Detalle As PolizaDetalleClass In Poliza.Detalles
            If Detalle.CuentaContable.CuentaMayor = CuentaMayor Then
                tmp += Detalle.Importe
            End If
        Next
        Return tmp
    End Function

    Private Sub Escribe(ByRef gr As System.Drawing.Graphics, ByVal Texto As String, ByVal x As Single, ByVal y As Single)
        Dim fn As New Drawing.Font("Courier New", 10)
        gr.DrawString(Texto, fn, Drawing.Brushes.Black, x, y)
    End Sub

    'Public Sub ImpresionExitosa()
    '    Cheque.Imprimir()
    'End Sub

End Class