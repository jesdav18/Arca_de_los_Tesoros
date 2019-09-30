using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Dia.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorDia : UserControl
    {

        int v_conteo_fusible_solicitudes;
        int v_conteo_fusible_cumpleanieros;

        public ctlContenedorPrincipalCoordinadorDia()
        {
            InitializeComponent();
            fusibleCumpleanios.Parent = cmdCumpleanieros;
            fusibleSolicitudes.Parent = cmdSolicitudes;
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     Usuario pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            bgObtenerFusibles.RunWorkerAsync();
            
            tmrFusibles.Start();
            
        }

        private void CmdMiEquipo_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = pageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);
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
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {
            }
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
            NavegacionPrincipal.SelectedPage = PageCumpleanieros;
            ctlContenedorCumpleanieros1.ConstruirControl(Pro_Conexion);

        }

        private void PnlSolicitudes_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageSolicitudes;
            ctlVistaSolicitudes1.ConstruirControl(Pro_Conexion,Pro_Usuario.Pro_Usuario);
        }

        private void CmdBusqueda_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = pageBusqueda;
            ctlBusquedaFichasIngreso1.ConstruirControl(Pro_Conexion);
        }

        private void CmdOrganizador_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = PageOrganizador;
            ctlPlanificadorActividades1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
            
        }
    }
}
