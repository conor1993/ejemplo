namespace ClasesContabilidad
{
    partial class frmGeneraBalanzaSAT
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
            this.lblFecModif = new System.Windows.Forms.Label();
            this.dtpFecModif = new System.Windows.Forms.DateTimePicker();
            this.grbTipoEnvio = new System.Windows.Forms.GroupBox();
            this.rbtComplementario = new System.Windows.Forms.RadioButton();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbEjercicio = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.fbdBuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBox1.SuspendLayout();
            this.grbTipoEnvio.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.lblFecModif);
            this.GroupBox1.Controls.Add(this.dtpFecModif);
            this.GroupBox1.Controls.Add(this.grbTipoEnvio);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.cmbPeriodo);
            this.GroupBox1.Controls.Add(this.cmbEjercicio);
            this.GroupBox1.Controls.Add(this.btnGenerar);
            this.GroupBox1.Controls.Add(this.txtCarpeta);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 157);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // lblFecModif
            // 
            this.lblFecModif.AutoSize = true;
            this.lblFecModif.Location = new System.Drawing.Point(6, 76);
            this.lblFecModif.Name = "lblFecModif";
            this.lblFecModif.Size = new System.Drawing.Size(117, 13);
            this.lblFecModif.TabIndex = 10;
            this.lblFecModif.Text = "Fecha de modificación:";
            this.lblFecModif.Visible = false;
            // 
            // dtpFecModif
            // 
            this.dtpFecModif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecModif.Location = new System.Drawing.Point(129, 73);
            this.dtpFecModif.Name = "dtpFecModif";
            this.dtpFecModif.Size = new System.Drawing.Size(82, 20);
            this.dtpFecModif.TabIndex = 9;
            this.dtpFecModif.Visible = false;
            // 
            // grbTipoEnvio
            // 
            this.grbTipoEnvio.Controls.Add(this.rbtComplementario);
            this.grbTipoEnvio.Controls.Add(this.rbtNormal);
            this.grbTipoEnvio.Location = new System.Drawing.Point(235, 16);
            this.grbTipoEnvio.Name = "grbTipoEnvio";
            this.grbTipoEnvio.Size = new System.Drawing.Size(198, 51);
            this.grbTipoEnvio.TabIndex = 4;
            this.grbTipoEnvio.TabStop = false;
            this.grbTipoEnvio.Text = "Tipo de envío";
            // 
            // rbtComplementario
            // 
            this.rbtComplementario.AutoSize = true;
            this.rbtComplementario.Location = new System.Drawing.Point(92, 19);
            this.rbtComplementario.Name = "rbtComplementario";
            this.rbtComplementario.Size = new System.Drawing.Size(100, 17);
            this.rbtComplementario.TabIndex = 1;
            this.rbtComplementario.Text = "Complementario";
            this.rbtComplementario.UseVisualStyleBackColor = true;
            this.rbtComplementario.CheckedChanged += new System.EventHandler(this.rbtComplementario_CheckedChanged);
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Checked = true;
            this.rbtNormal.Location = new System.Drawing.Point(6, 19);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtNormal.TabIndex = 0;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Período:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ejercicio:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(129, 46);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(68, 21);
            this.cmbPeriodo.TabIndex = 3;
            // 
            // cmbEjercicio
            // 
            this.cmbEjercicio.FormattingEnabled = true;
            this.cmbEjercicio.Location = new System.Drawing.Point(129, 19);
            this.cmbEjercicio.Name = "cmbEjercicio";
            this.cmbEjercicio.Size = new System.Drawing.Size(68, 21);
            this.cmbEjercicio.TabIndex = 1;
            this.cmbEjercicio.SelectedIndexChanged += new System.EventHandler(this.cmbEjercicio_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(362, 125);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(72, 26);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(129, 99);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(305, 20);
            this.txtCarpeta.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guardar en la carpeta:";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(464, 181);
            this.Panel1.TabIndex = 0;
            // 
            // frmGeneraBalanzaSAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 181);
            this.Controls.Add(this.Panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 166);
            this.Name = "frmGeneraBalanzaSAT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Balanza de Comprobación en XML para el SAT";
            this.Load += new System.EventHandler(this.frmGeneraBalanzaSAT_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmGeneraBalanzaSAT_KeyPress);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.grbTipoEnvio.ResumeLayout(false);
            this.grbTipoEnvio.PerformLayout();
            this.Panel1.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton rbtComplementario;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.Label lblFecModif;
        private System.Windows.Forms.DateTimePicker dtpFecModif;

    }
}

