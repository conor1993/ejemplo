Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Delegate Sub CampoModificado(Of tipo)(ByVal sender As Object, ByRef valor As tipo)

Partial Public MustInherit Class ClassBase(Of TipoEntity As {OC.EntityBase, New})
    Implements ICloneable, SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement

#Region "Miembros"
    Protected WithEvents Entity As TipoEntity
#End Region

#Region "Constructores"
    Public Sub New()
        Entity = New TipoEntity
    End Sub

    Public Sub New(ByRef Entidad As TipoEntity)
        Entity = Entidad
    End Sub
#End Region


#Region "Datos ITransactionalElement"
    Private WithEvents m_Transaccion As HC.Transaction

#Region "Propiedades"
    Public Property Transaction() As SD.LLBLGen.Pro.ORMSupportClasses.ITransaction Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.Transaction
        Get
            Return Me.m_Transaccion
        End Get
        Set(ByVal value As SD.LLBLGen.Pro.ORMSupportClasses.ITransaction)
            Me.m_Transaccion = value
        End Set
    End Property

    Public ReadOnly Property ParticipatesInTransaction() As Boolean Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.ParticipatesInTransaction
        Get
            Return Me.Transaction IsNot Nothing
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Sub TransactionCommit() Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.TransactionCommit
        If Me.Transaction IsNot Nothing Then Me.Transaction.Commit()
    End Sub

    Public Sub TransactionRollback() Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.TransactionRollback
        If Me.Transaction IsNot Nothing Then Me.Transaction.Rollback()
    End Sub
#End Region
#End Region

