namespace ClasesContabilidad
{
    partial class frmGeneraPolizasSAT
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbNumOrden = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedNumTramite = new System.Windows.Forms.MaskedTextBox();
            this.grbTipoEnvio = new System.Windows.Forms.GroupBox();
            this.rbtCompensacion = new System.Windows.Forms.RadioButton();
            this.rbtDevolucion = new System.Windows.Forms.RadioButton();
            this.rbtFiscCompulsa = new System.Windows.Forms.RadioButton();
            this.rbtActoFisc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.fbdBuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbrProgreso = new System.Windows.Forms.ProgressBar();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.grbTipoEnvio.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lblEstatus);
            this.GroupBox1.Controls.Add(this.pbrProgreso);
            this.GroupBox1.Controls.Add(this.groupBox2);
            this.GroupBox1.Controls.Add(this.grbTipoEnvio);
            this.GroupBox1.Controls.Add(this.btnGenerar);
            this.GroupBox1.Controls.Add(this.txtCarpeta);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 193);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // mtbNumOrden
            // 
            this.mtbNumOrden.AllowPromptAsInput = false;
            this.mtbNumOrden.HidePromptOnLeave = true;
            this.mtbNumOrden.Location = new System.Drawing.Point(116, 73);
            this.mtbNumOrden.Mask = ">LLL0000000/00";
            this.mtbNumOrden.Name = "mtbNumOrden";
            this.mtbNumOrden.PromptChar = ' ';
            this.mtbNumOrden.Size = new System.Drawing.Size(112, 20);
            this.mtbNumOrden.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número de trámite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de orden:";
            // 
            // maskedNumTramite
            // 
            this.maskedNumTramite.AllowPromptAsInput = false;
            this.maskedNumTramite.HidePromptOnLeave = true;
            this.maskedNumTramite.Location = new System.Drawing.Point(116, 73);
            this.maskedNumTramite.Mask = "9999999999";
            this.maskedNumTramite.Name = "maskedNumTramite";
            this.maskedNumTramite.PromptChar = ' ';
            this.maskedNumTramite.Size = new System.Drawing.Size(68, 20);
            this.maskedNumTramite.TabIndex = 7;
            // 
            // grbTipoEnvio
            // 
            this.grbTipoEnvio.Controls.Add(this.rbtCompensacion);
            this.grbTipoEnvio.Controls.Add(this.rbtDevolucion);
            this.grbTipoEnvio.Controls.Add(this.rbtFiscCompulsa);
            this.grbTipoEnvio.Controls.Add(this.rbtActoFisc);
            this.grbTipoEnvio.Location = new System.Drawing.Point(268, 16);
            this.grbTipoEnvio.Name = "grbTipoEnvio";
            this.grbTipoEnvio.Size = new System.Drawing.Size(165, 111);
            this.grbTipoEnvio.TabIndex = 8;
            this.grbTipoEnvio.TabStop = false;
            this.grbTipoEnvio.Text = "Tipo de solicitud";
            // 
            // rbtCompensacion
            // 
            this.rbtCompensacion.AutoSize = true;
            this.rbtCompensacion.Location = new System.Drawing.Point(6, 88);
            this.rbtCompensacion.Name = "rbtCompensacion";
            this.rbtCompensacion.Size = new System.Drawing.Size(95, 17);
            this.rbtCompensacion.TabIndex = 3;
            this.rbtCompensacion.Text = "Compensación";
            this.rbtCompensacion.UseVisualStyleBackColor = true;
            this.rbtCompensacion.CheckedChanged += new System.EventHandler(this.rbtCompensacion_CheckedChanged);
            // 
            // rbtDevolucion
            // 
            this.rbtDevolucion.AutoSize = true;
            this.rbtDevolucion.Location = new System.Drawing.Point(6, 65);
            this.rbtDevolucion.Name = "rbtDevolucion";
            this.rbtDevolucion.Size = new System.Drawing.Size(79, 17);
            this.rbtDevolucion.TabIndex = 2;
            this.rbtDevolucion.Text = "Devolución";
            this.rbtDevolucion.UseVisualStyleBackColor = true;
            this.rbtDevolucion.CheckedChanged += new System.EventHandler(this.rbtDevolucion_CheckedChanged);
            // 
            // rbtFiscCompulsa
            // 
            this.rbtFiscCompulsa.AutoSize = true;
            this.rbtFiscCompulsa.Location = new System.Drawing.Point(6, 42);
            this.rbtFiscCompulsa.Name = "rbtFiscCompulsa";
            this.rbtFiscCompulsa.Size = new System.Drawing.Size(133, 17);
            this.rbtFiscCompulsa.TabIndex = 1;
            this.rbtFiscCompulsa.Text = "Fiscalización compulsa";
            this.rbtFiscCompulsa.UseVisualStyleBackColor = true;
            this.rbtFiscCompulsa.CheckedChanged += new System.EventHandler(this.rbtFC_CheckedChanged);
            // 
            // rbtActoFisc
            // 
            this.rbtActoFisc.AutoSize = true;
            this.rbtActoFisc.Checked = true;
            this.rbtActoFisc.Location = new System.Drawing.Point(6, 19);
            this.rbtActoFisc.Name = "rbtActoFisc";
            this.rbtActoFisc.Size = new System.Drawing.Size(122, 17);
            this.rbtActoFisc.TabIndex = 0;
            this.rbtActoFisc.TabStop = true;
            this.rbtActoFisc.Text = "Acto de fiscalización";
            this.rbtActoFisc.UseVisualStyleBackColor = true;
            this.rbtActoFisc.CheckedChanged += new System.EventHandler(this.rbtAF_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ejercicio:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(116, 46);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(68, 21);
            this.cmbPeriodo.TabIndex = 3;
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(116, 19);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(68, 21);
            this.cmbEjercicio.TabIndex = 1;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(362, 159);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(72, 26);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(125, 133);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.ReadOnly = true;
            this.txtCarpeta.Size = new System.Drawing.Size(309, 20);
            this.txtCarpeta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Guardar en la carpeta:";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(464, 217);
            this.Panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedNumTramite);
            this.groupBox2.Controls.Add(this.cmbEjercicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mtbNumOrden);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 110);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // pbrProgreso
            // 
            this.pbrProgreso.Location = new System.Drawing.Point(6, 162);
            this.pbrProgreso.Name = "pbrProgreso";
            this.pbrProgreso.Size = new System.Drawing.Size(343, 22);
            this.pbrProgreso.TabIndex = 15;
            this.pbrProgreso.Visible = false;
            // 
            // lblEstatus
            // 
            this.lblEstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblEstatus.Location = new System.Drawing.Point(3, 161);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(346, 23);
            this.lblEstatus.TabIndex = 16;
            this.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGeneraPolizasSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 217);
            this.Controls.Add(this.Panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 166);
            this.Name = "frmGeneraPolizasSAT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Pólizas del Período en XML para el SAT";
            this.Load += new System.EventHandler(this.frmAsignaCuentasSAT_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmAsignaCuentasSAT_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grbTipoEnvio.ResumeLayout(false);
            this.grbTipoEnvio.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdBuscarCarpeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbEjercicio;
        private System.Windows.Forms.GroupBox grbTipoEnvio;
        private System.Windows.Forms.RadioButton rbtFiscCompulsa;
        private System.Windows.Forms.RadioButton rbtActoFisc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedNumTramite;
        private System.Windows.Forms.RadioButton rbtCompensacion;
        private System.Windows.Forms.RadioButton rbtDevolucion;
        private System.Windows.Forms.MaskedTextBox mtbNumOrden;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pbrProgreso;
        private System.Windows.Forms.Label lblEstatus;

    }
}

