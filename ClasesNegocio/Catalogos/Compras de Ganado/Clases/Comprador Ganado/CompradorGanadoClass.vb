Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports System.Windows.Forms
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class CompradorGanadoClass
    Inherits ClassBase(Of EC.McgcatCompradoresdeGanadoEntity)

#Region "Miembros"
    Dim _CodComprador As Integer
    Dim _Cuenta As CuentaContableClass
    Dim _Poblacion As PoblacionClass
#End Region

#Region "Constructores"
    Public Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Entidad As EC.McgcatCompradoresdeGanadoEntity)
        MyBase.New(Entidad)
    End Sub

    Sub New(ByVal Codigo As Integer)
        MyBase.New(New EC.McgcatCompradoresdeGanadoEntity(Codigo))
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property NomCompleto() As String
        Get
            Return String.Format("{0} {1} {2}", Entity.Nombre, Me.ApellidoPaterno, Me.ApellidoMaterno)
        End Get
    End Property

    ReadOnly Property Estado() As EstadoClass
        Get
            Return Ciudad.CodigoEstado
        End Get
    End Property

    ReadOnly Property Ciudad() As CiudadClass
        Get
            Return Poblacion.CodigoCiudad
        End Get
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If _Poblacion Is Nothing Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            ElseIf Not _Poblacion.Codigo = IdPoblacion Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If

            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            _Poblacion = value

            'If _Poblacion Is Nothing Then
            '     = Nothing
            'Else
            '    Entity.Poblacion = value.ObtenerEntidad
            'End If
        End Set
    End Property

    ReadOnly Property IdComprador() As Integer
        Get
            Return Entity.IdComprador
        End Get
    End Property

    Property Nombre() As String
        Get
            Return Entity.Nombre
        End Get
        Set(ByVal value As String)
            Entity.Nombre = value
        End Set
    End Property

    Property ApellidoPaterno() As String
        Get
            Return Entity.ApellidoPaterno
        End Get
        Set(ByVal value As String)
            Entity.ApellidoPaterno = value
        End Set
    End Property

    Property ApellidoMaterno() As String
        Get
            Return Entity.ApellidoMaterno
        End Get
        Set(ByVal value As String)
            Entity.ApellidoMaterno = value
        End Set
    End Property

    Property RFC() As String
        Get
            Return Entity.Rfc
        End Get
        Set(ByVal value As String)
            Entity.Rfc = value
        End Set
    End Property

    Property Calle() As String
        Get
            Return Entity.CalleyNumero
        End Get
        Set(ByVal value As String)
            Entity.CalleyNumero = value
        End Set
    End Property

    Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get
        Set(ByVal value As String)
            Entity.Colonia = value
        End Set
    End Property

    Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property

    Property PagarComision() As Boolean
        Get
            Return Entity.PagarComision
        End Get
        Set(ByVal value As Boolean)
            Entity.PagarComision = value
        End Set
    End Property

    Property ComisionxCabeza() As Decimal
        Get
            Return Entity.ComisionxCabeza
        End Get
        Set(ByVal value As Decimal)
            Entity.ComisionxCabeza = value
        End Set
    End Property

    Property CuentaContable() As CuentaContableClass
        Get
            If _Cuenta Is Nothing Then
                _Cuenta = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _Cuenta
        End Get
        Set(ByVal value As CuentaContableClass)
            _Cuenta = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Property Estatus() As EstatusEnum
        Get
            Return CType(Entity.Estatus, EstatusEnum)
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
        End Set
    End Property

    Property FechaBaja() As Date
        Get
            Return Entity.FechaBaja
        End Get
        Set(ByVal value As Date)
            Entity.FechaBaja = value
        End Set
    End Property

    Public Property ComisionPorKilo() As Decimal
        Get
            Return Entity.ComisionXkilo
        End Get
        Set(ByVal value As Decimal)
            Entity.ComisionXkilo = value
        End Set
    End Property

    Public Shared Function CargarCompradorGanado(ByVal IdComprador As Integer) As CompradorGanadoClass
        Dim CompradorGanado As New CompradorGanadoClass
        CompradorGanado.Obtener(IdComprador)
        Return CompradorGanado
    End Function
#End Region

#Region "Metodos"
    Public Shadows Function Borrar() As Boolean
        Try
            If MessageBox.Show("¿Quiere cancelar el comprador?", "Cancelar Comprador", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Return False
            End If

            Entity.Estatus = EstatusEnum.INACTIVO

            Return Entity.Save()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Try

            'If SPA.UspMcgcatCompradoresdeGanado(Nombre, ApellidoPaterno, ApellidoMaterno, RFC, Calle, Colonia, IdEstado, IdCiudad, IdPoblacion, PagarComision, ComisionxCabeza, CtaMay, SubCta, SsbCta, SssCta, Estatus, FechaAlta, FechaBaja, Func, NumOpc, IdComprador, trans) = 0 Then
            '    'RaiseEvent MensajeError(Me, "Error al guardar información de comprador de ganado")
            '    'MessageBox.Show("No se pudo Guardar la informacion de  Comprador de Ganado", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Return False
            'End If

            Dim coleccion As New CC.McgcatCompradoresdeGanadoCollection
            If Entity.IsNew Then
                If coleccion.GetDbCount(HC.McgcatCompradoresdeGanadoFields.Nombre = Nombre And HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno = ApellidoPaterno And HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
                    MessageBox.Show("Comprador de Ganado ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    'Else
                    '    trans.Add(CompradorGan)
                    '    CompradorGan.FetchUsingPK(IdComprador)
                    '    Return True
                End If
            Else
                If coleccion.GetDbCount(Not HC.McgcatCompradoresdeGanadoFields.IdComprador = IdComprador And HC.McgcatCompradoresdeGanadoFields.Nombre = Nombre And HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno = ApellidoPaterno And HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno = ApellidoMaterno) > 0 Then
                    MessageBox.Show("Comprador de Ganado ya existe", "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    'Else
                    '    Return CompradorGan.Save
                End If
            End If
            Return Entity.Save
        Catch ex As Exception
            'RaiseEvent MensajeError(Me, "Error al guardar información de comprador de ganado")
            MessageBox.Show("No se pudo Guardar la informacion de Comprador de Ganado" & ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
            Return False
        End Try
    End Function
#End Region
End Class