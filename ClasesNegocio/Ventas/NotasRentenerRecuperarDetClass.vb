Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System
Imports System.Windows.Forms
Public Class NotasRentenerRecuperarDetClass
    Inherits ClassBase(Of EC.PvnotasVentaRetDetEntity)
    Dim _producto As ProductoGeneralClass
    Sub New(ByVal codigo As Integer, ByVal consecutivo As Integer)
        Me.Obtener(codigo, consecutivo)
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
    '<System.ComponentModel.DisplayName("ID")> _
    Public Property IdNota() As Integer
        Get
            Return Entity.IdNota
        End Get
        Set(value As Integer)
            Entity.IdNota = value
        End Set
    End Property

    Public Property Consecutivo() As Integer
        Get
            Return Entity.Consecutivo
        End Get
        Set(value As Integer)
            Entity.Consecutivo = value
        End Set
    End Property

    Public Property CodArticulo() As Integer
        Get
            Return Entity.CodArticulo
        End Get
        Set(value As Integer)
            Entity.CodArticulo = value
        End Set
    End Property

    Public Property Cantidad() As Decimal?
        Get
            Return Entity.Cantidad
        End Get
        Set(value As Decimal?)
            Entity.Cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario() As Decimal
        Get
            Return Entity.PrecioUnit
        End Get
        Set(value As Decimal)
            Entity.PrecioUnit = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Entity.Descuento
        End Get
        Set(value As Decimal)
            Entity.Descuento = value
        End Set
    End Property

    Public Property Iva() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Public Property Ieps() As Decimal
        Get
            Return Entity.Ieps
        End Get
        Set(value As Decimal)
            Entity.Ieps = value
        End Set
    End Property

    Public Property IdProdComp() As Integer
        Get
            Return Entity.IdProdComp
        End Get
        Set(value As Integer)
            Entity.IdProdComp = value
        End Set
    End Property

    Public Property Eskit() As Boolean
        Get
            Return Entity.EsKit
        End Get
        Set(value As Boolean)
            Entity.EsKit = value
        End Set
    End Property

    Public ReadOnly Property Articulo As ProductoGeneralClass
        Get
            If _producto Is Nothing Then _producto = New ProductoGeneralClass(Me.CodArticulo)
            Return _producto
        End Get
    End Property



            '<System.ComponentModel.DisplayName("Nombre ID")> _
            'Public Property NomId() As String
            '    Get
            '        Return Entity.IdNom
            '    End Get
            '    Set(value As String)
            '        Entity.IdNom = value
            '    End Set
            'End Property


            '<System.ComponentModel.DisplayName("NumArticulos")> _
            'Public Property NumArticulos() As Short
            '    Get
            '        Return Entity.NumArticulos
            '    End Get
            '    Set(value As Short)
            '        Entity.NumArticulos = value
            '    End Set
            'End Property

            '<System.ComponentModel.DisplayName("Total")> _
            'Public Property Total() As Decimal
            '    Get
            '        Return Entity.Total
            '    End Get
            '    Set(value As Decimal)
            '        Entity.Total = value
            '    End Set
            'End Property


            '<System.ComponentModel.DisplayName("Nombre ID")> _
            'Public Property Fecha() As DateTime
            '    Get
            '        Return Entity.Fecha
            '    End Get
            '    Set(value As DateTime)
            '        Entity.Fecha = value
            '    End Set
            'End Property

            '<System.ComponentModel.DisplayName("Nombre ID")> _
            'Public Property CodUsuario() As Integer
            '    Get
            '        Return Entity.CodUsuario
            '    End Get
            '    Set(value As Integer)
            '        Entity.CodUsuario = value
            '    End Set
            'End Property
#End Region

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

    Public Function Obtener(ByVal Codigo As Integer, ByVal consecutivo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo, consecutivo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Sub LeerEntidad(ByVal EntidadL As EC.PvnotasVentaRetDetEntity)
        Me.Entity = EntidadL
    End Sub

    Public Function ObtenerEntidad() As EC.PvnotasVentaRetDetEntity
        Return Me.Entity
    End Function
#End Region






End Class

Public Class NotasRentenerRecuperarDetCollectionClass
    Inherits ColleccionBase(Of EC.PvnotasVentaRetDetEntity, CC.PvnotasVentaRetDetCollection, NotasRentenerRecuperarDetClass)
    Dim filtro As OC.PredicateExpression

#Region "Metodos"
    Public Shadows Sub Add(ByVal item As NotasRentenerRecuperarDetClass)
        MyBase.Add(item)
    End Sub

    Sub New(ByVal idnota As Integer)
        filtro = New OC.PredicateExpression
        filtro.Add(HC.PvnotasVentaRetDetFields.IdNota = idnota)
        Me.Obtener(filtro)
    End Sub

    Sub New()

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
