using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Core.Clases;
using System.Configuration;
using System.Reflection;
using Devart.Data.PostgreSql;

namespace Core.Controles
{
    public partial class ctlBienvenida : UserControl
    {

        #region INICIALIZADOR

        public ctlBienvenida()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

       

        private string Pro_BaseDatos
        {
            get
            {
                return ConfigurationSettings.AppSettings["DATABASE"];
            }
        }

        private string Pro_Hostname
        {
            get
            {
                return ConfigurationSettings.AppSettings["HOSTNAME"];
            }
        }

        private string Pro_Usuario
        {
            get
            {
                return ConfigurationSettings.AppSettings["USUARIO"];
            }
        }

        private string Pro_Password
        {
            get
            {
                return ConfigurationSettings.AppSettings["CONFIGURACION"];
            }
        }

        private string Pro_Puerto
        {
            get
            {
                return ConfigurationSettings.AppSettings["PUERTO"];
            }
        }


        #endregion

        #region EVENTOS

        public event EventHandler OnTerminaTiempoBienvenida;

        #endregion

        #region ENUMERACIONES

        public enum MODULOS
        {
            ANCIANO = 1,
            DIACONO = 2,
            COORDINADOR_DIA = 3,
            COORDINADOR_EDAD = 4
        }

        #endregion

        #region FUNCIONES

        public void ConstruirControl()
        {

           
            System.Reflection.Assembly v_ensamblado = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo obj_archivo_informacion = new System.IO.FileInfo(v_ensamblado.Location);
            DateTime v_ultima_actualizacion = obj_archivo_informacion.LastWriteTime;
            lblUltimaActualizacion.Text = "" + v_ultima_actualizacion.ToShortDateString() + ", " + v_ultima_actualizacion.ToShortTimeString();
            lblVersion.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();

            obj_archivo_informacion = null;
            v_ensamblado = null;

            tmrBienvenida.Start();
        }

        #endregion

        #region EVENTOS CONTROLES

        private void TmrBienvenida_Tick(object sender, EventArgs e)
        {
            tmrBienvenida.Stop();

            if (! bgCrearConexion.IsBusy)
            {
                bgCrearConexion.RunWorkerAsync();
            }
        }

        private void BgCrearConexion_DoWork(object sender, DoWorkEventArgs e)
        {
             Pro_Conexion =  CrearConexion.Crear_Conexion(Pro_Usuario,  
                                                         Pro_Password, 
                                                         Pro_Hostname, 
                                                         Pro_BaseDatos, 
                                                         Pro_Puerto);
        }

        private void BgCrearConexion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnTerminaTiempoBienvenida?.Invoke(sender, e);
        }

        #endregion

    }
}
