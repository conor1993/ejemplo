Imports System.Windows.Forms
Imports System
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class ProductosClass
    'Implements IEntidad
    Inherits ClassBase(Of EC.MsccatProductosEntity)

#Region "Miembros"
    'Dim entity As New EC.MsccatProductosEntity
    'Dim _Func As String
    'Dim _NumOpc As Integer
    Dim _CodProducto As Integer
    Dim _CuentaContable As CuentaContableClass
    Dim _Detalle As ProductosDetalleDecomisoCollectionClass
    Dim _ValorAgregado As Boolean = False
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado
    Dim CortesPre As EC.MsccortesPreCortesEntity
#End Region

#Region "Constructores"
    Public Sub New()
        entity = New EC.MsccatProductosEntity
        'Productos.Decomisa = False
        'Productos.CodigoBarra = ""
        'Productos.CodProdAnt = 0
        'Productos.Corte = False
        'Productos.Descripcion = ""
        'Productos.DescripcionCorta = ""
        'Productos.EnPiezas = False
        'Productos.Estatus = 1
        'Productos.MaximoPiezasxCaja = 0
        'Productos.NombreIngles = ""
        'Productos.Observaciones = ""
        'Productos.PreCorte = False
        'Productos.SubProducto = False
    End Sub

    Sub New(ByVal Entidad As EC.MsccatProductosEntity)
        entity = Entidad
    End Sub

    Sub New(ByVal IdProducto As Integer)
        entity = New EC.MsccatProductosEntity(IdProducto)
    End Sub

#End Region

