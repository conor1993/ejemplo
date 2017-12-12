namespace ClasesContabilidad
{
    partial class frmAsignaCuentasSAT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvCtasContables = new IntegraLab.Controles.DataGridViewMejorado();
            this.clmCuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescAgrupador = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmCodCtaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.mtb = new MEAToolBar.MEAToolBar();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasContables)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.lblMensaje);
            this.GroupBox1.Controls.Add(this.dgvCtasContables);
            this.GroupBox1.Location = new System.Drawing.Point(53, 33);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(869, 533);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(633, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presione <Supr> para limpiar agrupador";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 518);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(346, 13);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Presione <Enter> para habilitar el renglón para modificación";
            // 
            // dgvCtasContables
            // 
            this.dgvCtasContables.AllowUserToAddRows = false;
            this.dgvCtasContables.AllowUserToDeleteRows = false;
            this.dgvCtasContables.AllowUserToOrderColumns = true;
            this.dgvCtasContables.AllowUserToResizeRows = false;
            this.dgvCtasContables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCtasContables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtasContables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCtasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtasContables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCuentaContable,
            this.ClmNombre,
            this.clmDescAgrupador,
            this.clmCodCtaContable});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCtasContables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCtasContables.Location = new System.Drawing.Point(6, 19);
            this.dgvCtasContables.MultiSelect = false;
            this.dgvCtasContables.Name = "dgvCtasContables";
            this.dgvCtasContables.ReemplazarKey = System.Windows.Forms.Keys.Return;
            this.dgvCtasContables.ReemplazarKeyPor = System.Windows.Forms.Keys.Tab;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCtasContables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCtasContables.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCtasContables.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCtasContables.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCtasContables.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvCtasContables.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCtasContables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCtasContables.Size = new System.Drawing.Size(857, 495);
            this.dgvCtasContables.TabIndex = 0;
            this.dgvCtasContables.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtasContables_CellEndEdit);
            this.dgvCtasContables.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCtasContables_EditingControlShowing);
            this.dgvCtasContables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCtasContables_KeyDown);
            this.dgvCtasContables.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCtasContables_KeyPress);
            // 
            // clmCuentaContable
            // 
            this.clmCuentaContable.DataPropertyName = "NumCuenta";
            this.clmCuentaContable.FillWeight = 15F;
            this.clmCuentaContable.HeaderText = "Cuenta Contable";
            this.clmCuentaContable.Name = "clmCuentaContable";
            this.clmCuentaContable.ReadOnly = true;
            // 
            // ClmNombre
            // 
            this.ClmNombre.DataPropertyName = "NombreCuenta";
            this.ClmNombre.FillWeight = 35F;
            this.ClmNombre.HeaderText = "Descripcion";
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            // 
            // clmDescAgrupador
            // 
            this.clmDescAgrupador.DataPropertyName = "CodAgrupSAT";
            this.clmDescAgrupador.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.clmDescAgrupador.FillWeight = 50F;
            this.clmDescAgrupador.HeaderText = "Agrupador SAT";
            this.clmDescAgrupador.Name = "clmDescAgrupador";
            this.clmDescAgrupador.ReadOnly = true;
            // 
            // clmCodCtaContable
            // 
            this.clmCodCtaContable.DataPropertyName = "Codigo";
            this.clmCodCtaContable.FillWeight = 10F;
            this.clmCodCtaContable.HeaderText = "Codigo";
            this.clmCodCtaContable.Name = "clmCodCtaContable";
            this.clmCodCtaContable.Visible = false;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblTitulo);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.mtb);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(934, 578);
            this.Panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(934, 30);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Cuentas Contables y Agrupadores del SAT";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtb
            // 
            this.mtb.ButtonSize = new System.Drawing.Size(50, 50);
            this.mtb.Dock = System.Windows.Forms.DockStyle.None;
            this.mtb.DropDownArrows = true;
            this.mtb.HabilitarBorrar = true;
            this.mtb.HabilitarBuscar = true;
            this.mtb.HabilitarCancelar = true;
            this.mtb.HabilitarEditar = true;
            this.mtb.HabilitarGuardar = true;
            this.mtb.HabilitarImprimir = true;
            this.mtb.HabilitarLimpiar = true;
            this.mtb.HabilitarNuevo = true;
            this.mtb.HabilitarSalir = true;
            this.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32;
            this.mtb.Location = new System.Drawing.Point(3, 85);
            this.mtb.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.mtb.MostrarBorrar = false;
            this.mtb.MostrarBuscar = false;
            this.mtb.MostrarCancelar = false;
            this.mtb.MostrarEditar = false;
            this.mtb.MostrarGuardar = true;
            this.mtb.MostrarImprimir = false;
            this.mtb.MostrarLimpiar = false;
            this.mtb.MostrarNuevo = false;
            this.mtb.MostrarSalir = true;
            this.mtb.Name = "mtb";
            this.mtb.ShowToolTips = true;
            this.mtb.Size = new System.Drawing.Size(50, 266);
            this.mtb.TabIndex = 6;
            // 
            // frmAsignaCuentasSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 578);
            this.Controls.Add(this.Panel1);
            this.KeyPreview = true;
            this.Name = "frmAsignaCuentasSAT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignación de la Cuenta del SAT al Catálogo de Cuentas";
            this.Load += new System.EventHandler(this.frmAsignaCuentasSAT_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAsignaCuentasSAT_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasContables)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal IntegraLab.Controles.DataGridViewMejorado dgvCtasContables;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lblMensaje;
        internal System.Windows.Forms.Label lblTitulo;
        internal MEAToolBar.MEAToolBar mtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuentaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDescAgrupador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodCtaContable;
        private System.Windows.Forms.Label label1;

    }
}

