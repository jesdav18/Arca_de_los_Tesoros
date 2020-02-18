using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Data;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorEdad : UserControl
    {
        #region INICIALIZADOR

        public ctlContenedorPrincipalCoordinadorEdad()
        {
            InitializeComponent();
            ctlIngresoFicha1.OnFichaIngresada += ctlIngresoFicha1_OnFichaIngresada;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }


        #endregion

        #region EVENTOS

        public event EventHandler OnCerrarSesion;

        #endregion

        #region FUNCIONES  

        public void ConstruirControl(PgSqlConnection pConexion,
                                   Usuario pUsuario
                                   )
        {
            ctlEncabezado1.ConstruirControl(pUsuario);
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            fusibleCumpleanios.Visible = false;

            if (!bgObtenerFusibles.IsBusy)
            {
                bgObtenerFusibles.RunWorkerAsync();
            }

        }

        private void ctlIngresoFicha1_OnFichaIngresada(object sender, EventArgs e)
        {
            NavigationCoordinadorEdad.SelectedPage = PageInicial;
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
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        int v_conteo_fusible_solicitudes;
        int v_conteo_fusible_cumpleanieros;

        #endregion

        #region EVENTOS CONTROLES

        public void PicAgregarUsuario_Click(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            NavigationCoordinadorEdad.SelectedPage = PageFichaIngreso;
            ctlIngresoFicha1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario, false);

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdCerrarSesion_Click(object sender, EventArgs e)
        {


            OnCerrarSesion?.Invoke(sender, e);
        }

        public void CmdIngresarSolicitudes_Click(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            NavigationCoordinadorEdad.SelectedPage = pageIngresoSolicitudes;
            ctlIngresoSolicitudesCordinadorEdad1.ConstruirControl(Pro_Conexion,
                                                                  Pro_Usuario.Pro_ID_Colaborador);

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdMiEquipo_Click(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            NavigationCoordinadorEdad.SelectedPage = PageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdListaAsistencia_Click(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            NavigationCoordinadorEdad.SelectedPage = PageAsistencia;
            ctlContenedorAsistencias1.ConstruirControl(Pro_Conexion,
                                                       Pro_Usuario,
                                                       Pro_Usuario.Pro_ID_AreaAtencion
                                                       );

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdOrganizadorActividades_Click(object sender, EventArgs e)
        {


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            NavigationCoordinadorEdad.SelectedPage = pagePlanificadorActividades;
            ctlPlanificadorTrimestralCoordinadorEdad1.ConstruirControl(Pro_Conexion,
                                                                       Pro_Usuario.Pro_Usuario,
                                                                       Pro_Usuario.Pro_ID_AreaAtencion);

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }



        #endregion

        private void PnlRefrescar_Click(object sender, EventArgs e)
        {
            if (!bgObtenerFusibles.IsBusy)
            {
                bgObtenerFusibles.RunWorkerAsync();
            }
        }

        private void PnlCumpleanios_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();

            NavigationCoordinadorEdad.SelectedPage = PageCumpleanieros;
            ctlContenedorCumpleanieros1.ConstruirControl(Pro_Conexion);

            splashScreenManager1.CloseWaitForm();
        }

        private void BgObtenerFusibles_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ObtenerFusiblesIndicadores();
        }

        private void BgObtenerFusibles_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            fusibleCumpleanios.ConstruirControl(v_conteo_fusible_cumpleanieros);
        }
    }
    }
