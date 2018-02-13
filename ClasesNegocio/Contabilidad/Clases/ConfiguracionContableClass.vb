Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ConfiguracionContableClass
    Inherits ClassBase(Of EC.UsrConfigContabilidadEntity)

#Region "Miembros"

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.UsrConfigContabilidadEntity)
        MyBase.New(entidad)
    End Sub

    'Sub New(ByVal año As String, ByVal mes As String)
    '    MyBase.New(New EC.ConMesEntity(año, mes))
    'End Sub
#End Region

#Region "Propiedades"
    Public Property CancelaPolizaNeg() As String
        Get
            Return Entity.CancelacionPolizasNegativos
        End Get
        Set(ByVal value As String)
            Entity.CancelacionPolizasNegativos = value
        End Set
    End Property

    Public Property PorcIVA() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Public Property PorcISR() As Decimal
        Get
            Return Entity.Isr
        End Get
        Set(ByVal value As Decimal)
            Entity.Isr = value
        End Set
    End Property

    Public Property PorcRetencion() As Decimal
        Get
            Return Entity.TasaRetencion
        End Get
        Set(ByVal value As Decimal)
            Entity.TasaRetencion = value
        End Set
    End Property
    Public Property MostrarDomicilio() As Boolean
        Get
            Return Entity.MostrarDomicPoliza
        End Get
        Set(ByVal value As Boolean)
            Entity.MostrarDomicPoliza = value
        End Set
    End Property

    Public Property FechaCierreBanco() As Date
        Get
            Return Entity.FechaCierreDiarioBanco
        End Get
        Set(ByVal value As Date)
            Entity.FechaCierreDiarioBanco = value
        End Set
    End Property

    Public Property IVAFlete() As Decimal
        Get
            Return Entity.Ivaflete
        End Get
        Set(ByVal value As Decimal)
            Entity.Ivaflete = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Guardar1(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try

            If Not Entity.IsNew Then
                Entity.Save()
            End If

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el cierre diario de banco", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            'eliminar los datos que se tienen en la configuracion
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("PaContUsrConfigContabilidad", _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.CommandType = CommandType.StoredProcedure
                With ad.SelectCommand.Parameters
                    .Add("@Func", SqlDbType.Char).Value = "E"
                    .Add("@Opcion", SqlDbType.Int).Value = 1
                    .Add("@CancelaPolizaNegativos", SqlDbType.Char).Value = Me.CancelaPolizaNeg
                    .Add("@IVA", SqlDbType.Money).Value = Me.PorcIVA
                    .Add("@ISR", SqlDbType.Money).Value = Me.PorcISR
                    .Add("@TasaRetencion", SqlDbType.Money).Value = Me.PorcRetencion
                    .Add("@Flete", SqlDbType.Money).Value = Me.IVAFlete
                    .Add("@MostrarDomicilio", SqlDbType.Bit).Value = Me.MostrarDomicilio
                End With
                ad.SelectCommand.CommandTimeout = 30
                ad.SelectCommand.Connection.Open()
                ad.SelectCommand.ExecuteReader()
                'ad.Fill(Tabla)
                ad.SelectCommand.Connection.Close()
            End Using
            'guardar los nuevos datos de la configuración
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("PaContUsrConfigContabilidad", _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.CommandType = CommandType.StoredProcedure
                With ad.SelectCommand.Parameters
                    .Add("@Func", SqlDbType.Char).Value = "I"
                    .Add("@Opcion", SqlDbType.Int).Value = 1
                    .Add("@CancelaPolizaNegativos", SqlDbType.Char).Value = Me.CancelaPolizaNeg
                    .Add("@IVA", SqlDbType.Money).Value = Me.PorcIVA
                    .Add("@ISR", SqlDbType.Money).Value = Me.PorcISR
                    .Add("@TasaRetencion", SqlDbType.Money).Value = Me.PorcRetencion
                    .Add("@Flete", SqlDbType.Money).Value = Me.IVAFlete
                    .Add("@MostrarDomicilio", SqlDbType.Bit).Value = Me.MostrarDomicilio
                End With

                ad.SelectCommand.CommandTimeout = 30
                ad.SelectCommand.Connection.Open()
                ad.SelectCommand.ExecuteReader()
                'ad.Fill(Tabla)
                ad.SelectCommand.Connection.Close()
            End Using

            ' If Entity.IsNew Then
            'Dim col As New CC.UsrConfigContabilidadCollection
            'If col.GetDbCount(HC.ConMesFields.NumMes = Mes And HC.ConMesFields.NumYear = Año) > 0 Then
            'MsgBox("Ya exite el mes en el año seleccionado", MsgBoxStyle.Exclamation, "Aviso")
            'Return False
            'Entity.Save()
            'Else
            'Entity.Save()
            'End If

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el mes", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function



    Public Function Obtener(ByVal año As Integer, ByVal mes As Integer) As Boolean
        'Return Entity.FetchUsingPK(año, mes.ToString("00"))
    End Function
#End Region

#Region "Eventos"

#End Region
End Class
