Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System
Imports System.Windows.Forms



Public Class NotasRentenerRecuperarCabClass
    Inherits ClassBase(Of EC.PvnotasVentaRetCabEntity)
    Dim _Detalle As NotasRentenerRecuperarDetCollectionClass

    Sub New(ByVal codigo As Integer)
        Me.Obtener(codigo)
    End Sub

   
    Sub New()

    End Sub
 

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el codigo del retiro de caja
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DisplayName("ID")> _
    Public ReadOnly Property Id() As Integer
        Get
            Return Entity.Id
        End Get
    End Property

    <System.ComponentModel.DisplayName("Nombre ID")> _
    Public Property NomId() As String
        Get
            Return Entity.IdNom
        End Get
        Set(value As String)
            Entity.IdNom = value
        End Set
    End Property


    <System.ComponentModel.DisplayName("NumArticulos")> _
    Public Property NumArticulos() As Short
        Get
            Return Entity.NumArticulos
        End Get
        Set(value As Short)
            Entity.NumArticulos = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Total")> _
    Public Property Total() As Decimal
        Get
            Return Entity.Total
        End Get
        Set(value As Decimal)
            Entity.Total = value
        End Set
    End Property


    <System.ComponentModel.DisplayName("Nombre ID")> _
    Public Property Fecha() As DateTime
        Get
            Return Entity.Fecha
        End Get
        Set(value As DateTime)
            Entity.Fecha = value
        End Set
    End Property

    <System.ComponentModel.DisplayName("Nombre ID")> _
    Public Property CodUsuario() As Integer
        Get
            Return Entity.CodUsuario
        End Get
        Set(value As Integer)
            Entity.CodUsuario = value
        End Set
    End Property


    <System.ComponentModel.DisplayName("Nombre ID")> _
    Public ReadOnly Property Detalle() As NotasRentenerRecuperarDetCollectionClass
        Get
            'Dim filtro As New OC.PredicateExpression
            'filtro.Add(HC.PvnotasVentaRetDetFields.IdNota = Me.Id)
            If _Detalle Is Nothing Then
                _Detalle = New NotasRentenerRecuperarDetCollectionClass(Me.Id)

            End If

            Return _Detalle
        End Get
    End Property

#Region "Metodos"
    Public Function Borrar() As Boolean
        Try
            Return Entity.Delete()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return False
    End Function

    Public Function Guardar(Optional ByVal ApplicationName As String = "") As Boolean
        Try
            '  Dim col As New CC.RetiroCajaCollection

            'If Entity.IsNew Then
            '    If System.Convert.IsDBNull(Entity.FechaHora) Then
            '        MsgBox("No se puede tener fecha de fin al abrir un control de turno.", MsgBoxStyle.Exclamation, "")
            '        Return False
            '    End If
            'Else
            '    If col.GetDbCount(HC.RetiroCajaFields.FechaHora <= Entity.FechaHora) > 0 Then
            '        MsgBox("La fecha de inicio se traslapa con otro control de turno.", MsgBoxStyle.Exclamation, "Lapso de tiempo traslapado")
            '        Return False
            '    End If
            'End If
            Return Entity.Save()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal EntidadL As EC.PvnotasVentaRetCabEntity)
        Me.Entity = EntidadL
    End Sub

    Public Function ObtenerEntidad() As EC.PvnotasVentaRetCabEntity
        Return Me.Entity
    End Function
#End Region




#End Region

End Class

Public Class NotasRentenerRecuperarCabCollectionClass
    Inherits ColleccionBase(Of EC.PvnotasVentaRetCabEntity, CC.PvnotasVentaRetCabCollection, NotasRentenerRecuperarCabClass)

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As NotasRentenerRecuperarCabClass)
        MyBase.Add(item)
    End Sub

    Public Overloads Function Obtener() As Integer
        Try
            coleccion.GetMulti(Nothing)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal filtro As OC.PredicateExpression) As Integer
        Try
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function

  
#End Region

End Class
