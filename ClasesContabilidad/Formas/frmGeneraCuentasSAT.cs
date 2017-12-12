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
using EC = Integralab.ORM.EntityClasses;
using CC = Integralab.ORM.CollectionClasses;
using HC = Integralab.ORM.HelperClasses;
using CT = IntegraLab.eCont;
using Zip = Ionic.Zip;
using Ionic.Zip;

namespace ClasesContabilidad
{
    public partial class frmGeneraCuentasSAT : Form//, CN.iForm
    {
        CN.CuentaContableCollectionClass loColCuentasContables = new CN.CuentaContableCollectionClass();
        CN.AgrupadorSATColClass loColSATAgrupadores = new CN.AgrupadorSATColClass();

        CN.ControladorGanadera Controlador;
        //CN.CuentasContablesCol loColCuentasContables = new CN.CuentasContablesCol();
        //CN.SATAgrupadoresCol loColSATAgrupadores = new CN.SATAgrupadoresCol();
        CN.PeriodosContablesCollectionClass loColEjerciciosContables = new CN.PeriodosContablesCollectionClass();

        //CN.EjerciciosContablesCol loColEjerciciosContables = new CN.EjerciciosContablesCol();
        CN.ControlMesCollectionClass loColPeriodosContables = new CN.ControlMesCollectionClass();
        //CN.Ejercicio ejer;
        CN.ControlMesClass per;
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean seleccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private bool[] _ToolBarStatus = { true, true, true, true, true, true };
        private String lsIdEvento, lsNombreEvento;

        public frmGeneraCuentasSAT()
        {
            InitializeComponent();
        }

        public frmGeneraCuentasSAT(CN.ControladorGanadera controlador)
        {
            InitializeComponent();
            Controlador = controlador;
        }

    #region "iForm"
        //Boolean[] CN.iForm.ToolBarStatus
        //{
        //    get { return _ToolBarStatus; }
        //    //set { _ToolBarStatus = value; }
        //}

        //void CN.iForm.Guardar()
        //{
        //    Generar();
        //}

        ////private bool Validar()
        ////{
        ////    Boolean Validado = true;
        ////    String Mensaje = "";

        ////    if (txtNombre.Text.Trim() == "")
        ////        Mensaje = Mensaje + "   * No se ha capturado el nombre de la sección.\n";

        ////    if (Mensaje != "")
        ////    {
        ////        Validado = false;
        ////        Mensaje = "Antes de guardar debe corregir lo siguiente:\n\n" + Mensaje;
        ////        MessageBox.Show(Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        ////    }

        ////    return Validado;
        ////}

        //void CN.iForm.Borrar()
        //{
        //}

        //void CN.iForm.Cancelar()
        //{
        //}

        //void CN.iForm.Nuevo()
        //{
        //}

        //void CN.iForm.Buscar()
        //{
        //}

        //void CN.iForm.Imprimir()
        //{
        //}

    #endregion

