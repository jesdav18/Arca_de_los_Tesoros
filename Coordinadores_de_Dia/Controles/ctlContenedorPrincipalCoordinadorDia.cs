using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Dia.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorDia : UserControl
    {

        #region INICIALIZADOR

        public ctlContenedorPrincipalCoordinadorDia()
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

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                   Usuario pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            ctlEncabezado1.ConstruirControl(Pro_Usuario);
            bgObtenerFusibles.RunWorkerAsync();

            tmrFusibles.Start();

        }

        private void ObtenerFusiblesIndicadores()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception Exc)
                {
                }
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
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {
            }
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnPresionaCerrarSesion;

        #endregion

        #region EVENTOS CONTROLES

        private void CmdMiEquipo_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = pageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void BgObtenerFusibles_DoWork(object sender, DoWorkEventArgs e)
        {
            ObtenerFusiblesIndicadores();
        }

        private void BgObtenerFusibles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            fusibleSolicitudes.ConstruirControl(v_conteo_fusible_solicitudes);
            fusibleCumpleanios.ConstruirControl(v_conteo_fusible_cumpleanieros);
        }

        private void TmrFusibles_Tick(object sender, EventArgs e)
        {
            if (!bgObtenerFusibles.IsBusy)
            {
                bgObtenerFusibles.RunWorkerAsync();
            }
        }

        private void PnlCumpleanios_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageCumpleanieros;
            ctlContenedorCumpleanieros1.ConstruirControl(Pro_Conexion);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlSolicitudes_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageSolicitudes;
            ctlVistaSolicitudes1.ConstruirControl(Pro_Conexion,Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void CmdBusqueda_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = pageBusqueda;
            ctlBusquedaFichasIngreso1.ConstruirControl(Pro_Conexion);
            splashScreenManager1.CloseWaitForm();
        }

        private void CmdOrganizador_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavegacionPrincipal.SelectedPage = PageOrganizador;
            ctlPlanificadorActividades1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        private void PnlCerrarSesion_Click(object sender, EventArgs e)
        {
            OnPresionaCerrarSesion?.Invoke(sender, e);
        }

        #endregion
    }
}
