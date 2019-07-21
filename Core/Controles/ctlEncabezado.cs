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
    public partial class ctlEncabezado : UserControl
    {
        public ctlEncabezado()
        {
            InitializeComponent();
        }

        public void ConstruirControl(Usuario pUsuario)
        {
            lblNombreUsuario.Text = pUsuario.Pro_NombreColaborador;
            lblCargoUsuario.Text = pUsuario.Pro_DescripcionCargo;
        }

        private void LblNombreUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
