Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CN = ClasesNegocio
Imports System.Windows.Forms



Public Class BitacoraPV
    Inherits ClassBase(Of EC.BitacoraPvEntity)

#Region "Definiciones"
    Public mensaje As String = ""
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.BitacoraPvEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal idBit As Integer)
        MyBase.New(New EC.BitacoraPvEntity(idBit))
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdBitacora() As Integer
        Get
            Return Entity.IdBitacora
        End Get
        Set(ByVal value As Integer)
            Entity.IdBitacora = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return Entity.Fecha
        End Get
        Set(ByVal value As DateTime)
            Entity.Fecha = value
        End Set
    End Property

    Public Property Forma() As String
        Get
            Return Entity.Forma
        End Get
        Set(ByVal value As String)
            Entity.Forma = value
        End Set
    End Property

    Public Property Evento() As String
        Get
            Return Entity.Evento
        End Get
        Set(ByVal value As String)
            Entity.Evento = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return Entity.Usuario
        End Get
        Set(ByVal value As String)
            Entity.Usuario = value
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
#End Region

#Region "MEtodos"
    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        'Trans.Add(Entity)
        'Return Entity.Save
        Try
            If Entity.IsNew Then
                Trans.Add(Entity)
                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            Else
                Trans.Add(Entity)
                If Not Entity.Save Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function



    Public Sub llenarDatosTag(ByVal evento As String, ByVal usuario As String, ByVal Controles As System.Windows.Forms.Control.ControlCollection)

        'Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Bitacora")


        For Each ctrl As Control In Controles
            Select Case True
                Case TypeOf ctrl Is Windows.Forms.GroupBox
                    ''cuando es un groupbox
                    llenarDatosTag(evento, usuario, CType(ctrl, GroupBox).Controls)
                Case TypeOf ctrl Is Windows.Forms.Panel
                    llenarDatosTag(evento, usuario, CType(ctrl, GroupBox).Controls)
                Case TypeOf ctrl Is System.Windows.Forms.TabControl
                    For Each tp As TabPage In CType(ctrl, TabControl).TabPages
                        llenarDatosTag(evento, usuario, tp.Controls)
                    Next
                Case TypeOf ctrl Is System.Windows.Forms.TextBox
                    ctrl.Tag = CType(ctrl, TextBox).Text
                    'mensaje &= ctrl.Name & "-" & ctrl.Text & " | "
                Case TypeOf ctrl Is System.Windows.Forms.ComboBox
                    ctrl.Tag = CType(ctrl, ComboBox).Text
                    'mensaje &= ctrl.Name & "-" & ctrl.Text & " | "
                Case TypeOf ctrl Is System.Windows.Forms.CheckBox
                    ctrl.Tag = CType(ctrl, CheckBox).Checked.ToString
                    'mensaje &= ctrl.Name & "-" & CType(ctrl, CheckBox).Checked.ToString & " | "
                Case TypeOf ctrl Is System.Windows.Forms.RadioButton
                    ctrl.Tag = CType(ctrl, RadioButton).Checked.ToString
                    'mensaje &= ctrl.Name & "-" & CType(ctrl, RadioButton).Checked.ToString & " | "
            End Select
        Next

        'For Each ctrl As Control In forma.Controls

        '    If TypeOf ctrl Is System.Windows.Forms.Panel Or TypeOf ctrl Is System.Windows.Forms.GroupBox Then
        '        For Each cr As Control In ctrl.Controls
        '            If TypeOf cr Is System.Windows.Forms.TextBox Then
        '                mensaje &= cr.Name & "-" & IIf(cr.Text <> "", cr.Text, "vacio") & " | "
        '            End If
        '            If TypeOf cr Is System.Windows.Forms.ComboBox Then
        '                mensaje &= cr.Name & "-" & cr.Text & " | "
        '            End If
        '            If TypeOf cr Is System.Windows.Forms.CheckBox Then
        '                mensaje &= cr.Name & "-" & CType(cr, CheckBox).Checked.ToString & " | "
        '            End If
        '            If TypeOf cr Is System.Windows.Forms.RadioButton Then
        '                mensaje &= cr.Name & "-" & CType(cr, RadioButton).Checked.ToString & " | "
        '            End If
        '            If TypeOf cr Is System.Windows.Forms.TabControl Then
        '                For Each tp As TabPage In CType(cr, TabControl).TabPages
        '                    For Each c As Control In tp.Controls
        '                        If TypeOf c Is System.Windows.Forms.TextBox Then
        '                            mensaje &= c.Name & "-" & IIf(c.Text <> "", c.Text, "vacio") & " | "
        '                        End If
        '                        If TypeOf c Is System.Windows.Forms.ComboBox Then
        '                            mensaje &= c.Name & "-" & c.Text & " | "
        '                        End If
        '                        If TypeOf c Is System.Windows.Forms.CheckBox Then
        '                            mensaje &= c.Name & "-" & CType(c, CheckBox).Checked.ToString & " | "
        '                        End If
        '                        If TypeOf c Is System.Windows.Forms.RadioButton Then
        '                            mensaje &= c.Name & "-" & CType(c, RadioButton).Checked.ToString & " | "
        '                        End If
        '                    Next
        '                Next
        '            End If
        '        Next
        '    End If

        '    If TypeOf ctrl Is System.Windows.Forms.TabControl Then
        '        For Each tp As TabPage In CType(ctrl, TabControl).TabPages
        '            For Each cr As Control In tp.Controls
        '                If TypeOf cr Is System.Windows.Forms.TextBox Then
        '                    mensaje &= cr.Name & "-" & IIf(cr.Text <> "", cr.Text, "vacio") & " | "
        '                End If
        '                If TypeOf cr Is System.Windows.Forms.ComboBox Then
        '                    mensaje &= cr.Name & "-" & cr.Text & " | "
        '                End If
        '                If TypeOf cr Is System.Windows.Forms.CheckBox Then
        '                    mensaje &= cr.Name & "-" & CType(cr, CheckBox).Checked.ToString & " | "
        '                End If
        '                If TypeOf cr Is System.Windows.Forms.RadioButton Then
        '                    mensaje &= cr.Name & "-" & CType(cr, RadioButton).Checked.ToString & " | "
        '                End If
        '            Next
        '        Next
        '    End If


        '    If TypeOf ctrl Is System.Windows.Forms.TextBox Then
        '        mensaje &= ctrl.Name & "-" & ctrl.Text & " | "
        '    End If
        '    If TypeOf ctrl Is System.Windows.Forms.ComboBox Then
        '        mensaje &= ctrl.Name & "-" & ctrl.Text & " | "
        '    End If
        '    If TypeOf ctrl Is System.Windows.Forms.CheckBox Then
        '        mensaje &= ctrl.Name & "-" & CType(ctrl, CheckBox).Checked.ToString & " | "
        '    End If
        '    If TypeOf ctrl Is System.Windows.Forms.RadioButton Then
        '        mensaje &= ctrl.Name & "-" & CType(ctrl, RadioButton).Checked.ToString & " | "
        '    End If
        'Next

        ''MsgBox(mensaje, MsgBoxStyle.Information, Application.ProductName)
        'Me.Fecha = Now
        'Me.Forma = forma.Name
        'Me.Evento = evento
        'Me.Usuario = usuario
        'Me.Descripcion = mensaje

        'If Not Guardar(Trans) Then
        '    Trans.Rollback()
        '    MsgBox("Error al generar la bitacora.", MsgBoxStyle.Critical, Application.ProductName & " ERROR")
        'End If
        'Trans.Commit()

    End Sub

    Public Sub diferencias(ByVal Controles As System.Windows.Forms.Control.ControlCollection)
        For Each ctrl As Control In Controles
            Select Case True
                Case TypeOf ctrl Is Windows.Forms.GroupBox
                    ''cuando es un groupbox
                    diferencias(CType(ctrl, GroupBox).Controls)
                Case TypeOf ctrl Is Windows.Forms.Panel
                    diferencias(CType(ctrl, GroupBox).Controls)
                Case TypeOf ctrl Is System.Windows.Forms.TabControl
                    For Each tp As TabPage In CType(ctrl, TabControl).TabPages
                        diferencias(tp.Controls)
                    Next
                Case TypeOf ctrl Is System.Windows.Forms.TextBox
                    If ctrl.Name.ToString.Substring(0, 2).Equals("pk") Then
                        mensaje &= ctrl.Name & ": " & ctrl.Text & " | "
                    ElseIf Not ctrl.Tag.ToString.Equals(ctrl.Text.ToString) Then
                        mensaje &= ctrl.Name & ": " & ctrl.Tag.ToString & "->" & ctrl.Text & " | "
                    End If
                    'ctrl.Tag = CType(ctrl, TextBox).Text
                    'mensaje &= ctrl.Name & "-" & ctrl.Text & " | "
                Case TypeOf ctrl Is System.Windows.Forms.ComboBox
                    If ctrl.Name.ToString.Substring(0, 2).Equals("pk") Then
                        mensaje &= ctrl.Name & ": " & ctrl.Text & " | "
                    ElseIf Not ctrl.Tag.ToString.Equals(ctrl.Text.ToString) Then
                        mensaje &= ctrl.Name & ": " & ctrl.Tag.ToString & "->" & ctrl.Text & " | "
                    End If
                Case TypeOf ctrl Is System.Windows.Forms.CheckBox
                    If ctrl.Name.ToString.Substring(0, 2).Equals("pk") Then
                        mensaje &= ctrl.Name & ": " & ctrl.Text & " | "
                    ElseIf Not ctrl.Tag.ToString.Equals(CType(ctrl, CheckBox).Checked.ToString) Then
                        mensaje &= ctrl.Name & ": " & ctrl.Tag.ToString & "->" & ctrl.Text & " | "
                    End If
                Case TypeOf ctrl Is System.Windows.Forms.RadioButton
                    If ctrl.Name.ToString.Substring(0, 2).Equals("pk") Then
                        mensaje &= ctrl.Name & ": " & ctrl.Text & " | "
                    ElseIf Not ctrl.Tag.ToString.Equals(CType(ctrl, RadioButton).Checked.ToString) Then
                        mensaje &= ctrl.Name & ": " & ctrl.Tag.ToString & "->" & ctrl.Text & " | "
                    End If
            End Select
        Next
    End Sub
#End Region




End Class