#Region "Metodos"
    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim m As New MemoryStream()
        Dim f As New BinaryFormatter()
        f.Serialize(m, Me)
        m.Seek(0, SeekOrigin.Begin)
        Return f.Deserialize(m)
    End Function

    Public Function ObtenerEntidad() As TipoEntity
        Return Entity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As TipoEntity)
        Entity = Entidad
    End Sub

    Protected Overridable Function ValidarGuardar() As Boolean
        Try
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Protected Overridable Function ValidarBorrar() As Boolean
        Try
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Overridable Function Guardar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Trans IsNot Nothing Then
                Trans.Add(Entity)
            End If

            If Not ValidarGuardar() Then
                Return False
            End If

            Return Entity.Save()
        Catch ex As Exception

            Dim sqlExep As SqlClient.SqlException = CType(ex.InnerException, SqlClient.SqlException)
            If sqlExep.Number = 2627 Or sqlExep.Number = 2601 Then
                MsgBox("Esta intentando insertar un registro que ya existe." & vbLf & sqlExep.Message.ToString, MsgBoxStyle.Critical, Entidad.GetType.FullName.ToString)
                Trans.Rollback()
                Return False
            End If

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Trans.Rollback()
            Return False
        End Try
    End Function

    Public Overridable Function Borrar(Optional ByVal Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Trans IsNot Nothing Then
                Trans.Add(Entity)
            End If

            Try
                Entity.GetType.GetProperty("Estatus").SetValue(Entity, CShort(0), Nothing)
                'Entity.Delete()
            Catch ex As Exception

            End Try

            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    
#End Region
End Class

Public Interface iMainForm
    Sub LlamaForma(Of tipoForma As {System.Windows.Forms.Form, IDisposable, New})()
End Interface

Public Class ClassBase(Of TipoEntity As {OC.EntityBase, New})

#Region "Miembros"
    Protected Friend m_Seleccionado As Boolean = False
    Protected Friend m_Contenedor As Object

#Region "Eventos"
    Public Event SeleccionadoModificado As CampoModificado(Of Boolean)
    Protected Friend Event ItemSeleccionado As CampoModificado(Of Boolean)
    Public Event EntidadModificada As CampoModificado(Of TipoEntity)
    Public Event ContenedorModificado As CampoModificado(Of Object)
    Protected Friend Event ItemModificado(ByRef item As Object, ByVal e As EventArgs)
#End Region
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece la entity de la clase que contien todos los valores y relaciones
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Entidad() As TipoEntity
        Get
            Return Entity
        End Get
        Set(ByVal value As TipoEntity)
            Entity = value

            RaiseEvent EntidadModificada(Me, value)
            RaiseEvent ItemModificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si este elemento se ecnuentra seleccionado 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Seleccionado() As Boolean
        Get
            Return m_Seleccionado
        End Get
        Set(ByVal value As Boolean)
            m_Seleccionado = value

            RaiseEvent SeleccionadoModificado(Me, m_Seleccionado)
            RaiseEvent ItemSeleccionado(Me, m_Seleccionado)
            RaiseEvent ItemModificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el contenedor donde se encuentra la entidad.
    ''' Para obtener la entidad en el tipo que corresponda use el metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Contenedor() As Object
        Get
            Return m_Contenedor
        End Get
        Set(ByVal value As Object)
            m_Contenedor = value

            RaiseEvent ItemModificado(Me, New EventArgs)
        End Set
    End Property

    ''' <summary>
    ''' Obtiene el Indice de la colección donde se encuentra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Obtiene el Indice de la colección donde se encuentra")> _
    Public ReadOnly Property IndiceEnContenedor() As Integer
        Get
            Dim num As Integer

            If m_Contenedor IsNot Nothing Then
                Try
                    num = Me.Contenedor.GetType.GetMethod("IndexOf").Invoke(m_Contenedor, _
                            Reflection.BindingFlags.ExactBinding, Nothing, New Object() {Me}, Nothing)
                Catch ex As Exception
                    num = -1
                End Try
            Else
                num = -1
            End If

            Return num
        End Get
    End Property
#End Region

#Region "Metodos"
    Protected Friend Sub OnItemModificado()
        RaiseEvent ItemModificado(Me, New EventArgs)
    End Sub
#End Region
End Class

''' <summary>
''' Clase Generica con mejoras de la BindingList(Of Tipye) para usarse con Entity
''' </summary>
''' <typeparam name="TipoEntity"></typeparam>
''' <typeparam name="TipoCollection"></typeparam>
''' <typeparam name="TipoEntidad"></typeparam>
''' <remarks></remarks>
Partial Public MustInherit Class ColleccionBase(Of TipoEntity As {OC.EntityBase, New}, TipoCollection As {OC.EntityCollectionBase(Of TipoEntity), New}, _
                   TipoEntidad As {ClassBase(Of TipoEntity), New})
    Inherits System.ComponentModel.BindingList(Of TipoEntidad)
    Implements ComponentModel.IComponent, ComponentModel.ISite, SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement

#Region "Miembros"
    Private ordenar As New OrdenarClass(Of ColleccionBase(Of TipoEntity, TipoCollection, TipoEntidad))
    Protected coleccion As New TipoCollection

#End Region

#Region "Datos Componente"

    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.ComponentModel.IComponent.Disposed
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private m_cursite As System.ComponentModel.ISite
    Private m_component As System.ComponentModel.IComponent
    Private m_container As System.ComponentModel.IContainer
    Private m_designmode As Boolean = False
    Private m_Name As String
    Private m_getservice As System.IServiceProvider

#Region "Property"

    Public Property Site() As System.ComponentModel.ISite Implements System.ComponentModel.IComponent.Site
        Get
            Return m_cursite
        End Get
        Set(ByVal value As System.ComponentModel.ISite)
            m_cursite = value
        End Set
    End Property

    Public ReadOnly Property Component() As System.ComponentModel.IComponent Implements System.ComponentModel.ISite.Component
        Get
            Return m_component
        End Get
    End Property

    Public ReadOnly Property Container() As System.ComponentModel.IContainer Implements System.ComponentModel.ISite.Container
        Get
            Return m_container
        End Get
    End Property

    Public ReadOnly Property DesignMode() As Boolean Implements System.ComponentModel.ISite.DesignMode
        Get
            Return m_designmode
        End Get
    End Property

    Public Property Name() As String Implements System.ComponentModel.ISite.Name
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

#End Region

    Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
        Return m_getservice.GetService(serviceType)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If

            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region

#Region "Datos de Ordenacion"
    Protected Overrides Sub ApplySortCore(ByVal prop As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection)
        Direc = direction
        Propiedad = prop

        If Count > 0 Then
            Dim TipoDato As TipoDatoEnum = TipoDatoEnum.NUMERO
            Dim proInf As System.Reflection.PropertyInfo = GetType(TipoEntidad).GetProperty(prop.Name)

            Select Case proInf.GetValue(Me(0), Nothing).GetType.ToString
                Case "System.Int16"
                Case "System.Int32"
                Case "System.Int64"
                Case "System.Decimal"
                Case "System.Double"
                Case "System.Single"
                Case "System.SByte"
                Case "System.DateTime"
                    TipoDato = TipoDatoEnum.FECHA
                Case "System.Byte"
                Case Else
                    TipoDato = TipoDatoEnum.CADENA
            End Select

            ordenar.Ordenar(Me, 0, Me.Count - 1, Direc, TipoDato, proInf)
        End If

        EstaOrdenada = True

        Me.OnListChanged(New System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, prop))
    End Sub

    Protected Overrides Sub RemoveSortCore()

    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Dim Direc As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Descending
    Protected Overrides ReadOnly Property SortDirectionCore() As System.ComponentModel.ListSortDirection
        Get
            Return Direc
        End Get
    End Property

    Dim Propiedad As System.ComponentModel.PropertyDescriptor
    Protected Overrides ReadOnly Property SortPropertyCore() As System.ComponentModel.PropertyDescriptor
        Get
            Return Propiedad
        End Get
    End Property

    Private EstaOrdenada As Boolean = False
    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return EstaOrdenada
        End Get
    End Property
