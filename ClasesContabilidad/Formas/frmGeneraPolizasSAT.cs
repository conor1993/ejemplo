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
using OC = SD.LLBLGen.Pro.ORMSupportClasses;

namespace ClasesContabilidad
{
    public partial class frmGeneraPolizasSAT : Form, CN.iForm
    {
        CN.CuentasContablesCol loColCuentasContables = new CN.CuentasContablesCol();
        CN.SATAgrupadoresCol loColSATAgrupadores = new CN.SATAgrupadoresCol();
        CN.EjerciciosContablesCol loColEjerciciosContables = new CN.EjerciciosContablesCol();
        CN.PeriodosContablesCol loColPeriodosContables = new CN.PeriodosContablesCol();
        CN.VwAcuCtaContableCol loAcuCtaCont = new CN.VwAcuCtaContableCol();
        CN.Poliza loPoliza= new CN.Poliza();
        CN.PolizaCol loPolizaCol = new CN.PolizaCol();
        CN.PolizaDetalle loPolizaDetalle = new CN.PolizaDetalle();
        CN.PolizaDetalleCol loPolizaDetalleCol = new CN.PolizaDetalleCol();
        CN.Factura loFactura = new CN.Factura();
        CN.FacturaCol loFacturaCol = new CN.FacturaCol();
        Boolean puedorefrescar = true;
        Boolean Editar = false;
        Boolean seleccionado = false;
        Dictionary<string, int> list = new Dictionary<string, int>();

        private SqlDataAdapter DtAdap = new SqlDataAdapter();
        private DataSet dtsGral = new DataSet();
        private Boolean lbModificado = false;
        private bool[] _ToolBarStatus = { true, true, true, true, true, true };
        private String lsIdEvento, lsNombreEvento;

