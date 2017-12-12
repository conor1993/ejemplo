Imports OTL = Integralab.ORMSeguridad.TypedListClasses

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesMenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetallesMenuForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbpUsuarios = New System.Windows.Forms.TabPage
        Me.btnMenusUsuario = New System.Windows.Forms.Button
        Me.lstUsuarios = New System.Windows.Forms.ListBox
        Me.Usuarios = New OTL.UsuariosTypedList
        Me.tbpGrupos = New System.Windows.Forms.TabPage
        Me.btnMenusGrupo = New System.Windows.Forms.Button
        Me.lstGrupos = New System.Windows.Forms.ListBox
        Me.Grupos = New OTL.GruposTypedList
        Me.Lista = New System.Windows.Forms.ImageList(Me.components)
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.TabControl1.SuspendLayout()
        Me.tbpUsuarios.SuspendLayout()
        CType(Me.Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpGrupos.SuspendLayout()
        CType(Me.Grupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpUsuarios)
        Me.TabControl1.Controls.Add(Me.tbpGrupos)
        Me.TabControl1.ImageList = Me.Lista
        Me.TabControl1.Location = New System.Drawing.Point(55, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(459, 372)
        Me.TabControl1.TabIndex = 0
        '
        'tbpUsuarios
        '
        Me.tbpUsuarios.Controls.Add(Me.btnMenusUsuario)
        Me.tbpUsuarios.Controls.Add(Me.lstUsuarios)
        Me.tbpUsuarios.ImageIndex = 0
        Me.tbpUsuarios.Location = New System.Drawing.Point(4, 23)
        Me.tbpUsuarios.Name = "tbpUsuarios"
        Me.tbpUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUsuarios.Size = New System.Drawing.Size(451, 345)
        Me.tbpUsuarios.TabIndex = 0
        Me.tbpUsuarios.Text = "Usuarios"
        Me.tbpUsuarios.UseVisualStyleBackColor = True
        '
        'btnMenusUsuario
        '
        Me.btnMenusUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenusUsuario.Image = My.Resources.application_preferences
        Me.btnMenusUsuario.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMenusUsuario.Location = New System.Drawing.Point(372, 263)
        Me.btnMenusUsuario.Name = "btnMenusUsuario"
        Me.btnMenusUsuario.Size = New System.Drawing.Size(73, 70)
        Me.btnMenusUsuario.TabIndex = 4
        Me.btnMenusUsuario.Text = "Menus..."
        Me.btnMenusUsuario.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMenusUsuario.UseVisualStyleBackColor = True
        '
        'lstUsuarios
        '
        Me.lstUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstUsuarios.DataSource = Me.Usuarios
        Me.lstUsuarios.DisplayMember = "Usrnomcom"
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.Location = New System.Drawing.Point(6, 7)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(439, 251)
        Me.lstUsuarios.TabIndex = 1
        Me.lstUsuarios.ValueMember = "Usrndx"
        '
        'Usuarios
        '
        Me.Usuarios.ObeyWeakRelations = False
        Me.Usuarios.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.Usuarios.TableName = "Usuarios"
        '
        'tbpGrupos
        '
        Me.tbpGrupos.Controls.Add(Me.btnMenusGrupo)
        Me.tbpGrupos.Controls.Add(Me.lstGrupos)
        Me.tbpGrupos.ImageIndex = 1
        Me.tbpGrupos.Location = New System.Drawing.Point(4, 23)
        Me.tbpGrupos.Name = "tbpGrupos"
        Me.tbpGrupos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGrupos.Size = New System.Drawing.Size(451, 345)
        Me.tbpGrupos.TabIndex = 1
        Me.tbpGrupos.Text = "Grupos"
        Me.tbpGrupos.UseVisualStyleBackColor = True
        '
        'btnMenusGrupo
        '
        Me.btnMenusGrupo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenusGrupo.Image = My.Resources.application_preferences
        Me.btnMenusGrupo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnMenusGrupo.Location = New System.Drawing.Point(372, 265)
        Me.btnMenusGrupo.Name = "btnMenusGrupo"
        Me.btnMenusGrupo.Size = New System.Drawing.Size(73, 70)
        Me.btnMenusGrupo.TabIndex = 3
        Me.btnMenusGrupo.Text = "Menus..."
        Me.btnMenusGrupo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMenusGrupo.UseVisualStyleBackColor = True
        '
        'lstGrupos
        '
        Me.lstGrupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstGrupos.DataSource = Me.Grupos
        Me.lstGrupos.DisplayMember = "Gponom"
        Me.lstGrupos.FormattingEnabled = True
        Me.lstGrupos.Location = New System.Drawing.Point(6, 6)
        Me.lstGrupos.Name = "lstGrupos"
        Me.lstGrupos.Size = New System.Drawing.Size(439, 251)
        Me.lstGrupos.TabIndex = 0
        Me.lstGrupos.ValueMember = "Gpondx"
        '
        'Grupos
        '
        Me.Grupos.ObeyWeakRelations = False
        Me.Grupos.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.Grupos.TableName = "Grupos"
        '
        'Lista
        '
        Me.Lista.ImageStream = CType(resources.GetObject("Lista.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Lista.TransparentColor = System.Drawing.Color.Transparent
        Me.Lista.Images.SetKeyName(0, "user1.png")
        Me.Lista.Images.SetKeyName(1, "users4.png")
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = False
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 396)
        Me.MEAToolBar1.TabIndex = 1
        '
        'DetallesMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 396)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(534, 430)
        Me.Name = "DetallesMenuForm"
        Me.Text = "Acceso a Menus"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpUsuarios.ResumeLayout(False)
        CType(Me.Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpGrupos.ResumeLayout(False)
        CType(Me.Grupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpUsuarios As System.Windows.Forms.TabPage
    Friend WithEvents tbpGrupos As System.Windows.Forms.TabPage
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents lstGrupos As System.Windows.Forms.ListBox
    Friend WithEvents Usuarios As OTL.UsuariosTypedList
    Friend WithEvents Grupos As OTL.GruposTypedList
    Friend WithEvents btnMenusGrupo As System.Windows.Forms.Button
    Friend WithEvents btnMenusUsuario As System.Windows.Forms.Button
    Friend WithEvents Lista As System.Windows.Forms.ImageList
End Class
