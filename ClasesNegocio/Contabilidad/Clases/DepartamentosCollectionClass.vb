Imports EC = IntegraLab.ORM.EntityClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DepartamentosCollectionClas
    Inherits ColleccionBase(Of EC.CatDeptosEntity, CC.CatDeptosCollection, DepartamentosClass)

    Public Overloads Function Obtener(ByVal fcCondicion As CondicionEstatusDepartamento) As Integer
        Try
            If Not fcCondicion = CondicionEstatusDepartamento.TODOS Then
                coleccion.GetMulti(HC.CatDeptosFields.Estatus = fcCondicion)
            Else
                coleccion.GetMulti(Nothing)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal Sesion As ECS.SesionesEntity) As rptDepartamentos
        Try
            Dim rep As New rptDepartamentos

            rep.SetDataSource(Me)
            rep.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
            rep.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
            rep.SetParameterValue(2, "Catalogos/Contabilidad/ABC de Departamentos")

            Return rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al crear el reporte", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function
End Class