#End Region

#Region "Datos ITransactionalElement"
    Private WithEvents m_Transaccion As HC.Transaction

#Region "Propiedades"
    Public Property Transaction() As SD.LLBLGen.Pro.ORMSupportClasses.ITransaction Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.Transaction
        Get
            Return Me.m_Transaccion
        End Get
        Set(ByVal value As SD.LLBLGen.Pro.ORMSupportClasses.ITransaction)
            Me.m_Transaccion = value
        End Set
    End Property

    Public ReadOnly Property ParticipatesInTransaction() As Boolean Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.ParticipatesInTransaction
        Get
            Return Me.Transaction IsNot Nothing
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Sub TransactionCommit() Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.TransactionCommit
        If Me.Transaction IsNot Nothing Then Me.Transaction.Commit()
    End Sub

    Public Sub TransactionRollback() Implements SD.LLBLGen.Pro.ORMSupportClasses.ITransactionalElement.TransactionRollback
        If Me.Transaction IsNot Nothing Then Me.Transaction.Rollback()
    End Sub
#End Region
#End Region

#Region "Clases"
    Private Class OrdenarClass(Of TipoColeccion As ColleccionBase(Of TipoEntity, TipoCollection, TipoEntidad))

        Public Sub Ordenar(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal tipoDato As TipoDatoEnum, ByVal propInf As System.Reflection.PropertyInfo)

            If tipoDato = ColleccionBase(Of TipoEntity, TipoCollection, TipoEntidad).TipoDatoEnum.CADENA Then
                Me.OrdenarCadenas(FcColeccion, Inf, Sup, Ordenamiento, propInf)
            Else
                Me.OrdenarNumeroOFecha(FcColeccion, Inf, Sup, Ordenamiento, propInf)
            End If
            'If Inf = Sup Then Exit Sub

            'Dim Leng As Integer = Sup - Inf + 1
            'Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

            'Ordenar(FcColeccion, Inf, Sel, Ordenamiento, tipoDato, propInf)
            'Ordenar(FcColeccion, Sel + 1, Sup, Ordenamiento, tipoDato, propInf)

            'Dim temp(Leng) As TipoEntidad

            'For i As Integer = 0 To Leng - 1
            '    temp(i) = FcColeccion(Inf + i)
            'Next

            'Dim M1 As Integer = 0
            'Dim M2 As Integer = Sel - Inf + 1
            'Dim n1, n2 As Decimal
            'Dim n3 As String = ""
            'Dim n4 As String = "-"
            'Dim d1 As Date = #1/1/1990#
            'Dim d2 As Date = #1/1/1990#

            'For i As Integer = 0 To Leng - 1
            '    If M2 <= (Sup - Inf) Then
            '        If M1 <= (Sel - Inf) Then
            '            If tipoDato = TipoDatoEnum.NUMERO Then
            '                n1 = propInf.GetValue(temp(M1), Nothing)
            '                n2 = propInf.GetValue(temp(M2), Nothing)
            '            ElseIf tipoDato = TipoDatoEnum.CADENA Then
            '                n3 = propInf.GetValue(temp(M1), Nothing).ToString
            '                n4 = propInf.GetValue(temp(M2), Nothing).ToString
            '            Else
            '                d1 = propInf.GetValue(temp(M1), Nothing)
            '                d2 = propInf.GetValue(temp(M2), Nothing)
            '            End If

            '            If IIf(tipoDato = TipoDatoEnum.NUMERO, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
            '                IIf(tipoDato = TipoDatoEnum.CADENA, _
            '                IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
            '                IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2))) Then
            '                FcColeccion(i + Inf) = temp(M2)
            '                M2 += 1
            '            Else
            '                FcColeccion(i + Inf) = temp(M1)
            '                M1 += 1
            '            End If
            '        Else
            '            FcColeccion(i + Inf) = temp(M2)
            '            M2 += 1
            '        End If
            '    Else
            '        FcColeccion(i + Inf) = temp(M1)
            '        M1 += 1
            '    End If
            'Next
        End Sub

        Private Sub OrdenarNumeroOFecha(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal propInf As System.Reflection.PropertyInfo)
            If Inf = Sup Then Exit Sub

            Dim Leng As Integer = Sup - Inf + 1
            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

            OrdenarNumeroOFecha(FcColeccion, Inf, Sel, Ordenamiento, propInf)
            OrdenarNumeroOFecha(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf)

            Dim temp(Leng) As TipoEntidad

            For i As Integer = 0 To Leng - 1
                temp(i) = FcColeccion(Inf + i)
            Next

            Dim M1 As Integer = 0
            Dim M2 As Integer = Sel - Inf + 1

            If Ordenamiento = ComponentModel.ListSortDirection.Ascending Then
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If propInf.GetValue(temp(M1), Nothing) > propInf.GetValue(temp(M2), Nothing) Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            Else
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If propInf.GetValue(temp(M1), Nothing) < propInf.GetValue(temp(M2), Nothing) Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            End If
        End Sub

        Private Sub OrdenarCadenas(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal propInf As System.Reflection.PropertyInfo)
            If Inf = Sup Then Exit Sub

            Dim Leng As Integer = Sup - Inf + 1
            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

            OrdenarCadenas(FcColeccion, Inf, Sel, Ordenamiento, propInf)
            OrdenarCadenas(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf)

            Dim temp(Leng) As TipoEntidad

            For i As Integer = 0 To Leng - 1
                temp(i) = FcColeccion(Inf + i)
            Next

            Dim M1 As Integer = 0
            Dim M2 As Integer = Sel - Inf + 1

            If Ordenamiento = ComponentModel.ListSortDirection.Ascending Then
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If String.Compare(propInf.GetValue(temp(M1), Nothing).ToString, propInf.GetValue(temp(M2), Nothing).ToString) > 0 Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            Else
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If String.Compare(propInf.GetValue(temp(M1), Nothing).ToString, propInf.GetValue(temp(M2), Nothing).ToString) < 0 Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            End If
        End Sub
    End Class
