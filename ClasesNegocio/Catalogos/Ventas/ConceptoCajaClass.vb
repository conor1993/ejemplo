Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = INTEGRALAB.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports System.Data.SqlClient
Imports AlmacenGeneral

Public Class ConceptoCajaClass
    Inherits ClassBase(Of EC.ConceptoCajaEntity)

    Private ConceptoCajaCollection As New CC.ConceptoCajaCollection
    'Private entidad As EC.ConceptoCajaEntity
    'Private _plaza As New PlazaClass
    'Private _tipoAlmacen As New TipoConceptoCajaClass
    'Private _almacen As ConceptoCajaClass
    'Private _CuentaContable As CuentaContableClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
    'Private CodigoRetorno As Integer
    'Private _InventarioProductosGenerales As InventarioAlmacenCollectionClass
    ' Private _ProductosConExistencia As ProductoCollectionClass
    '  Private _Familias As LineaCollectionClass
    Private _RetirosCaja As RetiroCajaCollectionClass
    'Private _IngresosCaja As Ingreso

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        Me.Entidad = New EC.ConceptoCajaEntity
        Me.Entidad.Tipo = ""
        Me.Entidad.Concepto = ""
    End Sub
#Region "Propiedades"

    <ComponentModel.DisplayName("Código")> _
    Public ReadOnly Property IdConCaja() As Integer
        Get
            Return Entidad.IdConCaja
        End Get
    End Property

    <ComponentModel.DisplayName("Tipo")> _
    Public Property Tipo() As String
        Get
            Return Entidad.Tipo
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Tipo", "Debe ingresar un tipo")
                Throw New System.Exception(" ")
            Else
                Entidad.Tipo = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    Public ReadOnly Property NombreTipo() As String
        Get
            Return IIf(Entidad.Tipo.Equals("E"), "Retiro", "Abono")
        End Get
    End Property

    <ComponentModel.DisplayName("Concepto")> _
    Public Property Concepto() As String
        Get
            Return Entidad.Concepto
        End Get
        Set(ByVal value As String)
            If value = "" Then
                RaiseEvent MensajeError("Concepto", "Debe ingresar un Concepto")
                Throw New System.Exception(" ")
            Else
                Entidad.Concepto = value
                RaiseEvent Modificado(Me, New EventArgs)
            End If
        End Set
    End Property

    'Public ReadOnly Property RetirosCaja() As RetiroCajaCollectionClass
    '    Get
    '        If _RetirosCaja Is Nothing Then
    '            _RetirosCaja = New RetiroCajaCollectionClass(Me.Entidad.RetirosCaja)
    '        End If
    '        Return _RetirosCaja
    '    End Get
    'End Property

#Region "Propiedades Especiales"

    'Public Property IdAlmacenRetorno() As Integer
    '    Get
    '        Return CodigoRetorno
    '    End Get
    '    Set(ByVal value As Integer)
    '        CodigoRetorno = value
    '    End Set
    'End Property

#End Region

#End Region



    Public Shadows Function Guardar() As Boolean 'Implements IEntidad.Guardar
        Try
            If Me.Entidad.IsNew Then

                If Me.Entidad.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            Else
                'Dim col As New CC.ComicionistaCollection

                'If col.GetDbCount(Not HC.ComicionistaFields.Codigo = Codigo And HC.ComicionistaFields.Rfc = Rfc) > 0 Then
                '    MsgBox("Ya exite un comicionista con el mismo RFC", MsgBoxStyle.Exclamation, "RFC Repetido")
                '    Return False
                'End If

                If Me.Entidad.Save Then
                    Return True
                Else
                    MsgBox("No se logro guardar, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            ''Me.Entidad.Estatus = EstatusEnum.INACTIVO
            If Me.Entidad.Delete() Then
                Return True
            Else
                MsgBox("No a sido dado de baja, intente nuevamente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean ' Implements IEntidad.Obtener
        Try
            If Me.Entidad.FetchUsingPK(Codigo) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return False
        End Try

    End Function

    Public Overrides Function ToString() As String
        Return Me.Concepto
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub


End Class

Public Class ConceptoCajaCollectionClass
    Inherits ColleccionBase(Of EC.ConceptoCajaEntity, CC.ConceptoCajaCollection, ConceptoCajaClass)

    'Private WithEvents Coleccion As New CC.ComicionistaCollection
    'Private Filtro As OC.PredicateExpression
    'Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub


    Public Overloads Function Obtener(ByVal TipoMov As String) As Integer
        Try
            Dim filtro As New OC.PredicateExpression

            'If Not FcCondicion = CondicionEnum.TODOS Then filtro.Add(HC.ComicionistaFields.Estatus = FcCondicion)
            filtro.Add(HC.ConceptoCajaFields.Tipo = TipoMov)
            Return Obtener(filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    'Public Overloads Function Obtener(ByVal Comicionista As ConceptoCajaClass) As Integer
    '    Try
    '        Return Obtener(HC.ComicionistaFields.Codigo = Comicionista.Codigo)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return -1
    '    End Try
    'End Function

    'Public Overloads Function Obtener(ByVal Tipo As String) As Integer
    '    Try
    '        Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    '        Filtro.Add(HC.ConceptoCajaFields.Nombre Mod String.Format("%{0}%", Tipo))


    '        Return Obtener(Filtro)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return -1
    '    End Try
    'End Function

    'Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As Cre
    '    'Dim Reportes As New CrepConceptoCaja
    '    'Dim ds As New DataSet
    '    'Dim dcom As New DSetConceptoCaja.DtConceptoCajaDataTable

    '    'For Each com As ConceptoCajaClass In Me
    '    '    dcom.AddDtConceptoCajaRow(com.Codigo, com.Nombre, com.Apaterno, com.Amaterno, com.Domicilio, com.Colonia, com.Lada, com.Telefono, com.Rfc, com.Plaza.Descripcion, com.Email, com.Estatus.ToString)
    '    'Next
    '    'ds.Tables.Add(dcom)
    '    'Reportes.SetDataSource(ds)
    '    'Reportes.SetParameterValue(0, Empresa)
    '    'Reportes.SetParameterValue(1, Usuario)
    '    'Reportes.SetParameterValue(2, "Catalogos/Ventas/Vendedores")
    '    ''Reportes.SetParameterValue("empresa", empresa)
    '    'Return Reportes
    'End Function

    'Public Shared Function CargarConceptoCajas(Optional ByVal Filtro As OC.IPredicate = Nothing) As ConceptoCajaCollectionClass
    '    Dim ConceptoCajas As New ConceptoCajaCollectionClass()
    '    Dim ColeccionEntity As New CC.ComicionistaCollection()
    '    Dim Ordenamiento As New OC.SortExpression()

    '    Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Nombre, OC.SortOperator.Ascending))
    '    Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Apaterno, OC.SortOperator.Ascending))
    '    Ordenamiento.Add(New OC.SortClause(HC.ComicionistaFields.Amaterno, OC.SortOperator.Ascending))

    '    Try
    '        ColeccionEntity.GetMulti(Filtro, 0, Ordenamiento)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    ConceptoCajas.RellenarMe(ColeccionEntity)
    '    Return ConceptoCajas
    'End Function
End Class