Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DomicilioFiscalCollectionClass
    Inherits CollectionClass(Of DomicilioFiscalClass)

    Private Col As New CC.DomicilioFiscalCollection

    Public Function Obtener(Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            If Not FcCondicion = CondicionEnum.TODOS Then
                Col.GetMulti(Nothing)
            Else
                Col.GetMulti(HC.DomicilioFiscalFields.Estatus = FcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal RFC As String, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            If Not FcCondicion = CondicionEnum.Todos Then
                filtro.Add(HC.DomicilioFiscalFields.Estatus = FcCondicion)
            End If

            filtro.Add(HC.DomicilioFiscalFields.Rfc Mod String.Format("%{0}%", RFC))

            Col.GetMulti(filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal RFC As String, ByVal RazonSocial As String, ByVal Domicilio As String, ByVal Colonia As String, ByVal CodigoPostal As String, Optional ByVal FcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            filtro.Add(HC.DomicilioFiscalFields.Rfc Mod String.Format("%{0}%", RFC))
            filtro.Add(HC.DomicilioFiscalFields.RazonSocial Mod String.Format("%{0}%", RazonSocial))
            filtro.Add(HC.DomicilioFiscalFields.Domicilio Mod String.Format("%{0}%", Domicilio))
            filtro.Add(HC.DomicilioFiscalFields.Colonia Mod String.Format("%{0}%", Colonia))
            filtro.Add(HC.DomicilioFiscalFields.CodigoPostal Mod String.Format("%{0}%", CodigoPostal))

            If Not FcCondicion = CondicionEnum.Todos Then
                filtro.Add(HC.DomicilioFiscalFields.Estatus = FcCondicion)
            End If

            Col.GetMulti(filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    Public Function Existe(ByVal entc As DomicilioFiscalClass) As Boolean
        Try
            For Each ent As DomicilioFiscalClass In Me
                If ent.Codigo = entc.Codigo Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub Rellenar()
        Clear()

        For Each ente As EC.DomicilioFiscalEntity In Col
            Me.Add(New DomicilioFiscalClass(ente))
        Next
    End Sub

    Private Sub RellenarColeccion()
        Try
            Col = New CC.DomicilioFiscalCollection

            For Each entc As DomicilioFiscalClass In Me
                Col.Add(entc.ObtenerEntidad)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ObtenerColeccion() As CC.DomicilioFiscalCollection
        RellenarColeccion()
        Return Col
    End Function

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Coleccion As CC.DomicilioFiscalCollection)
        Col = Coleccion
        Rellenar()
    End Sub

End Class
