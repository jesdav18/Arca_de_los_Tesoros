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
using Core.Clases;

namespace Coordinadores_de_Dia.Controles
{
    public partial class ctlContenedorPrincipalCoordinadorDia : UserControl
    {
        public ctlContenedorPrincipalCoordinadorDia()
        {
            InitializeComponent();
            fusibleCumpleanios.Parent = cmdCumpleanieros;
            fusibleSolicitudes.Parent = cmdSolicitudes;
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     Usuario pUsuario)
        {
            Pro_Conexion = pConexion;
            Pro_Usuario = pUsuario;

            fusibleCumpleanios.ConstruirControl(99);
            fusibleSolicitudes.ConstruirControl(99);
        }

        private void CmdMiEquipo_Click(object sender, EventArgs e)
        {
            NavegacionPrincipal.SelectedPage = pageMiEquipo;
            ctlMiEquipo1.ConstruirControl(Pro_Conexion, Pro_Usuario);
        }
    }
}
