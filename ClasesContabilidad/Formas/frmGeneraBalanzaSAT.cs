using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CN = ClasesNegocio;
using EC = SideviORM.EntityClasses;
using CC = SideviORM.CollectionClasses;
using HC = SideviORM.HelperClasses;
using CT = IntegraLab.eCont;

namespace ClasesContabilidad
{
   
    public partial class frmGeneraBalanzaSAT : Form, CN.iForm
    {
        CN.VwAcuCtaContableCol loAcuCtaCont = new CN.VwAcuCtaContableCol();
        CN.CuentaContable loCuentaContable = new CN.CuentaContable();
        CN.EjerciciosContablesCol loColEjerciciosContables = new CN.EjerciciosContablesCol();
        CN.PeriodosContablesCol loColPeriodosContables = new CN.PeriodosContablesCol();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean seleccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private bool[] _ToolBarStatus = { true, true, true, true, true, true };
        private String lsIdEvento, lsNombreEvento;        

        public frmGeneraBalanzaSAT()
        {
            InitializeComponent();
        }

    #region "iForm"
        Boolean[] CN.iForm.ToolBarStatus
        {
            get { return _ToolBarStatus; }
            //set { _ToolBarStatus = value; }
        }

        void CN.iForm.Guardar()
        {
            Generar();
        }

        private bool Validar()
        {
            Boolean Validado = true;
            String Mensaje = "";

        //    if (txtNombre.Text.Trim() == "")
        //        Mensaje = Mensaje + "   * No se ha capturado el nombre de la sección.\n";

        //    if (Mensaje != "")
        //    {
        //        Validado = false;
        //        Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
        //        MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

            return Validado;
        }

        void CN.iForm.Borrar()
        {
        }

        void CN.iForm.Cancelar()
        {
        }

        void CN.iForm.Nuevo()
        {
        }

        void CN.iForm.Buscar()
        {
        }

        void CN.iForm.Imprimir()
        {
        }

    #endregion

