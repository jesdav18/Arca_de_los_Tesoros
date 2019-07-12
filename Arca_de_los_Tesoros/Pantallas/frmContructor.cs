using Anciano.Pantallas;
using Coordinadores_de_Dia.Pantallas;
using Coordinadores_de_Edad.Pantallas;
using Core.Clases;
using Core.Controles;
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
                }

            }
        }

        private void obj_ctl_bienvenida_OnTerminaTiempoBienvenida(object sender, EventArgs e)
        {
            Pro_Modulo = obj_ctl_bienvenida.Pro_Modulo;
            Pro_Conexion = obj_ctl_bienvenida.Pro_Conexion;

            switch (Pro_Modulo)
            {
                case MODULOS.ANCIANO:
                    frm_Anciano = new frmAnciano();
                    frm_Anciano.MdiParent = this;
                    frm_Anciano.StartPosition = FormStartPosition.CenterScreen;
                    frm_Anciano.Show();
                    break;
                case MODULOS.DIACONO:
                    frm_Diacono = new frmDiacono();
                    frm_Diacono.MdiParent = this;
                    frm_Diacono.StartPosition = FormStartPosition.CenterScreen;
                    frm_Diacono.Show();
                    break;
                case MODULOS.COORDINADOR_DIA:
                    frm_CoordinadorDia = new frmCoordinadorDia();
                    frm_CoordinadorDia.MdiParent = this;
                    frm_CoordinadorDia.Dock = DockStyle.Fill;
                    frm_CoordinadorDia.SendToBack();
                    frm_CoordinadorDia.MaximizeBox = false;
                    frm_CoordinadorDia.StartPosition = FormStartPosition.CenterScreen;
                    /*frm_CoordinadorEdad.ConstruirFormulario(Pro_Conexion,
                                                            Pro_ID_AgenciaServicio,
                                                            Pro_ID_ClienteServicio,
                                                            Pro_NombreAgenciaServicio,
                                                            Pro_IP_Host);*/

                    
                    frm_CoordinadorDia.Show();

                    break;
                case MODULOS.COORDINADOR_EDAD:
                    frm_CoordinadorEdad = new frmCoordinadorEdad();
                    frm_CoordinadorEdad.MdiParent = this;
                    frm_CoordinadorEdad.StartPosition = FormStartPosition.CenterScreen;
                    /*frm_CoordinadorEdad.ConstruirFormulario(Pro_Conexion,
                                                            Pro_ID_AgenciaServicio,
                                                            Pro_ID_ClienteServicio,
                                                            Pro_NombreAgenciaServicio,
                                                            Pro_IP_Host);*/
                    frm_CoordinadorEdad.Show();
                 
                    break;
                default:
                    MessageBox.Show("Por favor revise la configuración de Arca de los Tesoros. El módulo configurado es " + Pro_Modulo + " y no fue encontrado.", "Arca de los Tesoros", MessageBoxButtons
                        .OK, MessageBoxIcon.Error);
                    break;
                
            }
           
            ReestablecerFormConstructor();
        }
    }
}
