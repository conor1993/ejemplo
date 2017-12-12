Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class ZonaClass
    Inherits ClassBase(Of EC.ZonaEntity)

    Private _ZonaDetalle As ZonaDetalleCollectionClass

    Sub New()
        'Inicializacion de Todas las variables
        Entity = New EC.ZonaEntity
        Entity.Descripcion = ""
        Entity.DescCorta = ""
        Entity.Observaciones = ""
        Entity.Estatus = EstatusEnum.ACTIVO
    End Sub

    Sub New(ByVal IdZona As Integer)
        Entity = New EC.ZonaEntity(IdZona)
    End Sub

    Public Property Codigo() As Integer
        Get
            Return Entity.Codigo
        End Get
        Set(ByVal value As Integer)
            Entity.Codigo = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property DescripcionCorta() As String
        Get
            Return Entity.DescCorta
        End Get
        Set(ByVal value As String)
            Entity.DescCorta = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public ReadOnly Property Detalles() As ZonaDetalleCollectionClass
        Get
            If _ZonaDetalle Is Nothing Then
                _ZonaDetalle = New ZonaDetalleCollectionClass
                _ZonaDetalle.RellenarMe(Entity.ZonaDetalle)
            End If
            Return _ZonaDetalle
        End Get
    End Property

    Public Function Borrar() As Boolean
        Try
            Dim col As New CC.ClienteCollection

            If col.GetDbCount(HC.ClienteFields.CodigoZona = Codigo And HC.ClienteFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja la zona, tiene clientes activos", MsgBoxStyle.Exclamation, "Clientes Activos")
                Return False
            End If

            Dim colcom As New CC.ComicionistaCollection

            If colcom.GetDbCount(HC.ComicionistaFields.Zona = Codigo And HC.ComicionistaFields.Estatus = 1) > 0 Then
                MsgBox("No es posible dar de baja la zona, tiene comisionistas activos", MsgBoxStyle.Exclamation, "Comisionistas Activos")
                Return False
            End If

            Entity.Estatus = EstatusEnum.INACTIVO
            Return Entity.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Guardar() As Boolean
        If Me.Detalles.Count = 0 Then
            MsgBox("No agrego poblaciones a la zona", MsgBoxStyle.Exclamation, "Sin Poblaciones")
            Return False
        End If

        'valido si la zona es nueva
        If Entity.IsNew Then
            Dim MZona As New ZonaCollectionClass
            Dim MZonas As New EC.ZonaEntity
            Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Zonas")
            Dim coleccion As CC.ZonaDetalleCollection = Me.Detalles.ObtenerColeccion
            Try
                trans.Add(Entity)
                If Entity.Save() Then
                    trans.Add(Entity)
                    Entity.Refetch()
                    For Each zonadto As EC.ZonaDetalleEntity In coleccion
                        zonadto.Zona = Entity
                    Next
                    trans.Add(coleccion)
                    If coleccion.SaveMulti() Then
                        trans.Commit()
                        Return True
                    Else
                        trans.Commit()
                    End If
                    Return True
                Else
                    trans.Rollback()
                    MsgBox("El Zona no pudo ser guardado.", MsgBoxStyle.Critical)
                    Return False
                End If
            Catch ex As Exception
                trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            Finally
                trans.Dispose()
            End Try
            'si no es nueva
        Else
            'Declaro una coleccion de Zona Detalles que contendra la coleccion 
            'original de detalles de la zona
            'Dim LOZDC As New ZonaDetalleCollectionClass
            ''lleno la coleccion de Zona Detalles Original
            'LOZDC.Obtener(Codigo)
            Dim LOZDC As New CC.ZonaDetalleCollection


            'declaro una transaccion para realizar un rollback en caso de que en algun punto 
            'del proceso se genere algun error
            Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "X")
            trans.Add(LOZDC)
            LOZDC.GetMulti(HC.ZonaDetalleFields.ZnidZona = Codigo)
            Try
                'agrego a la transaccion la entidad zona
                trans.Add(Entity)

                'valida si se a guardado exitosamente los datos de la zona
                If Not Entity.Save Then
                    'si no se guardo la zona realiza el rollback para regresar a su estado inicial
                    trans.Rollback()
                    MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                    'regreo el valor false para avisar que el proceso de actualizacion
                    'no se realizo exitosamente
                    Return False
                End If

                'se utiliza como bandera para saber si encontro una Zona Detalle
                ' en la la Coleccion de Detalles de la Zona
                Dim esta As Boolean = False

                'trans.Add(LOZDC)
                'siclo que recorre toda la coleccion entidad x entidad de la coleccion original 
                'de Detalles de la zona
                For Each entdetO As EC.ZonaDetalleEntity In LOZDC
                    'inicializo la bandera como false
                    esta = False

                    'siclo para buscar si exite esa zona detalle en la lista modificada de 
                    'Zona detalles
                    For Each entdetM As ZonaDetalleClass In Detalles
                        'valida si la entidad Zona Detalle es = a la entidad original
                        If entdetM.Zona.Codigo = entdetO.ZnidZona And entdetM.Poblacion.Codigo = entdetO.PidPoblacion Then
                            'establece la bandera como verdadero para especificar que encontro la Zona Detalle
                            'en la lista modificada
                            esta = True

                            If Not entdetM.ObtenerEntidad.IsDirty Then
                                'remueve de la coleccion modificada la Zona Detalle ya que esta ya esta almacenada
                                'en la BD en la Tabla ZonaDetalles
                                Detalles.Remove(entdetM)
                            End If
                            'me salgo del siclo
                            Exit For
                        End If
                    Next
                    'valida si no se encontro la Zona Detalle en la coleccion modificada
                    If Not esta Then
                        'declaro una variable ZonaDetalleEntity para agregarla a la transaccion
                        'Dim ent As EC.ZonaDetalleEntity

                        ''obtiene la entidad de la ZonaDetalleClass
                        'ent = entdetO.ObtenerEntidad

                        'agrego la ent a la transaccion antes de eliminar la Zona Detalle de la BD
                        trans.Add(entdetO)

                        'elimino la Zona Detalle de la BD y valido que se haya eliminado exitosamente
                        If Not entdetO.Delete Then
                            'en caso que no se haya eliminado exitosamente realizo el rollback 
                            'para deajar la BD como en un inicio
                            trans.Rollback()

                            'regreso el valor false para avisar que el proceso de actualizacion no se realizo 
                            'exitosamente
                            Return False
                        End If
                    End If
                Next
                'verifico si todabia contiene poblaciones los detalles de la zona
                If Detalles.Count > 0 Then
                    'declaro un un objeto ZonaDetalleCollection para poderlo 
                    'agregar la colleccion de Zona Detalles a una transaccion
                    Dim col As CC.ZonaDetalleCollection

                    'obtengo la coleccion de datos de los Detalles de la Zona
                    col = Detalles.ObtenerColeccion

                    'agrego a una transaccion la coleccion de ZonaDetalles
                    trans.Add(col)


                    If col.SaveMulti > 0 Then
                        'finalizo la transaccion
                        trans.Commit()
                        'aviso que el proceso de actualizacion se realizo exitosamente
                        Return True
                    Else
                        'en caso que se haya generado algun error durante el guardado
                        'realizo un rollback para regresar al estado inicial
                        trans.Rollback()
                        MsgBox("No se logro guardar, intente de nuevo", MsgBoxStyle.Exclamation, "Aviso")
                        'aviso que se genero un error y por lo tanto no se puedo completar
                        'el proceso
                        Return False
                    End If
                    'si no tiene poblaciones
                Else
                    'finalizo la transaccion
                    trans.Commit()
                    'aviso que el proceso de actualizacion se realizo exitosamente
                    Return True
                End If
            Catch ex As Exception
                'en caso que se haya generado algun error durante el guardado
                'realizo un rollback para regresar al estado inicial
                trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                'aviso que se genero un error y por lo tanto no se puedo completar
                'el proceso
                Return False
            End Try
        End If
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Return Entity.FetchUsingPK(Codigo)
    End Function

    Public Function ObtenerDetalles() As Boolean
        _ZonaDetalle.RellenarMe(Entity.ZonaDetalle)
        Return True
    End Function

    Public Function ObtenerEntidad() As EC.ZonaEntity
        Return Me.Entity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.ZonaEntity)
        Entity = Entidad
    End Sub

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Overrides Function tostring() As String
        Return Me.Descripcion
    End Function

