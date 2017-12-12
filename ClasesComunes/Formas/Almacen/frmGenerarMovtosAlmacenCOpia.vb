Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Public Class frmGenerarMovtosAlmacenCOpia
#Region "Miembros"
    Dim Almacen As CN.AlmacenClass
    Dim Sucursal As CN.SucursalClass
    Dim InvMovAlmacenCab As CN.AlmacenGeneral.MovimientoAlmacenPVClass
    Dim InvMovAlmacenDet As CN.AlmacenGeneral.MovimientoAlmacenPVDetalleClass
    Dim _FolioAlm As String = ""
    Dim GranTotal As Decimal = 0
    Dim GranCantidad As Decimal = 0
#End Region
    
End Class