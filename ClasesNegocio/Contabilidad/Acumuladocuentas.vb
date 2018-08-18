
Imports HC = Integralab.ORM.HelperClasses

Public Class Acumuladocuentas
    Dim AcumCuentas As New AcumuladodeCuentasContablesClass



    Public Function Guardar2(ByVal Trans As HC.Transaction, ByVal anio As Integer, ByVal MesEnum2 As Integer, ByVal Polizadetalle As PolizaClass) As Boolean

        Dim PolizaDet As PolizaDetalleClass

        For Each PolizaDet In Polizadetalle.Detalles2
            ' ''---------------------- guardar  en acumcuentacontable---------------------------
            AcumCuentas.Obtener(PolizaDet.IdCuentaContable, anio)

            Select Case MesEnum2
                Case 1
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.EneroAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.EneroCargo = PolizaDet.Importe
                    End If
                Case 2
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.FebreroAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.FebreroCargo = PolizaDet.Importe
                    End If
                Case 3
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.MarzoAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.MarzoCargo = PolizaDet.Importe
                    End If
                Case 4
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.AbrilAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.AbrilCargo = PolizaDet.Importe
                    End If
                Case 5
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.MayoAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.MayoCargo = PolizaDet.Importe
                    End If
                Case 6
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.JunioAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.JunioCargo = PolizaDet.Importe
                    End If
                Case 7
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.JulioAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.JulioCargo = PolizaDet.Importe
                    End If
                Case 8
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.AgostoAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.AgostoCargo = PolizaDet.Importe
                    End If
                Case 9
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.SeptiembreAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.SeptiembreCargo = PolizaDet.Importe
                    End If
                Case 10
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.OctubreAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.OctubreCargo = PolizaDet.Importe
                    End If
                Case 11
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.NoviembreAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.NoviembreCargo = PolizaDet.Importe
                    End If
                Case 12
                    If (PolizaDet.Operacion = ClasesNegocio.PolizaOperacionEnum.ABONO) Then
                        AcumCuentas.DiciembreAbono = PolizaDet.Importe
                    Else
                        AcumCuentas.DiciembreCargo = PolizaDet.Importe
                    End If
            End Select
            ''-----------------------------------------------------------------------------------
            If Not AcumCuentas.Guardar2(Trans) Then
                Trans.Rollback()
                Exit Function
            End If
        Next




    End Function



End Class
