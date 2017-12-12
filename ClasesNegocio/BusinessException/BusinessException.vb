Imports RF = System.Reflection
Imports ECS = Integralab.ORMSeguridad.EntityClasses

Public Enum CategoriaEnumException As Integer
    REQUIERE_CONFIGURACION = 1
    VALIDACION = 2
    DATOS_NO_ENCONTRADOS = 4
    INCONSISTENCIA_DE_DATOS = 8
    DESCONOCIDO = 16
End Enum

Public Enum ModuloEnum As Integer
    NOTAS_DE_CREDITO = 0
    BALANCE_GENERAL = 1
    AUXILIAR_CONTABLE = 2
    MAYOR_GENERAL = 3
    SALIDA_RECIBA_RASTRO = 4
    GENERAL = 5
    SALIDA_RECIBA_CORRAL = 6
    CATALOGO_DE_PRECIOS_X_CLIENTE = 7
    SALIDA_RECIBA_MUERTE = 8
    REINICIO_CORRAL = 9
    SALIDA_CORRAL_RASTRO = 10
    SALIDA_CORRAL_TRANSFERENCIA = 11
    CATALOGO_CLIENTES = 12
    CAMBIO_DE_CORRAL = 13
    CIERRE_DIARIO_ENGORDA = 14
    CONFIGURACION_ENGORDA = 15
    CHEQUES_DEVUELTOS = 16
    PAGOS_CHEQUES_DEVUELTOS = 17
    PROGRAMACION_FORMULAS = 18
    SOLICITUD_PRODUCTOS = 19
    CATALOGO_LOTES = 20
    FACTURACION_FOLIOS = 21
    ORDEN_COMPRA = 22
End Enum

Public Class BusinessException
    Inherits Exception

#Region "Miembros"
    Private _Code As Integer
    Private _CodeEnum As CategoriaEnumException
    Private _message As String
    Private _SubModulo As ModuloEnum
#End Region

#Region "Propiedades"
    Public ReadOnly Property Code() As Integer
        Get
            Return _Code
        End Get
    End Property

    Public ReadOnly Property CodeEnum() As CategoriaEnumException
        Get
            Return _CodeEnum
        End Get
    End Property

    Public Overrides ReadOnly Property Message() As String
        Get
            Return _message
        End Get
    End Property

    Public ReadOnly Property SubModulo() As ModuloEnum
        Get
            Return _SubModulo
        End Get
    End Property
#End Region

#Region "Constructores"
    Public Sub New(ByVal CodEnum As CategoriaEnumException, ByVal SubModulo As ModuloEnum, ByVal Code As Integer, Optional ByVal Message As String = "")
        _CodeEnum = CodEnum
        _Code = Code
        _SubModulo = SubModulo
        _message = Message
    End Sub
#End Region

    Public Shared Function Run(ByVal Objeto As Object, ByVal Metodo As String, ByVal Parametros As Object(), ByVal Sesion As ECS.SesionesEntity, ByVal RutaAplicacion As String) As Object
        Dim Tipos() As Type = Nothing

        Try
            If Parametros IsNot Nothing Then
                For i As Integer = 0 To Parametros.Length - 1
                    ReDim Preserve Tipos(i)
                    Tipos(i) = Parametros(i).GetType()
                Next
            End If

            If Tipos Is Nothing Then
                For Each Met As RF.MethodInfo In Objeto.GetType().GetMethods()
                    If Met.Name = Metodo And Met.GetParameters().Length = 0 Then
                        If Met.IsPublic Then
                            Return Met.Invoke(Objeto, Nothing)
                            Exit For
                        Else
#If CONFIG = "Debug" Then
                            MsgBox("El Metodo [" & Metodo & "] debe ser publico", MsgBoxStyle.Critical)
#End If
                        End If
                    End If
                Next
            Else
                Dim Met As RF.MethodInfo = Objeto.GetType().GetMethod(Metodo, Tipos)

                If Met IsNot Nothing Then
                    If Met.IsPublic Then
                        Return Met.Invoke(Objeto, Parametros)
                    Else
#If CONFIG = "Debug" Then
                        MsgBox("El Metodo [" & Metodo & "] debe ser publico", MsgBoxStyle.Critical)