        public frmGeneraPolizasSAT()
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
        private void frmAsignaCuentasSAT_Load(object sender, EventArgs e)
        {
            try
            {
                loColCuentasContables.Obtener();
                loColSATAgrupadores.Obtener();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                loColEjerciciosContables.Obtener();
                cmbEjercicio.DisplayMember = "Año";
                cmbEjercicio.ValueMember = "Año";
                cmbEjercicio.DataSource = loColEjerciciosContables;
                //dtpFecModif.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.label5.Visible = false;
            this.maskedNumTramite.Visible = false;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (validar())
                Generar();
        }

    #region "Metodos"
        void Generar()
        {
            CT.v1_1.PolizasPolizaTransaccionCompNal csCompraNal;
            CT.v1_1.PolizasPolizaTransaccionCompNalOtr csCompraNalOtr;
            CT.v1_1.PolizasPolizaTransaccionCheque csCheque;
            CT.v1_1.PolizasPolizaTransaccionTransferencia csTransfer;

            btnGenerar.Enabled = false;
            try
            {
                if (fbdBuscarCarpeta.ShowDialog() == DialogResult.OK)
                    txtCarpeta.Text = fbdBuscarCarpeta.SelectedPath;
                else
                    return;

                // Se leen las pólizas del período y se agregan a la colección
                lblEstatus.Visible = true;
                lblEstatus.Text = "Buscando las Pólizas";
                Application.DoEvents();

                OC.PredicateExpression filtro = new OC.PredicateExpression();
                DateTime fechainicio, fechafin;
                fechainicio = new DateTime(Convert.ToInt32(cmbEjercicio.SelectedValue), Convert.ToInt32(cmbPeriodo.SelectedValue), 1);
                if (Convert.ToInt32(cmbPeriodo.SelectedValue) == 12)
                    fechafin = new DateTime(Convert.ToInt32(cmbEjercicio.SelectedValue) + 1, Convert.ToInt32(1), Convert.ToInt32(1));
                else
                    fechafin = new DateTime(Convert.ToInt32(cmbEjercicio.SelectedValue), Convert.ToInt32(cmbPeriodo.SelectedValue) + 1, Convert.ToInt32(1));

                filtro.Add(HC.PolizaFields.FechaPol >= fechainicio);
                filtro.Add(HC.PolizaFields.FechaPol < fechafin);
                loPolizaCol.Obtener(filtro);
                List<CT.v1_1.PolizasPoliza> csPolizasCol = new List<CT.v1_1.PolizasPoliza>();

                pbrProgreso.Minimum = 0;
                pbrProgreso.Maximum = loPolizaCol.Count;
                pbrProgreso.Value = 0;
                pbrProgreso.Visible = true;
                lblEstatus.Visible = false;

                // Se recorren las pólizas de la colección para agregarlas a las clases de serialización
                foreach (CN.Poliza Polcont in loPolizaCol)
                {
                    pbrProgreso.Value++;
                    Application.DoEvents();

                    // Encabezado de póliza
                    CT.v1_1.PolizasPoliza csPoliza = new CT.v1_1.PolizasPoliza();
                    csPoliza.NumUnIdenPol = ((char)Polcont.TipoPoliza).ToString() + Polcont.NumPoliza;
                    csPoliza.Fecha = Polcont.FechaPol;
                    csPoliza.Concepto = Polcont.Concepto;
                    csPoliza.Transaccion = new List<CT.v1_1.PolizasPolizaTransaccion>();

                    int liTotMovim = 0;
                    // Se recorre el detalle de la póliza para agregarlo a las clases de serialización
                    foreach (CN.PolizaDetalle PolDet in Polcont.PolizaDetalles)
                    {
                        // Renglon de movimiento de póliza
                        liTotMovim += 1;
                        CT.v1_1.PolizasPolizaTransaccion csTransac = new CT.v1_1.PolizasPolizaTransaccion();
                        csTransac.NumCta = PolDet.CuentaContable.NumCuenta;
                        csTransac.DesCta = PolDet.CuentaContable.Descripcion;
                        csTransac.Concepto = PolDet.Concepto;
                        if (PolDet.CarAbo == CN.PolizaDetalle.CarAboEnum.ABONO)
                            csTransac.Haber = PolDet.Importe;
                        else
                            csTransac.Debe = PolDet.Importe;
                        csTransac.Cheque = new List<CT.v1_1.PolizasPolizaTransaccionCheque>();
                        csTransac.Transferencia = new List<CT.v1_1.PolizasPolizaTransaccionTransferencia>();
                        csTransac.CompNal = new List<CT.v1_1.PolizasPolizaTransaccionCompNal>();
                        csTransac.CompNalOtr = new List<CT.v1_1.PolizasPolizaTransaccionCompNalOtr>();

                        // Si es el primer movimiento de la póliza, agrega los elementos relacionados
                        if (liTotMovim == 1)
                        {
                            //CT.v1_1.PolizasPolizaTransaccionCompNal csCompraNal = new CT.v1_1.PolizasPolizaTransaccionCompNal();
                            //CT.v1_1.PolizasPolizaTransaccionCompNalOtr csCompraNalOtr = new CT.v1_1.PolizasPolizaTransaccionCompNalOtr();
                            //csTransac.CompNal = new List<CT.v1_1.PolizasPolizaTransaccionCompNal>();
                            //csTransac.CompNalOtr = new List<CT.v1_1.PolizasPolizaTransaccionCompNalOtr>();

                            // Recorre las facturas relacionadas a la póliza
                            foreach (CN.Factura Fact in Polcont.Facturas)
                            {
                                if (Fact.UUID.Trim() == "")
                                {
                                    csCompraNalOtr = new CT.v1_1.PolizasPolizaTransaccionCompNalOtr();
                                    csCompraNalOtr.RFC = Fact.Proveedor.RFC;
                                    csCompraNalOtr.MontoTotal = Fact.Total;
                                    csCompraNalOtr.Moneda = "MXN";
                                    csCompraNalOtr.TipCamb = 1;
                                    csTransac.CompNalOtr.Add(csCompraNalOtr);
                                }
                                else
                                {
                                    csCompraNal = new CT.v1_1.PolizasPolizaTransaccionCompNal();
                                    csCompraNal.RFC = Fact.Proveedor.RFC;
                                    csCompraNal.MontoTotal = Fact.Total;
                                    csCompraNal.Moneda = "MXN";
                                    csCompraNal.TipCamb = 1;
                                    csTransac.CompNal.Add(csCompraNal);
                                }
                            }

                            //CT.v1_1.PolizasPolizaTransaccionCheque csCheque = new CT.v1_1.PolizasPolizaTransaccionCheque();
                            //CT.v1_1.PolizasPolizaTransaccionTransferencia csTransfer = new CT.v1_1.PolizasPolizaTransaccionTransferencia();
                            //csTransac.Cheque = new List<CT.v1_1.PolizasPolizaTransaccionCheque>();
                            //csTransac.Transferencia = new List<CT.v1_1.PolizasPolizaTransaccionTransferencia>();

                            // Revisa si hay movimientos bancarios relacionados a la póliza y los agrega
                            foreach (CN.MovBancario MovBan in Polcont.MovBancarioCol)
                            {
                                switch (MovBan.TipoMov)
                                {
                                    case CN.MovBancario.TipoMovBancarioEnum.CHEQUE:
                                        {
                                            csCheque = new CT.v1_1.PolizasPolizaTransaccionCheque();
                                            csCheque.Num = MovBan.Referencia;
                                            csCheque.BanEmisNal = MovBan.Banco.CveSat;
                                            csCheque.CtaOri = MovBan.CtaBancaria;
                                            csCheque.Fecha = MovBan.FechaMov;
                                            csCheque.Benef = MovBan.Beneficiario;
                                            csCheque.RFC = MovBan.Proveedor.RFC;
                                            csCheque.Monto = MovBan.Importe;
                                            csCheque.Moneda = "MXN";
                                            csCheque.TipCamb = 1;
                                            csTransac.Cheque.Add(csCheque);
                                            break;
                                        }
                                    case CN.MovBancario.TipoMovBancarioEnum.TRASPASO:
                                        {
                                            //csTransfer.BancoOriExt 
                                            if (MovBan.CarAbo == "A")
                                            {
                                                csTransfer = new CT.v1_1.PolizasPolizaTransaccionTransferencia();
                                                csTransfer.CtaOri = MovBan.CtaBancaria;
                                                csTransfer.BancoOriNal = MovBan.Banco.CveSat;
                                                csTransfer.CtaDest = MovBan.CtaBanDest;
                                                csTransfer.BancoDestNal = MovBan.BancoDest.CveSat;
                                                csTransfer.Fecha = MovBan.FechaMov;
                                                csTransfer.Benef = MovBan.Beneficiario;
                                                csTransfer.RFC = MovBan.Proveedor.RFC;
                                                csTransfer.Monto = MovBan.Importe;
                                                csTransfer.Moneda = "MXN";
                                                csTransfer.TipCamb = 1;
                                                csTransac.Transferencia.Add(csTransfer);
                                            }
                                            break;
                                        }
                                }
                            }

                            // Revisa si hay movimientos de credito de clientes generales relacionados a la póliza y los agrega
                            if (Polcont.MovimientosCte != null)
                            {
                                foreach (CN.MovimientoCliente MovCte in Polcont.MovimientosCte)
                                {
                                    if (MovCte.FacturaCte.UUID.Trim() == "")
                                    {
                                        csCompraNalOtr = new CT.v1_1.PolizasPolizaTransaccionCompNalOtr();
                                        csCompraNalOtr.RFC = MovCte.CteGeneral.RFC;
                                        csCompraNalOtr.MontoTotal = MovCte.Importe;
                                        csCompraNalOtr.Moneda = "MXN";
                                        csCompraNalOtr.TipCamb = 1;
                                        csTransac.CompNalOtr.Add(csCompraNalOtr);
                                    }
                                    else
                                    {
                                        csCompraNal = new CT.v1_1.PolizasPolizaTransaccionCompNal();
                                        csCompraNal.RFC = MovCte.CteGeneral.RFC;
                                        csCompraNal.MontoTotal = MovCte.Importe;
                                        csCompraNal.Moneda = "MXN";
                                        csCompraNal.TipCamb = 1;
                                        csTransac.CompNal.Add(csCompraNal);
                                    }
                                }

                                //csTransac.Transferencia = new List<CT.v1_1.PolizasPolizaTransaccionTransferencia>();
                                //if (Polcont.MovBancarioCol != null)
                                //    foreach (CN.MovBancario MovBan in Polcont.MovBancarioCol)
                                //    {

                                //        if (MovBan.PagoElectronico == false)
                                //        {
                                //            //MovBan.che
                                //            csCheque.Num = MovBan.Referencia;
                                //            csCheque.BanEmisNal = MovBan.Banco.CveSat;
                                //            //csCheque.BanEmisExt = loMovBancario.Banco.CveSat;
                                //            csCheque.CtaOri = MovBan.CtaBancaria;
                                //            csCheque.Fecha = MovBan.FechaMov;
                                //            csCheque.Benef = MovBan.Beneficiario;
                                //            csCheque.RFC = MovBan.Proveedor.RFC;
                                //            csCheque.Monto = MovBan.Importe;
                                //            csCheque.Moneda = "MXN";
                                //            csCheque.TipCamb = 1;
                                //            csTransac.Cheque.Add(csCheque);
                                //        }
                                //        else
                                //        {
                                //            csTransfer.CtaOri = MovBan.CtaBancaria;
                                //            csTransfer.BancoOriNal = MovBan.Banco.CveSat;
                                //            //csTransfer.BancoOriExt 
                                //            csTransfer.CtaDest = MovBan.CtaBanDest;
                                //            csTransfer.BancoDestNal = MovBan.BancoDest.CveSat;
                                //            csTransfer.Fecha = MovBan.FechaMov;
                                //            csTransfer.Benef = MovBan.Beneficiario;
                                //            csTransfer.RFC = MovBan.Proveedor.RFC;
                                //            csTransfer.Monto = MovBan.Importe;
                                //            csTransfer.Moneda = "MXN";
                                //            csTransfer.TipCamb = 1;
                                //            csTransac.Transferencia.Add(csTransfer);
                                //        }
                                //    }
                            }

                            // Revisa si hay movimientos de credito de clientes de vivienda relacionados a la póliza y los agrega
                            if (Polcont.MovimientosCredito != null)
                            {
                                foreach (CN.MovimientoCredito MovCto in Polcont.MovimientosCredito)
                                {
                                    //if (MovCto.UUID != "")
                                    //{
                                    //    PolizasPolizaTransaccionCompNalOtr.RFC = MovCto.CteGeneral.RFC;
                                    //    PolizasPolizaTransaccionCompNalOtr.MontoTotal = MovCto.Importe;
                                    //    PolizasPolizaTransaccionCompNalOtr.Moneda = "MXN";
                                    //    PolizasPolizaTransaccionCompNalOtr.TipCamb = 1;
                                    //    PolizasPolizaTransaccion.CompNalOtr.Add(PolizasPolizaTransaccionCompNalOtr);
                                    //}
                                    //else
                                    //{
                                    //    PolizasPolizaTransaccionCompNal.RFC = MovCto.CteGeneral.RFC;
                                    //    PolizasPolizaTransaccionCompNal.MontoTotal = MovCto.Importe;
                                    //    PolizasPolizaTransaccionCompNal.Moneda = "MXN";
                                    //    PolizasPolizaTransaccionCompNal.TipCamb = 1;
                                    //    PolizasPolizaTransaccion.CompNal.Add(PolizasPolizaTransaccionCompNal);
                                    //}
                                    csCompraNalOtr = new CT.v1_1.PolizasPolizaTransaccionCompNalOtr();
                                    csCompraNalOtr.RFC = MovCto.Cliente.RFC;
                                    csCompraNalOtr.MontoTotal = MovCto.Importe;
                                    csCompraNalOtr.Moneda = "MXN";
                                    csCompraNalOtr.TipCamb = 1;
                                    csTransac.CompNalOtr.Add(csCompraNalOtr);
                                }

                                //csTransac.Cheque = new List<CT.v1_1.PolizasPolizaTransaccionCheque>();
                                //csTransac.Transferencia = new List<CT.v1_1.PolizasPolizaTransaccionTransferencia>();
                                //if (Polcont.MovBancarioCol != null)
                                //    foreach (CN.MovBancario MovBan in Polcont.MovBancarioCol)
                                //    {

                                //        if (MovBan.PagoElectronico == false)
                                //        {
                                //            //MovBan.che
                                //            csCheque.Num = MovBan.Referencia;
                                //            csCheque.BanEmisNal = MovBan.Banco.CveSat;
                                //            //csCheque.BanEmisExt = loMovBancario.Banco.CveSat;
                                //            csCheque.CtaOri = MovBan.CtaBancaria;
                                //            csCheque.Fecha = MovBan.FechaMov;
                                //            csCheque.Benef = MovBan.Beneficiario;
                                //            csCheque.RFC = MovBan.Proveedor.RFC;
                                //            csCheque.Monto = MovBan.Importe;
                                //            csCheque.Moneda = "MXN";
                                //            csCheque.TipCamb = 1;
                                //            csTransac.Cheque.Add(csCheque);
                                //        }
                                //        else
                                //        {
                                //            csTransfer.CtaOri = MovBan.CtaBancaria;
                                //            csTransfer.BancoOriNal = MovBan.Banco.CveSat;
                                //            //csTransfer.BancoOriExt
                                //            csTransfer.CtaDest = MovBan.CtaBanDest;
                                //            csTransfer.BancoDestNal = MovBan.BancoDest.CveSat;
                                //            csTransfer.Fecha = MovBan.FechaMov;
                                //            csTransfer.Benef = MovBan.Beneficiario;
                                //            csTransfer.RFC = MovBan.Proveedor.RFC;
                                //            csTransfer.Monto = MovBan.Importe;
                                //            csTransfer.Moneda = "MXN";
                                //            csTransfer.TipCamb = 1;
                                //            csTransac.Transferencia.Add(csTransfer);
                                //        }

                                //    }
                            }

                        }   // if del primer movimiento

                        csPoliza.Transaccion.Add(csTransac);
                    }   //foreach de la lista de movimientos de las pólizas

                    csPolizasCol.Add(csPoliza);

                }   // foreach de la coleccion de pólizas

                // Se crea el catálogo de conversion
                string per = (string)cmbPeriodo.SelectedValue;
                int ej = int.Parse((string)cmbEjercicio.SelectedValue);
                string tipoSolicitud;
                if (rbtActoFisc.Checked)
                    tipoSolicitud = "AF";
                else if (rbtFiscCompulsa.Checked)
                    tipoSolicitud = "FC";
                else if (rbtDevolucion.Checked)
                    tipoSolicitud = "DE";
                else
                    tipoSolicitud = "CO";
                string NumOrden = mtbNumOrden.Text;
                if (NumOrden.Trim() == "/")
                    NumOrden = "";

                CT.v1_1.Polizas csCatPolizas = new CT.v1_1.Polizas(csPolizasCol, CN.Controlador.Empresa.RFC, per, ej, tipoSolicitud, NumOrden, maskedNumTramite.Text);
                string NomArch = CN.Controlador.Empresa.RFC.ToUpper() + ej.ToString("####") + per + "PL";
                CT.Controlador.GeneraPolizasXml(ref csCatPolizas, txtCarpeta.Text, NomArch);

                MessageBox.Show("El archivo se ha generado en la carpeta " + txtCarpeta.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pbrProgreso.Visible = false;
                pbrProgreso.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                btnGenerar.Enabled = true;
            }
            return;
        }

        public Boolean validar()
        {
            Boolean validando = true;
            String Mensaje = "";
            if (cmbEjercicio.SelectedIndex == -1)
                Mensaje = Mensaje + "Seleccione un ejercicio \n";
            if(cmbPeriodo.SelectedIndex == -1)
                Mensaje = Mensaje + "Seleccione un periodo \n";

            if (rbtActoFisc.Checked || rbtFiscCompulsa.Checked)
            {
                if (mtbNumOrden.Text.Length < 13)
                    Mensaje = Mensaje + "Corriga Número de orden contiene un formato incorrecto. \n";
            }
            if (rbtCompensacion.Checked || rbtDevolucion.Checked)
            {
                if (maskedNumTramite.Text.Length < 10)
                    Mensaje = Mensaje + "Corriga Número de tramite contiene un formato incorrecto. \n";
            }
            
            if (Mensaje != "")
            {
                validando = false;
                MessageBox.Show("Antes de generar es necesario que corriga estos datos: \n\n"+Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return validando;
        }

    #endregion

        private void rbtAF_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Visible = true;
            this.mtbNumOrden.Visible = true;
            this.label5.Visible = false;
            this.maskedNumTramite.Visible = false;
            this.maskedNumTramite.Text = "";

        }

        private void rbtFC_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Visible = true;
            this.mtbNumOrden.Visible = true;
            this.label5.Visible = false;
            this.maskedNumTramite.Visible = false;
            this.maskedNumTramite.Text = "";
        }

        private void rbtDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            this.mtbNumOrden.Visible = false;
            this.label5.Visible = true;
            this.maskedNumTramite.Visible = true;
            this.mtbNumOrden.Text = "";
        }

        private void rbtCompensacion_CheckedChanged(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            this.mtbNumOrden.Visible = false;
            this.label5.Visible = true;
            this.maskedNumTramite.Visible = true;
            this.mtbNumOrden.Text = "";
        }

    }
}
