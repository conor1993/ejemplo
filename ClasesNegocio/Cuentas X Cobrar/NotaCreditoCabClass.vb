Imports EC = Integralab.ORM.EntityClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class NotaCreditoCabClass
    Inherits EC.NotaCreditoCabEntity

#Region "Miembros"
    Dim _Detalle As CC.NotaCreditoDetCollection
    Dim _Cliente As ClientesIntroductoresClass
    Dim _TipoNota As TiposNotasCreditoClass
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal NotaCreditoCab As EC.NotaCreditoCabEntity)
        Me.FolNota = NotaCreditoCab.FolNota
        Me.IdCliente = NotaCreditoCab.IdCliente
        Me.FechaNota = NotaCreditoCab.FechaNota
        Me.Elaboro = NotaCreditoCab.Elaboro
        Me.Autorizo = NotaCreditoCab.Autorizo
        Me.Estatus = NotaCreditoCab.Estatus
        Me.IdConcepto = NotaCreditoCab.IdConcepto
        Me.Total = NotaCreditoCab.Total
    End Sub

    Sub New(ByVal FolNota As String, ByVal IdCliente As Integer, ByVal FechaNota As Date, ByVal Elaboro As String, ByVal autorizo As String, ByVal Estatus As NotaCreditoEnum, ByVal IdConcepto As Integer, ByVal Total As Decimal)
        Me.FolNota = FolNota
        Me.IdCliente = IdCliente
        Me.FechaNota = FechaNota
        Me.Elaboro = Elaboro
        Me.Autorizo = autorizo
        Me.Estatus = Estatus
        Me.IdConcepto = IdConcepto
        Me.Total = Total
    End Sub
#End Region

#Region "Propiedades"
    ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing OrElse _Cliente.Codigo <> Me.IdCliente Then
                _Cliente = New ClientesIntroductoresClass(Me.MfacCatClientes)
            End If
            Return _Cliente
        End Get
    End Property

    ReadOnly Property NombreCliente() As String
        Get
            Return Cliente.Nombre
        End Get
    End Property

    ReadOnly Property Concepto() As TiposNotasCreditoClass
        Get
            If _TipoNota Is Nothing OrElse _TipoNota.Codigo <> Me.IdConcepto Then
                _TipoNota = New TiposNotasCreditoClass(Me.CatTipNotas)
            End If
            Return _TipoNota
        End Get
    End Property

    ReadOnly Property Detalle() As CC.NotaCreditoDetCollection
        Get
            If _Detalle Is Nothing Then
                _Detalle = Me.NotaCreditoDet
            End If
            Return _Detalle
        End Get
    End Property

    Property EstatusDescripcion() As NotaCreditoEnum
        Get
            Return CType(Estatus, NotaCreditoEnum)
        End Get
        Set(ByVal value As NotaCreditoEnum)
            Estatus = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub Guardar(ByVal Trans As HC.Transaction)
        Me.RecalcularTotal()
        Trans.Add(Me)

        If Me.Save() Then
            For Each DetalleNotaCredito As EC.NotaCreditoDetEntity In Me.Detalle
                Trans.Add(DetalleNotaCredito)
                DetalleNotaCredito.Save()
            Next
        End If
    End Sub

    Public Sub RecalcularTotal()
        Dim Total As Decimal
        For Each detalle As EC.NotaCreditoDetEntity In Me.Detalle
            Total += detalle.Total
        Next
        Me.Total = Total
    End Sub

    Public Sub Imprimir(ByVal Sesion As ECS.SesionesEntity)
        Dim Reporte As New RptNutrientes()
        Dim vent As New PreVisualizarForm

        vent.Text = "Notas de Crédito"
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Cuentas por Cobrar/Notas de Credito")
        vent.Reporte = Reporte
        vent.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        vent.WindowState = Windows.Forms.FormWindowState.Maximized
        vent.ShowDialog()
    End Sub

    Public Sub Cancelar(ByVal Trans As HC.Transaction, ByVal Observaciones As String)
        If Me.EstatusDescripcion = NotaCreditoEnum.CANCELADA Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.NOTAS_DE_CREDITO, 3)
        End If

        Trans.Add(Me)
        Me.Observaciones = Observaciones
        Me.EstatusDescripcion = NotaCreditoEnum.CANCELADA
        Me.Save()

        For Each DetalleNota As EC.NotaCreditoDetEntity In Me.Detalle
            If CType(DetalleNota.Estatus, NotaCreditoEnum) = NotaCreditoEnum.APLICADA Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.NOTAS_DE_CREDITO, 2)
            Else
                Trans.Add(DetalleNota)
                DetalleNota.Estatus = NotaCreditoEnum.CANCELADA
                DetalleNota.Save()
            End If
        Next
    End Sub
#End Region
End Class