#Region "Propiedades"
    ReadOnly Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
    End Property

    <System.ComponentModel.DisplayName("Descripción"), _
    System.ComponentModel.DataObjectField(False, False, False, 10), _
    System.ComponentModel.DefaultValue(GetType(String), "")> _
    Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            entity.Descripcion = value
        End Set
    End Property

    Property DescripcionCorta() As String
        Get
            Return entity.DescripcionCorta
        End Get
        Set(ByVal value As String)
            entity.DescripcionCorta = value
        End Set
    End Property

    Property Observaciones() As String
        Get
            Return entity.Observaciones
        End Get
        Set(ByVal value As String)
            entity.Observaciones = value
        End Set
    End Property

    'Property CtaMay() As String
    '    Get
    '        Return Productos.CtaMay
    '    End Get
    '    Set(ByVal value As String)
    '        Productos.CtaMay = value
    '    End Set
    'End Property
    'Property SubCta() As String
    '    Get
    '        Return Productos.SubCta
    '    End Get
    '    Set(ByVal value As String)
    '        Productos.SubCta = value
    '    End Set
    'End Property
    'Property SsbCta() As String
    '    Get
    '        Return Productos.SsbCta
    '    End Get
    '    Set(ByVal value As String)
    '        Productos.SsbCta = value
    '    End Set
    'End Property
    'Property SssCta() As String
    '    Get
    '        Return Productos.SssCta
    '    End Get
    '    Set(ByVal value As String)

    '    End Set
    'End Property

    Property SubProducto() As Boolean
        Get
            Return entity.SubProducto
        End Get
        Set(ByVal value As Boolean)
            Entity.SubProducto = value
        End Set
    End Property

    Property PreCorte() As Boolean
        Get
            Return Entity.PreCorte
        End Get
        Set(ByVal value As Boolean)
            entity.PreCorte = value
        End Set
    End Property

    Property Corte() As Boolean
        Get
            Return entity.Corte
        End Get
        Set(ByVal value As Boolean)
            entity.Corte = value
        End Set
    End Property

    Property Canal() As Boolean
        Get
            Return entity.Canal
        End Get
        Set(ByVal value As Boolean)
            entity.Canal = value
        End Set
    End Property

    Property Decomisa() As Boolean
        Get
            Return entity.Decomisa
        End Get
        Set(ByVal value As Boolean)
            entity.Decomisa = value
        End Set
    End Property

    Property EnPiezas() As Boolean
        Get
            Return entity.EnPiezas
        End Get
        Set(ByVal value As Boolean)
            entity.EnPiezas = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            entity.Estatus = value
        End Set
    End Property

    Property CodProdAnt() As Integer
        Get
            Return entity.CodProdAnt
        End Get
        Set(ByVal value As Integer)
            entity.CodProdAnt = value
        End Set
    End Property

    Property MaximoPiezasxCaja() As Integer
        Get
            Return entity.MaximoPiezasxCaja
        End Get
        Set(ByVal value As Integer)
            entity.MaximoPiezasxCaja = value
        End Set
    End Property

    Property NombreIngles() As String
        Get
            Return entity.NombreIngles
        End Get
        Set(ByVal value As String)
            entity.NombreIngles = value
        End Set
    End Property

    Property CodigoBarra() As String
        Get
            Return entity.CodigoBarra
        End Get
        Set(ByVal value As String)
            entity.CodigoBarra = value
        End Set
    End Property

    Public Property ConHueso() As Boolean
        Get
            Return Entity.ConHueso
        End Get
        Set(ByVal value As Boolean)
            Entity.ConHueso = value
        End Set
    End Property
    'Property Func() As String
    '    Get
    '        Return _Func
    '    End Get
    '    Set(ByVal value As String)
    '        _Func = value
    '    End Set
    'End Property

    'Property NumOpc() As Integer
    '    Get
    '        Return _NumOpc
    '    End Get
    '    Set(ByVal value As Integer)
    '        _NumOpc = value
    '    End Set
    'End Property

    Property CodProducto() As Integer
        Get
            Return _CodProducto
        End Get
        Set(ByVal value As Integer)
            _CodProducto = value
        End Set
    End Property

    Property kilosmaximo() As Integer
        Get
            Return Entity.KilosMaximo
        End Get
        Set(ByVal value As Integer)
            Entity.KilosMaximo = value
        End Set
    End Property

    Property kilosmin() As Integer
        Get
            Return Entity.KilosMinimo
        End Get
        Set(ByVal value As Integer)
            Entity.KilosMinimo = value
        End Set
    End Property

    Public Property ValorAgregado1() As Boolean
        Get
            Return Entity.ValorAgregado
        End Get
        Set(ByVal value As Boolean)
            Entity.ValorAgregado = value
        End Set
    End Property

    Property IdCuentaContable() As Integer
        Get
            Return Me.entity.IdCeuntaContable.Value
        End Get
        Set(ByVal value As Integer)
            Me.entity.IdCeuntaContable = value
        End Set
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If Me._CuentaContable Is Nothing Then
                Me._CuentaContable = New CuentaContableClass(Me.entity.CuentaContable)
            End If

            Return Me._CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            Me._CuentaContable = value

            If value Is Nothing Then
                Me.entity.CuentaContable = Nothing
            Else
                Me.entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property CuentaContableNombre() As String
        Get
            Return Me.CuentaContable.NombreCuenta & ": " & Me.CuentaContable.CuentaContable
        End Get
    End Property

    <System.ComponentModel.DefaultValue(GetType(Decimal), "0")> _
    Public Property PrecioXKilo() As Decimal
        Get
            Return Me.entity.PrecioXkilo
        End Get
        Set(ByVal value As Decimal)
            Me.entity.PrecioXkilo = value
        End Set
    End Property

    Public Property PiezasXCabeza() As Integer
        Get
            Return Me.entity.PiezasXcabeza
        End Get
        Set(ByVal value As Integer)
            Me.entity.PiezasXcabeza = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As ProductosDetalleDecomisoCollectionClass
        Get
            If Me._Detalle Is Nothing Then
                Me._Detalle = New ProductosDetalleDecomisoCollectionClass

                If Not Me.entity.IsNew Then
                    Me._Detalle.RellenarMe(Me.entity.MsccatProductosDetalle)

                    If Me._Detalle.Count > 0 Then
                        Me._ValorAgregado = True
                    End If
                End If
            End If

            Return Me._Detalle
        End Get
    End Property

    Public ReadOnly Property DetallePropRel() As Object
        Get
            Return Me.Detalle
        End Get
    End Property

    Public Property ValorAgregado() As Boolean
        Get
            Return Me._ValorAgregado
        End Get
        Set(ByVal value As Boolean)
            Me._ValorAgregado = value
        End Set
    End Property

    Public Property EsMerma() As AsignadaEnum
        Get
            Return entity.EsMerma
        End Get
        Set(ByVal value As AsignadaEnum)
            entity.EsMerma = value
        End Set
    End Property

    Public Property EsDerivable() As Boolean
        Get
            Return Entity.EsDerivable
        End Get
        Set(ByVal value As Boolean)
            Entity.EsDerivable = value
        End Set
    End Property

    ReadOnly Property IdPrecorte() As Integer
        Get
            CortesPre = New EC.MsccortesPreCortesEntity
            CortesPre.FetchUsingPK(Me.IdProducto)
            Return CortesPre.IdPreCorte
        End Get
    End Property

    'Public Property PorcIVA() As Decimal
    '    Get
    '        Return Entity.PorcIva
    '    End Get
    '    Set(ByVal value As Decimal)
    '        Entity.PorcIVA = value
    '    End Set
    'End Property

    <System.ComponentModel.DisplayName("ClaveprodSat")> _
    Public Property ClaveprodSat() As String
        Get
            Return Entity.Claveproserv

        End Get
        Set(ByVal value As String)
            Entity.Claveproserv = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Overloads Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Entity.Estatus = EstatusDatos.CANCELADO

            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Return False
        End Try
    End Function

    Public Shadows Function Guardar(ByRef trans As HC.Transaction) As Boolean
        Try
            trans.Add(Entity)
            If Me.Entity.IsNew Then
                Me.Estatus = EstatusDatos.VIGENTE
            End If

            If Entity.Save() Then
                If Me.Detalle.Count > 0 Then
                    Return GuardarMotivosDecomiso(trans)
                End If
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Private Function GuardarMotivosDecomiso(ByRef trans As HC.Transaction) As Boolean
        Dim colDecomisosO As New CC.MsccatProductosDetalleCollection

        trans.Add(colDecomisosO)
        colDecomisosO.GetMulti(HC.MsccatProductosDetalleFields.IdProducto = Me.IdProducto)

        Dim colDet As CC.MsccatProductosDetalleCollection = Me.Detalle.ObtenerColeccion
        Dim encontro As Boolean

        For Each detO As EC.MsccatProductosDetalleEntity In colDecomisosO
            encontro = False

            For Each det As EC.MsccatProductosDetalleEntity In colDet
                If det.IdDecomiso = detO.IdDecomiso Then
                    encontro = True

                    colDet.Remove(det)

                    Exit For
                End If
            Next

            If Not encontro Then
                trans.Add(detO)

                detO.Delete()
            End If
        Next

        trans.Add(colDet)
        colDet.SaveMulti()
        Return True
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean 'Implements IEntidad.Obtener
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function Obtener(ByVal IdProducto As Integer, ByVal Descripcion As String, ByVal IdCliente As Integer, ByVal Opcion As Integer) As DataSet
        Try
            Obtener = SPR.UspConMsccatProductos(IdProducto, Descripcion, IdCliente, Opcion)
        Catch ex As Exception
            Obtener = Nothing
        End Try
    End Function

    'Public Function Guardar() As Boolean
    '    Try
    '        Dim IG As New CC.MsccatProductosCollection
    '        If Productos.IsNew Then
    '            If IG.GetDbCount(HC.MsccatProductosFields.Descripcion = Descripcion And HC.MsccatProductosFields.DescripcionCorta = DescripcionCorta) > 0 Then
    '                MessageBox.Show("Descripción de Precorte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Return False
    '            End If
    '        Else
    '            If IG.GetDbCount(Not HC.MsccatProductosFields.IdProducto = IdProducto And HC.MsccatProductosFields.Descripcion = Descripcion And HC.MsccatProductosFields.DescripcionCorta = DescripcionCorta) > 0 Then
    '                MessageBox.Show("Descripción de Precorte ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Return False
    '            End If
    '        End If
    '        Return Productos.Save
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    'End Function

    Public Overloads Function ObtenerEntidad() As EC.MsccatProductosEntity
        Return Me.Entity
    End Function

    Public Overloads Sub LeerEntidad(ByVal entidad As EC.MsccatProductosEntity)
        Me.Entity = entidad
    End Sub
