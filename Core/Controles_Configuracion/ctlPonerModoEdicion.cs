using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Controles_Configuracion
{
    public partial class ctlPonerModoEdicion : UserControl
    {

        #region INICIALIZADOR

        public ctlPonerModoEdicion()
        {
            InitializeComponent();
        }

        #endregion

        public bool Pro_ModoEdicion {
            get
            {
                return v_modo_edicion;
            }
            set
            {
                v_modo_edicion = value;
                if (v_modo_edicion)
                {
                    cmdEditNombreColaborador.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/editname_32x32.png");
                }
                else
                {
                    cmdEditNombreColaborador.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_32x32.png");
                }
            }
        }

        bool v_modo_edicion;
        public event EventHandler OnClicModoEdicion;

        private void CmdEditNombreColaborador_Click(object sender, EventArgs e)
        {
            Pro_ModoEdicion = !Pro_ModoEdicion;
            OnClicModoEdicion?.Invoke(sender, e);
        }
    }
}
