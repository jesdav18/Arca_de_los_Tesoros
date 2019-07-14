
using Devart.Data.PostgreSql;
using Core.Clases;
using System.Windows.Forms;

namespace Coordinadores_de_Edad.Pantallas
{
    public partial class frmCoordinadorEdad : DevExpress.XtraEditors.XtraForm
    {
        public frmCoordinadorEdad(PgSqlConnection pConexion, Usuario pUsuario)
        {
            InitializeComponent();
            ctlContenedorPrincipalCoordinadorEdad1.ConstruirControl(pConexion, pUsuario);
        }

       
    }
}