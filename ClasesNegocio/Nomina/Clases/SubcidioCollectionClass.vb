Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class SubcidioCollectionClass
    Inherits ColleccionBase(Of EC.NomSubsidioEmpleoEntity, CC.NomSubsidioEmpleoCollection, SubcidioClass)

    Public Overloads Function Obtener(ByVal a�o As Short) As Integer
        Try
            coleccion.GetMulti(HC.NomSubsidioEmpleoFields.A�o = a�o)

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los subcidios", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Guardar(ByVal a�o As Short) As Boolean
        Try
            RellenarColeccion()

            For Each isr As SubcidioClass In Me
                isr.A�o = a�o
            Next

            Return CBool(coleccion.SaveMulti() + 1)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function
End Class
