using System;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Core.Clases;

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

        public void ConstruirControl(PgSqlConnection pConexion, Usuario pUsuario )
        {
            ctlEncabezado1.ConstruirControl(pUsuario);
        }
    }
}
