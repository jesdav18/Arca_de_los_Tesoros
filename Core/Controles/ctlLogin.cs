using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Core.Controles
{
    public partial class ctlLogin : UserControl
    {

        #region INICIALIZADOR

        public ctlLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }

        #endregion

        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;

            txtUsuario.Focus();
            txtUsuario.Select();
        }

        private void CtlLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
