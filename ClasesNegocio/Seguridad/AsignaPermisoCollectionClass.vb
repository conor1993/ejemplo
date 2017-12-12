Imports EC = Integralab.ORM.EntityClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class AsignaPermisoCollectionClass
    Inherits ColleccionBase(Of EC.AutorizaProcesosEntity, CC.AutorizaProcesosCollection, AsignarPermisoClass)

    Public Sub Inicializar(ByVal idEmpresa As Integer)
        Dim usuariosConPermisos As New List(Of Integer)

        Obtener(HC.AutorizaProcesosFields.EmpresaId = idEmpresa)

        For Each usuarioConPermiso As AsignarPermisoClass In Me
            usuariosConPermisos.Add(usuarioConPermiso.IdUsuarioAlta)
        Next

        Dim usuarios As New CCS.UsuarioCollection
        Dim rel As New OC.RelationCollection

        rel.Add(New OC.EntityRelation(HCS.DetalleempresasFields.Usrndx, HCS.UsuarioFields.Usrndx, SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany), SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

        If usuariosConPermisos.Count > 0 Then
            usuarios.GetMulti(New OC.FieldCompareRangePredicate(HCS.UsuarioFields.Usrndx, _
                                       True, usuariosConPermisos.ToArray()) And HCS.DetalleempresasFields.Empndx = idEmpresa, 0, Nothing, rel)
        Else
            usuarios.GetMulti(Nothing)
        End If

        For Each usuario As ECS.UsuarioEntity In usuarios
            Dim permisoUsuario As New AsignarPermisoClass

            permisoUsuario.IdUsuarioAlta = usuario.Usrndx
            permisoUsuario.IdEmpresa = idEmpresa

            Add(permisoUsuario)
        Next
    End Sub

    Public Sub Guardar()
        Me.ObtenerColeccion.SaveMulti()
    End Sub
End Class