#End If
                    End If
                End If
            End If

        Catch ex As Exception
            If ex.InnerException.GetType() Is GetType(BusinessException) Then
                Dim ExInner As BusinessException = ex.InnerException

                Select Case ExInner.CodeEnum
                    Case CategoriaEnumException.DATOS_NO_ENCONTRADOS 'RutaAplicacion & "\i18n\es-mx.xml", 
                        MsgBox(MensajeConfiguracion(ExInner.SubModulo.ToString(), ExInner.Code).Replace("[?]", ExInner.Message), MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
                    Case CategoriaEnumException.INCONSISTENCIA_DE_DATOS
                        MsgBox(MensajeConfiguracion(ExInner.SubModulo.ToString(), ExInner.Code).Replace("[?]", ExInner.Message) & vbCrLf & "Compruebe esto en la base de datos", MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
                    Case CategoriaEnumException.REQUIERE_CONFIGURACION
                        MsgBox(MensajeConfiguracion(ExInner.SubModulo.ToString(), ExInner.Code).Replace("[?]", ExInner.Message), MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
                    Case CategoriaEnumException.VALIDACION
                        MsgBox(MensajeValidacion(ExInner.SubModulo.ToString(), ExInner.Code).Replace("[?]", ExInner.Message), MsgBoxStyle.Exclamation, Sesion.MiEmpresa.Empnom)
                    Case CategoriaEnumException.DESCONOCIDO
                        MsgBox(ExInner.Message, MsgBoxStyle.Critical, Sesion.MiEmpresa.Empnom)
                End Select
            Else
                Dim Mensaje As String = ""
#If CONFIG = "Debug" Then
                Dim Excep As Exception = ex.InnerException

                While (Excep IsNot Nothing)
                    Mensaje &= Chr(13) & Excep.Message
                    Excep = Excep.InnerException
                End While
                If Mensaje = String.Empty Then Mensaje = ex.Message
#Else
                Mensaje = "Ha ocurrido un error en el sistema"
                'proximamente incorporar log de errores
#End If
                MsgBox(Mensaje, MsgBoxStyle.Critical, Sesion.MiEmpresa.Empnom)
            End If
        End Try
        Return Nothing
    End Function

    Private Shared Function Mensaje(ByVal Tipo As CategoriaEnumException, ByVal SubModulo As String, ByVal Code As Integer) As String
        Dim Documento As New Xml.XmlDocument(), TagModulo As String

        Documento.LoadXml(My.Resources.ResourceManager.GetString(My.Resources.Culture.Name.ToLower.Replace("-", "_")))
        Documento.LoadXml(Documento.ChildNodes(0).InnerXml())

        Select Case Tipo
            Case CategoriaEnumException.DATOS_NO_ENCONTRADOS
                TagModulo = "ModuloDatosNoEncontrados"
            Case CategoriaEnumException.INCONSISTENCIA_DE_DATOS
                TagModulo = "ModuloInconsistenciaDatos"
            Case CategoriaEnumException.REQUIERE_CONFIGURACION
                TagModulo = "ModuloConfiguracion"
            Case Else 'CategoriaEnumException.VALIDACION
                TagModulo = "ModuloValidacion"
        End Select

        For Each Nodo As Xml.XmlNode In Documento.GetElementsByTagName(TagModulo)
            If Nodo.Attributes("Nombre").Value = SubModulo Then
                For Each Hijo As Xml.XmlNode In Nodo.ChildNodes
                    If Hijo.Attributes("Code").Value = Code Then
                        Return Hijo.InnerText.Trim
                    End If
                Next
            End If
        Next
        Throw New BusinessException(CategoriaEnumException.DESCONOCIDO, Nothing, 0, "Mensaje desconocido")
    End Function

    Public Shared Function MensajeDatosNoEncontrados(ByVal SubModulo As String, ByVal Code As Integer) As String
        Return Mensaje(CategoriaEnumException.DATOS_NO_ENCONTRADOS, SubModulo, Code)
    End Function

    Public Shared Function MensajeInconsistenciaDatos(ByVal SubModulo As String, ByVal Code As Integer) As String
        Return Mensaje(CategoriaEnumException.INCONSISTENCIA_DE_DATOS, SubModulo, Code)
    End Function

    Public Shared Function MensajeConfiguracion(ByVal SubModulo As String, ByVal Code As Integer) As String
        Return Mensaje(CategoriaEnumException.REQUIERE_CONFIGURACION, SubModulo, Code)
    End Function

    Public Shared Function MensajeValidacion(ByVal SubModulo As String, ByVal Code As Integer) As String
        Return Mensaje(CategoriaEnumException.VALIDACION, SubModulo, Code)
    End Function
End Class
