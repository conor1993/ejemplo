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

namespace ClasesContabilidad
{
    public partial class frmAsignaCuentasSAT : Form//, CN.iForm
    {
        CN.CuentaContableCollectionClass loColCuentasContables = new CN.CuentaContableCollectionClass();
       
        //CN.CuentasContablesCol loColCuentasContables = new CN.CuentasContablesCol();
        //CN.SATAgrupadoresCol loColSATAgrupadores = new CN.SATAgrupadoresCol();
        CN.AgrupadorSATColClass loColSATAgrupadores = new CN.AgrupadorSATColClass();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean seleccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private bool[] _ToolBarStatus = { true, true, true, true, true, true };
        private String lsIdEvento, lsNombreEvento;

        public frmAsignaCuentasSAT()
        {
            InitializeComponent();
        }

    #region "iForm"
        //Boolean[] CN.iForm.ToolBarStatus
        //{
        //    get { return _ToolBarStatus; }
        //    //set { _ToolBarStatus = value; }
        //}

        //void CN.iForm.Guardar()
        //{
        //    HC.Transaction trans = new HC.Transaction(IsolationLevel.ReadCommitted, "CuentasContables");
        //    try
        //    {
        //        foreach (DataGridViewRow Ren in dgvCtasContables.Rows)
        //        {
        //            CN.CuentaContable cc = (CN.CuentaContable)Ren.DataBoundItem;
        //            trans.Add(cc.Entidad);
        //            cc.Entidad.Save();
        //        }
        //        trans.Commit();
        //        MessageBox.Show("Las cuentas contables han sido actualizadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        trans.Rollback();
        //        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

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
                MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure MtbEstados = new MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure();
                MtbEstados.StateBuscar = "110101111";
                MtbEstados.StateLimpiar = "";
                MtbEstados.StateCancelar = "000100011";
                MtbEstados.StateNuevo = "011010001";
                MtbEstados.StateGuardar = "110100011";
                MtbEstados.StateBorrar = "100100001";
                MtbEstados.StateEditar = "001010000";
                MtbEstados.StateImprimir = "";
                MtbEstados.StateSalir = "";
                mtb.ToolBarButtonStatus = MtbEstados;

                mtb.sbCambiarEstadoBotones("Nuevo");

#if (DEBUG)
                clmCodCtaContable.Visible = true;
#endif
                //Eventos
                mtb.ClickGuardar += mtb_ClickGuardar;
                mtb.ClickSalir += mtb_ClickSalir;

                loColCuentasContables.Obtener();
                dgvCtasContables.AutoGenerateColumns = false;
                dgvCtasContables.DataSource = loColCuentasContables;

              
                loColSATAgrupadores.Obtener();
                clmDescAgrupador.DisplayMember = "CodDescripcion";
                clmDescAgrupador.ValueMember = "CodAgrupador";
                clmDescAgrupador.DataSource = loColSATAgrupadores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mtb_ClickGuardar(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e, ref bool Cancelar)
        {
            HC.Transaction trans = new HC.Transaction(IsolationLevel.ReadCommitted, "CuentasContables");
            try
            {
                foreach (DataGridViewRow Ren in dgvCtasContables.Rows)
                {
                    if (Ren.Cells[clmDescAgrupador.Index].Value != null)
                    {
                        CN.CuentaContableClass cc = new CN.CuentaContableClass((int)Ren.Cells[clmCodCtaContable.Index].Value);
                        cc.CodAgrupSAT = Ren.Cells[clmDescAgrupador.Index].Value.ToString();
                        //if (! cc.Guardar(trans))
                        //{
                        //    MessageBox.Show("Error al actualizar las cuentas contables.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    Cancelar = true;
                        //    trans.Rollback();
                        //}
                        trans.Add(cc.Entidad);
                        cc.Entidad.Save();
                    }                    
                }
                trans.Commit();
                MessageBox.Show("Las cuentas contables han sido actualizadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cancelar = true;
                trans.Rollback();
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void mtb_ClickSalir(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e, ref bool Cancelar)
        {
            this.Close();
        }

        private void frmAsignaCuentasSAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");
            //}
        }


        private void Evento_MensajeError(object sender, string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvCtasContables_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCtasContables.CurrentCell.ColumnIndex == 2)
            {
                DataGridViewComboBoxEditingControl combo = (DataGridViewComboBoxEditingControl)e.Control;
                combo.KeyPress += new KeyPressEventHandler(DataGridViewComboBox_KeyPress);
                e.Control.KeyPress += new KeyPressEventHandler(DataGridViewComboBox_KeyPress);
            }
        }

        private void DataGridViewComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                dgvCtasContables.CurrentCell.Value = "";
                dgvCtasContables.CancelEdit();
                e.Handled = true;
            }
        }

    #endregion

        private void dgvCtasContables_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCtasContables.CurrentCell.ColumnIndex == 2)
                if (e.KeyChar == (char)Keys.Back)
                {
                    dgvCtasContables.CurrentRow.Cells[2].Value = "";
                    e.Handled = true;
                }

            if (e.KeyChar == (char)Keys.Enter)
            {
                dgvCtasContables.CurrentRow.Cells[2].ReadOnly = false;
                dgvCtasContables.CurrentRow.DefaultCellStyle.Font = new Font(dgvCtasContables.DefaultCellStyle.Font, FontStyle.Bold);
                dgvCtasContables.CurrentCell = dgvCtasContables.CurrentRow.Cells[1];
                e.Handled = true;
            }          
            
        }

        private void dgvCtasContables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                  dgvCtasContables.CurrentRow.Cells[clmDescAgrupador.Index].Value = null;                 

            }
        }

        private void dgvCtasContables_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == clmDescAgrupador.Index)
            //{
            //    dgvCtasContables.CurrentCell = dgvCtasContables.Rows[dgvCtasContables.CurrentRow.Index + 1].Cells[0];
            //}
        }

    #region "Metodos"


    #endregion

    }
}
