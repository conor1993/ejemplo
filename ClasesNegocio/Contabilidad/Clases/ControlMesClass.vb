Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ControlMesClass
    Inherits ClassBase(Of EC.ConMesEntity)

#Region "Miembros"

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.ConMesEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal a�o As String, ByVal mes As String)
        MyBase.New(New EC.ConMesEntity(a�o, mes))
    End Sub
#End Region

#Region "Propiedades"
    Public Property A�o() As String
        Get
            Return Entity.NumYear
        End Get
        Set(ByVal value As String)
            Entity.NumYear = value
        End Set
    End Property

    Public Property Mes() As MesEnum2
        Get
            Return CInt(Entity.NumMes)
        End Get
        Set(ByVal value As MesEnum2)
            Entity.NumMes = CInt(value).ToString("00")
        End Set
    End Property

    Public Property NumMes() As String
        Get
            Return Entity.NumMes
        End Get
        Set(ByVal value As String)
            Entity.NumMes = value.ToString("00")
        End Set
    End Property

    Public Property Estatus() As EstatusMes
        Get
            Return Asc(Entity.Abierto)
        End Get
        Set(ByVal value As EstatusMes)
            Entity.Abierto = Chr(CInt(value))
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Mes = Nothing Then
                MsgBox("Debe establecer un mes", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            ElseIf A�o = "" Then
                MsgBox("Debe establecer un a�o", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Entity.IsNew Then
                Dim col As New CC.ConMesCollection

                If col.GetDbCount(HC.ConMesFields.NumMes = Mes And HC.ConMesFields.NumYear = A�o) > 0 Then
                    MsgBox("Ya exite el mes en el a�o seleccionado", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                Entity.Save()
            Else
                Entity.Save()
            End If

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al guardar el mes", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function ModificarEstatus(ByVal Estatus As String, ByVal trans As HC.Transaction) As Boolean
        trans.Add(Entity)
        Entity.Abierto = Estatus
        Entity.Save()
    End Function

    Public Function GenerarMeses(ByVal fcA�o As String) As Boolean
        Try
            Dim col As New CC.ConMesCollection

            col.GetMulti(HC.ConMesFields.NumYear = fcA�o)

            For i As Integer = 1 To 12
                Dim encontro As Boolean = False

                For Each ent As EC.ConMesEntity In col
                    If i.ToString("00") = ent.NumMes Then
                        encontro = True
                        Exit For
                    End If
                Next

                If Not encontro Then
                    Dim ent As New EC.ConMesEntity

                    ent.NumMes = i.ToString("00")
                    ent.NumYear = fcA�o

                    col.Add(ent)
                End If
            Next

            col.SaveMulti()

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al generar los meses", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal a�o As Integer, ByVal mes As Integer) As Boolean
        Return Entity.FetchUsingPK(a�o, mes.ToString("00"))
    End Function
#End Region

#Region "Eventos"

#End Region
End Class