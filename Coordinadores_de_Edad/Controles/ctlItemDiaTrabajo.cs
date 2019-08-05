using System.Windows.Forms;

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlItemDiaTrabajo : UserControl
    {
        public ctlItemDiaTrabajo()
        {
            InitializeComponent();
        }

        public void ConstruirControl(string pFecha)
        {
            lblFecha.Text = pFecha;
        }
    }
}