End Class

Public Class ZonaDetalleClass
    Implements IEntidad


    Private ZonaDetalle As EC.ZonaDetalleEntity
    Private m_poblacion As PoblacionClass
    Private m_estado As EstadoClass
    Private m_ciudad As CiudadClass
    Private _Zona As ZonaClass
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado

    Sub New()
        AddHandler Modificado, AddressOf FueModificado
        'Inicializacion de Todas las variables
        ZonaDetalle = New EC.ZonaDetalleEntity
        m_poblacion = New PoblacionClass
        ZonaDetalle.ZnidZona = 0
        ZonaDetalle.PidPoblacion = 0
        'ZonaDetalle.ZndidEstado = 0
        'ZonaDetalle.ZndidCiudad = 0
        'ZonaDetalle.ZndidPoblacion = 0
        'ZonaDetalle.Zndestatus = EstatusEnum.Activo
        'ZonaDetalle.Poblacion = m_poblacion.ObtenerEntidad
    End Sub

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get
            'Return ZonaDetalle.Zndestatus
        End Get
        Set(ByVal value As EstatusEnum)
            'ZonaDetalle.Zndestatus = value
            RaiseEvent Modificado(Me, New EventArgs)
        End Set
    End Property

    Public Property Zona() As ZonaClass
        Get
            If _Zona Is Nothing Then
                _Zona = New ZonaClass
                _Zona.LeerEntidad(ZonaDetalle.Zona)
            End If

            Return _Zona
        End Get
        Set(ByVal value As ZonaClass)
            _Zona = value
            ZonaDetalle.Zona = value.ObtenerEntidad
        End Set
    End Property

    Public ReadOnly Property Estado() As EstadoClass
        Get

            m_estado = New EstadoClass(ZonaDetalle.IdEstado)
            Return m_poblacion.CodigoCiudad.CodigoEstado
        End Get
    End Property

    Public ReadOnly Property Ciudad() As CiudadClass
        Get
            m_ciudad = New CiudadClass(ZonaDetalle.IdEstado, ZonaDetalle.IdCiudad)
            Return m_poblacion.CodigoCiudad
        End Get
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            m_poblacion = New PoblacionClass(ZonaDetalle.IdEstado, ZonaDetalle.IdCiudad, Me.ZonaDetalle.PidPoblacion)
            Return m_poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            m_poblacion = value
            ZonaDetalle.PidPoblacion = m_poblacion.ObtenerEntidad.Codigo
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            'ZonaDetalle.Zndestatus = EstatusEnum.Inactivo
            If ZonaDetalle.Save() Then Return True
            RaiseEvent MensajeError(Me, "La Poblacion de la Zona no se pudo borrar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Guardar() As Boolean
        Try
            If ZonaDetalle.Save Then Return True
            RaiseEvent MensajeError(Me, "La Poblacion de la Zona no se pudo guardar.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Function Obtener(ByVal codigo As Integer) As Boolean Implements IEntidad.Obtener
        Try
            If ZonaDetalle.FetchUsingPK(Estado.Codigo, Ciudad.Codigo, Zona.Codigo, Poblacion.Codigo) Then
                RaiseEvent Modificado(Me, New EventArgs)
                Return True
            End If
            RaiseEvent MensajeError(Me, "La Poblacion de la Zona especificada no existe.")
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return False
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.ZonaDetalleEntity)
        ZonaDetalle = Entidad
    End Sub

    Public Function ObtenerEntidad() As EC.ZonaDetalleEntity
        Return Me.ZonaDetalle
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ZonaDetalleCollectionClass
    Inherits CollectionClass(Of ZonaDetalleClass)

    Private Coleccion As New CC.ZonaDetalleCollection
    Public Event MensajeError As MensajeErrorHandler
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression

    Public Function Obtener() As Integer
        Try
            Me.ClearItems()


            Coleccion.GetMulti(Nothing)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal ZonaDetalle As ZonaDetalleClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.ZonaDetalleFields.ZnidZona = ZonaDetalle.Zona)
            'Filtro.AddWithOr(HC.ZonaDetalleFields.ZndidCiudad = ZonaDetalle.Ciudad)
            Dim Conteo As Integer = Coleccion.GetDbCount(Filtro)
            If Conteo > 0 Then
                Coleccion.GetMulti(Filtro)
                Rellenar()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal poblacion As PoblacionClass) As ZonaDetalleCollectionClass
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            'Filtro.Add(HC.ZonaDetalleFields.ZndidPoblacion = poblacion.Codigo)
            Dim Conteo As Integer = Coleccion.GetDbCount(Filtro)
            If Conteo > 0 Then
                Coleccion.GetMulti(Filtro)
                Me.Rellenar()
            End If
            Return Me
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Obtener(ByVal CodigoZona As Integer) As Integer
        Try
            Me.ClearItems()


            Coleccion.GetMulti(HC.ZonaDetalleFields.ZnidZona = CodigoZona)

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        For Each Zonadetalle As EC.ZonaDetalleEntity In Coleccion
            Dim miZonad As New ZonaDetalleClass
            miZonad.LeerEntidad(Zonadetalle)
            Me.Add(miZonad)
        Next
    End Sub

    Public Sub RellenarMe(ByVal NuevaColeccion As CC.ZonaDetalleCollection)
        Me.Clear()
        For Each Zonadetalle As EC.ZonaDetalleEntity In NuevaColeccion
            Dim miZonad As New ZonaDetalleClass
            miZonad.LeerEntidad(Zonadetalle)
            Me.Add(miZonad)
        Next
    End Sub

    Private Sub RellenarColeccion()
        Coleccion = New CC.ZonaDetalleCollection
        For Each Zonadet As ZonaDetalleClass In Me
            Dim miZonad As New EC.ZonaDetalleEntity
            miZonad = Zonadet.ObtenerEntidad
            Coleccion.Add(miZonad)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.ZonaDetalleCollection
        RellenarColeccion()
        Return Coleccion
    End Function

    Sub New()
        MyBase.New()
    End Sub

