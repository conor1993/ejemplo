Public Enum EstatusEnum As Byte
    ACTIVO = 1
    INACTIVO = 0
End Enum
Public Enum CondicionEnum As Byte
    ACTIVOS = 1
    INACTIVOS = 0
    TODOS = 2
End Enum
Public Enum PersonaEnum As Byte
    FISICA = 1
    MORAL = 0
End Enum

Public Enum DiasEnum As Byte
    DOMINGO
    LUNES
    MARTES
    MIERCOLES
    JUEVES
    VIERNES
    SABADO
End Enum
Public Enum SiNoEnum
    NO = False
    SI = True
End Enum
Public Enum TCambioEnum As Byte
    NO = 4
    SI = 5
End Enum
Public Enum TCamionEnum As Byte
    TRACTOR = 1
    REMOLQUE = 2
End Enum

Public Enum PPagoEnum As Byte
    NO = 0
    SI = 1
End Enum

Public Enum AlmacenEnum As Byte
    ALMACEN = 3
    SUBALMACEN = 4
    TODOS = 5
End Enum

Public Enum DireccionEnum As Byte
    ENTRADAS
    SALIDAS
End Enum
Public Enum PreferenciaEnum As Byte
    ALTO = 0
    NORMAL = 1
    BAJO = 2
End Enum