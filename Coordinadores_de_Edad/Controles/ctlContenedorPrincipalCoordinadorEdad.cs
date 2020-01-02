using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

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

        }

        private void ctlIngresoFicha1_OnFichaIngresada(object sender, EventArgs e)
        {
            NavigationCoordinadorEdad.SelectedPage = PageInicial;
        }

        private bool ValidarCambios()
        {
            if (ctlIngresoFicha1.Pro_EstaCreandoFicha)
            {
                if (Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Existen una ficha de ingreso en proceso de creación! ¿Desea descartar la creación de la ficha?", Utilidades.BotonesDialogo.YesNo) == DialogResult.No)
                {
                   
                    return true;
                }
                else
                {
                    ctlIngresoFicha1.Pro_EstaCreandoFicha = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
 
        #endregion

        #region EVENTOS CONTROLES

        public void PicAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCambios())
            {
                return;
            } 


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            NavigationCoordinadorEdad.SelectedPage = PageFichaIngreso;
            ctlIngresoFicha1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdCerrarSesion_Click(object sender, EventArgs e)
        {
            if (ValidarCambios())
            {
                return;
            }

            OnCerrarSesion?.Invoke(sender, e);
        }

        public void CmdIngresarSolicitudes_Click(object sender, EventArgs e)
        {
            if (ValidarCambios())
            {
                return;
            }


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
            if (ValidarCambios())
            {
                return;
            }


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
            if (ValidarCambios())
            {
                return;
            }


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }


            NavigationCoordinadorEdad.SelectedPage = PageAsistencia;
            ctlContenedorAsistencias1.ConstruirControl(Pro_Conexion,
                                                       Pro_Usuario.Pro_Usuario,
                                                       Pro_Usuario.Pro_ID_AreaAtencion
                                                       );

            if (splashScreenManager1.IsSplashFormVisible)
            {

                splashScreenManager1.CloseWaitForm();
            }

        }

        public void CmdOrganizadorActividades_Click(object sender, EventArgs e)
        {
            if (ValidarCambios())
            {
                return;
            }


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

      
    }
}
