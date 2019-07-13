using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorEdad : UserControl
    {
        public ctlContenedorPrincipalCoordinadorEdad()
        {
            InitializeComponent();
        }

        private void PicAgregarUsuario_Click(object sender, EventArgs e)
        {
            NavigationCoordinadorEdad.SelectedPage = PageFichaIngreso;
        }

        public event EventHandler OnClick;

        private void PnlEncabezado_Click(object sender, EventArgs e)
        {
            OnClick?.Invoke(sender, e);
        }
    }
}
