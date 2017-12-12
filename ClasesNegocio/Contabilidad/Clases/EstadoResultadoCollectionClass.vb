Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class EstadoResultadoCollectionClass
    Inherits ColleccionBase(Of EC.CabEdoResEntity, CC.CabEdoResCollection, EstadoResultadoClass)

#Region "Miembros"

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"

#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"
    Public Overloads Function Obtener(ByVal rubro As String, ByVal descripcion As String) As Integer
        Try
            If rubro = "" Then
                coleccion.GetMulti(HC.CabEdoResFields.NomEdoRes Mod String.Format("%{0}%", descripcion))
            Else
                coleccion.GetMulti(HC.CabEdoResFields.CveEdoRes = Microsoft.VisualBasic.Right("000" & rubro, 3) And HC.CabEdoResFields.NomEdoRes Mod String.Format("%{0}%", descripcion))
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los estados de resultado", MsgBoxStyle.Critical, "Error")
#End If

            Return -1
        End Try
    End Function
#End Region

#Region "Eventos"

#End Region

End Class