#End Region

#Region "Enumeradores"
    ''' <summary>
    ''' Sirve para especificar que tipo de dato se esta empleando
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum TipoDatoEnum
        FECHA
        NUMERO
        CADENA
    End Enum
#End Region

End Class

Public Class ColleccionBase(Of TipoEntity As {OC.EntityBase, New}, TipoCollection As {OC.EntityCollectionBase(Of TipoEntity), New}, _
                    TipoEntidad As {ClassBase(Of TipoEntity), New})

#Region "Miembros"
    Private m_Rellenando As Boolean = False
    Protected Friend m_MaximoSeleccionados As Integer = 1
    Protected Friend m_NumSeleccionados As Integer
    Protected Friend m_MostrarMensaje As Boolean
    Protected Friend m_MensajeMaximoElementos As String = "Ya se selecciono el maximo de elementos permitidos"

#Region "Eventos"
    ''' <summary>
    ''' Evento que se ejecuta cuando se modifica la propiedad seleccionado de un elemento de la colección
    ''' </summary>
    ''' <param name="coleccion">Objeto que dispara el evento</param>
    ''' <param name="e">Tipo de Evento</param>
    ''' <param name="index">Indice en el que se encuentra el elemento modificado</param>
    ''' <param name="itemSel">Elemento Modificado</param>
    ''' <param name="valor">Valor de la propiedad seleccionado del elemento</param>
    ''' <remarks></remarks>
    <ComponentModel.Description("Se ejecuta cuando se modifica la propiedad seleccionado de un elemento de la colección.")> _
    Public Event ItemSeleccionado(ByRef coleccion As Object, ByVal index As Integer, ByRef itemSel As TipoEntidad, ByRef valor As Boolean)

    ''' <summary>
    ''' Evento que se ejecuta cuando algun elemento de la colección es modificado
    ''' </summary>
    ''' <param name="coleccion">Colección en la que se encuentra el elemento</param>
    ''' <param name="e">Tipo de Evento</param>
    ''' <param name="index">Indice donde se encuentra el elemento</param>
    ''' <param name="itemSel">Elemento que fue modificado</param>
    ''' <remarks></remarks>
    <ComponentModel.Description("Se ejecuta cuando algún elemento de la colección es modificado.")> _
    Public Event ItemModificado(ByRef coleccion As Object, ByVal index As Integer, ByRef itemSel As TipoEntidad)
#End Region
#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal Collection As TipoCollection)
        Me.coleccion = Collection
        Me.Rellenar()
    End Sub

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Indica cuantos elementos en la coleccion es posible que puedan tener su propiedad Seleccionado en True
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Indica cuantos elementos en la coleccion es posible que puedan tener su propiedad Seleccionado en True")> _
    Public Property MaximoElementosSeleccionados() As Integer
        Get
            Return m_MaximoSeleccionados
        End Get
        Set(ByVal value As Integer)
            m_MaximoSeleccionados = value
        End Set
    End Property

    ''' <summary>
    ''' Numero de elementos con su propiedad Seleccionado en True
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Numero de elementos con su propiedad Seleccionado en True")> _
    Public ReadOnly Property CantidadSeleccionada() As Integer
        Get
            Return m_NumSeleccionados
        End Get
    End Property

    ''' <summary>
    ''' Establece True si quieres que se muestren las alertas al momento de llegar al maximo de elementos seleccionados permitido o False si solo quieres dejar que la misma colección no deje seleccionar mas de lo permitido sin mostrar alertas
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Establece True si quieres que se muestren las alertas al momento de llegar al maximo de elementos seleccionados permitido o False si solo quieres dejar que la misma colección no deje seleccionar mas de lo permitido sin mostrar alertas")> _
    Public Property MostrarAlertas() As Boolean
        Get
            Return m_MostrarMensaje
        End Get
        Set(ByVal value As Boolean)
            m_MostrarMensaje = value
        End Set
    End Property

    ''' <summary>
    ''' Mensaje que se mostrara cuando se haya seleccionado mas del limite permitido de elementos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Mensaje que se mostrara cuando se haya seleccionado mas del limite permitido de elementos")> _
    Public Property MensajeLimiteMaximo() As String
        Get
            Return m_MensajeMaximoElementos
        End Get
        Set(ByVal value As String)
            m_MensajeMaximoElementos = value
        End Set
    End Property
#End Region

#Region "Metodos de Relleno"
    Protected Sub Rellenar()
        Me.Clear()

        Me.m_Rellenando = True

        For Each entity As TipoEntity In coleccion
            Dim classB As New TipoEntidad
            classB.LeerEntidad(entity)
            classB.Contenedor = Me

            AddHandler classB.ItemSeleccionado, AddressOf Selecciono
            AddHandler classB.ItemModificado, AddressOf Modificado

            Me.Add(classB)
        Next

        Me.m_Rellenando = False
    End Sub

    Protected Sub RellenarColeccion()
        coleccion.Clear()

        For Each classB As TipoEntidad In Me
            coleccion.Add(classB.ObtenerEntidad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal Col As TipoCollection)
        coleccion = Col
        Rellenar()
    End Sub

    Public Function ObtenerColeccion() As TipoCollection
        RellenarColeccion()
        Return coleccion
    End Function

    Public Shadows Sub Add(ByVal item As TipoEntidad)
        If Not m_Rellenando Then
            If item IsNot Nothing Then
                item.Contenedor = Me

                AddHandler item.ItemModificado, AddressOf Modificado
                AddHandler item.ItemSeleccionado, AddressOf Selecciono
            End If
        End If
        MyBase.Add(item)
    End Sub
#End Region

#Region "Metodos de consulta"
    Public Function Obtener() As Integer
        Try
            Return Obtener(Nothing)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function Obtener(ByVal filtro As OC.IPredicate, Optional ByVal Ordenamiento As OC.SortExpression = Nothing, Optional ByVal Relaciones As OC.RelationCollection = Nothing) As Integer
        Try
            coleccion.GetMulti(filtro, 0, Ordenamiento, Relaciones)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al realizar la consulta", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function
#End Region

#Region "Metodos de Accion"
    Public Sub ForEach(ByVal accion As Action(Of TipoEntidad))
        For Each item As TipoEntidad In Me
            accion.Invoke(item)
        Next
    End Sub
#End Region

#Region "Eventos"
    Private Sub Selecciono(ByVal itemAfectado As Object, ByRef valor As Boolean)
        'If Equals(itemAfectado, Me.m_UltimoItem) Then
        '    If itemAfectado.Seleccionado = m_UltimoItem.Seleccionado Then
        '        Exit Sub
        '    End If
        'Else
        '    m_UltimoItem = itemAfectado
        'End If

        'If valor Then
        '    If Me.CantidadSeleccionada < Me.MaximoElementosSeleccionados Then
        '        Me.m_NumSeleccionados += 1
        RaiseEvent ItemSeleccionado(Me, Me.IndexOf(itemAfectado), itemAfectado, valor)
        '    Else
        'If Me.MostrarAlertas Then
        '    MsgBox(m_MensajeMaximoElementos, MsgBoxStyle.Exclamation, "Aviso")
        'End If

        'valor = False
        '    End If
        'Else
        'Me.m_NumSeleccionados -= 1
        'RaiseEvent ItemSeleccionado(Me, e, Me.IndexOf(itemAfectado), itemAfectado, valor)
        'End If
    End Sub

    Private Sub Modificado(ByRef item As Object, ByVal e As EventArgs)
        RaiseEvent ItemModificado(Me, IndexOf(item), item)
    End Sub

    'Private Sub ColleccionBase_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.AddingNew
    '    If Not m_Rellenando Then
    '        If e.NewObject IsNot Nothing Then
    '            Dim ent As TipoEntidad = DirectCast(e.NewObject, TipoEntidad)
    '            ent.Contenedor = Me

    '            AddHandler ent.ItemModificado, AddressOf Modificado
    '            AddHandler ent.ItemSeleccionado, AddressOf Selecciono
    '        End If
    '    End If
    'End Sub
#End Region
End Class

''' <summary>
''' Clase Generica con mejoras de la BindingList(Of Type) para uso sin Entity
''' </summary>
''' <typeparam name="Tipo"></typeparam>
''' <remarks></remarks>
Public MustInherit Class ColleccionBase(Of Tipo)
    Inherits System.ComponentModel.BindingList(Of Tipo)
    Implements ComponentModel.IComponent, ComponentModel.ISite

