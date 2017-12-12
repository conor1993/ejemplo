Imports NUnit.Framework
Imports Integralab.ORM
Imports ClasesNegocio

<TestFixture()> _
Public Class ControladorTest

#Region "Miembros"

    Private _Controlador As ControladorGanadera

#End Region

#Region "Propiedades"

    Friend ReadOnly Property Controlador() As ControladorGanadera
        Get
            Return _Controlador
        End Get
    End Property

#End Region

#Region "Metodos"

    <SetUp()> _
    Public Sub Init()
        _Controlador = New ControladorGanadera()
        Controlador.Sesion.MiEmpresa.Empnom = "CARNES DON SAUL S.A DE C.V."
        Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString = "Data Source=localhost;Initial Catalog=ganadera;Integrated Security=SSPI;"
    End Sub

    <Test()> _
    <ExpectedException(GetType(BusinessException))> _
    Public Sub ReporteLotesCerradosTest()
        Me.Controlador.ReporteLotesCerrados(Now)
    End Sub

    <Test()> _
    Public Sub ReporteSaldosClientesAcumulados()
        'Me.Controlador.ReporteSaldosClientesAcumulados(True, 0, 9999, Now.AddDays(-15), Now)
    End Sub

    <Test()> _
    Public Sub ReporteReporteProdAlimSugDia()
        Me.Controlador.ReporteProdAlimSugDia(False, #4/20/2010#)
    End Sub

#End Region

End Class
