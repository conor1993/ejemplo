Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ConfiguracionCtasCtrolColeccion
    Inherits ColleccionBase(Of EC.CfgCtrlCtasEntity, CC.CfgCtrlCtasCollection, ConfiguracionCtasCtrlClass)

    Public Overloads Function Obtener(ByVal Folio As Integer) As Integer
        Try
            Me.Clear()
            coleccion = New CC.CfgCtrlCtasCollection
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.CfgCtrlCtasFields.IdConCfgCtas = Folio)
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptConfiguracionCtaCtrl
        Try
            Dim Rep As New RptConfiguracionCtaCtrl
            Dim ds As New DataSet
            Dim dt As New DsConfiguracionCtasCtrl.DtConfiguracionCtasCtrlDataTable
            For Each cn As ConfiguracionCtasCtrlClass In Me
                'dt.AddDtConfiguracionCtasCtrlRow(cn.Folio, cn.Cta, cn.SubCuenta, cn.SsubCuenta, cn.SssubCuenta, cn.NombreCuenta, cn.TipoCuenta)
            Next
            ds.Tables.Add(dt)
            Rep.SetDataSource(ds)
            Rep.SetParameterValue(0, Empresa)
            Rep.SetParameterValue(1, Usuario)
            Rep.SetParameterValue(2, "Catálogos/Contabilidad")
            Return Rep
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return Nothing
        End Try
    End Function

#Region "Metodos"

    Public Sub Guardar(ByVal Trans As HC.Transaction)
        For Each Configuracion As ConfiguracionCtasCtrlClass In Me
            Trans.Add(Configuracion.Entidad)
            Configuracion.Entidad.Save()
        Next
    End Sub

    Public Sub ObtenerConceptos()
        Dim Conceptos As New CC.ConCfgCtasCollection
        Dim Lista As New List(Of Integer)
        Dim Filtro As New OC.PredicateExpression

        Me.Obtener()

        For Each Configuracion As ConfiguracionCtasCtrlClass In Me
            Lista.Add(Configuracion.IdConCfgCtas)
        Next

        If Lista.Count > 0 Then
            Filtro.Add(New OC.FieldCompareRangePredicate(HC.ConCfgCtasFields.IdConCfgCtas, True, Lista))
        End If
        Conceptos.GetMulti(Filtro)

        For Each Concepto As EC.ConCfgCtasEntity In Conceptos
            Dim Configuracion As New ConfiguracionCtasCtrlClass

            Configuracion.IdConCfgCtas = Concepto.IdConCfgCtas
            Me.Add(Configuracion)

        Next
    End Sub

#End Region

End Class