#Region "Miembros"
    Private ordenar As New OrdenarClass(Of ColleccionBase(Of Tipo))
#End Region

#Region "Datos Componente"
    Public Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.ComponentModel.IComponent.Disposed
    Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
    Private m_cursite As System.ComponentModel.ISite
    Private m_component As System.ComponentModel.IComponent
    Private m_container As System.ComponentModel.IContainer
    Private m_designmode As Boolean = False
    Private m_Name As String
    Private m_getservice As System.IServiceProvider

#Region "Property"

    Public Property Site() As System.ComponentModel.ISite Implements System.ComponentModel.IComponent.Site
        Get
            Return m_cursite
        End Get
        Set(ByVal value As System.ComponentModel.ISite)
            m_cursite = value
        End Set
    End Property

    Public ReadOnly Property Component() As System.ComponentModel.IComponent Implements System.ComponentModel.ISite.Component
        Get
            Return m_component
        End Get
    End Property

    Public ReadOnly Property Container() As System.ComponentModel.IContainer Implements System.ComponentModel.ISite.Container
        Get
            Return m_container
        End Get
    End Property

    Public ReadOnly Property DesignMode() As Boolean Implements System.ComponentModel.ISite.DesignMode
        Get
            Return m_designmode
        End Get
    End Property

    Public Property Name() As String Implements System.ComponentModel.ISite.Name
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

