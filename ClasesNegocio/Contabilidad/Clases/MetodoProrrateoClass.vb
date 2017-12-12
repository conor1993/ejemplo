Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Data.SqlClient

Public Class MetodoProrrateoClass
    Inherits ClassBase(Of EC.MetodoCabEntity)

#Region "Miembros"
    Private WithEvents m_Detalle As MetodoProrrateoDetalleCollectionClass
    Private m_SumaPorcentaje As Decimal

#Region "Eventos"
    Public Event ProcentajeModificado As CampoModificado(Of Decimal)
#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal IdMetodoProrrateo As Integer)
        MyBase.New(New EC.MetodoCabEntity(IdMetodoProrrateo))
    End Sub

    Sub New(ByVal entidad As EC.MetodoCabEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Código")> _
    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Private Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    <ComponentModel.DisplayName("Descripción")> _
    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As MetodoProrrateoDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New MetodoProrrateoDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.MetodoDet)
                InicializarDetalle()
            End If

            Return m_Detalle
        End Get
    End Property

    Public Property SumaPorcentaje() As Decimal
        Get
            Return m_SumaPorcentaje
        End Get
        Set(ByVal value As Decimal)
            m_SumaPorcentaje = value
        End Set
    End Property
    
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Dim trans As SqlTransaction = Nothing
        Dim sqlCon As New SqlConnection(HC.DbUtils.ActualConnectionString)
        Dim transL As New HC.Transaction(IsolationLevel.ReadCommitted, "X")

        Try
            If Not ValidarGuardar() Then
                Return False
            End If

            If Entity.IsNew Then
                transL.Add(Entity)

                If Not Entity.Save() Then
                    transL.Rollback()
                    MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
                    Return False
                End If

                For i As Integer = Detalle.Count - 1 To 0 Step -1
                    If Detalle(i).Porcentaje <= 0 Then
                        Detalle.RemoveAt(i)
                    End If
                Next

                

                Dim col As CC.MetodoDetCollection = Detalle.ObtenerColeccion

                transL.Add(col)

                If col.SaveMulti() = 0 Then
                    trans.Rollback()
                    MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
                    Return False
                End If

                transL.Commit()
            Else
                sqlCon.Open()
                trans = sqlCon.BeginTransaction(IsolationLevel.ReadCommitted, "X")

                Dim sqlComBorrar As New SqlCommand("Delete MetodoDet WHERE Cod_Metodo=" & Me.Codigo, sqlCon, trans)
                Dim sqlComGuardarDet As New SqlCommand("INSERT INTO MetodoDet VALUES(@Codigo,@Dep,@Porcentaje)", sqlCon, trans)
                Dim sqlComActualizar As New SqlCommand("UPDATE MetodoCab SET Descripcion=@Descripcion WHERE Codigo=" & Me.Codigo, sqlCon, trans)
                Dim guardoDetalle As Boolean

                With sqlComGuardarDet.Parameters
                    .Add("@Codigo", SqlDbType.Int)
                    .Add("@Dep", SqlDbType.SmallInt)
                    .Add("@Porcentaje", SqlDbType.SmallMoney)
                End With

                sqlComActualizar.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Me.Descripcion

                If sqlComBorrar.ExecuteNonQuery() = 0 Then
                    trans.Rollback()
                    MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
                    Return False
                End If

                If sqlComActualizar.ExecuteNonQuery() = 0 Then
                    trans.Rollback()
                    MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
                    Return False
                End If

                sqlComGuardarDet.Prepare()

                For Each det As MetodoProrrateoDetalleClass In Detalle
                    If det.Porcentaje > 0D Then
                        With sqlComGuardarDet
                            .Parameters(0).Value = Me.Codigo
                            .Parameters(1).Value = det.IdDepartamento
                            .Parameters(2).Value = det.Porcentaje
                        End With

                        If sqlComGuardarDet.ExecuteNonQuery() = 0 Then
                            trans.Rollback()
                            MsgBox("Ocurrio un error al guardar", MsgBoxStyle.Critical, "Error")
                            Return False
                        End If

                        guardoDetalle = True
                    End If
                Next

                If Not guardoDetalle Then
                    trans.Rollback()
                    MsgBox("No cuenta con departamentos a guardar", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If

                trans.Commit()
            End If

            Return True
        Catch ex As Exception
            If trans IsNot Nothing Then
                trans.Rollback()
            End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Function

    Private Shadows Function ValidarGuardar() As Boolean
        Try
            If Not Me.SumaPorcentaje = 100D Then
                MsgBox("La suma del porcentaje de todos los departamentos debe ser igual a 100", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Me.Descripcion = "" Then
                MsgBox("Debe ingresar un descripción", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            Dim col As New CC.MetodoCabCollection

            If Entity.IsNew Then
                If col.GetDbCount(HC.MetodoCabFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe un metodo de prorrateo con la misma descrioción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                If col.GetDbCount(Not HC.MetodoCabFields.Codigo = Me.Codigo And HC.MetodoCabFields.Descripcion = Me.Descripcion) > 0 Then
                    MsgBox("Ya existe un metodo de prorrateo con la misma descrioción", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al validar el guardado", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function

    Private Sub InicializarDetalle()
        Try
            Dim col As New CC.CatDeptosCollection
            Dim lista As New List(Of Integer)

            For Each det As MetodoProrrateoDetalleClass In Me.Detalle
                lista.Add(det.IdDepartamento)
            Next

            If lista.Count > 0 Then
                col.GetMulti(HC.CatDeptosFields.Estatus = EstatusDepartamento.ACTIVO And _
                            New OC.FieldCompareRangePredicate(HC.CatDeptosFields.CveDepto, True, lista.ToArray))
            Else
                col.GetMulti(HC.CatDeptosFields.Estatus = EstatusDepartamento.ACTIVO)
            End If

            For Each dep As EC.CatDeptosEntity In col
                Dim det As New MetodoProrrateoDetalleClass

                det.MetodoProrrateo = Me
                det.Departamento = New DepartamentosClass(dep)
                Me.m_Detalle.Add(det)
            Next
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub
    Public Function Obtener(ByVal IdMetodo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdMetodo)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al obtener el metodo", MsgBoxStyle.Critical, "Error")
#End If
            Return False
        End Try
    End Function
#End Region


#Region "Eventos"
    Private Sub m_Detalle_ItemModificado(ByRef coleccion As Object, ByVal index As Integer, ByRef itemSel As MetodoProrrateoDetalleClass) Handles m_Detalle.ItemModificado
        Me.SumaPorcentaje = 0D

        For Each det As MetodoProrrateoDetalleClass In Detalle
            Me.SumaPorcentaje += det.Porcentaje
        Next

        If SumaPorcentaje > 100D Then
            itemSel.Porcentaje = 100D - (SumaPorcentaje - itemSel.Porcentaje)
        End If

        RaiseEvent ProcentajeModificado(Me, Me.SumaPorcentaje)
    End Sub
#End Region
End Class