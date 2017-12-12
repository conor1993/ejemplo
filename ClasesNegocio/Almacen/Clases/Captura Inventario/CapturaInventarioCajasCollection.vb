Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CapturaInventarioCajasCollection
    Inherits ColleccionBase(Of EC.MscloteCortesDetComparacionEntity, CC.MscloteCortesDetComparacionCollection, CapturaInventarioCajasClass)

    Public Function Guardar() As Integer
        Try
            Dim col As New CC.MscloteCortesDetComparacionCollection

            Dim loteMax As Object = col.GetScalar(Integralab.ORM.MscloteCortesDetComparacionFieldIndex.LoteCorte, New OC.Expression(HC.MscloteCortesDetComparacionFields.LoteCorte), SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max)
            Dim loteCorte As String

            If DBNull.Value.Equals(loteMax) Then
                loteCorte = "I0001"
            Else
                loteCorte = "I" & (CInt(loteMax.ToString.Substring(1, loteMax.ToString.Length - 1)) + 1).ToString("0000")
            End If

            For i As Integer = 0 To Me.Count - 1
                Dim item As CapturaInventarioCajasClass = Me(i)

                Item.Lote = loteCorte
                item.FolioEtiqueta = i + 1
            Next

            RellenarColeccion()

            coleccion.SaveMulti()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el inventario", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function
End Class