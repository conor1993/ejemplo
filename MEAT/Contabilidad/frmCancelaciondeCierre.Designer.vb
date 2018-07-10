<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaciondeCierre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel_principal = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Descripcion4 = New System.Windows.Forms.Label()
        Me.lbl_Descripcion3 = New System.Windows.Forms.Label()
        Me.lbl_descripcion2 = New System.Windows.Forms.Label()
        Me.lbl_descripcion1 = New System.Windows.Forms.Label()
        Me.lbl_Descripcion0 = New System.Windows.Forms.Label()
        Me.tb_Anio = New System.Windows.Forms.TextBox()
        Me.lbl_Anio = New System.Windows.Forms.Label()
        Me.btn_CancelarAnio = New System.Windows.Forms.Button()
        Me.pb_Cancelaranio = New System.Windows.Forms.ProgressBar()
        Me.timer_cancelaranio = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Pocentaje = New System.Windows.Forms.Label()
        Me.panel_principal.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_principal
        '
        Me.panel_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_principal.Controls.Add(Me.Panel1)
        Me.panel_principal.Controls.Add(Me.tb_Anio)
        Me.panel_principal.Controls.Add(Me.lbl_Anio)
        Me.panel_principal.Location = New System.Drawing.Point(12, 12)
        Me.panel_principal.Name = "panel_principal"
        Me.panel_principal.Size = New System.Drawing.Size(454, 246)
        Me.panel_principal.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_Descripcion4)
        Me.Panel1.Controls.Add(Me.lbl_Descripcion3)
        Me.Panel1.Controls.Add(Me.lbl_descripcion2)
        Me.Panel1.Controls.Add(Me.lbl_descripcion1)
        Me.Panel1.Controls.Add(Me.lbl_Descripcion0)
        Me.Panel1.Location = New System.Drawing.Point(18, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 160)
        Me.Panel1.TabIndex = 3
        '
        'lbl_Descripcion4
        '
        Me.lbl_Descripcion4.AutoSize = True
        Me.lbl_Descripcion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion4.Location = New System.Drawing.Point(37, 126)
        Me.lbl_Descripcion4.Name = "lbl_Descripcion4"
        Me.lbl_Descripcion4.Size = New System.Drawing.Size(164, 15)
        Me.lbl_Descripcion4.TabIndex = 6
        Me.lbl_Descripcion4.Text = "--  Ajustar Saldos de Cuentas"
        '
        'lbl_Descripcion3
        '
        Me.lbl_Descripcion3.AutoSize = True
        Me.lbl_Descripcion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion3.Location = New System.Drawing.Point(34, 100)
        Me.lbl_Descripcion3.Name = "lbl_Descripcion3"
        Me.lbl_Descripcion3.Size = New System.Drawing.Size(280, 15)
        Me.lbl_Descripcion3.TabIndex = 5
        Me.lbl_Descripcion3.Text = "--  Desactualizar y Cancelar Póliza de Cierre Anual"
        '
        'lbl_descripcion2
        '
        Me.lbl_descripcion2.AutoSize = True
        Me.lbl_descripcion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion2.Location = New System.Drawing.Point(34, 72)
        Me.lbl_descripcion2.Name = "lbl_descripcion2"
        Me.lbl_descripcion2.Size = New System.Drawing.Size(264, 15)
        Me.lbl_descripcion2.TabIndex = 4
        Me.lbl_descripcion2.Text = "--  Desactualizar y Cancelar Póliza de Traspaso"
        '
        'lbl_descripcion1
        '
        Me.lbl_descripcion1.AutoSize = True
        Me.lbl_descripcion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion1.Location = New System.Drawing.Point(34, 46)
        Me.lbl_descripcion1.Name = "lbl_descripcion1"
        Me.lbl_descripcion1.Size = New System.Drawing.Size(263, 15)
        Me.lbl_descripcion1.TabIndex = 3
        Me.lbl_descripcion1.Text = "--  Ajustar Fecha de Inicio de Ejercicio Contable"
        '
        'lbl_Descripcion0
        '
        Me.lbl_Descripcion0.AutoSize = True
        Me.lbl_Descripcion0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Descripcion0.Location = New System.Drawing.Point(34, 17)
        Me.lbl_Descripcion0.Name = "lbl_Descripcion0"
        Me.lbl_Descripcion0.Size = New System.Drawing.Size(332, 15)
        Me.lbl_Descripcion0.TabIndex = 2
        Me.lbl_Descripcion0.Text = "Al Ejecutar este Proceso se Efectuará lo Siguiente:"
        '
        'tb_Anio
        '
        Me.tb_Anio.Location = New System.Drawing.Point(56, 17)
        Me.tb_Anio.Name = "tb_Anio"
        Me.tb_Anio.ReadOnly = True
        Me.tb_Anio.Size = New System.Drawing.Size(57, 20)
        Me.tb_Anio.TabIndex = 1
        Me.tb_Anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_Anio
        '
        Me.lbl_Anio.AutoSize = True
        Me.lbl_Anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Anio.Location = New System.Drawing.Point(15, 18)
        Me.lbl_Anio.Name = "lbl_Anio"
        Me.lbl_Anio.Size = New System.Drawing.Size(35, 15)
        Me.lbl_Anio.TabIndex = 0
        Me.lbl_Anio.Text = "Año:"
        '
        'btn_CancelarAnio
        '
        Me.btn_CancelarAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CancelarAnio.Location = New System.Drawing.Point(359, 274)
        Me.btn_CancelarAnio.Name = "btn_CancelarAnio"
        Me.btn_CancelarAnio.Size = New System.Drawing.Size(107, 29)
        Me.btn_CancelarAnio.TabIndex = 2
        Me.btn_CancelarAnio.Text = "Cancelar Año"
        Me.btn_CancelarAnio.UseVisualStyleBackColor = True
        '
        'pb_Cancelaranio
        '
        Me.pb_Cancelaranio.Location = New System.Drawing.Point(31, 283)
        Me.pb_Cancelaranio.Name = "pb_Cancelaranio"
        Me.pb_Cancelaranio.Size = New System.Drawing.Size(315, 10)
        Me.pb_Cancelaranio.TabIndex = 3
        '
        'timer_cancelaranio
        '
        '
        'lbl_Pocentaje
        '
        Me.lbl_Pocentaje.AutoSize = True
        Me.lbl_Pocentaje.Location = New System.Drawing.Point(190, 261)
        Me.lbl_Pocentaje.Name = "lbl_Pocentaje"
        Me.lbl_Pocentaje.Size = New System.Drawing.Size(21, 13)
        Me.lbl_Pocentaje.TabIndex = 4
        Me.lbl_Pocentaje.Text = "0%"
        '
        'frmCancelaciondeCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 328)
        Me.Controls.Add(Me.lbl_Pocentaje)
        Me.Controls.Add(Me.pb_Cancelaranio)
        Me.Controls.Add(Me.btn_CancelarAnio)
        Me.Controls.Add(Me.panel_principal)
        Me.Name = "frmCancelaciondeCierre"
        Me.Text = "Cancelación de Cierre Anual"
        Me.panel_principal.ResumeLayout(False)
        Me.panel_principal.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panel_principal As Panel
    Friend WithEvents tb_Anio As TextBox
    Friend WithEvents lbl_Anio As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Descripcion4 As Label
    Friend WithEvents lbl_Descripcion3 As Label
    Friend WithEvents lbl_descripcion2 As Label
    Friend WithEvents lbl_descripcion1 As Label
    Friend WithEvents lbl_Descripcion0 As Label
    Friend WithEvents btn_CancelarAnio As Button
    Friend WithEvents pb_Cancelaranio As ProgressBar
    Friend WithEvents timer_cancelaranio As Timer
    Friend WithEvents lbl_Pocentaje As Label
End Class
