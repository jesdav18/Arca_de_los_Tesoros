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

namespace Core.Controles.Cumpleanieros
{
    public partial class ctlProximosCumpleanieros : UserControl
    {
        public ctlProximosCumpleanieros()
        {
            InitializeComponent();
        }

        public PgSqlConnection Pro_Conexion { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion)
        {

            Pro_Conexion = pConexion;

            CargarTarjetasCumpleanieros();
        }

        private void CargarTarjetasCumpleanieros()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_proximos_cumpleanieros();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);

            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                while (pgDr.Read())
                {
                    ctlTarjetaCumpleaniero v_tarjeta = new ctlTarjetaCumpleaniero();
                    v_tarjeta.lblNombreColaborador.Text = pgDr.GetString("nombre_colaborador");
                    v_tarjeta.lblEdadColaborador.Text = pgDr.GetString("anios");
                    v_tarjeta.lblEquipo.Text = pgDr.GetString("equipo");

                    if (!string.IsNullOrEmpty(pgDr.GetString("ruta_fotografia")))
                    {
                        v_tarjeta.picImagenColaborador.Image = Image.FromFile(pgDr.GetString("ruta_fotografia"));
                    }

                    tileProximosCumpleanieros.Controls.Add(v_tarjeta);
                }

                pgDr.Close();
            }
            catch (Exception Exc)
            {

             
            }
        }
    }
}
