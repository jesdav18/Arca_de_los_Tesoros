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

namespace Core.Controles.Cumpleanieros
{
    public partial class ctlContenedorCumpleanieros : UserControl
    {
        public ctlContenedorCumpleanieros()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public string Pro_Dia { get; set; }


        public void ConstruirControl(PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;
            Pro_Dia = Utilidades.ObtenerFechaServidor(Pro_Conexion);
            ctlCumpleanierosDia1.ConstruirControl(Pro_Conexion,Pro_Dia);
            ctlProximosCumpleanieros1.ConstruirControl(Pro_Conexion);
        }
    }
}
