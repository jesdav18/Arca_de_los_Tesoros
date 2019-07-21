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
using Core.DataSets;

namespace Core.Controles
{
    public partial class ctlMiEquipo : UserControl
    {
        public ctlMiEquipo()
        {
            InitializeComponent();
        }

        private void CmdVerFicha_Click(object sender, EventArgs e)
        {
            dsVistas.dtMiEquipoRow v_fila = (dsVistas.dtMiEquipoRow)gvMiEquipo.GetFocusedDataRow();
            if (v_fila != null)
            {
               
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            gvMiEquipo.FindFilterText = "\"" + txtBusqueda.Text + "\"";
        }

        public PgSqlConnection Pro_Conexion { get; set; }
        public Usuario Pro_Usuario { get; set; }

        public void ConstruirControl(PgSqlConnection pConexion, Usuario pUsuario)
        {
            Pro_Usuario = pUsuario;
            Pro_Conexion = pConexion;
            lblEncabezado.Text = pUsuario.Pro_NombreEquipo;

            LimpiarBusqueda();
            CargarDatos();

        }

        private void LimpiarBusqueda()
        {
            txtBusqueda.Text = "";
        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            splashScreenManager1.ShowWaitForm();

            string sentencia = @"SELECT * FROM arca_tesoros.ft_view_mi_equipo(:p_id_colaborador);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_colaborador", PgSqlType.Int).Value = Pro_Usuario.Pro_ID_Colaborador;

            try
            {
                dsVistas1.dtMiEquipo.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsVistas1.dtMiEquipo);


                sentencia = null;
                pgComando.Dispose();
                pgComando = null;

                splashScreenManager1.CloseWaitForm();

            }
            catch (Exception Exc)
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }

                pgComando.Dispose();
                Log_Excepciones.CapturadorExcepciones(Exc, this.Name, "CargarDatos");
                MessageBox.Show(Exc.Message, "Arca de los tesoros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
