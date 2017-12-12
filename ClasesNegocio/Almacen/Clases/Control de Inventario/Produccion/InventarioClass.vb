Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class InventarioClass
    Implements IEntidad

#Region "Miembros"
    Dim Inventario As EC.MscinventarioProductoEntity
    Dim _Func As String
    Dim _NumOpc As Integer
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
#End Region

#Region "Constructores"
    Sub New()
        Inventario = New EC.MscinventarioProductoEntity
    End Sub

    Sub New(ByVal IdAlmacen As Integer, ByVal IdProducto As Integer)
        'pendiente por corregir
        'Inventario = New EC.MscinventarioProductoEntity(IdAlmacen, IdProducto, 1, 1)
    End Sub

    Sub New(ByVal Entidad As EC.MscinventarioProductoEntity)
        Inventario = Entidad
    End Sub
#End Region

#Region "Propiedades"
    Property IdCodAlmacen() As Integer
        Get
            Return Inventario.IdCodAlmacen
        End Get
        Set(ByVal value As Integer)
            Inventario.IdCodAlmacen = value
        End Set
    End Property

    Property IdCodProducto() As Integer
        Get
            Return Inventario.IdCodProducto
        End Get
        Set(ByVal value As Integer)
            Inventario.IdCodProducto = value
        End Set
    End Property

    Property EntKilos() As Decimal
        Get
            Return Inventario.EntKilos
        End Get
        Set(ByVal value As Decimal)
            Inventario.EntKilos = value
        End Set
    End Property

    Property EntPzas() As Integer
        Get
            Return Inventario.EntPzas
        End Get
        Set(ByVal value As Integer)
            Inventario.EntPzas = value
        End Set
    End Property

    Property ExistKilos() As Decimal
        Get
            Return Inventario.ExistKilos
        End Get
        Set(ByVal value As Decimal)
            Inventario.ExistKilos = value
        End Set
    End Property

    Property ExistPzas() As Integer
        Get
            Return Inventario.ExistPzas
        End Get
        Set(ByVal value As Integer)
            Inventario.ExistPzas = value
        End Set
    End Property

    Property SalKilos() As Decimal
        Get
            Return Inventario.SalKilos
        End Get
        Set(ByVal value As Decimal)
            Inventario.SalKilos = value
        End Set
    End Property

    Property SalPzas() As Integer
        Get
            Return Inventario.SalPzas
        End Get
        Set(ByVal value As Integer)
            Inventario.SalPzas = value
        End Set
    End Property

    Property Func() As String
        Get
            Return _Func
        End Get
        Set(ByVal value As String)
            _Func = value
        End Set
    End Property

    Property NumOpc() As Integer
        Get
            Return _NumOpc
        End Get
        Set(ByVal value As Integer)
            _NumOpc = value
        End Set
    End Property

    Public Property Año() As Integer
        Get
            Return Inventario.Año
        End Get
        Set(ByVal value As Integer)
            Inventario.Año = value
        End Set
    End Property

    Public Property Mes() As Integer
        Get
            Return Inventario.Mes
        End Get
        Set(ByVal value As Integer)
            Inventario.Mes = value
        End Set
    End Property

    Private Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        Try
            If Not (Año > 1 And Mes >= 1) Then
                Return False
            End If

            Dim inv As New EC.MscinventarioProductoEntity

            trans.Add(inv)

            If inv.FetchUsingPK(Me.IdCodAlmacen, Me.IdCodProducto, Me.Año, Me.Mes) Then
                If Me.NumOpc = 1 Then
                    inv.ExistKilos += Me.EntKilos
                    inv.ExistPzas += Me.EntPzas
                    inv.EntKilos += Me.EntKilos
                    inv.EntPzas += Me.EntPzas
                    inv.FechaUltimaEntrada = Now
                ElseIf Me.NumOpc = 2 Then
                    If Me.ExistKilos < 0 Then
                        Me.ExistKilos *= -1
                    End If

                    If Me.ExistPzas < 0 Then
                        Me.ExistPzas *= -1
                    End If

                    inv.ExistKilos -= Me.SalKilos
                    inv.ExistPzas -= Me.SalPzas
                    inv.SalKilos += Me.SalKilos
                    inv.SalPzas += Me.SalPzas
                    inv.FechaUltimaSalida = Now
                End If

                inv.Save()
            Else
                Dim col As New CC.MscinventarioProductoCollection

                trans.Add(col)

                Dim orden As New OC.SortExpression

                orden.Add(New OC.SortClause(HC.MscinventarioProductoFields.Año, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))
                orden.Add(New OC.SortClause(HC.MscinventarioProductoFields.Mes, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

                col.GetMulti(HC.MscinventarioProductoFields.IdCodAlmacen = Me.IdCodAlmacen And _
                                HC.MscinventarioProductoFields.IdCodProducto = Me.IdCodProducto, 1, orden, Nothing)

                If col.Count > 0 Then
                    Dim invNuevo As New EC.MscinventarioProductoEntity

                    trans.Add(invNuevo)

                    invNuevo.IdCodAlmacen = Me.IdCodAlmacen
                    invNuevo.IdCodProducto = Me.IdCodProducto
                    invNuevo.Año = Año
                    invNuevo.Mes = Mes

                    If Me.NumOpc = 1 Then
                        invNuevo.ExistKilos = col(0).ExistKilos + Me.EntKilos
                        invNuevo.ExistPzas = col(0).ExistPzas + Me.EntPzas
                        invNuevo.EntKilos = Me.EntKilos
                        invNuevo.EntPzas = Me.EntPzas
                        invNuevo.FechaUltimaEntrada = Now
                        invNuevo.ExtKilosInicial = col(0).ExistKilos
                        invNuevo.ExtPiezasInicial = col(0).ExistPzas
                    ElseIf Me.NumOpc = 2 Then
                        invNuevo.ExistKilos = col(0).ExistKilos - Me.SalKilos
                        invNuevo.ExistPzas = col(0).ExistPzas - Me.SalPzas
                        invNuevo.SalKilos = Me.SalKilos
                        invNuevo.SalPzas = Me.SalPzas
                        invNuevo.FechaUltimaSalida = Now
                        invNuevo.ExtKilosInicial = col(0).ExistKilos
                        invNuevo.ExtPiezasInicial = col(0).ExistPzas
                    End If

                    invNuevo.Save()
                Else
                    If Me.NumOpc = 2 Then
                        Return True
                        'If MsgBox("No hay producto en el inventario. ¿Quiere seguir con la instrucción? no se descontara del inventrio", MsgBoxStyle.Question, "Seguir con la isntrucción") = MsgBoxResult.Ok Then
                        '    Return True
                        'Else
                        '    Return False
                        'End If
                    End If

                    Dim invNuevo As New EC.MscinventarioProductoEntity

                    trans.Add(invNuevo)

                    invNuevo.IdCodAlmacen = Me.IdCodAlmacen
                    invNuevo.IdCodProducto = Me.IdCodProducto
                    invNuevo.Año = Año
                    invNuevo.Mes = Mes
                    invNuevo.ExistKilos = Me.EntKilos
                    invNuevo.ExistPzas = Me.EntPzas
                    invNuevo.EntKilos = Me.EntKilos
                    invNuevo.EntPzas = Me.EntPzas
                    invNuevo.FechaUltimaEntrada = Now
                    invNuevo.ExtKilosInicial = 0D
                    invNuevo.ExtPiezasInicial = 0D

                    invNuevo.Save()
                End If
            End If

            'ExistKilos =   ExistKilos  +   @ExistKilos,
            'ExistPzas  =   ExistPzas   +   @ExistPzas,
            'EntKilos   =   EntKilos    +   @EntKilos,
            'EntPzas    =   EntPzas     +   @EntPzas

            'If SPA.UspMscinventarioProducto(IdCodAlmacen, IdCodProducto, ExistKilos, ExistPzas, EntKilos, EntPzas, SalKilos, SalPzas, Func, NumOpc, trans) = 0 Then
            '    'RaiseEvent MensajeError(Me, "Error al guardar información en el inventario")
            '    Return False
            'End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Cancelar1() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar2() As Boolean Implements IEntidad.Guardar

    End Function
#End Region
End Class