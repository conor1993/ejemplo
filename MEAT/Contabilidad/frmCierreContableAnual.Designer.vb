<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCierreContableAnual
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
        Me.sp_CierreContable = New System.Windows.Forms.SplitContainer()
        Me.tb_nombreEjercicioActual = New System.Windows.Forms.TextBox()
        Me.tb_nombreEjercicioAnterior = New System.Windows.Forms.TextBox()
        Me.tb_cuentaEjercicioActual = New System.Windows.Forms.TextBox()
        Me.tb_cuentaEjercicioAterior = New System.Windows.Forms.TextBox()
        Me.tb_anioContable = New System.Windows.Forms.TextBox()
        Me.lbl_resultadoAnterior = New System.Windows.Forms.Label()
        Me.lbl_ejercicioAnterior = New System.Windows.Forms.Label()
        Me.lbl_anio = New System.Windows.Forms.Label()
        Me.lbl_info5 = New System.Windows.Forms.Label()
        Me.lbl_info4 = New System.Windows.Forms.Label()
        Me.lbl_info3 = New System.Windows.Forms.Label()
        Me.lbl_info2 = New System.Windows.Forms.Label()
        Me.lbl_info1 = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.btn_IniciarCierre = New System.Windows.Forms.Button()
        Me.pb_cierreAnual = New System.Windows.Forms.ProgressBar()
        Me.lbl_porcentaje = New System.Windows.Forms.Label()
        Me.timer_progressbar = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Informacion = New System.Windows.Forms.Label()
        Me.sp_CierreContable.Panel1.SuspendLayout()
        Me.sp_CierreContable.Panel2.SuspendLayout()
        Me.sp_CierreContable.SuspendLayout()
        Me.SuspendLayout()
        '
        'sp_CierreContable
        '
        Me.sp_CierreContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sp_CierreContable.Location = New System.Drawing.Point(12, 12)
        Me.sp_CierreContable.Name = "sp_CierreContable"
        Me.sp_CierreContable.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'sp_CierreContable.Panel1
        '
        Me.sp_CierreContable.Panel1.Controls.Add(Me.lbl_Informacion)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.tb_nombreEjercicioActual)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.tb_nombreEjercicioAnterior)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.tb_cuentaEjercicioActual)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.tb_cuentaEjercicioAterior)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.tb_anioContable)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.lbl_resultadoAnterior)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.lbl_ejercicioAnterior)
        Me.sp_CierreContable.Panel1.Controls.Add(Me.lbl_anio)
        '
        'sp_CierreContable.Panel2
        '
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_info5)
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_info4)
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_info3)
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_info2)
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_info1)
        Me.sp_CierreContable.Panel2.Controls.Add(Me.lbl_descripcion)
        Me.sp_CierreContable.Size = New System.Drawing.Size(413, 332)
        Me.sp_CierreContable.SplitterDistance = 163
        Me.sp_CierreContable.SplitterWidth = 10
        Me.sp_CierreContable.TabIndex = 1
        '
        'tb_nombreEjercicioActual
        '
        Me.tb_nombreEjercicioActual.BackColor = System.Drawing.SystemColors.Window
        Me.tb_nombreEjercicioActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_nombreEjercicioActual.Location = New System.Drawing.Point(144, 121)
        Me.tb_nombreEjercicioActual.Name = "tb_nombreEjercicioActual"
        Me.tb_nombreEjercicioActual.ReadOnly = True
        Me.tb_nombreEjercicioActual.Size = New System.Drawing.Size(248, 20)
        Me.tb_nombreEjercicioActual.TabIndex = 7
        '
        'tb_nombreEjercicioAnterior
        '
        Me.tb_nombreEjercicioAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.tb_nombreEjercicioAnterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_nombreEjercicioAnterior.Location = New System.Drawing.Point(144, 69)
        Me.tb_nombreEjercicioAnterior.Name = "tb_nombreEjercicioAnterior"
        Me.tb_nombreEjercicioAnterior.ReadOnly = True
        Me.tb_nombreEjercicioAnterior.Size = New System.Drawing.Size(248, 20)
        Me.tb_nombreEjercicioAnterior.TabIndex = 6
        '
        'tb_cuentaEjercicioActual
        '
        Me.tb_cuentaEjercicioActual.BackColor = System.Drawing.SystemColors.Window
        Me.tb_cuentaEjercicioActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_cuentaEjercicioActual.Location = New System.Drawing.Point(17, 121)
        Me.tb_cuentaEjercicioActual.Name = "tb_cuentaEjercicioActual"
        Me.tb_cuentaEjercicioActual.ReadOnly = True
        Me.tb_cuentaEjercicioActual.Size = New System.Drawing.Size(129, 20)
        Me.tb_cuentaEjercicioActual.TabIndex = 5
        '
        'tb_cuentaEjercicioAterior
        '
        Me.tb_cuentaEjercicioAterior.BackColor = System.Drawing.SystemColors.Window
        Me.tb_cuentaEjercicioAterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_cuentaEjercicioAterior.Location = New System.Drawing.Point(17, 69)
        Me.tb_cuentaEjercicioAterior.Name = "tb_cuentaEjercicioAterior"
        Me.tb_cuentaEjercicioAterior.ReadOnly = True
        Me.tb_cuentaEjercicioAterior.Size = New System.Drawing.Size(129, 20)
        Me.tb_cuentaEjercicioAterior.TabIndex = 4
        '
        'tb_anioContable
        '
        Me.tb_anioContable.BackColor = System.Drawing.SystemColors.Window
        Me.tb_anioContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_anioContable.Location = New System.Drawing.Point(112, 13)
        Me.tb_anioContable.Name = "tb_anioContable"
        Me.tb_anioContable.ReadOnly = True
        Me.tb_anioContable.Size = New System.Drawing.Size(60, 20)
        Me.tb_anioContable.TabIndex = 3
        '
        'lbl_resultadoAnterior
        '
        Me.lbl_resultadoAnterior.AutoSize = True
        Me.lbl_resultadoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultadoAnterior.Location = New System.Drawing.Point(14, 101)
        Me.lbl_resultadoAnterior.Name = "lbl_resultadoAnterior"
        Me.lbl_resultadoAnterior.Size = New System.Drawing.Size(187, 16)
        Me.lbl_resultadoAnterior.TabIndex = 2
        Me.lbl_resultadoAnterior.Text = "Resultado de Ejercicio Actual:"
        '
        'lbl_ejercicioAnterior
        '
        Me.lbl_ejercicioAnterior.AutoSize = True
        Me.lbl_ejercicioAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ejercicioAnterior.Location = New System.Drawing.Point(14, 50)
        Me.lbl_ejercicioAnterior.Name = "lbl_ejercicioAnterior"
        Me.lbl_ejercicioAnterior.Size = New System.Drawing.Size(192, 16)
        Me.lbl_ejercicioAnterior.TabIndex = 1
        Me.lbl_ejercicioAnterior.Text = "Resultado de Ejercicio Anterio:"
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoSize = True
        Me.lbl_anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_anio.Location = New System.Drawing.Point(14, 17)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Size = New System.Drawing.Size(92, 16)
        Me.lbl_anio.TabIndex = 0
        Me.lbl_anio.Text = "Año Contable:"
        '
        'lbl_info5
        '
        Me.lbl_info5.AutoSize = True
        Me.lbl_info5.Location = New System.Drawing.Point(48, 134)
        Me.lbl_info5.Name = "lbl_info5"
        Me.lbl_info5.Size = New System.Drawing.Size(254, 13)
        Me.lbl_info5.TabIndex = 5
        Me.lbl_info5.Text = "-  Generar Póliza de Traspaso a Ejercicios Anteriores"
        '
        'lbl_info4
        '
        Me.lbl_info4.AutoSize = True
        Me.lbl_info4.Location = New System.Drawing.Point(48, 109)
        Me.lbl_info4.Name = "lbl_info4"
        Me.lbl_info4.Size = New System.Drawing.Size(254, 13)
        Me.lbl_info4.TabIndex = 4
        Me.lbl_info4.Text = "-  Generar Póliza de Traspaso a Ejercicios Anteriores"
        '
        'lbl_info3
        '
        Me.lbl_info3.AutoSize = True
        Me.lbl_info3.Location = New System.Drawing.Point(48, 86)
        Me.lbl_info3.Name = "lbl_info3"
        Me.lbl_info3.Size = New System.Drawing.Size(220, 13)
        Me.lbl_info3.TabIndex = 3
        Me.lbl_info3.Text = "-  Generar Póliza de Cierre Anual del Ejercicio"
        '
        'lbl_info2
        '
        Me.lbl_info2.AutoSize = True
        Me.lbl_info2.Location = New System.Drawing.Point(48, 63)
        Me.lbl_info2.Name = "lbl_info2"
        Me.lbl_info2.Size = New System.Drawing.Size(203, 13)
        Me.lbl_info2.TabIndex = 2
        Me.lbl_info2.Text = "-  Calcular Saldos de Cuentas de Balance"
        '
        'lbl_info1
        '
        Me.lbl_info1.AutoSize = True
        Me.lbl_info1.Location = New System.Drawing.Point(48, 40)
        Me.lbl_info1.Name = "lbl_info1"
        Me.lbl_info1.Size = New System.Drawing.Size(203, 13)
        Me.lbl_info1.TabIndex = 1
        Me.lbl_info1.Text = "-  Calcular Saldos de Cuentas de Balance"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(48, 13)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(309, 16)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Al Ejecutar este Proceso se Efectuará lo Siguiente:"
        '
        'btn_IniciarCierre
        '
        Me.btn_IniciarCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_IniciarCierre.Location = New System.Drawing.Point(311, 360)
        Me.btn_IniciarCierre.Name = "btn_IniciarCierre"
        Me.btn_IniciarCierre.Size = New System.Drawing.Size(114, 29)
        Me.btn_IniciarCierre.TabIndex = 2
        Me.btn_IniciarCierre.Text = "Cerrar Ejercicio"
        Me.btn_IniciarCierre.UseVisualStyleBackColor = True
        '
        'pb_cierreAnual
        '
        Me.pb_cierreAnual.Location = New System.Drawing.Point(30, 368)
        Me.pb_cierreAnual.Name = "pb_cierreAnual"
        Me.pb_cierreAnual.Size = New System.Drawing.Size(275, 10)
        Me.pb_cierreAnual.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb_cierreAnual.TabIndex = 3
        Me.pb_cierreAnual.Visible = False
        '
        'lbl_porcentaje
        '
        Me.lbl_porcentaje.AutoSize = True
        Me.lbl_porcentaje.Location = New System.Drawing.Point(164, 347)
        Me.lbl_porcentaje.Name = "lbl_porcentaje"
        Me.lbl_porcentaje.Size = New System.Drawing.Size(21, 13)
        Me.lbl_porcentaje.TabIndex = 4
        Me.lbl_porcentaje.Text = "0%"
        Me.lbl_porcentaje.Visible = False
        '
        'timer_progressbar
        '
        '
        'lbl_Informacion
        '
        Me.lbl_Informacion.AutoSize = True
        Me.lbl_Informacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Informacion.Location = New System.Drawing.Point(20, 144)
        Me.lbl_Informacion.Name = "lbl_Informacion"
        Me.lbl_Informacion.Size = New System.Drawing.Size(327, 12)
        Me.lbl_Informacion.TabIndex = 8
        Me.lbl_Informacion.Text = "<Seleccione caja de texto y presione F3 pra buscar una Cuenta>"
        '
        'frmCierreContableAnual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 401)
        Me.Controls.Add(Me.lbl_porcentaje)
        Me.Controls.Add(Me.pb_cierreAnual)
        Me.Controls.Add(Me.btn_IniciarCierre)
        Me.Controls.Add(Me.sp_CierreContable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCierreContableAnual"
        Me.Text = "Cierren Contable Anual"
        Me.sp_CierreContable.Panel1.ResumeLayout(False)
        Me.sp_CierreContable.Panel1.PerformLayout()
        Me.sp_CierreContable.Panel2.ResumeLayout(False)
        Me.sp_CierreContable.Panel2.PerformLayout()
        Me.sp_CierreContable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sp_CierreContable As System.Windows.Forms.SplitContainer
    Friend WithEvents tb_nombreEjercicioActual As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombreEjercicioAnterior As System.Windows.Forms.TextBox
    Friend WithEvents tb_cuentaEjercicioActual As System.Windows.Forms.TextBox
    Friend WithEvents tb_cuentaEjercicioAterior As System.Windows.Forms.TextBox
    Friend WithEvents tb_anioContable As System.Windows.Forms.TextBox
    Friend WithEvents lbl_resultadoAnterior As System.Windows.Forms.Label
    Friend WithEvents lbl_ejercicioAnterior As System.Windows.Forms.Label
    Friend WithEvents lbl_anio As System.Windows.Forms.Label
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents btn_IniciarCierre As System.Windows.Forms.Button
    Friend WithEvents pb_cierreAnual As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_porcentaje As System.Windows.Forms.Label
    Friend WithEvents timer_progressbar As System.Windows.Forms.Timer
    Friend WithEvents lbl_info5 As System.Windows.Forms.Label
    Friend WithEvents lbl_info4 As System.Windows.Forms.Label
    Friend WithEvents lbl_info3 As System.Windows.Forms.Label
    Friend WithEvents lbl_info2 As System.Windows.Forms.Label
    Friend WithEvents lbl_info1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Informacion As System.Windows.Forms.Label
End Class
