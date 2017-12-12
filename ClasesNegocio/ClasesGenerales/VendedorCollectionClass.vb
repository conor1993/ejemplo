Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports Integra.Clases

Public Class VendedorCollectionClass
    Inherits ColleccionBase(Of EC.ComicionistaEntity, CC.ComicionistaCollection, VendedorClass)

    Private Filtro As OC.PredicateExpression
    Public Event MensajeError As Integra.Clases.MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(ByVal FcCondicion As Integra.Clases.CondicionEnum) As Integer
        Try
            If FcCondicion = Integra.Clases.CondicionEnum.TODOS Then
                coleccion.GetMulti(Nothing)
            Else
                coleccion.GetMulti(HC.ComicionistaFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Comicionista As VendedorClass) As Integer
        Try

            coleccion.GetMulti(HC.ComicionistaFields.Codigo = Comicionista.Codigo)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal Nombre As String, ByVal ApellidoPaterno As String, ByVal ApellidoMaterno As String, Optional ByVal Codigo As Integer = -1, Optional ByVal fccondicion As CondicionEnum = CondicionEnum.TODOS, Optional ByVal rfc As String = "") As Integer
        Try
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            If Codigo = -1 Then
                Filtro.Add(HC.ComicionistaFields.Nombre Mod String.Format("%{0}%", Nombre))
                Filtro.Add(HC.ComicionistaFields.Apaterno Mod String.Format("%{0}%", ApellidoPaterno))
                Filtro.Add(HC.ComicionistaFields.Amaterno Mod String.Format("%{0}%", ApellidoMaterno))
                Filtro.Add(HC.ComicionistaFields.Rfc Mod String.Format("%{0}%", rfc))

                If Not fccondicion = CondicionEnum.TODOS Then
                    Filtro.Add(HC.ComicionistaFields.Estatus = fccondicion)
                End If
            Else
                Filtro.Add(HC.ComicionistaFields.Codigo = Codigo)
            End If

            coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal NombreCompleto As String, ByVal FcCondicion As Integra.Clases.CondicionEnum) As Integer
        Try
            Dim filtro As New OC.PredicateExpression
            Dim field As OC.EntityField = HC.ComicionistaFields.Nombre.SetExpression((HC.ComicionistaFields.Nombre + " " + HC.ComicionistaFields.Apaterno + " " + HC.ComicionistaFields.Amaterno))
            filtro.Add(New OC.FieldLikePredicate(field, String.Format("%{0}%", NombreCompleto)))

            If Not FcCondicion = CondicionEnum.TODOS Then
                filtro.Add(HC.ComicionistaFields.Estatus = FcCondicion)
            End If

            Me.coleccion.GetMulti(filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un error durante la consulta", MsgBoxStyle.Critical, "Error")
#End If

            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal nombreEmpresa As String, ByVal Usuario As String) As CrepComisionista
        Dim Reportes As New CrepComisionista
        Dim ds As New DataSet
        Dim dcom As New DSetComisionista.DtComisionistaDataTable

        For Each com As VendedorClass In Me
            dcom.AddDtComisionistaRow(com.Codigo, com.Nombre, com.Apaterno, com.Amaterno, com.Domicilio, com.Colonia, com.Lada, com.Telefono, com.Rfc, com.Plaza.Descripcion, com.Email, com.Estatus.ToString)
        Next

        ds.Tables.Add(dcom)
        Reportes.SetDataSource(ds)
        Reportes.SetParameterValue(0, nombreEmpresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, "Catalogos\Ventas\Vendedores")
        Return Reportes

    End Function

End Class