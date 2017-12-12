
Imports System
Imports System.IO.Ports

Public Class Frmproduccionselecciondepuerto

#Region "propiedades"

    Private _count As Integer

    Public Property Puerto() As Integer

        Get
            Return _count
        End Get

        Set(ByVal value As Integer)
            _count = value
        End Set

    End Property

#End Region

#Region "eventos"

    Private Sub Frmproduccionselecciondepuertos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

#End Region

#Region "metodos del sistema"

    Private Sub cargarCombo()
        Dim ports As String() = SerialPort.GetPortNames()
        Dim port As String = ""
        For Each port In ports
            cmbselectports.Items.Add(obtenerPuertodecadena(port))
        Next port
    End Sub

    Private Function obtenerPuertodecadena(cadena As String) As Integer
        Dim port As Integer = 0
        cadena = cadena.Substring(3, cadena.Length - 3)
        If IsNumeric(cadena) Then
            port = CInt(cadena)
        End If
        Return port
    End Function

#End Region

    Private Sub cmbselectports_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbselectports.SelectionChangeCommitted
        Puerto() = CInt(cmbselectports.SelectedItem)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class