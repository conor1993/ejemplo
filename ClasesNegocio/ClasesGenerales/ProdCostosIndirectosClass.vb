Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class ProdCostosIndirectosClass
    Implements IEntidad


    Private PCI As EC.ProductoCostoIndirectoEntity
    Private PCIC As New CC.ProductoCostoIndirectoCollection
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private m_costoindirecto As New CostosIndirectosClass
    Private m_producto As New ProductoGeneralClass

    Public Property PDProducto() As ProductoGeneralClass
        Get
            m_producto.LeerEntidad(PCI.Producto)
            Return m_producto
        End Get
        Set(ByVal value As ProductoGeneralClass)
            m_producto = value
            PCI.Producto = m_producto.ObtenerEntidad()
        End Set
    End Property

    Public Property CostoIndirecto() As CostosIndirectosClass
        Get
            m_costoindirecto.LeerEntidad(PCI.CostoIndirecto)
            Return m_costoindirecto
        End Get
        Set(ByVal value As CostosIndirectosClass)
            m_costoindirecto = value
            PCI.CostoIndirecto = m_costoindirecto.ObtenerEntidad()
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return PCI.Importe
        End Get
        Set(ByVal value As Decimal)
            PCI.Importe = value
        End Set
    End Property

    Public Function Borrar() As Boolean Implements IEntidad.Borrar
        Try
            Me.Estatus = EstatusEnum.INACTIVO
            If PCI.Save Then
                Return True
            Else
                MsgBox("No se logró dar de baja el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox("No se logró dar de baja el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Public Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Function Guardar() As Boolean
        Try
            If PCI.Save Then
                Return True
            Else
                MsgBox("No se logró guardar el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("No se logro guardar el producto, intente nuevamente...", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End Try
    End Function

    Private Sub FueModificado(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Sub New()
        AddHandler Modificado, AddressOf FueModificado

        PCI = New EC.ProductoCostoIndirectoEntity

        PCI.Producto = Nothing
        PCI.CostoIndirecto = Nothing
        PCI.Importe = 0
    End Sub

    Public Overrides Function ToString() As String
        Return Me.PDProducto.Descripcion
    End Function

    Public Function ObtenerEntidad() As EC.ProductoCostoIndirectoEntity
        Return PCI
    End Function

    Public Sub LeerEntidad(ByVal FcEntidad As EC.ProductoCostoIndirectoEntity)
        PCI = FcEntidad
    End Sub

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ProdCostoIndirectoCollection
    Inherits CollectionClass(Of ProdCostosIndirectosClass)

    Private PCIColl As New CC.ProductoCostoIndirectoCollection
    Public Event MensajeError As MensajeErrorHandler

    Sub New()
        MyBase.New()
    End Sub

    Public Function Borrar() As Object
        PCIColl = New CC.ProductoCostoIndirectoCollection
        For Each PROCI As ProdCostosIndirectosClass In Me
            Dim PCIEntity As New EC.ProductoCostoIndirectoEntity
            PCIEntity = PROCI.ObtenerEntidad()
            PCIColl.Add(PCIEntity)
        Next
        Try
            Dim Conteo As Integer = PCIColl.DeleteMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Guardar() As Object
        PCIColl = New CC.ProductoCostoIndirectoCollection
        For Each PROCI As ProdCostosIndirectosClass In Me
            Dim PCIEntity As New EC.ProductoCostoIndirectoEntity
            PCIEntity = PROCI.ObtenerEntidad()
            PCIColl.Add(PCIEntity)
        Next
        Try
            Dim Conteo As Integer = PCIColl.SaveMulti()
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener() As Integer
        Try
            Me.ClearItems()
            Dim Conteo As Integer = PCIColl.GetDbCount()
            If Conteo > 0 Then
                PCIColl.GetMulti(Nothing)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Private Sub RellenarMe()
        Me.ClearItems()
        For Each PCIEntity As EC.ProductoCostoIndirectoEntity In PCIColl
            Dim PROCI As New ProdCostosIndirectosClass
            PROCI.LeerEntidad(PCIEntity)
            Me.Add(PROCI)
        Next
    End Sub

    Public Function Obtener(ByVal PROCI As ProdCostosIndirectosClass) As Integer
        Try
            Dim filtro As SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            Me.ClearItems()
            filtro = New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.ProductoCostoIndirectoFields.CodigoProducto = PROCI.PDProducto)
            filtro.AddWithOr(HC.ProductoCostoIndirectoFields.CodigoCostoIndirecto = PROCI.CostoIndirecto)
            'filtro.AddWithOr(HC.ProductoCostoIndirectoFields.Importe = PROCI.Importe)
            Dim Conteo As Integer = PCIColl.GetDbCount(filtro)
            If Conteo > 0 Then
                PCIColl.GetDbCount(filtro)
                RellenarMe()
            End If
            Return Conteo
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function ObtenerPCIColl() As CC.ProductoCostoIndirectoCollection
        RellenarPCIColl()
        Return PCIColl
    End Function

    Private Sub RellenarPCIColl()
        PCIColl = New CC.ProductoCostoIndirectoCollection
        For Each PROCI As ProdCostosIndirectosClass In Me
            Dim PCIEntity As New EC.ProductoCostoIndirectoEntity
            PCIEntity = PROCI.ObtenerEntidad
            PCIColl.Add(PCIEntity)
        Next
    End Sub

    Public Function ObtenerColeccion() As CC.ProductoCostoIndirectoCollection
        RellenarPCIColl()
        Return PCIColl
    End Function

    Public Sub LeerColeccion(ByVal Coleccion As CC.ProductoCostoIndirectoCollection)
        PCIColl = Coleccion
        RellenarMe()
    End Sub

End Class