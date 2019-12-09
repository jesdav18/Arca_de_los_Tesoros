
using Anciano.Controles;
using Coordinadores_de_Dia.Controles;
using Coordinadores_de_Edad.Controles;
using Core.Clases;
using Core.Controles;
using Core.Pantallas;
using Devart.Data.PostgreSql;
using Diacono.Controles;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arca_de_los_Tesoros
{
    public partial class frmContructor : Form
    {

        #region INICIALIZADOR

        public frmContructor()
        {
            InitializeComponent();
            obj_ctl_bienvenida = new ctlBienvenida();
        }

        #endregion

        #region VARIABLES Y OBJETOS PUBLICOS

        ctlBienvenida obj_ctl_bienvenida;      
        frmLogin frm_Login;

        ctlContenedorPrincipalCoordinadorEdad ctlCoordinadorEdad = null;
        ctlContenedorPrincipalCoordinadorDia ctlCoordinadorDia = null;
        ctlContenedorPrincipalAnciano ctlAnciano = null;
        ctlContenedorPrincipalDiacono ctlDiacono = null;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        MODULOS Pro_Modulo { get; set; }

        #endregion

        #region FUNCIONES

        private void Construir_Acceso()
        {

            try
            {
                frm_Login = new frmLogin(Pro_Conexion);
                frm_Login.OnUsuarioLogueado += frm_Login_OnUsuarioLogueado;
                ReestablecerFormConstructor();
                frm_Login.MdiParent = this;
                frm_Login.StartPosition = FormStartPosition.CenterScreen;
                frm_Login.Show();

            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      " Construir_Acceso_Para_Operaciones()");

                MessageBox.Show("Algo salió mal miemtras se cargaba la pantalla de autenticación. ", "Arca de los Tesoros");
            }
        }

        private void ReestablecerFormConstructor()
        {
            try
            {
                this.Hide();
                obj_ctl_bienvenida.Dispose();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            }
            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ReestablecerFormConstructor()");
               
                MessageBox.Show("Algo salió mal en el momento de Reestablecer el MDI Arca de los Tesosros. ", "Arca de Los Tesoros",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frm_Login_OnUsuarioLogueado(object sender, EventArgs e)
        {
            Usuario c_usuario = new Usuario();
            c_usuario = (Usuario)sender;

            RedireccionSegunNivelAcceso(c_usuario);
            c_usuario = null;
        }

        private void RedireccionSegunNivelAcceso(Usuario pUsuario)
        {
            if (frm_Login != null)
            {
                frm_Login.Dispose();
                frm_Login = null;
            }

            try
            {
                switch ((ROLES_USUARIO)pUsuario.Pro_ID_RolUsuario)
                {
                    case ROLES_USUARIO.ANCIANO:
                        ctlAnciano = new ctlContenedorPrincipalAnciano();
                        ctlAnciano.Parent = this;
                        ctlAnciano.ConstruirControl(Pro_Conexion, pUsuario);
                        ctlAnciano.OnPresionaCerrarSesion += ctlAnciano_CerrarSesion;
                        ctlAnciano.Dock = DockStyle.Fill;
                        ctlAnciano.BringToFront();
                        this.MinimumSize = new Size(986, 795);
                        Pro_Modulo = MODULOS.MODULO_ANCIANO;


                        break;
                    case ROLES_USUARIO.DIACONO:
                        ctlDiacono = new ctlContenedorPrincipalDiacono();
                        ctlDiacono.Parent = this;
                        ctlDiacono.ConstruirControl(Pro_Conexion, pUsuario);
                        ctlDiacono.OnPresionaCerrarSesion += ctlDiacono_CerrarSesion;
                        ctlDiacono.Dock = DockStyle.Fill;
                        ctlDiacono.BringToFront();
                        this.MinimumSize = new Size(986, 795);
                        Pro_Modulo = MODULOS.MODULO_DIACONO;

                        break;
                    case ROLES_USUARIO.COORDINADOR_DIA:

                        ctlCoordinadorDia = new ctlContenedorPrincipalCoordinadorDia();
                        ctlCoordinadorDia.Parent = this;
                        ctlCoordinadorDia.ConstruirControl(Pro_Conexion, pUsuario);
                        ctlCoordinadorDia.OnPresionaCerrarSesion += ctlCoordinadorDia_CerrarSesion;
                        ctlCoordinadorDia.Dock = DockStyle.Fill;
                        ctlCoordinadorDia.BringToFront();
                        this.MinimumSize = new Size(986, 795);
                        Pro_Modulo = MODULOS.MODULO_COORDINADOR_DIA;

                        break;

                    case ROLES_USUARIO.COORDINADOR_EDAD:

                        ctlCoordinadorEdad = new ctlContenedorPrincipalCoordinadorEdad();
                        ctlCoordinadorEdad.Parent = this;
                        ctlCoordinadorEdad.ConstruirControl(Pro_Conexion, pUsuario);
                        ctlCoordinadorEdad.OnCerrarSesion += ctlCoordinadorEdad_OnCerrarSesion;
                        ctlCoordinadorEdad.Dock = DockStyle.Fill;
                        ctlCoordinadorEdad.BringToFront();
                        this.MinimumSize = new Size(986, 795);
                        Pro_Modulo = MODULOS.MODULO_COORDINADOR_EDAD;

                        break;
                }
            }

            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "RedireccionSegunNivelAcceso(Usuario pUsuario)");

                MessageBox.Show("Algo salió mal mientras se cargaban los niveles de acceso. ", "Arca de los Tesoros");
                Construir_Acceso();
            }
        }

        private void ctlCoordinadorDia_CerrarSesion(object sender, EventArgs e)
        {
            ctlCoordinadorDia.Dispose();
            ctlCoordinadorDia = null;
            Construir_Acceso();
        }

        private void ctlDiacono_CerrarSesion(object sender, EventArgs e)
        {
            ctlAnciano.Dispose();
            ctlAnciano = null;
            Construir_Acceso();
        }

        private void ctlAnciano_CerrarSesion(object sender, EventArgs e)
        {
            ctlAnciano.Dispose();
            ctlAnciano = null;
            Construir_Acceso();
        }

        private void ctlCoordinadorEdad_OnCerrarSesion(object sender, EventArgs e)
        {
            ctlCoordinadorEdad.Dispose();
            ctlCoordinadorEdad = null;
            Construir_Acceso();
        }

        private void FrmContructor_Load(object sender, EventArgs e)
        {
            if (obj_ctl_bienvenida != null)
            {
                obj_ctl_bienvenida.OnTerminaTiempoBienvenida += new EventHandler(obj_ctl_bienvenida_OnTerminaTiempoBienvenida);
                this.Controls.Add(obj_ctl_bienvenida);
                obj_ctl_bienvenida.Dock = DockStyle.Fill;
                obj_ctl_bienvenida.ConstruirControl();
            }

            MdiClient ctlMDI;
            foreach (Control iterador in this.Controls)

            {
                try
                {
                    ctlMDI = (MdiClient)iterador;
                    ctlMDI.BackColor = Color.White;
                }

                catch (InvalidCastException Exc)

                {
                    Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "frmConstructor_Load");
                }
            }
        }

        private void obj_ctl_bienvenida_OnTerminaTiempoBienvenida(object sender, EventArgs e)
        {
            Pro_Conexion = obj_ctl_bienvenida.Pro_Conexion;
            Construir_Acceso();
        }

        #endregion

        #region ENUMERACIONES

        public enum ROLES_USUARIO
        {
            ANCIANO = 1,
            DIACONO = 2,
            COORDINADOR_DIA = 3,
            COORDINADOR_EDAD = 4
        }

        public enum MODULOS
        {
            MODULO_ANCIANO = 1,
            MODULO_DIACONO = 2,
            MODULO_COORDINADOR_DIA = 3,
            MODULO_COORDINADOR_EDAD = 4
        }


        #endregion

        #region EVENTOS CONTROLES

       
        private void FrmContructor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {    
                switch (Pro_Modulo)
                {
                    case MODULOS.MODULO_ANCIANO:
                        break;
                    case MODULOS.MODULO_DIACONO:
                        break;
                    case MODULOS.MODULO_COORDINADOR_DIA:
                        break;
                    case MODULOS.MODULO_COORDINADOR_EDAD:
                        if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                        {
                            ctlCoordinadorEdad.PicAgregarUsuario_Click(sender, new EventArgs());
                        }
                        else if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageFichaIngreso)
                        {
                            ctlCoordinadorEdad.ctlIngresoFicha1.IrAtras();
                        }                  
                        break;
                }             
            }
            else if (e.KeyCode == Keys.F2)
            {
                switch (Pro_Modulo)
                {
                    case MODULOS.MODULO_ANCIANO:
                        break;
                    case MODULOS.MODULO_DIACONO:
                        break;
                    case MODULOS.MODULO_COORDINADOR_DIA:
                        break;
                    case MODULOS.MODULO_COORDINADOR_EDAD:
                        if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                        {
                            ctlCoordinadorEdad.CmdOrganizadorActividades_Click(sender, new EventArgs());
                        }
                        else if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageFichaIngreso)
                        {
                            ctlCoordinadorEdad.ctlIngresoFicha1.IrAdelante();
                        }                 
                        break;                 
                }
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                {
                    ctlCoordinadorEdad.CmdListaAsistencia_Click(sender, new EventArgs());
                }
                
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                {
                    ctlCoordinadorEdad.CmdMiEquipo_Click(sender, new EventArgs());
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                {
                    ctlCoordinadorEdad.CmdIngresarSolicitudes_Click(sender, new EventArgs());
                }
            }
            else if (e.KeyCode == Keys.F6)
            {
                if (ctlCoordinadorEdad.NavigationCoordinadorEdad.SelectedPage == ctlCoordinadorEdad.PageInicial)
                {
                    ctlCoordinadorEdad.CmdCerrarSesion_Click(sender, new EventArgs());
                }
            }
        }

        #endregion

        private void FrmContructor_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (Pro_Modulo)
            {
                case MODULOS.MODULO_ANCIANO:
                    break;
                case MODULOS.MODULO_DIACONO:
                    break;
                case MODULOS.MODULO_COORDINADOR_DIA:
                    break;
                case MODULOS.MODULO_COORDINADOR_EDAD:
                    if (ctlCoordinadorEdad.ctlMiEquipo1.ctlVistaFichaIngreso1.Pro_ModoEdicion)
                    {
                        if (Utilidades.MostrarDialogo(FindForm(), "Validación de Registros", "¡Existen una ficha de ingreso con cambios sin guardar! ¿Desea Guardar los cambios?", Utilidades.BotonesDialogo.YesNo) == DialogResult.Yes)
                        {
                            ctlCoordinadorEdad.ctlMiEquipo1.ctlVistaFichaIngreso1.PicGuardarCambios_Click(sender, e);
                        }
                       
                    }
                   
                    break;
                default:
                    break;
            }
        }
    }
}
