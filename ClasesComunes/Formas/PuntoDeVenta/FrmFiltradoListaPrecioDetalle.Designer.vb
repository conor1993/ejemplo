<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFiltradoListaPrecioDetalle
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbLinea = New System.Windows.Forms.ComboBox
        Me.LineaC = New ClasesNegocio.LineaCollectionClass
        Me.CmbSubLinea = New System.Windows.Forms.ComboBox
        Me.SubLineaC = New ClasesNegocio.SubLineaCollectionClass
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbMarca = New System.Windows.Forms.ComboBox
        Me.MarcaC = New ClasesNegocio.MarcaCollectionClass
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Línea:"
        '
        'CmbLinea
        '
        Me.CmbLinea.DataSource = Me.LineaC
        Me.CmbLinea.DisplayMember = "Descripcion"
        Me.CmbLinea.FormattingEnabled = True
        Me.CmbLinea.Location = New System.Drawing.Point(73, 45)
        Me.CmbLinea.Name = "CmbLinea"
        Me.CmbLinea.Size = New System.Drawing.Size(301, 21)
        Me.CmbLinea.TabIndex = 1
        Me.CmbLinea.ValueMember = "Codigo"
        '
        'LineaC
        '
        Me.LineaC.AllowEdit = True
        Me.LineaC.AllowNew = True
        Me.LineaC.AllowRemove = True
        Me.LineaC.Name = ""
        Me.LineaC.RaiseListChangedEvents = True
        '
        'CmbSubLinea
        '
        Me.CmbSubLinea.DataSource = Me.SubLineaC
        Me.CmbSubLinea.DisplayMember = "Descripcion"
        Me.CmbSubLinea.FormattingEnabled = True
        Me.CmbSubLinea.Location = New System.Drawing.Point(73, 72)
        Me.CmbSubLinea.Name = "CmbSubLinea"
        Me.CmbSubLinea.Size = New System.Drawing.Size(301, 21)
        Me.CmbSubLinea.TabIndex = 3
        Me.CmbSubLinea.ValueMember = "Codigo"
        '
        'SubLineaC
        '
        Me.SubLineaC.AllowEdit = True
        Me.SubLineaC.AllowNew = True
        Me.SubLineaC.AllowRemove = True
        Me.SubLineaC.Name = ""
        Me.SubLineaC.RaiseListChangedEvents = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sub-Línea:"
        '
        'CmbMarca
        '
        Me.CmbMarca.DataSource = Me.MarcaC
        Me.CmbMarca.DisplayMember = "Nombre"
        Me.CmbMarca.FormattingEnabled = True
        Me.CmbMarca.Location = New System.Drawing.Point(73, 99)
        Me.CmbMarca.Name = "CmbMarca"
        Me.CmbMarca.Size = New System.Drawing.Size(301, 21)
        Me.CmbMarca.TabIndex = 5
        Me.CmbMarca.ValueMember = "Codigo"
        '
        'MarcaC
        '
        Me.MarcaC.AllowEdit = True
        Me.MarcaC.AllowNew = True
        Me.MarcaC.AllowRemove = True
        Me.MarcaC.Name = ""
        Me.MarcaC.RaiseListChangedEvents = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(386, 29)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "FILTRAR LISTA DE PRODUCTOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 27)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmFiltradoListaPrecioDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 168)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbMarca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbSubLinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbLinea)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(394, 202)
        Me.MinimumSize = New System.Drawing.Size(394, 202)
        Me.Name = "FrmFiltradoListaPrecioDetalle"
        Me.Text = "Filtrar Lista de Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSubLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LineaC As ClasesNegocio.LineaCollectionClass
    Friend WithEvents MarcaC As ClasesNegocio.MarcaCollectionClass
    Friend WithEvents SubLineaC As ClasesNegocio.SubLineaCollectionClass
End Class