End Class

Public Class ZonaCollectionClass
    Inherits ColleccionBase(Of EC.ZonaEntity, CC.ZonaCollection, ZonaClass)

    Private ZonaCollection As New CC.ZonaCollection
    Private Filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Obtener(Optional ByVal fcCondicion As CondicionEnum = CondicionEnum.Todos) As Integer
        Try
            Me.Clear()

            If fcCondicion = CondicionEnum.Todos Then
                ZonaCollection.GetMulti(Nothing)
            Else
                ZonaCollection.GetMulti(HC.ZonaFields.Estatus = fcCondicion)
            End If

            Rellenar()

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal activo As Boolean) As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = ZonaCollection.GetDbCount()
            If Conteo > 0 Then
                ZonaCollection.GetMulti(Nothing)
                For Each zonaEntity As EC.ZonaEntity In ZonaCollection
                    Dim zona As New ZonaClass
                    zona.LeerEntidad(zonaEntity)
                    'If zona.Estatus = EstatusEnum.Activo Then
                    Me.Add(zona)
                    'End If
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try

    End Function

    Public Function Obtener(ByVal Zona As ZonaClass) As Integer
        Try
            Me.ClearItems()
            Filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Filtro.Add(HC.ZonaFields.Codigo = Zona.Codigo)
            'Filtro.AddWithOr(HC.ListaPreciosField.LpdescCorta = Zona.Descripcion)
            'Filtro.AddWithOr(HC.ListaPreciosFields.LpdescCorta = Zona.DescripcionCorta)
            Filtro.AddWithOr(HC.ZonaFields.Descripcion = Zona.Descripcion)
            Filtro.AddWithOr(HC.ZonaFields.DescCorta = Zona.DescripcionCorta)
            Dim Conteo As Integer = ZonaCollection.GetDbCount(Filtro)
            If Conteo > 0 Then
                ZonaCollection.GetMulti(Filtro)
                For Each ZonaEntity As EC.ZonaEntity In ZonaCollection
                    Dim MiZona As New ZonaClass
                    MiZona.LeerEntidad(ZonaEntity)
                    Me.Add(MiZona)
                Next
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Integer
        ZonaCollection = New CC.ZonaCollection
        For Each Zona As ZonaClass In Me
            Dim ZonaEntity As New EC.ZonaEntity
            ZonaEntity = Zona.ObtenerEntidad()
            ZonaCollection.Add(ZonaEntity)
        Next
        Try
            Dim Conteo As Integer = ZonaCollection.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Borrar() As Integer
        ZonaCollection = New CC.ZonaCollection
        For Each Zona As ZonaClass In Me
            Dim ZonaEntity As New EC.ZonaEntity
            ZonaEntity = Zona.ObtenerEntidad()
            ZonaCollection.Add(ZonaEntity)
        Next
        Try
            Dim Conteo As Integer = ZonaCollection.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Private Sub Rellenar()
        Try
            Clear()
            For Each ente As EC.ZonaEntity In ZonaCollection
                Dim zon As New ZonaClass
                zon.LeerEntidad(ente)
                Add(zon)
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error al llenar la coleccion", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RellenarColeccion()
        Try
            ZonaCollection.Clear()
            For Each zon As ZonaClass In Me
                ZonaCollection.Add(zon.ObtenerEntidad)
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error al llenar la coleccion", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function ObtenerColeccion() As CC.ZonaCollection
        RellenarColeccion()
        Return ZonaCollection
    End Function

    Public Sub RellenarMe(ByVal Coleccion As CC.ZonaCollection)
        ZonaCollection = Coleccion
        Rellenar()
    End Sub

    Public Function Reporte() As CRepZona
        Dim Reportes As New CRepZona
        Dim ds As New DataSet
        Dim dtZon As New DSetZona.ZonaDataTable
        Dim dtZond As New DSetZona.ZonaDetalleDataTable
        For Each Zon As ZonaClass In Me
            Dim zonar As DSetZona.ZonaRow = dtZon.AddZonaRow(Zon.Codigo, Zon.Descripcion, Zon.DescripcionCorta, Zon.Observaciones, Zon.Estatus.ToString)
            For Each DetZona As ZonaDetalleClass In Zon.Detalles
                dtZond.AddZonaDetalleRow(DetZona.Estado.Descripcion, DetZona.Ciudad.Descripcion, DetZona.Poblacion.Descripcion, zonar)
            Next
        Next
        ds.Tables.Add(dtZon)
        Reportes.SetDataSource(ds)
        Return Reportes
    End Function

End Class