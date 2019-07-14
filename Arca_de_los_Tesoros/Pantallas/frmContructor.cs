using Anciano.Pantallas;
using Coordinadores_de_Dia.Pantallas;
using Coordinadores_de_Edad.Controles;
using Coordinadores_de_Edad.Pantallas;
using Core.Clases;
using Core.Controles;
using Core.Pantallas;
using Devart.Data.PostgreSql;
using Diacono.Pantallas;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Core.Controles.ctlBienvenida;

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
        frmCoordinadorEdad frm_CoordinadorEdad;
        frmCoordinadorDia frm_CoordinadorDia;
        frmDiacono frm_Diacono;
        frmAnciano frm_Anciano;
        frmLogin frm_Login;

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        MODULOS Pro_Modulo { get; set; }

        #endregion

        #region FUNCIONES

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

        #endregion

        public enum ROLES_USUARIO
        {
            ANCIANO = 1,
            DIACONO = 2,
            COORDINADOR_DIA = 3,
            COORDINADOR_EDAD = 4
        }

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

                        frm_Anciano = new frmAnciano();
                        frm_Anciano.MdiParent = this;
                        frm_Anciano.StartPosition = FormStartPosition.CenterScreen;
                        frm_Anciano.Show();

                        break;
                    case ROLES_USUARIO.DIACONO:

                        frm_Diacono = new frmDiacono();
                        frm_Diacono.MdiParent = this;
                        frm_Diacono.StartPosition = FormStartPosition.CenterScreen;
                        frm_Diacono.Show();

                        break;
                    case ROLES_USUARIO.COORDINADOR_DIA:

                        frm_CoordinadorDia = new frmCoordinadorDia();
                        frm_CoordinadorDia.MdiParent = this;
                        frm_CoordinadorDia.Dock = DockStyle.Fill;
                        frm_CoordinadorDia.SendToBack();
                        frm_CoordinadorDia.MaximizeBox = false;
                        frm_CoordinadorDia.StartPosition = FormStartPosition.CenterScreen;

                        break;

                    case ROLES_USUARIO.COORDINADOR_EDAD:

                        ctlContenedorPrincipalCoordinadorEdad ctl = new ctlContenedorPrincipalCoordinadorEdad();
                        ctl.Parent = this;
                        ctl.ConstruirControl(Pro_Conexion, pUsuario);
                        ctl.Dock = DockStyle.Fill;
                        ctl.BringToFront();
                        this.MinimumSize = new Size(986, 795);
                        

                        break;
                }
            }

            catch (Exception Exc)
            {
                Log_Excepciones.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "RedireccionSegunNivelAcceso(Usuario pUsuario)");
               

                MessageBox.Show("Algo salió mal mientras se cargaban los niveles de acceso. ", "Arca de los Tesoros");
            }


//ReestablecerFormConstructor();

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

       
    }
}
