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

        private void ValidarCambios()
        {
            if (ctlMiEquipo1.ctlVistaFichaIngreso1.Pro_ModoEdicion)
            {
                if (Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Existen una ficha de ingreso con cambios sin guardar! ¿Desea Guardar los cambios?", Utilidades.BotonesDialogo.YesNo) == DialogResult.Yes)
                {
                    ctlMiEquipo1.ctlVistaFichaIngreso1.PicGuardarCambios_Click(new object(), new EventArgs());
                }
            }
        }
 
        #endregion

        #region EVENTOS CONTROLES

        public void PicAgregarUsuario_Click(object sender, EventArgs e)
        {
            ValidarCambios();


            if (!splashScreenManager1.IsSplashFormVisible)
            {
                splashScreenManager1.ShowWaitForm();
            }

            if (ctlIngresoFicha1.Pro_EstaCreandoFicha)
            {
                if(Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Hay una ficha en proceso de creación! ¿Desea cancelar la creación de la ficha?", Utilidades.BotonesDialogo.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    NavigationCoordinadorEdad.SelectedPage = PageFichaIngreso;
                    ctlIngresoFicha1.ConstruirControl(Pro_Conexion, Pro_Usuario.Pro_Usuario);
                    splashScreenManager1.CloseWaitForm();
                }
            }
     
        }

        public void CmdCerrarSesion_Click(object sender, EventArgs e)
        {
            ValidarCambios();
            OnCerrarSesion?.Invoke(sender, e);
        }

        public void CmdIngresarSolicitudes_Click(object sender, EventArgs e)
        {
            ValidarCambios();
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = pageIngresoSolicitudes;
            ctlIngresoSolicitudesCordinadorEdad1.ConstruirControl(Pro_Conexion, 
                                                                  Pro_Usuario.Pro_ID_Colaborador);
            splashScreenManager1.CloseWaitForm();
        }

        public void CmdMiEquipo_Click(object sender, EventArgs e)
        {
            ValidarCambios();
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = PageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        public void CmdListaAsistencia_Click(object sender, EventArgs e)
        {
            ValidarCambios();

            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = PageAsistencia;
            ctlContenedorAsistencias1.ConstruirControl(Pro_Conexion,
                                                       Pro_Usuario.Pro_Usuario,
                                                       Pro_Usuario.Pro_ID_AreaAtencion
                                                       );
            splashScreenManager1.CloseWaitForm();
        }

        public void CmdOrganizadorActividades_Click(object sender, EventArgs e)
        {
            ValidarCambios();

            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = pagePlanificadorActividades;
            ctlPlanificadorTrimestralCoordinadorEdad1.ConstruirControl(Pro_Conexion, 
                                                                       Pro_Usuario.Pro_Usuario,
                                                                       Pro_Usuario.Pro_ID_AreaAtencion);
            splashScreenManager1.CloseWaitForm();
        }


        private void PnlEncabezadoCoordinadoresEdad_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

    }
}