#End Region

    Public Function GetService(ByVal serviceType As System.Type) As Object Implements System.IServiceProvider.GetService
        Return m_getservice.GetService(serviceType)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Liberar recursos administrados cuando se llamen explícitamente
            End If

            ' TODO: Liberar recursos no administrados compartidos
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region

#Region "Datos de Ordenacion"
    Protected Overrides Sub ApplySortCore(ByVal prop As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection)
        Direc = direction
        Propiedad = prop

        If Count > 0 Then
            Dim TipoDato As TipoDatoEnum = TipoDatoEnum.NUMERO
            Dim proInf As System.Reflection.PropertyInfo = GetType(Tipo).GetProperty(prop.Name)

            Select Case proInf.GetValue(Me(0), Nothing).GetType.ToString
                Case "System.Int16"
                Case "System.Int32"
                Case "System.Int64"
                Case "System.Decimal"
                Case "System.Double"
                Case "System.Single"
                Case "System.SByte"
                Case "System.DateTime"
                    TipoDato = TipoDatoEnum.FECHA
                Case "System.Byte"
                Case Else
                    TipoDato = TipoDatoEnum.CADENA
            End Select

            ordenar.Ordenar(Me, 0, Me.Count - 1, Direc, TipoDato, proInf)
        End If

        EstaOrdenada = True

        Me.OnListChanged(New System.ComponentModel.ListChangedEventArgs(System.ComponentModel.ListChangedType.Reset, prop))
    End Sub

    Protected Overrides Sub RemoveSortCore()

    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Dim Direc As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Descending
    Protected Overrides ReadOnly Property SortDirectionCore() As System.ComponentModel.ListSortDirection
        Get
            Return Direc
        End Get
    End Property

    Dim Propiedad As System.ComponentModel.PropertyDescriptor
    Protected Overrides ReadOnly Property SortPropertyCore() As System.ComponentModel.PropertyDescriptor
        Get
            Return Propiedad
        End Get
    End Property

    Private EstaOrdenada As Boolean = False
    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return EstaOrdenada
        End Get
    End Property