#End Region

End Class

Public Class ProductosCollectionsClass
    'Inherits CollectionClass(Of ProductosClass)
    'Dim Coleccion As New CC.MsccatProductosCollection
    Inherits ColleccionBase(Of EC.MsccatProductosEntity, CC.MsccatProductosCollection, ProductosClass)

    Public Overloads Function Obtener(ByVal Estatus As CondicionEstatusEnum, Optional ByVal NoCortes As Boolean = True, Optional ByVal PreCorte As Boolean = True) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If Estatus <> CondicionEstatusEnum.TODOS Then
                Filtro.Add(HC.MsccatProductosFields.Estatus = Estatus)
            End If

            If NoCortes Then
                Filtro.Add(HC.MsccatProductosFields.Corte = False)
            End If

            If PreCorte Then
                Filtro.Add(HC.MsccatProductosFields.PreCorte = False)
            End If

            coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Rellenar()

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal descripcion As String, ByVal estatus As CondicionEstatusEnum, Optional ByVal Orden As OC.SortExpression = Nothing) As Integer
        Try
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            filtro.Add(HC.MsccatProductosFields.Descripcion Mod String.Format("%{0}%", descripcion))

            If Not estatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.MsccatProductosFields.Estatus = estatus)
            End If

            coleccion.GetMulti(filtro, 0, Orden)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal descripcion As String, ByVal esDecomisable As Boolean, ByVal esSubProducto As Boolean, _
                            ByVal seManejaEnPiezas As Boolean, ByVal esDeValorAgregado As Boolean, _
                            ByVal esMerma As Boolean, Optional ByVal Orden As OC.SortExpression = Nothing) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.MsccatProductosFields.Descripcion Mod String.Format("%{0}%", descripcion) And _
                        HC.MsccatProductosFields.Decomisa = esDecomisable And HC.MsccatProductosFields.SubProducto = esSubProducto And _
                        HC.MsccatProductosFields.EnPiezas = seManejaEnPiezas And HC.MsccatProductosFields.EsMerma = esMerma)

            coleccion.GetMulti(Filtro, 0, Orden)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Descripcion As String, Optional ByVal PreCorte As Boolean = False, Optional ByVal Corte As Boolean = False, Optional ByVal Orden As OC.SortExpression = Nothing) As Integer
        Try
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            If Corte Then
                filtro.Add(HC.MsccatProductosFields.Corte = True)
            End If
            If PreCorte Then
                filtro.Add(HC.MsccatProductosFields.PreCorte = True)
            End If
            filtro.Add(HC.MsccatProductosFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            coleccion.GetMulti(filtro, 0, Orden)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Overloads Function Obtener(ByVal decomisable As Boolean, ByVal fcEstatus As CondicionEstatusEnum, Optional ByVal Orden As OC.SortExpression = Nothing) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            Filtro.Add(HC.MsccatProductosFields.Decomisa = decomisable)

            If fcEstatus <> CondicionEstatusEnum.TODOS Then
                Filtro.Add(HC.MsccatProductosFields.Estatus = fcEstatus)
            End If

            coleccion.GetMulti(Filtro, 0, Orden)
            Rellenar()

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function ObtenerCorte(ByVal IdProducto As Integer) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            Filtro.Add(HC.MsccatProductosFields.IdProducto = IdProducto And HC.MsccatProductosFields.Corte = True And _
                    HC.MsccatProductosFields.Estatus = EstatusEnum.ACTIVO)

            coleccion.GetMulti(Filtro)
            Rellenar()

            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function ObtenerCortes(ByVal Estatus As CondicionEstatusEnum) As Integer
        Try
            Me.Clear()
            Coleccion = New CC.MsccatProductosCollection
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.MsccatProductosFields.Corte = True)
            If Not Estatus = CondicionEstatusEnum.TODOS Then
                Filtro.Add(HC.MsccatProductosFields.Estatus = Estatus)
            End If

            Coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function ObtenerPrecortes(ByVal Estatus As CondicionEstatusEnum) As Integer
        Try
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

            Filtro.Add(HC.MsccatProductosFields.PreCorte = True)

            If Not Estatus = CondicionEstatusEnum.TODOS Then
                Filtro.Add(HC.MsccatProductosFields.Estatus = Estatus)
            End If

            coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function ObtenerProductos(ByVal Estatus As CondicionEstatusEnum) As Integer
        Try
            Me.Clear()
            Coleccion = New CC.MsccatProductosCollection
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression


            If Not Estatus = CondicionEstatusEnum.TODOS Then
                Filtro.Add((HC.MsccatProductosFields.SubProducto = True Or _
                        (HC.MsccatProductosFields.SubProducto = False And HC.MsccatProductosFields.Corte = False And _
                        HC.MsccatProductosFields.PreCorte = False)) And HC.MsccatProductosFields.Estatus = Estatus And HC.MsccatProductosFields.Canal = False)
            Else
                Filtro.Add(HC.MsccatProductosFields.SubProducto = True Or _
                        (HC.MsccatProductosFields.SubProducto = False And HC.MsccatProductosFields.Corte = False And _
                        HC.MsccatProductosFields.PreCorte = False) And HC.MsccatProductosFields.Canal = False)
            End If

            Coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Rellenar()

            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function ObtenerCanal(ByVal IdProducto As Integer) As Integer
        Try
            Me.Clear()
            Coleccion = New CC.MsccatProductosCollection
            Dim Filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.MsccatProductosFields.IdProducto = IdProducto And HC.MsccatProductosFields.Canal = True And _
                    HC.MsccatProductosFields.Estatus = EstatusEnum.ACTIVO)
            Coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function ObtenerXEmbarque(ByVal FolioEmbarque As String) As Integer
        Try
            Me.Clear()
            Dim Filtro As New OC.PredicateExpression
            Filtro.Add(New OC.FieldCompareSetPredicate(HC.MsccatProductosFields.IdProducto, HC.MfacEmbarquesDetFields.IdProducto, SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, HC.MfacEmbarquesDetFields.IdFolioEmbarque = FolioEmbarque))
            Coleccion.GetMulti(Filtro)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function ReportePrecortes(ByVal Empresa As String, ByVal Usuario As String) As RptPrecortes

        Dim Reportes As New RptPrecortes
        Try
            Dim Ds As New DataSet
            Dim Tabla As New DsPrecortes.PrecortesTablaDataTable

            For Each Pre As ProductosClass In Me
                Dim Renglon As DsPrecortes.PrecortesTablaRow = Tabla.AddPrecortesTablaRow(Pre.IdProducto, Pre.Descripcion, Pre.DescripcionCorta, Pre.Estatus.ToString, _
                Pre.NombreIngles, Pre.PrecioXKilo.ToString("N3"), Pre.PiezasXCabeza, Pre.CodigoBarra)
            Next
            Ds.Tables.Add(Tabla)
            Reportes.SetDataSource(Ds)
            Reportes.SetParameterValue(0, Empresa)
            Reportes.SetParameterValue(2, Usuario)
            Reportes.SetParameterValue(1, "Catalogos/Produccion/Pre-Cortes")

            Return Reportes
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Function ReporteCortes(ByVal Empresa As String, ByVal Usuario As String) As RptCortes
        Dim Reporte As New RptCortes
        Try
            Dim Tabla As New DataTable
            Tabla = SPR.UspConMsccortesPreCortes(0, 0, 2)
            Reporte.SetDataSource(Tabla)
            Reporte.SetParameterValue(0, Empresa)
            Reporte.SetParameterValue(1, Usuario)
            Reporte.SetParameterValue(2, "Catalogos/Produccion/Cortes")
            Return Reporte
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Public Shared Function CargarProductos(Optional ByVal Filtro As OC.IPredicate = Nothing) As IList
        Dim Productos As New CC.MsccatProductosCollection

        Try
            Productos.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, OC.SortOperator.Ascending)))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return Productos.GetList()
    End Function

    Public Shared Sub Imprimir(ByVal Session As ECS.SesionesEntity, Optional ByVal Filtro As OC.PredicateExpression = Nothing)
        Try
            Dim VerReporte As New PreVisualizarForm
            Dim Reporte As New RptABCProductos()

            Dim prueba As Stopwatch = Stopwatch.StartNew()
            Dim dt As DataTable = CC.MsccatProductosCollection.GetMultiAsDataTable(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MsccatProductosFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

            dt.Columns.Add("TipoProducto")
            For Each row As DataRow In dt.Rows
                Dim tipo(0) As String

                If row.Item("SubProducto") Then
                    tipo(tipo.Length - 1) = "SubProducto"
                End If
                If row.Item("Decomisa") Then
                    ReDim Preserve tipo(tipo.Length)
                    tipo(tipo.Length - 1) = "Decomisable"
                End If
                If row.Item("Canal") Then
                    ReDim Preserve tipo(tipo.Length)
                    tipo(tipo.Length - 1) = "Canal"
                End If
                If row.Item("EsMerma") Then
                    ReDim Preserve tipo(tipo.Length)
                    tipo(tipo.Length - 1) = "Merma"
                End If
                If row.Item("ValorAgregado") Then
                    ReDim Preserve tipo(tipo.Length)
                    tipo(tipo.Length - 1) = "ValorAgregado"
                End If
                row.Item("TipoProducto") = String.Join(", ", tipo)
            Next

            prueba.Stop()
            MsgBox(prueba.ElapsedMilliseconds / 1000)

            VerReporte.Reporte = Reporte
            Reporte.SetDataSource(dt)
            Reporte.SetParameterValue(0, Session.MiUsuario.Usrnomcom)
            Reporte.SetParameterValue(1, "Catalogos/Produccion/Productos")
            Reporte.SetParameterValue(2, Session.MiEmpresa.Empnom)
            VerReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Session.MiEmpresa.Empnom)
        End Try
    End Sub
