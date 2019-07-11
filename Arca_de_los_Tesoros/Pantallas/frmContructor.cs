using Core.Clases;
using Core.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