#End Region

#Region "Clases"
    Private Class OrdenarClass(Of TipoColeccion As ColleccionBase(Of Tipo))

        Public Sub Ordenar(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal tipoDato As TipoDatoEnum, ByVal propInf As System.Reflection.PropertyInfo)

            If tipoDato = ColleccionBase(Of Tipo).TipoDatoEnum.CADENA Then
                Me.OrdenarCadenas(FcColeccion, Inf, Sup, Ordenamiento, propInf)
            Else
                Me.OrdenarNumeroOFecha(FcColeccion, Inf, Sup, Ordenamiento, propInf)
            End If
        End Sub

        Private Sub OrdenarNumeroOFecha(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal propInf As System.Reflection.PropertyInfo)
            If Inf = Sup Then Exit Sub

            Dim Leng As Integer = Sup - Inf + 1
            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

            OrdenarNumeroOFecha(FcColeccion, Inf, Sel, Ordenamiento, propInf)
            OrdenarNumeroOFecha(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf)

            Dim temp(Leng) As Tipo

            For i As Integer = 0 To Leng - 1
                temp(i) = FcColeccion(Inf + i)
            Next

            Dim M1 As Integer = 0
            Dim M2 As Integer = Sel - Inf + 1

            If Ordenamiento = ComponentModel.ListSortDirection.Ascending Then
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If propInf.GetValue(temp(M1), Nothing) > propInf.GetValue(temp(M2), Nothing) Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            Else
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If propInf.GetValue(temp(M1), Nothing) < propInf.GetValue(temp(M2), Nothing) Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            End If
        End Sub

        Private Sub OrdenarCadenas(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
                                ByVal Ordenamiento As System.ComponentModel.ListSortDirection, _
                                ByVal propInf As System.Reflection.PropertyInfo)
            If Inf = Sup Then Exit Sub

            Dim Leng As Integer = Sup - Inf + 1
            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

            OrdenarCadenas(FcColeccion, Inf, Sel, Ordenamiento, propInf)
            OrdenarCadenas(FcColeccion, Sel + 1, Sup, Ordenamiento, propInf)

            Dim temp(Leng) As Tipo

            For i As Integer = 0 To Leng - 1
                temp(i) = FcColeccion(Inf + i)
            Next

            Dim M1 As Integer = 0
            Dim M2 As Integer = Sel - Inf + 1

            If Ordenamiento = ComponentModel.ListSortDirection.Ascending Then
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If String.Compare(propInf.GetValue(temp(M1), Nothing).ToString, propInf.GetValue(temp(M2), Nothing).ToString) > 0 Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            Else
                For i As Integer = 0 To Leng - 1
                    If M2 <= (Sup - Inf) Then
                        If M1 <= (Sel - Inf) Then
                            If String.Compare(propInf.GetValue(temp(M1), Nothing).ToString, propInf.GetValue(temp(M2), Nothing).ToString) < 0 Then
                                FcColeccion(i + Inf) = temp(M2)
                                M2 += 1
                            Else
                                FcColeccion(i + Inf) = temp(M1)
                                M1 += 1
                            End If
                        Else
                            FcColeccion(i + Inf) = temp(M2)
                            M2 += 1
                        End If
                    Else
                        FcColeccion(i + Inf) = temp(M1)
                        M1 += 1
                    End If
                Next
            End If
        End Sub
    End Class
#End Region

#Region "Enumeradores"
    ''' <summary>
    ''' Sirve para especificar que tipo de dato se esta empleando
    ''' </summary>
    ''' <remarks></remarks>
    Private Enum TipoDatoEnum
        FECHA
        NUMERO
        CADENA
    End Enum
