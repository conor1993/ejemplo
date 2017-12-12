Imports System.Drawing

Public Class frmCobrarEmergente
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Opacity = 0.98
        
    End Sub
    Public formaPadre As System.Windows.Forms.Form

    Public Property Padre() As System.Windows.Forms.Form
        Get
            Return Me.formaPadre
        End Get
        Set(ByVal Value As System.Windows.Forms.Form)
            Me.formaPadre = Value
        End Set
    End Property



    Private Sub frmCobrarEmergente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F8
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Case e.KeyCode
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Select
    End Sub

    Private Sub frmCobrarEmergente_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Outset)

    End Sub

    Private Sub frmCobrarEmergente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim scr = Screen.FromPoint(Me.Padre.Location)
        Me.Location = New Point(Me.Padre.Location.X + Me.Padre.Width, Me.Padre.Location.Y + (Me.Padre.Height / 2 - Me.Height / 2))
    End Sub
End Class