    #region "Eventos"
        private void frmGeneraBalanzaSAT_Load(object sender, EventArgs e)
        {
            try
            {
                loColEjerciciosContables.Obtener();                
                cmbEjercicio.DisplayMember = "Año";
                cmbEjercicio.ValueMember = "Año";
                cmbEjercicio.DataSource = loColEjerciciosContables;
                dtpFecModif.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGeneraBalanzaSAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            loAcuCtaCont.Clear();
            SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
            Filtro.Add(HC.PeriodoContableFields.Año == (string)cmbEjercicio.SelectedValue);
            loColPeriodosContables.Obtener(Filtro);
            cmbPeriodo.DisplayMember = "Periodo";
            cmbPeriodo.ValueMember = "Periodo";
            cmbPeriodo.DataSource = loColPeriodosContables;
        }

        private void rbtComplementario_CheckedChanged(object sender, EventArgs e)
        {
            lblFecModif.Visible = rbtComplementario.Checked;
            dtpFecModif.Visible = rbtComplementario.Checked;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

    #endregion

    #region "Metodos"
        void Generar()
        {
            try
            {
                if (fbdBuscarCarpeta.ShowDialog() == DialogResult.OK)
                    txtCarpeta.Text = fbdBuscarCarpeta.SelectedPath;
                else
                    return;
                SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.VwacuCuentaContableFields.Ejercicio == (string)cmbEjercicio.SelectedValue);
                loAcuCtaCont.Obtener(Filtro);

                List<CT.v1_1.BalanzaCtas> BalCtas = new List<CT.v1_1.BalanzaCtas>();
                int BalSinAgrupador = 0;
                foreach (CN.VwAcuCtaContable AcuCta in loAcuCtaCont)
                {
                    loCuentaContable = new CN.CuentaContable(AcuCta.CtaMay, AcuCta.SubCta, AcuCta.SsbCta, AcuCta.SssbCta);
                    if (loCuentaContable.CodAgrupadorSat != "")
                    {
                        if (cmbPeriodo.Text != "Periodo")
                        {
                            int mes = 0;
                            decimal SalFin = 0;
                            decimal SalIni = 0;
                            decimal Cargos = 0, Abonos = 0;
                            mes = Int32.Parse(cmbPeriodo.Text);
                            switch (mes)
                            {
                                case 1:
                                    Cargos = AcuCta.Cargos01;
                                    Abonos = AcuCta.Abonos01;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio;
                                        SalFin = AcuCta.SalInicialEjercicio + (AcuCta.Cargos01 - AcuCta.Abonos01);
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio;
                                        SalFin = AcuCta.SalInicialEjercicio + (AcuCta.Abonos01 - AcuCta.Cargos01);
                                    }
                                    break;
                                case 2:
                                    Cargos = AcuCta.Cargos02;
                                    Abonos = AcuCta.Abonos02;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02));
                                    }
                                    break;
                                case 3:
                                    Cargos = AcuCta.Cargos03;
                                    Abonos = AcuCta.Abonos03;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03));
                                    }
                                    break;
                                case 4:
                                    Cargos = AcuCta.Cargos04;
                                    Abonos = AcuCta.Abonos04;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04));
                                    }
                                    break;
                                case 5:
                                    Cargos = AcuCta.Cargos05;
                                    Abonos = AcuCta.Abonos05;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05));

                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05));
                                    }
                                    break;
                                case 6:
                                    Cargos = AcuCta.Cargos06;
                                    Abonos = AcuCta.Abonos06;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06));
                                    }
                                    break;
                                case 7:
                                    Cargos = AcuCta.Cargos07;
                                    Abonos = AcuCta.Abonos07;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07));
                                    }
                                    break;
                                case 8:
                                    Cargos = AcuCta.Cargos08;
                                    Abonos = AcuCta.Abonos08;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08));
                                    }
                                    break;
                                case 9:
                                    Cargos = AcuCta.Cargos09;
                                    Abonos = AcuCta.Abonos09;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09));
                                    }
                                    break;
                                case 10:
                                    Cargos = AcuCta.Cargos10;
                                    Abonos = AcuCta.Abonos10;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09) + (AcuCta.Cargos10 - AcuCta.Abonos10));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09) + (AcuCta.Abonos10 - AcuCta.Cargos10));
                                    }
                                    break;
                                case 11:
                                    Cargos = AcuCta.Cargos11;
                                    Abonos = AcuCta.Abonos11;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09) + (AcuCta.Cargos10 - AcuCta.Abonos10));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09) + (AcuCta.Cargos10 - AcuCta.Abonos10) + (AcuCta.Cargos11 - AcuCta.Abonos11));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09) + (AcuCta.Abonos10 - AcuCta.Cargos10));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09) + (AcuCta.Abonos10 - AcuCta.Cargos10) + (AcuCta.Abonos11 - AcuCta.Cargos11));
                                    }
                                    break;
                                case 12:
                                    Cargos = AcuCta.Cargos12;
                                    Abonos = AcuCta.Abonos12;
                                    if (loCuentaContable.Naturaleza == "D")
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09) + (AcuCta.Cargos10 - AcuCta.Abonos10) + (AcuCta.Cargos11 - AcuCta.Abonos11));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Cargos01 - AcuCta.Abonos01) + (AcuCta.Cargos02 - AcuCta.Abonos02) + (AcuCta.Cargos03 - AcuCta.Abonos03) + (AcuCta.Cargos04 - AcuCta.Abonos04) + (AcuCta.Cargos05 - AcuCta.Abonos05) + (AcuCta.Cargos06 - AcuCta.Abonos06) + (AcuCta.Cargos07 - AcuCta.Abonos07) + (AcuCta.Cargos08 - AcuCta.Abonos08) + (AcuCta.Cargos09 - AcuCta.Abonos09) + (AcuCta.Cargos10 - AcuCta.Abonos10) + (AcuCta.Cargos11 - AcuCta.Abonos11) + (AcuCta.Cargos12 - AcuCta.Abonos12));
                                    }
                                    else
                                    {
                                        SalIni = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09) + (AcuCta.Abonos10 - AcuCta.Cargos10) + (AcuCta.Abonos11 - AcuCta.Cargos11));
                                        SalFin = AcuCta.SalInicialEjercicio + ((AcuCta.Abonos01 - AcuCta.Cargos01) + (AcuCta.Abonos02 - AcuCta.Cargos02) + (AcuCta.Abonos03 - AcuCta.Cargos03) + (AcuCta.Abonos04 - AcuCta.Cargos04) + (AcuCta.Abonos05 - AcuCta.Cargos05) + (AcuCta.Abonos06 - AcuCta.Cargos06) + (AcuCta.Abonos07 - AcuCta.Cargos07) + (AcuCta.Abonos08 - AcuCta.Cargos08) + (AcuCta.Abonos09 - AcuCta.Cargos09) + (AcuCta.Abonos10 - AcuCta.Cargos10) + (AcuCta.Abonos11 - AcuCta.Cargos11) + (AcuCta.Abonos12 - AcuCta.Cargos12));
                                    }
                                    break;
                            }

                            if (SalIni != 0 || Cargos != 0 || Abonos != 0 || SalFin != 0)
                            {
                                CT.v1_1.BalanzaCtas bal = new CT.v1_1.BalanzaCtas();
                                bal.NumCta = AcuCta.NumCuenta;
                                bal.SaldoIni = SalIni;
                                bal.Debe = Cargos;
                                bal.Haber = Abonos;
                                bal.SaldoFin = SalFin;
                                BalCtas.Add(bal);
                            }
                        }
                    }
                }

                string per = (string)cmbPeriodo.SelectedValue;
                int ej = int.Parse((string)cmbEjercicio.SelectedValue);
                string tEnv = rbtNormal.Checked ? "N" : "C";
                CT.v1_1.Balanza loBal = new CT.v1_1.Balanza(BalCtas, CN.Controlador.Empresa.RFC, ej, per, tEnv);
                if (tEnv == "C") loBal.FechaModBal = dtpFecModif.Value;

                //if (CtasSinAgrupador > 0)
                //{
                //    if (MessageBox.Show("Existen " + CtasSinAgrupador.ToString() + " cuentas contables sin agrupador del SAT asignado. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                //    {
                //        return;
                //    }
                //}

                string NomArch = CN.Controlador.Empresa.RFC.ToUpper() + ej.ToString("####") + per + "B" + tEnv;
                CT.Controlador.GeneraBalanzaXml(loBal, txtCarpeta.Text, NomArch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }
    #endregion

    }
}