#End Region
    '#Region "Clases"
    '    Private Class OrdenarClass(Of TipoColeccion As ColleccionBase(Of Tipo))

    '        Public Sub Ordenar(ByRef FcColeccion As TipoColeccion, ByVal Inf As Integer, ByVal Sup As Integer, _
    '                                ByVal NombrePropiedad As String, ByVal Ordenamiento As System.ComponentModel.ListSortDirection)

    '            Dim TipoDato As TipoDatoEnum = TipoDatoEnum.NUMERO

    '            Select Case FcColeccion(Inf).GetType.GetProperty(NombrePropiedad).GetValue(FcColeccion(Inf), Nothing).GetType.ToString
    '                Case "System.Int16"
    '                Case "System.Int32"
    '                Case "System.Int64"
    '                Case "System.Decimal"
    '                Case "System.Double"
    '                Case "System.Single"
    '                Case "System.SByte"
    '                Case "System.DateTime"
    '                    TipoDato = TipoDatoEnum.FECHA
    '                Case "System.Byte"
    '                Case Else
    '                    TipoDato = TipoDatoEnum.CADENA
    '            End Select

    '            If Inf = Sup Then Exit Sub

    '            Dim Leng As Integer = Sup - Inf + 1
    '            Dim Sel As Integer = Math.Truncate((Inf + Sup) / 2)

    '            Ordenar(FcColeccion, Inf, Sel, NombrePropiedad, Ordenamiento)
    '            Ordenar(FcColeccion, Sel + 1, Sup, NombrePropiedad, Ordenamiento)

    '            Dim temp(Leng) As Tipo

    '            For i As Integer = 0 To Leng - 1
    '                temp(i) = FcColeccion(Inf + i)
    '            Next

    '            Dim M1 As Integer = 0
    '            Dim M2 As Integer = Sel - Inf + 1
    '            Dim n1, n2 As Decimal
    '            Dim n3 As String = ""
    '            Dim n4 As String = "-"
    '            Dim d1 As Date = "01/01/1990"
    '            Dim d2 As Date = "01/01/1990"

    '            For i As Integer = 0 To Leng - 1
    '                If M2 <= (Sup - Inf) Then
    '                    If M1 <= (Sel - Inf) Then
    '                        If TipoDato = TipoDatoEnum.NUMERO Then
    '                            n1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
    '                            n2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
    '                        ElseIf TipoDato = TipoDatoEnum.CADENA Then
    '                            n3 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing).ToString
    '                            n4 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing).ToString
    '                        Else
    '                            d1 = temp(M1).GetType.GetProperty(NombrePropiedad).GetValue(temp(M1), Nothing)
    '                            d2 = temp(M2).GetType.GetProperty(NombrePropiedad).GetValue(temp(M2), Nothing)
    '                        End If

    '                        If IIf(TipoDato = TipoDatoEnum.NUMERO, IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, n1 > n2, n1 < n2), _
    '                            IIf(TipoDato = TipoDatoEnum.CADENA, _
    '                            IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, String.Compare(n3, n4) > 0, String.Compare(n3, n4) < 0), _
    '                            IIf(Ordenamiento = ComponentModel.ListSortDirection.Ascending, d1 > d2, d1 < d2))) Then
    '                            FcColeccion(i + Inf) = temp(M2)
    '                            M2 += 1
    '                        Else
    '                            FcColeccion(i + Inf) = temp(M1)
    '                            M1 += 1
    '                        End If
    '                    Else
    '                        FcColeccion(i + Inf) = temp(M2)
    '                        M2 += 1
    '                    End If
    '                Else
    '                    FcColeccion(i + Inf) = temp(M1)
    '                    M1 += 1
    '                End If
    '            Next
    '        End Sub

    '        ''' <summary>
    '        ''' Sirve para especificar que tipo de dato se esta empleando
    '        ''' </summary>
    '        ''' <remarks></remarks>
    '        Private Enum TipoDatoEnum
    '            FECHA
    '            NUMERO
    '            CADENA
    '        End Enum
    '    End Class
    '#End Region
End Class

Public Class DataGridViewPwr
    Inherits Windows.Forms.DataGridView
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If keyData = Windows.Forms.Keys.Enter Then
            'If Me.CurrentCell.ColumnIndex = Me.ColumnCount - 1 Then
            '    Me.Rows.Add()
            'End If
            Windows.Forms.SendKeys.Send(Chr(Windows.Forms.Keys.Tab))
            Return True
        Else    
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Windows.Forms.Keys.Enter Then
            Windows.Forms.SendKeys.Send(Chr(Windows.Forms.Keys.Tab))
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub
End Class