Public Class FrmFiltradoListaPrecioDetalle

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmFiltradoListaPrecioDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim lineas As New ClasesNegocio.LineaCollectionClass
            lineas.Obtener(ClasesNegocio.CondicionEnum.TODOS)
            Dim marcas As New ClasesNegocio.MarcaCollectionClass
            marcas.Obtener(ClasesNegocio.CondicionEnum.TODOS)

            Dim lin As New ClasesNegocio.LineaClass

            lin.Descripcion = "TODAS"

            Me.LineaC.Add(lin)
            For Each linea As ClasesNegocio.LineaClass In lineas
                Me.LineaC.Add(linea)
            Next

            Dim marc As New ClasesNegocio.MarcaClass

            marc.Nombre = "TODAS"

            Me.MarcaC.Add(marc)
            For Each Marca As ClasesNegocio.MarcaClass In marcas
                Me.MarcaC.Add(Marca)
            Next

            Dim sublin As New ClasesNegocio.SubLineaClass
            sublin.Descripcion = "TODAS"
            Me.SubLineaC.Add(sublin)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CmbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLinea.SelectedIndexChanged
        If CmbLinea.SelectedIndex > -1 Then
            If CmbLinea.SelectedIndex = 0 Then
                Me.SubLineaC.Clear()
                Dim sublin As New ClasesNegocio.SubLineaClass
                sublin.Descripcion = "TODAS"
                SubLineaC.Add(sublin)
            Else
                Dim sublineas As New ClasesNegocio.SubLineaCollectionClass
                sublineas.Obtener(DirectCast(CmbLinea.SelectedItem, ClasesNegocio.LineaClass))

                Me.SubLineaC.Clear()
                Dim sublin As New ClasesNegocio.SubLineaClass
                sublin.Descripcion = "TODAS"
                SubLineaC.Add(sublin)

                For Each sublinea As ClasesNegocio.SubLineaClass In sublineas
                    SubLineaC.Add(sublinea)
                Next
            End If
        End If
    End Sub

End Class