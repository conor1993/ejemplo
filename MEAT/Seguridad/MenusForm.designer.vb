<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenusForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenusForm))
        Me.Tabla = New System.Windows.Forms.TableLayoutPanel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SolucionTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.IdentificadorTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.ObligatorioCheckBox = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.PadreTextBox = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.ObtenerMenusButton = New System.Windows.Forms.Button
        Me.MiMenu = New ILTreeViewMenu.TreeViewMenu
        Me.Tabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.ColumnCount = 2
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.23049!))
        Me.Tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.76951!))
        Me.Tabla.Controls.Add(Me.Label1, 0, 0)
        Me.Tabla.Controls.Add(Me.SolucionTextBox, 1, 0)
        Me.Tabla.Controls.Add(Me.Label2, 0, 1)
        Me.Tabla.Controls.Add(Me.IdentificadorTextBox, 1, 1)
        Me.Tabla.Controls.Add(Me.Label3, 0, 2)
        Me.Tabla.Controls.Add(Me.NombreTextBox, 1, 2)
        Me.Tabla.Controls.Add(Me.ObligatorioCheckBox, 0, 4)
        Me.Tabla.Controls.Add(Me.Label4, 0, 3)
        Me.Tabla.Controls.Add(Me.PadreTextBox, 1, 3)
        Me.Tabla.Location = New System.Drawing.Point(55, 12)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.RowCount = 5
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Tabla.Size = New System.Drawing.Size(551, 136)
        Me.Tabla.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solución:"
        '
        'SolucionTextBox
        '
        Me.SolucionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SolucionTextBox.Location = New System.Drawing.Point(130, 3)
        Me.SolucionTextBox.Name = "SolucionTextBox"
        Me.SolucionTextBox.ReadOnly = True
        Me.SolucionTextBox.Size = New System.Drawing.Size(418, 20)
        Me.SolucionTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identificador:"
        '
        'IdentificadorTextBox
        '
        Me.IdentificadorTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdentificadorTextBox.Location = New System.Drawing.Point(130, 30)
        Me.IdentificadorTextBox.Name = "IdentificadorTextBox"
        Me.IdentificadorTextBox.ReadOnly = True
        Me.IdentificadorTextBox.Size = New System.Drawing.Size(418, 20)
        Me.IdentificadorTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.Location = New System.Drawing.Point(130, 57)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(418, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'ObligatorioCheckBox
        '
        Me.ObligatorioCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObligatorioCheckBox.AutoSize = True
        Me.ObligatorioCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ObligatorioCheckBox.Location = New System.Drawing.Point(3, 111)
        Me.ObligatorioCheckBox.Name = "ObligatorioCheckBox"
        Me.ObligatorioCheckBox.Size = New System.Drawing.Size(121, 17)
        Me.ObligatorioCheckBox.TabIndex = 2
        Me.ObligatorioCheckBox.Text = "¿Es Obligatorio?"
        Me.ObligatorioCheckBox.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Padre:"
        '
        'PadreTextBox
        '
        Me.PadreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PadreTextBox.Location = New System.Drawing.Point(130, 84)
        Me.PadreTextBox.Name = "PadreTextBox"
        Me.PadreTextBox.ReadOnly = True
        Me.PadreTextBox.Size = New System.Drawing.Size(418, 20)
        Me.PadreTextBox.TabIndex = 1
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = True
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 563)
        Me.mtb.TabIndex = 0
        Me.mtb.Visible = False
        '
        'ObtenerMenusButton
        '
        Me.ObtenerMenusButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ObtenerMenusButton.Image = Global.MEAT.My.Resources.Resources.application_view
        Me.ObtenerMenusButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ObtenerMenusButton.Location = New System.Drawing.Point(531, 471)
        Me.ObtenerMenusButton.Name = "ObtenerMenusButton"
        Me.ObtenerMenusButton.Size = New System.Drawing.Size(77, 80)
        Me.ObtenerMenusButton.TabIndex = 3
        Me.ObtenerMenusButton.Text = "Obtener Menus"
        Me.ObtenerMenusButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ObtenerMenusButton.UseVisualStyleBackColor = True
        '
        'MiMenu
        '
        Me.MiMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiMenu.ImageIndex = 0
        Me.MiMenu.Location = New System.Drawing.Point(55, 154)
        Me.MiMenu.MenuSeleccionado = Nothing
        Me.MiMenu.Name = "MiMenu"
        Me.MiMenu.SelectedImageIndex = 0
        Me.MiMenu.Size = New System.Drawing.Size(553, 311)
        Me.MiMenu.TabIndex = 4
        '
        'MenusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 563)
        Me.Controls.Add(Me.MiMenu)
        Me.Controls.Add(Me.ObtenerMenusButton)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(626, 460)
        Me.Name = "MenusForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Menus"
        Me.Tabla.ResumeLayout(False)
        Me.Tabla.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SolucionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdentificadorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObligatorioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PadreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObtenerMenusButton As System.Windows.Forms.Button
    Friend WithEvents MiMenu As ILTreeViewMenu.TreeViewMenu
End Class
