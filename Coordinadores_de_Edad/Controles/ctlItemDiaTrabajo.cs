using System;
using System.Drawing;
using System.Windows.Forms;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlItemDiaTrabajo : UserControl
    {
        public ctlItemDiaTrabajo()
        {
            InitializeComponent();
        }

        public void ConstruirControl(string pFecha, string pDiaSemana)
        {
            lblFecha.Text = pFecha;
            lblDia.Text = pDiaSemana;
        }

        private void LblDia_MouseLeave(object sender, System.EventArgs e)
        {
            lblDia.BackColor = Color.White;
            lblFecha.BackColor = Color.White;
            lblFecha.ForeColor = Color.Black;
            lblDia.ForeColor = Color.Black;

        }

        private void LblFecha_MouseMove(object sender, MouseEventArgs e)
        {
            lblDia.BackColor = Color.FromArgb(47, 82, 153);
            lblFecha.BackColor = Color.FromArgb(47, 82, 153);
            lblFecha.ForeColor = Color.White;
            lblDia.ForeColor = Color.White;
        }

        public event EventHandler OnSeleccionaDia;

        private void LblFecha_Click(object sender, System.EventArgs e)
        {
            OnSeleccionaDia?.Invoke(lblFecha.Text,e) ;
        }
    }
}
