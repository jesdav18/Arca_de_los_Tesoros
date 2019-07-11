using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Clases;

namespace Core.Controles
{
    public partial class ctlBienvenida : UserControl
    {

        #region INICIALIZADOR

        public ctlBienvenida()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnTerminaTiempoBienvenida;

        #endregion

        private void TmrBienvenida_Tick(object sender, EventArgs e)
        {
            tmrBienvenida.Stop();

            if (! bgCrearConexion.IsBusy)
            {
                bgCrearConexion.RunWorkerAsync();
            }
        }

        private void BgCrearConexion_DoWork(object sender, DoWorkEventArgs e)
        {
            //CrearConexion.Crear_Conexion();
        }

        private void BgCrearConexion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            OnTerminaTiempoBienvenida?.Invoke(sender, e);
        }
    }
}
