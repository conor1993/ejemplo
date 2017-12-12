Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class AplicacionFormulaDetalleCollectionClass
    Inherits ColleccionBase(Of EC.DetAplForEntity, CC.DetAplForCollection, AplicacionFormulaDetalleClass)

    Public Function Guardar(ByVal trans As HC.Transaction) As Boolean
        Dim finalizarTransaccion As Boolean = False

        If trans Is Nothing Then
            trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Detalle Aplicacion Form")
            finalizarTransaccion = True
        End If

        Try
            For Each detalle As AplicacionFormulaDetalleClass In Me
                detalle.Guardar(trans)
            Next

            If finalizarTransaccion Then
                trans.Commit()
            End If

            Return True
        Catch ex As Exception
            If finalizarTransaccion Then
                trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            Else
                Throw ex
            End If
        End Try
    End Function

    Public Function Borrar(ByVal trans As HC.Transaction) As Boolean
        Dim finalizarTransaccion As Boolean = False

        If trans Is Nothing Then
            trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Detalle Aplicacion Form")
            finalizarTransaccion = True
        End If

        Try
            For Each detalle As AplicacionFormulaDetalleClass In Me
                detalle.Borrar(trans)
            Next

            If finalizarTransaccion Then
                trans.Commit()
            End If

            Return True
        Catch ex As Exception
            If finalizarTransaccion Then
                trans.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            Else
                Throw ex
            End If
        End Try
    End Function
End Class