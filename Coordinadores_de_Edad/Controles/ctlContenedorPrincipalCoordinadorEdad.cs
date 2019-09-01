using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorEdad : UserControl
    {
        public ctlContenedorPrincipalCoordinadorEdad()
        {
            InitializeComponent();
            ctlIngresoFicha1.OnFichaIngresada += ctlIngresoFicha1_OnFichaIngresada;
            
        }

        private void ctlIngresoFicha1_OnFichaIngresada(object sender, EventArgs e)
        {
            NavigationCoordinadorEdad.SelectedPage = PageInicial;
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        public event EventHandler OnCerrarSesion;
        

        public void PicAgregarUsuario_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = PageFichaIngreso;
            ctlIngresoFicha1.ConstruirControl(Pro_Conexion,Pro_Usuario.Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     Usuario pUsuario
                                     )
        {
            ctlEncabezado1.ConstruirControl(pUsuario);
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;
            
        }

        public void CmdCerrarSesion_Click(object sender, EventArgs e)
        {
            OnCerrarSesion?.Invoke(sender, e);
        }

        public void CmdIngresarSolicitudes_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = pageIngresoSolicitudes;
            ctlIngresoSolicitudesCordinadorEdad1.ConstruirControl(Pro_Conexion, 
                                                                  Pro_Usuario.Pro_ID_Colaborador);
            splashScreenManager1.CloseWaitForm();
        }

        public void CmdMiEquipo_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = PageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);
            splashScreenManager1.CloseWaitForm();
        }

        public void CmdListaAsistencia_Click(object sender, EventArgs e)
        {
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
            splashScreenManager1.ShowWaitForm();
            NavigationCoordinadorEdad.SelectedPage = pagePlanificadorActividades;
            ctlPlanificadorTrimestralCoordinadorEdad1.ConstruirControl(Pro_Conexion, 
                                                                       Pro_Usuario.Pro_Usuario,
                                                                       Pro_Usuario.Pro_ID_AreaAtencion);
            splashScreenManager1.CloseWaitForm();
        }
    }
}
