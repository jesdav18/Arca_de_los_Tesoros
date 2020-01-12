using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Anciano.Controles
{
    public partial class ctlContenedorPrincipalAnciano : UserControl
    {

        #region INICIALIZADOR

        public ctlContenedorPrincipalAnciano()
        {
            InitializeComponent();
            fusibleCumpleanios.Parent = cmdCumpleanieros;
            fusibleSolicitudes.Parent = cmdSolicitudes;
        }

        #endregion

        #region VARIABLES GLOBALES

        int v_conteo_fusible_solicitudes;
        int v_conteo_fusible_cumpleanieros;

        #endregion

        #region FUNCIONES
      
        public void ConstruirControl(PgSqlConnection pConexion,
                                  Usuario pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            fusibleCumpleanios.Visible = false;
            fusibleSolicitudes.Visible = false;

            ctlEncabezado1.ConstruirControl(Pro_Usuario);

            bgObtenerFusibles.RunWorkerAsync();

            

        }

        private void ObtenerFusiblesIndicadores()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = "SELECT * FROM arca_tesoros.ft_proc_obtiene_fusibles_indicadores();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    v_conteo_fusible_solicitudes = pgDr.GetInt32("conteo_solicitudes");
                    v_conteo_fusible_cumpleanieros = pgDr.GetInt32("conteo_cumpleanieros");

                    if (v_conteo_fusible_cumpleanieros == 0)
                    {
                        fusibleCumpleanios.Visible = false;
                    }
                    else
                    {
                        fusibleCumpleanios.Visible = true;
                    }

                    if (v_conteo_fusible_solicitudes == 0)
                    {
                        fusibleSolicitudes.Visible = false;
                    }
                    else
                    {
                        fusibleSolicitudes.Visible = true;
                    }
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {
            }
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        #endregion

        #region EVENTOS

        public event EventHandler OnPresionaCerrarSesion;

        #endregion

        #region EVENTOS CONTROLES

       
        private void BgObtenerFusibles_DoWork(object sender, DoWorkEventArgs e)
        {
            ObtenerFusiblesIndicadores();
        }

        private void BgObtenerFusibles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fusibleSolicitudes.ConstruirControl(v_conteo_fusible_solicitudes);
            fusibleCumpleanios.ConstruirControl(v_conteo_fusible_cumpleanieros);
        }

        private void PnlSolicitudes_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageSolicitudes;
            ctlVistaSolicitudes1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlCumpleanios_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageCumpleanieros;
            ctlContenedorCumpleanieros1.ConstruirControl(Pro_Conexion);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlOrganizador_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageOrganizador;
            ctlPlanificadorActividades1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlAgregarFicha_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageCrearFichaIngreso;
            ctlIngresoFicha1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlBusqueda_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = pageBusqueda;
            ctlBusquedaFichasIngreso1.ConstruirControl(Pro_Conexion,Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlCerrarSesion_Click(object sender, EventArgs e)
        {
            OnPresionaCerrarSesion?.Invoke(sender, e);
        }

        #endregion

        private void PnlActualizar_Click(object sender, EventArgs e)
        {
            if (!bgObtenerFusibles.IsBusy)
            {
                bgObtenerFusibles.RunWorkerAsync();
            }
        }
    }
}
