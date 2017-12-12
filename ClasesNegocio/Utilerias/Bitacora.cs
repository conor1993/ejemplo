using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using EC = SideviORM.EntityClasses ;
using CC = SideviORM.CollectionClasses;
using HC = SideviORM.HelperClasses;
using OC = SD.LLBLGen.Pro.ORMSupportClasses;
using CN = ClasesNegocio;
using System.Windows.Forms;


namespace ClasesNegocio
{
    [System.ComponentModel.DataObject(true)]
    public class Bitacora : CN.ClassBase<EC.BitacoraSideviEntity>, CN.IEntidad
    {
    #region Definiciones
        public event CN.MensajeErrorHandler MensajeError;
        public event EventHandler Modificado;
        private CN.CuentaBancoCol _CuentaBanc;        
        CN.SatAgrupador _AgrupSat;
        CN.SatBanco _sBanco;
        
    #endregion

    #region Constructores
        public Bitacora()
        {
            //_Entidad.Estatus = Convert.ToString((char)VigenciaEnum.VIGENTE);
        }

        public Bitacora(int Codigo)
        {
            this.Obtener(Codigo);
        }
        //public Banco(byte ClveSat)
        //{
        //    this.Obtener(ClveSat);
        //}
    #endregion 

    #region Propiedades

        [System.ComponentModel.DisplayName("Código")]
        [System.ComponentModel.DataObjectField(true)]
        public int IdBitacora
        {
            get { return Entidad.IdBitacora; }
            set { Entidad.IdBitacora = value; }
        }
        
        [System.ComponentModel.DisplayName("Fecha")]
        [System.ComponentModel.DataObjectField(true)]
        public DateTime Fecha
        {
            get { return Entidad.Fecha; }
            set { Entidad.Fecha = value; }
        }

        [System.ComponentModel.DisplayName("Forma")]
        [System.ComponentModel.DataObjectField(true)]
        public string Forma
        {
            get { return Entidad.Forma; }
            set { Entidad.Forma = value; }
        }

        [System.ComponentModel.DisplayName("Evento")]
        [System.ComponentModel.DataObjectField(true)]
        public string Evento
        {
            get { return Entidad.Evento; }
            set { Entidad.Evento = value; }
        }

        [System.ComponentModel.DisplayName("Usuario")]
        [System.ComponentModel.DataObjectField(true)]
        public string Usuario
        {
            get { return Entidad.Usuario; }
            set { Entidad.Usuario = value; }
        }

        [System.ComponentModel.DisplayName("Descripcion")]
        [System.ComponentModel.DataObjectField(true)]
        public string Descripcion
        {
            get { return Entidad.Descripcion; }
            set { Entidad.Descripcion = value; }
        }

    #endregion 

    #region Metodos"

        public Boolean Borrar(HC.Transaction trans= null)
        {
            Boolean CierraTrans = false;
            try
            {              
                
                if (trans==null )
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Bitacora");
                    CierraTrans = true;
                }
                
                trans.Add(_Entidad);

                if (_Entidad.Delete())
                {
                    if (CierraTrans) trans.Commit();
                    return true;
                }
                if (CierraTrans) trans.Rollback();
                if (MensajeError != null)
                    MensajeError(this, "No se pudo borrar la Bitacora.");
                else
                    throw (new Exception("No se pudo borrar la Bitacora."));

            }
            catch (Exception ex)
            {
                if (CierraTrans) trans.Rollback();
                string msg;
    #if DEBUG
                msg= ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace;
    #else
                msg= "Se produjo un error al intentar borrar el registro." + "\n" + ex.Message;
    #endif
                if (MensajeError != null) MensajeError(this, msg); else throw (new Exception(msg));
                return false;
            }
            return false;
        }

        public Boolean Guardar(HC.Transaction trans= null)
        {
            Boolean CierraTrans = false;
            try
            {
                if (trans == null)
                {
                    trans = new HC.Transaction(IsolationLevel.ReadCommitted, "Bitacora");
                    CierraTrans = true;
                }

                trans.Add(_Entidad);
                _Entidad.Save();
                //_Entidad.Refetch();

                if (CierraTrans) trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (CierraTrans) trans.Rollback();
                string msg;
    #if DEBUG
                msg= ex.Message + "\n" + ex.Source + "\n" + ex.StackTrace;
    #else
                msg= "Se produjo un error al intentar guardar el registro." + "\n" + ex.Message;
    #endif
                if (MensajeError != null) MensajeError(this, msg); else throw (new Exception(msg));
                return false;
            }
        }

        public Boolean Obtener(int Codigo)
        {
            if (_Entidad.FetchUsingPK(Codigo))
            {
                if (Modificado != null) Modificado(this, new EventArgs());
                return true;
            }

            else return false;
        }

       
    #endregion 

    }

    public class BitacoraCol : CN.ColleccionBase<EC.BitacoraSideviEntity, CC.BitacoraSideviCollection , Bitacora>
    {
        private OC.PredicateExpression Filtro;
        private OC.SortExpression DefaultOrder;
        public event MensajeErrorHandler MensajeError;

        public BitacoraCol()
        {
            //MyBase.new()
            DefaultOrder = new OC.SortExpression(new OC.SortClause(HC.BitacoraSideviFields.Fecha, OC.SortOperator.Ascending));
        }

        public int Borrar()
        {
            try
            {
                int Conteo = base.Borrar();
                return Conteo;
            }
                catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public int Guardar()
        {
            try
            {
                int Conteo = base.Guardar();
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public override int Obtener()
        {
            Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
            //Filtro.Add(HC.EquipoFields.Estatus == CN.EstatusVigenciaEnum.ACTIVO);
            try
            {
                return Obtener(Filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
        }

        public override int Obtener(OC.IPredicate filtro)
        {
            try
            {
                Coleccion.GetMulti(filtro);
                Rellenar();
                return Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
        }

        public int Obtener(Bitacora elem)
        {
            try
            {
                this.ClearItems();
                Filtro = new SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression();
                Filtro.Add(HC.BitacoraSideviFields.IdBitacora == elem.IdBitacora);
                

                int Conteo = Coleccion.GetDbCount(Filtro);
                if (Conteo > 0)
                {
                    Coleccion.GetMulti(Filtro);
                    this.Coleccion = Coleccion;
                    foreach (EC.BitacoraSideviEntity entity in Coleccion)
                    {
                        CN.Bitacora MiEntidad = new CN.Bitacora();
                        MiEntidad.LeerEntidad(entity);
                        this.Add(MiEntidad);
                    }
                }
                return Conteo;
            }
            catch (Exception ex)
            {
                if (MensajeError != null)
                    MensajeError(this, ex.Message);
                else
                    throw (ex);
                return -1;
            }
        }

        public String[] Listar()
        {
            List<string> lista = new List<string>();
            foreach (Bitacora elem in this)
            {
                lista.Add(elem.Evento);
            }
            return lista.ToArray();
        }

        internal void RellenarMe(string p)
        {
            throw new NotImplementedException();
        }

        
    }
    
 }