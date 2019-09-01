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

namespace Coordinadores_de_Edad.Controles
{
    public partial class ctlCubrirAusencias : UserControl
    {
        #region INICIALIZADOR

        public ctlCubrirAusencias()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Colaborador { get; set; }


        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pID_Colaborador)
        {
            Pro_Conexion = pConexion;
            Pro_ID_Colaborador = pID_Colaborador;



        }

        #endregion

        private void PnlBusquedaAyudas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