End Class

Public Class CortesPreCortesClass
    'Implements IEntidad
    Inherits ClassBase(Of EC.MsccortesPreCortesEntity)

    'Dim entity As New EC.MsccortesPreCortesEntity
    Dim _Func As String
    Dim _NumOpc As Integer

    Property CodPrecorte() As Integer
        Get
            Return entity.IdPreCorte
        End Get
        Set(ByVal value As Integer)
            entity.IdPreCorte = value
        End Set
    End Property

    Property CodCorte() As Integer
        Get
            Return entity.IdCorte
        End Get
        Set(ByVal value As Integer)
            entity.IdCorte = value
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

    Public Shadows Function Borrar() As Boolean 'Implements IEntidad.Borrar
        Try
            Return Entity.Delete
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Cancelar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean

    End Function

    'Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
    '    Try
    '        If SPA.UspMsccortesPreCortes(CodPrecorte, CodCorte, Func, NumOpc, trans) = 0 Then
    '            RaiseEvent MensajeError(Me, "Error al guardar información del producto o corte")
    '            Return False
    '        End If
    '        Return True
    '    Catch ex As Exception
    '        RaiseEvent MensajeError(Me, "Error al guardar información del producto o corte")
    '        Return False
    '    End Try
    'End Function

    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) 'Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) 'Implements IEntidad.Modificado

    Public Sub New()
        entity = New EC.MsccortesPreCortesEntity
    End Sub

    Sub New(ByVal Entidad As EC.MsccortesPreCortesEntity)
        entity = Entidad
    End Sub

    Sub New(ByVal IdCorte As Integer)
        entity = New EC.MsccortesPreCortesEntity(IdCorte)
    End Sub

    Public Shadows Function Guardar(Optional ByRef Trans As HC.Transaction = Nothing) As Boolean
        Try
            If Not Trans Is Nothing Then
                Trans.Add(Entity)
            End If

            Entity.Save()

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class