    #region "Eventos"
        private void frmAsignaCuentasSAT_Load(object sender, EventArgs e)
        {
            try
            {
                loColEjerciciosContables.Obtener();
                cmbEjercicio.DisplayMember = "Ejercicio";
                cmbEjercicio.ValueMember = "Ejercicio";
                cmbEjercicio.DataSource = loColEjerciciosContables;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAsignaCuentasSAT_KeyPress(object sender, KeyPressEventArgs e)
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

    #endregion

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            loColPeriodosContables.Clear();
            SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
            Filtro.Add(HC.ConMesFields.NumYear == Convert.ToString( cmbEjercicio.SelectedValue));
            loColPeriodosContables.Obtener(Filtro);
            cmbPeriodo.DisplayMember = "NumMes";
            cmbPeriodo.ValueMember = "NumMes";
            cmbPeriodo.DataSource = loColPeriodosContables;
        }

        #region "Metodos"

        public Boolean validar()
        {
            String mensaje = "";
            if (txtCarpeta.Text.Trim().Equals(""))
            {
                mensaje += "*Seleccione la ruta donde se guardara el archivo.\n";
            }
            if (cmbEjercicio.SelectedIndex == -1 || cmbEjercicio.SelectedValue == null )
            {
                mensaje += "*Seleccione un ejercicio.\n";
            }
            if (cmbPeriodo.SelectedIndex == -1 || cmbPeriodo.SelectedValue == null)
            {
                mensaje += "*Seleccione un periodo.\n";
            }

            if (!mensaje.Equals(""))
            {
                mensaje = "Antes de continuar es necesario verificar lo siguiente: \n" + mensaje;
                MessageBox.Show(mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        void Generar()
        {
            try
            {
                //MessageBox.Show("Error ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //if (fbdBuscarCarpeta.ShowDialog() == DialogResult.OK)
                //    txtCarpeta.Text = fbdBuscarCarpeta.SelectedPath;
                //else
                //    return;
                if (validar())
                {


                    // Se leen las cuentas contables del catálogo y se agregan a la coleccion de conversion
                    loColCuentasContables.Obtener();
                    List<CT.v1_1.CatalogoCtas> CatCtas = new List<CT.v1_1.CatalogoCtas>();
                    int CtasSinAgrupador = 0;
                    foreach (CN.CuentaContableClass ctacont in loColCuentasContables)
                    {
                        if (ctacont.CodAgrupSAT != "")
                        {
                            CT.v1_1.CatalogoCtas cta = new CT.v1_1.CatalogoCtas();
                            cta.CodAgrup = ctacont.CodAgrupSAT;
                            cta.NumCta = ctacont.NumCuenta;
                            cta.Desc = ctacont.NombreCuenta.Trim();
                            cta.SubCtaDe = ctacont.CtaPadre;
                            cta.Nivel = ctacont.Nivel;
                            cta.Natur = ("ACREEDORA" == ctacont.DescripcionNaturaleza) ? "A" : "D";
                            CatCtas.Add(cta);
                        }
                        else
                            CtasSinAgrupador++;
                    }

                    // Se crea el catálogo de conversion
                    string per = Convert.ToString(cmbPeriodo.SelectedValue);
                    int ej = int.Parse(Convert.ToString(cmbEjercicio.SelectedValue));
                    CT.v1_1.Catalogo loCat = new CT.v1_1.Catalogo(CatCtas, Controlador.Empresa.RFC.ToUpper(), per, ej);

                    if (CtasSinAgrupador > 0)
                    {
                        if (MessageBox.Show("Existen " + CtasSinAgrupador.ToString() + " cuentas contables sin agrupador del SAT asignado.\n" +
                                            "Las cuentas contables sin agrupador no serán incluidas en el archivo. ¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    string NomArch = Controlador.Empresa.RFC.ToUpper() + ej.ToString("####") + per + "CT";
                    CT.Controlador.GeneraCatalogoXml(loCat, txtCarpeta.Text, NomArch);

                    //ExtractFileToDirectory(txtCarpeta.Text + "\\" + NomArch + ".zip", txtCarpeta.Text + "\\" + NomArch);
                    //Application.DoEvents();
                    //System.Diagnostics.Process.Start(txtCarpeta.Text + "\\" + NomArch + "\\" + NomArch + ".xml");

                    MessageBox.Show("El archivo se ha generado en la carpeta " + txtCarpeta.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return;
        }


        public void ExtractFileToDirectory(string zipFileName, string outputDirectory)
        {
            ZipFile zip = ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            zip.ExtractAll(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
        }
        #endregion

        private void btnSelecRuta_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdBuscarCarpeta.ShowDialog() == DialogResult.OK)
                    txtCarpeta.Text = fbdBuscarCarpeta.SelectedPath;
                else
                    return;
            }
            catch (Exception ex)
            {
                  MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  return;
            }
        }

    }
}
